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
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "compatibilityHash")]
		[JsonPropertyName("compatibilityHash")]
		public string CompatibilityHash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CompatibilityHash"), typeof(string));
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
		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Index", value);
			}
		}

		[JsonProperty(PropertyName = "key")]
		[JsonPropertyName("key")]
		public string Key
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Key"), typeof(string));
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
		public string Hash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hash", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public long Bytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(long));
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
		public @bool IsUploaded
		{
			get
			{
				return (@bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUploaded"), typeof(@bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsUploaded", value);
			}
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public string AssetHash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetHash"), typeof(string));
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
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "assetHash")]
		[JsonPropertyName("assetHash")]
		public string AssetHash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetHash"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetHash", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public long Bytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Bytes", value);
			}
		}

		[JsonProperty(PropertyName = "free")]
		[JsonPropertyName("free")]
		public bool Free
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Free"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Free", value);
			}
		}

		[JsonProperty(PropertyName = "isUploaded")]
		[JsonPropertyName("isUploaded")]
		public bool IsUploaded
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUploaded"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsUploaded", value);
			}
		}

		[JsonProperty(PropertyName = "uploaderUserId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("uploaderUserId")]
		public string UploaderUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploaderUserId", value);
			}
		}

		[JsonProperty(PropertyName = "countsAgainstMemberQuota", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("countsAgainstMemberQuota")]
		public @bool CountsAgainstMemberQuota
		{
			get
			{
				return (@bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CountsAgainstMemberQuota"), typeof(@bool));
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
		public int MAX_BATCH_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(int));
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
		public string Hash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hash", value);
			}
		}

		[JsonProperty(PropertyName = "variant")]
		[JsonPropertyName("variant")]
		public string Variant
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Variant"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Variant", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "totalBytes")]
		[JsonPropertyName("totalBytes")]
		public long TotalBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalBytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalBytes", value);
			}
		}

		[JsonProperty(PropertyName = "chunkSize")]
		[JsonPropertyName("chunkSize")]
		public int ChunkSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChunkSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChunkSize", value);
			}
		}

		[JsonProperty(PropertyName = "totalChunks")]
		[JsonPropertyName("totalChunks")]
		public int TotalChunks
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalChunks"), typeof(int));
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
		public string UploadKey
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadKey"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadKey", value);
			}
		}

		[JsonProperty(PropertyName = "uploadEndpoint")]
		[JsonPropertyName("uploadEndpoint")]
		public string UploadEndpoint
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadEndpoint"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadEndpoint", value);
			}
		}

		[JsonProperty(PropertyName = "isDirectUpload")]
		[JsonPropertyName("isDirectUpload")]
		public bool IsDirectUpload
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDirectUpload"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsDirectUpload", value);
			}
		}

		[JsonProperty(PropertyName = "maxUploadConcurrency")]
		[JsonPropertyName("maxUploadConcurrency")]
		public int MaxUploadConcurrency
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxUploadConcurrency"), typeof(int));
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
		public int LastChunkSize => (int)(TotalBytes - ChunkSize * (TotalChunks - 1));

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string AssetSignature
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetSignature"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetSignature", value);
			}
		}

		[JsonProperty(PropertyName = "variantId")]
		[JsonPropertyName("variantId")]
		public string VariantId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantId"), typeof(string));
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
		public string Url
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Url"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Url", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "size")]
		[JsonPropertyName("size")]
		public long Size
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Size"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Size", value);
			}
		}

		[JsonProperty(PropertyName = "contentType")]
		[JsonPropertyName("contentType")]
		public string ContentType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContentType"), typeof(string));
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
		public string DeleteToken
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DeleteToken"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DeleteToken", value);
			}
		}

		[JsonProperty(PropertyName = "isFree")]
		[JsonPropertyName("isFree")]
		public string IsFree
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsFree"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsFree", value);
			}
		}

		[JsonProperty(PropertyName = "reclassifiedVersion")]
		[JsonPropertyName("reclassifiedVersion")]
		public int ReclassifiedVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReclassifiedVersion"), typeof(int));
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
		public string Token
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(string));
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

		public bool IsLocked
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLocked"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsLocked", value);
			}
		}

		public bool TryLock(TimeSpan duration)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryLock", duration), typeof(bool));
		}

		public bool TryExtend(string token, TimeSpan duration)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryExtend", token, duration), typeof(bool));
		}

		public bool TryRelease(string token)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryRelease", token), typeof(bool));
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
		public string Hash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hash"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hash", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public long Bytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(long));
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
		public string EntityId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EntityId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EntityId", value);
			}
		}

		[JsonProperty(PropertyName = "metadataUrl")]
		[JsonPropertyName("metadataUrl")]
		public string MetadataUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MetadataUrl"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MetadataUrl", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public string Description
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "iconUrl")]
		[JsonPropertyName("iconUrl")]
		public string IconUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IconUrl"), typeof(string));
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
		public bool SkipDateOfBirthRequirement
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SkipDateOfBirthRequirement"), typeof(bool));
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
		public string ConfigId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
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
		public string SplashScreenSignature
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SplashScreenSignature"), typeof(string));
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
		public static bool IsGraphicalClient(this BuildType type)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsGraphicalClient", type), typeof(bool));
		}

		public static bool IsHeadless(this BuildType type)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsHeadless", type), typeof(bool));
		}

		public static bool IsAppClient(this BuildType type)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "AppBuildTypeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsAppClient", type), typeof(bool));
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

		public override string GetIdString(bool includeVersion, string separator = "-")
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetIdString", includeVersion, separator), typeof(string));
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
		public string AlternateVersionNumber
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlternateVersionNumber"), typeof(string));
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
		public MultiLanguageValue<Uri> Graphic
		{
			get
			{
				return (MultiLanguageValue<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Graphic"), typeof(MultiLanguageValue<Uri>));
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
		public string Branch
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Branch"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Branch", value);
			}
		}

		[JsonProperty(PropertyName = "mergedBranch")]
		[JsonPropertyName("mergedBranch")]
		public string MergedBranch
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MergedBranch"), typeof(string));
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
		public string ChangeId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeId"), typeof(string));
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
		public bool WorkInProgress
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WorkInProgress"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WorkInProgress", value);
			}
		}

		[JsonProperty(PropertyName = "branchSpecific")]
		[JsonPropertyName("branchSpecific")]
		public bool BranchSpecific
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BranchSpecific"), typeof(bool));
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
		public static string GenerateChannelId => "CH-" + Guid.NewGuid();

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool IsValid
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsValid", value);
			}
		}

		[JsonProperty(PropertyName = "channelId")]
		[JsonPropertyName("channelId")]
		public string ChannelId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChannelId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ChannelId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
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
		public string BuildId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BuildId"), typeof(string));
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
		public string ConfigId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConfigId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConfigId", value);
			}
		}

		public void ExtractConfigId(out string ownerId, out string configId)
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
		public bool IsFolder => Signature == null;

		[JsonProperty(PropertyName = "signature")]
		[JsonPropertyName("signature")]
		public string Signature
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Signature"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Signature", value);
			}
		}

		[JsonProperty(PropertyName = "sizeBytes")]
		[JsonPropertyName("sizeBytes")]
		public int SizeBytes
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SizeBytes"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SizeBytes", value);
			}
		}

		[JsonProperty(PropertyName = "path")]
		[JsonPropertyName("path")]
		public string Path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(string));
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
		public string NoteId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NoteId"), typeof(string));
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
		public string Username
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public string UserID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserID", value);
			}
		}

		[JsonProperty(PropertyName = "discordHandle")]
		[JsonPropertyName("discordHandle")]
		public string DiscordHandle
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordHandle"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DiscordHandle", value);
			}
		}

		[JsonProperty(PropertyName = "githubHandle")]
		[JsonPropertyName("githubHandle")]
		public string GithubHandle
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GithubHandle"), typeof(string));
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
		public static bool IsWindows(this BuildPlatform platform)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsWindows", platform), typeof(bool));
		}

		public static bool IsLinux(this BuildPlatform platform)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsLinux", platform), typeof(bool));
		}

		public static bool IsDesktop(this BuildPlatform platform)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BuildPlatformExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDesktop", platform), typeof(bool));
		}
	}
	public abstract class BuildVariant : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "versionNumber")]
		[JsonPropertyName("versionNumber")]
		public string VariantId => CryptoHelper.HashIDToToken(GetIdString());

		[JsonProperty(PropertyName = "status")]
		[JsonPropertyName("status")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildStatus Status { get; set; }

		[JsonProperty(PropertyName = "files")]
		[JsonPropertyName("files")]
		public List<BuildFile> Files { get; set; }

		protected abstract string GetIdString();

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

		protected override string GetIdString()
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
		public string VersionString => VersionNumber.ToString();

		[JsonProperty(PropertyName = "platform")]
		[JsonPropertyName("platform")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public BuildPlatform Platform { get; set; }

		public virtual string GetIdString(bool includeVersion, string separator = "-")
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
		public string Feature
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Feature"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Feature", value);
			}
		}

		[JsonProperty(PropertyName = "version")]
		[JsonPropertyName("version")]
		public int Version
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Version"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Version", value);
			}
		}

		public FeatureFlag(string feature, int version)
		{
			Feature = feature;
			Version = version;
		}

		public bool Equals(FeatureFlag other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(int));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public int IssueNumber
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueNumber"), typeof(int));
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
		public string TestAccountName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountName"), typeof(string));
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
		public int TestAccountCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TestAccountCount"), typeof(int));
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
		public string Message
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Message"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Message", value);
			}
		}

		public static string ExtractMessage(string content)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudMessage", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractMessage", content), typeof(string));
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
		public string SessionId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionId", value);
			}
		}

		[JsonProperty(PropertyName = "hostUserId")]
		[JsonPropertyName("hostUserId")]
		public string HostUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HostUserId", value);
			}
		}

		[JsonProperty(PropertyName = "joinedUsers")]
		[JsonPropertyName("joinedUsers")]
		public int JoinedUsers
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "JoinedUsers"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "JoinedUsers", value);
			}
		}

		[JsonProperty(PropertyName = "activeUsers")]
		[JsonPropertyName("activeUsers")]
		public int ActiveUsers
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveUsers"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActiveUsers", value);
			}
		}

		[JsonProperty(PropertyName = "hostUserSessionId")]
		[JsonPropertyName("hostUserSessionId")]
		public string HostUserSessionId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUserSessionId"), typeof(string));
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
		public bool SessionHidden
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionHidden"), typeof(bool));
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
		public @int AssetMetadataJobs
		{
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetMetadataJobs"), typeof(@int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetMetadataJobs", value);
			}
		}

		[JsonProperty(PropertyName = "assetVariantJobs")]
		[JsonPropertyName("assetVariantJobs")]
		public @int AssetVariantJobs
		{
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetVariantJobs"), typeof(@int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetVariantJobs", value);
			}
		}

		[JsonProperty(PropertyName = "computedAssetMetadata")]
		[JsonPropertyName("computedAssetMetadata")]
		public @int ComputedAssetMetadata
		{
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputedAssetMetadata"), typeof(@int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputedAssetMetadata", value);
			}
		}

		[JsonProperty(PropertyName = "computedAssetVariants")]
		[JsonPropertyName("computedAssetVariants")]
		public @int ComputedAssetVariants
		{
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputedAssetVariants"), typeof(@int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputedAssetVariants", value);
			}
		}

		[JsonProperty(PropertyName = "recordPreprocessJobs")]
		[JsonPropertyName("recordPreprocessJobs")]
		public @int RecordPreprocessJobs
		{
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordPreprocessJobs"), typeof(@int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordPreprocessJobs", value);
			}
		}

		[JsonProperty(PropertyName = "uploadJobs")]
		[JsonPropertyName("uploadJobs")]
		public @int UploadJobs
		{
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadJobs"), typeof(@int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadJobs", value);
			}
		}

		[JsonProperty(PropertyName = "migrationTasksInQueue")]
		[JsonPropertyName("migrationTasksInQueue")]
		public double MigrationTasksInQueue
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationTasksInQueue"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationTasksInQueue", value);
			}
		}

		[JsonProperty(PropertyName = "migrationRecordsPerMinute")]
		[JsonPropertyName("migrationRecordsPerMinute")]
		public double MigrationRecordsPerMinute
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationRecordsPerMinute"), typeof(double));
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
		public string VariableOwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariableOwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariableOwnerId", value);
			}
		}

		[JsonProperty("path")]
		[JsonPropertyName("path")]
		public string Path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		[JsonProperty("value")]
		[JsonPropertyName("value")]
		public string Value
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(string));
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

		public void GetDefinitionPath(out string ownerId, out string subpath)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefinitionPath", ownerId, subpath);
		}

		public static void GetDefinitionPath(string path, out string ownerId, out string subpath)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariable", ResoniteBridge.ResoniteBridgeValueType.Type), "GetDefinitionPath", path, ownerId, subpath);
		}

		public bool Equals(CloudVariable other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string DefinitionOwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefinitionOwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DefinitionOwnerId", value);
			}
		}

		[JsonProperty("subpath")]
		[JsonPropertyName("subpath")]
		public string Subpath
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Subpath"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Subpath", value);
			}
		}

		[JsonProperty(PropertyName = "variableType")]
		[JsonPropertyName("variableType")]
		public string VariableType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariableType"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariableType", value);
			}
		}

		[JsonProperty(PropertyName = "defaultValue")]
		[JsonPropertyName("defaultValue")]
		public string DefaultValue
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultValue"), typeof(string));
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

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "commentId")]
		[JsonPropertyName("commentId")]
		public string CommentId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CommentId"), typeof(string));
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
		public string CommentSenderId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CommentSenderId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CommentSenderId", value);
			}
		}

		[JsonProperty(PropertyName = "responseToCommentId")]
		[JsonPropertyName("responseToCommentId")]
		public string ReplyToCommentId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReplyToCommentId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReplyToCommentId", value);
			}
		}

		[JsonProperty(PropertyName = "content")]
		[JsonPropertyName("content")]
		public string Content
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(string));
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
		public string Path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		[JsonProperty(PropertyName = "content")]
		[JsonPropertyName("content")]
		public string Content
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(string));
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
		public string Schema
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Schema"), typeof(string));
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
		public string UniverseId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(string));
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
		public bool UseUniverseDash
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseUniverseDash"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseUniverseDash", value);
			}
		}

		[JsonPropertyName("useUniverseHomes")]
		public bool UseUniverseHomes
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseUniverseHomes"), typeof(bool));
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
		public @bool AnnounceLocalIPs
		{
			get
			{
				return (@bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AnnounceLocalIPs"), typeof(@bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AnnounceLocalIPs", value);
			}
		}

		[JsonPropertyName("disableAnnounceOnLAN")]
		public bool DisableAnnounceOnLAN
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableAnnounceOnLAN"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisableAnnounceOnLAN", value);
			}
		}

		[JsonPropertyName("disableIntroTutorial")]
		public bool DisableIntroTutorial
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableIntroTutorial"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisableIntroTutorial", value);
			}
		}

		[JsonPropertyName("disableCloudHomeAutoLoad")]
		public bool DisableCloudHomeAutoLoad
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableCloudHomeAutoLoad"), typeof(bool));
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
		public bool NoUI
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NoUI"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NoUI", value);
			}
		}

		[JsonPropertyName("disableDesktop")]
		public bool DisableDesktop
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisableDesktop"), typeof(bool));
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
		public bool ForceStartMicrophoneMuted
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceStartMicrophoneMuted"), typeof(bool));
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
		public float TriggerDeadzone
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TriggerDeadzone"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TriggerDeadzone", value);
			}
		}

		[JsonPropertyName("axisDeadZone")]
		public float AxisDeadzone
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AxisDeadzone"), typeof(float));
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
		public bool AutoDetect
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoDetect"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoDetect", value);
			}
		}

		[JsonPropertyName("localBypass")]
		public bool LocalBypass
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalBypass"), typeof(bool));
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
		public string Username
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonPropertyName("password")]
		public string Password
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Password", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsValid => Address != null;

		[System.Text.Json.Serialization.JsonIgnore]
		public bool ShouldUseAutoDetect => AutoDetect;

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
		public string SessionID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionID", value);
			}
		}

		[JsonProperty(PropertyName = "lanOnly")]
		[JsonPropertyName("lanOnly")]
		public bool LanOnly
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LanOnly"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LanOnly", value);
			}
		}

		[JsonProperty(PropertyName = "headlessOnly")]
		[JsonPropertyName("headlessOnly")]
		public bool HeadlessOnly
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HeadlessOnly"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HeadlessOnly", value);
			}
		}

		[JsonProperty(PropertyName = "onlyUniverseId")]
		[JsonPropertyName("onlyUniverseId")]
		public string OnlyUniverseID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyUniverseID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlyUniverseID", value);
			}
		}

		[JsonProperty(PropertyName = "autoFocus")]
		[JsonPropertyName("autoFocus")]
		public bool AutoFocus
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoFocus"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoFocus", value);
			}
		}

		[JsonProperty(PropertyName = "waitForLogin")]
		[JsonPropertyName("waitForLogin")]
		public bool WaitForLogin
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WaitForLogin"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WaitForLogin", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool Processed
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Processed"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Processed", value);
			}
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public bool IsEnabled
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsEnabled"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsEnabled", value);
			}
		}

		[JsonProperty(PropertyName = "sessionName")]
		[JsonPropertyName("sessionName")]
		public string SessionName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionName", value);
			}
		}

		[JsonProperty(PropertyName = "customSessionId")]
		[JsonPropertyName("customSessionId")]
		public string CustomSessionId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomSessionId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomSessionId", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public string Description
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[DefaultValue(32)]
		[JsonProperty(PropertyName = "maxUsers")]
		[JsonPropertyName("maxUsers")]
		public int MaxUsers
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxUsers"), typeof(int));
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
		public bool UseCustomJoinVerifier
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseCustomJoinVerifier"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseCustomJoinVerifier", value);
			}
		}

		[JsonProperty(PropertyName = "hideFromPublicListing")]
		[JsonPropertyName("hideFromPublicListing")]
		public @bool HideFromPublicListing
		{
			get
			{
				return (@bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HideFromPublicListing"), typeof(@bool));
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
		public bool MobileFriendly
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MobileFriendly"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MobileFriendly", value);
			}
		}

		[JsonProperty(PropertyName = "loadWorldURL")]
		[JsonPropertyName("loadWorldURL")]
		public string LoadWorldURL
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadWorldURL"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LoadWorldURL", value);
			}
		}

		[JsonProperty(PropertyName = "loadWorldPresetName")]
		[JsonPropertyName("loadWorldPresetName")]
		public string LoadWorldPresetName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadWorldPresetName"), typeof(string));
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
		public ResoniteBridge.ResoniteBridgeValue ForcePort
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForcePort"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForcePort", value);
			}
		}

		[JsonProperty(PropertyName = "keepOriginalRoles")]
		[JsonPropertyName("keepOriginalRoles")]
		public bool KeepOriginalRoles
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KeepOriginalRoles"), typeof(bool));
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
		public string RoleCloudVariable
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RoleCloudVariable"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RoleCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "allowUserCloudVariable")]
		[JsonPropertyName("allowUserCloudVariable")]
		public string AllowUserCloudVariable
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AllowUserCloudVariable"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AllowUserCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "denyUserCloudVariable")]
		[JsonPropertyName("denyUserCloudVariable")]
		public string DenyUserCloudVariable
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DenyUserCloudVariable"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DenyUserCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "requiredUserJoinCloudVariable")]
		[JsonPropertyName("requiredUserJoinCloudVariable")]
		public string RequiredUserJoinCloudVariable
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredUserJoinCloudVariable"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RequiredUserJoinCloudVariable", value);
			}
		}

		[JsonProperty(PropertyName = "requiredUserJoinCloudVariableDenyMessage")]
		[JsonPropertyName("requiredUserJoinCloudVariableDenyMessage")]
		public string RequiredUserJoinCloudVariableDenyMessage
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequiredUserJoinCloudVariableDenyMessage"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RequiredUserJoinCloudVariableDenyMessage", value);
			}
		}

		[JsonProperty(PropertyName = "awayKickMinutes")]
		[JsonPropertyName("awayKickMinutes")]
		public double AwayKickMinutes
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AwayKickMinutes"), typeof(double));
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
		public string AutoInviteMessage
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoInviteMessage"), typeof(string));
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
		public bool AutoRecover
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoRecover"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoRecover", value);
			}
		}

		[JsonProperty(PropertyName = "idleRestartInterval")]
		[JsonPropertyName("idleRestartInterval")]
		public double IdleRestartInterval
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IdleRestartInterval"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IdleRestartInterval", value);
			}
		}

		[JsonProperty(PropertyName = "forcedRestartInterval")]
		[JsonPropertyName("forcedRestartInterval")]
		public double ForcedRestartInterval
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForcedRestartInterval"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForcedRestartInterval", value);
			}
		}

		[JsonProperty(PropertyName = "saveOnExit")]
		[JsonPropertyName("saveOnExit")]
		public bool SaveOnExit
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SaveOnExit"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SaveOnExit", value);
			}
		}

		[JsonProperty(PropertyName = "autosaveInterval")]
		[JsonPropertyName("autosaveInterval")]
		public double AutoSaveInterval
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoSaveInterval"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoSaveInterval", value);
			}
		}

		[JsonProperty(PropertyName = "autoSleep")]
		[JsonPropertyName("autoSleep")]
		public bool AutoSleep
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AutoSleep"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AutoSleep", value);
			}
		}

		[JsonProperty(PropertyName = "waitForLogin")]
		[JsonPropertyName("waitForLogin")]
		public bool WaitForLogin
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WaitForLogin"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WaitForLogin", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool Processed
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Processed"), typeof(bool));
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
		public string ContactUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactUserId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "contactUsername")]
		[JsonPropertyName("contactUsername")]
		public string ContactUsername
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactUsername"), typeof(string));
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
		public bool IsAccepted
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAccepted"), typeof(bool));
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
		public bool IsMigrated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[JsonProperty(PropertyName = "isCounterpartMigrated")]
		[JsonPropertyName("isCounterpartMigrated")]
		public bool IsCounterpartMigrated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsCounterpartMigrated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsCounterpartMigrated", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool IsSelfContact => OwnerId == ContactUserId;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool IsPartiallyMigrated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPartiallyMigrated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPartiallyMigrated", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool IsContactRequest
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsContactRequest"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsContactRequest", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool CanBeInteractedWith
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CanBeInteractedWith"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CanBeInteractedWith", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool IsValid
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsValid", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool ShouldBeHidden
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShouldBeHidden"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShouldBeHidden", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "friendUsername")]
		[JsonPropertyName("friendUsername")]
		public string LegacyFriendUsername
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyFriendUsername", value);
			}
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyFriendUsername"), typeof(string));
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

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public int BadgeCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BadgeCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BadgeCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override string FriendlyDescription
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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

		public override string FriendlyDescription => CreditType switch
		{
			CreditType.Basic => "Basic text credit", 
			CreditType.Prominent => "Prominent text credit", 
			CreditType.Spoken => "Spoken credit in videos/streams or prominent text", 
			CreditType.Sponsor => "Sponsor credit (spoken shoutout + text)", 
			_ => throw new NotImplementedException("Unsupported credit type: " + CreditType), 
		};

		public static ResoniteBridge.ResoniteBridgeValue GetTypeForAmount(decimal dollars)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CreditsEntitlement", ResoniteBridge.ResoniteBridgeValueType.Type), "GetTypeForAmount", dollars), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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
		public override string FriendlyDescription => "Automated deleted item/world recovery command";

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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
		public virtual bool IsLifetime => false;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public abstract string FriendlyDescription { get; }

		public abstract bool CombineWith(Entitlement other);

		public abstract bool SanitizeOrRemove();

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
		public override bool IsLifetime => true;

		[JsonProperty(PropertyName = "messageCount")]
		[JsonPropertyName("messageCount")]
		public int MessageCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MessageCount", value);
			}
		}

		public override string FriendlyDescription
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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
		public int GroupCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override string FriendlyDescription
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override bool CombineWith(Entitlement otherGroup)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", otherGroup), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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
		public override string FriendlyDescription => "Headless Server Access (send /headlessCode to Resonite in Contacts list to get the current code)";

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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

		public override string FriendlyDescription => ShoutoutType switch
		{
			LaunchShoutoutType.TextSmall => "Small shoutout in our launch posts", 
			LaunchShoutoutType.TextLarge => "Bigger shoutout in our launch posts", 
			LaunchShoutoutType.Verbal => "Verbal shoutout in our launch videos", 
			LaunchShoutoutType.Sponsor => "A big sponsor shoutout for launch", 
			_ => throw new NotImplementedException("Unsupported shoutout type: " + ShoutoutType), 
		};

		public static ResoniteBridge.ResoniteBridgeValue GetTypeForAmount(decimal dollars)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "LaunchShoutOutEntitlement", ResoniteBridge.ResoniteBridgeValueType.Type), "GetTypeForAmount", dollars), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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
		public long Bytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(long));
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
		public string StorageId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StorageId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StorageId", value);
			}
		}

		[JsonProperty(PropertyName = "group")]
		[JsonPropertyName("group")]
		public string Group
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(string));
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
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public string Description
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override string FriendlyDescription
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FriendlyDescription"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FriendlyDescription", value);
			}
		}

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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
		public string SupportSource { get; set; }

		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public string Username { get; set; }

		[JsonProperty(PropertyName = "iconUrl")]
		[JsonPropertyName("iconUrl")]
		public string IconURL { get; set; }

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public string UserId { get; set; }

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
		public override string FriendlyDescription => "Access to member-only worlds";

		public override bool CombineWith(Entitlement other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CombineWith", other), typeof(bool));
		}

		public override bool SanitizeOrRemove()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SanitizeOrRemove"), typeof(bool));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		public EntityId()
		{
		}

		public EntityId(string ownerId, string id)
		{
			Id = id;
			OwnerId = ownerId;
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(bool));
		}

		public bool Equals(EntityId other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public bool Equals(string other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
		}

		public static bool TryParse(string compositeId, out EntityId entityId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EntityId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId, entityId), typeof(bool));
		}

		public static EntityId TryParse(string compositeId)
		{
			return (EntityId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "EntityId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId), typeof(EntityId));
		}

		public static bool operator ==(EntityId a, EntityId b)
		{
			return a?.Equals(b) ?? ((object)b == null);
		}

		public static bool operator !=(EntityId a, EntityId b)
		{
			return !(a == b);
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(int));
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
		public int MessageIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessageIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MessageIndex", value);
			}
		}

		[JsonProperty(PropertyName = "message")]
		[JsonPropertyName("message")]
		public string Message
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Message"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Message", value);
			}
		}

		[JsonProperty(PropertyName = "addedByUserId")]
		[JsonPropertyName("addedByUserId")]
		public string AddedByUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AddedByUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AddedByUserId", value);
			}
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "popReceipt")]
		[JsonPropertyName("popReceipt")]
		public string PopReceipt
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PopReceipt"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PopReceipt", value);
			}
		}

		[JsonProperty(PropertyName = "blobKey")]
		[JsonPropertyName("blobKey")]
		public string BlobKey
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BlobKey"), typeof(string));
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
		public string QueueName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QueueName"), typeof(string));
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
		public static bool IsPubliclyReadable(this FavoriteEntity entity)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "FavoriteEntityHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsPubliclyReadable", entity), typeof(bool));
		}
	}
	public abstract class FundingEvent : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "amount")]
		[JsonPropertyName("amount")]
		public decimal Amount { get; set; }

		[JsonProperty(PropertyName = "currency")]
		[JsonPropertyName("currency")]
		public string Currency { get; set; }

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
		public bool IsInvalidated { get; set; }

		[JsonProperty(PropertyName = "entitlements")]
		[JsonPropertyName("entitlements")]
		public List<Entitlement> Entitlements { get; set; }

		[JsonProperty(PropertyName = "tierName")]
		[JsonPropertyName("tierName")]
		public string TierName { get; set; }

		[JsonProperty(PropertyName = "note")]
		[JsonPropertyName("note")]
		public string Note { get; set; }

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public bool IsValid => IsValidAtTime(DateTime.UtcNow);

		public bool IsValidAtTime(DateTime time)
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
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
		public int TierAmountCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierAmountCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TierAmountCents", value);
			}
		}

		[JsonProperty(PropertyName = "patronId")]
		[JsonPropertyName("patronId")]
		public string PatronId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatronId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatronId", value);
			}
		}

		[JsonProperty(PropertyName = "tierId")]
		[JsonPropertyName("tierId")]
		public string TierId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierId"), typeof(string));
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
		public string CustomerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomerId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
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
		public string CustomerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomerId", value);
			}
		}

		[JsonProperty("subscriptionId")]
		[JsonPropertyName("subscriptionId")]
		public string SubscriptionId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubscriptionId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubscriptionId", value);
			}
		}

		[JsonProperty("invoiceId")]
		[JsonPropertyName("invoiceId")]
		public string InvoiceId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InvoiceId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InvoiceId", value);
			}
		}

		[JsonProperty("tierId")]
		[JsonPropertyName("tierId")]
		public string TierId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TierId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TierId", value);
			}
		}

		[JsonProperty("eventId")]
		[JsonPropertyName("eventId")]
		public string EventId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EventId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EventId", value);
			}
		}

		[JsonProperty("isLive")]
		[JsonPropertyName("isLive")]
		public bool IsLive
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsLive"), typeof(bool));
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
		public string GroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "adminUserId")]
		[JsonPropertyName("adminUserId")]
		public string AdminUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AdminUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AdminUserId", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public bool IsMigrated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public ResoniteBridge.ResoniteBridgeValue LegacyQuotaBytes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public ResoniteBridge.ResoniteBridgeValue LegacyUsedBytes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
		public static OwnerType GetOwnerType(string id)
		{
			return (OwnerType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "IdUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "GetOwnerType", id), typeof(OwnerType));
		}
	}
	[Serializable]
	public struct RecordVersion : IEquatable<RecordVersion>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "globalVersion")]
		[JsonPropertyName("globalVersion")]
		public int GlobalVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GlobalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "localVersion")]
		[JsonPropertyName("localVersion")]
		public int LocalVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LocalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "lastModifyingUserId")]
		[JsonPropertyName("lastModifyingUserId")]
		public string LastModifyingUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModifyingUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModifyingUserId", value);
			}
		}

		[JsonProperty(PropertyName = "lastModifyingMachineId")]
		[JsonPropertyName("lastModifyingMachineId")]
		public string LastModifyingMachineId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModifyingMachineId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModifyingMachineId", value);
			}
		}

		public RecordVersion(int globalVersion, int localVersion, string lastModifyingUserId, string lastModifyingMachineId)
		{
			GlobalVersion = globalVersion;
			LocalVersion = localVersion;
			LastModifyingUserId = lastModifyingUserId;
			LastModifyingMachineId = lastModifyingMachineId;
		}

		public RecordVersion OverrideModifyingUserId(string userId)
		{
			return (RecordVersion)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideModifyingUserId", userId), typeof(RecordVersion));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
		}

		public bool Equals(RecordVersion other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(int));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(bool));
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
		public string MigrationId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationId", value);
			}
		}

		[JsonProperty(PropertyName = "migrationSource")]
		[JsonPropertyName("migrationSource")]
		public string MigrationSource
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationSource"), typeof(string));
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
		string RecordId { get; set; }

		string OwnerId { get; set; }

		string AssetURI { get; set; }

		[System.Text.Json.Serialization.JsonIgnore]
		RecordId CombinedRecordId { get; }

		RecordVersion Version { get; set; }

		string Name { get; set; }

		string OwnerName { get; set; }

		string Description { get; set; }

		string RecordType { get; set; }

		HashSet<string> Tags { get; set; }

		string Path { get; set; }

		string ThumbnailURI { get; set; }

		bool IsPublic { get; set; }

		bool IsForPatrons { get; set; }

		bool IsListed { get; set; }

		bool IsDeleted { get; set; }

		bool IsReadOnly { get; set; }

		int Visits { get; set; }

		double Rating { get; set; }

		int RandomOrder { get; set; }

		MigrationMetadata MigrationMetadata { get; set; }

		ResoniteBridge.ResoniteBridgeValue FirstPublishTime { get; set; }

		ResoniteBridge.ResoniteBridgeValue CreationTime { get; set; }

		DateTime LastModificationTime { get; set; }

		List<DBAsset> AssetManifest { get; set; }

		R Clone<R>() where R : class, IRecord, new();

		void IncrementGlobalVersion();

		void OverrideGlobalVersion(int globalVersion);

		void IncrementLocalVersion(string machineId, string userId);
	}
	public static class RecordHelper
	{
		public static string GenerateRecordID()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateRecordID"), typeof(string));
		}

		public static bool IsValidRecordID(string recordId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidRecordID", recordId), typeof(bool));
		}

		public static bool IsSameVersion(this RecordVersion version, RecordVersion otherVersion)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameVersion", version, otherVersion), typeof(bool));
		}

		public static bool CanOverwrite(this RecordVersion source, RecordVersion target, bool sourceDeleted = false, bool targetDeleted = false)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanOverwrite", source, target, sourceDeleted, targetDeleted), typeof(bool));
		}

		public static bool IsSameVersion(this IRecord record, IRecord other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameVersion", record, other), typeof(bool));
		}

		public static bool IsSameRecord(this IRecord record, IRecord other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSameRecord", record, other), typeof(bool));
		}

		public static void InheritPermissions(this IRecord record, IRecord source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "InheritPermissions", record, source);
		}

		public static bool CanOverwrite(this IRecord record, IRecord oldRecord)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanOverwrite", record, oldRecord), typeof(bool));
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

		public static R CreateForDirectory<R>(string ownerId, string rootPath, string name) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForDirectory", ownerId, rootPath, name), typeof(R));
		}

		public static R CreateForObject<R>(string name, string ownerId, string assetUrl, string thumbnailUrl = null, string recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForObject", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R));
		}

		public static R CreateForTexture<R>(string name, string ownerId, string assetUrl, string thumbnailUrl = null, string recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForTexture", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R));
		}

		public static R CreateForAudioClip<R>(string name, string ownerId, string assetUrl, string thumbnailUrl = null, string recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForAudioClip", name, ownerId, assetUrl, thumbnailUrl, recordId), typeof(R));
		}

		public static R CreateForLink<R>(string name, string ownerId, string targetUrl, string recordId = null) where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateForLink", name, ownerId, targetUrl, recordId), typeof(R));
		}
	}
	public class MarkReadBatch : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int MAX_BATCH_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_BATCH_SIZE", value);
			}
		}

		[JsonProperty(PropertyName = "senderId")]
		[JsonPropertyName("senderId")]
		public string SenderId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderId"), typeof(string));
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

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string UserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string GroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public bool IsMigrated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public ResoniteBridge.ResoniteBridgeValue LegacyQuotaBytes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public ResoniteBridge.ResoniteBridgeValue LegacyUsedBytes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(ResoniteBridge.ResoniteBridgeValue));
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
		public string UserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public string GroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "groupName")]
		[JsonPropertyName("groupName")]
		public string GroupName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupName", value);
			}
		}

		[JsonProperty(PropertyName = "isMigrated")]
		[JsonPropertyName("isMigrated")]
		public bool IsMigrated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(bool));
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
		public int MAX_ID_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_ID_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_ID_LENGTH", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsValid
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(bool));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "recipientId")]
		[JsonPropertyName("recipientId")]
		public string RecipientId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecipientId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecipientId", value);
			}
		}

		[JsonProperty(PropertyName = "senderId")]
		[JsonPropertyName("senderId")]
		public string SenderId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SenderId", value);
			}
		}

		[JsonProperty(PropertyName = "senderUserSessionId")]
		[JsonPropertyName("senderUserSessionId")]
		public string SenderUserSessionId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SenderUserSessionId"), typeof(string));
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
		public string Content
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Content"), typeof(string));
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
		public bool IsMigrated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigrated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigrated", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsSelfMessage
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSelfMessage"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsSelfMessage", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsSent => SenderId == OwnerId;

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsReceived => RecipientId == OwnerId;

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsRead
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsRead"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsRead", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public string OtherUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OtherUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OtherUserId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsPreFetched
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPreFetched"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPreFetched", value);
			}
		}

		public static string GenerateId()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Message", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateId"), typeof(string));
		}

		public static bool IsValidId(string id)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Message", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", id), typeof(bool));
		}

		public T ExtractContent<T>()
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractContent"), typeof(T));
		}

		public void SetContent<T>(T obj)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetContent", obj);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string PrimaryLocale
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrimaryLocale"), typeof(string));
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

		public void SetValue(T value, string locale = "en")
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value, locale);
		}

		public MultiLanguageValue()
		{
		}

		public MultiLanguageValue(T value, string locale = "en")
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
		public int LNL_PROTOCOL_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "LNL_PROTOCOL_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "LNL_PROTOCOL_VERSION", value);
			}
		}

		public static TimeSpan INFO_EXPIRATION => TimeSpan.FromMinutes(2.0);

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public string NodeId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeId"), typeof(string));
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
		public string NodeName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NodeName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NodeName", value);
			}
		}

		[JsonProperty(PropertyName = "address")]
		[JsonPropertyName("address")]
		public string Address
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Address"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Address", value);
			}
		}

		[JsonProperty(PropertyName = "port")]
		[JsonPropertyName("port")]
		public ushort Port
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Port"), typeof(ushort));
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
		public int ProtocolVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProtocolVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ProtocolVersion", value);
			}
		}

		[JsonProperty(PropertyName = "userCount")]
		[JsonPropertyName("userCount")]
		public int UserCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserCount", value);
			}
		}

		[JsonProperty(PropertyName = "capacity")]
		[JsonPropertyName("capacity")]
		public int Capacity
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Capacity"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Capacity", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public bool HasCapacity
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasCapacity"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasCapacity", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsShuttingDown => Capacity == 0;

		[JsonProperty(PropertyName = "universeId")]
		[JsonPropertyName("universeId")]
		public string UniverseId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(string));
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

		public bool ShouldUse(int protocolVersion = 2, ResoniteBridge.ResoniteBridgeValue preference = null, string universeId = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ShouldUse", protocolVersion, preference, universeId), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		public string ClientId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ClientId", value);
			}
		}

		public string ClientSecret
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientSecret"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ClientSecret", value);
			}
		}

		public string ClientType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ClientType"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ClientType", value);
			}
		}

		public string DisplayName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DisplayName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DisplayName", value);
			}
		}

		public string ConsentType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConsentType"), typeof(string));
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
		public string ApplicationId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApplicationId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ApplicationId", value);
			}
		}

		public string AuthorizationId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthorizationId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AuthorizationId", value);
			}
		}

		public string ReferenceId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferenceId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ReferenceId", value);
			}
		}

		public string Status
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Status", value);
			}
		}

		public string Subject
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Subject"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Subject", value);
			}
		}

		public string Type
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Type"), typeof(string));
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
		public int RegisteredUsers
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RegisteredUsers"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RegisteredUsers", value);
			}
		}

		[JsonProperty(PropertyName = "presentUsers")]
		[JsonPropertyName("presentUsers")]
		public int PresentUsers
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PresentUsers"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PresentUsers", value);
			}
		}

		[JsonProperty(PropertyName = "awayUsers")]
		[JsonPropertyName("awayUsers")]
		public int AwayUsers
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AwayUsers"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AwayUsers", value);
			}
		}

		[JsonProperty(PropertyName = "instanceCount")]
		[JsonPropertyName("instanceCount")]
		public int InstanceCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InstanceCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InstanceCount", value);
			}
		}

		[JsonProperty(PropertyName = "usersInVR")]
		[JsonPropertyName("usersInVR")]
		public int UsersInVR
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVR"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInVR", value);
			}
		}

		[JsonProperty(PropertyName = "usersInScreen")]
		[JsonPropertyName("usersInScreen")]
		public int UsersInScreen
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInScreen"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInScreen", value);
			}
		}

		[JsonProperty(PropertyName = "usersOnDesktop")]
		[JsonPropertyName("usersOnDesktop")]
		public int UsersOnDesktop
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersOnDesktop"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersOnDesktop", value);
			}
		}

		[JsonProperty(PropertyName = "usersOnMobile")]
		[JsonPropertyName("usersOnMobile")]
		public int UsersOnMobile
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersOnMobile"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersOnMobile", value);
			}
		}

		[JsonProperty(PropertyName = "usersInVisiblePublicSessions")]
		[JsonPropertyName("usersInVisiblePublicSessions")]
		public int UsersInVisiblePublicSessions
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVisiblePublicSessions"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInVisiblePublicSessions", value);
			}
		}

		[JsonProperty(PropertyName = "usersInVisibleSemiAccessibleSessions")]
		[JsonPropertyName("usersInVisibleSemiAccessibleSessions")]
		public int UsersInVisibleSemiAccessibleSessions
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInVisibleSemiAccessibleSessions"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInVisibleSemiAccessibleSessions", value);
			}
		}

		[JsonProperty(PropertyName = "usersInHiddenSessions")]
		[JsonPropertyName("usersInHiddenSessions")]
		public int UsersInHiddenSessions
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInHiddenSessions"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsersInHiddenSessions", value);
			}
		}

		[JsonProperty(PropertyName = "usersInPrivateSessions")]
		[JsonPropertyName("usersInPrivateSessions")]
		public int UsersInPrivateSessions
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsersInPrivateSessions"), typeof(int));
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

		public int GetUsersBySessionAccessLevel(SessionAccessLevel accessLevel)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsersBySessionAccessLevel", accessLevel), typeof(int));
		}

		public int GetUsersByClientType(UserSessionType type)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsersByClientType", type), typeof(int));
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
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonPropertyName("shortNamePrefix")]
		public string ShortNamePrefix
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShortNamePrefix"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShortNamePrefix", value);
			}
		}

		[JsonPropertyName("abbreviation")]
		public string Abbreviation
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Abbreviation"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Abbreviation", value);
			}
		}

		[JsonPropertyName("domain")]
		public string Domain
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Domain"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Domain", value);
			}
		}

		[JsonPropertyName("moderationURL")]
		public string ModerationUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModerationUrl"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModerationUrl", value);
			}
		}

		[JsonPropertyName("supportURL")]
		public string SupportUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SupportUrl"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SupportUrl", value);
			}
		}

		[JsonPropertyName("policiesPage")]
		public string PoliciesPage
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PoliciesPage"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PoliciesPage", value);
			}
		}

		[JsonPropertyName("email")]
		public string Email
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonPropertyName("discordInviteURL")]
		public string DiscordInviteUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DiscordInviteUrl"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DiscordInviteUrl", value);
			}
		}

		[JsonPropertyName("patreonURL")]
		public string PatreonUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonUrl"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatreonUrl", value);
			}
		}

		[JsonPropertyName("gitHubProfile")]
		public string GitHubProfile
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubProfile"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GitHubProfile", value);
			}
		}

		[JsonPropertyName("gitHubIssuesRepository")]
		public string GitHubIssuesRepository
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GitHubIssuesRepository"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GitHubIssuesRepository", value);
			}
		}

		[JsonPropertyName("webRecordEndpoint")]
		public string WebRecordEndpoint
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WebRecordEndpoint"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WebRecordEndpoint", value);
			}
		}

		[JsonPropertyName("webSessionEndpoint")]
		public string WebSessionEndpoint
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WebSessionEndpoint"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WebSessionEndpoint", value);
			}
		}

		[JsonPropertyName("groupId")]
		public string GroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupId", value);
			}
		}

		[JsonPropertyName("teamGroupId")]
		public string TeamGroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TeamGroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TeamGroupId", value);
			}
		}

		[JsonPropertyName("computeGroupId")]
		public string ComputeGroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeGroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeGroupId", value);
			}
		}

		[JsonPropertyName("networkGroupId")]
		public string NetworkGroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkGroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkGroupId", value);
			}
		}

		[JsonPropertyName("appUsername")]
		public string AppUsername
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUsername"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppUsername", value);
			}
		}

		[JsonPropertyName("devBotUsername")]
		public string DevBotUsername
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUsername"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DevBotUsername", value);
			}
		}

		[JsonPropertyName("computeUsername")]
		public string ComputeUsername
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUsername"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeUsername", value);
			}
		}

		[JsonPropertyName("networkUsername")]
		public string NetworkUsername
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUsername"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkUsername", value);
			}
		}

		[JsonPropertyName("appUserId")]
		public string AppUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppUserId", value);
			}
		}

		[JsonPropertyName("devBotUserId")]
		public string DevBotUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DevBotUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DevBotUserId", value);
			}
		}

		[JsonPropertyName("computeUserId")]
		public string ComputeUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ComputeUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ComputeUserId", value);
			}
		}

		[JsonPropertyName("networkUserId")]
		public string NetworkUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkUserId", value);
			}
		}

		[JsonPropertyName("authScheme")]
		public string AuthScheme
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthScheme"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AuthScheme", value);
			}
		}

		[JsonPropertyName("appScheme")]
		public string AppScheme
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppScheme"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppScheme", value);
			}
		}

		[JsonPropertyName("dbScheme")]
		public string DBScheme
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DBScheme"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DBScheme", value);
			}
		}

		[JsonPropertyName("sessionScheme")]
		public string SessionScheme
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionScheme"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionScheme", value);
			}
		}

		[JsonPropertyName("recordScheme")]
		public string RecordScheme
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordScheme"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordScheme", value);
			}
		}

		[JsonPropertyName("userSessionScheme")]
		public string UserSessionScheme
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionScheme"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserSessionScheme", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public string BaseInventoryUrl => RecordScheme + ":///" + GroupId + "/Inventory/";

		public string SteamAppId => "2519830";

		public long DiscordAppId => 1159154461059592333L;

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

		public static void LoadLegacyProfiles(string path)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PlatformProfile", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadLegacyProfiles", path);
		}

		public PlatformProfile()
		{
		}

		public PlatformProfile(string name, string shortNamePrefix, string abbreviation)
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

		public string FavoriteVariable(FavoriteEntity entity)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FavoriteVariable", entity), typeof(string));
		}

		public string VariablePath(string subpath)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariablePath", subpath), typeof(string));
		}

		public bool IsPlatformOwnerId(string ownerId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPlatformOwnerId", ownerId), typeof(bool));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordUri(string ownerId, string recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", ownerId, recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(string ownerId, string recordId)
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

		public ResoniteBridge.ResoniteBridgeValue GetInventoryItemUri(string itemPath)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetInventoryItemUri", itemPath), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSpawnObjectUri(string itemPath)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSpawnObjectUri", itemPath), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordPath(string recordPath)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordPath", recordPath), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordUri(string recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordUri", recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSessionUri(string sessionId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionUri", sessionId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSessionWebUri(string sessionId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionWebUri", sessionId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public bool ExtractRecordID(ResoniteBridge.ResoniteBridgeValue recordUri, out string ownerId, out string recordId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractRecordID", recordUri, ownerId, recordId), typeof(bool));
		}

		public bool ExtractRecordPath(ResoniteBridge.ResoniteBridgeValue recordUri, out string ownerId, out string recordPath)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractRecordPath", recordUri, ownerId, recordPath), typeof(bool));
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
		string Name { get; }

		string ShortNamePrefix { get; }

		string Abbreviation { get; }

		string Domain { get; }

		string ModerationUrl { get; }

		string SupportUrl { get; }

		string Email { get; }

		string DiscordInviteUrl { get; }

		string PoliciesPage { get; }

		string PatreonUrl { get; }

		string GitHubProfile { get; }

		string GitHubIssuesRepository { get; }

		string GroupId { get; }

		string TeamGroupId { get; }

		string ComputeGroupId { get; }

		string NetworkGroupId { get; }

		string AppUsername { get; }

		string DevBotUsername { get; }

		string ComputeUsername { get; }

		string NetworkUsername { get; }

		string AppUserId { get; }

		string DevBotUserId { get; }

		string ComputeUserId { get; }

		string NetworkUserId { get; }

		string AuthScheme { get; }

		string AppScheme { get; }

		string DBScheme { get; }

		string SessionScheme { get; }

		string RecordScheme { get; }

		string UserSessionScheme { get; }

		string BaseInventoryUrl { get; }

		string SteamAppId { get; }

		long DiscordAppId { get; }

		IEnumerable<string> PlatformVariables { get; }

		bool IsPlatformOwnerId(string ownerId);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(string ownerId, string recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(RecordId recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(IRecord recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(string ownerId, string recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(RecordId recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecordWebUri(IRecord recordId);

		ResoniteBridge.ResoniteBridgeValue GetInventoryItemUri(string itemPath);

		ResoniteBridge.ResoniteBridgeValue GetSpawnObjectUri(string itemPath);

		ResoniteBridge.ResoniteBridgeValue GetRecordPath(string recordPath);

		ResoniteBridge.ResoniteBridgeValue GetRecordUri(string recordId);

		ResoniteBridge.ResoniteBridgeValue GetSessionUri(string sessionId);

		ResoniteBridge.ResoniteBridgeValue GetSessionWebUri(string sessionId);

		bool ExtractRecordID(ResoniteBridge.ResoniteBridgeValue recordUri, out string ownerId, out string recordId);

		bool ExtractRecordPath(ResoniteBridge.ResoniteBridgeValue recordUri, out string ownerId, out string recordPath);

		string FavoriteVariable(FavoriteEntity entity);

		string VariablePath(string subpath);
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
		public string Token
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Token", value);
			}
		}

		[JsonProperty(PropertyName = "fromUserId")]
		[JsonPropertyName("fromUserId")]
		public string FromUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FromUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FromUserId", value);
			}
		}

		[JsonProperty(PropertyName = "toUserId")]
		[JsonPropertyName("toUserId")]
		public string ToUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ToUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ToUserId", value);
			}
		}

		[JsonProperty(PropertyName = "amount")]
		[JsonPropertyName("amount")]
		public decimal Amount
		{
			get
			{
				return (decimal)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Amount"), typeof(decimal));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Amount", value);
			}
		}

		[JsonProperty(PropertyName = "comment")]
		[JsonPropertyName("comment")]
		public string Comment
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Comment"), typeof(string));
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
		public bool Anonymous
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Anonymous"), typeof(bool));
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
		public string TASK_KEY
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "TASK_KEY"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "TASK_KEY", value);
			}
		}

		public string PRIORITY_ISSUES_ID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "PRIORITY_ISSUES_ID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "PRIORITY_ISSUES_ID", value);
			}
		}

		[JsonProperty(PropertyName = "title")]
		[JsonPropertyName("title")]
		public string Title
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Title"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Title", value);
			}
		}

		[JsonProperty(PropertyName = "issueNumber")]
		[JsonPropertyName("issueNumber")]
		public int IssueNumber
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueNumber"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IssueNumber", value);
			}
		}

		[JsonProperty(PropertyName = "issueURL")]
		[JsonPropertyName("issueURL")]
		public string IssueURL
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IssueURL"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IssueURL", value);
			}
		}

		[JsonProperty(PropertyName = "voteCount")]
		[JsonPropertyName("voteCount")]
		public int VoteCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VoteCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VoteCount", value);
			}
		}

		[JsonProperty(PropertyName = "activePledgeScore")]
		[JsonPropertyName("activePledgeScore")]
		public double ActivePledgeScore
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActivePledgeScore"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActivePledgeScore", value);
			}
		}

		[JsonProperty(PropertyName = "lifetimePledgeScore")]
		[JsonPropertyName("lifetimePledgeScore")]
		public double LifetimePledgeScore
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LifetimePledgeScore"), typeof(double));
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
		public string RecipientId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecipientId"), typeof(string));
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
		public string RecordId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "assetUri")]
		[JsonPropertyName("assetUri")]
		public string AssetURI
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURI"), typeof(string));
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
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("description")]
		public string Description
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "recordType")]
		[JsonPropertyName("recordType")]
		public string RecordType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordType"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordType", value);
			}
		}

		[JsonProperty(PropertyName = "ownerName")]
		[JsonPropertyName("ownerName")]
		public string OwnerName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerName"), typeof(string));
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
		public string Path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		[JsonProperty(PropertyName = "thumbnailUri", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("thumbnailUri")]
		public string ThumbnailURI
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailURI"), typeof(string));
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
		public bool IsDeleted
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDeleted"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsDeleted", value);
			}
		}

		[JsonProperty(PropertyName = "isPublic")]
		[JsonPropertyName("isPublic")]
		public bool IsPublic
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPublic"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPublic", value);
			}
		}

		[JsonProperty(PropertyName = "isForPatrons")]
		[JsonPropertyName("isForPatrons")]
		public bool IsForPatrons
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsForPatrons"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsForPatrons", value);
			}
		}

		[JsonProperty(PropertyName = "isListed")]
		[JsonPropertyName("isListed")]
		public bool IsListed
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListed"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsListed", value);
			}
		}

		[JsonProperty(PropertyName = "isReadOnly")]
		[JsonPropertyName("isReadOnly")]
		public bool IsReadOnly
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsReadOnly"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsReadOnly", value);
			}
		}

		[JsonProperty(PropertyName = "visits")]
		[JsonPropertyName("visits")]
		public int Visits
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Visits"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Visits", value);
			}
		}

		[JsonProperty(PropertyName = "rating")]
		[JsonPropertyName("rating")]
		public double Rating
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Rating"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Rating", value);
			}
		}

		[JsonProperty(PropertyName = "randomOrder")]
		[JsonPropertyName("randomOrder")]
		public int RandomOrder
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RandomOrder"), typeof(int));
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
		public bool IsValidOwnerId => IdUtil.GetOwnerType(OwnerId) != OwnerType.INVALID;

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsValidRecordId => RecordHelper.IsValidRecordID(RecordId);

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
		public @int LegacyGlobalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyGlobalVersion", value);
			}
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyGlobalVersion"), typeof(@int));
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "localVersion")]
		[JsonPropertyName("localVersion")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public @int LegacyLocalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLocalVersion", value);
			}
			get
			{
				return (@int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyLocalVersion"), typeof(@int));
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "lastModifyingUserId")]
		[JsonPropertyName("lastModifyingUserId")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public string LegacyLastModifyingUserId
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLastModifyingUserId", value);
			}
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyLastModifyingUserId"), typeof(string));
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "lastModifyingMachineId")]
		[JsonPropertyName("lastModifyingMachineId")]
		[System.Text.Json.Serialization.JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
		public string LegacyLastModifyingMachineId
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLastModifyingMachineId", value);
			}
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyLastModifyingMachineId"), typeof(string));
			}
		}

		public static bool IsValidId(string recordId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "Record", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", recordId), typeof(bool));
		}

		public void ResetVersioning()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetVersioning");
		}

		public void OverrideGlobalVersion(int globalVersion)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OverrideGlobalVersion", globalVersion);
		}

		public void IncrementGlobalVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IncrementGlobalVersion");
		}

		public void IncrementLocalVersion(string machineId, string userId)
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

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
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
		public string RecordId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(string));
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
		public string ModifyingUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModifyingUserId", value);
			}
		}

		[JsonProperty(PropertyName = "modifyingMachineId")]
		[JsonPropertyName("modifyingMachineId")]
		public string ModifyingMachineId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingMachineId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModifyingMachineId", value);
			}
		}

		[JsonProperty(PropertyName = "modifyingSource")]
		[JsonPropertyName("modifyingSource")]
		public string ModifyingSource
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ModifyingSource"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ModifyingSource", value);
			}
		}

		[JsonProperty(PropertyName = "originalAssetUrl")]
		[JsonPropertyName("originalAssetUrl")]
		public string OriginalAssetURL
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalAssetURL"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalAssetURL", value);
			}
		}

		[JsonProperty(PropertyName = "originalName")]
		[JsonPropertyName("originalName")]
		public string OriginalName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalName", value);
			}
		}

		[JsonProperty(PropertyName = "originalPath")]
		[JsonPropertyName("originalPath")]
		public string OriginalPath
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalPath"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalPath", value);
			}
		}

		[JsonProperty(PropertyName = "originalGlobalVersion")]
		[JsonPropertyName("originalGlobalVersion")]
		public int OriginalGlobalVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalGlobalVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalGlobalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "originalLocalVersion")]
		[JsonPropertyName("originalLocalVersion")]
		public int OriginalLocalVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalLocalVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalLocalVersion", value);
			}
		}

		[JsonProperty(PropertyName = "originalModifyingMachineId")]
		[JsonPropertyName("originalModifyingMachineId")]
		public string OriginalModifyingMachineId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalModifyingMachineId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalModifyingMachineId", value);
			}
		}

		[JsonProperty(PropertyName = "originalModifyingUserId")]
		[JsonPropertyName("originalModifyingUserId")]
		public string OriginalModifyingUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OriginalModifyingUserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OriginalModifyingUserId", value);
			}
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsValid => IsValidId(OwnerId, Id);

		public string ToURL(IPlatformProfile platform)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToURL", platform), typeof(string));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(int));
		}

		public bool Equals(RecordId other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public bool Equals(string other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public RecordId(string ownerId, string recordId)
		{
			OwnerId = ownerId;
			Id = recordId;
		}

		public RecordId()
		{
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
		}

		public static bool IsValidId(string ownerId, string id)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", ownerId, id), typeof(bool));
		}

		public static bool TryParse(string compositeId, out RecordId recordId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId, recordId), typeof(bool));
		}

		public static RecordId TryParse(string compositeId)
		{
			return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "RecordId", ResoniteBridge.ResoniteBridgeValueType.Type), "TryParse", compositeId), typeof(RecordId));
		}

		public static bool operator ==(RecordId a, RecordId b)
		{
			return a?.Equals(b) ?? ((object)b == null);
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "assetUri")]
		[JsonPropertyName("assetUri")]
		public string AssetURI
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURI"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetURI", value);
			}
		}

		[JsonProperty(PropertyName = "thumbnailUri")]
		[JsonPropertyName("thumbnailUri")]
		public string ThumbnailURI
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailURI"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailURI", value);
			}
		}

		[JsonProperty(PropertyName = "globalVersion")]
		[JsonPropertyName("globalVersion")]
		public int GlobalVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GlobalVersion"), typeof(int));
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
		public string PreprocessId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreprocessId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreprocessId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "recordId")]
		[JsonPropertyName("recordId")]
		public string RecordId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordId"), typeof(string));
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
		public float Progress
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Progress"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Progress", value);
			}
		}

		[JsonProperty(PropertyName = "failReason")]
		[JsonPropertyName("failReason")]
		public string FailReason
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FailReason"), typeof(string));
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
		private bool _isNormalized
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_isNormalized"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_isNormalized", value);
			}
		}

		[JsonProperty(PropertyName = "count")]
		[JsonPropertyName("count")]
		public int Count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Count", value);
			}
		}

		[JsonProperty(PropertyName = "offset")]
		[JsonPropertyName("offset")]
		public int Offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Offset", value);
			}
		}

		[JsonProperty(PropertyName = "private")]
		[JsonPropertyName("private")]
		public bool Private
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Private"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Private", value);
			}
		}

		[JsonProperty(PropertyName = "byOwner")]
		[JsonPropertyName("byOwner")]
		public string ByOwner
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ByOwner"), typeof(string));
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
		public string SubmittedTo
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedTo"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubmittedTo", value);
			}
		}

		[JsonProperty(PropertyName = "onlyFeatured")]
		[JsonPropertyName("onlyFeatured")]
		public bool OnlyFeatured
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyFeatured"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlyFeatured", value);
			}
		}

		[JsonProperty(PropertyName = "recordType")]
		[JsonPropertyName("recordType")]
		public string RecordType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordType"), typeof(string));
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

		public bool IsValid
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(bool));
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

		public bool Equals(SearchParameters other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public bool Equals(SearchParameters other, bool excludeOffsetAndCount)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other, excludeOffsetAndCount), typeof(bool));
		}

		private static bool ListsEqual(List<string> a, List<string> b)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "SearchParameters", ResoniteBridge.ResoniteBridgeValueType.Type), "ListsEqual", a, b), typeof(bool));
		}

		public static bool operator ==(SearchParameters a, SearchParameters b)
		{
			if ((object)a == null && (object)b == null)
			{
				return true;
			}
			if ((object)a == null || (object)b == null)
			{
				return false;
			}
			return a.Equals(b);
		}

		public static bool operator !=(SearchParameters a, SearchParameters b)
		{
			return !(a == b);
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(int));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(bool));
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
		public bool HasMoreResults
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasMoreResults"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasMoreResults", value);
			}
		}

		public SearchResults()
		{
		}

		public SearchResults(List<R> records, bool hasMore)
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
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "verificationKey")]
		[JsonPropertyName("verificationKey")]
		public string VerificationKey
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VerificationKey"), typeof(string));
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
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public string KeyId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "KeyId"), typeof(string));
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

		public static string GenerateId(string baseId = null)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateId", baseId), typeof(string));
		}

		public static bool IsValidId(string id)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", id), typeof(bool));
		}

		public static string GenerateRecordAccessBaseId(string accessingOwnerId, string recordId)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "OneTimeVerificationKey", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateRecordAccessBaseId", accessingOwnerId, recordId), typeof(string));
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
		public string UserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "secretKeyBase32")]
		[JsonPropertyName("secretKeyBase32")]
		public string SecretKeyBase32
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretKeyBase32"), typeof(string));
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
		public long ResponseTimeMilliseconds
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ResponseTimeMilliseconds"), typeof(long));
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
		public long MAX_SHARE_BYTES
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_SHARE_BYTES"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_SHARE_BYTES", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "bytes")]
		[JsonPropertyName("bytes")]
		public long Bytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Bytes"), typeof(long));
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
		public string Group
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Group"), typeof(string));
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
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "description")]
		[JsonPropertyName("description")]
		public string Description
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsExpired => IsExpiredAtTime(DateTime.UtcNow);

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsActive => IsActiveAtTime(DateTime.UtcNow);

		public bool IsActiveAtTime(DateTime timePoint)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsActiveAtTime", timePoint), typeof(bool));
		}

		public bool IsExpiredAtTime(DateTime timePoint)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsExpiredAtTime", timePoint), typeof(bool));
		}

		public bool Overrides(QuotaSource otherSource)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Overrides", otherSource), typeof(bool));
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
		public string TargetOwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TargetOwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TargetOwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "shareRatio")]
		[JsonPropertyName("shareRatio")]
		public float ShareRatio
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShareRatio"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShareRatio", value);
			}
		}

		[JsonProperty(PropertyName = "maxShareBytes")]
		[JsonPropertyName("maxShareBytes")]
		public long MaxShareBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxShareBytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxShareBytes", value);
			}
		}

		[JsonProperty(PropertyName = "currentShareBytes")]
		[JsonPropertyName("currentShareBytes")]
		public long CurrentShareBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentShareBytes"), typeof(long));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public long UsedBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsedBytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UsedBytes", value);
			}
		}

		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public long QuotaBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QuotaBytes", value);
			}
		}

		[JsonProperty(PropertyName = "fullQuotaBytes")]
		[JsonPropertyName("fullQuotaBytes")]
		public long FullQuotaBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FullQuotaBytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FullQuotaBytes", value);
			}
		}

		[JsonProperty(PropertyName = "shareableQuotaBytes")]
		[JsonPropertyName("shareableQuotaBytes")]
		public long ShareableQuotaBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShareableQuotaBytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShareableQuotaBytes", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public long SharedQuotaBytes => FullQuotaBytes - QuotaBytes;

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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string GroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupId"), typeof(string));
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
		public string SubmittedById
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedById"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubmittedById", value);
			}
		}

		[JsonProperty(PropertyName = "submittedByName")]
		[JsonPropertyName("submittedByName")]
		public string SubmittedByName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubmittedByName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SubmittedByName", value);
			}
		}

		[JsonProperty(PropertyName = "featured")]
		[JsonPropertyName("featured")]
		public bool Featured
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Featured"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Featured", value);
			}
		}

		[JsonProperty(PropertyName = "featuredByUserId")]
		[JsonPropertyName("featuredByUserId")]
		public string FeaturedByUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FeaturedByUserId"), typeof(string));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
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
		public string UploaderIP
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderIP"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploaderIP", value);
			}
		}

		[JsonProperty(PropertyName = "sessionId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("sessionId")]
		public string SessionId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionId", value);
			}
		}

		[JsonProperty(PropertyName = "uploaderOwnerId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("uploaderOwnerId")]
		public string UploaderOwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploaderOwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploaderOwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "signature")]
		[JsonPropertyName("signature")]
		public string Signature
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Signature"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Signature", value);
			}
		}

		[JsonProperty(PropertyName = "uploadEndpoint")]
		[JsonPropertyName("uploadEndpoint")]
		public string UploadEndpoint
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadEndpoint"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadEndpoint", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public string SignatureDataString => Id + Timestamp.ToString("o", CultureInfo.InvariantCulture);

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public byte[] SignatureData => Encoding.UTF8.GetBytes(SignatureDataString);

		public static string GenerateID()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "ThumbnailInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateID"), typeof(string));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
		[JsonPropertyName("name")]
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Name", value);
			}
		}

		[JsonProperty(PropertyName = "primaryGroupId")]
		[JsonPropertyName("primaryGroupId")]
		public string PrimaryGroupId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrimaryGroupId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrimaryGroupId", value);
			}
		}

		public bool IsPrimaryGroup(string groupId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPrimaryGroup", groupId), typeof(bool));
		}

		public ResoniteBridge.ResoniteBridgeValue GetBaseUri(IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBaseUri", platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetBaseInventoryUri(IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBaseInventoryUri", platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetSpawnObjectUri(string itemPath, IPlatformProfile platform)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSpawnObjectUri", itemPath, platform), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordAtPath(string recordPath, IPlatformProfile platform)
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
		public string UserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "token")]
		[JsonPropertyName("token")]
		public string SessionToken
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionToken"), typeof(string));
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
		public string SecretMachineIdHash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineIdHash"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretMachineIdHash", value);
			}
		}

		[NullOnExternal]
		[JsonProperty(PropertyName = "secretMachineIdSalt")]
		[JsonPropertyName("secretMachineIdSalt")]
		public string SecretMachineIdSalt
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineIdSalt"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretMachineIdSalt", value);
			}
		}

		[JsonProperty(PropertyName = "uidHash")]
		[JsonPropertyName("uidHash")]
		public string UID_Hash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID_Hash"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UID_Hash", value);
			}
		}

		[JsonProperty(PropertyName = "uidSalt")]
		[JsonPropertyName("uidSalt")]
		public string UID_Salt
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID_Salt"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UID_Salt", value);
			}
		}

		[JsonProperty(PropertyName = "rememberMe")]
		[JsonPropertyName("rememberMe")]
		public bool RememberMe
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RememberMe"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RememberMe", value);
			}
		}

		[JsonProperty(PropertyName = "isMachineBound")]
		[JsonPropertyName("isMachineBound")]
		public bool IsMachineBound
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMachineBound"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMachineBound", value);
			}
		}

		[JsonProperty("logoutUrl")]
		[JsonPropertyName("logoutUrl")]
		public string LogoutUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LogoutUrl"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LogoutUrl", value);
			}
		}

		[JsonProperty("logoutUrlClientSide")]
		[JsonPropertyName("logoutUrlClientSide")]
		public bool LogoutUrlClientSide
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LogoutUrlClientSide"), typeof(bool));
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
		public int SessionLoginCounter
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionLoginCounter"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionLoginCounter", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsExpired => DateTime.UtcNow > SessionExpire.ToUniversalTime();

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

		public static BroadcastTarget ToContact(string userId)
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

		public BroadcastTarget(BroadcastGroup group, string targetId)
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
			if (targetIds.Any((string id) => string.IsNullOrEmpty(id)))
			{
				throw new ArgumentException("One of the TargetIds is empty");
			}
			Group = group;
			TargetIds = new List<string>(targetIds);
		}

		public static bool RequiresTargetIds(BroadcastGroup group)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "BroadcastTarget", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresTargetIds", group), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(bool));
		}

		public bool Equals(BroadcastTarget other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(int));
		}

		public static bool operator ==(BroadcastTarget a, BroadcastTarget b)
		{
			if ((object)a == null && (object)b == null)
			{
				return true;
			}
			if ((object)a == null || (object)b == null)
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
		public int TotalCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalCents", value);
			}
		}

		[JsonProperty(PropertyName = "patreonRawCents")]
		[JsonPropertyName("patreonRawCents")]
		public int PatreonRawCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonRawCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatreonRawCents", value);
			}
		}

		[JsonProperty(PropertyName = "deltaCents")]
		[JsonPropertyName("deltaCents")]
		public int DeltaCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DeltaCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DeltaCents", value);
			}
		}

		[JsonProperty(PropertyName = "pledgeCents")]
		[JsonPropertyName("pledgeCents")]
		public int PledgeCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PledgeCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PledgeCents", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public string Email
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(string));
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
		public string Email
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[NullOnExternal]
		[JsonProperty(PropertyName = "lastPatreonEmail")]
		[JsonPropertyName("lastPatreonEmail")]
		public string LastPatreonEmail
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPatreonEmail"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastPatreonEmail", value);
			}
		}

		[JsonProperty(PropertyName = "isPatreonSupporter")]
		[JsonPropertyName("isPatreonSupporter")]
		public bool IsPatreonSupporter
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPatreonSupporter"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPatreonSupporter", value);
			}
		}

		[JsonProperty(PropertyName = "patreonId")]
		[JsonPropertyName("patreonId")]
		public string PatreonID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PatreonID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PatreonID", value);
			}
		}

		[JsonProperty(PropertyName = "lastPatreonPledgeCents")]
		[JsonPropertyName("lastPatreonPledgeCents")]
		public int LastPatreonPledgeCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPatreonPledgeCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastPatreonPledgeCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastTotalCents")]
		[JsonPropertyName("lastTotalCents")]
		public int LastTotalCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTotalCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastTotalCents", value);
			}
		}

		[JsonProperty(PropertyName = "minimumTotalUnits")]
		[JsonPropertyName("minimumTotalUnits")]
		public int MinimumTotalUnits
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MinimumTotalUnits"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MinimumTotalUnits", value);
			}
		}

		[JsonProperty(PropertyName = "externalCents")]
		[JsonPropertyName("externalCents")]
		public int ExternalCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExternalCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ExternalCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastExternalCents")]
		[JsonPropertyName("lastExternalCents")]
		public int LastExternalCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastExternalCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastExternalCents", value);
			}
		}

		[JsonProperty(PropertyName = "hasSupported")]
		[JsonPropertyName("hasSupported")]
		public bool HasSupported
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasSupported"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasSupported", value);
			}
		}

		[JsonProperty(PropertyName = "rewardType")]
		[JsonPropertyName("rewardType")]
		public string RewardType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RewardType"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RewardType", value);
			}
		}

		[JsonProperty(PropertyName = "customTier")]
		[JsonPropertyName("customTier")]
		public string CustomTier
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CustomTier"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CustomTier", value);
			}
		}

		[JsonProperty(PropertyName = "priorityIssue")]
		[JsonPropertyName("priorityIssue")]
		public int PriorityIssue
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PriorityIssue"), typeof(int));
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
		public int LastPaidPledgeAmount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPaidPledgeAmount"), typeof(int));
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
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public string Username
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public string Email
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(string));
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
		public string SecretMachineId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretMachineId", value);
			}
		}

		[JsonProperty(PropertyName = "rememberMe")]
		[JsonPropertyName("rememberMe")]
		public bool RememberMe
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RememberMe"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RememberMe", value);
			}
		}

		[JsonProperty(PropertyName = "machineBound")]
		[JsonPropertyName("machineBound")]
		public bool MachineBound
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MachineBound"), typeof(bool));
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

		public static LoginCredentials FromCredentialAuto(string credential, LoginAuthentication authentication)
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
		public abstract bool IsValidForLogin { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		public abstract bool IsValidForRegistration { get; }

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
		public override bool IsValidForRegistration => CryptoHelper.IsValidPassword(Password);

		[System.Text.Json.Serialization.JsonIgnore]
		public override bool IsValidForLogin => !string.IsNullOrEmpty(Password);

		[JsonProperty(PropertyName = "password", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("password")]
		public string Password
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Password"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Password", value);
			}
		}

		[JsonPropertyName("recoveryCode")]
		public string RecoveryCode
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecoveryCode"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecoveryCode", value);
			}
		}

		public PasswordLogin()
		{
		}

		public PasswordLogin(string password)
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
		public override bool IsValidForLogin => !string.IsNullOrWhiteSpace(SessionToken);

		public override bool IsValidForRegistration => false;

		[JsonProperty(PropertyName = "sessionToken", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("sessionToken")]
		public string SessionToken
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionToken"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionToken", value);
			}
		}

		public SessionTokenLogin()
		{
		}

		public SessionTokenLogin(string sessionToken)
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
		public string Username
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public string Email
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Email", value);
			}
		}

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public string UserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "quotaBytes")]
		[JsonPropertyName("quotaBytes")]
		public long QuotaBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "QuotaBytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "QuotaBytes", value);
			}
		}

		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public long UsedBytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UsedBytes"), typeof(long));
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
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "enabled")]
		[JsonPropertyName("enabled")]
		public bool Enabled
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Enabled"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Enabled", value);
			}
		}

		[JsonProperty(PropertyName = "assetURL")]
		[JsonPropertyName("assetURL")]
		public string AssetURL
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetURL"), typeof(string));
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
		public @bool PointFiltering
		{
			get
			{
				return (@bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PointFiltering"), typeof(@bool));
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
		public int MAX_DISPLAY_BADGES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_DISPLAY_BADGES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_DISPLAY_BADGES", value);
			}
		}

		[JsonProperty(PropertyName = "iconUrl")]
		[JsonPropertyName("iconUrl")]
		public string IconUrl
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IconUrl"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IconUrl", value);
			}
		}

		[JsonProperty(PropertyName = "tagline")]
		[JsonPropertyName("tagline")]
		public string Tagline
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Tagline"), typeof(string));
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
		public string Description
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Description"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Description", value);
			}
		}

		public bool IsValid(IPlatformProfile platform)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValid", platform), typeof(bool));
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
		public string Username
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Username", value);
			}
		}

		[JsonProperty(PropertyName = "email")]
		[JsonPropertyName("email")]
		public string Email
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(string));
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
		public bool GenerateNewUserId
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GenerateNewUserId"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GenerateNewUserId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsEmailValid => ValidationHelper.IsValidEmail(Email);

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsDateOfBirthValid => User.IsDateOfBirthValid(DateOfBirth);

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
		public bool IsActiveSupporter
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsActiveSupporter"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsActiveSupporter", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportMonths")]
		[JsonPropertyName("totalSupportMonths")]
		public int TotalSupportMonths
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportMonths"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportMonths", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportCents")]
		[JsonPropertyName("totalSupportCents")]
		public int TotalSupportCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastTierCents")]
		[JsonPropertyName("lastTierCents")]
		public int LastTierCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTierCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "highestTierCents")]
		[JsonPropertyName("highestTierCents")]
		public int HighestTierCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HighestTierCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HighestTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "lowestTierCents")]
		[JsonPropertyName("lowestTierCents")]
		public int LowestTierCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LowestTierCents"), typeof(int));
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
		public bool IsSupporter => TotalSupportMonths > 0;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override int Priority => 100;

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
		public bool IsActiveSupporter
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsActiveSupporter"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsActiveSupporter", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportMonths")]
		[JsonPropertyName("totalSupportMonths")]
		public int TotalSupportMonths
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportMonths"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportMonths", value);
			}
		}

		[JsonProperty(PropertyName = "totalSupportCents")]
		[JsonPropertyName("totalSupportCents")]
		public int TotalSupportCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalSupportCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalSupportCents", value);
			}
		}

		[JsonProperty(PropertyName = "lastTierCents")]
		[JsonPropertyName("lastTierCents")]
		public int LastTierCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastTierCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "highestTierCents")]
		[JsonPropertyName("highestTierCents")]
		public int HighestTierCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HighestTierCents"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HighestTierCents", value);
			}
		}

		[JsonProperty(PropertyName = "lowestTierCents")]
		[JsonPropertyName("lowestTierCents")]
		public int LowestTierCents
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LowestTierCents"), typeof(int));
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
		public bool IsSupporter => TotalSupportMonths > 0;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public override int Priority => 100;

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
		public abstract int Priority { get; }

		public abstract void Sanitize();

		public int CompareTo(SupporterMetadata other)
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
		public string Credential
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Credential"), typeof(string));
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
		public string ChangeSource
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ChangeSource"), typeof(string));
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
		public int MAX_USERNAME_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_USERNAME_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_USERNAME_LENGTH", value);
			}
		}

		public int MINIMUM_USER_AGE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MINIMUM_USER_AGE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MINIMUM_USER_AGE", value);
			}
		}

		public int MAXIMUM_USER_AGE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAXIMUM_USER_AGE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAXIMUM_USER_AGE", value);
			}
		}

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public string Id
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Id"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Id", value);
			}
		}

		[JsonProperty(PropertyName = "username")]
		[JsonPropertyName("username")]
		public string Username
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(string));
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
		public string Email
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Email"), typeof(string));
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
		public bool IsVerified
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsVerified"), typeof(bool));
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
		public bool IsAccountBanned
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAccountBanned"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAccountBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsPublicBanned
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPublicBanned"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPublicBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsSpectatorBanned
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSpectatorBanned"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsSpectatorBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsMuteBanned
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMuteBanned"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMuteBanned", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsListingBanned
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsListingBanned"), typeof(bool));
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
		public string ReferrerUserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ReferrerUserId"), typeof(string));
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
		public ResoniteBridge.ResoniteBridgeValue LegacyQuotaBytes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyQuotaBytes"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyQuotaBytes", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "usedBytes")]
		[JsonPropertyName("usedBytes")]
		public ResoniteBridge.ResoniteBridgeValue LegacyUsedBytes
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyUsedBytes"), typeof(ResoniteBridge.ResoniteBridgeValue));
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

		public static string BasicValidateUsername(string username)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "User", ResoniteBridge.ResoniteBridgeValueType.Type), "BasicValidateUsername", username), typeof(string));
		}

		public static bool IsDateOfBirthValid(ResoniteBridge.ResoniteBridgeValue date)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "User", ResoniteBridge.ResoniteBridgeValueType.Type), "IsDateOfBirthValid", date), typeof(bool));
		}

		public bool HasTag(string tag)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasTag", tag), typeof(bool));
		}

		public bool HasEntitlement<T>(Predicate<T> filter = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasEntitlement", filter), typeof(bool));
		}

		public bool IsSupporter<T>(Predicate<T> filter = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsSupporter", filter), typeof(bool));
		}

		public ResoniteBridge.ResoniteBridgeValue GetAccountName(string platformName, out ResoniteBridge.ResoniteBridgeValue color)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAccountName", platformName, color), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
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

		public static string Team => "team member";

		public static string Business => "business admin";

		public static string Admin => "platform admin";

		public static string Moderator => "moderator";

		public static string ModerationLead => "moderation lead";

		public static string Developer => "platform developer";

		public static string Mentor => "mentor";

		public static string Translator => "translator";

		public static string MentorLead => "mentor lead";

		public static string HTC_Vive => "htc vive";

		public static string DiagnoseRecordSync => "diagnose record sync";

		public static string HearingImpaired => "hearing impaired";

		public static string VisuallyImpaired => "visually impaired";

		public static string ColorBlind => "color blind";

		public static string Mute => "mute";

		public static string Potato => "potato";

		public static string DurianTester => "durian tester";

		public static string FoundingSupporter => "founding supporter";

		public static string FirstPlace => "1st";

		public static string SecondPlace => "2nd";

		public static string ThirdPlace => "3rd";

		public static string MMC_Participant => "mmc participant";

		public static string MMC_Cow => "mmc cow";

		public static string MMC_Lips => "mmc lips";

		public static string MMC_World => "mmc world";

		public static string MMC_Avatar => "mmc avatar";

		public static string MMC_Other => "mmc other";

		public static string VBLFC => "vblfc";

		public static string VFE22 => "vfe22";

		public static string Festa3 => "neos festa 3";

		public static string Festa3Participant => "neos festa 3 participant";

		public static string Festa4Ambassador => "neos festa 4 ambassador";

		public static string Festa4Participant => "neos festa 4 participant";

		public static string UniFesta2023 => "unifesta 2023";

		public static string MMC21_Participant => "mmc21 participant";

		public static string MMC21_Smile => "mmc21 smile";

		public static string MMC21_Mouth => "mmc21 mouth";

		public static string MMC21_GrillCheeze => "mmc21 grill cheeze";

		public static string MMC21_World => "world";

		public static string MMC21_Avatar => "avatar";

		public static string MMC21_Other => "other";

		public static string MMC21_Meme => "meme";

		public static string MMC21_WorldSocial => "social";

		public static string MMC21_WorldGame => "game";

		public static string MMC21_WorldMisc => "misc";

		public static string MMC21_AvatarAvatars => "avatars";

		public static string MMC21_AvatarAccessories => "accessories";

		public static string MMC21_AvatarMisc => "misc";

		public static string MMC21_OtherTAU => "tau";

		public static string MMC21_OtherMisc => "misc";

		public static string MMC22_Participant => "mmc22 participant";

		public static string MMC22_HonorableMention => "mmc22 honorable mention";

		public static string MMC22_World => "mmc22 world";

		public static string MMC22_Avatar => "mmc22 avatar";

		public static string MMC22_Art => "mmc22 art";

		public static string MMC22_ESD => "mmc22 esd";

		public static string MMC22_Meme => "mmc22 meme";

		public static string MMC22_Other => "mmc22 other";

		public static string MMC22_CheeseCoin => "mmc22 cheese coin";

		public static string MMC22_LitaLita => "mmc22 litalita";

		public static string MMC22_HolyWater => "mmc22 holywater";

		public static string MMC23_Participant => "mmc23 participant";

		public static string MMC23_HonorableMention => "mmc23 honorable mention";

		public static string MMC23_Gifty => "mmc23 gifty";

		public static string MMC23_World => "mmc23 world";

		public static string MMC23_Avatar => "mmc23 avatar";

		public static string MMC23_Art => "mmc23 art";

		public static string MMC23_ESD => "mmc23 esd";

		public static string MMC23_Other => "mmc23 other";

		public static string MMC23_Meme => "mmc23 meme";

		public static string MMC23_Prime => "mmc23 prime";

		public static string MMC23_LitaLita => "mmc23 litalita";

		public static string MMC23_HolyWater => "mmc23 holywater";

		public static string MMC24_Participant => "mmc24 participant";

		public static string MMC24_HonorableMention => "mmc24 honorable mention";

		public static string MMC24_Gifty => "mmc24 gifty";

		public static string MMC24_World => "mmc24 world";

		public static string MMC24_Avatar => "mmc24 avatar";

		public static string MMC24_Art => "mmc24 art";

		public static string MMC24_ESD => "mmc24 esd";

		public static string MMC24_Other => "mmc24 other";

		public static string MMC24_Meme => "mmc24 meme";

		public static string MMC24_Narrative => "mmc24 narrative";

		public static string MMC24_Prime => "mmc24 prime";

		public static string MMC24_Froox => "mmc24 froox";

		public static string MMC24_HolyWater => "mmc24 holywater";

		public static string MMC24_Litalita => "mmc24 litalita";

		public static string Halloween24_Participant => "halloween24 participant";

		public static string Halloween24_Winner => "halloween24 winner";

		public static string VKet24_Participant => "vket24 participant";

		public static string UniFesta24_Participant => "unifesta 2024 participant";

		public static string UniFesta24_Ambassador => "unifesta 2024 ambassador";

		public static string CustomBadge(string dbSignature, bool pointFiltering)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CustomBadge", dbSignature, pointFiltering), typeof(string));
		}

		public static string GetCustomBadge(string badge, out bool pointFiltering)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCustomBadge", badge, pointFiltering), typeof(string));
		}

		public static string GetCustom3DBadge(string badge)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCustom3DBadge", badge), typeof(string));
		}

		public static string ComposeMMC21(string baseCategory, string subcategory, int place)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "UserTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ComposeMMC21", baseCategory, subcategory, place), typeof(string));
		}
	}
	public delegate(bool, object) CloudVariableParser(string value);
	public enum VariablePermissionType
	{
		Read,
		Write,
		List
	}
	public static class CloudVariableHelper
	{
		public static int MAX_SUBPATH_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_SUBPATH_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_SUBPATH_LENGTH", value);
			}
		}

		public static int MAX_STRING_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_STRING_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_STRING_LENGTH", value);
			}
		}

		public static int DEFAULT_MAX_STRING_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MAX_STRING_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MAX_STRING_LENGTH", value);
			}
		}

		public static int MAX_URI_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_URI_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_URI_LENGTH", value);
			}
		}

		public static int MAX_VARIABLES_PER_USER
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_USER"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_USER", value);
			}
		}

		public static int MAX_VARIABLES_PER_GROUP
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_GROUP"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_VARIABLES_PER_GROUP", value);
			}
		}

		public static char DELIMITER
		{
			get
			{
				return (char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DELIMITER"), typeof(char));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DELIMITER", value);
			}
		}

		public static string PERM_ANYONE
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_ANYONE"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_ANYONE", value);
			}
		}

		public static string PERM_VARIABLE_OWNER
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER", value);
			}
		}

		public static string PERM_VARIABLE_OWNER_UNSAFE
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_UNSAFE"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_UNSAFE", value);
			}
		}

		public static string PERM_VARIABLE_OWNER_ONLY_CONTACTS
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS", value);
			}
		}

		public static string PERM_VARIABLE_OWNER_ONLY_CONTACTS_UNSAFE
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS_UNSAFE"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_VARIABLE_OWNER_ONLY_CONTACTS_UNSAFE", value);
			}
		}

		public static string PERM_DEFINITION_OWNER_ONLY
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY", value);
			}
		}

		public static string PERM_DEFINITION_OWNER_ONLY_UNSAFE
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_UNSAFE"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_UNSAFE", value);
			}
		}

		public static string PERM_DEFINITION_OWNER_ONLY_CONTACTS
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS", value);
			}
		}

		public static string PERM_DEFINITION_OWNER_ONLY_CONTACTS_UNSAFE
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS_UNSAFE"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_ONLY_CONTACTS_UNSAFE", value);
			}
		}

		public static string PERM_DEFINITION_OWNER
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER", value);
			}
		}

		public static string PERM_DEFINITION_OWNER_UNSAFE
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PERM_DEFINITION_OWNER_UNSAFE"), typeof(string));
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

		public static ResoniteBridge.ResoniteBridgeValue GetPermissionType(string name)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetPermissionType", name), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static bool IsValidPermissionList(VariablePermissionType permissionType, OwnerType owner, string permissions)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPermissionList", permissionType, owner, permissions), typeof(bool));
		}

		public static bool IsValidPermission(string permission)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPermission", permission), typeof(bool));
		}

		public static bool IsValidPath(string path)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidPath", path), typeof(bool));
		}

		public static bool IsValidSubpath(string subpath)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidSubpath", subpath), typeof(bool));
		}

		private static bool PreprocessPath(string path, out int separatorIndex)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PreprocessPath", path, separatorIndex), typeof(bool));
		}

		public static bool SplitPath(string path, out string ownerId, out string subpath)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SplitPath", path, ownerId, subpath), typeof(bool));
		}

		public static bool RequiresDefinitionOwner(string permission)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresDefinitionOwner", permission), typeof(bool));
		}

		public static bool RequiresVariableOwner(string permission)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "RequiresVariableOwner", permission), typeof(bool));
		}

		public static bool TargetContactsOnly(string permission)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TargetContactsOnly", permission), typeof(bool));
		}

		public static bool TargetDefinitionOwnerOnly(string permission)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TargetDefinitionOwnerOnly", permission), typeof(bool));
		}

		public static bool AllowsPublicAccess(string permission)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AllowsPublicAccess", permission), typeof(bool));
		}

		public static bool ParseValue<T>(string encodedValue, string type, out T value)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ParseValue", encodedValue, type, value), typeof(bool));
		}

		public static bool TryConvertTo<T>(object value, out T converted)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TryConvertTo", value, converted), typeof(bool));
		}

		public static bool TryConvertToColorX(object value, out ResoniteBridge.ResoniteBridgeValue converted)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TryConvertToColorX", value, converted), typeof(bool));
		}

		public static string EncodeValue<T>(T value, string type)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "EncodeValue", value, type), typeof(string));
		}

		public static CloudVariableParser GetUnsafeValueParser<T>()
		{
			return (CloudVariableParser)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetUnsafeValueParser"), typeof(CloudVariableParser));
		}

		public static bool IsValidValue(string type, string value)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidValue", type, value), typeof(bool));
		}

		public static CloudVariableParser GetValueParser(string type)
		{
			return (CloudVariableParser)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetValueParser", type), typeof(CloudVariableParser));
		}

		private static CloudVariableParser GetComplexValueParser(string type)
		{
			return (CloudVariableParser)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "CloudVariableHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetComplexValueParser", type), typeof(CloudVariableParser));
		}
	}
	public class VariableReadRequest : IEquatable<VariableReadRequest>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int MAX_BATCH_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_BATCH_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_BATCH_SIZE", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "path")]
		[JsonPropertyName("path")]
		public string Path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Path", value);
			}
		}

		public bool Equals(VariableReadRequest other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(bool));
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
		public string URL
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "URL"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "URL", value);
			}
		}

		[JsonProperty(PropertyName = "userId")]
		[JsonPropertyName("userId")]
		public string UserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserId", value);
			}
		}

		[JsonProperty(PropertyName = "recordVersion")]
		[JsonPropertyName("recordVersion")]
		public int RecordVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordVersion", value);
			}
		}

		[JsonProperty(PropertyName = "duration")]
		[JsonPropertyName("duration")]
		public long Duration
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Duration"), typeof(long));
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
		public string Referal
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Referal"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Referal", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsValid
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(bool));
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

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer)
		{
			return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadJson", reader, objectType, existingValue, serializer), typeof(object));
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

		public override bool CanConvert(Type typeToConvert)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(bool));
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
		private object defaultValue
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultValue"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultValue", value);
			}
		}

		public JsonStringEnumConverterAttribute(Type converterType, object defaultValue)
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

		public override bool CanConvert(Type typeToConvert)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(bool));
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
		public override void WriteJson(JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer)
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
		public override bool CanConvert(Type typeToConvert)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanConvert", typeToConvert), typeof(bool));
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

		private object _lock
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lock"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lock", value);
			}
		}

		[JsonPropertyName("max")]
		public int Max
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Max"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Max", value);
			}
		}

		[JsonPropertyName("min")]
		public int Min
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Min"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Min", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public int Length => Math.Abs(Max - Min) + 1;

		[System.Text.Json.Serialization.JsonIgnore]
		private IEnumerable<int> Range => Enumerable.Range(Min, Length);

		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<int> AvailablePorts => Range.NotInHashSet(InUse);

		[System.Text.Json.Serialization.JsonConstructor]
		public PortRange(int min = 0, int max = 0)
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

		private void ValidatePort(int port, string name = "Port")
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ValidatePort", port, name);
		}

		public bool Contains(int port)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Contains", port), typeof(bool));
		}

		public int UseNext()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UseNext"), typeof(int));
		}

		public int Next()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Next"), typeof(int));
		}

		public bool IsInUse(int port)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsInUse", port), typeof(bool));
		}

		public bool Use(int port)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Use", port), typeof(bool));
		}

		public bool Free(int port)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Free", port), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(string));
		}

		public static PortRange From(int minInclusive, int maxInclusive)
		{
			return (PortRange)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "PortRange", ResoniteBridge.ResoniteBridgeValueType.Type), "From", minInclusive, maxInclusive), typeof(PortRange));
		}

		public bool Try(Func<int, bool> startFunction)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Try", startFunction), typeof(bool));
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
		public static bool IsValidEmail(string email)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base.Models", "ValidationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidEmail", email), typeof(bool));
		}
	}
}
