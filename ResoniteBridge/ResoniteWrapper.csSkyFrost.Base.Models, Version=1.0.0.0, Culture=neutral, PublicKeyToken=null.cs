using ResoniteBridge;

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CompatibilityHash"), typeof(System.String));
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

		public AssemblyInfo()
		{
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Key"), typeof(System.String));
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

		public AssetChunk()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64));
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
				return (Diff)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(Diff));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		[JsonProperty(PropertyName = "isUploaded", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("isUploaded")]
		public System.Boolean IsUploaded
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUploaded"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsUploaded", value);
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public AssetDiff()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetHash"), typeof(System.String));
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
				return (E)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Entry"), typeof(E));
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
				return (ComputationLock)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeLock"), typeof(ComputationLock));
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

		public AssetEntry()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetHash"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Free"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUploaded"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderUserId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploaderUserId", value);
			}
		}

		[JsonProperty(PropertyName = "countsAgainstMemberQuota", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("countsAgainstMemberQuota")]
		public System.Boolean CountsAgainstMemberQuota
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CountsAgainstMemberQuota"), typeof(System.Boolean));
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

		public AssetInfo()
		{
		}
	}
	public class AssetMetadataRequest : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_BATCH_SIZE
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(System.Int32));
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

		public AssetMetadataRequest()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Variant"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalBytes"), typeof(System.Int64));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChunkSize"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalChunks"), typeof(System.Int32));
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
				return (UploadState)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadState"), typeof(UploadState));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadKey"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadEndpoint"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDirectUpload"), typeof(System.Boolean));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxUploadConcurrency"), typeof(System.Int32));
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
				return (List<AssetChunk>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Chunks"), typeof(List<AssetChunk>));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreatedOn"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreatedOn", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 LastChunkSize => (System.Int32)(TotalBytes - ChunkSize * (TotalChunks - 1));

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public AssetUploadData()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetSignature"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantId"), typeof(System.String));
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
				return (AssetVariantEntityType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EntityType"), typeof(AssetVariantEntityType));
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

		public AssetVariantComputationTask()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Url"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Size"), typeof(System.Int64));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContentType"), typeof(System.String));
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
				return (DateTimeOffset)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModified"), typeof(DateTimeOffset));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DeleteToken"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsFree"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReclassifiedVersion"), typeof(System.Int32));
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

		public BlobMetadata()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpireTimestamp"), typeof(DateTime));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLocked"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsLocked", value);
			}
		}

		public System.Boolean TryLock(TimeSpan duration)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryLock", duration), typeof(System.Boolean));
		}

		public System.Boolean TryExtend(System.String token, TimeSpan duration)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryExtend", token, duration), typeof(System.Boolean));
		}

		public System.Boolean TryRelease(System.String token)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryRelease", token), typeof(System.Boolean));
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

		public ComputationLock()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64));
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

		public DBAsset()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EntityId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MetadataUrl"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IconUrl"), typeof(System.String));
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
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RestrictToUniverseIds"), typeof(HashSet<string>));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SkipDateOfBirthRequirement"), typeof(System.Boolean));
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
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsernameClaims"), typeof(HashSet<string>));
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
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EmailClaims"), typeof(HashSet<string>));
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
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DateOfBirthClaims"), typeof(HashSet<string>));
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

		public SamlIdentityProvider()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (AppConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppConfiguration"), typeof(AppConfig));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SplashScreenSignature"), typeof(System.String));
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

		public AppBuildConfiguration()
		{
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsGraphicalClient", type), typeof(System.Boolean));
		}

		public static System.Boolean IsHeadless(this BuildType type)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsHeadless", type), typeof(System.Boolean));
		}

		public static System.Boolean IsAppClient(this BuildType type)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsAppClient", type), typeof(System.Boolean));
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

		public AppBuildVariant()
		{
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
				return (BuildType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BuildType"), typeof(BuildType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BuildType", value);
			}
		}

		public override System.String GetIdString(System.Boolean includeVersion, System.String separator = "-")
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetIdString", includeVersion, separator), typeof(System.String));
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

		public AppBuildVariantDescriptor()
		{
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
				return (BuildApplication)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Application"), typeof(BuildApplication));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Application", value);
			}
		}

		[JsonProperty(PropertyName = "version")]
		[JsonPropertyName("version")]
		public ResoniteBridge.ResoniteBridgeValue Version
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateVersionNumber"), typeof(System.String));
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
				return (MultiLanguageValue<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "graphic")]
		[JsonPropertyName("graphic")]
		public MultiLanguageValue<ResoniteBridge.ResoniteBridgeValue> Graphic
		{
			get
			{
				return (MultiLanguageValue<ResoniteBridge.ResoniteBridgeValue>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Graphic"), typeof(MultiLanguageValue<ResoniteBridge.ResoniteBridgeValue>));
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
				return (List<BuildChange>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Changes"), typeof(List<BuildChange>));
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
				return (List<BuildNote>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KnownIssues"), typeof(List<BuildNote>));
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
				return (List<BuildNote>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Notes"), typeof(List<BuildNote>));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Branch"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MergedBranch"), typeof(System.String));
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

		public Build()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeId"), typeof(System.String));
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
				return (MultiLanguageValue<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>));
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
				return (BuildChangeType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(BuildChangeType));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WorkInProgress"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BranchSpecific"), typeof(System.Boolean));
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
				return (List<IssueReference>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RelatedIssues"), typeof(List<IssueReference>));
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
				return (List<BuildUser>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contributors"), typeof(List<BuildUser>));
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
				return (List<BuildUser>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Reporters"), typeof(List<BuildUser>));
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
				return (HashSet<BuildPlatform>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AffectedPlatforms"), typeof(HashSet<BuildPlatform>));
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
				return (HashSet<PublishingPlatform>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExcludedPublishingPlatforms"), typeof(HashSet<PublishingPlatform>));
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

		public BuildChange()
		{
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
		public static System.String GenerateChannelId => "CH-" + Guid.NewGuid();

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsValid", value);
			}
		}

		[JsonProperty(PropertyName = "channelId")]
		[JsonPropertyName("channelId")]
		public System.String ChannelId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChannelId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (BuildApplication)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Application"), typeof(BuildApplication));
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
				return (BuildReferenceType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BuildReferenceType"), typeof(BuildReferenceType));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BuildId"), typeof(System.String));
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
				return (ConfigReferenceType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigReferenceType"), typeof(ConfigReferenceType));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigId", value);
			}
		}

		public void ExtractConfigId(out System.String ownerId, out System.String configId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractConfigId", ownerId, configId);
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

		public BuildChannel()
		{
		}
	}
	public class BuildFile : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsFolder => Signature == null;

		[JsonProperty(PropertyName = "signature")]
		[JsonPropertyName("signature")]
		public System.String Signature
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Signature"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SizeBytes"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String));
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

		public BuildFile()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NoteId"), typeof(System.String));
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
				return (MultiLanguageValue<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>));
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

		public BuildNote()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserID"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordHandle"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GithubHandle"), typeof(System.String));
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

		public BuildUser()
		{
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsWindows", platform), typeof(System.Boolean));
		}

		public static System.Boolean IsLinux(this BuildPlatform platform)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsLinux", platform), typeof(System.Boolean));
		}

		public static System.Boolean IsDesktop(this BuildPlatform platform)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDesktop", platform), typeof(System.Boolean));
		}
	}
	public abstract class BuildVariant : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "versionNumber")]
		[JsonPropertyName("versionNumber")]
		public System.String VariantId => CryptoHelper.HashIDToToken(GetIdString());

		[JsonProperty(PropertyName = "status")]
		[JsonPropertyName("status")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildStatus Status { get; set; }

		[JsonProperty(PropertyName = "files")]
		[JsonPropertyName("files")]
		public List<BuildFile> Files { get; set; }

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
	}
	public abstract class BuildVariant<D> : BuildVariant, ResoniteBridge.ResoniteBridgeValueHolder where D : BuildVariantDescriptor
	{
		[JsonProperty(PropertyName = "descriptor")]
		[JsonPropertyName("descriptor")]
		public D Descriptor { get; set; }

		protected override System.String GetIdString()
		{
			return Descriptor.GetIdString(includeVersion: true);
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
	}
	public abstract class BuildVariantDescriptor : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "versionNumber")]
		[JsonPropertyName("versionNumber")]
		public ResoniteBridge.ResoniteBridgeValue VersionNumber { get; set; }

		[JsonProperty(PropertyName = "versionString")]
		[JsonPropertyName("versionString")]
		public System.String VersionString => VersionNumber.ToString();

		[JsonProperty(PropertyName = "platform")]
		[JsonPropertyName("platform")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildPlatform Platform { get; set; }

		public virtual System.String GetIdString(System.Boolean includeVersion, System.String separator = "-")
		{
			string text = "";
			if (includeVersion)
			{
				text = VersionNumber.ToString() + separator;
			}
			return text + Platform;
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
	}
	public struct FeatureFlag : IEquatable<FeatureFlag>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "feature")]
		[JsonPropertyName("feature")]
		public System.String Feature
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Feature"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Version", value);
			}
		}

		public FeatureFlag(System.String feature, System.Int32 version)
		{
			Feature = feature;
			Version = version;
		}

		public System.Boolean Equals(FeatureFlag other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public static bool operator ==(FeatureFlag left, FeatureFlag right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(FeatureFlag left, FeatureFlag right)
		{
			return !(left == right);
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueNumber"), typeof(System.Int32));
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
				return (IssueSystem)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "System"), typeof(IssueSystem));
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
				return (IssueAction)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Action"), typeof(IssueAction));
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

		public IssueReference()
		{
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
				return (RegistrationRequest)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AdminUser"), typeof(RegistrationRequest));
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
				return (PasswordLogin)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppBotAccountLogin"), typeof(PasswordLogin));
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
				return (PasswordLogin)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotAccountLogin"), typeof(PasswordLogin));
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
				return (PasswordLogin)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeAccountLogin"), typeof(PasswordLogin));
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
				return (PasswordLogin)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkAccountLogin"), typeof(PasswordLogin));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountName"), typeof(System.String));
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
				return (PasswordLogin)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountLogin"), typeof(PasswordLogin));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountCount"), typeof(System.Int32));
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

		public CloudBootstrap()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Message"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Message", value);
			}
		}

		public static System.String ExtractMessage(System.String content)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudMessage", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractMessage", content), typeof(System.String));
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

		public CloudMessage()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUserId"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "JoinedUsers"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveUsers"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUserSessionId"), typeof(System.String));
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
				return (SessionAccessLevel)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccessLevel"), typeof(SessionAccessLevel));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionHidden"), typeof(System.Boolean));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionURLs"), typeof(List<string>));
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

		public CloudSessionMetadata()
		{
		}
	}
	public class CloudStats : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "assetMetadataJobs")]
		[JsonPropertyName("assetMetadataJobs")]
		public System.Int32 AssetMetadataJobs
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetMetadataJobs"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetMetadataJobs", value);
			}
		}

		[JsonProperty(PropertyName = "assetVariantJobs")]
		[JsonPropertyName("assetVariantJobs")]
		public System.Int32 AssetVariantJobs
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetVariantJobs"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetVariantJobs", value);
			}
		}

		[JsonProperty(PropertyName = "computedAssetMetadata")]
		[JsonPropertyName("computedAssetMetadata")]
		public System.Int32 ComputedAssetMetadata
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputedAssetMetadata"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputedAssetMetadata", value);
			}
		}

		[JsonProperty(PropertyName = "computedAssetVariants")]
		[JsonPropertyName("computedAssetVariants")]
		public System.Int32 ComputedAssetVariants
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputedAssetVariants"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputedAssetVariants", value);
			}
		}

		[JsonProperty(PropertyName = "recordPreprocessJobs")]
		[JsonPropertyName("recordPreprocessJobs")]
		public System.Int32 RecordPreprocessJobs
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordPreprocessJobs"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordPreprocessJobs", value);
			}
		}

		[JsonProperty(PropertyName = "uploadJobs")]
		[JsonPropertyName("uploadJobs")]
		public System.Int32 UploadJobs
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadJobs"), typeof(System.Int32));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationTasksInQueue"), typeof(System.Double));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationRecordsPerMinute"), typeof(System.Double));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CaptureTimestamp"), typeof(DateTime));
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

		public CloudStats()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariableOwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Value", value);
			}
		}

		[JsonProperty("timestamp")]
		[JsonPropertyName("timestamp")]
		public ResoniteBridge.ResoniteBridgeValue Timestamp
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Timestamp", value);
			}
		}

		public void GetDefinitionPath(out System.String ownerId, out System.String subpath)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefinitionPath", ownerId, subpath);
		}

		public static void GetDefinitionPath(System.String path, out System.String ownerId, out System.String subpath)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariable", ResoniteBridge.ResoniteBridgeValueType.Type), "GetDefinitionPath", path, ownerId, subpath);
		}

		public System.Boolean Equals(CloudVariable other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public CloudVariable()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefinitionOwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Subpath"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariableType"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultValue"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadPermissions"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WritePermissions"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListPermissions"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ListPermissions", value);
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public CloudVariableDefinition()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CommentId"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PostedOn"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CommentSenderId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReplyToCommentId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(System.String));
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

		public Comment()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(System.String));
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

		public ConfigFileData()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Schema"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnsafeModeWhitelist"), typeof(List<string>));
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
				return (InputConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Inputs"), typeof(InputConfig));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(System.String));
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
				return (NetworkNodePreference)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodePreference"), typeof(NetworkNodePreference));
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
				return (EntityInterfacePreference)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseEntityPreference"), typeof(EntityInterfacePreference));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseUniverseDash"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseUniverseHomes"), typeof(System.Boolean));
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
				return (ProxyConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Proxy"), typeof(ProxyConfig));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Proxy", value);
			}
		}

		[JsonPropertyName("announceLocalIPs")]
		public System.Boolean AnnounceLocalIPs
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AnnounceLocalIPs"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableAnnounceOnLAN"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableIntroTutorial"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableCloudHomeAutoLoad"), typeof(System.Boolean));
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
				return (List<WorldStartupParameters>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoStartWorlds"), typeof(List<WorldStartupParameters>));
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
				return (List<SessionJoinParameters>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoJoinSessions"), typeof(List<SessionJoinParameters>));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NoUI"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableDesktop"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisableDesktop", value);
			}
		}

		[JsonPropertyName("availableLoginMethods")]
		public ResoniteBridge.ResoniteBridgeValue AvailableLoginMethods
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AvailableLoginMethods"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PathWhitelist"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PathWhitelist", value);
			}
		}

		[JsonPropertyName("lnlConfig")]
		public ResoniteBridge.ResoniteBridgeValue LNLConfig
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LNLConfig"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceStartMicrophoneMuted"), typeof(System.Boolean));
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

		public AppConfig()
		{
		}
	}
	public class InputConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("triggerDeadZone")]
		public System.Single TriggerDeadzone
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TriggerDeadzone"), typeof(System.Single));
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
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AxisDeadzone"), typeof(System.Single));
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

		public InputConfig()
		{
		}
	}
	public class LNLConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("ports")]
		public ResoniteBridge.ResoniteBridgeValue Ports
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ports"), typeof(ResoniteBridge.ResoniteBridgeValue));
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

		public LNLConfig()
		{
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoDetect"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalBypass"), typeof(System.Boolean));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BypassDomains"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BypassDomains", value);
			}
		}

		[System.Text.Json.Serialization.JsonConverter(typeof(JsonUriConverter))]
		[JsonPropertyName("address")]
		public ResoniteBridge.ResoniteBridgeValue Address
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Address"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (CredentialType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CredentialStore"), typeof(CredentialType));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Password", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValid => Address != null;

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean ShouldUseAutoDetect => AutoDetect;

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

		public ProxyConfig()
		{
		}
	}
	public class SessionJoinParameters : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "url")]
		[JsonPropertyName("url")]
		public ResoniteBridge.ResoniteBridgeValue URL
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "URL"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionID"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LanOnly"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HeadlessOnly"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyUniverseID"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoFocus"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WaitForLogin"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Processed"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Processed", value);
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public SessionJoinParameters()
		{
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEnabled"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionName"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomSessionId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxUsers"), typeof(System.Int32));
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
				return (SessionAccessLevel)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccessLevel"), typeof(SessionAccessLevel));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseCustomJoinVerifier"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseCustomJoinVerifier", value);
			}
		}

		[JsonProperty(PropertyName = "hideFromPublicListing")]
		[JsonPropertyName("hideFromPublicListing")]
		public System.Boolean HideFromPublicListing
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HideFromPublicListing"), typeof(System.Boolean));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tags"), typeof(List<string>));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MobileFriendly"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadWorldURL"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadWorldPresetName"), typeof(System.String));
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
				return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OverrideCorrespondingWorldId"), typeof(RecordId));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OverrideCorrespondingWorldId", value);
			}
		}

		[JsonProperty(PropertyName = "forcePort")]
		[JsonPropertyName("forcePort")]
		public System.UInt16 ForcePort
		{
			get
			{
				return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForcePort"), typeof(System.UInt16));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KeepOriginalRoles"), typeof(System.Boolean));
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
				return (Dictionary<string, string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultUserRoles"), typeof(Dictionary<string, string>));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RoleCloudVariable"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllowUserCloudVariable"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DenyUserCloudVariable"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredUserJoinCloudVariable"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredUserJoinCloudVariableDenyMessage"), typeof(System.String));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AwayKickMinutes"), typeof(System.Double));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ParentSessionIds"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoInviteUsernames"), typeof(List<string>));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoInviteMessage"), typeof(System.String));
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
		public ResoniteBridge.ResoniteBridgeValue SaveAsOwner
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SaveAsOwner"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoRecover"), typeof(System.Boolean));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IdleRestartInterval"), typeof(System.Double));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForcedRestartInterval"), typeof(System.Double));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SaveOnExit"), typeof(System.Boolean));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoSaveInterval"), typeof(System.Double));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoSleep"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WaitForLogin"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Processed"), typeof(System.Boolean));
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

		public WorldStartupParameters()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactUsername"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateUsernames"), typeof(List<string>));
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
				return (ContactStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactStatus"), typeof(ContactStatus));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAccepted"), typeof(System.Boolean));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LatestMessageTime"), typeof(DateTime));
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
				return (UserProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Profile"), typeof(UserProfile));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsCounterpartMigrated"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsCounterpartMigrated", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsSelfContact => OwnerId == ContactUserId;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsPartiallyMigrated
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPartiallyMigrated"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPartiallyMigrated", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsContactRequest
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsContactRequest"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsContactRequest", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean CanBeInteractedWith
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeInteractedWith"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CanBeInteractedWith", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsValid
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsValid", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean ShouldBeHidden
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShouldBeHidden"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShouldBeHidden", value);
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
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyFriendUsername"), typeof(System.String));
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
			get
			{
				return (ContactStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyFriendStatus"), typeof(ContactStatus));
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public Contact()
		{
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
				return (BadgeType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BadgeType"), typeof(BadgeType));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BadgeCount"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public BadgeEntitlement()
		{
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
				return (CreditType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreditType"), typeof(CreditType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreditType", value);
			}
		}

		public override System.String FriendlyDescription => CreditType switch
		{
			CreditType.Basic => "Basic text credit", 
			CreditType.Prominent => "Prominent text credit", 
			CreditType.Spoken => "Spoken credit in videos/streams or prominent text", 
			CreditType.Sponsor => "Sponsor credit (spoken shoutout + text)", 
			_ => throw new NotImplementedException("Unsupported credit type: " + CreditType), 
		};

		public static ResoniteBridge.ResoniteBridgeValue GetTypeForAmount(System.Decimal dollars)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CreditsEntitlement", ResoniteBridge.ResoniteBridgeValueType.Type), "GetTypeForAmount", dollars), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public CreditsEntitlement()
		{
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
				return (CreditType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreditType"), typeof(CreditType));
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

		public CreditUser()
		{
		}
	}
	public class DeleteRecoveryEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public override System.String FriendlyDescription => "Automated deleted item/world recovery command";

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public DeleteRecoveryEntitlement()
		{
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
		public virtual System.Boolean IsLifetime => false;

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
	}
	public class ExitMessageEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.Boolean IsLifetime => true;

		[JsonProperty(PropertyName = "messageCount")]
		[JsonPropertyName("messageCount")]
		public System.Int32 MessageCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageCount"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public ExitMessageEntitlement()
		{
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupCount"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override System.Boolean CombineWith(Entitlement otherGroup)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", otherGroup), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public GroupCreationEntitlement()
		{
		}
	}
	public class HeadlessServerEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.String FriendlyDescription => "Headless Server Access (send /headlessCode to Resonite in Contacts list to get the current code)";

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public HeadlessServerEntitlement()
		{
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
				return (LaunchShoutoutType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShoutoutType"), typeof(LaunchShoutoutType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShoutoutType", value);
			}
		}

		public override System.String FriendlyDescription => ShoutoutType switch
		{
			LaunchShoutoutType.TextSmall => "Small shoutout in our launch posts", 
			LaunchShoutoutType.TextLarge => "Bigger shoutout in our launch posts", 
			LaunchShoutoutType.Verbal => "Verbal shoutout in our launch videos", 
			LaunchShoutoutType.Sponsor => "A big sponsor shoutout for launch", 
			_ => throw new NotImplementedException("Unsupported shoutout type: " + ShoutoutType), 
		};

		public static ResoniteBridge.ResoniteBridgeValue GetTypeForAmount(System.Decimal dollars)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "LaunchShoutOutEntitlement", ResoniteBridge.ResoniteBridgeValueType.Type), "GetTypeForAmount", dollars), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public LaunchShoutOutEntitlement()
		{
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
				return (LaunchShoutoutType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShoutoutType"), typeof(LaunchShoutoutType));
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

		public ShoutOutUser()
		{
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64));
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
				return (StorageShareLevel)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaximumShareLevel"), typeof(StorageShareLevel));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StorageId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StartsOn"), typeof(DateTime));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpiresOn"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public StorageSpaceEntitlement()
		{
		}
	}
	public abstract class SupporterBase : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "supportSource")]
		[JsonPropertyName("supportSource")]
		public System.String SupportSource { get; set; }

		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public System.String Username { get; set; }

		[JsonProperty(PropertyName = "iconUrl")]
		[JsonPropertyName("iconUrl")]
		public System.String IconURL { get; set; }

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public System.String UserId { get; set; }

		[JsonProperty(PropertyName = "supportTimestamp")]
		[JsonPropertyName("supportTimestamp")]
		public DateTime SupportTimestamp { get; set; }

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
	}
	public class WorldAccessEntitlement : Entitlement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "ownerIds")]
		[JsonPropertyName("ownerIds")]
		public HashSet<string> OwnerIds
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerIds"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerIds", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override System.String FriendlyDescription => "Access to member-only worlds";

		public override System.Boolean CombineWith(Entitlement other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(System.Boolean));
		}

		public override System.Boolean SanitizeOrRemove()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(System.Boolean));
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

		public WorldAccessEntitlement()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		public EntityId()
		{
		}

		public EntityId(System.String ownerId, System.String id)
		{
			Id = id;
			OwnerId = ownerId;
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
		}

		public System.Boolean Equals(EntityId other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Boolean Equals(System.String other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public static System.Boolean TryParse(System.String compositeId, out EntityId entityId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EntityId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId, entityId), typeof(System.Boolean));
		}

		public static EntityId TryParse(System.String compositeId)
		{
			return (EntityId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EntityId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId), typeof(EntityId));
		}

		public static bool operator ==(EntityId a, EntityId b)
		{
			return a?.Equals(b) ?? ((System.Object)b == null);
		}

		public static bool operator !=(EntityId a, EntityId b)
		{
			return !(a == b);
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageIndex"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Message"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AddedByUserId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AddedByUserId", value);
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public ExitMessage()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PopReceipt"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BlobKey"), typeof(System.String));
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Object"), typeof(T));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QueueName"), typeof(System.String));
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

		public ExternalQueueObject()
		{
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "FavoriteEntityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsPubliclyReadable", entity), typeof(System.Boolean));
		}
	}
	public abstract class FundingEvent : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "amount")]
		[JsonPropertyName("amount")]
		public System.Decimal Amount { get; set; }

		[JsonProperty(PropertyName = "currency")]
		[JsonPropertyName("currency")]
		public System.String Currency { get; set; }

		[JsonProperty(PropertyName = "eventTimestamp")]
		[JsonPropertyName("eventTimestamp")]
		public DateTime EventTimestamp { get; set; }

		[JsonProperty(PropertyName = "validityStart")]
		[JsonPropertyName("validityStart")]
		public DateTime ValidityStart { get; set; }

		[JsonProperty(PropertyName = "validityEnd")]
		[JsonPropertyName("validityEnd")]
		public DateTime ValidityEnd { get; set; }

		[JsonProperty(PropertyName = "isInvalidated")]
		[JsonPropertyName("isInvalidated")]
		public System.Boolean IsInvalidated { get; set; }

		[JsonProperty(PropertyName = "entitlements")]
		[JsonPropertyName("entitlements")]
		public List<Entitlement> Entitlements { get; set; }

		[JsonProperty(PropertyName = "tierName")]
		[JsonPropertyName("tierName")]
		public System.String TierName { get; set; }

		[JsonProperty(PropertyName = "note")]
		[JsonPropertyName("note")]
		public System.String Note { get; set; }

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsValid => IsValidAtTime(DateTime.UtcNow);

		public System.Boolean IsValidAtTime(DateTime time)
		{
			if (IsInvalidated)
			{
				return false;
			}
			if (time < ValidityStart)
			{
				return false;
			}
			if (time > ValidityEnd)
			{
				return false;
			}
			return true;
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
	}
	public class PatreonFundingEvent : FundingEvent, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String Id
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PaymentTime"), typeof(DateTime));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierAmountCents"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatronId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierId"), typeof(System.String));
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

		public PatreonFundingEvent()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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

		public StripeCustomerProperty()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubscriptionId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InvoiceId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EventId"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLive"), typeof(System.Boolean));
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

		public StripeFundingEvent()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AdminUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public System.Int64 LegacyQuotaBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public System.Int64 LegacyUsedBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(System.Int64));
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

		public Group()
		{
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
			return (OwnerType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "IdUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOwnerType", id), typeof(OwnerType));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalVersion"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalVersion"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModifyingUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModifyingMachineId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModifyingMachineId", value);
			}
		}

		public RecordVersion(System.Int32 globalVersion, System.Int32 localVersion, System.String lastModifyingUserId, System.String lastModifyingMachineId)
		{
			GlobalVersion = globalVersion;
			LocalVersion = localVersion;
			LastModifyingUserId = lastModifyingUserId;
			LastModifyingMachineId = lastModifyingMachineId;
		}

		public RecordVersion OverrideModifyingUserId(System.String userId)
		{
			return (RecordVersion)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideModifyingUserId", userId), typeof(RecordVersion));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public System.Boolean Equals(RecordVersion other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
		}

		public static bool operator ==(RecordVersion a, RecordVersion b)
		{
			return a.Equals(b);
		}

		public static bool operator !=(RecordVersion a, RecordVersion b)
		{
			return !a.Equals(b);
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
	}
	public class MigrationMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "migrationId")]
		[JsonPropertyName("migrationId")]
		public System.String MigrationId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationSource"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedOn"), typeof(DateTime));
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
				return (RecordVersion)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceVersion"), typeof(RecordVersion));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceVersion", value);
			}
		}

		[JsonProperty(PropertyName = "targetVersion")]
		[JsonPropertyName("targetVersion")]
		public ResoniteBridge.ResoniteBridgeValue TargetVersion
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetVersion"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (List<DBAsset>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetManifest"), typeof(List<DBAsset>));
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
				return (MigrationMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreviousMigration"), typeof(MigrationMetadata));
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

		public MigrationMetadata()
		{
		}
	}
	public interface IRecord : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.String RecordId { get; set; }

		System.String OwnerId { get; set; }

		System.String AssetURI { get; set; }

		[System.Text.Json.Serialization.JsonIgnore]
		RecordId CombinedRecordId { get; }

		RecordVersion Version { get; set; }

		System.String Name { get; set; }

		System.String OwnerName { get; set; }

		System.String Description { get; set; }

		System.String RecordType { get; set; }

		HashSet<string> Tags { get; set; }

		System.String Path { get; set; }

		System.String ThumbnailURI { get; set; }

		System.Boolean IsPublic { get; set; }

		System.Boolean IsForPatrons { get; set; }

		System.Boolean IsListed { get; set; }

		System.Boolean IsDeleted { get; set; }

		System.Boolean IsReadOnly { get; set; }

		System.Int32 Visits { get; set; }

		System.Double Rating { get; set; }

		System.Int32 RandomOrder { get; set; }

		MigrationMetadata MigrationMetadata { get; set; }

		ResoniteBridge.ResoniteBridgeValue FirstPublishTime { get; set; }

		ResoniteBridge.ResoniteBridgeValue CreationTime { get; set; }

		DateTime LastModificationTime { get; set; }

		List<DBAsset> AssetManifest { get; set; }

		R Clone<R>() where R : class, IRecord, new();

		void IncrementGlobalVersion();

		void OverrideGlobalVersion(System.Int32 globalVersion);

		void IncrementLocalVersion(System.String machineId, System.String userId);
	}
	public static class RecordHelper
	{
		public static System.String GenerateRecordID()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateRecordID"), typeof(System.String));
		}

		public static System.Boolean IsValidRecordID(System.String recordId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidRecordID", recordId), typeof(System.Boolean));
		}

		public static System.Boolean IsSameVersion(this RecordVersion version, RecordVersion otherVersion)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameVersion", version, otherVersion), typeof(System.Boolean));
		}

		public static System.Boolean CanOverwrite(this RecordVersion source, RecordVersion target, System.Boolean sourceDeleted = false, System.Boolean targetDeleted = false)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanOverwrite", source, target, sourceDeleted, targetDeleted), typeof(System.Boolean));
		}

		public static System.Boolean IsSameVersion(this IRecord record, IRecord other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameVersion", record, other), typeof(System.Boolean));
		}

		public static System.Boolean IsSameRecord(this IRecord record, IRecord other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameRecord", record, other), typeof(System.Boolean));
		}

		public static void InheritPermissions(this IRecord record, IRecord source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "InheritPermissions", record, source);
		}

		public static System.Boolean CanOverwrite(this IRecord record, IRecord oldRecord)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanOverwrite", record, oldRecord), typeof(System.Boolean));
		}

		public static void TakeIdentityFrom(this IRecord record, IRecord source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TakeIdentityFrom", record, source);
		}

		public static ResoniteBridge.ResoniteBridgeValue GetUrl(this IRecord record, IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUrl", record, platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static ResoniteBridge.ResoniteBridgeValue GetWebUrl(this IRecord record, IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetWebUrl", record, platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static void SetUrl(this IRecord record, IPlatformProfile platform, ResoniteBridge.ResoniteBridgeValue url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SetUrl", record, platform, url);
		}

		public static R Convert<R>(this IRecord record) where R : IRecord
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Convert", record), typeof(R));
		}

		public static R CreateForDirectory<R>(System.String ownerId, System.String rootPath, System.String name) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForDirectory", ownerId, rootPath, name), typeof(R));
		}

		public static R CreateForObject<R>(System.String name, System.String ownerId, System.String assetUrl, System.String thumbnailUrl = null, System.String recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForObject", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R));
		}

		public static R CreateForTexture<R>(System.String name, System.String ownerId, System.String assetUrl, System.String thumbnailUrl = null, System.String recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForTexture", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R));
		}

		public static R CreateForAudioClip<R>(System.String name, System.String ownerId, System.String assetUrl, System.String thumbnailUrl = null, System.String recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForAudioClip", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R));
		}

		public static R CreateForLink<R>(System.String name, System.String ownerId, System.String targetUrl, System.String recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForLink", name, ownerId, targetUrl, recordId), typeof(R));
		}
	}
	public class MarkReadBatch : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_BATCH_SIZE
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderId"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ids"), typeof(List<string>));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadTime"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReadTime", value);
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public MarkReadBatch()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public System.Int64 LegacyQuotaBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public System.Int64 LegacyUsedBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(System.Int64));
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

		public Member()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupName"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean));
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

		public Membership()
		{
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_ID_LENGTH"), typeof(System.Int32));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsValid", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public ResoniteBridge.ResoniteBridgeValue SendStatus
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SendStatus"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecipientId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderUserSessionId"), typeof(System.String));
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
				return (MessageType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageType"), typeof(MessageType));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SendTime"), typeof(DateTime));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastUpdateTime"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastUpdateTime", value);
			}
		}

		[JsonProperty(PropertyName = "readTime")]
		[JsonPropertyName("readTime")]
		public ResoniteBridge.ResoniteBridgeValue ReadTime
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadTime"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSelfMessage"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsSelfMessage", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsSent => SenderId == OwnerId;

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsReceived => RecipientId == OwnerId;

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsRead
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsRead"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsRead", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String OtherUserId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OtherUserId"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPreFetched"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPreFetched", value);
			}
		}

		public static System.String GenerateId()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Message", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateId"), typeof(System.String));
		}

		public static System.Boolean IsValidId(System.String id)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Message", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", id), typeof(System.Boolean));
		}

		public T ExtractContent<T>()
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractContent"), typeof(T));
		}

		public void SetContent<T>(T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetContent", obj);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public Message Clone()
		{
			return (Message)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(Message));
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

		public Message()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrimaryLocale"), typeof(System.String));
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
				return (Dictionary<string, T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ValuesByLocale"), typeof(Dictionary<string, T>));
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

		public MultiLanguageValue()
		{
		}

		public MultiLanguageValue(T value, System.String locale = "en")
		{
			SetValue(value, locale);
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LNL_PROTOCOL_VERSION"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LNL_PROTOCOL_VERSION", value);
			}
		}

		public static TimeSpan INFO_EXPIRATION => TimeSpan.FromMinutes(2.0);

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public System.String NodeId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeId"), typeof(System.String));
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
				return (DateTimeOffset)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTimeOffset));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeName"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Address"), typeof(System.String));
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
				return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Port"), typeof(System.UInt16));
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
				return (NetworkNodeType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeType"), typeof(NetworkNodeType));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProtocolVersion"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserCount"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Capacity"), typeof(System.Int32));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasCapacity"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasCapacity", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsShuttingDown => Capacity == 0;

		[JsonProperty(PropertyName = "universeId")]
		[JsonPropertyName("universeId")]
		public System.String UniverseId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UniverseId", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue TryGetEndpoint()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetEndpoint"), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public System.Boolean ShouldUse(System.Int32 protocolVersion = 2, ResoniteBridge.ResoniteBridgeValue preference, System.String universeId = null)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ShouldUse", protocolVersion, preference, universeId), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public NetworkNodeInfo()
		{
		}
	}
	public class OAuthApplication : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String Id
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientSecret"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientType"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisplayName"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConsentType"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Permissions"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PostLogoutRedirectUris"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RedirectUris"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Requirements"), typeof(List<string>));
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
				return (Dictionary<string, JsonElement>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Properties"), typeof(Dictionary<string, JsonElement>));
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

		public OAuthApplication()
		{
		}
	}
	public class OAuthToken : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String ApplicationId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApplicationId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthorizationId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferenceId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Subject"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Type", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue CreationDate
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreationDate"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreationDate", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue ExpirationDate
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpirationDate"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExpirationDate", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue RedemptionDate
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RedemptionDate"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (Dictionary<string, JsonElement>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Properties"), typeof(Dictionary<string, JsonElement>));
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

		public OAuthToken()
		{
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CaptureTimestamp"), typeof(DateTime));
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
				return (Dictionary<SessionAccessLevel, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VisibleSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>));
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
				return (Dictionary<SessionAccessLevel, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HiddenSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>));
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
				return (Dictionary<SessionAccessLevel, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveVisibleSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>));
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
				return (Dictionary<SessionAccessLevel, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveHiddenSessionsByAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RegisteredUsers"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PresentUsers"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AwayUsers"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InstanceCount"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVR"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInScreen"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersOnDesktop"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersOnMobile"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVisiblePublicSessions"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVisibleSemiAccessibleSessions"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInHiddenSessions"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInPrivateSessions"), typeof(System.Int32));
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
				return (Dictionary<SessionAccessLevel, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersBySessionAccessLevel"), typeof(Dictionary<SessionAccessLevel, int>));
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
				return (Dictionary<UserSessionType, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersByClientType"), typeof(Dictionary<UserSessionType, int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersByClientType", value);
			}
		}

		public System.Int32 GetUsersBySessionAccessLevel(SessionAccessLevel accessLevel)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsersBySessionAccessLevel", accessLevel), typeof(System.Int32));
		}

		public System.Int32 GetUsersByClientType(UserSessionType type)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsersByClientType", type), typeof(System.Int32));
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

		public OnlineStats()
		{
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
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN"), typeof(IPlatformProfile));
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
				return (List<IPlatformProfile>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "_legacyProfiles"), typeof(List<IPlatformProfile>));
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
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "RESONITE"), typeof(IPlatformProfile));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "RESONITE", value);
			}
		}

		public static IEnumerable<IPlatformProfile> LegacyProfiles => _legacyProfiles;

		[JsonPropertyName("name")]
		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShortNamePrefix"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Abbreviation"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Domain"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModerationUrl"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportUrl"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PoliciesPage"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordInviteUrl"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonUrl"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubProfile"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubIssuesRepository"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WebRecordEndpoint"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WebSessionEndpoint"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TeamGroupId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeGroupId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkGroupId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUsername"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUsername"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUsername"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUsername"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthScheme"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppScheme"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DBScheme"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionScheme"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordScheme"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionScheme"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserSessionScheme", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String BaseInventoryUrl => RecordScheme + ":///" + GroupId + "/Inventory/";

		public System.String SteamAppId => "2519830";

		public System.Int64 DiscordAppId => 1159154461059592333L;

		[JsonPropertyName("favoriteVariableOverrides")]
		public string[] FavoriteVariableOverrides
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FavoriteVariableOverrides"), typeof(string[]));
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
				return (IEnumerable<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PlatformVariables"), typeof(IEnumerable<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PlatformVariables", value);
			}
		}

		static PlatformProfile()
		{
			_legacyProfiles = new List<IPlatformProfile>();
			RESONITE = new PlatformProfile("Resonite", "Res", "RVR");
			PlatformProfile platformProfile = new PlatformProfile("Everion", "Ever", "EVR");
			platformProfile.Name = "Durian";
			platformProfile.ShortNamePrefix = "Duri";
			platformProfile.Abbreviation = "DUR";
			platformProfile.PoliciesPage = "https://yellowdogman.com/";
			platformProfile.GitHubProfile = "Yellow-Dog-Man";
			platformProfile.GitHubIssuesRepository = "DurianPrelaunch";
			platformProfile.AppUsername = "Durian";
			platformProfile.AppUsername = "U-Durian";
			platformProfile.WebRecordEndpoint = "https://everion-api.azurewebsites.net/open/world";
			platformProfile.WebSessionEndpoint = "https://everion-api.azurewebsites.net/open/session";
			platformProfile.Email = "hello@durian.com";
			platformProfile.DiscordInviteUrl = "discord.gg/NotApplicable";
			DURIAN = platformProfile;
		}

		public static void LoadLegacyProfiles(System.String path)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadLegacyProfiles", path);
		}

		public PlatformProfile()
		{
		}

		public PlatformProfile(System.String name, System.String shortNamePrefix, System.String abbreviation)
		{
			Name = name;
			ShortNamePrefix = shortNamePrefix;
			Abbreviation = abbreviation;
			string text = name.Replace(" ", "").ToLower();
			Domain = text + ".com";
			Email = "hello@" + Domain;
			ModerationUrl = "moderation." + Domain;
			SupportUrl = "support." + Domain;
			PoliciesPage = "https://" + Domain + "/policies";
			WebRecordEndpoint = "https://go." + Domain + "/record";
			WebSessionEndpoint = "https://go." + Domain + "/session";
			DiscordInviteUrl = "discord.gg/" + text;
			PatreonUrl = "https://patreon.com/" + text;
			GroupId = "G-" + name;
			TeamGroupId = GroupId + "-Team";
			ComputeGroupId = GroupId + "-Compute";
			NetworkGroupId = GroupId + "-Network";
			AppUsername = name;
			DevBotUsername = name + " DevBot";
			ComputeUsername = name + " Compute";
			NetworkUsername = name + " Network";
			AppUserId = "U-" + name;
			DevBotUserId = AppUserId + "-DevBot";
			ComputeUserId = AppUserId + "-Compute";
			NetworkUserId = AppUserId + "-Network";
			AuthScheme = shortNamePrefix.ToLower();
			AppScheme = name.ToLower();
			DBScheme = shortNamePrefix.ToLower() + "db";
			SessionScheme = shortNamePrefix.ToLower() + "session";
			RecordScheme = shortNamePrefix.ToLower() + "rec";
			UserSessionScheme = shortNamePrefix.ToLower() + "usersession";
		}

		public System.String FavoriteVariable(FavoriteEntity entity)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FavoriteVariable", entity), typeof(System.String));
		}

		public System.String VariablePath(System.String subpath)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariablePath", subpath), typeof(System.String));
		}

		public System.Boolean IsPlatformOwnerId(System.String ownerId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPlatformOwnerId", ownerId), typeof(System.Boolean));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordUri(System.String ownerId, System.String recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", ownerId, recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(System.String ownerId, System.String recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordWebUri", ownerId, recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordUri(RecordId recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordUri(IRecord record)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", record), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(RecordId recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordWebUri", recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(IRecord record)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordWebUri", record), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetInventoryItemUri(System.String itemPath)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInventoryItemUri", itemPath), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSpawnObjectUri(System.String itemPath)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSpawnObjectUri", itemPath), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordPath(System.String recordPath)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordPath", recordPath), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordUri(System.String recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSessionUri(System.String sessionId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionUri", sessionId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSessionWebUri(System.String sessionId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionWebUri", sessionId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public System.Boolean ExtractRecordID(ResoniteBridge.ResoniteBridgeValue recordUri, out System.String ownerId, out System.String recordId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractRecordID", recordUri, ownerId, recordId), typeof(System.Boolean));
		}

		public System.Boolean ExtractRecordPath(ResoniteBridge.ResoniteBridgeValue recordUri, out System.String ownerId, out System.String recordPath)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractRecordPath", recordUri, ownerId, recordPath), typeof(System.Boolean));
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
		System.String Name { get; }

		System.String ShortNamePrefix { get; }

		System.String Abbreviation { get; }

		System.String Domain { get; }

		System.String ModerationUrl { get; }

		System.String SupportUrl { get; }

		System.String Email { get; }

		System.String DiscordInviteUrl { get; }

		System.String PoliciesPage { get; }

		System.String PatreonUrl { get; }

		System.String GitHubProfile { get; }

		System.String GitHubIssuesRepository { get; }

		System.String GroupId { get; }

		System.String TeamGroupId { get; }

		System.String ComputeGroupId { get; }

		System.String NetworkGroupId { get; }

		System.String AppUsername { get; }

		System.String DevBotUsername { get; }

		System.String ComputeUsername { get; }

		System.String NetworkUsername { get; }

		System.String AppUserId { get; }

		System.String DevBotUserId { get; }

		System.String ComputeUserId { get; }

		System.String NetworkUserId { get; }

		System.String AuthScheme { get; }

		System.String AppScheme { get; }

		System.String DBScheme { get; }

		System.String SessionScheme { get; }

		System.String RecordScheme { get; }

		System.String UserSessionScheme { get; }

		System.String BaseInventoryUrl { get; }

		System.String SteamAppId { get; }

		System.Int64 DiscordAppId { get; }

		IEnumerable<string> PlatformVariables { get; }

		System.Boolean IsPlatformOwnerId(System.String ownerId);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(System.String ownerId, System.String recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(RecordId recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(IRecord recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(System.String ownerId, System.String recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(RecordId recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(IRecord recordId);

		ResoniteBridge.ResoniteBridgeValue GetInventoryItemUri(System.String itemPath);

		ResoniteBridge.ResoniteBridgeValue GetSpawnObjectUri(System.String itemPath);

		ResoniteBridge.ResoniteBridgeValue GetRecordPath(System.String recordPath);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(System.String recordId);

		ResoniteBridge.ResoniteBridgeValue GetSessionUri(System.String sessionId);

		ResoniteBridge.ResoniteBridgeValue GetSessionWebUri(System.String sessionId);

		System.Boolean ExtractRecordID(ResoniteBridge.ResoniteBridgeValue recordUri, out System.String ownerId, out System.String recordId);

		System.Boolean ExtractRecordPath(ResoniteBridge.ResoniteBridgeValue recordUri, out System.String ownerId, out System.String recordPath);

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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FromUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ToUserId"), typeof(System.String));
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
				return (System.Decimal)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Amount"), typeof(System.Decimal));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Comment"), typeof(System.String));
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
				return (TransferType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TransferType"), typeof(TransferType));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Anonymous"), typeof(System.Boolean));
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

		public PointTransfer()
		{
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class PriorityIssue : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String TASK_KEY
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "TASK_KEY"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "PRIORITY_ISSUES_ID"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Title"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueNumber"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueURL"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VoteCount"), typeof(System.Int32));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActivePledgeScore"), typeof(System.Double));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LifetimePledgeScore"), typeof(System.Double));
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

		public PriorityIssue()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecipientId"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReadTime"), typeof(DateTime));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Ids"), typeof(List<string>));
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

		public ReadMessageBatch()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURI"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetURI", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public RecordId CombinedRecordId => new RecordId(OwnerId, RecordId);

		[JsonProperty(PropertyName = "version")]
		[JsonPropertyName("version")]
		public RecordVersion Version
		{
			get
			{
				return (RecordVersion)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(RecordVersion));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordType"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerName"), typeof(System.String));
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
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tags"), typeof(HashSet<string>));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailURI"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModificationTime"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModificationTime", value);
			}
		}

		[JsonProperty(PropertyName = "creationTime")]
		[JsonPropertyName("creationTime")]
		public ResoniteBridge.ResoniteBridgeValue CreationTime
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreationTime"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreationTime", value);
			}
		}

		[JsonProperty(PropertyName = "firstPublishTime")]
		[JsonPropertyName("firstPublishTime")]
		public ResoniteBridge.ResoniteBridgeValue FirstPublishTime
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FirstPublishTime"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDeleted"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPublic"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsForPatrons"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListed"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsReadOnly"), typeof(System.Boolean));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Visits"), typeof(System.Int32));
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
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Rating"), typeof(System.Double));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RandomOrder"), typeof(System.Int32));
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
				return (List<Submission>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Submissions"), typeof(List<Submission>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Manifest"), typeof(List<string>));
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
				return (List<DBAsset>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetManifest"), typeof(List<DBAsset>));
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
				return (MigrationMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationMetadata"), typeof(MigrationMetadata));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationMetadata", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValidOwnerId => IdUtil.GetOwnerType(OwnerId) != OwnerType.INVALID;

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValidRecordId => RecordHelper.IsValidRecordID(RecordId);

		[Obsolete]
		[JsonProperty(PropertyName = "neosDBmanifest", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("neosDBmanifest")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public List<DBAsset> LegacyManifest
		{
			get
			{
				return (List<DBAsset>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyManifest"), typeof(List<DBAsset>));
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
		public System.Int32 LegacyGlobalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyGlobalVersion", value);
			}
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyGlobalVersion"), typeof(System.Int32));
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "localVersion")]
		[JsonPropertyName("localVersion")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public System.Int32 LegacyLocalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLocalVersion", value);
			}
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyLocalVersion"), typeof(System.Int32));
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
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyLastModifyingUserId"), typeof(System.String));
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
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyLastModifyingMachineId"), typeof(System.String));
			}
		}

		public static System.Boolean IsValidId(System.String recordId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Record", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", recordId), typeof(System.Boolean));
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
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(R));
		}

		public Record Clone()
		{
			return (Record)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(Record));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public Record()
		{
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
				return (RecordInfoOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Operation"), typeof(RecordInfoOperation));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Created"), typeof(DateTime));
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
				return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ParentRecord"), typeof(RecordId));
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
				return (RecordInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordInfo"), typeof(RecordInfo));
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

		public ChildRecordDiff()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(System.String));
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
				return (RecordOperation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Operation"), typeof(RecordOperation));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingTime"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingUserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingMachineId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingSource"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalAssetURL"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalName"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalPath"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalGlobalVersion"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalLocalVersion"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalModifyingMachineId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalModifyingUserId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalModifyingUserId", value);
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public RecordAuditInfo()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsValid => IsValidId(OwnerId, Id);

		public System.String ToURL(IPlatformProfile platform)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToURL", platform), typeof(System.String));
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public System.Boolean Equals(RecordId other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Boolean Equals(System.String other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public RecordId(System.String ownerId, System.String recordId)
		{
			OwnerId = ownerId;
			Id = recordId;
		}

		public RecordId()
		{
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public static System.Boolean IsValidId(System.String ownerId, System.String id)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", ownerId, id), typeof(System.Boolean));
		}

		public static System.Boolean TryParse(System.String compositeId, out RecordId recordId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId, recordId), typeof(System.Boolean));
		}

		public static RecordId TryParse(System.String compositeId)
		{
			return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId), typeof(RecordId));
		}

		public static bool operator ==(RecordId a, RecordId b)
		{
			return a?.Equals(b) ?? ((System.Object)b == null);
		}

		public static bool operator !=(RecordId a, RecordId b)
		{
			return !(a == b);
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURI"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailURI"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalVersion"), typeof(System.Int32));
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

		public RecordInfo()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreprocessId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(System.String));
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
				return (RecordPreprocessState)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(RecordPreprocessState));
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
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Progress"), typeof(System.Single));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FailReason"), typeof(System.String));
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
				return (List<AssetDiff>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ResultDiffs"), typeof(List<AssetDiff>));
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

		public RecordPreprocessStatus()
		{
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_isNormalized"), typeof(System.Boolean));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Offset"), typeof(System.Int32));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Private"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ByOwner"), typeof(System.String));
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
				return (OwnerType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerType"), typeof(OwnerType));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedTo"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyFeatured"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordType"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredTags"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OptionalTags"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExcludedTags"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExcludedTags", value);
			}
		}

		[JsonProperty(PropertyName = "minDate")]
		[JsonPropertyName("minDate")]
		public ResoniteBridge.ResoniteBridgeValue MinDate
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MinDate"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MinDate", value);
			}
		}

		[JsonProperty(PropertyName = "maxDate")]
		[JsonPropertyName("maxDate")]
		public ResoniteBridge.ResoniteBridgeValue MaxDate
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxDate"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (SearchSortParameter)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SortBy"), typeof(SearchSortParameter));
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
				return (SearchSortDirection)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SortDirection"), typeof(SearchSortDirection));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExtraSignatures"), typeof(List<string>));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsValid", value);
			}
		}

		public void Normalize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Normalize");
		}

		private List<string> NormalizeTags(List<string> tags)
		{
			return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NormalizeTags", tags), typeof(List<string>));
		}

		public System.Boolean Equals(SearchParameters other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public System.Boolean Equals(SearchParameters other, System.Boolean excludeOffsetAndCount)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other, excludeOffsetAndCount), typeof(System.Boolean));
		}

		private static System.Boolean ListsEqual(List<string> a, List<string> b)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "SearchParameters", ResoniteBridge.ResoniteBridgeValueType.Type), "ListsEqual", a, b), typeof(System.Boolean));
		}

		public static bool operator ==(SearchParameters a, SearchParameters b)
		{
			if ((System.Object)a == null && (System.Object)b == null)
			{
				return true;
			}
			if ((System.Object)a == null || (System.Object)b == null)
			{
				return false;
			}
			return a.Equals(b);
		}

		public static bool operator !=(SearchParameters a, SearchParameters b)
		{
			return !(a == b);
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
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

		public SearchParameters()
		{
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
				return (List<R>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Records"), typeof(List<R>));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasMoreResults"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasMoreResults", value);
			}
		}

		public SearchResults()
		{
		}

		public SearchResults(List<R> records, System.Boolean hasMore)
		{
			Records = records;
			HasMoreResults = hasMore;
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VerificationKey"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contacts"), typeof(List<string>));
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

		public CheckContactData()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KeyId"), typeof(System.String));
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
				return (VerificationKeyUse)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Use"), typeof(VerificationKeyUse));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Use", value);
			}
		}

		public static System.String GenerateId(System.String baseId = null)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateId", baseId), typeof(System.String));
		}

		public static System.Boolean IsValidId(System.String id)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", id), typeof(System.Boolean));
		}

		public static System.String GenerateRecordAccessBaseId(System.String accessingOwnerId, System.String recordId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateRecordAccessBaseId", accessingOwnerId, recordId), typeof(System.String));
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

		public OneTimeVerificationKey()
		{
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Exponent"), typeof(byte[]));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Modulus"), typeof(byte[]));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "P"), typeof(byte[]));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Q"), typeof(byte[]));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DP"), typeof(byte[]));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DQ"), typeof(byte[]));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InverseQ"), typeof(byte[]));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "D"), typeof(byte[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "D", value);
			}
		}

		public static implicit operator RSAParametersData(ResoniteBridge.ResoniteBridgeValue rsa)
		{
			return new RSAParametersData
			{
				Exponent = rsa.Exponent,
				Modulus = rsa.Modulus,
				P = rsa.P,
				Q = rsa.Q,
				DP = rsa.DP,
				DQ = rsa.DQ,
				InverseQ = rsa.InverseQ,
				D = rsa.D
			};
		}

		public static implicit operator RSAParameters(RSAParametersData data)
		{
			RSAParameters result = default(RSAParameters);
			result.Exponent = data.Exponent;
			result.Modulus = data.Modulus;
			result.P = data.P;
			result.Q = data.Q;
			result.DP = data.DP;
			result.DQ = data.DQ;
			result.InverseQ = data.InverseQ;
			result.D = data.D;
			return result;
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

		public RSAParametersData()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretKeyBase32"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecoveryCodes"), typeof(List<string>));
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
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretKey"), typeof(byte[]));
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

		public TOTP_Key()
		{
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastUpdate"), typeof(DateTime));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ResponseTimeMilliseconds"), typeof(System.Int64));
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

		public ServerStatistics()
		{
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
				return (List<Contact>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contacts"), typeof(List<Contact>));
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

		public StatusInitializationResult()
		{
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_SHARE_BYTES"), typeof(System.Int64));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bytes", value);
			}
		}

		[JsonProperty(PropertyName = "expiresOn")]
		[JsonPropertyName("expiresOn")]
		public ResoniteBridge.ResoniteBridgeValue ExpiresOn
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpiresOn"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExpiresOn", value);
			}
		}

		[JsonProperty(PropertyName = "activatesOn")]
		[JsonPropertyName("activatesOn")]
		public ResoniteBridge.ResoniteBridgeValue ActivatesOn
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActivatesOn"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreatedOn"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(System.String));
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
				return (QuotaType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(QuotaType));
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
				return (StorageShareLevel)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaximumShareLevel"), typeof(StorageShareLevel));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsExpired => IsExpiredAtTime(DateTime.UtcNow);

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsActive => IsActiveAtTime(DateTime.UtcNow);

		public System.Boolean IsActiveAtTime(DateTime timePoint)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsActiveAtTime", timePoint), typeof(System.Boolean));
		}

		public System.Boolean IsExpiredAtTime(DateTime timePoint)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsExpiredAtTime", timePoint), typeof(System.Boolean));
		}

		public System.Boolean Overrides(QuotaSource otherSource)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Overrides", otherSource), typeof(System.Boolean));
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

		public QuotaSource()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetOwnerId"), typeof(System.String));
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
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShareRatio"), typeof(System.Single));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxShareBytes"), typeof(System.Int64));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentShareBytes"), typeof(System.Int64));
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

		public QuotaShare()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsedBytes"), typeof(System.Int64));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytes"), typeof(System.Int64));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FullQuotaBytes"), typeof(System.Int64));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShareableQuotaBytes"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShareableQuotaBytes", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Int64 SharedQuotaBytes => FullQuotaBytes - QuotaBytes;

		[JsonProperty(PropertyName = "quotaSources")]
		[JsonPropertyName("quotaSources")]
		public List<QuotaSource> QuotaSources
		{
			get
			{
				return (List<QuotaSource>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaSources"), typeof(List<QuotaSource>));
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
				return (List<QuotaShare>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaShares"), typeof(List<QuotaShare>));
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

		public Storage()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(System.String));
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
				return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetRecordId"), typeof(RecordId));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmissionTime"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedById"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedByName"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Featured"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FeaturedByUserId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FeaturedByUserId", value);
			}
		}

		[JsonProperty(PropertyName = "featuredTimestamp")]
		[JsonPropertyName("featuredTimestamp")]
		public ResoniteBridge.ResoniteBridgeValue FeaturedTimestamp
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FeaturedTimestamp"), typeof(ResoniteBridge.ResoniteBridgeValue));
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

		public Submission()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (DateTimeOffset)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTimeOffset));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderIP"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderOwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Signature"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadEndpoint", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.String SignatureDataString => Id + Timestamp.ToString("o", CultureInfo.InvariantCulture);

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public byte[] SignatureData => Encoding.UTF8.GetBytes(SignatureDataString);

		public static System.String GenerateID()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "ThumbnailInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateID"), typeof(System.String));
		}

		public void Sign(ResoniteBridge.ResoniteBridgeValue key)
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

		public ThumbnailInfo()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrimaryGroupId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrimaryGroupId", value);
			}
		}

		public System.Boolean IsPrimaryGroup(System.String groupId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPrimaryGroup", groupId), typeof(System.Boolean));
		}

		public ResoniteBridge.ResoniteBridgeValue GetBaseUri(IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBaseUri", platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetBaseInventoryUri(IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBaseInventoryUri", platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSpawnObjectUri(System.String itemPath, IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSpawnObjectUri", itemPath, platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordAtPath(System.String recordPath, IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAtPath", recordPath, platform), typeof(ResoniteBridge.ResoniteBridgeValue));
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

		public Universe()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionToken"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionCreated"), typeof(DateTime));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionExpire"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineIdHash"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineIdSalt"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID_Hash"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID_Salt"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RememberMe"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMachineBound"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LogoutUrl"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LogoutUrlClientSide"), typeof(System.Boolean));
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
				return (SessionLoginType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalLoginType"), typeof(SessionLoginType));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionLoginCounter"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionLoginCounter", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsExpired => DateTime.UtcNow > SessionExpire.ToUniversalTime();

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

		public UserSession()
		{
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
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Entity"), typeof(T));
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
				return (List<ConfigFileData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigFiles"), typeof(List<ConfigFileData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigFiles", value);
			}
		}

		public IEnumerable EntitiesToSanitize()
		{
			return (IEnumerable)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EntitiesToSanitize"), typeof(IEnumerable));
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

		public UserSessionResult()
		{
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
				return (BroadcastTarget)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "PUBLIC"), typeof(BroadcastTarget));
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
				return (BroadcastTarget)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "ALL_CONTACTS"), typeof(BroadcastTarget));
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
				return (BroadcastGroup)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(BroadcastGroup));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetIds"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TargetIds", value);
			}
		}

		public static BroadcastTarget ToContact(System.String userId)
		{
			return (BroadcastTarget)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "ToContact", userId), typeof(BroadcastTarget));
		}

		public BroadcastTarget()
		{
		}

		public BroadcastTarget(BroadcastGroup group)
		{
			if (RequiresTargetIds(group))
			{
				throw new InvalidOperationException($"Group {group} requires list of target IDs");
			}
			Group = group;
		}

		public BroadcastTarget(BroadcastGroup group, System.String targetId)
		{
			if (!RequiresTargetIds(group))
			{
				throw new InvalidOperationException($"Group {group} doesn't use target IDs");
			}
			if (string.IsNullOrEmpty(targetId))
			{
				throw new ArgumentException("TargetID is empty");
			}
			Group = group;
			TargetIds = new List<string> { targetId };
		}

		public BroadcastTarget(BroadcastGroup group, IEnumerable<string> targetIds)
		{
			if (!RequiresTargetIds(group))
			{
				throw new InvalidOperationException($"Group {group} doesn't use target IDs");
			}
			if (targetIds.Any((System.String id) => string.IsNullOrEmpty(id)))
			{
				throw new ArgumentException("One of the TargetIds is empty");
			}
			Group = group;
			TargetIds = new List<string>(targetIds);
		}

		public static System.Boolean RequiresTargetIds(BroadcastGroup group)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresTargetIds", group), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
		}

		public System.Boolean Equals(BroadcastTarget other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public static bool operator ==(BroadcastTarget a, BroadcastTarget b)
		{
			if ((System.Object)a == null && (System.Object)b == null)
			{
				return true;
			}
			if ((System.Object)a == null || (System.Object)b == null)
			{
				return false;
			}
			return a.Equals(b);
		}

		public static bool operator !=(BroadcastTarget a, BroadcastTarget b)
		{
			return !(a == b);
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonRawCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DeltaCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PledgeCents"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Timestamp"), typeof(DateTime));
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

		public LegacyPatreonSnapshot()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPatreonEmail"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPatreonSupporter"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonID"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPatreonPledgeCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTotalCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MinimumTotalUnits"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExternalCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastExternalCents"), typeof(System.Int32));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasSupported"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RewardType"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomTier"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PriorityIssue"), typeof(System.Int32));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastActivationTime"), typeof(DateTime));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPaidPledgeAmount"), typeof(System.Int32));
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
				return (List<LegacyPatreonSnapshot>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Snapshots"), typeof(List<LegacyPatreonSnapshot>));
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

		public LegacyUserPatreonData()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String));
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
				return (LoginAuthentication)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Authentication"), typeof(LoginAuthentication));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineId"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RememberMe"), typeof(System.Boolean));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MachineBound"), typeof(System.Boolean));
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
			return (LoginCredentials)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "LoginCredentials", ResoniteBridge.ResoniteBridgeValueType.Type), "FromCredentialAuto", credential, authentication), typeof(LoginCredentials));
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

		public LoginCredentials()
		{
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
	}
	public class PasswordLogin : LoginAuthentication, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public override System.Boolean IsValidForRegistration => CryptoHelper.IsValidPassword(Password);

		[System.Text.Json.Serialization.JsonIgnore]
		public override System.Boolean IsValidForLogin => !string.IsNullOrEmpty(Password);

		[JsonProperty(PropertyName = "password", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("password")]
		public System.String Password
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecoveryCode"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecoveryCode", value);
			}
		}

		public PasswordLogin()
		{
		}

		public PasswordLogin(System.String password)
		{
			Password = password;
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
		public override System.Boolean IsValidForLogin => !string.IsNullOrWhiteSpace(SessionToken);

		public override System.Boolean IsValidForRegistration => false;

		[JsonProperty(PropertyName = "sessionToken", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("sessionToken")]
		public System.String SessionToken
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionToken"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionToken", value);
			}
		}

		public SessionTokenLogin()
		{
		}

		public SessionTokenLogin(System.String sessionToken)
		{
			SessionToken = sessionToken;
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytes"), typeof(System.Int64));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsedBytes"), typeof(System.Int64));
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
				return (Dictionary<string, long>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytesSources"), typeof(Dictionary<string, long>));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RegistrationDate"), typeof(DateTime));
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
				return (LegacyUserPatreonData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonData"), typeof(LegacyUserPatreonData));
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

		public MigratedUserData()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Enabled"), typeof(System.Boolean));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURL"), typeof(System.String));
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
				return (BadgeType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BadgeType"), typeof(BadgeType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BadgeType", value);
			}
		}

		[JsonProperty(PropertyName = "pointFiltering")]
		[JsonPropertyName("pointFiltering")]
		public System.Boolean PointFiltering
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PointFiltering"), typeof(System.Boolean));
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
				return (MultiLanguageValue<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(MultiLanguageValue<string>));
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
				return (MultiLanguageValue<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(MultiLanguageValue<string>));
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

		public BadgeDefinition()
		{
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class UserProfile : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_DISPLAY_BADGES
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_DISPLAY_BADGES"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IconUrl"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tagline"), typeof(System.String));
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
				return (List<EntityId>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisplayBadges"), typeof(List<EntityId>));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		public System.Boolean IsValid(IPlatformProfile platform)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValid", platform), typeof(System.Boolean));
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

		public UserProfile()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String));
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
				return (DateTimeOffset)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DateOfBirth"), typeof(DateTimeOffset));
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
				return (PasswordLogin)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(PasswordLogin));
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
				return (LoginCredentials)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationCredentials"), typeof(LoginCredentials));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GenerateNewUserId"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GenerateNewUserId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsEmailValid => ValidationHelper.IsValidEmail(Email);

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsDateOfBirthValid => User.IsDateOfBirthValid(DateOfBirth);

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

		public RegistrationRequest()
		{
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsActiveSupporter"), typeof(System.Boolean));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportMonths"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTierCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HighestTierCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LowestTierCents"), typeof(System.Int32));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FirstSupportTimestamp"), typeof(DateTime));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastSupportTimestamp"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastSupportTimestamp", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsSupporter => TotalSupportMonths > 0;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override System.Int32 Priority => 100;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override ResoniteBridge.ResoniteBridgeValue AccountNameOverride => "Account.Type.Patreon".AsLocaleKey();

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override ResoniteBridge.ResoniteBridgeValue AccountNameColorOverride => colorX.FromHexCode("#FF424D");

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

		public PatreonSupporter()
		{
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsActiveSupporter"), typeof(System.Boolean));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportMonths"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTierCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HighestTierCents"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LowestTierCents"), typeof(System.Int32));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FirstSupportTimestamp"), typeof(DateTime));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastSupportTimestamp"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastSupportTimestamp", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Boolean IsSupporter => TotalSupportMonths > 0;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override System.Int32 Priority => 100;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override ResoniteBridge.ResoniteBridgeValue AccountNameOverride => "Account.Type.Stripe".AsLocaleKey();

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override ResoniteBridge.ResoniteBridgeValue AccountNameColorOverride => colorX.FromHexCode("#FF424D");

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

		public StripeSupporter()
		{
		}
	}
	[JsonDerivedType(typeof(PatreonSupporter), "patreon")]
	[JsonDerivedType(typeof(StripeSupporter), "stripe")]
	public abstract class SupporterMetadata : IComparable<SupporterMetadata>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract ResoniteBridge.ResoniteBridgeValue AccountNameOverride { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract ResoniteBridge.ResoniteBridgeValue AccountNameColorOverride { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract System.Int32 Priority { get; }

		public abstract void Sanitize();

		public System.Int32 CompareTo(SupporterMetadata other)
		{
			return Priority.CompareTo(other.Priority);
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Credential"), typeof(System.String));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangedOn"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeSource"), typeof(System.String));
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

		public OldCredential()
		{
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class User : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_USERNAME_LENGTH
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_USERNAME_LENGTH"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MINIMUM_USER_AGE"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAXIMUM_USER_AGE"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateNormalizedNames"), typeof(List<string>));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(System.String));
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
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateEmails"), typeof(HashSet<string>));
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
				return (List<OldCredential>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OldUsernames"), typeof(List<OldCredential>));
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
				return (List<OldCredential>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OldEmails"), typeof(List<OldCredential>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OldEmails", value);
			}
		}

		[JsonProperty(PropertyName = "dateOfBirth")]
		[JsonPropertyName("dateOfBirth")]
		public ResoniteBridge.ResoniteBridgeValue DateOfBirth
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DateOfBirth"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RegistrationDate"), typeof(DateTime));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsVerified"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsVerified", value);
			}
		}

		[JsonProperty(PropertyName = "accountBanExpiration")]
		[JsonPropertyName("accountBanExpiration")]
		public ResoniteBridge.ResoniteBridgeValue AccountBanExpiration
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AccountBanExpiration"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AccountBanExpiration", value);
			}
		}

		[JsonProperty(PropertyName = "publicBanExpiration")]
		[JsonPropertyName("publicBanExpiration")]
		public ResoniteBridge.ResoniteBridgeValue PublicBanExpiration
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicBanExpiration"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
		public ResoniteBridge.ResoniteBridgeValue PublicBanType
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicBanType"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicBanType", value);
			}
		}

		[JsonProperty(PropertyName = "spectatorBanExpiration")]
		[JsonPropertyName("spectatorBanExpiration")]
		public ResoniteBridge.ResoniteBridgeValue SpectatorBanExpiration
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SpectatorBanExpiration"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SpectatorBanExpiration", value);
			}
		}

		[JsonProperty(PropertyName = "muteBanExpiration")]
		[JsonPropertyName("muteBanExpiration")]
		public ResoniteBridge.ResoniteBridgeValue MuteBanExpiration
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MuteBanExpiration"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MuteBanExpiration", value);
			}
		}

		[JsonProperty(PropertyName = "listingBanExpiration")]
		[JsonPropertyName("listingBanExpiration")]
		public ResoniteBridge.ResoniteBridgeValue ListingBanExpiration
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListingBanExpiration"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAccountBanned"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAccountBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsPublicBanned
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPublicBanned"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPublicBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsSpectatorBanned
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSpectatorBanned"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsSpectatorBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsMuteBanned
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMuteBanned"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMuteBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsListingBanned
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListingBanned"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsListingBanned", value);
			}
		}

		[JsonProperty(PropertyName = "uniqueDeviceIDs", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("uniqueDeviceIDs")]
		public List<string> UniqueDeviceIDs
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniqueDeviceIDs"), typeof(List<string>));
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
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tags"), typeof(List<string>));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferrerUserId"), typeof(System.String));
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
				return (UserProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Profile"), typeof(UserProfile));
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
				return (List<SupporterMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupporterMetadata"), typeof(List<SupporterMetadata>));
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
				return (List<Entitlement>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Entitlements"), typeof(List<Entitlement>));
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
				return (LoginCredentials)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationCredentials"), typeof(LoginCredentials));
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
				return (MigratedUserData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedData"), typeof(MigratedUserData));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EarliestRegistrationDate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EarliestRegistrationDate", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "patreonData")]
		[JsonPropertyName("patreonData")]
		public LegacyUserPatreonData LegacyPatreonData
		{
			get
			{
				return (LegacyUserPatreonData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyPatreonData"), typeof(LegacyUserPatreonData));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyPatreonData", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public System.Int64 LegacyQuotaBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public System.Int64 LegacyUsedBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(System.Int64));
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
				return (Dictionary<string, long>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytesSources"), typeof(Dictionary<string, long>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytesSources", value);
			}
		}

		public static System.String BasicValidateUsername(System.String username)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "User", ResoniteBridge.ResoniteBridgeValueType.Type), "BasicValidateUsername", username), typeof(System.String));
		}

		public static System.Boolean IsDateOfBirthValid(ResoniteBridge.ResoniteBridgeValue date)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "User", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDateOfBirthValid", date), typeof(System.Boolean));
		}

		public System.Boolean HasTag(System.String tag)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasTag", tag), typeof(System.Boolean));
		}

		public System.Boolean HasEntitlement<T>(Predicate<T> filter = null)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasEntitlement", filter), typeof(System.Boolean));
		}

		public System.Boolean IsSupporter<T>(Predicate<T> filter = null)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsSupporter", filter), typeof(System.Boolean));
		}

		public ResoniteBridge.ResoniteBridgeValue GetAccountName(System.String platformName, out ResoniteBridge.ResoniteBridgeValue color)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAccountName", platformName, color), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
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

		public User()
		{
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
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Rankings"), typeof(string[]));
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
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Categories"), typeof(string[]));
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
				return (string[][])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_Subcategories"), typeof(string[][]));
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
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_WorldSubCat"), typeof(string[]));
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
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_AvatarSubCat"), typeof(string[]));
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
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MMC21_OtherSubCat"), typeof(string[]));
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
				return (Dictionary<string, string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "EventTags"), typeof(Dictionary<string, string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "EventTags", value);
			}
		}

		public static System.String Team => "team member";

		public static System.String Business => "business admin";

		public static System.String Admin => "platform admin";

		public static System.String Moderator => "moderator";

		public static System.String ModerationLead => "moderation lead";

		public static System.String Developer => "platform developer";

		public static System.String Mentor => "mentor";

		public static System.String Translator => "translator";

		public static System.String MentorLead => "mentor lead";

		public static System.String HTC_Vive => "htc vive";

		public static System.String DiagnoseRecordSync => "diagnose record sync";

		public static System.String HearingImpaired => "hearing impaired";

		public static System.String VisuallyImpaired => "visually impaired";

		public static System.String ColorBlind => "color blind";

		public static System.String Mute => "mute";

		public static System.String Potato => "potato";

		public static System.String DurianTester => "durian tester";

		public static System.String FoundingSupporter => "founding supporter";

		public static System.String FirstPlace => "1st";

		public static System.String SecondPlace => "2nd";

		public static System.String ThirdPlace => "3rd";

		public static System.String MMC_Participant => "mmc participant";

		public static System.String MMC_Cow => "mmc cow";

		public static System.String MMC_Lips => "mmc lips";

		public static System.String MMC_World => "mmc world";

		public static System.String MMC_Avatar => "mmc avatar";

		public static System.String MMC_Other => "mmc other";

		public static System.String VBLFC => "vblfc";

		public static System.String VFE22 => "vfe22";

		public static System.String Festa3 => "neos festa 3";

		public static System.String Festa3Participant => "neos festa 3 participant";

		public static System.String Festa4Ambassador => "neos festa 4 ambassador";

		public static System.String Festa4Participant => "neos festa 4 participant";

		public static System.String UniFesta2023 => "unifesta 2023";

		public static System.String MMC21_Participant => "mmc21 participant";

		public static System.String MMC21_Smile => "mmc21 smile";

		public static System.String MMC21_Mouth => "mmc21 mouth";

		public static System.String MMC21_GrillCheeze => "mmc21 grill cheeze";

		public static System.String MMC21_World => "world";

		public static System.String MMC21_Avatar => "avatar";

		public static System.String MMC21_Other => "other";

		public static System.String MMC21_Meme => "meme";

		public static System.String MMC21_WorldSocial => "social";

		public static System.String MMC21_WorldGame => "game";

		public static System.String MMC21_WorldMisc => "misc";

		public static System.String MMC21_AvatarAvatars => "avatars";

		public static System.String MMC21_AvatarAccessories => "accessories";

		public static System.String MMC21_AvatarMisc => "misc";

		public static System.String MMC21_OtherTAU => "tau";

		public static System.String MMC21_OtherMisc => "misc";

		public static System.String MMC22_Participant => "mmc22 participant";

		public static System.String MMC22_HonorableMention => "mmc22 honorable mention";

		public static System.String MMC22_World => "mmc22 world";

		public static System.String MMC22_Avatar => "mmc22 avatar";

		public static System.String MMC22_Art => "mmc22 art";

		public static System.String MMC22_ESD => "mmc22 esd";

		public static System.String MMC22_Meme => "mmc22 meme";

		public static System.String MMC22_Other => "mmc22 other";

		public static System.String MMC22_CheeseCoin => "mmc22 cheese coin";

		public static System.String MMC22_LitaLita => "mmc22 litalita";

		public static System.String MMC22_HolyWater => "mmc22 holywater";

		public static System.String MMC23_Participant => "mmc23 participant";

		public static System.String MMC23_HonorableMention => "mmc23 honorable mention";

		public static System.String MMC23_Gifty => "mmc23 gifty";

		public static System.String MMC23_World => "mmc23 world";

		public static System.String MMC23_Avatar => "mmc23 avatar";

		public static System.String MMC23_Art => "mmc23 art";

		public static System.String MMC23_ESD => "mmc23 esd";

		public static System.String MMC23_Other => "mmc23 other";

		public static System.String MMC23_Meme => "mmc23 meme";

		public static System.String MMC23_Prime => "mmc23 prime";

		public static System.String MMC23_LitaLita => "mmc23 litalita";

		public static System.String MMC23_HolyWater => "mmc23 holywater";

		public static System.String MMC24_Participant => "mmc24 participant";

		public static System.String MMC24_HonorableMention => "mmc24 honorable mention";

		public static System.String MMC24_Gifty => "mmc24 gifty";

		public static System.String MMC24_World => "mmc24 world";

		public static System.String MMC24_Avatar => "mmc24 avatar";

		public static System.String MMC24_Art => "mmc24 art";

		public static System.String MMC24_ESD => "mmc24 esd";

		public static System.String MMC24_Other => "mmc24 other";

		public static System.String MMC24_Meme => "mmc24 meme";

		public static System.String MMC24_Narrative => "mmc24 narrative";

		public static System.String MMC24_Prime => "mmc24 prime";

		public static System.String MMC24_Froox => "mmc24 froox";

		public static System.String MMC24_HolyWater => "mmc24 holywater";

		public static System.String MMC24_Litalita => "mmc24 litalita";

		public static System.String Halloween24_Participant => "halloween24 participant";

		public static System.String Halloween24_Winner => "halloween24 winner";

		public static System.String VKet24_Participant => "vket24 participant";

		public static System.String UniFesta24_Participant => "unifesta 2024 participant";

		public static System.String UniFesta24_Ambassador => "unifesta 2024 ambassador";

		public static System.String CustomBadge(System.String dbSignature, System.Boolean pointFiltering)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CustomBadge", dbSignature, pointFiltering), typeof(System.String));
		}

		public static System.String GetCustomBadge(System.String badge, out System.Boolean pointFiltering)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCustomBadge", badge, pointFiltering), typeof(System.String));
		}

		public static System.String GetCustom3DBadge(System.String badge)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCustom3DBadge", badge), typeof(System.String));
		}

		public static System.String ComposeMMC21(System.String baseCategory, System.String subcategory, System.Int32 place)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ComposeMMC21", baseCategory, subcategory, place), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_SUBPATH_LENGTH"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_STRING_LENGTH"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MAX_STRING_LENGTH"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_URI_LENGTH"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_USER"), typeof(System.Int32));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_GROUP"), typeof(System.Int32));
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
				return (System.Char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DELIMITER"), typeof(System.Char));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_ANYONE"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_UNSAFE"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS_UNSAFE"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_UNSAFE"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS_UNSAFE"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_UNSAFE"), typeof(System.String));
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
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_validPermissions"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "_validPermissions", value);
			}
		}

		public static ResoniteBridge.ResoniteBridgeValue GetPermissionType(System.String name)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPermissionType", name), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static System.Boolean IsValidPermissionList(VariablePermissionType permissionType, OwnerType owner, System.String permissions)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPermissionList", permissionType, owner, permissions), typeof(System.Boolean));
		}

		public static System.Boolean IsValidPermission(System.String permission)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPermission", permission), typeof(System.Boolean));
		}

		public static System.Boolean IsValidPath(System.String path)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPath", path), typeof(System.Boolean));
		}

		public static System.Boolean IsValidSubpath(System.String subpath)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidSubpath", subpath), typeof(System.Boolean));
		}

		private static System.Boolean PreprocessPath(System.String path, out System.Int32 separatorIndex)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PreprocessPath", path, separatorIndex), typeof(System.Boolean));
		}

		public static System.Boolean SplitPath(System.String path, out System.String ownerId, out System.String subpath)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SplitPath", path, ownerId, subpath), typeof(System.Boolean));
		}

		public static System.Boolean RequiresDefinitionOwner(System.String permission)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresDefinitionOwner", permission), typeof(System.Boolean));
		}

		public static System.Boolean RequiresVariableOwner(System.String permission)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresVariableOwner", permission), typeof(System.Boolean));
		}

		public static System.Boolean TargetContactsOnly(System.String permission)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TargetContactsOnly", permission), typeof(System.Boolean));
		}

		public static System.Boolean TargetDefinitionOwnerOnly(System.String permission)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TargetDefinitionOwnerOnly", permission), typeof(System.Boolean));
		}

		public static System.Boolean AllowsPublicAccess(System.String permission)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AllowsPublicAccess", permission), typeof(System.Boolean));
		}

		public static System.Boolean ParseValue<T>(System.String encodedValue, System.String type, out T value)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ParseValue", encodedValue, type, value), typeof(System.Boolean));
		}

		public static System.Boolean TryConvertTo<T>(System.Object value, out T converted)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TryConvertTo", value, converted), typeof(System.Boolean));
		}

		public static System.Boolean TryConvertToColorX(System.Object value, out ResoniteBridge.ResoniteBridgeValue converted)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TryConvertToColorX", value, converted), typeof(System.Boolean));
		}

		public static System.String EncodeValue<T>(T value, System.String type)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EncodeValue", value, type), typeof(System.String));
		}

		public static CloudVariableParser GetUnsafeValueParser<T>()
		{
			return (CloudVariableParser)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnsafeValueParser"), typeof(CloudVariableParser));
		}

		public static System.Boolean IsValidValue(System.String type, System.String value)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidValue", type, value), typeof(System.Boolean));
		}

		public static CloudVariableParser GetValueParser(System.String type)
		{
			return (CloudVariableParser)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetValueParser", type), typeof(CloudVariableParser));
		}

		private static CloudVariableParser GetComplexValueParser(System.String type)
		{
			return (CloudVariableParser)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetComplexValueParser", type), typeof(CloudVariableParser));
		}
	}
	public class VariableReadRequest : IEquatable<VariableReadRequest>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_BATCH_SIZE
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(System.Int32));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		public System.Boolean Equals(VariableReadRequest other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
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

		public VariableReadRequest()
		{
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
				return (V)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Variable"), typeof(V));
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
				return (D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Definition"), typeof(D));
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

		public VariableReadResult()
		{
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "URL"), typeof(System.String));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordVersion"), typeof(System.Int32));
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
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Duration"), typeof(System.Int64));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Start"), typeof(DateTime));
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
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "End"), typeof(DateTime));
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
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Referal"), typeof(System.String));
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
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsValid", value);
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

		public Visit()
		{
		}
	}
	public class NewtonDefaultingStringEnumConverter<T> : StringEnumConverter, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, Enum
	{
		private T DefaultValue
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultValue", value);
			}
		}

		public NewtonDefaultingStringEnumConverter(T defaultVal)
		{
			DefaultValue = defaultVal;
		}

		public override System.Object ReadJson(JsonReader reader, Type objectType, System.Object existingValue, Newtonsoft.Json.JsonSerializer serializer)
		{
			return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadJson", reader, objectType, existingValue, serializer), typeof(System.Object));
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
	}
	public class JsonDefaultingStringEnumConverter<T> : System.Text.Json.Serialization.JsonConverter<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, Enum
	{
		private T DefaultValue
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultValue"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultValue", value);
			}
		}

		public JsonDefaultingStringEnumConverter(T defaultValue)
		{
			DefaultValue = defaultValue;
		}

		public JsonDefaultingStringEnumConverter()
		{
			DefaultValue = default(T);
		}

		public override System.Boolean CanConvert(Type typeToConvert)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(System.Boolean));
		}

		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", reader, typeToConvert, options), typeof(T));
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
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultValue"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultValue", value);
			}
		}

		public JsonStringEnumConverterAttribute(Type converterType, System.Object defaultValue)
		{
			if (defaultValue.GetType() != converterType)
			{
				throw new ArgumentException("Default value must be of type: " + converterType.Name);
			}
			this.defaultValue = defaultValue;
		}

		public override System.Text.Json.Serialization.JsonConverter CreateConverter(Type typeToConvert)
		{
			return (System.Text.Json.Serialization.JsonConverter)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateConverter", typeToConvert), typeof(System.Text.Json.Serialization.JsonConverter));
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
	}
	public interface ISanitizableCollection : ResoniteBridge.ResoniteBridgeValueHolder
	{
		IEnumerable EntitiesToSanitize();
	}
	public class JsonTransitionEnumConverter<T> : System.Text.Json.Serialization.JsonConverter<T>, ResoniteBridge.ResoniteBridgeValueHolder where T : struct
	{
		public JsonTransitionEnumConverter()
			: this((JsonSerializerOptions)null)
		{
		}

		public JsonTransitionEnumConverter(JsonSerializerOptions options)
		{
		}

		public override System.Boolean CanConvert(Type typeToConvert)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(System.Boolean));
		}

		public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", reader, typeToConvert, options), typeof(T));
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

		public NewtonsoftJsonTransitionEnumConverter()
		{
		}
	}
	public class JsonUriConverter : System.Text.Json.Serialization.JsonConverter<Uri>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override System.Boolean CanConvert(Type typeToConvert)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(System.Boolean));
		}

		public override ResoniteBridge.ResoniteBridgeValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", reader, typeToConvert, options), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override void Write(Utf8JsonWriter writer, ResoniteBridge.ResoniteBridgeValue value, JsonSerializerOptions options)
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

		public JsonUriConverter()
		{
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
				return (HashSet<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "InUse"), typeof(HashSet<int>));
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
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lock"), typeof(System.Object));
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
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Max"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Max", value);
			}
		}

		[JsonPropertyName("min")]
		public System.Int32 Min
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Min"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Min", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Int32 Length => Math.Abs(Max - Min) + 1;

		[System.Text.Json.Serialization.JsonIgnore]
		private IEnumerable<int> Range => Enumerable.Range(Min, Length);

		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<int> AvailablePorts => Range.NotInHashSet(InUse);

		[System.Text.Json.Serialization.JsonConstructor]
		public PortRange(System.Int32 min = 0, System.Int32 max = 0)
		{
			ValidatePort(min, "min");
			ValidatePort(max, "max");
			if (max < min)
			{
				throw new ArgumentException("Max cannot be less than Min", "max");
			}
			if (min > max)
			{
				throw new ArgumentException("Min cannot be greater than Max", "min");
			}
			Min = min;
			Max = max;
		}

		private void ValidatePort(System.Int32 port, System.String name = "Port")
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ValidatePort", port, name);
		}

		public System.Boolean Contains(System.Int32 port)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Contains", port), typeof(System.Boolean));
		}

		public System.Int32 UseNext()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UseNext"), typeof(System.Int32));
		}

		public System.Int32 Next()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Next"), typeof(System.Int32));
		}

		public System.Boolean IsInUse(System.Int32 port)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInUse", port), typeof(System.Boolean));
		}

		public System.Boolean Use(System.Int32 port)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Use", port), typeof(System.Boolean));
		}

		public System.Boolean Free(System.Int32 port)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Free", port), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public static PortRange From(System.Int32 minInclusive, System.Int32 maxInclusive)
		{
			return (PortRange)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PortRange", ResoniteBridge.ResoniteBridgeValueType.Type), "From", minInclusive, maxInclusive), typeof(PortRange));
		}

		public System.Boolean Try(Func<int, bool> startFunction)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Try", startFunction), typeof(System.Boolean));
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
	}
	public static class EnumerableExtensions
	{
		public static IEnumerable<TSource> NotInHashSet<TSource>(this IEnumerable<TSource> first, HashSet<TSource> second)
		{
			return (IEnumerable<TSource>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EnumerableExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "NotInHashSet", first, second), typeof(IEnumerable<TSource>));
		}

		private static IEnumerable<TSource> NotInHashSetIterator<TSource>(IEnumerable<TSource> first, HashSet<TSource> second)
		{
			return (IEnumerable<TSource>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EnumerableExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "NotInHashSetIterator", first, second), typeof(IEnumerable<TSource>));
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
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "ValidationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidEmail", email), typeof(System.Boolean));
		}
	}
}
