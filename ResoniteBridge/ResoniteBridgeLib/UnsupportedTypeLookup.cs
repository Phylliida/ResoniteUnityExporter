using System;
using System.Collections.Generic;

namespace ResoniteBridge
{
    public class RollingCache
    {
        public int offset;
        public object[] values;
        public Guid[] keys;
        public RollingCache(int capacity)
        {
            values = new object[capacity];
            keys = new Guid[capacity];
        }

        public bool TryLookup(object value, out Guid guid)
        {
            guid = Guid.Empty;
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == value)
                {
                    guid = keys[i];
                    return true;
                }
            }
            return false;
        }

        public void Add(object value, Guid key)
        {
            values[offset] = value;
            keys[offset] = key;
            offset = (offset + 1) % values.Length;
        }
    }

    public class UnsupportedTypeLookup
    {
        // maintain a cache/lookup for each type, this ensures caches don't get flooded out by other types
        // and so prevents entry creation spam
        int cacheCapacity;
        Dictionary<Type, UnsupportedTypeLookupHelper> lookups = new Dictionary<Type, UnsupportedTypeLookupHelper>();

        public UnsupportedTypeLookup(int cacheCapacity)
        {
            this.cacheCapacity = cacheCapacity;
        }

        UnsupportedTypeLookupHelper GetHelperForType(Type type)
        {
            UnsupportedTypeLookupHelper lookup;
            if (!lookups.TryGetValue(type, out lookup))
            {
                lookup = new UnsupportedTypeLookupHelper(cacheCapacity);
                lookups[type] = lookup;
            }
            return lookup;
        }

        public Guid Add(object value)
        {
            if (value == null)
            {
                return Guid.Empty;
            }
            return GetHelperForType(value.GetType()).Add(value);
        }

        public bool TryGet(Guid guid, Type type, out object value)
        {
            if (guid == Guid.Empty)
            {
                value = null;
                return true;
            }
            return GetHelperForType(type).TryGet(guid, out value);
        }
    }

    public class UnsupportedTypeLookupHelper
    {
        RollingCache cache;
        public Dictionary<Guid, object> lookup = new Dictionary<Guid, object>();
        public UnsupportedTypeLookupHelper(int cacheCapacity)
        {
            cache = new RollingCache(cacheCapacity);
        }

        public Guid Add(object value)
        {
            Guid guid;
            // we have a cache so the first 10 or so values won't allocate new dict entries every call
            if (!cache.TryLookup(value, out guid))
            {
                guid = Guid.NewGuid();
                while (lookup.ContainsKey(guid) || guid == Guid.Empty)
                {
                    guid = Guid.NewGuid();
                }
                lookup[guid] = value;
                cache.Add(value, guid);
            }
            return guid;
        }

        public bool TryGet(Guid guid, out object value)
        {
            if (guid == Guid.Empty) // empty guid is null guid
            {
                value = null;
                return true;
            }
            return lookup.TryGetValue(guid, out value);
        }
    }

}
