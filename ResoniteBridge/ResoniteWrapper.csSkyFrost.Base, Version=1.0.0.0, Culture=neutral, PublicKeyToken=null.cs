using ResoniteBridge;

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
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
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.CodeAnalysis
{
}
namespace System.Runtime.CompilerServices
{
}
namespace SkyFrost.Base
{
	public class AccountDataStoreUploadTask : RecordUploadTaskBase<Record>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private IAccountDataStore source
		{
			get
			{
				return (IAccountDataStore)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "source"), typeof(IAccountDataStore));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "source", value);
			}
		}

		public AccountDataStoreUploadTask(SkyFrostInterface cloud, IAccountDataStore source, Record record)
			: base(cloud, record, ensureFolder: false)
		{
			this.source = source;
		}

		protected override async ValueTask<AssetData> ReadFile(System.String signature)
		{
			return (ValueTask<AssetData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadFile", signature), typeof(ValueTask<AssetData>));
		}

		protected override Task<bool> PrepareFilesForUpload(CancellationToken cancellationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrepareFilesForUpload", cancellationToken), typeof(Task<bool>));
		}

		protected override Task<bool> PrepareRecord(CancellationToken cancelationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrepareRecord", cancelationToken), typeof(Task<bool>));
		}

		protected override Task StoreSyncedRecord(Record record)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreSyncedRecord", record), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AccountDataStoreUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AccountTransferController : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private IAccountDataStore source
		{
			get
			{
				return (IAccountDataStore)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "source"), typeof(IAccountDataStore));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "source", value);
			}
		}

		private IAccountDataStore target
		{
			get
			{
				return (IAccountDataStore)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "target"), typeof(IAccountDataStore));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "target", value);
			}
		}

		private AccountMigrationConfig config
		{
			get
			{
				return (AccountMigrationConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "config"), typeof(AccountMigrationConfig));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "config", value);
			}
		}

		public System.String ProgressMessage
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProgressMessage"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ProgressMessage", value);
			}
		}

		public System.Boolean ContactsCompleted
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactsCompleted"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactsCompleted", value);
			}
		}

		public System.Boolean UserOwnedCompleted
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserOwnedCompleted"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserOwnedCompleted", value);
			}
		}

		public HashSet<string> GroupsCompleted
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupsCompleted"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupsCompleted", value);
			}
		}

		public AccountMigrationStatus Status
		{
			get
			{
				return (AccountMigrationStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(AccountMigrationStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Status", value);
			}
		}

		public event Action<string> ProgressMessagePosted;

		public AccountTransferController(IAccountDataStore source, IAccountDataStore target, System.String migrationId, AccountMigrationConfig config)
		{
			this.source = source;
			this.target = target;
			this.source.MigrationId = migrationId;
			this.target.MigrationId = migrationId;
			this.config = config;
			this.source.ProgressMessage += delegate(System.String str)
			{
				this.ProgressMessagePosted?.Invoke(str);
			};
			this.target.ProgressMessage += delegate(System.String str)
			{
				this.ProgressMessagePosted?.Invoke(str);
			};
			if (this.target is CloudAccountDataStore cloudAccountDataStore)
			{
				cloudAccountDataStore.PreserveOldHome = config.PreserveOldHome;
			}
		}

		private void SetProgressMessage(System.String message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetProgressMessage", message);
		}

		private System.Boolean ProcessRecord(Record record)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessRecord", record), typeof(System.Boolean));
		}

		private System.Boolean ProcessContact(Contact contact)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessContact", contact), typeof(System.Boolean));
		}

		private System.Boolean ProcessGroup(Group group)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessGroup", group), typeof(System.Boolean));
		}

		public async Task<bool> Transfer(CancellationToken cancellationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Transfer", cancellationToken), typeof(Task<bool>));
		}

		public async Task TransferUserProfileData()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferUserProfileData"), typeof(Task));
		}

		public async Task TransferFundingEvents()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferFundingEvents"), typeof(Task));
		}

		public async Task TransferExitMessages()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferExitMessages"), typeof(Task));
		}

		public async Task TransferOwned(System.String ownerId, RecordMigrationStatus recordsStatus, VariableMigrationStatus variablesStatus, List<string> recordsToMigrate, List<string> variablesToMigrate, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferOwned", ownerId, recordsStatus, variablesStatus, recordsToMigrate, variablesToMigrate, cancellationToken), typeof(Task));
		}

		private async Task TrasnferRecordAuditLog(System.String ownerId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrasnferRecordAuditLog", ownerId), typeof(Task));
		}

		private async Task TransferSelectedRecords(System.String ownerId, RecordMigrationStatus recordsStatus, List<string> recordsToMigrate)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferSelectedRecords", ownerId, recordsStatus, recordsToMigrate), typeof(Task));
		}

		public async Task TransferVariables(System.String ownerId, VariableMigrationStatus status, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferVariables", ownerId, status, cancellationToken), typeof(Task));
		}

		public async Task TransferVariableDefinitions(System.String ownerId, VariableMigrationStatus status, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferVariableDefinitions", ownerId, status, cancellationToken), typeof(Task));
		}

		private RecordStatusCallbacks SetupCallbacks(RecordMigrationStatus status)
		{
			return (RecordStatusCallbacks)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetupCallbacks", status), typeof(RecordStatusCallbacks));
		}

		public async Task TransferRecords(System.String ownerId, RecordMigrationStatus status, System.Boolean onlyNew, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferRecords", ownerId, status, onlyNew, cancellationToken), typeof(Task));
		}

		public async Task TransferContacts(CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferContacts", cancellationToken), typeof(Task));
		}

		public async Task TransferMessages(Contact contact, System.String contactId, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferMessages", contact, contactId, cancellationToken), typeof(Task));
		}

		public async Task TransferMembers(Group group, GroupMigrationStatus groupStatus, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferMembers", group, groupStatus, cancellationToken), typeof(Task));
		}

		private void HandleRecordError(RecordMigrationStatus status, Record record, System.String error)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HandleRecordError", status, record, error);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AccountTransferController(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudAccountDataStore : IAccountDataStore, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public SkyFrostInterface Cloud
		{
			get
			{
				return (SkyFrostInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Cloud"), typeof(SkyFrostInterface));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Cloud", value);
			}
		}

		private static HashSet<string> CONFLICTING_IDS
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudAccountDataStore", ResoniteBridge.ResoniteBridgeValueType.Type), "CONFLICTING_IDS"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudAccountDataStore", ResoniteBridge.ResoniteBridgeValueType.Type), "CONFLICTING_IDS", value);
			}
		}

		private Dictionary<string, int> _fetchedRecords
		{
			get
			{
				return (Dictionary<string, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_fetchedRecords"), typeof(Dictionary<string, int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_fetchedRecords", value);
			}
		}

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

		public System.Boolean PreserveOldHome
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreserveOldHome"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreserveOldHome", value);
			}
		}

		public System.String Name => Cloud.UserAgentProduct + " " + Cloud.UserAgentVersion;

		public System.String UserId => Cloud.Session.CurrentUserID;

		public System.String Username => Cloud.Session.CurrentUsername;

		public System.Int32 FetchedGroupCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FetchedGroupCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FetchedGroupCount", value);
			}
		}

		public IPlatformProfile PlatformProfile => Cloud.Platform;

		public event Action<string> ProgressMessage;

		public System.Int32 FetchedRecordCount(System.String ownerId)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchedRecordCount", ownerId), typeof(System.Int32));
		}

		public CloudAccountDataStore(SkyFrostInterface cloud)
		{
			Cloud = cloud;
		}

		public virtual async Task Prepare()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Prepare"), typeof(Task));
		}

		public virtual async Task Complete()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Complete"), typeof(Task));
		}

		public virtual Task<User> GetUser()
		{
			return (Task<User>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser"), typeof(Task<User>));
		}

		public virtual async Task<List<ExitMessage>> GetExitMessages()
		{
			return (Task<List<ExitMessage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExitMessages"), typeof(Task<List<ExitMessage>>));
		}

		public virtual async Task<List<PatreonFundingEvent>> GetPatreonFundingEvents()
		{
			return (Task<List<PatreonFundingEvent>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<List<PatreonFundingEvent>>));
		}

		public virtual async Task<List<Contact>> GetContacts()
		{
			return (Task<List<Contact>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<List<Contact>>));
		}

		public virtual async ResoniteBridge.ResoniteBridgeValue GetMessages(System.String contactId, ResoniteBridge.ResoniteBridgeValue from)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", contactId, from), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public virtual async ResoniteBridge.ResoniteBridgeValue GetGroups()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroups"), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public virtual async Task<List<MemberData>> GetMembers(System.String groupId)
		{
			return (Task<List<MemberData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMembers", groupId), typeof(Task<List<MemberData>>));
		}

		public virtual async Task<Record> GetRecord(System.String ownerId, System.String recordId)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId), typeof(Task<Record>));
		}

		public virtual async ResoniteBridge.ResoniteBridgeValue GetRecords(System.String ownerId, ResoniteBridge.ResoniteBridgeValue from, Action<string> searchProgressReport = null)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordAuditLog(System.String ownerId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		private async Task<Record> FillRecordDetails(Record r)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FillRecordDetails", r), typeof(Task<Record>));
		}

		public virtual async Task<List<CloudVariableDefinition>> GetVariableDefinitions(System.String ownerId)
		{
			return (Task<List<CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariableDefinitions", ownerId), typeof(Task<List<CloudVariableDefinition>>));
		}

		public virtual async Task<List<CloudVariable>> GetVariables(System.String ownerId)
		{
			return (Task<List<CloudVariable>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariables", ownerId), typeof(Task<List<CloudVariable>>));
		}

		public virtual async Task<CloudVariable> GetVariable(System.String ownerId, System.String path)
		{
			return (Task<CloudVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", ownerId, path), typeof(Task<CloudVariable>));
		}

		public virtual async Task<DateTime> GetLatestMessageTime(System.String contactId)
		{
			return (Task<DateTime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestMessageTime", contactId), typeof(Task<DateTime>));
		}

		public virtual async ResoniteBridge.ResoniteBridgeValue GetLatestRecordTime(System.String ownerId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestRecordTime", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public virtual async Task StoreDefinitions(List<CloudVariableDefinition> definitions, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreDefinitions", definitions, source), typeof(Task));
		}

		public virtual async Task StoreContact(Contact contact, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreContact", contact, source), typeof(Task));
		}

		public virtual async Task StoreMessage(Message message, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message, source), typeof(Task));
		}

		public virtual async Task StoreVariables(List<CloudVariable> variables, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVariables", variables, source), typeof(Task));
		}

		public virtual async Task StoreGroup(Group group, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreGroup", group, storage, source), typeof(Task));
		}

		public virtual async Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMember", group, member, storage, source), typeof(Task));
		}

		public virtual async Task StoreUserData(User user)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreUserData", user), typeof(Task));
		}

		public virtual Task StoreFundingEvent(PatreonFundingEvent fundingEvent)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreFundingEvent", fundingEvent), typeof(Task));
		}

		public Task StoreRecordAudit(RecordAuditInfo auditInfo)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecordAudit", auditInfo), typeof(Task));
		}

		public Task StoreExitMessage(ExitMessage message)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreExitMessage", message), typeof(Task));
		}

		public virtual async Task<StoreResultData> StoreRecord(Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks, System.Boolean overwriteOnConflict)
		{
			return (Task<StoreResultData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecord", record, source, statusCallbacks, overwriteOnConflict), typeof(Task<StoreResultData>));
		}

		public virtual async Task DownloadAsset(System.String hash, System.String targetPath)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DownloadAsset", hash, targetPath), typeof(Task));
		}

		public virtual async Task<long> GetAssetSize(System.String hash)
		{
			return (Task<long>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetSize", hash), typeof(Task<long>));
		}

		public virtual async Task<string> GetAsset(System.String hash)
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsset", hash), typeof(Task<string>));
		}

		public virtual Task<AssetData> ReadAsset(System.String hash)
		{
			return (Task<AssetData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadAsset", hash), typeof(Task<AssetData>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudAccountDataStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum RecordStoreResult
	{
		Stored,
		AlreadyExists,
		Conflict,
		Ignored,
		Error
	}
	public struct StoreResultData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public RecordStoreResult result
		{
			get
			{
				return (RecordStoreResult)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "result"), typeof(RecordStoreResult));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "result", value);
			}
		}

		public System.String error
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "error"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "error", value);
			}
		}

		public StoreResultData(RecordStoreResult result, System.String error = null)
		{
			this.result = result;
			this.error = error;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StoreResultData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct GroupData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Group group
		{
			get
			{
				return (Group)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "group"), typeof(Group));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "group", value);
			}
		}

		public Storage storage
		{
			get
			{
				return (Storage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "storage"), typeof(Storage));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "storage", value);
			}
		}

		public GroupData(Group group, Storage storage)
		{
			this.group = group;
			this.storage = storage;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public GroupData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct MemberData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Member member
		{
			get
			{
				return (Member)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "member"), typeof(Member));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "member", value);
			}
		}

		public Storage storage
		{
			get
			{
				return (Storage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "storage"), typeof(Storage));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "storage", value);
			}
		}

		public MemberData(Member member, Storage storage)
		{
			this.member = member;
			this.storage = storage;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MemberData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class RecordStatusCallbacks : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Action<AssetDiff> AssetToUploadAdded
		{
			get
			{
				return (Action<AssetDiff>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetToUploadAdded"), typeof(Action<AssetDiff>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AssetToUploadAdded", value);
			}
		}

		public Action<long> BytesUploaded
		{
			get
			{
				return (Action<long>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BytesUploaded"), typeof(Action<long>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BytesUploaded", value);
			}
		}

		public Action AssetUploaded
		{
			get
			{
				return (Action)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetUploaded"), typeof(Action));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AssetUploaded", value);
			}
		}

		public Action<string> AssetMissing
		{
			get
			{
				return (Action<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetMissing"), typeof(Action<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AssetMissing", value);
			}
		}

		public Action<string> MigrationStarted
		{
			get
			{
				return (Action<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MigrationStarted"), typeof(Action<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MigrationStarted", value);
			}
		}

		public Action<string> MigrationFinished
		{
			get
			{
				return (Action<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MigrationFinished"), typeof(Action<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MigrationFinished", value);
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

		public RecordStatusCallbacks(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RecordStatusCallbacks()
		{
		}
	}
	public interface IAccountDataStore : ResoniteBridge.ResoniteBridgeValueHolder
	{
		IPlatformProfile PlatformProfile { get; }

		System.String MigrationId { get; set; }

		System.String Name { get; }

		System.String UserId { get; }

		System.String Username { get; }

		System.Int32 FetchedGroupCount { get; }

		event Action<string> ProgressMessage;

		System.Int32 FetchedRecordCount(System.String ownerId);

		Task Prepare();

		Task Complete();

		Task<long> GetAssetSize(System.String hash);

		Task DownloadAsset(System.String hash, System.String targetPath);

		Task<string> GetAsset(System.String hash);

		Task<AssetData> ReadAsset(System.String hash);

		Task<User> GetUser();

		Task<List<ExitMessage>> GetExitMessages();

		Task<List<PatreonFundingEvent>> GetPatreonFundingEvents();

		Task<List<CloudVariableDefinition>> GetVariableDefinitions(System.String ownerId);

		Task<CloudVariable> GetVariable(System.String ownerId, System.String path);

		Task<List<CloudVariable>> GetVariables(System.String ownerId);

		ResoniteBridge.ResoniteBridgeValue GetGroups();

		Task<List<MemberData>> GetMembers(System.String groupId);

		Task<Record> GetRecord(System.String ownerId, System.String recordId);

		ResoniteBridge.ResoniteBridgeValue GetRecords(System.String ownerId, ResoniteBridge.ResoniteBridgeValue from, Action<string> searchProgressReport = null);

		ResoniteBridge.ResoniteBridgeValue GetRecordAuditLog(System.String ownerId);

		Task<List<Contact>> GetContacts();

		ResoniteBridge.ResoniteBridgeValue GetMessages(System.String contactId, ResoniteBridge.ResoniteBridgeValue from);

		ResoniteBridge.ResoniteBridgeValue GetLatestRecordTime(System.String ownerId);

		Task<DateTime> GetLatestMessageTime(System.String contactId);

		Task StoreUserData(User user);

		Task StoreExitMessage(ExitMessage exitMessage);

		Task StoreFundingEvent(PatreonFundingEvent fundingEvent);

		Task StoreDefinitions(List<CloudVariableDefinition> definition, IAccountDataStore source);

		Task StoreVariables(List<CloudVariable> variable, IAccountDataStore source);

		Task StoreGroup(Group group, Storage storage, IAccountDataStore source);

		Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source);

		Task<StoreResultData> StoreRecord(Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks = null, System.Boolean forceConflictOverwrite = false);

		Task StoreRecordAudit(RecordAuditInfo info);

		Task StoreContact(Contact contact, IAccountDataStore source);

		Task StoreMessage(Message message, IAccountDataStore source);
	}
	public class LocalAccountDataStore : IAccountDataStore, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private struct AssetJob : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public System.String hash
			{
				get
				{
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "hash"), typeof(System.String));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "hash", value);
				}
			}

			public IAccountDataStore source
			{
				get
				{
					return (IAccountDataStore)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "source"), typeof(IAccountDataStore));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "source", value);
				}
			}

			public AssetJob(System.String hash, IAccountDataStore source)
			{
				this.hash = hash;
				this.source = source;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return __backing;
				}
				set
				{
					__backing = value;
				}
			}

			public AssetJob(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private ResoniteBridge.ResoniteBridgeValue downloadProcessor
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "downloadProcessor"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "downloadProcessor", value);
			}
		}

		private HashSet<string> scheduledAssets
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "scheduledAssets"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "scheduledAssets", value);
			}
		}

		public System.String BasePath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BasePath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BasePath", value);
			}
		}

		public System.String AssetsPath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetsPath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AssetsPath", value);
			}
		}

		private Dictionary<string, int> _fetchedRecords
		{
			get
			{
				return (Dictionary<string, int>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_fetchedRecords"), typeof(Dictionary<string, int>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_fetchedRecords", value);
			}
		}

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

		public System.String Name => "Local Data Store";

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

		public System.Int32 FetchedGroupCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FetchedGroupCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FetchedGroupCount", value);
			}
		}

		public IPlatformProfile PlatformProfile
		{
			get
			{
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PlatformProfile"), typeof(IPlatformProfile));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PlatformProfile", value);
			}
		}

		public event Action<string> ProgressMessage;

		public System.Int32 FetchedRecordCount(System.String ownerId)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchedRecordCount", ownerId), typeof(System.Int32));
		}

		public LocalAccountDataStore(IPlatformProfile platform, System.String userId, System.String basePath, System.String assetsPath)
		{
			PlatformProfile = platform;
			UserId = userId;
			BasePath = basePath;
			AssetsPath = assetsPath;
			InitDownloadProcessor();
		}

		public Task Prepare()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Prepare"), typeof(Task));
		}

		public async Task Complete()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Complete"), typeof(Task));
		}

		private void InitDownloadProcessor()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitDownloadProcessor");
		}

		public Task<List<Contact>> GetContacts()
		{
			return (Task<List<Contact>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<List<Contact>>));
		}

		public Task<List<ExitMessage>> GetExitMessages()
		{
			return (Task<List<ExitMessage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExitMessages"), typeof(Task<List<ExitMessage>>));
		}

		public async ResoniteBridge.ResoniteBridgeValue GetRecordAuditLog(System.String ownerId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public async Task<User> GetUser()
		{
			return (Task<User>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser"), typeof(Task<User>));
		}

		public async Task<List<PatreonFundingEvent>> GetPatreonFundingEvents()
		{
			return (Task<List<PatreonFundingEvent>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<List<PatreonFundingEvent>>));
		}

		public async ResoniteBridge.ResoniteBridgeValue GetMessages(System.String contactId, ResoniteBridge.ResoniteBridgeValue from)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", contactId, from), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public async Task<Record> GetRecord(System.String ownerId, System.String recordId)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId), typeof(Task<Record>));
		}

		public async ResoniteBridge.ResoniteBridgeValue GetRecords(System.String ownerId, ResoniteBridge.ResoniteBridgeValue from, Action<string> searchProgressReport = null)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public Task<List<CloudVariableDefinition>> GetVariableDefinitions(System.String ownerId)
		{
			return (Task<List<CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariableDefinitions", ownerId), typeof(Task<List<CloudVariableDefinition>>));
		}

		public Task<List<CloudVariable>> GetVariables(System.String ownerId)
		{
			return (Task<List<CloudVariable>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariables", ownerId), typeof(Task<List<CloudVariable>>));
		}

		public async Task<CloudVariable> GetVariable(System.String ownerId, System.String path)
		{
			return (Task<CloudVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", ownerId, path), typeof(Task<CloudVariable>));
		}

		public async ResoniteBridge.ResoniteBridgeValue GetGroups()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroups"), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public async Task<List<MemberData>> GetMembers(System.String groupId)
		{
			return (Task<List<MemberData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMembers", groupId), typeof(Task<List<MemberData>>));
		}

		private Task<List<T>> GetEntities<T>(System.String path)
		{
			return (Task<List<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEntities", path), typeof(Task<List<T>>));
		}

		private T GetEntity<T>(System.String path)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEntity", path), typeof(T));
		}

		public async Task StoreDefinitions(List<CloudVariableDefinition> definitions, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreDefinitions", definitions, source), typeof(Task));
		}

		public async Task StoreVariables(List<CloudVariable> variables, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVariables", variables, source), typeof(Task));
		}

		public Task StoreContact(Contact contact, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreContact", contact, source), typeof(Task));
		}

		public Task StoreMessage(Message message, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message, source), typeof(Task));
		}

		public async Task<StoreResultData> StoreRecord(Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks, System.Boolean overwriteOnConflict)
		{
			return (Task<StoreResultData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecord", record, source, statusCallbacks, overwriteOnConflict), typeof(Task<StoreResultData>));
		}

		public async Task StoreGroup(Group group, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreGroup", group, storage, source), typeof(Task));
		}

		public async Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMember", group, member, storage, source), typeof(Task));
		}

		public async Task StoreRecordAudit(RecordAuditInfo info)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecordAudit", info), typeof(Task));
		}

		public async Task StoreUserData(User user)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreUserData", user), typeof(Task));
		}

		public async Task StoreFundingEvent(PatreonFundingEvent fundingEvent)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreFundingEvent", fundingEvent), typeof(Task));
		}

		public async Task StoreExitMessage(ExitMessage exitMessage)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreExitMessage", exitMessage), typeof(Task));
		}

		private Task StoreEntity<T>(T entity, System.String path)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreEntity", entity, path), typeof(Task));
		}

		private System.String UserPath()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserPath"), typeof(System.String));
		}

		private System.String PatreonPath()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PatreonPath"), typeof(System.String));
		}

		private System.String ExitMessagesPath()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitMessagesPath"), typeof(System.String));
		}

		private System.String VariableDefinitionPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariableDefinitionPath", ownerId), typeof(System.String));
		}

		private System.String VariablePath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariablePath", ownerId), typeof(System.String));
		}

		private System.String ContactsPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactsPath", ownerId), typeof(System.String));
		}

		private System.String MessagesPath(System.String ownerId, System.String contactId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MessagesPath", ownerId, contactId), typeof(System.String));
		}

		private System.String RecordsPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordsPath", ownerId), typeof(System.String));
		}

		private System.String RecordAuditPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordAuditPath", ownerId), typeof(System.String));
		}

		private System.String GroupsPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GroupsPath", ownerId), typeof(System.String));
		}

		private System.String MembersPath(System.String ownerId, System.String groupId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MembersPath", ownerId, groupId), typeof(System.String));
		}

		private System.String GetAssetPath(System.String hash)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetPath", hash), typeof(System.String));
		}

		public async Task<DateTime> GetLatestMessageTime(System.String contactId)
		{
			return (Task<DateTime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestMessageTime", contactId), typeof(Task<DateTime>));
		}

		public async ResoniteBridge.ResoniteBridgeValue GetLatestRecordTime(System.String ownerId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestRecordTime", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		private void ScheduleAsset(System.String hash, IAccountDataStore store)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleAsset", hash, store);
		}

		public Task DownloadAsset(System.String hash, System.String targetPath)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DownloadAsset", hash, targetPath), typeof(Task));
		}

		public Task<long> GetAssetSize(System.String hash)
		{
			return (Task<long>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetSize", hash), typeof(Task<long>));
		}

		public Task<string> GetAsset(System.String hash)
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsset", hash), typeof(Task<string>));
		}

		public Task<AssetData> ReadAsset(System.String hash)
		{
			return (Task<AssetData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadAsset", hash), typeof(Task<AssetData>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public LocalAccountDataStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class MigrationHelper
	{
		private struct MigrationGroup : IEquatable<MigrationGroup>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public static IPlatformProfile from
			{
				get
				{
					return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "from"), typeof(IPlatformProfile));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "from", value);
				}
			}

			public static IPlatformProfile to
			{
				get
				{
					return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "to"), typeof(IPlatformProfile));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "to", value);
				}
			}

			public MigrationGroup(IPlatformProfile from, IPlatformProfile to)
			{
				this.from = from;
				this.to = to;
			}

			public System.Boolean Equals(MigrationGroup other)
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
			}

			public override System.Boolean Equals(System.Object obj)
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
			}

			public override System.Int32 GetHashCode()
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
			}

			public static bool operator ==(MigrationGroup left, MigrationGroup right)
			{
				return left.Equals(right);
			}

			public static bool operator !=(MigrationGroup left, MigrationGroup right)
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

			public MigrationGroup(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private static ResoniteBridge.ResoniteBridgeValue migrationStrings
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "migrationStrings"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "migrationStrings", value);
			}
		}

		private static ResoniteBridge.ResoniteBridgeValue GetMigrationStrings(IPlatformProfile from, IPlatformProfile to)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMigrationStrings", from, to), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static ResoniteBridge.ResoniteBridgeValue MigrateLegacyURL(this ResoniteBridge.ResoniteBridgeValue url, IPlatformProfile to)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateLegacyURL", url, to), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static ResoniteBridge.ResoniteBridgeValue MigrateURL(this ResoniteBridge.ResoniteBridgeValue url, IPlatformProfile from, IPlatformProfile to)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateURL", url, from, to), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static System.String MigrateURL(this System.String str, IPlatformProfile from, IPlatformProfile to)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateURL", str, from, to), typeof(System.String));
		}

		public static System.String MigrateString(this System.String str, IPlatformProfile from, IPlatformProfile to)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateString", str, from, to), typeof(System.String));
		}

		public static System.String MigrateSubStrings(this System.String str, IPlatformProfile from, IPlatformProfile to)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateSubStrings", str, from, to), typeof(System.String));
		}
	}
	[JsonDerivedType(typeof(CloudflareAssetInterface), "cloudflare")]
	[JsonDerivedType(typeof(AzureAssetInterface), "azure")]
	public abstract class AssetInterface : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[System.Text.Json.Serialization.JsonIgnore]
		public SkyFrostInterface Cloud { get; private set; }

		[System.Text.Json.Serialization.JsonIgnore]
		public ApiClient Api => Cloud.Api;

		[System.Text.Json.Serialization.JsonIgnore]
		public User CurrentUser => Cloud.Session.CurrentUser;

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String CurrentUserID => Cloud.Session.CurrentUserID;

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String DBScheme => Cloud.Platform.DBScheme;

		public void Initialize(SkyFrostInterface cloud)
		{
			if (Cloud != null)
			{
				throw new InvalidOperationException("AssetBackend has already been initialized");
			}
			Cloud = cloud;
		}

		public abstract ResoniteBridge.ResoniteBridgeValue DBToHttp(ResoniteBridge.ResoniteBridgeValue productDBUri, DB_Endpoint endpoint);

		public abstract ResoniteBridge.ResoniteBridgeValue ThumbnailToHttp(ThumbnailInfo thumbnail);

		public async Task<Stream> GatherAsset(System.String signature)
		{
			_ = 1;
			try
			{
				HttpRequestMessage request = Api.CreateRequest(DBToHttp(GenerateURL(signature), DB_Endpoint.Default), authenticate: false, HttpMethod.Get);
				CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(TimeSpan.FromMinutes(30.0));
				return await (await Api.Client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationTokenSource.Token).ConfigureAwait(continueOnCapturedContext: false)).Content.ReadAsStreamAsync().ConfigureAwait(continueOnCapturedContext: false);
			}
			catch (HttpRequestException)
			{
				return null;
			}
		}

		public ResoniteBridge.ResoniteBridgeValue FilterDatabaseURL(ResoniteBridge.ResoniteBridgeValue assetURL)
		{
			if (assetURL.Scheme == DBScheme && assetURL.Segments.Length >= 2 && assetURL.Segments[1].Contains("."))
			{
				assetURL = new Uri(DBScheme + ":///" + Path.GetFileNameWithoutExtension(assetURL.Segments[1]) + assetURL.Query);
			}
			return assetURL;
		}

		public ResoniteBridge.ResoniteBridgeValue GenerateURL(System.String signature)
		{
			return GenerateURLWithExtension(signature, null);
		}

		public ResoniteBridge.ResoniteBridgeValue GenerateURLWithExtension(System.String signature, System.String extension)
		{
			if (!string.IsNullOrEmpty(extension) && extension[0] != '.')
			{
				extension = "." + extension;
			}
			return new Uri(DBScheme + ":///" + signature + extension);
		}

		public System.String DBSignature(ResoniteBridge.ResoniteBridgeValue dbUri, System.Boolean ignoreScheme = false)
		{
			string extension;
			return DBSignature(dbUri, out extension, ignoreScheme);
		}

		public System.String DBSignature(ResoniteBridge.ResoniteBridgeValue dbUri, out System.String extension, System.Boolean ignoreScheme = false)
		{
			if (!ignoreScheme && dbUri.Scheme != DBScheme)
			{
				throw new ArgumentException($"{dbUri} is not a Database URI");
			}
			if (dbUri.Segments.Length < 2)
			{
				extension = null;
				return null;
			}
			string path = dbUri.Segments[1];
			extension = Path.GetExtension(path);
			string text = Path.GetFileNameWithoutExtension(path);
			if (text.Length < 30)
			{
				text = LegacyAssetMap.MapLegacySignature(text);
			}
			return text;
		}

		public System.String DBQuery(ResoniteBridge.ResoniteBridgeValue dbUri)
		{
			if (string.IsNullOrWhiteSpace(dbUri.Query))
			{
				return null;
			}
			return dbUri.Query.Substring(1);
		}

		public System.String DBFilename(ResoniteBridge.ResoniteBridgeValue dbUri)
		{
			if (dbUri.Segments.Length < 2)
			{
				return null;
			}
			return dbUri.Segments[1] + dbUri.Query;
		}

		public System.Boolean IsValidDBUri(System.String uri)
		{
			if (string.IsNullOrWhiteSpace(uri))
			{
				return false;
			}
			if (!Uri.TryCreate(uri, UriKind.Absolute, out Uri result))
			{
				return false;
			}
			return IsValidDBUri(result);
		}

		public System.Boolean IsValidDBUri(ResoniteBridge.ResoniteBridgeValue uri)
		{
			if (uri.Scheme != DBScheme)
			{
				return false;
			}
			if (uri.Segments.Length < 2)
			{
				return false;
			}
			return true;
		}

		public System.Boolean IsLegacyDB(ResoniteBridge.ResoniteBridgeValue uri)
		{
			if (uri.Scheme != DBScheme)
			{
				return false;
			}
			if (uri.Segments.Length < 2)
			{
				return false;
			}
			return Path.GetFileNameWithoutExtension(uri.Segments[1]).Length < 30;
		}

		public Task<CloudResult<AssetInfo>> GetGlobalAssetInfo(System.String hash)
		{
			return Api.GET<AssetInfo>("assets/" + hash.ToLower());
		}

		public Task<CloudResult<AssetInfo>> GetUserAssetInfo(System.String hash)
		{
			return GetAssetInfo(CurrentUserID, hash);
		}

		public Task<CloudResult<AssetInfo>> GetAssetInfo(System.String ownerId, System.String hash)
		{
			return IdUtil.GetOwnerType(ownerId) switch
			{
				OwnerType.User => Api.GET<AssetInfo>("users/" + ownerId + "/assets/" + hash), 
				OwnerType.Group => Api.GET<AssetInfo>("groups/" + ownerId + "/assets/" + hash), 
				_ => throw new Exception("Invalid ownerId"), 
			};
		}

		public async Task<bool> IsValidShader(System.String hash)
		{
			if ((await Api.GET("shaders/" + hash).ConfigureAwait(continueOnCapturedContext: false)).IsOK)
			{
				return true;
			}
			return false;
		}

		public AssetUploadTask CreateFileAssetUploadTask(System.String ownerId, System.String signature, System.String variant, System.String assetPath, ResoniteBridge.ResoniteBridgeValue progress, System.Int32 retries = 5)
		{
			AssetUploadTask assetUploadTask = CreateEmptyAssetUploadTask();
			assetUploadTask.InitializeWithFile(Cloud, ownerId, signature, variant, assetPath, progress, retries);
			return assetUploadTask;
		}

		public AssetUploadTask CreateStreamAssetUploadTask(System.String ownerId, System.String signature, System.String variant, Stream assetStream, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			AssetUploadTask assetUploadTask = CreateEmptyAssetUploadTask();
			assetUploadTask.InitializeWithStream(Cloud, ownerId, signature, variant, assetStream, progress, bytes, retries);
			return assetUploadTask;
		}

		public AssetUploadTask CreateURLAssetUploadTask(System.String ownerId, System.String signature, System.String variant, ResoniteBridge.ResoniteBridgeValue assetURL, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			AssetUploadTask assetUploadTask = CreateEmptyAssetUploadTask();
			assetUploadTask.InitializeWithURL(Cloud, ownerId, signature, variant, assetURL, progress, bytes, retries);
			return assetUploadTask;
		}

		public Task<CloudResult> GetAssetMime(ResoniteBridge.ResoniteBridgeValue url)
		{
			return GetAssetMime(DBSignature(url));
		}

		public abstract Task<CloudResult> GetAssetMime(System.String hash);

		public abstract Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String session);

		protected abstract AssetUploadTask CreateEmptyAssetUploadTask();

		public System.String GetAssetBaseURL(System.String ownerId, System.String hash, System.String variant)
		{
			hash = hash.ToLower();
			string text = hash;
			if (variant != null)
			{
				text = text + "&" + variant;
			}
			return IdUtil.GetOwnerType(ownerId) switch
			{
				OwnerType.User => "users/" + ownerId + "/assets/" + text, 
				OwnerType.Group => "groups/" + ownerId + "/assets/" + text, 
				_ => throw new Exception("Invalid ownerId"), 
			};
		}

		public Task<CloudResult<List<string>>> GetAvailableVariants(ResoniteBridge.ResoniteBridgeValue dbUrl)
		{
			string hash = DBSignature(dbUrl);
			return GetAvailableVariants(hash);
		}

		public abstract Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash);

		public Task<CloudResult<List<T>>> GetAssetMetadata<T>(List<string> hashes) where T : class, IAssetMetadata, new()
		{
			Type typeFromHandle = typeof(T);
			string resource = "assets/" + GetMetadataURLSegment(typeFromHandle);
			return Api.POST<List<T>>(resource, hashes);
		}

		public async Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> GetAssetMetadata(ResoniteBridge.ResoniteBridgeValue variantType, System.String hash)
		{
			return variantType switch
			{
				AssetVariantType.Texture => (await GetAssetMetadata<BitmapMetadata>(hash).ConfigureAwait(continueOnCapturedContext: false)).AsResult<IAssetMetadata>(), 
				AssetVariantType.Cubemap => (await GetAssetMetadata<CubemapMetadata>(hash).ConfigureAwait(continueOnCapturedContext: false)).AsResult<IAssetMetadata>(), 
				AssetVariantType.Volume => (await GetAssetMetadata<VolumeMetadata>(hash).ConfigureAwait(continueOnCapturedContext: false)).AsResult<IAssetMetadata>(), 
				AssetVariantType.Mesh => (await GetAssetMetadata<MeshMetadata>(hash).ConfigureAwait(continueOnCapturedContext: false)).AsResult<IAssetMetadata>(), 
				AssetVariantType.Shader => (await GetAssetMetadata<ShaderMetadata>(hash).ConfigureAwait(continueOnCapturedContext: false)).AsResult<IAssetMetadata>(), 
				_ => throw new Exception("Unsupported metadata type: " + variantType), 
			};
		}

		public Task<CloudResult<T>> GetAssetMetadata<T>(System.String hash) where T : class, IAssetMetadata, new()
		{
			Type typeFromHandle = typeof(T);
			string resource = "assets/" + hash + "/" + GetMetadataURLSegment(typeFromHandle);
			return Api.GET<T>(resource);
		}

		public Task<CloudResult<List<string>>> RequestAssetVariant(System.String hash, ResoniteBridge.ResoniteBridgeValue descriptor)
		{
			if (!(descriptor is Texture2DVariantDescriptor texture2DVariantDescriptor))
			{
				if (!(descriptor is CubemapVariantDescriptor cubemapVariantDescriptor))
				{
					if (!(descriptor is Texture3DVariantDescriptor texture3DVariantDescriptor))
					{
						if (!(descriptor is ShaderVariantDescriptor shaderVariantDescriptor))
						{
							if (descriptor is MeshVariantDescriptor meshVariantDescriptor)
							{
								return Api.POST<List<string>>("assets/" + hash + "/meshVariant/" + meshVariantDescriptor.VariantIdentifier, null);
							}
							throw new Exception("Unsupported variant descriptor: " + descriptor.GetType());
						}
						return Api.POST<List<string>>("assets/" + hash + "/shaderVariant/" + shaderVariantDescriptor.VariantIdentifier, null);
					}
					return Api.POST<List<string>>("assets/" + hash + "/volumeVariant/" + texture3DVariantDescriptor.VariantIdentifier, null);
				}
				return Api.POST<List<string>>("assets/" + hash + "/cubemapVariant/" + cubemapVariantDescriptor.VariantIdentifier, null);
			}
			return Api.POST<List<string>>("assets/" + hash + "/bitmapVariant/" + texture2DVariantDescriptor.VariantIdentifier, null);
		}

		public Task<CloudResult> StoreAssetMetadata(ResoniteBridge.ResoniteBridgeValue metadata)
		{
			if (!(metadata is BitmapMetadata metadata2))
			{
				if (!(metadata is CubemapMetadata metadata3))
				{
					if (!(metadata is VolumeMetadata metadata4))
					{
						if (!(metadata is MeshMetadata metadata5))
						{
							if (metadata is ShaderMetadata metadata6)
							{
								return StoreShaderMetadata(metadata.AssetIdentifier, metadata6);
							}
							throw new Exception("Unsupported metadata type: " + metadata.GetType());
						}
						return StoreMeshMetadata(metadata.AssetIdentifier, metadata5);
					}
					return StoreVolumeMetadata(metadata.AssetIdentifier, metadata4);
				}
				return StoreCubemapMetadata(metadata.AssetIdentifier, metadata3);
			}
			return StoreBitmapMetadata(metadata.AssetIdentifier, metadata2);
		}

		public Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> GetBitmapMetadata(System.String hash)
		{
			return Api.GET<BitmapMetadata>("assets/" + hash + "/bitmapMetadata");
		}

		public Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>> GetBitmapMetadata(List<string> hashes)
		{
			return Api.POST<List<BitmapMetadata>>("assets/bitmapMetadata", hashes);
		}

		public Task<CloudResult> StoreBitmapMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			return Api.PUT("assets/" + hash + "/bitmapMetadata", metadata);
		}

		public Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> GetCubemapMetadata(System.String hash)
		{
			return Api.GET<CubemapMetadata>("assets/" + hash + "/cubemapMetadata");
		}

		public Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>> GetCubemapMetadata(List<string> hashes)
		{
			return Api.POST<List<CubemapMetadata>>("assets/cubemapMetadata", hashes);
		}

		public Task<CloudResult> StoreCubemapMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			return Api.PUT("assets/" + hash + "/cubemapMetadata", metadata);
		}

		public Task<CloudResult> StoreVolumeMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			return Api.PUT("assets/" + hash + "/volumeMetadata", metadata);
		}

		public Task<CloudResult> StoreMeshMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			return Api.PUT("assets/" + hash + "/meshMetadata", metadata);
		}

		public Task<CloudResult> StoreShaderMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			return Api.PUT("assets/" + hash + "/shaderMetadata", metadata);
		}

		public Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>> GetAssetComputationTask(System.Boolean usePoisonQueue = false)
		{
			return Api.GET<ExternalQueueObject<AssetVariantComputationTask>>($"processing/assetComputations?computeVersion={AssetUtil.COMPUTE_VERSION}" + $"&usePoisonQueue={usePoisonQueue}", null, throwOnError: false);
		}

		public async Task<CloudResult> ExtendAssetComputationTask(ExternalQueueObject<AssetVariantComputationTask> task)
		{
			CloudResult cloudResult = await Api.PATCH("processing/assetComputations", task);
			if (cloudResult.IsOK)
			{
				task.PopReceipt = cloudResult.Content;
			}
			return cloudResult;
		}

		public Task<CloudResult> FinishAssetComputation(ExternalQueueObject<AssetVariantComputationTask> task)
		{
			string text = "processing/assetComputations/" + Uri.EscapeDataString(task.Id) + "?popReceipt=" + Uri.EscapeDataString(task.PopReceipt);
			if (!string.IsNullOrEmpty(task.BlobKey))
			{
				text = text + "&blobKey=" + Uri.EscapeDataString(task.BlobKey);
			}
			if (task.QueueName != null)
			{
				text = text + "&queueName=" + task.QueueName;
			}
			return Api.DELETE(text);
		}

		public Task<CloudResult> FinishVariantComputation(System.String hash, System.String variantId)
		{
			return Api.POST("processing/assetComputations/" + hash + "/" + variantId, null);
		}

		private static System.String GetMetadataURLSegment(Type type)
		{
			if (type == typeof(ResoniteBridge.ResoniteBridgeValue))
			{
				return "bitmapMetadata";
			}
			if (type == typeof(ResoniteBridge.ResoniteBridgeValue))
			{
				return "cubemapMetadata";
			}
			if (type == typeof(ResoniteBridge.ResoniteBridgeValue))
			{
				return "volumeMetadata";
			}
			if (type == typeof(ResoniteBridge.ResoniteBridgeValue))
			{
				return "meshMetadata";
			}
			if (type == typeof(ResoniteBridge.ResoniteBridgeValue))
			{
				return "shaderMetadata";
			}
			throw new NotImplementedException("Unsupported metadata type: " + type);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
	public abstract class AssetUploadTask : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.Boolean DEBUG_UPLOAD;

		protected Stream assetStream;

		protected System.String assetPath;

		protected ResoniteBridge.ResoniteBridgeValue assetURL;

		protected System.String assetFileName;

		public SkyFrostInterface Cloud { get; private set; }

		public ApiClient Api => Cloud.Api;

		public System.String OwnerId { get; private set; }

		public System.String Signature { get; private set; }

		public System.String Variant { get; private set; }

		public System.Int32 Retries { get; protected set; }

		public System.Boolean IsOptional { get; set; }

		public ResoniteBridge.ResoniteBridgeValue Progress { get; private set; }

		public CloudResult<AssetUploadData> UploadData { get; protected set; }

		public System.Boolean UploadStarted { get; protected set; }

		public System.Int64 TotalBytes { get; private set; }

		public System.Int32 EnqueuedChunks { get; protected set; }

		public System.Int32 UploadedChunks { get; protected set; }

		public abstract System.Int32 MaxParallelChunks { get; }

		public void InitializeWithFile(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, System.String assetPath, ResoniteBridge.ResoniteBridgeValue progress, System.Int32 retries = 5)
		{
			Initialize(cloud, ownerId, signature, variant, assetPath, File.OpenRead(assetPath), null, progress, null, retries);
		}

		public void InitializeWithStream(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, Stream assetStream, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			Initialize(cloud, ownerId, signature, variant, null, assetStream, null, progress, bytes, retries);
		}

		public void InitializeWithURL(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, ResoniteBridge.ResoniteBridgeValue url, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			Initialize(cloud, ownerId, signature, variant, null, null, url, progress, bytes, retries);
		}

		private void Initialize(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, System.String assetPath, Stream assetStream, ResoniteBridge.ResoniteBridgeValue assetURL, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			if (Cloud != null)
			{
				throw new InvalidOperationException("AssetUploadTask is already initialized");
			}
			if (assetURL != null && assetURL.Scheme != "http" && assetURL.Scheme != "https" && assetURL.Scheme != "ftp")
			{
				throw new Exception("Unsupported URL: " + assetURL);
			}
			Cloud = cloud;
			OwnerId = ownerId;
			Signature = signature;
			Variant = variant;
			Retries = retries;
			Progress = progress;
			TotalBytes = bytes ?? (assetStream.Length - assetStream.Position);
			this.assetURL = assetURL;
			this.assetPath = assetPath;
			this.assetStream = assetStream;
			if (!string.IsNullOrEmpty(assetPath))
			{
				assetFileName = Path.GetFileName(assetPath);
			}
			OnInitialize();
		}

		public async Task<CloudResult<AssetUploadData>> RunUpload()
		{
			CloudResult<AssetUploadData> cloudResult = await UploadAssetData().ConfigureAwait(continueOnCapturedContext: false);
			if (cloudResult.IsOK)
			{
				return await WaitForAssetFinishProcessing().ConfigureAwait(continueOnCapturedContext: false);
			}
			return cloudResult;
		}

		public abstract Task<CloudResult<AssetUploadData>> UploadAssetData();

		public abstract ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing();

		protected virtual void OnInitialize()
		{
		}

		protected void DisposeOfStream()
		{
			if (assetPath != null)
			{
				assetStream.Dispose();
			}
			assetStream = null;
		}

		public virtual void Dispose()
		{
			DisposeOfStream();
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
	public abstract class AssetUploadTask<TChunkResult> : AssetUploadTask, ResoniteBridge.ResoniteBridgeValueHolder where TChunkResult : class
	{
		private class UploadChunkBuffer : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public byte[] data
			{
				get
				{
					return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "data"), typeof(byte[]));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "data", value);
				}
			}

			public Task<CloudResult<TChunkResult>> task
			{
				get
				{
					return (Task<CloudResult<TChunkResult>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "task"), typeof(Task<CloudResult<TChunkResult>>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "task", value);
				}
			}

			public System.Int32 chunk
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "chunk"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "chunk", value);
				}
			}

			public System.Int32 length
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "length"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "length", value);
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

			public UploadChunkBuffer(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public UploadChunkBuffer()
			{
			}
		}

		private void EnqueueChunk(UploadChunkBuffer buffer, List<UploadChunkBuffer> processingBuffers)
		{
			buffer.task = base.Api.RunRequest<TChunkResult>(() => CreateChunkUploadRequest(buffer.chunk, buffer.data, buffer.length), TimeSpan.FromMinutes(5.0), throwOnError: true);
			processingBuffers.Add(buffer);
		}

		private async Task<UploadChunkBuffer> TakeFinishedBuffer(List<UploadChunkBuffer> buffers)
		{
			List<Task> tasks = Pool.BorrowList<Task>();
			for (int i = 0; i < buffers.Count; i++)
			{
				if (buffers[i].task != null)
				{
					if (AssetUploadTask.DEBUG_UPLOAD)
					{
						UniLog.Log($"Adding task from chunk {buffers[i].chunk}: {buffers[i].task.Id}, IsCompleted: {buffers[i].task.IsCompleted}, IsCanceled: {buffers[i].task.IsCanceled}, IsFaulted: {buffers[i].task.IsFaulted}");
					}
					tasks.Add(buffers[i].task);
				}
			}
			if (AssetUploadTask.DEBUG_UPLOAD)
			{
				UniLog.Log("Waiting for any task to finish. Count: " + tasks.Count);
			}
			await Task.WhenAny(tasks).ConfigureAwait(continueOnCapturedContext: false);
			if (AssetUploadTask.DEBUG_UPLOAD)
			{
				UniLog.Log("Task finished, checking buffers");
			}
			Pool.Return(ref tasks);
			foreach (UploadChunkBuffer buffer in buffers)
			{
				if (AssetUploadTask.DEBUG_UPLOAD)
				{
					UniLog.Log($"Buffer Task {buffer.task?.Id} from chunk {buffer.chunk}. IsCompleted: {buffer.task?.IsCompleted}. IsCanceled: {buffer.task?.IsCanceled}. IsFaulted: {buffer.task?.IsFaulted}");
				}
				if (buffer.task != null && buffer.task.IsCompleted)
				{
					buffers.Remove(buffer);
					return buffer;
				}
			}
			throw new Exception("No Finished Buffer Available");
		}

		public override async Task<CloudResult<AssetUploadData>> UploadAssetData()
		{
			if (base.UploadStarted)
			{
				throw new InvalidOperationException("Upload already started");
			}
			base.UploadStarted = true;
			CloudResult<AssetUploadData> cloudResult = null;
			for (int attempt = 0; attempt < base.Retries; attempt++)
			{
				cloudResult = await Upload().ConfigureAwait(continueOnCapturedContext: false);
				if (cloudResult.IsOK)
				{
					return cloudResult;
				}
				if (cloudResult.State == HttpStatusCode.Forbidden && base.IsOptional)
				{
					return cloudResult;
				}
				if (cloudResult.State == HttpStatusCode.BadRequest && (cloudResult.Content?.Contains("AlreadyUploaded") ?? false))
				{
					return cloudResult;
				}
				assetStream?.Seek(0L, SeekOrigin.Begin);
				UniLog.Warning($"Error uploading asset data {base.OwnerId}:{base.Signature}:{base.Variant}. Attempt: {attempt}\n{cloudResult}");
			}
			return cloudResult;
		}

		private async Task<CloudResult<AssetUploadData>> Upload()
		{
			CloudResult<AssetUploadData> assetUploadResult = (base.UploadData = await InitiateUpload().ConfigureAwait(continueOnCapturedContext: false));
			if (AssetUploadTask.DEBUG_UPLOAD)
			{
				UniLog.Log("Initiate Chunk Upload: " + assetUploadResult);
			}
			if (assetUploadResult.IsError)
			{
				return assetUploadResult;
			}
			await UploadInitiated(base.UploadData.Entity).ConfigureAwait(continueOnCapturedContext: false);
			List<UploadChunkBuffer> freeBuffers = Pool.BorrowList<UploadChunkBuffer>();
			List<UploadChunkBuffer> processingBuffers = Pool.BorrowList<UploadChunkBuffer>();
			for (int i = 0; i < MathX.Min(base.UploadData.Entity.TotalChunks, MaxParallelChunks); i++)
			{
				UploadChunkBuffer uploadChunkBuffer = new UploadChunkBuffer();
				if (assetStream != null)
				{
					uploadChunkBuffer.data = new byte[base.UploadData.Entity.ChunkSize];
				}
				freeBuffers.Add(uploadChunkBuffer);
			}
			Stopwatch s = Stopwatch.StartNew();
			base.EnqueuedChunks = 0;
			base.UploadedChunks = 0;
			while (base.UploadedChunks < base.UploadData.Entity.TotalChunks)
			{
				bool flag;
				UploadChunkBuffer uploadBuffer;
				if (freeBuffers.Count > 0 && base.EnqueuedChunks < base.UploadData.Entity.TotalChunks)
				{
					uploadBuffer = freeBuffers.TakeLast();
					int expectedSize = ((base.EnqueuedChunks == base.UploadData.Entity.TotalChunks - 1) ? base.UploadData.Entity.LastChunkSize : base.UploadData.Entity.ChunkSize);
					if (assetStream != null)
					{
						int totalRead;
						for (totalRead = 0; totalRead < expectedSize; totalRead += await assetStream.ReadAsync(uploadBuffer.data, totalRead, expectedSize - totalRead).ConfigureAwait(continueOnCapturedContext: false))
						{
							if (!assetStream.CanRead)
							{
								break;
							}
						}
						if (totalRead != expectedSize)
						{
							UniLog.Log($"Source stream didn't provide enough data for chunk. Expected: {expectedSize}, got: {totalRead}");
							return new CloudResult<AssetUploadData>(null, (ResoniteBridge.ResoniteBridgeValue)0, null, 0);
						}
					}
					uploadBuffer.chunk = base.EnqueuedChunks;
					uploadBuffer.length = expectedSize;
					if (AssetUploadTask.DEBUG_UPLOAD)
					{
						UniLog.Log($"Enqueuing chunk {base.EnqueuedChunks}.");
					}
					EnqueueChunk(uploadBuffer, processingBuffers);
					base.EnqueuedChunks++;
					flag = freeBuffers.Count == 0;
				}
				else
				{
					flag = true;
				}
				if (!flag)
				{
					continue;
				}
				if (AssetUploadTask.DEBUG_UPLOAD)
				{
					UniLog.Log("Waiting for finished buffer");
				}
				uploadBuffer = await TakeFinishedBuffer(processingBuffers).ConfigureAwait(continueOnCapturedContext: false);
				if (AssetUploadTask.DEBUG_UPLOAD)
				{
					UniLog.Log($"Got finished buffer {uploadBuffer.chunk}: " + uploadBuffer?.task);
				}
				if (uploadBuffer.task.IsCanceled)
				{
					if (AssetUploadTask.DEBUG_UPLOAD)
					{
						UniLog.Log($"Task failed, enqueuing chunk {uploadBuffer.chunk} again");
					}
					EnqueueChunk(uploadBuffer, processingBuffers);
					continue;
				}
				CloudResult<TChunkResult> cloudResult2 = await uploadBuffer.task.ConfigureAwait(continueOnCapturedContext: false);
				if (AssetUploadTask.DEBUG_UPLOAD)
				{
					UniLog.Log($"Chunk {uploadBuffer.chunk} result: " + cloudResult2);
				}
				if (cloudResult2.IsError)
				{
					return new CloudResult<AssetUploadData>(null, cloudResult2.State, cloudResult2.Headers, cloudResult2.RequestAttempts, cloudResult2.Content);
				}
				ProcessChunkUploadResult(uploadBuffer.chunk, cloudResult2.Entity);
				uploadBuffer.task = null;
				freeBuffers.Add(uploadBuffer);
				base.UploadedChunks++;
				float num = (System.Single)base.UploadedChunks / (System.Single)base.UploadData.Entity.TotalChunks;
				base.Progress?.UpdateProgress(num, "Upload", $"Chunk {base.UploadedChunks} out of {base.UploadData.Entity.TotalChunks} ({num * 100f:F0} %)");
			}
			s.Stop();
			try
			{
				DisposeOfStream();
			}
			catch (Exception ex)
			{
				UniLog.Error("Exception when disposing of stream:\n" + ex);
			}
			double rate = (System.Double)base.UploadData.Entity.TotalBytes / s.Elapsed.TotalSeconds;
			Pool.Return(ref processingBuffers);
			Pool.Return(ref freeBuffers);
			CloudResult cloudResult3 = await FinalizeChunkUpload().ConfigureAwait(continueOnCapturedContext: false);
			if (cloudResult3.IsError)
			{
				UniLog.Log($"Asset {assetPath ?? base.Signature} failed to complete upload. State: {cloudResult3.State}, Message: {cloudResult3.Content}");
				base.UploadData = new CloudResult<AssetUploadData>(base.UploadData.Entity, cloudResult3.State, cloudResult3.Headers, cloudResult3.RequestAttempts, cloudResult3.Content);
				return base.UploadData;
			}
			UniLog.Log($"Asset {assetPath ?? base.Signature} uploaded in {s.Elapsed}. Average rate: {UnitFormatting.FormatBytes(rate)}/s");
			return assetUploadResult;
		}

		protected abstract Task<CloudResult<AssetUploadData>> InitiateUpload();

		protected virtual Task UploadInitiated(AssetUploadData data)
		{
			return Task.CompletedTask;
		}

		protected abstract ResoniteBridge.ResoniteBridgeValue CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length);

		protected abstract void ProcessChunkUploadResult(System.Int32 chunkIndex, TChunkResult result);

		protected abstract Task<CloudResult> FinalizeChunkUpload();

		protected async ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing(System.String apiUrl)
		{
			if (base.UploadData.Entity.IsDirectUpload)
			{
				base.UploadData.Entity.UploadState = UploadState.Uploaded;
				return new CloudResult<AssetUploadData>(base.UploadData.Entity, HttpStatusCode.OK, null, 0);
			}
			CloudResult<AssetUploadData> cloudResult2;
			while (true)
			{
				cloudResult2 = (base.UploadData = await base.Api.GET<AssetUploadData>(apiUrl).ConfigureAwait(continueOnCapturedContext: false));
				if (cloudResult2.IsError)
				{
					return cloudResult2;
				}
				if (cloudResult2.Entity.UploadState == UploadState.Uploaded || cloudResult2.Entity.UploadState == UploadState.Failed)
				{
					break;
				}
				await Task.Delay(1500).ConfigureAwait(continueOnCapturedContext: false);
			}
			return cloudResult2;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
	public static class AssetUtil
	{
		public static System.Int32 COMPUTE_VERSION => 18;

		public static System.String GenerateHashSignature(System.String file)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateHashSignature", file), typeof(System.String));
		}

		public static System.String GenerateHashSignature(Stream fileStream)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateHashSignature", fileStream), typeof(System.String));
		}

		public static System.String ComposeIdentifier(System.String signature, System.String variant)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "ComposeIdentifier", signature, variant), typeof(System.String));
		}

		public static void SplitIdentifier(System.String identifier, out System.String signature, out System.String variant)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "SplitIdentifier", identifier, signature, variant);
		}
	}
	public class AssetVariantIdentifier : ResoniteBridge.ResoniteBridgeValueHolder
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

		[JsonProperty(PropertyName = "variantIdentifier")]
		[JsonPropertyName("variantIdentifier")]
		public System.String VariantIdentifier
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantIdentifier"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariantIdentifier", value);
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

		public AssetVariantIdentifier(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AssetVariantIdentifier()
		{
		}
	}
	public class AzureAssetInterface : AssetInterface, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("blobEndpoint")]
		public System.String BlobEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BlobEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BlobEndpoint", value);
			}
		}

		[JsonPropertyName("thumbnailEndpoint")]
		public System.String ThumbnailEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailEndpoint", value);
			}
		}

		[JsonPropertyName("legacyBlobEndpoint")]
		public System.String LegacyBlobEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyBlobEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LegacyBlobEndpoint", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String AssetsEndpoint => BlobEndpoint + "assets/";

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String InstallsEndpoint => BlobEndpoint + "install/";

		public AzureAssetInterface(System.String blobEndpoint, System.String thumbnailEndpoint, System.String legacyBlobEndpoint)
		{
			BlobEndpoint = blobEndpoint;
			ThumbnailEndpoint = thumbnailEndpoint;
			LegacyBlobEndpoint = legacyBlobEndpoint;
		}

		public override ResoniteBridge.ResoniteBridgeValue DBToHttp(ResoniteBridge.ResoniteBridgeValue productDBUri, DB_Endpoint endpoint)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBToHttp", productDBUri, endpoint), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override ResoniteBridge.ResoniteBridgeValue ThumbnailToHttp(ThumbnailInfo thumbnail)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailToHttp", thumbnail), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue ThumbnailIdToHttp(System.String id)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailIdToHttp", id), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		protected override AssetUploadTask CreateEmptyAssetUploadTask()
		{
			return (AssetUploadTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateEmptyAssetUploadTask"), typeof(AssetUploadTask));
		}

		public override Task<CloudResult> GetAssetMime(System.String hash)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMime", hash), typeof(Task<CloudResult>));
		}

		public override Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String session)
		{
			return (Task<CloudResult<ThumbnailInfo>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadThumbnail", path, session), typeof(Task<CloudResult<ThumbnailInfo>>));
		}

		public override Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash)
		{
			return (Task<CloudResult<List<string>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAvailableVariants", hash), typeof(Task<CloudResult<List<string>>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AzureAssetInterface(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AzureAssetUploadTask : AssetUploadTask<CloudMessage>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.Int32 UPLOAD_DEGREE_OF_PARALLELISM
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AzureAssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "UPLOAD_DEGREE_OF_PARALLELISM"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AzureAssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "UPLOAD_DEGREE_OF_PARALLELISM", value);
			}
		}

		private System.String baseUrl
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "baseUrl"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "baseUrl", value);
			}
		}

		public override System.Int32 MaxParallelChunks => UPLOAD_DEGREE_OF_PARALLELISM;

		protected override void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		protected override Task<CloudResult<AssetUploadData>> InitiateUpload()
		{
			return (Task<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitiateUpload"), typeof(Task<CloudResult<AssetUploadData>>));
		}

		protected override ResoniteBridge.ResoniteBridgeValue CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateChunkUploadRequest", chunkIndex, data, length), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		protected override Task<CloudResult> FinalizeChunkUpload()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeChunkUpload"), typeof(Task<CloudResult>));
		}

		protected override void ProcessChunkUploadResult(System.Int32 chunkIndex, CloudMessage result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessChunkUploadResult", chunkIndex, result);
		}

		public override ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing()
		{
			return (ValueTask<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing"), typeof(ValueTask<CloudResult<AssetUploadData>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AzureAssetUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AzureAssetUploadTask()
		{
		}
	}
	public class CloudflareAssetInterface : AssetInterface, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("apiEndpoint")]
		public System.String ApiEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApiEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ApiEndpoint", value);
			}
		}

		[JsonPropertyName("assetsEndpoint")]
		public System.String AssetsEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsEndpoint", value);
			}
		}

		[JsonPropertyName("variantsEndpoint")]
		public System.String VariantsEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantsEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariantsEndpoint", value);
			}
		}

		[JsonPropertyName("thumbnailsEndpoint")]
		public System.String ThumbnailsEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailsEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailsEndpoint", value);
			}
		}

		public CloudflareAssetInterface(System.String apiEndpoint, System.String assetsEndpoint, System.String variantsEndpoint, System.String thumbnailsEndpoint)
		{
			ApiEndpoint = apiEndpoint;
			AssetsEndpoint = assetsEndpoint;
			VariantsEndpoint = variantsEndpoint;
			ThumbnailsEndpoint = thumbnailsEndpoint;
		}

		public override ResoniteBridge.ResoniteBridgeValue DBToHttp(ResoniteBridge.ResoniteBridgeValue dbUri, DB_Endpoint endpoint)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBToHttp", dbUri, endpoint), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public override ResoniteBridge.ResoniteBridgeValue ThumbnailToHttp(ThumbnailInfo thumbnail)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailToHttp", thumbnail), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public async Task<CloudResult<BlobMetadata>> GetAssetMedata(System.String hash)
		{
			return (Task<CloudResult<BlobMetadata>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMedata", hash), typeof(Task<CloudResult<BlobMetadata>>));
		}

		public override async Task<CloudResult> GetAssetMime(System.String hash)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMime", hash), typeof(Task<CloudResult>));
		}

		public override Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash)
		{
			return (Task<CloudResult<List<string>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAvailableVariants", hash), typeof(Task<CloudResult<List<string>>>));
		}

		public override async Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String sessionId)
		{
			return (Task<CloudResult<ThumbnailInfo>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadThumbnail", path, sessionId), typeof(Task<CloudResult<ThumbnailInfo>>));
		}

		protected override AssetUploadTask CreateEmptyAssetUploadTask()
		{
			return (AssetUploadTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateEmptyAssetUploadTask"), typeof(AssetUploadTask));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudflareAssetInterface(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudflareChunkResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String ETag
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ETag"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ETag", value);
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

		public CloudflareChunkResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CloudflareChunkResult()
		{
		}
	}
	public class CloudflareAssetUploadTask : AssetUploadTask<CloudflareChunkResult>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.String apiBaseUrl
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "apiBaseUrl"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "apiBaseUrl", value);
			}
		}

		private List<AssetChunk> parts
		{
			get
			{
				return (List<AssetChunk>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "parts"), typeof(List<AssetChunk>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "parts", value);
			}
		}

		public override System.Int32 MaxParallelChunks => Math.Max(1, (base.UploadData?.Entity?.MaxUploadConcurrency).GetValueOrDefault());

		protected override void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		protected override Task UploadInitiated(AssetUploadData data)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadInitiated", data), typeof(Task));
		}

		protected override ResoniteBridge.ResoniteBridgeValue CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateChunkUploadRequest", chunkIndex, data, length), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		protected override Task<CloudResult<AssetUploadData>> InitiateUpload()
		{
			return (Task<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitiateUpload"), typeof(Task<CloudResult<AssetUploadData>>));
		}

		protected override Task<CloudResult> FinalizeChunkUpload()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeChunkUpload"), typeof(Task<CloudResult>));
		}

		protected override void ProcessChunkUploadResult(System.Int32 chunkIndex, CloudflareChunkResult result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessChunkUploadResult", chunkIndex, result);
		}

		public override ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing()
		{
			return (ValueTask<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing"), typeof(ValueTask<CloudResult<AssetUploadData>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudflareAssetUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CloudflareAssetUploadTask()
		{
		}
	}
	public static class LegacyAssetMap
	{
		private static Dictionary<string, string> map
		{
			get
			{
				return (Dictionary<string, string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "LegacyAssetMap", ResoniteBridge.ResoniteBridgeValueType.Type), "map"), typeof(Dictionary<string, string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "LegacyAssetMap", ResoniteBridge.ResoniteBridgeValueType.Type), "map", value);
			}
		}

		public static System.String MapLegacySignature(System.String signature)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "LegacyAssetMap", ResoniteBridge.ResoniteBridgeValueType.Type), "MapLegacySignature", signature), typeof(System.String));
		}
	}
	public struct CloudVariableIdentity : IEquatable<CloudVariableIdentity>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String ownerId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ownerId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ownerId", value);
			}
		}

		public System.String path
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "path"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "path", value);
			}
		}

		public CloudVariableIdentity(System.String ownerId, System.String path)
		{
			this.ownerId = ownerId;
			this.path = path;
		}

		public override System.Boolean Equals(System.Object obj)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean));
		}

		public System.Boolean Equals(CloudVariableIdentity other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public override System.Int32 GetHashCode()
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetHashCode"), typeof(System.Int32));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public static bool operator ==(CloudVariableIdentity left, CloudVariableIdentity right)
		{
			return left.Equals(right);
		}

		public static bool operator !=(CloudVariableIdentity left, CloudVariableIdentity right)
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

		public CloudVariableIdentity(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public delegate void CloudVariableEventHandler(CloudVariableProxy proxy);
	public struct TimestampedCloudVariable<T> : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public T value
		{
			get
			{
				return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "value"), typeof(T));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "value", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue timestamp
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "timestamp"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "timestamp", value);
			}
		}

		public TimestampedCloudVariable(T value, ResoniteBridge.ResoniteBridgeValue timestamp)
		{
			this.value = value;
			this.timestamp = timestamp;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public TimestampedCloudVariable(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum CloudVariableState
	{
		Uninitialized,
		ReadFromTheCloud,
		ChangedLocally,
		WrittenToCloud,
		Invalid,
		Unregistered
	}
	public class CloudVariableManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<CloudVariableIdentity, CloudVariableProxy> _variableProxies
		{
			get
			{
				return (Dictionary<CloudVariableIdentity, CloudVariableProxy>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_variableProxies"), typeof(Dictionary<CloudVariableIdentity, CloudVariableProxy>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_variableProxies", value);
			}
		}

		private HashSet<CloudVariableProxy> _changedVariables
		{
			get
			{
				return (HashSet<CloudVariableProxy>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_changedVariables"), typeof(HashSet<CloudVariableProxy>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_changedVariables", value);
			}
		}

		private VariableReadBatchQuery _readBatch
		{
			get
			{
				return (VariableReadBatchQuery)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_readBatch"), typeof(VariableReadBatchQuery));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_readBatch", value);
			}
		}

		private VariableWriteBatchQuery _writeBatch
		{
			get
			{
				return (VariableWriteBatchQuery)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_writeBatch"), typeof(VariableWriteBatchQuery));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_writeBatch", value);
			}
		}

		public ILocalVariableAccessor LocalAccessor
		{
			get
			{
				return (ILocalVariableAccessor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalAccessor"), typeof(ILocalVariableAccessor));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LocalAccessor", value);
			}
		}

		internal System.Object Lock
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Lock"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Lock", value);
			}
		}

		public void SetLocalAccessor(ILocalVariableAccessor accessor)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetLocalAccessor", accessor);
		}

		internal Task<VariableReadResult<CloudVariable, CloudVariableDefinition>> ReadVariable(System.String ownerId, System.String path)
		{
			return (Task<VariableReadResult<CloudVariable, CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadVariable", ownerId, path), typeof(Task<VariableReadResult<CloudVariable, CloudVariableDefinition>>));
		}

		internal Task<CloudVariable> WriteVariable(CloudVariable variable)
		{
			return (Task<CloudVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteVariable", variable), typeof(Task<CloudVariable>));
		}

		internal void RegisterChanged(CloudVariableProxy proxies)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterChanged", proxies);
		}

		public CloudVariableManager(SkyFrostInterface cloud)
			: base(cloud)
		{
			_readBatch = new VariableReadBatchQuery(this);
			_writeBatch = new VariableWriteBatchQuery(this);
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public void SignIn()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignIn");
		}

		public async Task SignOut()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task));
		}

		public async Task SaveAllChangedVariables()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAllChangedVariables"), typeof(Task));
		}

		public CloudVariableProxy RequestProxy(System.String ownerId, System.String path)
		{
			return (CloudVariableProxy)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestProxy", ownerId, path), typeof(CloudVariableProxy));
		}

		public CloudVariableProxy RegisterListener(System.String ownerId, System.String path, CloudVariableEventHandler onChanged)
		{
			return (CloudVariableProxy)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", ownerId, path, onChanged), typeof(CloudVariableProxy));
		}

		internal System.Boolean TryUnregisterProxy(CloudVariableProxy proxy)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryUnregisterProxy", proxy), typeof(System.Boolean));
		}

		public Task<CloudResult<CloudVariableDefinition>> GetDefinition(System.String ownerId, System.String subpath)
		{
			return (Task<CloudResult<CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefinition", ownerId, subpath), typeof(Task<CloudResult<CloudVariableDefinition>>));
		}

		public Task<CloudResult<CloudVariableDefinition>> UpsertDefinition(CloudVariableDefinition definition)
		{
			return (Task<CloudResult<CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertDefinition", definition), typeof(Task<CloudResult<CloudVariableDefinition>>));
		}

		public Task<CloudResult> DeleteDefinition(System.String ownerId, System.String subpath)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteDefinition", ownerId, subpath), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<T>> ReadGlobal<T>(System.String path, System.String variableType)
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadGlobal", path, variableType), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<CloudVariable>> Get(System.String ownerId, System.String path)
		{
			return (Task<CloudResult<CloudVariable>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Get", ownerId, path), typeof(Task<CloudResult<CloudVariable>>));
		}

		public async Task<CloudResult<TimestampedCloudVariable<T>>> ReadWithTimestamp<T>(System.String ownerId, System.String path, System.String variableType = null)
		{
			return (Task<CloudResult<TimestampedCloudVariable<T>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadWithTimestamp", ownerId, path, variableType), typeof(Task<CloudResult<TimestampedCloudVariable<T>>>));
		}

		public async Task<CloudResult<T>> Read<T>(System.String ownerId, System.String path, System.String variableType = null)
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", ownerId, path, variableType), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<List<VariableReadResult<CloudVariable, CloudVariableDefinition>>>> ReadBatch(List<VariableReadRequest> batch)
		{
			return (Task<CloudResult<List<VariableReadResult<CloudVariable, CloudVariableDefinition>>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadBatch", batch), typeof(Task<CloudResult<List<VariableReadResult<CloudVariable, CloudVariableDefinition>>>>));
		}

		public Task<CloudResult<List<CloudVariable>>> GetAllByOwner(System.String ownerId)
		{
			return (Task<CloudResult<List<CloudVariable>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAllByOwner", ownerId), typeof(Task<CloudResult<List<CloudVariable>>>));
		}

		public Task<CloudResult<List<CloudVariableDefinition>>> ListDefinitions(System.String ownerId)
		{
			return (Task<CloudResult<List<CloudVariableDefinition>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListDefinitions", ownerId), typeof(Task<CloudResult<List<CloudVariableDefinition>>>));
		}

		public Task<CloudResult<List<CloudVariable>>> WriteBatch(List<CloudVariable> batch)
		{
			return (Task<CloudResult<List<CloudVariable>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteBatch", batch), typeof(Task<CloudResult<List<CloudVariable>>>));
		}

		public Task<CloudResult> Write<T>(System.String ownerId, System.String path, T value, System.String variableType = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", ownerId, path, value, variableType), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> Upsert(CloudVariable variable)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Upsert", variable), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> Delete(System.String ownerId, System.String path)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Delete", ownerId, path), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<T>> ReadOwners<T>(System.String path, System.String variableType = null)
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadOwners", path, variableType), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<TimestampedCloudVariable<T>>> ReadOwnersWithTimestamp<T>(System.String path, System.String variableType = null)
		{
			return (Task<CloudResult<TimestampedCloudVariable<T>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadOwnersWithTimestamp", path, variableType), typeof(Task<CloudResult<TimestampedCloudVariable<T>>>));
		}

		public Task<CloudResult> WriteOwners<T>(System.String path, T value, System.String variableType = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteOwners", path, value, variableType), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> Delete(System.String path)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Delete", path), typeof(Task<CloudResult>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudVariableManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface ILocalVariableAccessor : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Task<CloudVariable> ReadLocalVariable(System.String path, System.String defaultValue);

		Task WriteLocalVariable(CloudVariable variable);
	}
	public class CloudVariableProxy : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Double WRITE_DELAY_SECONDS
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WRITE_DELAY_SECONDS"), typeof(System.Double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WRITE_DELAY_SECONDS", value);
			}
		}

		public System.Double REFRESH_INTERVAL_SECONDS
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "REFRESH_INTERVAL_SECONDS"), typeof(System.Double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "REFRESH_INTERVAL_SECONDS", value);
			}
		}

		public System.Double UNREGISTER_DELAY_SECONDS
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "UNREGISTER_DELAY_SECONDS"), typeof(System.Double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "UNREGISTER_DELAY_SECONDS", value);
			}
		}

		public CloudVariableDefinition _definition
		{
			get
			{
				return (CloudVariableDefinition)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_definition"), typeof(CloudVariableDefinition));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_definition", value);
			}
		}

		private CloudVariable _variable
		{
			get
			{
				return (CloudVariable)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_variable"), typeof(CloudVariable));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_variable", value);
			}
		}

		private System.Boolean _isLocalVariable
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_isLocalVariable"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_isLocalVariable", value);
			}
		}

		private System.String _definitionOwnerId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_definitionOwnerId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_definitionOwnerId", value);
			}
		}

		private System.String _definitionSubpath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_definitionSubpath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_definitionSubpath", value);
			}
		}

		private CloudVariableManager _manager
		{
			get
			{
				return (CloudVariableManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_manager"), typeof(CloudVariableManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_manager", value);
			}
		}

		private ILocalVariableAccessor _localVariableAccessor
		{
			get
			{
				return (ILocalVariableAccessor)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_localVariableAccessor"), typeof(ILocalVariableAccessor));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_localVariableAccessor", value);
			}
		}

		private Task _readTask
		{
			get
			{
				return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_readTask"), typeof(Task));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_readTask", value);
			}
		}

		private CancellationTokenSource _readCancel
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_readCancel"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_readCancel", value);
			}
		}

		private Task _writeTask
		{
			get
			{
				return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_writeTask"), typeof(Task));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_writeTask", value);
			}
		}

		private CancellationTokenSource _unregisterCancel
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_unregisterCancel"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_unregisterCancel", value);
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

		public CloudVariableState State
		{
			get
			{
				return (CloudVariableState)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(CloudVariableState));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		public System.Boolean HasValidValue
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasValidValue"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasValidValue", value);
			}
		}

		public DateTime LastCloudWrite
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastCloudWrite"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastCloudWrite", value);
			}
		}

		public DateTime LastCloudRead
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastCloudRead"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastCloudRead", value);
			}
		}

		public CloudVariableIdentity Identity
		{
			get
			{
				return (CloudVariableIdentity)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Identity"), typeof(CloudVariableIdentity));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Identity", value);
			}
		}

		public System.Boolean HasListeners => this._valueChanged != null;

		public System.String RawValue => _variable?.Value;

		public System.Boolean IsDefinitionOwner
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDefinitionOwner"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsDefinitionOwner", value);
			}
		}

		public System.Boolean IsVariableOwner => IdUtil.GetOwnerType(Identity.ownerId) switch
		{
			OwnerType.Machine => true, 
			OwnerType.User => Identity.ownerId == Cloud.Session.CurrentUserID, 
			_ => Cloud.Groups.IsCurrentUserMemberOfGroup(Identity.ownerId), 
		};

		public System.Boolean PublicRead
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicRead"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicRead", value);
			}
		}

		public System.Boolean PublicWrite
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicWrite"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicWrite", value);
			}
		}

		public System.Boolean PrivateWrite
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrivateWrite"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrivateWrite", value);
			}
		}

		public SkyFrostInterface Cloud => _manager.Cloud;

		private event CloudVariableEventHandler _valueChanged;

		public CloudVariableProxy(CloudVariableIdentity identity, CloudVariableManager manager, ILocalVariableAccessor localReader)
		{
			Identity = identity;
			_manager = manager;
			_localVariableAccessor = localReader;
			_isLocalVariable = IdUtil.GetOwnerType(Identity.ownerId) == OwnerType.Machine;
			if (_isLocalVariable && _localVariableAccessor == null)
			{
				throw new InvalidOperationException("Cannot request a local cloud variable without passing valid local reader");
			}
			int num = identity.path.IndexOf(".");
			_definitionOwnerId = identity.path.Substring(0, num);
			_definitionSubpath = identity.path.Substring(num + 1);
			State = CloudVariableState.Uninitialized;
			ScheduleUnregistration();
			Task.Run(async delegate
			{
				_ = 1;
				do
				{
					try
					{
						await Refresh().ConfigureAwait(continueOnCapturedContext: false);
						await Task.Delay(TimeSpan.FromSeconds(300.0));
					}
					catch (Exception arg)
					{
						UniLog.Error($"Exception when running refresh for cloud variable proxy {Identity}\n{arg}");
					}
				}
				while (State != CloudVariableState.Unregistered && State != CloudVariableState.Invalid);
			});
		}

		public void Register(CloudVariableEventHandler onChanged)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Register", onChanged);
		}

		public void Unregister(CloudVariableEventHandler onChanged)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Unregister", onChanged);
		}

		private void ScheduleUnregistration()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleUnregistration");
		}

		public System.Boolean WriteToCloud()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteToCloud"), typeof(System.Boolean));
		}

		public async Task ForceWriteToCloud()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceWriteToCloud"), typeof(Task));
		}

		public Task Refresh()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Refresh"), typeof(Task));
		}

		private System.Boolean CanAccessInPublic(List<string> permissions)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPublic", permissions), typeof(System.Boolean));
		}

		private System.Boolean CanAccessInPrivate(List<string> permissions)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPrivate", permissions), typeof(System.Boolean));
		}

		private System.Boolean CanAccessInPrivate(System.String perm)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPrivate", perm), typeof(System.Boolean));
		}

		public T ReadValue<T>()
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValue"), typeof(T));
		}

		public System.Boolean SetValue(System.String value)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value), typeof(System.Boolean));
		}

		public System.Boolean SetValue<T>(T value)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value), typeof(System.Boolean));
		}

		private void RunChangedEvent()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunChangedEvent");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudVariableProxy(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AppHub : IHubServer, IHubDebugClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private CancellationTokenSource _cancellation
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cancellation"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cancellation", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue Hub
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hub"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hub", value);
			}
		}

		private CancellationToken Token => _cancellation.Token;

		private System.Boolean IsClosed => _cancellation.IsCancellationRequested;

		public AppHub(ResoniteBridge.ResoniteBridgeValue hub)
		{
			Hub = hub;
			_cancellation = new CancellationTokenSource();
		}

		public void Disconnect()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Disconnect");
		}

		private async ValueTask EnsureConnectedHub()
		{
			return (ValueTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureConnectedHub"), typeof(ValueTask));
		}

		public Task Pong(System.Int32 index)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pong", index), typeof(Task));
		}

		public Task Debug(System.String message)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Debug", message), typeof(Task));
		}

		public async Task Ping(System.Int32 index)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Ping", index), typeof(Task));
		}

		public async Task SendMessage(Message message)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendMessage", message), typeof(Task));
		}

		public async Task MarkMessagesRead(MarkReadBatch markReadBatch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkMessagesRead", markReadBatch), typeof(Task));
		}

		public async Task BroadcastStatus(UserStatus status, BroadcastTarget target)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastStatus", status, target), typeof(Task));
		}

		public async Task<bool> UpdateContact(Contact contact)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContact", contact), typeof(Task<bool>));
		}

		public async Task ListenOnContact(System.String contactId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenOnContact", contactId), typeof(Task));
		}

		public async Task ListenOnKey(System.String broadcastKey)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenOnKey", broadcastKey), typeof(Task));
		}

		public async Task RequestStatus(System.String userId = null, System.Boolean invisible = false)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestStatus", userId, invisible), typeof(Task));
		}

		public async Task<StatusInitializationResult> InitializeStatus()
		{
			return (Task<StatusInitializationResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeStatus"), typeof(Task<StatusInitializationResult>));
		}

		public async ResoniteBridge.ResoniteBridgeValue InitializeContacts(CancellationToken cancellationToken)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeContacts", cancellationToken), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public async Task BroadcastSession(SessionInfo session, BroadcastTarget target)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastSession", session, target), typeof(Task));
		}

		public async Task BroadcastSessionEnded(System.String sessionId, DateTime timestamp, BroadcastTarget target)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastSessionEnded", sessionId, timestamp, target), typeof(Task));
		}

		public async Task ListenForLNLPokeRequests(System.String universeId, System.String connectionUrl)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenForLNLPokeRequests", universeId, connectionUrl), typeof(Task));
		}

		public async Task RequestLNLPoke(System.String universeId, System.String connectionUrl, System.String address, System.Int32 port)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestLNLPoke", universeId, connectionUrl, address, port), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AppHub(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class HubStatusController : IHubStatusClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private CancellationTokenSource _initializationCancellation
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initializationCancellation"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initializationCancellation", value);
			}
		}

		private System.Int32 exceptionCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "exceptionCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "exceptionCount", value);
			}
		}

		public System.Boolean Initialized
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Initialized"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Initialized", value);
			}
		}

		public System.Boolean Initializing => _initializationCancellation != null;

		public SkyFrostInterface Cloud
		{
			get
			{
				return (SkyFrostInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Cloud", value);
			}
		}

		public event Action<string> OnUserStatusRequested;

		public event Action<string, string> OnKeyListenerAdded;

		public HubStatusController(SkyFrostInterface cloud)
		{
			Cloud = cloud;
		}

		internal void ResetInitializationStatus()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetInitializationStatus");
		}

		public void Initialize(CancellationToken token)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", token);
		}

		private void RunInitialization(CancellationToken cancellation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunInitialization", cancellation);
		}

		public async Task SignOut()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task));
		}

		public async Task ReceiveStatusUpdate(UserStatus status)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveStatusUpdate", status), typeof(Task));
		}

		public async Task SendStatusToUser(System.String userId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendStatusToUser", userId), typeof(Task));
		}

		public async Task ContactAddedOrUpdated(Contact contact)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactAddedOrUpdated", contact), typeof(Task));
		}

		public async Task KeyListenerAdded(System.String broadcastKey, System.String connectionId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "KeyListenerAdded", broadcastKey, connectionId), typeof(Task));
		}

		private async ValueTask WaitForInitialized()
		{
			return (ValueTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForInitialized"), typeof(ValueTask));
		}

		public Task ReceiveSessionUpdate(SessionInfo info)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveSessionUpdate", info), typeof(Task));
		}

		public Task RemoveSession(System.String sessionId, DateTime timestamp)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveSession", sessionId, timestamp), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public HubStatusController(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public interface IHubClient : IHubDebugClient, IHubMessagingClient, IModerationClient, IHubStatusClient, IHubNetworkingClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
	}
	public interface IHubDebugClient : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Task Pong(System.Int32 index);

		Task Debug(System.String message);
	}
	public interface IHubMessagingClient : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Task ReceiveMessage(Message message);

		Task MessageSent(Message message);

		Task MessagesRead(ReadMessageBatch readBatch);
	}
	public interface IModerationClient : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Task UserPublicBanned(System.String userId);

		Task UserMuteBanned(System.String userId);

		Task UserSpectatorBanned(System.String userId);
	}
	public interface IHubStatusClient : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Task ReceiveStatusUpdate(UserStatus status);

		Task SendStatusToUser(System.String userId);

		Task ContactAddedOrUpdated(Contact contact);

		Task ReceiveSessionUpdate(SessionInfo info);

		Task RemoveSession(System.String sessionId, DateTime timestamp);

		Task KeyListenerAdded(System.String broadcastKey, System.String connectionId);
	}
	public interface IHubNetworkingClient : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Task PokeOverLNL(System.String connectionUrl, System.String address, System.Int32 port);
	}
	public interface IHubServer : ResoniteBridge.ResoniteBridgeValueHolder
	{
		Task Ping(System.Int32 index);

		Task SendMessage(Message message);

		Task MarkMessagesRead(MarkReadBatch batch);

		[Obsolete]
		Task<StatusInitializationResult> InitializeStatus();

		ResoniteBridge.ResoniteBridgeValue InitializeContacts(CancellationToken cancellationToken);

		Task ListenOnContact(System.String contactId);

		Task ListenOnKey(System.String broadcastKey);

		Task BroadcastStatus(UserStatus status, BroadcastTarget target);

		Task<bool> UpdateContact(Contact contact);

		Task RequestStatus(System.String userId = null, System.Boolean invisible = false);

		Task BroadcastSession(SessionInfo session, BroadcastTarget target);

		Task BroadcastSessionEnded(System.String sessionId, DateTime timestamp, BroadcastTarget target);

		Task ListenForLNLPokeRequests(System.String universeId, System.String connectionUrl);

		Task RequestLNLPoke(System.String universeId, System.String connectionUrl, System.String address, System.Int32 port);
	}
	public interface ISessionListingSettings : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean HasUniverse { get; }

		System.String UniverseId { get; }

		System.Boolean AcceptSession(SessionInfo sessionInfo);
	}
	public interface IUserStatusSource : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean LoadingOnlineStatus { get; }

		System.String AppVersion { get; }

		System.Boolean IsMobile { get; }

		UserSessionType SessionType { get; }

		System.Boolean IsUserPresent { get; }

		DateTime LastPresenceTimestamp { get; }

		ResoniteBridge.ResoniteBridgeValue OutputDevice { get; }

		DateTime LastSessionChangeTimestamp { get; }

		void OnlineStatusChanged(OnlineStatus status);

		void SignIn();

		Task SignOut();

		System.Boolean BeginUpdate();

		void FinishUpdate();

		System.Boolean UpdateSessions(UserStatus status, System.Boolean forceUpdate);
	}
	public class AppsManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ResoniteBridge.ResoniteBridgeValue Universe
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Universe"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Universe", value);
			}
		}

		public AppsManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public Task<CloudResult<List<SamlIdentityProvider>>> GetSamlProviders(System.String universeId)
		{
			return (Task<CloudResult<List<SamlIdentityProvider>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSamlProviders", universeId), typeof(Task<CloudResult<List<SamlIdentityProvider>>>));
		}

		public async Task Initialize(System.String universeId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", universeId), typeof(Task));
		}

		public Task<CloudResult<Universe>> GetUniverse(System.String universeId)
		{
			return (Task<CloudResult<Universe>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUniverse", universeId), typeof(Task<CloudResult<Universe>>));
		}

		private async Task UpdateCurrentUniverse(System.String universeId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUniverse", universeId), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AppsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class BadgeManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue _cachedBadges
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cachedBadges"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cachedBadges", value);
			}
		}

		public BadgeManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public async Task<CloudResult<BadgeDefinition>> GetBadge(System.String ownerId, System.String badgeId, System.Boolean allowCache = true)
		{
			return (Task<CloudResult<BadgeDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBadge", ownerId, badgeId, allowCache), typeof(Task<CloudResult<BadgeDefinition>>));
		}

		public async Task<CloudResult> UpdateBadge(BadgeDefinition badge)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBadge", badge), typeof(Task<CloudResult>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BadgeManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ContactData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<string, UserStatus> statuses
		{
			get
			{
				return (Dictionary<string, UserStatus>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "statuses"), typeof(Dictionary<string, UserStatus>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "statuses", value);
			}
		}

		public ContactManager ContactManager
		{
			get
			{
				return (ContactManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactManager"), typeof(ContactManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactManager", value);
			}
		}

		public SkyFrostInterface Cloud => ContactManager?.Cloud;

		public Contact Contact
		{
			get
			{
				return (Contact)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contact"), typeof(Contact));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Contact", value);
			}
		}

		public System.String UserId => Contact.ContactUserId;

		public UserStatus CurrentStatus
		{
			get
			{
				return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStatus"), typeof(UserStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentStatus", value);
			}
		}

		public UserStatus PreviousStatus
		{
			get
			{
				return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreviousStatus"), typeof(UserStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreviousStatus", value);
			}
		}

		public SessionInfo CurrentSessionInfo
		{
			get
			{
				return (SessionInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSessionInfo"), typeof(SessionInfo));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentSessionInfo", value);
			}
		}

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

		public ContactData(ContactManager manager, Contact contact)
		{
			ContactManager = manager;
			Contact = contact;
			CreatedOn = DateTime.UtcNow;
			CurrentStatus = GetDefaultStatus();
			PreviousStatus = GetDefaultStatus();
		}

		public UserStatus GetStatus(System.String userSessionId)
		{
			return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStatus", userSessionId), typeof(UserStatus));
		}

		public void DecodeSessions(HashSet<SessionInfo> infos, List<UserSessionMetadata> undecoded = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DecodeSessions", infos, undecoded);
		}

		internal System.Boolean UpdateStatus(UserStatus status)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStatus", status), typeof(System.Boolean));
		}

		internal System.Boolean ClearExpired()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearExpired"), typeof(System.Boolean));
		}

		private void UpdateAggregate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateAggregate");
		}

		internal System.Boolean TryMatchNewSession(SessionInfo info)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryMatchNewSession", info), typeof(System.Boolean));
		}

		internal System.Boolean TryUpdateSession(SessionInfo info)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryUpdateSession", info), typeof(System.Boolean));
		}

		internal System.Boolean TryRemoveSession(System.String sessionId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryRemoveSession", sessionId), typeof(System.Boolean));
		}

		private UserStatus GetDefaultStatus()
		{
			return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultStatus"), typeof(UserStatus));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ContactData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ContactManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.String _contactPath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_contactPath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_contactPath", value);
			}
		}

		private Dictionary<string, ContactData> contacts
		{
			get
			{
				return (Dictionary<string, ContactData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "contacts"), typeof(Dictionary<string, ContactData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "contacts", value);
			}
		}

		private List<ContactData> contactDataList
		{
			get
			{
				return (List<ContactData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "contactDataList"), typeof(List<ContactData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "contactDataList", value);
			}
		}

		private HashSet<string> sessionBroadcastKeys
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sessionBroadcastKeys"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sessionBroadcastKeys", value);
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

		private System.Int32 updateListIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "updateListIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "updateListIndex", value);
			}
		}

		public System.Int32 ContactRequestCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactRequestCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactRequestCount", value);
			}
		}

		public System.Boolean ContactListLoaded
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactListLoaded"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactListLoaded", value);
			}
		}

		public System.Int32 ContactCount => contacts.Count;

		public event Action<ContactData> ContactAdded;

		public event Action<ContactData> ContactUpdated;

		public event Action<ContactData> ContactRemoved;

		public event Action<int> ContactRequestCountChanged;

		public event Action<ContactData> ContactStatusChanged;

		public ContactManager(SkyFrostInterface cloud, System.String contactPath)
			: base(cloud)
		{
			_contactPath = contactPath;
			base.Cloud.Sessions.SessionAdded += OnSessionAdded;
			base.Cloud.Sessions.SessionUpdated += OnSessionUpdated;
			base.Cloud.Sessions.SessionRemoved += OnSessionRemoved;
		}

		private void OnSessionRemoved(SessionInfo info)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionRemoved", info);
		}

		private void OnSessionUpdated(SessionInfo info)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionUpdated", info);
		}

		private void OnSessionAdded(SessionInfo info)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionAdded", info);
		}

		public void GetContacts(List<Contact> list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts", list);
		}

		public void ForeachContact(Action<Contact> action)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForeachContact", action);
		}

		public void ForeachContactData(Action<ContactData> action)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForeachContactData", action);
		}

		public Contact GetContact(System.String contactId)
		{
			return (Contact)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContact", contactId), typeof(Contact));
		}

		public UserStatus GetContactSession(System.String contactId, System.String userSessionId)
		{
			return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContactSession", contactId, userSessionId), typeof(UserStatus));
		}

		public Contact FindContact(Predicate<Contact> predicate)
		{
			return (Contact)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindContact", predicate), typeof(Contact));
		}

		public System.Boolean IsContact(System.String userId, System.Boolean mutuallyAccepted = false)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsContact", userId, mutuallyAccepted), typeof(System.Boolean));
		}

		public System.Int32 CountPresentContacts(SessionInfo session)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CountPresentContacts", session), typeof(System.Int32));
		}

		public Task<bool> AddContact(System.String contactId, System.String contactName)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddContact", contactId, contactName), typeof(Task<bool>));
		}

		public Task<bool> AddContact(Contact contact)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddContact", contact), typeof(Task<bool>));
		}

		public Task<bool> RemoveContact(Contact contact)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveContact", contact), typeof(Task<bool>));
		}

		public Task<bool> IgnoreRequest(Contact contact)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IgnoreRequest", contact), typeof(Task<bool>));
		}

		private Task<bool> UpdateContact(Contact contact)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContact", contact), typeof(Task<bool>));
		}

		internal void LoadContact(Contact contact, ref System.Int32 requests)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LoadContact", contact, requests);
		}

		internal void FinalizeLoading(System.Int32 requests)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeLoading", requests);
		}

		internal void ContactStatusUpdated(UserStatus status)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactStatusUpdated", status);
		}

		internal void ContactAddedOrUpdated(Contact contact)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactAddedOrUpdated", contact);
		}

		internal void UpdateContactRequestCount()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContactRequestCount");
		}

		internal void Reconnecting()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reconnecting");
		}

		internal void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		internal void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task<CloudResult<List<Contact>>> GetContacts()
		{
			return (Task<CloudResult<List<Contact>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<CloudResult<List<Contact>>>));
		}

		public Task<CloudResult<List<Contact>>> GetContacts(System.String userId)
		{
			return (Task<CloudResult<List<Contact>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts", userId), typeof(Task<CloudResult<List<Contact>>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ContactManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class GroupsManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private System.Object _groupsLock
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupsLock"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupsLock", value);
			}
		}

		private Dictionary<string, Member> _groupMemberInfos
		{
			get
			{
				return (Dictionary<string, Member>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupMemberInfos"), typeof(Dictionary<string, Member>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupMemberInfos", value);
			}
		}

		private Dictionary<string, Group> _groups
		{
			get
			{
				return (Dictionary<string, Group>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groups"), typeof(Dictionary<string, Group>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groups", value);
			}
		}

		private Dictionary<string, Storage> _groupStorages
		{
			get
			{
				return (Dictionary<string, Storage>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupStorages"), typeof(Dictionary<string, Storage>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupStorages", value);
			}
		}

		private Dictionary<string, Storage> _groupMemberStorages
		{
			get
			{
				return (Dictionary<string, Storage>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupMemberStorages"), typeof(Dictionary<string, Storage>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupMemberStorages", value);
			}
		}

		private List<Membership> _groupMemberships
		{
			get
			{
				return (List<Membership>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupMemberships"), typeof(List<Membership>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupMemberships", value);
			}
		}

		public IEnumerable<Membership> CurrentUserMemberships => _groupMemberships;

		public IEnumerable<Member> CurrentUserMemberInfos => _groupMemberInfos.Select((KeyValuePair<string, Member> p) => p.Value);

		public event Action<IEnumerable<Membership>> MembershipsUpdated;

		public event Action<Group> GroupUpdated;

		public event Action<Member> GroupMemberUpdated;

		public GroupsManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public void GetCurrentGroups(List<Group> groups)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCurrentGroups", groups);
		}

		public Group TryGetCurrentUserGroupInfo(System.String groupId)
		{
			return (Group)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetCurrentUserGroupInfo", groupId), typeof(Group));
		}

		public Member TryGetCurrentUserGroupMemberInfo(System.String groupId)
		{
			return (Member)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetCurrentUserGroupMemberInfo", groupId), typeof(Member));
		}

		public Storage TryGetGroupStorage(System.String groupId)
		{
			return (Storage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetGroupStorage", groupId), typeof(Storage));
		}

		public Storage TryGetMemberStorage(System.String groupId)
		{
			return (Storage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetMemberStorage", groupId), typeof(Storage));
		}

		public System.Boolean IsCurrentUserMemberOfGroup(System.String groupId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsCurrentUserMemberOfGroup", groupId), typeof(System.Boolean));
		}

		public Membership TryGetCurrentUserGroupMembership(System.String groupId)
		{
			return (Membership)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetCurrentUserGroupMembership", groupId), typeof(Membership));
		}

		internal void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		private void SetMemberships(IEnumerable<Membership> memberships)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetMemberships", memberships);
		}

		private void ClearMemberships()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearMemberships");
		}

		private void AddMembership(Membership membership)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMembership", membership);
		}

		private async Task RunMembershipsUpdated()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunMembershipsUpdated"), typeof(Task));
		}

		public Task<CloudResult<Group>> GetGroup(System.String groupId)
		{
			return (Task<CloudResult<Group>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroup", groupId), typeof(Task<CloudResult<Group>>));
		}

		public Task<CloudResult<Group>> GetGroupCached(System.String groupId)
		{
			return (Task<CloudResult<Group>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupCached", groupId), typeof(Task<CloudResult<Group>>));
		}

		public Task<CloudResult<Group>> CreateGroup(Group group)
		{
			return (Task<CloudResult<Group>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateGroup", group), typeof(Task<CloudResult<Group>>));
		}

		public Task<CloudResult> AddGroupMember(Member member, System.Int64 quota = -1L)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddGroupMember", member, quota), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> DeleteGroupMember(Member member)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteGroupMember", member), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<Member>> GetGroupMember(System.String groupId, System.String userId)
		{
			return (Task<CloudResult<Member>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupMember", groupId, userId), typeof(Task<CloudResult<Member>>));
		}

		public Task<CloudResult<List<Member>>> GetGroupMembers(System.String groupId)
		{
			return (Task<CloudResult<List<Member>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupMembers", groupId), typeof(Task<CloudResult<List<Member>>>));
		}

		public async Task<CloudResult> UpdateCurrentUserMemberships()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserMemberships"), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<List<Membership>>> GetUserGroupMemeberships()
		{
			return (Task<CloudResult<List<Membership>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserGroupMemeberships"), typeof(Task<CloudResult<List<Membership>>>));
		}

		public Task<CloudResult<List<Membership>>> GetUserGroupMemeberships(System.String userId)
		{
			return (Task<CloudResult<List<Membership>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserGroupMemeberships", userId), typeof(Task<CloudResult<List<Membership>>>));
		}

		public async Task UpdateGroupInfo(System.String groupId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateGroupInfo", groupId), typeof(Task));
		}

		public Task<CloudResult<Submission>> UpsertSubmission(System.String groupId, System.String ownerId, System.String recordId, System.Boolean feature = false)
		{
			return (Task<CloudResult<Submission>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertSubmission", groupId, ownerId, recordId, feature), typeof(Task<CloudResult<Submission>>));
		}

		public Task<CloudResult> DeleteSubmission(System.String groupId, System.String submissionId)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteSubmission", groupId, submissionId), typeof(Task<CloudResult>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public GroupsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class MessageManager : SkyFrostModule, IHubMessagingClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private CancellationTokenSource _fetchCancellation
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_fetchCancellation"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_fetchCancellation", value);
			}
		}

		private System.Boolean _initialFetchRunning
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initialFetchRunning"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initialFetchRunning", value);
			}
		}

		private System.Object _messagesLock
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messagesLock"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messagesLock", value);
			}
		}

		private Dictionary<string, UserMessages> _messages
		{
			get
			{
				return (Dictionary<string, UserMessages>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messages"), typeof(Dictionary<string, UserMessages>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messages", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _messagesWaitingForConfirmation
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messagesWaitingForConfirmation"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messagesWaitingForConfirmation", value);
			}
		}

		private System.Boolean _unreadCountDirty
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_unreadCountDirty"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_unreadCountDirty", value);
			}
		}

		public System.Boolean SendReadNotification
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SendReadNotification"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SendReadNotification", value);
			}
		}

		public System.Boolean InitialUnreadMessagesFetched
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InitialUnreadMessagesFetched"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InitialUnreadMessagesFetched", value);
			}
		}

		public System.Int32 TotalUnreadCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalUnreadCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalUnreadCount", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue UnreadCountByUser
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnreadCountByUser"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UnreadCountByUser", value);
			}
		}

		public event Action<Message> OnMessageSent;

		public event Action<Message> OnMessageReceived;

		public event Action<Message> OnMessageRead;

		public event Action<int> UnreadMessageCountChanged;

		public MessageManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public Task ReceiveMessage(Message message)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveMessage", message), typeof(Task));
		}

		private void ProcessReceivedMessage(Message message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessReceivedMessage", message);
		}

		internal void ProcessSentMessage(Message message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessSentMessage", message);
		}

		public Task MessageSent(Message message)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MessageSent", message), typeof(Task));
		}

		public Task MessagesRead(ReadMessageBatch batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MessagesRead", batch), typeof(Task));
		}

		internal void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		private void FetchInitialMessages()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchInitialMessages");
		}

		internal void RegisterMessageWaitingForConfirmation(Message message, TaskCompletionSource<bool> completion)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterMessageWaitingForConfirmation", message, completion);
		}

		internal void UnregisterMessageWaitingForConfirmation(Message message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterMessageWaitingForConfirmation", message);
		}

		internal void MarkUnreadCountDirty()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkUnreadCountDirty");
		}

		internal void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public Task<CloudResult<Message>> StoreMessage(Message message)
		{
			return (Task<CloudResult<Message>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message), typeof(Task<CloudResult<Message>>));
		}

		public Task<CloudResult<List<Message>>> GetUnreadMessages(ResoniteBridge.ResoniteBridgeValue fromTime)
		{
			return (Task<CloudResult<List<Message>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnreadMessages", fromTime), typeof(Task<CloudResult<List<Message>>>));
		}

		public Task<CloudResult<List<Message>>> GetMessageHistory(System.String user, System.Int32 maxItems = 100)
		{
			return (Task<CloudResult<List<Message>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessageHistory", user, maxItems), typeof(Task<CloudResult<List<Message>>>));
		}

		public Task<CloudResult<List<Message>>> GetMessages(ResoniteBridge.ResoniteBridgeValue fromTime, System.Int32 maxItems, System.String user, System.Boolean unreadOnly, ResoniteBridge.ResoniteBridgeValue timeout)
		{
			return (Task<CloudResult<List<Message>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", fromTime, maxItems, user, unreadOnly, timeout), typeof(Task<CloudResult<List<Message>>>));
		}

		public UserMessages GetUserMessages(System.String userId)
		{
			return (UserMessages)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserMessages", userId), typeof(UserMessages));
		}

		public void GetAllUserMessages(List<UserMessages> list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAllUserMessages", list);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MessageManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class UserMessages : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private HashSet<string> _messageIds
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messageIds"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messageIds", value);
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

		private Task<CloudResult<List<Message>>> _historyLoadTask
		{
			get
			{
				return (Task<CloudResult<List<Message>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_historyLoadTask"), typeof(Task<CloudResult<List<Message>>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_historyLoadTask", value);
			}
		}

		private System.Boolean _historyLoaded
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_historyLoaded"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_historyLoaded", value);
			}
		}

		public static System.Int32 MAX_READ_HISTORY => 100;

		public static System.Int32 MAX_UNREAD_HISTORY => 200;

		public MessageManager Manager
		{
			get
			{
				return (MessageManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Manager"), typeof(MessageManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Manager", value);
			}
		}

		public SkyFrostInterface Cloud => Manager.Cloud;

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

		public List<Message> Messages
		{
			get
			{
				return (List<Message>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Messages"), typeof(List<Message>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Messages", value);
			}
		}

		public System.Int32 UnreadCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnreadCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UnreadCount", value);
			}
		}

		public UserMessages(System.String userId, MessageManager manager)
		{
			UserId = userId;
			Manager = manager;
		}

		public void MarkAllRead()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkAllRead");
		}

		public Message CreateTextMessage(System.String text)
		{
			return (Message)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateTextMessage", text), typeof(Message));
		}

		public Message CreateInviteMessage(SessionInfo sessionInfo)
		{
			return (Message)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateInviteMessage", sessionInfo), typeof(Message));
		}

		public Task<bool> SendInviteMessage(SessionInfo sessionInfo)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendInviteMessage", sessionInfo), typeof(Task<bool>));
		}

		public async Task<bool> SendMessage(Message message)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendMessage", message), typeof(Task<bool>));
		}

		public void RegisterSentMessage(Message message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterSentMessage", message);
		}

		public Task<bool> SendTextMessage(System.String text)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendTextMessage", text), typeof(Task<bool>));
		}

		public async Task EnsureHistory()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureHistory"), typeof(Task));
		}

		internal System.Boolean AddMessage(Message message)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMessage", message), typeof(System.Boolean));
		}

		public void GetMessages(List<Message> messages)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", messages);
		}

		public void MarkReadByRecipient(List<string> ids, DateTime readTime, List<Message> readMessages)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkReadByRecipient", ids, readTime, readMessages);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UserMessages(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class MigrationManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue _migrationTasks
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_migrationTasks"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_migrationTasks", value);
			}
		}

		private DateTime nextMigrationTaskUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nextMigrationTaskUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nextMigrationTaskUpdate", value);
			}
		}

		public IEnumerable<AccountMigrationTask> MigrationTasks
		{
			get
			{
				return (IEnumerable<AccountMigrationTask>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationTasks"), typeof(IEnumerable<AccountMigrationTask>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrationTasks", value);
			}
		}

		public MigrationManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		internal void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public AccountMigrationTask TryGetMigrationTask(System.String taskId)
		{
			return (AccountMigrationTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetMigrationTask", taskId), typeof(AccountMigrationTask));
		}

		public void UpdateMigrationTasksInSeconds(System.Single seconds)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateMigrationTasksInSeconds", seconds);
		}

		public void ForceMigrationTaskUpdate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceMigrationTaskUpdate");
		}

		private void TryScheduleMigrationTaskUpdate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryScheduleMigrationTaskUpdate");
		}

		public Task<CloudResult<AccountMigrationTask>> GetMigration(System.String migrationId)
		{
			return (Task<CloudResult<AccountMigrationTask>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMigration", migrationId), typeof(Task<CloudResult<AccountMigrationTask>>));
		}

		public Task<CloudResult<List<AccountMigrationTask>>> GetMigrations()
		{
			return (Task<CloudResult<List<AccountMigrationTask>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMigrations"), typeof(Task<CloudResult<List<AccountMigrationTask>>>));
		}

		public Task<CloudResult<List<AccountMigrationTask>>> CreateMigrationTask(MigrationInitialization init, System.Boolean migrateFavorites, System.Boolean overwriteFavorites)
		{
			return (Task<CloudResult<List<AccountMigrationTask>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateMigrationTask", init, migrateFavorites, overwriteFavorites), typeof(Task<CloudResult<List<AccountMigrationTask>>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MigrationManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class ModerationManager : SkyFrostModule, IModerationClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public event Action<string> OnUserPublicBanned;

		public event Action<string> OnUserMuted;

		public event Action<string> OnUserSpectatorBanned;

		public ModerationManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public async Task<CloudResult<bool>> IsPublicBanned(System.String id)
		{
			return (Task<CloudResult<bool>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPublicBanned", id), typeof(Task<CloudResult<bool>>));
		}

		public Task UserPublicBanned(System.String userId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserPublicBanned", userId), typeof(Task));
		}

		public Task UserMuteBanned(System.String userId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserMuteBanned", userId), typeof(Task));
		}

		public Task UserSpectatorBanned(System.String userId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserSpectatorBanned", userId), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ModerationManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class FixedNetworkNodeSource : INetworkNodeManager, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonPropertyName("nodes")]
		public List<NetworkNodeInfo> Nodes
		{
			get
			{
				return (List<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(List<NetworkNodeInfo>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Nodes", value);
			}
		}

		public event Action<INetworkNodeManager> AvailableNodesChanged;

		public FixedNetworkNodeSource(List<NetworkNodeInfo> nodes)
		{
			Nodes = nodes;
		}

		public Task ForceUpdate()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceUpdate"), typeof(Task));
		}

		public IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, ResoniteBridge.ResoniteBridgeValue preference, System.String universeId)
		{
			return (IEnumerable<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodes", type, protocolVersion, preference, universeId), typeof(IEnumerable<NetworkNodeInfo>));
		}

		public void Initialize(SkyFrostInterface SkyFrost)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", SkyFrost);
		}

		public NetworkNodeInfo TryGetNode(System.String id)
		{
			return (NetworkNodeInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNode", id), typeof(NetworkNodeInfo));
		}

		public async ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id)
		{
			return (ValueTask<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNodeWithRefetch", id), typeof(ValueTask<NetworkNodeInfo>));
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public FixedNetworkNodeSource(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	[JsonDerivedType(typeof(FixedNetworkNodeSource), "fixed")]
	[JsonDerivedType(typeof(NetworkNodeManager), "dynamic")]
	public interface INetworkNodeManager : ResoniteBridge.ResoniteBridgeValueHolder
	{
		event Action<INetworkNodeManager> AvailableNodesChanged;

		void Initialize(SkyFrostInterface SkyFrost);

		Task ForceUpdate();

		IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, ResoniteBridge.ResoniteBridgeValue preference, System.String universeId);

		NetworkNodeInfo TryGetNode(System.String id);

		ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id);

		void Update();
	}
	public delegate void LNL_PokeRequestHandler(System.String connectionUrl, System.String targetAddress, System.Int32 targetPort);
	public class NetworkNodeManager : INetworkNodeManager, IHubNetworkingClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private List<NetworkNodeInfo> _nodes
		{
			get
			{
				return (List<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_nodes"), typeof(List<NetworkNodeInfo>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_nodes", value);
			}
		}

		private DateTime _lastUpdateTime
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastUpdateTime"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastUpdateTime", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public SkyFrostInterface Cloud
		{
			get
			{
				return (SkyFrostInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Cloud", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public ApiClient Api => Cloud.Api;

		public event Action<INetworkNodeManager> AvailableNodesChanged;

		public event LNL_PokeRequestHandler OnLNLPokeRequested;

		public void Initialize(SkyFrostInterface SkyFrost)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", SkyFrost);
		}

		public IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, ResoniteBridge.ResoniteBridgeValue preference, System.String universeId)
		{
			return (IEnumerable<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodes", type, protocolVersion, preference, universeId), typeof(IEnumerable<NetworkNodeInfo>));
		}

		public NetworkNodeInfo TryGetNode(System.String id)
		{
			return (NetworkNodeInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNode", id), typeof(NetworkNodeInfo));
		}

		public async ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id)
		{
			return (ValueTask<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNodeWithRefetch", id), typeof(ValueTask<NetworkNodeInfo>));
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public async Task ForceUpdate()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceUpdate"), typeof(Task));
		}

		public Task<CloudResult<List<NetworkNodeInfo>>> GetNetworkNodes(System.String universeId = "")
		{
			return (Task<CloudResult<List<NetworkNodeInfo>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNetworkNodes", universeId), typeof(Task<CloudResult<List<NetworkNodeInfo>>>));
		}

		public Task<CloudResult> UpdateNetworkNodeInfo(NetworkNodeInfo info)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateNetworkNodeInfo", info), typeof(Task<CloudResult>));
		}

		public Task ListenForLNLPokeRequests(System.String connectionUrl)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenForLNLPokeRequests", connectionUrl), typeof(Task));
		}

		public Task RequestLNLPoke(System.String connectionUrl, System.String address, System.Int32 port)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestLNLPoke", connectionUrl, address, port), typeof(Task));
		}

		public Task PokeOverLNL(System.String connectionUrl, System.String address, System.Int32 port)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PokeOverLNL", connectionUrl, address, port), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public NetworkNodeManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public NetworkNodeManager()
		{
		}
	}
	public class ProfileManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue[] _favorites
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favorites"), typeof(ResoniteBridge.ResoniteBridgeValue[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favorites", value);
			}
		}

		private Action<ResoniteBridge.ResoniteBridgeValue>[] _favoriteListeners
		{
			get
			{
				return (Action<ResoniteBridge.ResoniteBridgeValue>[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favoriteListeners"), typeof(Action<ResoniteBridge.ResoniteBridgeValue>[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favoriteListeners", value);
			}
		}

		private CloudVariableProxy[] _favoriteProxies
		{
			get
			{
				return (CloudVariableProxy[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favoriteProxies"), typeof(CloudVariableProxy[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favoriteProxies", value);
			}
		}

		private string[] _favoriteVariablePaths
		{
			get
			{
				return (string[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favoriteVariablePaths"), typeof(string[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favoriteVariablePaths", value);
			}
		}

		public ProfileManager(SkyFrostInterface cloud)
			: base(cloud)
		{
			_favorites = new Uri[Enum.GetValues(typeof(FavoriteEntity)).Length];
			_favoriteListeners = new Action<Uri>[_favorites.Length];
			_favoriteProxies = new CloudVariableProxy[_favorites.Length];
			_favoriteVariablePaths = new string[_favorites.Length];
		}

		public ResoniteBridge.ResoniteBridgeValue GetCurrentFavorite(FavoriteEntity entity)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCurrentFavorite", entity), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public void SetFavorite(FavoriteEntity entity, ResoniteBridge.ResoniteBridgeValue url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetFavorite", entity, url);
		}

		public async Task EnsureInitialized(FavoriteEntity entity)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureInitialized", entity), typeof(Task));
		}

		public void RegisterListener(FavoriteEntity entity, Action<ResoniteBridge.ResoniteBridgeValue> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", entity, callback);
		}

		public void UnregisterListener(FavoriteEntity entity, Action<ResoniteBridge.ResoniteBridgeValue> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterListener", entity, callback);
		}

		internal async Task SignIn()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignIn"), typeof(Task));
		}

		public void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		private void OnCloudVariableChanged(CloudVariableProxy proxy)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnCloudVariableChanged", proxy);
		}

		private ResoniteBridge.ResoniteBridgeValue FilterUrl(ResoniteBridge.ResoniteBridgeValue url)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FilterUrl", url), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		private void SafeInvoke(Action<ResoniteBridge.ResoniteBridgeValue> events, ResoniteBridge.ResoniteBridgeValue arg)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SafeInvoke", events, arg);
		}

		public Task<CloudResult> UpdateProfile(UserProfile profile)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateProfile", profile), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> UpdateProfile(System.String userId, UserProfile profile)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateProfile", userId, profile), typeof(Task<CloudResult>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ProfileManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class RecordsManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue _recordBatchQueries
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_recordBatchQueries"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_recordBatchQueries", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _recordCaches
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_recordCaches"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_recordCaches", value);
			}
		}

		public Dictionary<Type, Dictionary<ResoniteBridge.ResoniteBridgeValue, CloudResult>> cachedRecords
		{
			get
			{
				return (Dictionary<Type, Dictionary<ResoniteBridge.ResoniteBridgeValue, CloudResult>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cachedRecords"), typeof(Dictionary<Type, Dictionary<ResoniteBridge.ResoniteBridgeValue, CloudResult>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cachedRecords", value);
			}
		}

		public RecordsManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public RecordBatchQuery<R> RecordBatch<R>() where R : class, IRecord, new()
		{
			return (RecordBatchQuery<R>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordBatch"), typeof(RecordBatchQuery<R>));
		}

		public RecordCache<R> RecordCache<R>() where R : class, IRecord, new()
		{
			return (RecordCache<R>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordCache"), typeof(RecordCache<R>));
		}

		public ResoniteBridge.ResoniteBridgeValue GenerateRecordUri(System.String ownerId, System.String recordId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateRecordUri", ownerId, recordId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public System.Boolean ExtractRecordID(ResoniteBridge.ResoniteBridgeValue recordUri, out System.String ownerId, out System.String recordId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractRecordID", recordUri, ownerId, recordId), typeof(System.Boolean));
		}

		public System.Boolean ExtractRecordPath(ResoniteBridge.ResoniteBridgeValue recordUri, out System.String ownerId, out System.String recordPath)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtractRecordPath", recordUri, ownerId, recordPath), typeof(System.Boolean));
		}

		public async Task<CloudResult<R>> GetRecordCached<R>(ResoniteBridge.ResoniteBridgeValue recordUri, System.String accessKey = null) where R : class, IRecord, new()
		{
			return (Task<CloudResult<R>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordCached", recordUri, accessKey), typeof(Task<CloudResult<R>>));
		}

		public Task<CloudResult<R>> GetRecord<R>(ResoniteBridge.ResoniteBridgeValue recordUri, System.String accessKey = null) where R : class, IRecord, new()
		{
			return (Task<CloudResult<R>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", recordUri, accessKey), typeof(Task<CloudResult<R>>));
		}

		public Task<CloudResult<R>> GetRecord<R>(System.String ownerId, System.String recordId, System.String accessKey = null, System.Boolean includeDeleted = false) where R : class, IRecord, new()
		{
			return (Task<CloudResult<R>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId, accessKey, includeDeleted), typeof(Task<CloudResult<R>>));
		}

		public Task<CloudResult<R>> GetRecordAtPath<R>(System.String ownerId, System.String path, System.String accessKey = null) where R : class, IRecord, new()
		{
			return (Task<CloudResult<R>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAtPath", ownerId, path, accessKey), typeof(Task<CloudResult<R>>));
		}

		public Task<CloudResult<List<R>>> GetRecords<R>(List<RecordId> ids) where R : class, IRecord, new()
		{
			return (Task<CloudResult<List<R>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ids), typeof(Task<CloudResult<List<R>>>));
		}

		public Task<CloudResult<List<R>>> GetRecords<R>(System.String ownerId, System.String tag = null, System.String path = null) where R : class, IRecord, new()
		{
			return (Task<CloudResult<List<R>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, tag, path), typeof(Task<CloudResult<List<R>>>));
		}

		public async ResoniteBridge.ResoniteBridgeValue GetRecordsInHierarchy<R>(System.String ownerId, System.String path) where R : class, IRecord, new()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordsInHierarchy", ownerId, path), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public Task<CloudResult<SearchResults<R>>> FindRecords<R>(SearchParameters search, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true) where R : class, IRecord, new()
		{
			return (Task<CloudResult<SearchResults<R>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindRecords", search, timeout, throwOnError), typeof(Task<CloudResult<SearchResults<R>>>));
		}

		public Task<CloudResult<CloudMessage>> UpsertRecord<R>(R record, System.Boolean ensureFolder = true) where R : class, IRecord, new()
		{
			return (Task<CloudResult<CloudMessage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertRecord", record, ensureFolder), typeof(Task<CloudResult<CloudMessage>>));
		}

		public Task<CloudResult<RecordPreprocessStatus>> PreprocessRecord<R>(R record) where R : class, IRecord, new()
		{
			return (Task<CloudResult<RecordPreprocessStatus>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PreprocessRecord", record), typeof(Task<CloudResult<RecordPreprocessStatus>>));
		}

		public Task<CloudResult<RecordPreprocessStatus>> GetPreprocessStatus(RecordPreprocessStatus status)
		{
			return (Task<CloudResult<RecordPreprocessStatus>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPreprocessStatus", status), typeof(Task<CloudResult<RecordPreprocessStatus>>));
		}

		public Task<CloudResult<RecordPreprocessStatus>> GetPreprocessStatus(System.String ownerId, System.String recordId, System.String id)
		{
			return (Task<CloudResult<RecordPreprocessStatus>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPreprocessStatus", ownerId, recordId, id), typeof(Task<CloudResult<RecordPreprocessStatus>>));
		}

		public Task<CloudResult> DeleteRecord(IRecord record)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecord", record), typeof(Task<CloudResult>));
		}

		public async Task<CloudResult> DeleteRecord(System.String ownerId, System.String recordId)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecord", ownerId, recordId), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> AddTag(System.String ownerId, System.String recordId, System.String tag)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddTag", ownerId, recordId, tag), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<List<RecordAuditInfo>>> GetRecordAuditLog(System.String ownerId, ResoniteBridge.ResoniteBridgeValue from, ResoniteBridge.ResoniteBridgeValue to)
		{
			return (Task<CloudResult<List<RecordAuditInfo>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId, from, to), typeof(Task<CloudResult<List<RecordAuditInfo>>>));
		}

		public ResoniteBridge.ResoniteBridgeValue EnumerateRecordAuditLog()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnumerateRecordAuditLog"), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public async ResoniteBridge.ResoniteBridgeValue EnumerateRecordAuditLog(System.String ownerId)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnumerateRecordAuditLog", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct CryptoData : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ResoniteBridge.ResoniteBridgeValue provider
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "provider"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "provider", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue parameters
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "parameters"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "parameters", value);
			}
		}

		public CryptoData(ResoniteBridge.ResoniteBridgeValue provider, ResoniteBridge.ResoniteBridgeValue parameters)
		{
			this.provider = provider;
			this.parameters = parameters;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CryptoData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SecurityManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue _cryptoProvider
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cryptoProvider"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cryptoProvider", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue PublicKey
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicKey"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicKey", value);
			}
		}

		public SecurityManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		internal void ActivateSession(CryptoData cryptoData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ActivateSession", cryptoData);
		}

		internal void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public static Task<CryptoData> GenerateCryptoData()
		{
			return (Task<CryptoData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SecurityManager", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateCryptoData"), typeof(Task<CryptoData>));
		}

		public byte[] SignHash(byte[] hash)
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignHash", hash), typeof(byte[]));
		}

		public Task<CloudResult<OneTimeVerificationKey>> CreateKey(System.String baseId, VerificationKeyUse use, System.Int32 expirationSeconds = 0)
		{
			return (Task<CloudResult<OneTimeVerificationKey>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateKey", baseId, use, expirationSeconds), typeof(Task<CloudResult<OneTimeVerificationKey>>));
		}

		public async Task<CloudResult<bool>> CheckContact(CheckContactData data)
		{
			return (Task<CloudResult<bool>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CheckContact", data), typeof(Task<CloudResult<bool>>));
		}

		public Task<CloudResult<TOTP_Key>> InitializeTOTP()
		{
			return (Task<CloudResult<TOTP_Key>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeTOTP"), typeof(Task<CloudResult<TOTP_Key>>));
		}

		public Task<CloudResult> ActivateTOTP(System.String code)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ActivateTOTP", code), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> DeactivateTOTP(System.String code)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeactivateTOTP", code), typeof(Task<CloudResult>));
		}

		public async ValueTask EnsureIPAllowed()
		{
			return (ValueTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureIPAllowed"), typeof(ValueTask));
		}

		public Task<CloudResult> TemporarilyAllowIP()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TemporarilyAllowIP"), typeof(Task<CloudResult>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SecurityManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SessionManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static TimeSpan SESSION_EXTEND_INTERVAL
		{
			get
			{
				return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), "SESSION_EXTEND_INTERVAL"), typeof(TimeSpan));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), "SESSION_EXTEND_INTERVAL", value);
			}
		}

		public static TimeSpan TOKEN_UPDATE_INTERVAL
		{
			get
			{
				return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), "TOKEN_UPDATE_INTERVAL"), typeof(TimeSpan));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), "TOKEN_UPDATE_INTERVAL", value);
			}
		}

		private DateTime _lastSessionUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastSessionUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastSessionUpdate", value);
			}
		}

		private DateTime _lastTokenRefresh
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastTokenRefresh"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastTokenRefresh", value);
			}
		}

		private System.Boolean _updateCurrentUserInfo
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_updateCurrentUserInfo"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_updateCurrentUserInfo", value);
			}
		}

		private System.String _saml2Endpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_saml2Endpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_saml2Endpoint", value);
			}
		}

		private System.Boolean _useLegacyLogin
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_useLegacyLogin"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_useLegacyLogin", value);
			}
		}

		private UserSession _currentSession
		{
			get
			{
				return (UserSession)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentSession"), typeof(UserSession));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentSession", value);
			}
		}

		private User _currentUser
		{
			get
			{
				return (User)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentUser"), typeof(User));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentUser", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _currentAuthenticationHeader
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentAuthenticationHeader"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentAuthenticationHeader", value);
			}
		}

		private System.Object _sessionLock
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionLock"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionLock", value);
			}
		}

		public DateTime InitialSessionActivationTime
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InitialSessionActivationTime"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InitialSessionActivationTime", value);
			}
		}

		public new User CurrentUser
		{
			get
			{
				return (User)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentUser", value);
			}
		}

		public UserSession CurrentSession
		{
			get
			{
				return (UserSession)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSession"), typeof(UserSession));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentSession", value);
			}
		}

		internal ResoniteBridge.ResoniteBridgeValue AuthenticationHeader => _currentAuthenticationHeader;

		public event Action<UserSession> SessionChanged;

		public event Action<User> UserUpdated;

		public event Action<List<Task>> OnFinalizeSession;

		public SessionManager(SkyFrostInterface cloud, System.String saml2Endpoint, System.Boolean useLegacyLogin)
			: base(cloud)
		{
			_saml2Endpoint = saml2Endpoint;
			_useLegacyLogin = useLegacyLogin;
		}

		public void ScheduleUpdateCurrentUserInfo()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleUpdateCurrentUserInfo");
		}

		public async Task<CloudResult<User>> UpdateCurrentUserInfo()
		{
			return (Task<CloudResult<User>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserInfo"), typeof(Task<CloudResult<User>>));
		}

		public async Task<CloudResult<UserSessionResult<UserSession>>> Login(System.String credential, LoginAuthentication authentication, System.String secretMachineId, System.Boolean rememberMe, System.String totp)
		{
			return (Task<CloudResult<UserSessionResult<UserSession>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Login", credential, authentication, secretMachineId, rememberMe, totp), typeof(Task<CloudResult<UserSessionResult<UserSession>>>));
		}

		private Dictionary<string, object> GenerateLegacyLogin(System.String credential, System.String password, System.String secretMachineId, System.Boolean rememberMe = false, System.String totp = null)
		{
			return (Dictionary<string, object>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateLegacyLogin", credential, password, secretMachineId, rememberMe, totp), typeof(Dictionary<string, object>));
		}

		public async Task ActivateSession(UserSession session, CryptoData cryptoData)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ActivateSession", session, cryptoData), typeof(Task));
		}

		public async Task FinalizeSession()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeSession"), typeof(Task));
		}

		public async Task Logout(System.Boolean isManual)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Logout", isManual), typeof(Task));
		}

		internal void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task<CloudResult> LogoutAll(System.Boolean keepCurrent, System.String secretMachineId)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogoutAll", keepCurrent, secretMachineId), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<UserSession>> GetExternalLogin(System.String key)
		{
			return (Task<CloudResult<UserSession>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExternalLogin", key), typeof(Task<CloudResult<UserSession>>));
		}

		public Task<CloudResult> DeleteExternalLogin(System.String key)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteExternalLogin", key), typeof(Task<CloudResult>));
		}

		public async Task<CloudResult> ExtendSession(System.Boolean updateToken = true, System.String secretMachineId = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtendSession", updateToken, secretMachineId), typeof(Task<CloudResult>));
		}

		public async Task<bool> LoginSaml2(System.String samlEntityId, System.String secretMachineId, CancellationToken cancellationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LoginSaml2", samlEntityId, secretMachineId, cancellationToken), typeof(Task<bool>));
		}

		private async Task LogoutSaml2(UserSession session)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogoutSaml2", session), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SessionManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public delegate void SessionsChangedHandler(System.Boolean sessionsAddedOrRemoved);
	public class SessionsManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private struct SessionInfoData : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public SessionInfo info
			{
				get
				{
					return (SessionInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "info"), typeof(SessionInfo));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "info", value);
				}
			}

			public DateTime lastExternalUpdate
			{
				get
				{
					return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "lastExternalUpdate"), typeof(DateTime));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "lastExternalUpdate", value);
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

			public SessionInfoData(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public SessionInfoData()
			{
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

		private Dictionary<string, SessionInfoData> sessions
		{
			get
			{
				return (Dictionary<string, SessionInfoData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sessions"), typeof(Dictionary<string, SessionInfoData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sessions", value);
			}
		}

		private System.Boolean _sessionsChanged
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionsChanged"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionsChanged", value);
			}
		}

		private System.Boolean _sessionsAddedOrRemoved
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionsAddedOrRemoved"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionsAddedOrRemoved", value);
			}
		}

		private System.Boolean _initialPublicSessionsFetched
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initialPublicSessionsFetched"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initialPublicSessionsFetched", value);
			}
		}

		private System.Boolean _forceFetchRequested
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_forceFetchRequested"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_forceFetchRequested", value);
			}
		}

		private Task _initialPublicSessionFetchTask
		{
			get
			{
				return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initialPublicSessionFetchTask"), typeof(Task));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initialPublicSessionFetchTask", value);
			}
		}

		private Dictionary<string, DateTime> _removedPublicSessions
		{
			get
			{
				return (Dictionary<string, DateTime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_removedPublicSessions"), typeof(Dictionary<string, DateTime>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_removedPublicSessions", value);
			}
		}

		private DateTime lastCleanup
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "lastCleanup"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "lastCleanup", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _sessionIdListeners
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionIdListeners"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionIdListeners", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _worldIdListeners
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_worldIdListeners"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_worldIdListeners", value);
			}
		}

		private System.Boolean ShouldDoFullFetch
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShouldDoFullFetch"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ShouldDoFullFetch", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue ListingSettings
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListingSettings"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ListingSettings", value);
			}
		}

		public event Action<SessionInfo> SessionAdded;

		public event Action<SessionInfo> SessionUpdated;

		public event Action<SessionInfo> SessionRemoved;

		public event SessionsChangedHandler SessionsChanged;

		public SessionsManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public void ForceFetch()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceFetch");
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public SessionInfo TryGetInfo(System.String sessionId)
		{
			return (SessionInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetInfo", sessionId), typeof(SessionInfo));
		}

		public void GetSessions(List<SessionInfo> list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessions", list);
		}

		public void GetNestedSessions(System.String sessionId, List<SessionInfo> nestedSessions)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNestedSessions", sessionId, nestedSessions);
		}

		public void GetSessionsForWorldId(RecordId id, List<SessionInfo> infos)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionsForWorldId", id, infos);
		}

		public SessionInfo MatchSessionInfo(UserStatus status, UserSessionMetadata metadata)
		{
			return (SessionInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MatchSessionInfo", status, metadata), typeof(SessionInfo));
		}

		public void CreateSessionMap(UserStatus status, Dictionary<string, SessionInfo> map)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateSessionMap", status, map);
		}

		private void RunSessionUpdated(SessionInfo info, System.String normalizedSessionId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunSessionUpdated", info, normalizedSessionId);
		}

		public void UpdateSessionInfo(SessionInfo info, System.Boolean localUpdate = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateSessionInfo", info, localUpdate);
		}

		private System.Boolean ShouldRemoveSession(SessionInfoData data)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ShouldRemoveSession", data), typeof(System.Boolean));
		}

		public void RemoveSession(System.String sessionId, DateTime timestamp, System.Boolean isLocalRemoval = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveSession", sessionId, timestamp, isLocalRemoval);
		}

		public void RegisterSessionIdChanges(System.String sessionId, Action<SessionInfo> callback, System.Boolean callImmediatelly = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterSessionIdChanges", sessionId, callback, callImmediatelly);
		}

		public void UnregisterSessionIdChanges(System.String sessionId, Action<SessionInfo> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterSessionIdChanges", sessionId, callback);
		}

		public void RegisterWorldIdChanges(RecordId worldId, Action<IReadOnlyList<SessionInfo>> callback, System.Boolean callImmediatelly = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterWorldIdChanges", worldId, callback, callImmediatelly);
		}

		public void UnregisterWorldIdChanges(RecordId worldId, Action<IReadOnlyList<SessionInfo>> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterWorldIdChanges", worldId, callback);
		}

		public Task<CloudResult> UpdateSessions(SessionUpdate update)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateSessions", update), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<SessionInfo>> GetSession(System.String sessionId)
		{
			return (Task<CloudResult<SessionInfo>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSession", sessionId), typeof(Task<CloudResult<SessionInfo>>));
		}

		public Task<CloudResult<List<SessionInfo>>> GetSessions(System.String name = null, System.String universeId = null, System.String hostName = null, System.String hostId = null, System.Int32 minActiveUsers = null, System.Boolean includeEmptyHeadless = true)
		{
			return (Task<CloudResult<List<SessionInfo>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessions", name, universeId, hostName, hostId, minActiveUsers, includeEmptyHeadless), typeof(Task<CloudResult<List<SessionInfo>>>));
		}

		public Task<CloudResult> UpdateSessionMetadata(CloudSessionMetadata metadata)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateSessionMetadata", metadata), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<List<string>>> GetSessionURLs(System.String sessionId)
		{
			return (Task<CloudResult<List<string>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionURLs", sessionId), typeof(Task<CloudResult<List<string>>>));
		}

		public System.String PrintoutSessions()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintoutSessions"), typeof(System.String));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SessionsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class DefaultSessionListingSettings : ISessionListingSettings, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean HasUniverse => false;

		public System.String UniverseId => null;

		public System.Boolean AcceptSession(SessionInfo sessionInfo)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AcceptSession", sessionInfo), typeof(System.Boolean));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public DefaultSessionListingSettings(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public DefaultSessionListingSettings()
		{
		}
	}
	public class StatisticsManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private Dictionary<CreditType, List<CreditUser>> _userCredits
		{
			get
			{
				return (Dictionary<CreditType, List<CreditUser>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_userCredits"), typeof(Dictionary<CreditType, List<CreditUser>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_userCredits", value);
			}
		}

		private DateTime _lastServerStatsUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastServerStatsUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastServerStatsUpdate", value);
			}
		}

		private DateTime _lastOnlineStatsUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastOnlineStatsUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastOnlineStatsUpdate", value);
			}
		}

		public System.String ServerStatusEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerStatusEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ServerStatusEndpoint", value);
			}
		}

		public ServerStatus ServerStatus
		{
			get
			{
				return (ServerStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerStatus"), typeof(ServerStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ServerStatus", value);
			}
		}

		public OnlineStats OnlineStats
		{
			get
			{
				return (OnlineStats)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlineStats"), typeof(OnlineStats));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlineStats", value);
			}
		}

		public System.Int64 ServerResponseTime
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerResponseTime"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ServerResponseTime", value);
			}
		}

		public DateTime LastServerUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastServerUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastServerUpdate", value);
			}
		}

		public DateTime LastServerStateFetch
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastServerStateFetch"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastServerStateFetch", value);
			}
		}

		public DateTime LastLocalServerResponse
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastLocalServerResponse"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastLocalServerResponse", value);
			}
		}

		public StatisticsManager(SkyFrostInterface cloud, System.String serverStatusEndpoint)
			: base(cloud)
		{
			ServerStatusEndpoint = serverStatusEndpoint;
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task<CloudResult> HealthCheck()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HealthCheck"), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> Ping()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Ping"), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> NotifyOnlineInstance(System.String machineId)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NotifyOnlineInstance", machineId), typeof(Task<CloudResult>));
		}

		public async Task<CloudResult<ServerStatistics>> GetServerStatistics()
		{
			return (Task<CloudResult<ServerStatistics>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetServerStatistics"), typeof(Task<CloudResult<ServerStatistics>>));
		}

		public async Task<OnlineStats> GetOnlineStats()
		{
			return (Task<OnlineStats>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOnlineStats"), typeof(Task<OnlineStats>));
		}

		public async Task<CloudStats> GetCloudStats()
		{
			return (Task<CloudStats>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCloudStats"), typeof(Task<CloudStats>));
		}

		public async Task<CloudResult<List<CreditUser>>> GetUserCredits(CreditType type)
		{
			return (Task<CloudResult<List<CreditUser>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCredits", type), typeof(Task<CloudResult<List<CreditUser>>>));
		}

		public async Task<List<CreditUser>> GetUserCreditsCached(CreditType type)
		{
			return (Task<List<CreditUser>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCreditsCached", type), typeof(Task<List<CreditUser>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StatisticsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class StorageManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static float[] storageUpdateDelays
		{
			get
			{
				return (float[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "StorageManager", ResoniteBridge.ResoniteBridgeValueType.Type), "storageUpdateDelays"), typeof(float[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "StorageManager", ResoniteBridge.ResoniteBridgeValueType.Type), "storageUpdateDelays", value);
			}
		}

		private System.Boolean _updateCurrentUserStorage
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_updateCurrentUserStorage"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_updateCurrentUserStorage", value);
			}
		}

		private Storage _currentUserStorage
		{
			get
			{
				return (Storage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentUserStorage"), typeof(Storage));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentUserStorage", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _storageDirty
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_storageDirty"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_storageDirty", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _updatingStorage
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_updatingStorage"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_updatingStorage", value);
			}
		}

		public System.Int64 CurrentStorageQuota => CurrentStorage?.QuotaBytes;

		public System.Int64 CurrentStorageUsed => CurrentStorage?.UsedBytes;

		public System.Int64 CurrentStorageFree => CurrentStorageQuota - CurrentStorageUsed;

		public Storage CurrentStorage
		{
			get
			{
				return (Storage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorage"), typeof(Storage));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentStorage", value);
			}
		}

		public event Action<Storage> StorageUpdated;

		public StorageManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public void ScheduleUpdateCurrentUserStorage()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleUpdateCurrentUserStorage");
		}

		public void MarkUserStorageDirty()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkUserStorageDirty");
		}

		public void MarkStorageDirty(System.String ownerId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkStorageDirty", ownerId);
		}

		public async Task<CloudResult<Storage>> UpdateCurrentUserStorage()
		{
			return (Task<CloudResult<Storage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserStorage"), typeof(Task<CloudResult<Storage>>));
		}

		public async Task UpdateStorage(System.String ownerId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStorage", ownerId), typeof(Task));
		}

		internal void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		internal void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public Task<CloudResult<Storage>> GetStorage(System.String ownerId)
		{
			return (Task<CloudResult<Storage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStorage", ownerId), typeof(Task<CloudResult<Storage>>));
		}

		public Task<CloudResult<Storage>> GetMemberStorage(System.String ownerId, System.String userId)
		{
			return (Task<CloudResult<Storage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMemberStorage", ownerId, userId), typeof(Task<CloudResult<Storage>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public StorageManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class UsersManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public UsersManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public Task<CloudResult<User>> GetUser(System.String userId, System.String banAccessKey = null)
		{
			return (Task<CloudResult<User>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser", userId, banAccessKey), typeof(Task<CloudResult<User>>));
		}

		public Task<CloudResult<User>> GetUserByName(System.String username)
		{
			return (Task<CloudResult<User>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserByName", username), typeof(Task<CloudResult<User>>));
		}

		public Task<CloudResult<User>> GetUserByNameLegacy(System.String username)
		{
			return (Task<CloudResult<User>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserByNameLegacy", username), typeof(Task<CloudResult<User>>));
		}

		public Task<CloudResult<List<User>>> GetUsers(System.String searchName)
		{
			return (Task<CloudResult<List<User>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsers", searchName), typeof(Task<CloudResult<List<User>>>));
		}

		public Task<CloudResult<RSAParametersData>> GetPublicKey(System.String userId, System.String userSessionId)
		{
			return (Task<CloudResult<RSAParametersData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPublicKey", userId, userSessionId), typeof(Task<CloudResult<RSAParametersData>>));
		}

		public Task<CloudResult> UpdatePublicKey(System.String userId, System.String userSessionId, RSAParametersData key)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdatePublicKey", userId, userSessionId, key), typeof(Task<CloudResult>));
		}

		public async Task<CloudResult<User>> GetUserCached(System.String userId)
		{
			return (Task<CloudResult<User>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCached", userId), typeof(Task<CloudResult<User>>));
		}

		public Task<CloudResult> RequestAccountDeletion(LoginCredentials credentials, System.String totp)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestAccountDeletion", credentials, totp), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> CancelAccountDeletion(LoginCredentials credentials, System.String totp)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CancelAccountDeletion", credentials, totp), typeof(Task<CloudResult>));
		}

		public async Task<CloudResult<UserSessionResult<User>>> Register(System.String username, System.String email, System.String password, DateTimeOffset dateOfBirth, System.String migrationCredential = null, System.String migrationPassword = null, System.String migrationTotp = null, System.Boolean resetUserId = false)
		{
			return (Task<CloudResult<UserSessionResult<User>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Register", username, email, password, dateOfBirth, migrationCredential, migrationPassword, migrationTotp, resetUserId), typeof(Task<CloudResult<UserSessionResult<User>>>));
		}

		public Task<CloudResult> RequestRecoveryCode(System.String email)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestRecoveryCode", email), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<List<PatreonFundingEvent>>> GetPatreonFundingEvents()
		{
			return (Task<CloudResult<List<PatreonFundingEvent>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<CloudResult<List<PatreonFundingEvent>>>));
		}

		public Task<CloudResult<List<ExitMessage>>> GetExitMessages()
		{
			return (Task<CloudResult<List<ExitMessage>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExitMessages"), typeof(Task<CloudResult<List<ExitMessage>>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UsersManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class UserStatusManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean QuietMode
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "QuietMode"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "QuietMode", value);
			}
		}

		public System.Single AwayActivateSeconds
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AwayActivateSeconds"), typeof(System.Single));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AwayActivateSeconds", value);
			}
		}

		private OnlineStatus _onlineStatus
		{
			get
			{
				return (OnlineStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_onlineStatus"), typeof(OnlineStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_onlineStatus", value);
			}
		}

		private UserStatus status
		{
			get
			{
				return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "status"), typeof(UserStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "status", value);
			}
		}

		private DateTime lastSessionChangeTimestamp
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "lastSessionChangeTimestamp"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "lastSessionChangeTimestamp", value);
			}
		}

		private DateTime lastPublicKeyUpdateTimestamp
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "lastPublicKeyUpdateTimestamp"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "lastPublicKeyUpdateTimestamp", value);
			}
		}

		private CancellationTokenSource publicKeyCancellationToken
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "publicKeyCancellationToken"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "publicKeyCancellationToken", value);
			}
		}

		private System.Boolean _forceUpdate
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_forceUpdate"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_forceUpdate", value);
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

		public System.Boolean ForceInvisible
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceInvisible"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForceInvisible", value);
			}
		}

		public IUserStatusSource StatusSource
		{
			get
			{
				return (IUserStatusSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StatusSource"), typeof(IUserStatusSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StatusSource", value);
			}
		}

		public System.String UserSessionId => status?.UserSessionId;

		public System.Boolean LoadingOnlineStatus => StatusSource?.LoadingOnlineStatus ?? false;

		public OnlineStatus OnlineStatus
		{
			get
			{
				return (OnlineStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlineStatus"), typeof(OnlineStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlineStatus", value);
			}
		}

		public System.Boolean IsPresent
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPresent"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPresent", value);
			}
		}

		public System.Boolean IsAutoAway
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAutoAway"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAutoAway", value);
			}
		}

		public UserStatusManager(SkyFrostInterface cloud)
			: base(cloud)
		{
			InitializeNewStatus();
		}

		internal void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		internal void ForceUpdate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceUpdate");
		}

		private void UpdatePublicKey()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdatePublicKey");
		}

		private void UpdateStatus()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStatus");
		}

		private void DoUpdate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoUpdate");
		}

		internal void SignIn()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignIn");
		}

		internal void SendStatusToUser(System.String userId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendStatusToUser", userId);
		}

		internal async Task SignOut()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task));
		}

		private void SetStatusToOffline()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetStatusToOffline");
		}

		private void InitializeNewStatus()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeNewStatus");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public UserStatusManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class VisitsManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public VisitsManager(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		public Task<CloudResult> LogVisit(Visit visit)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogVisit", visit), typeof(Task<CloudResult>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public VisitsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class AccountMigrationConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "migrateUserProfile")]
		[JsonPropertyName("migrateUserProfile")]
		public System.Boolean MigrateUserProfile
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateUserProfile"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateUserProfile", value);
			}
		}

		[JsonProperty(PropertyName = "migrateFundingEvents")]
		[JsonPropertyName("migrateFundingEvents")]
		public System.Boolean MigrateFundingEvents
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateFundingEvents"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateFundingEvents", value);
			}
		}

		[JsonProperty(PropertyName = "migrateExitMessages")]
		[JsonPropertyName("migrateExitMessages")]
		public System.Boolean MigrateExitMessages
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateExitMessages"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateExitMessages", value);
			}
		}

		[JsonProperty(PropertyName = "migrateContacts")]
		[JsonPropertyName("migrateContacts")]
		public System.Boolean MigrateContacts
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateContacts"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateContacts", value);
			}
		}

		[JsonProperty(PropertyName = "migrateMessageHistory")]
		[JsonPropertyName("migrateMessageHistory")]
		public System.Boolean MigrateMessageHistory
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateMessageHistory"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateMessageHistory", value);
			}
		}

		[JsonProperty(PropertyName = "migrateCloudVariables")]
		[JsonPropertyName("migrateCloudVariables")]
		public System.Boolean MigrateCloudVariables
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateCloudVariables"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateCloudVariables", value);
			}
		}

		[JsonProperty(PropertyName = "migrateCloudVariableDefinitions")]
		[JsonPropertyName("migrateCloudVariableDefinitions")]
		public System.Boolean MigrateCloudVariableDefinitions
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateCloudVariableDefinitions"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateCloudVariableDefinitions", value);
			}
		}

		[JsonProperty(PropertyName = "migrateUserRecords")]
		[JsonPropertyName("migrateUserRecords")]
		public System.Boolean MigrateUserRecords
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateUserRecords"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateUserRecords", value);
			}
		}

		[JsonProperty(PropertyName = "migrateRecordAuditLog")]
		[JsonPropertyName("migrateRecordAuditLog")]
		public System.Boolean MigrateRecordAuditLog
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateRecordAuditLog"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateRecordAuditLog", value);
			}
		}

		[JsonProperty(PropertyName = "preserveOldHome")]
		[JsonPropertyName("preserveOldHome")]
		public System.Boolean PreserveOldHome
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreserveOldHome"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreserveOldHome", value);
			}
		}

		[JsonProperty(PropertyName = "recordsToMigrate")]
		[JsonPropertyName("recordsToMigrate")]
		public List<string> RecordsToMigrate
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordsToMigrate"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordsToMigrate", value);
			}
		}

		[JsonProperty(PropertyName = "variablesToMigrate")]
		[JsonPropertyName("variablesToMigrate")]
		public List<string> VariablesToMigrate
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariablesToMigrate"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariablesToMigrate", value);
			}
		}

		[JsonProperty(PropertyName = "onlyNewRecords")]
		[JsonPropertyName("onlyNewRecords")]
		public System.Boolean OnlyNewRecords
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyNewRecords"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlyNewRecords", value);
			}
		}

		[JsonProperty(PropertyName = "forceOverwrite")]
		[JsonPropertyName("forceOverwrite")]
		public System.Boolean ForceOverwrite
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceOverwrite"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForceOverwrite", value);
			}
		}

		[JsonProperty(PropertyName = "migrateGroups")]
		[JsonPropertyName("migrateGroups")]
		public System.Boolean MigrateGroups
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateGroups"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateGroups", value);
			}
		}

		[JsonProperty(PropertyName = "groupsToMigrate")]
		[JsonPropertyName("groupsToMigrate")]
		public HashSet<string> GroupsToMigrate
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupsToMigrate"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupsToMigrate", value);
			}
		}

		public System.Boolean IsMigratingSomething
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigratingSomething"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMigratingSomething", value);
			}
		}

		public void ClearAll()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearAll");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AccountMigrationConfig(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AccountMigrationConfig()
		{
		}
	}
	public class AccountMigrationStatus : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue _lastSnapshot
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastSnapshot"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastSnapshot", value);
			}
		}

		private System.Int32 _lastMigratedRecords
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastMigratedRecords"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastMigratedRecords", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public ResoniteBridge.ResoniteBridgeValue TotalTime => CompletedOn - StartedOn;

		[JsonProperty(PropertyName = "phase")]
		[JsonPropertyName("phase")]
		public System.String Phase
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Phase"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Phase", value);
			}
		}

		[JsonProperty(PropertyName = "startedOn")]
		[JsonPropertyName("startedOn")]
		public ResoniteBridge.ResoniteBridgeValue StartedOn
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StartedOn"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StartedOn", value);
			}
		}

		[JsonProperty(PropertyName = "completedOn")]
		[JsonPropertyName("completedOn")]
		public ResoniteBridge.ResoniteBridgeValue CompletedOn
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CompletedOn"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CompletedOn", value);
			}
		}

		[JsonProperty(PropertyName = "userRecordsStatus")]
		[JsonPropertyName("userRecordsStatus")]
		public RecordMigrationStatus UserRecordsStatus
		{
			get
			{
				return (RecordMigrationStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserRecordsStatus"), typeof(RecordMigrationStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserRecordsStatus", value);
			}
		}

		[JsonProperty(PropertyName = "userVariablesStatus")]
		[JsonPropertyName("userVariablesStatus")]
		public VariableMigrationStatus UserVariablesStatus
		{
			get
			{
				return (VariableMigrationStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserVariablesStatus"), typeof(VariableMigrationStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserVariablesStatus", value);
			}
		}

		[JsonProperty(PropertyName = "recordsPerMinute")]
		[JsonPropertyName("recordsPerMinute")]
		public System.Double RecordsPerMinute
		{
			get
			{
				return (System.Double)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordsPerMinute"), typeof(System.Double));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordsPerMinute", value);
			}
		}

		[JsonProperty(PropertyName = "currentlyMigratingName")]
		[JsonPropertyName("currentlyMigratingName")]
		public System.String CurrentlyMigratingName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentlyMigratingName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentlyMigratingName", value);
			}
		}

		[JsonProperty(PropertyName = "currentlyMigratingItem")]
		[JsonPropertyName("currentlyMigratingItem")]
		public System.String CurrentlyMigratingItem
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentlyMigratingItem"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentlyMigratingItem", value);
			}
		}

		[JsonProperty(PropertyName = "totalContactCount")]
		[JsonPropertyName("totalContactCount")]
		public System.Int32 TotalContactCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalContactCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalContactCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedContactCount")]
		[JsonPropertyName("migratedContactCount")]
		public System.Int32 MigratedContactCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedContactCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedContactCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedMessageCount")]
		[JsonPropertyName("migratedMessageCount")]
		public System.Int32 MigratedMessageCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedMessageCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedMessageCount", value);
			}
		}

		[JsonProperty(PropertyName = "totalGroupCount")]
		[JsonPropertyName("totalGroupCount")]
		public System.Int32 TotalGroupCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalGroupCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalGroupCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedGroupCount")]
		[JsonPropertyName("migratedGroupCount")]
		public System.Int32 MigratedGroupCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedGroupCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedGroupCount", value);
			}
		}

		[JsonProperty(PropertyName = "missingAssets")]
		[JsonPropertyName("missingAssets")]
		public HashSet<string> MissingAssets
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MissingAssets"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MissingAssets", value);
			}
		}

		[JsonProperty(PropertyName = "error")]
		[JsonPropertyName("error")]
		public System.String Error
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Error"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Error", value);
			}
		}

		[JsonProperty(PropertyName = "messagesFailed")]
		[JsonPropertyName("messagesFailed")]
		public System.Boolean MessagesFailed
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessagesFailed"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MessagesFailed", value);
			}
		}

		[JsonProperty(PropertyName = "abort")]
		[JsonPropertyName("abort")]
		public System.Boolean Abort
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Abort"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Abort", value);
			}
		}

		[JsonProperty(PropertyName = "groupStatuses")]
		[JsonPropertyName("groupStatuses")]
		public List<GroupMigrationStatus> GroupStatuses
		{
			get
			{
				return (List<GroupMigrationStatus>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupStatuses"), typeof(List<GroupMigrationStatus>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupStatuses", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalMigratedMemberCount => GroupStatuses?.Sum((GroupMigrationStatus g) => g.MigratedMemberCount) ?? 0;

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalMigratedVariableCount => (UserVariablesStatus.MigratedVariableCount + GroupStatuses?.Sum((GroupMigrationStatus g) => g.VariablesStatus.MigratedVariableCount)).GetValueOrDefault();

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalMigratedVariableDefinitionCount => (UserVariablesStatus.MigratedVariableDefinitionCount + GroupStatuses?.Sum((GroupMigrationStatus g) => g.VariablesStatus.MigratedVariableDefinitionCount)).GetValueOrDefault();

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalRecordCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalRecordCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalProcessedRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalProcessedRecordCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalProcessedRecordCount", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalFailedRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalFailedRecordCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalFailedRecordCount", value);
			}
		}

		public void RegisterMissingAsset(System.String hash)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterMissingAsset", hash);
		}

		public GroupMigrationStatus GetGroupStatus(System.String ownerId, System.String groupName)
		{
			return (GroupMigrationStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupStatus", ownerId, groupName), typeof(GroupMigrationStatus));
		}

		public void UpdateStats()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStats");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AccountMigrationStatus(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AccountMigrationStatus()
		{
		}
	}
	[DataModelType]
	public enum MigrationState
	{
		Waiting,
		Migrating,
		Completed,
		Failed
	}
	public class AccountMigrationTask : ResoniteBridge.ResoniteBridgeValueHolder
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
		public System.String TaskId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TaskId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TaskId", value);
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

		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "state")]
		[JsonPropertyName("state")]
		public MigrationState State
		{
			get
			{
				return (MigrationState)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(MigrationState));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		[JsonProperty(PropertyName = "estimatedQueuePosition")]
		[JsonPropertyName("estimatedQueuePosition")]
		public System.Int32 EstimatedQueuePosition
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EstimatedQueuePosition"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EstimatedQueuePosition", value);
			}
		}

		[JsonProperty(PropertyName = "createdOn")]
		[JsonPropertyName("createdOn")]
		public DateTimeOffset CreatedOn
		{
			get
			{
				return (DateTimeOffset)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreatedOn"), typeof(DateTimeOffset));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreatedOn", value);
			}
		}

		[JsonProperty(PropertyName = "startCount")]
		[JsonPropertyName("startCount")]
		public System.Int32 StartCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StartCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StartCount", value);
			}
		}

		[JsonProperty(PropertyName = "lastError")]
		[JsonPropertyName("lastError")]
		public System.String LastError
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastError"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastError", value);
			}
		}

		[JsonProperty(PropertyName = "config")]
		[JsonPropertyName("config")]
		public AccountMigrationConfig Config
		{
			get
			{
				return (AccountMigrationConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Config"), typeof(AccountMigrationConfig));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Config", value);
			}
		}

		[JsonProperty(PropertyName = "status")]
		[JsonPropertyName("status")]
		public AccountMigrationStatus Status
		{
			get
			{
				return (AccountMigrationStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(AccountMigrationStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Status", value);
			}
		}

		[JsonProperty(PropertyName = "contactsCompleted")]
		[JsonPropertyName("contactsCompleted")]
		public System.Boolean ContactsCompleted
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactsCompleted"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactsCompleted", value);
			}
		}

		[JsonProperty(PropertyName = "userOwnedCompleted")]
		[JsonPropertyName("userOwnedCompleted")]
		public System.Boolean UserOwnedCompleted
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserOwnedCompleted"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserOwnedCompleted", value);
			}
		}

		[JsonProperty(PropertyName = "groupsCompleted")]
		[JsonPropertyName("groupsCompleted")]
		public HashSet<string> GroupsCompleted
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupsCompleted"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupsCompleted", value);
			}
		}

		[JsonProperty(PropertyName = "runStatuses")]
		[JsonPropertyName("runStatuses")]
		public List<AccountMigrationStatus> RunStatuses
		{
			get
			{
				return (List<AccountMigrationStatus>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RunStatuses"), typeof(List<AccountMigrationStatus>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RunStatuses", value);
			}
		}

		public void UpdateStatus()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStatus");
		}

		public void MergeStatus(VariableMigrationStatus target, VariableMigrationStatus source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MergeStatus", target, source);
		}

		public void MergeStatus(RecordMigrationStatus target, RecordMigrationStatus source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MergeStatus", target, source);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AccountMigrationTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AccountMigrationTask()
		{
		}
	}
	public class GroupMigrationStatus : ResoniteBridge.ResoniteBridgeValueHolder
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

		[JsonProperty(PropertyName = "migratedMemberCount")]
		[JsonPropertyName("migratedMemberCount")]
		public System.Int32 MigratedMemberCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedMemberCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedMemberCount", value);
			}
		}

		[JsonProperty(PropertyName = "recordsStatus")]
		[JsonPropertyName("recordsStatus")]
		public RecordMigrationStatus RecordsStatus
		{
			get
			{
				return (RecordMigrationStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordsStatus"), typeof(RecordMigrationStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordsStatus", value);
			}
		}

		[JsonProperty(PropertyName = "variablesStatus")]
		[JsonPropertyName("variablesStatus")]
		public VariableMigrationStatus VariablesStatus
		{
			get
			{
				return (VariableMigrationStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariablesStatus"), typeof(VariableMigrationStatus));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariablesStatus", value);
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

		public GroupMigrationStatus(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GroupMigrationStatus()
		{
		}
	}
	public class MigrationInitialization : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "sourceCloudConfig")]
		[JsonPropertyName("sourceCloudConfig")]
		public SkyFrostConfig SourceCloudConfig
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceCloudConfig"), typeof(SkyFrostConfig));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceCloudConfig", value);
			}
		}

		[JsonProperty(PropertyName = "sourceLogin")]
		[JsonPropertyName("sourceLogin")]
		public LoginCredentials SourceLogin
		{
			get
			{
				return (LoginCredentials)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceLogin"), typeof(LoginCredentials));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceLogin", value);
			}
		}

		[JsonProperty(PropertyName = "sourceTOTP")]
		[JsonPropertyName("sourceTOTP")]
		public System.String SourceTOTP
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceTOTP"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceTOTP", value);
			}
		}

		[JsonProperty(PropertyName = "sourceSession")]
		[JsonPropertyName("sourceSession")]
		public UserSession SourceSession
		{
			get
			{
				return (UserSession)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceSession"), typeof(UserSession));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceSession", value);
			}
		}

		[JsonProperty(PropertyName = "sourceUID")]
		[JsonPropertyName("sourceUID")]
		public System.String SourceUID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceUID"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceUID", value);
			}
		}

		[JsonProperty(PropertyName = "sourceSecretMachineID")]
		[JsonPropertyName("sourceSecretMachineID")]
		public System.String SourceSecretMachineID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceSecretMachineID"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceSecretMachineID", value);
			}
		}

		[JsonProperty(PropertyName = "config")]
		[JsonPropertyName("config")]
		public AccountMigrationConfig Config
		{
			get
			{
				return (AccountMigrationConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Config"), typeof(AccountMigrationConfig));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Config", value);
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

		public MigrationInitialization(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public MigrationInitialization()
		{
		}
	}
	public class RecordMigrationFailure : ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		[JsonProperty(PropertyName = "recordName")]
		[JsonPropertyName("recordName")]
		public System.String RecordName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordName", value);
			}
		}

		[JsonProperty(PropertyName = "recordPath")]
		[JsonPropertyName("recordPath")]
		public System.String RecordPath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordPath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordPath", value);
			}
		}

		[JsonProperty(PropertyName = "failureReason")]
		[JsonPropertyName("failureReason")]
		public System.String FailureReason
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FailureReason"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FailureReason", value);
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

		public RecordMigrationFailure(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RecordMigrationFailure()
		{
		}
	}
	public class RecordMigrationStatus : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "totalRecordCount")]
		[JsonPropertyName("totalRecordCount")]
		public System.Int32 TotalRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalRecordCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedRecordCount")]
		[JsonPropertyName("migratedRecordCount")]
		public System.Int32 MigratedRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedRecordCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "alreadyMigratedRecordCount")]
		[JsonPropertyName("alreadyMigratedRecordCount")]
		public System.Int32 AlreadyMigratedRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlreadyMigratedRecordCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AlreadyMigratedRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "conflictedRecordCount")]
		[JsonPropertyName("conflictedRecordCount")]
		public System.Int32 ConflictedRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConflictedRecordCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConflictedRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "totalProcessedRecordCount")]
		[JsonPropertyName("totalProcessedRecordCount")]
		public System.Int32 TotalProcessedRecordCount => MigratedRecordCount + AlreadyMigratedRecordCount + ConflictedRecordCount;

		[JsonProperty(PropertyName = "recordSearchPhase")]
		[JsonPropertyName("recordSearchPhase")]
		public System.String RecordSearchPhase
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordSearchPhase"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordSearchPhase", value);
			}
		}

		[JsonProperty(PropertyName = "bytesToUpload")]
		[JsonPropertyName("bytesToUpload")]
		public System.Int64 BytesToUpload
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesToUpload"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesToUpload", value);
			}
		}

		[JsonProperty(PropertyName = "bytesUploaded")]
		[JsonPropertyName("bytesUploaded")]
		public System.Int64 BytesUploaded
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesUploaded"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesUploaded", value);
			}
		}

		[JsonProperty(PropertyName = "assetsToUpload")]
		[JsonPropertyName("assetsToUpload")]
		public System.Int32 AssetsToUpload
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsToUpload"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsToUpload", value);
			}
		}

		[JsonProperty(PropertyName = "assetsUploaded")]
		[JsonPropertyName("assetsUploaded")]
		public System.Int32 AssetsUploaded
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsUploaded"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsUploaded", value);
			}
		}

		[JsonProperty(PropertyName = "lastUpdated")]
		[JsonPropertyName("lastUpdated")]
		public DateTime LastUpdated
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastUpdated"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastUpdated", value);
			}
		}

		[JsonProperty(PropertyName = "currentlyMigratingRecords")]
		[JsonPropertyName("currentlyMigratingRecords")]
		public HashSet<string> CurrentlyMigratingRecords
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentlyMigratingRecords"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentlyMigratingRecords", value);
			}
		}

		[JsonProperty(PropertyName = "failedRecords")]
		[JsonPropertyName("failedRecords")]
		public List<RecordMigrationFailure> FailedRecords
		{
			get
			{
				return (List<RecordMigrationFailure>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FailedRecords"), typeof(List<RecordMigrationFailure>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FailedRecords", value);
			}
		}

		public void Updated()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Updated");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordMigrationStatus(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RecordMigrationStatus()
		{
		}
	}
	public class VariableMigrationStatus : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "migratedVariableCount")]
		[JsonPropertyName("migratedVariableCount")]
		public System.Int32 MigratedVariableCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedVariableCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedVariableCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedVariableDefinitionCount")]
		[JsonPropertyName("migratedVariableDefinitionCount")]
		public System.Int32 MigratedVariableDefinitionCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedVariableDefinitionCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedVariableDefinitionCount", value);
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

		public VariableMigrationStatus(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public VariableMigrationStatus()
		{
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class SessionInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Int32 MAX_DLL_LENGTH
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_DLL_LENGTH"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_DLL_LENGTH", value);
			}
		}

		public System.Int32 MAX_NAME_LENGTH
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_NAME_LENGTH"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_NAME_LENGTH", value);
			}
		}

		public System.Int32 MAX_DESCRIPTION_LENGTH
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_DESCRIPTION_LENGTH"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_DESCRIPTION_LENGTH", value);
			}
		}

		public System.Int32 MAX_TAG_LENGTH
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_TAG_LENGTH"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_TAG_LENGTH", value);
			}
		}

		public System.Int32 MAX_TAGS
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_TAGS"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_TAGS", value);
			}
		}

		public System.Int32 MAX_PARENT_SESSION_IDS
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_PARENT_SESSION_IDS"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_PARENT_SESSION_IDS", value);
			}
		}

		public System.Int32 MAX_NESTED_SESSION_IDS
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_NESTED_SESSION_IDS"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_NESTED_SESSION_IDS", value);
			}
		}

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

		public System.Int32 MAX_URL_LENGTH
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_URL_LENGTH"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_URL_LENGTH", value);
			}
		}

		public System.Int32 MAX_USER_COUNT
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_USER_COUNT"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_USER_COUNT", value);
			}
		}

		public static TimeSpan SESSION_UPDATE_INTERVAL => TimeSpan.FromSeconds(5.0);

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
		public RecordId ActualCorrespondingWorldId => PrivateCorrespondingWorldId ?? CorrespondingWorldId;

		[JsonProperty(PropertyName = "correspondingWorldId")]
		[JsonPropertyName("correspondingWorldId")]
		public RecordId CorrespondingWorldId
		{
			get
			{
				return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CorrespondingWorldId"), typeof(RecordId));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CorrespondingWorldId", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public RecordId PrivateCorrespondingWorldId
		{
			get
			{
				return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrivateCorrespondingWorldId"), typeof(RecordId));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrivateCorrespondingWorldId", value);
			}
		}

		[JsonProperty(PropertyName = "tags")]
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

		[JsonProperty(PropertyName = "normalizedSessionId")]
		[JsonPropertyName("normalizedSessionId")]
		public System.String NormalizedSessionId => NormalizeId(SessionId);

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

		[JsonProperty(PropertyName = "hostMachineId")]
		[JsonPropertyName("hostMachineId")]
		public System.String HostMachineId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostMachineId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HostMachineId", value);
			}
		}

		[JsonProperty(PropertyName = "hostUsername")]
		[JsonPropertyName("hostUsername")]
		public System.String HostUsername
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUsername"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HostUsername", value);
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

		[JsonProperty(PropertyName = "systemCompatibilityHash")]
		[JsonPropertyName("systemCompatibilityHash")]
		public System.String SystemCompatibilityHash
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SystemCompatibilityHash"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SystemCompatibilityHash", value);
			}
		}

		[JsonProperty(PropertyName = "dataModelAssemblies")]
		[JsonPropertyName("dataModelAssemblies")]
		public List<AssemblyInfo> DataModelAssemblies
		{
			get
			{
				return (List<AssemblyInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataModelAssemblies"), typeof(List<AssemblyInfo>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DataModelAssemblies", value);
			}
		}

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

		[JsonProperty(PropertyName = "appVersion")]
		[JsonPropertyName("appVersion")]
		public System.String AppVersion
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppVersion"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppVersion", value);
			}
		}

		[JsonProperty(PropertyName = "headlessHost")]
		[JsonPropertyName("headlessHost")]
		public System.Boolean HeadlessHost
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HeadlessHost"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HeadlessHost", value);
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

		[JsonProperty(PropertyName = "nestedSessionIds")]
		[JsonPropertyName("nestedSessionIds")]
		public List<string> NestedSessionIds
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NestedSessionIds"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NestedSessionIds", value);
			}
		}

		[JsonProperty(PropertyName = "sessionUsers")]
		[JsonPropertyName("sessionUsers")]
		public List<SessionUser> SessionUsers
		{
			get
			{
				return (List<SessionUser>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionUsers"), typeof(List<SessionUser>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionUsers", value);
			}
		}

		[JsonProperty(PropertyName = "thumbnailUrl")]
		[JsonPropertyName("thumbnailUrl")]
		public System.String ThumbnailUrl
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailUrl"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailUrl", value);
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

		[JsonProperty(PropertyName = "totalJoinedUsers")]
		[JsonPropertyName("totalJoinedUsers")]
		public System.Int32 TotalJoinedUsers
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalJoinedUsers"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalJoinedUsers", value);
			}
		}

		[JsonProperty(PropertyName = "totalActiveUsers")]
		[JsonPropertyName("totalActiveUsers")]
		public System.Int32 TotalActiveUsers
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalActiveUsers"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalActiveUsers", value);
			}
		}

		[JsonProperty(PropertyName = "maxUsers")]
		[JsonPropertyName("maxUsers")]
		public System.Int32 MaximumUsers
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaximumUsers"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaximumUsers", value);
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

		[JsonProperty(PropertyName = "sessionBeginTime")]
		[JsonPropertyName("sessionBeginTime")]
		public DateTime SessionBeginTime
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionBeginTime"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionBeginTime", value);
			}
		}

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

		[JsonProperty(PropertyName = "hideFromListing")]
		[JsonPropertyName("hideFromListing")]
		public System.Boolean HideFromListing
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HideFromListing"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HideFromListing", value);
			}
		}

		[JsonProperty(PropertyName = "broadcastKey")]
		[JsonPropertyName("broadcastKey")]
		public System.String BroadcastKey
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BroadcastKey"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BroadcastKey", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.UInt16 LAN_Port
		{
			get
			{
				return (System.UInt16)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LAN_Port"), typeof(System.UInt16));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LAN_Port", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.String LAN_URL
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LAN_URL"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LAN_URL", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsOnLAN => LAN_URL != null;

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime LastLAN_Update
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastLAN_Update"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastLAN_Update", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime LastWorldConfigurationUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastWorldConfigurationUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastWorldConfigurationUpdate", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime LastWorldUserUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastWorldUserUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastWorldUserUpdate", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime LastInviteListUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastInviteListUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastInviteListUpdate", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsExpired => IsTimestampExpired(LastUpdate);

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Single ExpirationProgress => TimestampExpirationProgress(LastUpdate);

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.String SanitizedHostUsername => StringParsingHelper.SanitizeFormatTags(HostUsername);

		public System.Boolean HasEnded
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasEnded"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HasEnded", value);
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

		public static System.String NormalizeId(System.String id)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "NormalizeId", id), typeof(System.String));
		}

		public static System.Boolean IsTimestampExpired(DateTime lastUpdate)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsTimestampExpired", lastUpdate), typeof(System.Boolean));
		}

		public static System.Single TimestampExpirationProgress(DateTime lastUpdate)
		{
			return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "TimestampExpirationProgress", lastUpdate), typeof(System.Single));
		}

		public SessionInfo()
		{
		}

		public SessionInfo(System.String sessionId)
		{
			SessionId = sessionId;
			LastUpdate = DateTime.UtcNow;
		}

		public static System.Boolean IsAllowedName(System.String name)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsAllowedName", name), typeof(System.Boolean));
		}

		public static System.Boolean IsCustomSessionId(System.String sessionId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsCustomSessionId", sessionId), typeof(System.Boolean));
		}

		public static System.String GetCustomSessionIdOwner(System.String sessionId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCustomSessionIdOwner", sessionId), typeof(System.String));
		}

		public static System.Boolean IsValidSessionId(System.String sessionId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidSessionId", sessionId), typeof(System.Boolean));
		}

		public static System.Boolean IsValidVersion(System.String version)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidVersion", version), typeof(System.Boolean));
		}

		public List<ResoniteBridge.ResoniteBridgeValue> GetSessionURLs()
		{
			return (List<ResoniteBridge.ResoniteBridgeValue>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionURLs"), typeof(List<ResoniteBridge.ResoniteBridgeValue>));
		}

		public void SetEnded()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetEnded");
		}

		public void CopyLAN_Data(SessionInfo source)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CopyLAN_Data", source);
		}

		public System.Boolean HasTag(System.String tag)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasTag", tag), typeof(System.Boolean));
		}

		public void Trim()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Trim");
		}

		public CloudSessionMetadata GetMetadata()
		{
			return (CloudSessionMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMetadata"), typeof(CloudSessionMetadata));
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

		public SessionInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class SessionUpdate : ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "hostedSessions")]
		[JsonPropertyName("hostedSessions")]
		public List<SessionInfo> HostedSessions
		{
			get
			{
				return (List<SessionInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostedSessions"), typeof(List<SessionInfo>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HostedSessions", value);
			}
		}

		[JsonProperty(PropertyName = "removedSessions")]
		[JsonPropertyName("removedSessions")]
		public List<string> RemovedSessions
		{
			get
			{
				return (List<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RemovedSessions"), typeof(List<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RemovedSessions", value);
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

		public SessionUpdate(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SessionUpdate()
		{
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class SessionUser : IEquatable<SessionUser>, ResoniteBridge.ResoniteBridgeValueHolder
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

		[JsonProperty(PropertyName = "userID")]
		[JsonPropertyName("userID")]
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

		[JsonProperty(PropertyName = "userSessionId")]
		[JsonPropertyName("userSessionId")]
		public System.String UserSessionId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserSessionId", value);
			}
		}

		[JsonProperty(PropertyName = "isPresent")]
		[JsonPropertyName("isPresent")]
		public System.Boolean IsPresent
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPresent"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPresent", value);
			}
		}

		[JsonProperty(PropertyName = "outputDevice")]
		[JsonPropertyName("outputDevice")]
		[Newtonsoft.Json.JsonConverter(typeof(NewtonsoftJsonTransitionEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonTransitionEnumConverter<OutputDevice>))]
		public ResoniteBridge.ResoniteBridgeValue OutputDevice
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDevice"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OutputDevice", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.String SanitizedUsername => StringParsingHelper.SanitizeFormatTags(Username);

		public System.Boolean Equals(SessionUser other)
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

		public SessionUser(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SessionUser()
		{
		}
	}
	public class SkyFrostConfig : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String SECRET_CLIENT_KEY
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SECRET_CLIENT_KEY"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SECRET_CLIENT_KEY", value);
			}
		}

		public System.String CLOUDFLARE_DURIAN_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "CLOUDFLARE_DURIAN_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "CLOUDFLARE_DURIAN_ENDPOINT", value);
			}
		}

		public System.String DURIAN_ASSET_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DURIAN_ASSET_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DURIAN_ASSET_ENDPOINT", value);
			}
		}

		public System.String DURIAN_VARIANT_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DURIAN_VARIANT_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DURIAN_VARIANT_ENDPOINT", value);
			}
		}

		public System.String DURIAN_THUMBNAIL_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DURIAN_THUMBNAIL_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DURIAN_THUMBNAIL_ENDPOINT", value);
			}
		}

		public System.String CLOUDFLARE_SKYFROST_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "CLOUDFLARE_SKYFROST_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "CLOUDFLARE_SKYFROST_ENDPOINT", value);
			}
		}

		public System.String SKYFROST_ASSET_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SKYFROST_ASSET_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SKYFROST_ASSET_ENDPOINT", value);
			}
		}

		public System.String SKYFROST_VARIANT_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SKYFROST_VARIANT_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SKYFROST_VARIANT_ENDPOINT", value);
			}
		}

		public System.String SKYFROST_THUMBNAIL_ENDPOINT
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SKYFROST_THUMBNAIL_ENDPOINT"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SKYFROST_THUMBNAIL_ENDPOINT", value);
			}
		}

		[JsonPropertyName("platform")]
		public IPlatformProfile Platform
		{
			get
			{
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Platform"), typeof(IPlatformProfile));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Platform", value);
			}
		}

		[JsonPropertyName("userAgentProduct")]
		public System.String UserAgentProduct
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentProduct"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserAgentProduct", value);
			}
		}

		[JsonPropertyName("userAgentVersion")]
		public System.String UserAgentVersion
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentVersion"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserAgentVersion", value);
			}
		}

		[JsonPropertyName("gzip")]
		public System.Boolean GZip
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GZip"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GZip", value);
			}
		}

		[JsonPropertyName("proxyConfig")]
		public ProxyConfig ProxyConfig
		{
			get
			{
				return (ProxyConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProxyConfig"), typeof(ProxyConfig));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ProxyConfig", value);
			}
		}

		[JsonPropertyName("apiEndpoint")]
		public System.String ApiEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApiEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ApiEndpoint", value);
			}
		}

		[JsonPropertyName("signalREndpoint")]
		public System.String SignalREndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SignalREndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SignalREndpoint", value);
			}
		}

		[JsonPropertyName("serverStatusEndpoint")]
		public System.String ServerStatusEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerStatusEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ServerStatusEndpoint", value);
			}
		}

		[JsonPropertyName("secretClientAccessKey")]
		public System.String SecretClientAccessKey
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretClientAccessKey"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SecretClientAccessKey", value);
			}
		}

		[JsonPropertyName("saml2Endpoint")]
		public System.String Saml2Endpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Saml2Endpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Saml2Endpoint", value);
			}
		}

		[JsonPropertyName("defaultTimeout")]
		public TimeSpan DefaultTimeout
		{
			get
			{
				return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultTimeout"), typeof(TimeSpan));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DefaultTimeout", value);
			}
		}

		[JsonPropertyName("assetInterface")]
		public AssetInterface AssetInterface
		{
			get
			{
				return (AssetInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetInterface"), typeof(AssetInterface));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetInterface", value);
			}
		}

		[JsonPropertyName("networkNodes")]
		public INetworkNodeManager NetworkNodes
		{
			get
			{
				return (INetworkNodeManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkNodes"), typeof(INetworkNodeManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkNodes", value);
			}
		}

		[JsonPropertyName("contactPath")]
		public System.String ContactPath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactPath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactPath", value);
			}
		}

		[JsonPropertyName("legacyLogin")]
		public System.Boolean UseLegacyLogin
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseLegacyLogin"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseLegacyLogin", value);
			}
		}

		[JsonPropertyName("universeId")]
		public System.String UniverseID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseID"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UniverseID", value);
			}
		}

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

		public static SkyFrostConfig DEFAULT_PRODUCTION => SKYFROST_PRODUCTION;

		public static SkyFrostConfig DEFAULT_PRODUCTION_DIRECT => SKYFROST_PRODUCTION_DIRECT;

		public static SkyFrostConfig DEFAULT_STAGING => SKYFROST_STAGING;

		public static SkyFrostConfig DEFAULT_LOCAL => SKYFROST_LOCAL;

		public static SkyFrostConfig DURIAN_LOCAL => new SkyFrostConfig
		{
			Platform = PlatformProfile.DURIAN,
			UserAgentProduct = "Durian",
			ApiEndpoint = "http://localhost:60612",
			SignalREndpoint = "http://localhost:60612/hub",
			ServerStatusEndpoint = "https://skyfroststorage.blob.core.windows.net/install/ServerResponse",
			AssetInterface = new CloudflareAssetInterface("https://assetx.frooxius.workers.dev/", "https://assets.everion.com/", "https://variants.everion.com/", "https://thumbnails.everion.com/"),
			NetworkNodes = new NetworkNodeManager(),
			ContactPath = "contacts"
		};

		public static SkyFrostConfig DURIAN_STAGING => new SkyFrostConfig
		{
			Platform = PlatformProfile.DURIAN,
			UserAgentProduct = "Durian",
			ApiEndpoint = "https://everion-api.azurewebsites.net",
			SignalREndpoint = "https://everion-api.azurewebsites.net/hub",
			ServerStatusEndpoint = "https://everionfastblob.blob.core.windows.net/metadata/ServerResponse",
			Saml2Endpoint = "https://everionaccount.azurewebsites.net/Identity/Account/SAML/",
			AssetInterface = new CloudflareAssetInterface("https://assetx.frooxius.workers.dev/", "https://assets.everion.com/", "https://variants.everion.com/", "https://thumbnails.everion.com/"),
			NetworkNodes = new NetworkNodeManager()
		};

		public static SkyFrostConfig DURIAN_PRODUCTION => new SkyFrostConfig
		{
			Platform = PlatformProfile.DURIAN,
			UserAgentProduct = "Durian",
			ApiEndpoint = "https://everion-api.azurewebsites.net",
			SignalREndpoint = "https://everion-api.azurewebsites.net/hub",
			ServerStatusEndpoint = "https://everionfastblob.blob.core.windows.net/metadata/ServerResponse",
			Saml2Endpoint = "https://everionaccount.azurewebsites.net/Identity/Account/SAML/",
			AssetInterface = new CloudflareAssetInterface("https://assetx.frooxius.workers.dev/", "https://assets.everion.com/", "https://variants.everion.com/", "https://thumbnails.everion.com/"),
			NetworkNodes = new NetworkNodeManager()
		};

		public static SkyFrostConfig SKYFROST_LOCAL => new SkyFrostConfig
		{
			Platform = PlatformProfile.RESONITE,
			UserAgentProduct = "Resonite",
			ApiEndpoint = "http://localhost:60612",
			SignalREndpoint = "http://localhost:60612/hub",
			ServerStatusEndpoint = "https://skyfrostfastblob.blob.core.windows.net/install/ServerResponse",
			AssetInterface = new CloudflareAssetInterface("https://skyfrost-archive.resonite.com/", "https://assets.resonite.com/", "https://variants.resonite.com/", "https://thumbnails.resonite.com/"),
			NetworkNodes = new NetworkNodeManager(),
			ContactPath = "contacts"
		};

		public static SkyFrostConfig SKYFROST_STAGING => new SkyFrostConfig
		{
			Platform = PlatformProfile.RESONITE,
			UserAgentProduct = "Resonite",
			ApiEndpoint = "https://skyfrost-api-staging.azurewebsites.net/",
			SignalREndpoint = "https://skyfrost-api-staging.azurewebsites.net/hub",
			ServerStatusEndpoint = "https://skyfrostfastblob.blob.core.windows.net/metadata/ServerResponse",
			Saml2Endpoint = "https://account.resonite.com/Identity/Account/SAML/",
			AssetInterface = new CloudflareAssetInterface("https://skyfrost-archive.resonite.com/", "https://assets.resonite.com/", "https://variants.resonite.com/", "https://thumbnails.resonite.com/"),
			NetworkNodes = new NetworkNodeManager()
		};

		public static SkyFrostConfig SKYFROST_PRODUCTION => new SkyFrostConfig
		{
			Platform = PlatformProfile.RESONITE,
			UserAgentProduct = "Resonite",
			ApiEndpoint = "https://api.resonite.com",
			SignalREndpoint = "https://api.resonite.com/hub",
			ServerStatusEndpoint = "https://skyfrostfastblob.blob.core.windows.net/metadata/ServerResponse",
			Saml2Endpoint = "https://account.resonite.com/Identity/Account/SAML/",
			AssetInterface = new CloudflareAssetInterface("https://skyfrost-archive.resonite.com/", "https://assets.resonite.com/", "https://variants.resonite.com/", "https://thumbnails.resonite.com/"),
			NetworkNodes = new NetworkNodeManager()
		};

		public static SkyFrostConfig SKYFROST_PRODUCTION_DIRECT => new SkyFrostConfig
		{
			Platform = PlatformProfile.RESONITE,
			UserAgentProduct = "Resonite",
			ApiEndpoint = "https://skyfrost-api.azurewebsites.net",
			SignalREndpoint = "https://skyfrost-api.azurewebsites.net//hub",
			ServerStatusEndpoint = "https://skyfrostfastblob.blob.core.windows.net/metadata/ServerResponse",
			Saml2Endpoint = "https://account.resonite.com/Identity/Account/SAML/",
			AssetInterface = new CloudflareAssetInterface("https://skyfrost-archive.resonite.com/", "https://assets.resonite.com/", "https://variants.resonite.com/", "https://thumbnails.resonite.com/"),
			NetworkNodes = new NetworkNodeManager()
		};

		public SkyFrostConfig WithUserAgent(System.String product, System.String version = null)
		{
			return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithUserAgent", product, version), typeof(SkyFrostConfig));
		}

		public SkyFrostConfig WithGzip(System.Boolean enabled)
		{
			return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithGzip", enabled), typeof(SkyFrostConfig));
		}

		public SkyFrostConfig WithoutSignalR()
		{
			return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithoutSignalR"), typeof(SkyFrostConfig));
		}

		public SkyFrostConfig WithUniverse(System.String universeId)
		{
			return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithUniverse", universeId), typeof(SkyFrostConfig));
		}

		public SkyFrostConfig WithProxy(ProxyConfig proxy)
		{
			return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithProxy", proxy), typeof(SkyFrostConfig));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SkyFrostConfig(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SkyFrostConfig()
		{
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class UserSessionMetadata : IEquatable<UserSessionMetadata>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		[JsonProperty(PropertyName = "sessionHash")]
		[JsonPropertyName("sessionHash")]
		public System.String SessionHash
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionHash"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionHash", value);
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

		[JsonProperty(PropertyName = "isHost")]
		[JsonPropertyName("isHost")]
		public System.Boolean IsHost
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsHost"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsHost", value);
			}
		}

		[JsonProperty(PropertyName = "broadcastKey")]
		[JsonPropertyName("broadcastKey")]
		public System.String BroadcastKey
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BroadcastKey"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BroadcastKey", value);
			}
		}

		public System.Boolean Equals(UserSessionMetadata other)
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

		public UserSessionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UserSessionMetadata()
		{
		}
	}
	public static class OnlineStatusHelper
	{
		public static System.Boolean DefaultPrivate(this OnlineStatus status)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "OnlineStatusHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DefaultPrivate", status), typeof(System.Boolean));
		}
	}
	[JsonObject(MemberSerialization = MemberSerialization.OptIn)]
	public class UserStatus : IEquatable<UserStatus>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static TimeSpan StatusExpiration
		{
			get
			{
				return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserStatus", ResoniteBridge.ResoniteBridgeValueType.Type), "StatusExpiration"), typeof(TimeSpan));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserStatus", ResoniteBridge.ResoniteBridgeValueType.Type), "StatusExpiration", value);
			}
		}

		public static TimeSpan StatusHeartbeat
		{
			get
			{
				return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserStatus", ResoniteBridge.ResoniteBridgeValueType.Type), "StatusHeartbeat"), typeof(TimeSpan));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserStatus", ResoniteBridge.ResoniteBridgeValueType.Type), "StatusHeartbeat", value);
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

		[JsonProperty(PropertyName = "userSessionId")]
		[JsonPropertyName("userSessionId")]
		public System.String UserSessionId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionId"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserSessionId", value);
			}
		}

		[JsonProperty(PropertyName = "sessionType")]
		[JsonPropertyName("sessionType")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public UserSessionType SessionType
		{
			get
			{
				return (UserSessionType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionType"), typeof(UserSessionType));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionType", value);
			}
		}

		[JsonProperty(PropertyName = "outputDevice")]
		[JsonPropertyName("outputDevice")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ResoniteBridge.ResoniteBridgeValue OutputDevice
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDevice"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OutputDevice", value);
			}
		}

		[JsonProperty(PropertyName = "isMobile")]
		[JsonPropertyName("isMobile")]
		public System.Boolean IsMobile
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMobile"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMobile", value);
			}
		}

		[JsonProperty(PropertyName = "onlineStatus")]
		[JsonPropertyName("onlineStatus")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public ResoniteBridge.ResoniteBridgeValue OnlineStatus
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlineStatus"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlineStatus", value);
			}
		}

		[JsonProperty(PropertyName = "isPresent")]
		[JsonPropertyName("isPresent")]
		public System.Boolean IsPresent
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPresent"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPresent", value);
			}
		}

		[JsonProperty(PropertyName = "lastPresenceTimestamp")]
		[JsonPropertyName("lastPresenceTimestamp")]
		public ResoniteBridge.ResoniteBridgeValue LastPresenceTimestamp
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPresenceTimestamp"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastPresenceTimestamp", value);
			}
		}

		[JsonProperty(PropertyName = "lastStatusChange")]
		[JsonPropertyName("lastStatusChange")]
		public DateTime LastStatusChange
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastStatusChange"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastStatusChange", value);
			}
		}

		[JsonProperty(PropertyName = "hashSalt")]
		[JsonPropertyName("hashSalt")]
		public System.String HashSalt
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HashSalt"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HashSalt", value);
			}
		}

		[JsonProperty(PropertyName = "appVersion")]
		[JsonPropertyName("appVersion")]
		public System.String AppVersion
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppVersion"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppVersion", value);
			}
		}

		[JsonProperty(PropertyName = "compatibilityHash")]
		[JsonPropertyName("compatibilityHash")]
		[Obsolete]
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

		[JsonProperty(PropertyName = "publicRSAKey")]
		[JsonPropertyName("publicRSAKey")]
		public RSAParametersData PublicRSAKey
		{
			get
			{
				return (RSAParametersData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicRSAKey"), typeof(RSAParametersData));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicRSAKey", value);
			}
		}

		[JsonProperty(PropertyName = "sessions")]
		[JsonPropertyName("sessions")]
		public List<UserSessionMetadata> Sessions
		{
			get
			{
				return (List<UserSessionMetadata>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Sessions"), typeof(List<UserSessionMetadata>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Sessions", value);
			}
		}

		[JsonProperty(PropertyName = "currentSessionIndex")]
		[JsonPropertyName("currentSessionIndex")]
		public System.Int32 CurrentSessionIndex
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSessionIndex"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentSessionIndex", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public UserSessionMetadata CurrentSession
		{
			get
			{
				return (UserSessionMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSession"), typeof(UserSessionMetadata));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentSession", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Boolean IsExpired => DateTime.UtcNow - LastStatusChange > StatusExpiration;

		public UserStatus Clone()
		{
			return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(UserStatus));
		}

		public void InitializeSessionList()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeSessionList");
		}

		public UserSessionMetadata AddSession(SessionInfo info, System.Boolean isFocused)
		{
			return (UserSessionMetadata)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddSession", info, isFocused), typeof(UserSessionMetadata));
		}

		public SessionInfo MatchSessionInfo(IEnumerable<SessionInfo> infos, UserSessionMetadata metadata)
		{
			return (SessionInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MatchSessionInfo", infos, metadata), typeof(SessionInfo));
		}

		public System.Boolean IsMatchingSession(SessionInfo info, UserSessionMetadata metadata)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsMatchingSession", info, metadata), typeof(System.Boolean));
		}

		public void CreateSessionMap(IEnumerable<SessionInfo> infos, Dictionary<string, SessionInfo> map)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateSessionMap", infos, map);
		}

		public System.Boolean IsDominantOver(UserStatus status)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsDominantOver", status), typeof(System.Boolean));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public System.Boolean Equals(UserStatus other)
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

		public UserStatus(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UserStatus()
		{
		}
	}
	public static class RecordTags
	{
		private static HashSet<string> IGNORE_TAGS
		{
			get
			{
				return (HashSet<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "IGNORE_TAGS"), typeof(HashSet<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "IGNORE_TAGS", value);
			}
		}

		public static System.String CommonAvatar => "common_avatar";

		public static System.String CommonTool => "common_tool";

		public static System.String ProfileIcon => "profile_icon";

		public static System.String MessageItem => "message_item";

		public static System.String WorldOrb => "world_orb";

		public static System.String AudioPlayer => "audio_player";

		public static System.String VideoPlayer => "video_player";

		public static System.String VirtualKeyboard => "virtual_keyboard";

		public static System.String InteractiveCamera => "interactive_camera";

		public static System.String Facet => "facet";

		public static System.String ProgressBar => "progress_bar";

		public static System.String WorldLoadingProgress => "world_loading_progress";

		public static System.String AudioStreamInterface => "audio_stream_interface";

		public static System.String TextDisplay => "text_display";

		public static System.String DocumentDisplay => "document_display";

		public static System.String UrlDisplay => "url_display";

		public static System.String NameplateTemplate => "nameplate_template";

		public static System.String NoticeDisplay => "notice_display";

		public static System.String ColorDialog => "color_dialog";

		public static System.String Photo => "camera_photo";

		public static System.String VRPhoto => "vr_photo";

		public static System.String Photo360 => "360_photo";

		public static System.String PhotoStereo => "stereo_photo";

		public static System.String RawFile => "raw_file";

		public static System.String AudioClip => "audio_clip";

		public static System.String VideoClip => "video_clip";

		public static System.String RawFileAsset(System.String url)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "RawFileAsset", url), typeof(System.String));
		}

		public static System.String TextureAsset(System.String url)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "TextureAsset", url), typeof(System.String));
		}

		public static System.String ClipAsset(System.String url)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ClipAsset", url), typeof(System.String));
		}

		public static System.String ClipLength(System.Double length)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ClipLength", length), typeof(System.String));
		}

		public static System.String LocationName(System.String name)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationName", name), typeof(System.String));
		}

		public static System.String LocationHost(System.String userId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationHost", userId), typeof(System.String));
		}

		public static System.String LocationAccessLevel(SessionAccessLevel accessLevel)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationAccessLevel", accessLevel), typeof(System.String));
		}

		public static System.String LocationHiddenFromListing(System.Boolean hidden)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationHiddenFromListing", hidden), typeof(System.String));
		}

		public static System.String PresentUser(System.String userId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "PresentUser", userId), typeof(System.String));
		}

		public static System.String Timestamp(DateTime time)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Timestamp", time), typeof(System.String));
		}

		public static System.String CorrespondingMessageId(System.String messageId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CorrespondingMessageId", messageId), typeof(System.String));
		}

		public static System.String CorrespondingWorldUrl(System.String worldUrl)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CorrespondingWorldUrl", worldUrl), typeof(System.String));
		}

		public static System.String GetCorrespondingMessageId(HashSet<string> tags)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCorrespondingMessageId", tags), typeof(System.String));
		}

		public static System.String GetCorrespondingWorldUrl(HashSet<string> tags)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCorrespondingWorldUrl", tags), typeof(System.String));
		}

		private static System.String ExtractValue(HashSet<string> tags, System.String prefix)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractValue", tags, prefix), typeof(System.String));
		}

		public static void GenerateTagsFromName(System.String name, HashSet<string> tags)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateTagsFromName", name, tags);
		}

		private static void ExtractTag(StringBuilder tagBuilder, HashSet<string> tags)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractTag", tagBuilder, tags);
		}
	}
	[DataModelType]
	public enum DB_Endpoint
	{
		Default,
		Video
	}
	[DataModelType]
	public enum ServerStatus
	{
		Good,
		Slow,
		Down,
		NoInternet
	}
	public delegate Task<T> ConsoleLoginHandler<T>(System.String totpCode) where T : CloudResult;
	public class SkyFrostInterface : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.Boolean DEBUG_REQUESTS
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_REQUESTS"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_REQUESTS", value);
			}
		}

		public static System.Boolean UseNewtonsoftJson
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "UseNewtonsoftJson"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "UseNewtonsoftJson", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue SignalRTransports
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SignalRTransports"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SignalRTransports", value);
			}
		}

		public static Action<string> ProfilerBeginSampleCallback
		{
			get
			{
				return (Action<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfilerBeginSampleCallback"), typeof(Action<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfilerBeginSampleCallback", value);
			}
		}

		public static Action ProfilerEndSampleCallback
		{
			get
			{
				return (Action)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfilerEndSampleCallback"), typeof(Action));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfilerEndSampleCallback", value);
			}
		}

		public static Func<MemoryStream> MemoryStreamAllocator
		{
			get
			{
				return (Func<MemoryStream>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MemoryStreamAllocator"), typeof(Func<MemoryStream>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MemoryStreamAllocator", value);
			}
		}

		private CancellationTokenSource _hubConnectionToken
		{
			get
			{
				return (CancellationTokenSource)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_hubConnectionToken"), typeof(CancellationTokenSource));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_hubConnectionToken", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue _metadataBatchQueries
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_metadataBatchQueries"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_metadataBatchQueries", value);
			}
		}

		private System.Int32 SignalRConnectionAttempts
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SignalRConnectionAttempts"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SignalRConnectionAttempts", value);
			}
		}

		public System.String UID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UID", value);
			}
		}

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

		public System.String UserAgentProduct
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentProduct"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserAgentProduct", value);
			}
		}

		public System.String UserAgentVersion
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentVersion"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserAgentVersion", value);
			}
		}

		public System.String ApiEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApiEndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ApiEndpoint", value);
			}
		}

		public System.String SignalREndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SignalREndpoint"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SignalREndpoint", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue UserAgent
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgent"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserAgent", value);
			}
		}

		public User CurrentUser => Session.CurrentUser;

		public System.String CurrentUserID => Session.CurrentUserID;

		public System.String CurrentUsername => Session.CurrentUsername;

		public System.String UniverseID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseID"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UniverseID", value);
			}
		}

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

		public IPlatformProfile Platform
		{
			get
			{
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Platform"), typeof(IPlatformProfile));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Platform", value);
			}
		}

		public ApiClient Api
		{
			get
			{
				return (ApiClient)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Api", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue SafeHttpClient
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SafeHttpClient"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SafeHttpClient", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue Proxy
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Proxy"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Proxy", value);
			}
		}

		public AppHub HubClient
		{
			get
			{
				return (AppHub)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HubClient"), typeof(AppHub));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HubClient", value);
			}
		}

		public AssetGatherer AssetGatherer
		{
			get
			{
				return (AssetGatherer)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetGatherer"), typeof(AssetGatherer));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetGatherer", value);
			}
		}

		public AssetInterface Assets
		{
			get
			{
				return (AssetInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Assets"), typeof(AssetInterface));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Assets", value);
			}
		}

		public ProxyConfig ProxyConfig
		{
			get
			{
				return (ProxyConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProxyConfig"), typeof(ProxyConfig));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ProxyConfig", value);
			}
		}

		protected virtual System.Boolean UseAlternateWebsocket => false;

		public HubStatusController HubStatusController
		{
			get
			{
				return (HubStatusController)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HubStatusController"), typeof(HubStatusController));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HubStatusController", value);
			}
		}

		public SessionManager Session
		{
			get
			{
				return (SessionManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Session"), typeof(SessionManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Session", value);
			}
		}

		public UsersManager Users
		{
			get
			{
				return (UsersManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Users"), typeof(UsersManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Users", value);
			}
		}

		public StorageManager Storage
		{
			get
			{
				return (StorageManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Storage"), typeof(StorageManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Storage", value);
			}
		}

		public SecurityManager Security
		{
			get
			{
				return (SecurityManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Security"), typeof(SecurityManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Security", value);
			}
		}

		public ProfileManager Profile
		{
			get
			{
				return (ProfileManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Profile"), typeof(ProfileManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Profile", value);
			}
		}

		public StatisticsManager Stats
		{
			get
			{
				return (StatisticsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Stats"), typeof(StatisticsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Stats", value);
			}
		}

		public RecordsManager Records
		{
			get
			{
				return (RecordsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Records"), typeof(RecordsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Records", value);
			}
		}

		public SessionsManager Sessions
		{
			get
			{
				return (SessionsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Sessions"), typeof(SessionsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Sessions", value);
			}
		}

		public CloudVariableManager Variables
		{
			get
			{
				return (CloudVariableManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Variables"), typeof(CloudVariableManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Variables", value);
			}
		}

		public UserStatusManager Status
		{
			get
			{
				return (UserStatusManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(UserStatusManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Status", value);
			}
		}

		public ContactManager Contacts
		{
			get
			{
				return (ContactManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contacts"), typeof(ContactManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Contacts", value);
			}
		}

		public GroupsManager Groups
		{
			get
			{
				return (GroupsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Groups"), typeof(GroupsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Groups", value);
			}
		}

		public MessageManager Messages
		{
			get
			{
				return (MessageManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Messages"), typeof(MessageManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Messages", value);
			}
		}

		public INetworkNodeManager NetworkNodes
		{
			get
			{
				return (INetworkNodeManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkNodes"), typeof(INetworkNodeManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NetworkNodes", value);
			}
		}

		public MigrationManager Migration
		{
			get
			{
				return (MigrationManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Migration"), typeof(MigrationManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Migration", value);
			}
		}

		public VisitsManager Visits
		{
			get
			{
				return (VisitsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Visits"), typeof(VisitsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Visits", value);
			}
		}

		public BadgeManager Badges
		{
			get
			{
				return (BadgeManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Badges"), typeof(BadgeManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Badges", value);
			}
		}

		public ModerationManager Moderation
		{
			get
			{
				return (ModerationManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Moderation"), typeof(ModerationManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Moderation", value);
			}
		}

		[Conditional("PROFILE")]
		private void ProfilerBeginSample(System.String name)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerBeginSample", name);
		}

		[Conditional("PROFILE")]
		private void ProfilerEndSample()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerEndSample");
		}

		public MetadataBatchQuery<M> MetadataBatch<M>() where M : class, IAssetMetadata, new()
		{
			return (MetadataBatchQuery<M>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MetadataBatch"), typeof(MetadataBatchQuery<M>));
		}

		protected virtual Task OnLogin()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnLogin"), typeof(Task));
		}

		protected virtual Task OnLogout(System.Boolean isManual)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnLogout", isManual), typeof(Task));
		}

		public virtual Task OnSessionTokenRefresh()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionTokenRefresh"), typeof(Task));
		}

		protected virtual void InstallConfigFile(System.String path, System.String content)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InstallConfigFile", path, content);
		}

		public SkyFrostInterface(System.String uid, System.String secretMachineId, SkyFrostConfig config)
		{
			if (string.IsNullOrEmpty(uid))
			{
				throw new ArgumentNullException("uid");
			}
			if (config == null)
			{
				throw new ArgumentNullException("config");
			}
			if (config.Platform == null)
			{
				throw new ArgumentNullException("Platform");
			}
			if (config.AssetInterface == null)
			{
				throw new ArgumentNullException("AssetInterface");
			}
			Platform = config.Platform;
			UniverseID = config.UniverseID;
			ApiEndpoint = config.ApiEndpoint;
			SignalREndpoint = config.SignalREndpoint;
			UserAgentProduct = config.UserAgentProduct;
			UserAgentVersion = config.UserAgentVersion;
			NodePreference = config.NodePreference;
			UserAgent = new ProductInfoHeaderValue(UserAgentProduct, UserAgentVersion);
			HttpClientHandler httpClientHandler = new HttpClientHandler();
			WebProxy webProxy = WebProxyUtility.CreateProxy(config.ProxyConfig);
			if (webProxy != null)
			{
				UniLog.Log("Initializing proxy configuration for SkyFrost.");
				httpClientHandler.Proxy = webProxy;
				Proxy = webProxy;
			}
			else
			{
				UniLog.Log("Proxy configuration for skyfrost not found or failed to initialize.");
			}
			try
			{
				httpClientHandler.MaxConnectionsPerServer = 16;
			}
			catch (NotImplementedException)
			{
			}
			if (httpClientHandler.SupportsAutomaticDecompression && config.GZip)
			{
				httpClientHandler.AutomaticDecompression = DecompressionMethods.GZip;
			}
			UniLog.Log($"HttpClient AutomaticDecompressionSupported: {httpClientHandler.SupportsAutomaticDecompression}");
			Api = new ApiClient(new HttpClient(httpClientHandler)
			{
				Timeout = Timeout.InfiniteTimeSpan
			}, config.ApiEndpoint, AuthenticateApiRequest, UserAgent, config.SecretClientAccessKey, () => MemoryStreamAllocator?.Invoke(), delegate
			{
			}, delegate
			{
			});
			Api.DefaultTimeout = config.DefaultTimeout;
			SafeHttpClient = new HttpClient(httpClientHandler);
			SafeHttpClient.Timeout = TimeSpan.FromMinutes(1.0);
			if (!string.IsNullOrWhiteSpace(uid))
			{
				UID = uid;
			}
			if (!string.IsNullOrWhiteSpace(secretMachineId))
			{
				SecretMachineId = secretMachineId;
			}
			HubStatusController = new HubStatusController(this);
			Session = new SessionManager(this, config.Saml2Endpoint, config.UseLegacyLogin);
			Users = new UsersManager(this);
			Storage = new StorageManager(this);
			Security = new SecurityManager(this);
			Profile = new ProfileManager(this);
			Stats = new StatisticsManager(this, config.ServerStatusEndpoint);
			Sessions = new SessionsManager(this);
			Variables = new CloudVariableManager(this);
			Status = new UserStatusManager(this);
			Contacts = new ContactManager(this, config.ContactPath);
			Groups = new GroupsManager(this);
			Messages = new MessageManager(this);
			Migration = new MigrationManager(this);
			Records = new RecordsManager(this);
			Visits = new VisitsManager(this);
			Badges = new BadgeManager(this);
			Moderation = new ModerationManager(this);
			Assets = config.AssetInterface;
			Assets.Initialize(this);
			NetworkNodes = config.NetworkNodes;
			NetworkNodes.Initialize(this);
			Sessions.ListingSettings = new DefaultSessionListingSettings();
			Task.Run(async delegate
			{
				if (await RunInitialAnonymousHubConnection().ConfigureAwait(continueOnCapturedContext: false))
				{
					await ConnectToHub("Initial Startup").ConfigureAwait(continueOnCapturedContext: false);
				}
			});
		}

		protected virtual Task<bool> RunInitialAnonymousHubConnection()
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunInitialAnonymousHubConnection"), typeof(Task<bool>));
		}

		private void AuthenticateApiRequest(ResoniteBridge.ResoniteBridgeValue request, System.String totpCode)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AuthenticateApiRequest", request, totpCode);
		}

		internal async Task ConnectToHub(System.String source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectToHub", source), typeof(Task));
		}

		private static async Task Connect(ResoniteBridge.ResoniteBridgeValue connection, System.String source, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Connect", connection, source, cancellationToken), typeof(Task));
		}

		private async Task DisconnectFromHub()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DisconnectFromHub"), typeof(Task));
		}

		public virtual void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		internal async Task Login()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Login"), typeof(Task));
		}

		public async Task FinalizeSession()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeSession"), typeof(Task));
		}

		internal async Task BeginLogout(System.Boolean isManual)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginLogout", isManual), typeof(Task));
		}

		internal void ResetModules()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetModules");
		}

		internal void CompleteLogout(System.Boolean isManual)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompleteLogout", isManual);
		}

		public System.Boolean HasPotentialAccess(System.String ownerId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasPotentialAccess", ownerId), typeof(System.Boolean));
		}

		public async Task<bool> InteractiveConsoleLogin(System.Boolean tryUseCommandLineArgs = false)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InteractiveConsoleLogin", tryUseCommandLineArgs), typeof(Task<bool>));
		}

		public async Task<T> HandleConsoleLogin<T>(ConsoleLoginHandler<T> handler) where T : CloudResult
		{
			return (Task<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HandleConsoleLogin", handler), typeof(Task<T>));
		}

		public async Task<bool> InteractiveConsoleRegister()
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InteractiveConsoleRegister"), typeof(Task<bool>));
		}

		public System.String GetOwnerPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOwnerPath", ownerId), typeof(System.String));
		}

		internal void ProcessUserSessionResult<T>(UserSessionResult<T> result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessUserSessionResult", result);
		}

		public async Task<ExitMessage> GetRandomExitMessage()
		{
			return (Task<ExitMessage>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRandomExitMessage"), typeof(Task<ExitMessage>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SkyFrostInterface(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class SkyFrostModule : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public SkyFrostInterface Cloud { get; private set; }

		public ApiClient Api => Cloud.Api;

		public IPlatformProfile Platform => Cloud.Platform;

		public System.Boolean IsUserSignedIn => CurrentUser != null;

		public User CurrentUser => Cloud.Session.CurrentUser;

		public System.String CurrentUserID => CurrentUser?.Id;

		public System.String CurrentUsername => CurrentUser?.Username;

		public SkyFrostModule(SkyFrostInterface cloud)
		{
			Cloud = cloud;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
	public delegate void ApiAuthenticator(ResoniteBridge.ResoniteBridgeValue request, System.String totpCode);
	public delegate MemoryStream MemoryStreamAllocator();
	public class ApiClient : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private static ResoniteBridge.ResoniteBridgeValue JSON_MEDIA_TYPE
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "JSON_MEDIA_TYPE"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "JSON_MEDIA_TYPE", value);
			}
		}

		private static ResoniteBridge.ResoniteBridgeValue PATCH_METHOD
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "PATCH_METHOD"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "PATCH_METHOD", value);
			}
		}

		private static ResoniteBridge.ResoniteBridgeValue COPY_METHOD
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "COPY_METHOD"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "COPY_METHOD", value);
			}
		}

		public TimeSpan DefaultTimeout
		{
			get
			{
				return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultTimeout"), typeof(TimeSpan));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultTimeout", value);
			}
		}

		public System.Int32 DefaultRetries
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultRetries"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultRetries", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue Client
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Client"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Client", value);
			}
		}

		public System.String ApiBase
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ApiBase"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ApiBase", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue UserAgent
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "UserAgent"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "UserAgent", value);
			}
		}

		public System.String SecretClientAccessKey
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SecretClientAccessKey"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SecretClientAccessKey", value);
			}
		}

		private ApiAuthenticator authenticator
		{
			get
			{
				return (ApiAuthenticator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "authenticator"), typeof(ApiAuthenticator));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "authenticator", value);
			}
		}

		private MemoryStreamAllocator memoryAllocator
		{
			get
			{
				return (MemoryStreamAllocator)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "memoryAllocator"), typeof(MemoryStreamAllocator));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "memoryAllocator", value);
			}
		}

		private Action<string> profilerBeginSampleCallback
		{
			get
			{
				return (Action<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "profilerBeginSampleCallback"), typeof(Action<string>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "profilerBeginSampleCallback", value);
			}
		}

		private Action profilerEndSampleCallback
		{
			get
			{
				return (Action)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "profilerEndSampleCallback"), typeof(Action));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "profilerEndSampleCallback", value);
			}
		}

		public DateTime LastServerResponse
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastServerResponse"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastServerResponse", value);
			}
		}

		public ApiClient(ResoniteBridge.ResoniteBridgeValue client, System.String apiBase, ApiAuthenticator authenticator, ResoniteBridge.ResoniteBridgeValue userAgent, System.String secretClientAccessKey = null, MemoryStreamAllocator memoryAllocator = null, Action<string> profilerBeginSampleCallback = null, Action profilerEndSampleCallback = null)
		{
			Client = client;
			ApiBase = apiBase;
			UserAgent = userAgent;
			SecretClientAccessKey = secretClientAccessKey;
			if (ApiBase != null && ApiBase.EndsWith("/"))
			{
				ApiBase = ApiBase.Substring(0, ApiBase.Length - 1);
			}
			this.authenticator = authenticator;
			this.memoryAllocator = memoryAllocator;
			this.profilerBeginSampleCallback = profilerBeginSampleCallback;
			this.profilerEndSampleCallback = profilerEndSampleCallback;
		}

		[Conditional("PROFILE")]
		private void ProfilerBeginSample(System.String name)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerBeginSample", name);
		}

		[Conditional("PROFILE")]
		private void ProfilerEndSample()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerEndSample");
		}

		public Task<CloudResult<T>> GET<T>(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GET", resource, timeout, throwOnError), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> HEAD<T>(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HEAD", resource, timeout, throwOnError), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> POST<T>(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, System.Boolean throwOnError = true, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST", resource, entity, timeout, totpCode, throwOnError, postprocessRequest), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> POST_File<T>(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_File", resource, filePath, fileMIME, progressIndicator), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> PUT<T>(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> PATCH<T>(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PATCH", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> DELETE<T>(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, System.Boolean throwOnError = true) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DELETE", resource, timeout, totpCode, throwOnError), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult> GET(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GET", resource, timeout, throwOnError), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> HEAD(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HEAD", resource, timeout, throwOnError), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> COPY(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "COPY", resource, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> POST(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST", resource, entity, timeout, totpCode, throwOnError), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> POST_FileMultipart(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_FileMultipart", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> POST_FileDirect(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_FileDirect", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> PUT_FileMultipart(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT_FileMultipart", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> PUT_FileDirect(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT_FileDirect", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> PUT(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT", resource, entity, timeout, throwOnError), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> PATCH(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PATCH", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> DELETE(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocess = null, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DELETE", resource, timeout, totpCode, postprocess, throwOnError), typeof(Task<CloudResult>));
		}

		public ResoniteBridge.ResoniteBridgeValue CreateRequest(System.String resource, ResoniteBridge.ResoniteBridgeValue method, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocess = null)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateRequest", resource, method, totpCode, postprocess), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public ResoniteBridge.ResoniteBridgeValue CreateRequest(ResoniteBridge.ResoniteBridgeValue resource, System.Boolean authenticate, ResoniteBridge.ResoniteBridgeValue method, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocess = null)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateRequest", resource, authenticate, method, totpCode, postprocess), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public void AddFileToRequest(ResoniteBridge.ResoniteBridgeValue request, System.String filePath, System.String mime = null, ResoniteBridge.ResoniteBridgeValue progressIndicator)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddFileToRequest", request, filePath, mime, progressIndicator);
		}

		public void AddMultipartFileToRequest(ResoniteBridge.ResoniteBridgeValue request, System.String filePath, System.String mime = null, ResoniteBridge.ResoniteBridgeValue progressIndicator)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMultipartFileToRequest", request, filePath, mime, progressIndicator);
		}

		private void AddBody(ResoniteBridge.ResoniteBridgeValue message, System.Object entity)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddBody", message, entity);
		}

		internal async Task<CloudResult> RunRequest(Func<ResoniteBridge.ResoniteBridgeValue> requestSource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunRequest", requestSource, timeout, throwOnError), typeof(Task<CloudResult>));
		}

		internal async Task<CloudResult<T>> RunRequest<T>(Func<ResoniteBridge.ResoniteBridgeValue> requestSource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError) where T : class
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunRequest", requestSource, timeout, throwOnError), typeof(Task<CloudResult<T>>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public ApiClient(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public enum GatherJobState
	{
		Waiting,
		Initiating,
		Gathering,
		Finished,
		Failed
	}
	public abstract class AssetGatherer : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public const System.Int32 DEFAULT_CONCURRENT_DOWNLOADS = 8;

		public const System.Int32 DEFAULT_MAX_ATTEMPTS = 5;

		public System.Int32 BufferSize = 32768;

		public System.Int32 MaximumAttempts = 5;

		public System.String TemporaryPath;

		private ResoniteBridge.ResoniteBridgeValue buffers = new Stack<byte[]>();

		private System.Int64 _totalBytesPerSecond;

		private DateTime _lastSpeedUpdate;

		private System.Int64 _speedAccumulatedBytes;

		private System.Object _speedLock = new object();

		public SkyFrostInterface Cloud { get; private set; }

		public System.Int64 TotalBytesPerSecond
		{
			get
			{
				BytesDownloaded(0L);
				return _totalBytesPerSecond;
			}
		}

		public AssetGatherer(SkyFrostInterface cloud)
		{
			if (cloud == null)
			{
				throw new ArgumentNullException("cloud");
			}
			Cloud = cloud;
		}

		internal byte[] BorrowBuffer()
		{
			lock (buffers)
			{
				while (buffers.Count > 0)
				{
					byte[] array = buffers.Pop();
					if (array.Length == BufferSize)
					{
						return array;
					}
				}
				return new byte[BufferSize];
			}
		}

		internal void ReturnBuffer(byte[] buffer)
		{
			if (buffer.Length != BufferSize)
			{
				return;
			}
			lock (buffers)
			{
				buffers.Push(buffer);
			}
		}

		internal void BytesDownloaded(System.Int64 bytes)
		{
			lock (_speedLock)
			{
				_speedAccumulatedBytes += bytes;
				DateTime utcNow = DateTime.UtcNow;
				TimeSpan timeSpan = utcNow - _lastSpeedUpdate;
				if (timeSpan.TotalSeconds >= 1.0)
				{
					_totalBytesPerSecond = (System.Int32)((System.Double)_speedAccumulatedBytes / timeSpan.TotalSeconds);
					_lastSpeedUpdate = utcNow;
					_speedAccumulatedBytes = 0L;
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
	}
	public class AssetGatherer<G> : AssetGatherer, ResoniteBridge.ResoniteBridgeValueHolder where G : GatherJob, new()
	{
		private Dictionary<object, ResoniteBridge.ResoniteBridgeValue> processors
		{
			get
			{
				return (Dictionary<object, ResoniteBridge.ResoniteBridgeValue>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "processors"), typeof(Dictionary<object, ResoniteBridge.ResoniteBridgeValue>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "processors", value);
			}
		}

		private Dictionary<object, List<G>> waitingJobs
		{
			get
			{
				return (Dictionary<object, List<G>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "waitingJobs"), typeof(Dictionary<object, List<G>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "waitingJobs", value);
			}
		}

		private Dictionary<ResoniteBridge.ResoniteBridgeValue, G> jobs
		{
			get
			{
				return (Dictionary<ResoniteBridge.ResoniteBridgeValue, G>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "jobs"), typeof(Dictionary<ResoniteBridge.ResoniteBridgeValue, G>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "jobs", value);
			}
		}

		private List<G> activeJobs
		{
			get
			{
				return (List<G>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "activeJobs"), typeof(List<G>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "activeJobs", value);
			}
		}

		public System.Int32 ActiveJobCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveJobCount"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ActiveJobCount", value);
			}
		}

		public AssetGatherer(SkyFrostInterface cloud)
			: base(cloud)
		{
		}

		private async Task ProcessJob(System.Object category)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessJob", category), typeof(Task));
		}

		public void SetCategoryParallelism(System.Object category, System.Int32 concurrentJobs)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetCategoryParallelism", category, concurrentJobs);
		}

		private ResoniteBridge.ResoniteBridgeValue SetCategoryParallelismIntern(System.Object category, System.Int32 concurrentJobs)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetCategoryParallelismIntern", category, concurrentJobs), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public G Gather(ResoniteBridge.ResoniteBridgeValue url, System.Single priority = 0f, Action<G> initialize = null)
		{
			return (G)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Gather", url, priority, initialize), typeof(G));
		}

		public void GetActiveJobs(List<G> list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetActiveJobs", list);
		}

		public void GetAllJobs(List<G> list)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAllJobs", list);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetGatherer(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class BatchQuery<Query, Result> : ResoniteBridge.ResoniteBridgeValueHolder where Query : class, IEquatable<Query> where Result : class
	{
		protected class QueryResult : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public Query query
			{
				get
				{
					return (Query)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "query"), typeof(Query));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "query", value);
				}
			}

			public Result result
			{
				get
				{
					return (Result)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "result"), typeof(Result));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "result", value);
				}
			}

			public QueryResult(Query query)
			{
				this.query = query;
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
				get
				{
					return __backing;
				}
				set
				{
					__backing = value;
				}
			}

			public QueryResult(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}
		}

		private System.Object _lock = new object();

		private Dictionary<Query, TaskCompletionSource<Result>> queue = new Dictionary<Query, TaskCompletionSource<Result>>();

		private TaskCompletionSource<bool> immediateDispatch;

		private volatile System.Boolean dispatchScheduled;

		public System.Int32 MaxBatchSize { get; set; } = 32;


		public System.Single DelaySeconds { get; set; } = 0.25f;


		public BatchQuery(System.Int32 maxBatchSize = 32, System.Single delaySeconds = 0.25f)
		{
			MaxBatchSize = maxBatchSize;
			DelaySeconds = delaySeconds;
		}

		public async Task<Result> Request(Query query)
		{
			TaskCompletionSource<Result> value = null;
			lock (_lock)
			{
				if (!queue.TryGetValue(query, out value))
				{
					value = new TaskCompletionSource<Result>();
					queue.Add(query, value);
					if (!dispatchScheduled)
					{
						dispatchScheduled = true;
						immediateDispatch = new TaskCompletionSource<bool>();
						Task.Run(async delegate
						{
							try
							{
								await SendBatch().ConfigureAwait(continueOnCapturedContext: false);
							}
							catch (Exception arg)
							{
								UniLog.Error($"Exception when sending metadata batch query of type {typeof(Query)} with result {typeof(Result)}\n" + $"{arg}");
							}
						});
					}
					else if (queue.Count >= MaxBatchSize)
					{
						immediateDispatch.TrySetResult(result: true);
					}
				}
			}
			return await value.Task.ConfigureAwait(continueOnCapturedContext: false);
		}

		private async Task SendBatch()
		{
			await Task.WhenAny(new Task[2]
			{
				immediateDispatch.Task,
				Task.Delay(TimeSpan.FromSeconds(DelaySeconds))
			}).ConfigureAwait(continueOnCapturedContext: false);
			List<QueryResult> toSend = Pool.BorrowList<QueryResult>();
			lock (_lock)
			{
				foreach (KeyValuePair<Query, TaskCompletionSource<Result>> item in queue)
				{
					toSend.Add(new QueryResult(item.Key));
					if (toSend.Count == MaxBatchSize)
					{
						break;
					}
				}
			}
			Exception exception = null;
			try
			{
				if (toSend.Count > 0)
				{
					await RunBatch(toSend).ConfigureAwait(continueOnCapturedContext: false);
				}
			}
			catch (Exception ex)
			{
				UniLog.Error($"Exception running batch for metadata {typeof(Result)}\n{ex}");
				exception = ex;
			}
			lock (_lock)
			{
				foreach (QueryResult item2 in toSend)
				{
					if (exception != null)
					{
						queue[item2.query].SetException(exception);
					}
					else
					{
						queue[item2.query].SetResult(item2.result);
					}
					queue.Remove(item2.query);
				}
				if (queue.Count > 0)
				{
					if (queue.Count >= MaxBatchSize)
					{
						immediateDispatch.TrySetResult(result: true);
					}
					else
					{
						immediateDispatch = new TaskCompletionSource<bool>();
					}
					Task.Run((ResoniteBridge.ResoniteBridgeValue)SendBatch);
				}
				else
				{
					dispatchScheduled = false;
				}
			}
		}

		protected abstract Task RunBatch(List<QueryResult> batch);

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
	public class CloudResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ResoniteBridge.ResoniteBridgeValue State
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue Headers
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Headers"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Headers", value);
			}
		}

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

		public System.Int64 ContentLength
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContentLength"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContentLength", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue LastModified
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastModified"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastModified", value);
			}
		}

		public System.Int32 RequestAttempts
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequestAttempts"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RequestAttempts", value);
			}
		}

		public System.Boolean IsOK
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsOK"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsOK", value);
			}
		}

		public System.Boolean IsError => !IsOK;

		public CloudResult(ResoniteBridge.ResoniteBridgeValue state, ResoniteBridge.ResoniteBridgeValue headers, System.Int32 requestAttempts, System.String content, System.String contentType = null, System.Int64 contentSize = null, ResoniteBridge.ResoniteBridgeValue lastModified)
		{
			State = state;
			RequestAttempts = requestAttempts;
			Content = content;
			Headers = headers;
			ContentType = contentType;
			ContentLength = contentSize;
			LastModified = lastModified;
			if (IsError && content != null)
			{
				try
				{
					Content = JsonConvert.DeserializeObject<CloudMessage>(content)?.Message;
				}
				catch
				{
					Content = content;
				}
			}
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public System.String TryGetHeaderValue(System.String name)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetHeaderValue", name), typeof(System.String));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class CloudResult<T> : CloudResult, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.Boolean IsSensitive
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudResult", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSensitive"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudResult", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSensitive", value);
			}
		}

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

		static CloudResult()
		{
			IsSensitive = typeof(T).GetCustomAttribute<SensitiveEntityAttribute>() != null;
		}

		public CloudResult(T result, CloudResult sourceEntity)
			: this(result, sourceEntity.State, sourceEntity.Headers, sourceEntity.RequestAttempts, sourceEntity.Content, sourceEntity.ContentType, sourceEntity.ContentLength, sourceEntity.LastModified)
		{
		}

		public CloudResult(T result, ResoniteBridge.ResoniteBridgeValue state, ResoniteBridge.ResoniteBridgeValue headers, System.Int32 requestAttempts, System.String content = null, System.String contentType = null, System.Int64 contentLength = null, ResoniteBridge.ResoniteBridgeValue lastModified)
			: base(state, headers, requestAttempts, content, contentType, contentLength, lastModified)
		{
			Entity = result;
		}

		public CloudResult<E> AsResult<E>() where E : class
		{
			return (CloudResult<E>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AsResult"), typeof(CloudResult<E>));
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

		public CloudResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class GatherJob : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.Object DEFAULT_CATEGORY
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "GatherJob", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CATEGORY"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "GatherJob", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CATEGORY", value);
			}
		}

		private TaskCompletionSource<ResoniteBridge.ResoniteBridgeValue> _taskSource
		{
			get
			{
				return (TaskCompletionSource<ResoniteBridge.ResoniteBridgeValue>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_taskSource"), typeof(TaskCompletionSource<ResoniteBridge.ResoniteBridgeValue>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_taskSource", value);
			}
		}

		private DateTime _lastSpeedUpdate
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastSpeedUpdate"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastSpeedUpdate", value);
			}
		}

		private System.Int64 _speedAccumulatedBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_speedAccumulatedBytes"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_speedAccumulatedBytes", value);
			}
		}

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

		public AssetGatherer Gatherer
		{
			get
			{
				return (AssetGatherer)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Gatherer"), typeof(AssetGatherer));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Gatherer", value);
			}
		}

		public virtual System.Object CategoryKey => DEFAULT_CATEGORY;

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

		public GatherJobState State
		{
			get
			{
				return (GatherJobState)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(GatherJobState));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue StatusCode
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StatusCode"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StatusCode", value);
			}
		}

		public System.Single Priority
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Priority"), typeof(System.Single));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Priority", value);
			}
		}

		public System.String FilePath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FilePath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FilePath", value);
			}
		}

		public System.String Error
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Error"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Error", value);
			}
		}

		public Exception Exception
		{
			get
			{
				return (Exception)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Exception"), typeof(Exception));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Exception", value);
			}
		}

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

		public System.Int64 DownloadedBytes
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DownloadedBytes"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DownloadedBytes", value);
			}
		}

		public System.Int32 BytesPerSecond
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesPerSecond"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesPerSecond", value);
			}
		}

		public System.Int32 AttemptsLeft
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AttemptsLeft"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AttemptsLeft", value);
			}
		}

		public System.Boolean Active
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Active"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Active", value);
			}
		}

		public System.Boolean Completed
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Completed"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Completed", value);
			}
		}

		public DB_Endpoint AppDB_Endpoint
		{
			get
			{
				return (DB_Endpoint)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppDB_Endpoint"), typeof(DB_Endpoint));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AppDB_Endpoint", value);
			}
		}

		public DateTime GatheringStarted
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GatheringStarted"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GatheringStarted", value);
			}
		}

		public DateTime GatheringFinished
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GatheringFinished"), typeof(DateTime));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GatheringFinished", value);
			}
		}

		public Task Task => _taskSource.Task;

		public event Action<float> ProgressUpdated;

		internal void Initialize(AssetGatherer gatherer, ResoniteBridge.ResoniteBridgeValue url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", gatherer, url);
		}

		private ResoniteBridge.ResoniteBridgeValue ResolveURL(ResoniteBridge.ResoniteBridgeValue url, DB_Endpoint endpoint)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResolveURL", url, endpoint), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public async Task Download()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Download"), typeof(Task));
		}

		protected void StartGathering()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StartGathering");
		}

		protected void FinishGathering(System.String newFilePath = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishGathering", newFilePath);
		}

		protected void Fail(System.String reason, System.Boolean nonRecoverable, Exception exception = null, ResoniteBridge.ResoniteBridgeValue statusCode)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Fail", reason, nonRecoverable, exception, statusCode);
		}

		protected void AddDownloadedBytes(System.Int64 delta)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddDownloadedBytes", delta);
		}

		protected void UpdateBytes(System.Int64 total, System.Int64 received)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBytes", total, received);
		}

		protected virtual async Task RunDownload()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunDownload"), typeof(Task));
		}

		protected virtual Task<string> FinishGather()
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishGather"), typeof(Task<string>));
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

		public GatherJob(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GatherJob()
		{
		}
	}
	public class InfiniteRetryPolicy : IRetryPolicy, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public TimeSpan[] Intervals
		{
			get
			{
				return (TimeSpan[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Intervals"), typeof(TimeSpan[]));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Intervals", value);
			}
		}

		public InfiniteRetryPolicy(params int[] secondIntervals)
		{
			Intervals = secondIntervals.Select((System.Int32 s) => TimeSpan.FromSeconds((System.Double)s)).ToArray();
		}

		public InfiniteRetryPolicy(params TimeSpan[] intervals)
		{
			Intervals = intervals;
		}

		public ResoniteBridge.ResoniteBridgeValue NextRetryDelay(ResoniteBridge.ResoniteBridgeValue retryContext)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NextRetryDelay", retryContext), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public InfiniteRetryPolicy(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class IPAddressExtensions
	{
		public static System.Boolean IsLinkLocalAddress(this ResoniteBridge.ResoniteBridgeValue ipAddress)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "IPAddressExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsLinkLocalAddress", ipAddress), typeof(System.Boolean));
		}
	}
	public class MetadataBatchQuery<M> : BatchQuery<string, M>, ResoniteBridge.ResoniteBridgeValueHolder where M : class, IAssetMetadata, new()
	{
		private AssetInterface assetInterface
		{
			get
			{
				return (AssetInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetInterface"), typeof(AssetInterface));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetInterface", value);
			}
		}

		public MetadataBatchQuery(SkyFrostInterface cloud)
			: base(32, 0.25f)
		{
			assetInterface = cloud.Assets;
		}

		protected override async Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public MetadataBatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class RecordBatchQuery<R> : BatchQuery<RecordId, R>, ResoniteBridge.ResoniteBridgeValueHolder where R : class, IRecord, new()
	{
		private RecordsManager records
		{
			get
			{
				return (RecordsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "records"), typeof(RecordsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "records", value);
			}
		}

		public RecordBatchQuery(SkyFrostInterface cloud)
			: base(32, 0.25f)
		{
			records = cloud.Records;
		}

		public RecordBatchQuery(RecordsManager records)
			: base(32, 0.25f)
		{
			this.records = records;
		}

		protected override async Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordBatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class RecordCache<TRecord> : ResoniteBridge.ResoniteBridgeValueHolder where TRecord : class, IRecord, new()
	{
		private Dictionary<RecordId, TRecord> cached
		{
			get
			{
				return (Dictionary<RecordId, TRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cached"), typeof(Dictionary<RecordId, TRecord>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cached", value);
			}
		}

		public RecordsManager Records
		{
			get
			{
				return (RecordsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Records"), typeof(RecordsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Records", value);
			}
		}

		public RecordCache(RecordsManager records)
		{
			Records = records;
		}

		public RecordCache(SkyFrostInterface cloud)
		{
			Records = cloud.Records;
		}

		public Task<TRecord> Get(System.String ownerId, System.String recordId)
		{
			return (Task<TRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Get", ownerId, recordId), typeof(Task<TRecord>));
		}

		public async Task<TRecord> Get(RecordId recordId)
		{
			return (Task<TRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Get", recordId), typeof(Task<TRecord>));
		}

		public void Cache(TRecord record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Cache", record);
		}

		public void Cache(IEnumerable<TRecord> records)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Cache", records);
		}

		private RecordId GetKey(IRecord record)
		{
			return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetKey", record), typeof(RecordId));
		}

		private void CacheIntern(RecordId key, TRecord record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CacheIntern", key, record);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordCache(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class RecordSearch<R> : ResoniteBridge.ResoniteBridgeValueHolder where R : class, IRecord, new()
	{
		public System.Int32 DEFAULT_BATCH_SIZE
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DEFAULT_BATCH_SIZE"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DEFAULT_BATCH_SIZE", value);
			}
		}

		public System.Int32 BatchSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BatchSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BatchSize", value);
			}
		}

		private SearchParameters searchParameters
		{
			get
			{
				return (SearchParameters)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "searchParameters"), typeof(SearchParameters));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "searchParameters", value);
			}
		}

		private RecordsManager recordsManager
		{
			get
			{
				return (RecordsManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "recordsManager"), typeof(RecordsManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "recordsManager", value);
			}
		}

		private System.Boolean cache
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cache"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cache", value);
			}
		}

		public List<R> Records
		{
			get
			{
				return (List<R>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Records"), typeof(List<R>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Records", value);
			}
		}

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

		public System.Boolean EqualsParameters(SearchParameters other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EqualsParameters", other), typeof(System.Boolean));
		}

		public RecordSearch(SearchParameters searchParameters, SkyFrostInterface cloud, System.Boolean cache = true)
		{
			this.searchParameters = searchParameters;
			recordsManager = cloud.Records;
			this.cache = cache;
			Records = new List<R>();
			HasMoreResults = true;
		}

		public async ValueTask GetResultsSlice(System.Int32 offset, System.Int32 count, List<R> results, System.Int32 attempts = 5, System.Boolean throwOnError = true)
		{
			return (ValueTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResultsSlice", offset, count, results, attempts, throwOnError), typeof(ValueTask));
		}

		public async ValueTask<bool> EnsureResults(System.Int32 count, System.Int32 attempts = 5, System.Boolean throwOnError = true, System.Int32 delayMilliseconds = 250, ResoniteBridge.ResoniteBridgeValue timeout)
		{
			return (ValueTask<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureResults", count, attempts, throwOnError, delayMilliseconds, timeout), typeof(ValueTask<bool>));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordSearch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct AssetData : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ResoniteBridge.ResoniteBridgeValue url
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "url"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "url", value);
			}
		}

		public Stream stream
		{
			get
			{
				return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stream"), typeof(Stream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stream", value);
			}
		}

		public AssetData(ResoniteBridge.ResoniteBridgeValue url)
		{
			this.url = url;
			stream = null;
		}

		public AssetData(Stream stream)
		{
			this.stream = stream;
			url = null;
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public static implicit operator AssetData(Stream stream)
		{
			return new AssetData(stream);
		}

		public static implicit operator AssetData(ResoniteBridge.ResoniteBridgeValue url)
		{
			return new AssetData(url);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public abstract class RecordUploadTaskBase<R> : ResoniteBridge.ResoniteBridgeValueHolder where R : class, IRecord, new()
	{
		public enum FailureScope
		{
			Record,
			Owner,
			Global
		}

		public class AssetUploadData : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public ResoniteBridge.ResoniteBridgeValue appDBURL
			{
				get
				{
					return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "appDBURL"), typeof(ResoniteBridge.ResoniteBridgeValue));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "appDBURL", value);
				}
			}

			public System.Int64 bytes
			{
				get
				{
					return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "bytes"), typeof(System.Int64));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "bytes", value);
				}
			}

			public System.String appDBSig
			{
				get
				{
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "appDBSig"), typeof(System.String));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "appDBSig", value);
				}
			}

			public AssetInfo cloudInfo
			{
				get
				{
					return (AssetInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cloudInfo"), typeof(AssetInfo));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cloudInfo", value);
				}
			}

			public System.String localFile
			{
				get
				{
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localFile"), typeof(System.String));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "localFile", value);
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

			public AssetUploadData()
			{
			}
		}

		protected static System.Boolean LOG_PROGRESS;

		private System.String _stageDescription;

		private System.Single preprocessProgress;

		private TaskCompletionSource<bool> _completionSource = new TaskCompletionSource<bool>();

		public SkyFrostInterface Cloud { get; private set; }

		public System.Boolean IsFinished { get; private set; }

		public System.Boolean Failed { get; private set; }

		public System.String FailReason { get; private set; }

		public System.Boolean WasAlreadySynced { get; private set; }

		public System.Single Progress
		{
			get
			{
				float num = preprocessProgress * 0.1f;
				if (BytesToUpload > 0)
				{
					num += (System.Single)BytesUploaded / (System.Single)BytesToUpload * 0.9f;
				}
				return num;
			}
		}

		public System.String StageDescription
		{
			get
			{
				return _stageDescription;
			}
			set
			{
				if (LOG_PROGRESS)
				{
					UniLog.Log($"RecordSync {Record?.CombinedRecordId} Stage: " + value);
				}
				_stageDescription = value;
			}
		}

		public System.Int64 BytesToUpload { get; private set; }

		public System.Int64 BytesUploaded { get; private set; }

		public System.Int64 AssetsToUpload { get; private set; }

		public System.Int64 AssetsUploaded { get; private set; }

		public Task Task => _completionSource.Task;

		public R Record { get; private set; }

		public System.Boolean EnsureFolder { get; private set; }

		public List<AssetDiff> AssetDiffs { get; private set; }

		public System.Boolean ForceConflictSync { get; set; }

		public event Action<AssetDiff> AssetToUploadAdded;

		public event Action<long> BytesUploadedAdded;

		public event Action AssetUploaded;

		public event Action<string> AssetMissing;

		protected abstract Task<bool> PrepareFilesForUpload(CancellationToken cancellationToken);

		protected abstract Task StoreSyncedRecord(R record);

		protected abstract ValueTask<AssetData> ReadFile(System.String signature);

		protected virtual ValueTask UploadStarted(System.String signature)
		{
			return default(ValueTask);
		}

		public RecordUploadTaskBase(SkyFrostInterface cloud, R record, System.Boolean ensureFolder = true)
		{
			Cloud = cloud;
			Record = record.Clone<R>();
			EnsureFolder = ensureFolder;
		}

		protected void Fail(System.String error)
		{
			UniLog.Error($"Failed sync for {Record.OwnerId}:{Record.RecordId}. Local: {Record.Version.LocalVersion}, Global: {Record.Version.GlobalVersion}:\n" + error);
			Failed = true;
			FailReason = error;
			IsFinished = true;
		}

		protected void FailConflict()
		{
			Fail("Conflict");
		}

		private void RemoveManifestDuplicates()
		{
			if (Record.AssetManifest == null)
			{
				return;
			}
			HashSet<string> hashSet = Pool.BorrowHashSet<string>();
			for (int num = Record.AssetManifest.Count - 1; num >= 0; num--)
			{
				if (!hashSet.Add(Record.AssetManifest[num].Hash))
				{
					Record.AssetManifest.RemoveAt(num);
				}
			}
			Pool.Return(ref hashSet);
		}

		private async Task EnsureManifestAssetSizes()
		{
			if (Record.AssetManifest == null)
			{
				return;
			}
			foreach (DBAsset dbAsset in Record.AssetManifest)
			{
				if (dbAsset.Bytes <= 0)
				{
					CloudResult<AssetInfo> cloudResult = await Cloud.Assets.GetGlobalAssetInfo(dbAsset.Hash).ConfigureAwait(continueOnCapturedContext: false);
					if (cloudResult.IsOK)
					{
						dbAsset.Bytes = cloudResult.Entity.Bytes;
					}
					else
					{
						UniLog.Warning($"Failed getting asset info for asset with 0 byte size: {dbAsset.Hash}\n{cloudResult}");
					}
				}
			}
		}

		public Task RunUpload(CancellationToken cancellationToken)
		{
			try
			{
				return Task.Run(async delegate
				{
					try
					{
						await RunUploadInternal(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
						_completionSource.SetResult(IsFinished);
					}
					catch (Exception ex2)
					{
						UniLog.Error("Exception during record upload task:\n" + ex2);
						Fail("Exception during sync.");
						_completionSource.SetException(ex2);
					}
				});
			}
			catch (Exception ex)
			{
				UniLog.Error("Exception during record upload task:\n" + ex);
				Fail("Exception during sync.");
				_completionSource.SetResult(result: false);
				return Task.CompletedTask;
			}
		}

		private async Task<bool> CheckCloudVersion(CancellationToken cancelationToken)
		{
			if (cancelationToken.IsCancellationRequested)
			{
				Fail("Record upload task cancelled");
				return false;
			}
			UniLog.Log($"Starting sync for {Record.OwnerId}:{Record.RecordId}. Local: {Record.Version.LocalVersion}, Global: {Record.Version.GlobalVersion}");
			StageDescription = "Starting record upload task";
			CloudResult<R> cloudResult = await Cloud.Records.GetRecord<R>(Record.OwnerId, Record.RecordId, null, includeDeleted: true).ConfigureAwait(continueOnCapturedContext: false);
			if (cancelationToken.IsCancellationRequested)
			{
				Fail("Record upload task cancelled");
				return false;
			}
			if (Record.RecordId == "R-SettingsData")
			{
				ForceConflictSync = true;
			}
			if (cloudResult.IsOK)
			{
				R entity = cloudResult.Entity;
				if (Record.IsSameVersion(entity))
				{
					if (LOG_PROGRESS)
					{
						UniLog.Log($"RecordSync {Record?.CombinedRecordId}, Same version, skipping upload");
					}
					await StoreSyncedRecord(entity);
					IsFinished = true;
					WasAlreadySynced = true;
					return false;
				}
				if (!Record.CanOverwrite(entity))
				{
					UniLog.Log("Conflict! Cloud Record: " + JsonConvert.SerializeObject(entity) + "\n\nLocal record: " + JsonConvert.SerializeObject(Record));
					if (entity.IsDeleted && Record.Version.GlobalVersion == 0)
					{
						UniLog.Log("Cloud Record has been deleted and local version is completely new - considering this as replacement.");
						ForceConflictSync = true;
					}
					if (!ForceConflictSync)
					{
						FailConflict();
						return false;
					}
					UniLog.Log("Forcing synchronization");
					try
					{
						Record.OverrideGlobalVersion(entity.Version.GlobalVersion);
						if (Record.Version.LastModifyingUserId == entity.Version.LastModifyingUserId && Record.Version.LastModifyingMachineId == entity.Version.LastModifyingMachineId)
						{
							RecordVersion version = Record.Version;
							version.LocalVersion = entity.Version.LocalVersion + 1;
							Record.Version = version;
						}
					}
					catch (Exception ex)
					{
						Fail(ex.Message);
						return false;
					}
				}
			}
			return true;
		}

		protected abstract Task<bool> PrepareRecord(CancellationToken cancelationToken);

		private async Task<bool> PreprocessRecord(CancellationToken cancelationToken)
		{
			string lastFailReason = null;
			for (int attempt = 0; attempt < 10; attempt++)
			{
				StageDescription = $"Preprocessing record, Assets: {Record.AssetManifest?.Count ?? 0}. Attempt: {attempt}";
				preprocessProgress = 0f;
				UniLog.Log("Preprocessing record: " + Record.OwnerId + ":" + Record.RecordId);
				CloudResult<RecordPreprocessStatus> preprocessStatus = await Cloud.Records.PreprocessRecord(Record).ConfigureAwait(continueOnCapturedContext: false);
				if (cancelationToken.IsCancellationRequested)
				{
					Fail("Record upload task cancelled");
					return false;
				}
				if (preprocessStatus.Entity == null)
				{
					Fail(preprocessStatus.State.ToString() + " - " + preprocessStatus.Content);
					return false;
				}
				while (preprocessStatus.IsOK && preprocessStatus.Entity.State == RecordPreprocessState.Preprocessing)
				{
					preprocessProgress = preprocessStatus.Entity.Progress;
					StageDescription = $"Waiting for preprocess to finish: {preprocessProgress * 100f:F2}. Attempt: {attempt}";
					await Task.Delay(1000, cancelationToken).ConfigureAwait(continueOnCapturedContext: false);
					if (cancelationToken.IsCancellationRequested)
					{
						Fail("Record upload task cancelled");
						return false;
					}
					preprocessStatus = await Cloud.Records.GetPreprocessStatus(preprocessStatus.Entity).ConfigureAwait(continueOnCapturedContext: false);
				}
				preprocessProgress = 1f;
				StageDescription = $"Handling preprocess result: {preprocessStatus}. Attempt: {attempt}";
				if (preprocessStatus.IsError || preprocessStatus.Entity == null)
				{
					Fail("Record preprocessing failed: " + preprocessStatus.State.ToString() + " - " + preprocessStatus.Content);
					return false;
				}
				if (preprocessStatus.Entity.State != RecordPreprocessState.Failed)
				{
					AssetDiffs = preprocessStatus.Entity.ResultDiffs;
					return true;
				}
				lastFailReason = (StageDescription = "Record preprocessing failed. PreprocessId: " + preprocessStatus.Entity.PreprocessId + ", RecordId:" + preprocessStatus.Entity.RecordId + ", Fail Reason: " + preprocessStatus.Entity.FailReason);
				if (preprocessStatus.Entity.FailReason == null || !preprocessStatus.Entity.FailReason.Contains("TooManyRequests"))
				{
					Fail(lastFailReason);
					return false;
				}
				await Task.Delay(TimeSpan.FromSeconds((System.Single)attempt * 2f)).ConfigureAwait(continueOnCapturedContext: false);
			}
			Fail("Record preprocessing failed after all attempts: " + lastFailReason);
			return false;
		}

		private async Task<bool> UploadAssets(CancellationToken cancelationToken)
		{
			StageDescription = "Uploading assets";
			if (!(await PrepareFilesForUpload(cancelationToken).ConfigureAwait(continueOnCapturedContext: false)))
			{
				return false;
			}
			StageDescription = "Collecting upload information";
			foreach (AssetDiff assetDiff in AssetDiffs)
			{
				if (assetDiff.IsUploaded == false)
				{
					AssetsToUpload++;
					BytesToUpload += assetDiff.Bytes;
					this.AssetToUploadAdded?.Invoke(assetDiff);
				}
			}
			StageDescription = "Scheduling uploads";
			List<AssetUploadTask> assetUploads = new List<AssetUploadTask>();
			foreach (AssetDiff diff in AssetDiffs)
			{
				if (diff.IsUploaded != false)
				{
					continue;
				}
				long uploadedBefore = BytesUploaded;
				long uploadedBytes = 0L;
				CallbackProgressIndicator progressIndicator = new CallbackProgressIndicator(delegate(System.Single percent, ResoniteBridge.ResoniteBridgeValue info, ResoniteBridge.ResoniteBridgeValue detailInfo)
				{
					long num = (System.Int64)((System.Single)diff.Bytes * percent);
					long obj = num - uploadedBytes;
					BytesUploaded = uploadedBefore + num;
					this.BytesUploadedAdded?.Invoke(obj);
				}, null, null);
				string _hash = diff.Hash.ToLowerInvariant();
				AssetData fileData = await ReadFile(_hash).ConfigureAwait(continueOnCapturedContext: false);
				try
				{
					if (LOG_PROGRESS)
					{
						UniLog.Log($"RecordSync {Record?.CombinedRecordId}, Uploading {diff.Hash} - {UnitFormatting.FormatBytes(diff.Bytes)}");
					}
					AssetUploadTask uploadTask = ((fileData.stream == null) ? Cloud.Assets.CreateURLAssetUploadTask(Record.OwnerId, diff.Hash, null, fileData.url, progressIndicator, diff.Bytes) : Cloud.Assets.CreateStreamAssetUploadTask(Record.OwnerId, diff.Hash, null, fileData.stream, progressIndicator, diff.Bytes));
					CloudResult<SkyFrost.Base.AssetUploadData> uploadResult = await uploadTask.UploadAssetData().ConfigureAwait(continueOnCapturedContext: false);
					await UploadStarted(_hash).ConfigureAwait(continueOnCapturedContext: false);
					if (cancelationToken.IsCancellationRequested)
					{
						Fail("Record upload task cancelled");
						return false;
					}
					if (uploadResult.IsError)
					{
						if (uploadResult.State == HttpStatusCode.NotFound)
						{
							UniLog.Log($"Asset missing: {uploadTask.Signature} - {uploadTask.UploadData?.Entity} - {uploadResult.Content}");
							this.AssetMissing?.Invoke(uploadTask.Signature);
						}
						else
						{
							if (uploadResult.Content != "AlreadyUploaded")
							{
								Fail("Couldn't upload asset " + diff.Hash + ": " + uploadResult.State.ToString() + " - " + uploadResult.Content);
								return false;
							}
							this.AssetUploaded?.Invoke();
						}
					}
					else
					{
						this.AssetUploaded?.Invoke();
						assetUploads.Add(uploadTask);
					}
				}
				finally
				{
					((IDisposable)fileData).Dispose();
				}
				BytesUploaded = uploadedBefore + diff.Bytes;
			}
			foreach (AssetUploadTask uploadTask in assetUploads)
			{
				CloudResult<SkyFrost.Base.AssetUploadData> cloudResult = await uploadTask.WaitForAssetFinishProcessing().ConfigureAwait(continueOnCapturedContext: false);
				if (cloudResult.IsError)
				{
					if (cloudResult.State != HttpStatusCode.NotFound)
					{
						if (cloudResult.Content.StartsWith("MissingAllRequiredChunks") && uploadTask.UploadData?.Entity != null)
						{
							Fail("MissingAllRequiredChunks\n" + System.Text.Json.JsonSerializer.Serialize(uploadTask.UploadData.Entity));
							return false;
						}
						Fail($"Couldn't upload asset {uploadTask.Signature} - {uploadTask.UploadData?.Entity}: {cloudResult.State} - {cloudResult.Content}");
						return false;
					}
					UniLog.Log($"Asset missing: {uploadTask.Signature} - {uploadTask.UploadData?.Entity} - {cloudResult.Content}");
					this.AssetMissing?.Invoke(uploadTask.Signature);
				}
				else
				{
					AssetsUploaded++;
				}
			}
			return true;
		}

		private async Task<bool> UpsertRecord(CancellationToken cancelationToken)
		{
			StageDescription = "Upserting Record";
			CloudResult<CloudMessage> cloudResult = await Cloud.Records.UpsertRecord(Record, EnsureFolder).ConfigureAwait(continueOnCapturedContext: false);
			if (cancelationToken.IsCancellationRequested)
			{
				Fail("Record upload task cancelled");
				return false;
			}
			StageDescription = "Finishing";
			if (!cloudResult.IsOK)
			{
				Fail("UpsertResult State: " + cloudResult.State.ToString() + "\nContent:\n" + cloudResult.Content);
				return false;
			}
			await StoreSyncedRecord(Record).ConfigureAwait(continueOnCapturedContext: false);
			IsFinished = true;
			StageDescription = "Finished Record Upload";
			UniLog.Log($"Finished sync for {Record.CombinedRecordId}. Local: {Record.Version.LocalVersion}, Global: {Record.Version.GlobalVersion}");
			return true;
		}

		private async Task RunUploadInternal(CancellationToken cancelationToken)
		{
			if (await CheckCloudVersion(cancelationToken).ConfigureAwait(continueOnCapturedContext: false) && await PrepareRecord(cancelationToken).ConfigureAwait(continueOnCapturedContext: false))
			{
				RemoveManifestDuplicates();
				if (await PreprocessRecord(cancelationToken).ConfigureAwait(continueOnCapturedContext: false) && await UploadAssets(cancelationToken).ConfigureAwait(continueOnCapturedContext: false))
				{
					await EnsureManifestAssetSizes().ConfigureAwait(continueOnCapturedContext: false);
					await UpsertRecord(cancelationToken).ConfigureAwait(continueOnCapturedContext: false);
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
	}
	public static class SearchQueryParser
	{
		public static void Parse(System.String search, List<string> optionalTags, List<string> requiredTags, List<string> excludedTags)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SearchQueryParser", ResoniteBridge.ResoniteBridgeValueType.Type), "Parse", search, optionalTags, requiredTags, excludedTags);
		}
	}
	public struct CloudVariableInfo : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String subpath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "subpath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "subpath", value);
			}
		}

		public System.String type
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "type", value);
			}
		}

		public System.String defaultValue
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultValue"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultValue", value);
			}
		}

		public CloudVariableInfo(System.String path, System.String type, System.String defaultValue)
		{
			subpath = path;
			this.type = type;
			this.defaultValue = defaultValue;
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public CloudVariableInfo(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class SettingsCloudVariables
	{
		public static CloudVariableInfo LAST_MUTE_STATUS => new CloudVariableInfo("Profile.LastMuteStatus", "bool", false.ToString());

		public static CloudVariableInfo LAST_ONLINE_STATUS => new CloudVariableInfo("Profile.LastOnlineStatus", "string", OnlineStatus.Online.ToString());

		public static ResoniteBridge.ResoniteBridgeValue DEFAULT_DASH_OFFSET
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DASH_OFFSET"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DASH_OFFSET", value);
			}
		}

		public static CloudVariableInfo DASH_OFFSET => new CloudVariableInfo("Userspace.RadiantDash.Offset", "float3", DEFAULT_DASH_OFFSET.ToString());

		public static CloudVariableInfo DASH_SCALE => new CloudVariableInfo("Userspace.RadiantDash.Scale", "float3", float3.One.ToString());

		public static CloudVariableInfo DASH_FREEFORM => new CloudVariableInfo("Userspace.RadiantDash.Freeform", "bool", "false");

		public static IEnumerable<CloudVariableInfo> AllSettings
		{
			get
			{
				return (IEnumerable<CloudVariableInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "AllSettings"), typeof(IEnumerable<CloudVariableInfo>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "AllSettings", value);
			}
		}
	}
	public class SignalRWebSocket : WebSocket, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private ResoniteBridge.ResoniteBridgeValue _client
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_client"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_client", value);
			}
		}

		public override ResoniteBridge.ResoniteBridgeValue CloseStatus => _client.CloseStatus;

		public override System.String CloseStatusDescription => _client.CloseStatusDescription;

		public override System.String SubProtocol => _client.SubProtocol;

		public override ResoniteBridge.ResoniteBridgeValue State => _client.State;

		public static async Task<SignalRWebSocket> Create(ResoniteBridge.ResoniteBridgeValue context, CancellationToken cancellationToken)
		{
			return (Task<SignalRWebSocket>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SignalRWebSocket", ResoniteBridge.ResoniteBridgeValueType.Type), "Create", context, cancellationToken), typeof(Task<SignalRWebSocket>));
		}

		public SignalRWebSocket()
		{
			_client = new System.Net.WebSockets.Managed.ClientWebSocket();
		}

		public async Task Connect(ResoniteBridge.ResoniteBridgeValue uri, ResoniteBridge.ResoniteBridgeValue options, CancellationToken token)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Connect", uri, options, token), typeof(Task));
		}

		public override void Abort()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Abort");
		}

		public override Task CloseAsync(ResoniteBridge.ResoniteBridgeValue closeStatus, System.String statusDescription, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloseAsync", closeStatus, statusDescription, cancellationToken), typeof(Task));
		}

		public override Task CloseOutputAsync(ResoniteBridge.ResoniteBridgeValue closeStatus, System.String statusDescription, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloseOutputAsync", closeStatus, statusDescription, cancellationToken), typeof(Task));
		}

		public override void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public override async Task<ResoniteBridge.ResoniteBridgeValue> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return (Task<ResoniteBridge.ResoniteBridgeValue>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveAsync", buffer, cancellationToken), typeof(Task<ResoniteBridge.ResoniteBridgeValue>));
		}

		public override async Task SendAsync(ArraySegment<byte> buffer, ResoniteBridge.ResoniteBridgeValue messageType, System.Boolean endOfMessage, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendAsync", buffer, messageType, endOfMessage, cancellationToken), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SignalRWebSocket(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class TemporaryUtility
	{
		public static System.String FilterViveportUsername(System.String username)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "TemporaryUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "FilterViveportUsername", username), typeof(System.String));
		}
	}
	public static class UID
	{
		public static System.String Compute()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UID", ResoniteBridge.ResoniteBridgeValueType.Type), "Compute"), typeof(System.String));
		}
	}
	public class VariableReadBatchQuery : BatchQuery<VariableReadRequest, VariableReadResult<CloudVariable, CloudVariableDefinition>>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private CloudVariableManager variables
		{
			get
			{
				return (CloudVariableManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "variables"), typeof(CloudVariableManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "variables", value);
			}
		}

		public VariableReadBatchQuery(CloudVariableManager variables)
			: base(32, 0.25f)
		{
			if (variables == null)
			{
				throw new ArgumentNullException("variables");
			}
			this.variables = variables;
			base.DelaySeconds = 1f;
		}

		protected override async Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public VariableReadBatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class VariableWriteBatchQuery : BatchQuery<CloudVariable, CloudVariable>, ResoniteBridge.ResoniteBridgeValueHolder
	{
		private CloudVariableManager variables
		{
			get
			{
				return (CloudVariableManager)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "variables"), typeof(CloudVariableManager));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "variables", value);
			}
		}

		public VariableWriteBatchQuery(CloudVariableManager variables)
			: base(32, 0.25f)
		{
			if (variables == null)
			{
				throw new ArgumentNullException("variables");
			}
			this.variables = variables;
			base.DelaySeconds = 5f;
		}

		protected override async Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public VariableWriteBatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public struct RegistryProxyConfiguration : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.String ProxyOverride
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ProxyOverride"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ProxyOverride", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue ProxyServer
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ProxyServer"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ProxyServer", value);
			}
		}

		public RegistryProxyConfiguration(ResoniteBridge.ResoniteBridgeValue proxyServer, System.String proxyOverride)
		{
			ProxyOverride = proxyOverride ?? string.Empty;
			ProxyServer = proxyServer;
		}

		public static RegistryProxyConfiguration From(System.String proxyServer = "", System.String proxyOverride = "")
		{
			return (RegistryProxyConfiguration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RegistryProxyConfiguration", ResoniteBridge.ResoniteBridgeValueType.Type), "From", proxyServer, proxyOverride), typeof(RegistryProxyConfiguration));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RegistryProxyConfiguration(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public class WebProxyUtility : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private static ResoniteBridge.ResoniteBridgeValue SetupCredentials(ProxyConfig config)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "SetupCredentials", config), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static ResoniteBridge.ResoniteBridgeValue CreateProxy(ProxyConfig config)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateProxy", config), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static ResoniteBridge.ResoniteBridgeValue MakeAbsolouteProxyAddress(ResoniteBridge.ResoniteBridgeValue uri)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "MakeAbsolouteProxyAddress", uri), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static System.String MakeAbsolouteProxyAddress(System.String str)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "MakeAbsolouteProxyAddress", str), typeof(System.String));
		}

		private static ProxyConfig HydrateProxyConfiguration(ProxyConfig initialConfig)
		{
			return (ProxyConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "HydrateProxyConfiguration", initialConfig), typeof(ProxyConfig));
		}

		private static ProxyConfig GenerateProxySettingsFromDefaultWebProxy(ProxyConfig initialConfig)
		{
			return (ProxyConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateProxySettingsFromDefaultWebProxy", initialConfig), typeof(ProxyConfig));
		}

		private static ResoniteBridge.ResoniteBridgeValue GetProxyConfigFromRegistry()
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GetProxyConfigFromRegistry"), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static ResoniteBridge.ResoniteBridgeValue GenerateProxyConfigFromRegistry(ResoniteBridge.ResoniteBridgeValue registryValues)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateProxyConfigFromRegistry", registryValues), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		private static System.String GetDomainFromProxyOverride(System.String domain)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GetDomainFromProxyOverride", domain), typeof(System.String));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public WebProxyUtility(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public WebProxyUtility()
		{
		}
	}
}
