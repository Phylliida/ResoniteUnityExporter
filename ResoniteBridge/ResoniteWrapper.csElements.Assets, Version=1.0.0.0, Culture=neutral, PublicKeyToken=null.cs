using System;

using System.Collections;

using System.Collections.Concurrent;

using System.Collections.Generic;

using System.Diagnostics;

using System.Globalization;

using System.IO;

using System.IO.Compression;

using System.Linq;

using System.Numerics;

using System.Reflection;

using System.Runtime.CompilerServices;

using System.Runtime.InteropServices;

using System.Runtime.Versioning;

using System.Security;

using System.Security.Permissions;

using System.Text;

using System.Text.Json;

using System.Text.Json.Serialization;

using System.Threading.Tasks;

using Assimp;

using BepuPhysics.Collidables;

using BepuPhysics.Trees;

using BepuUtilities;

using BepuUtilities.Memory;

using ColorLUT.CUBE;

using Compressonator.NET;

using crunch.NET;

using CSCore;

using CSCore.Codecs;

using CSCore.Codecs.FLAC;

using CSCore.Codecs.OGG;

using CSCore.Codecs.WAV;

using CUETools.Codecs;

using CUETools.Codecs.FLAKE;

using Elements.Core;

using FreeImageAPI;

using FreeImageAPI.Metadata;

using FreeImageAPI.Plugins;

using Graph3D.Vrml;

using Graph3D.Vrml.Fields;

using Graph3D.Vrml.Nodes;

using Graph3D.Vrml.Nodes.Geometry;

using Graph3D.Vrml.Nodes.Grouping;

using Graph3D.Vrml.Parser;

using Graph3D.Vrml.Tokenizer;

using Jeffijoe.MessageFormat;

using laszip.net;

using LZ4;

using Microsoft.CodeAnalysis;

using Mikktspace.NET;

using MimeDetective;

using Msdfgen.NET;

using Newtonsoft.Json;

using Newtonsoft.Json.Converters;

using OggVorbisEncoder;

using PDFiumSharp;

using PDFiumSharp.Enums;

using PDFiumSharp.Types;

using Pfim;

using QRCoder;

using RNNoise.NET;

using SharpFont;

using SkyFrost.Base;

using SubtitlesParser.Classes;

using SubtitlesParser.Classes.Parsers;


//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
namespace Microsoft.CodeAnalysis
{
}
namespace System.Runtime.CompilerServices
{
}
namespace MPOHeaderReader
{
	public class MPO_File : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private static byte?[] MP_IDENTIFIER
		{
			get
			{
				return (byte?[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MPO_File", ResoniteBridge.ResoniteBridgeValueType.Type), "MP_IDENTIFIER"), typeof(byte?[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MPO_File", ResoniteBridge.ResoniteBridgeValueType.Type), "MP_IDENTIFIER", value);
			}
		}

		public MPO_File(string file)
		{
			using FileStream stream = File.OpenRead(file);
			Init(stream);
		}

		public MPO_File(Stream stream)
		{
			Init(stream);
		}

		private void Init(Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Init", stream);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MPO_File(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
}
namespace Elements.Assets
{
	public static class AnimJImporter
	{
		public static AnimX ImportFromFile(string file)
		{
			return (AnimX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AnimJImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "ImportFromFile", file), typeof(AnimX));
		}

		public static async ValueTask<AnimX> Import(Stream stream)
		{
			return (ValueTask<AnimX>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AnimJImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "Import", stream), typeof(ValueTask<AnimX>));
		}

		public static AnimX ImportFromJSON(string json)
		{
			return (AnimX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AnimJImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "ImportFromJSON", json), typeof(AnimX));
		}

		public static AnimX CreateFrom(Animation animation)
		{
			return (AnimX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AnimJImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateFrom", animation), typeof(AnimX));
		}
	}
	public class Animation : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("name")]
		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		[JsonPropertyName("globalDuration")]
		public float GlobalDuration
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "GlobalDuration"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "GlobalDuration", value);
			}
		}

		[JsonPropertyName("tracks")]
		public List<AnimationTrack> Tracks
		{
			get
			{
				return (List<AnimationTrack>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Tracks"), typeof(List<AnimationTrack>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Tracks", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Animation(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class AnimationTrackConverter : System.Text.Json.Serialization.JsonConverter<AnimationTrack>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override bool CanConvert(Type typeToConvert)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CanConvert", typeToConvert), typeof(bool));
		}

		public override AnimationTrack Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (AnimationTrack)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", reader, typeToConvert, options), typeof(AnimationTrack));
		}

		public override void Write(Utf8JsonWriter writer, AnimationTrack value, JsonSerializerOptions options)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", writer, value, options);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AnimationTrackConverter(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class AnimationTrack : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public abstract TrackType TrackType { get; }

		[System.Text.Json.Serialization.JsonIgnore]
		public abstract Type ValueType { get; }

		[JsonPropertyName("node")]
		public string Node { get; set; }

		[JsonPropertyName("property")]
		public string Property { get; set; }

		internal abstract float AddTo(AnimX animx);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class CurveAnimationTrack<T> : AnimationTrack, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public override TrackType TrackType => TrackType.Curve;

		[System.Text.Json.Serialization.JsonIgnore]
		public override Type ValueType => typeof(T);

		[JsonPropertyName("keyframes")]
		public List<CurveAnimationKeyframe<T>> Keyframes
		{
			get
			{
				return (List<CurveAnimationKeyframe<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Keyframes"), typeof(List<CurveAnimationKeyframe<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Keyframes", value);
			}
		}

		internal override float AddTo(AnimX animx)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTo", animx), typeof(float));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CurveAnimationTrack(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class CurveAnimationKeyframe<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("time")]
		public float Time
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Time"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Time", value);
			}
		}

		[JsonPropertyName("value")]
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Value", value);
			}
		}

		[JsonPropertyName("leftTangent")]
		public T LeftTangent
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LeftTangent"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LeftTangent", value);
			}
		}

		[JsonPropertyName("rightTangent")]
		public T RightTangent
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RightTangent"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RightTangent", value);
			}
		}

		[JsonPropertyName("interpolation")]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public KeyframeInterpolation Interpolation
		{
			get
			{
				return (KeyframeInterpolation)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Interpolation"), typeof(KeyframeInterpolation));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Interpolation", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CurveAnimationKeyframe(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DiscreteAnimationTrack<T> : AnimationTrack, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public override TrackType TrackType => TrackType.Discrete;

		[System.Text.Json.Serialization.JsonIgnore]
		public override Type ValueType => typeof(T);

		[JsonPropertyName("keyframes")]
		public List<DiscreteAnimationKeyframe<T>> Keyframes
		{
			get
			{
				return (List<DiscreteAnimationKeyframe<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Keyframes"), typeof(List<DiscreteAnimationKeyframe<T>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Keyframes", value);
			}
		}

		internal override float AddTo(AnimX animx)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTo", animx), typeof(float));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DiscreteAnimationTrack(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DiscreteAnimationKeyframe<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("time")]
		public float Time
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Time"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Time", value);
			}
		}

		[JsonPropertyName("value")]
		public T Value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Value", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DiscreteAnimationKeyframe(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class RawAnimationTrack<T> : AnimationTrack, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public override TrackType TrackType => TrackType.Raw;

		[System.Text.Json.Serialization.JsonIgnore]
		public override Type ValueType => typeof(T);

		[JsonPropertyName("interval")]
		public float Interval
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Interval"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Interval", value);
			}
		}

		[JsonPropertyName("keyframes")]
		public List<T> Keyframes
		{
			get
			{
				return (List<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Keyframes"), typeof(List<T>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Keyframes", value);
			}
		}

		internal override float AddTo(AnimX animx)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTo", animx), typeof(float));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public RawAnimationTrack(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class SubtitleImporter
	{
		public float CONVERSION_RATIO
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "CONVERSION_RATIO"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "CONVERSION_RATIO", value);
			}
		}

		public string DEFAULT_NODE
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_NODE"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_NODE", value);
			}
		}

		public string DEFAULT_PROPERTY
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PROPERTY"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PROPERTY", value);
			}
		}

		public static AnimX Import(string file)
		{
			return (AnimX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "Import", file), typeof(AnimX));
		}

		public static AnimX Import(Stream stream, string name)
		{
			return (AnimX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "Import", stream, name), typeof(AnimX));
		}

		public static void Import(Stream stream, AnimX anim, string node, string property)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SubtitleImporter", ResoniteBridge.ResoniteBridgeValueType.Type), "Import", stream, anim, node, property);
		}
	}
	public enum AssetClass
	{
		Unknown,
		Text,
		Package,
		Object,
		Texture,
		Cubemap,
		Volume,
		Document,
		Model,
		PointCloud,
		Audio,
		Video,
		Shader,
		Animation,
		Font,
		Folder,
		Subtitle,
		Special
	}
	public static class AssetHelper
	{
		private static Dictionary<AssetClass, List<string>> associatedExtensions
		{
			get
			{
				return (Dictionary<AssetClass, List<string>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "associatedExtensions"), typeof(Dictionary<AssetClass, List<string>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "associatedExtensions", value);
			}
		}

		private static bool IsLinux
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsLinux"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsLinux", value);
			}
		}

		public static void Init()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Init");
		}

		static AssetHelper()
		{
			associatedExtensions = new Dictionary<AssetClass, List<string>>
			{
				{
					AssetClass.Unknown,
					null
				},
				{
					AssetClass.Text,
					new List<string>
					{
						"txt", "log", "cs", "py", "css", "html", "htm", "c", "cpp", "h",
						"hpp", "java", "md", "cc"
					}
				},
				{
					AssetClass.Document,
					new List<string> { "pdf" }
				},
				{
					AssetClass.Package,
					new List<string> { "resonitepackage" }
				},
				{
					AssetClass.Object,
					new List<string> { "json", "bson", "7zbson", "lz4bson", "brson", "frdt" }
				},
				{
					AssetClass.Audio,
					new List<string> { "wav", "wave", "flac", "fla", "ogg", "aiff", "aif", "aifc" }
				},
				{
					AssetClass.Cubemap,
					new List<string> { "bmpcube" }
				},
				{
					AssetClass.Volume,
					new List<string> { "3dtex", "cube" }
				},
				{
					AssetClass.Video,
					new List<string>
					{
						"mp4", "mpeg", "avi", "mov", "mpg", "mkv", "flv", "webm", "mts", "3gp",
						"bik", "m2v", "m2s", "wmv", "m3u8", "m3u", "pls", "ogv", "m4a", "mp3",
						"mpeg3", "aac", "ac3", "aif", "aiff", "ape", "au", "it", "mka", "mod",
						"mp1", "mp2", "opus", "s3m", "sid", "w64", "wma", "xm", "nsf", "nsfe",
						"gbs", "vgm", "vgz", "spc", "gym"
					}
				},
				{
					AssetClass.Animation,
					new List<string> { "animj" }
				},
				{
					AssetClass.PointCloud,
					new List<string> { "pts", "las", "laz" }
				},
				{
					AssetClass.Font,
					new List<string> { "ttf", "otf", "ttc", "otc", "woff" }
				},
				{
					AssetClass.Shader,
					new List<string> { "unityshader" }
				},
				{
					AssetClass.Special,
					new List<string>()
				}
			};
			List<string> list = new List<string> { "meshx" };
			try
			{
				AssimpContext assimpContext = new AssimpContext();
				string[] supportedImportFormats = assimpContext.GetSupportedImportFormats();
				foreach (string text in supportedImportFormats)
				{
					list.Add(text.Substring(1));
				}
				assimpContext.Dispose();
			}
			catch (Exception ex)
			{
				UniLog.Error("Exception Initializing AssimpContext:\n" + ex.ToString(), stackTrace: false);
			}
			if (FreeCADInterface.IsAvailable)
			{
				list.AddRange(FreeCADInterface.SupportedFormats);
			}
			UniLog.Log("Supported 3D model formats: " + string.Join(", ", list));
			UniLog.Log("Supported point cloud formats: " + string.Join(", ", associatedExtensions[AssetClass.PointCloud]));
			associatedExtensions.Add(AssetClass.Model, list);
			List<string> list2 = TextureDecoder.SupportedExtensions.ToList();
			associatedExtensions.Add(AssetClass.Texture, list2);
			UniLog.Log("Supported image formats: " + string.Join(", ", list2));
			UniLog.Log("Supported audio formats: " + string.Join(", ", associatedExtensions[AssetClass.Audio]));
			UniLog.Log("Supported video formats: " + string.Join(", ", associatedExtensions[AssetClass.Video]));
			UniLog.Log("Supported font formats: " + string.Join(", ", associatedExtensions[AssetClass.Font]));
			UniLog.Log("Supported document formats: " + string.Join(", ", associatedExtensions[AssetClass.Document]));
			List<string> list3 = (from s in SubtitlesFormat.SupportedSubtitlesFormats
				where s.Extension != null
				select s.Extension.Substring(2)).ToList();
			associatedExtensions.Add(AssetClass.Subtitle, list3);
			UniLog.Log("Supported subtitle formats: " + string.Join(", ", list3));
		}

		public static bool IsVideoStreamingService(Uri url)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsVideoStreamingService", url), typeof(bool));
		}

		public static AssetClass IdentifyClass(string path)
		{
			return (AssetClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IdentifyClass", path), typeof(AssetClass));
		}

		public static AssetClass ClassifyExtension(string ext)
		{
			return (AssetClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ClassifyExtension", ext), typeof(AssetClass));
		}

		public static AssetClass ClassifyMime(string mime)
		{
			return (AssetClass)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ClassifyMime", mime), typeof(AssetClass));
		}

		public static colorX GetClassColor(AssetClass assetClass)
		{
			return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetClassColor", assetClass), typeof(colorX));
		}

		public static bool IsStreamingProtocol(Uri uri)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsStreamingProtocol", uri), typeof(bool));
		}

		public static bool IsStreamingProtocol(string scheme)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsStreamingProtocol", scheme), typeof(bool));
		}
	}
	public delegate float RawSampleFilter(int index, int channel, float amplitude);
	public delegate void RawSampleHandler(int index, int channel, float amplitude);
	public delegate void SampleHandler<S>(int index, S sample) where S : unmanaged, IAudioSample<S>;
	public delegate S SampleFilter<S>(int index, S sample) where S : unmanaged, IAudioSample<S>;
	public delegate void SampleChunkFilter<S>(ref Span<S> chunk, bool isLastChunk) where S : unmanaged, IAudioSample<S>;
	public class AudioX : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ref struct SourceData<S> : ResoniteBridge.ResoniteBridgeValueHolder where S : struct, IAudioSample<S>
		{
			public Span<S> data
			{
				get
				{
					return (Span<S>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "data"), typeof(Span<S>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "data", value);
				}
			}

			public BufferBlock block
			{
				get
				{
					return (BufferBlock)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "block"), typeof(BufferBlock));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "block", value);
				}
			}

			public SourceData(Span<S> data, BufferBlock block = null)
			{
				this.data = data;
				this.block = block;
			}

			public void Dispose()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public SourceData(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public int DEFAULT_BUFFER_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "DEFAULT_BUFFER_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "DEFAULT_BUFFER_SIZE", value);
			}
		}

		private AudioEncodeSettings encodeSettings
		{
			get
			{
				return (AudioEncodeSettings)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "encodeSettings"), typeof(AudioEncodeSettings));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "encodeSettings", value);
			}
		}

		private ISampleDecoder sampleDecoder
		{
			get
			{
				return (ISampleDecoder)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "sampleDecoder"), typeof(ISampleDecoder));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "sampleDecoder", value);
			}
		}

		private ISampleEncoder sampleEncoder
		{
			get
			{
				return (ISampleEncoder)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "sampleEncoder"), typeof(ISampleEncoder));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "sampleEncoder", value);
			}
		}

		private float[] samples
		{
			get
			{
				return (float[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "samples"), typeof(float[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "samples", value);
			}
		}

		public bool IsFullyDecoded => samples != null;

		public ChannelConfiguration Channels
		{
			get
			{
				return (ChannelConfiguration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Channels"), typeof(ChannelConfiguration));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Channels", value);
			}
		}

		public int ChannelCount => Channels.ChannelCount();

		public Type SampleType => Channels.SampleType();

		public int SampleRate
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SampleRate"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SampleRate", value);
			}
		}

		public int SampleCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SampleCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SampleCount", value);
			}
		}

		public double Duration
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Duration"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Duration", value);
			}
		}

		public bool IsReadable
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsReadable"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsReadable", value);
			}
		}

		public bool IsWriteable
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsWriteable"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsWriteable", value);
			}
		}

		public AudioEncodeSettings EncodeSettings => encodeSettings;

		public float[] RawSamples => samples;

		public AudioX(ChannelConfiguration channels, int sampleRate)
		{
			samples = new float[4096];
			Channels = channels;
			SampleCount = 0;
			SampleRate = sampleRate;
			IsReadable = true;
			IsWriteable = true;
		}

		public AudioX(AudioEncodeSettings encodeSettings)
		{
			this.encodeSettings = encodeSettings;
			Channels = encodeSettings.Channels;
			SampleRate = encodeSettings.SampleRate;
			sampleEncoder = CreateEncoder(new MemoryStream(), encodeSettings);
			IsReadable = false;
			IsWriteable = true;
		}

		public AudioX(float[] data, ChannelConfiguration channels, int sampleRate, bool writeable = false)
		{
			samples = data;
			Channels = channels;
			SampleCount = data.Length / channels.ChannelCount();
			SampleRate = sampleRate;
			IsReadable = true;
			IsWriteable = writeable;
			ComputeDuration();
		}

		public AudioX(string file)
		{
			FileStream stream = File.OpenRead(file);
			string extension = Path.GetExtension(file);
			LoadFromStream(stream, extension);
		}

		public AudioX(Stream stream, string ext = null)
		{
			LoadFromStream(stream, ext);
		}

		private void LoadFromStream(Stream stream, string extension)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LoadFromStream", stream, extension);
		}

		private void ComputeDuration()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeDuration");
		}

		public int Read<T>(Span<T> target, double position, double rate = 1.0, bool loop = false) where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", target, position, rate, loop), typeof(int));
		}

		private int Read<S, T>(Span<T> target, double position, double rate = 1.0, bool loop = false) where S : struct, IAudioSample<S> where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", target, position, rate, loop), typeof(int));
		}

		private SourceData<S> GetSource<S>(int offset, int count) where S : struct, IAudioSample<S>
		{
			return (SourceData<S>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSource", offset, count), typeof(SourceData<S>));
		}

		public Span<S> GetRawBuffer<S>() where S : struct, IAudioSample<S>
		{
			return (Span<S>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawBuffer"), typeof(Span<S>));
		}

		public unsafe void WriteSample<S>(S sample) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteSample", sample);
		}

		public void WriteSamples(Span<float> newRawSamples)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteSamples", newRawSamples);
		}

		public void WriteSamples<S>(Span<S> newSamples) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteSamples", newSamples);
		}

		public void FinishEncode()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FinishEncode");
		}

		private void FinishEncode(ISampleEncoder encoder, AudioEncodeSettings encodeSettings)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FinishEncode", encoder, encodeSettings);
		}

		public void SetSampleCount(int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetSampleCount", count);
		}

		public void IncreaseSampleCount(int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IncreaseSampleCount", count);
		}

		public void SetDuration(float duration)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetDuration", duration);
		}

		private void EnsureCapacity(int capacity)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureCapacity", capacity);
		}

		private void CheckWritable()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckWritable");
		}

		private void CheckReadable()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckReadable");
		}

		private void CheckSampleType<S>() where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckSampleType");
		}

		public void Save(string file)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Save", file);
		}

		public static string SetExtension(string file, AudioEncodeSettings settings)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AudioX", ResoniteBridge.ResoniteBridgeValueType.Type), "SetExtension", file, settings), typeof(string));
		}

		public static ISampleEncoder CreateEncoder(Stream stream, AudioEncodeSettings settings)
		{
			return (ISampleEncoder)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AudioX", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateEncoder", stream, settings), typeof(ISampleEncoder));
		}

		public void Encode(string file, AudioEncodeSettings settings)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Encode", file, settings);
		}

		public void Encode(Stream stream, AudioEncodeSettings settings)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Encode", stream, settings);
		}

		private void Encode(ISampleEncoder encoder)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Encode", encoder);
		}

		public void FullyDecode()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FullyDecode");
		}

		public void ForEachRawSample(RawSampleHandler onRead)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForEachRawSample", onRead);
		}

		private int ForeachRawSampleInBlock<S>(int offset, RawSampleHandler onRead) where S : struct, IAudioSample<S>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForeachRawSampleInBlock", offset, onRead), typeof(int));
		}

		public void ForeachSample<S>(SampleHandler<S> onRead) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForeachSample", onRead);
		}

		private int ForeachSampleInBlock<S>(int offset, SampleHandler<S> onRead) where S : struct, IAudioSample<S>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForeachSampleInBlock", offset, onRead), typeof(int));
		}

		public void Trim(int start, int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Trim", start, count);
		}

		public void ProcessSamplesAndTrim<S>(int start, int count, SampleFilter<S> filter) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ProcessSamplesAndTrim", start, count, filter);
		}

		public void ProcessSamples<S>(SampleFilter<S> filter) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ProcessSamples", filter);
		}

		public void ProcessSamples<S>(SampleChunkFilter<S> chunkFilter) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ProcessSamples", chunkFilter);
		}

		public void ProcessRawSamples(Func<float, float> filter)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ProcessRawSamples", filter);
		}

		public void ProcessRawSamples(RawSampleFilter filter)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ProcessRawSamples", filter);
		}

		private void TrimAndProcess(int start, int count, RawSampleFilter rawFilter)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimAndProcess", start, count, rawFilter);
		}

		private void TrimAndProcess<S>(int start, int count, SampleFilter<S> sampleFilter, SampleChunkFilter<S> chunkFilter, RawSampleFilter rawFilter) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimAndProcess", start, count, sampleFilter, chunkFilter, rawFilter);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public void SkipStartDuration(float duration, out int start, out int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SkipStartDuration", duration, start, count);
		}

		public void SkipEndDuration(float duration, out int start, out int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SkipEndDuration", duration, start, count);
		}

		public void FindStartAndEnd(float threshold, out int start, out int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FindStartAndEnd", threshold, start, count);
		}

		public float ComputeMaximumAmplitude()
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeMaximumAmplitude"), typeof(float));
		}

		public float ComputeMaximumAmplitude<S>(Func<S, S> sampleFilter) where S : struct, IAudioSample<S>
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeMaximumAmplitude", sampleFilter), typeof(float));
		}

		public void Normalize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Normalize");
		}

		public void AdjustVolume(float multiply)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AdjustVolume", multiply);
		}

		public void TrimSilence(float threshold = 0.002f)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimSilence", threshold);
		}

		public void TrimStartSilence(float threshold = 0.002f)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimStartSilence", threshold);
		}

		public void TrimEndSilence(float threshold = 0.002f)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimEndSilence", threshold);
		}

		public void TrimStart(float duration)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimStart", duration);
		}

		public void TrimEnd(float duration)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimEnd", duration);
		}

		public void FadeIn(float duration)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FadeIn", duration);
		}

		public void FadeOut(float duration)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FadeOut", duration);
		}

		public void MakeFadeLoop(float duration)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MakeFadeLoop", duration);
		}

		private void MakeFadeLoop<S>(float duration) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MakeFadeLoop", duration);
		}

		public void Resample(int newSampleRate)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Resample", newSampleRate);
		}

		public void Denoise()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Denoise");
		}

		private void Denoise<S>() where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Denoise");
		}

		public void ExtractSides()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractSides");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AudioX(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class AudioBufferPool : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static AudioBufferPool Instance
		{
			get
			{
				return (AudioBufferPool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AudioBufferPool", ResoniteBridge.ResoniteBridgeValueType.Type), "Instance"), typeof(AudioBufferPool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AudioBufferPool", ResoniteBridge.ResoniteBridgeValueType.Type), "Instance", value);
			}
		}

		public int BUFFER_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BUFFER_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BUFFER_LENGTH", value);
			}
		}

		public int MaxBlockCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MaxBlockCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MaxBlockCount", value);
			}
		}

		private Dictionary<BufferBlockKey, BufferBlock> bufferBlocks
		{
			get
			{
				return (Dictionary<BufferBlockKey, BufferBlock>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "bufferBlocks"), typeof(Dictionary<BufferBlockKey, BufferBlock>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "bufferBlocks", value);
			}
		}

		private Queue<BufferBlockKey> recycleQueue
		{
			get
			{
				return (Queue<BufferBlockKey>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "recycleQueue"), typeof(Queue<BufferBlockKey>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "recycleQueue", value);
			}
		}

		private HashSet<BufferBlockKey> recycleQueuedBlocks
		{
			get
			{
				return (HashSet<BufferBlockKey>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "recycleQueuedBlocks"), typeof(HashSet<BufferBlockKey>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "recycleQueuedBlocks", value);
			}
		}

		private object _lock
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_lock"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_lock", value);
			}
		}

		public BufferBlock RequestBlock(AudioX clip, int position)
		{
			return (BufferBlock)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RequestBlock", clip, position), typeof(BufferBlock));
		}

		public BufferBlock RequestBlock(in BufferBlockKey key)
		{
			return (BufferBlock)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RequestBlock", key), typeof(BufferBlock));
		}

		public void ReturnBlock(BufferBlock block)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReturnBlock", block);
		}

		private BufferBlock GetFreshBlock()
		{
			return (BufferBlock)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetFreshBlock"), typeof(BufferBlock));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AudioBufferPool(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class BufferBlock : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public BufferBlockKey key
		{
			get
			{
				return (BufferBlockKey)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "key"), typeof(BufferBlockKey));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "key", value);
			}
		}

		public bool isDecoded
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "isDecoded"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "isDecoded", value);
			}
		}

		public int userCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "userCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "userCount", value);
			}
		}

		public int decodedSamples
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "decodedSamples"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "decodedSamples", value);
			}
		}

		public float[] buffer
		{
			get
			{
				return (float[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "buffer"), typeof(float[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "buffer", value);
			}
		}

		public BufferBlock(float[] buffer)
		{
			this.buffer = buffer;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BufferBlock(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct BufferBlockKey : IEquatable<BufferBlockKey>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public AudioX clip
		{
			get
			{
				return (AudioX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "clip"), typeof(AudioX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "clip", value);
			}
		}

		public int position
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "position"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "position", value);
			}
		}

		public BufferBlockKey(AudioX clip, int position)
		{
			this.clip = clip;
			this.position = position;
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public bool Equals(BufferBlockKey other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public static bool operator ==(BufferBlockKey left, BufferBlockKey right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(BufferBlockKey left, BufferBlockKey right)
		{
			return !(left == right);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BufferBlockKey(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct CircularBufferReadState<S> : ResoniteBridge.ResoniteBridgeValueHolder where S : struct, IAudioSample<S>
	{
		public S lastSample
		{
			get
			{
				return (S)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "lastSample"), typeof(S));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "lastSample", value);
			}
		}

		public long lastGlobalPosition
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "lastGlobalPosition"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "lastGlobalPosition", value);
			}
		}

		public double lastPosition
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "lastPosition"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "lastPosition", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CircularBufferReadState(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct CircularBufferWriteState<S> : ResoniteBridge.ResoniteBridgeValueHolder where S : struct, IAudioSample<S>
	{
		public S lastSample
		{
			get
			{
				return (S)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "lastSample"), typeof(S));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "lastSample", value);
			}
		}

		public double lastPosition
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "lastPosition"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "lastPosition", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CircularBufferWriteState(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class CircularAudioBuffer : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public abstract int Length { get; }

		public long GlobalIndex { get; protected set; }

		public int CurrentHead { get; protected set; }

		public long StartGlobalIndex => GlobalIndex - Length;

		public int AvailableSamples(long lastIndex)
		{
			return MathX.Min((int)(GlobalIndex - lastIndex), Length);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class CircularAudioBuffer<S> : CircularAudioBuffer, IEnumerable<S>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder where S : struct, IAudioSample<S>
	{
		private S[] data
		{
			get
			{
				return (S[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(S[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public override int Length => data.Length;

		public CircularAudioBuffer(int length, CircularAudioBuffer<S> initializeWith = null)
		{
			data = new S[length];
			if (initializeWith != null)
			{
				base.GlobalIndex = initializeWith.GlobalIndex;
				int num = MathX.Min(length, initializeWith.AvailableSamples(initializeWith.StartGlobalIndex));
				base.CurrentHead += num;
				base.CurrentHead %= Length;
				long globalPosition = base.GlobalIndex - num;
				initializeWith.Read(data.AsSpan(), ref globalPosition);
			}
		}

		public void Put<T>(Span<T> source) where T : struct, IAudioSample<T>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Put", source);
		}

		public void Put<T>(Span<T> source, ref CircularBufferWriteState<T> state, double rate = 1.0) where T : struct, IAudioSample<T>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Put", source, state, rate);
		}

		public void Put<T>(Span<T> source, ref double position, ref T lastSample, double rate = 1.0) where T : struct, IAudioSample<T>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Put", source, position, lastSample, rate);
		}

		public int Read<T>(Span<T> target, ref long globalPosition, double rate = 1.0) where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", target, globalPosition, rate), typeof(int));
		}

		public int Read<T>(Span<T> target, ref CircularBufferReadState<S> state, double rate) where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", target, state, rate), typeof(int));
		}

		public int Read<T>(Span<T> target, ref long globalPosition, double rate, ref double position, ref S lastSample) where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", target, globalPosition, rate, position, lastSample), typeof(int));
		}

		public IEnumerator<S> GetEnumerator()
		{
			return (IEnumerator<S>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<S>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CircularAudioBuffer(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public enum ChannelConfiguration
	{
		Mono,
		Stereo,
		Quad,
		Surround51
	}
	public static class ChannelHelper
	{
		public static int ChannelCount(this ChannelConfiguration channelConfiguration)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ChannelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ChannelCount", channelConfiguration), typeof(int));
		}

		public static Type SampleType(this ChannelConfiguration channelConfiguration)
		{
			return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ChannelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SampleType", channelConfiguration), typeof(Type));
		}
	}
	public class CSCoreSampleDecoder : ISampleDecoder, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private IWaveSource waveSource
		{
			get
			{
				return (IWaveSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "waveSource"), typeof(IWaveSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "waveSource", value);
			}
		}

		private ISampleSource sampleSource
		{
			get
			{
				return (ISampleSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "sampleSource"), typeof(ISampleSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "sampleSource", value);
			}
		}

		public Stream InputStream
		{
			get
			{
				return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InputStream"), typeof(Stream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InputStream", value);
			}
		}

		public int Samples
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Samples"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Samples", value);
			}
		}

		public int SampleRate
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SampleRate"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SampleRate", value);
			}
		}

		public ChannelConfiguration Channels
		{
			get
			{
				return (ChannelConfiguration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Channels"), typeof(ChannelConfiguration));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Channels", value);
			}
		}

		public long Position
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Position"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Position", value);
			}
		}

		public AudioEncodeSettings EncodeSettings
		{
			get
			{
				return (AudioEncodeSettings)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "EncodeSettings"), typeof(AudioEncodeSettings));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "EncodeSettings", value);
			}
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public int Read(float[] buffer, int offset, int count)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", buffer, offset, count), typeof(int));
		}

		public CSCoreSampleDecoder(string file)
		{
			string extension = Path.GetExtension(file).Replace(".", "");
			Load(File.OpenRead(file), extension);
		}

		public CSCoreSampleDecoder(Stream stream, string extension = null)
		{
			Load(stream, extension);
		}

		private void Load(Stream stream, string extension)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Load", stream, extension);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CSCoreSampleDecoder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class FlacEncoder : ISampleEncoder, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private FlakeWriter writer
		{
			get
			{
				return (FlakeWriter)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "writer"), typeof(FlakeWriter));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "writer", value);
			}
		}

		private AudioBuffer buffer
		{
			get
			{
				return (AudioBuffer)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "buffer"), typeof(AudioBuffer));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "buffer", value);
			}
		}

		public Stream OutputStream
		{
			get
			{
				return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OutputStream"), typeof(Stream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OutputStream", value);
			}
		}

		public FlacEncoder(Stream stream, FlacEncodeSettings settings)
		{
			OutputStream = stream;
			settings.EnsureValidSettings();
			AudioPCMConfig pcm = new AudioPCMConfig(settings.BitsPerSample, settings.ChannelCount, settings.SampleRate);
			writer = new FlakeWriter(null, stream, pcm, leaveOpen: true);
			writer.CompressionLevel = settings.CompressionLevel;
			buffer = new AudioBuffer(pcm, 65536);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public void Write(Span<float> samples)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", samples);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public FlacEncoder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class VorbisEncoder : ISampleEncoder, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int BUFFER_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BUFFER_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BUFFER_SIZE", value);
			}
		}

		private OggStream oggStream
		{
			get
			{
				return (OggStream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "oggStream"), typeof(OggStream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "oggStream", value);
			}
		}

		private ProcessingState processingState
		{
			get
			{
				return (ProcessingState)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "processingState"), typeof(ProcessingState));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "processingState", value);
			}
		}

		private float[][] buffer
		{
			get
			{
				return (float[][])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "buffer"), typeof(float[][]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "buffer", value);
			}
		}

		public int Channels => buffer.Length;

		public Stream OutputStream
		{
			get
			{
				return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OutputStream"), typeof(Stream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OutputStream", value);
			}
		}

		public VorbisEncoder(Stream stream, VorbisEncodeSettings settings)
		{
			OutputStream = stream;
			settings.EnsureValidSettings();
			int channelCount = settings.ChannelCount;
			VorbisInfo info = VorbisInfo.InitVariableBitRate(channelCount, settings.SampleRate, settings.Quality);
			int serialNumber = new Random().Next();
			oggStream = new OggStream(serialNumber);
			Comments comments = new Comments();
			if (settings.Tags != null)
			{
				foreach (KeyValuePair<string, string> tag in settings.Tags)
				{
					comments.AddTag(tag.Key, tag.Value);
				}
			}
			OggPacket packet = HeaderPacketBuilder.BuildInfoPacket(info);
			OggPacket packet2 = HeaderPacketBuilder.BuildCommentsPacket(comments);
			OggPacket packet3 = HeaderPacketBuilder.BuildBooksPacket(info);
			oggStream.PacketIn(packet);
			oggStream.PacketIn(packet2);
			oggStream.PacketIn(packet3);
			FlushPages(force: true);
			processingState = ProcessingState.Create(info);
			buffer = new float[channelCount][];
			for (int i = 0; i < channelCount; i++)
			{
				buffer[i] = new float[512];
			}
		}

		public void Write(Span<float> samples)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", samples);
		}

		public void Finish()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Finish");
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private void WritePackets()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WritePackets");
		}

		private void FlushPages(bool force)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FlushPages", force);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public VorbisEncoder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class WavEncoder : ISampleEncoder, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private WaveWriter writer
		{
			get
			{
				return (WaveWriter)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "writer"), typeof(WaveWriter));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "writer", value);
			}
		}

		public Stream OutputStream
		{
			get
			{
				return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OutputStream"), typeof(Stream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OutputStream", value);
			}
		}

		public WavEncoder(Stream stream, WavEncodeSettings settings)
		{
			OutputStream = stream;
			int sampleRate = settings.SampleRate;
			int bitsPerSample = settings.BitsPerSample;
			int channels = settings.Channels.ChannelCount();
			writer = new WaveWriter(stream, new WaveFormat(sampleRate, bitsPerSample, channels, (settings.Format != WavEncodeSettings.SampleFormat.Float_32) ? AudioEncoding.Pcm : AudioEncoding.IeeeFloat));
		}

		public void Write(Span<float> samples)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", samples);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public WavEncoder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class AudioEncodeSettings : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int SampleRate { get; set; }

		public ChannelConfiguration Channels { get; set; }

		public int ChannelCount => Channels.ChannelCount();

		public abstract string Extension { get; }

		public override bool Equals(object obj)
		{
			if (obj == null)
			{
				return false;
			}
			if (GetType() != obj.GetType())
			{
				return false;
			}
			AudioEncodeSettings audioEncodeSettings = (AudioEncodeSettings)obj;
			if (SampleRate == audioEncodeSettings.SampleRate)
			{
				return Channels == audioEncodeSettings.Channels;
			}
			return false;
		}

		public override int GetHashCode()
		{
			return (-990289814 * -1521134295 + SampleRate.GetHashCode()) * -1521134295 + Channels.GetHashCode();
		}

		public void UpdateFrom(AudioX audio)
		{
			SampleRate = audio.SampleRate;
			Channels = audio.Channels;
		}

		public static bool operator ==(AudioEncodeSettings left, AudioEncodeSettings right)
		{
			return EqualityComparer<AudioEncodeSettings>.Default.Equals(left, right);
		}

		public static bool operator !=(AudioEncodeSettings left, AudioEncodeSettings right)
		{
			return !(left == right);
		}

		public override string ToString()
		{
			return $"SampleRate: {SampleRate} Hz, Channels: {Channels}";
		}

		public abstract string ToString(bool includeBaseInfo);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class FlacEncodeSettings : AudioEncodeSettings, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int BitsPerSample
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BitsPerSample"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BitsPerSample", value);
			}
		}

		public int CompressionLevel
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CompressionLevel"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CompressionLevel", value);
			}
		}

		public override string Extension => "flac";

		public void EnsureValidSettings()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureValidSettings");
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public static bool operator ==(FlacEncodeSettings left, FlacEncodeSettings right)
		{
			return EqualityComparer<FlacEncodeSettings>.Default.Equals(left, right);
		}

		public static bool operator !=(FlacEncodeSettings left, FlacEncodeSettings right)
		{
			return !(left == right);
		}

		public override string ToString(bool includeBaseInfo)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString", includeBaseInfo), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public FlacEncodeSettings(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class VorbisEncodeSettings : AudioEncodeSettings, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static float[] QualityBitrates
		{
			get
			{
				return (float[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VorbisEncodeSettings", ResoniteBridge.ResoniteBridgeValueType.Type), "QualityBitrates"), typeof(float[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VorbisEncodeSettings", ResoniteBridge.ResoniteBridgeValueType.Type), "QualityBitrates", value);
			}
		}

		public Dictionary<string, string> Tags
		{
			get
			{
				return (Dictionary<string, string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Tags"), typeof(Dictionary<string, string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Tags", value);
			}
		}

		public float Quality
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Quality"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Quality", value);
			}
		}

		public override string Extension => "ogg";

		public static float BitrateToQuality(float bitrate)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VorbisEncodeSettings", ResoniteBridge.ResoniteBridgeValueType.Type), "BitrateToQuality", bitrate), typeof(float));
		}

		public static float QualityToBitrate(float quality)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VorbisEncodeSettings", ResoniteBridge.ResoniteBridgeValueType.Type), "QualityToBitrate", quality), typeof(float));
		}

		public void EnsureValidSettings()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureValidSettings");
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public static bool operator ==(VorbisEncodeSettings left, VorbisEncodeSettings right)
		{
			return EqualityComparer<VorbisEncodeSettings>.Default.Equals(left, right);
		}

		public static bool operator !=(VorbisEncodeSettings left, VorbisEncodeSettings right)
		{
			return !(left == right);
		}

		public override string ToString(bool includeBaseInfo)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString", includeBaseInfo), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public VorbisEncodeSettings(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class WavEncodeSettings : AudioEncodeSettings, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum SampleFormat
		{
			Byte_8,
			Short_16,
			Int_24,
			Int_32,
			Float_32
		}

		public SampleFormat Format
		{
			get
			{
				return (SampleFormat)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Format"), typeof(SampleFormat));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Format", value);
			}
		}

		public int BitsPerSample => Format switch
		{
			SampleFormat.Byte_8 => 8, 
			SampleFormat.Short_16 => 16, 
			SampleFormat.Int_24 => 24, 
			SampleFormat.Int_32 => 32, 
			SampleFormat.Float_32 => 32, 
			_ => throw new Exception("Invalid sample format: " + Format), 
		};

		public override string Extension => "wav";

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public static bool operator ==(WavEncodeSettings left, WavEncodeSettings right)
		{
			return EqualityComparer<WavEncodeSettings>.Default.Equals(left, right);
		}

		public static bool operator !=(WavEncodeSettings left, WavEncodeSettings right)
		{
			return !(left == right);
		}

		public override string ToString(bool includeBaseInfo)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString", includeBaseInfo), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public WavEncodeSettings(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface ISampleDecoder : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		Stream InputStream { get; }

		int Samples { get; }

		int SampleRate { get; }

		ChannelConfiguration Channels { get; }

		long Position { get; set; }

		AudioEncodeSettings EncodeSettings { get; }

		int Read(float[] buffer, int offset, int count);
	}
	public interface ISampleEncoder : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		Stream OutputStream { get; }

		void Write(Span<float> samples);
	}
	public interface IAudioDataSource : ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public class BufferDenoiser<S> : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder where S : struct, IAudioSample<S>
	{
		private List<Denoiser> _denoisers
		{
			get
			{
				return (List<Denoiser>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_denoisers"), typeof(List<Denoiser>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_denoisers", value);
			}
		}

		private int ChannelCount => _denoisers.Count;

		public BufferDenoiser()
		{
			int sampleChannelCount = typeof(S).GetSampleChannelCount();
			for (int i = 0; i < sampleChannelCount; i++)
			{
				_denoisers.Add(new Denoiser());
			}
		}

		public void Denoise(ref Span<S> buffer, bool finish)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Denoise", buffer, finish);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BufferDenoiser(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class SampleHelper
	{
		public double SAMPLE_POSITION_EPSILON
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SAMPLE_POSITION_EPSILON"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SAMPLE_POSITION_EPSILON", value);
			}
		}

		public static int GetSampleChannelCount(this Type type)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetSampleChannelCount", type), typeof(int));
		}

		public static Span<MonoSample> AsMonoBuffer(this float[] buffer, int offset = 0, int count = -1)
		{
			return (Span<MonoSample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsMonoBuffer", buffer, offset, count), typeof(Span<MonoSample>));
		}

		public static Span<StereoSample> AsStereoBuffer(this float[] buffer, int offset = 0, int count = -1)
		{
			return (Span<StereoSample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsStereoBuffer", buffer, offset, count), typeof(Span<StereoSample>));
		}

		public static Span<QuadSample> AsQuadBuffer(this float[] buffer, int offset = 0, int count = -1)
		{
			return (Span<QuadSample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsQuadBuffer", buffer, offset, count), typeof(Span<QuadSample>));
		}

		public static Span<Surround51Sample> AsSurround51Buffer(this float[] buffer, int offset = 0, int count = -1)
		{
			return (Span<Surround51Sample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsSurround51Buffer", buffer, offset, count), typeof(Span<Surround51Sample>));
		}

		public static Span<S> AsAudioBuffer<S>(this float[] buffer, int offset = 0, int count = -1) where S : struct, IAudioSample<S>
		{
			return (Span<S>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsAudioBuffer", buffer, offset, count), typeof(Span<S>));
		}

		public static Span<MonoSample> AsMonoBuffer(this Span<float> buffer)
		{
			return (Span<MonoSample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsMonoBuffer", buffer), typeof(Span<MonoSample>));
		}

		public static Span<StereoSample> AsStereoBuffer(this Span<float> buffer)
		{
			return (Span<StereoSample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsStereoBuffer", buffer), typeof(Span<StereoSample>));
		}

		public static Span<QuadSample> AsQuadBuffer(this Span<float> buffer)
		{
			return (Span<QuadSample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsQuadBuffer", buffer), typeof(Span<QuadSample>));
		}

		public static Span<Surround51Sample> AsSurround51Buffer(this Span<float> buffer)
		{
			return (Span<Surround51Sample>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsSurround51Buffer", buffer), typeof(Span<Surround51Sample>));
		}

		public static Span<S> AsAudioBuffer<S>(this Span<float> buffer) where S : struct, IAudioSample<S>
		{
			return (Span<S>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "AsAudioBuffer", buffer), typeof(Span<S>));
		}

		public static int TransitionSampleBlock<S, T>(Span<T> target, ref double startOffset, S lastSample, S nextSample, double rate = 1.0) where S : struct, IAudioSample<S> where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TransitionSampleBlock", target, startOffset, lastSample, nextSample, rate), typeof(int));
		}

		public static int CopySamples<S, T>(this Span<S> source, Span<T> target) where S : struct, IAudioSample<S> where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CopySamples", source, target), typeof(int));
		}

		public static int CopySamples<S, T>(this Span<S> source, Span<T> target, ref double sourcePosition, ref S lastSample, double rate = 1.0) where S : struct, IAudioSample<S> where T : struct, IAudioSample<T>
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CopySamples", source, target, sourcePosition, lastSample, rate), typeof(int));
		}

		public static void Multiply<S>(this Span<S> buffer, float gain) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Multiply", buffer, gain);
		}

		public static void Add<S>(this Span<S> buffer, Span<S> other) where S : struct, IAudioSample<S>
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "SampleHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Add", buffer, other);
		}
	}
	[DataModelType]
	public interface IAudioSample : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int ChannelCount { get; }

		ChannelConfiguration Channels { get; }

		float this[int ch] { get; }

		float AbsoluteAmplitude { get; }

		MonoSample ToMono();

		StereoSample ToStereo();

		QuadSample ToQuad();

		Surround51Sample ToSurround51();
	}
	public interface IAudioSample<S> : IAudioSample, ResoniteBridge.ResoniteBridgeValueHolder where S : struct, IAudioSample<S>
	{
		S Add(S sample);

		S Subtract(S sample);

		S Multiply(float value);

		S Bias(float value);

		S LerpTo(S next, float lerp);

		S SetChannel(int channel, float value);
	}
	public struct MonoSample : IAudioSample<MonoSample>, IAudioSample, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int CHANNEL_COUNT
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CHANNEL_COUNT"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CHANNEL_COUNT", value);
			}
		}

		public float amplitude
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "amplitude"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "amplitude", value);
			}
		}

		public int ChannelCount => 1;

		public ChannelConfiguration Channels => ChannelConfiguration.Mono;

		public float AbsoluteAmplitude => MathX.Abs(amplitude);

		public float this[int channel] => amplitude;

		public MonoSample SetChannel(int channel, float value)
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetChannel", channel, value), typeof(MonoSample));
		}

		public MonoSample(float amplitude)
		{
			this.amplitude = amplitude;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator float(MonoSample sample)
		{
			return sample.amplitude;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator MonoSample(float amplitude)
		{
			return new MonoSample(amplitude);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator MonoSample(in StereoSample sample)
		{
			return new MonoSample((sample.left + sample.right) * 0.5f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator MonoSample(in QuadSample sample)
		{
			return new MonoSample((float)sample);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator MonoSample(in Surround51Sample sample)
		{
			return new MonoSample((float)sample);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MonoSample operator +(MonoSample a, MonoSample b)
		{
			return new MonoSample(a.amplitude + b.amplitude);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MonoSample operator -(MonoSample a, MonoSample b)
		{
			return new MonoSample(a.amplitude - b.amplitude);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MonoSample operator *(MonoSample s, float v)
		{
			return new MonoSample(s.amplitude * v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MonoSample operator /(MonoSample s, float v)
		{
			return new MonoSample(s.amplitude / v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MonoSample operator *(float v, MonoSample s)
		{
			return new MonoSample(s.amplitude * v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static MonoSample operator /(float v, MonoSample s)
		{
			return new MonoSample(v / s.amplitude);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample Multiply(float value)
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", value), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample Bias(float value)
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Bias", value), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample Add(MonoSample sample)
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", sample), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample Subtract(MonoSample sample)
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", sample), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample LerpTo(MonoSample next, float lerp)
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LerpTo", next, lerp), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample ToMono()
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToMono"), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample ToStereo()
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToStereo"), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample ToQuad()
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToQuad"), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample ToSurround51()
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToSurround51"), typeof(Surround51Sample));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MonoSample(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct QuadSample : IAudioSample<QuadSample>, IAudioSample, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int CHANNEL_COUNT
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CHANNEL_COUNT"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CHANNEL_COUNT", value);
			}
		}

		public float leftFront
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "leftFront"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "leftFront", value);
			}
		}

		public float rightFront
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rightFront"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rightFront", value);
			}
		}

		public float leftRear
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "leftRear"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "leftRear", value);
			}
		}

		public float rightRear
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rightRear"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rightRear", value);
			}
		}

		public int ChannelCount => 4;

		public ChannelConfiguration Channels => ChannelConfiguration.Quad;

		public float AbsoluteAmplitude => MathX.Max(MathX.Abs(leftFront), MathX.Abs(rightFront), MathX.Abs(leftRear), MathX.Abs(rightRear));

		public float this[int channel] => (channel & 2) switch
		{
			0 => leftFront, 
			1 => rightFront, 
			2 => leftRear, 
			3 => rightRear, 
			_ => 0f, 
		};

		public float Left => (leftFront + leftRear) * 0.5f;

		public float Right => (rightFront + rightRear) * 0.5f;

		public QuadSample SwappedChannels => new QuadSample(rightFront, leftFront, rightRear, leftRear);

		public QuadSample SetChannel(int channel, float value)
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetChannel", channel, value), typeof(QuadSample));
		}

		public QuadSample(float amplitude)
		{
			leftFront = amplitude;
			rightFront = amplitude;
			leftRear = amplitude;
			rightRear = amplitude;
		}

		public QuadSample(float left, float right)
		{
			leftFront = left;
			rightFront = right;
			leftRear = left;
			rightRear = right;
		}

		public QuadSample(float leftFront, float rightFront, float leftRear, float rightRear)
		{
			this.leftFront = leftFront;
			this.rightFront = rightFront;
			this.leftRear = leftRear;
			this.rightRear = rightRear;
		}

		public QuadSample ExtractSides()
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractSides"), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator QuadSample(MonoSample sample)
		{
			return new QuadSample(sample.amplitude);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator QuadSample(in StereoSample sample)
		{
			return new QuadSample(sample.left, sample.right);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator QuadSample(in Surround51Sample sample)
		{
			return new QuadSample(sample.leftFront + sample.center, sample.rightFront + sample.center, sample.leftRear, sample.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator float(in QuadSample sample)
		{
			return (sample.leftFront + sample.rightFront + sample.leftRear + sample.rightRear) * 0.25f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadSample operator +(in QuadSample a, in QuadSample b)
		{
			return new QuadSample(a.leftFront + b.leftFront, a.rightFront + b.rightFront, a.leftRear + b.leftRear, a.rightRear + b.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadSample operator -(in QuadSample a, in QuadSample b)
		{
			return new QuadSample(a.leftFront - b.leftFront, a.rightFront - b.rightFront, a.leftRear - b.leftRear, a.rightRear - b.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadSample operator +(in QuadSample s, float v)
		{
			return new QuadSample(s.leftFront + v, s.rightFront + v, s.leftRear + v, s.rightRear + v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadSample operator *(in QuadSample s, float v)
		{
			return new QuadSample(s.leftFront * v, s.rightFront * v, s.leftRear * v, s.rightRear * v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadSample operator /(in QuadSample s, float v)
		{
			return new QuadSample(s.leftFront / v, s.rightFront / v, s.leftRear / v, s.rightRear / v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadSample operator *(float v, in QuadSample s)
		{
			return s * v;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static QuadSample operator /(float v, in QuadSample s)
		{
			return new QuadSample(v / s.leftFront, v / s.rightFront, v / s.leftRear, v / s.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample Multiply(float value)
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", value), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample Bias(float value)
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Bias", value), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample Add(QuadSample sample)
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", sample), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample Subtract(QuadSample sample)
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", sample), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample LerpTo(QuadSample next, float lerp)
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LerpTo", next, lerp), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample ToMono()
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToMono"), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample ToStereo()
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToStereo"), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample ToQuad()
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToQuad"), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample ToSurround51()
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToSurround51"), typeof(Surround51Sample));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public QuadSample(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct StereoSample : IAudioSample<StereoSample>, IAudioSample, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int CHANNEL_COUNT
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CHANNEL_COUNT"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CHANNEL_COUNT", value);
			}
		}

		public float left
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "left"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "left", value);
			}
		}

		public float right
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "right"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "right", value);
			}
		}

		public int ChannelCount => 2;

		public ChannelConfiguration Channels => ChannelConfiguration.Stereo;

		public float this[int channel]
		{
			get
			{
				if (((uint)channel & (true ? 1u : 0u)) != 0)
				{
					return right;
				}
				return left;
			}
		}

		public float AbsoluteAmplitude => MathX.Max(MathX.Abs(left), MathX.Abs(right));

		public StereoSample SwappedChannels => new StereoSample(right, left);

		public StereoSample SetChannel(int channel, float value)
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetChannel", channel, value), typeof(StereoSample));
		}

		public StereoSample(float amplitude)
		{
			left = amplitude;
			right = amplitude;
		}

		public StereoSample(float left, float right)
		{
			this.left = left;
			this.right = right;
		}

		public StereoSample ExtractSides()
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractSides"), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator StereoSample(MonoSample sample)
		{
			return new StereoSample(sample.amplitude);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator StereoSample(in QuadSample sample)
		{
			return new StereoSample(sample.Left, sample.Right);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator StereoSample(in Surround51Sample sample)
		{
			return new StereoSample(sample.Left, sample.Right);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator float(in StereoSample sample)
		{
			return (sample.left + sample.right) * 0.5f;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StereoSample operator +(in StereoSample a, in StereoSample b)
		{
			return new StereoSample(a.left + b.left, a.right + b.right);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StereoSample operator -(in StereoSample a, in StereoSample b)
		{
			return new StereoSample(a.left - b.left, a.right - b.right);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StereoSample operator *(in StereoSample s, float v)
		{
			return new StereoSample(s.left * v, s.right * v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StereoSample operator /(in StereoSample s, float v)
		{
			return new StereoSample(s.left / v, s.right / v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StereoSample operator *(float v, in StereoSample s)
		{
			return new StereoSample(s.left * v, s.right * v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static StereoSample operator /(float v, in StereoSample s)
		{
			return new StereoSample(v / s.left, v / s.right);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample Multiply(float value)
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", value), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample Bias(float value)
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Bias", value), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample Add(StereoSample sample)
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", sample), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample Subtract(StereoSample sample)
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", sample), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample LerpTo(StereoSample next, float lerp)
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LerpTo", next, lerp), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample ToMono()
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToMono"), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample ToStereo()
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToStereo"), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample ToQuad()
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToQuad"), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample ToSurround51()
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToSurround51"), typeof(Surround51Sample));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StereoSample(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Surround51Sample : IAudioSample<Surround51Sample>, IAudioSample, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int CHANNEL_COUNT
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CHANNEL_COUNT"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CHANNEL_COUNT", value);
			}
		}

		public float leftFront
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "leftFront"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "leftFront", value);
			}
		}

		public float rightFront
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rightFront"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rightFront", value);
			}
		}

		public float center
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "center"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "center", value);
			}
		}

		public float subwoofer
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "subwoofer"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "subwoofer", value);
			}
		}

		public float leftRear
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "leftRear"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "leftRear", value);
			}
		}

		public float rightRear
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rightRear"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rightRear", value);
			}
		}

		public int ChannelCount => 6;

		public ChannelConfiguration Channels => ChannelConfiguration.Surround51;

		public float Left => (leftFront + leftRear) * 0.5f + center;

		public float Right => (rightFront + rightRear) * 0.5f + center;

		public float AbsoluteAmplitude => MathX.Max(MathX.Max(MathX.Abs(leftFront), MathX.Abs(rightFront)), MathX.Max(MathX.Abs(center), MathX.Max(subwoofer)), MathX.Max(MathX.Abs(leftRear), MathX.Abs(rightRear)));

		public float this[int channel] => channel switch
		{
			0 => leftFront, 
			1 => rightFront, 
			2 => center, 
			3 => subwoofer, 
			4 => leftRear, 
			5 => rightRear, 
			_ => 0f, 
		};

		public Surround51Sample SwappedChannels => new Surround51Sample(rightFront, leftFront, center, subwoofer, rightRear, leftRear);

		public Surround51Sample SetChannel(int channel, float value)
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetChannel", channel, value), typeof(Surround51Sample));
		}

		public Surround51Sample(float amplitude)
		{
			leftFront = amplitude;
			rightFront = amplitude;
			center = amplitude;
			subwoofer = amplitude;
			leftRear = amplitude;
			rightRear = amplitude;
		}

		public Surround51Sample(float left, float right)
		{
			leftFront = left;
			rightFront = right;
			leftRear = left;
			rightRear = right;
			center = 0f;
			subwoofer = 0f;
		}

		public Surround51Sample(float leftFront, float rightFront, float center, float subwoofer, float leftRear, float rightRear)
		{
			this.leftFront = leftFront;
			this.rightFront = rightFront;
			this.center = center;
			this.subwoofer = subwoofer;
			this.leftRear = leftRear;
			this.rightRear = rightRear;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Surround51Sample(MonoSample sample)
		{
			return new Surround51Sample(sample.amplitude);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Surround51Sample(in StereoSample sample)
		{
			return new Surround51Sample(sample.left, sample.right);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static implicit operator Surround51Sample(in QuadSample sample)
		{
			return new Surround51Sample(sample.leftFront, sample.rightFront, 0f, 0f, sample.leftRear, sample.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static explicit operator float(in Surround51Sample sample)
		{
			return (sample.leftFront + sample.rightFront + sample.leftRear + sample.rightRear + sample.center + sample.subwoofer) * (1f / 6f);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Surround51Sample operator +(in Surround51Sample a, in Surround51Sample b)
		{
			return new Surround51Sample(a.leftFront + b.leftFront, a.rightFront + b.rightFront, a.center + b.center, a.subwoofer + b.subwoofer, a.leftRear + b.leftRear, a.rightRear + b.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Surround51Sample operator -(in Surround51Sample a, in Surround51Sample b)
		{
			return new Surround51Sample(a.leftFront - b.leftFront, a.rightFront - b.rightFront, a.center - b.center, a.subwoofer - b.subwoofer, a.leftRear - b.leftRear, a.rightRear - b.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Surround51Sample operator +(in Surround51Sample s, float v)
		{
			return new Surround51Sample(s.leftFront + v, s.rightFront + v, s.center + v, s.subwoofer + v, s.leftRear + v, s.rightRear + v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Surround51Sample operator *(in Surround51Sample s, float v)
		{
			return new Surround51Sample(s.leftFront * v, s.rightFront * v, s.center * v, s.subwoofer * v, s.leftRear * v, s.rightRear * v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Surround51Sample operator /(in Surround51Sample s, float v)
		{
			return new Surround51Sample(s.leftFront / v, s.rightFront / v, s.center / v, s.subwoofer / v, s.leftRear / v, s.rightRear / v);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Surround51Sample operator *(float v, in Surround51Sample s)
		{
			return s * v;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static Surround51Sample operator /(float v, in Surround51Sample s)
		{
			return new Surround51Sample(v / s.leftFront, v / s.rightFront, v / s.center, v / s.subwoofer, v / s.leftRear, v / s.rightRear);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample Multiply(float value)
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Multiply", value), typeof(Surround51Sample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample Bias(float value)
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Bias", value), typeof(Surround51Sample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample Add(Surround51Sample sample)
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", sample), typeof(Surround51Sample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample Subtract(Surround51Sample sample)
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Subtract", sample), typeof(Surround51Sample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample LerpTo(Surround51Sample next, float lerp)
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LerpTo", next, lerp), typeof(Surround51Sample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public MonoSample ToMono()
		{
			return (MonoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToMono"), typeof(MonoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public StereoSample ToStereo()
		{
			return (StereoSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToStereo"), typeof(StereoSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public QuadSample ToQuad()
		{
			return (QuadSample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToQuad"), typeof(QuadSample));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Surround51Sample ToSurround51()
		{
			return (Surround51Sample)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToSurround51"), typeof(Surround51Sample));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Surround51Sample(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class VorbisWriter : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Stream outStream
		{
			get
			{
				return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "outStream"), typeof(Stream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "outStream", value);
			}
		}

		private OggStream oggStream
		{
			get
			{
				return (OggStream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "oggStream"), typeof(OggStream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "oggStream", value);
			}
		}

		private VorbisInfo info
		{
			get
			{
				return (VorbisInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "info"), typeof(VorbisInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "info", value);
			}
		}

		private Comments comments
		{
			get
			{
				return (Comments)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "comments"), typeof(Comments));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "comments", value);
			}
		}

		private ProcessingState processingState
		{
			get
			{
				return (ProcessingState)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "processingState"), typeof(ProcessingState));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "processingState", value);
			}
		}

		private float[][] _buffer
		{
			get
			{
				return (float[][])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_buffer"), typeof(float[][]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_buffer", value);
			}
		}

		public bool HeaderWritten
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HeaderWritten"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HeaderWritten", value);
			}
		}

		public VorbisWriter(Stream stream, int channels, int sampleRate, float quality)
		{
			outStream = stream;
			info = VorbisInfo.InitVariableBitRate(channels, sampleRate, quality);
			oggStream = new OggStream(new Random().Next());
			comments = new Comments();
		}

		public void AddTag(string tag, string content)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTag", tag, content);
		}

		public void WriteHeader()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteHeader");
		}

		public void WriteAudio(float[] buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteAudio", buffer);
		}

		public void WriteAudio(float[] buffer, int samples)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteAudio", buffer, samples);
		}

		public void WriteAudio(float[][] data)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteAudio", data);
		}

		public void WriteAudio(float[][] data, int samples)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteAudio", data, samples);
		}

		public void Finish()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Finish");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public VorbisWriter(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DocumentX : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private IDocumentDataSource documentDataSource
		{
			get
			{
				return (IDocumentDataSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "documentDataSource"), typeof(IDocumentDataSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "documentDataSource", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public int PageCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PageCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PageCount", value);
			}
		}

		public DocumentX(IDocumentDataSource dataSource)
		{
			InitDataSource(dataSource);
		}

		public DocumentX(string file)
		{
			FileStream fileStream = File.OpenRead(file);
			try
			{
				FileType obj = fileStream.GetFileType() ?? throw new InvalidDataException("Could not determine the file type");
				fileStream.Seek(0L, SeekOrigin.Begin);
				if (obj.Extension.EndsWith("pdf"))
				{
					fileStream.Dispose();
					fileStream = null;
					InitDataSource(new PDF_DataSource(file));
				}
			}
			finally
			{
				if (documentDataSource == null)
				{
					fileStream?.Dispose();
				}
			}
		}

		private void InitDataSource(IDocumentDataSource dataSource)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InitDataSource", dataSource);
		}

		public IDocumentPage GetPage(int index)
		{
			return (IDocumentPage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPage", index), typeof(IDocumentPage));
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DocumentX(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IDocumentDataSource : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		string Name { get; }

		int PageCount { get; }

		IDocumentPage GetPage(int index);
	}
	public interface IDocumentPage : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Index { get; }

		double2 ReferenceSize { get; }

		bool HasAlpha { get; }

		void RenderTo(Bitmap2D bitmap);

		void RenderTo(Bitmap2D bitmap, Rect pageSection);
	}
	public class PDF_DataSource : IDocumentDataSource, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private PdfDocument _document
		{
			get
			{
				return (PdfDocument)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_document"), typeof(PdfDocument));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_document", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public int PageCount => _document.Pages.Count;

		public PDF_DataSource(string file)
		{
			_document = new PdfDocument(file);
			Name = Path.GetFileNameWithoutExtension(file);
		}

		public PDF_DataSource(Stream stream)
		{
			_document = new PdfDocument(stream, FPDF_FILEREAD.FromStream(stream));
			Name = "UNKNOWN";
		}

		public IDocumentPage GetPage(int index)
		{
			return (IDocumentPage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPage", index), typeof(IDocumentPage));
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PDF_DataSource(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class PDF_Page : IDocumentPage, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private struct RenderFormat : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public BitmapFormats format
			{
				get
				{
					return (BitmapFormats)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "format"), typeof(BitmapFormats));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "format", value);
				}
			}

			public bool reverseByteOrder
			{
				get
				{
					return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "reverseByteOrder"), typeof(bool));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "reverseByteOrder", value);
				}
			}

			public RenderFormat(BitmapFormats format, bool reverseByteOrder)
			{
				this.format = format;
				this.reverseByteOrder = reverseByteOrder;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public RenderFormat(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private PdfPage _page
		{
			get
			{
				return (PdfPage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_page"), typeof(PdfPage));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_page", value);
			}
		}

		public int Index => _page.Index;

		public double2 ReferenceSize => new double2(_page.Width, _page.Height);

		public bool HasAlpha => _page.HasTransparency;

		public PDF_Page(PdfPage page)
		{
			_page = page;
		}

		public void RenderTo(Bitmap2D bitmap)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RenderTo", bitmap);
		}

		public unsafe void RenderTo(Bitmap2D bitmap, Rect pageSection)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RenderTo", bitmap, pageSection);
		}

		private static RenderFormat? ToPDFium(TextureFormat format)
		{
			return (RenderFormat?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PDF_Page", ResoniteBridge.ResoniteBridgeValueType.Type), "ToPDFium", format), typeof(RenderFormat?));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PDF_Page(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class FileUtility
	{
		public static string DetectMime(string path)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FileUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "DetectMime", path), typeof(string));
		}
	}
	public class LocaleData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("localeCode")]
		public string LocaleCode
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LocaleCode"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LocaleCode", value);
			}
		}

		[JsonPropertyName("authors")]
		public List<string> Authors
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Authors"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Authors", value);
			}
		}

		[JsonPropertyName("messages")]
		public Dictionary<string, string> Messages
		{
			get
			{
				return (Dictionary<string, string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Messages"), typeof(Dictionary<string, string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Messages", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LocaleData(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class LocaleResource : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public struct Message : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public string localeCode
			{
				get
				{
					return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "localeCode"), typeof(string));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "localeCode", value);
				}
			}

			public string messagePattern
			{
				get
				{
					return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "messagePattern"), typeof(string));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "messagePattern", value);
				}
			}

			public Message(string localeCode, string messagePattern)
			{
				this.localeCode = localeCode;
				this.messagePattern = messagePattern;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Message(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private Dictionary<string, Message> _formatMessages
		{
			get
			{
				return (Dictionary<string, Message>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_formatMessages"), typeof(Dictionary<string, Message>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_formatMessages", value);
			}
		}

		private Dictionary<string, MessageFormatter> _formatters
		{
			get
			{
				return (Dictionary<string, MessageFormatter>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_formatters"), typeof(Dictionary<string, MessageFormatter>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_formatters", value);
			}
		}

		private Dictionary<string, List<string>> _authors
		{
			get
			{
				return (Dictionary<string, List<string>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_authors"), typeof(Dictionary<string, List<string>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_authors", value);
			}
		}

		public int MessageCount => _formatMessages.Count;

		public DictionaryEnumerableWrapper<string, Message> Messages => _formatMessages;

		public IEnumerable<KeyValuePair<string, IReadOnlyList<string>>> Authors
		{
			get
			{
				return (IEnumerable<KeyValuePair<string, IReadOnlyList<string>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Authors"), typeof(IEnumerable<KeyValuePair<string, IReadOnlyList<string>>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Authors", value);
			}
		}

		public static string GetMainLanguage(string localeCode)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "LocaleResource", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMainLanguage", localeCode), typeof(string));
		}

		public int CountMessages(Predicate<string> filter)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CountMessages", filter), typeof(int));
		}

		public string Format(string key, Dictionary<string, object> arguments)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Format", key, arguments), typeof(string));
		}

		public string GetKeyLocaleCode(string key)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetKeyLocaleCode", key), typeof(string));
		}

		public bool HasKey(string key)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasKey", key), typeof(bool));
		}

		public string GetMessagePattern(string key)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMessagePattern", key), typeof(string));
		}

		public async Task LoadAdditively(string file)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LoadAdditively", file), typeof(Task));
		}

		public void LoadDataAdditively(string json)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LoadDataAdditively", json);
		}

		public void LoadDataAdditively(LocaleData data)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LoadDataAdditively", data);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LocaleResource(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public enum TextureType
	{
		Albedo,
		Normal,
		Height,
		Emissive,
		Specular,
		Gloss,
		Roughness,
		AmbientOcclusion,
		UNKNOWN
	}
	public struct ClassifiedTexture : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TextureType type
		{
			get
			{
				return (TextureType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "type"), typeof(TextureType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "type", value);
			}
		}

		public string file
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "file"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "file", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ClassifiedTexture(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class MaterialHelper
	{
		public static TextureType DetermineTextureType(string filename)
		{
			return (TextureType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MaterialHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DetermineTextureType", filename), typeof(TextureType));
		}
	}
	[DataModelType]
	public struct ConvexHullBepuData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ConvexHull convexHull
		{
			get
			{
				return (ConvexHull)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "convexHull"), typeof(ConvexHull));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "convexHull", value);
			}
		}

		public float3 center
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "center"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "center", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ConvexHullBepuData(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class BepuMeshHelper
	{
		private delegate void Decoder<T>(Stream stream, out T decoded);

		public float POINT_CLOUD_SPREAD
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "POINT_CLOUD_SPREAD"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "POINT_CLOUD_SPREAD", value);
			}
		}

		public int MAX_TRIANGLES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_TRIANGLES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_TRIANGLES", value);
			}
		}

		public static void ComputeConvexHull(MeshX meshx, BufferPool bufferPool, object bufferLock, Action meshDataExtracted, out ConvexHull convexHull, out float3 center)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeConvexHull", meshx, bufferPool, bufferLock, meshDataExtracted, convexHull, center);
		}

		public static void ExtractTriangles(MeshX meshx, bool dualSided, BufferPool bufferPool, object bufferLock, Action meshDataExtracted, out Buffer<BepuPhysics.Collidables.Triangle> triangles)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractTriangles", meshx, dualSided, bufferPool, bufferLock, meshDataExtracted, triangles);
		}

		public static void ComputeMeshCollider(MeshX meshx, bool dualSided, BufferPool bufferPool, object bufferLock, Action meshDataExtracted, out BepuPhysics.Collidables.Mesh mesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeMeshCollider", meshx, dualSided, bufferPool, bufferLock, meshDataExtracted, mesh);
		}

		public static void SerializeMeshCollider(ref BepuPhysics.Collidables.Mesh mesh, Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SerializeMeshCollider", mesh, stream);
		}

		public static void SerializeTree(ref Tree tree, Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SerializeTree", tree, stream);
		}

		public static void DeserializeMeshCollider(MeshX meshx, bool dualSided, MeshCompression compression, Stream stream, BufferPool bufferPool, object bufferLock, Action meshDataExtracted, out BepuPhysics.Collidables.Mesh mesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DeserializeMeshCollider", meshx, dualSided, compression, stream, bufferPool, bufferLock, meshDataExtracted, mesh);
		}

		public static void DeserializeMeshCollider(MeshX meshx, bool dualSided, Stream stream, BufferPool bufferPool, object bufferLock, Action meshDataExtracted, out BepuPhysics.Collidables.Mesh mesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DeserializeMeshCollider", meshx, dualSided, stream, bufferPool, bufferLock, meshDataExtracted, mesh);
		}

		public static void DeserializeTree(Stream stream, BufferPool bufferPool, ref Tree tree)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DeserializeTree", stream, bufferPool, tree);
		}

		private static void SerializeNodeChild(ref NodeChild nodeChild, BinaryWriter writer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SerializeNodeChild", nodeChild, writer);
		}

		private static void DeserializeNodeChild(ref NodeChild nodeChild, BinaryReader reader)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DeserializeNodeChild", nodeChild, reader);
		}

		public static void SerializeConvexHull(ref ConvexHull convexHull, in float3 center, Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SerializeConvexHull", convexHull, center, stream);
		}

		public static void DeserializeConvexHull(MeshCompression compression, Stream stream, BufferPool bufferPool, object bufferLock, out ConvexHullBepuData convexHullData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DeserializeConvexHull", compression, stream, bufferPool, bufferLock, convexHullData);
		}

		public static void DeserializeConvexHull(Stream stream, BufferPool bufferPool, object bufferLock, out ConvexHullBepuData convexHullData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DeserializeConvexHull", stream, bufferPool, bufferLock, convexHullData);
		}

		public static ConvexHull BuildEmptyConvexHull(BufferPool bufferPool)
		{
			return (ConvexHull)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BuildEmptyConvexHull", bufferPool), typeof(ConvexHull));
		}

		public static bool IsValid(Span<Vector3> points)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValid", points), typeof(bool));
		}

		public static bool IsValid(Buffer<Vector3> points)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValid", points), typeof(bool));
		}

		public static bool IsValid(Vector3 v)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValid", v), typeof(bool));
		}

		private static void Decode<T>(MeshCompression compression, Stream stream, Decoder<T> decoder, out T decoded)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BepuMeshHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", compression, stream, decoder, decoded);
		}
	}
	public class BlendShape : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MeshX Mesh
		{
			get
			{
				return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Mesh"), typeof(MeshX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Mesh", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Name", value);
			}
		}

		private List<BlendShapeFrame> _frames
		{
			get
			{
				return (List<BlendShapeFrame>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_frames"), typeof(List<BlendShapeFrame>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_frames", value);
			}
		}

		private bool _hasNormals
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_hasNormals"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_hasNormals", value);
			}
		}

		private bool _hasTangents
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_hasTangents"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_hasTangents", value);
			}
		}

		public int Index => Mesh.IndexOfBlendShape(this);

		public bool HasNormals
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasNormals"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasNormals", value);
			}
		}

		public bool HasTangents
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasTangents"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasTangents", value);
			}
		}

		public int FrameCount => _frames.Count;

		public BlendShapeFrame this[int frame] => _frames[frame];

		public IEnumerable<BlendShapeFrame> Frames => _frames;

		public BlendShapeFrame AddFrame(float weight)
		{
			return (BlendShapeFrame)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddFrame", weight), typeof(BlendShapeFrame));
		}

		public BlendShapeFrame InsertFrame(int index, float weight)
		{
			return (BlendShapeFrame)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InsertFrame", index, weight), typeof(BlendShapeFrame));
		}

		public bool RemoveFrame(BlendShapeFrame frame)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveFrame", frame), typeof(bool));
		}

		public void RemoveFrameAt(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveFrameAt", index);
		}

		public void ClearFrames()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearFrames");
		}

		public void NormalizeFrameWeights()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "NormalizeFrameWeights");
		}

		internal BlendShape(MeshX mesh, string name)
		{
			Mesh = mesh;
			Name = name;
		}

		internal void EnsureCapacity(int capacity)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureCapacity", capacity);
		}

		internal void RemoveElements(int index, int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveElements", index, count);
		}

		internal void Encode(BinaryWriter bw)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Encode", bw);
		}

		internal void Decode(BinaryReader br)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Decode", br);
		}

		public void RecalculateNormals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateNormals");
		}

		public void RecalculateNormalsMerged(double cellSize = 0.001)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateNormalsMerged", cellSize);
		}

		public void RecalculateTangentsMikktspace(int uvChannel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateTangentsMikktspace", uvChannel);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BlendShape(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class BlendShapeFrame : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public BlendShape BlendShape
		{
			get
			{
				return (BlendShape)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BlendShape"), typeof(BlendShape));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BlendShape", value);
			}
		}

		public float Weight
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Weight"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Weight", value);
			}
		}

		internal float3[] positions
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "positions"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "positions", value);
			}
		}

		internal float3[] normals
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "normals"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "normals", value);
			}
		}

		internal float3[] tangents
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "tangents"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "tangents", value);
			}
		}

		public MeshX Mesh => BlendShape.Mesh;

		public float3[] RawPositions => positions;

		public float3[] RawNormals => normals;

		public float3[] RawTangents => tangents;

		internal BlendShapeFrame(BlendShape shape, float weight)
		{
			BlendShape = shape;
			Weight = weight;
			Mesh.EnsureArray(state: true, ref positions, Mesh.VertexCapacity);
			if (shape.HasNormals)
			{
				Mesh.EnsureArray(state: true, ref normals, Mesh.VertexCapacity);
			}
			if (shape.HasTangents)
			{
				Mesh.EnsureArray(state: true, ref tangents, Mesh.VertexCapacity);
			}
		}

		public float3 GetPositionDelta(int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPositionDelta", index), typeof(float3));
		}

		public float3 GetNormalDelta(int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNormalDelta", index), typeof(float3));
		}

		public float3 GetTangentDelta(int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTangentDelta", index), typeof(float3));
		}

		public void SetPositionDelta(int index, float3 delta)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPositionDelta", index, delta);
		}

		public void SetNormalDelta(int index, float3 delta)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetNormalDelta", index, delta);
		}

		public void SetTangentDelta(int index, float3 delta)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetTangentDelta", index, delta);
		}

		public void SetPositionDeltas(float3[] deltas, int? count = null, int sourceOffset = 0, int targetOffset = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPositionDeltas", deltas, count, sourceOffset, targetOffset);
		}

		public void SetNormalDeltas(float3[] deltas, int? count = null, int sourceOffset = 0, int targetOffset = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetNormalDeltas", deltas, count, sourceOffset, targetOffset);
		}

		public void SetTangentDeltas(float3[] deltas, int? count = null, int sourceOffset = 0, int targetOffset = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetTangentDeltas", deltas, count, sourceOffset, targetOffset);
		}

		private void CopyArray(float3[] source, float3[] target, int? count, int sourceOffset, int targetOffset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyArray", source, target, count, sourceOffset, targetOffset);
		}

		public void CalculateDeltaNormalsFromFull()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateDeltaNormalsFromFull");
		}

		public void RecalculateNormals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateNormals");
		}

		public void RecalculateNormalsMerged(double cellSize = 0.001)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateNormalsMerged", cellSize);
		}

		public bool RecalculateTangentsMikktspace(int uvChannel = 0)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateTangentsMikktspace", uvChannel), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BlendShapeFrame(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IMeshXElement : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int Index { get; }
	}
	public interface IMeshXPrimitive : IMeshXElement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		Submesh Submesh { get; }
	}
	public struct AppendResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<int> boneMapping
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "boneMapping"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "boneMapping", value);
			}
		}

		public List<int> blendshapeMapping
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "blendshapeMapping"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "blendshapeMapping", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AppendResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct BoneBinding : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int boneIndex0
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "boneIndex0"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "boneIndex0", value);
			}
		}

		public int boneIndex1
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "boneIndex1"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "boneIndex1", value);
			}
		}

		public int boneIndex2
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "boneIndex2"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "boneIndex2", value);
			}
		}

		public int boneIndex3
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "boneIndex3"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "boneIndex3", value);
			}
		}

		public float weight0
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight0"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight0", value);
			}
		}

		public float weight1
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight1"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight1", value);
			}
		}

		public float weight2
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight2"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight2", value);
			}
		}

		public float weight3
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight3"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight3", value);
			}
		}

		public static BoneBinding Empty
		{
			get
			{
				return (BoneBinding)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BoneBinding", ResoniteBridge.ResoniteBridgeValueType.Type), "Empty"), typeof(BoneBinding));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BoneBinding", ResoniteBridge.ResoniteBridgeValueType.Type), "Empty", value);
			}
		}

		public float TotalWeight => weight0 + weight1 + weight2 + weight3;

		public int GetBoneIndex(int index)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBoneIndex", index), typeof(int));
		}

		public void SetBoneIndex(int index, int boneIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBoneIndex", index, boneIndex);
		}

		public int AddBone(Bone bone, float weight)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddBone", bone, weight), typeof(int));
		}

		public int AddBone(int index, float weight)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddBone", index, weight), typeof(int));
		}

		public void Sort()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Sort");
		}

		public void Trim(float threshold)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Trim", threshold);
		}

		public void TrimBoneCount(int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimBoneCount", count);
		}

		public void Normalize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Normalize");
		}

		public void FillInEmpty(int boneIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillInEmpty", boneIndex);
		}

		public void GetBinding(int index, out int boneIndex, out float weight)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBinding", index, boneIndex, weight);
		}

		public void SetBinding(int index, Bone bone, float weight)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBinding", index, bone, weight);
		}

		public void SetBinding(int index, int boneIndex, float weight)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBinding", index, boneIndex, weight);
		}

		public float GetWeight(int index)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetWeight", index), typeof(float));
		}

		public void VerifyBoneIndexes(MeshX meshx)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "VerifyBoneIndexes", meshx);
		}

		public void ClearBones()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearBones");
		}

		internal void BoneRemoved(int removedIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BoneRemoved", removedIndex);
		}

		private void VerifyBoneIndex(MeshX meshx, ref int index, ref float weight)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "VerifyBoneIndex", meshx, index, weight);
		}

		private void UpdateRemovedIndex(ref int index, int removed)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateRemovedIndex", index, removed);
		}

		public Bone GetBone(MeshX meshx, int bindingIndex)
		{
			return (Bone)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBone", meshx, bindingIndex), typeof(Bone));
		}

		public float3 TransformPosition(MeshX meshx, in float3 position, Span<float4x4> boneTransforms)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformPosition", meshx, position, boneTransforms), typeof(float3));
		}

		public float3 TransformDirection(MeshX meshx, in float3 direction, Span<float4x4> boneTransforms)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformDirection", meshx, direction, boneTransforms), typeof(float3));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BoneBinding(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class Bone : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public MeshX Mesh
		{
			get
			{
				return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Mesh"), typeof(MeshX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Mesh", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Name", value);
			}
		}

		public float4x4 BindPose
		{
			get
			{
				return (float4x4)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BindPose"), typeof(float4x4));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BindPose", value);
			}
		}

		public int Index => Mesh.IndexOfBone(this);

		internal Bone(string name, MeshX mesh)
		{
			Name = name;
			Mesh = mesh;
			BindPose = float4x4.Identity;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Bone(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.MeshX", "Elements.Core")]
	public class MeshX : ResoniteBridge.ResoniteBridgeValueHolder
	{
		internal struct UV_Array : ResoniteBridge.ResoniteBridgeValueHolder
		{
			internal float2[] uv_2D
			{
				get
				{
					return (float2[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "uv_2D"), typeof(float2[]));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "uv_2D", value);
				}
			}

			internal float3[] uv_3D
			{
				get
				{
					return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "uv_3D"), typeof(float3[]));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "uv_3D", value);
				}
			}

			internal float4[] uv_4D
			{
				get
				{
					return (float4[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "uv_4D"), typeof(float4[]));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "uv_4D", value);
				}
			}

			public int Dimensions
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Dimensions"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Dimensions", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public UV_Array(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public struct PrimitiveEnumerator<T> : IEnumerator<T>, IEnumerator, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder where T : struct, IMeshXPrimitive
		{
			private List<Submesh>.Enumerator _submeshEnumerator
			{
				get
				{
					return (List<Submesh>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "_submeshEnumerator"), typeof(List<Submesh>.Enumerator));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "_submeshEnumerator", value);
				}
			}

			private int _currentIndex
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "_currentIndex"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "_currentIndex", value);
				}
			}

			private ISubmesh<T> _currentSubmesh
			{
				get
				{
					return (ISubmesh<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "_currentSubmesh"), typeof(ISubmesh<T>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "_currentSubmesh", value);
				}
			}

			public T Current => _currentSubmesh[_currentIndex];

			object IEnumerator.Current => Current;

			public PrimitiveEnumerator(MeshX meshx)
			{
				_submeshEnumerator = meshx.submeshes.GetEnumerator();
				_currentIndex = -1;
				_currentSubmesh = null;
			}

			public void Dispose()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
			}

			public bool MoveNext()
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MoveNext"), typeof(bool));
			}

			public void Reset()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Reset");
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public PrimitiveEnumerator(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public struct VertexEnumerator : IEnumerator<Vertex>, IEnumerator, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
		{
			private MeshX meshx
			{
				get
				{
					return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "meshx"), typeof(MeshX));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "meshx", value);
				}
			}

			private int _index
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "_index"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "_index", value);
				}
			}

			public Vertex Current => meshx.GetVertex(_index);

			object IEnumerator.Current => Current;

			public VertexEnumerator(MeshX meshx)
			{
				this.meshx = meshx;
				_index = -1;
			}

			public void Dispose()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
			}

			public bool MoveNext()
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MoveNext"), typeof(bool));
			}

			public void Reset()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Reset");
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public VertexEnumerator(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public enum Encoding
		{
			Plain,
			LZ4,
			LZMA
		}

		private struct SubmeshMergeKey : IEquatable<SubmeshMergeKey>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public object key
			{
				get
				{
					return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "key"), typeof(object));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "key", value);
				}
			}

			public SubmeshTopology topology
			{
				get
				{
					return (SubmeshTopology)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "topology"), typeof(SubmeshTopology));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "topology", value);
				}
			}

			public SubmeshMergeKey(object key, SubmeshTopology topology)
			{
				this.key = key;
				this.topology = topology;
			}

			public bool Equals(SubmeshMergeKey other)
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
			}

			public override bool Equals(object obj)
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
			}

			public override int GetHashCode()
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
			}

			public static bool operator ==(SubmeshMergeKey left, SubmeshMergeKey right)
			{
				return left.Equals(right);
			}

			public static bool operator !=(SubmeshMergeKey left, SubmeshMergeKey right)
			{
				return !(left == right);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public SubmeshMergeKey(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		internal List<Submesh> submeshes
		{
			get
			{
				return (List<Submesh>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "submeshes"), typeof(List<Submesh>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "submeshes", value);
			}
		}

		internal List<BlendShape> blendshapes
		{
			get
			{
				return (List<BlendShape>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "blendshapes"), typeof(List<BlendShape>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "blendshapes", value);
			}
		}

		internal Dictionary<string, BlendShape> blendshapeMap
		{
			get
			{
				return (Dictionary<string, BlendShape>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "blendshapeMap"), typeof(Dictionary<string, BlendShape>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "blendshapeMap", value);
			}
		}

		internal List<Bone> bones
		{
			get
			{
				return (List<Bone>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "bones"), typeof(List<Bone>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "bones", value);
			}
		}

		internal int[] vertexIDs
		{
			get
			{
				return (int[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "vertexIDs"), typeof(int[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "vertexIDs", value);
			}
		}

		private int _vertexID
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_vertexID"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_vertexID", value);
			}
		}

		internal float3[] positions
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "positions"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "positions", value);
			}
		}

		internal float3[] normals
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "normals"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "normals", value);
			}
		}

		internal float4[] tangents
		{
			get
			{
				return (float4[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "tangents"), typeof(float4[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "tangents", value);
			}
		}

		internal color[] colors
		{
			get
			{
				return (color[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "colors"), typeof(color[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "colors", value);
			}
		}

		internal UV_Array[] uv_channels
		{
			get
			{
				return (UV_Array[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "uv_channels"), typeof(UV_Array[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "uv_channels", value);
			}
		}

		internal BoneBinding[] boneBindings
		{
			get
			{
				return (BoneBinding[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "boneBindings"), typeof(BoneBinding[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "boneBindings", value);
			}
		}

		internal BitArray flags
		{
			get
			{
				return (BitArray)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "flags"), typeof(BitArray));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "flags", value);
			}
		}

		public int MESHX_BINARY_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MESHX_BINARY_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MESHX_BINARY_VERSION", value);
			}
		}

		public string MAGIC_STRING
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAGIC_STRING"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAGIC_STRING", value);
			}
		}

		private static byte[] _magicHeader
		{
			get
			{
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "_magicHeader"), typeof(byte[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "_magicHeader", value);
			}
		}

		public float3[] RawPositions => positions;

		public float3[] RawNormals => normals;

		public float4[] RawTangents => tangents;

		public color[] RawColors => colors;

		public float2[] RawUV0s => TryGetRawUV_Array(0).uv_2D;

		public float2[] RawUV1s => TryGetRawUV_Array(1).uv_2D;

		public float2[] RawUV2s => TryGetRawUV_Array(2).uv_2D;

		public float2[] RawUV3s => TryGetRawUV_Array(3).uv_2D;

		public BoneBinding[] RawBoneBindings => boneBindings;

		public BitArray RawFlags => flags;

		public int VertexCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VertexCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VertexCount", value);
			}
		}

		public int BoneCount => bones.Count;

		public int UV_ChannelCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV_ChannelCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV_ChannelCount", value);
			}
		}

		public int TotalPointCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TotalPointCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TotalPointCount", value);
			}
		}

		public int TotalTriangleCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TotalTriangleCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TotalTriangleCount", value);
			}
		}

		public int TotalFaceCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TotalFaceCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TotalFaceCount", value);
			}
		}

		internal int VerticesVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VerticesVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VerticesVersion", value);
			}
		}

		public int VertexCapacity
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VertexCapacity"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VertexCapacity", value);
			}
		}

		public int FreeCapacity => VertexCapacity - VertexCount;

		public bool TrackRemovals
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TrackRemovals"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TrackRemovals", value);
			}
		}

		public bool HasNormals
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasNormals"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasNormals", value);
			}
		}

		public bool HasTangents
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasTangents"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasTangents", value);
			}
		}

		public bool HasColors
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasColors"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasColors", value);
			}
		}

		public bool HasBoneBindings
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasBoneBindings"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasBoneBindings", value);
			}
		}

		public ColorProfile Profile
		{
			get
			{
				return (ColorProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Profile"), typeof(ColorProfile));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Profile", value);
			}
		}

		public bool HasUV0s
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasUV0s"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasUV0s", value);
			}
		}

		public bool HasUV1s
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasUV1s"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasUV1s", value);
			}
		}

		public bool HasUV2s
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasUV2s"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasUV2s", value);
			}
		}

		public bool HasUV3s
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasUV3s"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasUV3s", value);
			}
		}

		public int SubmeshCount => submeshes.Count;

		public ListEnumerableWrapper<Submesh> Submeshes => new ListEnumerableWrapper<Submesh>(submeshes);

		public bool HasFlags
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasFlags"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasFlags", value);
			}
		}

		public int BlendShapeCount => blendshapes.Count;

		public IEnumerable<BlendShape> BlendShapes => blendshapes;

		public EnumerableWrapper<Triangle, PrimitiveEnumerator<Triangle>> Triangles
		{
			get
			{
				return (EnumerableWrapper<Triangle, PrimitiveEnumerator<Triangle>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Triangles"), typeof(EnumerableWrapper<Triangle, PrimitiveEnumerator<Triangle>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Triangles", value);
			}
		}

		public EnumerableWrapper<Point, PrimitiveEnumerator<Point>> Points
		{
			get
			{
				return (EnumerableWrapper<Point, PrimitiveEnumerator<Point>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Points"), typeof(EnumerableWrapper<Point, PrimitiveEnumerator<Point>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Points", value);
			}
		}

		public EnumerableWrapper<Vertex, VertexEnumerator> Vertices
		{
			get
			{
				return (EnumerableWrapper<Vertex, VertexEnumerator>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertices"), typeof(EnumerableWrapper<Vertex, VertexEnumerator>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertices", value);
			}
		}

		public IEnumerable<Bone> Bones => bones;

		public static int MAGIC_HEADER_LENGTH => 6;

		public Span<float3> AccessRawPositions()
		{
			return (Span<float3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AccessRawPositions"), typeof(Span<float3>));
		}

		public Span<float3> AccessRawNormals()
		{
			return (Span<float3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AccessRawNormals"), typeof(Span<float3>));
		}

		public Span<float4> AccessRawTangents()
		{
			return (Span<float4>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AccessRawTangents"), typeof(Span<float4>));
		}

		public Span<color> AccessRawColors()
		{
			return (Span<color>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AccessRawColors"), typeof(Span<color>));
		}

		public Span<float2> AccessRawUVs(int index)
		{
			return (Span<float2>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AccessRawUVs", index), typeof(Span<float2>));
		}

		internal ref UV_Array GetRawUV_Array(int uv)
		{
			return (ref UV_Array)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawUV_Array", uv), typeof(ref UV_Array));
		}

		internal UV_Array TryGetRawUV_Array(int uv)
		{
			return (UV_Array)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryGetRawUV_Array", uv), typeof(UV_Array));
		}

		public float2[] GetRawUVs(int uv)
		{
			return (float2[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawUVs", uv), typeof(float2[]));
		}

		public float3[] GetRawUVs_3D(int uv)
		{
			return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawUVs_3D", uv), typeof(float3[]));
		}

		public float4[] GetRawUVs_4D(int uv)
		{
			return (float4[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawUVs_4D", uv), typeof(float4[]));
		}

		public void TrimUVChannels()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimUVChannels");
		}

		public void EnsureNormals(bool enabled, in float3 defaultValue = default(float3))
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureNormals", enabled, defaultValue);
		}

		public void EnsureTangents(bool enabled, in float4 defaultValue = default(float4))
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureTangents", enabled, defaultValue);
		}

		public void EnsureColors(bool enabled, in color defaultValue = default(color))
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureColors", enabled, defaultValue);
		}

		public int GetUV_Dimension(int uv)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUV_Dimension", uv), typeof(int));
		}

		public void SetUV_Dimension(int uv, int dimension)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetUV_Dimension", uv, dimension);
		}

		public bool HasUV_2D(int uv)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasUV_2D", uv), typeof(bool));
		}

		public bool HasUV_3D(int uv)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasUV_3D", uv), typeof(bool));
		}

		public bool HasUV_4D(int uv)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasUV_4D", uv), typeof(bool));
		}

		public void SetHasUV(int uv, bool state)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetHasUV", uv, state);
		}

		public void SetHasUV_3D(int uv, bool state)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetHasUV_3D", uv, state);
		}

		public void SetHasUV_4D(int uv, bool state)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetHasUV_4D", uv, state);
		}

		public static implicit operator TriangleSubmesh(MeshX meshx)
		{
			return meshx.TryGetSubmesh<TriangleSubmesh>();
		}

		public static implicit operator PointSubmesh(MeshX meshx)
		{
			return meshx.TryGetSubmesh<PointSubmesh>();
		}

		public Submesh GetSubmesh(int index)
		{
			return (Submesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSubmesh", index), typeof(Submesh));
		}

		public Submesh GetSubmeshForFace(int faceIndex)
		{
			return (Submesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSubmeshForFace", faceIndex), typeof(Submesh));
		}

		public int IndexOfSubmesh(Submesh submesh)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IndexOfSubmesh", submesh), typeof(int));
		}

		public Submesh AddSubmesh(SubmeshTopology topology)
		{
			return (Submesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddSubmesh", topology), typeof(Submesh));
		}

		public T AddSubmesh<T>() where T : Submesh
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddSubmesh"), typeof(T));
		}

		public T InsertSubmesh<T>(int index) where T : Submesh
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InsertSubmesh", index), typeof(T));
		}

		public void RemoveSubmesh(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveSubmesh", index);
		}

		public void RemoveSubmesh(Submesh submesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveSubmesh", submesh);
		}

		public T TryGetSubmesh<T>(int index = 0) where T : Submesh
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryGetSubmesh", index), typeof(T));
		}

		public Submesh TryGetSubmesh(SubmeshTopology topology, int index = 0)
		{
			return (Submesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryGetSubmesh", topology, index), typeof(Submesh));
		}

		private T InstantiateSubmesh<T>() where T : Submesh
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InstantiateSubmesh"), typeof(T));
		}

		public BlendShape AddBlendShape(string name)
		{
			return (BlendShape)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddBlendShape", name), typeof(BlendShape));
		}

		public BlendShape InsertBlendshapeAt(string name, int index)
		{
			return (BlendShape)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InsertBlendshapeAt", name, index), typeof(BlendShape));
		}

		public BlendShape GetBlendShape(int index)
		{
			return (BlendShape)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShape", index), typeof(BlendShape));
		}

		public BlendShape GetBlendShape(string name)
		{
			return (BlendShape)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShape", name), typeof(BlendShape));
		}

		public int IndexOfBlendShape(BlendShape blendShape)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IndexOfBlendShape", blendShape), typeof(int));
		}

		public bool HasBlendShape(string name)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasBlendShape", name), typeof(bool));
		}

		public int BlendShapeIndex(string name)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BlendShapeIndex", name), typeof(int));
		}

		public BlendShape TryGetBlendShape(string name)
		{
			return (BlendShape)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryGetBlendShape", name), typeof(BlendShape));
		}

		public void RemoveBlendShape(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveBlendShape", index);
		}

		public bool RemoveBlendShape(string name)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveBlendShape", name), typeof(bool));
		}

		public bool RemoveBlendShape(BlendShape blendshape)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveBlendShape", blendshape), typeof(bool));
		}

		public MeshX()
		{
			VerticesVersion = -1;
			Triangles = new EnumerableWrapper<Triangle, PrimitiveEnumerator<Triangle>>(() => new PrimitiveEnumerator<Triangle>(this));
			Points = new EnumerableWrapper<Point, PrimitiveEnumerator<Point>>(() => new PrimitiveEnumerator<Point>(this));
			Vertices = new EnumerableWrapper<Vertex, VertexEnumerator>(() => new VertexEnumerator(this));
		}

		public MeshX(MeshX clone)
			: this()
		{
			float4x4? transform = null;
			Copy(clone, in transform);
		}

		public void EnsureFreeCapacity(int capacity)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureFreeCapacity", capacity);
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public void ClearVerticesAndIndicies()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearVerticesAndIndicies");
		}

		public void ClearSubmeshes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearSubmeshes");
		}

		public void CopyDataChannelFlags(MeshX source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyDataChannelFlags", source);
		}

		public void Copy(MeshX source, in float4x4? transform = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Copy", source, transform);
		}

		public AppendResult Append(MeshX source, bool appendSubmeshes = true, in float4x4? transform = null, Func<Submesh, int> submeshMapper = null)
		{
			return (AppendResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Append", source, appendSubmeshes, transform, submeshMapper), typeof(AppendResult));
		}

		public bool SetVertexCount(int count)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetVertexCount", count), typeof(bool));
		}

		public void IncreaseVertexCount(int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IncreaseVertexCount", count);
		}

		public void RemoveVerticesFromEnd(int count, bool updateSubmeshes = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveVerticesFromEnd", count, updateSubmeshes);
		}

		public void IncreasePointCount(int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IncreasePointCount", count);
		}

		public void IncreaseTriangleCount(int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IncreaseTriangleCount", count);
		}

		public void AddVertices(int count, VertexCollection verts = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddVertices", count, verts);
		}

		public bool EnsureVertexCount(int count)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureVertexCount", count), typeof(bool));
		}

		public Vertex AddVertex()
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddVertex"), typeof(Vertex));
		}

		public Vertex AddVertex(in float3 pos)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddVertex", pos), typeof(Vertex));
		}

		public Triangle AddTriangle(int submesh = 0)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle", submesh), typeof(Triangle));
		}

		public void AddTriangles(int count, int submesh = 0, TriangleCollection trigs = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangles", count, submesh, trigs);
		}

		public Triangle AddTriangle(int v0, int v1, int v2, int submesh = 0)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle", v0, v1, v2, submesh), typeof(Triangle));
		}

		public Triangle AddTriangle(Vertex v0, Vertex v1, Vertex v2, int submesh = 0)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle", v0, v1, v2, submesh), typeof(Triangle));
		}

		public Point AddPoint(int submesh)
		{
			return (Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddPoint", submesh), typeof(Point));
		}

		public void AddPoints(int count, int submesh, PointCollection points = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddPoints", count, submesh, points);
		}

		public Vertex GetVertex(int index)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVertex", index), typeof(Vertex));
		}

		public Triangle GetTriangle(int index, int submesh = 0)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTriangle", index, submesh), typeof(Triangle));
		}

		public Point GetPoint(int index, int submesh = 0)
		{
			return (Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPoint", index, submesh), typeof(Point));
		}

		public Triangle GetTriangleByFaceIndex(int faceIndex)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTriangleByFaceIndex", faceIndex), typeof(Triangle));
		}

		public Triangle GetTriangleFromAllTriangleSubmeshes(int triangleIndex)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTriangleFromAllTriangleSubmeshes", triangleIndex), typeof(Triangle));
		}

		public void RemoveVertices(int index, int count, bool updateSubmeshes = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveVertices", index, count, updateSubmeshes);
		}

		public void RemoveTriangles(int index, int count, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveTriangles", index, count, submesh);
		}

		public void RemovePoints(int index, int count, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemovePoints", index, count, submesh);
		}

		public void RemoveVertex(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveVertex", index);
		}

		public void RemoveVertex(Vertex v)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveVertex", v);
		}

		public void RemoveVertices(VertexCollection vertices)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveVertices", vertices);
		}

		public void RemoveTriangles(TriangleCollection triangles)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveTriangles", triangles);
		}

		public void RemovePoints(PointCollection points)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemovePoints", points);
		}

		private void RemoveMixedPrimitives<T>(List<T> list) where T : IMeshXPrimitive
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveMixedPrimitives", list);
		}

		public void RemoveTriangle(int index, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveTriangle", index, submesh);
		}

		public void RemoveTriangle(Triangle t, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveTriangle", t, submesh);
		}

		public void RemoveTriangles(TriangleCollection triangles, int submesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveTriangles", triangles, submesh);
		}

		public void RemovePoint(int index, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemovePoint", index, submesh);
		}

		internal void RemoveElements<T>(List<T> elements, Action<int, int> remove) where T : IMeshXElement
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveElements", elements, remove);
		}

		public ref readonly float3 GetPosition(int index)
		{
			return (ref readonly float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPosition", index), typeof(ref readonly float3));
		}

		public ref readonly float3 GetNormal(int index)
		{
			return (ref readonly float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNormal", index), typeof(ref readonly float3));
		}

		public void SetVertex(int index, in float3 position)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetVertex", index, position);
		}

		public void SetNormal(int index, in float3 normal)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetNormal", index, normal);
		}

		public void SetTangent(int index, in float4 tangent)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetTangent", index, tangent);
		}

		public void SetColor(int index, in color color)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetColor", index, color);
		}

		public void SetUV(int index, int uvChannel, in float2 uv)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetUV", index, uvChannel, uv);
		}

		public void SetTriangle(int index, int v0, int v1, int v2, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetTriangle", index, v0, v1, v2, submesh);
		}

		public Bone GetBone(int index)
		{
			return (Bone)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBone", index), typeof(Bone));
		}

		public Bone FindBone(Func<Bone, bool> filter)
		{
			return (Bone)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FindBone", filter), typeof(Bone));
		}

		public int IndexOfBone(Bone bone)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IndexOfBone", bone), typeof(int));
		}

		public Bone AddBone(string name = "Bone")
		{
			return (Bone)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddBone", name), typeof(Bone));
		}

		public void RemoveBoneAt(int index, bool autoUpdateBindings = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveBoneAt", index, autoUpdateBindings);
		}

		public bool RemoveBone(Bone bone, bool autoUpdateBindings = true)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveBone", bone, autoUpdateBindings), typeof(bool));
		}

		public void ClearBones(bool autoUpdateBindings = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearBones", autoUpdateBindings);
		}

		internal void CheckNormals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckNormals");
		}

		internal void CheckTangents()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckTangents");
		}

		internal void CheckColors()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckColors");
		}

		internal void CheckBoneBindings()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckBoneBindings");
		}

		internal void CheckUV(int uv)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckUV", uv);
		}

		internal void CheckFlags()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckFlags");
		}

		internal void VerifyVertexIndex(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "VerifyVertexIndex", index);
		}

		internal void EnsureVertexArray<T>(bool state, ref T[] array, T defaultValue = default(T))
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureVertexArray", state, array, defaultValue);
		}

		internal void EnsureArray<T>(bool state, ref T[] array, int minSize, T defaultValue = default(T))
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureArray", state, array, minSize, defaultValue);
		}

		private void EnsureBitArray(bool state, ref BitArray array, int minSize)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureBitArray", state, array, minSize);
		}

		private void EnsureVertexCapacity(int capacity)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureVertexCapacity", capacity);
		}

		internal void RemoveElements<T>(T[] array, int index, int count, int length, bool clear = false, T clearVal = default(T))
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveElements", array, index, count, length, clear, clearVal);
		}

		private void RemoveElements(BitArray bitArray, int index, int count, int length)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveElements", bitArray, index, count, length);
		}

		public void ForEachUV(Func<float4, float4> processAll)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForEachUV", processAll);
		}

		public void ForEachUV(Func<float2, float2> process2D, Func<float3, float3> process3D, Func<float4, float4> process4D)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForEachUV", process2D, process3D, process4D);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public void RecalculateBlendshapeNormals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateBlendshapeNormals");
		}

		public void RecalculateBlendshapeNormalsMerged(double cellSize = 0.001)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateBlendshapeNormalsMerged", cellSize);
		}

		public void RecalculateBlendshapeTangentsMikktspace(int uvChannel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateBlendshapeTangentsMikktspace", uvChannel);
		}

		public void MergeBlendshapes(List<int> indexes = null, string name = "Merged")
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MergeBlendshapes", indexes, name);
		}

		public void SortBlendshapesByName(List<int> remapedOrder = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SortBlendshapesByName", remapedOrder);
		}

		public void SortBlendshapesByNameLength(List<int> remapedOrder = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SortBlendshapesByNameLength", remapedOrder);
		}

		public void SortBlendshapes(Comparison<BlendShape> comparison, List<int> remappedOrder = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SortBlendshapes", comparison, remappedOrder);
		}

		public bool RecalculateTangentsMikktspace(TriangleCollection triangles = null, int uvChannel = 0)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateTangentsMikktspace", triangles, uvChannel), typeof(bool));
		}

		public static byte MAGIC_HEADER_BYTE(int index)
		{
			return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "MAGIC_HEADER_BYTE", index), typeof(byte));
		}

		public byte[] SaveToArray(Encoding encoding = Encoding.LZ4)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveToArray", encoding), typeof(byte[]));
		}

		public void SaveToFile(string file, Encoding encoding = Encoding.LZ4)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveToFile", file, encoding);
		}

		public MeshX(string file)
			: this()
		{
			using FileStream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
			Decode(stream);
		}

		public MeshX(Stream stream)
			: this()
		{
			Decode(stream);
		}

		public void Encode(Stream stream, Encoding encoding = Encoding.LZ4)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Encode", stream, encoding);
		}

		private static bool HasMagicHeader(BinaryReader reader)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "HasMagicHeader", reader), typeof(bool));
		}

		public void Decode(Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Decode", stream);
		}

		internal static uint EncodeFlags(params bool[] flags)
		{
			return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "EncodeFlags", flags), typeof(uint));
		}

		internal static bool ReadFlag(ref uint data)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadFlag", data), typeof(bool));
		}

		private static void ReadFlag(ref uint data, out bool flag)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadFlag", data, flag);
		}

		private static void Write(BinaryWriter bw, ref BoneBinding binding)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "Write", bw, binding);
		}

		private static BoneBinding ReadBoneBinding(BinaryReader br)
		{
			return (BoneBinding)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "ReadBoneBinding", br), typeof(BoneBinding));
		}

		public float3 TransformVertex(int index, Span<float4x4> boneTransforms)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformVertex", index, boneTransforms), typeof(float3));
		}

		public void TransformAllVertices(Span<float3> targetPoses, Span<float4x4> boneTransforms)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformAllVertices", targetPoses, boneTransforms);
		}

		public void TransformAllNormals(Span<float3> targetNormals, Span<float4x4> boneTransforms)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformAllNormals", targetNormals, boneTransforms);
		}

		public void TransformAllTangents(Span<float4> targetTangents, Span<float4x4> boneTransforms)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformAllTangents", targetTangents, boneTransforms);
		}

		public void BakeSkinnedMesh(Span<float4x4> boneTransforms)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BakeSkinnedMesh", boneTransforms);
		}

		public Elements.Core.BoundingBox ComputeSkinnedBounds(Span<float4x4> boneTransforms)
		{
			return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeSkinnedBounds", boneTransforms), typeof(Elements.Core.BoundingBox));
		}

		private void VerifySkinnedTransormation(Span<float4x4> boneTransforms)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "VerifySkinnedTransormation", boneTransforms);
		}

		public void GetVertices<T>(T[] array, Func<float3, T> convert)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVertices", array, convert);
		}

		public void GetTriangleIndicies(int[] array, int arrayOffset, TriangleSubmesh triangles)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTriangleIndicies", array, arrayOffset, triangles);
		}

		public bool CompareTriangleIndicies(int[] array, int arrayOffset, TriangleSubmesh triangles)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTriangleIndicies", array, arrayOffset, triangles), typeof(bool));
		}

		public void GetTriangleIndicies(int[] array)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTriangleIndicies", array);
		}

		public bool CompareTriangleIndicies(int[] array)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CompareTriangleIndicies", array), typeof(bool));
		}

		public Vertex AddVertex(Vertex vertex)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddVertex", vertex), typeof(Vertex));
		}

		public Vertex DuplicateVertex(int index)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DuplicateVertex", index), typeof(Vertex));
		}

		public Triangle AddTriangle(Triangle triangle)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle", triangle), typeof(Triangle));
		}

		public void FlipNormals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FlipNormals");
		}

		public void ReverseWinding()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReverseWinding");
		}

		public void MakeDualSided()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MakeDualSided");
		}

		public void RecalculateNormals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateNormals");
		}

		public void RecalculateNormalsMerged(double cellSize = 0.001)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateNormalsMerged", cellSize);
		}

		public void RecalculateNormals(TriangleCollection triangles, bool onlyFlagged = false, bool removeFlag = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateNormals", triangles, onlyFlagged, removeFlag);
		}

		public bool RecalculateTangents(TriangleCollection triangles = null, int uvChannel = 0)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RecalculateTangents", triangles, uvChannel), typeof(bool));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void CalcTangentValues(Triangle t, float2[] uvs, float3[] binorms)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalcTangentValues", t, uvs, binorms);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float4 CalcTangent(in float3 nor, in float3 tan0, in float3 tan1)
		{
			return (float4)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "CalcTangent", nor, tan0, tan1), typeof(float4));
		}

		public void SortBoneWeights()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SortBoneWeights");
		}

		public void NormalizeBoneWeights()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "NormalizeBoneWeights");
		}

		public void SortTrimAndNormalizeBoneWeights(float trimThreshold = 0.0001f, int maxBoneCount = int.MaxValue)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SortTrimAndNormalizeBoneWeights", trimThreshold, maxBoneCount);
		}

		public void FillInEmptyBindings(int boneIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillInEmptyBindings", boneIndex);
		}

		public void StripEmptyBlendshapes(List<int> removedBlendshapes = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StripEmptyBlendshapes", removedBlendshapes);
		}

		public int StripEmptySubmeshes(List<int> indexRemap)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StripEmptySubmeshes", indexRemap), typeof(int));
		}

		public int StripEmptyBones()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StripEmptyBones"), typeof(int));
		}

		public int StripEmptyBones(List<int> remapIndex, Predicate<Bone> filter = null)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StripEmptyBones", remapIndex, filter), typeof(int));
		}

		public int StripEmptyBones(IReadOnlyList<BoneMetadata> precomputedMetadata, List<int> remapIndex, Predicate<Bone> filter = null)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StripEmptyBones", precomputedMetadata, remapIndex, filter), typeof(int));
		}

		public void StripBlendshapeNormals()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StripBlendshapeNormals");
		}

		public void StripBlendshapeTangents()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StripBlendshapeTangents");
		}

		public void BakeBlendShapes(Dictionary<int, float> blendshapes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BakeBlendShapes", blendshapes);
		}

		public void BakeBlendShapes(Dictionary<BlendShape, float> blendshapes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BakeBlendShapes", blendshapes);
		}

		public void TransformVertexByBlendshapes(int vertexIndex, ref float3 pos, ref float3 normal, ref float4 tangent, Span<float> weights)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformVertexByBlendshapes", vertexIndex, pos, normal, tangent, weights);
		}

		public void TransformVertexByBones(int vertexIndex, ref float3 pos, ref float3 normal, ref float4 tangent, Span<float4x4> boneTransforms)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TransformVertexByBones", vertexIndex, pos, normal, tangent, boneTransforms);
		}

		private static bool IsValidBlendshapeValue(in float3 value)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidBlendshapeValue", value), typeof(bool));
		}

		public void SplitBlenshapeByAxis(int blendshapeIndex, Axis3D axis, float center, float transition, string negativeSuffix, string positiveSuffix)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SplitBlenshapeByAxis", blendshapeIndex, axis, center, transition, negativeSuffix, positiveSuffix);
		}

		public void Translate(in float3 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Translate", offset);
		}

		public void Rotate(in floatQ rotation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Rotate", rotation);
		}

		public void Scale(float scale)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Scale", scale);
		}

		public void Scale(in float3 scale)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Scale", scale);
		}

		public float3 AverageVertexCenter()
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AverageVertexCenter"), typeof(float3));
		}

		public Elements.Core.BoundingBox CalculateBoundingBox()
		{
			return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateBoundingBox"), typeof(Elements.Core.BoundingBox));
		}

		public Elements.Core.BoundingBox CalculateBoundingBox(out int invalidVertexCount)
		{
			return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateBoundingBox", invalidVertexCount), typeof(Elements.Core.BoundingBox));
		}

		public void CalculateTriangleLengths(out float smallest, out float largest, out float average, out float median)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateTriangleLengths", smallest, largest, average, median);
		}

		public void CalculateTriangleAreas(out float smallest, out float largest, out float average, out float median)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateTriangleAreas", smallest, largest, average, median);
		}

		public List<SubmeshMetadata> CalculateSubmeshMetadata()
		{
			return (List<SubmeshMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateSubmeshMetadata"), typeof(List<SubmeshMetadata>));
		}

		public List<BoneMetadata> CalculateBoneMetadata()
		{
			return (List<BoneMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateBoneMetadata"), typeof(List<BoneMetadata>));
		}

		public List<ApproximateBoneBounds> CalculateApproximateBoneBounds()
		{
			return (List<ApproximateBoneBounds>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateApproximateBoneBounds"), typeof(List<ApproximateBoneBounds>));
		}

		public List<ApproximateBoneBounds> CalculateApproximateBoneBounds(IReadOnlyList<BoneMetadata> metadata)
		{
			return (List<ApproximateBoneBounds>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateApproximateBoneBounds", metadata), typeof(List<ApproximateBoneBounds>));
		}

		public void GenerateFlatShadingTriangles(VertexCollection newVertices = null, VertexCollection originalVertices = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateFlatShadingTriangles", newVertices, originalVertices);
		}

		public void GenerateFlatShadingTriangles(TriangleCollection triangles, VertexCollection newVertices = null, VertexCollection originalVertices = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateFlatShadingTriangles", triangles, newVertices, originalVertices);
		}

		private void GenerateFlatShadingTriangles_Internal(int triangleCount, Func<int, Triangle> getTriangle, VertexCollection newVertices = null, VertexCollection originalVertices = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateFlatShadingTriangles_Internal", triangleCount, getTriangle, newVertices, originalVertices);
		}

		public void ConvertToFlatShading()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertToFlatShading");
		}

		public void MergeSubmeshesByKey(List<object> keys, List<int> sourceIndexes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MergeSubmeshesByKey", keys, sourceIndexes);
		}

		public MeshX SeparateGeometryUnaffectedByBlendshapes()
		{
			return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SeparateGeometryUnaffectedByBlendshapes"), typeof(MeshX));
		}

		public List<MeshX> SplitSubmeshes()
		{
			return (List<MeshX>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SplitSubmeshes"), typeof(List<MeshX>));
		}

		public MeshX GetConvexHull()
		{
			return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetConvexHull"), typeof(MeshX));
		}

		public MeshX GetMergedDoubles(double cellSize = 0.001)
		{
			return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMergedDoubles", cellSize), typeof(MeshX));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MeshX(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class MeshX_Extensions
	{
		public struct QuadTriangles : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public Triangle first
			{
				get
				{
					return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "first"), typeof(Triangle));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "first", value);
				}
			}

			public Triangle second
			{
				get
				{
					return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "second"), typeof(Triangle));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "second", value);
				}
			}

			public QuadTriangles(in Triangle first, in Triangle second)
			{
				this.first = first;
				this.second = second;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public QuadTriangles(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public static QuadTriangles AddQuadAsTriangles(this TriangleSubmesh triangles, Vertex v0, Vertex v1, Vertex v2, Vertex v3, bool reverse = false)
		{
			return (QuadTriangles)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddQuadAsTriangles", triangles, v0, v1, v2, v3, reverse), typeof(QuadTriangles));
		}

		public static QuadTriangles AddQuadAsTriangles(this TriangleSubmesh triangles, int v0, int v1, int v2, int v3, bool reverse = false)
		{
			return (QuadTriangles)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddQuadAsTriangles", triangles, v0, v1, v2, v3, reverse), typeof(QuadTriangles));
		}

		public static QuadTriangles AddQuadAsTriangles(this MeshX mesh, Vertex v0, Vertex v1, Vertex v2, Vertex v3, int submesh = 0, bool reverse = false)
		{
			return (QuadTriangles)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddQuadAsTriangles", mesh, v0, v1, v2, v3, submesh, reverse), typeof(QuadTriangles));
		}

		public static QuadTriangles AddQuadAsTriangles(this MeshX mesh, int v0, int v1, int v2, int v3, int submesh = 0, bool reverse = false)
		{
			return (QuadTriangles)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddQuadAsTriangles", mesh, v0, v1, v2, v3, submesh, reverse), typeof(QuadTriangles));
		}

		public static void SetQuadAsTriangles(this TriangleSubmesh triangles, int v0, int v1, int v2, int v3, int t0, int t1, bool reverse = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SetQuadAsTriangles", triangles, v0, v1, v2, v3, t0, t1, reverse);
		}

		public static void SetQuadAsTriangles(this TriangleSubmesh triangles, Vertex v0, Vertex v1, Vertex v2, Vertex v3, int t0, int t1, bool reverse = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SetQuadAsTriangles", triangles, v0, v1, v2, v3, t0, t1, reverse);
		}

		public static void SetQuadAsTriangles(this TriangleSubmesh triangles, Vertex v0, Vertex v1, Vertex v2, Vertex v3, Triangle t0, Triangle t1, bool reverse = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SetQuadAsTriangles", triangles, v0, v1, v2, v3, t0, t1, reverse);
		}

		public static void SetQuadAsTriangles(this MeshX mesh, int v0, int v1, int v2, int v3, int t0, int t1, bool reverse = false, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SetQuadAsTriangles", mesh, v0, v1, v2, v3, t0, t1, reverse, submesh);
		}

		public static void SetQuadAsTriangles(this MeshX mesh, Vertex v0, Vertex v1, Vertex v2, Vertex v3, int t0, int t1, bool reverse = false, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SetQuadAsTriangles", mesh, v0, v1, v2, v3, t0, t1, reverse, submesh);
		}

		public static void SetQuadAsTriangles(this MeshX mesh, Vertex v0, Vertex v1, Vertex v2, Vertex v3, Triangle t0, Triangle t1, bool reverse = false, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SetQuadAsTriangles", mesh, v0, v1, v2, v3, t0, t1, reverse, submesh);
		}

		public static void AddTriangleFan(this TriangleSubmesh submesh, IList<int> vertices, bool reverseOrder = false, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", submesh, vertices, reverseOrder, triangles);
		}

		public static void AddTriangleFan(this TriangleSubmesh submesh, IList<Vertex> vertices, bool reverseOrder = false, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", submesh, vertices, reverseOrder, triangles);
		}

		public static void AddTriangleFan<T>(this TriangleSubmesh submesh, IList<T> vertices, Func<T, int> getIndex, bool reverseOrder = false, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", submesh, vertices, getIndex, reverseOrder, triangles);
		}

		public static void AddTriangleFan(this TriangleSubmesh submesh, IList<int> vertices, int offset, int count, bool reverseOrder = false, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", submesh, vertices, offset, count, reverseOrder, triangles);
		}

		public static void AddTriangleFan(this TriangleSubmesh submesh, IList<Vertex> vertices, int offset, int count, bool reverseOrder = false, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", submesh, vertices, offset, count, reverseOrder, triangles);
		}

		public static void AddTriangleFan<T>(this TriangleSubmesh submesh, IList<T> vertices, int offset, int count, Func<T, int> getIndex, bool reverseOrder = false, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", submesh, vertices, offset, count, getIndex, reverseOrder, triangles);
		}

		public static void AddTriangleFan(this TriangleSubmesh submesh, int vertexCount, Func<int, int> getVertexIndex, bool reverseOrder = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", submesh, vertexCount, getVertexIndex, reverseOrder);
		}

		public static void ConnectTriangleFan(this TriangleSubmesh submesh, IList<int> vertices, Func<int> getNextTriangle, bool reverseOrder = false, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ConnectTriangleFan", submesh, vertices, getNextTriangle, reverseOrder, triangles);
		}

		public static void ConnectTriangleFan(this TriangleSubmesh submesh, int vertexOffset, int vertexCount, Func<int, int> getVertexIndex, Func<int> getNextTriangle, bool reverseOrder = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ConnectTriangleFan", submesh, vertexOffset, vertexCount, getVertexIndex, getNextTriangle, reverseOrder);
		}

		public static void AddTriangleFan(this MeshX mesh, IList<int> vertices, bool reverseOrder = false, int submesh = 0, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", mesh, vertices, reverseOrder, submesh, triangles);
		}

		public static void AddTriangleFan(this MeshX mesh, IList<Vertex> vertices, bool reverseOrder = false, int submesh = 0, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", mesh, vertices, reverseOrder, submesh, triangles);
		}

		public static void AddTriangleFan<T>(this MeshX mesh, IList<T> vertices, Func<T, int> getIndex, bool reverseOrder = false, int submesh = 0, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", mesh, vertices, getIndex, reverseOrder, submesh, triangles);
		}

		public static void AddTriangleFan(this MeshX mesh, int vertexCount, Func<int, int> getVertexIndex, bool reverseOrder = false, int submesh = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AddTriangleFan", mesh, vertexCount, getVertexIndex, reverseOrder, submesh);
		}

		public static void ConnectTriangleFan(this MeshX mesh, IList<int> vertices, Func<int> getNextTriangle, bool reverseOrder = false, int submesh = 0, TriangleCollection triangles = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ConnectTriangleFan", mesh, vertices, getNextTriangle, reverseOrder, submesh, triangles);
		}

		public static void SetupAsPointCloud(this MeshX mesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SetupAsPointCloud", mesh);
		}

		public static void ConvertToPointCloud(this MeshX mesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshX_Extensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToPointCloud", mesh);
		}
	}
	public enum SubmeshTopology
	{
		Points,
		Triangles
	}
	public interface ISubmesh<P> : ResoniteBridge.ResoniteBridgeValueHolder where P : IMeshXPrimitive
	{
		P this[int index] { get; }
	}
	public abstract class Submesh : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public readonly MeshX Mesh;

		internal int[] indicies;

		internal int[] primitiveIDs;

		private int _currentID;

		public abstract SubmeshTopology Topology { get; }

		public int Index => Mesh.IndexOfSubmesh(this);

		public int Count { get; protected set; }

		public int IndicieCount => Count * IndiciesPerElement;

		public int[] RawIndicies => indicies;

		public int Capacity
		{
			get
			{
				int[] array = indicies;
				return ((array != null) ? array.Length : 0) / IndiciesPerElement;
			}
		}

		public abstract int IndiciesPerElement { get; }

		internal int PrimitivesVersion { get; private set; }

		public Submesh(MeshX mesh)
		{
			Mesh = mesh;
			PrimitivesVersion = -1;
		}

		public bool SetCountAndSequence(int count, int sequenceStart = 0)
		{
			int num = count - Count;
			if (num > 0)
			{
				int count2 = Count;
				IncreaseCount(num);
				for (int i = count2 * IndiciesPerElement; i < IndicieCount; i++)
				{
					indicies[i] = i + sequenceStart;
				}
			}
			else if (num < 0)
			{
				RemoveFromEnd(-num);
			}
			return num != 0;
		}

		public void Clear()
		{
			Count = 0;
		}

		public bool SetCount(int count)
		{
			int num = count - Count;
			if (num > 0)
			{
				IncreaseCount(num);
			}
			else if (num < 0)
			{
				RemoveFromEnd(-num);
			}
			return num != 0;
		}

		public void IncreaseCount(int count)
		{
			Count += count;
			if (Capacity < Count)
			{
				EnsureCapacity(MathX.Max(Capacity * 2, Count, 4));
			}
			if (Mesh.TrackRemovals)
			{
				for (int i = Count - count; i < Count; i++)
				{
					primitiveIDs[i] = _currentID++;
				}
			}
		}

		public void Append(Submesh submesh)
		{
			if (submesh.Topology != Topology)
			{
				throw new InvalidOperationException("Submesh topology mismatch!");
			}
			IncreaseCount(submesh.Count);
			Array.Copy(submesh.RawIndicies, 0, RawIndicies, IndicieCount - submesh.IndicieCount, submesh.IndicieCount);
		}

		public void RemoveFromEnd(int count)
		{
			Remove(Count - count, count);
		}

		public void Remove(int index)
		{
			Remove(index, 1);
		}

		public void Remove(int index, int count)
		{
			if (count != 0)
			{
				VerifyIndex(index);
				if (index + count > Count)
				{
					throw new ArgumentOutOfRangeException("count");
				}
				if (index + count != Count)
				{
					PrimitivesVersion--;
				}
				int indiciesPerElement = IndiciesPerElement;
				Mesh.RemoveElements(indicies, index * indiciesPerElement, count * indiciesPerElement, Count * indiciesPerElement, clear: false, 0);
				Mesh.RemoveElements(primitiveIDs, index, count, Count, clear: true, int.MaxValue);
				Count -= count;
			}
		}

		private void EnsureCapacity(int capacity)
		{
			Mesh.EnsureArray(state: true, ref indicies, capacity * IndiciesPerElement, 0);
			Mesh.EnsureArray(Mesh.TrackRemovals, ref primitiveIDs, capacity, 0);
		}

		internal void VerifyIndex(int index)
		{
			if (index < 0 || index >= Count)
			{
				throw new ArgumentOutOfRangeException($"index = {index}");
			}
		}

		internal bool UpdateIndex(ref int version, ref int index)
		{
			if (version < 0)
			{
				if (version != PrimitivesVersion)
				{
					throw new Exception("Primitive has been invalidated");
				}
			}
			else if (version != primitiveIDs[index])
			{
				while (index > 0 && primitiveIDs[index] > version)
				{
					index--;
				}
				if (primitiveIDs[index] != version)
				{
					throw new Exception("Primitive has been removed");
				}
				return true;
			}
			return false;
		}

		internal void VerticesRemoved(int index, int count)
		{
			int num = index + count;
			for (int i = 0; i < indicies.Length; i++)
			{
				if (indicies[i] >= index && indicies[i] < num)
				{
					indicies[i] = -1;
				}
				else if (indicies[i] >= num)
				{
					indicies[i] -= count;
				}
			}
		}

		internal void EnableTrackRemovals()
		{
			for (int i = 0; i < Count; i++)
			{
				primitiveIDs[i] = _currentID++;
			}
		}

		internal void Encode(BinaryWriter bw)
		{
			bw.Write7BitEncoded((ulong)Count);
			if (Count > 0)
			{
				for (int i = 0; i < IndicieCount; i++)
				{
					bw.Write(indicies[i]);
				}
			}
		}

		internal void Decode(BinaryReader br)
		{
			int count = (int)br.Read7BitEncoded();
			IncreaseCount(count);
			for (int i = 0; i < IndicieCount; i++)
			{
				indicies[i] = br.ReadInt32();
			}
		}

		public Elements.Core.BoundingBox CalculateBoundingBox()
		{
			int invalidIndicies;
			return CalculateBoundingBox(out invalidIndicies);
		}

		public Elements.Core.BoundingBox CalculateBoundingBox(out int invalidIndicies)
		{
			Elements.Core.BoundingBox result = default(Elements.Core.BoundingBox);
			result.MakeEmpty();
			invalidIndicies = 0;
			float3[] positions = Mesh.positions;
			if (positions != null)
			{
				for (int i = 0; i < IndicieCount; i++)
				{
					int num = indicies[i];
					if (num >= 0 && num <= positions.Length)
					{
						float3 point = positions[num];
						if (point.IsValid())
						{
							result.Encapsulate(in point);
						}
						else
						{
							invalidIndicies++;
						}
					}
					else
					{
						invalidIndicies++;
					}
				}
			}
			return result;
		}

		public SubmeshMetadata CalculateMetadata()
		{
			SubmeshMetadata result = default(SubmeshMetadata);
			result.elementCount = Count;
			result.topology = Topology;
			result.bounds = CalculateBoundingBox(out result.invalidIndicieCount);
			return result;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public struct SubmeshMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int elementCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "elementCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "elementCount", value);
			}
		}

		public SubmeshTopology topology
		{
			get
			{
				return (SubmeshTopology)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "topology"), typeof(SubmeshTopology));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "topology", value);
			}
		}

		public Elements.Core.BoundingBox bounds
		{
			get
			{
				return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "bounds"), typeof(Elements.Core.BoundingBox));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "bounds", value);
			}
		}

		public int invalidIndicieCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "invalidIndicieCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "invalidIndicieCount", value);
			}
		}

		[JsonPropertyName("elementCount")]
		[JsonProperty(PropertyName = "elementCount")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int ElementCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ElementCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ElementCount", value);
			}
		}

		[JsonPropertyName("invalidIndicieCount")]
		[JsonProperty(PropertyName = "invalidIndicieCount")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int InvalidIndicieCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InvalidIndicieCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InvalidIndicieCount", value);
			}
		}

		[JsonProperty(PropertyName = "topology")]
		[JsonPropertyName("topology")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public SubmeshTopology Topology
		{
			get
			{
				return (SubmeshTopology)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Topology"), typeof(SubmeshTopology));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Topology", value);
			}
		}

		[JsonProperty(PropertyName = "bounds")]
		[JsonPropertyName("bounds")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Elements.Core.BoundingBox Bounds
		{
			get
			{
				return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Bounds"), typeof(Elements.Core.BoundingBox));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Bounds", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SubmeshMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public struct BoneMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int weight0count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight0count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight0count", value);
			}
		}

		public int weight1count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight1count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight1count", value);
			}
		}

		public int weight2count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight2count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight2count", value);
			}
		}

		public int weight3count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "weight3count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "weight3count", value);
			}
		}

		public Elements.Core.BoundingBox bounds
		{
			get
			{
				return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "bounds"), typeof(Elements.Core.BoundingBox));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "bounds", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public int TotalVertexCount => weight0count + weight1count + weight2count + weight3count;

		[JsonPropertyName("weight0count")]
		[JsonProperty(PropertyName = "weight0count")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Weight0Count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Weight0Count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Weight0Count", value);
			}
		}

		[JsonPropertyName("weight1count")]
		[JsonProperty(PropertyName = "weight1count")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Weight1Count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Weight1Count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Weight1Count", value);
			}
		}

		[JsonPropertyName("weight2count")]
		[JsonProperty(PropertyName = "weight2count")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Weight2Count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Weight2Count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Weight2Count", value);
			}
		}

		[JsonPropertyName("weight3count")]
		[JsonProperty(PropertyName = "weight3count")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int Weight3Count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Weight3Count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Weight3Count", value);
			}
		}

		[JsonPropertyName("bounds")]
		[JsonProperty(PropertyName = "bounds")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Elements.Core.BoundingBox Bounds
		{
			get
			{
				return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Bounds"), typeof(Elements.Core.BoundingBox));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Bounds", value);
			}
		}

		public int GetVertexCount(int weightIndex)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVertexCount", weightIndex), typeof(int));
		}

		public void SetVertexCount(int weightIndex, int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetVertexCount", weightIndex, count);
		}

		public static BoneMetadata CreateEmpty()
		{
			return (BoneMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BoneMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateEmpty"), typeof(BoneMetadata));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BoneMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public struct ApproximateBoneBounds : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int rootBoneIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rootBoneIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rootBoneIndex", value);
			}
		}

		public Elements.Core.BoundingSphere bounds
		{
			get
			{
				return (Elements.Core.BoundingSphere)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "bounds"), typeof(Elements.Core.BoundingSphere));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "bounds", value);
			}
		}

		[JsonPropertyName("rootBoneIndex")]
		[JsonProperty(PropertyName = "rootBoneIndex")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public int RootBoneIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RootBoneIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RootBoneIndex", value);
			}
		}

		[JsonPropertyName("bounds")]
		[JsonProperty(PropertyName = "bounds")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public Elements.Core.BoundingSphere Bounds
		{
			get
			{
				return (Elements.Core.BoundingSphere)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Bounds"), typeof(Elements.Core.BoundingSphere));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Bounds", value);
			}
		}

		public ApproximateBoneBounds(int rootBoneIndex, Elements.Core.BoundingSphere bounds)
		{
			this.rootBoneIndex = rootBoneIndex;
			this.bounds = bounds;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ApproximateBoneBounds(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct MultiVertex : IVertex, IEnumerable<Vertex>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private VertexCollection _vertices
		{
			get
			{
				return (VertexCollection)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_vertices"), typeof(VertexCollection));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_vertices", value);
			}
		}

		public int Count => _vertices?.Count ?? 0;

		public MeshX Mesh
		{
			get
			{
				return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Mesh"), typeof(MeshX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Mesh", value);
			}
		}

		public float3 Position
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Position"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Position", value);
			}
		}

		public float3 Normal
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Normal"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Normal", value);
			}
		}

		public float3 Tangent
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Tangent"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Tangent", value);
			}
		}

		public float4 Tangent4
		{
			get
			{
				return (float4)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Tangent4"), typeof(float4));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Tangent4", value);
			}
		}

		public color Color
		{
			get
			{
				return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Color"), typeof(color));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Color", value);
			}
		}

		public BoneBinding BoneBinding
		{
			get
			{
				return (BoneBinding)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BoneBinding"), typeof(BoneBinding));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BoneBinding", value);
			}
		}

		public float2 UV0
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV0"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV0", value);
			}
		}

		public float2 UV1
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV1"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV1", value);
			}
		}

		public float2 UV2
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV2"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV2", value);
			}
		}

		public float2 UV3
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV3"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV3", value);
			}
		}

		public void Add(Vertex v)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", v);
		}

		public bool Remove(Vertex v)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", v), typeof(bool));
		}

		public IEnumerator<Vertex> GetEnumerator()
		{
			return (IEnumerator<Vertex>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<Vertex>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		public float2 GetUV(int channel)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUV", channel), typeof(float2));
		}

		public void SetUV(int channel, in float2 uv)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetUV", channel, uv);
		}

		private void CheckVertices()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckVertices");
		}

		private void Set(Action<Vertex> set)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Set", set);
		}

		public float3 GetBlendShapePositionDelta(string key, int frame = 0)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShapePositionDelta", key, frame), typeof(float3));
		}

		public void SetBlendShapePositionDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapePositionDelta", key, delta, frame);
		}

		public float3 GetBlendShapeNormalDelta(string key, int frame = 0)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShapeNormalDelta", key, frame), typeof(float3));
		}

		public void SetBlendShapeNormalDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeNormalDelta", key, delta, frame);
		}

		public float3 GetBlendShapeTangentDelta(string key, int frame = 0)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShapeTangentDelta", key, frame), typeof(float3));
		}

		public void SetBlendShapeTangentDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeTangentDelta", key, delta, frame);
		}

		void IVertex.SetUV(int channel, in float2 uv)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetUV", channel, uv);
		}

		void IVertex.SetBlendShapePositionDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapePositionDelta", key, delta, frame);
		}

		void IVertex.SetBlendShapeNormalDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeNormalDelta", key, delta, frame);
		}

		void IVertex.SetBlendShapeTangentDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeTangentDelta", key, delta, frame);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MultiVertex(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class PolarGrid : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float RingsRadiusBegin
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RingsRadiusBegin"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RingsRadiusBegin", value);
			}
		}

		public float RingsRadiusEnd
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RingsRadiusEnd"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RingsRadiusEnd", value);
			}
		}

		public float RingWidth
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RingWidth"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RingWidth", value);
			}
		}

		public int RingCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RingCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RingCount", value);
			}
		}

		public float LinesRadiusBegin
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LinesRadiusBegin"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LinesRadiusBegin", value);
			}
		}

		public float LinesRadiusEnd
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LinesRadiusEnd"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LinesRadiusEnd", value);
			}
		}

		public float LineThickness
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LineThickness"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LineThickness", value);
			}
		}

		public int LineCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LineCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LineCount", value);
			}
		}

		public int RingSegments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RingSegments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RingSegments", value);
			}
		}

		private List<Ring> rings
		{
			get
			{
				return (List<Ring>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rings"), typeof(List<Ring>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rings", value);
			}
		}

		private List<Quad> lines
		{
			get
			{
				return (List<Quad>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "lines"), typeof(List<Quad>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "lines", value);
			}
		}

		public PolarGrid(MeshX meshx, int ringSegments = 32)
			: base(meshx)
		{
			meshx.TrackRemovals = true;
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PolarGrid(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Point : IMeshXPrimitive, IMeshXElement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private int index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "index", value);
			}
		}

		private int version
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "version"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "version", value);
			}
		}

		private PointSubmesh submesh
		{
			get
			{
				return (PointSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "submesh"), typeof(PointSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "submesh", value);
			}
		}

		public PointSubmesh Submesh => submesh;

		public MeshX Mesh => submesh?.Mesh;

		Submesh IMeshXPrimitive.Submesh => submesh;

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public int SubmeshIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SubmeshIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SubmeshIndex", value);
			}
		}

		public int VertexIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VertexIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VertexIndex", value);
			}
		}

		public Vertex Vertex
		{
			get
			{
				return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex"), typeof(Vertex));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex", value);
			}
		}

		internal Point(int index, PointSubmesh submesh)
		{
			this.index = index;
			this.submesh = submesh;
			if (submesh.Mesh.TrackRemovals)
			{
				version = submesh.primitiveIDs[index];
			}
			else
			{
				version = submesh.PrimitivesVersion;
			}
		}

		internal bool UpdateIndex()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateIndex"), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Point(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class PointCollection : IEnumerable<Point>, IEnumerable, IList<Point>, ICollection<Point>, IPoolable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		internal List<Point> _points
		{
			get
			{
				return (List<Point>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_points"), typeof(List<Point>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_points", value);
			}
		}

		public int Count => _points.Count;

		public int Capacity
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Capacity"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Capacity", value);
			}
		}

		public bool IsReadOnly => false;

		public Point this[int index]
		{
			get
			{
				Point point = _points[index];
				if (point.UpdateIndex())
				{
					_points[index] = point;
				}
				return point;
			}
			set
			{
				_points[index] = value;
			}
		}

		public void UpdateIndexes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateIndexes");
		}

		public PointCollection()
			: this(4)
		{
		}

		public PointCollection(int capacity = 4)
		{
			_points = new List<Point>(capacity);
		}

		public void Add(Point v)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", v);
		}

		public void AddRange(IEnumerable<Point> collection)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddRange", collection);
		}

		public bool Remove(Point v)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", v), typeof(bool));
		}

		public void RemoveAt(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveAt", index);
		}

		public void RemoveRange(int index, int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveRange", index, count);
		}

		public IEnumerator<Point> GetEnumerator()
		{
			return (IEnumerator<Point>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<Point>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		public int IndexOf(Point item)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IndexOf", item), typeof(int));
		}

		public void Insert(int index, Point item)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Insert", index, item);
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public bool Contains(Point item)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Contains", item), typeof(bool));
		}

		public void CopyTo(Point[] array, int arrayIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyTo", array, arrayIndex);
		}

		void IPoolable.Clean()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clean");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PointCollection(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class PointSubmesh : Submesh, ISubmesh<Point>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override SubmeshTopology Topology => SubmeshTopology.Points;

		public override int IndiciesPerElement => 1;

		public Point this[int index] => GetPoint(index);

		public PointSubmesh(MeshX mesh)
			: base(mesh)
		{
		}

		public Point AddPoint()
		{
			return (Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddPoint"), typeof(Point));
		}

		public Point AddPoint(int vIndex)
		{
			return (Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddPoint", vIndex), typeof(Point));
		}

		public void AddPoints(int count, PointCollection points = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddPoints", count, points);
		}

		public Point GetPoint(int index)
		{
			return (Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPoint", index), typeof(Point));
		}

		public void SetPoint(int index, int vIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPoint", index, vIndex);
		}

		public void Remove(Point p)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", p);
		}

		public void Remove(PointCollection points)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", points);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PointSubmesh(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class SmoothNormalsContext : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private double cellSize
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "cellSize"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "cellSize", value);
			}
		}

		private double multiplier
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "multiplier"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "multiplier", value);
			}
		}

		private Dictionary<int3, float3> normals
		{
			get
			{
				return (Dictionary<int3, float3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "normals"), typeof(Dictionary<int3, float3>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "normals", value);
			}
		}

		public SmoothNormalsContext(double cellSize = 0.001)
		{
			this.cellSize = cellSize;
			multiplier = 1.0 / cellSize;
			normals = Pool.BorrowDictionary<int3, float3>();
		}

		public float3 GetNormal(in float3 position)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetNormal", position), typeof(float3));
		}

		public bool TryGetNormal(in float3 position, out float3 normal)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryGetNormal", position, normal), typeof(bool));
		}

		public void AssignNormal(Vertex vertex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AssignNormal", vertex);
		}

		public void StoreNormal(in float3 normal, in float3 position)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreNormal", normal, position);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SmoothNormalsContext(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Arrow", "Elements.Core")]
	public class Arrow : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public int Sides
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Sides"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Sides", value);
			}
		}

		public float3 Vector
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Vector"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Vector", value);
			}
		}

		public float BodyRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BodyRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BodyRadius", value);
			}
		}

		public float HeadRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "HeadRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "HeadRadius", value);
			}
		}

		public float HeadLength
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "HeadLength"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "HeadLength", value);
			}
		}

		public float MinimalBodyLength
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MinimalBodyLength"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MinimalBodyLength", value);
			}
		}

		private ConicalFrustum head
		{
			get
			{
				return (ConicalFrustum)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "head"), typeof(ConicalFrustum));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "head", value);
			}
		}

		private ConicalFrustum body
		{
			get
			{
				return (ConicalFrustum)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "body"), typeof(ConicalFrustum));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "body", value);
			}
		}

		public colorX ColorBase
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ColorBase"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ColorBase", value);
			}
		}

		public colorX ColorTop
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ColorTop"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ColorTop", value);
			}
		}

		public colorX ColorHead
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ColorHead"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ColorHead", value);
			}
		}

		public float2 BodyUVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BodyUVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BodyUVScale", value);
			}
		}

		public float2 BodyUVOffset
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BodyUVOffset"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BodyUVOffset", value);
			}
		}

		public float2 HeadUVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HeadUVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HeadUVScale", value);
			}
		}

		public float2 HeadUVOffset
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HeadUVOffset"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HeadUVOffset", value);
			}
		}

		public Arrow(TriangleSubmesh submesh, int sides)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			Sides = sides;
			body = new ConicalFrustum(submesh, sides, flatShading: false);
			head = new ConicalFrustum(submesh, sides, flatShading: false);
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		public override void Remove()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Arrow(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.BevelBox", "Elements.Core")]
	public class BevelBox : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public float3 Size
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public float Bevel
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Bevel"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Bevel", value);
			}
		}

		public float3 UVScale
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		private int faceVertOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "faceVertOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "faceVertOffset", value);
			}
		}

		private int edgeVertOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "edgeVertOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "edgeVertOffset", value);
			}
		}

		private int cornerVertOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "cornerVertOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "cornerVertOffset", value);
			}
		}

		private static color DEBUG_COLOR(int index)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BevelBox", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_COLOR", index), typeof(color));
		}

		public BevelBox(TriangleSubmesh submesh)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			faceVertOffset = base.AllVertices.Count;
			base.Mesh.AddVertices(24, base.AllVertices);
			for (int i = 0; i < 6; i++)
			{
				int num = i * 4 + faceVertOffset;
				MeshX_Extensions.QuadTriangles quadTriangles = Submesh.AddQuadAsTriangles(base.AllVertices[num], base.AllVertices[num + 1], base.AllVertices[num + 2], base.AllVertices[num + 3]);
				base.AllTriangles.Add(quadTriangles.first);
				base.AllTriangles.Add(quadTriangles.second);
			}
			cornerVertOffset = base.AllVertices.Count;
			base.Mesh.AddVertices(24, base.AllVertices);
			for (int j = 0; j < 8; j++)
			{
				int num2 = j * 3 + cornerVertOffset;
				Triangle v;
				switch (j)
				{
					case 1:
					case 2:
					case 4:
					case 7:
						v = Submesh.AddTriangle(base.AllVertices[num2 + 2], base.AllVertices[num2 + 1], base.AllVertices[num2]);
						break;
					default:
						v = Submesh.AddTriangle(base.AllVertices[num2], base.AllVertices[num2 + 1], base.AllVertices[num2 + 2]);
						break;
				}
				base.AllTriangles.Add(v);
			}
			edgeVertOffset = base.AllVertices.Count;
			base.Mesh.AddVertices(48, base.AllVertices);
			for (int k = 0; k < 12; k++)
			{
				int num3 = k * 4 + edgeVertOffset;
				bool flag = false;
				switch (k)
				{
					case 1:
					case 2:
					case 4:
					case 7:
					case 9:
					case 10:
						flag = true;
						break;
				}
				MeshX_Extensions.QuadTriangles quadTriangles2 = Submesh.AddQuadAsTriangles(base.AllVertices[num3 + (flag ? 3 : 0)], base.AllVertices[num3 + ((!flag) ? 1 : 2)], base.AllVertices[num3 + (flag ? 1 : 2)], base.AllVertices[num3 + ((!flag) ? 3 : 0)]);
				base.AllTriangles.Add(quadTriangles2.first);
				base.AllTriangles.Add(quadTriangles2.second);
			}
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private void PositionFace(float3 sideOffset, Func<float2, float3> vertexOffset, float2 uvScale, int side)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PositionFace", sideOffset, vertexOffset, uvScale, side);
		}

		private void PositionCorner(float3 basePosition, float bevel, int corner)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PositionCorner", basePosition, bevel, corner);
		}

		private void PositionEdge(ref float3 basePosition, ref float3 edgeAxis, ref float3 moveAxis0, ref float3 moveAxis1, float bevel, float edgeLength, int edge)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PositionEdge", basePosition, edgeAxis, moveAxis0, moveAxis1, bevel, edgeLength, edge);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BevelBox(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Box", "Elements.Core")]
	public class Box : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int TOTAL_VERTICES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TOTAL_VERTICES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TOTAL_VERTICES", value);
			}
		}

		public int TOTAL_TRIANGLES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TOTAL_TRIANGLES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TOTAL_TRIANGLES", value);
			}
		}

		public Vertex FirstVertex
		{
			get
			{
				return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FirstVertex"), typeof(Vertex));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FirstVertex", value);
			}
		}

		public float3 Size
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public float3 UVScale
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public colorX? Color
		{
			get
			{
				return (colorX?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Color"), typeof(colorX?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Color", value);
			}
		}

		public override void Remove()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove");
		}

		public Box(Vertex firstVertex)
			: base(firstVertex.Mesh)
		{
			FirstVertex = firstVertex;
		}

		public Box(TriangleSubmesh submesh)
			: base(submesh.Mesh)
		{
			FirstVertex = AddCubeGeometry(submesh, base.AllTriangles);
			base.Mesh.HasNormals = true;
			base.Mesh.HasTangents = true;
			base.Mesh.HasUV0s = true;
		}

		public static void ConnectTrianglesUnsafe(int firstVertex, int firstTriangle, TriangleSubmesh submesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Box", ResoniteBridge.ResoniteBridgeValueType.Type), "ConnectTrianglesUnsafe", firstVertex, firstTriangle, submesh);
		}

		public static Vertex AddCubeGeometry(TriangleSubmesh submesh, TriangleCollection triangles = null)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Box", ResoniteBridge.ResoniteBridgeValueType.Type), "AddCubeGeometry", submesh, triangles), typeof(Vertex));
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		public void UpdateUnsafe(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateUnsafe", index);
		}

		private static float3 GetVertexOffset(in float2 v, in float3 halfSize, int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Box", ResoniteBridge.ResoniteBridgeValueType.Type), "GetVertexOffset", v, halfSize, index), typeof(float3));
		}

		public static void UpdateAxisAlignedBoxVertices(MeshX mesh, int index, in float3 from, in float3 to, in float3 uvScale, in colorX? color)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Box", ResoniteBridge.ResoniteBridgeValueType.Type), "UpdateAxisAlignedBoxVertices", mesh, index, from, to, uvScale, color);
		}

		public static void UpdateBoxVertices(MeshX mesh, int index, in float3 size, in float3 uvScale, in float3? position, in floatQ? rotation, in colorX? color)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Box", ResoniteBridge.ResoniteBridgeValueType.Type), "UpdateBoxVertices", mesh, index, size, uvScale, position, rotation, color);
		}

		private static void PositionQuad(int index, in float3 sideDir, float offset, in float3 halfSize, in float2 uvScale, int side, MeshX mesh, in float3? position, in floatQ? rotation, in colorX? color)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Box", ResoniteBridge.ResoniteBridgeValueType.Type), "PositionQuad", index, sideDir, offset, halfSize, uvScale, side, mesh, position, rotation, color);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Box(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Circle", "Elements.Core")]
	public class Circle : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Segments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Segments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Segments", value);
			}
		}

		public bool TriangleFan
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TriangleFan"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TriangleFan", value);
			}
		}

		public float Radius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Radius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Radius", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public float Arc
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Arc"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Arc", value);
			}
		}

		public Circle(MeshX mesh, int segments, bool triangleFan)
			: base(mesh)
		{
			Segments = segments;
			TriangleFan = triangleFan;
			mesh.AddVertices(triangleFan ? (segments + 1) : segments, base.AllVertices);
			mesh.AddTriangleFan(base.AllVertices, reverseOrder: false, 0, base.AllTriangles);
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Circle(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.ConicalFrustum", "Elements.Core")]
	public class ConicalFrustum : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum UV_Mapping
		{
			Cylindrical,
			Radial
		}

		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public int Sides
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Sides"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Sides", value);
			}
		}

		public bool FlatShading
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FlatShading"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FlatShading", value);
			}
		}

		public bool Cap
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Cap"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Cap", value);
			}
		}

		public float Height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Height", value);
			}
		}

		public float RadiusBottom
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RadiusBottom"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RadiusBottom", value);
			}
		}

		public float RadiusTop
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RadiusTop"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RadiusTop", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public float2 UVOffset
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVOffset"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVOffset", value);
			}
		}

		public UV_Mapping UVMapping
		{
			get
			{
				return (UV_Mapping)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVMapping"), typeof(UV_Mapping));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVMapping", value);
			}
		}

		public colorX ColorBase
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ColorBase"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ColorBase", value);
			}
		}

		public colorX ColorTop
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ColorTop"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ColorTop", value);
			}
		}

		public int SideVerts
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SideVerts"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SideVerts", value);
			}
		}

		public int CapVerts
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CapVerts"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CapVerts", value);
			}
		}

		public float3[] BaseVertexOffset
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BaseVertexOffset"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BaseVertexOffset", value);
			}
		}

		public float3[] TopVertexOffset
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TopVertexOffset"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TopVertexOffset", value);
			}
		}

		private int _baseVertOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_baseVertOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_baseVertOffset", value);
			}
		}

		private int _topVertOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_topVertOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_topVertOffset", value);
			}
		}

		private int _baseCapVertOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_baseCapVertOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_baseCapVertOffset", value);
			}
		}

		private int _topCapVertOffset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_topCapVertOffset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_topCapVertOffset", value);
			}
		}

		public float Radius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Radius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Radius", value);
			}
		}

		public ConicalFrustum(TriangleSubmesh submesh, int sides, bool flatShading, bool cap = true)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			Sides = sides;
			FlatShading = flatShading;
			Cap = cap;
			SideVerts = (FlatShading ? (sides * 2) : (sides + 1));
			CapVerts = sides;
			BaseVertexOffset = new float3[sides];
			TopVertexOffset = new float3[sides];
			_baseVertOffset = base.AllVertices.Count;
			base.Mesh.AddVertices(SideVerts, base.AllVertices);
			_topVertOffset = base.AllVertices.Count;
			base.Mesh.AddVertices(SideVerts, base.AllVertices);
			if (Cap)
			{
				_baseCapVertOffset = base.AllVertices.Count;
				base.Mesh.AddVertices(CapVerts, base.AllVertices);
				_topCapVertOffset = base.AllVertices.Count;
				base.Mesh.AddVertices(CapVerts, base.AllVertices);
			}
			for (int i = 0; i < sides; i++)
			{
				int num = (FlatShading ? (i * 2) : i);
				MeshX_Extensions.QuadTriangles quadTriangles = Submesh.AddQuadAsTriangles(base.AllVertices[_baseVertOffset + num + 1], base.AllVertices[_topVertOffset + num + 1], base.AllVertices[_topVertOffset + num], base.AllVertices[_baseVertOffset + num], reverse: true);
				base.AllTriangles.Add(quadTriangles.first);
				base.AllTriangles.Add(quadTriangles.second);
			}
			if (Cap)
			{
				Submesh.AddTriangleFan(base.AllVertices, _baseCapVertOffset, CapVerts, reverseOrder: false, base.AllTriangles);
				Submesh.AddTriangleFan(base.AllVertices, _topCapVertOffset, CapVerts, reverseOrder: true, base.AllTriangles);
			}
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ConicalFrustum(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.ConicalTube", "Elements.Core")]
	public class ConicalTube : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Segments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Segments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Segments", value);
			}
		}

		public float Height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Height", value);
			}
		}

		public float UpperOuterRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UpperOuterRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UpperOuterRadius", value);
			}
		}

		public float UpperInnerRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UpperInnerRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UpperInnerRadius", value);
			}
		}

		public float LowerOuterRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LowerOuterRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LowerOuterRadius", value);
			}
		}

		public float LowerInnerRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LowerInnerRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LowerInnerRadius", value);
			}
		}

		private Screw _outerWall
		{
			get
			{
				return (Screw)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_outerWall"), typeof(Screw));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_outerWall", value);
			}
		}

		private Screw _innerWall
		{
			get
			{
				return (Screw)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_innerWall"), typeof(Screw));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_innerWall", value);
			}
		}

		private Screw _top
		{
			get
			{
				return (Screw)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_top"), typeof(Screw));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_top", value);
			}
		}

		private Screw _bottom
		{
			get
			{
				return (Screw)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_bottom"), typeof(Screw));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_bottom", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UVScale", value);
			}
		}

		public ConicalTube(TriangleSubmesh submesh, int segments)
			: base(submesh.Mesh)
		{
			Segments = segments;
			_outerWall = new Screw(submesh, segments, 2);
			_outerWall.WrapAroundCurve = false;
			_outerWall.WrapAroundSegments = true;
			_innerWall = new Screw(submesh, segments, 2);
			_innerWall.WrapAroundCurve = false;
			_innerWall.WrapAroundSegments = true;
			_top = new Screw(submesh, segments, 2);
			_top.WrapAroundCurve = false;
			_top.WrapAroundSegments = true;
			_bottom = new Screw(submesh, segments, 2);
			_bottom.WrapAroundCurve = false;
			_bottom.WrapAroundSegments = true;
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		public override void Remove()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove");
		}

		public override void RemoveGeometry()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveGeometry");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ConicalTube(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class EdgeBlockBuilder : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class Point : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public float2 Position
			{
				get
				{
					return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Position"), typeof(float2));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Position", value);
				}
			}

			public float2 Normal
			{
				get
				{
					return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Normal"), typeof(float2));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Normal", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Point(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public readonly TriangleSubmesh Submesh;

		public bool CalculateNormals = true;

		public bool AutoPointNormals = true;

		public bool UniformWidthNormals = true;

		private List<Point> points = new List<Point>();

		private bool _geometryBuilt;

		public abstract int ProfileVertexCount { get; }

		public abstract bool FlatShading { get; }

		public int PointCount => points.Count;

		private int ActualPointVertexCount
		{
			get
			{
				if (!FlatShading)
				{
					return ProfileVertexCount;
				}
				return ActualProfileVertexCount * 2 + 2;
			}
		}

		private int ActualProfileVertexCount
		{
			get
			{
				if (!FlatShading)
				{
					return ProfileVertexCount;
				}
				return ProfileVertexCount * 2 - 2;
			}
		}

		protected abstract void UpdateVertex(Vertex vert, Point point, int index);

		protected void InvalidateGeometry()
		{
			_geometryBuilt = false;
		}

		public EdgeBlockBuilder(TriangleSubmesh submesh)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
		}

		public Point AddPoint()
		{
			Point point = new Point();
			points.Add(point);
			InvalidateGeometry();
			return point;
		}

		public void RemovePoint(Point point)
		{
			points.Remove(point);
			InvalidateGeometry();
		}

		public void RemovePointAt(int index)
		{
			points.RemoveAt(index);
			InvalidateGeometry();
		}

		public Point GetPoint(int index)
		{
			return points[index];
		}

		private Vertex GetPointFillVertex(int pointIndex, bool top)
		{
			if (FlatShading)
			{
				return base.AllVertices[pointIndex * ActualPointVertexCount + ActualProfileVertexCount * 2 + (top ? 1 : 0)];
			}
			return base.AllVertices[pointIndex * ActualPointVertexCount + (top ? (ActualPointVertexCount - 1) : 0)];
		}

		private Vertex GetPointEdgeVertex(int pointIndex, int vertexIndex, bool connectingToEdge)
		{
			if (FlatShading)
			{
				return base.AllVertices[pointIndex * ActualPointVertexCount + vertexIndex + ((!connectingToEdge) ? ActualProfileVertexCount : 0)];
			}
			return base.AllVertices[pointIndex * ActualPointVertexCount + vertexIndex];
		}

		private int GetProfileVertexIndex(int actualVertexSubindex)
		{
			if (FlatShading)
			{
				if (actualVertexSubindex < ActualProfileVertexCount * 2)
				{
					actualVertexSubindex %= ActualProfileVertexCount;
					if (actualVertexSubindex == 0)
					{
						return 0;
					}
					if (actualVertexSubindex == ActualProfileVertexCount - 1)
					{
						return ProfileVertexCount - 1;
					}
					actualVertexSubindex--;
					actualVertexSubindex /= 2;
					return 1 + actualVertexSubindex;
				}
				if (actualVertexSubindex == ActualProfileVertexCount * 2)
				{
					return 0;
				}
				return ProfileVertexCount - 1;
			}
			return actualVertexSubindex;
		}

		public void CalculatePointNormals()
		{
			for (int i = 0; i < points.Count; i++)
			{
				Point point = points[MathX.Repeat(i - 1, points.Count - 1)];
				Point point2 = points[MathX.Repeat(i + 1, points.Count - 1)];
				float2 a = (point.Position - points[i].Position).Normalized;
				float2 b = (point2.Position - points[i].Position).Normalized;
				float a2 = MathX.AngleRad(in a, in b) / 2f;
				float num = 1f / MathX.Tan(a2);
				if (float.IsNaN(num))
				{
					num = 0f;
				}
				float2 a3 = a * num;
				float2 a4 = MathX.RotateRad(in a, MathF.PI / 2f);
				float2 a5 = MathX.RotateRad(in a, -MathF.PI / 2f);
				float2 b2 = ((MathX.Dot(in a4, in b) > MathX.Dot(in a5, in b)) ? a4 : a5);
				float2 v = a3 + b2;
				if (!UniformWidthNormals)
				{
					v = v.Normalized;
				}
				points[i].Normal = -v;
			}
		}

		public override void Update()
		{
			Update(out var _);
		}

		public void Update(out bool changedGeometry)
		{
			changedGeometry = false;
			if (!_geometryBuilt)
			{
				changedGeometry = true;
				base.Mesh.RemoveTriangles(base.AllTriangles);
				base.Mesh.RemoveVertices(base.AllVertices);
				base.AllTriangles.Clear();
				base.AllVertices.Clear();
				if (points.Count >= 3)
				{
					base.Mesh.AddVertices(ActualPointVertexCount * points.Count, base.AllVertices);
					for (int i = 0; i < points.Count; i++)
					{
						for (int j = 0; j < ActualProfileVertexCount - 1; j += ((!FlatShading) ? 1 : 2))
						{
							Vertex pointEdgeVertex = GetPointEdgeVertex(i % points.Count, j, connectingToEdge: false);
							Vertex pointEdgeVertex2 = GetPointEdgeVertex(i % points.Count, j + 1, connectingToEdge: false);
							Vertex pointEdgeVertex3 = GetPointEdgeVertex((i + 1) % points.Count, j + 1, connectingToEdge: true);
							Vertex pointEdgeVertex4 = GetPointEdgeVertex((i + 1) % points.Count, j, connectingToEdge: true);
							MeshX_Extensions.QuadTriangles quadTriangles = Submesh.AddQuadAsTriangles(pointEdgeVertex4, pointEdgeVertex3, pointEdgeVertex2, pointEdgeVertex);
							base.AllTriangles.Add(quadTriangles.first);
							base.AllTriangles.Add(quadTriangles.second);
						}
					}
					VertexCollection vertexCollection = new VertexCollection();
					for (int k = 0; k < points.Count; k++)
					{
						vertexCollection.Add(GetPointFillVertex(k, top: false));
					}
					Submesh.AddTriangleFan(vertexCollection, reverseOrder: true, base.AllTriangles);
					vertexCollection.Clear();
					for (int l = 0; l < points.Count; l++)
					{
						vertexCollection.Add(GetPointFillVertex(l, top: true));
					}
					Submesh.AddTriangleFan(vertexCollection, reverseOrder: false, base.AllTriangles);
				}
				_geometryBuilt = true;
			}
			if (points.Count < 3)
			{
				return;
			}
			if (AutoPointNormals)
			{
				CalculatePointNormals();
			}
			for (int m = 0; m < points.Count; m++)
			{
				for (int n = 0; n < ActualPointVertexCount; n++)
				{
					UpdateVertex(base.AllVertices[m * ActualPointVertexCount + n], points[m], GetProfileVertexIndex(n));
				}
			}
			TransformVertices(normalsAndTangents: false);
			if (CalculateNormals)
			{
				if (base.Mesh.TotalTriangleCount == base.AllTriangles.Count)
				{
					base.Mesh.RecalculateNormals();
				}
				else
				{
					base.Mesh.RecalculateNormals(base.AllTriangles);
				}
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.BevelEdgeBlockBuilder", "Elements.Core")]
	public class BevelEdgeBlockBuilder : EdgeBlockBuilder, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private bool _relief
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_relief"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_relief", value);
			}
		}

		private bool _flatShading
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_flatShading"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_flatShading", value);
			}
		}

		public float Thickness
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Thickness"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Thickness", value);
			}
		}

		public bool Relief
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Relief"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Relief", value);
			}
		}

		public override int ProfileVertexCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ProfileVertexCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ProfileVertexCount", value);
			}
		}

		public override bool FlatShading => _flatShading;

		public BevelEdgeBlockBuilder(MeshX meshx, bool flatShading = true)
			: base(meshx)
		{
			_flatShading = flatShading;
		}

		protected override void UpdateVertex(Vertex vert, Point point, int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateVertex", vert, point, index);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BevelEdgeBlockBuilder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.BevelPlane", "Elements.Core")]
	public class BevelPlane : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private float _width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_width", value);
			}
		}

		private float _height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_height", value);
			}
		}

		private float _thickness
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_thickness"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_thickness", value);
			}
		}

		public float TopLeftCut
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TopLeftCut"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TopLeftCut", value);
			}
		}

		public float BottomRightCut
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BottomRightCut"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BottomRightCut", value);
			}
		}

		private BevelEdgeBlockBuilder builder
		{
			get
			{
				return (BevelEdgeBlockBuilder)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "builder"), typeof(BevelEdgeBlockBuilder));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "builder", value);
			}
		}

		private EdgeBlockBuilder.Point p0
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p0"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p0", value);
			}
		}

		private EdgeBlockBuilder.Point p1
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p1"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p1", value);
			}
		}

		private EdgeBlockBuilder.Point p2
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p2"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p2", value);
			}
		}

		private EdgeBlockBuilder.Point p3
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p3"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p3", value);
			}
		}

		private EdgeBlockBuilder.Point p4
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p4"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p4", value);
			}
		}

		private EdgeBlockBuilder.Point p5
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p5"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p5", value);
			}
		}

		public float Width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		public float Height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Height", value);
			}
		}

		public float Thickness
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Thickness"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Thickness", value);
			}
		}

		public bool Relief
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Relief"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Relief", value);
			}
		}

		public float BorderWidth => ComputeBorderWidth(Thickness);

		public float UsableWidth => Width - BorderWidth * 2f;

		public float UsableHeight => Height - BorderWidth * 2f;

		private float ComputeBorderWidth(float thickness)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeBorderWidth", thickness), typeof(float));
		}

		public BevelPlane(MeshX meshx)
		{
			builder = new BevelEdgeBlockBuilder(meshx);
			builder.AutoPointNormals = false;
			p0 = builder.AddPoint();
			p1 = builder.AddPoint();
			p2 = builder.AddPoint();
			p3 = builder.AddPoint();
			p4 = builder.AddPoint();
			p5 = builder.AddPoint();
			p0.Normal = new float2(-1f);
			p1.Normal = new float2(0f, 1f);
			p2.Normal = new float2(1f, 1f);
			p3.Normal = new float2(1f);
			p4.Normal = new float2(0f, -1f);
			p5.Normal = new float2(-1f, -1f);
		}

		public void Update(out bool changedGeometry)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update", changedGeometry);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BevelPlane(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.BevelStripe", "Elements.Core")]
	public class BevelStripe : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private float _width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_width", value);
			}
		}

		private float _height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_height", value);
			}
		}

		private float _thickness
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_thickness"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_thickness", value);
			}
		}

		public float LeftSlantAngle
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LeftSlantAngle"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LeftSlantAngle", value);
			}
		}

		public float RightSlantAngle
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RightSlantAngle"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RightSlantAngle", value);
			}
		}

		private BevelEdgeBlockBuilder builder
		{
			get
			{
				return (BevelEdgeBlockBuilder)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "builder"), typeof(BevelEdgeBlockBuilder));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "builder", value);
			}
		}

		private EdgeBlockBuilder.Point p0
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p0"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p0", value);
			}
		}

		private EdgeBlockBuilder.Point p1
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p1"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p1", value);
			}
		}

		private EdgeBlockBuilder.Point p2
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p2"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p2", value);
			}
		}

		private EdgeBlockBuilder.Point p3
		{
			get
			{
				return (EdgeBlockBuilder.Point)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "p3"), typeof(EdgeBlockBuilder.Point));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "p3", value);
			}
		}

		public float3 Position
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Position"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Position", value);
			}
		}

		public floatQ Rotation
		{
			get
			{
				return (floatQ)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Rotation"), typeof(floatQ));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Rotation", value);
			}
		}

		public float3 Scale
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Scale"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Scale", value);
			}
		}

		public float Width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		public float Height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Height", value);
			}
		}

		public float Thickness
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Thickness"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Thickness", value);
			}
		}

		public bool Relief
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Relief"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Relief", value);
			}
		}

		public float SlantAngle
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SlantAngle", value);
			}
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SlantAngle"), typeof(float));
			}
		}

		public float LeftSlantOffset => CalculateSlantOffset(LeftSlantAngle);

		public float RightSlantOffset => CalculateSlantOffset(RightSlantAngle);

		public float UsableWidth => Width - LeftSlantOffset - RightSlantOffset - (Relief ? Thickness : (Thickness / 2f));

		public float BorderWidth => ComputeBorderWidth(Thickness);

		private float ComputeBorderWidth(float thickness)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeBorderWidth", thickness), typeof(float));
		}

		public BevelStripe(MeshX meshx)
		{
			builder = new BevelEdgeBlockBuilder(meshx);
			builder.AutoPointNormals = false;
			p0 = builder.AddPoint();
			p1 = builder.AddPoint();
			p2 = builder.AddPoint();
			p3 = builder.AddPoint();
		}

		public void Update(out bool changedGeometry)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update", changedGeometry);
		}

		public void Remove()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove");
		}

		private float CalculateSlantOffset(float angle)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateSlantOffset", angle), typeof(float));
		}

		public static float CalculateSlantOffset(float angle, float height)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BevelStripe", ResoniteBridge.ResoniteBridgeValueType.Type), "CalculateSlantOffset", angle, height), typeof(float));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BevelStripe(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Frame", "Elements.Core")]
	public class Frame : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float2 ContentSize
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ContentSize"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ContentSize", value);
			}
		}

		public float Thickness
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Thickness"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Thickness", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public Frame(TriangleSubmesh submesh)
			: base(submesh.Mesh)
		{
			base.Mesh.AddVertices(8, base.AllVertices);
			int indexUnsafe = base.AllVertices[0].IndexUnsafe;
			for (int i = 0; i < 4; i++)
			{
				int num = i * 2;
				MeshX_Extensions.QuadTriangles quadTriangles = base.Mesh.AddQuadAsTriangles((indexUnsafe + num) % 8, (indexUnsafe + 2 + num) % 8, (indexUnsafe + 3 + num) % 8, (indexUnsafe + 1 + num) % 8);
				base.AllTriangles.Add(quadTriangles.first);
				base.AllTriangles.Add(quadTriangles.second);
			}
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Frame(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Grid", "Elements.Core")]
	public class Grid : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public struct Point : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public color color
			{
				get
				{
					return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "color"), typeof(color));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "color", value);
				}
			}

			public float3 offset
			{
				get
				{
					return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "offset"), typeof(float3));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "offset", value);
				}
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public Point(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public bool FlatShading
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FlatShading"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FlatShading", value);
			}
		}

		public int2 Points
		{
			get
			{
				return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Points"), typeof(int2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Points", value);
			}
		}

		public bool ReverseWinding
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ReverseWinding"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ReverseWinding", value);
			}
		}

		public float2 Size
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public float2 UVOffset
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVOffset"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVOffset", value);
			}
		}

		public Func<int2, float3> PointDisplacement
		{
			get
			{
				return (Func<int2, float3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "PointDisplacement"), typeof(Func<int2, float3>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "PointDisplacement", value);
			}
		}

		public Func<int2, float2> UVDisplacement
		{
			get
			{
				return (Func<int2, float2>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVDisplacement"), typeof(Func<int2, float2>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVDisplacement", value);
			}
		}

		public Func<int2, color> PointColor
		{
			get
			{
				return (Func<int2, color>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "PointColor"), typeof(Func<int2, color>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "PointColor", value);
			}
		}

		public Grid(TriangleSubmesh submesh, int2 points, bool flatShading, bool reverseWinding = false)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			Points = points;
			FlatShading = flatShading;
			ReverseWinding = reverseWinding;
			int2 @int = points - 1;
			int num = @int.x * @int.y;
			int count = ((!flatShading) ? (points.x * points.y) : (num * 6));
			base.Mesh.AddVertices(count, base.AllVertices);
			if (flatShading)
			{
				for (int i = 0; i < num; i++)
				{
					int num2 = i * 6;
					base.AllTriangles.Add(submesh.AddTriangle(num2, num2 + 1, num2 + 2, ReverseWinding));
					base.AllTriangles.Add(submesh.AddTriangle(num2 + 3, num2 + 4, num2 + 5, ReverseWinding));
				}
				return;
			}
			for (int j = 0; j < @int.y; j++)
			{
				for (int k = 0; k < @int.x; k++)
				{
					int num3 = k + j * points.x;
					MeshX_Extensions.QuadTriangles quadTriangles = submesh.AddQuadAsTriangles(num3, num3 + 1, num3 + 1 + points.x, num3 + points.x, ReverseWinding);
					base.AllTriangles.Add(quadTriangles.first);
					base.AllTriangles.Add(quadTriangles.second);
				}
			}
		}

		private static bool IsValidQuadCoord(in int2 coord, in int2 quads)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Grid", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidQuadCoord", coord, quads), typeof(bool));
		}

		private static int QuadOffset(in int2 coord, in int2 quads)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Grid", ResoniteBridge.ResoniteBridgeValueType.Type), "QuadOffset", coord, quads), typeof(int));
		}

		public void GetTrianglesForPoint(in int2 point, out Triangle trig0, out Triangle trig1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTrianglesForPoint", point, trig0, trig1);
		}

		public void GetVerticesForPoint(in int2 point, in int2 quads, RawList<Vertex> vertices)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVerticesForPoint", point, quads, vertices);
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Grid(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.IcoSphere", "Elements.Core")]
	public class IcoSphere : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public float Radius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Radius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Radius", value);
			}
		}

		public float FlatFaceExtrude
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FlatFaceExtrude"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FlatFaceExtrude", value);
			}
		}

		public float FlatFaceScale
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FlatFaceScale"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FlatFaceScale", value);
			}
		}

		public int Subdivisions
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Subdivisions"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Subdivisions", value);
			}
		}

		public bool FlatShading
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FlatShading"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FlatShading", value);
			}
		}

		private float3[] _directions
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_directions"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_directions", value);
			}
		}

		public IcoSphere(TriangleSubmesh submesh, int subdivisions, bool flatShading)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			Subdivisions = subdivisions;
			FlatShading = flatShading;
			base.Mesh.AddVertices(12, base.AllVertices);
			Submesh.AddTriangles(20, base.AllTriangles);
			float num = (1f + MathX.Sqrt(5f)) / 2f;
			base.AllVertices.Positions[0] = new float3(-1f, num).Normalized;
			base.AllVertices.Positions[1] = new float3(1f, num).Normalized;
			base.AllVertices.Positions[2] = new float3(-1f, 0f - num).Normalized;
			base.AllVertices.Positions[3] = new float3(1f, 0f - num).Normalized;
			base.AllVertices.Positions[4] = new float3(0f, -1f, num).Normalized;
			base.AllVertices.Positions[5] = new float3(0f, 1f, num).Normalized;
			base.AllVertices.Positions[6] = new float3(0f, -1f, 0f - num).Normalized;
			base.AllVertices.Positions[7] = new float3(0f, 1f, 0f - num).Normalized;
			base.AllVertices.Positions[8] = new float3(num, 0f, -1f).Normalized;
			base.AllVertices.Positions[9] = new float3(num, 0f, 1f).Normalized;
			base.AllVertices.Positions[10] = new float3(0f - num, 0f, -1f).Normalized;
			base.AllVertices.Positions[11] = new float3(0f - num, 0f, 1f).Normalized;
			base.AllTriangles[0].Set(0, 11, 5);
			base.AllTriangles[1].Set(0, 5, 1);
			base.AllTriangles[2].Set(0, 1, 7);
			base.AllTriangles[3].Set(0, 7, 10);
			base.AllTriangles[4].Set(0, 10, 11);
			base.AllTriangles[5].Set(1, 5, 9);
			base.AllTriangles[6].Set(5, 11, 4);
			base.AllTriangles[7].Set(11, 10, 2);
			base.AllTriangles[8].Set(10, 7, 6);
			base.AllTriangles[9].Set(7, 1, 8);
			base.AllTriangles[10].Set(3, 9, 4);
			base.AllTriangles[11].Set(3, 4, 2);
			base.AllTriangles[12].Set(3, 2, 6);
			base.AllTriangles[13].Set(3, 6, 8);
			base.AllTriangles[14].Set(3, 8, 9);
			base.AllTriangles[15].Set(4, 9, 5);
			base.AllTriangles[16].Set(2, 4, 11);
			base.AllTriangles[17].Set(6, 2, 10);
			base.AllTriangles[18].Set(8, 6, 7);
			base.AllTriangles[19].Set(9, 8, 1);
			Dictionary<ulong, int> middlePointCache = null;
			HashSet<int> inUse = null;
			if (FlatShading)
			{
				base.Mesh.GenerateFlatShadingTriangles(base.AllTriangles);
				int index = base.AllVertices[0].Index;
				int count = base.AllVertices.Count;
				base.Mesh.RemoveVertices(index, count);
				base.AllVertices.Clear();
				for (int i = 0; i < base.AllTriangles.Count * 3; i++)
				{
					base.AllVertices.Add(base.Mesh.GetVertex(index = i));
				}
				inUse = new HashSet<int>();
			}
			else
			{
				middlePointCache = new Dictionary<ulong, int>();
			}
			for (int j = 0; j < Subdivisions; j++)
			{
				foreach (Triangle allTriangle in base.AllTriangles)
				{
					int vertex0Index = allTriangle.Vertex0Index;
					int vertex1Index = allTriangle.Vertex1Index;
					int vertex2Index = allTriangle.Vertex2Index;
					int middlePoint = GetMiddlePoint(vertex0Index, vertex1Index, middlePointCache);
					int middlePoint2 = GetMiddlePoint(vertex1Index, vertex2Index, middlePointCache);
					int middlePoint3 = GetMiddlePoint(vertex2Index, vertex0Index, middlePointCache);
					if (FlatShading)
					{
						int index2 = base.Mesh.DuplicateVertex(middlePoint).Index;
						int index3 = base.Mesh.DuplicateVertex(middlePoint).Index;
						int index4 = base.Mesh.DuplicateVertex(middlePoint2).Index;
						int index5 = base.Mesh.DuplicateVertex(middlePoint2).Index;
						int index6 = base.Mesh.DuplicateVertex(middlePoint3).Index;
						int index7 = base.Mesh.DuplicateVertex(middlePoint3).Index;
						vertex0Index = GetUnique(vertex0Index, inUse);
						vertex1Index = GetUnique(vertex1Index, inUse);
						vertex2Index = GetUnique(vertex2Index, inUse);
						base.AllVertices.Add(base.Mesh.GetVertex(index2));
						base.AllVertices.Add(base.Mesh.GetVertex(index3));
						base.AllVertices.Add(base.Mesh.GetVertex(index4));
						base.AllVertices.Add(base.Mesh.GetVertex(index5));
						base.AllVertices.Add(base.Mesh.GetVertex(index6));
						base.AllVertices.Add(base.Mesh.GetVertex(index7));
						Submesh.AddTriangle(vertex0Index, middlePoint, middlePoint3);
						Submesh.AddTriangle(vertex1Index, middlePoint2, index2);
						Submesh.AddTriangle(vertex2Index, index6, index4);
						Submesh.AddTriangle(index3, index5, index7);
					}
					else
					{
						Submesh.AddTriangle(vertex0Index, middlePoint, middlePoint3);
						Submesh.AddTriangle(vertex1Index, middlePoint2, middlePoint);
						Submesh.AddTriangle(vertex2Index, middlePoint3, middlePoint2);
						Submesh.AddTriangle(middlePoint, middlePoint2, middlePoint3);
					}
				}
				int index8 = base.AllTriangles[0].Index;
				int count2 = base.AllTriangles.Count;
				Submesh.Remove(index8, count2);
				base.AllTriangles.Clear();
				for (int k = 0; k < count2 * 4; k++)
				{
					base.AllTriangles.Add(Submesh.GetTriangle(index8 + k));
				}
			}
			if (FlatShading)
			{
				base.Mesh.RecalculateNormals(base.AllTriangles);
				_directions = new float3[base.AllVertices.Count];
				for (int l = 0; l < base.AllVertices.Count; l++)
				{
					_directions[l] = base.AllVertices.Positions[l].Normalized;
				}
			}
			else
			{
				for (int m = 0; m < base.AllVertices.Count; m++)
				{
					Vertex vertex = base.AllVertices[m];
					vertex.Normal = vertex.Position.Normalized;
				}
			}
			base.Mesh.RecalculateTangents(base.AllTriangles);
		}

		private int GetMiddlePoint(int p0, int p1, Dictionary<ulong, int> middlePointCache)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMiddlePoint", p0, p1, middlePointCache), typeof(int));
		}

		private int GetUnique(int index, HashSet<int> inUse)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUnique", index, inUse), typeof(int));
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public IcoSphere(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.LabelPointer", "Elements.Core")]
	public class LabelPointer : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public float3 LabelPoint
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LabelPoint"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LabelPoint", value);
			}
		}

		public float3 TargetPoint
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TargetPoint"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TargetPoint", value);
			}
		}

		public floatQ LabelRotation
		{
			get
			{
				return (floatQ)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LabelRotation"), typeof(floatQ));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LabelRotation", value);
			}
		}

		public float LabelWidth
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LabelWidth"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LabelWidth", value);
			}
		}

		public float Width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Width", value);
			}
		}

		public float ExpandLerp
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ExpandLerp"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ExpandLerp", value);
			}
		}

		public bool DualSided
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "DualSided"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "DualSided", value);
			}
		}

		public LabelPointer(TriangleSubmesh submesh, bool dualSided)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			DualSided = dualSided;
			base.Mesh.AddVertices(DualSided ? 16 : 8, base.AllVertices);
			for (int i = 0; i < (DualSided ? 4 : 2); i++)
			{
				int num = i * 4;
				MeshX_Extensions.QuadTriangles quadTriangles = Submesh.AddQuadAsTriangles(base.AllVertices[num], base.AllVertices[num + 1], base.AllVertices[num + 2], base.AllVertices[num + 3], i >= 2);
				base.AllTriangles.Add(quadTriangles.first);
				base.AllTriangles.Add(quadTriangles.second);
			}
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public LabelPointer(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Line2D", "Elements.Core")]
	public class Line2D : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float Width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Width", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public colorX Color
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Color"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Color", value);
			}
		}

		public int VertexStartIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "VertexStartIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "VertexStartIndex", value);
			}
		}

		public int TriangleStartIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TriangleStartIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TriangleStartIndex", value);
			}
		}

		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Submesh", value);
			}
		}

		public float2[] Points
		{
			get
			{
				return (float2[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Points"), typeof(float2[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Points", value);
			}
		}

		public int PointCount => Points.Length;

		public Line2D(TriangleSubmesh submesh, int points)
			: base(submesh.Mesh)
		{
			GenerateGeometry(submesh, points);
		}

		public void GenerateGeometry(TriangleSubmesh submesh, int points)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateGeometry", submesh, points);
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		public override void RemoveGeometry()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveGeometry");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Line2D(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class MeshXShape : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float3 Position;

		public floatQ Rotation = floatQ.Identity;

		public float3 Scale = float3.One;

		public MeshX Mesh { get; private set; }

		public VertexCollection AllVertices { get; protected set; }

		public TriangleCollection AllTriangles { get; protected set; }

		public PointCollection AllPoints { get; protected set; }

		public MeshXShape(MeshX mesh)
		{
			UpdateMesh(mesh);
			AllVertices = new VertexCollection();
			AllTriangles = new TriangleCollection();
			AllPoints = new PointCollection();
		}

		protected void UpdateMesh(MeshX mesh)
		{
			Mesh = mesh;
		}

		public abstract void Update();

		public virtual void Remove()
		{
			RemoveGeometry();
			Mesh = null;
		}

		public virtual void RemoveGeometry()
		{
			Mesh.RemoveTriangles(AllTriangles);
			Mesh.RemovePoints(AllPoints);
			Mesh.RemoveVertices(AllVertices);
			AllTriangles.Clear();
			AllPoints.Clear();
			AllVertices.Clear();
		}

		protected void TransformVertices(bool normalsAndTangents)
		{
			ref float3 position = ref Position;
			float3 b = float3.Zero;
			if (position == b)
			{
				ref floatQ rotation = ref Rotation;
				floatQ b2 = floatQ.Identity;
				if (rotation == b2)
				{
					ref float3 scale = ref Scale;
					float3 b3 = float3.One;
					if (scale == b3)
					{
						return;
					}
				}
			}
			for (int i = 0; i < AllVertices.Count; i++)
			{
				Vertex vertex = AllVertices[i];
				float3 a = vertex.Position;
				a *= Scale;
				a = Rotation * a;
				a += Position;
				vertex.Position = a;
				if (normalsAndTangents)
				{
					if (Mesh.HasNormals)
					{
						ref floatQ rotation2 = ref Rotation;
						b = vertex.Normal;
						vertex.Normal = rotation2 * b;
					}
					if (Mesh.HasTangents)
					{
						float4 tangent = vertex.Tangent4;
						ref floatQ rotation3 = ref Rotation;
						b = tangent.xyz;
						float3 b3 = rotation3 * b;
						vertex.Tangent4 = new float4(in b3, tangent.w);
					}
				}
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Quad", "Elements.Core")]
	public class Quad : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int TOTAL_VERTICES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TOTAL_VERTICES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TOTAL_VERTICES", value);
			}
		}

		public int TOTAL_TRIANGLES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TOTAL_TRIANGLES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TOTAL_TRIANGLES", value);
			}
		}

		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public float2 Size
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public float2 Pivot
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Pivot"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Pivot", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public float2 UVOffset
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVOffset"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVOffset", value);
			}
		}

		public Vertex FirstVertex
		{
			get
			{
				return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "FirstVertex"), typeof(Vertex));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "FirstVertex", value);
			}
		}

		public Triangle Triangle0
		{
			get
			{
				return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Triangle0"), typeof(Triangle));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Triangle0", value);
			}
		}

		public Triangle Triangle1
		{
			get
			{
				return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Triangle1"), typeof(Triangle));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Triangle1", value);
			}
		}

		public bool UseColors
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UseColors"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UseColors", value);
			}
		}

		public colorX UpperLeftColor
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UpperLeftColor"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UpperLeftColor", value);
			}
		}

		public colorX UpperRightColor
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UpperRightColor"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UpperRightColor", value);
			}
		}

		public colorX LowerLeftColor
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LowerLeftColor"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LowerLeftColor", value);
			}
		}

		public colorX LowerRightColor
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LowerRightColor"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LowerRightColor", value);
			}
		}

		public colorX? Color
		{
			get
			{
				return (colorX?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Color"), typeof(colorX?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Color", value);
			}
		}

		public colorX GetColor(int index)
		{
			return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetColor", index), typeof(colorX));
		}

		public override void Remove()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove");
		}

		public Quad(TriangleSubmesh submesh)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			base.Mesh.IncreaseVertexCount(4);
			FirstVertex = base.Mesh.GetVertex(base.Mesh.VertexCount - 4);
			int indexUnsafe = FirstVertex.IndexUnsafe;
			MeshX_Extensions.QuadTriangles quadTriangles = Submesh.AddQuadAsTriangles(indexUnsafe, indexUnsafe + 1, indexUnsafe + 2, indexUnsafe + 3);
			Triangle0 = quadTriangles.first;
			Triangle1 = quadTriangles.second;
			base.Mesh.HasUV0s = true;
			base.Mesh.HasNormals = true;
			base.Mesh.HasTangents = true;
		}

		public Quad(Vertex firstVertex)
			: base(firstVertex.Mesh)
		{
			FirstVertex = firstVertex;
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		public void UpdateUnsafe(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateUnsafe", index);
		}

		public static void SetQuad(MeshX meshx, int startVertex, in float3 position, in floatQ rotation, in float2 pivot, in float2 halfSize, in float2 uvScale, in float2 uvOffset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Quad", ResoniteBridge.ResoniteBridgeValueType.Type), "SetQuad", meshx, startVertex, position, rotation, pivot, halfSize, uvScale, uvOffset);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Quad(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Ring", "Elements.Core")]
	public class Ring : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Segments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Segments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Segments", value);
			}
		}

		public float InnerRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "InnerRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "InnerRadius", value);
			}
		}

		public float OuterRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "OuterRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "OuterRadius", value);
			}
		}

		public float Arc
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Arc"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Arc", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		public float Radius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Radius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Radius", value);
			}
		}

		public float Width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		public Vertex InnerRingVertex(int segment)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InnerRingVertex", segment), typeof(Vertex));
		}

		public Vertex OuterRingVertex(int segment)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OuterRingVertex", segment), typeof(Vertex));
		}

		public Ring(MeshX meshx, int segments)
			: base(meshx)
		{
			Segments = segments;
			meshx.AddVertices((segments + 1) * 2, base.AllVertices);
			for (int i = 0; i < Segments; i++)
			{
				Vertex v = InnerRingVertex(i);
				Vertex v2 = OuterRingVertex(i);
				Vertex v3 = OuterRingVertex(i + 1);
				Vertex v4 = InnerRingVertex(i + 1);
				MeshX_Extensions.QuadTriangles quadTriangles = base.Mesh.AddQuadAsTriangles(v, v2, v3, v4);
				base.AllTriangles.Add(quadTriangles.first);
				base.AllTriangles.Add(quadTriangles.second);
			}
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Ring(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Screw", "Elements.Core")]
	public class Screw : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public int Segments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Segments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Segments", value);
			}
		}

		public bool WrapAroundCurve
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WrapAroundCurve"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WrapAroundCurve", value);
			}
		}

		public bool WrapAroundSegments
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "WrapAroundSegments"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "WrapAroundSegments", value);
			}
		}

		public float Angle
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Angle"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Angle", value);
			}
		}

		public float3 Axis
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Axis"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Axis", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		private float3[] curvePoints
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "curvePoints"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "curvePoints", value);
			}
		}

		public int CurvePoints => curvePoints.Length;

		public float3 this[int pointIndex]
		{
			get
			{
				return curvePoints[pointIndex];
			}
			set
			{
				curvePoints[pointIndex] = value;
			}
		}

		public Screw(TriangleSubmesh submesh, int segments, int curvePoints)
			: base(submesh.Mesh)
		{
			submesh.Mesh.HasNormals = true;
			submesh.Mesh.HasUV0s = true;
			Submesh = submesh;
			Segments = segments;
			this.curvePoints = new float3[curvePoints];
			base.Mesh.AddVertices(curvePoints * (Segments + 1), base.AllVertices);
			for (int i = 0; i < segments; i++)
			{
				for (int j = 0; j < curvePoints - 1; j++)
				{
					Vertex vertex = GetVertex(i, j);
					Vertex vertex2 = GetVertex(i + 1, j);
					Vertex vertex3 = GetVertex(i + 1, j + 1);
					Vertex vertex4 = GetVertex(i, j + 1);
					MeshX_Extensions.QuadTriangles quadTriangles = Submesh.AddQuadAsTriangles(vertex, vertex2, vertex3, vertex4);
					base.AllTriangles.Add(quadTriangles.first);
					base.AllTriangles.Add(quadTriangles.second);
				}
			}
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		public Vertex GetVertex(int segment, int point)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVertex", segment, point), typeof(Vertex));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Screw(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class ProfileSegmentedBuilderBase : SegmentedBuilder<ProfileSegment>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private bool _dualSided;

		private Shading _shading;

		private Ends _ends;

		private Topology _topology;

		public override bool DualSided => _dualSided;

		public override Shading ShadingType => _shading;

		public override Ends EndsType => _ends;

		public override Topology TopologyType => _topology;

		public abstract float Circumference { get; }

		public abstract float3 GetPoint(int index);

		public ProfileSegmentedBuilderBase(TriangleSubmesh submesh, Topology topology, Shading shading = Shading.Smooth, Ends ends = Ends.Open, bool dualSided = false)
			: base(submesh)
		{
			_shading = shading;
			_ends = ends;
			_dualSided = dualSided;
			_topology = topology;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.ProfileSegmentedBuilder", "Elements.Core")]
	public class ProfileSegmentedBuilder : ProfileSegmentedBuilderBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private float3[] _points
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_points"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_points", value);
			}
		}

		private float _circumference
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_circumference"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_circumference", value);
			}
		}

		private float _pointStep
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_pointStep"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_pointStep", value);
			}
		}

		public override int Points => _points.Length;

		public override float PointStep => _pointStep;

		public override float Circumference
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Circumference"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Circumference", value);
			}
		}

		public override float3 GetPoint(int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPoint", index), typeof(float3));
		}

		public void SetPoint(int index, in float3 point)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPoint", index, point);
		}

		public ProfileSegmentedBuilder(TriangleSubmesh submesh, int points, Topology topology, Shading shading = Shading.Smooth, Ends ends = Ends.Open, bool dualSided = false)
			: base(submesh, topology, shading, ends, dualSided)
		{
			_points = new float3[points];
			_pointStep = 1f / (float)(_points.Length - 1);
			Initialize();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ProfileSegmentedBuilder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ProfileSegment : Segment, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private float _scale
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_scale"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_scale", value);
			}
		}

		public float Scale
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Scale"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Scale", value);
			}
		}

		protected override float SimpleCircumference => ((ProfileSegmentedBuilderBase)base.Builder).Circumference * _scale;

		protected override float3 ComputeLocalPoint(int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeLocalPoint", index), typeof(float3));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ProfileSegment(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class Segment : IComparable<Segment>, IComparable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private bool _dirty;

		private float3 _position = float3.Zero;

		private floatQ _rotation = floatQ.Identity;

		private float _vCoord;

		private color _color = color.White;

		private ColorProfile _profile = ColorProfile.sRGB;

		internal float3 _dir;

		private SegmentedBuilder builder;

		internal VertexCollection ConnectToVertices;

		internal VertexCollection ConnectAtVertices;

		internal TriangleCollection Triangles;

		private float[] vertexCircumferences;

		public bool IsDirty => _dirty;

		public int Index { get; internal set; }

		public Segment PreviousSegment
		{
			get
			{
				if (Index != 0)
				{
					return builder.GetSegment(Index - 1);
				}
				return null;
			}
		}

		public Segment NextSegment
		{
			get
			{
				if (Index != builder.SegmentCount - 1)
				{
					return builder.GetSegment(Index + 1);
				}
				return null;
			}
		}

		public float3 Position
		{
			get
			{
				return _position;
			}
			set
			{
				_position = value;
				MarkDirty();
			}
		}

		public floatQ Rotation
		{
			get
			{
				return _rotation;
			}
			set
			{
				_rotation = value;
				MarkDirty();
			}
		}

		public float VCoordinate
		{
			get
			{
				return _vCoord;
			}
			set
			{
				_vCoord = value;
				MarkDirty();
			}
		}

		public color Color
		{
			get
			{
				return _color;
			}
			set
			{
				_color = value;
				MarkDirty();
			}
		}

		public ColorProfile Profile
		{
			get
			{
				return _profile;
			}
			set
			{
				_profile = value;
				MarkDirty();
			}
		}

		protected TriangleSubmesh Submesh => builder.Submesh;

		protected bool IsCircle => builder.TopologyType == SegmentedBuilder.Topology.Circle;

		protected MeshX Mesh => builder.Mesh;

		protected int Points => builder.Points;

		protected float PointStep => builder.PointStep;

		protected int Sides => builder.Sides;

		protected bool DualSided => builder.DualSided;

		protected bool FlatSides => builder.FlatSides;

		protected bool FlatSegments => builder.FlatSegments;

		protected int SegmentVerts => (FlatSides ? (Sides * 2) : (Sides + 1)) * Faces;

		protected int SegmentTrigs => Sides * 2 * Faces;

		protected int Faces
		{
			get
			{
				if (!DualSided)
				{
					return 1;
				}
				return 2;
			}
		}

		protected SegmentedBuilder Builder => builder;

		public float Circumference
		{
			get
			{
				if (builder.PreciseUV)
				{
					return vertexCircumferences[vertexCircumferences.Length - 1];
				}
				return SimpleCircumference;
			}
		}

		protected abstract float SimpleCircumference { get; }

		public float GetCircumferenceToVertex(int index)
		{
			return vertexCircumferences[index];
		}

		internal virtual void Setup(SegmentedBuilder builder, int index)
		{
			this.builder = builder;
			Index = index;
			MarkDirty();
		}

		internal void ConnectTo(Segment segment)
		{
			ConnectToVertices = ConnectToVertices ?? GenerateVertices();
			Triangles = Triangles ?? GenerateTriangles();
			VertexCollection connectAtVertices = segment.GetConnectAtVertices(this);
			VertexCollection connectToVertices = ConnectToVertices;
			_ = Triangles;
			for (int i = 0; i < Faces; i++)
			{
				for (int j = 0; j < Sides; j++)
				{
					int num = (FlatSides ? (j * 2) : j);
					int num2 = j * 2;
					if (i == 1)
					{
						num += SegmentVerts / 2;
						num2 += SegmentTrigs / 2;
					}
					Mesh.SetQuadAsTriangles(connectToVertices[num], connectAtVertices[num], connectAtVertices[num + 1], connectToVertices[num + 1], Triangles[num2], Triangles[num2 + 1], i == 1);
				}
			}
		}

		public float3 ComputePoint(int index)
		{
			floatQ q = Rotation;
			float3 v = ComputeLocalPoint(index);
			float3 a = q * v;
			float3 b = Position;
			return a + b;
		}

		protected abstract float3 ComputeLocalPoint(int index);

		internal void UpdateVertexGeometry(bool updateVertexCircumferences)
		{
			if (ConnectAtVertices == null && ConnectToVertices == null)
			{
				return;
			}
			if (updateVertexCircumferences)
			{
				vertexCircumferences = vertexCircumferences.EnsureExactSize(Sides + 1);
			}
			float3 b = default(float3);
			for (int i = 0; i < Points; i++)
			{
				float3 a = ComputePoint(i);
				if (updateVertexCircumferences)
				{
					if (i == 0)
					{
						vertexCircumferences[i] = 0f;
					}
					else
					{
						vertexCircumferences[i] = vertexCircumferences[i - 1] + MathX.Distance(in a, in b);
					}
					b = a;
				}
				bool flag = i == 0 && IsCircle;
				for (int j = 0; j < Faces; j++)
				{
					for (int k = 0; k < ((!(FlatSides || flag)) ? 1 : 2); k++)
					{
						int num;
						if (!IsCircle && FlatSides)
						{
							num = i * 2 - 1 + k;
							if (num < 0 || (i == Points - 1 && k == 1))
							{
								continue;
							}
						}
						else if (FlatSides || flag)
						{
							num = i * 2 + k - 1;
							if (num < 0)
							{
								num += SegmentVerts / Faces;
							}
						}
						else
						{
							num = i;
						}
						if (j == 1)
						{
							num += SegmentVerts / 2;
						}
						if (ConnectAtVertices != null)
						{
							ConnectAtVertices.Positions[num] = a;
						}
						if (ConnectToVertices != null)
						{
							ConnectToVertices.Positions[num] = a;
						}
					}
				}
			}
			if (updateVertexCircumferences && builder.TopologyType == SegmentedBuilder.Topology.Circle)
			{
				vertexCircumferences[vertexCircumferences.Length - 1] = vertexCircumferences[1] + vertexCircumferences[vertexCircumferences.Length - 2];
			}
		}

		internal void UpdateVertexColors()
		{
			if (ConnectAtVertices == null && ConnectToVertices == null)
			{
				return;
			}
			Mesh.Profile = _profile;
			for (int i = 0; i < SegmentVerts; i++)
			{
				if (ConnectAtVertices != null)
				{
					ConnectAtVertices.Colors[i] = _color;
				}
				if (ConnectToVertices != null)
				{
					ConnectToVertices.Colors[i] = _color;
				}
			}
		}

		internal void UpdateVertexUVs()
		{
			if (ConnectAtVertices == null && ConnectToVertices == null)
			{
				return;
			}
			bool flag = true;
			bool flag2 = false;
			float num = 0f;
			float num2 = (builder.PreciseUV ? (1f / Circumference) : (1f / (float)Sides));
			int num3 = 0;
			int num4 = SegmentVerts >> 1;
			for (int i = 0; i < SegmentVerts; i++)
			{
				if (DualSided && i == num4)
				{
					num = 0f;
					num3 = 0;
					flag = true;
					flag2 = true;
				}
				float2 a = new float2(flag2 ? (1f - num) : num, _vCoord);
				if (builder.SwapUV)
				{
					a = a.yx;
				}
				a *= builder.UVScale;
				a += builder.UVOffset;
				if (ConnectAtVertices != null)
				{
					ConnectAtVertices.UV0s[i] = a;
				}
				if (ConnectToVertices != null)
				{
					ConnectToVertices.UV0s[i] = a;
				}
				if (flag || !FlatSides)
				{
					if (num3 < Sides)
					{
						num3++;
					}
					num = ((!builder.PreciseUV) ? (num + num2) : (GetCircumferenceToVertex(num3) * num2));
					flag = false;
				}
				else
				{
					flag = true;
				}
			}
		}

		internal void FlagVertices()
		{
			for (int i = 0; i < SegmentVerts; i++)
			{
				if (ConnectAtVertices != null)
				{
					ConnectAtVertices.Flags[i] = true;
				}
				if (ConnectToVertices != null)
				{
					ConnectToVertices.Flags[i] = true;
				}
			}
		}

		internal void SmoothCircleNormals()
		{
			if (ConnectAtVertices != null)
			{
				SmoothCircleNormals(ConnectAtVertices);
			}
			if (ConnectToVertices != null)
			{
				SmoothCircleNormals(ConnectToVertices);
			}
		}

		private void SmoothCircleNormals(VertexCollection collection)
		{
			Vertex vertex = collection[0];
			Vertex vertex2 = collection[collection.Count - 1];
			float3 normalized = (vertex.NormalUnsafe + vertex2.NormalUnsafe).Normalized;
			vertex.NormalUnsafe = normalized;
			vertex2.NormalUnsafe = normalized;
		}

		private VertexCollection GetConnectAtVertices(Segment connectingSegment)
		{
			if (FlatSegments)
			{
				ConnectAtVertices = ConnectAtVertices ?? GenerateVertices();
				return ConnectAtVertices;
			}
			ConnectToVertices = ConnectToVertices ?? GenerateVertices();
			return ConnectToVertices;
		}

		private TriangleCollection GenerateTriangles()
		{
			TriangleCollection triangleCollection = new TriangleCollection();
			Submesh.AddTriangles(SegmentTrigs, triangleCollection);
			builder.AllTriangles.AddRange(triangleCollection);
			return triangleCollection;
		}

		private VertexCollection GenerateVertices()
		{
			MarkDirty();
			VertexCollection vertexCollection = new VertexCollection();
			Mesh.AddVertices(SegmentVerts, vertexCollection);
			builder.AllVertices.AddRange(vertexCollection);
			return vertexCollection;
		}

		internal void ClearDirty()
		{
			_dirty = false;
		}

		internal void MarkDirty()
		{
			if (!_dirty)
			{
				builder.RegisterDirtySegment(this);
				_dirty = true;
			}
		}

		public int CompareTo(Segment other)
		{
			return Index.CompareTo(other.Index);
		}

		public int CompareTo(object obj)
		{
			return CompareTo((Segment)obj);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class SegmentedBuilder : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[DataModelType]
		[OldTypeName("Elements.Core.SegmentedBuilder+Shading", "Elements.Core")]
		public enum Shading
		{
			Smooth,
			FlatSides,
			FlatSegments,
			Flat
		}

		[DataModelType]
		[OldTypeName("Elements.Core.SegmentedBuilder+Topology", "Elements.Core")]
		public enum Topology
		{
			Circle,
			Line
		}

		[DataModelType]
		[OldTypeName("Elements.Core.SegmentedBuilder+Ends", "Elements.Core")]
		public enum Ends
		{
			Open,
			Capped,
			SmoothNormals,
			Connected
		}

		public readonly TriangleSubmesh Submesh;

		public bool PreciseUV;

		public float2 UVScale = new float2(1f, 1f);

		public float2 UVOffset;

		public bool ScaleUVByCircumference = true;

		public float MinimalCircumference = 0.001f;

		public bool ForceUp;

		public float3 Up = float3.Up;

		public floatQ AutoOrientOffset = floatQ.Identity;

		public bool BlendOrientation = true;

		public bool AutoOrientSegments;

		public bool AutoGenerateUV;

		public bool SwapUV;

		public abstract bool DualSided { get; }

		public abstract Shading ShadingType { get; }

		public abstract int Points { get; }

		public abstract float PointStep { get; }

		public abstract Topology TopologyType { get; }

		public abstract Ends EndsType { get; }

		public int Sides
		{
			get
			{
				if (TopologyType != 0)
				{
					return Points - 1;
				}
				return Points;
			}
		}

		public bool FlatSides
		{
			get
			{
				if (ShadingType != Shading.Flat)
				{
					return ShadingType == Shading.FlatSides;
				}
				return true;
			}
		}

		public bool FlatSegments
		{
			get
			{
				if (ShadingType != Shading.Flat)
				{
					return ShadingType == Shading.FlatSegments;
				}
				return true;
			}
		}

		public abstract int SegmentCount { get; }

		public abstract Segment GetSegment(int index);

		internal abstract void RegisterDirtySegment(Segment segment);

		public abstract void MarkAllDirty();

		public SegmentedBuilder(TriangleSubmesh submesh)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class SegmentedBuilder<S> : SegmentedBuilder, ResoniteBridge.ResoniteBridgeValueHolder where S : Segment, new()
	{
		private List<S> segments = new List<S>();

		private bool allDirty;

		private List<S> dirtySegments = new List<S>();

		private int _beginCapVertOffset;

		private int _endCapVertOffset;

		private Segment _lastFirstSegment;

		private Segment _lastLastSegment;

		private bool _lastAutoOrientSegments;

		public override int SegmentCount => segments.Count;

		public S this[int index] => segments[index];

		public override Segment GetSegment(int index)
		{
			return this[index];
		}

		internal override void RegisterDirtySegment(Segment segment)
		{
			if (!allDirty)
			{
				dirtySegments.Add((S)segment);
			}
		}

		public override void MarkAllDirty()
		{
			allDirty = true;
			dirtySegments.Clear();
		}

		public SegmentedBuilder(TriangleSubmesh submesh)
			: base(submesh.Mesh)
		{
		}

		protected void Initialize()
		{
			if (EndsType == Ends.Capped && TopologyType == Topology.Circle)
			{
				_beginCapVertOffset = base.AllVertices.Count;
				base.Mesh.AddVertices(Points, base.AllVertices);
				_endCapVertOffset = base.AllVertices.Count;
				base.Mesh.AddVertices(Points, base.AllVertices);
				Submesh.AddTriangleFan(base.AllVertices, _beginCapVertOffset, Points, reverseOrder: false, base.AllTriangles);
				Submesh.AddTriangleFan(base.AllVertices, _endCapVertOffset, Points, reverseOrder: true, base.AllTriangles);
			}
		}

		public void EnsureSegmentCount(int count)
		{
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			while (SegmentCount > count)
			{
				RemoveLastSegment();
			}
			while (SegmentCount < count)
			{
				AddSegment();
			}
		}

		public S AddSegment(float3? pos = null)
		{
			S val = null;
			if (segments.Count > 0)
			{
				val = segments[segments.Count - 1];
			}
			S val2 = new S();
			val2.Setup(this, segments.Count);
			segments.Add(val2);
			val2.Position = pos ?? val?.Position ?? float3.Zero;
			val?.ConnectTo(val2);
			return val2;
		}

		public void RemoveLastSegment()
		{
			S val = segments.TakeLast();
			VertexCollection vertexCollection = new VertexCollection();
			if (val.ConnectAtVertices != null)
			{
				vertexCollection.AddRange(val.ConnectAtVertices);
			}
			if (val.ConnectToVertices != null && val.ConnectToVertices != val.ConnectAtVertices)
			{
				vertexCollection.AddRange(val.ConnectToVertices);
			}
			base.AllVertices.RemoveRange(base.AllVertices.Count - vertexCollection.Count, vertexCollection.Count);
			base.Mesh.RemoveVertices(vertexCollection);
			if (segments.Count > 0)
			{
				S val2 = segments[segments.Count - 1];
				base.AllTriangles.RemoveRange(base.AllTriangles.Count - val2.Triangles.Count, val2.Triangles.Count);
				Submesh.Remove(val2.Triangles);
				val2.Triangles = null;
			}
		}

		public override void Update()
		{
			Update(out var _);
		}

		public void Update(out bool geometryUpdated)
		{
			geometryUpdated = false;
			if (dirtySegments.Count == 0 && !allDirty)
			{
				return;
			}
			base.Mesh.HasNormals = true;
			base.Mesh.HasUV0s = true;
			base.Mesh.HasTangents = true;
			if (AutoOrientSegments && !_lastAutoOrientSegments)
			{
				MarkAllDirty();
			}
			_lastAutoOrientSegments = AutoOrientSegments;
			if (EndsType == Ends.Connected && SegmentCount > 1 && (_lastFirstSegment != segments[0] || _lastLastSegment != segments.GetLast()))
			{
				_lastFirstSegment = segments[0];
				_lastLastSegment = segments.GetLast();
				_lastLastSegment.ConnectTo(_lastFirstSegment);
				geometryUpdated = true;
			}
			List<S> list = (allDirty ? segments : dirtySegments);
			int count;
			if (AutoOrientSegments)
			{
				count = dirtySegments.Count;
				for (int i = 0; i < count; i++)
				{
					S val = dirtySegments[i];
					val.PreviousSegment?.MarkDirty();
					val.NextSegment?.MarkDirty();
				}
				dirtySegments.Sort();
				foreach (S item in list)
				{
					float3 b = item.PreviousSegment?.Position ?? item.Position;
					float3 a = item.NextSegment?.Position ?? item.Position;
					float3 a2 = item.Position;
					float3 a3 = a2 - b;
					a2 = item.Position;
					float3 a4 = a - a2;
					a2 = item.Position;
					if (a2 == b)
					{
						a3 = a4;
					}
					a2 = item.Position;
					if (a2 == a)
					{
						a4 = a3;
					}
					a2 = float3.Zero;
					if (a3 == a2)
					{
						a3 = a4;
					}
					else
					{
						a2 = float3.Zero;
						if (a4 == a2)
						{
							a4 = a3;
						}
					}
					a2 = float3.Zero;
					if (a4 != a2)
					{
						float3 @float;
						if (!ForceUp)
						{
							floatQ q = item.PreviousSegment?.Rotation ?? AutoOrientOffset;
							@float = q * Up;
						}
						else
						{
							@float = Up;
						}
						float3 up = @float;
						float3 forward = a3;
						if (BlendOrientation)
						{
							a2 = forward.Normalized;
							float3 b2 = a4.Normalized;
							float3 v = a2 + b2;
							forward = v * 0.5f;
						}
						item._dir = forward;
						floatQ b3 = floatQ.LookRotation(in forward, in up);
						item.Rotation = AutoOrientOffset * b3;
					}
					else if (item.PreviousSegment != null)
					{
						item.Rotation = item.PreviousSegment.Rotation;
					}
					else
					{
						item.Rotation = AutoOrientOffset;
					}
				}
			}
			count = list.Count;
			for (int j = 0; j < count; j++)
			{
				S val2 = list[j];
				val2.UpdateVertexGeometry(PreciseUV);
				if (!allDirty)
				{
					val2.PreviousSegment?.MarkDirty();
					val2.NextSegment?.MarkDirty();
				}
			}
			if (AutoGenerateUV)
			{
				int num = ((!allDirty) ? dirtySegments.Min((S s) => s.Index) : 0);
				float num2 = 0f;
				if (num > 0)
				{
					num2 = segments[num - 1].VCoordinate;
				}
				for (int k = num; k < segments.Count; k++)
				{
					if (k == 0)
					{
						segments[k].VCoordinate = 0f;
						continue;
					}
					float3 a2 = segments[k - 1].Position;
					float3 b2 = segments[k].Position;
					float num3 = MathX.Distance(in a2, in b2);
					if (ScaleUVByCircumference)
					{
						num3 /= MathX.Max(MinimalCircumference, segments[k].Circumference);
					}
					num2 += num3;
					segments[k].VCoordinate = num2;
				}
			}
			bool hasColors = base.Mesh.HasColors;
			for (int l = 0; l < count; l++)
			{
				list[l].UpdateVertexUVs();
				if (hasColors)
				{
					list[l].UpdateVertexColors();
				}
			}
			if (EndsType == Ends.Capped && TopologyType == Topology.Circle)
			{
				if (segments.GetFirst().IsDirty || allDirty)
				{
					UpdateCapVerts(_beginCapVertOffset, segments.GetFirst(), flip: true);
				}
				if (segments.GetLast().IsDirty || allDirty)
				{
					UpdateCapVerts(_endCapVertOffset, segments.GetLast(), flip: false);
				}
			}
			TriangleCollection resource = Elements.Core.Pool<TriangleCollection>.Borrow();
			foreach (S item2 in list)
			{
				if (item2.Triangles != null)
				{
					resource.AddRange(item2.Triangles);
				}
			}
			base.Mesh.RecalculateNormals(resource);
			base.Mesh.RecalculateTangents(resource);
			Elements.Core.Pool<TriangleCollection>.Return(ref resource);
			if (TopologyType == Topology.Circle && (ShadingType == Shading.Smooth || ShadingType == Shading.FlatSegments))
			{
				foreach (S item3 in list)
				{
					item3.SmoothCircleNormals();
				}
			}
			if (EndsType == Ends.SmoothNormals && SegmentCount > 1)
			{
				S val3 = segments[0];
				S last = segments.GetLast();
				VertexCollection vertexCollection = last.ConnectToVertices ?? last.ConnectAtVertices;
				if (val3.ConnectToVertices != null && vertexCollection != null)
				{
					for (int m = 0; m < val3.ConnectToVertices.Count; m++)
					{
						Vertex vertex = val3.ConnectToVertices[m];
						Vertex vertex2 = vertexCollection[m];
						float3 normalized = (vertex.NormalUnsafe + vertex2.NormalUnsafe).Normalized;
						vertex.NormalUnsafe = normalized;
						vertex2.NormalUnsafe = normalized;
					}
				}
			}
			foreach (S item4 in list)
			{
				item4.ClearDirty();
			}
			dirtySegments.Clear();
			allDirty = false;
		}

		private void UpdateCapVerts(int offset, Segment segment, bool flip)
		{
			for (int i = 0; i < Points; i++)
			{
				float3 @float = segment.ComputePoint(i);
				Vertex vertex = base.AllVertices[offset + i];
				vertex.PositionUnsafe = @float;
				ref float3 normalUnsafe = ref vertex.NormalUnsafe;
				floatQ q = segment.Rotation;
				float3 v = (flip ? float3.Backward : float3.Forward);
				normalUnsafe = q * v;
				vertex.UV0Unsafe = float2.Zero;
				ref float4 tangent4Unsafe = ref vertex.Tangent4Unsafe;
				q = segment.Rotation;
				v = (flip ? float3.Left : float3.Right);
				float3 v2 = q * v;
				tangent4Unsafe = v2;
				base.Mesh.Profile = segment.Profile;
				if (base.Mesh.HasColors)
				{
					vertex.ColorUnsafe = segment.Color;
				}
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.StripBuilder", "Elements.Core")]
	public class StripBuilder : SegmentedBuilder<StripSegment>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private bool _dualSided
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_dualSided"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_dualSided", value);
			}
		}

		private Shading _shading
		{
			get
			{
				return (Shading)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_shading"), typeof(Shading));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_shading", value);
			}
		}

		private int _points
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_points"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_points", value);
			}
		}

		private Ends _ends
		{
			get
			{
				return (Ends)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_ends"), typeof(Ends));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_ends", value);
			}
		}

		private float _pointStep
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_pointStep"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_pointStep", value);
			}
		}

		private float3 _baseOffset
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_baseOffset"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_baseOffset", value);
			}
		}

		internal float3[] _offsets
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_offsets"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_offsets", value);
			}
		}

		public override bool DualSided => _dualSided;

		public override Shading ShadingType => _shading;

		public override Ends EndsType => _ends;

		public override int Points => _points;

		public override float PointStep => _pointStep;

		public override Topology TopologyType => Topology.Line;

		public float3 BaseOffset => _baseOffset;

		public StripBuilder(TriangleSubmesh submesh, int points, Ends ends = Ends.Open, Shading shading = Shading.Smooth, bool dualSided = false, float3? baseOffset = null)
			: base(submesh)
		{
			_points = points;
			_ends = ends;
			_shading = shading;
			_dualSided = dualSided;
			_pointStep = 1f / (float)(points - 1);
			_baseOffset = baseOffset ?? new float3(1f);
			Initialize();
		}

		public float3[] GetOffsetsArray()
		{
			return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOffsetsArray"), typeof(float3[]));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StripBuilder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StripSegment : Segment, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private StripBuilder _stripBuilder
		{
			get
			{
				return (StripBuilder)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_stripBuilder"), typeof(StripBuilder));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_stripBuilder", value);
			}
		}

		private float _width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_width", value);
			}
		}

		private float _halfWidth
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_halfWidth"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_halfWidth", value);
			}
		}

		public float Width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		protected override float SimpleCircumference => _width;

		internal override void Setup(SegmentedBuilder builder, int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Setup", builder, index);
		}

		protected override float3 ComputeLocalPoint(int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeLocalPoint", index), typeof(float3));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StripSegment(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.TubeBuilder", "Elements.Core")]
	public class TubeBuilder : SegmentedBuilder<TubeSegment>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private bool _dualSided
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_dualSided"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_dualSided", value);
			}
		}

		private Shading _shading
		{
			get
			{
				return (Shading)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_shading"), typeof(Shading));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_shading", value);
			}
		}

		private int _points
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_points"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_points", value);
			}
		}

		private Ends _ends
		{
			get
			{
				return (Ends)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_ends"), typeof(Ends));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_ends", value);
			}
		}

		private float _pointStep
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_pointStep"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_pointStep", value);
			}
		}

		internal float3[] _offsets
		{
			get
			{
				return (float3[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_offsets"), typeof(float3[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_offsets", value);
			}
		}

		public override bool DualSided => _dualSided;

		public override Shading ShadingType => _shading;

		public override Ends EndsType => _ends;

		public override int Points => _points;

		public override float PointStep => _pointStep;

		public override Topology TopologyType => Topology.Circle;

		public TubeBuilder(TriangleSubmesh submesh, int points, Ends ends = Ends.Capped, Shading shading = Shading.Smooth, bool dualSided = false)
			: base(submesh)
		{
			_points = points;
			_ends = ends;
			_shading = shading;
			_dualSided = dualSided;
			_pointStep = 1f / (float)_points;
			Initialize();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TubeBuilder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TubeSegment : Segment, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private TubeBuilder _stripBuilder
		{
			get
			{
				return (TubeBuilder)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_stripBuilder"), typeof(TubeBuilder));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_stripBuilder", value);
			}
		}

		private float _radius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_radius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_radius", value);
			}
		}

		public float Radius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Radius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Radius", value);
			}
		}

		protected override float SimpleCircumference => _radius * (MathF.PI * 2f);

		internal override void Setup(SegmentedBuilder builder, int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Setup", builder, index);
		}

		protected override float3 ComputeLocalPoint(int index)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeLocalPoint", index), typeof(float3));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TubeSegment(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.Torus", "Elements.Core")]
	public class Torus : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int MinorSegments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MinorSegments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MinorSegments", value);
			}
		}

		public int MajorSegments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MajorSegments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MajorSegments", value);
			}
		}

		public float MinorRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MinorRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MinorRadius", value);
			}
		}

		public float MajorRadius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MajorRadius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MajorRadius", value);
			}
		}

		private Screw screw
		{
			get
			{
				return (Screw)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "screw"), typeof(Screw));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "screw", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UVScale", value);
			}
		}

		public Torus(TriangleSubmesh submesh, int minorSegments, int majorSegments)
			: base(submesh.Mesh)
		{
			MinorSegments = minorSegments;
			MajorSegments = majorSegments;
			screw = new Screw(submesh, majorSegments, minorSegments + 1);
			screw.WrapAroundCurve = true;
			screw.WrapAroundSegments = true;
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		public override void Remove()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove");
		}

		public override void RemoveGeometry()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveGeometry");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Torus(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	[OldTypeName("Elements.Core.UVSphereCapsule", "Elements.Core")]
	public class UVSphereCapsule : MeshXShape, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[DataModelType]
		public enum Shading
		{
			Smooth,
			FlatSegments,
			FlatRings,
			Flat
		}

		public TriangleSubmesh Submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Submesh", value);
			}
		}

		public float Radius
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Radius"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Radius", value);
			}
		}

		public float Height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Height", value);
			}
		}

		public Shading ShadingType
		{
			get
			{
				return (Shading)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ShadingType"), typeof(Shading));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ShadingType", value);
			}
		}

		public int Rings
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Rings"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Rings", value);
			}
		}

		public int Segments
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Segments"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Segments", value);
			}
		}

		public bool Capsule
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Capsule"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Capsule", value);
			}
		}

		public float3 TopOffset
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TopOffset"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TopOffset", value);
			}
		}

		public float3 BottomOffset
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BottomOffset"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BottomOffset", value);
			}
		}

		public float3[,] Offsets
		{
			get
			{
				return (float3[,])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Offsets"), typeof(float3[,]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Offsets", value);
			}
		}

		public bool UseColors
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UseColors"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UseColors", value);
			}
		}

		public color TopColor
		{
			get
			{
				return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TopColor"), typeof(color));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TopColor", value);
			}
		}

		public color BottomColor
		{
			get
			{
				return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BottomColor"), typeof(color));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BottomColor", value);
			}
		}

		public color[,] Colors
		{
			get
			{
				return (color[,])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Colors"), typeof(color[,]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Colors", value);
			}
		}

		public int SegmentVerts
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SegmentVerts"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SegmentVerts", value);
			}
		}

		public int RingVerts
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RingVerts"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RingVerts", value);
			}
		}

		public bool DuplicatedMiddleRing
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "DuplicatedMiddleRing"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "DuplicatedMiddleRing", value);
			}
		}

		private float _segmentStep
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_segmentStep"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_segmentStep", value);
			}
		}

		private float _ringStep
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_ringStep"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_ringStep", value);
			}
		}

		public float2 UVScale
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UVScale"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UVScale", value);
			}
		}

		private bool FlatRings
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FlatRings"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FlatRings", value);
			}
		}

		private bool FlatSegments
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FlatSegments"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FlatSegments", value);
			}
		}

		public int LinearOffsetCount => Segments * (Rings - 2) + 2;

		public UVSphereCapsule(TriangleSubmesh submesh, int rings, int segments, Shading shadingType = Shading.Smooth, bool capsule = false)
			: base(submesh.Mesh)
		{
			Submesh = submesh;
			Rings = rings;
			Segments = segments;
			ShadingType = shadingType;
			Capsule = capsule;
			_segmentStep = 1f / (float)segments;
			_ringStep = 1f / (float)(rings - 1);
			int num = Rings;
			if (capsule && (rings & 1) == 1)
			{
				num++;
				DuplicatedMiddleRing = true;
			}
			SegmentVerts = (FlatSegments ? (Segments * 2) : (Segments + 1));
			RingVerts = (FlatRings ? (num * 2) : num);
			int vertexCount = base.Mesh.VertexCount;
			base.Mesh.AddVertices(SegmentVerts * RingVerts, base.AllVertices);
			for (int i = 0; i < Segments; i++)
			{
				int num2 = (FlatSegments ? (i * 2) : i);
				int num3 = RingVerts * num2;
				int num4 = RingVerts * (num2 + 1);
				num3 += vertexCount;
				num4 += vertexCount;
				for (int j = 0; j < num - 1; j++)
				{
					int num5 = (FlatRings ? (j * 2) : j);
					int v = num3 + num5 + 1;
					int v2 = num4 + num5 + 1;
					int v3 = num4 + num5;
					int v4 = num3 + num5;
					MeshX_Extensions.QuadTriangles quadTriangles = Submesh.AddQuadAsTriangles(v, v2, v3, v4);
					base.AllTriangles.Add(quadTriangles.first);
					base.AllTriangles.Add(quadTriangles.second);
				}
			}
		}

		public override void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Update");
		}

		private floatQ GenerateRotation(float segmentIndex, float ringIndex)
		{
			return (floatQ)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateRotation", segmentIndex, ringIndex), typeof(floatQ));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public UVSphereCapsule(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct Triangle : IMeshXPrimitive, IMeshXElement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private int index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "index", value);
			}
		}

		private int version
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "version"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "version", value);
			}
		}

		private TriangleSubmesh submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "submesh", value);
			}
		}

		public TriangleSubmesh Submesh => submesh;

		public MeshX Mesh => submesh?.Mesh;

		public bool IsNull => submesh == null;

		Submesh IMeshXPrimitive.Submesh => submesh;

		public int IndexUnsafe => index;

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public int SubmeshIndexUnsafe => submesh.Index;

		public int SubmeshIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SubmeshIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SubmeshIndex", value);
			}
		}

		public int Vertex0IndexUnsafe
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex0IndexUnsafe"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex0IndexUnsafe", value);
			}
		}

		public int Vertex1IndexUnsafe
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex1IndexUnsafe"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex1IndexUnsafe", value);
			}
		}

		public int Vertex2IndexUnsafe
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex2IndexUnsafe"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex2IndexUnsafe", value);
			}
		}

		public int Vertex0Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex0Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex0Index", value);
			}
		}

		public int Vertex1Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex1Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex1Index", value);
			}
		}

		public int Vertex2Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex2Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex2Index", value);
			}
		}

		public Vertex Vertex0
		{
			get
			{
				return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex0"), typeof(Vertex));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex0", value);
			}
		}

		public Vertex Vertex1
		{
			get
			{
				return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex1"), typeof(Vertex));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex1", value);
			}
		}

		public Vertex Vertex2
		{
			get
			{
				return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Vertex2"), typeof(Vertex));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Vertex2", value);
			}
		}

		public float3 SurfaceNormal
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SurfaceNormal"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SurfaceNormal", value);
			}
		}

		public float3 SurfaceNormalUnsafe
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SurfaceNormalUnsafe"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SurfaceNormalUnsafe", value);
			}
		}

		public float Area
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Area"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Area", value);
			}
		}

		public float AreaUnsafe
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AreaUnsafe"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AreaUnsafe", value);
			}
		}

		public float AverageLength
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AverageLength"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AverageLength", value);
			}
		}

		public float AverageLengthUnsafe
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AverageLengthUnsafe"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AverageLengthUnsafe", value);
			}
		}

		public color AverageColor
		{
			get
			{
				return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AverageColor"), typeof(color));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AverageColor", value);
			}
		}

		public color AverageColorUnsafe
		{
			get
			{
				return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AverageColorUnsafe"), typeof(color));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AverageColorUnsafe", value);
			}
		}

		internal Triangle(int index, TriangleSubmesh submesh)
		{
			this.index = index;
			this.submesh = submesh;
			if (submesh.Mesh.TrackRemovals)
			{
				version = submesh.primitiveIDs[index];
			}
			else
			{
				version = submesh.PrimitivesVersion;
			}
		}

		public void Copy(Triangle t)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Copy", t);
		}

		public Vertex GetVertex(int index)
		{
			return (Vertex)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVertex", index), typeof(Vertex));
		}

		public int GetVertexIndexUnsafe(int index)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVertexIndexUnsafe", index), typeof(int));
		}

		public void Set(Vertex v0, Vertex v1, Vertex v2)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Set", v0, v1, v2);
		}

		public void Set(int v0, int v1, int v2)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Set", v0, v1, v2);
		}

		public void ReverseWinding()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReverseWinding");
		}

		public bool TryComputeSurfaceNormalUnsafe(out float3 normal)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryComputeSurfaceNormalUnsafe", normal), typeof(bool));
		}

		public float3 GetBarycentricCoordinate(in float3 point)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBarycentricCoordinate", point), typeof(float3));
		}

		public float3 GetBarycentricCoordinateFromUV0(in float2 uv)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBarycentricCoordinateFromUV0", uv), typeof(float3));
		}

		public float3 InterpolatePosition(in float3 barycentricCoordinate)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InterpolatePosition", barycentricCoordinate), typeof(float3));
		}

		public float3 InterpolateNormal(in float3 barycentricCoordinate)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InterpolateNormal", barycentricCoordinate), typeof(float3));
		}

		public color InterpolateColor(in float3 barycentricCoordinate)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InterpolateColor", barycentricCoordinate), typeof(color));
		}

		public float4 InterpolateTangent(in float3 barycentricCoordinate)
		{
			return (float4)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InterpolateTangent", barycentricCoordinate), typeof(float4));
		}

		public float2 InterpolateUV0(in float3 barycentricCoordinate)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InterpolateUV0", barycentricCoordinate), typeof(float2));
		}

		internal bool UpdateIndex()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateIndex"), typeof(bool));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Triangle(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct TriangleCollectionSlice : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int offset
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "offset"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "offset", value);
			}
		}

		public int count
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "count"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "count", value);
			}
		}

		public TriangleCollection collection
		{
			get
			{
				return (TriangleCollection)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "collection"), typeof(TriangleCollection));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "collection", value);
			}
		}

		public bool IsNull => collection == null;

		public Triangle this[int index]
		{
			get
			{
				if (index < 0 || index >= count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return collection[offset + index];
			}
		}

		public TriangleCollectionSlice(int offset, int count, TriangleCollection collection)
		{
			this.offset = offset;
			this.count = count;
			this.collection = collection;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TriangleCollectionSlice(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TriangleCollection : IEnumerable<Triangle>, IEnumerable, IList<Triangle>, ICollection<Triangle>, IPoolable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		internal List<Triangle> _triangles
		{
			get
			{
				return (List<Triangle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_triangles"), typeof(List<Triangle>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_triangles", value);
			}
		}

		public int Count => _triangles.Count;

		public int Capacity
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Capacity"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Capacity", value);
			}
		}

		public bool IsReadOnly => false;

		public Triangle this[int index]
		{
			get
			{
				Triangle triangle = _triangles[index];
				if (triangle.UpdateIndex())
				{
					_triangles[index] = triangle;
				}
				return triangle;
			}
			set
			{
				_triangles[index] = value;
			}
		}

		public void UpdateIndexes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateIndexes");
		}

		public TriangleCollection()
			: this(4)
		{
		}

		public TriangleCollection(int capacity = 4)
		{
			_triangles = new List<Triangle>(capacity);
		}

		public void Add(Triangle v)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", v);
		}

		public void AddRange(IEnumerable<Triangle> collection)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddRange", collection);
		}

		public bool Remove(Triangle v)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", v), typeof(bool));
		}

		public void RemoveAt(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveAt", index);
		}

		public void RemoveRange(int index, int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveRange", index, count);
		}

		public List<Triangle>.Enumerator GetEnumerator()
		{
			return (List<Triangle>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(List<Triangle>.Enumerator));
		}

		IEnumerator<Triangle> IEnumerable<Triangle>.GetEnumerator()
		{
			return (IEnumerator<Triangle>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<Triangle>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		public int IndexOf(Triangle item)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IndexOf", item), typeof(int));
		}

		public void Insert(int index, Triangle item)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Insert", index, item);
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public bool Contains(Triangle item)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Contains", item), typeof(bool));
		}

		public void CopyTo(Triangle[] array, int arrayIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyTo", array, arrayIndex);
		}

		void IPoolable.Clean()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clean");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TriangleCollection(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct trig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int v0
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "v0"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "v0", value);
			}
		}

		public int v1
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "v1"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "v1", value);
			}
		}

		public int v2
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "v2"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "v2", value);
			}
		}

		public trig(int v0, int v1, int v2)
		{
			this.v0 = v0;
			this.v1 = v1;
			this.v2 = v2;
		}

		public void VerticesRemoved(int index, int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "VerticesRemoved", index, count);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public trig(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class TriangleSubmesh : Submesh, ISubmesh<Triangle>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override SubmeshTopology Topology => SubmeshTopology.Triangles;

		public override int IndiciesPerElement => 3;

		Triangle ISubmesh<Triangle>.this[int index] => GetTriangle(index);

		public TriangleSubmesh(MeshX mesh)
			: base(mesh)
		{
		}

		public Triangle AddTriangle()
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle"), typeof(Triangle));
		}

		public void AddTriangles(int count, TriangleCollection trigs = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangles", count, trigs);
		}

		public Triangle AddTriangle(int v0, int v1, int v2)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle", v0, v1, v2), typeof(Triangle));
		}

		public Triangle AddTriangle(int v0, int v1, int v2, bool reverse)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle", v0, v1, v2, reverse), typeof(Triangle));
		}

		public Triangle AddTriangle(Vertex v0, Vertex v1, Vertex v2)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddTriangle", v0, v1, v2), typeof(Triangle));
		}

		public void SetTriangle(int index, int v0, int v1, int v2)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetTriangle", index, v0, v1, v2);
		}

		public Triangle GetTriangle(int index)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTriangle", index), typeof(Triangle));
		}

		public Triangle GetTriangleUnsafe(int index)
		{
			return (Triangle)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTriangleUnsafe", index), typeof(Triangle));
		}

		public void GetIndicies(int index, out int v0, out int v1, out int v2)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetIndicies", index, v0, v1, v2);
		}

		public void GetIndiciesUnsafe(int index, out int v0, out int v1, out int v2)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetIndiciesUnsafe", index, v0, v1, v2);
		}

		public void Remove(Triangle t)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", t);
		}

		public void Remove(TriangleCollection triangles)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", triangles);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TriangleSubmesh(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IVertex : ResoniteBridge.ResoniteBridgeValueHolder
	{
		MeshX Mesh { get; }

		float3 Position { get; set; }

		float3 Normal { get; set; }

		float3 Tangent { get; set; }

		float4 Tangent4 { get; set; }

		color Color { get; set; }

		float2 UV0 { get; set; }

		float2 UV1 { get; set; }

		float2 UV2 { get; set; }

		float2 UV3 { get; set; }

		BoneBinding BoneBinding { get; set; }

		float2 GetUV(int channel);

		void SetUV(int channel, in float2 uv);

		float3 GetBlendShapePositionDelta(string key, int frame = 0);

		void SetBlendShapePositionDelta(string key, in float3 delta, int frame = 0);

		float3 GetBlendShapeNormalDelta(string key, int frame = 0);

		void SetBlendShapeNormalDelta(string key, in float3 delta, int frame = 0);

		float3 GetBlendShapeTangentDelta(string key, int frame = 0);

		void SetBlendShapeTangentDelta(string key, in float3 delta, int frame = 0);
	}
	public struct Vertex : IVertex, IMeshXElement, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private int index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "index", value);
			}
		}

		private int version
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "version"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "version", value);
			}
		}

		private MeshX meshx
		{
			get
			{
				return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "meshx"), typeof(MeshX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "meshx", value);
			}
		}

		public MeshX Mesh => meshx;

		public static Vertex Null => default(Vertex);

		public int IndexUnsafe => index;

		public int Index
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Index"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Index", value);
			}
		}

		public ref float3 PositionUnsafe => ref meshx.positions[index];

		public float3 Position
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Position"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Position", value);
			}
		}

		public ref float3 NormalUnsafe => ref meshx.normals[index];

		public float3 Normal
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Normal"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Normal", value);
			}
		}

		public ref float4 Tangent4Unsafe => ref meshx.tangents[index];

		public float3 Tangent
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Tangent"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Tangent", value);
			}
		}

		public float4 Tangent4
		{
			get
			{
				return (float4)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Tangent4"), typeof(float4));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Tangent4", value);
			}
		}

		public ref color ColorUnsafe => ref meshx.colors[index];

		public color Color
		{
			get
			{
				return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Color"), typeof(color));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Color", value);
			}
		}

		public ref BoneBinding BoneBindingUnsafe => ref meshx.boneBindings[index];

		public BoneBinding BoneBinding
		{
			get
			{
				return (BoneBinding)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BoneBinding"), typeof(BoneBinding));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BoneBinding", value);
			}
		}

		public ref float2 UV0Unsafe => ref meshx.uv_channels[0].uv_2D[index];

		public ref float2 UV1Unsafe => ref meshx.uv_channels[1].uv_2D[index];

		public ref float2 UV2Unsafe => ref meshx.uv_channels[2].uv_2D[index];

		public ref float2 UV3Unsafe => ref meshx.uv_channels[3].uv_2D[index];

		public float2 UV0
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV0"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV0", value);
			}
		}

		public float2 UV1
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV1"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV1", value);
			}
		}

		public float2 UV2
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV2"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV2", value);
			}
		}

		public float2 UV3
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV3"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV3", value);
			}
		}

		public bool FlagUnsafe
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FlagUnsafe"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FlagUnsafe", value);
			}
		}

		public bool Flag
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Flag"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Flag", value);
			}
		}

		internal Vertex(int index, MeshX meshx)
		{
			this.index = index;
			this.meshx = meshx;
			if (meshx.TrackRemovals)
			{
				version = meshx.vertexIDs[index];
			}
			else
			{
				version = meshx.VerticesVersion;
			}
		}

		public void Copy(Vertex v)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Copy", v);
		}

		public float2 GetUV(int uvChannel)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUV", uvChannel), typeof(float2));
		}

		public float4 GetUV_Auto(int uvChannel)
		{
			return (float4)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUV_Auto", uvChannel), typeof(float4));
		}

		public void SetUV(int uvChannel, in float2 uv)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetUV", uvChannel, uv);
		}

		public float3 GetBlendShapePositionDelta(string key, int frame = 0)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShapePositionDelta", key, frame), typeof(float3));
		}

		public void SetBlendShapePositionDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapePositionDelta", key, delta, frame);
		}

		public float3 GetBlendShapeNormalDelta(string key, int frame = 0)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShapeNormalDelta", key, frame), typeof(float3));
		}

		public void SetBlendShapeNormalDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeNormalDelta", key, delta, frame);
		}

		public float3 GetBlendShapeTangentDelta(string key, int frame = 0)
		{
			return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBlendShapeTangentDelta", key, frame), typeof(float3));
		}

		public void SetBlendShapeTangentDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeTangentDelta", key, delta, frame);
		}

		public void SetPosition(in float3 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPosition", value);
		}

		public void SetNormal(in float3 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetNormal", value);
		}

		public void SetTangent(in float3 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetTangent", value);
		}

		public void SetTangent4(in float4 value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetTangent4", value);
		}

		public void SetColor(in color value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetColor", value);
		}

		public void SetFlag(bool value)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetFlag", value);
		}

		internal bool UpdateIndex()
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateIndex"), typeof(bool));
		}

		void IVertex.SetUV(int channel, in float2 uv)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetUV", channel, uv);
		}

		void IVertex.SetBlendShapePositionDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapePositionDelta", key, delta, frame);
		}

		void IVertex.SetBlendShapeNormalDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeNormalDelta", key, delta, frame);
		}

		void IVertex.SetBlendShapeTangentDelta(string key, in float3 delta, int frame = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetBlendShapeTangentDelta", key, delta, frame);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Vertex(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class VertexCollection : IEnumerable<Vertex>, IEnumerable, IList<Vertex>, ICollection<Vertex>, IPoolable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		internal List<Vertex> _vertices
		{
			get
			{
				return (List<Vertex>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_vertices"), typeof(List<Vertex>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_vertices", value);
			}
		}

		public Indexer<float3> Positions
		{
			get
			{
				return (Indexer<float3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Positions"), typeof(Indexer<float3>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Positions", value);
			}
		}

		public Indexer<float3> Normals
		{
			get
			{
				return (Indexer<float3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Normals"), typeof(Indexer<float3>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Normals", value);
			}
		}

		public Indexer<float3> Tangents
		{
			get
			{
				return (Indexer<float3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Tangents"), typeof(Indexer<float3>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Tangents", value);
			}
		}

		public Indexer<float4> Tangents4
		{
			get
			{
				return (Indexer<float4>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Tangents4"), typeof(Indexer<float4>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Tangents4", value);
			}
		}

		public Indexer<color> Colors
		{
			get
			{
				return (Indexer<color>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Colors"), typeof(Indexer<color>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Colors", value);
			}
		}

		public Indexer<float2> UV0s
		{
			get
			{
				return (Indexer<float2>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UV0s"), typeof(Indexer<float2>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UV0s", value);
			}
		}

		public Indexer<float2> UV1s
		{
			get
			{
				return (Indexer<float2>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UV1s"), typeof(Indexer<float2>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UV1s", value);
			}
		}

		public Indexer<float2> UV2s
		{
			get
			{
				return (Indexer<float2>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UV2s"), typeof(Indexer<float2>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UV2s", value);
			}
		}

		public Indexer<float2> UV3s
		{
			get
			{
				return (Indexer<float2>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "UV3s"), typeof(Indexer<float2>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "UV3s", value);
			}
		}

		public Indexer<bool> Flags
		{
			get
			{
				return (Indexer<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Flags"), typeof(Indexer<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Flags", value);
			}
		}

		public int Count => _vertices.Count;

		public int Capacity
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Capacity"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Capacity", value);
			}
		}

		public bool IsReadOnly => false;

		public Vertex this[int index]
		{
			get
			{
				Vertex vertex = _vertices[index];
				if (vertex.UpdateIndex())
				{
					_vertices[index] = vertex;
				}
				return vertex;
			}
			set
			{
				_vertices[index] = value;
			}
		}

		public void UpdateIndexes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateIndexes");
		}

		public VertexCollection(int capacity = 4)
		{
			_vertices = new List<Vertex>(capacity);
			Positions = new Indexer<float3>((int i) => this[i].Position, delegate(int i, float3 v)
			{
				this[i].SetPosition(in v);
			});
			Normals = new Indexer<float3>((int i) => this[i].Normal, delegate(int i, float3 v)
			{
				this[i].SetNormal(in v);
			});
			Tangents = new Indexer<float3>((int i) => this[i].Tangent, delegate(int i, float3 v)
			{
				this[i].SetTangent(in v);
			});
			Tangents4 = new Indexer<float4>((int i) => this[i].Tangent4, delegate(int i, float4 v)
			{
				this[i].SetTangent4(in v);
			});
			Colors = new Indexer<color>((int i) => this[i].Color, delegate(int i, color v)
			{
				this[i].SetColor(in v);
			});
			UV0s = new Indexer<float2>((int i) => this[i].UV0, delegate(int i, float2 v)
			{
				this[i].SetUV(0, in v);
			});
			UV1s = new Indexer<float2>((int i) => this[i].UV1, delegate(int i, float2 v)
			{
				this[i].SetUV(1, in v);
			});
			UV2s = new Indexer<float2>((int i) => this[i].UV2, delegate(int i, float2 v)
			{
				this[i].SetUV(2, in v);
			});
			UV3s = new Indexer<float2>((int i) => this[i].UV3, delegate(int i, float2 v)
			{
				this[i].SetUV(3, in v);
			});
			Flags = new Indexer<bool>((int i) => this[i].Flag, delegate(int i, bool v)
			{
				this[i].SetFlag(v);
			});
		}

		public void Add(Vertex v)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Add", v);
		}

		public void AddRange(IEnumerable<Vertex> collection)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddRange", collection);
		}

		public bool Remove(Vertex v)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Remove", v), typeof(bool));
		}

		public void RemoveAt(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveAt", index);
		}

		public void RemoveRange(int index, int count)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveRange", index, count);
		}

		public List<Vertex>.Enumerator GetEnumerator()
		{
			return (List<Vertex>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(List<Vertex>.Enumerator));
		}

		IEnumerator<Vertex> IEnumerable<Vertex>.GetEnumerator()
		{
			return (IEnumerator<Vertex>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<Vertex>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		public int IndexOf(Vertex item)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IndexOf", item), typeof(int));
		}

		public void Insert(int index, Vertex item)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Insert", index, item);
		}

		public void Clear()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clear");
		}

		public bool Contains(Vertex item)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Contains", item), typeof(bool));
		}

		public void CopyTo(Vertex[] array, int arrayIndex)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyTo", array, arrayIndex);
		}

		void IPoolable.Clean()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clean");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public VertexCollection(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class BlenderInterface
	{
		private static string[] searchLocations
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "searchLocations"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "searchLocations", value);
			}
		}

		public static bool IsAvailable => File.Exists(Executable);

		public static string RootDir
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "RootDir"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "RootDir", value);
			}
		}

		public static string Executable
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Executable"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Executable", value);
			}
		}

		static BlenderInterface()
		{
			searchLocations = new string[3] { "C:\\Program Files", "C:\\Program Files (x86)", "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Blender" };
			try
			{
				string fullPath = Path.GetFullPath("Tools\\Blender\\blender.exe");
				if (File.Exists(fullPath))
				{
					RootDir = PathUtility.GetDirectoryName(fullPath);
					Executable = fullPath;
					return;
				}
				string[] array = searchLocations;
				foreach (string text in array)
				{
					if (!Directory.Exists(text))
					{
						continue;
					}
					string text3;
					if (text.IndexOf("blender", StringComparison.InvariantCultureIgnoreCase) < 0)
					{
						string[] directories = Directory.GetDirectories(text);
						foreach (string path in directories)
						{
							if (!Path.GetFileName(path).ToLower().Contains("blender foundation"))
							{
								continue;
							}
							string[] directories2 = Directory.GetDirectories(path);
							foreach (string text2 in directories2)
							{
								text3 = Path.Combine(text2, "blender.exe");
								if (File.Exists(text3))
								{
									RootDir = text2;
									Executable = text3;
									return;
								}
							}
						}
					}
					text3 = Path.Combine(text, "blender.exe");
					if (File.Exists(text3))
					{
						RootDir = text;
						Executable = text3;
						break;
					}
				}
			}
			catch (Exception ex)
			{
				UniLog.Error("Error when detecting Blender: " + ex);
			}
		}

		public static void ExportToFBX(string input, string output)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ExportToFBX", input, output);
		}

		public static void ExportToGLTF(string input, string output)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ExportToGLTF", input, output);
		}

		private static void RunScript(string script, string arguments = "-b -P \"{0}\"")
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BlenderInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "RunScript", script, arguments);
		}
	}
	public static class FreeCADInterface
	{
		private static string[] searchLocations
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "searchLocations"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "searchLocations", value);
			}
		}

		public static string[] SupportedFormats
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportedFormats"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportedFormats", value);
			}
		}

		public static bool IsAvailable => File.Exists(Executable);

		public static string RootDir
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "RootDir"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "RootDir", value);
			}
		}

		public static string Executable
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Executable"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Executable", value);
			}
		}

		static FreeCADInterface()
		{
			searchLocations = new string[2] { "C:\\Program Files", "C:\\Program Files (x86)" };
			SupportedFormats = new string[11]
			{
				"stp", "step", "inp", "brep", "brp", "frd", "iges", "igs", "iv", "oca",
				"gcad"
			};
			try
			{
				string[] array = searchLocations;
				foreach (string path in array)
				{
					if (!Directory.Exists(path))
					{
						continue;
					}
					string[] directories = Directory.GetDirectories(path);
					foreach (string text in directories)
					{
						if (Path.GetFileName(text).ToLower().Contains("freecad"))
						{
							RootDir = text;
							return;
						}
					}
				}
			}
			catch (Exception ex)
			{
				UniLog.Error("Error when detecting FreeCAD: " + ex);
			}
		}

		public static void Tesselate(string input, string output, float tesselation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Tesselate", input, output, tesselation);
		}

		private static void RunScript(string script)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeCADInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "RunScript", script);
		}
	}
	public static class ModelPreimporter
	{
		public float DEFAULT_TESSELATION
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ModelPreimporter", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_TESSELATION"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ModelPreimporter", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_TESSELATION", value);
			}
		}

		public static string Preimport(string model, string tempPath)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ModelPreimporter", ResoniteBridge.ResoniteBridgeValueType.Type), "Preimport", model, tempPath), typeof(string));
		}
	}
	public class ComputedConvexHull : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float3 Position
		{
			get
			{
				return (float3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Position"), typeof(float3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Position", value);
			}
		}

		public floatQ Rotation
		{
			get
			{
				return (floatQ)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Rotation"), typeof(floatQ));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Rotation", value);
			}
		}

		public MeshX Mesh
		{
			get
			{
				return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Mesh"), typeof(MeshX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Mesh", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ComputedConvexHull(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class VHACDInterface
	{
		[DataModelType]
		public enum DecompositionMode
		{
			Voxel,
			Tetrahedron
		}

		public int MIN_RESOLUTION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_RESOLUTION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_RESOLUTION", value);
			}
		}

		public int MAX_RESOLUTION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_RESOLUTION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_RESOLUTION", value);
			}
		}

		public int DEFAULT_RESOLUTION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_RESOLUTION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_RESOLUTION", value);
			}
		}

		public int MIN_DEPTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_DEPTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_DEPTH", value);
			}
		}

		public int MAX_DEPTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_DEPTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_DEPTH", value);
			}
		}

		public int DEFAULT_DEPTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DEPTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DEPTH", value);
			}
		}

		public float DEFAULT_CONCAVITY
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CONCAVITY"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CONCAVITY", value);
			}
		}

		public int DEFAULT_DOWNSAMPLING
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DOWNSAMPLING"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DOWNSAMPLING", value);
			}
		}

		public int MIN_DOWNSAMPLING
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_DOWNSAMPLING"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_DOWNSAMPLING", value);
			}
		}

		public int MAX_DOWNSAMPLING
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_DOWNSAMPLING"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_DOWNSAMPLING", value);
			}
		}

		public float DEFAULT_ALPHA
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_ALPHA"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_ALPHA", value);
			}
		}

		public float DEFAULT_BETA
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_BETA"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_BETA", value);
			}
		}

		public float DEFAULT_GAMMA
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_GAMMA"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_GAMMA", value);
			}
		}

		public float DEFAULT_DELTA
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DELTA"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DELTA", value);
			}
		}

		public bool DEFAULT_PCA
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PCA"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PCA", value);
			}
		}

		public DecompositionMode DEFAULT_MODE
		{
			get
			{
				return (DecompositionMode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MODE"), typeof(DecompositionMode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MODE", value);
			}
		}

		public int MIN_MAX_VERTICES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_MAX_VERTICES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_MAX_VERTICES", value);
			}
		}

		public int MAX_MAX_VERTICES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_MAX_VERTICES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_MAX_VERTICES", value);
			}
		}

		public int DEFAULT_MAX_VERTICES
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MAX_VERTICES"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MAX_VERTICES", value);
			}
		}

		public float MIN_MIN_VOLUME
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_MIN_VOLUME"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MIN_MIN_VOLUME", value);
			}
		}

		public float MAX_MIN_VOLUME
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_MIN_VOLUME"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_MIN_VOLUME", value);
			}
		}

		public float DEFAULT_MIN_VOLUME
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MIN_VOLUME"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_MIN_VOLUME", value);
			}
		}

		public bool DEFAULT_CONVEX_HULL_APPROXIMATION
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CONVEX_HULL_APPROXIMATION"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CONVEX_HULL_APPROXIMATION", value);
			}
		}

		public static bool IsAvailable => File.Exists(Executable);

		public static string Executable
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Executable"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Executable", value);
			}
		}

		public static Task<List<ComputedConvexHull>> Decompose(MeshX mesh, int resolution = 100000, int depth = 20, float concavity = 0.0025f, int planeDownsampling = 4, int convexHullDownsampling = 4, float alpha = 0.05f, float beta = 0.05f, float gamma = 0.00125f, float delta = 0.05f, bool pca = false, DecompositionMode mode = DecompositionMode.Voxel, int maxVerticesPerHull = 64, float minVolumePerHull = 0.0001f, bool convexHullApproximation = true)
		{
			return (Task<List<ComputedConvexHull>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Decompose", mesh, resolution, depth, concavity, planeDownsampling, convexHullDownsampling, alpha, beta, gamma, delta, pca, mode, maxVerticesPerHull, minVolumePerHull, convexHullApproximation), typeof(Task<List<ComputedConvexHull>>));
		}

		private static void ExtractHulls(MFNode node, List<ComputedConvexHull> hulls)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VHACDInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractHulls", node, hulls);
		}
	}
	public static class WavefrontExporter
	{
		public static void ExportAsOBJ(this MeshX meshx, string file)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "WavefrontExporter", ResoniteBridge.ResoniteBridgeValueType.Type), "ExportAsOBJ", meshx, file);
		}

		public static void ExportAsOBJ(this MeshX meshx, Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "WavefrontExporter", ResoniteBridge.ResoniteBridgeValueType.Type), "ExportAsOBJ", meshx, stream);
		}
	}
	public class RecordPackage : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public string ASSET_SCHEME
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ASSET_SCHEME"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ASSET_SCHEME", value);
			}
		}

		public string MAIN_RECORD_ID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAIN_RECORD_ID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAIN_RECORD_ID", value);
			}
		}

		public string ASSETS_FOLDER
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ASSETS_FOLDER"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ASSETS_FOLDER", value);
			}
		}

		public string VARIANTS_FOLDER
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "VARIANTS_FOLDER"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "VARIANTS_FOLDER", value);
			}
		}

		public string METADATA_FOLDER
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "METADATA_FOLDER"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "METADATA_FOLDER", value);
			}
		}

		public string RECORD_EXTENSION
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RECORD_EXTENSION"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RECORD_EXTENSION", value);
			}
		}

		private ZipArchive _archive
		{
			get
			{
				return (ZipArchive)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_archive"), typeof(ZipArchive));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_archive", value);
			}
		}

		private Dictionary<string, Record> _records
		{
			get
			{
				return (Dictionary<string, Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_records"), typeof(Dictionary<string, Record>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_records", value);
			}
		}

		private Dictionary<string, ZipArchiveEntry> _assets
		{
			get
			{
				return (Dictionary<string, ZipArchiveEntry>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_assets"), typeof(Dictionary<string, ZipArchiveEntry>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_assets", value);
			}
		}

		private Dictionary<string, Dictionary<string, ZipArchiveEntry>> _variants
		{
			get
			{
				return (Dictionary<string, Dictionary<string, ZipArchiveEntry>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_variants"), typeof(Dictionary<string, Dictionary<string, ZipArchiveEntry>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_variants", value);
			}
		}

		private Dictionary<string, IAssetMetadata> _metadata
		{
			get
			{
				return (Dictionary<string, IAssetMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_metadata"), typeof(Dictionary<string, IAssetMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_metadata", value);
			}
		}

		public int RecordCount => _records.Count;

		public int AssetCount => _assets.Count;

		public Record MainRecord
		{
			get
			{
				return (Record)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MainRecord"), typeof(Record));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MainRecord", value);
			}
		}

		public IEnumerable<Record> Records => _records.Values;

		public IEnumerable<string> Assets => _assets.Keys;

		public IEnumerable<IAssetMetadata> Metadata => _metadata.Values;

		public static Uri GetAssetURL(string signature)
		{
			return (Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "RecordPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "GetAssetURL", signature), typeof(Uri));
		}

		public static string GetAssetSignature(Uri uri)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "RecordPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "GetAssetSignature", uri), typeof(string));
		}

		public static RecordPackage Decode(string file)
		{
			return (RecordPackage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "RecordPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", file), typeof(RecordPackage));
		}

		public static RecordPackage Decode(Stream stream)
		{
			return (RecordPackage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "RecordPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", stream), typeof(RecordPackage));
		}

		public static RecordPackage Create(Stream writeStream)
		{
			return (RecordPackage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "RecordPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "Create", writeStream), typeof(RecordPackage));
		}

		public bool HasAsset(string signature)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasAsset", signature), typeof(bool));
		}

		public bool HasVariant(string signature, string variantIdentifier)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasVariant", signature, variantIdentifier), typeof(bool));
		}

		public IEnumerable<string> EnumerateVariantsForAsset(string signature)
		{
			return (IEnumerable<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnumerateVariantsForAsset", signature), typeof(IEnumerable<string>));
		}

		public IAssetMetadata TryGetMetadata(string signature)
		{
			return (IAssetMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryGetMetadata", signature), typeof(IAssetMetadata));
		}

		public void WriteRecord(Record record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteRecord", record);
		}

		public void WriteMetadata(IAssetMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteMetadata", metadata);
		}

		private void WriteMetadata<M>(M metadata, string extension) where M : IAssetMetadata
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteMetadata", metadata, extension);
		}

		private void DecodeMetadata<M>(string signature, ZipArchiveEntry entry) where M : IAssetMetadata
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DecodeMetadata", signature, entry);
		}

		public void ExtractAsset(string signature, Stream targetStream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractAsset", signature, targetStream);
		}

		public void ExtractVariant(string signature, string variantIdentifier, Stream targetStream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractVariant", signature, variantIdentifier, targetStream);
		}

		public void WriteAsset(string signature, string file)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteAsset", signature, file);
		}

		public void WriteAsset(string signature, Stream assetData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteAsset", signature, assetData);
		}

		public Stream ReadAsset(string signature)
		{
			return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadAsset", signature), typeof(Stream));
		}

		public Stream ReadVariant(string signature, string variantIdentifier)
		{
			return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadVariant", signature, variantIdentifier), typeof(Stream));
		}

		public void WriteVariant(string signature, string variantIdentifier, string file)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteVariant", signature, variantIdentifier, file);
		}

		public void WriteVariant(string signature, string variantIdentifier, Stream assetData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteVariant", signature, variantIdentifier, assetData);
		}

		private void Extract(Dictionary<string, ZipArchiveEntry> entries, string identifier, Stream targetStream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Extract", entries, identifier, targetStream);
		}

		private Stream Read(Dictionary<string, ZipArchiveEntry> entries, string identifier)
		{
			return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Read", entries, identifier), typeof(Stream));
		}

		private void Write(Dictionary<string, ZipArchiveEntry> entries, string folder, string identifier, Stream sourceData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Write", entries, folder, identifier, sourceData);
		}

		private void Load(Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Load", stream);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public RecordPackage(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class PointCloudDecoder
	{
		public static MeshX Decode(string file)
		{
			return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PointCloudDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", file), typeof(MeshX));
		}

		public static MeshX DecodeASCII_PTS(string file)
		{
			return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PointCloudDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "DecodeASCII_PTS", file), typeof(MeshX));
		}

		public static MeshX DecodeLAZ(string file)
		{
			return (MeshX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PointCloudDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "DecodeLAZ", file), typeof(MeshX));
		}
	}
	public class ShaderPackage : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ZipArchive _archive
		{
			get
			{
				return (ZipArchive)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_archive"), typeof(ZipArchive));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_archive", value);
			}
		}

		private Dictionary<string, ShaderSource> _cachedSources
		{
			get
			{
				return (Dictionary<string, ShaderSource>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_cachedSources"), typeof(Dictionary<string, ShaderSource>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_cachedSources", value);
			}
		}

		public ShaderMetadata Metadata
		{
			get
			{
				return (ShaderMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Metadata"), typeof(ShaderMetadata));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Metadata", value);
			}
		}

		public static string MetadataPath => "metadata.json";

		public static ShaderPackage CreateFromSource(string shaderSourceFile, Stream targetStream, string origin)
		{
			return (ShaderPackage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateFromSource", shaderSourceFile, targetStream, origin), typeof(ShaderPackage));
		}

		public ShaderPackage(string file)
		{
			FileStream stream = File.OpenRead(file);
			Decode(stream);
		}

		public ShaderPackage(ShaderMetadata metadata, Stream writeStream)
		{
			_archive = new ZipArchive(writeStream, ZipArchiveMode.Create);
			Metadata = metadata;
			string value = JsonConvert.SerializeObject(Metadata, Formatting.Indented);
			using Stream stream = _archive.CreateEntry(MetadataPath, CompressionLevel.Optimal).Open();
			StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(value);
			streamWriter.Flush();
		}

		public ShaderPackage(Stream stream)
		{
			Decode(stream);
		}

		private void Decode(Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Decode", stream);
		}

		public void WriteSource(ShaderSource source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteSource", source);
		}

		public ShaderSource ReadSource(string filename)
		{
			return (ShaderSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadSource", filename), typeof(ShaderSource));
		}

		public void WriteVariant(string platform, uint variant, Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteVariant", platform, variant, stream);
		}

		public byte[] ReadVariant(string platform, uint variant)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadVariant", platform, variant), typeof(byte[]));
		}

		public static string VariantPath(string platform, uint variant)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "VariantPath", platform, variant), typeof(string));
		}

		public static string SourcePath(string sourceSubpath)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderPackage", ResoniteBridge.ResoniteBridgeValueType.Type), "SourcePath", sourceSubpath), typeof(string));
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ShaderPackage(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class ShaderSource : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private static HashSet<string> IgnoredIncludes
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderSource", ResoniteBridge.ResoniteBridgeValueType.Type), "IgnoredIncludes"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderSource", ResoniteBridge.ResoniteBridgeValueType.Type), "IgnoredIncludes", value);
			}
		}

		public string File
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "File"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "File", value);
			}
		}

		public string[] Lines
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Lines"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Lines", value);
			}
		}

		public bool IsInclude
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsInclude"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsInclude", value);
			}
		}

		public string ShaderName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ShaderName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ShaderName", value);
			}
		}

		public int ShaderNameLine
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ShaderNameLine"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ShaderNameLine", value);
			}
		}

		public int ShaderNameStartIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ShaderNameStartIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ShaderNameStartIndex", value);
			}
		}

		public int ShaderNameEndIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ShaderNameEndIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ShaderNameEndIndex", value);
			}
		}

		public int PropertiesStartLine
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PropertiesStartLine"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PropertiesStartLine", value);
			}
		}

		public int PropertiesStartIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PropertiesStartIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PropertiesStartIndex", value);
			}
		}

		public int PropertiesEndLine
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PropertiesEndLine"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PropertiesEndLine", value);
			}
		}

		public int PropertiesEndIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PropertiesEndIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PropertiesEndIndex", value);
			}
		}

		public List<int> IncludeLines
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IncludeLines"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IncludeLines", value);
			}
		}

		public List<int> MultiCompileLines
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MultiCompileLines"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MultiCompileLines", value);
			}
		}

		public List<int> OnlyRenderersLines
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OnlyRenderersLines"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OnlyRenderersLines", value);
			}
		}

		public List<int> FallbackLines
		{
			get
			{
				return (List<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FallbackLines"), typeof(List<int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FallbackLines", value);
			}
		}

		public List<string> Includes
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Includes"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Includes", value);
			}
		}

		public List<List<string>> Variants
		{
			get
			{
				return (List<List<string>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Variants"), typeof(List<List<string>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Variants", value);
			}
		}

		public static List<ShaderSource> CollectSources(string file)
		{
			return (List<ShaderSource>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderSource", ResoniteBridge.ResoniteBridgeValueType.Type), "CollectSources", file), typeof(List<ShaderSource>));
		}

		private static void ProcessIncludes(ShaderSource source, Dictionary<string, ShaderSource> dependencies)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderSource", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessIncludes", source, dependencies);
		}

		public ShaderSource(string filename, bool isInclude)
			: this(filename, System.IO.File.ReadAllLines(filename), isInclude)
		{
		}

		public ShaderSource(string filename, string[] lines, bool isInclude)
		{
			File = filename;
			Lines = lines;
			IsInclude = isInclude;
			bool insideComment = false;
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			int num = 0;
			for (int i = 0; i < lines.Length; i++)
			{
				string rawLine = GetRawLine(lines[i], ref insideComment);
				string text = rawLine.Trim();
				if (!IsInclude)
				{
					if (!flag)
					{
						flag = rawLine.Contains("Shader");
					}
					if (flag && !flag2)
					{
						ShaderNameStartIndex = rawLine.IndexOf('"');
						if (ShaderNameStartIndex >= 0)
						{
							ShaderNameStartIndex++;
							ShaderNameLine = i;
							ShaderNameEndIndex = rawLine.IndexOf('"', ShaderNameStartIndex + 1);
							flag2 = true;
							ShaderName = rawLine.Substring(ShaderNameStartIndex, ShaderNameEndIndex - ShaderNameStartIndex);
						}
					}
					int j = 0;
					if (flag2 && !flag3)
					{
						j = rawLine.IndexOf("Properties");
						if (j >= 0)
						{
							flag3 = true;
							PropertiesStartIndex = -1;
						}
					}
					if (flag3 && !flag4)
					{
						for (; j < rawLine.Length; j++)
						{
							switch (rawLine[j])
							{
								case '{':
									if (num == 0)
									{
										PropertiesStartLine = i;
										PropertiesStartIndex = j;
									}
									num++;
									break;
								case '}':
									num--;
									if (num == 0)
									{
										PropertiesEndLine = i;
										PropertiesEndIndex = j;
										flag4 = true;
									}
									break;
							}
						}
					}
				}
				if (text.StartsWith("#pragma "))
				{
					if (text.Contains("multi_compile "))
					{
						int num2 = rawLine.IndexOf("multi_compile");
						num2 += "multi_compile".Length;
						rawLine = rawLine.Substring(num2);
						List<string> item = new List<string>(from v in rawLine.Split(new string[1] { " " }, StringSplitOptions.RemoveEmptyEntries)
							select ProcessVariant(v));
						MultiCompileLines.Add(i);
						Variants.Add(item);
					}
					else if (text.Contains("shader_feature "))
					{
						int num3 = rawLine.IndexOf("shader_feature");
						num3 += "shader_feature".Length;
						rawLine = rawLine.Substring(num3);
						List<string> item2 = new List<string>
						{
							"_",
							rawLine.Trim()
						};
						MultiCompileLines.Add(i);
						Variants.Add(item2);
					}
					else if (text.Contains("only_renderers"))
					{
						OnlyRenderersLines.Add(i);
					}
				}
				else if (text.StartsWith("#include "))
				{
					int num4 = rawLine.IndexOf('"') + 1;
					int num5 = rawLine.LastIndexOf('"');
					string item3 = rawLine.Substring(num4, num5 - num4).Trim();
					if (!IgnoredIncludes.Contains(item3))
					{
						IncludeLines.Add(i);
						Includes.Add(item3);
					}
				}
				else if (text.StartsWith("fallback ", StringComparison.InvariantCultureIgnoreCase))
				{
					FallbackLines.Add(i);
				}
			}
		}

		public string GetSource()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSource"), typeof(string));
		}

		public string GetVariantSource(List<string> keywords, uint variantIndex, string renderers)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariantSource", keywords, variantIndex, renderers), typeof(string));
		}

		private static void InjectDefine(StringBuilder str, string keyword)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderSource", ResoniteBridge.ResoniteBridgeValueType.Type), "InjectDefine", str, keyword);
		}

		public string ComputeSourceHash()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeSourceHash"), typeof(string));
		}

		internal void ResolveIncludes()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResolveIncludes");
		}

		internal void FlattenPath(Dictionary<string, string> nameMapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FlattenPath", nameMapping);
		}

		internal void UpdateIncludes(Dictionary<string, string> nameMapping)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateIncludes", nameMapping);
		}

		private static string ProcessVariant(string variant)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderSource", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessVariant", variant), typeof(string));
		}

		private static string GetRawLine(string line, ref bool insideComment)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderSource", ResoniteBridge.ResoniteBridgeValueType.Type), "GetRawLine", line, insideComment), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ShaderSource(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public enum GlyphRenderMethod
	{
		Raster,
		MSDF
	}
	public class FontX : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ConcurrentDictionary<uint, GlyphMetrics> glyphMetrics
		{
			get
			{
				return (ConcurrentDictionary<uint, GlyphMetrics>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "glyphMetrics"), typeof(ConcurrentDictionary<uint, GlyphMetrics>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "glyphMetrics", value);
			}
		}

		private ConcurrentDictionary<uint, GlyphOutline> glyphOutlines
		{
			get
			{
				return (ConcurrentDictionary<uint, GlyphOutline>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "glyphOutlines"), typeof(ConcurrentDictionary<uint, GlyphOutline>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "glyphOutlines", value);
			}
		}

		private ConcurrentDictionary<uint, GlyphMetrics> charMapping
		{
			get
			{
				return (ConcurrentDictionary<uint, GlyphMetrics>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "charMapping"), typeof(ConcurrentDictionary<uint, GlyphMetrics>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "charMapping", value);
			}
		}

		private ConcurrentDictionary<uint, ConcurrentDictionary<uint, float2>> kerningCache
		{
			get
			{
				return (ConcurrentDictionary<uint, ConcurrentDictionary<uint, float2>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "kerningCache"), typeof(ConcurrentDictionary<uint, ConcurrentDictionary<uint, float2>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "kerningCache", value);
			}
		}

		private ConcurrentDictionary<string, uint> namedGlyphs
		{
			get
			{
				return (ConcurrentDictionary<string, uint>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "namedGlyphs"), typeof(ConcurrentDictionary<string, uint>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "namedGlyphs", value);
			}
		}

		private List<GlyphAtlas> atlases
		{
			get
			{
				return (List<GlyphAtlas>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "atlases"), typeof(List<GlyphAtlas>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "atlases", value);
			}
		}

		private IFontDataSource fontDataSource
		{
			get
			{
				return (IFontDataSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "fontDataSource"), typeof(IFontDataSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "fontDataSource", value);
			}
		}

		public string Name
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Name"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Name", value);
			}
		}

		public float LineHeight
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LineHeight"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LineHeight", value);
			}
		}

		public int GlyphCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "GlyphCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "GlyphCount", value);
			}
		}

		public int NamedGlyphCount => namedGlyphs.Count;

		public FontX(IFontDataSource dataSource)
		{
			fontDataSource = dataSource;
			Name = dataSource.FontName;
			LineHeight = dataSource.LineHeight;
			GlyphCount = dataSource.GlyphCount;
		}

		public int2 GetDefaultGlyphResolution(uint glyphId)
		{
			return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDefaultGlyphResolution", glyphId), typeof(int2));
		}

		public GlyphMetrics GetGlyphMetrics(uint glyphId)
		{
			return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphMetrics", glyphId), typeof(GlyphMetrics));
		}

		public bool GetGlyphTintable(uint glyphId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphTintable", glyphId), typeof(bool));
		}

		public GlyphMetrics GetCharMetrics(char ch)
		{
			return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCharMetrics", ch), typeof(GlyphMetrics));
		}

		public GlyphMetrics GetCharMetrics(uint charcode)
		{
			return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCharMetrics", charcode), typeof(GlyphMetrics));
		}

		public uint GetGlyphIdFromName(string glyphName)
		{
			return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphIdFromName", glyphName), typeof(uint));
		}

		public void ClearCachedCharMapping(uint charcode)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearCachedCharMapping", charcode);
		}

		public float2 GetKerning(uint leftGlyphId, uint rightGlyphId)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetKerning", leftGlyphId, rightGlyphId), typeof(float2));
		}

		public uint CharToGlyphId(char ch)
		{
			return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CharToGlyphId", ch), typeof(uint));
		}

		public GlyphOutline GetOutline(uint glyphId)
		{
			return (GlyphOutline)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOutline", glyphId), typeof(GlyphOutline));
		}

		public void AssignGlyphName(string name, uint glyphId, bool replaceExisting)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AssignGlyphName", name, glyphId, replaceExisting);
		}

		public void RemoveGlyphName(string name, uint glyphId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveGlyphName", name, glyphId);
		}

		public static FontX Load(string file, string extension = null)
		{
			return (FontX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FontX", ResoniteBridge.ResoniteBridgeValueType.Type), "Load", file, extension), typeof(FontX));
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public unsafe bool RenderGlyphMSDF(uint glyphId, Bitmap2D bitmap, Rect region, int pixelRange, bool rotated)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RenderGlyphMSDF", glyphId, bitmap, region, pixelRange, rotated), typeof(bool));
		}

		public bool RenderGlyphRaster(uint glyphId, Bitmap2D bitmap, Rect region, bool rotated)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RenderGlyphRaster", glyphId, bitmap, region, rotated), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public FontX(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct GlyphPackData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public uint glyphId
		{
			get
			{
				return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "glyphId"), typeof(uint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "glyphId", value);
			}
		}

		public float2 size
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "size"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "size", value);
			}
		}

		public float area
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "area"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "area", value);
			}
		}

		public float longerSide
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "longerSide"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "longerSide", value);
			}
		}

		public GlyphPackData(uint glyphId, in float2 size)
		{
			this.glyphId = glyphId;
			this.size = size;
			area = size.x * size.y;
			longerSide = MathX.MaxComponent(in size);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlyphPackData(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlyphAtlas : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int DEFAULT_PACK_REGION_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "DEFAULT_PACK_REGION_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "DEFAULT_PACK_REGION_SIZE", value);
			}
		}

		public int DEFAULT_MAX_ATLAS_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "DEFAULT_MAX_ATLAS_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "DEFAULT_MAX_ATLAS_SIZE", value);
			}
		}

		public FontX Font
		{
			get
			{
				return (FontX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Font"), typeof(FontX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Font", value);
			}
		}

		public int PixelRange
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "PixelRange"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "PixelRange", value);
			}
		}

		public int Padding
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Padding"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Padding", value);
			}
		}

		public int PackRegionSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "PackRegionSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "PackRegionSize", value);
			}
		}

		public GlyphRenderMethod RenderMethod
		{
			get
			{
				return (GlyphRenderMethod)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RenderMethod"), typeof(GlyphRenderMethod));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RenderMethod", value);
			}
		}

		private ConcurrentDictionary<uint, GlyphAtlasData> _glyphs
		{
			get
			{
				return (ConcurrentDictionary<uint, GlyphAtlasData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_glyphs"), typeof(ConcurrentDictionary<uint, GlyphAtlasData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_glyphs", value);
			}
		}

		private RectPackNode _rootPackNode
		{
			get
			{
				return (RectPackNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_rootPackNode"), typeof(RectPackNode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_rootPackNode", value);
			}
		}

		private int _maxAtlasSize
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_maxAtlasSize"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_maxAtlasSize", value);
			}
		}

		public bool BitmapAllocated => Atlas != null;

		public bool AllowsPacking => _rootPackNode != null;

		public int2 CurrentPackSize
		{
			get
			{
				return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CurrentPackSize"), typeof(int2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CurrentPackSize", value);
			}
		}

		public Bitmap2D Atlas
		{
			get
			{
				return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Atlas"), typeof(Bitmap2D));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Atlas", value);
			}
		}

		public GlyphAtlas(FontX font, GlyphRenderMethod renderMethod, int padding = 1, int pixelRange = 2, int packRegionSize = 512, int maxAtlasSize = 8192)
		{
			Font = font;
			PixelRange = pixelRange;
			Padding = padding;
			RenderMethod = renderMethod;
			PackRegionSize = packRegionSize;
			float2 v = float2.One;
			float2 size = v * PackRegionSize;
			_rootPackNode = new RectPackNode(in size);
			_maxAtlasSize = 8192;
		}

		public GlyphAtlasData GetGlyphData(uint glyphId)
		{
			return (GlyphAtlasData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphData", glyphId), typeof(GlyphAtlasData));
		}

		public bool HasGlyphData(uint glyphId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HasGlyphData", glyphId), typeof(bool));
		}

		public int Pack(List<GlyphPackData> glyphs, int offset = 0, bool allowPartialPack = false)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Pack", glyphs, offset, allowPartialPack), typeof(int));
		}

		public bool Pack(in GlyphPackData glyph)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Pack", glyph), typeof(bool));
		}

		public void AllocateBitmap(bool mipmaps)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AllocateBitmap", mipmaps);
		}

		private void GrowAtlas()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GrowAtlas");
		}

		public void FinishPacking()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FinishPacking");
		}

		public void CopyGlyphBitmapFrom(uint glyphId, GlyphAtlas sourceAtlas)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyGlyphBitmapFrom", glyphId, sourceAtlas);
		}

		public void CopyGlyphBitmapFrom(GlyphAtlasData targetGlyph, GlyphAtlas sourceAtlas)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyGlyphBitmapFrom", targetGlyph, sourceAtlas);
		}

		public void CopyGlyphBitmapFrom(GlyphAtlasData targetGlyph, GlyphAtlas sourceAtlas, GlyphAtlasData sourceGlyph)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyGlyphBitmapFrom", targetGlyph, sourceAtlas, sourceGlyph);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlyphAtlas(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlyphAtlasData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public uint glyphId
		{
			get
			{
				return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "glyphId"), typeof(uint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "glyphId", value);
			}
		}

		public Rect region
		{
			get
			{
				return (Rect)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "region"), typeof(Rect));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "region", value);
			}
		}

		public bool rotated
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rotated"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rotated", value);
			}
		}

		public float2 offset
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "offset"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "offset", value);
			}
		}

		public Rect uv
		{
			get
			{
				return (Rect)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "uv"), typeof(Rect));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "uv", value);
			}
		}

		public float2 rangeExtendRatio
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "rangeExtendRatio"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "rangeExtendRatio", value);
			}
		}

		public GlyphAtlasData(uint glyphId, Rect region, bool rotated)
		{
			this.glyphId = glyphId;
			this.region = region;
			this.rotated = rotated;
		}

		public void CalculateRenderParameters(GlyphAtlas atlas)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CalculateRenderParameters", atlas);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlyphAtlasData(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlyphMetrics : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public uint glyphId
		{
			get
			{
				return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "glyphId"), typeof(uint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "glyphId", value);
			}
		}

		public float width
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "width"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "width", value);
			}
		}

		public float height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "height", value);
			}
		}

		public float horizontalAdvance
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "horizontalAdvance"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "horizontalAdvance", value);
			}
		}

		public float horizontalBearingX
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "horizontalBearingX"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "horizontalBearingX", value);
			}
		}

		public float horizontalBearingY
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "horizontalBearingY"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "horizontalBearingY", value);
			}
		}

		public float verticalAdvance
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "verticalAdvance"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "verticalAdvance", value);
			}
		}

		public float verticalBearingX
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "verticalBearingX"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "verticalBearingX", value);
			}
		}

		public float verticalBearingY
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "verticalBearingY"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "verticalBearingY", value);
			}
		}

		public GlyphMetrics(uint glyphId, float width, float height, float horizontalAdvance, float horizontalBearingX, float horizontalBearingY, float verticalAdvance, float verticalBearingX, float verticalBearingY)
		{
			this.glyphId = glyphId;
			this.width = width;
			this.height = height;
			this.horizontalAdvance = horizontalAdvance;
			this.horizontalBearingX = horizontalBearingX;
			this.horizontalBearingY = horizontalBearingY;
			this.verticalAdvance = verticalAdvance;
			this.verticalBearingX = verticalBearingX;
			this.verticalBearingY = verticalBearingY;
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlyphMetrics(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlyphContour : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float2 origin
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "origin"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "origin", value);
			}
		}

		public List<GlyphSegment> segments
		{
			get
			{
				return (List<GlyphSegment>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "segments"), typeof(List<GlyphSegment>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "segments", value);
			}
		}

		public int SegmentCount => segments.Count;

		public GlyphContour(in float2 origin)
		{
			this.origin = origin;
		}

		public float2 GetOriginPoint(int segmentIndex)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetOriginPoint", segmentIndex), typeof(float2));
		}

		public void AddLine(in float2 point)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddLine", point);
		}

		public void AddConic(in float2 point, in float2 controlPoint)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddConic", point, controlPoint);
		}

		public void AddCubic(in float2 point, in float2 controlPoint0, in float2 controlPoint1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddCubic", point, controlPoint0, controlPoint1);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlyphContour(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public enum GlyphSegmentType
	{
		Line,
		Conic,
		Cubic
	}
	public struct GlyphSegment : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public GlyphSegmentType type
		{
			get
			{
				return (GlyphSegmentType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "type"), typeof(GlyphSegmentType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "type", value);
			}
		}

		public float2 point
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "point"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "point", value);
			}
		}

		public float2 controlPoint0
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "controlPoint0"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "controlPoint0", value);
			}
		}

		public float2 controlPoint1
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "controlPoint1"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "controlPoint1", value);
			}
		}

		private GlyphSegment(GlyphSegmentType type, in float2 point, in float2 controlPoint0, in float2 controlPoint1)
		{
			this.type = type;
			this.point = point;
			this.controlPoint0 = controlPoint0;
			this.controlPoint1 = controlPoint1;
		}

		public static GlyphSegment Line(in float2 point)
		{
			return (GlyphSegment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphSegment", ResoniteBridge.ResoniteBridgeValueType.Type), "Line", point), typeof(GlyphSegment));
		}

		public static GlyphSegment Conic(in float2 point, in float2 controlPoint)
		{
			return (GlyphSegment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphSegment", ResoniteBridge.ResoniteBridgeValueType.Type), "Conic", point, controlPoint), typeof(GlyphSegment));
		}

		public static GlyphSegment Cubic(in float2 point, in float2 controlPoint0, in float2 controlPoint1)
		{
			return (GlyphSegment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphSegment", ResoniteBridge.ResoniteBridgeValueType.Type), "Cubic", point, controlPoint0, controlPoint1), typeof(GlyphSegment));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlyphSegment(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class GlyphOutline : IEnumerable<GlyphContour>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<GlyphContour> _contours
		{
			get
			{
				return (List<GlyphContour>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_contours"), typeof(List<GlyphContour>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_contours", value);
			}
		}

		public int ContourCount => _contours.Count;

		public GlyphContour LastContour => _contours[ContourCount - 1];

		public GlyphContour this[int index] => _contours[index];

		public GlyphContour AddContour(in float2 origin)
		{
			return (GlyphContour)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddContour", origin), typeof(GlyphContour));
		}

		public void AddContour(GlyphContour contour)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddContour", contour);
		}

		public void RemoveContourAt(int index)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveContourAt", index);
		}

		public List<GlyphContour>.Enumerator GetEnumerator()
		{
			return (List<GlyphContour>.Enumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(List<GlyphContour>.Enumerator));
		}

		IEnumerator<GlyphContour> IEnumerable<GlyphContour>.GetEnumerator()
		{
			return (IEnumerator<GlyphContour>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator<GlyphContour>));
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (IEnumerator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetEnumerator"), typeof(IEnumerator));
		}

		public void FixArtifacts()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FixArtifacts");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public GlyphOutline(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DynamicBitmapFileFont : IFontDataSource, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public class SpriteGlyph : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public string file
			{
				get
				{
					return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "file"), typeof(string));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "file", value);
				}
			}

			public GlyphMetrics metrics
			{
				get
				{
					return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "metrics"), typeof(GlyphMetrics));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "metrics", value);
				}
			}

			public bool tintable
			{
				get
				{
					return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "tintable"), typeof(bool));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "tintable", value);
				}
			}

			private int2 _cachedSize
			{
				get
				{
					return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "_cachedSize"), typeof(int2));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "_cachedSize", value);
				}
			}

			public Bitmap2D LoadedBitmap
			{
				get
				{
					return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LoadedBitmap"), typeof(Bitmap2D));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LoadedBitmap", value);
				}
			}

			public int2 SpriteResolution
			{
				get
				{
					return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SpriteResolution"), typeof(int2));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SpriteResolution", value);
				}
			}

			public SpriteGlyph(string file, GlyphMetrics metrics, bool tintable, Bitmap2D loadedBitmap = null)
			{
				this.file = file;
				this.metrics = metrics;
				this.tintable = tintable;
				LoadedBitmap = loadedBitmap;
				if (loadedBitmap != null)
				{
					_cachedSize = loadedBitmap.Size;
				}
			}

			public void EnsureLoadedBitmap()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureLoadedBitmap");
			}

			public void FreeBitmap()
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FreeBitmap");
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public SpriteGlyph(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private object _lock
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_lock"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_lock", value);
			}
		}

		private Dictionary<uint, SpriteGlyph> _glyphs
		{
			get
			{
				return (Dictionary<uint, SpriteGlyph>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_glyphs"), typeof(Dictionary<uint, SpriteGlyph>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_glyphs", value);
			}
		}

		private BiDictionary<uint, uint> _charToGlyphId
		{
			get
			{
				return (BiDictionary<uint, uint>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_charToGlyphId"), typeof(BiDictionary<uint, uint>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_charToGlyphId", value);
			}
		}

		public string FontName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FontName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FontName", value);
			}
		}

		public int GlyphCount => _glyphs.Count;

		public float LineHeight => 1f;

		public uint CharToGlyphId(uint charcode)
		{
			return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CharToGlyphId", charcode), typeof(uint));
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public bool GetGlyphTintable(uint glyphId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphTintable", glyphId), typeof(bool));
		}

		public GlyphMetrics ExtractGlyphMetrics(uint glyphId)
		{
			return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractGlyphMetrics", glyphId), typeof(GlyphMetrics));
		}

		public int2 GetDefaultGlyphResolution(uint glyphId)
		{
			return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDefaultGlyphResolution", glyphId), typeof(int2));
		}

		public GlyphOutline ExtractGlyphOutline(uint glyphId)
		{
			return (GlyphOutline)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractGlyphOutline", glyphId), typeof(GlyphOutline));
		}

		public void RenderRawGlyphBitmap(uint glyphId, Bitmap2D target, IntRect rect, bool rotated)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RenderRawGlyphBitmap", glyphId, target, rect, rotated);
		}

		public bool SupportsRenderMethod(GlyphRenderMethod method)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SupportsRenderMethod", method), typeof(bool));
		}

		public float2 ExtractKerning(uint leftGlyphId, uint rightGlyphId)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractKerning", leftGlyphId, rightGlyphId), typeof(float2));
		}

		public bool LoadFrom(string file)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LoadFrom", file), typeof(bool));
		}

		public void AddSpriteGlyph(uint glyphId, uint unicodeCodepoint, SpriteGlyph spriteGlyph)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AddSpriteGlyph", glyphId, unicodeCodepoint, spriteGlyph);
		}

		public void RemoveSpriteGlyph(uint glyphId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemoveSpriteGlyph", glyphId);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DynamicBitmapFileFont(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class FreeTypeFont : IFontDataSource, IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private static Library SharpFontLibrary
		{
			get
			{
				return (Library)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "SharpFontLibrary"), typeof(Library));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "SharpFontLibrary", value);
			}
		}

		public static bool UseStaticCallbacks
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "UseStaticCallbacks"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "UseStaticCallbacks", value);
			}
		}

		private SharpFont.Face face
		{
			get
			{
				return (SharpFont.Face)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "face"), typeof(SharpFont.Face));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "face", value);
			}
		}

		private float conversionRatio
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "conversionRatio"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "conversionRatio", value);
			}
		}

		private OutlineFuncs outlineFuncs
		{
			get
			{
				return (OutlineFuncs)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "outlineFuncs"), typeof(OutlineFuncs));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "outlineFuncs", value);
			}
		}

		private GlyphOutline currentOutline
		{
			get
			{
				return (GlyphOutline)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "currentOutline"), typeof(GlyphOutline));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "currentOutline", value);
			}
		}

		private static OutlineFuncs staticOutlineFuncs
		{
			get
			{
				return (OutlineFuncs)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "staticOutlineFuncs"), typeof(OutlineFuncs));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "staticOutlineFuncs", value);
			}
		}

		private static float staticConversionRatio
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "staticConversionRatio"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "staticConversionRatio", value);
			}
		}

		private static GlyphOutline staticCurrentOutline
		{
			get
			{
				return (GlyphOutline)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "staticCurrentOutline"), typeof(GlyphOutline));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "staticCurrentOutline", value);
			}
		}

		public static string FreeTypeVersion
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "FreeTypeVersion"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "FreeTypeVersion", value);
			}
		}

		public string FontName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FontName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FontName", value);
			}
		}

		public int GlyphCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "GlyphCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "GlyphCount", value);
			}
		}

		public float LineHeight
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LineHeight"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LineHeight", value);
			}
		}

		public FreeTypeFont(string file)
		{
			lock (SharpFontLibrary)
			{
				face = new SharpFont.Face(SharpFontLibrary, File.ReadAllBytes(file), 0);
				FontName = face.FamilyName;
				GlyphCount = face.GlyphCount;
				conversionRatio = 1f / (float)(int)face.UnitsPerEM;
				LineHeight = (float)face.Height * conversionRatio;
				if (!UseStaticCallbacks)
				{
					outlineFuncs = new OutlineFuncs(MoveTo, LineTo, ConicTo, CubicTo, 0, 0);
				}
				else if (staticOutlineFuncs == null)
				{
					staticOutlineFuncs = new OutlineFuncs(MoveToStatic, LineToStatic, ConicToStatic, CubicToStatic, 0, 0);
				}
			}
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public int2 GetDefaultGlyphResolution(uint glyphId)
		{
			return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetDefaultGlyphResolution", glyphId), typeof(int2));
		}

		public uint CharToGlyphId(uint charcode)
		{
			return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CharToGlyphId", charcode), typeof(uint));
		}

		public bool GetGlyphTintable(uint glyphId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphTintable", glyphId), typeof(bool));
		}

		public float2 ExtractKerning(uint leftGlyphId, uint rightGlyphId)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractKerning", leftGlyphId, rightGlyphId), typeof(float2));
		}

		public GlyphMetrics ExtractGlyphMetrics(uint glyphId)
		{
			return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractGlyphMetrics", glyphId), typeof(GlyphMetrics));
		}

		public GlyphOutline ExtractGlyphOutline(uint glyphId)
		{
			return (GlyphOutline)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractGlyphOutline", glyphId), typeof(GlyphOutline));
		}

		public bool SupportsRenderMethod(GlyphRenderMethod method)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SupportsRenderMethod", method), typeof(bool));
		}

		public void RenderRawGlyphBitmap(uint glyphId, Bitmap2D target, IntRect rect, bool rotated)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RenderRawGlyphBitmap", glyphId, target, rect, rotated);
		}

		private int MoveTo(ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MoveTo", point, userData), typeof(int));
		}

		private int LineTo(ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LineTo", point, userData), typeof(int));
		}

		private int ConicTo(ref FTVector controlPoint, ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConicTo", controlPoint, point, userData), typeof(int));
		}

		private int CubicTo(ref FTVector controlPoint0, ref FTVector controlPoint1, ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CubicTo", controlPoint0, controlPoint1, point, userData), typeof(int));
		}

		private float2 ToEngine(ref FTVector vector)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToEngine", vector), typeof(float2));
		}

		[Elements.Core.MonoPInvokeCallback(typeof(MoveToFunc))]
		private static int MoveToStatic(ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "MoveToStatic", point, userData), typeof(int));
		}

		[Elements.Core.MonoPInvokeCallback(typeof(LineToFunc))]
		private static int LineToStatic(ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "LineToStatic", point, userData), typeof(int));
		}

		[Elements.Core.MonoPInvokeCallback(typeof(ConicToFunc))]
		private static int ConicToStatic(ref FTVector controlPoint, ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "ConicToStatic", controlPoint, point, userData), typeof(int));
		}

		[Elements.Core.MonoPInvokeCallback(typeof(CubicToFunc))]
		private static int CubicToStatic(ref FTVector controlPoint0, ref FTVector controlPoint1, ref FTVector point, IntPtr userData)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "CubicToStatic", controlPoint0, controlPoint1, point, userData), typeof(int));
		}

		private static float2 ToEngineStatic(ref FTVector vector)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "FreeTypeFont", ResoniteBridge.ResoniteBridgeValueType.Type), "ToEngineStatic", vector), typeof(float2));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public FreeTypeFont(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IFontDataSource : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		string FontName { get; }

		int GlyphCount { get; }

		float LineHeight { get; }

		uint CharToGlyphId(uint charcode);

		bool GetGlyphTintable(uint glyphId);

		int2 GetDefaultGlyphResolution(uint glyphId);

		float2 ExtractKerning(uint leftGlyphId, uint rightGlyphId);

		GlyphMetrics ExtractGlyphMetrics(uint glyphId);

		GlyphOutline ExtractGlyphOutline(uint glyphId);

		void RenderRawGlyphBitmap(uint glyphId, Bitmap2D target, IntRect rect, bool rotated);

		bool SupportsRenderMethod(GlyphRenderMethod method);
	}
	internal interface ICharacterFilter : ResoniteBridge.ResoniteBridgeValueHolder
	{
		char FilterCharacter(char ch, int index);
	}
	internal interface ISizeFilter : ResoniteBridge.ResoniteBridgeValueHolder
	{
		float FilterSize(float size, int index);
	}
	public class CharSubstitutionNode : StringContainerNode, ICharacterFilter, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public char Character
		{
			get
			{
				return (char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Character"), typeof(char));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Character", value);
			}
		}

		public CharSubstitutionNode(char character, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Character = character;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public char FilterCharacter(char ch, int index)
		{
			return (char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FilterCharacter", ch, index), typeof(char));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CharSubstitutionNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public enum TextHorizontalAlignment
	{
		Left,
		Center,
		Right,
		Justify
	}
	[DataModelType]
	public enum TextVerticalAlignment
	{
		Top,
		Middle,
		Bottom
	}
	public class StringAlignmentNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TextHorizontalAlignment Alignment
		{
			get
			{
				return (TextHorizontalAlignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Alignment"), typeof(TextHorizontalAlignment));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Alignment", value);
			}
		}

		public StringAlignmentNode(TextHorizontalAlignment alignment, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Alignment = alignment;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public static StringAlignmentNode Parse(ReadOnlySpan<char> parameter, int startIndex, StringContainerNode parent)
		{
			return (StringAlignmentNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringAlignmentNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, startIndex, parent), typeof(StringAlignmentNode));
		}

		private static bool IsParameter(ReadOnlySpan<char> parameter, string name)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringAlignmentNode", ResoniteBridge.ResoniteBridgeValueType.Type), "IsParameter", parameter, name), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringAlignmentNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringAlignmentExtensions
	{
		public static TextHorizontalAlignment GetHorizontalAlignment(this StringNode node, out bool isOverride)
		{
			return (TextHorizontalAlignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringAlignmentExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetHorizontalAlignment", node, isOverride), typeof(TextHorizontalAlignment));
		}
	}
	public enum CapitalizationMode
	{
		Lowercase,
		Uppercase,
		SmallCaps
	}
	public class StringCapitalizationNode : StringContainerNode, ICharacterFilter, ISizeFilter, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public CapitalizationMode Mode
		{
			get
			{
				return (CapitalizationMode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Mode"), typeof(CapitalizationMode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Mode", value);
			}
		}

		public StringCapitalizationNode(CapitalizationMode mode, int startIndex, StringContainerNode node)
			: base(startIndex, node)
		{
			Mode = mode;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public char FilterCharacter(char ch, int index)
		{
			return (char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FilterCharacter", ch, index), typeof(char));
		}

		public float FilterSize(float size, int index)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FilterSize", size, index), typeof(float));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringCapitalizationNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StringCloseallBlockNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public StringCloseallBlockNode(int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringCloseallBlockNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StringColorNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[Flags]
		public enum MixMode
		{
			Color = 1,
			Alpha = 2
		}

		private static Dictionary<string, colorX> colors
		{
			get
			{
				return (Dictionary<string, colorX>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringColorNode", ResoniteBridge.ResoniteBridgeValueType.Type), "colors"), typeof(Dictionary<string, colorX>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringColorNode", ResoniteBridge.ResoniteBridgeValueType.Type), "colors", value);
			}
		}

		public colorX Color
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Color"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Color", value);
			}
		}

		public MixMode Mode
		{
			get
			{
				return (MixMode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Mode"), typeof(MixMode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Mode", value);
			}
		}

		public static void RegisterColorConstant(string name, colorX color)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringColorNode", ResoniteBridge.ResoniteBridgeValueType.Type), "RegisterColorConstant", name, color);
		}

		public StringColorNode(colorX color, MixMode mode, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Color = color;
			Mode = mode;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public static StringColorNode Parse(ReadOnlySpan<char> parameter, bool alphaOnly, int startIndex, StringContainerNode parent)
		{
			return (StringColorNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringColorNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, alphaOnly, startIndex, parent), typeof(StringColorNode));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringColorNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringColorExtensions
	{
		public static colorX GetFontColor(this StringNode node)
		{
			return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringColorExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFontColor", node), typeof(colorX));
		}
	}
	public class StringFontNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public FontSet FontSet
		{
			get
			{
				return (FontSet)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FontSet"), typeof(FontSet));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FontSet", value);
			}
		}

		public string FontName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FontName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FontName", value);
			}
		}

		public int FontIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FontIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FontIndex", value);
			}
		}

		public StringFontNode(string fontName, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			FontName = fontName;
		}

		public StringFontNode(int fontIndex, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			FontIndex = fontIndex;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public void ResolveFont()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResolveFont");
		}

		public static StringFontNode Parse(ReadOnlySpan<char> parameter, int startIndex, StringContainerNode parent)
		{
			return (StringFontNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringFontNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, startIndex, parent), typeof(StringFontNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringFontNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringFontExtensions
	{
		public static FontSet GetFontSet(this StringNode node, bool spriteFontSet = false)
		{
			return (FontSet)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringFontExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFontSet", node, spriteFontSet), typeof(FontSet));
		}
	}
	public struct StringFormatting : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public bool bold
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "bold"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "bold", value);
			}
		}

		public bool italics
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "italics"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "italics", value);
			}
		}

		public bool underline
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "underline"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "underline", value);
			}
		}

		public bool strikethrough
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "strikethrough"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "strikethrough", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringFormatting(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StringFormatNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum FormatType
		{
			Bold,
			Italics,
			Underline,
			Strikethrough
		}

		public FormatType Type
		{
			get
			{
				return (FormatType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Type"), typeof(FormatType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Type", value);
			}
		}

		public StringFormatNode(int startIndex, FormatType type, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Type = type;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringFormatNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringFormatExtensions
	{
		public static StringFormatting GetFontFormatting(this StringNode node)
		{
			return (StringFormatting)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFontFormatting", node), typeof(StringFormatting));
		}

		public static void GetFontFormatting(this StringNode node, ref StringFormatting formatting)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFontFormatting", node, formatting);
		}
	}
	public class StringGlyphNode : StringRenderGlyphSegmentNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public uint GlyphId
		{
			get
			{
				return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "GlyphId"), typeof(uint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "GlyphId", value);
			}
		}

		public string GlyphName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "GlyphName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "GlyphName", value);
			}
		}

		public bool Tint
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Tint"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Tint", value);
			}
		}

		public bool IsNamedSprite
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsNamedSprite"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsNamedSprite", value);
			}
		}

		public override bool HasCharacters => false;

		public override char GetCharacter(int index)
		{
			return (char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCharacter", index), typeof(char));
		}

		public StringGlyphNode(uint glyphId, string glyphName, int startIndex, bool? tint, StringContainerNode parent)
			: base(startIndex, parent)
		{
			GlyphId = glyphId;
			GlyphName = glyphName;
			IsNamedSprite = !string.IsNullOrWhiteSpace(GlyphName);
			if (tint.HasValue)
			{
				Tint = tint.Value;
				return;
			}
			if (!IsNamedSprite)
			{
				Tint = true;
				return;
			}
			FontSet fontSet = parent.GetFontSet(spriteFontSet: true);
			if (fontSet != null && fontSet.GetGlyphByName(glyphName, out var _, out var glyphId2, out var font))
			{
				Tint = font.GetGlyphTintable(glyphId2);
			}
			else
			{
				Tint = false;
			}
		}

		public override void GetRawString(StringBuilder str)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawString", str);
		}

		internal override void Shape(bool kerning, ref uint? lastGlyphId, ref FontX lastFont, ref float lastSize, List<ICharacterFilter> characterFilterCache, List<ISizeFilter> sizeFilterCache)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Shape", kerning, lastGlyphId, lastFont, lastSize, characterFilterCache, sizeFilterCache);
		}

		public static StringGlyphNode Parse(ReadOnlySpan<char> parameter, int startIndex, StringContainerNode parent)
		{
			return (StringGlyphNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringGlyphNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, startIndex, parent), typeof(StringGlyphNode));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringGlyphNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StringHorizontalGradientNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<color> colors
		{
			get
			{
				return (List<color>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "colors"), typeof(List<color>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "colors", value);
			}
		}

		public color Sample(float normalizedPosition)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Sample", normalizedPosition), typeof(color));
		}

		public StringHorizontalGradientNode(List<color> colors, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			this.colors = colors;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public static StringHorizontalGradientNode Parse(ReadOnlySpan<char> parameters, int startIndex, StringContainerNode parent)
		{
			return (StringHorizontalGradientNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringHorizontalGradientNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameters, startIndex, parent), typeof(StringHorizontalGradientNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringHorizontalGradientNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StringLineBreakNode : StringRenderGlyphSegmentNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public override bool HasCharacters => true;

		public StringLineBreakNode(int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
		}

		public override char GetCharacter(int index)
		{
			return (char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCharacter", index), typeof(char));
		}

		public override void GetRawString(StringBuilder str)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawString", str);
		}

		internal override void Shape(bool kerning, ref uint? lastGlyphId, ref FontX lastFont, ref float lastSize, List<ICharacterFilter> characterFilterCache, List<ISizeFilter> sizeFilterCache)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Shape", kerning, lastGlyphId, lastFont, lastSize, characterFilterCache, sizeFilterCache);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringLineBreakNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StringLineHeightNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float Height
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Height"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Height", value);
			}
		}

		public StringLineHeightNode(float height, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Height = height;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public static StringLineHeightNode Parse(ReadOnlySpan<char> parameter, int startIndex, StringContainerNode parent)
		{
			return (StringLineHeightNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringLineHeightNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, startIndex, parent), typeof(StringLineHeightNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringLineHeightNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringLineHeightExtensions
	{
		public static float GetLineHeight(this StringNode node)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringLineHeightExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetLineHeight", node), typeof(float));
		}
	}
	public class StringMarkNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public colorX MarkColor
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MarkColor"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MarkColor", value);
			}
		}

		public StringMarkNode(colorX markColor, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			MarkColor = markColor;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public static StringMarkNode Parse(ReadOnlySpan<char> parameter, int startIndex, StringContainerNode parent)
		{
			return (StringMarkNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringMarkNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, startIndex, parent), typeof(StringMarkNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringMarkNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringMarkExtensions
	{
		public static colorX? GetMarkColor(this StringNode node)
		{
			return (colorX?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringMarkExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMarkColor", node), typeof(colorX?));
		}
	}
	public class StringNoLineBreakNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public StringNoLineBreakNode(int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringNoLineBreakNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringNoLineBreakExtensions
	{
		public static bool DisableLineBreaking(this StringNode node)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringNoLineBreakExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "DisableLineBreaking", node), typeof(bool));
		}
	}
	public class StringNoParseNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum Mode
		{
			OpenClose,
			Length
		}

		public Mode NoParseMode
		{
			get
			{
				return (Mode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "NoParseMode"), typeof(Mode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "NoParseMode", value);
			}
		}

		public int NoParseLength
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "NoParseLength"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "NoParseLength", value);
			}
		}

		public override bool AllowOutOfOrderSplit => false;

		public StringNoParseNode(Mode noParseMode, int noParseLength, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			NoParseMode = noParseMode;
			NoParseLength = noParseLength;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public override bool IsValidNestedNode(StringContainerNode node)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsValidNestedNode", node), typeof(bool));
		}

		public static StringNoParseNode Parse(ReadOnlySpan<char> parameter, int startIndex, StringContainerNode parent)
		{
			return (StringNoParseNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringNoParseNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, startIndex, parent), typeof(StringNoParseNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringNoParseNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class StringRenderGlyphSegmentNode : StringNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int GlyphSegmentOffset { get; private set; }

		public int GlyphSegmentLength { get; private set; }

		public float2 PenPosition { get; set; }

		public abstract bool HasCharacters { get; }

		public abstract char GetCharacter(int index);

		public StringRenderGlyphSegmentNode(int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			ClearRenderGlyphs();
		}

		internal abstract void Shape(bool kerning, ref uint? lastGlyphId, ref FontX lastFont, ref float lastSize, List<ICharacterFilter> characterFilterCache, List<ISizeFilter> sizeFilterCache);

		protected void AppendGlyph(float glyphSize, int stringIndex, in float2 offset, GlyphMetrics metrics, FontX font, uint? lastGlyphId)
		{
			float x = metrics.horizontalBearingX * glyphSize;
			float num = metrics.horizontalBearingY * glyphSize;
			float x2 = metrics.width * glyphSize;
			float y = metrics.height * glyphSize;
			float2 a;
			float2 b;
			if (lastGlyphId.HasValue)
			{
				float2 v = font.GetKerning(lastGlyphId.Value, metrics.glyphId);
				a = PenPosition;
				b = v * glyphSize;
				PenPosition = a + b;
			}
			a = PenPosition;
			b = new float2(x, 0f - num);
			float2 a2 = a + b;
			float2 position = a2 + offset;
			RenderGlyph glyph = default(RenderGlyph);
			glyph.stringIndex = stringIndex;
			glyph.glyphId = metrics.glyphId;
			glyph.font = font;
			a = new float2(x2, y);
			glyph.rect = new Rect(in position, in a);
			glyph.line = -1;
			a = PenPosition;
			b = new float2(metrics.horizontalAdvance * glyphSize);
			PenPosition = a + b;
			glyph.pen = PenPosition;
			AppendRenderGlyph(ref glyph);
		}

		internal void ClearRenderGlyphs()
		{
			GlyphSegmentOffset = -1;
			GlyphSegmentLength = -1;
			PenPosition = float2.Zero;
		}

		public int AppendRenderGlyph(ref RenderGlyph glyph)
		{
			if (GlyphSegmentLength == -1)
			{
				GlyphSegmentOffset = base.Root.GlyphLayoutLength;
				GlyphSegmentLength = 0;
			}
			int num = GlyphSegmentOffset + GlyphSegmentLength;
			base.Root.AppendGlyph(num, ref glyph);
			GlyphSegmentLength++;
			return num;
		}

		public ref RenderGlyph GetRenderGlyph(int index)
		{
			if (index < 0 || index >= GlyphSegmentLength)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return ref base.Root.GetRenderGlyph(GlyphSegmentOffset + index);
		}

		public string GetStringBetween(int startGlyph, int endGlyph)
		{
			if (startGlyph > endGlyph)
			{
				throw new ArgumentException("startGlyph cannot be larger than endGlyph");
			}
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = startGlyph; i <= endGlyph; i++)
			{
				RenderGlyph renderGlyph = GetRenderGlyph(i);
				if (renderGlyph.stringIndex >= 0)
				{
					stringBuilder.Append(base.Root.String[renderGlyph.stringIndex]);
				}
			}
			return stringBuilder.ToString();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public enum TextScriptMode
	{
		Superscript,
		Subscript
	}
	public class StringScriptModeNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TextScriptMode Mode
		{
			get
			{
				return (TextScriptMode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Mode"), typeof(TextScriptMode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Mode", value);
			}
		}

		public StringScriptModeNode(TextScriptMode mode, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Mode = mode;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringScriptModeNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringSubSupScriptExtensions
	{
		public static void AdjustSizeAndBaseline(this StringNode node, ref float size, ref float baseLine)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringSubSupScriptExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "AdjustSizeAndBaseline", node, size, baseLine);
		}
	}
	public class StringSegmentNode : StringRenderGlyphSegmentNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int Length
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Length"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Length", value);
			}
		}

		public override bool HasCharacters => true;

		public char this[int index]
		{
			get
			{
				if (index < 0 || index >= Length)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return base.Root.String[base.StartIndex + index];
			}
		}

		public override char GetCharacter(int index)
		{
			return (char)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetCharacter", index), typeof(char));
		}

		public StringSegmentNode(int startIndex, int length, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Length = length;
			ToString();
			ClearRenderGlyphs();
		}

		internal override void Shape(bool kerning, ref uint? lastGlyphId, ref FontX lastFont, ref float lastSize, List<ICharacterFilter> characterFilterCache, List<ISizeFilter> sizeFilterCache)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Shape", kerning, lastGlyphId, lastFont, lastSize, characterFilterCache, sizeFilterCache);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public override void GetRawString(StringBuilder str)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRawString", str);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringSegmentNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class StringSizeNode : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum Mode
		{
			Relative,
			Absolute
		}

		public float Size
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public Mode SizeMode
		{
			get
			{
				return (Mode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "SizeMode"), typeof(Mode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "SizeMode", value);
			}
		}

		public StringSizeNode(float size, Mode sizeMode, int startIndex, StringContainerNode parent)
			: base(startIndex, parent)
		{
			Size = size;
			SizeMode = sizeMode;
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public static StringSizeNode Parse(ReadOnlySpan<char> parameter, int startIndex, StringContainerNode parent)
		{
			return (StringSizeNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringSizeNode", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", parameter, startIndex, parent), typeof(StringSizeNode));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringSizeNode(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class StringSizeExtensions
	{
		public static float GetFontSize(this StringNode node)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringSizeExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFontSize", node), typeof(float));
		}
	}
	public struct TextEditingVisuals : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int caretPosition
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "caretPosition"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "caretPosition", value);
			}
		}

		public int selectionStart
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "selectionStart"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "selectionStart", value);
			}
		}

		public colorX caretColor
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "caretColor"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "caretColor", value);
			}
		}

		public colorX selectionColor
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "selectionColor"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "selectionColor", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TextEditingVisuals(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct AtlasData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public GlyphAtlas glyphAtlas
		{
			get
			{
				return (GlyphAtlas)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "glyphAtlas"), typeof(GlyphAtlas));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "glyphAtlas", value);
			}
		}

		public object customData
		{
			get
			{
				return (object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "customData"), typeof(object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "customData", value);
			}
		}

		public AtlasData(GlyphAtlas glyphAtlas, object customData = null)
		{
			this.glyphAtlas = glyphAtlas;
			this.customData = customData;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AtlasData(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct AtlasSubmesh : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public GlyphAtlas atlas
		{
			get
			{
				return (GlyphAtlas)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "atlas"), typeof(GlyphAtlas));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "atlas", value);
			}
		}

		public TriangleSubmesh submesh
		{
			get
			{
				return (TriangleSubmesh)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "submesh"), typeof(TriangleSubmesh));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "submesh", value);
			}
		}

		public AtlasSubmesh(GlyphAtlas atlas, TriangleSubmesh submesh)
		{
			this.atlas = atlas;
			this.submesh = submesh;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AtlasSubmesh(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate TriangleSubmesh AtlasSubmeshMapper(AtlasData atlasData);
	public static class GlyphAtlasMeshGenerator
	{
		private struct LineSegment : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public StringLine line
			{
				get
				{
					return (StringLine)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "line"), typeof(StringLine));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "line", value);
				}
			}

			public int startGlyphIndex
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "startGlyphIndex"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "startGlyphIndex", value);
				}
			}

			public int endGlyphIndex
			{
				get
				{
					return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "endGlyphIndex"), typeof(int));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "endGlyphIndex", value);
				}
			}

			public RenderGlyph startGlyph
			{
				get
				{
					return (RenderGlyph)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "startGlyph"), typeof(RenderGlyph));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "startGlyph", value);
				}
			}

			public RenderGlyph endGlyph
			{
				get
				{
					return (RenderGlyph)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "endGlyph"), typeof(RenderGlyph));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "endGlyph", value);
				}
			}

			public LineSegment(StringLine line, int startGlyphIndex, int endGlyphIndex, RenderGlyph startGlyph, RenderGlyph endGlyph)
			{
				this.line = line;
				this.startGlyphIndex = startGlyphIndex;
				this.endGlyphIndex = endGlyphIndex;
				this.startGlyph = startGlyph;
				this.endGlyph = endGlyph;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public LineSegment(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		public static void Generate(StringRenderTree renderTree, float2 offset, MeshX meshx, AtlasSubmeshMapper submeshMapper, Dictionary<FontSet, List<AtlasData>> fontSetAtlases, TextEditingVisuals textEditVisuals, out bool usesAuxiliarySubmesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphAtlasMeshGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "Generate", renderTree, offset, meshx, submeshMapper, fontSetAtlases, textEditVisuals, usesAuxiliarySubmesh);
		}

		private static int MatchStringPositionToGlyph(StringRenderTree renderTree, int stringPosition)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphAtlasMeshGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "MatchStringPositionToGlyph", renderTree, stringPosition), typeof(int));
		}

		private static void Mark(StringRenderTree renderTree, MeshX mesh, TriangleSubmesh submesh, in LineSegment lineSegment, in color markColor, in float2 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphAtlasMeshGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "Mark", renderTree, mesh, submesh, lineSegment, markColor, offset);
		}

		private static void ExtractLineSegments(StringRenderTree renderTree, int startIndex, int length, List<LineSegment> lineSegments)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphAtlasMeshGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractLineSegments", renderTree, startIndex, length, lineSegments);
		}

		private static void InsertLine(MeshX mesh, TriangleSubmesh submesh, in float2 startPoint, in float2 endPoint, in color color, float thickness, in float2 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphAtlasMeshGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "InsertLine", mesh, submesh, startPoint, endPoint, color, thickness, offset);
		}

		private static void InsertLine(StringRenderTree renderTree, MeshX mesh, TriangleSubmesh submesh, in LineSegment segment, in color color, float heightOffset, float thickness, in float2 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "GlyphAtlasMeshGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "InsertLine", renderTree, mesh, submesh, segment, color, heightOffset, thickness, offset);
		}
	}
	public struct RenderGlyph : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int stringIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "stringIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "stringIndex", value);
			}
		}

		public uint glyphId
		{
			get
			{
				return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "glyphId"), typeof(uint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "glyphId", value);
			}
		}

		public FontX font
		{
			get
			{
				return (FontX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "font"), typeof(FontX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "font", value);
			}
		}

		public Rect rect
		{
			get
			{
				return (Rect)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rect"), typeof(Rect));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rect", value);
			}
		}

		public float2 pen
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "pen"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "pen", value);
			}
		}

		public int line
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "line"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "line", value);
			}
		}

		public void Translate(float x, float y)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Translate", x, y);
		}

		public void Translate(in float2 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Translate", offset);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public RenderGlyph(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public delegate void GlyphPositioner(ref RenderGlyph glyph, in float2 offset, int lineIndex);
	public class StringRenderTree : StringContainerNode, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private enum WithComputationMode
		{
			Word,
			Line
		}

		private struct RenestNode : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public StringSegment tag
			{
				get
				{
					return (StringSegment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "tag"), typeof(StringSegment));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "tag", value);
				}
			}

			public StringContainerNode node
			{
				get
				{
					return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "node"), typeof(StringContainerNode));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "node", value);
				}
			}

			public RenestNode(StringSegment tag, StringContainerNode node)
			{
				this.tag = tag;
				this.node = node;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return this.__backing;
				}
				set
				{
					this.__backing = value;
				}
			}

			public RenestNode(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private enum TagScanState
		{
			ScanningBeginning,
			ScanningTag,
			ScanningParameter,
			ScanningForEnd,
			FinishedScanning,
			Invalid
		}

		public int MAX_AUTO_SIZE_ITERATIONS
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAX_AUTO_SIZE_ITERATIONS"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAX_AUTO_SIZE_ITERATIONS", value);
			}
		}

		public static GlyphMetrics EMPTY_GLYPH
		{
			get
			{
				return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "EMPTY_GLYPH"), typeof(GlyphMetrics));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "EMPTY_GLYPH", value);
			}
		}

		public static GlyphMetrics TINY_GLYPH
		{
			get
			{
				return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "TINY_GLYPH"), typeof(GlyphMetrics));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "TINY_GLYPH", value);
			}
		}

		public static GlyphMetrics UNIT_GLYPH
		{
			get
			{
				return (GlyphMetrics)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "UNIT_GLYPH"), typeof(GlyphMetrics));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "UNIT_GLYPH", value);
			}
		}

		public int MAX_TAG_LENGTH
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAX_TAG_LENGTH"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAX_TAG_LENGTH", value);
			}
		}

		public string String
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "String"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "String", value);
			}
		}

		public float TabSpaces
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "TabSpaces"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "TabSpaces", value);
			}
		}

		public float Size
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Size"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Size", value);
			}
		}

		public float AutoSizeRatio
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "AutoSizeRatio"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "AutoSizeRatio", value);
			}
		}

		public float LineHeight
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LineHeight"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LineHeight", value);
			}
		}

		public colorX Color
		{
			get
			{
				return (colorX)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Color"), typeof(colorX));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Color", value);
			}
		}

		public TextHorizontalAlignment HorizontalAlignment
		{
			get
			{
				return (TextHorizontalAlignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "HorizontalAlignment"), typeof(TextHorizontalAlignment));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "HorizontalAlignment", value);
			}
		}

		public TextVerticalAlignment VerticalAlignment
		{
			get
			{
				return (TextVerticalAlignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "VerticalAlignment"), typeof(TextVerticalAlignment));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "VerticalAlignment", value);
			}
		}

		public float JustificationThreshold
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "JustificationThreshold"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "JustificationThreshold", value);
			}
		}

		public AlignmentMode AlignmentMode
		{
			get
			{
				return (AlignmentMode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "AlignmentMode"), typeof(AlignmentMode));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "AlignmentMode", value);
			}
		}

		public bool Bounded
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Bounded"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Bounded", value);
			}
		}

		public float2 BoundsSize
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BoundsSize"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BoundsSize", value);
			}
		}

		public Alignment BoundsAlignment
		{
			get
			{
				return (Alignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BoundsAlignment"), typeof(Alignment));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BoundsAlignment", value);
			}
		}

		private List<FontSet> _fontSets
		{
			get
			{
				return (List<FontSet>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_fontSets"), typeof(List<FontSet>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_fontSets", value);
			}
		}

		internal float _tabLength
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_tabLength"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_tabLength", value);
			}
		}

		internal float _invTabLength
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_invTabLength"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_invTabLength", value);
			}
		}

		private List<StringLine> _lines
		{
			get
			{
				return (List<StringLine>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_lines"), typeof(List<StringLine>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_lines", value);
			}
		}

		private int _glyphLayoutLength
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_glyphLayoutLength"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_glyphLayoutLength", value);
			}
		}

		private RenderGlyph[] _glyphLayout
		{
			get
			{
				return (RenderGlyph[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_glyphLayout"), typeof(RenderGlyph[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_glyphLayout", value);
			}
		}

		private bool _isShaped
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_isShaped"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_isShaped", value);
			}
		}

		public float LastLayoutWidth
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LastLayoutWidth"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LastLayoutWidth", value);
			}
		}

		public float LastLayoutHeight
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LastLayoutHeight"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LastLayoutHeight", value);
			}
		}

		public float ActualSize => Size * AutoSizeRatio;

		public FontSet MainFontSet => _fontSets[0];

		public FontSet MainSpriteFontSet
		{
			get
			{
				return (FontSet)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MainSpriteFontSet"), typeof(FontSet));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MainSpriteFontSet", value);
			}
		}

		public int FontSetCount => _fontSets.Count;

		public int GlyphLayoutLength => _glyphLayoutLength;

		public int LineCount => _lines.Count;

		public bool IsShaped => _isShaped;

		public static bool AllowsLineBreak(char ch)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "AllowsLineBreak", ch), typeof(bool));
		}

		public void HorizontalAutoSize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "HorizontalAutoSize");
		}

		public bool AutoSizeLayout(float min = 0f, float max = float.PositiveInfinity)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AutoSizeLayout", min, max), typeof(bool));
		}

		public void ComputeLines()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeLines");
		}

		public void Layout()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Layout");
		}

		public void OffsetLines(in float2 offset)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OffsetLines", offset);
		}

		private bool ExceedsHorizontalBounds(ref RenderGlyph glyph)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExceedsHorizontalBounds", glyph), typeof(bool));
		}

		private void GenerateLines(GlyphPositioner glyphPositionOverride = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateLines", glyphPositionOverride);
		}

		private void ComputeLineData()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeLineData");
		}

		private void LayOutLines()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LayOutLines");
		}

		private void PerformHorizontalAlignment()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PerformHorizontalAlignment");
		}

		public float ComputeMaxWordWidth()
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeMaxWordWidth"), typeof(float));
		}

		public float ComputeMaxLineWidth()
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeMaxLineWidth"), typeof(float));
		}

		private void UpdateMaxWordWidth(StringRenderGlyphSegmentNode segment, ref float maxLength, int? startGlyph, int? endGlyph)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateMaxWordWidth", segment, maxLength, startGlyph, endGlyph);
		}

		public float ComputeTotalLineHeight(AlignmentMode alignmentMode)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeTotalLineHeight", alignmentMode), typeof(float));
		}

		private void ComputeTopAndBottom(AlignmentMode alignmentMode, out float top, out float bottom)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeTopAndBottom", alignmentMode, top, bottom);
		}

		private void PerformVerticalAlignment()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PerformVerticalAlignment");
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public void ClearShaping()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearShaping");
		}

		public void ShapeText(bool kerning = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ShapeText", kerning);
		}

		public FontSet GetFontSet(string name)
		{
			return (FontSet)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetFontSet", name), typeof(FontSet));
		}

		public FontSet GetFontSet(int index)
		{
			return (FontSet)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetFontSet", index), typeof(FontSet));
		}

		public StringRenderTree(string str, FontSet fontSet, Func<StringContainerNode, StringContainerNode> initRootNodes = null, bool parse = true)
			: this(str, new List<FontSet> { fontSet }, initRootNodes, parse)
		{
		}

		public StringRenderTree(string str, List<FontSet> fontSets = null, Func<StringContainerNode, StringContainerNode> initRootNodes = null, bool parse = true)
		{
			String = str;
			_fontSets = fontSets;
			if (_fontSets != null)
			{
				MainSpriteFontSet = _fontSets.FirstOrDefault((FontSet f) => f.MainFont.NamedGlyphCount > 0);
			}
			if (parse)
			{
				Parse(str, initRootNodes);
				return;
			}
			StringContainerNode stringContainerNode = this;
			if (initRootNodes != null)
			{
				stringContainerNode = initRootNodes(stringContainerNode);
			}
			StringSegmentNode item = new StringSegmentNode(0, str.Length, stringContainerNode);
			stringContainerNode.Nodes.Add(item);
		}

		public override StringContainerNode Clone(int startIndex, StringContainerNode parent)
		{
			return (StringContainerNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone", startIndex, parent), typeof(StringContainerNode));
		}

		internal void AppendGlyph(int index, ref RenderGlyph glyph)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AppendGlyph", index, glyph);
		}

		public ref RenderGlyph GetRenderGlyph(int index)
		{
			return (ref RenderGlyph)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRenderGlyph", index), typeof(ref RenderGlyph));
		}

		public StringLine GetLine(int index)
		{
			return (StringLine)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLine", index), typeof(StringLine));
		}

		private void Parse(string str, Func<StringContainerNode, StringContainerNode> initRootNodes = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Parse", str, initRootNodes);
		}

		private static void FinishSegment(int segmentStart, int segmentEnd, StringContainerNode root)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "FinishSegment", segmentStart, segmentEnd, root);
		}

		private static StringNode CreateNode(int startIndex, StringContainerNode parent, in StringSegment tag, in StringSegment parameter)
		{
			return (StringNode)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateNode", startIndex, parent, tag, parameter), typeof(StringNode));
		}

		private static bool IsTag(in StringSegment tag, string name)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "IsTag", tag, name), typeof(bool));
		}

		private static bool IsTagCharacter(char ch)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "IsTagCharacter", ch), typeof(bool));
		}

		private static bool GetTag(in StringSegment segment, out StringSegment tag, out StringSegment parameter, out bool isClosingTag, out int tagEndIndex)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringRenderTree", ResoniteBridge.ResoniteBridgeValueType.Type), "GetTag", segment, tag, parameter, isClosingTag, tagEndIndex), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringRenderTree(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class StringContainerNode : StringNode, IEnumerable<StringRenderGlyphSegmentNode>, IEnumerable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public readonly List<StringNode> Nodes = new List<StringNode>();

		public virtual bool AllowOutOfOrderSplit => true;

		public StringContainerNode()
		{
		}

		public StringContainerNode(int startIndex, StringContainerNode parent)
			: this(startIndex, parent, parent.Root)
		{
		}

		public StringContainerNode(int startIndex, StringContainerNode parent, StringRenderTree root)
			: base(startIndex, parent, root)
		{
		}

		public virtual bool IsValidNestedNode(StringContainerNode node)
		{
			return true;
		}

		public abstract StringContainerNode Clone(int startIndex, StringContainerNode parent);

		public override void GetRawString(StringBuilder stringBuilder)
		{
			foreach (StringNode node in Nodes)
			{
				node.GetRawString(stringBuilder);
			}
		}

		public IEnumerator<StringRenderGlyphSegmentNode> GetEnumerator()
		{
			foreach (StringNode node in Nodes)
			{
				if (node is StringRenderGlyphSegmentNode stringRenderGlyphSegmentNode)
				{
					yield return stringRenderGlyphSegmentNode;
				}
				else
				{
					if (!(node is StringContainerNode stringContainerNode))
					{
						continue;
					}
					foreach (StringRenderGlyphSegmentNode item in stringContainerNode)
					{
						yield return item;
					}
				}
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class StringLine : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public float2 Position
		{
			get
			{
				return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Position"), typeof(float2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Position", value);
			}
		}

		public float Ascender
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Ascender"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Ascender", value);
			}
		}

		public float Descender
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Descender"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Descender", value);
			}
		}

		public float LineHeight
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LineHeight"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LineHeight", value);
			}
		}

		public float LineHeightMultiplier
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "LineHeightMultiplier"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "LineHeightMultiplier", value);
			}
		}

		public int StartIndex
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "StartIndex"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "StartIndex", value);
			}
		}

		public int GlyphCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "GlyphCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "GlyphCount", value);
			}
		}

		public TextHorizontalAlignment Alignment
		{
			get
			{
				return (TextHorizontalAlignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Alignment"), typeof(TextHorizontalAlignment));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Alignment", value);
			}
		}

		public float ActualHeight => Descender - Ascender;

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public StringLine(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class StringNode : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public StringContainerNode Parent { get; private set; }

		public StringRenderTree Root { get; private set; }

		public int StartIndex { get; private set; }

		public StringNode()
		{
			if (!(this is StringRenderTree root))
			{
				throw new InvalidOperationException("Cannot use parameterless constructor unless the node is root");
			}
			Parent = null;
			Root = root;
			StartIndex = 0;
		}

		public StringNode(int startIndex, StringContainerNode parent)
			: this(startIndex, parent, parent.Root)
		{
		}

		public StringNode(int startIndex, StringContainerNode parent, StringRenderTree root)
		{
			Parent = parent;
			Root = root;
			StartIndex = startIndex;
		}

		public abstract void GetRawString(StringBuilder str);

		public string GetRawString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			GetRawString(stringBuilder);
			return stringBuilder.ToString();
		}

		public void GetParentNodes<T>(List<T> nodes) where T : class
		{
			Parent?.GetParentNodes(nodes);
			if (this is T item)
			{
				nodes.Add(item);
			}
		}

		public T GetParentNode<T>() where T : class
		{
			if (this is T result)
			{
				return result;
			}
			if (Parent != null)
			{
				return Parent.GetParentNode<T>();
			}
			return null;
		}

		public static ReadOnlySpan<char> ExtractRawParameter(ReadOnlySpan<char> parameter)
		{
			bool quotesRemoved;
			return ExtractRawParameter(parameter, out quotesRemoved);
		}

		public static ReadOnlySpan<char> ExtractRawParameter(ReadOnlySpan<char> parameter, out bool quotesRemoved)
		{
			quotesRemoved = false;
			if (parameter.Length == 0)
			{
				return parameter;
			}
			int i;
			for (i = 0; i < parameter.Length && char.IsWhiteSpace(parameter[i]); i++)
			{
			}
			parameter = parameter.Slice(i);
			if (parameter.Length == 0)
			{
				return parameter;
			}
			if (parameter[0] == '"')
			{
				int j;
				for (j = 1; j < parameter.Length && parameter[j] != '"'; j++)
				{
				}
				if (j == parameter.Length)
				{
					return parameter;
				}
				quotesRemoved = true;
				return parameter.Slice(1, j - 1);
			}
			int k;
			for (k = 1; k < parameter.Length && !char.IsWhiteSpace(parameter[k]); k++)
			{
			}
			if (k == parameter.Length)
			{
				return parameter;
			}
			return parameter.Slice(0, k);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public static class StringParsingHelper
	{
		public static string SanitizeFormatTags(string str)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "StringParsingHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "SanitizeFormatTags", str), typeof(string));
		}
	}
	public class FontSet : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<FontX> Fonts
		{
			get
			{
				return (List<FontX>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Fonts"), typeof(List<FontX>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Fonts", value);
			}
		}

		public FontX MainFont => Fonts[0];

		public FontSet(FontX mainFont)
		{
			Fonts.Add(mainFont);
		}

		public bool GetGlyphByUnicode(uint charcode, out GlyphMetrics metrics, out FontX font)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphByUnicode", charcode, metrics, font), typeof(bool));
		}

		public bool GetGlyphByName(string name, out GlyphMetrics metrics, out uint glyphId, out FontX font)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGlyphByName", name, metrics, glyphId, font), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public FontSet(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public enum AlignmentMode
	{
		Geometric,
		LineBased
	}
	public static class TextRenderHelper
	{
		public static TextHorizontalAlignment GetHorizontalText(this Alignment align)
		{
			return (TextHorizontalAlignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextRenderHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetHorizontalText", align), typeof(TextHorizontalAlignment));
		}

		public static TextVerticalAlignment GetVerticalText(this Alignment align)
		{
			return (TextVerticalAlignment)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextRenderHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetVerticalText", align), typeof(TextVerticalAlignment));
		}
	}
	internal class AnimatedTexture : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public AnimatedTexture(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public interface IBitmap : ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IBitmap<B> : IBitmap, ResoniteBridge.ResoniteBridgeValueHolder where B : IBitmap<B>
	{
		B ConvertTo(TextureFormat format);
	}
	[DataModelType]
	public abstract class Bitmap : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private int _bytesPerPixel;

		protected List<int> mipmapOrigins;

		private static float3x3 LOGLUV_ENCODE_MAT = new float3x3(0.2209f, 0.339f, 0.4184f, 0.1138f, 0.678f, 0.7319f, 0.0102f, 0.113f, 0.2969f);

		public TextureFormat Format { get; private set; }

		public double BitsPerPixel { get; private set; }

		public byte[] RawData { get; private set; }

		public int TotalPixels { get; private set; }

		public int ElementTotalPixels { get; private set; }

		public int ElementTotalBytes { get; private set; }

		public string OriginalFormat { get; private set; }

		public ColorProfile Profile { get; protected set; }

		public bool PreferColor32
		{
			get
			{
				TextureFormat format = Format;
				if ((uint)(format - 16) <= 3u)
				{
					return true;
				}
				return false;
			}
		}

		public bool SupportsAlpha => Format.SupportsAlpha();

		public bool HasMipMaps => MipMapLevels > 1;

		public int MipMapLevels => mipmapOrigins?.Count ?? 1;

		public virtual int ElementCount => 1;

		protected void Init(byte[] data, TextureFormat format, bool mipmaps, string originalFormat, ColorProfile profile)
		{
			Format = format;
			OriginalFormat = originalFormat;
			Profile = profile;
			BitsPerPixel = Format.GetBitsPerPixel();
			_bytesPerPixel = (int)MathX.BitsToBytes(BitsPerPixel);
			if (mipmaps)
			{
				int num = InitMipmapLevels();
				mipmapOrigins = new List<int>();
				int num2 = 0;
				for (int i = 0; i < num; i++)
				{
					mipmapOrigins.Add(num2);
					num2 += MipmapTotalPixels(i);
				}
				TotalPixels = num2;
			}
			else
			{
				TotalPixels = MipmapTotalPixels(0);
			}
			ElementTotalPixels = TotalPixels;
			TotalPixels *= ElementCount;
			int num3 = (int)MathX.BitsToBytes((double)TotalPixels * BitsPerPixel);
			ElementTotalBytes = (int)MathX.BitsToBytes((double)ElementTotalPixels * BitsPerPixel);
			if (data == null)
			{
				RawData = new byte[num3];
				return;
			}
			if (data.Length != num3)
			{
				throw new ArgumentException("Length of data doesn't match texture's parameters. " + $"Expected: {num3}, Got: {data.Length}");
			}
			RawData = data;
		}

		protected abstract int InitMipmapLevels();

		public abstract int MipmapTotalPixels(int mip);

		public abstract int MipmapOrigin(int mip);

		public void ReinterpretProfile(ColorProfile targetProfile)
		{
			Profile = targetProfile;
		}

		public color32 DecodePixel32(int index)
		{
			switch (Format)
			{
				case TextureFormat.Alpha8:
					return new color32(0, 0, 0, RawData[index]);
				case TextureFormat.R8:
					return new color32(RawData[index], 0, 0);
				case TextureFormat.RGB24:
					index *= _bytesPerPixel;
					return new color32(RawData[index], RawData[index + 1], RawData[index + 2]);
				case TextureFormat.ARGB32:
					index *= _bytesPerPixel;
					return new color32(RawData[index + 1], RawData[index + 2], RawData[index + 3], RawData[index]);
				case TextureFormat.BGRA32:
					index *= _bytesPerPixel;
					return new color32(RawData[index + 2], RawData[index + 1], RawData[index], RawData[index + 3]);
				case TextureFormat.RGBA32:
					index *= _bytesPerPixel;
					return new color32(RawData[index], RawData[index + 1], RawData[index + 2], RawData[index + 3]);
				case TextureFormat.RGB565:
				case TextureFormat.RGBAHalf:
				case TextureFormat.ARGBHalf:
				case TextureFormat.RHalf:
				case TextureFormat.RGHalf:
				case TextureFormat.RGBAFloat:
				case TextureFormat.ARGBFloat:
				case TextureFormat.RFloat:
				case TextureFormat.RGFloat:
				{
					color c = DecodePixel(index);
					return (color32)c;
				}
				default:
					throw new Exception($"Reading pixels is not supported for this format: {Format}");
			}
		}

		public color DecodePixel(int index)
		{
			index *= _bytesPerPixel;
			switch (Format)
			{
				case TextureFormat.Alpha8:
					return new color(0f, 0f, 0f, PixelHelper.FromByte(RawData[index]));
				case TextureFormat.R8:
					return new color(PixelHelper.FromByte(RawData[index]), 0f, 0f);
				case TextureFormat.RGB24:
					return new color(PixelHelper.FromByte(RawData[index]), PixelHelper.FromByte(RawData[index + 1]), PixelHelper.FromByte(RawData[index + 2]));
				case TextureFormat.RGB565:
				{
					ushort num = ReadUShort(index);
					return new color((float)(num & 0x1F) / 31f, (float)((num >> 5) & 0x3F) / 63f, (float)((num >> 11) & 0x1F) / 31f);
				}
				case TextureFormat.ARGB32:
					return new color(PixelHelper.FromByte(RawData[index + 1]), PixelHelper.FromByte(RawData[index + 2]), PixelHelper.FromByte(RawData[index + 3]), PixelHelper.FromByte(RawData[index]));
				case TextureFormat.BGRA32:
					return new color(PixelHelper.FromByte(RawData[index + 2]), PixelHelper.FromByte(RawData[index + 1]), PixelHelper.FromByte(RawData[index]), PixelHelper.FromByte(RawData[index + 3]));
				case TextureFormat.RGBA32:
					return new color(PixelHelper.FromByte(RawData[index]), PixelHelper.FromByte(RawData[index + 1]), PixelHelper.FromByte(RawData[index + 2]), PixelHelper.FromByte(RawData[index + 3]));
				case TextureFormat.RGBAHalf:
					return new color(half.ToHalf(ReadUShort(index)), half.ToHalf(ReadUShort(index + 2)), half.ToHalf(ReadUShort(index + 4)), half.ToHalf(ReadUShort(index + 6)));
				case TextureFormat.ARGBHalf:
					return new color(half.ToHalf(ReadUShort(index + 2)), half.ToHalf(ReadUShort(index + 4)), half.ToHalf(ReadUShort(index + 6)), half.ToHalf(ReadUShort(index)));
				case TextureFormat.RGBAFloat:
					return new color(Uint32ToSingle(ReadUint(index)), Uint32ToSingle(ReadUint(index + 4)), Uint32ToSingle(ReadUint(index + 8)), Uint32ToSingle(ReadUint(index + 12)));
				case TextureFormat.ARGBFloat:
					return new color(Uint32ToSingle(ReadUint(index + 4)), Uint32ToSingle(ReadUint(index + 8)), Uint32ToSingle(ReadUint(index + 12)), Uint32ToSingle(ReadUint(index)));
				case TextureFormat.RHalf:
					return new color(half.ToHalf(ReadUShort(index)), 0f, 0f);
				case TextureFormat.RGHalf:
					return new color(half.ToHalf(ReadUShort(index)), half.ToHalf(ReadUShort(index + 2)), 0f);
				case TextureFormat.RFloat:
					return new color(Uint32ToSingle(ReadUint(index)), 0f, 0f);
				case TextureFormat.RGFloat:
					return new color(Uint32ToSingle(ReadUint(index)), Uint32ToSingle(ReadUint(index + 4)), 0f);
				default:
					throw new Exception($"Reading pixels is not supported for this format: {Format}");
			}
		}

		public void EncodePixel(int index, in color color)
		{
			index *= _bytesPerPixel;
			switch (Format)
			{
				case TextureFormat.Alpha8:
					RawData[index] = PixelHelper.ToByte(color.a);
					break;
				case TextureFormat.R8:
					RawData[index] = PixelHelper.ToByte(color.r);
					break;
				case TextureFormat.RGB24:
					RawData[index] = PixelHelper.ToByte(color.r);
					RawData[index + 1] = PixelHelper.ToByte(color.g);
					RawData[index + 2] = PixelHelper.ToByte(color.b);
					break;
				case TextureFormat.RGB565:
					WriteUshort((ushort)(PixelHelper.To5Bits(color.r) | (PixelHelper.To6Bits(color.g) << 5) | (PixelHelper.To5Bits(color.b) << 11)), index);
					break;
				case TextureFormat.ARGB32:
					RawData[index] = PixelHelper.ToByte(color.a);
					RawData[index + 1] = PixelHelper.ToByte(color.r);
					RawData[index + 2] = PixelHelper.ToByte(color.g);
					RawData[index + 3] = PixelHelper.ToByte(color.b);
					break;
				case TextureFormat.BGRA32:
					RawData[index] = PixelHelper.ToByte(color.b);
					RawData[index + 1] = PixelHelper.ToByte(color.g);
					RawData[index + 2] = PixelHelper.ToByte(color.r);
					RawData[index + 3] = PixelHelper.ToByte(color.a);
					break;
				case TextureFormat.RGBA32:
					RawData[index] = PixelHelper.ToByte(color.r);
					RawData[index + 1] = PixelHelper.ToByte(color.g);
					RawData[index + 2] = PixelHelper.ToByte(color.b);
					RawData[index + 3] = PixelHelper.ToByte(color.a);
					break;
				case TextureFormat.RGBAHalf:
					WriteUshort(PixelHelper.ToHalf(color.r), index);
					WriteUshort(PixelHelper.ToHalf(color.g), index + 2);
					WriteUshort(PixelHelper.ToHalf(color.b), index + 4);
					WriteUshort(PixelHelper.ToHalf(color.a), index + 6);
					break;
				case TextureFormat.RGBAFloat:
					WriteUint(SingleToUint32(color.r), index);
					WriteUint(SingleToUint32(color.g), index + 4);
					WriteUint(SingleToUint32(color.b), index + 8);
					WriteUint(SingleToUint32(color.a), index + 12);
					break;
				case TextureFormat.ARGBHalf:
					WriteUshort(PixelHelper.ToHalf(color.a), index);
					WriteUshort(PixelHelper.ToHalf(color.r), index + 2);
					WriteUshort(PixelHelper.ToHalf(color.g), index + 4);
					WriteUshort(PixelHelper.ToHalf(color.b), index + 6);
					break;
				case TextureFormat.ARGBFloat:
					WriteUint(SingleToUint32(color.a), index);
					WriteUint(SingleToUint32(color.r), index + 4);
					WriteUint(SingleToUint32(color.g), index + 8);
					WriteUint(SingleToUint32(color.b), index + 12);
					break;
				case TextureFormat.RHalf:
					WriteUshort(PixelHelper.ToHalf(color.r), index);
					break;
				case TextureFormat.RGHalf:
					WriteUshort(PixelHelper.ToHalf(color.r), index);
					WriteUshort(PixelHelper.ToHalf(color.g), index + 2);
					break;
				case TextureFormat.RFloat:
					WriteUint(SingleToUint32(color.r), index);
					break;
				case TextureFormat.RGFloat:
					WriteUint(SingleToUint32(color.r), index);
					WriteUint(SingleToUint32(color.g), index + 4);
					break;
				default:
					throw new Exception($"Encoding pixels is not supported for this format: {Format}");
			}
		}

		public void EncodePixel32(int index, in color32 color)
		{
			switch (Format)
			{
				case TextureFormat.Alpha8:
					RawData[index] = color.a;
					break;
				case TextureFormat.R8:
					RawData[index] = color.r;
					break;
				case TextureFormat.RGB24:
					index *= _bytesPerPixel;
					RawData[index] = color.r;
					RawData[index + 1] = color.g;
					RawData[index + 2] = color.b;
					break;
				case TextureFormat.ARGB32:
					index *= _bytesPerPixel;
					RawData[index] = color.a;
					RawData[index + 1] = color.r;
					RawData[index + 2] = color.g;
					RawData[index + 3] = color.b;
					break;
				case TextureFormat.BGRA32:
					index *= _bytesPerPixel;
					RawData[index] = color.b;
					RawData[index + 1] = color.g;
					RawData[index + 2] = color.r;
					RawData[index + 3] = color.a;
					break;
				case TextureFormat.RGBA32:
					index *= _bytesPerPixel;
					RawData[index] = color.r;
					RawData[index + 1] = color.g;
					RawData[index + 2] = color.b;
					RawData[index + 3] = color.a;
					break;
				case TextureFormat.RGB565:
				case TextureFormat.RGBAHalf:
				case TextureFormat.ARGBHalf:
				case TextureFormat.RHalf:
				case TextureFormat.RGHalf:
				case TextureFormat.RGBAFloat:
				case TextureFormat.ARGBFloat:
				case TextureFormat.RFloat:
				case TextureFormat.RGFloat:
				{
					int index2 = index;
					color color2 = color;
					EncodePixel(index2, in color2);
					break;
				}
				default:
					throw new Exception($"Encoding pixels is not supported for this format: {Format}");
			}
		}

		public void ForEachPixel(Func<color, color> filter)
		{
			ForEachPixel(0, TotalPixels, filter);
		}

		public void ForEachPixelHSV(Func<ColorHSV, ColorHSV> filter)
		{
			ForEachPixel(delegate(color c)
			{
				ColorHSV arg = new ColorHSV(in c);
				return filter(arg).ToRGB();
			});
		}

		public void ForEachPixel(int mip, Func<color, color> filter)
		{
			for (int i = 0; i < ElementCount; i++)
			{
				int num = i * ElementTotalPixels + MipmapOrigin(mip);
				int to = num + MipmapTotalPixels(mip);
				ForEachPixel(num, to, filter);
			}
		}

		private void ForEachPixel(int from, int to, Func<color, color> filter)
		{
			Parallel.For(from, to, delegate(int i)
			{
				Bitmap bitmap = this;
				color color = filter(DecodePixel(i));
				bitmap.EncodePixel(i, in color);
			});
		}

		private void WriteUint(uint value, int index)
		{
			RawData[index] = (byte)value;
			RawData[index + 1] = (byte)(value >> 8);
			RawData[index + 2] = (byte)(value >> 16);
			RawData[index + 3] = (byte)(value >> 24);
		}

		private void WriteUshort(ushort value, int index)
		{
			RawData[index] = (byte)value;
			RawData[index + 1] = (byte)(value >> 8);
		}

		private uint ReadUint(int index)
		{
			return (uint)(RawData[index] | (RawData[index + 1] << 8) | (RawData[index + 2] << 16) | (RawData[index + 3] << 24));
		}

		private ushort ReadUShort(int index)
		{
			return (ushort)(RawData[index] | (RawData[index + 1] << 8));
		}

		public unsafe static uint SingleToUint32(float value)
		{
			return *(uint*)(&value);
		}

		public unsafe static float Uint32ToSingle(uint value)
		{
			return *(float*)(&value);
		}

		public void Clear(color color)
		{
			EncodePixel(0, in color);
			for (int i = _bytesPerPixel; i < RawData.Length; i++)
			{
				RawData[i] = RawData[i % _bytesPerPixel];
			}
		}

		public void InvertColors()
		{
			ForEachPixel(delegate(color c)
			{
				float3 v = c.rgb;
				float3 rgb = 1 - v;
				return new color(in rgb, c.a);
			});
		}

		public void InvertAlpha()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rgb;
				return new color(in rgb, 1f - c.a);
			});
		}

		public void Normalize(bool rgbIndependently = false, bool normalizeAlpha = false, bool normalizeMinValue = false)
		{
			float4 min = float4.MaxValue;
			float4 a = float4.MinValue;
			for (int i = 0; i < TotalPixels; i++)
			{
				color c2 = DecodePixel(i);
				float4 b = c2;
				min = MathX.Min(in min, in b);
				a = MathX.Max(in a, in b);
			}
			if (!normalizeMinValue)
			{
				min = default(float4);
			}
			if (!rgbIndependently)
			{
				float3 v = min.xyz;
				float num = MathX.MinComponent(in v);
				v = a.xyz;
				float num2 = MathX.MaxComponent(in v);
				min = new float4(num, num, num, min.w);
				a = new float4(num2, num2, num2, a.w);
			}
			float4 v2 = a - min;
			bool4 a2 = v2 != 0f;
			bool4 b2 = new bool4(x: true, y: true, z: true, normalizeAlpha);
			bool4 mask = a2 & b2;
			float4 mod = (1f / v2).Mask(mask, 1f);
			min = min.Mask(mask);
			ForEachPixel(delegate(color c)
			{
				float4 a3 = c;
				float4 a4 = a3 - min;
				float4 v3 = a4 * mod;
				return v3;
			});
		}

		public bool HasTransparentPixels(float threshold = 1f)
		{
			if (!SupportsAlpha)
			{
				return false;
			}
			bool foundAlpha = false;
			Parallel.For(0, TotalPixels, delegate(int i, ParallelLoopState state)
			{
				if (DecodePixel(i).a < threshold)
				{
					foundAlpha = true;
					state.Break();
				}
			});
			return foundAlpha;
		}

		public colorX AverageColor(bool inLinearSpace = true)
		{
			color a = default(color);
			for (int i = 0; i < TotalPixels; i++)
			{
				color color = DecodePixel(i);
				if (inLinearSpace)
				{
					color = color.ConvertProfile(Profile, ColorProfile.Linear);
				}
				a += color;
			}
			color color2 = a / (float)TotalPixels;
			if (inLinearSpace)
			{
				color2 = color2.ConvertProfile(ColorProfile.Linear, Profile);
			}
			return new colorX(color2, Profile);
		}

		public colorX AverageColor(Predicate<color> filter, bool inLinearSpace = true)
		{
			color a = default(color);
			int num = 0;
			for (int i = 0; i < TotalPixels; i++)
			{
				color color = DecodePixel(i);
				if (filter == null || filter(color))
				{
					if (inLinearSpace)
					{
						color = color.ConvertProfile(Profile, ColorProfile.Linear);
					}
					a += color;
					num++;
				}
			}
			color color2 = a / (float)num;
			if (inLinearSpace)
			{
				color2 = color2.ConvertProfile(ColorProfile.Linear, Profile);
			}
			return new colorX(color2, Profile);
		}

		public void FillFrom(Bitmap source)
		{
			int count = MathX.Min(source.TotalPixels, TotalPixels);
			CopyPixelsFrom(source, 0, 0, count);
		}

		public void FillFromMipMap(Bitmap2D source, int sourceMip, int targetMip = 0)
		{
			int sourceStart = source.MipmapOrigin(sourceMip);
			int destStart = MipmapOrigin(targetMip);
			int count = source.MipmapTotalPixels(sourceMip);
			CopyPixelsFrom(source, sourceStart, destStart, count);
		}

		public void CopyPixelsFrom(Bitmap source, int sourceStart, int destStart, int count)
		{
			if (Format == source.Format)
			{
				int sourceIndex = (int)MathX.BitsToBytes((double)sourceStart * BitsPerPixel);
				int destinationIndex = (int)MathX.BitsToBytes((double)destStart * BitsPerPixel);
				int length = (int)MathX.BitsToBytes((double)count * BitsPerPixel);
				Array.Copy(source.RawData, sourceIndex, RawData, destinationIndex, length);
			}
			else if (PreferColor32)
			{
				Parallel.For(0, count, delegate(int i)
				{
					Bitmap bitmap2 = this;
					int index2 = i + destStart;
					color32 color2 = source.DecodePixel32(i + sourceStart);
					bitmap2.EncodePixel32(index2, in color2);
				});
			}
			else
			{
				Parallel.For(0, count, delegate(int i)
				{
					Bitmap bitmap = this;
					int index = i + destStart;
					color color = source.DecodePixel(i + sourceStart);
					bitmap.EncodePixel(index, in color);
				});
			}
		}

		public void InvertRGB()
		{
			ForEachPixel(delegate(color c)
			{
				float3 v = c.rgb;
				float3 rgb = 1 - v;
				return new color(in rgb, c.a);
			});
		}

		public void InvertR()
		{
			ForEachPixel(delegate(color c)
			{
				float r = 1f - c.r;
				float3 gba = c.gba;
				return new color(r, in gba);
			});
		}

		public void InvertG()
		{
			ForEachPixel((color c) => new color(c.r, 1f - c.g, c.b, c.a));
		}

		public void InvertB()
		{
			ForEachPixel(delegate(color c)
			{
				float2 rg = c.rg;
				return new color(in rg, 1f - c.b, c.a);
			});
		}

		public void InvertA()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rgb;
				return new color(in rgb, 1f - c.a);
			});
		}

		public void ColorToAlpha(color fillColor)
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = fillColor.rgb;
				return new color(in rgb, c.Luminance);
			});
		}

		public void AlphaFromIntensity()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rgb;
				float3 v = c.rgb;
				return new color(in rgb, MathX.MaxComponent(in v));
			});
		}

		public void AlphaToMask()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.aaa;
				return new color(in rgb);
			});
		}

		public void RemoveAlpha()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rgb;
				return new color(in rgb);
			});
		}

		public void GrayscaleAverage()
		{
			ForEachPixel(delegate(color c)
			{
				float3 v = c.rgb;
				return new color(MathX.AvgComponent(in v), c.a);
			});
		}

		public void GrayscaleLuminance()
		{
			ForEachPixel((color c) => new color(c.Luminance, c.a));
		}

		public void SwapRG()
		{
			ForEachPixel(delegate(color c)
			{
				float2 rg = c.gb;
				float2 ba = c.ba;
				return new color(in rg, in ba);
			});
		}

		public void SwapRB()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.bgr;
				return new color(in rgb, c.a);
			});
		}

		public void SwapRA()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.agb;
				return new color(in rgb, c.r);
			});
		}

		public void SwapGB()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rbg;
				return new color(in rgb, c.a);
			});
		}

		public void SwapGA()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rab;
				return new color(in rgb, c.g);
			});
		}

		public void SwapBA()
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rga;
				return new color(in rgb, c.b);
			});
		}

		public void AddBackground(color bgColor)
		{
			ForEachPixel((color c) => color.AlphaBlend(c, bgColor));
		}

		public void AdjustGamma(float gamma)
		{
			ForEachPixel(delegate(color c)
			{
				float3 v = c.rgb;
				float3 rgb = MathX.Pow(in v, gamma);
				return new color(in rgb, c.a);
			});
		}

		public void AdjustAlphaGamma(float gamma)
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rgb;
				return new color(in rgb, MathX.Pow(c.a, gamma));
			});
		}

		public void ShiftHue(float offset)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(MathX.Frac(c.h + offset), c.s, c.v, c.a));
		}

		public void SetHue(float hue)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(hue, c.s, c.v, c.a));
		}

		public void SetSaturation(float saturation)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(c.h, saturation, c.v, c.a));
		}

		public void OffsetSaturation(float offset)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(c.h, MathX.Clamp01(c.s + offset), c.v, c.a));
		}

		public void MulSaturation(float ratio)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(c.h, MathX.Clamp01(c.s * ratio), c.v, c.a));
		}

		public void SetValue(float value)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(c.h, c.s, value, c.a));
		}

		public void MulValue(float ratio)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(c.h, c.s, c.v * ratio, c.a));
		}

		public void OffsetValue(float offset)
		{
			ForEachPixelHSV((ColorHSV c) => new ColorHSV(c.h, c.s, c.v + offset, c.a));
		}

		public void OffsetAlpha(float offset)
		{
			ForEachPixel(delegate(color c)
			{
				float3 rgb = c.rgb;
				return new color(in rgb, MathX.Clamp01(c.a + offset));
			});
		}

		public virtual void ConvertToProfile(ColorProfile targetProfile)
		{
			if (Profile != targetProfile)
			{
				ForEachPixel((color c) => c.ConvertProfile(Profile, targetProfile));
				Profile = targetProfile;
			}
		}

		public virtual void ConvertTosRGB()
		{
			ForEachPixel((color c) => c.ConvertProfile(ColorProfile.sRGB, ColorProfile.Linear));
		}

		public virtual void ConvertHDRToHDRsRGB()
		{
			ForEachPixel(delegate(color c)
			{
				if (c.r <= 1f && c.g <= 1f && c.b <= 1f)
				{
					c = c.ConvertProfile(ColorProfile.sRGB, ColorProfile.Linear);
				}
				else
				{
					if (c.r > 1f)
					{
						c = c.SetR(MathX.Pow(c.r, 0.45454544f));
					}
					if (c.g > 1f)
					{
						c = c.SetG(MathX.Pow(c.g, 0.45454544f));
					}
					if (c.b > 1f)
					{
						c = c.SetB(MathX.Pow(c.r, 0.45454544f));
					}
				}
				return c;
			});
		}

		public void PackNormalMap()
		{
			ForEachPixel((color c) => new color(1f, c.g, c.g, c.r));
		}

		public void EncodeLogLUV()
		{
			ForEachPixel(delegate(color c)
			{
				float3 v = c.rgb;
				float3 a = LOGLUV_ENCODE_MAT * v;
				v = new float3(1E-06f, 1E-06f, 1E-06f);
				a = MathX.Max(in a, in v);
				float2 v2 = a.xy;
				float2 @float = v2 / a.z;
				float num = 2f * MathX.Log(a.y) + 127f;
				float num2 = MathX.Frac(num);
				float b = (num - MathX.Floor(num2 * 255f) / 255f) / 255f;
				return new color(@float.x, @float.y, b, num2);
			});
		}

		public void EncodeRGBM()
		{
			ForEachPixel(delegate(color c)
			{
				float4 @float = default(float4);
				float3 v = c.rgb;
				_ = v * (1f / 6f);
				@float = @float.SetComponent(MathX.Clamp01(MathX.Max(MathX.Max(c.r, c.g), MathX.Max(c.b, 1E-06f))), 3);
				color c2 = c / @float.SetComponent(MathX.Ceil(@float.w * 255f) / 255f, 3).w;
				@float = c2;
				return @float;
			});
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[DataModelType]
	public enum WrapMode
	{
		Clamp,
		Repeat
	}
	[DataModelType]
	public enum TextureSize
	{
		NPOT,
		LowestPOT,
		NearestPOT,
		HighestPOT
	}
	public class Bitmap2D : Bitmap2DBase, IBitmap<Bitmap2D>, IBitmap, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int RAW_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RAW_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RAW_VERSION", value);
			}
		}

		public string MAGIC_STRING
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAGIC_STRING"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAGIC_STRING", value);
			}
		}

		public color this[int x, int y]
		{
			get
			{
				return GetPixel(x, y);
			}
			set
			{
				SetPixel(x, y, in value);
			}
		}

		public color this[float x, float y] => GetPixelBilinear(x, y);

		public color this[int2 point]
		{
			get
			{
				return GetPixel(point.x, point.y);
			}
			set
			{
				SetPixel(point.x, point.y, in value);
			}
		}

		public color this[float2 point] => GetPixelBilinear(point.x, point.y);

		public Bitmap2D(byte[] data, int width, int height, TextureFormat format, bool mipmaps, ColorProfile profile, bool flipY = true, string originalFormat = null)
		{
			InitSize(new int2(width, height), flipY, format);
			Init(data, format, mipmaps, originalFormat, profile);
		}

		public Bitmap2D(int width, int height, TextureFormat format, bool mipmaps, ColorProfile profile, bool flipY = true, string originalFormat = null)
			: this(null, width, height, format, mipmaps, profile, flipY, originalFormat)
		{
		}

		public float2 PixelToUV(int x, int y)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PixelToUV", x, y), typeof(float2));
		}

		public float2 PixelToUV(in int2 point)
		{
			return (float2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PixelToUV", point), typeof(float2));
		}

		public int2 UVToPixel(in float2 uv)
		{
			return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UVToPixel", uv), typeof(int2));
		}

		public color SampleUV(in float2 uv, WrapMode wrap = WrapMode.Clamp, int mipLevel = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SampleUV", uv, wrap, mipLevel), typeof(color));
		}

		public color GetPixelBilinear(float x, float y, WrapMode wrap = WrapMode.Clamp, int mipLevel = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixelBilinear", x, y, wrap, mipLevel), typeof(color));
		}

		public color GetPixel(int x, int y, int mipLevel = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixel", x, y, mipLevel), typeof(color));
		}

		public color32 GetPixel32(int x, int y, int mipLevel = 0)
		{
			return (color32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixel32", x, y, mipLevel), typeof(color32));
		}

		public void SetPixel(int x, int y, in color color, int mipLevel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPixel", x, y, color, mipLevel);
		}

		public void SetPixel32(int x, int y, in color32 color, int mipLevel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPixel32", x, y, color, mipLevel);
		}

		public bool VerifyRegion(int x, int y, int width, int height, int mip = 0)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "VerifyRegion", x, y, width, height, mip), typeof(bool));
		}

		public void GetMipMapBuffers(List<Memory<byte>> mipbuffers)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMipMapBuffers", mipbuffers);
		}

		public void GetMipMapBuffers(List<MipMapBuffer> mipbuffers)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMipMapBuffers", mipbuffers);
		}

		private void CheckRegion(int x, int y, int width, int height, int mip)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckRegion", x, y, width, height, mip);
		}

		public static int ComputeTotalPixels(in int2 size, bool mipmaps)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeTotalPixels", size, mipmaps), typeof(int));
		}

		public Bitmap2D ExtractMipMap(int mip, bool includeLowerMips = false)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractMipMap", mip, includeLowerMips), typeof(Bitmap2D));
		}

		public Bitmap2D ConvertTo(TextureFormat format)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertTo", format), typeof(Bitmap2D));
		}

		public void FillFrom(BitmapCube cubemap, BitmapCube.Face face, int miplevel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillFrom", cubemap, face, miplevel);
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public void Fill(int x, int y, int width, int height, color color, int mip = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Fill", x, y, width, height, color, mip);
		}

		public static Bitmap2D Load(string file, bool? generateMipmaps, AlphaHandling alphaHandling = AlphaHandling.KeepOriginal, int maxSize = int.MaxValue, float sizeRatio = 1f)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "Load", file, generateMipmaps, alphaHandling, maxSize, sizeRatio), typeof(Bitmap2D));
		}

		public static Bitmap2D Load(Stream stream, string extension, bool? generateMipmaps, AlphaHandling alphaHandling = AlphaHandling.KeepOriginal, int maxSize = int.MaxValue, float sizeRatio = 1f)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "Load", stream, extension, generateMipmaps, alphaHandling, maxSize, sizeRatio), typeof(Bitmap2D));
		}

		public static Bitmap2D LoadRaw(string file)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadRaw", file), typeof(Bitmap2D));
		}

		public static Bitmap2D LoadRaw(Stream stream)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadRaw", stream), typeof(Bitmap2D));
		}

		public void SaveRaw(string file, RawBitmapEncoding encoding = RawBitmapEncoding.LZMA)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveRaw", file, encoding);
		}

		public void SaveRaw(Stream stream, RawBitmapEncoding encoding = RawBitmapEncoding.LZMA)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveRaw", stream, encoding);
		}

		public bool Save(string file, int quality = 85, bool preserveColorInAlpha = true)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Save", file, quality, preserveColorInAlpha), typeof(bool));
		}

		public bool Save(Stream stream, string extension, int quality = 85, bool preserveColorInAlpha = true)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Save", stream, extension, quality, preserveColorInAlpha), typeof(bool));
		}

		public FIBITMAP ToFreeImage()
		{
			return (FIBITMAP)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToFreeImage"), typeof(FIBITMAP));
		}

		public FIBITMAP ToFreeImage(IntRect region, int sourceMip = 0)
		{
			return (FIBITMAP)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToFreeImage", region, sourceMip), typeof(FIBITMAP));
		}

		public color GetPixelBoxClamp(int x, int y, int mip = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixelBoxClamp", x, y, mip), typeof(color));
		}

		public color GetPixelBoxRepeat(int x, int y, int mip = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixelBoxRepeat", x, y, mip), typeof(color));
		}

		public void GenerateMipmapsBox()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateMipmapsBox");
		}

		public void GenerateMipmapLevelBox(int mip)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateMipmapLevelBox", mip);
		}

		public void GenerateMipMapForRegion(IntRect region, Filtering filtering)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateMipMapForRegion", region, filtering);
		}

		public Bitmap2D GetRescaled(int longestSize, bool? mipmaps = null, bool forceRescale = false, Filtering filtering = Filtering.Box)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRescaled", longestSize, mipmaps, forceRescale, filtering), typeof(Bitmap2D));
		}

		public Bitmap2D GetRescaled(int width, int height, bool? mipmaps = null, bool forceRescale = false, Filtering filtering = Filtering.Box)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRescaled", width, height, mipmaps, forceRescale, filtering), typeof(Bitmap2D));
		}

		public Bitmap2D GetRescaled(int2 size, bool? mipmaps = null, bool forceRescale = false, Filtering filtering = Filtering.Box)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRescaled", size, mipmaps, forceRescale, filtering), typeof(Bitmap2D));
		}

		public Bitmap2D GetRescaled(IntRect region, int sourceMip, int2 size, bool? mipmaps = null, bool forceRescale = false, Filtering filtering = Filtering.Box)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRescaled", region, sourceMip, size, mipmaps, forceRescale, filtering), typeof(Bitmap2D));
		}

		public Bitmap2D Crop(Rect rect)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Crop", rect), typeof(Bitmap2D));
		}

		public Bitmap2D Crop(int2 position, int2 size)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Crop", position, size), typeof(Bitmap2D));
		}

		public Bitmap2D Crop(int x, int y, int width, int height)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Crop", x, y, width, height), typeof(Bitmap2D));
		}

		public Bitmap2D CropCenter(int2 newSize)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CropCenter", newSize), typeof(Bitmap2D));
		}

		public Bitmap2D CropSquareCenter()
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CropSquareCenter"), typeof(Bitmap2D));
		}

		public Bitmap2D CropAspectRatioCenter(float2 ratio)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CropAspectRatioCenter", ratio), typeof(Bitmap2D));
		}

		public Bitmap2D CropAspectRatioCenter(float ratio)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CropAspectRatioCenter", ratio), typeof(Bitmap2D));
		}

		public void CopyFrom(Bitmap2D source, int sourceX, int sourceY, int destX, int destY, int width, int height)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", source, sourceX, sourceY, destX, destY, width, height);
		}

		public Bitmap2D MakeSquare()
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MakeSquare"), typeof(Bitmap2D));
		}

		public void FindForegroundRegion(color backgroundColor, out int2 position, out int2 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FindForegroundRegion", backgroundColor, position, size);
		}

		public void FindForegroundRegion(color32 backgroundColor, out int2 position, out int2 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FindForegroundRegion", backgroundColor, position, size);
		}

		public void FindForegroundRegion(Pixel2DPredicate isForeground, out int2 position, out int2 size)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FindForegroundRegion", isForeground, position, size);
		}

		public Bitmap2D Trim(Pixel2DPredicate isForeground)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Trim", isForeground), typeof(Bitmap2D));
		}

		public Bitmap2D Trim(color c)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Trim", c), typeof(Bitmap2D));
		}

		public Bitmap2D Trim(color32 c)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Trim", c), typeof(Bitmap2D));
		}

		public Bitmap2D TrimTransparent()
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimTransparent"), typeof(Bitmap2D));
		}

		public Bitmap2D TrimByCornerColor()
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TrimByCornerColor"), typeof(Bitmap2D));
		}

		public Bitmap2D Pad(int2 targetSize, bool? overrideMipmaps = null)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Pad", targetSize, overrideMipmaps), typeof(Bitmap2D));
		}

		public void AlphaBlend(Bitmap2D other)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AlphaBlend", other);
		}

		public void AdditiveBlend(Bitmap2D other)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AdditiveBlend", other);
		}

		public void MultiplyBlend(Bitmap2D other)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MultiplyBlend", other);
		}

		public void ApplyMask(Bitmap2D mask)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ApplyMask", mask);
		}

		public void CustomBlend(Bitmap2D other, Func<color, color, color> blendFunction)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CustomBlend", other, blendFunction);
		}

		public void FlipHorizontal()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FlipHorizontal");
		}

		public void FlipVertical()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FlipVertical");
		}

		public void FlipYInMemory()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FlipYInMemory");
		}

		public Bitmap2D Rotate90CW()
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Rotate90CW"), typeof(Bitmap2D));
		}

		public Bitmap2D Rotate90CCW()
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Rotate90CCW"), typeof(Bitmap2D));
		}

		public Bitmap2D Rotate180()
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Rotate180"), typeof(Bitmap2D));
		}

		public Bitmap2D RemapPositions(int2 newSize, Func<int2, int2, int2> remappingFunction)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RemapPositions", newSize, remappingFunction), typeof(Bitmap2D));
		}

		public void ForEachPixel(Func<color, color> filter, IntRect rect, int miplevel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForEachPixel", filter, rect, miplevel);
		}

		public void ForEachPixelUV(Func<float2, color> generator)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForEachPixelUV", generator);
		}

		public Bitmap2D GenerateTileableLoop(float2 transitionRatio)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateTileableLoop", transitionRatio), typeof(Bitmap2D));
		}

		public Bitmap2D GenerateTileableMirrored(float2 transitionRatio)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateTileableMirrored", transitionRatio), typeof(Bitmap2D));
		}

		public void BleedColorToAlpha()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BleedColorToAlpha");
		}

		public color? AverageRGBFromVisibleSurroundings(int x, int y, Bit2DArray overrides = null)
		{
			return (color?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AverageRGBFromVisibleSurroundings", x, y, overrides), typeof(color?));
		}

		public static bool SupportsBlockCompression(TextureFormat targetFormat)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportsBlockCompression", targetFormat), typeof(bool));
		}

		public Bitmap2D BlockCompress(TextureFormat targetFormat, float quality = 0.5f, int maxThreads = 0)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BlockCompress", targetFormat, quality, maxThreads), typeof(Bitmap2D));
		}

		public bool CrunchCompress(string file, TextureFormat targetFormat, bool normalMap, bool perceptual, int maxThreads = -1)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CrunchCompress", file, targetFormat, normalMap, perceptual, maxThreads), typeof(bool));
		}

		public static Bitmap2D LoadCRN(string file)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadCRN", file), typeof(Bitmap2D));
		}

		public static Bitmap2D LoadCRN(Stream stream)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap2D", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadCRN", stream), typeof(Bitmap2D));
		}

		public void DrawPixelSquare(IntRect rect, color color, bool dotted = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DrawPixelSquare", rect, color, dotted);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Bitmap2D(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public abstract class Bitmap2DBase : Bitmap, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private int2 _size;

		private float2 _pixelToUV;

		private float2 _uvToPixel;

		protected List<int2> mipmapSizes;

		public int2 Size
		{
			get
			{
				return _size;
			}
			protected set
			{
				_size = value;
				int2 v = _size - 1;
				_uvToPixel = v;
				_pixelToUV = 1f / _uvToPixel;
			}
		}

		public int2 AlignedSize { get; protected set; }

		public bool FlipY { get; protected set; }

		public float2 PixelToUVRatio => _pixelToUV;

		public float2 UVToPixelRatio => _uvToPixel;

		protected void InitSize(int2 size, bool flipY, TextureFormat format)
		{
			Size = size;
			int2 size2 = Size;
			AlignedSize = AlignSize(in size2, format);
			FlipY = flipY;
		}

		public int PixelStart(int x, int y, int mip)
		{
			if (mip == 0)
			{
				if (FlipY)
				{
					y = AlignedSize.y - y - 1;
				}
				return x + y * AlignedSize.x;
			}
			int2 @int = mipmapSizes[mip];
			int num = mipmapOrigins[mip];
			if (FlipY)
			{
				y = @int.y - y - 1;
			}
			return num + (x + y * @int.x);
		}

		public int MipmapByteOrigin(int mip)
		{
			return (int)MathX.BitsToBytes((double)MipmapOrigin(mip) * base.BitsPerPixel);
		}

		public int MipmapTotalBytes(int mip)
		{
			return (int)MathX.BitsToBytes((double)MipmapTotalPixels(mip) * base.BitsPerPixel);
		}

		public override int MipmapOrigin(int mip)
		{
			if (mip != 0)
			{
				return mipmapOrigins[mip];
			}
			return 0;
		}

		protected void GetMipMapBuffers(List<Memory<byte>> mipBuffers, int offset)
		{
			for (int i = 0; i < base.MipMapLevels; i++)
			{
				int start = offset + MipmapByteOrigin(i);
				int length = MipmapTotalBytes(i);
				MipMapSize(i);
				Memory<byte> item = new Memory<byte>(base.RawData, start, length);
				mipBuffers.Add(item);
			}
		}

		protected void GetMipMapBuffers(List<MipMapBuffer> mipBuffers, int offset, int face)
		{
			for (int i = 0; i < base.MipMapLevels; i++)
			{
				int start = offset + MipmapByteOrigin(i);
				int length = MipmapTotalBytes(i);
				int2 size = MipMapSize(i);
				Memory<byte> buffer = new Memory<byte>(base.RawData, start, length);
				mipBuffers.Add(new MipMapBuffer(size, face, buffer));
			}
		}

		protected override int InitMipmapLevels()
		{
			mipmapSizes = new List<int2>();
			int2 size = Size;
			MipmapLevels(in size, mipmapSizes);
			return mipmapSizes.Count;
		}

		public override int MipmapTotalPixels(int mip)
		{
			int2 size = ((mip == 0) ? Size : mipmapSizes[mip]);
			size = AlignSize(in size, base.Format);
			return size.x * size.y;
		}

		public int2 MipMapSize(int mip)
		{
			if (mip != 0)
			{
				return mipmapSizes[mip];
			}
			return AlignedSize;
		}

		public static bool IsSizeAligned(in int2 size, TextureFormat format)
		{
			int2 @int = format.BlockSize();
			if (size.x % @int.x != 0 || size.y % @int.y != 0)
			{
				return false;
			}
			return true;
		}

		public static int2 AlignSize(in int2 size, TextureFormat format)
		{
			int2 a = format.BlockSize();
			int2 b = size % a;
			int2 a2 = a - b;
			int2 b2 = a2 % a;
			return size + b2;
		}

		public static int MipmapLevelCount(int2 size)
		{
			int num = 1;
			while (size.x > 1 || size.y > 1)
			{
				num++;
				size /= 2;
			}
			return num;
		}

		public static int MipmapLevels(in int2 size, List<int2> sizes)
		{
			if (size.x > 1 || size.y > 1)
			{
				int num = size.x * size.y;
				sizes?.Add(size);
				int2 a = size / 2;
				int2 size2 = MathX.Max(in a, 1);
				return num + MipmapLevels(in size2, sizes);
			}
			sizes?.Add(int2.One);
			return 1;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public enum RawBitmapEncoding
	{
		Uncompressed,
		LZMA
	}
	public delegate bool Pixel2DPredicate(Bitmap2D bitmap, int x, int y);
	internal enum LegacyTextureFormat
	{
		Unknown,
		RGB24,
		ARGB32,
		RGBA32,
		BGRA32,
		RGBAHalf,
		RGBAFloat
	}
	internal static class LegacyHelper
	{
		public static TextureFormat ConvertLegacyFormat(this LegacyTextureFormat format)
		{
			return (TextureFormat)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "LegacyHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertLegacyFormat", format), typeof(TextureFormat));
		}
	}
	public class Bitmap3D : Bitmap, IBitmap<Bitmap3D>, IBitmap, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum Encoding
		{
			Raw,
			Quantized8Bit
		}

		public int BITMAP3D_BINARY_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "BITMAP3D_BINARY_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "BITMAP3D_BINARY_VERSION", value);
			}
		}

		public string MAGIC_STRING
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAGIC_STRING"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAGIC_STRING", value);
			}
		}

		private List<int3> mipmapSizes
		{
			get
			{
				return (List<int3>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "mipmapSizes"), typeof(List<int3>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "mipmapSizes", value);
			}
		}

		public int3 Size
		{
			get
			{
				return (int3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Size"), typeof(int3));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Size", value);
			}
		}

		public color this[int3 pos]
		{
			get
			{
				return GetPixel(pos.x, pos.y, pos.z);
			}
			set
			{
				SetPixel(pos.x, pos.y, pos.z, in value);
			}
		}

		public color this[int x, int y, int z]
		{
			get
			{
				return GetPixel(x, y, z);
			}
			set
			{
				SetPixel(x, y, z, in value);
			}
		}

		public Bitmap3D(int width, int height, int depth, TextureFormat format, bool mipmaps, ColorProfile profile, string originalFormat = null)
			: this(null, width, height, depth, format, mipmaps, profile, originalFormat)
		{
		}

		public Bitmap3D(byte[] data, int width, int height, int depth, TextureFormat format, bool mipmaps, ColorProfile profile, string originalFormat = null)
		{
			Size = new int3(width, height, depth);
			Init(data, format, mipmaps, originalFormat, profile);
		}

		public color GetPixel(int x, int y, int z, int mip = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixel", x, y, z, mip), typeof(color));
		}

		public color GetPixel32(int x, int y, int z, int mip = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixel32", x, y, z, mip), typeof(color));
		}

		public void SetPixel(int x, int y, int z, in color color, int mip = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPixel", x, y, z, color, mip);
		}

		public color SampleUVW(in float3 uvw)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SampleUVW", uvw), typeof(color));
		}

		public color GetPixelBilinear(float x, float y, float z)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixelBilinear", x, y, z), typeof(color));
		}

		public color GetPixelBilinear(in float3 position)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixelBilinear", position), typeof(color));
		}

		private color SampleBilinearLayer(in int3 pos, in float2 ratio)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SampleBilinearLayer", pos, ratio), typeof(color));
		}

		protected override int InitMipmapLevels()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InitMipmapLevels"), typeof(int));
		}

		public override int MipmapTotalPixels(int mip)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MipmapTotalPixels", mip), typeof(int));
		}

		public override int MipmapOrigin(int mip)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MipmapOrigin", mip), typeof(int));
		}

		public int3 MipMapSize(int mip)
		{
			return (int3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MipMapSize", mip), typeof(int3));
		}

		private int PixelStart(int x, int y, int z, int mip)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PixelStart", x, y, z, mip), typeof(int));
		}

		public static int MipmapLevels(in int3 size, List<int3> sizes)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "MipmapLevels", size, sizes), typeof(int));
		}

		public static int3 AlignSize(in int3 size, TextureFormat format)
		{
			return (int3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "AlignSize", size, format), typeof(int3));
		}

		public Bitmap3D ConvertTo(TextureFormat format)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertTo", format), typeof(Bitmap3D));
		}

		public void ForEachPixelUVW(Func<float3, color> filter)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ForEachPixelUVW", filter);
		}

		public void Encode(Stream stream)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Encode", stream);
		}

		private static Bitmap3D Decode(Stream stream)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", stream), typeof(Bitmap3D));
		}

		public void Save(string file)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Save", file);
		}

		public static Bitmap3D Load(string file)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "Load", file), typeof(Bitmap3D));
		}

		public static Bitmap3D LoadFromCUBE(string file)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadFromCUBE", file), typeof(Bitmap3D));
		}

		public void SaveToCUBE(string file, string title = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveToCUBE", file, title);
		}

		public static Bitmap3D CreateFromSlices(List<string> paths, TextureFormat format, TextureSize sizehandling)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateFromSlices", paths, format, sizehandling), typeof(Bitmap3D));
		}

		public static Bitmap3D CreateFromSlices(List<Bitmap2D> slices, TextureFormat format, TextureSize sizehandling)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateFromSlices", slices, format, sizehandling), typeof(Bitmap3D));
		}

		private static Bitmap3D CreateFromSlices(SliceAccessor slices, TextureFormat format, TextureSize sizeHandling)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateFromSlices", slices, format, sizeHandling), typeof(Bitmap3D));
		}

		public void FillFromSlices(List<Bitmap2D> slices, bool scale)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillFromSlices", slices, scale);
		}

		public void FillFromSlices(List<string> paths, bool scale)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillFromSlices", paths, scale);
		}

		private void FillFromSlices(SliceAccessor slices, bool scale)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillFromSlices", slices, scale);
		}

		private static color SampleSlices(SliceAccessor slices, float3 uvw)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Bitmap3D", ResoniteBridge.ResoniteBridgeValueType.Type), "SampleSlices", slices, uvw), typeof(color));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Bitmap3D(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct MipMapBuffer : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int2 size
		{
			get
			{
				return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "size"), typeof(int2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "size", value);
			}
		}

		public int face
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "face"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "face", value);
			}
		}

		public Memory<byte> buffer
		{
			get
			{
				return (Memory<byte>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "buffer"), typeof(Memory<byte>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "buffer", value);
			}
		}

		public MipMapBuffer(int2 size, int face, Memory<byte> buffer)
		{
			this.size = size;
			this.face = face;
			this.buffer = buffer;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MipMapBuffer(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class BitmapBlockCompression
	{
		public static bool SupportsBlockCompression(TextureFormat targetFormat)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapBlockCompression", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportsBlockCompression", targetFormat), typeof(bool));
		}

		public static bool NeedsToConvertForBlockCompression(ref TextureFormat sourceFormat, TextureFormat targetFormat)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapBlockCompression", ResoniteBridge.ResoniteBridgeValueType.Type), "NeedsToConvertForBlockCompression", sourceFormat, targetFormat), typeof(bool));
		}

		public unsafe static void BlockCompress(List<MipMapBuffer> sourceBuffers, List<MipMapBuffer> targetBuffers, TextureFormat sourceFormat, TextureFormat targetFormat, float quality = 0.5f, int maxThreads = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapBlockCompression", ResoniteBridge.ResoniteBridgeValueType.Type), "BlockCompress", sourceBuffers, targetBuffers, sourceFormat, targetFormat, quality, maxThreads);
		}

		private static CMP_FORMAT ToCompressonator(TextureFormat format)
		{
			return (CMP_FORMAT)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapBlockCompression", ResoniteBridge.ResoniteBridgeValueType.Type), "ToCompressonator", format), typeof(CMP_FORMAT));
		}
	}
	public class BitmapCube : Bitmap2DBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum Face
		{
			PosX,
			NegX,
			PosY,
			NegY,
			PosZ,
			NegZ
		}

		public int CUBEMAP_BINARY_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CUBEMAP_BINARY_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CUBEMAP_BINARY_VERSION", value);
			}
		}

		public string MAGIC_STRING
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAGIC_STRING"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAGIC_STRING", value);
			}
		}

		public override int ElementCount => 6;

		public color this[int x, int y, Face face]
		{
			get
			{
				return GetPixel(x, y, face);
			}
			set
			{
				SetPixel(x, y, face, value);
			}
		}

		public color this[int2 point, Face face] => this[point.x, point.y, face];

		public BitmapCube(byte[] data, int width, int height, TextureFormat format, bool mipmaps, ColorProfile profile, string originalFormat = null)
		{
			InitSize(new int2(width, height), flipY: false, format);
			Init(data, format, mipmaps, originalFormat, profile);
		}

		public BitmapCube(int width, int height, TextureFormat format, bool mipmaps, ColorProfile profile, string originalFormat = null)
			: this(null, width, height, format, mipmaps, profile, originalFormat)
		{
		}

		public BitmapCube(Bitmap2D posX, Bitmap2D negX, Bitmap2D posY, Bitmap2D negY, Bitmap2D posZ, Bitmap2D negZ)
		{
			int2 a = int2.One;
			int2 b = posX.Size;
			InitSize(a * b, flipY: true, posX.Format);
			bool hasMipMaps = posX.HasMipMaps;
			ColorProfile profile = posX.Profile;
			if (negX.Profile != profile || posY.Profile != profile || negY.Profile != profile || posZ.Profile != profile || negZ.Profile != profile)
			{
				throw new Exception("The supplied Bitmap2D's do not share the same color profile");
			}
			a = posY.Size;
			b = base.Size;
			if (!(a != b))
			{
				int2 a2 = posZ.Size;
				int2 b2 = base.Size;
				if (!(a2 != b2))
				{
					int2 a3 = negX.Size;
					int2 b3 = base.Size;
					if (!(a3 != b3))
					{
						int2 a4 = negY.Size;
						int2 b4 = base.Size;
						if (!(a4 != b4))
						{
							int2 a5 = negZ.Size;
							int2 b5 = base.Size;
							if (!(a5 != b5))
							{
								if ((hasMipMaps && !posY.HasMipMaps) || !posZ.HasMipMaps || !negX.HasMipMaps || !negY.HasMipMaps || !negZ.HasMipMaps)
								{
									throw new Exception("The supplied Bitmap2D's don't all have mipmaps");
								}
								Init(null, posX.Format, hasMipMaps, null, profile);
								FillFrom(posX, Face.PosX, hasMipMaps);
								FillFrom(negX, Face.NegX, hasMipMaps);
								FillFrom(posY, Face.PosY, hasMipMaps);
								FillFrom(negY, Face.NegY, hasMipMaps);
								FillFrom(posZ, Face.PosZ, hasMipMaps);
								FillFrom(negZ, Face.NegZ, hasMipMaps);
								return;
							}
						}
					}
				}
			}
			throw new Exception("The supplied Bitmap2D's aren't all the same size");
		}

		protected override int InitMipmapLevels()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InitMipmapLevels"), typeof(int));
		}

		public override int MipmapOrigin(int mip)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MipmapOrigin", mip), typeof(int));
		}

		public int FaceByteOrigin(Face face)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FaceByteOrigin", face), typeof(int));
		}

		public int FaceStart(Face face)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FaceStart", face), typeof(int));
		}

		public int PixelStart(int x, int y, Face face, int mip)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PixelStart", x, y, face, mip), typeof(int));
		}

		public int MipmapByteOrigin(int mip, Face face)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MipmapByteOrigin", mip, face), typeof(int));
		}

		public int MipmapTotalBytes(int mip, Face face)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MipmapTotalBytes", mip, face), typeof(int));
		}

		public void GetMipMapBuffers(List<Memory<byte>> mipbuffers)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMipMapBuffers", mipbuffers);
		}

		public void GetMipMapBuffers(List<MipMapBuffer> mipbuffers)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMipMapBuffers", mipbuffers);
		}

		public color GetPixel(int x, int y, Face face, int mipLevel = 0)
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixel", x, y, face, mipLevel), typeof(color));
		}

		public color32 GetPixel32(int x, int y, Face face, int mipLevel = 0)
		{
			return (color32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPixel32", x, y, face, mipLevel), typeof(color32));
		}

		public void SetPixel(int x, int y, Face face, color color, int mipLevel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPixel", x, y, face, color, mipLevel);
		}

		public void SetPixel32(int x, int y, Face face, color32 color, int mipLevel = 0)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SetPixel32", x, y, face, color, mipLevel);
		}

		public static int MipmapLevels(int2 size, List<int2> sizes)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapCube", ResoniteBridge.ResoniteBridgeValueType.Type), "MipmapLevels", size, sizes), typeof(int));
		}

		public static int ComputeTotalPixels(int2 size, bool mipmaps)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapCube", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeTotalPixels", size, mipmaps), typeof(int));
		}

		public BitmapCube ExtractMipMap(int mip, bool includeChildMips)
		{
			return (BitmapCube)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ExtractMipMap", mip, includeChildMips), typeof(BitmapCube));
		}

		public BitmapCube ConvertTo(TextureFormat format)
		{
			return (BitmapCube)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ConvertTo", format), typeof(BitmapCube));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public Bitmap2D GetFaceAsBitmap2D(Face face, bool mipmaps = true)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetFaceAsBitmap2D", face, mipmaps), typeof(Bitmap2D));
		}

		public void FillFrom(Bitmap2D bitmap, Face face, bool mipmaps = true)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillFrom", bitmap, face, mipmaps);
		}

		public void FillFrom(Bitmap2D bitmap, Face face, int miplevel)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FillFrom", bitmap, face, miplevel);
		}

		public void Save(string file, RawBitmapEncoding encoding = RawBitmapEncoding.LZMA)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Save", file, encoding);
		}

		public static BitmapCube Load(string file)
		{
			return (BitmapCube)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapCube", ResoniteBridge.ResoniteBridgeValueType.Type), "Load", file), typeof(BitmapCube));
		}

		public void Encode(Stream stream, RawBitmapEncoding encoding = RawBitmapEncoding.LZMA)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Encode", stream, encoding);
		}

		public static BitmapCube Decode(Stream stream)
		{
			return (BitmapCube)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapCube", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", stream), typeof(BitmapCube));
		}

		public static bool SupportsBlockCompression(TextureFormat targetFormat)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapCube", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportsBlockCompression", targetFormat), typeof(bool));
		}

		public BitmapCube BlockCompress(TextureFormat targetFormat, float quality = 0.5f, int maxThreads = 0)
		{
			return (BitmapCube)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "BlockCompress", targetFormat, quality, maxThreads), typeof(BitmapCube));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BitmapCube(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class BitmapQRCodeGenerator
	{
		public static Bitmap2D Generate(string payload, QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.Q, TextureFormat format = TextureFormat.RGBA32, color? trueColor = null, color? falseColor = null)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapQRCodeGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "Generate", payload, eccLevel, format, trueColor, falseColor), typeof(Bitmap2D));
		}

		public static void Generate(ref Bitmap2D bitmap, string payload, QRCodeGenerator.ECCLevel eccLevel = QRCodeGenerator.ECCLevel.Q, TextureFormat format = TextureFormat.RGBA32, color? trueColor = null, color? falseColor = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapQRCodeGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "Generate", bitmap, payload, eccLevel, format, trueColor, falseColor);
		}
	}
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct MP_Header : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MP_Header(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class DocumentRasterizer
	{
	}
	public class TextureSizeException : Exception, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int2 Size
		{
			get
			{
				return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Size"), typeof(int2));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Size", value);
			}
		}

		public int MaxPixels
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MaxPixels"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MaxPixels", value);
			}
		}

		public override string Message => $"Texture size of {Size} exceeds maximum number of allowed pixels: {MaxPixels}";

		public TextureSizeException(int2 size, int maxPixels)
		{
			Size = size;
			MaxPixels = maxPixels;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TextureSizeException(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	internal class SliceAccessor : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<string> paths
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "paths"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "paths", value);
			}
		}

		private List<Bitmap2D> slices
		{
			get
			{
				return (List<Bitmap2D>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "slices"), typeof(List<Bitmap2D>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "slices", value);
			}
		}

		private int slice0layer
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "slice0layer"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "slice0layer", value);
			}
		}

		private int slice1layer
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "slice1layer"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "slice1layer", value);
			}
		}

		public int Count => paths?.Count ?? slices.Count;

		public SliceAccessor(List<string> paths)
		{
			this.paths = paths;
			slices = new List<Bitmap2D>();
			slices.Add(null);
			slices.Add(null);
		}

		public SliceAccessor(List<Bitmap2D> slices)
		{
			this.slices = slices;
		}

		public Bitmap2D GetSlice(int layer)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetSlice", layer), typeof(Bitmap2D));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public SliceAccessor(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public interface IPixel : ResoniteBridge.ResoniteBridgeValueHolder
	{
		int BitsR { get; }

		int BitsG { get; }

		int BitsB { get; }

		int BitsA { get; }

		bool SupportsHDR { get; }

		float R { get; set; }

		float G { get; set; }

		float B { get; set; }

		float A { get; set; }
	}
	public struct PixelABGR1555 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort data
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public int BitsR => 5;

		public int BitsG => 5;

		public int BitsB => 5;

		public int BitsA => 1;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelABGR1555(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelAlpha8 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte a
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "a"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "a", value);
			}
		}

		public int BitsR => 0;

		public int BitsG => 0;

		public int BitsB => 0;

		public int BitsA => 8;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelAlpha8(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelARGB1555 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort data
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public int BitsR => 5;

		public int BitsG => 5;

		public int BitsB => 5;

		public int BitsA => 1;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelARGB1555(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelARGB32 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte a
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "a"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "a", value);
			}
		}

		public byte r
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public byte g
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "g"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "g", value);
			}
		}

		public byte b
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "b"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "b", value);
			}
		}

		public int BitsR => 8;

		public int BitsG => 8;

		public int BitsB => 8;

		public int BitsA => 8;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelARGB32(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelBGR24 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte b
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "b"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "b", value);
			}
		}

		public byte g
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "g"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "g", value);
			}
		}

		public byte r
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public int BitsR => 8;

		public int BitsG => 8;

		public int BitsB => 8;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelBGR24(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelBGR555 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort data
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public int BitsR => 5;

		public int BitsG => 5;

		public int BitsB => 5;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelBGR555(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelBGR565 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort data
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public int BitsR => 5;

		public int BitsG => 6;

		public int BitsB => 5;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelBGR565(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelBGRA32 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte b
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "b"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "b", value);
			}
		}

		public byte g
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "g"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "g", value);
			}
		}

		public byte r
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public byte a
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "a"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "a", value);
			}
		}

		public int BitsR => 8;

		public int BitsG => 8;

		public int BitsB => 8;

		public int BitsA => 8;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelBGRA32(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelBGRA4444 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte bg
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "bg"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "bg", value);
			}
		}

		public byte ra
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ra"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ra", value);
			}
		}

		public int BitsR => 4;

		public int BitsG => 4;

		public int BitsB => 4;

		public int BitsA => 4;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelBGRA4444(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelGR32 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort g
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "g"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "g", value);
			}
		}

		public ushort r
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public int BitsR => 16;

		public int BitsG => 16;

		public int BitsB => 0;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelGR32(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class PixelHelper
	{
		public float USHORT_MUL
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "USHORT_MUL"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "USHORT_MUL", value);
			}
		}

		public float BYTE_MUL
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BYTE_MUL"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BYTE_MUL", value);
			}
		}

		public float BIT6_MUL
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BIT6_MUL"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BIT6_MUL", value);
			}
		}

		public float BIT5_MUL
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BIT5_MUL"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BIT5_MUL", value);
			}
		}

		public float BIT4_MUL
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BIT4_MUL"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "BIT4_MUL", value);
			}
		}

		public static color ToColor<P>(this P pixel) where P : IPixel
		{
			return (color)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ToColor", pixel), typeof(color));
		}

		public static ushort ToUshort(float value)
		{
			return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ToUshort", value), typeof(ushort));
		}

		public static byte ToByte(float value)
		{
			return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ToByte", value), typeof(byte));
		}

		public static byte To4Bits(float value)
		{
			return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "To4Bits", value), typeof(byte));
		}

		public static byte To5Bits(float value)
		{
			return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "To5Bits", value), typeof(byte));
		}

		public static byte To6Bits(float value)
		{
			return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "To6Bits", value), typeof(byte));
		}

		public static ushort ToHalf(float value)
		{
			return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ToHalf", value), typeof(ushort));
		}

		public static float FromUshort(ushort value)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FromUshort", value), typeof(float));
		}

		public static float FromByte(byte value)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FromByte", value), typeof(float));
		}

		public static float From6Bits(byte value)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "From6Bits", value), typeof(float));
		}

		public static float From5Bits(byte value)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "From5Bits", value), typeof(float));
		}

		public static float From4Bits(byte value)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "PixelHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "From4Bits", value), typeof(float));
		}
	}
	public struct PixelRA16 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte r
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public byte a
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "a"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "a", value);
			}
		}

		public int BitsR => 8;

		public int BitsG => 0;

		public int BitsB => 0;

		public int BitsA => 8;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRA16(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelRG32 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort r
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public ushort g
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "g"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "g", value);
			}
		}

		public int BitsR => 16;

		public int BitsG => 16;

		public int BitsB => 0;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRG32(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelRGB24 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte r
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public byte g
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "g"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "g", value);
			}
		}

		public byte b
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "b"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "b", value);
			}
		}

		public int BitsR => 8;

		public int BitsG => 8;

		public int BitsB => 8;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRGB24(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelRGB555 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort data
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public int BitsR => 5;

		public int BitsG => 5;

		public int BitsB => 5;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRGB555(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelRGB565 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort data
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public int BitsR => 5;

		public int BitsG => 6;

		public int BitsB => 5;

		public int BitsA => 0;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRGB565(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelRGBA32 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte r
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "r"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "r", value);
			}
		}

		public byte g
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "g"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "g", value);
			}
		}

		public byte b
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "b"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "b", value);
			}
		}

		public byte a
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "a"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "a", value);
			}
		}

		public int BitsR => 8;

		public int BitsG => 8;

		public int BitsB => 8;

		public int BitsA => 8;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRGBA32(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelRGBA4444 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public byte rg
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "rg"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "rg", value);
			}
		}

		public byte ba
		{
			get
			{
				return (byte)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "ba"), typeof(byte));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "ba", value);
			}
		}

		public int BitsR => 4;

		public int BitsG => 4;

		public int BitsB => 4;

		public int BitsA => 4;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRGBA4444(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public struct PixelRGBA5551 : IPixel, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ushort data
		{
			get
			{
				return (ushort)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "data"), typeof(ushort));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "data", value);
			}
		}

		public int BitsR => 5;

		public int BitsG => 5;

		public int BitsB => 5;

		public int BitsA => 1;

		public bool SupportsHDR => false;

		public float R
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "R"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "R", value);
			}
		}

		public float G
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "G"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "G", value);
			}
		}

		public float B
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "B"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "B", value);
			}
		}

		public float A
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "A"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "A", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public PixelRGBA5551(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public enum AlphaHandling
	{
		KeepOriginal,
		ForceRGB,
		ForceRGBA
	}
	public class TextureDecoder : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int MAX_PIXELS
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MAX_PIXELS"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MAX_PIXELS", value);
			}
		}

		public float GAMMA
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "GAMMA"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "GAMMA", value);
			}
		}

		public float INV_GAMMA
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "INV_GAMMA"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "INV_GAMMA", value);
			}
		}

		public int MIN_DOWNSCALE_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "MIN_DOWNSCALE_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "MIN_DOWNSCALE_SIZE", value);
			}
		}

		public static Bitmap2D ERRORTEXTURE
		{
			get
			{
				return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ERRORTEXTURE"), typeof(Bitmap2D));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ERRORTEXTURE", value);
			}
		}

		public static Bitmap3D ERRORTEXTURE3D
		{
			get
			{
				return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ERRORTEXTURE3D"), typeof(Bitmap3D));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ERRORTEXTURE3D", value);
			}
		}

		private static Dictionary<string, FREE_IMAGE_FORMAT> extensions
		{
			get
			{
				return (Dictionary<string, FREE_IMAGE_FORMAT>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "extensions"), typeof(Dictionary<string, FREE_IMAGE_FORMAT>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "extensions", value);
			}
		}

		public static IEnumerable<string> SupportedExtensions => extensions.Keys;

		public static event Action<string> OnErrorMessage;

		static TextureDecoder()
		{
			FreeImageEngine.Message += FreeImageEngine_Message;
			extensions = new Dictionary<string, FREE_IMAGE_FORMAT>();
			foreach (FreeImagePlugin readablePlugin in PluginRepository.ReadablePlugins)
			{
				string[] array = readablePlugin.ExtentsionList.Split(new char[1] { ',' });
				for (int i = 0; i < array.Length; i++)
				{
					string key = array[i].ToLower().Trim();
					if (!extensions.ContainsKey(key))
					{
						extensions.Add(key, readablePlugin.FIFormat);
					}
				}
			}
			ERRORTEXTURE = GenerateErrorTexture(4, 4, TextureFormat.RGB24);
			ERRORTEXTURE3D = GenerateErrorTexture(4, 4, 4, TextureFormat.RGB24);
		}

		public static Bitmap2D GenerateErrorTexture(int width, int height, TextureFormat format)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateErrorTexture", width, height, format), typeof(Bitmap2D));
		}

		public static Bitmap3D GenerateErrorTexture(int width, int height, int depth, TextureFormat format)
		{
			return (Bitmap3D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateErrorTexture", width, height, depth, format), typeof(Bitmap3D));
		}

		public static void FillErrorTexture(Bitmap2D bitmap)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "FillErrorTexture", bitmap);
		}

		public static void FillErrorTexture(BitmapCube cube)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "FillErrorTexture", cube);
		}

		public static void FillErrorTexture(Bitmap3D bitmap)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "FillErrorTexture", bitmap);
		}

		public static void PrintInitInfo()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "PrintInitInfo");
		}

		private static void FreeImageEngine_Message(FREE_IMAGE_FORMAT fif, string message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "FreeImageEngine_Message", fif, message);
		}

		public static FREE_IMAGE_FORMAT DetectFormat(string extension)
		{
			return (FREE_IMAGE_FORMAT)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "DetectFormat", extension), typeof(FREE_IMAGE_FORMAT));
		}

		public static void DibLoaded(FIBITMAP dib)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "DibLoaded", dib);
		}

		public static void UnloadDib(FIBITMAP dib)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "UnloadDib", dib);
		}

		public static Bitmap2D FromDDS(Stream stream, bool? generateMipMaps)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "FromDDS", stream, generateMipMaps), typeof(Bitmap2D));
		}

		public static void ConvertDDSData(IImage dds, Span<byte> data, int mip, Bitmap2D bitmap)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertDDSData", dds, data, mip, bitmap);
		}

		public static void ConvertImageData<P>(Span<byte> data, int2 mipSize, int mip, Bitmap2D bitmap) where P : struct, IPixel
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertImageData", data, mipSize, mip, bitmap);
		}

		public static TextureFormat GetFormat(ImageFormat format)
		{
			return (TextureFormat)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "GetFormat", format), typeof(TextureFormat));
		}

		public static Bitmap2D FromFreeImage(ref FIBITMAP dib, bool generateMipMaps, AlphaHandling alphaHandling, int maxSize = int.MaxValue, float sizeRatio = 1f, string originalFormat = null)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "FromFreeImage", dib, generateMipMaps, alphaHandling, maxSize, sizeRatio, originalFormat), typeof(Bitmap2D));
		}

		public static Bitmap2D Decode(string file, bool? generateMipMaps, AlphaHandling alphaHandling = AlphaHandling.KeepOriginal, int maxSize = int.MaxValue, float sizeRatio = 1f)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", file, generateMipMaps, alphaHandling, maxSize, sizeRatio), typeof(Bitmap2D));
		}

		public static Bitmap2D Decode(Stream fStream, string extension, bool? generateMipMaps, AlphaHandling alphaHandling = AlphaHandling.KeepOriginal, int maxSize = int.MaxValue, float sizeRatio = 1f)
		{
			return (Bitmap2D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Decode", fStream, extension, generateMipMaps, alphaHandling, maxSize, sizeRatio), typeof(Bitmap2D));
		}

		public static string FreeImageFormatToMIME(FREE_IMAGE_FORMAT format)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureDecoder", ResoniteBridge.ResoniteBridgeValueType.Type), "FreeImageFormatToMIME", format), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public TextureDecoder(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class TextureEncoder
	{
		public static bool Encode(FIBITMAP dib, string file, int quality = 85, bool preserveColorInAlpha = true)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode", dib, file, quality, preserveColorInAlpha), typeof(bool));
		}

		public static bool Encode(FIBITMAP dib, Stream stream, string extension, int quality = 85, bool preserveColorInAlpha = true)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode", dib, stream, extension, quality, preserveColorInAlpha), typeof(bool));
		}

		public static bool Encode(byte[] data, int width, int height, int channels, string outputFile, int quality = 75, bool preserveColorInAlpha = true)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Encode", data, width, height, channels, outputFile, quality, preserveColorInAlpha), typeof(bool));
		}

		public static void ConvertToPNG(string inputFile, string outputFile, int maxSize = -1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToPNG", inputFile, outputFile, maxSize);
		}

		public static void ConvertToJPG(string inputFile, string outputFile, int maxSize = -1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToJPG", inputFile, outputFile, maxSize);
		}

		public static void ConvertToWEBP(string inputFile, string outputFile, int maxSize = -1, int quality = 80)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToWEBP", inputFile, outputFile, maxSize, quality);
		}

		public static void ConvertToEXR(string inputFile, string outputFile, int maxSize = -1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToEXR", inputFile, outputFile, maxSize);
		}

		public static void ConvertToPNG(Stream data, string outputFile, int maxSize = -1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToPNG", data, outputFile, maxSize);
		}

		public static bool ClearMetadata(string inputFile, string outputFile)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ClearMetadata", inputFile, outputFile), typeof(bool));
		}

		public static bool ClearMetadata(Stream data, string outputFile)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ClearMetadata", data, outputFile), typeof(bool));
		}

		private static bool ClearMetadata(FIBITMAP dib)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ClearMetadata", dib), typeof(bool));
		}

		public static void ConvertToEXR(Stream data, string outputFile, int maxSize = -1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToEXR", data, outputFile, maxSize);
		}

		public static FIBITMAP EnsureNonHDR(FIBITMAP dib, bool unloadOld = true)
		{
			return (FIBITMAP)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "EnsureNonHDR", dib, unloadOld), typeof(FIBITMAP));
		}

		public static FIBITMAP Ensure24BPP(FIBITMAP dib, bool unloadOld = true)
		{
			return (FIBITMAP)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Ensure24BPP", dib, unloadOld), typeof(FIBITMAP));
		}

		public static FIBITMAP Rescale(FIBITMAP dib, int maxSize = -1)
		{
			return (FIBITMAP)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "Rescale", dib, maxSize), typeof(FIBITMAP));
		}

		public static void ConvertToJPG(Stream data, string outputFile, int maxSize = -1)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToJPG", data, outputFile, maxSize);
		}

		public static void ConvertToWEBP(Stream data, string outputFile, int maxSize = -1, int quality = 80)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureEncoder", ResoniteBridge.ResoniteBridgeValueType.Type), "ConvertToWEBP", data, outputFile, maxSize, quality);
		}
	}
	[DataModelType]
	public enum TextureFormat
	{
		Unknown = 0,
		Alpha8 = 1,
		R8 = 2,
		RGB24 = 16,
		ARGB32 = 17,
		RGBA32 = 18,
		BGRA32 = 19,
		RGB565 = 24,
		RGBAHalf = 32,
		ARGBHalf = 33,
		RHalf = 34,
		RGHalf = 35,
		RGBAFloat = 48,
		ARGBFloat = 49,
		RFloat = 50,
		RGFloat = 51,
		BC1 = 64,
		BC2 = 65,
		BC3 = 66,
		BC4 = 67,
		BC5 = 68,
		BC6H = 69,
		BC7 = 70,
		ETC2_RGB = 96,
		ETC2_RGBA1 = 97,
		ETC2_RGBA8 = 98,
		ASTC_4x4 = 128,
		ASTC_5x5 = 129,
		ASTC_6x6 = 130,
		ASTC_8x8 = 131,
		ASTC_10x10 = 132,
		ASTC_12x12 = 133
	}
	public static class TextureFormatExtensions
	{
		public static bool SupportsRead(this TextureFormat format)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportsRead", format), typeof(bool));
		}

		public static bool SupportsWrite(this TextureFormat format)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportsWrite", format), typeof(bool));
		}

		public static bool IsBlockCompressed(this TextureFormat format)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsBlockCompressed", format), typeof(bool));
		}

		public static int2 BlockSize(this TextureFormat format)
		{
			return (int2)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "BlockSize", format), typeof(int2));
		}

		public static int3 BlockSize3D(this TextureFormat format)
		{
			return (int3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "BlockSize3D", format), typeof(int3));
		}

		public static bool IsHDR(this TextureFormat format)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsHDR", format), typeof(bool));
		}

		public static double GetBitsPerPixel(this TextureFormat format)
		{
			return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetBitsPerPixel", format), typeof(double));
		}

		public static int GetBytesPerPixel(this TextureFormat format)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetBytesPerPixel", format), typeof(int));
		}

		public static int GetBytesPerChannel(this TextureFormat format)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetBytesPerChannel", format), typeof(int));
		}

		public static int GetChannels(this TextureFormat format)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "GetChannels", format), typeof(int));
		}

		public static bool SupportsAlpha(this TextureFormat format)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureFormatExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "SupportsAlpha", format), typeof(bool));
		}
	}
	public enum VersionComparison
	{
		Exact,
		AllowNewer,
		Ignore
	}
	public class ComputedVariantResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public string identifier
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "identifier"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "identifier", value);
			}
		}

		public string file
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "file"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "file", value);
			}
		}

		public ComputedVariantResult(string identifier, string file)
		{
			this.identifier = identifier;
			this.file = file;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ComputedVariantResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public enum AssetVariantType
	{
		Texture,
		Cubemap,
		Volume,
		Mesh,
		Shader
	}
	public delegate void VariantGeneratedHandler(ComputedVariantResult result);
	public static class AssetVariantHelper
	{
		public static string TempFolder
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TempFolder"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "TempFolder", value);
			}
		}

		public static List<ComputedVariantResult> GenerateVariants(string file, IAssetVariantDescriptor variantDescriptor, int maxThreads = -1, VariantGeneratedHandler variantGenerated = null, Predicate<string> variantFilter = null)
		{
			return (List<ComputedVariantResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateVariants", file, variantDescriptor, maxThreads, variantGenerated, variantFilter), typeof(List<ComputedVariantResult>));
		}

		public static D FromIdentifier<D>(string identifier) where D : class, IAssetVariantDescriptor
		{
			return (D)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", identifier), typeof(D));
		}

		public static AssetVariantType DescriptorToVariantType(Type type)
		{
			return (AssetVariantType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DescriptorToVariantType", type), typeof(AssetVariantType));
		}

		public static IAssetVariantDescriptor FromIdentifier(Type type, string identifier)
		{
			return (IAssetVariantDescriptor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", type, identifier), typeof(IAssetVariantDescriptor));
		}

		public static IAssetVariantDescriptor FromIdentifier(AssetVariantType type, string identifier)
		{
			return (IAssetVariantDescriptor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", type, identifier), typeof(IAssetVariantDescriptor));
		}

		public static bool VersionEquals(IAssetVariantDescriptor a, IAssetVariantDescriptor b, VersionComparison versionComparison)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetVariantHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "VersionEquals", a, b, versionComparison), typeof(bool));
		}
	}
	public class CubemapVariantDescriptor : TextureVariantDescriptor<CubemapVariantDescriptor, CubemapMetadata>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private delegate void ChainSegmentGenerator(int size, bool mips);

		public int CURRENT_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CURRENT_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CURRENT_VERSION", value);
			}
		}

		[JsonProperty(PropertyName = "size")]
		[JsonPropertyName("size")]
		public int Size
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Size"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Size", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public int MipMapCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MipMapCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MipMapCount", value);
			}
		}

		public override string ValidationError
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValidationError"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValidationError", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override string VariantIdentifier => GenerateVariantIdentifier(Size, base.MipMaps);

		public override string ValidateCloudVariant(CubemapMetadata metadata)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ValidateCloudVariant", metadata), typeof(string));
		}

		public override bool IsPotentialAlternative(CubemapVariantDescriptor other, TextureCompression? requireCompression)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsPotentialAlternative", other, requireCompression), typeof(bool));
		}

		public CubemapVariantDescriptor()
		{
		}

		public CubemapVariantDescriptor(TextureCompression compression, int compressionQuality, int size, bool mipmaps, ColorPreprocess colorPreprocess, AlphaPreprocess alphaPreprocess, int version = 1)
			: base(compression, compressionQuality, mipmaps, colorPreprocess, alphaPreprocess, version)
		{
			Size = size;
		}

		private string GenerateVariantIdentifier(int size, bool mips)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateVariantIdentifier", size, mips), typeof(string));
		}

		public override void EnsureCurrentVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureCurrentVersion");
		}

		public static CubemapVariantDescriptor FromIdentifier(string identifier)
		{
			return (CubemapVariantDescriptor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "CubemapVariantDescriptor", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", identifier), typeof(CubemapVariantDescriptor));
		}

		public override bool Equals(CubemapVariantDescriptor other, VersionComparison versionComparison)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other, versionComparison), typeof(bool));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public static bool operator ==(CubemapVariantDescriptor left, CubemapVariantDescriptor right)
		{
			return EqualityComparer<CubemapVariantDescriptor>.Default.Equals(left, right);
		}

		public static bool operator !=(CubemapVariantDescriptor left, CubemapVariantDescriptor right)
		{
			return !(left == right);
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public override List<CubemapVariantDescriptor> GenerateCloudChain()
		{
			return (List<CubemapVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateCloudChain"), typeof(List<CubemapVariantDescriptor>));
		}

		public override void GenerateLoadChain(List<string> chain)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateLoadChain", chain);
		}

		private void GenerateChain(ChainSegmentGenerator onGeneratedSegment)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateChain", onGeneratedSegment);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CubemapVariantDescriptor(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public enum MeshDataType
	{
		Mesh,
		MeshCollider,
		DualSidedMeshCollider,
		ConvexHullCollider
	}
	public enum MeshCompression
	{
		None,
		LZ4,
		LZMA
	}
	public class MeshVariantDescriptor : IAssetVariantDescriptor<MeshVariantDescriptor, MeshMetadata>, IAssetVariantDescriptor, IEquatable<MeshVariantDescriptor>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int CURRENT_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CURRENT_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CURRENT_VERSION", value);
			}
		}

		public bool OriginalAsset => false;

		public bool IsValid => ValidationError == null;

		public string ValidationError
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValidationError"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValidationError", value);
			}
		}

		public string VariantIdentifier
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VariantIdentifier"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VariantIdentifier", value);
			}
		}

		[JsonProperty(PropertyName = "variantVersion")]
		[JsonPropertyName("variantVersion")]
		public int VariantVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VariantVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VariantVersion", value);
			}
		}

		[JsonProperty(PropertyName = "dataType")]
		[JsonPropertyName("dataType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public MeshDataType? DataType
		{
			get
			{
				return (MeshDataType?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DataType"), typeof(MeshDataType?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DataType", value);
			}
		}

		[JsonProperty(PropertyName = "compression")]
		[JsonPropertyName("compression")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public MeshCompression Compression
		{
			get
			{
				return (MeshCompression)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Compression"), typeof(MeshCompression));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Compression", value);
			}
		}

		public MeshVariantDescriptor(MeshDataType? dataType, MeshCompression compression, int version = 2)
		{
			VariantVersion = version;
			DataType = dataType;
			Compression = compression;
		}

		public static MeshVariantDescriptor FromIdentifier(string query)
		{
			return (MeshVariantDescriptor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshVariantDescriptor", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", query), typeof(MeshVariantDescriptor));
		}

		public void EnsureCurrentVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureCurrentVersion");
		}

		public bool Equals(MeshVariantDescriptor other, VersionComparison versionComparison)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other, versionComparison), typeof(bool));
		}

		public bool Equals(MeshVariantDescriptor other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public List<IAssetVariantDescriptor> GenerateCloudChainNonGeneric()
		{
			return (List<IAssetVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateCloudChainNonGeneric"), typeof(List<IAssetVariantDescriptor>));
		}

		public List<MeshVariantDescriptor> GenerateCloudChain()
		{
			return (List<MeshVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateCloudChain"), typeof(List<MeshVariantDescriptor>));
		}

		public void GenerateLoadChain(List<string> chain)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateLoadChain", chain);
		}

		public List<MeshVariantDescriptor> GetBestAlternateChain(List<MeshVariantDescriptor> availableDescriptors, Predicate<MeshVariantDescriptor> variantFilter = null)
		{
			return (List<MeshVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBestAlternateChain", availableDescriptors, variantFilter), typeof(List<MeshVariantDescriptor>));
		}

		public string ValidateCloudVariant(MeshMetadata metadata)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ValidateCloudVariant", metadata), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MeshVariantDescriptor(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public enum ShaderTargetPlatform
	{
		WindowsDX11,
		LinuxOpenGL,
		AndroidOpenGL
	}
	public static class ShaderTargetPlatformHelper
	{
		public static string PackageName(this ShaderTargetPlatform targetPlatform)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderTargetPlatformHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "PackageName", targetPlatform), typeof(string));
		}
	}
	public class ShaderVariantDescriptor : IAssetVariantDescriptor<ShaderVariantDescriptor, ShaderMetadata>, IAssetVariantDescriptor, IEquatable<ShaderVariantDescriptor>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int CURRENT_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CURRENT_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CURRENT_VERSION", value);
			}
		}

		public bool OriginalAsset => false;

		[JsonProperty(PropertyName = "variantVersion")]
		[JsonPropertyName("variantVersion")]
		public int VariantVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VariantVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VariantVersion", value);
			}
		}

		[JsonProperty(PropertyName = "variantIndex")]
		[JsonPropertyName("variantIndex")]
		public uint VariantIndex
		{
			get
			{
				return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VariantIndex"), typeof(uint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VariantIndex", value);
			}
		}

		[JsonProperty(PropertyName = "targetPlatform")]
		[JsonPropertyName("targetPlatform")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ShaderTargetPlatform TargetPlatform
		{
			get
			{
				return (ShaderTargetPlatform)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TargetPlatform"), typeof(ShaderTargetPlatform));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TargetPlatform", value);
			}
		}

		public bool IsValid => ValidationError == null;

		public string ValidationError
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValidationError"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValidationError", value);
			}
		}

		public string VariantIdentifier => string.Format("variant={0}&platform={1}", VariantIndex.ToString("X8"), TargetPlatform);

		public ShaderVariantDescriptor(uint variantIndex, ShaderTargetPlatform targetPlatform)
		{
			VariantIndex = variantIndex;
			TargetPlatform = targetPlatform;
		}

		public void EnsureCurrentVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureCurrentVersion");
		}

		public static ShaderVariantDescriptor FromIdentifier(string query)
		{
			return (ShaderVariantDescriptor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderVariantDescriptor", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", query), typeof(ShaderVariantDescriptor));
		}

		public bool Equals(ShaderVariantDescriptor other, VersionComparison versionComparison)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other, versionComparison), typeof(bool));
		}

		public bool Equals(ShaderVariantDescriptor other)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other), typeof(bool));
		}

		public List<IAssetVariantDescriptor> GenerateCloudChainNonGeneric()
		{
			return (List<IAssetVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateCloudChainNonGeneric"), typeof(List<IAssetVariantDescriptor>));
		}

		public List<ShaderVariantDescriptor> GenerateCloudChain()
		{
			return (List<ShaderVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateCloudChain"), typeof(List<ShaderVariantDescriptor>));
		}

		public void GenerateLoadChain(List<string> chain)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateLoadChain", chain);
		}

		public List<ShaderVariantDescriptor> GetBestAlternateChain(List<ShaderVariantDescriptor> availableDescriptors, Predicate<ShaderVariantDescriptor> variantFilter = null)
		{
			return (List<ShaderVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetBestAlternateChain", availableDescriptors, variantFilter), typeof(List<ShaderVariantDescriptor>));
		}

		public string ValidateCloudVariant(ShaderMetadata metadata)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ValidateCloudVariant", metadata), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ShaderVariantDescriptor(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class Texture2DVariantDescriptor : TextureVariantDescriptor<Texture2DVariantDescriptor, BitmapMetadata>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private delegate void ChainSegmentGenerator(int width, int height, bool mips);

		public int CURRENT_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CURRENT_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CURRENT_VERSION", value);
			}
		}

		[JsonProperty(PropertyName = "width")]
		[JsonPropertyName("width")]
		public int Width
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		[JsonProperty(PropertyName = "height")]
		[JsonPropertyName("height")]
		public int Height
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Height"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Height", value);
			}
		}

		[JsonProperty(PropertyName = "mipMapFiltering")]
		[JsonPropertyName("mipMapFiltering")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public Filtering? Filtering
		{
			get
			{
				return (Filtering?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Filtering"), typeof(Filtering?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Filtering", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public int MipMapCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MipMapCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MipMapCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override string ValidationError
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValidationError"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValidationError", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override string VariantIdentifier => GenerateVariantIdentifier(Width, Height, base.MipMaps);

		public override string ValidateCloudVariant(BitmapMetadata metadata)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ValidateCloudVariant", metadata), typeof(string));
		}

		public bool IsValidCloudSize(BitmapMetadata metadata)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsValidCloudSize", metadata), typeof(bool));
		}

		public Texture2DVariantDescriptor()
		{
		}

		public Texture2DVariantDescriptor(TextureCompression compression, int compressionQuality, int width, int height, bool mipMaps, Filtering? filtering, ColorPreprocess colorPreprocess, AlphaPreprocess alphaPreprocess, int version = 3)
			: base(compression, compressionQuality, mipMaps, colorPreprocess, alphaPreprocess, version)
		{
			Width = width;
			Height = height;
			Filtering = filtering;
		}

		public override void EnsureCurrentVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureCurrentVersion");
		}

		public static Texture2DVariantDescriptor FromIdentifier(string identifier)
		{
			return (Texture2DVariantDescriptor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Texture2DVariantDescriptor", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", identifier), typeof(Texture2DVariantDescriptor));
		}

		private string GenerateVariantIdentifier(int width, int height, bool mips)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateVariantIdentifier", width, height, mips), typeof(string));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public override bool Equals(Texture2DVariantDescriptor other, VersionComparison versionComparison)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other, versionComparison), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public static bool operator ==(Texture2DVariantDescriptor left, Texture2DVariantDescriptor right)
		{
			return EqualityComparer<Texture2DVariantDescriptor>.Default.Equals(left, right);
		}

		public static bool operator !=(Texture2DVariantDescriptor left, Texture2DVariantDescriptor right)
		{
			return !(left == right);
		}

		public override void GenerateLoadChain(List<string> chain)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateLoadChain", chain);
		}

		public override float GetAlternativeScore(Texture2DVariantDescriptor other)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetAlternativeScore", other), typeof(float));
		}

		public override List<Texture2DVariantDescriptor> GenerateCloudChain()
		{
			return (List<Texture2DVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateCloudChain"), typeof(List<Texture2DVariantDescriptor>));
		}

		private void GenerateChain(ChainSegmentGenerator onGeneratedSegment)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateChain", onGeneratedSegment);
		}

		public override bool IsPotentialAlternative(Texture2DVariantDescriptor other, TextureCompression? requireCompression = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsPotentialAlternative", other, requireCompression), typeof(bool));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Texture2DVariantDescriptor(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class Texture3DVariantDescriptor : TextureVariantDescriptor<Texture3DVariantDescriptor, VolumeMetadata>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private delegate void ChainSegmentGenerator(int width, int height, int depth, bool mips);

		public int CURRENT_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "CURRENT_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "CURRENT_VERSION", value);
			}
		}

		[JsonProperty(PropertyName = "width")]
		[JsonPropertyName("width")]
		public int Width
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		[JsonProperty(PropertyName = "height")]
		[JsonPropertyName("height")]
		public int Height
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Height"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Height", value);
			}
		}

		[JsonProperty(PropertyName = "depth")]
		[JsonPropertyName("depth")]
		public int Depth
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Depth"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Depth", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public int MipMapCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MipMapCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MipMapCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override string ValidationError
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ValidationError"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ValidationError", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public override string VariantIdentifier => GenerateVariantIdentifier(Width, Height, Depth, base.MipMaps);

		public override string ValidateCloudVariant(VolumeMetadata metadata)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ValidateCloudVariant", metadata), typeof(string));
		}

		public bool IsValidCloudSize(VolumeMetadata metadata)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsValidCloudSize", metadata), typeof(bool));
		}

		public Texture3DVariantDescriptor()
		{
		}

		public Texture3DVariantDescriptor(TextureCompression compression, int compressionQuality, int width, int height, int depth, bool mipMaps, ColorPreprocess colorPreprocess, AlphaPreprocess alphaPreprocess, int version = 0)
			: base(compression, compressionQuality, mipMaps, colorPreprocess, alphaPreprocess, version)
		{
			Width = width;
			Height = height;
			Depth = depth;
			if (mipMaps)
			{
				throw new NotSupportedException("Mipmaps are currently not supported for 3D textures");
			}
		}

		public override void EnsureCurrentVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsureCurrentVersion");
		}

		public static Texture3DVariantDescriptor FromIdentifier(string identifier)
		{
			return (Texture3DVariantDescriptor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Texture3DVariantDescriptor", ResoniteBridge.ResoniteBridgeValueType.Type), "FromIdentifier", identifier), typeof(Texture3DVariantDescriptor));
		}

		private string GenerateVariantIdentifier(int width, int height, int depth, bool mips)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateVariantIdentifier", width, height, depth, mips), typeof(string));
		}

		public override bool Equals(object obj)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", obj), typeof(bool));
		}

		public override bool Equals(Texture3DVariantDescriptor other, VersionComparison versionComparison)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Equals", other, versionComparison), typeof(bool));
		}

		public override int GetHashCode()
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetHashCode"), typeof(int));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public static bool operator ==(Texture3DVariantDescriptor left, Texture3DVariantDescriptor right)
		{
			return EqualityComparer<Texture3DVariantDescriptor>.Default.Equals(left, right);
		}

		public static bool operator !=(Texture3DVariantDescriptor left, Texture3DVariantDescriptor right)
		{
			return !(left == right);
		}

		public override void GenerateLoadChain(List<string> chain)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateLoadChain", chain);
		}

		public override float GetAlternativeScore(Texture3DVariantDescriptor other)
		{
			return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetAlternativeScore", other), typeof(float));
		}

		public override List<Texture3DVariantDescriptor> GenerateCloudChain()
		{
			return (List<Texture3DVariantDescriptor>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateCloudChain"), typeof(List<Texture3DVariantDescriptor>));
		}

		private void GenerateChain(ChainSegmentGenerator onGeneratedSegment)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateChain", onGeneratedSegment);
		}

		public override bool IsPotentialAlternative(Texture3DVariantDescriptor other, TextureCompression? requireCompression = null)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsPotentialAlternative", other, requireCompression), typeof(bool));
		}

		public static int3 GetMaxLimitedSize(in int3 originalSize, int maxSize = 16384)
		{
			return (int3)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Texture3DVariantDescriptor", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMaxLimitedSize", originalSize, maxSize), typeof(int3));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public Texture3DVariantDescriptor(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public enum TextureCompression
	{
		RawRGBA,
		RawRGBAHalf,
		BC1_Crunched,
		BC3_Crunched,
		BC3nm_Crunched,
		BC1_Crunched_Non_Perceptual,
		BC3_Crunched_Non_Perceptual,
		BC1_LZMA,
		BC3_LZMA,
		BC3nm_LZMA,
		BC4_LZMA,
		BC6H_LZMA,
		BC7_LZMA,
		ETC2_RGB_Crunched,
		ETC2_RGBA8_Crunched,
		ETC2_RGB_LZMA,
		ETC2_RGBA8_LZMA,
		ASTC_4x4_LZMA,
		ASTC_5x5_LZMA,
		ASTC_6x6_LZMA,
		ASTC_8x8_LZMA,
		ASTC_10x10_LZMA,
		ASTC_12x12_LZMA
	}
	[DataModelType]
	public enum ColorPreprocess
	{
		None,
		sRGB,
		HDRsRGB,
		LogLUV,
		RGBM
	}
	[DataModelType]
	public enum AlphaPreprocess
	{
		None,
		sRGB,
		LogLUV,
		RGBM
	}
	[DataModelType]
	public enum Filtering
	{
		Bilinear,
		Box,
		Lanczos3
	}
	[DataModelType]
	public enum PowerOfTwoSize
	{
		NonPowerOfTwo,
		Smaller,
		Nearest,
		Larger
	}
	[DataModelType]
	public enum SizeMode
	{
		Maximum,
		Exact
	}
	public static class TextureCompressionExtensions
	{
		public static bool IsRaw(this TextureCompression compression)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureCompressionExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsRaw", compression), typeof(bool));
		}

		public static bool IsHDR(this TextureCompression compression)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureCompressionExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsHDR", compression), typeof(bool));
		}

		public static TextureFormat ToFormat(this TextureCompression compression, ImageMetadataBase metadata = null, bool threeChannelSupported = false, ColorProfile profile = ColorProfile.sRGB)
		{
			return (TextureFormat)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureCompressionExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "ToFormat", compression, metadata, threeChannelSupported, profile), typeof(TextureFormat));
		}
	}
	public abstract class TextureVariantDescriptor : IAssetVariantDescriptor, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "originalAsset")]
		[JsonPropertyName("originalAsset")]
		public bool OriginalAsset { get; set; }

		[JsonProperty(PropertyName = "variantVersion")]
		[JsonPropertyName("variantVersion")]
		public int VariantVersion { get; set; }

		public bool IsValid => ValidationError == null;

		public abstract string ValidationError { get; }

		public abstract string VariantIdentifier { get; }

		public abstract void EnsureCurrentVersion();

		public abstract List<IAssetVariantDescriptor> GenerateCloudChainNonGeneric();

		public abstract void GenerateLoadChain(List<string> chain);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public abstract class TextureVariantDescriptor<D, M> : TextureVariantDescriptor, IAssetVariantDescriptor<D, M>, IAssetVariantDescriptor, IEquatable<D>, ResoniteBridge.ResoniteBridgeValueHolder where D : TextureVariantDescriptor<D, M> where M : ImageMetadataBase
	{
		public const int CLOUD_MIPS_MAX_PIXELS = 16384;

		public const int MAX_SIZE = 16384;

		[System.Text.Json.Serialization.JsonIgnore]
		public override string ValidationError
		{
			get
			{
				if (CompressionQuality < 0 || CompressionQuality > 100)
				{
					return "CompressionQuality is out of range";
				}
				if (ColorPreprocess == ColorPreprocess.LogLUV && AlphaPreprocess != AlphaPreprocess.LogLUV)
				{
					return "Color and Alpha preprocess must match for LogLUV";
				}
				if (ColorPreprocess == ColorPreprocess.RGBM && AlphaPreprocess != AlphaPreprocess.RGBM)
				{
					return "Color and Alpha preprocess must match for RGBM";
				}
				return null;
			}
		}

		[JsonProperty(PropertyName = "textureCompression")]
		[JsonPropertyName("textureCompression")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public TextureCompression TextureCompression { get; protected set; }

		[JsonProperty(PropertyName = "compressionQuality")]
		[JsonPropertyName("compressionQuality")]
		public int CompressionQuality { get; protected set; }

		[JsonProperty(PropertyName = "mipMaps")]
		[JsonPropertyName("mipMaps")]
		public bool MipMaps { get; protected set; }

		[JsonProperty(PropertyName = "colorPreprocess")]
		[JsonPropertyName("colorPreprocess")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ColorPreprocess ColorPreprocess { get; set; }

		[JsonProperty(PropertyName = "colorPreprocess")]
		[JsonPropertyName("colorPreprocess")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public AlphaPreprocess AlphaPreprocess { get; set; }

		public static int2 GetMaxLimitedSize(in int2 originalSize, int maxSize = 16384)
		{
			if ((originalSize > maxSize).None())
			{
				return originalSize;
			}
			int num = MathX.MaxComponent(in originalSize);
			double num2 = (double)maxSize / (double)num;
			double2 v = originalSize * num2;
			return MathX.RoundToInt(in v);
		}

		public static int2 GetMinLimitedSize(in int2 currentSize, in int2 maxSize, int minSize)
		{
			if ((currentSize < minSize).None())
			{
				return currentSize;
			}
			int num = MathX.MinComponent(in currentSize);
			double num2 = (double)minSize / (double)num;
			double2 v = currentSize * num2;
			int2 @int = MathX.RoundToInt(in v);
			if ((@int > maxSize).Any())
			{
				return maxSize;
			}
			return @int;
		}

		public TextureVariantDescriptor()
		{
			base.OriginalAsset = true;
		}

		public TextureVariantDescriptor(TextureCompression compression, int compressionQuality, bool mipMaps, ColorPreprocess colorPreprocess, AlphaPreprocess alphaPreprocess, int version)
		{
			base.VariantVersion = version;
			TextureCompression = compression;
			CompressionQuality = compressionQuality;
			MipMaps = mipMaps;
			AlphaPreprocess = alphaPreprocess;
			ColorPreprocess = colorPreprocess;
		}

		protected static Dictionary<string, string> ParseBase(string identifier, out TextureCompression compression, out int quality, out bool mips, out ColorPreprocess colorPreprocess, out AlphaPreprocess alphaPreprocess, out int version)
		{
			if (string.IsNullOrWhiteSpace(identifier))
			{
				compression = TextureCompression.RawRGBA;
				quality = 0;
				version = 0;
				mips = false;
				colorPreprocess = ColorPreprocess.None;
				alphaPreprocess = AlphaPreprocess.None;
				return null;
			}
			Dictionary<string, string> dictionary = StringHelper.ParseQueryString(identifier);
			version = 0;
			compression = TextureCompression.RawRGBA;
			quality = 0;
			mips = false;
			colorPreprocess = ColorPreprocess.None;
			alphaPreprocess = AlphaPreprocess.None;
			foreach (KeyValuePair<string, string> item in dictionary)
			{
				string key = item.Key;
				string value = item.Value;
				switch (key)
				{
					case "version":
						version = int.Parse(value);
						break;
					case "compression":
						if (!Enum.TryParse<TextureCompression>(value, ignoreCase: true, out compression))
						{
							throw new ArgumentException("Invalid texture compression: " + value);
						}
						break;
					case "quality":
						quality = int.Parse(value);
						break;
					case "mips":
						mips = bool.Parse(value);
						break;
					case "colorPreprocess":
						if (!Enum.TryParse<ColorPreprocess>(value, ignoreCase: true, out colorPreprocess))
						{
							throw new ArgumentException("Invalid color preprocess: " + value);
						}
						break;
					case "alphaPreprocess":
						if (!Enum.TryParse<AlphaPreprocess>(value, ignoreCase: true, out alphaPreprocess))
						{
							throw new ArgumentException("Invalid alpha preprocess: " + value);
						}
						break;
				}
			}
			return dictionary;
		}

		public virtual bool IsPotentialAlternative(D other, TextureCompression? requireCompression)
		{
			if (MipMaps != other.MipMaps)
			{
				return false;
			}
			if (ColorPreprocess != other.ColorPreprocess)
			{
				return false;
			}
			if (AlphaPreprocess != other.AlphaPreprocess)
			{
				return false;
			}
			if (requireCompression.HasValue)
			{
				if ((requireCompression.GetValueOrDefault() == TextureCompression.BC1_Crunched || requireCompression.GetValueOrDefault() == TextureCompression.BC1_Crunched_Non_Perceptual || requireCompression.GetValueOrDefault() == TextureCompression.BC1_LZMA) && (other.TextureCompression == TextureCompression.BC1_Crunched || other.TextureCompression == TextureCompression.BC1_Crunched_Non_Perceptual || other.TextureCompression == TextureCompression.BC1_LZMA))
				{
					return true;
				}
				if ((requireCompression.GetValueOrDefault() == TextureCompression.BC3_Crunched || requireCompression.GetValueOrDefault() == TextureCompression.BC3_Crunched_Non_Perceptual || requireCompression.GetValueOrDefault() == TextureCompression.BC3_LZMA) && (other.TextureCompression == TextureCompression.BC3_Crunched || other.TextureCompression == TextureCompression.BC3_Crunched_Non_Perceptual || other.TextureCompression == TextureCompression.BC3_LZMA))
				{
					return true;
				}
				if (requireCompression.GetValueOrDefault() == TextureCompression.BC3nm_Crunched && other.TextureCompression == TextureCompression.BC3nm_LZMA)
				{
					return true;
				}
				if (requireCompression.GetValueOrDefault() == TextureCompression.BC3nm_Crunched && (other.TextureCompression == TextureCompression.BC1_Crunched || other.TextureCompression == TextureCompression.BC1_Crunched_Non_Perceptual || other.TextureCompression == TextureCompression.BC1_LZMA))
				{
					return true;
				}
				if (requireCompression != other.TextureCompression)
				{
					return false;
				}
			}
			TextureFormat format = TextureCompression.ToFormat();
			TextureFormat format2 = TextureCompression.ToFormat();
			if (format.SupportsAlpha() && !format2.SupportsAlpha())
			{
				return false;
			}
			if (format.IsHDR() && !format2.IsHDR())
			{
				return false;
			}
			return true;
		}

		public List<D> GetBestAlternateChain(List<D> availableDescriptors, Predicate<D> variantFilter = null)
		{
			List<D> list = GenerateCloudChain();
			TextureCompression? textureCompression = null;
			textureCompression = list[0].TextureCompression;
			if (textureCompression.HasValue && textureCompression.GetValueOrDefault().IsRaw())
			{
				textureCompression = null;
			}
			list[0] = list[0].GetBestAlternateDescriptor(availableDescriptors, list[0].TextureCompression, variantFilter);
			if (list[0] == null)
			{
				return null;
			}
			TextureCompression textureCompression2 = list[0].TextureCompression;
			for (int i = 1; i < list.Count; i++)
			{
				list[i] = list[i].GetBestAlternateDescriptor(availableDescriptors, textureCompression2, variantFilter);
				if (list[i] == null)
				{
					return null;
				}
			}
			return list;
		}

		public D GetBestAlternateDescriptor(List<D> availableDescriptors, TextureCompression? requireCompression = null, Predicate<D> variantFilter = null)
		{
			float num = float.NegativeInfinity;
			D result = null;
			foreach (D availableDescriptor in availableDescriptors)
			{
				if (IsPotentialAlternative(availableDescriptor, requireCompression) && (variantFilter == null || variantFilter(availableDescriptor)))
				{
					float alternativeScore = GetAlternativeScore(availableDescriptor);
					if (alternativeScore > num)
					{
						result = availableDescriptor;
						num = alternativeScore;
					}
				}
			}
			return result;
		}

		public virtual float GetAlternativeScore(D other)
		{
			return 0f + (float)(other.CompressionQuality - CompressionQuality) / 100f + (float)(other.TextureCompression - TextureCompression) + (float)(base.VariantVersion - other.VariantVersion) * 0.1f;
		}

		public bool Equals(D other)
		{
			return Equals(other, VersionComparison.Exact);
		}

		public virtual bool Equals(D other, VersionComparison versionComparison)
		{
			if (base.OriginalAsset != other.OriginalAsset)
			{
				return false;
			}
			if (base.OriginalAsset && other.OriginalAsset)
			{
				return true;
			}
			if (!AssetVariantHelper.VersionEquals(this, other, versionComparison))
			{
				return false;
			}
			if (TextureCompression == other.TextureCompression && CompressionQuality == other.CompressionQuality && MipMaps == other.MipMaps && ColorPreprocess == other.ColorPreprocess)
			{
				return AlphaPreprocess == other.AlphaPreprocess;
			}
			return false;
		}

		public virtual string ValidateCloudVariant(M metadata)
		{
			string validationError = ValidationError;
			if (validationError != null)
			{
				return validationError;
			}
			if (base.OriginalAsset)
			{
				return "OriginalAsset variants are never handled by the cloud";
			}
			if (TextureCompression == TextureCompression.BC6H_LZMA || TextureCompression == TextureCompression.BC7_LZMA)
			{
				if (CompressionQuality != 100 && CompressionQuality != 80 && CompressionQuality != 60)
				{
					return "Invalid compression quality for BC6H or BC7";
				}
			}
			else if (CompressionQuality != 100)
			{
				return "Invalid compression quality, must be always 100 for cloud variants";
			}
			if (ColorPreprocess == ColorPreprocess.HDRsRGB && !metadata.ColorData.IsHDR())
			{
				return "Cannot preprocess color data with HDRsRGB when the color data is not HDR";
			}
			return null;
		}

		public override List<IAssetVariantDescriptor> GenerateCloudChainNonGeneric()
		{
			return GenerateCloudChain().Cast<IAssetVariantDescriptor>().ToList();
		}

		public abstract List<D> GenerateCloudChain();

		public override int GetHashCode()
		{
			return ((((((546537952 * -1521134295 + base.OriginalAsset.GetHashCode()) * -1521134295 + base.VariantVersion.GetHashCode()) * -1521134295 + TextureCompression.GetHashCode()) * -1521134295 + CompressionQuality.GetHashCode()) * -1521134295 + MipMaps.GetHashCode()) * -1521134295 + ColorPreprocess.GetHashCode()) * -1521134295 + AlphaPreprocess.GetHashCode();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	public class InvalidVariantException : Exception, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public InvalidVariantException(string message)
			: base(message)
		{
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public InvalidVariantException(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class CubemapVariantGenerator
	{
		public static List<ComputedVariantResult> GenerateVariants(string file, CubemapVariantDescriptor variantDescriptor, int maxThreads = -1, VariantGeneratedHandler variantGenerated = null, Predicate<string> variantFilter = null)
		{
			return (List<ComputedVariantResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "CubemapVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateVariants", file, variantDescriptor, maxThreads, variantGenerated, variantFilter), typeof(List<ComputedVariantResult>));
		}
	}
	public static class MeshVariantGenerator
	{
		public static List<ComputedVariantResult> GenerateVariants(string file, MeshVariantDescriptor variantDescriptor, int maxThreads = -1, VariantGeneratedHandler variantGenerated = null, Predicate<string> variantFilter = null)
		{
			return (List<ComputedVariantResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateVariants", file, variantDescriptor, maxThreads, variantGenerated, variantFilter), typeof(List<ComputedVariantResult>));
		}

		private static void ComputeMeshCollider(string file, MeshX meshx, MeshCompression compression, bool dualSided)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeMeshCollider", file, meshx, compression, dualSided);
		}

		private static void ComputeColliderData(string file, MeshCompression compression, Action<Stream, BufferPool> compute)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeColliderData", file, compression, compute);
		}

		private static void ComputeColliderData(string file, MeshCompression compression, Action<Stream> compute)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeColliderData", file, compression, compute);
		}
	}
	public static class ShaderVariantGenerator
	{
		public static List<ComputedVariantResult> GenerateVariants(string file, ShaderVariantDescriptor variantDescriptor, int maxThreads = -1, VariantGeneratedHandler variantGenerated = null, Predicate<string> variantFilter = null)
		{
			return (List<ComputedVariantResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateVariants", file, variantDescriptor, maxThreads, variantGenerated, variantFilter), typeof(List<ComputedVariantResult>));
		}
	}
	public static class Texture2DVariantGenerator
	{
		public static List<ComputedVariantResult> GenerateVariants(string file, Texture2DVariantDescriptor variantDescriptor, int maxThreads = -1, VariantGeneratedHandler variantGenerated = null, Predicate<string> variantFilter = null)
		{
			return (List<ComputedVariantResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Texture2DVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateVariants", file, variantDescriptor, maxThreads, variantGenerated, variantFilter), typeof(List<ComputedVariantResult>));
		}
	}
	public static class Texture3DVariantGenerator
	{
		public static List<ComputedVariantResult> GenerateVariants(string file, Texture3DVariantDescriptor variantDescriptor, int maxThreads = -1, VariantGeneratedHandler variantGenerated = null, Predicate<string> variantFilter = null)
		{
			return (List<ComputedVariantResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "Texture3DVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateVariants", file, variantDescriptor, maxThreads, variantGenerated, variantFilter), typeof(List<ComputedVariantResult>));
		}
	}
	internal static class TextureVariantGenerator
	{
		public static B Preprocess<B>(B bitmap, TextureCompression compression, ColorPreprocess colorPreprocess, AlphaPreprocess alphaPreprocess, bool allowARGB) where B : Bitmap, IBitmap<B>
		{
			return (B)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "TextureVariantGenerator", ResoniteBridge.ResoniteBridgeValueType.Type), "Preprocess", bitmap, compression, colorPreprocess, alphaPreprocess, allowARGB), typeof(B));
		}
	}
	[DataModelType]
	public interface IAssetVariantDescriptor : ResoniteBridge.ResoniteBridgeValueHolder
	{
		bool OriginalAsset { get; }

		bool IsValid { get; }

		string ValidationError { get; }

		string VariantIdentifier { get; }

		int VariantVersion { get; }

		void EnsureCurrentVersion();

		void GenerateLoadChain(List<string> chain);

		List<IAssetVariantDescriptor> GenerateCloudChainNonGeneric();
	}
	public interface IAssetVariantDescriptor<D, M> : IAssetVariantDescriptor, IEquatable<D>, ResoniteBridge.ResoniteBridgeValueHolder where D : IAssetVariantDescriptor<D, M> where M : IAssetMetadata
	{
		List<D> GenerateCloudChain();

		List<D> GetBestAlternateChain(List<D> availableDescriptors, Predicate<D> variantFilter = null);

		bool Equals(D other, VersionComparison versionComparison);

		string ValidateCloudVariant(M metadata);
	}
	public static class AssetMetadataHelper
	{
		public static AssetVariantType MetadataToAssetType(Type metadataType)
		{
			return (AssetVariantType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MetadataToAssetType", metadataType), typeof(AssetVariantType));
		}

		public static T ComputeMetadata<T>(string file) where T : class, IAssetMetadata
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "AssetMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "ComputeMetadata", file), typeof(T));
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class BitmapMetadata : ImageMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int METADATA_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "METADATA_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "METADATA_VERSION", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public override int LatestVersion => 5;

		[JsonProperty(PropertyName = "width")]
		[JsonPropertyName("width")]
		public int Width
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		[JsonProperty(PropertyName = "height")]
		[JsonPropertyName("height")]
		public int Height
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Height"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Height", value);
			}
		}

		[JsonProperty(PropertyName = "mipMapCount")]
		[JsonPropertyName("mipMapCount")]
		public int MipMapCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MipMapCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MipMapCount", value);
			}
		}

		[JsonProperty(PropertyName = "baseFormat")]
		[JsonPropertyName("baseFormat")]
		public string BaseFormat
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BaseFormat"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BaseFormat", value);
			}
		}

		public override void CopyFrom(IAssetMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public void CopyFrom(BitmapMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public static BitmapMetadata GenerateMetadata(string file)
		{
			return (BitmapMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", file), typeof(BitmapMetadata));
		}

		public static BitmapMetadata GenerateMetadata(Bitmap2D bitmap)
		{
			return (BitmapMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", bitmap), typeof(BitmapMetadata));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public BitmapMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class BitmapMetadataHelper
	{
		public static void GenerateMetadataShared(Bitmap bitmap, ImageMetadataBase data)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "BitmapMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadataShared", bitmap, data);
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class CubemapMetadata : ImageMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int METADATA_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "METADATA_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "METADATA_VERSION", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public override int LatestVersion => 5;

		[JsonProperty(PropertyName = "size")]
		[JsonPropertyName("size")]
		public int Size
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Size"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Size", value);
			}
		}

		[JsonProperty(PropertyName = "mipmaps")]
		[JsonPropertyName("mipmaps")]
		public bool MipMaps
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MipMaps"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MipMaps", value);
			}
		}

		public override void CopyFrom(IAssetMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public void CopyFrom(CubemapMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public static CubemapMetadata GenerateMetadata(string file)
		{
			return (CubemapMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "CubemapMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", file), typeof(CubemapMetadata));
		}

		public static CubemapMetadata GenerateMetadata(BitmapCube cube)
		{
			return (CubemapMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "CubemapMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", cube), typeof(CubemapMetadata));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public CubemapMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class DummyMetadata : IAssetMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static DummyMetadata Dummy
		{
			get
			{
				return (DummyMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "DummyMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "Dummy"), typeof(DummyMetadata));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "DummyMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "Dummy", value);
			}
		}

		public string AssetIdentifier
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AssetIdentifier"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AssetIdentifier", value);
			}
		}

		public int MetadataVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MetadataVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MetadataVersion", value);
			}
		}

		public bool IsLatestVersion
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsLatestVersion"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsLatestVersion", value);
			}
		}

		public bool IsCorrupted => false;

		public void CopyFrom(IAssetMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public DummyMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[DataModelType]
	public interface IAssetMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		string AssetIdentifier { get; set; }

		int MetadataVersion { get; set; }

		bool IsLatestVersion { get; }

		bool IsCorrupted { get; }

		void CopyFrom(IAssetMetadata other);
	}
	[DataModelType]
	public enum ColorChannelData
	{
		UNKNOWN = 0,
		Black = 1,
		White = 2,
		OneBitColor = 3,
		Grayscale = 4,
		Color = 5,
		GrayscaleHDR = 6,
		ColorHDR = 7,
		HDR = 7,
		NoColor = 1
	}
	[DataModelType]
	public enum AlphaChannelData
	{
		UNKNOWN = 0,
		FullyOpaque = 1,
		FullyTransparent = 2,
		OneBitAlpha = 3,
		Alpha = 4,
		AlphaHDR = 5,
		NoAlpha = 1
	}
	public static class ImageMetadataHelper
	{
		public static bool HasColors(this ColorChannelData data)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ImageMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "HasColors", data), typeof(bool));
		}

		public static bool IsGrayscaleOnly(this ColorChannelData data)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ImageMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsGrayscaleOnly", data), typeof(bool));
		}

		public static bool IsHDR(this ColorChannelData data)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ImageMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "IsHDR", data), typeof(bool));
		}

		public static bool CanUseOneBitAlpha(this AlphaChannelData data)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ImageMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "CanUseOneBitAlpha", data), typeof(bool));
		}

		public static bool HasTransparency(this AlphaChannelData data)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ImageMetadataHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "HasTransparency", data), typeof(bool));
		}
	}
	public abstract class ImageMetadataBase : IAssetMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private const float MAX_COLOR_DISTANCE = 0.003921569f;

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public abstract int LatestVersion { get; }

		[JsonProperty(PropertyName = "isCorrupted")]
		[JsonPropertyName("isCorrupted")]
		public bool IsCorrupted { get; set; }

		[JsonProperty(PropertyName = "metadataVersion")]
		[JsonPropertyName("metadataVersion")]
		public int MetadataVersion { get; set; }

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsLatestVersion => MetadataVersion == LatestVersion;

		[JsonProperty(PropertyName = "assetIdenfitier")]
		[JsonPropertyName("assetIdenfitier")]
		public string AssetIdentifier { get; set; }

		[JsonProperty(PropertyName = "bitsPerPixel")]
		[JsonPropertyName("bitsPerPixel")]
		public double BitsPerPixel { get; set; }

		[JsonProperty(PropertyName = "channelCount")]
		[JsonPropertyName("channelCount")]
		public int ChannelCount { get; set; }

		[JsonProperty(PropertyName = "colorData")]
		[JsonPropertyName("colorData")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ColorChannelData ColorData { get; set; }

		[JsonProperty(PropertyName = "alphaData")]
		[JsonPropertyName("alphaData")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public AlphaChannelData AlphaData { get; set; }

		[JsonProperty(PropertyName = "averageColor")]
		[JsonPropertyName("averageColor")]
		public color AverageColor { get; set; }

		[JsonProperty(PropertyName = "averageVisibleColor")]
		[JsonPropertyName("averageVisibleColor")]
		public color AverageVisibleColor { get; set; }

		[JsonProperty(PropertyName = "averageHSV")]
		[JsonPropertyName("averageHSV")]
		public ColorHSV AverageHSV { get; set; }

		[JsonProperty(PropertyName = "averageVisibleHSV")]
		[JsonPropertyName("averageVisibleHSV")]
		public ColorHSV AverageVisibleHSV { get; set; }

		[JsonProperty(PropertyName = "invalidPixelCount")]
		[JsonPropertyName("invalidPixelCount")]
		public int InvalidPixelCount { get; set; }

		public abstract void CopyFrom(IAssetMetadata metadata);

		public void CopyFrom(ImageMetadataBase metadata)
		{
			AssetIdentifier = metadata.AssetIdentifier;
			MetadataVersion = metadata.MetadataVersion;
			ColorData = metadata.ColorData;
			AlphaData = metadata.AlphaData;
		}

		protected void InitGeneration()
		{
			MetadataVersion = LatestVersion;
			ColorData = ColorChannelData.UNKNOWN;
			AlphaData = AlphaChannelData.UNKNOWN;
		}

		internal bool UpdateColorData(in color c, TextureFormat format)
		{
			ColorChannelData colorDataType = GetColorDataType(in c);
			AlphaChannelData alphaDataType = GetAlphaDataType(in c);
			if ((colorDataType == ColorChannelData.GrayscaleHDR && ColorData == ColorChannelData.Color) || (colorDataType == ColorChannelData.Color && ColorData == ColorChannelData.GrayscaleHDR))
			{
				ColorData = ColorChannelData.ColorHDR;
			}
			else if ((colorDataType == ColorChannelData.White && ColorData == ColorChannelData.Black) || (colorDataType == ColorChannelData.Black && ColorData == ColorChannelData.White))
			{
				ColorData = ColorChannelData.OneBitColor;
			}
			else if (colorDataType > ColorData)
			{
				ColorData = colorDataType;
			}
			if ((alphaDataType == AlphaChannelData.FullyTransparent && AlphaData == AlphaChannelData.FullyOpaque) || (alphaDataType == AlphaChannelData.FullyOpaque && AlphaData == AlphaChannelData.FullyTransparent))
			{
				AlphaData = AlphaChannelData.OneBitAlpha;
			}
			else if (alphaDataType > AlphaData)
			{
				AlphaData = alphaDataType;
			}
			if (IsMaxDataLevel(format, colorDataType) && IsMaxDataLevel(format, alphaDataType))
			{
				return true;
			}
			return false;
		}

		protected static ColorChannelData GetColorDataType(in color c)
		{
			if (MathX.Distance(c.r, c.g) <= 0.003921569f && MathX.Distance(c.r, c.b) <= 0.003921569f)
			{
				if (MathX.Approximately(c.r, 0f))
				{
					return ColorChannelData.Black;
				}
				if (MathX.Approximately(c.r, 1f))
				{
					return ColorChannelData.White;
				}
				if (c.r > 1f)
				{
					return ColorChannelData.GrayscaleHDR;
				}
				return ColorChannelData.Grayscale;
			}
			if (c.r > 1f || c.g > 1f || c.b > 1f)
			{
				return ColorChannelData.ColorHDR;
			}
			return ColorChannelData.Color;
		}

		protected static AlphaChannelData GetAlphaDataType(in color c)
		{
			if (MathX.Approximately(c.a, 1f))
			{
				return AlphaChannelData.FullyOpaque;
			}
			if (MathX.Approximately(c.a, 0f))
			{
				return AlphaChannelData.FullyTransparent;
			}
			if (c.a > 1f)
			{
				return AlphaChannelData.AlphaHDR;
			}
			return AlphaChannelData.Alpha;
		}

		protected static bool IsMaxDataLevel(TextureFormat format, ColorChannelData data)
		{
			if (format.IsHDR())
			{
				return data == ColorChannelData.ColorHDR;
			}
			if (format == TextureFormat.Alpha8)
			{
				return data == ColorChannelData.Black;
			}
			return data == ColorChannelData.Color;
		}

		protected static bool IsMaxDataLevel(TextureFormat format, AlphaChannelData data)
		{
			if (!format.SupportsAlpha())
			{
				return data == AlphaChannelData.FullyOpaque;
			}
			if (!format.IsHDR())
			{
				return data == AlphaChannelData.Alpha;
			}
			return data == AlphaChannelData.AlphaHDR;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class MeshMetadata : IAssetMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int METADATA_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "METADATA_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "METADATA_VERSION", value);
			}
		}

		[JsonProperty(PropertyName = "metadataVersion")]
		[JsonPropertyName("metadataVersion")]
		public int MetadataVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MetadataVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MetadataVersion", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsLatestVersion => MetadataVersion == 1;

		[JsonProperty(PropertyName = "isCorrupted")]
		[JsonPropertyName("isCorrupted")]
		public bool IsCorrupted
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsCorrupted"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsCorrupted", value);
			}
		}

		[JsonProperty(PropertyName = "assetIdenfitier")]
		[JsonPropertyName("assetIdenfitier")]
		public string AssetIdentifier
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AssetIdentifier"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AssetIdentifier", value);
			}
		}

		[JsonProperty(PropertyName = "vertexCount")]
		[JsonPropertyName("vertexCount")]
		public int VertexCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VertexCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VertexCount", value);
			}
		}

		[JsonProperty(PropertyName = "invalidVertexCount")]
		[JsonPropertyName("invalidVertexCount")]
		public int InvalidVertexCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "InvalidVertexCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "InvalidVertexCount", value);
			}
		}

		[JsonProperty(PropertyName = "totalTriangleCount")]
		[JsonPropertyName("totalTriangleCount")]
		public int TotalTriangleCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TotalTriangleCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TotalTriangleCount", value);
			}
		}

		[JsonProperty(PropertyName = "totalPointCount")]
		[JsonPropertyName("totalPointCount")]
		public int TotalPointCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TotalPointCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TotalPointCount", value);
			}
		}

		[JsonProperty(PropertyName = "submeshCount")]
		[JsonPropertyName("submeshCount")]
		public int SubmeshCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SubmeshCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SubmeshCount", value);
			}
		}

		[JsonProperty(PropertyName = "boneCount")]
		[JsonPropertyName("boneCount")]
		public int BoneCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BoneCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BoneCount", value);
			}
		}

		[JsonProperty(PropertyName = "blendshapeCount")]
		[JsonPropertyName("blendshapeCount")]
		public int BlendshapeCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BlendshapeCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BlendshapeCount", value);
			}
		}

		[JsonProperty(PropertyName = "hasNormals")]
		[JsonPropertyName("hasNormals")]
		public bool HasNormals
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasNormals"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasNormals", value);
			}
		}

		[JsonProperty(PropertyName = "hasTangents")]
		[JsonPropertyName("hasTangents")]
		public bool HasTangents
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasTangents"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasTangents", value);
			}
		}

		[JsonProperty(PropertyName = "hasColors")]
		[JsonPropertyName("hasColors")]
		public bool HasColors
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasColors"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasColors", value);
			}
		}

		[JsonProperty(PropertyName = "hasBoneBindings")]
		[JsonPropertyName("hasBoneBindings")]
		public bool HasBoneBindings
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "HasBoneBindings"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "HasBoneBindings", value);
			}
		}

		[JsonProperty(PropertyName = "UV0dimension")]
		[JsonPropertyName("UV0dimension")]
		public int UV0dimension
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV0dimension"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV0dimension", value);
			}
		}

		[JsonProperty(PropertyName = "UV1dimension")]
		[JsonPropertyName("UV1dimension")]
		public int UV1dimension
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV1dimension"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV1dimension", value);
			}
		}

		[JsonProperty(PropertyName = "UV2dimension")]
		[JsonPropertyName("UV2dimension")]
		public int UV2dimension
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV2dimension"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV2dimension", value);
			}
		}

		[JsonProperty(PropertyName = "UV3dimension")]
		[JsonPropertyName("UV3dimension")]
		public int UV3dimension
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UV3dimension"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UV3dimension", value);
			}
		}

		[JsonProperty(PropertyName = "bounds")]
		[JsonPropertyName("bounds")]
		public Elements.Core.BoundingBox Bounds
		{
			get
			{
				return (Elements.Core.BoundingBox)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Bounds"), typeof(Elements.Core.BoundingBox));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Bounds", value);
			}
		}

		[JsonProperty(PropertyName = "smallestTriangleSize")]
		[JsonPropertyName("smallestTriangleSize")]
		public float SmallestTriangleSize
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SmallestTriangleSize"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SmallestTriangleSize", value);
			}
		}

		[JsonProperty(PropertyName = "largestTriangleSize")]
		[JsonPropertyName("largestTriangleSize")]
		public float LargestTriangleSize
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LargestTriangleSize"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LargestTriangleSize", value);
			}
		}

		[JsonProperty(PropertyName = "averageTriangleSize")]
		[JsonPropertyName("averageTriangleSize")]
		public float AverageTriangleSize
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AverageTriangleSize"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AverageTriangleSize", value);
			}
		}

		[JsonProperty(PropertyName = "medianTriangleSize")]
		[JsonPropertyName("medianTriangleSize")]
		public float MedianTriangleSize
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MedianTriangleSize"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MedianTriangleSize", value);
			}
		}

		[JsonProperty(PropertyName = "smallestTriangleArea")]
		[JsonPropertyName("smallestTriangleArea")]
		public float SmallestTriangleArea
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SmallestTriangleArea"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SmallestTriangleArea", value);
			}
		}

		[JsonProperty(PropertyName = "largestTriangleArea")]
		[JsonPropertyName("largestTriangleArea")]
		public float LargestTriangleArea
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LargestTriangleArea"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LargestTriangleArea", value);
			}
		}

		[JsonProperty(PropertyName = "averageTriangleArea")]
		[JsonPropertyName("averageTriangleArea")]
		public float AverageTriangleArea
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AverageTriangleArea"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AverageTriangleArea", value);
			}
		}

		[JsonProperty(PropertyName = "medianTriangleArea")]
		[JsonPropertyName("medianTriangleArea")]
		public float MedianTriangleArea
		{
			get
			{
				return (float)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MedianTriangleArea"), typeof(float));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MedianTriangleArea", value);
			}
		}

		[JsonProperty(PropertyName = "submeshMetadata")]
		[JsonPropertyName("submeshMetadata")]
		public List<SubmeshMetadata> SubmeshMetadata
		{
			get
			{
				return (List<SubmeshMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SubmeshMetadata"), typeof(List<SubmeshMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SubmeshMetadata", value);
			}
		}

		[JsonProperty(PropertyName = "boneMetadata")]
		[JsonPropertyName("boneMetadata")]
		public List<BoneMetadata> BoneMetadata
		{
			get
			{
				return (List<BoneMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BoneMetadata"), typeof(List<BoneMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BoneMetadata", value);
			}
		}

		[JsonProperty(PropertyName = "approximateBoneBounds")]
		[JsonPropertyName("approximateBoneBounds")]
		public List<ApproximateBoneBounds> ApproximateBoneBounds
		{
			get
			{
				return (List<ApproximateBoneBounds>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ApproximateBoneBounds"), typeof(List<ApproximateBoneBounds>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ApproximateBoneBounds", value);
			}
		}

		public void CopyFrom(IAssetMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public void CopyFrom(MeshMetadata mesh)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", mesh);
		}

		public static MeshMetadata GenerateMetadata(string file)
		{
			return (MeshMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", file), typeof(MeshMetadata));
		}

		public static MeshMetadata GenerateMetadata(MeshX mesh)
		{
			return (MeshMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "MeshMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", mesh), typeof(MeshMetadata));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public MeshMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class ShaderSourceFile : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "filename")]
		[JsonPropertyName("filename")]
		public string FileName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FileName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FileName", value);
			}
		}

		[JsonProperty(PropertyName = "hash")]
		[JsonPropertyName("hash")]
		public string Hash
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Hash"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Hash", value);
			}
		}

		public ShaderSourceFile()
		{
		}

		public ShaderSourceFile(string filename, string hash)
		{
			FileName = filename;
			Hash = hash;
		}

		public ShaderSourceFile Clone()
		{
			return (ShaderSourceFile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone"), typeof(ShaderSourceFile));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ShaderSourceFile(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class ShaderMetadata : IAssetMetadata, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int METADATA_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "METADATA_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "METADATA_VERSION", value);
			}
		}

		[JsonProperty(PropertyName = "metadataVersion")]
		[JsonPropertyName("metadataVersion")]
		public int MetadataVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MetadataVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MetadataVersion", value);
			}
		}

		[JsonProperty(PropertyName = "isCorrupted")]
		[JsonPropertyName("isCorrupted")]
		public bool IsCorrupted
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsCorrupted"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsCorrupted", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsLatestVersion => MetadataVersion == 0;

		[JsonProperty(PropertyName = "assetIdenfitier")]
		[JsonPropertyName("assetIdenfitier")]
		public string AssetIdentifier
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AssetIdentifier"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AssetIdentifier", value);
			}
		}

		[JsonProperty(PropertyName = "origin")]
		[JsonPropertyName("origin")]
		public string Origin
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Origin"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Origin", value);
			}
		}

		[JsonProperty(PropertyName = "sourceFile")]
		[JsonPropertyName("sourceFile")]
		public ShaderSourceFile SourceFile
		{
			get
			{
				return (ShaderSourceFile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SourceFile"), typeof(ShaderSourceFile));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SourceFile", value);
			}
		}

		[JsonProperty(PropertyName = "includeFiles")]
		[JsonPropertyName("includeFiles")]
		public List<ShaderSourceFile> IncludeFiles
		{
			get
			{
				return (List<ShaderSourceFile>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IncludeFiles"), typeof(List<ShaderSourceFile>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IncludeFiles", value);
			}
		}

		[JsonProperty(PropertyName = "variantGroups")]
		[JsonPropertyName("variantGroups")]
		public List<List<string>> VariantGroups
		{
			get
			{
				return (List<List<string>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "VariantGroups"), typeof(List<List<string>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "VariantGroups", value);
			}
		}

		[JsonProperty(PropertyName = "uniqueKeywords")]
		[JsonPropertyName("uniqueKeywords")]
		public List<string> UniqueKeywords
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UniqueKeywords"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UniqueKeywords", value);
			}
		}

		public IEnumerable<ShaderSourceFile> AllSourceFiles
		{
			get
			{
				return (IEnumerable<ShaderSourceFile>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AllSourceFiles"), typeof(IEnumerable<ShaderSourceFile>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AllSourceFiles", value);
			}
		}

		public ShaderMetadata()
		{
		}

		public static ShaderMetadata LoadFromJSON(string json)
		{
			return (ShaderMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "LoadFromJSON", json), typeof(ShaderMetadata));
		}

		public ShaderMetadata(string origin, ShaderSourceFile sourceFile, List<List<string>> variantGroups, List<ShaderSourceFile> includes)
		{
			Origin = origin;
			SourceFile = sourceFile;
			VariantGroups = variantGroups;
			IncludeFiles = includes;
			GenerateUniqueKeywords();
		}

		public static ShaderMetadata GenerateMetadata(string file)
		{
			return (ShaderMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "ShaderMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", file), typeof(ShaderMetadata));
		}

		public void CopyFrom(IAssetMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public void CopyFrom(ShaderMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public IEnumerable<List<string>> EnumerateAllVariants(bool returnCopy = true)
		{
			return (IEnumerable<List<string>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnumerateAllVariants", returnCopy), typeof(IEnumerable<List<string>>));
		}

		private IEnumerable<List<string>> EnumerateVariants(List<string> baseVariants, int groupIndex, bool returnCopy = true)
		{
			return (IEnumerable<List<string>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnumerateVariants", baseVariants, groupIndex, returnCopy), typeof(IEnumerable<List<string>>));
		}

		public uint GetVariantIndex(List<string> keywords)
		{
			return (uint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariantIndex", keywords), typeof(uint));
		}

		public int GetKeywordIndex(string keyword)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetKeywordIndex", keyword), typeof(int));
		}

		public bool IsValidIndex(uint index)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsValidIndex", index), typeof(bool));
		}

		public void GenerateUniqueKeywords()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateUniqueKeywords");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public ShaderMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class VolumeMetadata : ImageMetadataBase, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int METADATA_VERSION
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "METADATA_VERSION"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "METADATA_VERSION", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public override int LatestVersion => 1;

		[JsonProperty(PropertyName = "width")]
		[JsonPropertyName("width")]
		public int Width
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Width"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Width", value);
			}
		}

		[JsonProperty(PropertyName = "height")]
		[JsonPropertyName("height")]
		public int Height
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Height"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Height", value);
			}
		}

		[JsonProperty(PropertyName = "depth")]
		[JsonPropertyName("depth")]
		public int Depth
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Depth"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Depth", value);
			}
		}

		[JsonProperty(PropertyName = "baseFormat")]
		[JsonPropertyName("baseFormat")]
		public string BaseFormat
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "BaseFormat"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "BaseFormat", value);
			}
		}

		public override void CopyFrom(IAssetMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public void CopyFrom(VolumeMetadata metadata)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CopyFrom", metadata);
		}

		public static VolumeMetadata GenerateMetadata(string file)
		{
			return (VolumeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VolumeMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", file), typeof(VolumeMetadata));
		}

		public static VolumeMetadata GenerateMetadata(Bitmap3D bitmap)
		{
			return (VolumeMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "Elements.Assets", "VolumeMetadata", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMetadata", bitmap), typeof(VolumeMetadata));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return this.__backing;
			}
			set
			{
				this.__backing = value;
			}
		}

		public VolumeMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
}
