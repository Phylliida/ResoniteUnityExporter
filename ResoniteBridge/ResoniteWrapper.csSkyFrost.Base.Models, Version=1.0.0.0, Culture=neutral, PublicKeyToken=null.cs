using ResoniteBridge;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Elements.Core;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Microsoft.CodeAnalysis
{
}
namespace System.Runtime.CompilerServices
{
}
namespace SkyFrost.Base
{
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class AssemblyInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "compatibilityHash")]
		[JsonPropertyName("compatibilityHash")]
		public System.String CompatibilityHash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CompatibilityHash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CompatibilityHash", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssemblyInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AssetChunk : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "index")]
		[JsonPropertyName("index")]
		public System.Int32 Index
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		[JsonProperty(PropertyName = "key")]
		[JsonPropertyName("key")]
		public System.String Key
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Key"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Key", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetChunk(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AssetDiff : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum Diff
		{
			Added,
			Unchanged,
			Removed
		}

		[JsonProperty(PropertyName = "hash")]
		[JsonPropertyName("hash")]
		public System.String Hash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hash", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public System.Int64 Bytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bytes", value);
			}
		}

		[JsonProperty(PropertyName = "state")]
		[JsonPropertyName("state")]
		public Diff State
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(Diff)) is Diff __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Diff");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		[JsonProperty(PropertyName = "isUploaded", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("isUploaded")]
		public bool? IsUploaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUploaded"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsUploaded", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetDiff(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class AssetEntry<E> : ResoniteBridge.ResoniteBridgeValueHolder where E : class, new()
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.String AssetHash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetHash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetHash", value);
			}
		}

		[JsonProperty(PropertyName = "entry")]
		[JsonPropertyName("entry")]
		public E Entry
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Entry"), typeof(E)) is E __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to E");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Entry", value);
			}
		}

		[JsonProperty(PropertyName = "computeLock")]
		[JsonPropertyName("computeLock")]
		public ComputationLock ComputeLock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeLock"), typeof(ComputationLock)) is ComputationLock __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ComputationLock");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeLock", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetEntry(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class AssetInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "assetHash")]
		[JsonPropertyName("assetHash")]
		public System.String AssetHash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetHash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetHash", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public System.Int64 Bytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bytes", value);
			}
		}

		[JsonProperty(PropertyName = "free")]
		[JsonPropertyName("free")]
		public System.Boolean Free
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Free"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Free", value);
			}
		}

		[JsonProperty(PropertyName = "isUploaded")]
		[JsonPropertyName("isUploaded")]
		public System.Boolean IsUploaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUploaded"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsUploaded", value);
			}
		}

		[JsonProperty(PropertyName = "uploaderUserId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("uploaderUserId")]
		public System.String UploaderUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploaderUserId", value);
			}
		}

		[JsonProperty(PropertyName = "countsAgainstMemberQuota", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("countsAgainstMemberQuota")]
		public bool? CountsAgainstMemberQuota
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CountsAgainstMemberQuota"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CountsAgainstMemberQuota", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AssetMetadataRequest : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_BATCH_SIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_BATCH_SIZE", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetMetadataRequest(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum UploadState
	{
		UploadingChunks,
		Finalizing,
		Uploaded,
		Failed
	}
	public class AssetUploadData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "hash")]
		[JsonPropertyName("hash")]
		public System.String Hash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hash", value);
			}
		}

		[JsonProperty(PropertyName = "variant")]
		[JsonPropertyName("variant")]
		public System.String Variant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Variant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Variant", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "totalBytes")]
		[JsonPropertyName("totalBytes")]
		public System.Int64 TotalBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalBytes", value);
			}
		}

		[JsonProperty(PropertyName = "chunkSize")]
		[JsonPropertyName("chunkSize")]
		public System.Int32 ChunkSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChunkSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChunkSize", value);
			}
		}

		[JsonProperty(PropertyName = "totalChunks")]
		[JsonPropertyName("totalChunks")]
		public System.Int32 TotalChunks
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalChunks"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalChunks", value);
			}
		}

		[JsonProperty(PropertyName = "uploadState")]
		[JsonPropertyName("uploadState")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public UploadState UploadState
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadState"), typeof(UploadState)) is UploadState __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UploadState");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadState", value);
			}
		}

		[JsonProperty(PropertyName = "uploadKey")]
		[JsonPropertyName("uploadKey")]
		public System.String UploadKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadKey"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadKey", value);
			}
		}

		[JsonProperty(PropertyName = "uploadEndpoint")]
		[JsonPropertyName("uploadEndpoint")]
		public System.String UploadEndpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadEndpoint", value);
			}
		}

		[JsonProperty(PropertyName = "isDirectUpload")]
		[JsonPropertyName("isDirectUpload")]
		public System.Boolean IsDirectUpload
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDirectUpload"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsDirectUpload", value);
			}
		}

		[JsonProperty(PropertyName = "maxUploadConcurrency")]
		[JsonPropertyName("maxUploadConcurrency")]
		public System.Int32 MaxUploadConcurrency
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxUploadConcurrency"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxUploadConcurrency", value);
			}
		}

		[JsonProperty(PropertyName = "chunks")]
		[JsonPropertyName("chunks")]
		public List<AssetChunk> Chunks
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Chunks"), typeof(List<AssetChunk>)) is List<AssetChunk> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<AssetChunk>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Chunks", value);
			}
		}

		[JsonProperty(PropertyName = "createdOn")]
		[JsonPropertyName("createdOn")]
		public DateTime CreatedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreatedOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreatedOn", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 LastChunkSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastChunkSize"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetUploadData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum AssetVariantEntityType
	{
		BitmapMetadata,
		BitmapVariant,
		CubemapMetadata,
		CubemapVariant,
		VolumeMetadata,
		VolumeVariant,
		MeshMetadata,
		MeshVariant,
		ShaderMetadata,
		ShaderVariant
	}
	public class AssetVariantComputationTask : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "assetSignature")]
		[JsonPropertyName("assetSignature")]
		public System.String AssetSignature
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetSignature"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetSignature", value);
			}
		}

		[JsonProperty(PropertyName = "variantId")]
		[JsonPropertyName("variantId")]
		public System.String VariantId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariantId", value);
			}
		}

		[JsonProperty(PropertyName = "entityType")]
		[JsonPropertyName("entityType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public AssetVariantEntityType EntityType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EntityType"), typeof(AssetVariantEntityType)) is AssetVariantEntityType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AssetVariantEntityType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EntityType", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetVariantComputationTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class BlobMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "url")]
		[JsonPropertyName("url")]
		public System.String Url
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Url"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Url", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "size")]
		[JsonPropertyName("size")]
		public System.Int64 Size
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Size"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Size", value);
			}
		}

		[JsonProperty(PropertyName = "contentType")]
		[JsonPropertyName("contentType")]
		public System.String ContentType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContentType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContentType", value);
			}
		}

		[JsonProperty(PropertyName = "lastModified")]
		[JsonPropertyName("lastModified")]
		public DateTimeOffset LastModified
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModified"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModified", value);
			}
		}

		[JsonProperty(PropertyName = "deleteToken")]
		[JsonPropertyName("deleteToken")]
		public System.String DeleteToken
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DeleteToken"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DeleteToken", value);
			}
		}

		[JsonProperty(PropertyName = "isFree")]
		[JsonPropertyName("isFree")]
		public System.String IsFree
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsFree"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsFree", value);
			}
		}

		[JsonProperty(PropertyName = "reclassifiedVersion")]
		[JsonPropertyName("reclassifiedVersion")]
		public System.Int32 ReclassifiedVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReclassifiedVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReclassifiedVersion", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BlobMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public struct ComputationLock : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "token")]
		public System.String Token
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Token", value);
			}
		}

		[JsonProperty(PropertyName = "timestamp")]
		public DateTime ExpireTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpireTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExpireTimestamp", value);
			}
		}

		public System.Boolean IsLocked
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLocked"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean TryLock(TimeSpan duration)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryLock", duration), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean TryExtend(System.String token, TimeSpan duration)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryExtend", token, duration), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean TryRelease(System.String token)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryRelease", token), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ComputationLock(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class DBAsset : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "hash")]
		[JsonPropertyName("hash")]
		public System.String Hash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hash", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public System.Int64 Bytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bytes", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public DBAsset(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SamlIdentityProvider : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "entityId")]
		[JsonPropertyName("entityId")]
		public System.String EntityId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EntityId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EntityId", value);
			}
		}

		[JsonProperty(PropertyName = "metadataUrl")]
		[JsonPropertyName("metadataUrl")]
		public System.String MetadataUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MetadataUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MetadataUrl", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "iconUrl")]
		[JsonPropertyName("iconUrl")]
		public System.String IconUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IconUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IconUrl", value);
			}
		}

		[JsonProperty(PropertyName = "restrictToUniverseIds")]
		[JsonPropertyName("restrictToUniverseIds")]
		public HashSet<string> RestrictToUniverseIds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RestrictToUniverseIds"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RestrictToUniverseIds", value);
			}
		}

		[JsonProperty(PropertyName = "skipDateOfBirthRequirement")]
		[JsonPropertyName("skipDateOfBirthRequirement")]
		public System.Boolean SkipDateOfBirthRequirement
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SkipDateOfBirthRequirement"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SkipDateOfBirthRequirement", value);
			}
		}

		[JsonProperty(PropertyName = "usernameClaims")]
		[JsonPropertyName("usernameClaims")]
		public HashSet<string> UsernameClaims
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsernameClaims"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsernameClaims", value);
			}
		}

		[JsonProperty(PropertyName = "emailClaims")]
		[JsonPropertyName("emailClaims")]
		public HashSet<string> EmailClaims
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EmailClaims"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EmailClaims", value);
			}
		}

		[JsonProperty(PropertyName = "dateOfBirthClaims")]
		[JsonPropertyName("dateOfBirthClaims")]
		public HashSet<string> DateOfBirthClaims
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DateOfBirthClaims"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DateOfBirthClaims", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SamlIdentityProvider(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AppBuildConfiguration : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "configId")]
		[JsonPropertyName("configId")]
		public System.String ConfigId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "appConfiguration")]
		[JsonPropertyName("appConfiguration")]
		public AppConfig AppConfiguration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppConfiguration"), typeof(AppConfig)) is AppConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AppConfig");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppConfiguration", value);
			}
		}

		[JsonProperty(PropertyName = "splashScreenSignature")]
		[JsonPropertyName("splashScreenSignature")]
		public System.String SplashScreenSignature
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SplashScreenSignature"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SplashScreenSignature", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AppBuildConfiguration(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum BuildType
	{
		Unity_Mono,
		Unity_Mono_Debug,
		Unity_IL2CPP_Release,
		Unity_IL2CPP_Master,
		HeadlessNetFramework,
		HeadlessNet,
		UnitySDK
	}
	public static class AppBuildTypeExtensions
	{
		public static System.Boolean IsGraphicalClient(this BuildType type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsGraphicalClient", type), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsHeadless(this BuildType type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsHeadless", type), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsAppClient(this BuildType type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsAppClient", type), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	public class AppBuildVariant : BuildVariant<AppBuildVariantDescriptor>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AppBuildVariant(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AppBuildVariantDescriptor : BuildVariantDescriptor, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "buildType")]
		[JsonPropertyName("buildType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildType BuildType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BuildType"), typeof(BuildType)) is BuildType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BuildType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BuildType", value);
			}
		}

		public override System.String GetIdString(System.Boolean includeVersion, System.String separator = "-")
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetIdString", includeVersion, separator), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AppBuildVariantDescriptor(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum BuildApplication
	{
		App,
		Launcher
	}
	public class Build : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "application")]
		[JsonPropertyName("application")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildApplication Application
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Application"), typeof(BuildApplication)) is BuildApplication __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BuildApplication");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Application", value);
			}
		}

		[JsonProperty(PropertyName = "version")]
		[JsonPropertyName("version")]
		public VersionNumber Version
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(VersionNumber)) is VersionNumber __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VersionNumber");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Version", value);
			}
		}

		[JsonProperty(PropertyName = "alternateVersionNumber")]
		[JsonPropertyName("alternateVersionNumber")]
		public System.String AlternateVersionNumber
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateVersionNumber"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AlternateVersionNumber", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public MultiLanguageValue<string> Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>)) is MultiLanguageValue<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MultiLanguageValue<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "graphic")]
		[JsonPropertyName("graphic")]
		public MultiLanguageValue<System.Uri> Graphic
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Graphic"), typeof(MultiLanguageValue<System.Uri>)) is MultiLanguageValue<System.Uri> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MultiLanguageValue<Uri>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Graphic", value);
			}
		}

		[JsonProperty(PropertyName = "changes")]
		[JsonPropertyName("changes")]
		public List<BuildChange> Changes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Changes"), typeof(List<BuildChange>)) is List<BuildChange> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<BuildChange>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Changes", value);
			}
		}

		[JsonProperty(PropertyName = "knownIssues")]
		[JsonPropertyName("knownIssues")]
		public List<BuildNote> KnownIssues
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KnownIssues"), typeof(List<BuildNote>)) is List<BuildNote> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<BuildNote>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "KnownIssues", value);
			}
		}

		[JsonProperty(PropertyName = "notes")]
		[JsonPropertyName("notes")]
		public List<BuildNote> Notes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Notes"), typeof(List<BuildNote>)) is List<BuildNote> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<BuildNote>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Notes", value);
			}
		}

		[JsonProperty(PropertyName = "branch")]
		[JsonPropertyName("branch")]
		public System.String Branch
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Branch"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Branch", value);
			}
		}

		[JsonProperty(PropertyName = "mergedBranch")]
		[JsonPropertyName("mergedBranch")]
		public System.String MergedBranch
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MergedBranch"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MergedBranch", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Build(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum BuildChangeType
	{
		Feature,
		Tweak,
		Optimization,
		Security,
		Bugfix
	}
	public class BuildChange : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "changeId")]
		[JsonPropertyName("changeId")]
		public System.String ChangeId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeId", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public MultiLanguageValue<string> Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>)) is MultiLanguageValue<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MultiLanguageValue<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "type")]
		[JsonPropertyName("type")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildChangeType Type
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(BuildChangeType)) is BuildChangeType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BuildChangeType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Type", value);
			}
		}

		[JsonProperty(PropertyName = "workInProgress")]
		[JsonPropertyName("workInProgress")]
		public System.Boolean WorkInProgress
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WorkInProgress"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WorkInProgress", value);
			}
		}

		[JsonProperty(PropertyName = "branchSpecific")]
		[JsonPropertyName("branchSpecific")]
		public System.Boolean BranchSpecific
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BranchSpecific"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BranchSpecific", value);
			}
		}

		[JsonProperty(PropertyName = "relatedIssues")]
		[JsonPropertyName("relatedIssues")]
		public List<IssueReference> RelatedIssues
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RelatedIssues"), typeof(List<IssueReference>)) is List<IssueReference> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IssueReference>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RelatedIssues", value);
			}
		}

		[JsonProperty(PropertyName = "contributors")]
		[JsonPropertyName("contributors")]
		public List<BuildUser> Contributors
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contributors"), typeof(List<BuildUser>)) is List<BuildUser> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<BuildUser>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Contributors", value);
			}
		}

		[JsonProperty(PropertyName = "reporters")]
		[JsonPropertyName("reporters")]
		public List<BuildUser> Reporters
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Reporters"), typeof(List<BuildUser>)) is List<BuildUser> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<BuildUser>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Reporters", value);
			}
		}

		[JsonProperty(PropertyName = "affectedPlatforms")]
		[JsonPropertyName("affectedPlatforms")]
		public HashSet<BuildPlatform> AffectedPlatforms
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AffectedPlatforms"), typeof(HashSet<BuildPlatform>)) is HashSet<BuildPlatform> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<BuildPlatform>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AffectedPlatforms", value);
			}
		}

		[JsonProperty(PropertyName = "excludedPublishingPlatforms")]
		[JsonPropertyName("excludedPublishingPlatforms")]
		public HashSet<PublishingPlatform> ExcludedPublishingPlatforms
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExcludedPublishingPlatforms"), typeof(HashSet<PublishingPlatform>)) is HashSet<PublishingPlatform> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<PublishingPlatform>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExcludedPublishingPlatforms", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildChange(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum BuildReferenceType
	{
		Invalid,
		VersionNumber,
		ChannelId,
		LatestInBranch
	}
	public enum ConfigReferenceType
	{
		Invalid,
		ConfigId,
		ChannelId
	}
	public class BuildChannel : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.String GenerateChannelId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildChannel", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateChannelId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[JsonProperty(PropertyName = "channelId")]
		[JsonPropertyName("channelId")]
		public System.String ChannelId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChannelId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChannelId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "application")]
		[JsonPropertyName("application")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildApplication Application
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Application"), typeof(BuildApplication)) is BuildApplication __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BuildApplication");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Application", value);
			}
		}

		[JsonProperty(PropertyName = "buildReferenceId")]
		[JsonPropertyName("buildReferenceId")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildReferenceType BuildReferenceType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BuildReferenceType"), typeof(BuildReferenceType)) is BuildReferenceType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BuildReferenceType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BuildReferenceType", value);
			}
		}

		[JsonProperty(PropertyName = "buildId")]
		[JsonPropertyName("buildId")]
		public System.String BuildId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BuildId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BuildId", value);
			}
		}

		[JsonProperty(PropertyName = "configReferenceId")]
		[JsonPropertyName("configReferenceId")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ConfigReferenceType ConfigReferenceType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigReferenceType"), typeof(ConfigReferenceType)) is ConfigReferenceType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConfigReferenceType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigReferenceType", value);
			}
		}

		[JsonProperty(PropertyName = "configurationId")]
		[JsonPropertyName("configId")]
		public System.String ConfigId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigId", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildChannel(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class BuildFile : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsFolder
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsFolder"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[JsonProperty(PropertyName = "signature")]
		[JsonPropertyName("signature")]
		public System.String Signature
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Signature"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Signature", value);
			}
		}

		[JsonProperty(PropertyName = "sizeBytes")]
		[JsonPropertyName("sizeBytes")]
		public System.Int32 SizeBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SizeBytes"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SizeBytes", value);
			}
		}

		[JsonProperty(PropertyName = "path")]
		[JsonPropertyName("path")]
		public System.String Path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildFile(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class BuildNote : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "noteId")]
		[JsonPropertyName("noteId")]
		public System.String NoteId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NoteId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NoteId", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public MultiLanguageValue<string> Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>)) is MultiLanguageValue<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MultiLanguageValue<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildNote(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class BuildUser : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public System.String Username
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public System.String UserID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserID", value);
			}
		}

		[JsonProperty(PropertyName = "discordHandle")]
		[JsonPropertyName("discordHandle")]
		public System.String DiscordHandle
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordHandle"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DiscordHandle", value);
			}
		}

		[JsonProperty(PropertyName = "githubHandle")]
		[JsonPropertyName("githubHandle")]
		public System.String GithubHandle
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GithubHandle"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GithubHandle", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildUser(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum BuildStatus
	{
		Nonexistent,
		ScheduledToBuild,
		Building,
		Built,
		FailedToBuild
	}
	public enum BuildPlatform
	{
		Any,
		Windows_x64,
		Linux_x64,
		Android_ARM7,
		OculusQuest
	}
	public static class BuildPlatformExtensions
	{
		public static System.Boolean IsWindows(this BuildPlatform platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsWindows", platform), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsLinux(this BuildPlatform platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsLinux", platform), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsDesktop(this BuildPlatform platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDesktop", platform), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	public abstract class BuildVariant : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "versionNumber")]
		[JsonPropertyName("versionNumber")]
		public System.String VariantId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		[JsonProperty(PropertyName = "status")]
		[JsonPropertyName("status")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildStatus Status
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(BuildStatus)) is BuildStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BuildStatus");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Status", value);
			}
		}

		[JsonProperty(PropertyName = "files")]
		[JsonPropertyName("files")]
		public List<BuildFile> Files
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Files"), typeof(List<BuildFile>)) is List<BuildFile> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<BuildFile>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Files", value);
			}
		}

		protected abstract System.String GetIdString();

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildVariant()
		{
		}
	}
	public abstract class BuildVariant<D> : BuildVariant, ResoniteBridge.ResoniteBridgeValueHolder where D : BuildVariantDescriptor
	{
		[JsonProperty(PropertyName = "descriptor")]
		[JsonPropertyName("descriptor")]
		public D Descriptor
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Descriptor"), typeof(D)) is D __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to D");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Descriptor", value);
			}
		}

		protected override System.String GetIdString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetIdString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildVariant()
		{
		}
	}
	public abstract class BuildVariantDescriptor : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "versionNumber")]
		[JsonPropertyName("versionNumber")]
		public VersionNumber VersionNumber
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VersionNumber"), typeof(VersionNumber)) is VersionNumber __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VersionNumber");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VersionNumber", value);
			}
		}

		[JsonProperty(PropertyName = "versionString")]
		[JsonPropertyName("versionString")]
		public System.String VersionString
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VersionString"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		[JsonProperty(PropertyName = "platform")]
		[JsonPropertyName("platform")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildPlatform Platform
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Platform"), typeof(BuildPlatform)) is BuildPlatform __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BuildPlatform");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Platform", value);
			}
		}

		public virtual System.String GetIdString(System.Boolean includeVersion, System.String separator = "-")
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetIdString", includeVersion, separator), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BuildVariantDescriptor()
		{
		}
	}
	public struct FeatureFlag : IEquatable<FeatureFlag>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "feature")]
		[JsonPropertyName("feature")]
		public System.String Feature
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Feature"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Feature", value);
			}
		}

		[JsonProperty(PropertyName = "version")]
		[JsonPropertyName("version")]
		public System.Int32 Version
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Version", value);
			}
		}

		public System.Boolean Equals(FeatureFlag other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static bool operator ==(FeatureFlag left, FeatureFlag right)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "FeatureFlag", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(FeatureFlag left, FeatureFlag right)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "FeatureFlag", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public FeatureFlag(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public FeatureFlag()
		{
		}
	}
	public enum IssueSystem
	{
		GitHub,
		Moderation
	}
	public enum IssueAction
	{
		None,
		Close,
		Update,
		RequestResolveConfirmation
	}
	public class IssueReference : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "issueNumber")]
		[JsonPropertyName("issueNumber")]
		public System.Int32 IssueNumber
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueNumber"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IssueNumber", value);
			}
		}

		[JsonProperty(PropertyName = "issueSystem")]
		[JsonPropertyName("issueSystem")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[global::System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public IssueSystem System
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "System"), typeof(IssueSystem)) is IssueSystem __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IssueSystem");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "System", value);
			}
		}

		[JsonProperty(PropertyName = "issueSystem")]
		[JsonPropertyName("issueSystem")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[global::System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public IssueAction Action
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Action"), typeof(IssueAction)) is IssueAction __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IssueAction");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Action", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public IssueReference(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum PublishingPlatform
	{
		Steam,
		SideQuest,
		ItchIo
	}
	public class CloudBootstrap : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "adminUser")]
		[JsonPropertyName("adminUser")]
		public RegistrationRequest AdminUser
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AdminUser"), typeof(RegistrationRequest)) is RegistrationRequest __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RegistrationRequest");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AdminUser", value);
			}
		}

		[JsonProperty(PropertyName = "appBotLogin")]
		[JsonPropertyName("appBotLogin")]
		public PasswordLogin AppBotAccountLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppBotAccountLogin"), typeof(PasswordLogin)) is PasswordLogin __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PasswordLogin");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppBotAccountLogin", value);
			}
		}

		[JsonProperty(PropertyName = "devBotLogin")]
		[JsonPropertyName("devBotLogin")]
		public PasswordLogin DevBotAccountLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotAccountLogin"), typeof(PasswordLogin)) is PasswordLogin __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PasswordLogin");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DevBotAccountLogin", value);
			}
		}

		[JsonProperty(PropertyName = "computeLogin")]
		[JsonPropertyName("computeLogin")]
		public PasswordLogin ComputeAccountLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeAccountLogin"), typeof(PasswordLogin)) is PasswordLogin __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PasswordLogin");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeAccountLogin", value);
			}
		}

		[JsonProperty(PropertyName = "networkLogin")]
		[JsonPropertyName("networkLogin")]
		public PasswordLogin NetworkAccountLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkAccountLogin"), typeof(PasswordLogin)) is PasswordLogin __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PasswordLogin");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkAccountLogin", value);
			}
		}

		[JsonProperty(PropertyName = "testAccountName")]
		[JsonPropertyName("testAccountName")]
		public System.String TestAccountName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TestAccountName", value);
			}
		}

		[JsonProperty(PropertyName = "testAccountLogin")]
		[JsonPropertyName("testAccountLogin")]
		public PasswordLogin TestAccountLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountLogin"), typeof(PasswordLogin)) is PasswordLogin __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PasswordLogin");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TestAccountLogin", value);
			}
		}

		[JsonProperty(PropertyName = "testAccountCount")]
		[JsonPropertyName("testAccountCount")]
		public System.Int32 TestAccountCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TestAccountCount", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudBootstrap(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudMessage : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "Message")]
		[JsonPropertyName("Message")]
		public System.String Message
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Message"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Message", value);
			}
		}

		public static System.String ExtractMessage(System.String content)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudMessage", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractMessage", content), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudMessage(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudSessionMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "sessionId")]
		[JsonPropertyName("sessionId")]
		public System.String SessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionId", value);
			}
		}

		[JsonProperty(PropertyName = "hostUserId")]
		[JsonPropertyName("hostUserId")]
		public System.String HostUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HostUserId", value);
			}
		}

		[JsonProperty(PropertyName = "joinedUsers")]
		[JsonPropertyName("joinedUsers")]
		public System.Int32 JoinedUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "JoinedUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "JoinedUsers", value);
			}
		}

		[JsonProperty(PropertyName = "activeUsers")]
		[JsonPropertyName("activeUsers")]
		public System.Int32 ActiveUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActiveUsers", value);
			}
		}

		[JsonProperty(PropertyName = "hostUserSessionId")]
		[JsonPropertyName("hostUserSessionId")]
		public System.String HostUserSessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUserSessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HostUserSessionId", value);
			}
		}

		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "accessLevel")]
		[JsonPropertyName("accessLevel")]
		public SessionAccessLevel AccessLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccessLevel"), typeof(SessionAccessLevel)) is SessionAccessLevel __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SessionAccessLevel");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AccessLevel", value);
			}
		}

		[JsonProperty(PropertyName = "sessionHidden")]
		[JsonPropertyName("sessionHidden")]
		public System.Boolean SessionHidden
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionHidden"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionHidden", value);
			}
		}

		[JsonProperty(PropertyName = "sessionURLs")]
		[JsonPropertyName("sessionURLs")]
		public List<string> SessionURLs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionURLs"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionURLs", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudSessionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudStats : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "assetMetadataJobs")]
		[JsonPropertyName("assetMetadataJobs")]
		public int? AssetMetadataJobs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetMetadataJobs"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetMetadataJobs", value);
			}
		}

		[JsonProperty(PropertyName = "assetVariantJobs")]
		[JsonPropertyName("assetVariantJobs")]
		public int? AssetVariantJobs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetVariantJobs"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetVariantJobs", value);
			}
		}

		[JsonProperty(PropertyName = "computedAssetMetadata")]
		[JsonPropertyName("computedAssetMetadata")]
		public int? ComputedAssetMetadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputedAssetMetadata"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputedAssetMetadata", value);
			}
		}

		[JsonProperty(PropertyName = "computedAssetVariants")]
		[JsonPropertyName("computedAssetVariants")]
		public int? ComputedAssetVariants
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputedAssetVariants"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputedAssetVariants", value);
			}
		}

		[JsonProperty(PropertyName = "recordPreprocessJobs")]
		[JsonPropertyName("recordPreprocessJobs")]
		public int? RecordPreprocessJobs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordPreprocessJobs"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordPreprocessJobs", value);
			}
		}

		[JsonProperty(PropertyName = "uploadJobs")]
		[JsonPropertyName("uploadJobs")]
		public int? UploadJobs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadJobs"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadJobs", value);
			}
		}

		[JsonProperty(PropertyName = "migrationTasksInQueue")]
		[JsonPropertyName("migrationTasksInQueue")]
		public System.Double MigrationTasksInQueue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationTasksInQueue"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationTasksInQueue", value);
			}
		}

		[JsonProperty(PropertyName = "migrationRecordsPerMinute")]
		[JsonPropertyName("migrationRecordsPerMinute")]
		public System.Double MigrationRecordsPerMinute
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationRecordsPerMinute"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationRecordsPerMinute", value);
			}
		}

		[JsonProperty(PropertyName = "captureTimestamp")]
		[JsonPropertyName("captureTimestamp")]
		public DateTime CaptureTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CaptureTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CaptureTimestamp", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudStats(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudVariable : IEquatable<CloudVariable>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty("ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String VariableOwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariableOwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariableOwnerId", value);
			}
		}

		[JsonProperty("path")]
		[JsonPropertyName("path")]
		public System.String Path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		[JsonProperty("value")]
		[JsonPropertyName("value")]
		public System.String Value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Value", value);
			}
		}

		[JsonProperty("timestamp")]
		[JsonPropertyName("timestamp")]
		public DateTimeOffset? Timestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Timestamp", value);
			}
		}

		public System.Boolean Equals(CloudVariable other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudVariable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudVariableDefinition : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty("definitionOwnerId")]
		[JsonPropertyName("definitionOwnerId")]
		public System.String DefinitionOwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefinitionOwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DefinitionOwnerId", value);
			}
		}

		[JsonProperty("subpath")]
		[JsonPropertyName("subpath")]
		public System.String Subpath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Subpath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Subpath", value);
			}
		}

		[JsonProperty(PropertyName = "variableType")]
		[JsonPropertyName("variableType")]
		public System.String VariableType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariableType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariableType", value);
			}
		}

		[JsonProperty(PropertyName = "defaultValue")]
		[JsonPropertyName("defaultValue")]
		public System.String DefaultValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultValue"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DefaultValue", value);
			}
		}

		[JsonProperty(PropertyName = "readPermissions")]
		[JsonPropertyName("readPermissions")]
		public List<string> ReadPermissions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadPermissions"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReadPermissions", value);
			}
		}

		[JsonProperty(PropertyName = "writePermissions")]
		[JsonPropertyName("writePermissions")]
		public List<string> WritePermissions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WritePermissions"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WritePermissions", value);
			}
		}

		[JsonProperty(PropertyName = "listPermissions")]
		[JsonPropertyName("listPermissions")]
		public List<string> ListPermissions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListPermissions"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ListPermissions", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudVariableDefinition(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class Comment : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "commentId")]
		[JsonPropertyName("commentId")]
		public System.String CommentId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CommentId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CommentId", value);
			}
		}

		[JsonProperty(PropertyName = "postedOn")]
		[JsonPropertyName("postedOn")]
		public DateTime PostedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PostedOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PostedOn", value);
			}
		}

		[JsonProperty(PropertyName = "commentSenderId")]
		[JsonPropertyName("commentSenderId")]
		public System.String CommentSenderId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CommentSenderId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CommentSenderId", value);
			}
		}

		[JsonProperty(PropertyName = "responseToCommentId")]
		[JsonPropertyName("responseToCommentId")]
		public System.String ReplyToCommentId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReplyToCommentId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReplyToCommentId", value);
			}
		}

		[JsonProperty(PropertyName = "content")]
		[JsonPropertyName("content")]
		public System.String Content
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Content", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Comment(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ConfigFileData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "path")]
		[JsonPropertyName("path")]
		public System.String Path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		[JsonProperty(PropertyName = "content")]
		[JsonPropertyName("content")]
		public System.String Content
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Content", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ConfigFileData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
	public enum LoginMethods
	{
		Login,
		Register,
		SAML
	}
	public enum EntityInterfacePreference
	{
		UserPreferred,
		UniversePreferred,
		UniverseOnly
	}
	public class AppConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("$schema")]
		public System.String Schema
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Schema"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Schema", value);
			}
		}

		[JsonPropertyName("unsafeModeWhiteList")]
		public List<string> UnsafeModeWhitelist
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnsafeModeWhitelist"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UnsafeModeWhitelist", value);
			}
		}

		[JsonPropertyName("inputs")]
		public InputConfig Inputs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Inputs"), typeof(InputConfig)) is InputConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to InputConfig");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Inputs", value);
			}
		}

		[JsonPropertyName("universeId")]
		public System.String UniverseId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UniverseId", value);
			}
		}

		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonPropertyName("nodePreference")]
		public NetworkNodePreference NodePreference
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodePreference"), typeof(NetworkNodePreference)) is NetworkNodePreference __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NetworkNodePreference");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NodePreference", value);
			}
		}

		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonPropertyName("universeEntityPreference")]
		public EntityInterfacePreference UniverseEntityPreference
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseEntityPreference"), typeof(EntityInterfacePreference)) is EntityInterfacePreference __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to EntityInterfacePreference");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UniverseEntityPreference", value);
			}
		}

		[JsonPropertyName("useUniverseDash")]
		public System.Boolean UseUniverseDash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseUniverseDash"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseUniverseDash", value);
			}
		}

		[JsonPropertyName("useUniverseHomes")]
		public System.Boolean UseUniverseHomes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseUniverseHomes"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseUniverseHomes", value);
			}
		}

		[JsonPropertyName("proxy")]
		public ProxyConfig Proxy
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Proxy"), typeof(ProxyConfig)) is ProxyConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ProxyConfig");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Proxy", value);
			}
		}

		[JsonPropertyName("announceLocalIPs")]
		public bool? AnnounceLocalIPs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AnnounceLocalIPs"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AnnounceLocalIPs", value);
			}
		}

		[JsonPropertyName("disableAnnounceOnLAN")]
		public System.Boolean DisableAnnounceOnLAN
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableAnnounceOnLAN"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisableAnnounceOnLAN", value);
			}
		}

		[JsonPropertyName("disableIntroTutorial")]
		public System.Boolean DisableIntroTutorial
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableIntroTutorial"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisableIntroTutorial", value);
			}
		}

		[JsonPropertyName("disableCloudHomeAutoLoad")]
		public System.Boolean DisableCloudHomeAutoLoad
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableCloudHomeAutoLoad"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisableCloudHomeAutoLoad", value);
			}
		}

		[JsonPropertyName("autoStartWorlds")]
		public List<WorldStartupParameters> AutoStartWorlds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoStartWorlds"), typeof(List<WorldStartupParameters>)) is List<WorldStartupParameters> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<WorldStartupParameters>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoStartWorlds", value);
			}
		}

		[JsonPropertyName("autoJoinSessions")]
		public List<SessionJoinParameters> AutoJoinSessions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoJoinSessions"), typeof(List<SessionJoinParameters>)) is List<SessionJoinParameters> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<SessionJoinParameters>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoJoinSessions", value);
			}
		}

		[JsonPropertyName("noUI")]
		public System.Boolean NoUI
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NoUI"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NoUI", value);
			}
		}

		[JsonPropertyName("disableDesktop")]
		public System.Boolean DisableDesktop
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableDesktop"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisableDesktop", value);
			}
		}

		[JsonPropertyName("availableLoginMethods")]
		public List<LoginMethods>? AvailableLoginMethods
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AvailableLoginMethods"), typeof(List<LoginMethods>)) is List<LoginMethods> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<LoginMethods>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AvailableLoginMethods", value);
			}
		}

		[JsonPropertyName("pathWhitelist")]
		public List<string> PathWhitelist
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PathWhitelist"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PathWhitelist", value);
			}
		}

		[JsonPropertyName("lnlConfig")]
		public LNLConfig? LNLConfig
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LNLConfig"), typeof(LNLConfig)) is LNLConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LNLConfig");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LNLConfig", value);
			}
		}

		[JsonPropertyName("forceStartMicrophoneMuted")]
		public System.Boolean ForceStartMicrophoneMuted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceStartMicrophoneMuted"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForceStartMicrophoneMuted", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AppConfig(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class InputConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("triggerDeadZone")]
		public System.Single TriggerDeadzone
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TriggerDeadzone"), typeof(System.Single)) is System.Single __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to float");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TriggerDeadzone", value);
			}
		}

		[JsonPropertyName("axisDeadZone")]
		public System.Single AxisDeadzone
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AxisDeadzone"), typeof(System.Single)) is System.Single __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to float");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AxisDeadzone", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public InputConfig(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class LNLConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("ports")]
		public PortRange? Ports
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ports"), typeof(PortRange)) is PortRange __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PortRange");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Ports", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LNLConfig(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ProxyConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum CredentialType
		{
			DefaultSystemCache,
			NetworkCache,
			Kerberos,
			UsernamePassword
		}

		[JsonPropertyName("autoDetect")]
		public System.Boolean AutoDetect
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoDetect"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoDetect", value);
			}
		}

		[JsonPropertyName("localBypass")]
		public System.Boolean LocalBypass
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalBypass"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LocalBypass", value);
			}
		}

		[JsonPropertyName("bypassDomains")]
		public List<string> BypassDomains
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BypassDomains"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BypassDomains", value);
			}
		}

		[System.Text.Json.Serialization.JsonConverter(typeof(JsonUriConverter))]
		[JsonPropertyName("address")]
		public System.Uri Address
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Address"), typeof(System.Uri)) is System.Uri __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Uri");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Address", value);
			}
		}

		[JsonPropertyName("credentialStore")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public CredentialType CredentialStore
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CredentialStore"), typeof(CredentialType)) is CredentialType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CredentialType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CredentialStore", value);
			}
		}

		[JsonPropertyName("username")]
		public System.String Username
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonPropertyName("password")]
		public System.String Password
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Password", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean ShouldUseAutoDetect
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShouldUseAutoDetect"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ProxyConfig(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SessionJoinParameters : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "url")]
		[JsonPropertyName("url")]
		public System.Uri URL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "URL"), typeof(System.Uri)) is System.Uri __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Uri");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "URL", value);
			}
		}

		[JsonProperty(PropertyName = "sessionId")]
		[JsonPropertyName("sessionId")]
		public System.String SessionID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionID", value);
			}
		}

		[JsonProperty(PropertyName = "lanOnly")]
		[JsonPropertyName("lanOnly")]
		public System.Boolean LanOnly
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LanOnly"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LanOnly", value);
			}
		}

		[JsonProperty(PropertyName = "headlessOnly")]
		[JsonPropertyName("headlessOnly")]
		public System.Boolean HeadlessOnly
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HeadlessOnly"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HeadlessOnly", value);
			}
		}

		[JsonProperty(PropertyName = "onlyUniverseId")]
		[JsonPropertyName("onlyUniverseId")]
		public System.String OnlyUniverseID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyUniverseID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlyUniverseID", value);
			}
		}

		[JsonProperty(PropertyName = "autoFocus")]
		[JsonPropertyName("autoFocus")]
		public System.Boolean AutoFocus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoFocus"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoFocus", value);
			}
		}

		[JsonProperty(PropertyName = "waitForLogin")]
		[JsonPropertyName("waitForLogin")]
		public System.Boolean WaitForLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WaitForLogin"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WaitForLogin", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean Processed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Processed"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Processed", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SessionJoinParameters(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum SaveAsOwner
	{
		LocalMachine,
		CloudUser
	}
	public class WorldStartupParameters : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "isEnabled")]
		[JsonPropertyName("isEnabled")]
		public System.Boolean IsEnabled
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEnabled"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsEnabled", value);
			}
		}

		[JsonProperty(PropertyName = "sessionName")]
		[JsonPropertyName("sessionName")]
		public System.String SessionName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionName", value);
			}
		}

		[JsonProperty(PropertyName = "customSessionId")]
		[JsonPropertyName("customSessionId")]
		public System.String CustomSessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomSessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomSessionId", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[DefaultValue(32)]
		[JsonProperty(PropertyName = "maxUsers")]
		[JsonPropertyName("maxUsers")]
		public System.Int32 MaxUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxUsers", value);
			}
		}

		[JsonProperty(PropertyName = "accessLevel")]
		[JsonPropertyName("accessLevel")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public SessionAccessLevel AccessLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccessLevel"), typeof(SessionAccessLevel)) is SessionAccessLevel __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SessionAccessLevel");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AccessLevel", value);
			}
		}

		[JsonProperty(PropertyName = "useCustomJoinVerifier")]
		[JsonPropertyName("useCustomJoinVerifier")]
		public System.Boolean UseCustomJoinVerifier
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseCustomJoinVerifier"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseCustomJoinVerifier", value);
			}
		}

		[JsonProperty(PropertyName = "hideFromPublicListing")]
		[JsonPropertyName("hideFromPublicListing")]
		public bool? HideFromPublicListing
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HideFromPublicListing"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HideFromPublicListing", value);
			}
		}

		[JsonProperty(PropertyName = "tags")]
		[JsonPropertyName("tags")]
		public List<string> Tags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tags"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "mobileFriendly")]
		[JsonPropertyName("mobileFriendly")]
		public System.Boolean MobileFriendly
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MobileFriendly"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MobileFriendly", value);
			}
		}

		[JsonProperty(PropertyName = "loadWorldURL")]
		[JsonPropertyName("loadWorldURL")]
		public System.String LoadWorldURL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadWorldURL"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LoadWorldURL", value);
			}
		}

		[JsonProperty(PropertyName = "loadWorldPresetName")]
		[JsonPropertyName("loadWorldPresetName")]
		public System.String LoadWorldPresetName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadWorldPresetName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LoadWorldPresetName", value);
			}
		}

		[JsonProperty(PropertyName = "overrideCorrespondingWorldId")]
		[JsonPropertyName("overrideCorrespondingWorldId")]
		public RecordId OverrideCorrespondingWorldId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideCorrespondingWorldId"), typeof(RecordId)) is RecordId __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordId");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverrideCorrespondingWorldId", value);
			}
		}

		[JsonProperty(PropertyName = "forcePort")]
		[JsonPropertyName("forcePort")]
		public ushort? ForcePort
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForcePort"), typeof(System.UInt16)) is System.UInt16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ushort");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForcePort", value);
			}
		}

		[JsonProperty(PropertyName = "keepOriginalRoles")]
		[JsonPropertyName("keepOriginalRoles")]
		public System.Boolean KeepOriginalRoles
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KeepOriginalRoles"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "KeepOriginalRoles", value);
			}
		}

		[JsonProperty(PropertyName = "defaultUserRoles")]
		[JsonPropertyName("defaultUserRoles")]
		public Dictionary<string, string> DefaultUserRoles
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUserRoles"), typeof(Dictionary<string, string>)) is Dictionary<string, string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DefaultUserRoles", value);
			}
		}

		[JsonProperty(PropertyName = "roleCloudVariable")]
		[JsonPropertyName("roleCloudVariable")]
		public System.String RoleCloudVariable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RoleCloudVariable"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RoleCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "allowUserCloudVariable")]
		[JsonPropertyName("allowUserCloudVariable")]
		public System.String AllowUserCloudVariable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllowUserCloudVariable"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AllowUserCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "denyUserCloudVariable")]
		[JsonPropertyName("denyUserCloudVariable")]
		public System.String DenyUserCloudVariable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DenyUserCloudVariable"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DenyUserCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "requiredUserJoinCloudVariable")]
		[JsonPropertyName("requiredUserJoinCloudVariable")]
		public System.String RequiredUserJoinCloudVariable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredUserJoinCloudVariable"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RequiredUserJoinCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "requiredUserJoinCloudVariableDenyMessage")]
		[JsonPropertyName("requiredUserJoinCloudVariableDenyMessage")]
		public System.String RequiredUserJoinCloudVariableDenyMessage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredUserJoinCloudVariableDenyMessage"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RequiredUserJoinCloudVariableDenyMessage", value);
			}
		}

		[JsonProperty(PropertyName = "awayKickMinutes")]
		[JsonPropertyName("awayKickMinutes")]
		public System.Double AwayKickMinutes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AwayKickMinutes"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AwayKickMinutes", value);
			}
		}

		[JsonProperty(PropertyName = "parentSessionIds")]
		[JsonPropertyName("parentSessionIds")]
		public List<string> ParentSessionIds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ParentSessionIds"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ParentSessionIds", value);
			}
		}

		[JsonProperty(PropertyName = "autoInviteUsernames")]
		[JsonPropertyName("autoInviteUsernames")]
		public List<string> AutoInviteUsernames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoInviteUsernames"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoInviteUsernames", value);
			}
		}

		[JsonProperty(PropertyName = "autoInviteMessage")]
		[JsonPropertyName("autoInviteMessage")]
		public System.String AutoInviteMessage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoInviteMessage"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoInviteMessage", value);
			}
		}

		[JsonProperty(PropertyName = "saveAsOwner")]
		[JsonPropertyName("saveAsOwner")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public SaveAsOwner? SaveAsOwner
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SaveAsOwner"), typeof(SaveAsOwner)) is SaveAsOwner __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SaveAsOwner");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SaveAsOwner", value);
			}
		}

		[JsonProperty(PropertyName = "autoRecover")]
		[JsonPropertyName("autoRecover")]
		public System.Boolean AutoRecover
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoRecover"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoRecover", value);
			}
		}

		[JsonProperty(PropertyName = "idleRestartInterval")]
		[JsonPropertyName("idleRestartInterval")]
		public System.Double IdleRestartInterval
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IdleRestartInterval"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IdleRestartInterval", value);
			}
		}

		[JsonProperty(PropertyName = "forcedRestartInterval")]
		[JsonPropertyName("forcedRestartInterval")]
		public System.Double ForcedRestartInterval
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForcedRestartInterval"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForcedRestartInterval", value);
			}
		}

		[JsonProperty(PropertyName = "saveOnExit")]
		[JsonPropertyName("saveOnExit")]
		public System.Boolean SaveOnExit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SaveOnExit"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SaveOnExit", value);
			}
		}

		[JsonProperty(PropertyName = "autosaveInterval")]
		[JsonPropertyName("autosaveInterval")]
		public System.Double AutoSaveInterval
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoSaveInterval"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoSaveInterval", value);
			}
		}

		[JsonProperty(PropertyName = "autoSleep")]
		[JsonPropertyName("autoSleep")]
		public System.Boolean AutoSleep
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoSleep"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoSleep", value);
			}
		}

		[JsonProperty(PropertyName = "waitForLogin")]
		[JsonPropertyName("waitForLogin")]
		public System.Boolean WaitForLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WaitForLogin"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WaitForLogin", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean Processed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Processed"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Processed", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public WorldStartupParameters(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class Contact : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String ContactUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactUserId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "contactUsername")]
		[JsonPropertyName("contactUsername")]
		public System.String ContactUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactUsername", value);
			}
		}

		[JsonProperty(PropertyName = "alternateUsernames")]
		[JsonPropertyName("alternateUsernames")]
		public List<string> AlternateUsernames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateUsernames"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AlternateUsernames", value);
			}
		}

		[JsonProperty(PropertyName = "contactStatus")]
		[JsonPropertyName("contactStatus")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ContactStatus ContactStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactStatus"), typeof(ContactStatus)) is ContactStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ContactStatus");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactStatus", value);
			}
		}

		[JsonProperty(PropertyName = "isAccepted")]
		[JsonPropertyName("isAccepted")]
		public System.Boolean IsAccepted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAccepted"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAccepted", value);
			}
		}

		[JsonProperty(PropertyName = "latestMessageTime")]
		[JsonPropertyName("latestMessageTime")]
		public DateTime LatestMessageTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LatestMessageTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LatestMessageTime", value);
			}
		}

		[JsonProperty(PropertyName = "profile")]
		[JsonPropertyName("profile")]
		public UserProfile Profile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Profile"), typeof(UserProfile)) is UserProfile __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserProfile");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Profile", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public System.Boolean IsMigrated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[JsonProperty(PropertyName = "isCounterpartMigrated")]
		[JsonPropertyName("isCounterpartMigrated")]
		public System.Boolean IsCounterpartMigrated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsCounterpartMigrated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsCounterpartMigrated", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsSelfContact
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSelfContact"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsPartiallyMigrated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPartiallyMigrated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsContactRequest
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsContactRequest"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean CanBeInteractedWith
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeInteractedWith"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean ShouldBeHidden
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShouldBeHidden"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "friendUsername")]
		[JsonPropertyName("friendUsername")]
		public System.String LegacyFriendUsername
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyFriendUsername", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "friendStatus")]
		[JsonPropertyName("friendStatus")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ContactStatus LegacyFriendStatus
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyFriendStatus", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Contact(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum ContactStatus
	{
		None,
		SearchResult,
		Requested,
		Ignored,
		Blocked,
		Accepted
	}
	public class BadgeEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "badgeType")]
		[JsonPropertyName("badgeType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BadgeType BadgeType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BadgeType"), typeof(BadgeType)) is BadgeType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BadgeType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BadgeType", value);
			}
		}

		[JsonProperty(PropertyName = "badgeCount")]
		[JsonPropertyName("badgeCount")]
		public System.Int32 BadgeCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BadgeCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BadgeCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BadgeEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[DataModelType]
	[OldAssembly("SkyFrost.Base")]
	public enum CreditType
	{
		Basic,
		Prominent,
		Spoken,
		Sponsor
	}
	public class CreditsEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "creditType")]
		[JsonPropertyName("creditType")]
		public CreditType CreditType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreditType"), typeof(CreditType)) is CreditType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CreditType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreditType", value);
			}
		}

		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static CreditType? GetTypeForAmount(System.Decimal dollars)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CreditsEntitlement", ResoniteBridge.ResoniteBridgeValueType.Type), "GetTypeForAmount", dollars), typeof(CreditType)) is CreditType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CreditsEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CreditUser : SupporterBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "creditType")]
		[JsonPropertyName("creditType")]
		public CreditType CreditType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreditType"), typeof(CreditType)) is CreditType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CreditType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreditType", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CreditUser(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DeleteRecoveryEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public DeleteRecoveryEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonDerivedType(typeof(DeleteRecoveryEntitlement), "deleteRecovery")]
	[JsonDerivedType(typeof(GroupCreationEntitlement), "groupCreation")]
	[JsonDerivedType(typeof(StorageSpaceEntitlement), "storageSpace")]
	[JsonDerivedType(typeof(WorldAccessEntitlement), "worldAccess")]
	[JsonDerivedType(typeof(BadgeEntitlement), "badge")]
	[JsonDerivedType(typeof(ExitMessageEntitlement), "exitMessage")]
	[JsonDerivedType(typeof(LaunchShoutOutEntitlement), "shoutOut")]
	[JsonDerivedType(typeof(CreditsEntitlement), "credits")]
	[JsonDerivedType(typeof(HeadlessServerEntitlement), "headless")]
	public abstract class Entitlement : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public virtual System.Boolean IsLifetime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLifetime"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract System.String FriendlyDescription { get; }

		public abstract System.Boolean CombineWith(Entitlement other);

		public abstract System.Boolean SanitizeOrRemove();

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Entitlement()
		{
		}
	}
	public class ExitMessageEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.Boolean IsLifetime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLifetime"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[JsonProperty(PropertyName = "messageCount")]
		[JsonPropertyName("messageCount")]
		public System.Int32 MessageCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MessageCount", value);
			}
		}

		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ExitMessageEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class GroupCreationEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "groupCount")]
		[JsonPropertyName("groupCount")]
		public System.Int32 GroupCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.Boolean CombineWith(Entitlement otherGroup)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", otherGroup), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public GroupCreationEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class HeadlessServerEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public HeadlessServerEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum LaunchShoutoutType
	{
		TextSmall,
		TextLarge,
		Verbal,
		Sponsor
	}
	public class LaunchShoutOutEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "shoutoutType")]
		[JsonPropertyName("shoutoutType")]
		public LaunchShoutoutType ShoutoutType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShoutoutType"), typeof(LaunchShoutoutType)) is LaunchShoutoutType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LaunchShoutoutType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShoutoutType", value);
			}
		}

		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static LaunchShoutoutType? GetTypeForAmount(System.Decimal dollars)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "LaunchShoutOutEntitlement", ResoniteBridge.ResoniteBridgeValueType.Type), "GetTypeForAmount", dollars), typeof(LaunchShoutoutType)) is LaunchShoutoutType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LaunchShoutOutEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ShoutOutUser : SupporterBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "shoutoutType")]
		[JsonPropertyName("shoutoutType")]
		public LaunchShoutoutType ShoutoutType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShoutoutType"), typeof(LaunchShoutoutType)) is LaunchShoutoutType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LaunchShoutoutType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShoutoutType", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ShoutOutUser(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class StorageSpaceEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public System.Int64 Bytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bytes", value);
			}
		}

		[JsonProperty(PropertyName = "maximumShareLevel")]
		[JsonPropertyName("maximumShareLevel")]
		public StorageShareLevel MaximumShareLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaximumShareLevel"), typeof(StorageShareLevel)) is StorageShareLevel __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to StorageShareLevel");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaximumShareLevel", value);
			}
		}

		[JsonProperty(PropertyName = "storageId")]
		[JsonPropertyName("storageId")]
		public System.String StorageId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StorageId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StorageId", value);
			}
		}

		[JsonProperty(PropertyName = "group")]
		[JsonPropertyName("group")]
		public System.String Group
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Group", value);
			}
		}

		[JsonProperty(PropertyName = "startsOn")]
		[JsonPropertyName("startsOn")]
		public DateTime StartsOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StartsOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StartsOn", value);
			}
		}

		[JsonProperty(PropertyName = "expiresOn")]
		[JsonPropertyName("expiresOn")]
		public DateTime ExpiresOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpiresOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExpiresOn", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StorageSpaceEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class SupporterBase : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "supportSource")]
		[JsonPropertyName("supportSource")]
		public System.String SupportSource
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportSource"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportSource", value);
			}
		}

		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public System.String Username
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "iconUrl")]
		[JsonPropertyName("iconUrl")]
		public System.String IconURL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IconURL"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IconURL", value);
			}
		}

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public System.String UserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "supportTimestamp")]
		[JsonPropertyName("supportTimestamp")]
		public DateTime SupportTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportTimestamp", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SupporterBase()
		{
		}
	}
	public class WorldAccessEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerIds")]
		[JsonPropertyName("ownerIds")]
		public HashSet<string> OwnerIds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerIds"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerIds", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override System.String FriendlyDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean SanitizeOrRemove()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public WorldAccessEntitlement(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class EntityId : IEquatable<EntityId>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(EntityId other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(System.String other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static EntityId TryParse(System.String compositeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EntityId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId), typeof(EntityId)) is EntityId __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static bool operator ==(EntityId a, EntityId b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EntityId", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(EntityId a, EntityId b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EntityId", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public EntityId(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ExitMessage : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "messageIndex")]
		[JsonPropertyName("messageIndex")]
		public System.Int32 MessageIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MessageIndex", value);
			}
		}

		[JsonProperty(PropertyName = "message")]
		[JsonPropertyName("message")]
		public System.String Message
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Message"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Message", value);
			}
		}

		[JsonProperty(PropertyName = "addedByUserId")]
		[JsonPropertyName("addedByUserId")]
		public System.String AddedByUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AddedByUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AddedByUserId", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ExitMessage(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ExternalQueueObject<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "popReceipt")]
		[JsonPropertyName("popReceipt")]
		public System.String PopReceipt
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PopReceipt"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PopReceipt", value);
			}
		}

		[JsonProperty(PropertyName = "blobKey")]
		[JsonPropertyName("blobKey")]
		public System.String BlobKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BlobKey"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BlobKey", value);
			}
		}

		[JsonProperty(PropertyName = "object")]
		[JsonPropertyName("object")]
		public T Object
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Object"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Object", value);
			}
		}

		[JsonProperty(PropertyName = "queueName")]
		[JsonPropertyName("queueName")]
		public System.String QueueName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QueueName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QueueName", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ExternalQueueObject(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum FavoriteEntity
	{
		Avatar,
		Keyboard,
		Camera,
		Home,
		AudioPlayer,
		VideoPlayer,
		TextDisplay,
		UrlDisplay,
		AudioStreamController,
		ProgressBar,
		WorldLoadingIndicator,
		NamePlate,
		NoticeDisplay,
		ColorDialog,
		DocumentDisplay
	}
	public static class FavoriteEntityHelper
	{
		public static System.Boolean IsPubliclyReadable(this FavoriteEntity entity)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "FavoriteEntityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsPubliclyReadable", entity), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	public abstract class FundingEvent : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "amount")]
		[JsonPropertyName("amount")]
		public System.Decimal Amount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Amount"), typeof(System.Decimal)) is System.Decimal __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to decimal");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Amount", value);
			}
		}

		[JsonProperty(PropertyName = "currency")]
		[JsonPropertyName("currency")]
		public System.String Currency
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Currency"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Currency", value);
			}
		}

		[JsonProperty(PropertyName = "eventTimestamp")]
		[JsonPropertyName("eventTimestamp")]
		public DateTime EventTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EventTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EventTimestamp", value);
			}
		}

		[JsonProperty(PropertyName = "validityStart")]
		[JsonPropertyName("validityStart")]
		public DateTime ValidityStart
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValidityStart"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValidityStart", value);
			}
		}

		[JsonProperty(PropertyName = "validityEnd")]
		[JsonPropertyName("validityEnd")]
		public DateTime ValidityEnd
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValidityEnd"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValidityEnd", value);
			}
		}

		[JsonProperty(PropertyName = "isInvalidated")]
		[JsonPropertyName("isInvalidated")]
		public System.Boolean IsInvalidated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsInvalidated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsInvalidated", value);
			}
		}

		[JsonProperty(PropertyName = "entitlements")]
		[JsonPropertyName("entitlements")]
		public List<Entitlement> Entitlements
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Entitlements"), typeof(List<Entitlement>)) is List<Entitlement> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Entitlement>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Entitlements", value);
			}
		}

		[JsonProperty(PropertyName = "tierName")]
		[JsonPropertyName("tierName")]
		public System.String TierName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TierName", value);
			}
		}

		[JsonProperty(PropertyName = "note")]
		[JsonPropertyName("note")]
		public System.String Note
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Note"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Note", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean IsValidAtTime(DateTime time)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidAtTime", time), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public FundingEvent()
		{
		}
	}
	public class PatreonFundingEvent : FundingEvent, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "paymentTime")]
		[JsonPropertyName("paymentTime")]
		public DateTime PaymentTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PaymentTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PaymentTime", value);
			}
		}

		[JsonProperty(PropertyName = "tierAmountCents")]
		[JsonPropertyName("tierAmountCents")]
		public System.Int32 TierAmountCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierAmountCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TierAmountCents", value);
			}
		}

		[JsonProperty(PropertyName = "patronId")]
		[JsonPropertyName("patronId")]
		public System.String PatronId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatronId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatronId", value);
			}
		}

		[JsonProperty(PropertyName = "tierId")]
		[JsonPropertyName("tierId")]
		public System.String TierId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TierId", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public PatreonFundingEvent(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class StripeCustomerProperty : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "customerId")]
		[JsonPropertyName("customerId")]
		public System.String CustomerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomerId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StripeCustomerProperty(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class StripeFundingEvent : FundingEvent, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty("customerId")]
		[JsonPropertyName("customerId")]
		public System.String CustomerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomerId", value);
			}
		}

		[JsonProperty("subscriptionId")]
		[JsonPropertyName("subscriptionId")]
		public System.String SubscriptionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubscriptionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubscriptionId", value);
			}
		}

		[JsonProperty("invoiceId")]
		[JsonPropertyName("invoiceId")]
		public System.String InvoiceId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InvoiceId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InvoiceId", value);
			}
		}

		[JsonProperty("tierId")]
		[JsonPropertyName("tierId")]
		public System.String TierId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TierId", value);
			}
		}

		[JsonProperty("eventId")]
		[JsonPropertyName("eventId")]
		public System.String EventId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EventId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EventId", value);
			}
		}

		[JsonProperty("isLive")]
		[JsonPropertyName("isLive")]
		public System.Boolean IsLive
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLive"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsLive", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StripeFundingEvent(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class Group : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String GroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "adminUserId")]
		[JsonPropertyName("adminUserId")]
		public System.String AdminUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AdminUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AdminUserId", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public System.Boolean IsMigrated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public long? LegacyQuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public long? LegacyUsedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyUsedBytes", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Group(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[DataModelType]
	[OldAssembly("SkyFrost.Base")]
	public enum OwnerType
	{
		Machine,
		User,
		Group,
		INVALID
	}
	public static class IdUtil
	{
		public static OwnerType GetOwnerType(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "IdUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOwnerType", id), typeof(OwnerType)) is OwnerType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	[Serializable]
	public struct RecordVersion : IEquatable<RecordVersion>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "globalVersion")]
		[JsonPropertyName("globalVersion")]
		public System.Int32 GlobalVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GlobalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "localVersion")]
		[JsonPropertyName("localVersion")]
		public System.Int32 LocalVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LocalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "lastModifyingUserId")]
		[JsonPropertyName("lastModifyingUserId")]
		public System.String LastModifyingUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModifyingUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModifyingUserId", value);
			}
		}

		[JsonProperty(PropertyName = "lastModifyingMachineId")]
		[JsonPropertyName("lastModifyingMachineId")]
		public System.String LastModifyingMachineId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModifyingMachineId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModifyingMachineId", value);
			}
		}

		public RecordVersion OverrideModifyingUserId(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideModifyingUserId", userId), typeof(RecordVersion)) is RecordVersion __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(RecordVersion other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static bool operator ==(RecordVersion a, RecordVersion b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordVersion", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(RecordVersion a, RecordVersion b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordVersion", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordVersion(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RecordVersion()
		{
		}
	}
	public class MigrationMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "migrationId")]
		[JsonPropertyName("migrationId")]
		public System.String MigrationId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationId", value);
			}
		}

		[JsonProperty(PropertyName = "migrationSource")]
		[JsonPropertyName("migrationSource")]
		public System.String MigrationSource
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationSource"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationSource", value);
			}
		}

		[JsonProperty(PropertyName = "migratedOn")]
		[JsonPropertyName("migratedOn")]
		public DateTime MigratedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedOn", value);
			}
		}

		[JsonProperty(PropertyName = "sourceVersion")]
		[JsonPropertyName("sourceVersion")]
		public RecordVersion SourceVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceVersion"), typeof(RecordVersion)) is RecordVersion __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordVersion");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceVersion", value);
			}
		}

		[JsonProperty(PropertyName = "targetVersion")]
		[JsonPropertyName("targetVersion")]
		public RecordVersion? TargetVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetVersion"), typeof(RecordVersion)) is RecordVersion __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordVersion");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TargetVersion", value);
			}
		}

		[JsonProperty(PropertyName = "assetManifest", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("assetManifest")]
		public List<DBAsset> AssetManifest
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetManifest"), typeof(List<DBAsset>)) is List<DBAsset> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<DBAsset>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetManifest", value);
			}
		}

		[JsonProperty(PropertyName = "previousMigration")]
		[JsonPropertyName("previousMigration")]
		public MigrationMetadata PreviousMigration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreviousMigration"), typeof(MigrationMetadata)) is MigrationMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MigrationMetadata");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreviousMigration", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MigrationMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface IRecord : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.String RecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordId", value);
			}
		}

		System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		System.String AssetURI
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURI"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetURI", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		RecordId CombinedRecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CombinedRecordId"), typeof(RecordId)) is RecordId __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordId");
				}
			}
		}

		RecordVersion Version
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(RecordVersion)) is RecordVersion __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordVersion");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Version", value);
			}
		}

		System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		System.String OwnerName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerName", value);
			}
		}

		System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		System.String RecordType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordType", value);
			}
		}

		HashSet<string> Tags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tags"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Tags", value);
			}
		}

		System.String Path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		System.String ThumbnailURI
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailURI"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailURI", value);
			}
		}

		System.Boolean IsPublic
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPublic"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPublic", value);
			}
		}

		System.Boolean IsForPatrons
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsForPatrons"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsForPatrons", value);
			}
		}

		System.Boolean IsListed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListed"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsListed", value);
			}
		}

		System.Boolean IsDeleted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDeleted"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsDeleted", value);
			}
		}

		System.Boolean IsReadOnly
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsReadOnly"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsReadOnly", value);
			}
		}

		System.Int32 Visits
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Visits"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Visits", value);
			}
		}

		System.Double Rating
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Rating"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Rating", value);
			}
		}

		System.Int32 RandomOrder
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RandomOrder"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RandomOrder", value);
			}
		}

		MigrationMetadata MigrationMetadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationMetadata"), typeof(MigrationMetadata)) is MigrationMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MigrationMetadata");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationMetadata", value);
			}
		}

		DateTime? FirstPublishTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FirstPublishTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FirstPublishTime", value);
			}
		}

		DateTime? CreationTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreationTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreationTime", value);
			}
		}

		DateTime LastModificationTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModificationTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModificationTime", value);
			}
		}

		List<DBAsset> AssetManifest
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetManifest"), typeof(List<DBAsset>)) is List<DBAsset> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<DBAsset>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetManifest", value);
			}
		}

		R Clone<R>() where R : class, IRecord, new();

		void IncrementGlobalVersion();

		void OverrideGlobalVersion(System.Int32 globalVersion);

		void IncrementLocalVersion(System.String machineId, System.String userId);
	}
	public static class RecordHelper
	{
		public static System.String GenerateRecordID()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateRecordID"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidRecordID(System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidRecordID", recordId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsSameVersion(this RecordVersion version, RecordVersion otherVersion)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameVersion", version, otherVersion), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean CanOverwrite(this RecordVersion source, RecordVersion target, System.Boolean sourceDeleted = false, System.Boolean targetDeleted = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanOverwrite", source, target, sourceDeleted, targetDeleted), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsSameVersion(this IRecord record, IRecord other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameVersion", record, other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsSameRecord(this IRecord record, IRecord other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameRecord", record, other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static void InheritPermissions(this IRecord record, IRecord source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "InheritPermissions", record, source);
		}

		public static System.Boolean CanOverwrite(this IRecord record, IRecord oldRecord)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanOverwrite", record, oldRecord), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static void TakeIdentityFrom(this IRecord record, IRecord source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TakeIdentityFrom", record, source);
		}

		public static System.Uri GetUrl(this IRecord record, IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUrl", record, platform), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Uri GetWebUrl(this IRecord record, IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetWebUrl", record, platform), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static void SetUrl(this IRecord record, IPlatformProfile platform, System.Uri url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SetUrl", record, platform, url);
		}

		public static R Convert<R>(this IRecord record) where R : IRecord
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Convert", record), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static R CreateForDirectory<R>(System.String ownerId, System.String rootPath, System.String name) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForDirectory", ownerId, rootPath, name), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static R CreateForObject<R>(System.String name, System.String ownerId, System.String assetUrl, System.String thumbnailUrl = null, System.String recordId = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForObject", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static R CreateForTexture<R>(System.String name, System.String ownerId, System.String assetUrl, System.String thumbnailUrl = null, System.String recordId = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForTexture", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static R CreateForAudioClip<R>(System.String name, System.String ownerId, System.String assetUrl, System.String thumbnailUrl = null, System.String recordId = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForAudioClip", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static R CreateForLink<R>(System.String name, System.String ownerId, System.String targetUrl, System.String recordId = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForLink", name, ownerId, targetUrl, recordId), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	public class MarkReadBatch : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_BATCH_SIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_BATCH_SIZE", value);
			}
		}

		[JsonProperty(PropertyName = "senderId")]
		[JsonPropertyName("senderId")]
		public System.String SenderId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SenderId", value);
			}
		}

		[JsonProperty(PropertyName = "ids")]
		[JsonPropertyName("ids")]
		public List<string> Ids
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ids"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Ids", value);
			}
		}

		[JsonProperty(PropertyName = "readTime")]
		[JsonPropertyName("readTime")]
		public DateTime ReadTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReadTime", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MarkReadBatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class Member : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String UserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String GroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public System.Boolean IsMigrated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public long? LegacyQuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public long? LegacyUsedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyUsedBytes", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Member(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class Membership : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String UserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String GroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "groupName")]
		[JsonPropertyName("groupName")]
		public System.String GroupName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupName", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public System.Boolean IsMigrated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Membership(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum MessageType
	{
		Text,
		Object,
		Sound,
		SessionInvite
	}
	public enum SendStatus
	{
		Sending,
		Failed,
		Sent
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class Message : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_ID_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_ID_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_ID_LENGTH", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public SendStatus? SendStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SendStatus"), typeof(SendStatus)) is SendStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SendStatus");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SendStatus", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "recipientId")]
		[JsonPropertyName("recipientId")]
		public System.String RecipientId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecipientId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecipientId", value);
			}
		}

		[JsonProperty(PropertyName = "senderId")]
		[JsonPropertyName("senderId")]
		public System.String SenderId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SenderId", value);
			}
		}

		[JsonProperty(PropertyName = "senderUserSessionId")]
		[JsonPropertyName("senderUserSessionId")]
		public System.String SenderUserSessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderUserSessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SenderUserSessionId", value);
			}
		}

		[JsonProperty(PropertyName = "messageType")]
		[JsonPropertyName("messageType")]
		[Newtonsoft.Json.JsonConverter(typeof(NewtonDefaultingStringEnumConverter<MessageType>))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonDefaultingStringEnumConverter<MessageType>))]
		public MessageType MessageType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageType"), typeof(MessageType)) is MessageType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MessageType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MessageType", value);
			}
		}

		[JsonProperty(PropertyName = "content")]
		[JsonPropertyName("content")]
		public System.String Content
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Content", value);
			}
		}

		[JsonProperty(PropertyName = "sendTime")]
		[JsonPropertyName("sendTime")]
		public DateTime SendTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SendTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SendTime", value);
			}
		}

		[JsonProperty(PropertyName = "lastUpdateTime")]
		[JsonPropertyName("lastUpdateTime")]
		public DateTime LastUpdateTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastUpdateTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastUpdateTime", value);
			}
		}

		[JsonProperty(PropertyName = "readTime")]
		[JsonPropertyName("readTime")]
		public DateTime? ReadTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReadTime", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public System.Boolean IsMigrated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsSelfMessage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSelfMessage"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsSent
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSent"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsReceived
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsReceived"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsRead
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsRead"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String OtherUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OtherUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OtherUserId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsPreFetched
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPreFetched"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPreFetched", value);
			}
		}

		public static System.String GenerateId()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Message", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateId"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidId(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Message", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", id), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public T ExtractContent<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractContent"), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public void SetContent<T>(T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetContent", obj);
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Message Clone()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(Message)) is Message __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Message(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class MultiLanguageValue<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "primaryLocale")]
		[JsonPropertyName("primaryLocale")]
		public System.String PrimaryLocale
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrimaryLocale"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrimaryLocale", value);
			}
		}

		[JsonProperty(PropertyName = "valuesByLocale")]
		[JsonPropertyName("valuesByLocale")]
		public Dictionary<string, T> ValuesByLocale
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValuesByLocale"), typeof(Dictionary<string, T>)) is Dictionary<string, T> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, T>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ValuesByLocale", value);
			}
		}

		public void SetValue(T value, System.String locale = "en")
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value, locale);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MultiLanguageValue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum NetworkNodeType
	{
		LNL_NAT,
		LNL_Relay
	}
	public enum NetworkNodePreference
	{
		Any,
		UniversePreferred,
		UniverseOnly
	}
	public class NetworkNodeInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 LNL_PROTOCOL_VERSION
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LNL_PROTOCOL_VERSION"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LNL_PROTOCOL_VERSION", value);
			}
		}

		public static TimeSpan INFO_EXPIRATION
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "NetworkNodeInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "INFO_EXPIRATION"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String NodeId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NodeId", value);
			}
		}

		[JsonProperty(PropertyName = "timestamp")]
		[JsonPropertyName("timestamp")]
		public DateTimeOffset Timestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Timestamp", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String NodeName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NodeName", value);
			}
		}

		[JsonProperty(PropertyName = "address")]
		[JsonPropertyName("address")]
		public System.String Address
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Address"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Address", value);
			}
		}

		[JsonProperty(PropertyName = "port")]
		[JsonPropertyName("port")]
		public System.UInt16 Port
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Port"), typeof(System.UInt16)) is System.UInt16 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ushort");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Port", value);
			}
		}

		[JsonProperty(PropertyName = "nodeType")]
		[JsonPropertyName("nodeType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public NetworkNodeType NodeType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeType"), typeof(NetworkNodeType)) is NetworkNodeType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to NetworkNodeType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NodeType", value);
			}
		}

		[JsonProperty(PropertyName = "protocolVersion")]
		[JsonPropertyName("protocolVersion")]
		public System.Int32 ProtocolVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProtocolVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ProtocolVersion", value);
			}
		}

		[JsonProperty(PropertyName = "userCount")]
		[JsonPropertyName("userCount")]
		public System.Int32 UserCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserCount", value);
			}
		}

		[JsonProperty(PropertyName = "capacity")]
		[JsonPropertyName("capacity")]
		public System.Int32 Capacity
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Capacity"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Capacity", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean HasCapacity
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasCapacity"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsShuttingDown
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsShuttingDown"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[JsonProperty(PropertyName = "universeId")]
		[JsonPropertyName("universeId")]
		public System.String UniverseId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UniverseId", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue TryGetEndpoint()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetEndpoint"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean ShouldUse(System.Int32 protocolVersion = 2, NetworkNodePreference? preference = null, System.String universeId = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ShouldUse", protocolVersion, preference, universeId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public NetworkNodeInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class OAuthApplication : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		public System.String ClientId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ClientId", value);
			}
		}

		public System.String ClientSecret
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientSecret"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ClientSecret", value);
			}
		}

		public System.String ClientType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ClientType", value);
			}
		}

		public System.String DisplayName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisplayName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisplayName", value);
			}
		}

		public System.String ConsentType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConsentType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConsentType", value);
			}
		}

		public List<string> Permissions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Permissions"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Permissions", value);
			}
		}

		public List<string> PostLogoutRedirectUris
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PostLogoutRedirectUris"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PostLogoutRedirectUris", value);
			}
		}

		public List<string> RedirectUris
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RedirectUris"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RedirectUris", value);
			}
		}

		public List<string> Requirements
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Requirements"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Requirements", value);
			}
		}

		public Dictionary<string, JsonElement> Properties
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Properties"), typeof(Dictionary<string, JsonElement>)) is Dictionary<string, JsonElement> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, JsonElement>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Properties", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public OAuthApplication(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class OAuthToken : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String ApplicationId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApplicationId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ApplicationId", value);
			}
		}

		public System.String AuthorizationId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthorizationId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AuthorizationId", value);
			}
		}

		public System.String ReferenceId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferenceId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReferenceId", value);
			}
		}

		public System.String Status
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Status", value);
			}
		}

		public System.String Subject
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Subject"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Subject", value);
			}
		}

		public System.String Type
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Type", value);
			}
		}

		public DateTimeOffset? CreationDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreationDate"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreationDate", value);
			}
		}

		public DateTimeOffset? ExpirationDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpirationDate"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExpirationDate", value);
			}
		}

		public DateTimeOffset? RedemptionDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RedemptionDate"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RedemptionDate", value);
			}
		}

		public Dictionary<string, JsonElement> Properties
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Properties"), typeof(Dictionary<string, JsonElement>)) is Dictionary<string, JsonElement> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, JsonElement>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Properties", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public OAuthToken(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class OnlineStats : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "captureTimestamp")]
		[JsonPropertyName("captureTimestamp")]
		public DateTime CaptureTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CaptureTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CaptureTimestamp", value);
			}
		}

		[JsonProperty(PropertyName = "visibleSessionsByAccessLevel")]
		[JsonPropertyName("visibleSessionsByAccessLevel")]
		public Dictionary<SessionAccessLevel, int> VisibleSessionsByAccessLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VisibleSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>)) is Dictionary<SessionAccessLevel, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<SessionAccessLevel, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VisibleSessionsByAccessLevel", value);
			}
		}

		[JsonProperty(PropertyName = "hiddenSessionsByAccessLevel")]
		[JsonPropertyName("hiddenSessionsByAccessLevel")]
		public Dictionary<SessionAccessLevel, int> HiddenSessionsByAccessLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HiddenSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>)) is Dictionary<SessionAccessLevel, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<SessionAccessLevel, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HiddenSessionsByAccessLevel", value);
			}
		}

		[JsonProperty(PropertyName = "activeVisibleSessionsByAccessLevel")]
		[JsonPropertyName("activeVisibleSessionsByAccessLevel")]
		public Dictionary<SessionAccessLevel, int> ActiveVisibleSessionsByAccessLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveVisibleSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>)) is Dictionary<SessionAccessLevel, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<SessionAccessLevel, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActiveVisibleSessionsByAccessLevel", value);
			}
		}

		[JsonProperty(PropertyName = "activeHiddenSessionsByAccessLevel")]
		[JsonPropertyName("activeHiddenSessionsByAccessLevel")]
		public Dictionary<SessionAccessLevel, int> ActiveHiddenSessionsByAccessLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveHiddenSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>)) is Dictionary<SessionAccessLevel, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<SessionAccessLevel, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActiveHiddenSessionsByAccessLevel", value);
			}
		}

		[JsonProperty(PropertyName = "registeredUsers")]
		[JsonPropertyName("registeredUsers")]
		public System.Int32 RegisteredUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RegisteredUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RegisteredUsers", value);
			}
		}

		[JsonProperty(PropertyName = "presentUsers")]
		[JsonPropertyName("presentUsers")]
		public System.Int32 PresentUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PresentUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PresentUsers", value);
			}
		}

		[JsonProperty(PropertyName = "awayUsers")]
		[JsonPropertyName("awayUsers")]
		public System.Int32 AwayUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AwayUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AwayUsers", value);
			}
		}

		[JsonProperty(PropertyName = "instanceCount")]
		[JsonPropertyName("instanceCount")]
		public System.Int32 InstanceCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InstanceCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InstanceCount", value);
			}
		}

		[JsonProperty(PropertyName = "usersInVR")]
		[JsonPropertyName("usersInVR")]
		public System.Int32 UsersInVR
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVR"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInVR", value);
			}
		}

		[JsonProperty(PropertyName = "usersInScreen")]
		[JsonPropertyName("usersInScreen")]
		public System.Int32 UsersInScreen
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInScreen"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInScreen", value);
			}
		}

		[JsonProperty(PropertyName = "usersOnDesktop")]
		[JsonPropertyName("usersOnDesktop")]
		public System.Int32 UsersOnDesktop
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersOnDesktop"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersOnDesktop", value);
			}
		}

		[JsonProperty(PropertyName = "usersOnMobile")]
		[JsonPropertyName("usersOnMobile")]
		public System.Int32 UsersOnMobile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersOnMobile"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersOnMobile", value);
			}
		}

		[JsonProperty(PropertyName = "usersInVisiblePublicSessions")]
		[JsonPropertyName("usersInVisiblePublicSessions")]
		public System.Int32 UsersInVisiblePublicSessions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVisiblePublicSessions"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInVisiblePublicSessions", value);
			}
		}

		[JsonProperty(PropertyName = "usersInVisibleSemiAccessibleSessions")]
		[JsonPropertyName("usersInVisibleSemiAccessibleSessions")]
		public System.Int32 UsersInVisibleSemiAccessibleSessions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVisibleSemiAccessibleSessions"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInVisibleSemiAccessibleSessions", value);
			}
		}

		[JsonProperty(PropertyName = "usersInHiddenSessions")]
		[JsonPropertyName("usersInHiddenSessions")]
		public System.Int32 UsersInHiddenSessions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInHiddenSessions"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInHiddenSessions", value);
			}
		}

		[JsonProperty(PropertyName = "usersInPrivateSessions")]
		[JsonPropertyName("usersInPrivateSessions")]
		public System.Int32 UsersInPrivateSessions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInPrivateSessions"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInPrivateSessions", value);
			}
		}

		[JsonProperty(PropertyName = "usersBySessionAccessLevel")]
		[JsonPropertyName("usersBySessionAccessLevel")]
		public Dictionary<SessionAccessLevel, int> UsersBySessionAccessLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersBySessionAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>)) is Dictionary<SessionAccessLevel, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<SessionAccessLevel, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersBySessionAccessLevel", value);
			}
		}

		[JsonProperty(PropertyName = "usersByClientType")]
		[JsonPropertyName("usersByClientType")]
		public Dictionary<UserSessionType, int> UsersByClientType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersByClientType"), typeof(Dictionary<UserSessionType, int>)) is Dictionary<UserSessionType, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<UserSessionType, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersByClientType", value);
			}
		}

		public System.Int32 GetUsersBySessionAccessLevel(SessionAccessLevel accessLevel)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsersBySessionAccessLevel", accessLevel), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Int32 GetUsersByClientType(UserSessionType type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsersByClientType", type), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public OnlineStats(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum OutputDevice
	{
		Unknown,
		Screen,
		VR,
		Camera
	}
	public class PlatformProfile : IPlatformProfile, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static IPlatformProfile DURIAN
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IPlatformProfile");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN", value);
			}
		}

		private static List<IPlatformProfile> _legacyProfiles
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "_legacyProfiles"), typeof(List<IPlatformProfile>)) is List<IPlatformProfile> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<IPlatformProfile>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "_legacyProfiles", value);
			}
		}

		public static IPlatformProfile RESONITE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "RESONITE"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IPlatformProfile");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "RESONITE", value);
			}
		}

		public static IEnumerable<IPlatformProfile> LegacyProfiles
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "LegacyProfiles"), typeof(IEnumerable<IPlatformProfile>)) is IEnumerable<IPlatformProfile> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<IPlatformProfile>");
				}
			}
		}

		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonPropertyName("shortNamePrefix")]
		public System.String ShortNamePrefix
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShortNamePrefix"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShortNamePrefix", value);
			}
		}

		[JsonPropertyName("abbreviation")]
		public System.String Abbreviation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Abbreviation"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Abbreviation", value);
			}
		}

		[JsonPropertyName("domain")]
		public System.String Domain
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Domain"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Domain", value);
			}
		}

		[JsonPropertyName("moderationURL")]
		public System.String ModerationUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModerationUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModerationUrl", value);
			}
		}

		[JsonPropertyName("supportURL")]
		public System.String SupportUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportUrl", value);
			}
		}

		[JsonPropertyName("policiesPage")]
		public System.String PoliciesPage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PoliciesPage"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PoliciesPage", value);
			}
		}

		[JsonPropertyName("email")]
		public System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonPropertyName("discordInviteURL")]
		public System.String DiscordInviteUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordInviteUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DiscordInviteUrl", value);
			}
		}

		[JsonPropertyName("patreonURL")]
		public System.String PatreonUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatreonUrl", value);
			}
		}

		[JsonPropertyName("gitHubProfile")]
		public System.String GitHubProfile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubProfile"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GitHubProfile", value);
			}
		}

		[JsonPropertyName("gitHubIssuesRepository")]
		public System.String GitHubIssuesRepository
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubIssuesRepository"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GitHubIssuesRepository", value);
			}
		}

		[JsonPropertyName("webRecordEndpoint")]
		public System.String WebRecordEndpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WebRecordEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WebRecordEndpoint", value);
			}
		}

		[JsonPropertyName("webSessionEndpoint")]
		public System.String WebSessionEndpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WebSessionEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WebSessionEndpoint", value);
			}
		}

		[JsonPropertyName("groupId")]
		public System.String GroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonPropertyName("teamGroupId")]
		public System.String TeamGroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TeamGroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TeamGroupId", value);
			}
		}

		[JsonPropertyName("computeGroupId")]
		public System.String ComputeGroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeGroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeGroupId", value);
			}
		}

		[JsonPropertyName("networkGroupId")]
		public System.String NetworkGroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkGroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkGroupId", value);
			}
		}

		[JsonPropertyName("appUsername")]
		public System.String AppUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppUsername", value);
			}
		}

		[JsonPropertyName("devBotUsername")]
		public System.String DevBotUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DevBotUsername", value);
			}
		}

		[JsonPropertyName("computeUsername")]
		public System.String ComputeUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeUsername", value);
			}
		}

		[JsonPropertyName("networkUsername")]
		public System.String NetworkUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkUsername", value);
			}
		}

		[JsonPropertyName("appUserId")]
		public System.String AppUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppUserId", value);
			}
		}

		[JsonPropertyName("devBotUserId")]
		public System.String DevBotUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DevBotUserId", value);
			}
		}

		[JsonPropertyName("computeUserId")]
		public System.String ComputeUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeUserId", value);
			}
		}

		[JsonPropertyName("networkUserId")]
		public System.String NetworkUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkUserId", value);
			}
		}

		[JsonPropertyName("authScheme")]
		public System.String AuthScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AuthScheme", value);
			}
		}

		[JsonPropertyName("appScheme")]
		public System.String AppScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppScheme", value);
			}
		}

		[JsonPropertyName("dbScheme")]
		public System.String DBScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DBScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DBScheme", value);
			}
		}

		[JsonPropertyName("sessionScheme")]
		public System.String SessionScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionScheme", value);
			}
		}

		[JsonPropertyName("recordScheme")]
		public System.String RecordScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordScheme", value);
			}
		}

		[JsonPropertyName("userSessionScheme")]
		public System.String UserSessionScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserSessionScheme", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String BaseInventoryUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseInventoryUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.String SteamAppId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SteamAppId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Int64 DiscordAppId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordAppId"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		[JsonPropertyName("favoriteVariableOverrides")]
		public string[] FavoriteVariableOverrides
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FavoriteVariableOverrides"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FavoriteVariableOverrides", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<string> PlatformVariables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PlatformVariables"), typeof(IEnumerable<string>)) is IEnumerable<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<string>");
				}
			}
		}

		public static void LoadLegacyProfiles(System.String path)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadLegacyProfiles", path);
		}

		public System.String FavoriteVariable(FavoriteEntity entity)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FavoriteVariable", entity), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.String VariablePath(System.String subpath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariablePath", subpath), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean IsPlatformOwnerId(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPlatformOwnerId", ownerId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordUri(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", ownerId, recordId), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordWebUri(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordWebUri", ownerId, recordId), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordUri(RecordId recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", recordId), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordUri(IRecord record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", record), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordWebUri(RecordId recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordWebUri", recordId), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordWebUri(IRecord record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordWebUri", record), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetInventoryItemUri(System.String itemPath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInventoryItemUri", itemPath), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetSpawnObjectUri(System.String itemPath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSpawnObjectUri", itemPath), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordPath(System.String recordPath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordPath", recordPath), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordUri(System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", recordId), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetSessionUri(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionUri", sessionId), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetSessionWebUri(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionWebUri", sessionId), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public PlatformProfile(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonDerivedType(typeof(PlatformProfile), "platformProfile")]
	public interface IPlatformProfile : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String ShortNamePrefix
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShortNamePrefix"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String Abbreviation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Abbreviation"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String Domain
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Domain"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String ModerationUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModerationUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String SupportUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String DiscordInviteUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordInviteUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String PoliciesPage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PoliciesPage"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String PatreonUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String GitHubProfile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubProfile"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String GitHubIssuesRepository
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubIssuesRepository"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String GroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String TeamGroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TeamGroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String ComputeGroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeGroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String NetworkGroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkGroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String AppUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String DevBotUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String ComputeUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String NetworkUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String AppUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String DevBotUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String ComputeUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String NetworkUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String AuthScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String AppScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String DBScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DBScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String SessionScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String RecordScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String UserSessionScheme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionScheme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String BaseInventoryUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BaseInventoryUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.String SteamAppId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SteamAppId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.Int64 DiscordAppId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordAppId"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		IEnumerable<string> PlatformVariables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PlatformVariables"), typeof(IEnumerable<string>)) is IEnumerable<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<string>");
				}
			}
		}

		System.Boolean IsPlatformOwnerId(System.String ownerId);

		System.Uri GetRecordUri(System.String ownerId, System.String recordId);

		System.Uri GetRecordUri(RecordId recordId);

		System.Uri GetRecordUri(IRecord recordId);

		System.Uri GetRecordWebUri(System.String ownerId, System.String recordId);

		System.Uri GetRecordWebUri(RecordId recordId);

		System.Uri GetRecordWebUri(IRecord recordId);

		System.Uri GetInventoryItemUri(System.String itemPath);

		System.Uri GetSpawnObjectUri(System.String itemPath);

		System.Uri GetRecordPath(System.String recordPath);

		System.Uri GetRecordUri(System.String recordId);

		System.Uri GetSessionUri(System.String sessionId);

		System.Uri GetSessionWebUri(System.String sessionId);

		System.String FavoriteVariable(FavoriteEntity entity);

		System.String VariablePath(System.String subpath);
	}
	public enum TransferType
	{
		User2User,
		Generation,
		Tip
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class PointTransfer : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "token")]
		[JsonPropertyName("token")]
		public System.String Token
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Token", value);
			}
		}

		[JsonProperty(PropertyName = "fromUserId")]
		[JsonPropertyName("fromUserId")]
		public System.String FromUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FromUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FromUserId", value);
			}
		}

		[JsonProperty(PropertyName = "toUserId")]
		[JsonPropertyName("toUserId")]
		public System.String ToUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ToUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ToUserId", value);
			}
		}

		[JsonProperty(PropertyName = "amount")]
		[JsonPropertyName("amount")]
		public System.Decimal Amount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Amount"), typeof(System.Decimal)) is System.Decimal __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to decimal");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Amount", value);
			}
		}

		[JsonProperty(PropertyName = "comment")]
		[JsonPropertyName("comment")]
		public System.String Comment
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Comment"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Comment", value);
			}
		}

		[JsonProperty(PropertyName = "transferType")]
		[JsonPropertyName("transferType")]
		[Newtonsoft.Json.JsonConverter(typeof(NewtonDefaultingStringEnumConverter<TransferType>), new object[] { TransferType.User2User })]
		[JsonStringEnumConverter(typeof(TransferType), TransferType.User2User)]
		public TransferType TransferType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TransferType"), typeof(TransferType)) is TransferType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TransferType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TransferType", value);
			}
		}

		[JsonProperty(PropertyName = "anonymous")]
		[JsonPropertyName("anonymous")]
		public System.Boolean Anonymous
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Anonymous"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Anonymous", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public PointTransfer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class PriorityIssue : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String TASK_KEY
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "TASK_KEY"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "TASK_KEY", value);
			}
		}

		public System.String PRIORITY_ISSUES_ID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "PRIORITY_ISSUES_ID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "PRIORITY_ISSUES_ID", value);
			}
		}

		[JsonProperty(PropertyName = "title")]
		[JsonPropertyName("title")]
		public System.String Title
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Title"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Title", value);
			}
		}

		[JsonProperty(PropertyName = "issueNumber")]
		[JsonPropertyName("issueNumber")]
		public System.Int32 IssueNumber
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueNumber"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IssueNumber", value);
			}
		}

		[JsonProperty(PropertyName = "issueURL")]
		[JsonPropertyName("issueURL")]
		public System.String IssueURL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueURL"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IssueURL", value);
			}
		}

		[JsonProperty(PropertyName = "voteCount")]
		[JsonPropertyName("voteCount")]
		public System.Int32 VoteCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VoteCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VoteCount", value);
			}
		}

		[JsonProperty(PropertyName = "activePledgeScore")]
		[JsonPropertyName("activePledgeScore")]
		public System.Double ActivePledgeScore
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActivePledgeScore"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActivePledgeScore", value);
			}
		}

		[JsonProperty(PropertyName = "lifetimePledgeScore")]
		[JsonPropertyName("lifetimePledgeScore")]
		public System.Double LifetimePledgeScore
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LifetimePledgeScore"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LifetimePledgeScore", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public PriorityIssue(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ReadMessageBatch : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "recipientId")]
		[JsonPropertyName("recipientId")]
		public System.String RecipientId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecipientId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecipientId", value);
			}
		}

		[JsonProperty(PropertyName = "readTime")]
		[JsonPropertyName("readTime")]
		public DateTime ReadTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReadTime", value);
			}
		}

		[JsonProperty(PropertyName = "ids")]
		[JsonPropertyName("ids")]
		public List<string> Ids
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ids"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Ids", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ReadMessageBatch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class Record : IRecord, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String RecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "assetUri")]
		[JsonPropertyName("assetUri")]
		public System.String AssetURI
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURI"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetURI", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public RecordId CombinedRecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CombinedRecordId"), typeof(RecordId)) is RecordId __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordId");
				}
			}
		}

		[JsonProperty(PropertyName = "version")]
		[JsonPropertyName("version")]
		public RecordVersion Version
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(RecordVersion)) is RecordVersion __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordVersion");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Version", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("description")]
		public System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "recordType")]
		[JsonPropertyName("recordType")]
		public System.String RecordType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordType", value);
			}
		}

		[JsonProperty(PropertyName = "ownerName")]
		[JsonPropertyName("ownerName")]
		public System.String OwnerName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerName", value);
			}
		}

		[JsonProperty(PropertyName = "tags", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("tags")]
		public HashSet<string> Tags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tags"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "path")]
		[JsonPropertyName("path")]
		public System.String Path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		[JsonProperty(PropertyName = "thumbnailUri", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("thumbnailUri")]
		public System.String ThumbnailURI
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailURI"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailURI", value);
			}
		}

		[JsonProperty(PropertyName = "lastModificationTime")]
		[JsonPropertyName("lastModificationTime")]
		public DateTime LastModificationTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModificationTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModificationTime", value);
			}
		}

		[JsonProperty(PropertyName = "creationTime")]
		[JsonPropertyName("creationTime")]
		public DateTime? CreationTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreationTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreationTime", value);
			}
		}

		[JsonProperty(PropertyName = "firstPublishTime")]
		[JsonPropertyName("firstPublishTime")]
		public DateTime? FirstPublishTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FirstPublishTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FirstPublishTime", value);
			}
		}

		[JsonProperty(PropertyName = "isDeleted")]
		[JsonPropertyName("isDeleted")]
		public System.Boolean IsDeleted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDeleted"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsDeleted", value);
			}
		}

		[JsonProperty(PropertyName = "isPublic")]
		[JsonPropertyName("isPublic")]
		public System.Boolean IsPublic
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPublic"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPublic", value);
			}
		}

		[JsonProperty(PropertyName = "isForPatrons")]
		[JsonPropertyName("isForPatrons")]
		public System.Boolean IsForPatrons
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsForPatrons"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsForPatrons", value);
			}
		}

		[JsonProperty(PropertyName = "isListed")]
		[JsonPropertyName("isListed")]
		public System.Boolean IsListed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListed"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsListed", value);
			}
		}

		[JsonProperty(PropertyName = "isReadOnly")]
		[JsonPropertyName("isReadOnly")]
		public System.Boolean IsReadOnly
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsReadOnly"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsReadOnly", value);
			}
		}

		[JsonProperty(PropertyName = "visits")]
		[JsonPropertyName("visits")]
		public System.Int32 Visits
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Visits"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Visits", value);
			}
		}

		[JsonProperty(PropertyName = "rating")]
		[JsonPropertyName("rating")]
		public System.Double Rating
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Rating"), typeof(System.Double)) is System.Double __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to double");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Rating", value);
			}
		}

		[JsonProperty(PropertyName = "randomOrder")]
		[JsonPropertyName("randomOrder")]
		public System.Int32 RandomOrder
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RandomOrder"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RandomOrder", value);
			}
		}

		[JsonProperty(PropertyName = "submissions")]
		[JsonPropertyName("submissions")]
		public List<Submission> Submissions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Submissions"), typeof(List<Submission>)) is List<Submission> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Submission>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Submissions", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public List<string> Manifest
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Manifest"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Manifest", value);
			}
		}

		[JsonProperty(PropertyName = "assetManifest", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("assetManifest")]
		public List<DBAsset> AssetManifest
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetManifest"), typeof(List<DBAsset>)) is List<DBAsset> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<DBAsset>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetManifest", value);
			}
		}

		[JsonProperty(PropertyName = "migrationMetadata", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("migrationMetadata")]
		public MigrationMetadata MigrationMetadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationMetadata"), typeof(MigrationMetadata)) is MigrationMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MigrationMetadata");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationMetadata", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValidOwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValidOwnerId"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValidRecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValidRecordId"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "neosDBmanifest", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("neosDBmanifest")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public List<DBAsset> LegacyManifest
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyManifest"), typeof(List<DBAsset>)) is List<DBAsset> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<DBAsset>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyManifest", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "globalVersion")]
		[JsonPropertyName("globalVersion")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public int? LegacyGlobalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyGlobalVersion", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "localVersion")]
		[JsonPropertyName("localVersion")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public int? LegacyLocalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLocalVersion", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "lastModifyingUserId")]
		[JsonPropertyName("lastModifyingUserId")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public System.String LegacyLastModifyingUserId
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLastModifyingUserId", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "lastModifyingMachineId")]
		[JsonPropertyName("lastModifyingMachineId")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public System.String LegacyLastModifyingMachineId
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLastModifyingMachineId", value);
			}
		}

		public static System.Boolean IsValidId(System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Record", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", recordId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public void ResetVersioning()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetVersioning");
		}

		public void OverrideGlobalVersion(System.Int32 globalVersion)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideGlobalVersion", globalVersion);
		}

		public void IncrementGlobalVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IncrementGlobalVersion");
		}

		public void IncrementLocalVersion(System.String machineId, System.String userId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IncrementLocalVersion", machineId, userId);
		}

		public R Clone<R>() where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(R)) is R __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Record Clone()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(Record)) is Record __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Record(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ChildRecordDiff : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum RecordInfoOperation
		{
			Upsert,
			Remove
		}

		[JsonProperty(PropertyName = "operation")]
		[JsonPropertyName("operation")]
		public RecordInfoOperation Operation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Operation"), typeof(RecordInfoOperation)) is RecordInfoOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordInfoOperation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Operation", value);
			}
		}

		[JsonProperty(PropertyName = "created")]
		[JsonPropertyName("created")]
		public DateTime Created
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Created"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Created", value);
			}
		}

		[JsonProperty(PropertyName = "parentRecord")]
		[JsonPropertyName("parentRecord")]
		public RecordId ParentRecord
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ParentRecord"), typeof(RecordId)) is RecordId __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordId");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ParentRecord", value);
			}
		}

		[JsonProperty(PropertyName = "recordInfo")]
		[JsonPropertyName("recordInfo")]
		public RecordInfo RecordInfo
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordInfo"), typeof(RecordInfo)) is RecordInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordInfo");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordInfo", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ChildRecordDiff(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum RecordOperation
	{
		Update,
		Delete
	}
	public class RecordAuditInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "timestamp")]
		[JsonPropertyName("timestamp")]
		public DateTime Timestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Timestamp", value);
			}
		}

		[JsonProperty(PropertyName = "recordId")]
		[JsonPropertyName("recordId")]
		public System.String RecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordId", value);
			}
		}

		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "operation")]
		[JsonPropertyName("operation")]
		public RecordOperation Operation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Operation"), typeof(RecordOperation)) is RecordOperation __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordOperation");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Operation", value);
			}
		}

		[JsonProperty(PropertyName = "modifyingTime")]
		[JsonPropertyName("modifyingTime")]
		public DateTime ModifyingTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModifyingTime", value);
			}
		}

		[JsonProperty(PropertyName = "modifyingUserId")]
		[JsonPropertyName("modifyingUserId")]
		public System.String ModifyingUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModifyingUserId", value);
			}
		}

		[JsonProperty(PropertyName = "modifyingMachineId")]
		[JsonPropertyName("modifyingMachineId")]
		public System.String ModifyingMachineId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingMachineId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModifyingMachineId", value);
			}
		}

		[JsonProperty(PropertyName = "modifyingSource")]
		[JsonPropertyName("modifyingSource")]
		public System.String ModifyingSource
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingSource"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModifyingSource", value);
			}
		}

		[JsonProperty(PropertyName = "originalAssetUrl")]
		[JsonPropertyName("originalAssetUrl")]
		public System.String OriginalAssetURL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalAssetURL"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalAssetURL", value);
			}
		}

		[JsonProperty(PropertyName = "originalName")]
		[JsonPropertyName("originalName")]
		public System.String OriginalName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalName", value);
			}
		}

		[JsonProperty(PropertyName = "originalPath")]
		[JsonPropertyName("originalPath")]
		public System.String OriginalPath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalPath", value);
			}
		}

		[JsonProperty(PropertyName = "originalGlobalVersion")]
		[JsonPropertyName("originalGlobalVersion")]
		public System.Int32 OriginalGlobalVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalGlobalVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalGlobalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "originalLocalVersion")]
		[JsonPropertyName("originalLocalVersion")]
		public System.Int32 OriginalLocalVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalLocalVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalLocalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "originalModifyingMachineId")]
		[JsonPropertyName("originalModifyingMachineId")]
		public System.String OriginalModifyingMachineId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalModifyingMachineId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalModifyingMachineId", value);
			}
		}

		[JsonProperty(PropertyName = "originalModifyingUserId")]
		[JsonPropertyName("originalModifyingUserId")]
		public System.String OriginalModifyingUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalModifyingUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalModifyingUserId", value);
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordAuditInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class RecordId : IEquatable<RecordId>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "recordId")]
		[JsonPropertyName("recordId")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.String ToURL(IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToURL", platform), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(RecordId other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(System.String other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidId(System.String ownerId, System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", ownerId, id), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static RecordId TryParse(System.String compositeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId), typeof(RecordId)) is RecordId __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static bool operator ==(RecordId a, RecordId b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(RecordId a, RecordId b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordId(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class RecordInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "recordId")]
		[JsonPropertyName("recordId")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "assetUri")]
		[JsonPropertyName("assetUri")]
		public System.String AssetURI
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURI"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetURI", value);
			}
		}

		[JsonProperty(PropertyName = "thumbnailUri")]
		[JsonPropertyName("thumbnailUri")]
		public System.String ThumbnailURI
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailURI"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailURI", value);
			}
		}

		[JsonProperty(PropertyName = "globalVersion")]
		[JsonPropertyName("globalVersion")]
		public System.Int32 GlobalVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GlobalVersion", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum RecordPreprocessState
	{
		Preprocessing,
		Success,
		Failed
	}
	public class RecordPreprocessStatus : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String PreprocessId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreprocessId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreprocessId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "recordId")]
		[JsonPropertyName("recordId")]
		public System.String RecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordId", value);
			}
		}

		[JsonProperty(PropertyName = "state")]
		[JsonPropertyName("state")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public RecordPreprocessState State
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(RecordPreprocessState)) is RecordPreprocessState __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordPreprocessState");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		[JsonProperty(PropertyName = "progress")]
		[JsonPropertyName("progress")]
		public System.Single Progress
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Progress"), typeof(System.Single)) is System.Single __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to float");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Progress", value);
			}
		}

		[JsonProperty(PropertyName = "failReason")]
		[JsonPropertyName("failReason")]
		public System.String FailReason
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FailReason"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FailReason", value);
			}
		}

		[JsonProperty(PropertyName = "resultDiffs")]
		[JsonPropertyName("resultDiffs")]
		public List<AssetDiff> ResultDiffs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ResultDiffs"), typeof(List<AssetDiff>)) is List<AssetDiff> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<AssetDiff>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ResultDiffs", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordPreprocessStatus(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum SearchSortParameter
	{
		CreationDate,
		LastUpdateDate,
		FirstPublishTime,
		TotalVisits,
		Name,
		Random
	}
	public enum SearchSortDirection
	{
		Ascending,
		Descending
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class SearchParameters : IEquatable<SearchParameters>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.Boolean _isNormalized
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_isNormalized"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_isNormalized", value);
			}
		}

		[JsonProperty(PropertyName = "count")]
		[JsonPropertyName("count")]
		public System.Int32 Count
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Count", value);
			}
		}

		[JsonProperty(PropertyName = "offset")]
		[JsonPropertyName("offset")]
		public System.Int32 Offset
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Offset"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Offset", value);
			}
		}

		[JsonProperty(PropertyName = "private")]
		[JsonPropertyName("private")]
		public System.Boolean Private
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Private"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Private", value);
			}
		}

		[JsonProperty(PropertyName = "byOwner")]
		[JsonPropertyName("byOwner")]
		public System.String ByOwner
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ByOwner"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ByOwner", value);
			}
		}

		[JsonProperty(PropertyName = "ownerType")]
		[JsonPropertyName("ownerType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public OwnerType OwnerType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerType"), typeof(OwnerType)) is OwnerType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OwnerType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerType", value);
			}
		}

		[JsonProperty(PropertyName = "submittedTo")]
		[JsonPropertyName("submittedTo")]
		public System.String SubmittedTo
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedTo"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubmittedTo", value);
			}
		}

		[JsonProperty(PropertyName = "onlyFeatured")]
		[JsonPropertyName("onlyFeatured")]
		public System.Boolean OnlyFeatured
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyFeatured"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlyFeatured", value);
			}
		}

		[JsonProperty(PropertyName = "recordType")]
		[JsonPropertyName("recordType")]
		public System.String RecordType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordType", value);
			}
		}

		[JsonProperty(PropertyName = "requiredTags")]
		[JsonPropertyName("requiredTags")]
		public List<string> RequiredTags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredTags"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RequiredTags", value);
			}
		}

		[JsonProperty(PropertyName = "optionalTags")]
		[JsonPropertyName("optionalTags")]
		public List<string> OptionalTags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OptionalTags"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OptionalTags", value);
			}
		}

		[JsonProperty(PropertyName = "excludedTags")]
		[JsonPropertyName("excludedTags")]
		public List<string> ExcludedTags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExcludedTags"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExcludedTags", value);
			}
		}

		[JsonProperty(PropertyName = "minDate")]
		[JsonPropertyName("minDate")]
		public DateTime? MinDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MinDate"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MinDate", value);
			}
		}

		[JsonProperty(PropertyName = "maxDate")]
		[JsonPropertyName("maxDate")]
		public DateTime? MaxDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxDate"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxDate", value);
			}
		}

		[JsonProperty(PropertyName = "sortBy")]
		[JsonPropertyName("sortBy")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public SearchSortParameter SortBy
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SortBy"), typeof(SearchSortParameter)) is SearchSortParameter __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SearchSortParameter");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SortBy", value);
			}
		}

		[JsonProperty(PropertyName = "sortDirection")]
		[JsonPropertyName("sortDirection")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public SearchSortDirection SortDirection
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SortDirection"), typeof(SearchSortDirection)) is SearchSortDirection __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SearchSortDirection");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SortDirection", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public List<string> ExtraSignatures
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExtraSignatures"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExtraSignatures", value);
			}
		}

		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public void Normalize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Normalize");
		}

		private List<string> NormalizeTags(List<string> tags)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NormalizeTags", tags), typeof(List<string>)) is List<string> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(SearchParameters other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(SearchParameters other, System.Boolean excludeOffsetAndCount)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other, excludeOffsetAndCount), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private static System.Boolean ListsEqual(List<string> a, List<string> b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "SearchParameters", ResoniteBridge.ResoniteBridgeValueType.Type), "ListsEqual", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static bool operator ==(SearchParameters a, SearchParameters b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "SearchParameters", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(SearchParameters a, SearchParameters b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "SearchParameters", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SearchParameters(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class SearchResults<R> : ResoniteBridge.ResoniteBridgeValueHolder where R : class, IRecord, new()
	{
		[JsonProperty(PropertyName = "records")]
		[JsonPropertyName("records")]
		public List<R> Records
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Records"), typeof(List<R>)) is List<R> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<R>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Records", value);
			}
		}

		[JsonProperty(PropertyName = "hasMoreResults")]
		[JsonPropertyName("hasMoreResults")]
		public System.Boolean HasMoreResults
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasMoreResults"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasMoreResults", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SearchResults(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CheckContactData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "verificationKey")]
		[JsonPropertyName("verificationKey")]
		public System.String VerificationKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VerificationKey"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VerificationKey", value);
			}
		}

		[JsonProperty(PropertyName = "contacts")]
		[JsonPropertyName("contacts")]
		public List<string> Contacts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contacts"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Contacts", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CheckContactData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum VerificationKeyUse
	{
		NONE,
		CheckContact,
		AccessRecord,
		AccessBans
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class OneTimeVerificationKey : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String KeyId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KeyId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "KeyId", value);
			}
		}

		[JsonProperty(PropertyName = "keyUse")]
		[JsonPropertyName("keyUse")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public VerificationKeyUse Use
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Use"), typeof(VerificationKeyUse)) is VerificationKeyUse __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VerificationKeyUse");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Use", value);
			}
		}

		public static System.String GenerateId(System.String baseId = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateId", baseId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidId(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", id), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String GenerateRecordAccessBaseId(System.String accessingOwnerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateRecordAccessBaseId", accessingOwnerId, recordId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public OneTimeVerificationKey(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class RSAParametersData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "Exponent")]
		[JsonPropertyName("Exponent")]
		public byte[] Exponent
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Exponent"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Exponent", value);
			}
		}

		[JsonProperty(PropertyName = "Modulus")]
		[JsonPropertyName("Modulus")]
		public byte[] Modulus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Modulus"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Modulus", value);
			}
		}

		[JsonProperty(PropertyName = "P")]
		[JsonPropertyName("P")]
		public byte[] P
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "P"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "P", value);
			}
		}

		[JsonProperty(PropertyName = "Q")]
		[JsonPropertyName("Q")]
		public byte[] Q
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Q"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Q", value);
			}
		}

		[JsonProperty(PropertyName = "DP")]
		[JsonPropertyName("DP")]
		public byte[] DP
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DP"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DP", value);
			}
		}

		[JsonProperty(PropertyName = "DQ")]
		[JsonPropertyName("DQ")]
		public byte[] DQ
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DQ"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DQ", value);
			}
		}

		[JsonProperty(PropertyName = "InverseQ")]
		[JsonPropertyName("InverseQ")]
		public byte[] InverseQ
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InverseQ"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InverseQ", value);
			}
		}

		[JsonProperty(PropertyName = "D")]
		[JsonPropertyName("D")]
		public byte[] D
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "D"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "D", value);
			}
		}

		public static implicit operator RSAParametersData(RSAParameters rsa)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RSAParametersData", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", rsa), typeof(RSAParametersData)) is RSAParametersData __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RSAParametersData");
			}
		}

		public static implicit operator RSAParameters(RSAParametersData data)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RSAParametersData", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", data), typeof(RSAParameters)) is RSAParameters __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RSAParameters");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RSAParametersData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class TOTP_Key : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public System.String UserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "secretKeyBase32")]
		[JsonPropertyName("secretKeyBase32")]
		public System.String SecretKeyBase32
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretKeyBase32"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretKeyBase32", value);
			}
		}

		[JsonProperty(PropertyName = "recoveryCodes")]
		[JsonPropertyName("recoveryCodes")]
		public List<string> RecoveryCodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecoveryCodes"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecoveryCodes", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public byte[] SecretKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretKey"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretKey", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public TOTP_Key(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ServerStatistics : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "lastUpdate")]
		[JsonPropertyName("lastUpdate")]
		public DateTime LastUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastUpdate"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastUpdate", value);
			}
		}

		[JsonProperty(PropertyName = "responseTimeMilliseconds")]
		[JsonPropertyName("responseTimeMilliseconds")]
		public System.Int64 ResponseTimeMilliseconds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ResponseTimeMilliseconds"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ResponseTimeMilliseconds", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ServerStatistics(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[DataModelType]
	[OldAssembly("SkyFrost.Base")]
	public enum SessionAccessLevel
	{
		Private = 0,
		LAN = 1,
		Contacts = 2,
		ContactsPlus = 3,
		RegisteredUsers = 4,
		Anyone = 5,
		[Obsolete]
		Friends = 2,
		[Obsolete]
		FriendsOfFriends = 3
	}
	public class StatusInitializationResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "contacts")]
		[JsonPropertyName("contacts")]
		public List<Contact> Contacts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contacts"), typeof(List<Contact>)) is List<Contact> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Contact>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Contacts", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StatusInitializationResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum QuotaType
	{
		Base,
		Normal,
		Share,
		Unlimited
	}
	public enum StorageShareLevel
	{
		None,
		Groups,
		GroupsAndUsers
	}
	public class QuotaSource : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int64 MAX_SHARE_BYTES
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_SHARE_BYTES"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_SHARE_BYTES", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public System.Int64 Bytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bytes", value);
			}
		}

		[JsonProperty(PropertyName = "expiresOn")]
		[JsonPropertyName("expiresOn")]
		public DateTime? ExpiresOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpiresOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExpiresOn", value);
			}
		}

		[JsonProperty(PropertyName = "activatesOn")]
		[JsonPropertyName("activatesOn")]
		public DateTime? ActivatesOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActivatesOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActivatesOn", value);
			}
		}

		[JsonProperty(PropertyName = "createdOn")]
		[JsonPropertyName("createdOn")]
		public DateTime CreatedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreatedOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreatedOn", value);
			}
		}

		[JsonProperty(PropertyName = "group")]
		[JsonPropertyName("group")]
		public System.String Group
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Group", value);
			}
		}

		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "type")]
		[JsonPropertyName("type")]
		public QuotaType Type
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(QuotaType)) is QuotaType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to QuotaType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Type", value);
			}
		}

		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "maximumShareLevel")]
		[JsonPropertyName("maximumShareLevel")]
		public StorageShareLevel MaximumShareLevel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaximumShareLevel"), typeof(StorageShareLevel)) is StorageShareLevel __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to StorageShareLevel");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaximumShareLevel", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsExpired
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsExpired"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsActive
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsActive"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean IsActiveAtTime(DateTime timePoint)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsActiveAtTime", timePoint), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean IsExpiredAtTime(DateTime timePoint)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsExpiredAtTime", timePoint), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Overrides(QuotaSource otherSource)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Overrides", otherSource), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public QuotaSource(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class QuotaShare : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "targetOwnerId")]
		[JsonPropertyName("targetOwnerId")]
		public System.String TargetOwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetOwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TargetOwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "shareRatio")]
		[JsonPropertyName("shareRatio")]
		public System.Single ShareRatio
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShareRatio"), typeof(System.Single)) is System.Single __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to float");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShareRatio", value);
			}
		}

		[JsonProperty(PropertyName = "maxShareBytes")]
		[JsonPropertyName("maxShareBytes")]
		public System.Int64 MaxShareBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxShareBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxShareBytes", value);
			}
		}

		[JsonProperty(PropertyName = "currentShareBytes")]
		[JsonPropertyName("currentShareBytes")]
		public System.Int64 CurrentShareBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentShareBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentShareBytes", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public QuotaShare(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class Storage : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public System.Int64 UsedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsedBytes", value);
			}
		}

		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public System.Int64 QuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QuotaBytes", value);
			}
		}

		[JsonProperty(PropertyName = "fullQuotaBytes")]
		[JsonPropertyName("fullQuotaBytes")]
		public System.Int64 FullQuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FullQuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FullQuotaBytes", value);
			}
		}

		[JsonProperty(PropertyName = "shareableQuotaBytes")]
		[JsonPropertyName("shareableQuotaBytes")]
		public System.Int64 ShareableQuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShareableQuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShareableQuotaBytes", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Int64 SharedQuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SharedQuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		[JsonProperty(PropertyName = "quotaSources")]
		[JsonPropertyName("quotaSources")]
		public List<QuotaSource> QuotaSources
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaSources"), typeof(List<QuotaSource>)) is List<QuotaSource> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<QuotaSource>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QuotaSources", value);
			}
		}

		[JsonProperty(PropertyName = "quotaShares")]
		[JsonPropertyName("quotaShares")]
		public List<QuotaShare> QuotaShares
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaShares"), typeof(List<QuotaShare>)) is List<QuotaShare> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<QuotaShare>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QuotaShares", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Storage(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[Serializable]
	public class Submission : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String GroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "targetRecordId")]
		[JsonPropertyName("targetRecordId")]
		public RecordId TargetRecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRecordId"), typeof(RecordId)) is RecordId __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordId");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TargetRecordId", value);
			}
		}

		[JsonProperty(PropertyName = "submissionTime")]
		[JsonPropertyName("submissionTime")]
		public DateTime SubmissionTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmissionTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubmissionTime", value);
			}
		}

		[JsonProperty(PropertyName = "submittedById")]
		[JsonPropertyName("submittedById")]
		public System.String SubmittedById
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedById"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubmittedById", value);
			}
		}

		[JsonProperty(PropertyName = "submittedByName")]
		[JsonPropertyName("submittedByName")]
		public System.String SubmittedByName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedByName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubmittedByName", value);
			}
		}

		[JsonProperty(PropertyName = "featured")]
		[JsonPropertyName("featured")]
		public System.Boolean Featured
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Featured"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Featured", value);
			}
		}

		[JsonProperty(PropertyName = "featuredByUserId")]
		[JsonPropertyName("featuredByUserId")]
		public System.String FeaturedByUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FeaturedByUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FeaturedByUserId", value);
			}
		}

		[JsonProperty(PropertyName = "featuredTimestamp")]
		[JsonPropertyName("featuredTimestamp")]
		public DateTime? FeaturedTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FeaturedTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FeaturedTimestamp", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Submission(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ThumbnailInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "timestamp")]
		[JsonPropertyName("timestamp")]
		public DateTimeOffset Timestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Timestamp", value);
			}
		}

		[JsonProperty(PropertyName = "uploaderIP", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("uploaderIP")]
		public System.String UploaderIP
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderIP"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploaderIP", value);
			}
		}

		[JsonProperty(PropertyName = "sessionId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("sessionId")]
		public System.String SessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionId", value);
			}
		}

		[JsonProperty(PropertyName = "uploaderOwnerId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("uploaderOwnerId")]
		public System.String UploaderOwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderOwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploaderOwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "signature")]
		[JsonPropertyName("signature")]
		public System.String Signature
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Signature"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Signature", value);
			}
		}

		[JsonProperty(PropertyName = "uploadEndpoint")]
		[JsonPropertyName("uploadEndpoint")]
		public System.String UploadEndpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadEndpoint", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.String SignatureDataString
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SignatureDataString"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public byte[] SignatureData
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SignatureData"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
		}

		public static System.String GenerateID()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "ThumbnailInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateID"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public void Sign(RSAParameters key)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Sign", key);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ThumbnailInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class Universe : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "primaryGroupId")]
		[JsonPropertyName("primaryGroupId")]
		public System.String PrimaryGroupId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrimaryGroupId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrimaryGroupId", value);
			}
		}

		public System.Boolean IsPrimaryGroup(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPrimaryGroup", groupId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetBaseUri(IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBaseUri", platform), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetBaseInventoryUri(IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBaseInventoryUri", platform), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetSpawnObjectUri(System.String itemPath, IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSpawnObjectUri", itemPath, platform), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetRecordAtPath(System.String recordPath, IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAtPath", recordPath, platform), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Universe(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum SessionLoginType
	{
		UNKNOWN,
		Password,
		Saml2,
		Migration
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[SensitiveEntity]
	public class UserSession : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public System.String UserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "token")]
		[JsonPropertyName("token")]
		public System.String SessionToken
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionToken"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionToken", value);
			}
		}

		[JsonProperty(PropertyName = "created")]
		[JsonPropertyName("created")]
		public DateTime SessionCreated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionCreated"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionCreated", value);
			}
		}

		[JsonProperty(PropertyName = "expire")]
		[JsonPropertyName("expire")]
		public DateTime SessionExpire
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionExpire"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionExpire", value);
			}
		}

		[NullOnExternal]
		[JsonProperty(PropertyName = "secretMachineIdHash")]
		[JsonPropertyName("secretMachineIdHash")]
		public System.String SecretMachineIdHash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineIdHash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretMachineIdHash", value);
			}
		}

		[NullOnExternal]
		[JsonProperty(PropertyName = "secretMachineIdSalt")]
		[JsonPropertyName("secretMachineIdSalt")]
		public System.String SecretMachineIdSalt
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineIdSalt"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretMachineIdSalt", value);
			}
		}

		[JsonProperty(PropertyName = "uidHash")]
		[JsonPropertyName("uidHash")]
		public System.String UID_Hash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID_Hash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UID_Hash", value);
			}
		}

		[JsonProperty(PropertyName = "uidSalt")]
		[JsonPropertyName("uidSalt")]
		public System.String UID_Salt
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID_Salt"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UID_Salt", value);
			}
		}

		[JsonProperty(PropertyName = "rememberMe")]
		[JsonPropertyName("rememberMe")]
		public System.Boolean RememberMe
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RememberMe"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RememberMe", value);
			}
		}

		[JsonProperty(PropertyName = "isMachineBound")]
		[JsonPropertyName("isMachineBound")]
		public System.Boolean IsMachineBound
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMachineBound"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMachineBound", value);
			}
		}

		[JsonProperty("logoutUrl")]
		[JsonPropertyName("logoutUrl")]
		public System.String LogoutUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LogoutUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LogoutUrl", value);
			}
		}

		[JsonProperty("logoutUrlClientSide")]
		[JsonPropertyName("logoutUrlClientSide")]
		public System.Boolean LogoutUrlClientSide
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LogoutUrlClientSide"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LogoutUrlClientSide", value);
			}
		}

		[JsonProperty(PropertyName = "originalLoginType")]
		[JsonPropertyName("originalLoginType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public SessionLoginType OriginalLoginType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalLoginType"), typeof(SessionLoginType)) is SessionLoginType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SessionLoginType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalLoginType", value);
			}
		}

		[JsonProperty(PropertyName = "sessionLoginCounter")]
		[JsonPropertyName("sessionLoginCounter")]
		public System.Int32 SessionLoginCounter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionLoginCounter"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionLoginCounter", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsExpired
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsExpired"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UserSession(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[SensitiveEntity]
	public class UserSessionResult<T> : ISanitizableCollection, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "entity")]
		[JsonPropertyName("entity")]
		public T Entity
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Entity"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Entity", value);
			}
		}

		[JsonProperty(PropertyName = "configFiles")]
		[JsonPropertyName("configFiles")]
		public List<ConfigFileData> ConfigFiles
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigFiles"), typeof(List<ConfigFileData>)) is List<ConfigFileData> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ConfigFileData>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigFiles", value);
			}
		}

		public IEnumerable EntitiesToSanitize()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EntitiesToSanitize"), typeof(IEnumerable)) is IEnumerable __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UserSessionResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum BroadcastGroup
	{
		Public,
		AllContacts,
		SpecificContacts,
		BroadcastKey,
		ConnectionIds
	}
	public class BroadcastTarget : IEquatable<BroadcastTarget>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static BroadcastTarget PUBLIC
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "PUBLIC"), typeof(BroadcastTarget)) is BroadcastTarget __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BroadcastTarget");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "PUBLIC", value);
			}
		}

		public static BroadcastTarget ALL_CONTACTS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "ALL_CONTACTS"), typeof(BroadcastTarget)) is BroadcastTarget __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BroadcastTarget");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "ALL_CONTACTS", value);
			}
		}

		[JsonProperty(PropertyName = "group")]
		[JsonPropertyName("group")]
		public BroadcastGroup Group
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(BroadcastGroup)) is BroadcastGroup __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BroadcastGroup");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Group", value);
			}
		}

		[JsonProperty(PropertyName = "targetIds")]
		[JsonPropertyName("targetIds")]
		public List<string> TargetIds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetIds"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TargetIds", value);
			}
		}

		public static BroadcastTarget ToContact(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "ToContact", userId), typeof(BroadcastTarget)) is BroadcastTarget __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean RequiresTargetIds(BroadcastGroup group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresTargetIds", group), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Equals(BroadcastTarget other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Int32 GetHashCode()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static bool operator ==(BroadcastTarget a, BroadcastTarget b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(BroadcastTarget a, BroadcastTarget b)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", a, b), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BroadcastTarget(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class LegacyPatreonSnapshot : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "totalCents")]
		[JsonPropertyName("totalCents")]
		public System.Int32 TotalCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalCents", value);
			}
		}

		[JsonProperty(PropertyName = "patreonRawCents")]
		[JsonPropertyName("patreonRawCents")]
		public System.Int32 PatreonRawCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonRawCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatreonRawCents", value);
			}
		}

		[JsonProperty(PropertyName = "deltaCents")]
		[JsonPropertyName("deltaCents")]
		public System.Int32 DeltaCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DeltaCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DeltaCents", value);
			}
		}

		[JsonProperty(PropertyName = "pledgeCents")]
		[JsonPropertyName("pledgeCents")]
		public System.Int32 PledgeCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PledgeCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PledgeCents", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonProperty(PropertyName = "timestamp")]
		[JsonPropertyName("timestamp")]
		public DateTime Timestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Timestamp", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LegacyPatreonSnapshot(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class LegacyUserPatreonData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[NullOnExternal]
		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[NullOnExternal]
		[JsonProperty(PropertyName = "lastPatreonEmail")]
		[JsonPropertyName("lastPatreonEmail")]
		public System.String LastPatreonEmail
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPatreonEmail"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastPatreonEmail", value);
			}
		}

		[JsonProperty(PropertyName = "isPatreonSupporter")]
		[JsonPropertyName("isPatreonSupporter")]
		public System.Boolean IsPatreonSupporter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPatreonSupporter"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPatreonSupporter", value);
			}
		}

		[JsonProperty(PropertyName = "patreonId")]
		[JsonPropertyName("patreonId")]
		public System.String PatreonID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatreonID", value);
			}
		}

		[JsonProperty(PropertyName = "lastPatreonPledgeCents")]
		[JsonPropertyName("lastPatreonPledgeCents")]
		public System.Int32 LastPatreonPledgeCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPatreonPledgeCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastPatreonPledgeCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastTotalCents")]
		[JsonPropertyName("lastTotalCents")]
		public System.Int32 LastTotalCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTotalCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastTotalCents", value);
			}
		}

		[JsonProperty(PropertyName = "minimumTotalUnits")]
		[JsonPropertyName("minimumTotalUnits")]
		public System.Int32 MinimumTotalUnits
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MinimumTotalUnits"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MinimumTotalUnits", value);
			}
		}

		[JsonProperty(PropertyName = "externalCents")]
		[JsonPropertyName("externalCents")]
		public System.Int32 ExternalCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExternalCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExternalCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastExternalCents")]
		[JsonPropertyName("lastExternalCents")]
		public System.Int32 LastExternalCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastExternalCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastExternalCents", value);
			}
		}

		[JsonProperty(PropertyName = "hasSupported")]
		[JsonPropertyName("hasSupported")]
		public System.Boolean HasSupported
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasSupported"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasSupported", value);
			}
		}

		[JsonProperty(PropertyName = "rewardType")]
		[JsonPropertyName("rewardType")]
		public System.String RewardType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RewardType"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RewardType", value);
			}
		}

		[JsonProperty(PropertyName = "customTier")]
		[JsonPropertyName("customTier")]
		public System.String CustomTier
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomTier"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomTier", value);
			}
		}

		[JsonProperty(PropertyName = "priorityIssue")]
		[JsonPropertyName("priorityIssue")]
		public System.Int32 PriorityIssue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PriorityIssue"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PriorityIssue", value);
			}
		}

		[JsonProperty(PropertyName = "lastActivationTime")]
		[JsonPropertyName("lastActivationTime")]
		public DateTime LastActivationTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastActivationTime"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastActivationTime", value);
			}
		}

		[JsonProperty(PropertyName = "lastPaidPledgeAmount")]
		[JsonPropertyName("lastPaidPledgeAmount")]
		public System.Int32 LastPaidPledgeAmount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPaidPledgeAmount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastPaidPledgeAmount", value);
			}
		}

		[NullOnExternal]
		[JsonProperty(PropertyName = "snapshots")]
		[JsonPropertyName("snapshots")]
		public List<LegacyPatreonSnapshot> Snapshots
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Snapshots"), typeof(List<LegacyPatreonSnapshot>)) is List<LegacyPatreonSnapshot> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<LegacyPatreonSnapshot>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Snapshots", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LegacyUserPatreonData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class LoginCredentials : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public System.String Username
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonProperty(PropertyName = "authentication")]
		[JsonPropertyName("authentication")]
		public LoginAuthentication Authentication
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Authentication"), typeof(LoginAuthentication)) is LoginAuthentication __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LoginAuthentication");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Authentication", value);
			}
		}

		[JsonProperty(PropertyName = "secretMachineId")]
		[JsonPropertyName("secretMachineId")]
		public System.String SecretMachineId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretMachineId", value);
			}
		}

		[JsonProperty(PropertyName = "rememberMe")]
		[JsonPropertyName("rememberMe")]
		public System.Boolean RememberMe
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RememberMe"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RememberMe", value);
			}
		}

		[JsonProperty(PropertyName = "machineBound")]
		[JsonPropertyName("machineBound")]
		public System.Boolean MachineBound
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MachineBound"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MachineBound", value);
			}
		}

		public void Preprocess()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Preprocess");
		}

		public static LoginCredentials FromCredentialAuto(System.String credential, LoginAuthentication authentication)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "LoginCredentials", ResoniteBridge.ResoniteBridgeValueType.Type), "FromCredentialAuto", credential, authentication), typeof(LoginCredentials)) is LoginCredentials __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LoginCredentials(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonDerivedType(typeof(PasswordLogin), "password")]
	[JsonDerivedType(typeof(SessionTokenLogin), "sessionToken")]
	public abstract class LoginAuthentication : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public abstract System.Boolean IsValidForLogin { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		public abstract System.Boolean IsValidForRegistration { get; }

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LoginAuthentication()
		{
		}
	}
	public class PasswordLogin : LoginAuthentication, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public override System.Boolean IsValidForRegistration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValidForRegistration"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override System.Boolean IsValidForLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValidForLogin"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[JsonProperty(PropertyName = "password", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("password")]
		public System.String Password
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Password", value);
			}
		}

		[JsonPropertyName("recoveryCode")]
		public System.String RecoveryCode
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecoveryCode"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecoveryCode", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public PasswordLogin(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SessionTokenLogin : LoginAuthentication, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.Boolean IsValidForLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValidForLogin"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public override System.Boolean IsValidForRegistration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValidForRegistration"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[JsonProperty(PropertyName = "sessionToken", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("sessionToken")]
		public System.String SessionToken
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionToken"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionToken", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SessionTokenLogin(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class MigratedUserData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public System.String Username
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public System.String UserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public System.Int64 QuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QuotaBytes", value);
			}
		}

		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public System.Int64 UsedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsedBytes", value);
			}
		}

		[JsonProperty(PropertyName = "quotaBytesSources")]
		[JsonPropertyName("quotaBytesSources")]
		public Dictionary<string, long> QuotaBytesSources
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytesSources"), typeof(Dictionary<string, long>)) is Dictionary<string, long> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, long>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QuotaBytesSources", value);
			}
		}

		[JsonProperty(PropertyName = "registrationDate")]
		[JsonPropertyName("registrationDate")]
		public DateTime RegistrationDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RegistrationDate"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RegistrationDate", value);
			}
		}

		[JsonProperty(PropertyName = "patreonData")]
		[JsonPropertyName("patreonData")]
		public LegacyUserPatreonData PatreonData
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonData"), typeof(LegacyUserPatreonData)) is LegacyUserPatreonData __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LegacyUserPatreonData");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatreonData", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MigratedUserData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[DataModelType]
	[OldAssembly("SkyFrost.Base")]
	public enum OnlineStatus
	{
		Offline,
		Invisible,
		Away,
		Busy,
		Online,
		Sociable
	}
	public enum BadgeType
	{
		Static2D,
		Model
	}
	public class BadgeDefinition : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "enabled")]
		[JsonPropertyName("enabled")]
		public System.Boolean Enabled
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Enabled"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Enabled", value);
			}
		}

		[JsonProperty(PropertyName = "assetURL")]
		[JsonPropertyName("assetURL")]
		public System.String AssetURL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURL"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetURL", value);
			}
		}

		[JsonProperty(PropertyName = "badgeType")]
		[JsonPropertyName("badgeType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BadgeType BadgeType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BadgeType"), typeof(BadgeType)) is BadgeType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BadgeType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BadgeType", value);
			}
		}

		[JsonProperty(PropertyName = "pointFiltering")]
		[JsonPropertyName("pointFiltering")]
		public bool? PointFiltering
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PointFiltering"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PointFiltering", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public MultiLanguageValue<string> Name
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(MultiLanguageValue<string>)) is MultiLanguageValue<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MultiLanguageValue<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public MultiLanguageValue<string> Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>)) is MultiLanguageValue<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MultiLanguageValue<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BadgeDefinition(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class UserProfile : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_DISPLAY_BADGES
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_DISPLAY_BADGES"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_DISPLAY_BADGES", value);
			}
		}

		[JsonProperty(PropertyName = "iconUrl")]
		[JsonPropertyName("iconUrl")]
		public System.String IconUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IconUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IconUrl", value);
			}
		}

		[JsonProperty(PropertyName = "tagline")]
		[JsonPropertyName("tagline")]
		public System.String Tagline
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tagline"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Tagline", value);
			}
		}

		[JsonProperty(PropertyName = "displayBadges")]
		[JsonPropertyName("displayBadges")]
		public List<EntityId> DisplayBadges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisplayBadges"), typeof(List<EntityId>)) is List<EntityId> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<EntityId>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisplayBadges", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public System.String Description
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		public System.Boolean IsValid(IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValid", platform), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UserProfile(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class RegistrationRequest : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public System.String Username
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonProperty(PropertyName = "dateOfBirth")]
		[JsonPropertyName("dateOfBirth")]
		public DateTimeOffset DateOfBirth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DateOfBirth"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DateOfBirth", value);
			}
		}

		[JsonProperty(PropertyName = "password")]
		[JsonPropertyName("password")]
		public PasswordLogin Password
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(PasswordLogin)) is PasswordLogin __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PasswordLogin");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Password", value);
			}
		}

		[JsonProperty(PropertyName = "migrationCredentials")]
		[JsonPropertyName("migrationCredentials")]
		public LoginCredentials MigrationCredentials
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationCredentials"), typeof(LoginCredentials)) is LoginCredentials __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LoginCredentials");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationCredentials", value);
			}
		}

		[JsonProperty(PropertyName = "generateNewUserId")]
		[JsonPropertyName("generateNewUserId")]
		public System.Boolean GenerateNewUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GenerateNewUserId"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GenerateNewUserId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsEmailValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEmailValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsDateOfBirthValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDateOfBirthValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public void Preprocess()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Preprocess");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RegistrationRequest(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class PatreonSupporter : SupporterMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "isActiveSupporter")]
		[JsonPropertyName("isActiveSupporter")]
		public System.Boolean IsActiveSupporter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsActiveSupporter"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsActiveSupporter", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportMonths")]
		[JsonPropertyName("totalSupportMonths")]
		public System.Int32 TotalSupportMonths
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportMonths"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportMonths", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportCents")]
		[JsonPropertyName("totalSupportCents")]
		public System.Int32 TotalSupportCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastTierCents")]
		[JsonPropertyName("lastTierCents")]
		public System.Int32 LastTierCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTierCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "highestTierCents")]
		[JsonPropertyName("highestTierCents")]
		public System.Int32 HighestTierCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HighestTierCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HighestTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "lowestTierCents")]
		[JsonPropertyName("lowestTierCents")]
		public System.Int32 LowestTierCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LowestTierCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LowestTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "firstSupportTimestamp")]
		[JsonPropertyName("firstSupportTimestamp")]
		public DateTime FirstSupportTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FirstSupportTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FirstSupportTimestamp", value);
			}
		}

		[JsonProperty(PropertyName = "lastSupportTimestamp")]
		[JsonPropertyName("lastSupportTimestamp")]
		public DateTime LastSupportTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastSupportTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastSupportTimestamp", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsSupporter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSupporter"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override System.Int32 Priority
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Priority"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override LocaleString AccountNameOverride
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccountNameOverride"), typeof(LocaleString)) is LocaleString __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LocaleString");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override colorX? AccountNameColorOverride
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccountNameColorOverride"), typeof(colorX)) is colorX __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to colorX");
				}
			}
		}

		public override void Sanitize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Sanitize");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public PatreonSupporter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class StripeSupporter : SupporterMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "isActiveSupporter")]
		[JsonPropertyName("isActiveSupporter")]
		public System.Boolean IsActiveSupporter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsActiveSupporter"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsActiveSupporter", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportMonths")]
		[JsonPropertyName("totalSupportMonths")]
		public System.Int32 TotalSupportMonths
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportMonths"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportMonths", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportCents")]
		[JsonPropertyName("totalSupportCents")]
		public System.Int32 TotalSupportCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastTierCents")]
		[JsonPropertyName("lastTierCents")]
		public System.Int32 LastTierCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTierCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "highestTierCents")]
		[JsonPropertyName("highestTierCents")]
		public System.Int32 HighestTierCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HighestTierCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HighestTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "lowestTierCents")]
		[JsonPropertyName("lowestTierCents")]
		public System.Int32 LowestTierCents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LowestTierCents"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LowestTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "firstSupportTimestamp")]
		[JsonPropertyName("firstSupportTimestamp")]
		public DateTime FirstSupportTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FirstSupportTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FirstSupportTimestamp", value);
			}
		}

		[JsonProperty(PropertyName = "lastSupportTimestamp")]
		[JsonPropertyName("lastSupportTimestamp")]
		public DateTime LastSupportTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastSupportTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastSupportTimestamp", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsSupporter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSupporter"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override System.Int32 Priority
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Priority"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override LocaleString AccountNameOverride
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccountNameOverride"), typeof(LocaleString)) is LocaleString __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LocaleString");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override colorX? AccountNameColorOverride
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccountNameColorOverride"), typeof(colorX)) is colorX __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to colorX");
				}
			}
		}

		public override void Sanitize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Sanitize");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StripeSupporter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonDerivedType(typeof(PatreonSupporter), "patreon")]
	[JsonDerivedType(typeof(StripeSupporter), "stripe")]
	public abstract class SupporterMetadata : IComparable<SupporterMetadata>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract LocaleString AccountNameOverride { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract colorX? AccountNameColorOverride { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract System.Int32 Priority { get; }

		public abstract void Sanitize();

		public System.Int32 CompareTo(SupporterMetadata other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompareTo", other), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SupporterMetadata()
		{
		}
	}
	public enum BanType
	{
		PublicSoft,
		PublicStandard,
		PublicHard,
		Mute,
		Spectator,
		Account,
		Listing
	}
	public enum PublicBanType
	{
		Standard,
		Soft,
		Hard
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class OldCredential : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "credential")]
		[JsonPropertyName("credential")]
		public System.String Credential
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Credential"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Credential", value);
			}
		}

		[JsonProperty(PropertyName = "changedOn")]
		[JsonPropertyName("changedOn")]
		public DateTime ChangedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangedOn"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangedOn", value);
			}
		}

		[JsonProperty(PropertyName = "changeSource")]
		[JsonPropertyName("changeSource")]
		public System.String ChangeSource
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeSource"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChangeSource", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public OldCredential(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class User : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_USERNAME_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_USERNAME_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_USERNAME_LENGTH", value);
			}
		}

		public System.Int32 MINIMUM_USER_AGE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MINIMUM_USER_AGE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MINIMUM_USER_AGE", value);
			}
		}

		public System.Int32 MAXIMUM_USER_AGE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAXIMUM_USER_AGE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAXIMUM_USER_AGE", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public System.String Username
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "alternateNormalizedNames")]
		[JsonPropertyName("alternateNormalizedNames")]
		public List<string> AlternateNormalizedNames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateNormalizedNames"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AlternateNormalizedNames", value);
			}
		}

		[JsonProperty(PropertyName = "email", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("email")]
		public System.String Email
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonProperty(PropertyName = "alternateEmails", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("alternateEmails")]
		public HashSet<string> AlternateEmails
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateEmails"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AlternateEmails", value);
			}
		}

		[JsonProperty(PropertyName = "oldUsernames")]
		[JsonPropertyName("oldUsernames")]
		public List<OldCredential> OldUsernames
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OldUsernames"), typeof(List<OldCredential>)) is List<OldCredential> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OldCredential>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OldUsernames", value);
			}
		}

		[JsonProperty(PropertyName = "oldEmails")]
		[JsonPropertyName("oldEmails")]
		public List<OldCredential> OldEmails
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OldEmails"), typeof(List<OldCredential>)) is List<OldCredential> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<OldCredential>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OldEmails", value);
			}
		}

		[JsonProperty(PropertyName = "dateOfBirth")]
		[JsonPropertyName("dateOfBirth")]
		public DateTimeOffset? DateOfBirth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DateOfBirth"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTimeOffset");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DateOfBirth", value);
			}
		}

		[JsonProperty(PropertyName = "registrationDate")]
		[JsonPropertyName("registrationDate")]
		public DateTime RegistrationDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RegistrationDate"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RegistrationDate", value);
			}
		}

		[JsonProperty(PropertyName = "isVerified")]
		[JsonPropertyName("isVerified")]
		public System.Boolean IsVerified
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsVerified"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsVerified", value);
			}
		}

		[JsonProperty(PropertyName = "accountBanExpiration")]
		[JsonPropertyName("accountBanExpiration")]
		public DateTime? AccountBanExpiration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccountBanExpiration"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AccountBanExpiration", value);
			}
		}

		[JsonProperty(PropertyName = "publicBanExpiration")]
		[JsonPropertyName("publicBanExpiration")]
		public DateTime? PublicBanExpiration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicBanExpiration"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicBanExpiration", value);
			}
		}

		[JsonProperty(PropertyName = "publicBanType")]
		[JsonPropertyName("publicBanType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public PublicBanType? PublicBanType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicBanType"), typeof(PublicBanType)) is PublicBanType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to PublicBanType");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicBanType", value);
			}
		}

		[JsonProperty(PropertyName = "spectatorBanExpiration")]
		[JsonPropertyName("spectatorBanExpiration")]
		public DateTime? SpectatorBanExpiration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SpectatorBanExpiration"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SpectatorBanExpiration", value);
			}
		}

		[JsonProperty(PropertyName = "muteBanExpiration")]
		[JsonPropertyName("muteBanExpiration")]
		public DateTime? MuteBanExpiration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MuteBanExpiration"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MuteBanExpiration", value);
			}
		}

		[JsonProperty(PropertyName = "listingBanExpiration")]
		[JsonPropertyName("listingBanExpiration")]
		public DateTime? ListingBanExpiration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListingBanExpiration"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ListingBanExpiration", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsAccountBanned
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAccountBanned"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsPublicBanned
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPublicBanned"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsSpectatorBanned
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSpectatorBanned"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsMuteBanned
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMuteBanned"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsListingBanned
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListingBanned"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		[JsonProperty(PropertyName = "uniqueDeviceIDs", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("uniqueDeviceIDs")]
		public List<string> UniqueDeviceIDs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniqueDeviceIDs"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UniqueDeviceIDs", value);
			}
		}

		[JsonProperty(PropertyName = "tags")]
		[JsonPropertyName("tags")]
		public List<string> Tags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tags"), typeof(List<string>)) is List<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "referrerUserId")]
		[JsonPropertyName("referrerUserId")]
		public System.String ReferrerUserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferrerUserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReferrerUserId", value);
			}
		}

		[JsonProperty(PropertyName = "profile")]
		[JsonPropertyName("profile")]
		public UserProfile Profile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Profile"), typeof(UserProfile)) is UserProfile __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserProfile");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Profile", value);
			}
		}

		[JsonProperty(PropertyName = "supporterMetadata")]
		[JsonPropertyName("supporterMetadata")]
		public List<SupporterMetadata> SupporterMetadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupporterMetadata"), typeof(List<SupporterMetadata>)) is List<SupporterMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<SupporterMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupporterMetadata", value);
			}
		}

		[JsonProperty(PropertyName = "entitlements")]
		[JsonPropertyName("entitlements")]
		public List<Entitlement> Entitlements
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Entitlements"), typeof(List<Entitlement>)) is List<Entitlement> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Entitlement>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Entitlements", value);
			}
		}

		[NullOnExternal]
		[JsonProperty(PropertyName = "migrationCredentials")]
		[JsonPropertyName("migrationCredentials")]
		public LoginCredentials MigrationCredentials
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationCredentials"), typeof(LoginCredentials)) is LoginCredentials __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LoginCredentials");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationCredentials", value);
			}
		}

		[JsonProperty(PropertyName = "migratedData")]
		[JsonPropertyName("migratedData")]
		public MigratedUserData MigratedData
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedData"), typeof(MigratedUserData)) is MigratedUserData __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MigratedUserData");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedData", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime EarliestRegistrationDate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EarliestRegistrationDate"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "patreonData")]
		[JsonPropertyName("patreonData")]
		public LegacyUserPatreonData LegacyPatreonData
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyPatreonData"), typeof(LegacyUserPatreonData)) is LegacyUserPatreonData __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LegacyUserPatreonData");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyPatreonData", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public long? LegacyQuotaBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public long? LegacyUsedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyUsedBytes", value);
			}
		}

		[Obsolete]
		[NullOnExternal]
		[JsonProperty(PropertyName = "quotaBytesSources")]
		[JsonPropertyName("quotaBytesSources")]
		public Dictionary<string, long> LegacyQuotaBytesSources
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytesSources"), typeof(Dictionary<string, long>)) is Dictionary<string, long> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, long>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytesSources", value);
			}
		}

		public static System.String BasicValidateUsername(System.String username)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "User", ResoniteBridge.ResoniteBridgeValueType.Type), "BasicValidateUsername", username), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsDateOfBirthValid(DateTimeOffset? date)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "User", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDateOfBirthValid", date), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean HasTag(System.String tag)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasTag", tag), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean HasEntitlement<T>(Predicate<T> filter = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasEntitlement", filter), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean IsSupporter<T>(Predicate<T> filter = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsSupporter", filter), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public User(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum UserSessionType
	{
		Unknown,
		GraphicalClient,
		ChatClient,
		Headless,
		Bot
	}
	public static class UserTags
	{
		public static string[] Rankings
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Rankings"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Rankings", value);
			}
		}

		public static string[] MMC21_Categories
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Categories"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Categories", value);
			}
		}

		public static string[][] MMC21_Subcategories
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Subcategories"), typeof(string[][])) is string[][] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[][]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Subcategories", value);
			}
		}

		public static string[] MMC21_WorldSubCat
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_WorldSubCat"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_WorldSubCat", value);
			}
		}

		public static string[] MMC21_AvatarSubCat
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_AvatarSubCat"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_AvatarSubCat", value);
			}
		}

		public static string[] MMC21_OtherSubCat
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_OtherSubCat"), typeof(string[])) is string[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_OtherSubCat", value);
			}
		}

		public static Dictionary<string, string> EventTags
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "EventTags"), typeof(Dictionary<string, string>)) is Dictionary<string, string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "EventTags", value);
			}
		}

		public static System.String Team
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Team"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Business
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Business"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Admin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Admin"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Moderator
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Moderator"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String ModerationLead
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ModerationLead"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Developer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Developer"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Mentor
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Mentor"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Translator
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Translator"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MentorLead
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MentorLead"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String HTC_Vive
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "HTC_Vive"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String DiagnoseRecordSync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "DiagnoseRecordSync"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String HearingImpaired
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "HearingImpaired"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VisuallyImpaired
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VisuallyImpaired"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String ColorBlind
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ColorBlind"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Mute
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Mute"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Potato
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Potato"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String DurianTester
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "DurianTester"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String FoundingSupporter
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "FoundingSupporter"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String FirstPlace
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "FirstPlace"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String SecondPlace
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "SecondPlace"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String ThirdPlace
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ThirdPlace"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC_Cow
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC_Cow"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC_Lips
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC_Lips"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC_World
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC_World"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC_Avatar
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC_Avatar"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC_Other
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC_Other"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VBLFC
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VBLFC"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VFE22
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VFE22"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Festa3
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Festa3"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Festa3Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Festa3Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Festa4Ambassador
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Festa4Ambassador"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Festa4Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Festa4Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String UniFesta2023
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "UniFesta2023"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_Smile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Smile"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_Mouth
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Mouth"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_GrillCheeze
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_GrillCheeze"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_World
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_World"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_Avatar
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Avatar"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_Other
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Other"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_Meme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Meme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_WorldSocial
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_WorldSocial"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_WorldGame
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_WorldGame"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_WorldMisc
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_WorldMisc"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_AvatarAvatars
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_AvatarAvatars"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_AvatarAccessories
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_AvatarAccessories"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_AvatarMisc
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_AvatarMisc"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_OtherTAU
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_OtherTAU"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC21_OtherMisc
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_OtherMisc"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_HonorableMention
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_HonorableMention"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_World
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_World"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_Avatar
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_Avatar"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_Art
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_Art"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_ESD
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_ESD"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_Meme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_Meme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_Other
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_Other"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_CheeseCoin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_CheeseCoin"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_LitaLita
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_LitaLita"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC22_HolyWater
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC22_HolyWater"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_HonorableMention
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_HonorableMention"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_Gifty
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_Gifty"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_World
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_World"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_Avatar
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_Avatar"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_Art
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_Art"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_ESD
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_ESD"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_Other
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_Other"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_Meme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_Meme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_Prime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_Prime"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_LitaLita
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_LitaLita"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC23_HolyWater
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC23_HolyWater"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_HonorableMention
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_HonorableMention"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Gifty
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Gifty"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_World
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_World"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Avatar
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Avatar"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Art
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Art"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_ESD
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_ESD"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Other
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Other"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Meme
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Meme"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Narrative
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Narrative"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Prime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Prime"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Froox
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Froox"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_HolyWater
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_HolyWater"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MMC24_Litalita
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC24_Litalita"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Halloween24_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Halloween24_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Halloween24_Winner
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Halloween24_Winner"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VKet24_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VKet24_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String UniFesta24_Participant
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "UniFesta24_Participant"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String UniFesta24_Ambassador
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "UniFesta24_Ambassador"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String CustomBadge(System.String dbSignature, System.Boolean pointFiltering)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CustomBadge", dbSignature, pointFiltering), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String GetCustom3DBadge(System.String badge)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCustom3DBadge", badge), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String ComposeMMC21(System.String baseCategory, System.String subcategory, System.Int32 place)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ComposeMMC21", baseCategory, subcategory, place), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	public delegate(bool, object) CloudVariableParser(System.String value);
	public enum VariablePermissionType
	{
		Read,
		Write,
		List
	}
	public static class CloudVariableHelper
	{
		public static System.Int32 MAX_SUBPATH_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_SUBPATH_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_SUBPATH_LENGTH", value);
			}
		}

		public static System.Int32 MAX_STRING_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_STRING_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_STRING_LENGTH", value);
			}
		}

		public static System.Int32 DEFAULT_MAX_STRING_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MAX_STRING_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MAX_STRING_LENGTH", value);
			}
		}

		public static System.Int32 MAX_URI_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_URI_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_URI_LENGTH", value);
			}
		}

		public static System.Int32 MAX_VARIABLES_PER_USER
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_USER"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_USER", value);
			}
		}

		public static System.Int32 MAX_VARIABLES_PER_GROUP
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_GROUP"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_GROUP", value);
			}
		}

		public static System.Char DELIMITER
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DELIMITER"), typeof(System.Char)) is System.Char __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to char");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DELIMITER", value);
			}
		}

		public static System.String PERM_ANYONE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_ANYONE"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_ANYONE", value);
			}
		}

		public static System.String PERM_VARIABLE_OWNER
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER", value);
			}
		}

		public static System.String PERM_VARIABLE_OWNER_UNSAFE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_UNSAFE"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_UNSAFE", value);
			}
		}

		public static System.String PERM_VARIABLE_OWNER_ONLY_CONTACTS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS", value);
			}
		}

		public static System.String PERM_VARIABLE_OWNER_ONLY_CONTACTS_UNSAFE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS_UNSAFE"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS_UNSAFE", value);
			}
		}

		public static System.String PERM_DEFINITION_OWNER_ONLY
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY", value);
			}
		}

		public static System.String PERM_DEFINITION_OWNER_ONLY_UNSAFE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_UNSAFE"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_UNSAFE", value);
			}
		}

		public static System.String PERM_DEFINITION_OWNER_ONLY_CONTACTS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS", value);
			}
		}

		public static System.String PERM_DEFINITION_OWNER_ONLY_CONTACTS_UNSAFE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS_UNSAFE"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS_UNSAFE", value);
			}
		}

		public static System.String PERM_DEFINITION_OWNER
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER", value);
			}
		}

		public static System.String PERM_DEFINITION_OWNER_UNSAFE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_UNSAFE"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_UNSAFE", value);
			}
		}

		private static HashSet<string> _validPermissions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_validPermissions"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_validPermissions", value);
			}
		}

		public static VariablePermissionType? GetPermissionType(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPermissionType", name), typeof(VariablePermissionType)) is VariablePermissionType __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidPermissionList(VariablePermissionType permissionType, OwnerType owner, System.String permissions)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPermissionList", permissionType, owner, permissions), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidPermission(System.String permission)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPermission", permission), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidPath(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPath", path), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidSubpath(System.String subpath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidSubpath", subpath), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean RequiresDefinitionOwner(System.String permission)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresDefinitionOwner", permission), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean RequiresVariableOwner(System.String permission)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresVariableOwner", permission), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean TargetContactsOnly(System.String permission)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TargetContactsOnly", permission), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean TargetDefinitionOwnerOnly(System.String permission)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TargetDefinitionOwnerOnly", permission), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean AllowsPublicAccess(System.String permission)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AllowsPublicAccess", permission), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String EncodeValue<T>(T value, System.String type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EncodeValue", value, type), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static CloudVariableParser GetUnsafeValueParser<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnsafeValueParser"), typeof(CloudVariableParser)) is CloudVariableParser __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidValue(System.String type, System.String value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidValue", type, value), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static CloudVariableParser GetValueParser(System.String type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetValueParser", type), typeof(CloudVariableParser)) is CloudVariableParser __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private static CloudVariableParser GetComplexValueParser(System.String type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetComplexValueParser", type), typeof(CloudVariableParser)) is CloudVariableParser __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	public class VariableReadRequest : IEquatable<VariableReadRequest>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_BATCH_SIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_BATCH_SIZE", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public System.String OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "path")]
		[JsonPropertyName("path")]
		public System.String Path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		public System.Boolean Equals(VariableReadRequest other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public VariableReadRequest(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class VariableReadResult<V, D> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "variable")]
		[JsonPropertyName("variable")]
		public V Variable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Variable"), typeof(V)) is V __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to V");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Variable", value);
			}
		}

		[JsonProperty(PropertyName = "definition")]
		[JsonPropertyName("definition")]
		public D Definition
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Definition"), typeof(D)) is D __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to D");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Definition", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public VariableReadResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class Visit : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "url")]
		[JsonPropertyName("url")]
		public System.String URL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "URL"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "URL", value);
			}
		}

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public System.String UserId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "recordVersion")]
		[JsonPropertyName("recordVersion")]
		public System.Int32 RecordVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordVersion", value);
			}
		}

		[JsonProperty(PropertyName = "duration")]
		[JsonPropertyName("duration")]
		public System.Int64 Duration
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Duration"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Duration", value);
			}
		}

		[JsonProperty(PropertyName = "start")]
		[JsonPropertyName("start")]
		public DateTime Start
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Start"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Start", value);
			}
		}

		[JsonProperty(PropertyName = "end")]
		[JsonPropertyName("end")]
		public DateTime End
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "End"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "End", value);
			}
		}

		[JsonProperty(PropertyName = "referal")]
		[JsonPropertyName("referal")]
		public System.String Referal
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Referal"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Referal", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public Visit(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class NewtonDefaultingStringEnumConverter<T> : StringEnumConverter, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, Enum
	{
		private T DefaultValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultValue", value);
			}
		}

		public override System.Object ReadJson(JsonReader reader, Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadJson", reader, objectType, existingValue, serializer), typeof(System.Object)) is System.Object __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public NewtonDefaultingStringEnumConverter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NewtonDefaultingStringEnumConverter()
		{
		}
	}
	public class JsonDefaultingStringEnumConverter<T> : System.Text.Json.Serialization.JsonConverter<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, Enum
	{
		private T DefaultValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(T)) is T __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to T");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultValue", value);
			}
		}

		public override System.Boolean CanConvert(Type typeToConvert)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", reader, typeToConvert, options), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", writer, value, options);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public JsonDefaultingStringEnumConverter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public sealed class JsonStringEnumConverterAttribute : System.Text.Json.Serialization.JsonConverterAttribute, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.Object defaultValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultValue"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultValue", value);
			}
		}

		public override System.Text.Json.Serialization.JsonConverter CreateConverter(Type typeToConvert)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateConverter", typeToConvert), typeof(System.Text.Json.Serialization.JsonConverter)) is System.Text.Json.Serialization.JsonConverter __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public JsonStringEnumConverterAttribute(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public JsonStringEnumConverterAttribute()
		{
		}
	}
	public interface ISanitizableCollection : ResoniteBridge.ResoniteBridgeValueHolder
	{
		IEnumerable EntitiesToSanitize();
	}
	public class JsonTransitionEnumConverter<T> : System.Text.Json.Serialization.JsonConverter<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public override System.Boolean CanConvert(Type typeToConvert)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", reader, typeToConvert, options), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", writer, value, options);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public JsonTransitionEnumConverter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class NewtonsoftJsonTransitionEnumConverter : StringEnumConverter, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override void WriteJson(JsonWriter writer, System.Object value, Newtonsoft.Json.JsonSerializer serializer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteJson", writer, value, serializer);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public NewtonsoftJsonTransitionEnumConverter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class JsonUriConverter : System.Text.Json.Serialization.JsonConverter<Uri>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.Boolean CanConvert(Type typeToConvert)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.Uri Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", reader, typeToConvert, options), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override void Write(Utf8JsonWriter writer, System.Uri value, JsonSerializerOptions options)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", writer, value, options);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public JsonUriConverter(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class NullOnExternalAttribute : Attribute
	{
		public NullOnExternalAttribute()
		{
		}
	}
	public class PortRange : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private HashSet<int> InUse
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "InUse"), typeof(HashSet<int>)) is HashSet<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "InUse", value);
			}
		}

		private System.Object _lock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lock"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lock", value);
			}
		}

		[JsonPropertyName("max")]
		public System.Int32 Max
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Max"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[JsonPropertyName("min")]
		public System.Int32 Min
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Min"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Int32 Length
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Length"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		private IEnumerable<int> Range
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Range"), typeof(IEnumerable<int>)) is IEnumerable<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<int>");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<int> AvailablePorts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AvailablePorts"), typeof(IEnumerable<int>)) is IEnumerable<int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<int>");
				}
			}
		}

		private void ValidatePort(System.Int32 port, System.String name = "Port")
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ValidatePort", port, name);
		}

		public System.Boolean Contains(System.Int32 port)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Contains", port), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Int32 UseNext()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UseNext"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Int32 Next()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Next"), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean IsInUse(System.Int32 port)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInUse", port), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Use(System.Int32 port)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Use", port), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Free(System.Int32 port)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Free", port), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public override System.String ToString()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static PortRange From(System.Int32 minInclusive, System.Int32 maxInclusive)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PortRange", ResoniteBridge.ResoniteBridgeValueType.Type), "From", minInclusive, maxInclusive), typeof(PortRange)) is PortRange __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean Try(Func<int, bool> startFunction)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Try", startFunction), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public PortRange(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public PortRange()
		{
		}
	}
	public static class EnumerableExtensions
	{
		public static IEnumerable<TSource> NotInHashSet<TSource>(this IEnumerable<TSource> first, HashSet<TSource> second)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EnumerableExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "NotInHashSet", first, second), typeof(IEnumerable<TSource>)) is IEnumerable<TSource> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private static IEnumerable<TSource> NotInHashSetIterator<TSource>(IEnumerable<TSource> first, HashSet<TSource> second)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EnumerableExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "NotInHashSetIterator", first, second), typeof(IEnumerable<TSource>)) is IEnumerable<TSource> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	[AttributeUsage(AttributeTargets.Class)]
	public class SensitiveEntityAttribute : Attribute
	{
		public SensitiveEntityAttribute()
		{
		}
	}
	public static class ValidationHelper
	{
		public static System.Boolean IsValidEmail(System.String email)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "ValidationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidEmail", email), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
}
