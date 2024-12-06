using ResoniteBridge;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using Elements.Assets;
using Elements.Core;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using SkyFrost.Base;

namespace Microsoft.CodeAnalysis
{
}
namespace System.Runtime.CompilerServices
{
}
namespace FrooxEngine.Store
{
	public class AssetRecord : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "id"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "id", value);
			}
		}

		public System.String url
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "url"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "url", value);
			}
		}

		public System.String path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "path", value);
			}
		}

		public System.String signature
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "signature"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "signature", value);
			}
		}

		public System.String cloudsig
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "cloudsig"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "cloudsig", value);
			}
		}

		public System.Int64 bytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "bytes"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "bytes", value);
			}
		}

		public byte[] encryptionKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "encryptionKey"), typeof(byte[])) is byte[] __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "encryptionKey", value);
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

		public AssetRecord(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AssetRecord()
		{
		}
	}
	public class LocalDatabaseAccountDataStore : IAccountDataStore, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public LocalDB Database
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Database"), typeof(LocalDB)) is LocalDB __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LocalDB");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Database", value);
			}
		}

		private Dictionary<string, int> _fetchedRecords
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_fetchedRecords"), typeof(Dictionary<string, int>)) is Dictionary<string, int> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, int>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_fetchedRecords", value);
			}
		}

		public IPlatformProfile PlatformProfile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PlatformProfile"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PlatformProfile", value);
			}
		}

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
		}

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

		public System.Int32 FetchedGroupCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FetchedGroupCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FetchedGroupCount", value);
			}
		}

		public System.Boolean MachineOwnerOnly
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MachineOwnerOnly"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MachineOwnerOnly", value);
			}
		}

		public event Action<string> ProgressMessage;

		public LocalDatabaseAccountDataStore(LocalDB database, IPlatformProfile platform, System.Boolean machineOwnerOnly)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDatabaseAccountDataStore", ResoniteBridge.ResoniteBridgeValueType.Type), database, platform, machineOwnerOnly);
		}

		public Task Complete()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Complete"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<User> GetUser()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser"), typeof(Task<User>)) is Task<User> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<ExitMessage>> GetExitMessages()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExitMessages"), typeof(Task<List<ExitMessage>>)) is Task<List<ExitMessage>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<PatreonFundingEvent>> GetPatreonFundingEvents()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<List<PatreonFundingEvent>>)) is Task<List<PatreonFundingEvent>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordAuditLog(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task DownloadAsset(System.String hash, System.String targetPath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DownloadAsset", hash, targetPath), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Int32 FetchedRecordCount(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchedRecordCount", ownerId), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<string> GetAsset(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsset", hash), typeof(Task<string>)) is Task<string> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<long> GetAssetSize(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetSize", hash), typeof(Task<long>)) is Task<long> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private Task<AssetRecord> GetAssetRecord(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetRecord", hash), typeof(Task<AssetRecord>)) is Task<AssetRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<Contact>> GetContacts()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<List<Contact>>)) is Task<List<Contact>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetGroups()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroups"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<DateTime> GetLatestMessageTime(System.String contactId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestMessageTime", contactId), typeof(Task<DateTime>)) is Task<DateTime> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<DateTime?> GetLatestRecordTime(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestRecordTime", ownerId), typeof(Task<DateTime?>)) is Task<DateTime?> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<MemberData>> GetMembers(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMembers", groupId), typeof(Task<List<MemberData>>)) is Task<List<MemberData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetMessages(System.String contactId, DateTime? from)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", contactId, from), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<SkyFrost.Base.Record> GetRecord(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId), typeof(Task<SkyFrost.Base.Record>)) is Task<SkyFrost.Base.Record> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private Task ComputeManifest(Record record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ComputeManifest", record), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecords(System.String ownerId, DateTime? from, Action<string> searchProgressReport = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<CloudVariable> GetVariable(System.String ownerId, System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", ownerId, path), typeof(Task<CloudVariable>)) is Task<CloudVariable> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<CloudVariableDefinition>> GetVariableDefinitions(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariableDefinitions", ownerId), typeof(Task<List<CloudVariableDefinition>>)) is Task<List<CloudVariableDefinition>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<CloudVariable>> GetVariables(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariables", ownerId), typeof(Task<List<CloudVariable>>)) is Task<List<CloudVariable>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task Prepare()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Prepare"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<AssetData> ReadAsset(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadAsset", hash), typeof(Task<AssetData>)) is Task<AssetData> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreContact(Contact contact, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreContact", contact, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreDefinitions(List<CloudVariableDefinition> definition, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreDefinitions", definition, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreGroup(Group group, Storage storage, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreGroup", group, storage, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMember", group, member, storage, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreMessage(Message message, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<StoreResultData> StoreRecord(SkyFrost.Base.Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks = null, System.Boolean forceConflictOverwrite = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecord", record, source, statusCallbacks, forceConflictOverwrite), typeof(Task<StoreResultData>)) is Task<StoreResultData> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreVariables(List<CloudVariable> variable, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVariables", variable, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreUserData(User user)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreUserData", user), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreExitMessage(ExitMessage exitMessage)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreExitMessage", exitMessage), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreFundingEvent(PatreonFundingEvent patreonFunding)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreFundingEvent", patreonFunding), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreRecordAudit(RecordAuditInfo info)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecordAudit", info), typeof(Task)) is Task __retCasted)
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

		public LocalDatabaseAccountDataStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalDatabaseAccountDataStore()
		{
		}
	}
	public class LocalDB : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public enum ImportLocation
		{
			Original,
			Copy,
			Move
		}

		public struct VariableResult<T> : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public T value
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "value"), typeof(T)) is T __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "value", value);
				}
			}

			public System.Boolean hasValue
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "hasValue"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "hasValue", value);
				}
			}

			public VariableResult(T value)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "VariableResult", ResoniteBridge.ResoniteBridgeValueType.Type), value);
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return __backing;
				}
				set
				{
					__backing = value;
				}
			}

			public VariableResult(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public VariableResult()
			{
			}
		}

		private static Type connectorType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "connectorType"), typeof(Type)) is Type __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Type");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "connectorType", value);
			}
		}

		private System.Boolean markedForRepair
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "markedForRepair"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "markedForRepair", value);
			}
		}

		private System.String initSubphase
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "initSubphase"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "initSubphase", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue appDB
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "appDB"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LiteDatabaseAsync");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "appDB", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue assets
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assets"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILiteCollectionAsync<AssetRecord>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assets", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue records
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "records"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILiteCollectionAsync<Record>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "records", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue variables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "variables"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILiteCollectionAsync<LocalVariable>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "variables", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue visits
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "visits"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILiteCollectionAsync<LocalVisit>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "visits", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue assetMetadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetMetadata"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILiteCollectionAsync<LocalMetadata>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetMetadata", value);
			}
		}

		private HashSet<string> _precachePaths
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_precachePaths"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_precachePaths", value);
			}
		}

		private System.String RepairMarkFile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "RepairMarkFile"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "RepairMarkFile", value);
			}
		}

		private RSACryptoServiceProvider _machineCryptoProvider
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_machineCryptoProvider"), typeof(RSACryptoServiceProvider)) is RSACryptoServiceProvider __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RSACryptoServiceProvider");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_machineCryptoProvider", value);
			}
		}

		private RSAParameters _localMachineKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_localMachineKey"), typeof(RSAParameters)) is RSAParameters __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RSAParameters");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_localMachineKey", value);
			}
		}

		private static ushort[] INIT_TABLE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "INIT_TABLE"), typeof(ushort[])) is ushort[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ushort[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "INIT_TABLE", value);
			}
		}

		private static ushort[] SEED_TABLE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "SEED_TABLE"), typeof(ushort[])) is ushort[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ushort[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "SEED_TABLE", value);
			}
		}

		private Dictionary<string, List<Action>> variableListeners
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "variableListeners"), typeof(Dictionary<string, List<Action>>)) is Dictionary<string, List<Action>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, List<Action>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "variableListeners", value);
			}
		}

		public System.Int32 IV_SIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "IV_SIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "IV_SIZE", value);
			}
		}

		public System.Int32 KEY_SIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "KEY_SIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "KEY_SIZE", value);
			}
		}

		public SkyFrostInterface Cloud
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface)) is SkyFrostInterface __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostInterface");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Cloud", value);
			}
		}

		public System.Boolean DatabaseCorrupted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DatabaseCorrupted"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.String PermanentPath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PermanentPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PermanentPath", value);
			}
		}

		public System.String TemporaryPath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TemporaryPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TemporaryPath", value);
			}
		}

		public System.String AssetCachePath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetCachePath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetCachePath", value);
			}
		}

		public System.String AssetStoragePath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetStoragePath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetStoragePath", value);
			}
		}

		public System.String DatabaseFile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DatabaseFile"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DatabaseFile", value);
			}
		}

		public System.String LocalKeyFile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalKeyFile"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LocalKeyFile", value);
			}
		}

		public System.String MachineID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MachineID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MachineID", value);
			}
		}

		public System.String SecretMachineID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretMachineID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretMachineID", value);
			}
		}

		public System.String LocalOwnerID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalOwnerID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public byte[] PublicKeyExponent
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicKeyExponent"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
		}

		public byte[] PublicKeyModulus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicKeyModulus"), typeof(byte[])) is byte[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to byte[]");
				}
			}
		}

		public System.Boolean IsDisposed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDisposed"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsDisposed", value);
			}
		}

		private event Action _databaseCorruptionDetected;

		public event Action DatabaseCorruptionDetected
		{
			add
			{
				Task.Run(async delegate
				{
					if (DatabaseCorrupted)
					{
						value();
					}
					else
					{
						_databaseCorruptionDetected += value;
					}
				});
			}
			remove
			{
				Task.Run(async delegate
				{
					_databaseCorruptionDetected -= value;
				});
			}
		}

		public byte[] SignHash(byte[] hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignHash", hash), typeof(byte[])) is byte[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String GenerateGUIDSignature()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateGUIDSignature"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean IsValidMachineId(System.String machineId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidMachineId", machineId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String GenerateMachineID(RSAParameters rsa)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMachineID", rsa), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.Boolean MachineIdMatches(System.String machineId, RSAParameters rsa)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "MachineIdMatches", machineId, rsa), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static byte[] HashPublicKey(RSAParameters rsa)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "HashPublicKey", rsa), typeof(byte[])) is byte[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String ProcessUrl(System.Uri url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessUrl", url), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static System.String ProcessUrl(System.String url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessUrl", url), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<int> GetRecordCount()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordCount"), typeof(Task<int>)) is Task<int> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public unsafe static System.String ProcessConnection(System.String connection, System.String seed)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessConnection", connection, seed), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task Initialize(IProgressIndicator progress)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", progress), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public LocalDB(SkyFrostInterface cloud, System.String permanentPath, System.String temporaryPath, HashSet<string> precachePaths)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), cloud, permanentPath, temporaryPath, precachePaths);
		}

		public void AssignCloud(SkyFrostInterface cloud)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AssignCloud", cloud);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public void CheckValid()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CheckValid");
		}

		public System.String GetTempFileName(System.String extension)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetTempFileName", extension), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.String GetTempFilePath(System.String extension)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetTempFilePath", extension), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.String GetTempFilePath()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetTempFilePath"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Boolean IsPathWithinDatabase(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPathWithinDatabase", path), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private Task MarkDatabaseForRepair(Exception ex)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkDatabaseForRepair", ex), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public List<T> RepairExtractAllEntries<T>(ResoniteBridge.ResoniteBridgeValue database, System.String collectionName, Func<T, string> uniqueKeySelector = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RepairExtractAllEntries", database, collectionName, uniqueKeySelector), typeof(List<T>)) is List<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GenerateLocalURL(System.String extension, System.String signature = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateLocalURL", extension, signature), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> ImportLocalAssetAsync(System.String path, ImportLocation location, System.String forceSignature = null, System.String cloudSig = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ImportLocalAssetAsync", path, location, forceSignature, cloudSig), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<AssetRecord>> GetAllVariantsAsync(System.Uri assetURL)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAllVariantsAsync", assetURL), typeof(Task<List<AssetRecord>>)) is Task<List<AssetRecord>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<string> StoreCacheRecordAsync(System.Uri assetURL, System.String path, System.Boolean encrypt = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreCacheRecordAsync", assetURL, path, encrypt), typeof(Task<string>)) is Task<string> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task DeleteCacheRecordAsync(System.Uri assetURL)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteCacheRecordAsync", assetURL), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task StoreAssetRecordAsync(System.Uri assetURL, System.String path, byte[] encryptionKey = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreAssetRecordAsync", assetURL, path, encryptionKey), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private Task InsertAssetRecordAsync(AssetRecord assetRecord)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InsertAssetRecordAsync", assetRecord), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private Task InsertRecordAsync(Record record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InsertRecordAsync", record), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> EnsurePermanentStorageAsync(System.Uri assetURL, System.Boolean ignoreMissing = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsurePermanentStorageAsync", assetURL, ignoreMissing), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<AssetRecord> TryFetchAssetBySignatureAsync(System.String signature)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryFetchAssetBySignatureAsync", signature), typeof(Task<AssetRecord>)) is Task<AssetRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<AssetRecord> TryFetchAssetByCloudSignatureAsync(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryFetchAssetByCloudSignatureAsync", hash), typeof(Task<AssetRecord>)) is Task<AssetRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private Task<AssetRecord> FindAssetRecordWithExistingAsset(ResoniteBridge.ResoniteBridgeValue predicate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindAssetRecordWithExistingAsset", predicate), typeof(Task<AssetRecord>)) is Task<AssetRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<AssetRecord> TryFetchAssetRecordAsync(System.Uri assetURL)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryFetchAssetRecordAsync", assetURL), typeof(Task<AssetRecord>)) is Task<AssetRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<Stream> TryOpenAsset(System.Uri assetURL)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryOpenAsset", assetURL), typeof(Task<Stream>)) is Task<Stream> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<AssetRecord> TryFetchAssetRecordWithMetadataAsync(System.Uri assetURL)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryFetchAssetRecordWithMetadataAsync", assetURL), typeof(Task<AssetRecord>)) is Task<AssetRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		private void UnpackAssetRecord(AssetRecord record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnpackAssetRecord", record);
		}

		private void PackAssetRecord(AssetRecord record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PackAssetRecord", record);
		}

		public Task<IAssetMetadata> TryFetchAssetMetadataAsync(System.String identifier)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryFetchAssetMetadataAsync", identifier), typeof(Task<IAssetMetadata>)) is Task<IAssetMetadata> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.String MetadataIdentifier(IAssetMetadata metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MetadataIdentifier", metadata), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task SaveAssetMetadataAsync(IAssetMetadata metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAssetMetadataAsync", metadata), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<Record> TryFetchRecordAsync(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryFetchRecordAsync", ownerId, recordId), typeof(Task<Record>)) is Task<Record> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<bool> StoreRecordAsync(Record record, Func<Record, bool> overwriteCheck = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecordAsync", record, overwriteCheck), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<bool> DeleteRecordAsync(System.Uri recordUri)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecordAsync", recordUri), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<bool> DeleteRecordAsync(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecordAsync", ownerId, recordId), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<bool> DeleteRecordAsync(Record record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecordAsync", record), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task UpdateRecordAsync(System.String ownerId, System.String recordId, Func<Record, bool> updateFunc)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateRecordAsync", ownerId, recordId, updateFunc), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<List<Record>> FetchRecordsAsync(ResoniteBridge.ResoniteBridgeValue predicate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchRecordsAsync", predicate), typeof(Task<List<Record>>)) is Task<List<Record>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<Record> FetchRecordAsync(ResoniteBridge.ResoniteBridgeValue predicate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchRecordAsync", predicate), typeof(Task<Record>)) is Task<Record> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> SaveAssetAsync(Bitmap2D texture, System.String extension = "webp", System.Int32 quality = int.MaxValue, System.Boolean preserveColorInAlpha = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAssetAsync", texture, extension, quality, preserveColorInAlpha), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> SaveAssetAsync(Bitmap3D texture, System.String extension = "3dtex")
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAssetAsync", texture, extension), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> SaveAssetAsync(MeshX mesh, MeshX.Encoding encoding = MeshX.Encoding.LZ4)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAssetAsync", mesh, encoding), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> SaveAssetAsync(AnimX anim, AnimX.Encoding encoding = AnimX.Encoding.LZMA)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAssetAsync", anim, encoding), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> SaveAssetAsync(BitmapCube texture)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAssetAsync", texture), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<System.Uri> SaveAssetAsync(AudioX audio, AudioEncodeSettings encodeSettings = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAssetAsync", audio, encodeSettings), typeof(Task<System.Uri>)) is Task<System.Uri> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public void RegisterVariableListener(System.String path, Action callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterVariableListener", path, callback);
		}

		public void UnregisterVariableListener(System.String path, Action callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterVariableListener", path, callback);
		}

		public Task<LocalVariable> GetVariableAsync(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariableAsync", path), typeof(Task<LocalVariable>)) is Task<LocalVariable> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<T> ReadVariableOrCreateAsync<T>(System.String path, T def = default(T))
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadVariableOrCreateAsync", path, def), typeof(Task<T>)) is Task<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<T> ReadVariableAsync<T>(System.String path, T def = default(T))
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadVariableAsync", path, def), typeof(Task<T>)) is Task<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<VariableResult<T>> TryReadVariableAsync<T>(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryReadVariableAsync", path), typeof(Task<VariableResult<T>>)) is Task<VariableResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<T> ReadOrInitVariableAsync<T>(System.String path, T initValue)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadOrInitVariableAsync", path, initValue), typeof(Task<T>)) is Task<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task WriteVariableAsync<T>(System.String path, T value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteVariableAsync", path, value), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<string> ReadVariableAsync(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadVariableAsync", path), typeof(Task<string>)) is Task<string> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task WriteVariableAsync(System.String path, System.String value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteVariableAsync", path, value), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<bool> DeleteVariableAsync(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteVariableAsync", path), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task<LocalVisit> GetVisitAsync(System.String url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVisitAsync", url), typeof(Task<LocalVisit>)) is Task<LocalVisit> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Task LogVisitAsync(System.String url, System.Int32 globalVersion = 0)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogVisitAsync", url, globalVersion), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public Stream OpenAssetRead(AssetRecord record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OpenAssetRead", record), typeof(Stream)) is Stream __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static byte[] GenerateKey()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateKey"), typeof(byte[])) is byte[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static CryptoStream CreateEncryptionStream(byte[] key, Stream outputStream)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateEncryptionStream", key, outputStream), typeof(CryptoStream)) is CryptoStream __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public static CryptoStream CreateDecryptionStream(byte[] key, Stream inputStream)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateDecryptionStream", key, inputStream), typeof(CryptoStream)) is CryptoStream __retCasted)
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

		public LocalDB(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalDB()
		{
		}
	}
	public static class LocalDBUtility
	{
		public static Task ExportData(System.String persistentPath, System.String tempPath, System.String exportPath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDBUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "ExportData", persistentPath, tempPath, exportPath), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}
	}
	public class LocalMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "id"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "id", value);
			}
		}

		public System.String MetadataId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MetadataId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MetadataId", value);
			}
		}

		public System.String Metadata
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Metadata"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Metadata", value);
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

		public LocalMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalMetadata()
		{
		}
	}
	public class LocalVariable : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "id"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "id", value);
			}
		}

		public System.String path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "path", value);
			}
		}

		public System.String value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "value"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "value", value);
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

		public LocalVariable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalVariable()
		{
		}
	}
	public class LocalVariableProxy<T> : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.String path
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "path", value);
			}
		}

		private T currentValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "currentValue"), typeof(T)) is T __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "currentValue", value);
			}
		}

		private T defaultValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultValue"), typeof(T)) is T __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultValue", value);
			}
		}

		private LocalDB db
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "db"), typeof(LocalDB)) is LocalDB __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to LocalDB");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "db", value);
			}
		}

		public T Value
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Value"), typeof(T)) is T __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Value", value);
			}
		}

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
		}

		public event Action<LocalVariableProxy<T>> OnChanged;

		public LocalVariableProxy(LocalDB db, System.String path, T defaultValue)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalVariableProxy", ResoniteBridge.ResoniteBridgeValueType.Type), db, path, defaultValue);
		}

		private void OnVariableChanged()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnVariableChanged");
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public static implicit operator T(LocalVariableProxy<T> proxy)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalVariableProxy", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", proxy), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
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

		public LocalVariableProxy(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalVariableProxy()
		{
		}
	}
	public class LocalVisit : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "id"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "id", value);
			}
		}

		public System.String url
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "url"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "url", value);
			}
		}

		public System.Int32 globalVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "globalVersion"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "globalVersion", value);
			}
		}

		public DateTime lastVisit
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "lastVisit"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "lastVisit", value);
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

		public LocalVisit(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public LocalVisit()
		{
		}
	}
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[DataModelType]
	public class Record : IRecord, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.Uri _cachedURL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cachedURL"), typeof(System.Uri)) is System.Uri __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cachedURL", value);
			}
		}

		private System.String _cachedURL_OwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cachedURL_OwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cachedURL_OwnerId", value);
			}
		}

		private System.String _cachedURL_RecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cachedURL_RecordId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cachedURL_RecordId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Int32 id
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "id"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "id", value);
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

		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsSynced
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsSynced"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsSynced", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public Record ConflictingCloudVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConflictingCloudVersion"), typeof(Record)) is Record __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Record");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConflictingCloudVersion", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime FetchedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FetchedOn"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FetchedOn", value);
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

		[JsonProperty(PropertyName = "rootRecordId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("rootRecordId")]
		public RecordId RootRecordId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RootRecordId"), typeof(RecordId)) is RecordId __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RootRecordId", value);
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
		public System.String LegacyLastModifyingMachineId
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyLastModifyingMachineId", value);
			}
		}

		public void ReplaceInTags(System.String oldString, System.String newString)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReplaceInTags", oldString, newString);
		}

		public void ClearRecordSpecificMetadata()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearRecordSpecificMetadata");
		}

		public System.Uri GetUrl(IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUrl", platform), typeof(System.Uri)) is System.Uri __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to returnTpe");
			}
		}

		public System.Uri GetWebURL(IPlatformProfile platform)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetWebURL", platform), typeof(System.Uri)) is System.Uri __retCasted)
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

		public static System.Boolean IsValidId(System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "Record", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", recordId), typeof(System.Boolean)) is System.Boolean __retCasted)
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

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
}
