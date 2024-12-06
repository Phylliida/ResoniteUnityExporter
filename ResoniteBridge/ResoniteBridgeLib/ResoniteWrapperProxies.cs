using System;
using System.Buffers;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ResoniteBridge
{
    public abstract class JsonConverterProxy<T>
    {
        public abstract System.Boolean CanConvert(Type typeToConvert);

        public abstract T Read(byte[] reader, Type typeToConvert, JsonSerializerOptions options);

        public abstract void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options);
    }
}
