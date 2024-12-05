using System;

using System.Collections.Generic;

using System.Diagnostics;

using System.Globalization;

using System.IO;

using System.Linq;

using System.Linq.Expressions;

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

using LiteDB;

using LiteDB.Async;

using Microsoft.CodeAnalysis;

using Newtonsoft.Json;

using SkyFrost.Base;

using Wiry.Base32;


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
namespace FrooxEngine.Store
{
	public class AssetRecord : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int id
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "id"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "id", value);
			}
		}

		public string url
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "url"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "url", value);
			}
		}

		public string path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "path", value);
			}
		}

		public string signature
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "signature"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "signature", value);
			}
		}

		public string cloudsig
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "cloudsig"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "cloudsig", value);
			}
		}

		public long bytes
		{
			get
			{
				return (long)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "bytes"), typeof(long));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "bytes", value);
			}
		}

		public byte[] encryptionKey
		{
			get
			{
				return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "encryptionKey"), typeof(byte[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "encryptionKey", value);
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

		public AssetRecord(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class LocalDatabaseAccountDataStore : IAccountDataStore, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public LocalDB Database
		{
			get
			{
				return (LocalDB)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "Database"), typeof(LocalDB));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "Database", value);
			}
		}

		private Dictionary<string, int> _fetchedRecords
		{
			get
			{
				return (Dictionary<string, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_fetchedRecords"), typeof(Dictionary<string, int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_fetchedRecords", value);
			}
		}

		public IPlatformProfile PlatformProfile
		{
			get
			{
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PlatformProfile"), typeof(IPlatformProfile));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PlatformProfile", value);
			}
		}

		public string MigrationId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MigrationId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MigrationId", value);
			}
		}

		public string Name => "LocalDB Data Store";

		public string UserId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "UserId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "UserId", value);
			}
		}

		public string Username
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Username"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Username", value);
			}
		}

		public int FetchedGroupCount
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FetchedGroupCount"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FetchedGroupCount", value);
			}
		}

		public bool MachineOwnerOnly
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MachineOwnerOnly"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MachineOwnerOnly", value);
			}
		}

		public event Action<string> ProgressMessage;

		public LocalDatabaseAccountDataStore(LocalDB database, IPlatformProfile platform, bool machineOwnerOnly)
		{
			Database = database;
			PlatformProfile = platform;
			MachineOwnerOnly = machineOwnerOnly;
			UserId = "M-" + database.MachineID;
		}

		public Task Complete()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Complete"), typeof(Task));
		}

		public async Task<User> GetUser()
		{
			return (Task<User>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUser"), typeof(Task<User>));
		}

		public async Task<List<ExitMessage>> GetExitMessages()
		{
			return (Task<List<ExitMessage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetExitMessages"), typeof(Task<List<ExitMessage>>));
		}

		public async Task<List<PatreonFundingEvent>> GetPatreonFundingEvents()
		{
			return (Task<List<PatreonFundingEvent>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetPatreonFundingEvents"), typeof(Task<List<PatreonFundingEvent>>));
		}

		public async IAsyncEnumerable<RecordAuditInfo> GetRecordAuditLog(string ownerId)
		{
			return (IAsyncEnumerable<RecordAuditInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRecordAuditLog", ownerId), typeof(IAsyncEnumerable<RecordAuditInfo>));
		}

		public async Task DownloadAsset(string hash, string targetPath)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DownloadAsset", hash, targetPath), typeof(Task));
		}

		public int FetchedRecordCount(string ownerId)
		{
			return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FetchedRecordCount", ownerId), typeof(int));
		}

		public async Task<string> GetAsset(string hash)
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetAsset", hash), typeof(Task<string>));
		}

		public async Task<long> GetAssetSize(string hash)
		{
			return (Task<long>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetAssetSize", hash), typeof(Task<long>));
		}

		private async Task<AssetRecord> GetAssetRecord(string hash)
		{
			return (Task<AssetRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetAssetRecord", hash), typeof(Task<AssetRecord>));
		}

		public Task<List<Contact>> GetContacts()
		{
			return (Task<List<Contact>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetContacts"), typeof(Task<List<Contact>>));
		}

		public async IAsyncEnumerable<GroupData> GetGroups()
		{
			return (IAsyncEnumerable<GroupData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetGroups"), typeof(IAsyncEnumerable<GroupData>));
		}

		public Task<DateTime> GetLatestMessageTime(string contactId)
		{
			return (Task<DateTime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLatestMessageTime", contactId), typeof(Task<DateTime>));
		}

		public Task<DateTime?> GetLatestRecordTime(string ownerId)
		{
			return (Task<DateTime?>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetLatestRecordTime", ownerId), typeof(Task<DateTime?>));
		}

		public Task<List<MemberData>> GetMembers(string groupId)
		{
			return (Task<List<MemberData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMembers", groupId), typeof(Task<List<MemberData>>));
		}

		public IAsyncEnumerable<Message> GetMessages(string contactId, DateTime? from)
		{
			return (IAsyncEnumerable<Message>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetMessages", contactId, from), typeof(IAsyncEnumerable<Message>));
		}

		public async Task<SkyFrost.Base.Record> GetRecord(string ownerId, string recordId)
		{
			return (Task<SkyFrost.Base.Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRecord", ownerId, recordId), typeof(Task<SkyFrost.Base.Record>));
		}

		private async Task ComputeManifest(Record record)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ComputeManifest", record), typeof(Task));
		}

		public async IAsyncEnumerable<SkyFrost.Base.Record> GetRecords(string ownerId, DateTime? from, Action<string> searchProgressReport = null)
		{
			return (IAsyncEnumerable<SkyFrost.Base.Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(IAsyncEnumerable<SkyFrost.Base.Record>));
		}

		public Task<CloudVariable> GetVariable(string ownerId, string path)
		{
			return (Task<CloudVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariable", ownerId, path), typeof(Task<CloudVariable>));
		}

		public Task<List<CloudVariableDefinition>> GetVariableDefinitions(string ownerId)
		{
			return (Task<List<CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariableDefinitions", ownerId), typeof(Task<List<CloudVariableDefinition>>));
		}

		public Task<List<CloudVariable>> GetVariables(string ownerId)
		{
			return (Task<List<CloudVariable>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariables", ownerId), typeof(Task<List<CloudVariable>>));
		}

		public Task Prepare()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Prepare"), typeof(Task));
		}

		public Task<AssetData> ReadAsset(string hash)
		{
			return (Task<AssetData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadAsset", hash), typeof(Task<AssetData>));
		}

		public Task StoreContact(Contact contact, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreContact", contact, source), typeof(Task));
		}

		public Task StoreDefinitions(List<CloudVariableDefinition> definition, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreDefinitions", definition, source), typeof(Task));
		}

		public Task StoreGroup(Group group, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreGroup", group, storage, source), typeof(Task));
		}

		public Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreMember", group, member, storage, source), typeof(Task));
		}

		public Task StoreMessage(Message message, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreMessage", message, source), typeof(Task));
		}

		public Task<StoreResultData> StoreRecord(SkyFrost.Base.Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks = null, bool forceConflictOverwrite = false)
		{
			return (Task<StoreResultData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreRecord", record, source, statusCallbacks, forceConflictOverwrite), typeof(Task<StoreResultData>));
		}

		public Task StoreVariables(List<CloudVariable> variable, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreVariables", variable, source), typeof(Task));
		}

		public Task StoreUserData(User user)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreUserData", user), typeof(Task));
		}

		public Task StoreExitMessage(ExitMessage exitMessage)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreExitMessage", exitMessage), typeof(Task));
		}

		public Task StoreFundingEvent(PatreonFundingEvent patreonFunding)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreFundingEvent", patreonFunding), typeof(Task));
		}

		public Task StoreRecordAudit(RecordAuditInfo info)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreRecordAudit", info), typeof(Task));
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

		public LocalDatabaseAccountDataStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
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
					return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "value"), typeof(T));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "value", value);
				}
			}

			public bool hasValue
			{
				get
				{
					return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "hasValue"), typeof(bool));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "hasValue", value);
				}
			}

			public VariableResult(T value)
			{
				this.value = value;
				hasValue = true;
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

			public VariableResult(ResoniteBridge.ResoniteBridgeValue value)
			{
				this.__Backing = value;
			}
		}

		private static Type connectorType
		{
			get
			{
				return (Type)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "connectorType"), typeof(Type));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "connectorType", value);
			}
		}

		private bool markedForRepair
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "markedForRepair"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "markedForRepair", value);
			}
		}

		private string initSubphase
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "initSubphase"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "initSubphase", value);
			}
		}

		private LiteDatabaseAsync appDB
		{
			get
			{
				return (LiteDatabaseAsync)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "appDB"), typeof(LiteDatabaseAsync));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "appDB", value);
			}
		}

		private ILiteCollectionAsync<AssetRecord> assets
		{
			get
			{
				return (ILiteCollectionAsync<AssetRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "assets"), typeof(ILiteCollectionAsync<AssetRecord>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "assets", value);
			}
		}

		private ILiteCollectionAsync<Record> records
		{
			get
			{
				return (ILiteCollectionAsync<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "records"), typeof(ILiteCollectionAsync<Record>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "records", value);
			}
		}

		private ILiteCollectionAsync<LocalVariable> variables
		{
			get
			{
				return (ILiteCollectionAsync<LocalVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "variables"), typeof(ILiteCollectionAsync<LocalVariable>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "variables", value);
			}
		}

		private ILiteCollectionAsync<LocalVisit> visits
		{
			get
			{
				return (ILiteCollectionAsync<LocalVisit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "visits"), typeof(ILiteCollectionAsync<LocalVisit>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "visits", value);
			}
		}

		private ILiteCollectionAsync<LocalMetadata> assetMetadata
		{
			get
			{
				return (ILiteCollectionAsync<LocalMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "assetMetadata"), typeof(ILiteCollectionAsync<LocalMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "assetMetadata", value);
			}
		}

		private HashSet<string> _precachePaths
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_precachePaths"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_precachePaths", value);
			}
		}

		private string RepairMarkFile
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "RepairMarkFile"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "RepairMarkFile", value);
			}
		}

		private RSACryptoServiceProvider _machineCryptoProvider
		{
			get
			{
				return (RSACryptoServiceProvider)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_machineCryptoProvider"), typeof(RSACryptoServiceProvider));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_machineCryptoProvider", value);
			}
		}

		private RSAParameters _localMachineKey
		{
			get
			{
				return (RSAParameters)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_localMachineKey"), typeof(RSAParameters));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_localMachineKey", value);
			}
		}

		private static ushort[] INIT_TABLE
		{
			get
			{
				return (ushort[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "INIT_TABLE"), typeof(ushort[]));
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
				return (ushort[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "SEED_TABLE"), typeof(ushort[]));
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
				return (Dictionary<string, List<Action>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "variableListeners"), typeof(Dictionary<string, List<Action>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "variableListeners", value);
			}
		}

		public int IV_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "IV_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "IV_SIZE", value);
			}
		}

		public int KEY_SIZE
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "KEY_SIZE"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "KEY_SIZE", value);
			}
		}

		public SkyFrostInterface Cloud
		{
			get
			{
				return (SkyFrostInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Cloud"), typeof(SkyFrostInterface));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Cloud", value);
			}
		}

		public bool DatabaseCorrupted => markedForRepair;

		public string PermanentPath
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "PermanentPath"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "PermanentPath", value);
			}
		}

		public string TemporaryPath
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "TemporaryPath"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "TemporaryPath", value);
			}
		}

		public string AssetCachePath
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AssetCachePath"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AssetCachePath", value);
			}
		}

		public string AssetStoragePath
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AssetStoragePath"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AssetStoragePath", value);
			}
		}

		public string DatabaseFile
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "DatabaseFile"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "DatabaseFile", value);
			}
		}

		public string LocalKeyFile
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LocalKeyFile"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LocalKeyFile", value);
			}
		}

		public string MachineID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MachineID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MachineID", value);
			}
		}

		public string SecretMachineID
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "SecretMachineID"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "SecretMachineID", value);
			}
		}

		public string LocalOwnerID => "M-" + MachineID;

		public byte[] PublicKeyExponent => _localMachineKey.Exponent;

		public byte[] PublicKeyModulus => _localMachineKey.Modulus;

		public bool IsDisposed
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsDisposed"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsDisposed", value);
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
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SignHash", hash), typeof(byte[]));
		}

		public static string GenerateGUIDSignature()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateGUIDSignature"), typeof(string));
		}

		public static bool IsValidMachineId(string machineId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidMachineId", machineId), typeof(bool));
		}

		public static string GenerateMachineID(RSAParameters rsa)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateMachineID", rsa), typeof(string));
		}

		public static bool MachineIdMatches(string machineId, RSAParameters rsa)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "MachineIdMatches", machineId, rsa), typeof(bool));
		}

		public static byte[] HashPublicKey(RSAParameters rsa)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "HashPublicKey", rsa), typeof(byte[]));
		}

		public static string ProcessUrl(Uri url)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessUrl", url), typeof(string));
		}

		public static string ProcessUrl(string url)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessUrl", url), typeof(string));
		}

		public async Task<int> GetRecordCount()
		{
			return (Task<int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetRecordCount"), typeof(Task<int>));
		}

		public unsafe static string ProcessConnection(string connection, string seed)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "ProcessConnection", connection, seed), typeof(string));
		}

		public async Task Initialize(IProgressIndicator progress)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Initialize", progress), typeof(Task));
		}

		public LocalDB(SkyFrostInterface cloud, string permanentPath, string temporaryPath, HashSet<string> precachePaths)
		{
			if (cloud != null)
			{
				AssignCloud(cloud);
			}
			if (permanentPath == null)
			{
				throw new ArgumentNullException("permanentPath");
			}
			if (temporaryPath == null)
			{
				throw new ArgumentNullException("temporaryPath");
			}
			Cloud = cloud;
			PermanentPath = permanentPath;
			TemporaryPath = temporaryPath;
			_precachePaths = precachePaths;
			AssetCachePath = Path.Combine(TemporaryPath, "Cache");
			AssetStoragePath = Path.Combine(PermanentPath, "Assets");
			LocalKeyFile = Path.Combine(PermanentPath, "LocalKey.bin");
			DatabaseFile = Path.Combine(PermanentPath, "Data.litedb");
			RepairMarkFile = Path.Combine(PermanentPath, "DatabaseRepair.mark");
		}

		public void AssignCloud(SkyFrostInterface cloud)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "AssignCloud", cloud);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public void CheckValid()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "CheckValid");
		}

		public string GetTempFileName(string extension)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTempFileName", extension), typeof(string));
		}

		public string GetTempFilePath(string extension)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTempFilePath", extension), typeof(string));
		}

		public string GetTempFilePath()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetTempFilePath"), typeof(string));
		}

		public bool IsPathWithinDatabase(string path)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IsPathWithinDatabase", path), typeof(bool));
		}

		private async Task MarkDatabaseForRepair(Exception ex)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MarkDatabaseForRepair", ex), typeof(Task));
		}

		public List<T> RepairExtractAllEntries<T>(LiteDatabase database, string collectionName, Func<T, string> uniqueKeySelector = null)
		{
			return (List<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RepairExtractAllEntries", database, collectionName, uniqueKeySelector), typeof(List<T>));
		}

		public Uri GenerateLocalURL(string extension, string signature = null)
		{
			return (Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GenerateLocalURL", extension, signature), typeof(Uri));
		}

		public async Task<Uri> ImportLocalAssetAsync(string path, ImportLocation location, string forceSignature = null, string cloudSig = null)
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ImportLocalAssetAsync", path, location, forceSignature, cloudSig), typeof(Task<Uri>));
		}

		public async Task<List<AssetRecord>> GetAllVariantsAsync(Uri assetURL)
		{
			return (Task<List<AssetRecord>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetAllVariantsAsync", assetURL), typeof(Task<List<AssetRecord>>));
		}

		public async Task<string> StoreCacheRecordAsync(Uri assetURL, string path, bool encrypt = false)
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreCacheRecordAsync", assetURL, path, encrypt), typeof(Task<string>));
		}

		public async Task DeleteCacheRecordAsync(Uri assetURL)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeleteCacheRecordAsync", assetURL), typeof(Task));
		}

		public async Task StoreAssetRecordAsync(Uri assetURL, string path, byte[] encryptionKey = null)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreAssetRecordAsync", assetURL, path, encryptionKey), typeof(Task));
		}

		private async Task InsertAssetRecordAsync(AssetRecord assetRecord)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InsertAssetRecordAsync", assetRecord), typeof(Task));
		}

		private async Task InsertRecordAsync(Record record)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "InsertRecordAsync", record), typeof(Task));
		}

		public async Task<Uri> EnsurePermanentStorageAsync(Uri assetURL, bool ignoreMissing = false)
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "EnsurePermanentStorageAsync", assetURL, ignoreMissing), typeof(Task<Uri>));
		}

		public async Task<AssetRecord> TryFetchAssetBySignatureAsync(string signature)
		{
			return (Task<AssetRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryFetchAssetBySignatureAsync", signature), typeof(Task<AssetRecord>));
		}

		public async Task<AssetRecord> TryFetchAssetByCloudSignatureAsync(string hash)
		{
			return (Task<AssetRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryFetchAssetByCloudSignatureAsync", hash), typeof(Task<AssetRecord>));
		}

		private async Task<AssetRecord> FindAssetRecordWithExistingAsset(Expression<Func<AssetRecord, bool>> predicate)
		{
			return (Task<AssetRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FindAssetRecordWithExistingAsset", predicate), typeof(Task<AssetRecord>));
		}

		public async Task<AssetRecord> TryFetchAssetRecordAsync(Uri assetURL)
		{
			return (Task<AssetRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryFetchAssetRecordAsync", assetURL), typeof(Task<AssetRecord>));
		}

		public async Task<Stream> TryOpenAsset(Uri assetURL)
		{
			return (Task<Stream>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryOpenAsset", assetURL), typeof(Task<Stream>));
		}

		public async Task<AssetRecord> TryFetchAssetRecordWithMetadataAsync(Uri assetURL)
		{
			return (Task<AssetRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryFetchAssetRecordWithMetadataAsync", assetURL), typeof(Task<AssetRecord>));
		}

		private void UnpackAssetRecord(AssetRecord record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UnpackAssetRecord", record);
		}

		private void PackAssetRecord(AssetRecord record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "PackAssetRecord", record);
		}

		public async Task<IAssetMetadata> TryFetchAssetMetadataAsync(string identifier)
		{
			return (Task<IAssetMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryFetchAssetMetadataAsync", identifier), typeof(Task<IAssetMetadata>));
		}

		public async Task<T> TryFetchAssetMetadataAsync<T>(string identifier) where T : class, IAssetMetadata
		{
			return (Task<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryFetchAssetMetadataAsync", identifier), typeof(Task<T>));
		}

		public string MetadataIdentifier(IAssetMetadata metadata)
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "MetadataIdentifier", metadata), typeof(string));
		}

		public async Task SaveAssetMetadataAsync(IAssetMetadata metadata)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveAssetMetadataAsync", metadata), typeof(Task));
		}

		public async Task<Record> TryFetchRecordAsync(string ownerId, string recordId)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryFetchRecordAsync", ownerId, recordId), typeof(Task<Record>));
		}

		public async Task<bool> StoreRecordAsync(Record record, Func<Record, bool> overwriteCheck = null)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "StoreRecordAsync", record, overwriteCheck), typeof(Task<bool>));
		}

		public async Task<bool> DeleteRecordAsync(Uri recordUri)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeleteRecordAsync", recordUri), typeof(Task<bool>));
		}

		public async Task<bool> DeleteRecordAsync(string ownerId, string recordId)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeleteRecordAsync", ownerId, recordId), typeof(Task<bool>));
		}

		public async Task<bool> DeleteRecordAsync(Record record)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeleteRecordAsync", record), typeof(Task<bool>));
		}

		public async Task UpdateRecordAsync(string ownerId, string recordId, Func<Record, bool> updateFunc)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UpdateRecordAsync", ownerId, recordId, updateFunc), typeof(Task));
		}

		public async Task<List<Record>> FetchRecordsAsync(Expression<Func<Record, bool>> predicate)
		{
			return (Task<List<Record>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FetchRecordsAsync", predicate), typeof(Task<List<Record>>));
		}

		public async Task<Record> FetchRecordAsync(Expression<Func<Record, bool>> predicate)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "FetchRecordAsync", predicate), typeof(Task<Record>));
		}

		public async Task<Uri> SaveAssetAsync(Bitmap2D texture, string extension = "webp", int quality = int.MaxValue, bool preserveColorInAlpha = true)
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveAssetAsync", texture, extension, quality, preserveColorInAlpha), typeof(Task<Uri>));
		}

		public Task<Uri> SaveAssetAsync(Bitmap3D texture, string extension = "3dtex")
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveAssetAsync", texture, extension), typeof(Task<Uri>));
		}

		public Task<Uri> SaveAssetAsync(MeshX mesh, MeshX.Encoding encoding = MeshX.Encoding.LZ4)
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveAssetAsync", mesh, encoding), typeof(Task<Uri>));
		}

		public Task<Uri> SaveAssetAsync(AnimX anim, AnimX.Encoding encoding = AnimX.Encoding.LZMA)
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveAssetAsync", anim, encoding), typeof(Task<Uri>));
		}

		public Task<Uri> SaveAssetAsync(BitmapCube texture)
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveAssetAsync", texture), typeof(Task<Uri>));
		}

		public Task<Uri> SaveAssetAsync(AudioX audio, AudioEncodeSettings encodeSettings = null)
		{
			return (Task<Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "SaveAssetAsync", audio, encodeSettings), typeof(Task<Uri>));
		}

		public void RegisterVariableListener(string path, Action callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "RegisterVariableListener", path, callback);
		}

		public void UnregisterVariableListener(string path, Action callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "UnregisterVariableListener", path, callback);
		}

		public async Task<LocalVariable> GetVariableAsync(string path)
		{
			return (Task<LocalVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVariableAsync", path), typeof(Task<LocalVariable>));
		}

		public async Task<T> ReadVariableOrCreateAsync<T>(string path, T def = default(T))
		{
			return (Task<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadVariableOrCreateAsync", path, def), typeof(Task<T>));
		}

		public async Task<T> ReadVariableAsync<T>(string path, T def = default(T))
		{
			return (Task<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadVariableAsync", path, def), typeof(Task<T>));
		}

		public async Task<VariableResult<T>> TryReadVariableAsync<T>(string path)
		{
			return (Task<VariableResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "TryReadVariableAsync", path), typeof(Task<VariableResult<T>>));
		}

		public async Task<T> ReadOrInitVariableAsync<T>(string path, T initValue)
		{
			return (Task<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadOrInitVariableAsync", path, initValue), typeof(Task<T>));
		}

		public async Task WriteVariableAsync<T>(string path, T value)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteVariableAsync", path, value), typeof(Task));
		}

		public async Task<string> ReadVariableAsync(string path)
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReadVariableAsync", path), typeof(Task<string>));
		}

		public async Task WriteVariableAsync(string path, string value)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "WriteVariableAsync", path, value), typeof(Task));
		}

		public async Task<bool> DeleteVariableAsync(string path)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "DeleteVariableAsync", path), typeof(Task<bool>));
		}

		public async Task<LocalVisit> GetVisitAsync(string url)
		{
			return (Task<LocalVisit>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetVisitAsync", url), typeof(Task<LocalVisit>));
		}

		public async Task LogVisitAsync(string url, int globalVersion = 0)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "LogVisitAsync", url, globalVersion), typeof(Task));
		}

		public Stream OpenAssetRead(AssetRecord record)
		{
			return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OpenAssetRead", record), typeof(Stream));
		}

		public static byte[] GenerateKey()
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateKey"), typeof(byte[]));
		}

		public static CryptoStream CreateEncryptionStream(byte[] key, Stream outputStream)
		{
			return (CryptoStream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateEncryptionStream", key, outputStream), typeof(CryptoStream));
		}

		public static CryptoStream CreateDecryptionStream(byte[] key, Stream inputStream)
		{
			return (CryptoStream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDB", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateDecryptionStream", key, inputStream), typeof(CryptoStream));
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

		public LocalDB(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public static class LocalDBUtility
	{
		public static async Task ExportData(string persistentPath, string tempPath, string exportPath)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "LocalDBUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "ExportData", persistentPath, tempPath, exportPath), typeof(Task));
		}
	}
	public class LocalMetadata : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int id
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "id"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "id", value);
			}
		}

		public string MetadataId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MetadataId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MetadataId", value);
			}
		}

		public string Metadata
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Metadata"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Metadata", value);
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

		public LocalMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class LocalVariable : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int id
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "id"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "id", value);
			}
		}

		public string path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "path", value);
			}
		}

		public string value
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "value"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "value", value);
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

		public LocalVariable(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class LocalVariableProxy<T> : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private string path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "path", value);
			}
		}

		private T currentValue
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "currentValue"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "currentValue", value);
			}
		}

		private T defaultValue
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "defaultValue"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "defaultValue", value);
			}
		}

		private LocalDB db
		{
			get
			{
				return (LocalDB)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "db"), typeof(LocalDB));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "db", value);
			}
		}

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

		public string Path => path;

		public event Action<LocalVariableProxy<T>> OnChanged;

		public LocalVariableProxy(LocalDB db, string path, T defaultValue)
		{
			this.db = db;
			this.path = path;
			this.defaultValue = defaultValue;
			db.RegisterVariableListener(path, OnVariableChanged);
			OnVariableChanged();
		}

		private void OnVariableChanged()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OnVariableChanged");
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Dispose");
		}

		public static implicit operator T(LocalVariableProxy<T> proxy)
		{
			return proxy.Value;
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

		public LocalVariableProxy(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	public class LocalVisit : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public int id
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "id"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "id", value);
			}
		}

		public string url
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "url"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "url", value);
			}
		}

		public int globalVersion
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "globalVersion"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "globalVersion", value);
			}
		}

		public DateTime lastVisit
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "lastVisit"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "lastVisit", value);
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

		public LocalVisit(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
	[Serializable]
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	[DataModelType]
	public class Record : IRecord, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Uri _cachedURL
		{
			get
			{
				return (Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_cachedURL"), typeof(Uri));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_cachedURL", value);
			}
		}

		private string _cachedURL_OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_cachedURL_OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_cachedURL_OwnerId", value);
			}
		}

		private string _cachedURL_RecordId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(this.__Backing, "_cachedURL_RecordId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(this.__Backing, "_cachedURL_RecordId", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public int id
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "id"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "id", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public RecordId CombinedRecordId => new RecordId(OwnerId, RecordId);

		[JsonProperty(PropertyName = "id")]
		[JsonPropertyName("id")]
		public string RecordId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RecordId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RecordId", value);
			}
		}

		[JsonProperty(PropertyName = "ownerId")]
		[JsonPropertyName("ownerId")]
		public string OwnerId
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OwnerId"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OwnerId", value);
			}
		}

		[JsonProperty(PropertyName = "assetUri")]
		[JsonPropertyName("assetUri")]
		public string AssetURI
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AssetURI"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AssetURI", value);
			}
		}

		[JsonProperty(PropertyName = "version")]
		[JsonPropertyName("version")]
		public RecordVersion Version
		{
			get
			{
				return (RecordVersion)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Version"), typeof(RecordVersion));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Version", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public bool IsSynced
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsSynced"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsSynced", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public Record ConflictingCloudVersion
		{
			get
			{
				return (Record)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ConflictingCloudVersion"), typeof(Record));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ConflictingCloudVersion", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime FetchedOn
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FetchedOn"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FetchedOn", value);
			}
		}

		[JsonProperty(PropertyName = "name")]
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

		[JsonProperty(PropertyName = "description", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("description")]
		public string Description
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Description"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "recordType")]
		[JsonPropertyName("recordType")]
		public string RecordType
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RecordType"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RecordType", value);
			}
		}

		[JsonProperty(PropertyName = "ownerName")]
		[JsonPropertyName("ownerName")]
		public string OwnerName
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "OwnerName"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "OwnerName", value);
			}
		}

		[JsonProperty(PropertyName = "tags", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("tags")]
		public HashSet<string> Tags
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Tags"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Tags", value);
			}
		}

		[JsonProperty(PropertyName = "path")]
		[JsonPropertyName("path")]
		public string Path
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Path"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Path", value);
			}
		}

		[JsonProperty(PropertyName = "thumbnailUri", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("thumbnailUri")]
		public string ThumbnailURI
		{
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "ThumbnailURI"), typeof(string));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "ThumbnailURI", value);
			}
		}

		[JsonProperty(PropertyName = "isPublic")]
		[JsonPropertyName("isPublic")]
		public bool IsPublic
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsPublic"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsPublic", value);
			}
		}

		[JsonProperty(PropertyName = "isForPatrons")]
		[JsonPropertyName("isForPatrons")]
		public bool IsForPatrons
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsForPatrons"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsForPatrons", value);
			}
		}

		[JsonProperty(PropertyName = "isListed")]
		[JsonPropertyName("isListed")]
		public bool IsListed
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsListed"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsListed", value);
			}
		}

		[JsonProperty(PropertyName = "isReadOnly")]
		[JsonPropertyName("isReadOnly")]
		public bool IsReadOnly
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsReadOnly"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsReadOnly", value);
			}
		}

		[JsonProperty(PropertyName = "lastModificationTime")]
		[JsonPropertyName("lastModificationTime")]
		public DateTime LastModificationTime
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LastModificationTime"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LastModificationTime", value);
			}
		}

		[JsonProperty(PropertyName = "rootRecordId", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("rootRecordId")]
		public RecordId RootRecordId
		{
			get
			{
				return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RootRecordId"), typeof(RecordId));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RootRecordId", value);
			}
		}

		[JsonProperty(PropertyName = "creationTime")]
		[JsonPropertyName("creationTime")]
		public DateTime? CreationTime
		{
			get
			{
				return (DateTime?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "CreationTime"), typeof(DateTime?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "CreationTime", value);
			}
		}

		[JsonProperty(PropertyName = "firstPublishTime")]
		[JsonPropertyName("firstPublishTime")]
		public DateTime? FirstPublishTime
		{
			get
			{
				return (DateTime?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "FirstPublishTime"), typeof(DateTime?));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "FirstPublishTime", value);
			}
		}

		[JsonProperty(PropertyName = "isDeleted")]
		[JsonPropertyName("isDeleted")]
		public bool IsDeleted
		{
			get
			{
				return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "IsDeleted"), typeof(bool));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "IsDeleted", value);
			}
		}

		[JsonProperty(PropertyName = "visits")]
		[JsonPropertyName("visits")]
		public int Visits
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Visits"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Visits", value);
			}
		}

		[JsonProperty(PropertyName = "rating")]
		[JsonPropertyName("rating")]
		public double Rating
		{
			get
			{
				return (double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Rating"), typeof(double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Rating", value);
			}
		}

		[JsonProperty(PropertyName = "randomOrder")]
		[JsonPropertyName("randomOrder")]
		public int RandomOrder
		{
			get
			{
				return (int)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "RandomOrder"), typeof(int));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "RandomOrder", value);
			}
		}

		[JsonProperty(PropertyName = "submissions")]
		[JsonPropertyName("submissions")]
		public List<Submission> Submissions
		{
			get
			{
				return (List<Submission>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Submissions"), typeof(List<Submission>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Submissions", value);
			}
		}

		[JsonProperty(PropertyName = "migrationMetadata", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("migrationMetadata")]
		public MigrationMetadata MigrationMetadata
		{
			get
			{
				return (MigrationMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "MigrationMetadata"), typeof(MigrationMetadata));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "MigrationMetadata", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public List<string> Manifest
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "Manifest"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "Manifest", value);
			}
		}

		[JsonProperty(PropertyName = "assetManifest", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("assetManifest")]
		public List<DBAsset> AssetManifest
		{
			get
			{
				return (List<DBAsset>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "AssetManifest"), typeof(List<DBAsset>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "AssetManifest", value);
			}
		}

		public bool IsValidOwnerId => IdUtil.GetOwnerType(OwnerId) != OwnerType.INVALID;

		public bool IsValidRecordId => RecordHelper.IsValidRecordID(RecordId);

		[Obsolete]
		[JsonProperty(PropertyName = "neosDBmanifest", NullValueHandling = NullValueHandling.Ignore)]
		[JsonPropertyName("neosDBmanifest")]
		public List<DBAsset> LegacyManifest
		{
			get
			{
				return (List<DBAsset>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LegacyManifest"), typeof(List<DBAsset>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LegacyManifest", value);
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "globalVersion")]
		[JsonPropertyName("globalVersion")]
		public int? LegacyGlobalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LegacyGlobalVersion", value);
			}
			get
			{
				return (int?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LegacyGlobalVersion"), typeof(int?));
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "localVersion")]
		[JsonPropertyName("localVersion")]
		public int? LegacyLocalVersion
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LegacyLocalVersion", value);
			}
			get
			{
				return (int?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LegacyLocalVersion"), typeof(int?));
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "lastModifyingUserId")]
		[JsonPropertyName("lastModifyingUserId")]
		public string LegacyLastModifyingUserId
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LegacyLastModifyingUserId", value);
			}
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LegacyLastModifyingUserId"), typeof(string));
			}
		}

		[Obsolete]
		[JsonProperty(PropertyName = "lastModifyingMachineId")]
		[JsonPropertyName("lastModifyingMachineId")]
		public string LegacyLastModifyingMachineId
		{
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(this.__Backing, "LegacyLastModifyingMachineId", value);
			}
			get
			{
				return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(this.__Backing, "LegacyLastModifyingMachineId"), typeof(string));
			}
		}

		public void ReplaceInTags(string oldString, string newString)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ReplaceInTags", oldString, newString);
		}

		public void ClearRecordSpecificMetadata()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ClearRecordSpecificMetadata");
		}

		public Uri GetUrl(IPlatformProfile platform)
		{
			return (Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetUrl", platform), typeof(Uri));
		}

		public Uri GetWebURL(IPlatformProfile platform)
		{
			return (Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "GetWebURL", platform), typeof(Uri));
		}

		public override string ToString()
		{
			return (string)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ToString"), typeof(string));
		}

		public static bool IsValidId(string recordId)
		{
			return (bool)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "FrooxEngine.Store", "Record", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidId", recordId), typeof(bool));
		}

		public void ResetVersioning()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "ResetVersioning");
		}

		public void OverrideGlobalVersion(int globalVersion)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "OverrideGlobalVersion", globalVersion);
		}

		public void IncrementGlobalVersion()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IncrementGlobalVersion");
		}

		public void IncrementLocalVersion(string machineId, string userId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "IncrementLocalVersion", machineId, userId);
		}

		public R Clone<R>() where R : class, IRecord, new()
		{
			return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(this.__Backing, "Clone"), typeof(R));
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

		public Record(ResoniteBridge.ResoniteBridgeValue value)
		{
			this.__Backing = value;
		}
	}
}
