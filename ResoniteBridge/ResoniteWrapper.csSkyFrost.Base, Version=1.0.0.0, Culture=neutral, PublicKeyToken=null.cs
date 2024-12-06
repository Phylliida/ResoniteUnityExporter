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
using Microsoft.CodeAnalysis;
using Microsoft.Win32;
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

		protected override ValueTask<AssetData> ReadFile(System.String signature)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadFile", signature), typeof(ValueTask<AssetData>)) is ValueTask<AssetData> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask<AssetData>");
			}
		}

		protected override Task<bool> PrepareFilesForUpload(CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrepareFilesForUpload", cancellationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		protected override Task<bool> PrepareRecord(CancellationToken cancelationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrepareRecord", cancelationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		protected override Task StoreSyncedRecord(Record record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreSyncedRecord", record), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public AccountDataStoreUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AccountDataStoreUploadTask()
		{
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

		private void SetProgressMessage(System.String message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetProgressMessage", message);
		}

		private System.Boolean ProcessRecord(Record record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessRecord", record), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private System.Boolean ProcessContact(Contact contact)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessContact", contact), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private System.Boolean ProcessGroup(Group group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessGroup", group), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Task<bool> Transfer(CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Transfer", cancellationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task TransferUserProfileData()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferUserProfileData"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferFundingEvents()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferFundingEvents"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferExitMessages()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferExitMessages"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferOwned(System.String ownerId, RecordMigrationStatus recordsStatus, VariableMigrationStatus variablesStatus, List<string> recordsToMigrate, List<string> variablesToMigrate, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferOwned", ownerId, recordsStatus, variablesStatus, recordsToMigrate, variablesToMigrate, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private Task TrasnferRecordAuditLog(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrasnferRecordAuditLog", ownerId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private Task TransferSelectedRecords(System.String ownerId, RecordMigrationStatus recordsStatus, List<string> recordsToMigrate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferSelectedRecords", ownerId, recordsStatus, recordsToMigrate), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferVariables(System.String ownerId, VariableMigrationStatus status, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferVariables", ownerId, status, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferVariableDefinitions(System.String ownerId, VariableMigrationStatus status, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferVariableDefinitions", ownerId, status, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private RecordStatusCallbacks SetupCallbacks(RecordMigrationStatus status)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetupCallbacks", status), typeof(RecordStatusCallbacks)) is RecordStatusCallbacks __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RecordStatusCallbacks");
			}
		}

		public Task TransferRecords(System.String ownerId, RecordMigrationStatus status, System.Boolean onlyNew, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferRecords", ownerId, status, onlyNew, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferContacts(CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferContacts", cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferMessages(Contact contact, System.String contactId, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferMessages", contact, contactId, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task TransferMembers(Group group, GroupMigrationStatus groupStatus, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferMembers", group, groupStatus, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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

		public AccountTransferController()
		{
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

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
		}

		public System.String UserId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
			}
		}

		public System.String Username
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
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
		}

		public event Action<string> ProgressMessage;

		public System.Int32 FetchedRecordCount(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchedRecordCount", ownerId), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public virtual Task Prepare()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Prepare"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task Complete()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Complete"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task<User> GetUser()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser"), typeof(Task<User>)) is Task<User> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<User>");
			}
		}

		public virtual Task<List<ExitMessage>> GetExitMessages()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExitMessages"), typeof(Task<List<ExitMessage>>)) is Task<List<ExitMessage>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<ExitMessage>>");
			}
		}

		public virtual Task<List<PatreonFundingEvent>> GetPatreonFundingEvents()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<List<PatreonFundingEvent>>)) is Task<List<PatreonFundingEvent>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<PatreonFundingEvent>>");
			}
		}

		public virtual Task<List<Contact>> GetContacts()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<List<Contact>>)) is Task<List<Contact>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<Contact>>");
			}
		}

		public virtual ResoniteBridge.ResoniteBridgeValue GetMessages(System.String contactId, ResoniteBridge.ResoniteBridgeValue from)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", contactId, from), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<Message>");
			}
		}

		public virtual ResoniteBridge.ResoniteBridgeValue GetGroups()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroups"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<GroupData>");
			}
		}

		public virtual Task<List<MemberData>> GetMembers(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMembers", groupId), typeof(Task<List<MemberData>>)) is Task<List<MemberData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<MemberData>>");
			}
		}

		public virtual Task<Record> GetRecord(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId), typeof(Task<Record>)) is Task<Record> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<Record>");
			}
		}

		public virtual ResoniteBridge.ResoniteBridgeValue GetRecords(System.String ownerId, ResoniteBridge.ResoniteBridgeValue from, Action<string> searchProgressReport = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<Record>");
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
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<RecordAuditInfo>");
			}
		}

		private Task<Record> FillRecordDetails(Record r)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FillRecordDetails", r), typeof(Task<Record>)) is Task<Record> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<Record>");
			}
		}

		public virtual Task<List<CloudVariableDefinition>> GetVariableDefinitions(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariableDefinitions", ownerId), typeof(Task<List<CloudVariableDefinition>>)) is Task<List<CloudVariableDefinition>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<CloudVariableDefinition>>");
			}
		}

		public virtual Task<List<CloudVariable>> GetVariables(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariables", ownerId), typeof(Task<List<CloudVariable>>)) is Task<List<CloudVariable>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<CloudVariable>>");
			}
		}

		public virtual Task<CloudVariable> GetVariable(System.String ownerId, System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", ownerId, path), typeof(Task<CloudVariable>)) is Task<CloudVariable> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudVariable>");
			}
		}

		public virtual Task<DateTime> GetLatestMessageTime(System.String contactId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestMessageTime", contactId), typeof(Task<DateTime>)) is Task<DateTime> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<DateTime>");
			}
		}

		public virtual ResoniteBridge.ResoniteBridgeValue GetLatestRecordTime(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestRecordTime", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<DateTime?>");
			}
		}

		public virtual Task StoreDefinitions(List<CloudVariableDefinition> definitions, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreDefinitions", definitions, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task StoreContact(Contact contact, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreContact", contact, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task StoreMessage(Message message, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task StoreVariables(List<CloudVariable> variables, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVariables", variables, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task StoreGroup(Group group, Storage storage, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreGroup", group, storage, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMember", group, member, storage, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task StoreUserData(User user)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreUserData", user), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task StoreFundingEvent(PatreonFundingEvent fundingEvent)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreFundingEvent", fundingEvent), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task StoreRecordAudit(RecordAuditInfo auditInfo)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecordAudit", auditInfo), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task StoreExitMessage(ExitMessage message)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreExitMessage", message), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task<StoreResultData> StoreRecord(Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks, System.Boolean overwriteOnConflict)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecord", record, source, statusCallbacks, overwriteOnConflict), typeof(Task<StoreResultData>)) is Task<StoreResultData> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<StoreResultData>");
			}
		}

		public virtual Task DownloadAsset(System.String hash, System.String targetPath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DownloadAsset", hash, targetPath), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task<long> GetAssetSize(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetSize", hash), typeof(Task<long>)) is Task<long> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<long>");
			}
		}

		public virtual Task<string> GetAsset(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsset", hash), typeof(Task<string>)) is Task<string> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<string>");
			}
		}

		public virtual Task<AssetData> ReadAsset(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadAsset", hash), typeof(Task<AssetData>)) is Task<AssetData> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<AssetData>");
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

		public CloudAccountDataStore(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CloudAccountDataStore()
		{
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

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public StoreResultData()
		{
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

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public GroupData()
		{
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

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public MemberData()
		{
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
	}
	public interface IAccountDataStore : ResoniteBridge.ResoniteBridgeValueHolder
	{
		IPlatformProfile PlatformProfile
		{
			get
			{
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PlatformProfile"), typeof(IPlatformProfile));
			}
		}

		System.String MigrationId
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

		System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
		}

		System.String UserId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
			}
		}

		System.String Username
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Username"), typeof(System.String));
			}
		}

		System.Int32 FetchedGroupCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FetchedGroupCount"), typeof(System.Int32));
			}
		}

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

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

			public AssetJob()
			{
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

		public System.String Name
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Name"), typeof(System.String));
			}
		}

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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchedRecordCount", ownerId), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
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
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task Complete()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Complete"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private void InitDownloadProcessor()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitDownloadProcessor");
		}

		public Task<List<Contact>> GetContacts()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<List<Contact>>)) is Task<List<Contact>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<Contact>>");
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
				throw new InvalidCastException("Cannot cast result to Task<List<ExitMessage>>");
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
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<RecordAuditInfo>");
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
				throw new InvalidCastException("Cannot cast result to Task<User>");
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
				throw new InvalidCastException("Cannot cast result to Task<List<PatreonFundingEvent>>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetMessages(System.String contactId, ResoniteBridge.ResoniteBridgeValue from)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", contactId, from), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<Message>");
			}
		}

		public Task<Record> GetRecord(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId), typeof(Task<Record>)) is Task<Record> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<Record>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecords(System.String ownerId, ResoniteBridge.ResoniteBridgeValue from, Action<string> searchProgressReport = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<Record>");
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
				throw new InvalidCastException("Cannot cast result to Task<List<CloudVariableDefinition>>");
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
				throw new InvalidCastException("Cannot cast result to Task<List<CloudVariable>>");
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
				throw new InvalidCastException("Cannot cast result to Task<CloudVariable>");
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
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<GroupData>");
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
				throw new InvalidCastException("Cannot cast result to Task<List<MemberData>>");
			}
		}

		private Task<List<T>> GetEntities<T>(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEntities", path), typeof(Task<List<T>>)) is Task<List<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<T>>");
			}
		}

		private T GetEntity<T>(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEntity", path), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public Task StoreDefinitions(List<CloudVariableDefinition> definitions, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreDefinitions", definitions, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task StoreVariables(List<CloudVariable> variables, IAccountDataStore source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVariables", variables, source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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
				throw new InvalidCastException("Cannot cast result to Task");
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
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task<StoreResultData> StoreRecord(Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks, System.Boolean overwriteOnConflict)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecord", record, source, statusCallbacks, overwriteOnConflict), typeof(Task<StoreResultData>)) is Task<StoreResultData> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<StoreResultData>");
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
				throw new InvalidCastException("Cannot cast result to Task");
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
				throw new InvalidCastException("Cannot cast result to Task");
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
				throw new InvalidCastException("Cannot cast result to Task");
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
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task StoreFundingEvent(PatreonFundingEvent fundingEvent)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreFundingEvent", fundingEvent), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private Task StoreEntity<T>(T entity, System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreEntity", entity, path), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private System.String UserPath()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserPath"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String PatreonPath()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PatreonPath"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String ExitMessagesPath()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitMessagesPath"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String VariableDefinitionPath(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariableDefinitionPath", ownerId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String VariablePath(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariablePath", ownerId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String ContactsPath(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactsPath", ownerId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String MessagesPath(System.String ownerId, System.String contactId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MessagesPath", ownerId, contactId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String RecordsPath(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordsPath", ownerId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String RecordAuditPath(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordAuditPath", ownerId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String GroupsPath(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GroupsPath", ownerId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String MembersPath(System.String ownerId, System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MembersPath", ownerId, groupId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private System.String GetAssetPath(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetPath", hash), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
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
				throw new InvalidCastException("Cannot cast result to Task<DateTime>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetLatestRecordTime(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestRecordTime", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<DateTime?>");
			}
		}

		private void ScheduleAsset(System.String hash, IAccountDataStore store)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleAsset", hash, store);
		}

		public Task DownloadAsset(System.String hash, System.String targetPath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DownloadAsset", hash, targetPath), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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
				throw new InvalidCastException("Cannot cast result to Task<long>");
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
				throw new InvalidCastException("Cannot cast result to Task<string>");
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
				throw new InvalidCastException("Cannot cast result to Task<AssetData>");
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

			public System.Boolean Equals(MigrationGroup other)
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
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
					throw new InvalidCastException("Cannot cast result to int");
				}
			}

			public static bool operator ==(MigrationGroup left, MigrationGroup right)
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", left, right), typeof(System.Boolean));
			}

			public static bool operator !=(MigrationGroup left, MigrationGroup right)
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", left, right), typeof(System.Boolean));
			}

			private ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

			public MigrationGroup()
			{
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMigrationStrings", from, to), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SortedDictionary<string, string>");
			}
		}

		public static ResoniteBridge.ResoniteBridgeValue MigrateLegacyURL(this ResoniteBridge.ResoniteBridgeValue url, IPlatformProfile to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateLegacyURL", url, to), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public static ResoniteBridge.ResoniteBridgeValue MigrateURL(this ResoniteBridge.ResoniteBridgeValue url, IPlatformProfile from, IPlatformProfile to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateURL", url, from, to), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public static System.String MigrateURL(this System.String str, IPlatformProfile from, IPlatformProfile to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateURL", str, from, to), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String MigrateString(this System.String str, IPlatformProfile from, IPlatformProfile to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateString", str, from, to), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String MigrateSubStrings(this System.String str, IPlatformProfile from, IPlatformProfile to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateSubStrings", str, from, to), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}
	}
	[JsonDerivedType(typeof(CloudflareAssetInterface), "cloudflare")]
	[JsonDerivedType(typeof(AzureAssetInterface), "azure")]
	public abstract class AssetInterface : ResoniteBridge.ResoniteBridgeValueHolder
	{
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
		public ApiClient Api
		{
			get
			{
				return (ApiClient)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient));
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public User CurrentUser
		{
			get
			{
				return (User)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User));
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String CurrentUserID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserID"), typeof(System.String));
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String DBScheme
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DBScheme"), typeof(System.String));
			}
		}

		public void Initialize(SkyFrostInterface cloud)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", cloud);
		}

		public abstract ResoniteBridge.ResoniteBridgeValue DBToHttp(ResoniteBridge.ResoniteBridgeValue productDBUri, DB_Endpoint endpoint);

		public abstract ResoniteBridge.ResoniteBridgeValue ThumbnailToHttp(ThumbnailInfo thumbnail);

		public Task<Stream> GatherAsset(System.String signature)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GatherAsset", signature), typeof(Task<Stream>)) is Task<Stream> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<Stream>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue FilterDatabaseURL(ResoniteBridge.ResoniteBridgeValue assetURL)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FilterDatabaseURL", assetURL), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GenerateURL(System.String signature)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateURL", signature), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GenerateURLWithExtension(System.String signature, System.String extension)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateURLWithExtension", signature, extension), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public System.String DBSignature(ResoniteBridge.ResoniteBridgeValue dbUri, System.Boolean ignoreScheme = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBSignature", dbUri, ignoreScheme), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String DBQuery(ResoniteBridge.ResoniteBridgeValue dbUri)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBQuery", dbUri), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String DBFilename(ResoniteBridge.ResoniteBridgeValue dbUri)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBFilename", dbUri), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.Boolean IsValidDBUri(System.String uri)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidDBUri", uri), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean IsValidDBUri(ResoniteBridge.ResoniteBridgeValue uri)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidDBUri", uri), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean IsLegacyDB(ResoniteBridge.ResoniteBridgeValue uri)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsLegacyDB", uri), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Task<CloudResult<AssetInfo>> GetGlobalAssetInfo(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalAssetInfo", hash), typeof(Task<CloudResult<AssetInfo>>)) is Task<CloudResult<AssetInfo>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetInfo>>");
			}
		}

		public Task<CloudResult<AssetInfo>> GetUserAssetInfo(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserAssetInfo", hash), typeof(Task<CloudResult<AssetInfo>>)) is Task<CloudResult<AssetInfo>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetInfo>>");
			}
		}

		public Task<CloudResult<AssetInfo>> GetAssetInfo(System.String ownerId, System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetInfo", ownerId, hash), typeof(Task<CloudResult<AssetInfo>>)) is Task<CloudResult<AssetInfo>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetInfo>>");
			}
		}

		public Task<bool> IsValidShader(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidShader", hash), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public AssetUploadTask CreateFileAssetUploadTask(System.String ownerId, System.String signature, System.String variant, System.String assetPath, ResoniteBridge.ResoniteBridgeValue progress, System.Int32 retries = 5)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateFileAssetUploadTask", ownerId, signature, variant, assetPath, progress, retries), typeof(AssetUploadTask)) is AssetUploadTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AssetUploadTask");
			}
		}

		public AssetUploadTask CreateStreamAssetUploadTask(System.String ownerId, System.String signature, System.String variant, Stream assetStream, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateStreamAssetUploadTask", ownerId, signature, variant, assetStream, progress, bytes, retries), typeof(AssetUploadTask)) is AssetUploadTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AssetUploadTask");
			}
		}

		public AssetUploadTask CreateURLAssetUploadTask(System.String ownerId, System.String signature, System.String variant, ResoniteBridge.ResoniteBridgeValue assetURL, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateURLAssetUploadTask", ownerId, signature, variant, assetURL, progress, bytes, retries), typeof(AssetUploadTask)) is AssetUploadTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AssetUploadTask");
			}
		}

		public Task<CloudResult> GetAssetMime(ResoniteBridge.ResoniteBridgeValue url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMime", url), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public abstract Task<CloudResult> GetAssetMime(System.String hash);

		public abstract Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String session);

		protected abstract AssetUploadTask CreateEmptyAssetUploadTask();

		public System.String GetAssetBaseURL(System.String ownerId, System.String hash, System.String variant)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetBaseURL", ownerId, hash, variant), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public Task<CloudResult<List<string>>> GetAvailableVariants(ResoniteBridge.ResoniteBridgeValue dbUrl)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAvailableVariants", dbUrl), typeof(Task<CloudResult<List<string>>>)) is Task<CloudResult<List<string>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<string>>>");
			}
		}

		public abstract Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash);

		public Task<CloudResult<List<T>>> GetAssetMetadata<T>(List<string> hashes) where T : class, IAssetMetadata, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMetadata", hashes), typeof(Task<CloudResult<List<T>>>)) is Task<CloudResult<List<T>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<T>>>");
			}
		}

		public Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> GetAssetMetadata(ResoniteBridge.ResoniteBridgeValue variantType, System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMetadata", variantType, hash), typeof(Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>>)) is Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<IAssetMetadata>>");
			}
		}

		public Task<CloudResult<T>> GetAssetMetadata<T>(System.String hash) where T : class, IAssetMetadata, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMetadata", hash), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<List<string>>> RequestAssetVariant(System.String hash, ResoniteBridge.ResoniteBridgeValue descriptor)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestAssetVariant", hash, descriptor), typeof(Task<CloudResult<List<string>>>)) is Task<CloudResult<List<string>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<string>>>");
			}
		}

		public Task<CloudResult> StoreAssetMetadata(ResoniteBridge.ResoniteBridgeValue metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreAssetMetadata", metadata), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> GetBitmapMetadata(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBitmapMetadata", hash), typeof(Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>>)) is Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<BitmapMetadata>>");
			}
		}

		public Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>> GetBitmapMetadata(List<string> hashes)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBitmapMetadata", hashes), typeof(Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>>)) is Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<BitmapMetadata>>>");
			}
		}

		public Task<CloudResult> StoreBitmapMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreBitmapMetadata", hash, metadata), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> GetCubemapMetadata(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCubemapMetadata", hash), typeof(Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>>)) is Task<CloudResult<ResoniteBridge.ResoniteBridgeValue>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<CubemapMetadata>>");
			}
		}

		public Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>> GetCubemapMetadata(List<string> hashes)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCubemapMetadata", hashes), typeof(Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>>)) is Task<CloudResult<List<ResoniteBridge.ResoniteBridgeValue>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<CubemapMetadata>>>");
			}
		}

		public Task<CloudResult> StoreCubemapMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreCubemapMetadata", hash, metadata), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> StoreVolumeMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVolumeMetadata", hash, metadata), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> StoreMeshMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMeshMetadata", hash, metadata), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> StoreShaderMetadata(System.String hash, ResoniteBridge.ResoniteBridgeValue metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreShaderMetadata", hash, metadata), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>> GetAssetComputationTask(System.Boolean usePoisonQueue = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetComputationTask", usePoisonQueue), typeof(Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>>)) is Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>>");
			}
		}

		public Task<CloudResult> ExtendAssetComputationTask(ExternalQueueObject<AssetVariantComputationTask> task)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtendAssetComputationTask", task), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> FinishAssetComputation(ExternalQueueObject<AssetVariantComputationTask> task)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishAssetComputation", task), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> FinishVariantComputation(System.String hash, System.String variantId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishVariantComputation", hash, variantId), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		private static System.String GetMetadataURLSegment(Type type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMetadataURLSegment", type), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
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

		public AssetInterface()
		{
		}
	}
	public abstract class AssetUploadTask : IDisposable, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.Boolean DEBUG_UPLOAD
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_UPLOAD"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_UPLOAD", value);
			}
		}

		protected Stream assetStream
		{
			get
			{
				return (Stream)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetStream"), typeof(Stream));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetStream", value);
			}
		}

		protected System.String assetPath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetPath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetPath", value);
			}
		}

		protected ResoniteBridge.ResoniteBridgeValue assetURL
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetURL"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetURL", value);
			}
		}

		protected System.String assetFileName
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetFileName"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetFileName", value);
			}
		}

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

		public ApiClient Api
		{
			get
			{
				return (ApiClient)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient));
			}
		}

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

		public System.Int32 Retries
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Retries"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Retries", value);
			}
		}

		public System.Boolean IsOptional
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsOptional"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsOptional", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue Progress
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Progress"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Progress", value);
			}
		}

		public CloudResult<AssetUploadData> UploadData
		{
			get
			{
				return (CloudResult<AssetUploadData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadData"), typeof(CloudResult<AssetUploadData>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadData", value);
			}
		}

		public System.Boolean UploadStarted
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadStarted"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadStarted", value);
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

		public System.Int32 EnqueuedChunks
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EnqueuedChunks"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EnqueuedChunks", value);
			}
		}

		public System.Int32 UploadedChunks
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadedChunks"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadedChunks", value);
			}
		}

		public abstract System.Int32 MaxParallelChunks { get; }

		public void InitializeWithFile(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, System.String assetPath, ResoniteBridge.ResoniteBridgeValue progress, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeWithFile", cloud, ownerId, signature, variant, assetPath, progress, retries);
		}

		public void InitializeWithStream(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, Stream assetStream, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeWithStream", cloud, ownerId, signature, variant, assetStream, progress, bytes, retries);
		}

		public void InitializeWithURL(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, ResoniteBridge.ResoniteBridgeValue url, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeWithURL", cloud, ownerId, signature, variant, url, progress, bytes, retries);
		}

		private void Initialize(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, System.String assetPath, Stream assetStream, ResoniteBridge.ResoniteBridgeValue assetURL, ResoniteBridge.ResoniteBridgeValue progress, System.Int64 bytes = null, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", cloud, ownerId, signature, variant, assetPath, assetStream, assetURL, progress, bytes, retries);
		}

		public Task<CloudResult<AssetUploadData>> RunUpload()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunUpload"), typeof(Task<CloudResult<AssetUploadData>>)) is Task<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetUploadData>>");
			}
		}

		public abstract Task<CloudResult<AssetUploadData>> UploadAssetData();

		public abstract ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing();

		protected virtual void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		protected void DisposeOfStream()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DisposeOfStream");
		}

		public virtual void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetUploadTask()
		{
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
					return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "data"), typeof(byte[]));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "data", value);
				}
			}

			public Task<CloudResult<TChunkResult>> task
			{
				get
				{
					return (Task<CloudResult<TChunkResult>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "task"), typeof(Task<CloudResult<TChunkResult>>));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "task", value);
				}
			}

			public System.Int32 chunk
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "chunk"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "chunk", value);
				}
			}

			public System.Int32 length
			{
				get
				{
					return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "length"), typeof(System.Int32));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "length", value);
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
		}

		private void EnqueueChunk(UploadChunkBuffer buffer, List<UploadChunkBuffer> processingBuffers)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnqueueChunk", buffer, processingBuffers);
		}

		private Task<UploadChunkBuffer> TakeFinishedBuffer(List<UploadChunkBuffer> buffers)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TakeFinishedBuffer", buffers), typeof(Task<UploadChunkBuffer>)) is Task<UploadChunkBuffer> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<UploadChunkBuffer>");
			}
		}

		public override Task<CloudResult<AssetUploadData>> UploadAssetData()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadAssetData"), typeof(Task<CloudResult<AssetUploadData>>)) is Task<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetUploadData>>");
			}
		}

		private Task<CloudResult<AssetUploadData>> Upload()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Upload"), typeof(Task<CloudResult<AssetUploadData>>)) is Task<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetUploadData>>");
			}
		}

		protected abstract Task<CloudResult<AssetUploadData>> InitiateUpload();

		protected virtual Task UploadInitiated(AssetUploadData data)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadInitiated", data), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		protected abstract ResoniteBridge.ResoniteBridgeValue CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length);

		protected abstract void ProcessChunkUploadResult(System.Int32 chunkIndex, TChunkResult result);

		protected abstract Task<CloudResult> FinalizeChunkUpload();

		protected ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing(System.String apiUrl)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing", apiUrl), typeof(ValueTask<CloudResult<AssetUploadData>>)) is ValueTask<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask<CloudResult<AssetUploadData>>");
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

		public AssetUploadTask()
		{
		}
	}
	public static class AssetUtil
	{
		public static System.Int32 COMPUTE_VERSION
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "COMPUTE_VERSION"), typeof(System.Int32));
			}
		}

		public static System.String GenerateHashSignature(System.String file)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateHashSignature", file), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String GenerateHashSignature(Stream fileStream)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateHashSignature", fileStream), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String ComposeIdentifier(System.String signature, System.String variant)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "ComposeIdentifier", signature, variant), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
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
		public System.String AssetsEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsEndpoint"), typeof(System.String));
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String InstallsEndpoint
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InstallsEndpoint"), typeof(System.String));
			}
		}

		public override ResoniteBridge.ResoniteBridgeValue DBToHttp(ResoniteBridge.ResoniteBridgeValue productDBUri, DB_Endpoint endpoint)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBToHttp", productDBUri, endpoint), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public override ResoniteBridge.ResoniteBridgeValue ThumbnailToHttp(ThumbnailInfo thumbnail)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailToHttp", thumbnail), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue ThumbnailIdToHttp(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailIdToHttp", id), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		protected override AssetUploadTask CreateEmptyAssetUploadTask()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateEmptyAssetUploadTask"), typeof(AssetUploadTask)) is AssetUploadTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AssetUploadTask");
			}
		}

		public override Task<CloudResult> GetAssetMime(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMime", hash), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public override Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String session)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadThumbnail", path, session), typeof(Task<CloudResult<ThumbnailInfo>>)) is Task<CloudResult<ThumbnailInfo>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<ThumbnailInfo>>");
			}
		}

		public override Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAvailableVariants", hash), typeof(Task<CloudResult<List<string>>>)) is Task<CloudResult<List<string>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<string>>>");
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

		public AzureAssetInterface(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AzureAssetInterface()
		{
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

		public override System.Int32 MaxParallelChunks
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxParallelChunks"), typeof(System.Int32));
			}
		}

		protected override void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		protected override Task<CloudResult<AssetUploadData>> InitiateUpload()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitiateUpload"), typeof(Task<CloudResult<AssetUploadData>>)) is Task<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetUploadData>>");
			}
		}

		protected override ResoniteBridge.ResoniteBridgeValue CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateChunkUploadRequest", chunkIndex, data, length), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to HttpRequestMessage");
			}
		}

		protected override Task<CloudResult> FinalizeChunkUpload()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeChunkUpload"), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		protected override void ProcessChunkUploadResult(System.Int32 chunkIndex, CloudMessage result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessChunkUploadResult", chunkIndex, result);
		}

		public override ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing"), typeof(ValueTask<CloudResult<AssetUploadData>>)) is ValueTask<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask<CloudResult<AssetUploadData>>");
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

		public AzureAssetUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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

		public override ResoniteBridge.ResoniteBridgeValue DBToHttp(ResoniteBridge.ResoniteBridgeValue dbUri, DB_Endpoint endpoint)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBToHttp", dbUri, endpoint), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public override ResoniteBridge.ResoniteBridgeValue ThumbnailToHttp(ThumbnailInfo thumbnail)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailToHttp", thumbnail), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public Task<CloudResult<BlobMetadata>> GetAssetMedata(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMedata", hash), typeof(Task<CloudResult<BlobMetadata>>)) is Task<CloudResult<BlobMetadata>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<BlobMetadata>>");
			}
		}

		public override Task<CloudResult> GetAssetMime(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMime", hash), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public override Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAvailableVariants", hash), typeof(Task<CloudResult<List<string>>>)) is Task<CloudResult<List<string>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<string>>>");
			}
		}

		public override Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadThumbnail", path, sessionId), typeof(Task<CloudResult<ThumbnailInfo>>)) is Task<CloudResult<ThumbnailInfo>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<ThumbnailInfo>>");
			}
		}

		protected override AssetUploadTask CreateEmptyAssetUploadTask()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateEmptyAssetUploadTask"), typeof(AssetUploadTask)) is AssetUploadTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AssetUploadTask");
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

		public CloudflareAssetInterface(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CloudflareAssetInterface()
		{
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

		public override System.Int32 MaxParallelChunks
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxParallelChunks"), typeof(System.Int32));
			}
		}

		protected override void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		protected override Task UploadInitiated(AssetUploadData data)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadInitiated", data), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		protected override ResoniteBridge.ResoniteBridgeValue CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateChunkUploadRequest", chunkIndex, data, length), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to HttpRequestMessage");
			}
		}

		protected override Task<CloudResult<AssetUploadData>> InitiateUpload()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitiateUpload"), typeof(Task<CloudResult<AssetUploadData>>)) is Task<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AssetUploadData>>");
			}
		}

		protected override Task<CloudResult> FinalizeChunkUpload()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeChunkUpload"), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		protected override void ProcessChunkUploadResult(System.Int32 chunkIndex, CloudflareChunkResult result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessChunkUploadResult", chunkIndex, result);
		}

		public override ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing"), typeof(ValueTask<CloudResult<AssetUploadData>>)) is ValueTask<CloudResult<AssetUploadData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask<CloudResult<AssetUploadData>>");
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

		public CloudflareAssetUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "LegacyAssetMap", ResoniteBridge.ResoniteBridgeValueType.Type), "MapLegacySignature", signature), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
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

		public override System.Boolean Equals(System.Object obj)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", obj), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean Equals(CloudVariableIdentity other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				throw new InvalidCastException("Cannot cast result to int");
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
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static bool operator ==(CloudVariableIdentity left, CloudVariableIdentity right)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableIdentity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", left, right), typeof(System.Boolean));
		}

		public static bool operator !=(CloudVariableIdentity left, CloudVariableIdentity right)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableIdentity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", left, right), typeof(System.Boolean));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public CloudVariableIdentity()
		{
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

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public TimestampedCloudVariable()
		{
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadVariable", ownerId, path), typeof(Task<VariableReadResult<CloudVariable, CloudVariableDefinition>>)) is Task<VariableReadResult<CloudVariable, CloudVariableDefinition>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<VariableReadResult<CloudVariable, CloudVariableDefinition>>");
			}
		}

		internal Task<CloudVariable> WriteVariable(CloudVariable variable)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteVariable", variable), typeof(Task<CloudVariable>)) is Task<CloudVariable> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudVariable>");
			}
		}

		internal void RegisterChanged(CloudVariableProxy proxies)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterChanged", proxies);
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public void SignIn()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignIn");
		}

		public Task SignOut()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task SaveAllChangedVariables()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SaveAllChangedVariables"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public CloudVariableProxy RequestProxy(System.String ownerId, System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestProxy", ownerId, path), typeof(CloudVariableProxy)) is CloudVariableProxy __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CloudVariableProxy");
			}
		}

		public CloudVariableProxy RegisterListener(System.String ownerId, System.String path, CloudVariableEventHandler onChanged)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", ownerId, path, onChanged), typeof(CloudVariableProxy)) is CloudVariableProxy __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CloudVariableProxy");
			}
		}

		internal System.Boolean TryUnregisterProxy(CloudVariableProxy proxy)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryUnregisterProxy", proxy), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Task<CloudResult<CloudVariableDefinition>> GetDefinition(System.String ownerId, System.String subpath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefinition", ownerId, subpath), typeof(Task<CloudResult<CloudVariableDefinition>>)) is Task<CloudResult<CloudVariableDefinition>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<CloudVariableDefinition>>");
			}
		}

		public Task<CloudResult<CloudVariableDefinition>> UpsertDefinition(CloudVariableDefinition definition)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertDefinition", definition), typeof(Task<CloudResult<CloudVariableDefinition>>)) is Task<CloudResult<CloudVariableDefinition>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<CloudVariableDefinition>>");
			}
		}

		public Task<CloudResult> DeleteDefinition(System.String ownerId, System.String subpath)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteDefinition", ownerId, subpath), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<T>> ReadGlobal<T>(System.String path, System.String variableType)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadGlobal", path, variableType), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<CloudVariable>> Get(System.String ownerId, System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Get", ownerId, path), typeof(Task<CloudResult<CloudVariable>>)) is Task<CloudResult<CloudVariable>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<CloudVariable>>");
			}
		}

		public Task<CloudResult<TimestampedCloudVariable<T>>> ReadWithTimestamp<T>(System.String ownerId, System.String path, System.String variableType = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadWithTimestamp", ownerId, path, variableType), typeof(Task<CloudResult<TimestampedCloudVariable<T>>>)) is Task<CloudResult<TimestampedCloudVariable<T>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<TimestampedCloudVariable<T>>>");
			}
		}

		public Task<CloudResult<T>> Read<T>(System.String ownerId, System.String path, System.String variableType = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Read", ownerId, path, variableType), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<List<VariableReadResult<CloudVariable, CloudVariableDefinition>>>> ReadBatch(List<VariableReadRequest> batch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadBatch", batch), typeof(Task<CloudResult<List<VariableReadResult<CloudVariable, CloudVariableDefinition>>>>)) is Task<CloudResult<List<VariableReadResult<CloudVariable, CloudVariableDefinition>>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<VariableReadResult<CloudVariable, CloudVariableDefinition>>>>");
			}
		}

		public Task<CloudResult<List<CloudVariable>>> GetAllByOwner(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAllByOwner", ownerId), typeof(Task<CloudResult<List<CloudVariable>>>)) is Task<CloudResult<List<CloudVariable>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<CloudVariable>>>");
			}
		}

		public Task<CloudResult<List<CloudVariableDefinition>>> ListDefinitions(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListDefinitions", ownerId), typeof(Task<CloudResult<List<CloudVariableDefinition>>>)) is Task<CloudResult<List<CloudVariableDefinition>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<CloudVariableDefinition>>>");
			}
		}

		public Task<CloudResult<List<CloudVariable>>> WriteBatch(List<CloudVariable> batch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteBatch", batch), typeof(Task<CloudResult<List<CloudVariable>>>)) is Task<CloudResult<List<CloudVariable>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<CloudVariable>>>");
			}
		}

		public Task<CloudResult> Write<T>(System.String ownerId, System.String path, T value, System.String variableType = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Write", ownerId, path, value, variableType), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> Upsert(CloudVariable variable)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Upsert", variable), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> Delete(System.String ownerId, System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Delete", ownerId, path), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<T>> ReadOwners<T>(System.String path, System.String variableType = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadOwners", path, variableType), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<TimestampedCloudVariable<T>>> ReadOwnersWithTimestamp<T>(System.String path, System.String variableType = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadOwnersWithTimestamp", path, variableType), typeof(Task<CloudResult<TimestampedCloudVariable<T>>>)) is Task<CloudResult<TimestampedCloudVariable<T>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<TimestampedCloudVariable<T>>>");
			}
		}

		public Task<CloudResult> WriteOwners<T>(System.String path, T value, System.String variableType = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteOwners", path, value, variableType), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> Delete(System.String path)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Delete", path), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
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

		public CloudVariableManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CloudVariableManager()
		{
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

		public System.Boolean HasListeners
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasListeners"), typeof(System.Boolean));
			}
		}

		public System.String RawValue
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RawValue"), typeof(System.String));
			}
		}

		public System.Boolean IsDefinitionOwner
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDefinitionOwner"), typeof(System.Boolean));
			}
		}

		public System.Boolean IsVariableOwner
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsVariableOwner"), typeof(System.Boolean));
			}
		}

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

		public SkyFrostInterface Cloud
		{
			get
			{
				return (SkyFrostInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface));
			}
		}

		private event CloudVariableEventHandler _valueChanged;

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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteToCloud"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Task ForceWriteToCloud()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceWriteToCloud"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task Refresh()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Refresh"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private System.Boolean CanAccessInPublic(List<string> permissions)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPublic", permissions), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private System.Boolean CanAccessInPrivate(List<string> permissions)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPrivate", permissions), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private System.Boolean CanAccessInPrivate(System.String perm)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPrivate", perm), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public T ReadValue<T>()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadValue"), typeof(T)) is T __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to T");
			}
		}

		public System.Boolean SetValue(System.String value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Boolean SetValue<T>(T value)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetValue", value), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
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

		public CloudVariableProxy()
		{
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

		private CancellationToken Token
		{
			get
			{
				return (CancellationToken)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(CancellationToken));
			}
		}

		private System.Boolean IsClosed
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsClosed"), typeof(System.Boolean));
			}
		}

		public void Disconnect()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Disconnect");
		}

		private ValueTask EnsureConnectedHub()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureConnectedHub"), typeof(ValueTask)) is ValueTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask");
			}
		}

		public Task Pong(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Pong", index), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task Debug(System.String message)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Debug", message), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task Ping(System.Int32 index)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Ping", index), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task SendMessage(Message message)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendMessage", message), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task MarkMessagesRead(MarkReadBatch markReadBatch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkMessagesRead", markReadBatch), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task BroadcastStatus(UserStatus status, BroadcastTarget target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastStatus", status, target), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task<bool> UpdateContact(Contact contact)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContact", contact), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task ListenOnContact(System.String contactId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenOnContact", contactId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task ListenOnKey(System.String broadcastKey)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenOnKey", broadcastKey), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task RequestStatus(System.String userId = null, System.Boolean invisible = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestStatus", userId, invisible), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task<StatusInitializationResult> InitializeStatus()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeStatus"), typeof(Task<StatusInitializationResult>)) is Task<StatusInitializationResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<StatusInitializationResult>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue InitializeContacts(CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeContacts", cancellationToken), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<Contact>");
			}
		}

		public Task BroadcastSession(SessionInfo session, BroadcastTarget target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastSession", session, target), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task BroadcastSessionEnded(System.String sessionId, DateTime timestamp, BroadcastTarget target)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastSessionEnded", sessionId, timestamp, target), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task ListenForLNLPokeRequests(System.String universeId, System.String connectionUrl)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenForLNLPokeRequests", universeId, connectionUrl), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task RequestLNLPoke(System.String universeId, System.String connectionUrl, System.String address, System.Int32 port)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestLNLPoke", universeId, connectionUrl, address, port), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public AppHub(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AppHub()
		{
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

		public System.Boolean Initializing
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Initializing"), typeof(System.Boolean));
			}
		}

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

		public Task SignOut()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task ReceiveStatusUpdate(UserStatus status)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveStatusUpdate", status), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task SendStatusToUser(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendStatusToUser", userId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task ContactAddedOrUpdated(Contact contact)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactAddedOrUpdated", contact), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task KeyListenerAdded(System.String broadcastKey, System.String connectionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "KeyListenerAdded", broadcastKey, connectionId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private ValueTask WaitForInitialized()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForInitialized"), typeof(ValueTask)) is ValueTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask");
			}
		}

		public Task ReceiveSessionUpdate(SessionInfo info)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveSessionUpdate", info), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task RemoveSession(System.String sessionId, DateTime timestamp)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveSession", sessionId, timestamp), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public HubStatusController(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public HubStatusController()
		{
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
		System.Boolean HasUniverse
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasUniverse"), typeof(System.Boolean));
			}
		}

		System.String UniverseId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(System.String));
			}
		}

		System.Boolean AcceptSession(SessionInfo sessionInfo);
	}
	public interface IUserStatusSource : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean LoadingOnlineStatus
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadingOnlineStatus"), typeof(System.Boolean));
			}
		}

		System.String AppVersion
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppVersion"), typeof(System.String));
			}
		}

		System.Boolean IsMobile
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMobile"), typeof(System.Boolean));
			}
		}

		UserSessionType SessionType
		{
			get
			{
				return (UserSessionType)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionType"), typeof(UserSessionType));
			}
		}

		System.Boolean IsUserPresent
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUserPresent"), typeof(System.Boolean));
			}
		}

		DateTime LastPresenceTimestamp
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPresenceTimestamp"), typeof(DateTime));
			}
		}

		ResoniteBridge.ResoniteBridgeValue OutputDevice
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDevice"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
		}

		DateTime LastSessionChangeTimestamp
		{
			get
			{
				return (DateTime)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastSessionChangeTimestamp"), typeof(DateTime));
			}
		}

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

		public Task<CloudResult<List<SamlIdentityProvider>>> GetSamlProviders(System.String universeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSamlProviders", universeId), typeof(Task<CloudResult<List<SamlIdentityProvider>>>)) is Task<CloudResult<List<SamlIdentityProvider>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<SamlIdentityProvider>>>");
			}
		}

		public Task Initialize(System.String universeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", universeId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task<CloudResult<Universe>> GetUniverse(System.String universeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUniverse", universeId), typeof(Task<CloudResult<Universe>>)) is Task<CloudResult<Universe>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Universe>>");
			}
		}

		private Task UpdateCurrentUniverse(System.String universeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUniverse", universeId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public AppsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AppsManager()
		{
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

		public Task<CloudResult<BadgeDefinition>> GetBadge(System.String ownerId, System.String badgeId, System.Boolean allowCache = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBadge", ownerId, badgeId, allowCache), typeof(Task<CloudResult<BadgeDefinition>>)) is Task<CloudResult<BadgeDefinition>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<BadgeDefinition>>");
			}
		}

		public Task<CloudResult> UpdateBadge(BadgeDefinition badge)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBadge", badge), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
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

		public BadgeManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public BadgeManager()
		{
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

		public SkyFrostInterface Cloud
		{
			get
			{
				return (SkyFrostInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface));
			}
		}

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

		public System.String UserId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String));
			}
		}

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

		public UserStatus GetStatus(System.String userSessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStatus", userSessionId), typeof(UserStatus)) is UserStatus __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UserStatus");
			}
		}

		public void DecodeSessions(HashSet<SessionInfo> infos, List<UserSessionMetadata> undecoded = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DecodeSessions", infos, undecoded);
		}

		internal System.Boolean UpdateStatus(UserStatus status)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStatus", status), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal System.Boolean ClearExpired()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearExpired"), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private void UpdateAggregate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateAggregate");
		}

		internal System.Boolean TryMatchNewSession(SessionInfo info)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryMatchNewSession", info), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal System.Boolean TryUpdateSession(SessionInfo info)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryUpdateSession", info), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		internal System.Boolean TryRemoveSession(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryRemoveSession", sessionId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		private UserStatus GetDefaultStatus()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultStatus"), typeof(UserStatus)) is UserStatus __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UserStatus");
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

		public ContactData(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContactData()
		{
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

		public System.Int32 ContactCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactCount"), typeof(System.Int32));
			}
		}

		public event Action<ContactData> ContactAdded;

		public event Action<ContactData> ContactUpdated;

		public event Action<ContactData> ContactRemoved;

		public event Action<int> ContactRequestCountChanged;

		public event Action<ContactData> ContactStatusChanged;

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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContact", contactId), typeof(Contact)) is Contact __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Contact");
			}
		}

		public UserStatus GetContactSession(System.String contactId, System.String userSessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContactSession", contactId, userSessionId), typeof(UserStatus)) is UserStatus __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UserStatus");
			}
		}

		public Contact FindContact(Predicate<Contact> predicate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindContact", predicate), typeof(Contact)) is Contact __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Contact");
			}
		}

		public System.Boolean IsContact(System.String userId, System.Boolean mutuallyAccepted = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsContact", userId, mutuallyAccepted), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public System.Int32 CountPresentContacts(SessionInfo session)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CountPresentContacts", session), typeof(System.Int32)) is System.Int32 __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to int");
			}
		}

		public Task<bool> AddContact(System.String contactId, System.String contactName)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddContact", contactId, contactName), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task<bool> AddContact(Contact contact)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddContact", contact), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task<bool> RemoveContact(Contact contact)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveContact", contact), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task<bool> IgnoreRequest(Contact contact)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IgnoreRequest", contact), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		private Task<bool> UpdateContact(Contact contact)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContact", contact), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<CloudResult<List<Contact>>>)) is Task<CloudResult<List<Contact>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Contact>>>");
			}
		}

		public Task<CloudResult<List<Contact>>> GetContacts(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts", userId), typeof(Task<CloudResult<List<Contact>>>)) is Task<CloudResult<List<Contact>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Contact>>>");
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

		public ContactManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ContactManager()
		{
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

		public IEnumerable<Membership> CurrentUserMemberships
		{
			get
			{
				return (IEnumerable<Membership>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserMemberships"), typeof(IEnumerable<Membership>));
			}
		}

		public IEnumerable<Member> CurrentUserMemberInfos
		{
			get
			{
				return (IEnumerable<Member>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserMemberInfos"), typeof(IEnumerable<Member>));
			}
		}

		public event Action<IEnumerable<Membership>> MembershipsUpdated;

		public event Action<Group> GroupUpdated;

		public event Action<Member> GroupMemberUpdated;

		public void GetCurrentGroups(List<Group> groups)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCurrentGroups", groups);
		}

		public Group TryGetCurrentUserGroupInfo(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetCurrentUserGroupInfo", groupId), typeof(Group)) is Group __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Group");
			}
		}

		public Member TryGetCurrentUserGroupMemberInfo(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetCurrentUserGroupMemberInfo", groupId), typeof(Member)) is Member __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Member");
			}
		}

		public Storage TryGetGroupStorage(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetGroupStorage", groupId), typeof(Storage)) is Storage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Storage");
			}
		}

		public Storage TryGetMemberStorage(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetMemberStorage", groupId), typeof(Storage)) is Storage __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Storage");
			}
		}

		public System.Boolean IsCurrentUserMemberOfGroup(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsCurrentUserMemberOfGroup", groupId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Membership TryGetCurrentUserGroupMembership(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetCurrentUserGroupMembership", groupId), typeof(Membership)) is Membership __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Membership");
			}
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

		private Task RunMembershipsUpdated()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunMembershipsUpdated"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task<CloudResult<Group>> GetGroup(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroup", groupId), typeof(Task<CloudResult<Group>>)) is Task<CloudResult<Group>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Group>>");
			}
		}

		public Task<CloudResult<Group>> GetGroupCached(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupCached", groupId), typeof(Task<CloudResult<Group>>)) is Task<CloudResult<Group>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Group>>");
			}
		}

		public Task<CloudResult<Group>> CreateGroup(Group group)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateGroup", group), typeof(Task<CloudResult<Group>>)) is Task<CloudResult<Group>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Group>>");
			}
		}

		public Task<CloudResult> AddGroupMember(Member member, System.Int64 quota = -1L)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddGroupMember", member, quota), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> DeleteGroupMember(Member member)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteGroupMember", member), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<Member>> GetGroupMember(System.String groupId, System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupMember", groupId, userId), typeof(Task<CloudResult<Member>>)) is Task<CloudResult<Member>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Member>>");
			}
		}

		public Task<CloudResult<List<Member>>> GetGroupMembers(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupMembers", groupId), typeof(Task<CloudResult<List<Member>>>)) is Task<CloudResult<List<Member>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Member>>>");
			}
		}

		public Task<CloudResult> UpdateCurrentUserMemberships()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserMemberships"), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<List<Membership>>> GetUserGroupMemeberships()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserGroupMemeberships"), typeof(Task<CloudResult<List<Membership>>>)) is Task<CloudResult<List<Membership>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Membership>>>");
			}
		}

		public Task<CloudResult<List<Membership>>> GetUserGroupMemeberships(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserGroupMemeberships", userId), typeof(Task<CloudResult<List<Membership>>>)) is Task<CloudResult<List<Membership>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Membership>>>");
			}
		}

		public Task UpdateGroupInfo(System.String groupId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateGroupInfo", groupId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task<CloudResult<Submission>> UpsertSubmission(System.String groupId, System.String ownerId, System.String recordId, System.Boolean feature = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertSubmission", groupId, ownerId, recordId, feature), typeof(Task<CloudResult<Submission>>)) is Task<CloudResult<Submission>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Submission>>");
			}
		}

		public Task<CloudResult> DeleteSubmission(System.String groupId, System.String submissionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteSubmission", groupId, submissionId), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
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

		public GroupsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public GroupsManager()
		{
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

		public Task ReceiveMessage(Message message)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveMessage", message), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MessageSent", message), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task MessagesRead(ReadMessageBatch batch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MessagesRead", batch), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message), typeof(Task<CloudResult<Message>>)) is Task<CloudResult<Message>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Message>>");
			}
		}

		public Task<CloudResult<List<Message>>> GetUnreadMessages(ResoniteBridge.ResoniteBridgeValue fromTime)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnreadMessages", fromTime), typeof(Task<CloudResult<List<Message>>>)) is Task<CloudResult<List<Message>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Message>>>");
			}
		}

		public Task<CloudResult<List<Message>>> GetMessageHistory(System.String user, System.Int32 maxItems = 100)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessageHistory", user, maxItems), typeof(Task<CloudResult<List<Message>>>)) is Task<CloudResult<List<Message>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Message>>>");
			}
		}

		public Task<CloudResult<List<Message>>> GetMessages(ResoniteBridge.ResoniteBridgeValue fromTime, System.Int32 maxItems, System.String user, System.Boolean unreadOnly, ResoniteBridge.ResoniteBridgeValue timeout)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", fromTime, maxItems, user, unreadOnly, timeout), typeof(Task<CloudResult<List<Message>>>)) is Task<CloudResult<List<Message>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Message>>>");
			}
		}

		public UserMessages GetUserMessages(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserMessages", userId), typeof(UserMessages)) is UserMessages __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UserMessages");
			}
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

		public MessageManager()
		{
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

		public static System.Int32 MAX_READ_HISTORY
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserMessages", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_READ_HISTORY"), typeof(System.Int32));
			}
		}

		public static System.Int32 MAX_UNREAD_HISTORY
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserMessages", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_UNREAD_HISTORY"), typeof(System.Int32));
			}
		}

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

		public SkyFrostInterface Cloud
		{
			get
			{
				return (SkyFrostInterface)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface));
			}
		}

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

		public void MarkAllRead()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkAllRead");
		}

		public Message CreateTextMessage(System.String text)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateTextMessage", text), typeof(Message)) is Message __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Message");
			}
		}

		public Message CreateInviteMessage(SessionInfo sessionInfo)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateInviteMessage", sessionInfo), typeof(Message)) is Message __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Message");
			}
		}

		public Task<bool> SendInviteMessage(SessionInfo sessionInfo)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendInviteMessage", sessionInfo), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task<bool> SendMessage(Message message)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendMessage", message), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public void RegisterSentMessage(Message message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterSentMessage", message);
		}

		public Task<bool> SendTextMessage(System.String text)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendTextMessage", text), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task EnsureHistory()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureHistory"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		internal System.Boolean AddMessage(Message message)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMessage", message), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
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

		public UserMessages()
		{
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
		}

		internal void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public AccountMigrationTask TryGetMigrationTask(System.String taskId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetMigrationTask", taskId), typeof(AccountMigrationTask)) is AccountMigrationTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AccountMigrationTask");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMigration", migrationId), typeof(Task<CloudResult<AccountMigrationTask>>)) is Task<CloudResult<AccountMigrationTask>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<AccountMigrationTask>>");
			}
		}

		public Task<CloudResult<List<AccountMigrationTask>>> GetMigrations()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMigrations"), typeof(Task<CloudResult<List<AccountMigrationTask>>>)) is Task<CloudResult<List<AccountMigrationTask>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<AccountMigrationTask>>>");
			}
		}

		public Task<CloudResult<List<AccountMigrationTask>>> CreateMigrationTask(MigrationInitialization init, System.Boolean migrateFavorites, System.Boolean overwriteFavorites)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateMigrationTask", init, migrateFavorites, overwriteFavorites), typeof(Task<CloudResult<List<AccountMigrationTask>>>)) is Task<CloudResult<List<AccountMigrationTask>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<AccountMigrationTask>>>");
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

		public MigrationManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public MigrationManager()
		{
		}
	}
	public class ModerationManager : SkyFrostModule, IModerationClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public event Action<string> OnUserPublicBanned;

		public event Action<string> OnUserMuted;

		public event Action<string> OnUserSpectatorBanned;

		public Task<CloudResult<bool>> IsPublicBanned(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsPublicBanned", id), typeof(Task<CloudResult<bool>>)) is Task<CloudResult<bool>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<bool>>");
			}
		}

		public Task UserPublicBanned(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserPublicBanned", userId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task UserMuteBanned(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserMuteBanned", userId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task UserSpectatorBanned(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserSpectatorBanned", userId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public ModerationManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ModerationManager()
		{
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

		public Task ForceUpdate()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceUpdate"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, ResoniteBridge.ResoniteBridgeValue preference, System.String universeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodes", type, protocolVersion, preference, universeId), typeof(IEnumerable<NetworkNodeInfo>)) is IEnumerable<NetworkNodeInfo> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<NetworkNodeInfo>");
			}
		}

		public void Initialize(SkyFrostInterface SkyFrost)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", SkyFrost);
		}

		public NetworkNodeInfo TryGetNode(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNode", id), typeof(NetworkNodeInfo)) is NetworkNodeInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NetworkNodeInfo");
			}
		}

		public ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNodeWithRefetch", id), typeof(ValueTask<NetworkNodeInfo>)) is ValueTask<NetworkNodeInfo> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask<NetworkNodeInfo>");
			}
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

		public FixedNetworkNodeSource()
		{
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
		public ApiClient Api
		{
			get
			{
				return (ApiClient)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient));
			}
		}

		public event Action<INetworkNodeManager> AvailableNodesChanged;

		public event LNL_PokeRequestHandler OnLNLPokeRequested;

		public void Initialize(SkyFrostInterface SkyFrost)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", SkyFrost);
		}

		public IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, ResoniteBridge.ResoniteBridgeValue preference, System.String universeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodes", type, protocolVersion, preference, universeId), typeof(IEnumerable<NetworkNodeInfo>)) is IEnumerable<NetworkNodeInfo> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IEnumerable<NetworkNodeInfo>");
			}
		}

		public NetworkNodeInfo TryGetNode(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNode", id), typeof(NetworkNodeInfo)) is NetworkNodeInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to NetworkNodeInfo");
			}
		}

		public ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNodeWithRefetch", id), typeof(ValueTask<NetworkNodeInfo>)) is ValueTask<NetworkNodeInfo> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask<NetworkNodeInfo>");
			}
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task ForceUpdate()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceUpdate"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task<CloudResult<List<NetworkNodeInfo>>> GetNetworkNodes(System.String universeId = "")
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNetworkNodes", universeId), typeof(Task<CloudResult<List<NetworkNodeInfo>>>)) is Task<CloudResult<List<NetworkNodeInfo>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<NetworkNodeInfo>>>");
			}
		}

		public Task<CloudResult> UpdateNetworkNodeInfo(NetworkNodeInfo info)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateNetworkNodeInfo", info), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task ListenForLNLPokeRequests(System.String connectionUrl)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenForLNLPokeRequests", connectionUrl), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task RequestLNLPoke(System.String connectionUrl, System.String address, System.Int32 port)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestLNLPoke", connectionUrl, address, port), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task PokeOverLNL(System.String connectionUrl, System.String address, System.Int32 port)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PokeOverLNL", connectionUrl, address, port), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public NetworkNodeManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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

		public ResoniteBridge.ResoniteBridgeValue GetCurrentFavorite(FavoriteEntity entity)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCurrentFavorite", entity), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public void SetFavorite(FavoriteEntity entity, ResoniteBridge.ResoniteBridgeValue url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetFavorite", entity, url);
		}

		public Task EnsureInitialized(FavoriteEntity entity)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureInitialized", entity), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public void RegisterListener(FavoriteEntity entity, Action<ResoniteBridge.ResoniteBridgeValue> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", entity, callback);
		}

		public void UnregisterListener(FavoriteEntity entity, Action<ResoniteBridge.ResoniteBridgeValue> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterListener", entity, callback);
		}

		internal Task SignIn()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignIn"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FilterUrl", url), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		private void SafeInvoke(Action<ResoniteBridge.ResoniteBridgeValue> events, ResoniteBridge.ResoniteBridgeValue arg)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SafeInvoke", events, arg);
		}

		public Task<CloudResult> UpdateProfile(UserProfile profile)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateProfile", profile), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> UpdateProfile(System.String userId, UserProfile profile)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateProfile", userId, profile), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
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

		public ProfileManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ProfileManager()
		{
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

		public RecordBatchQuery<R> RecordBatch<R>() where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordBatch"), typeof(RecordBatchQuery<R>)) is RecordBatchQuery<R> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RecordBatchQuery<R>");
			}
		}

		public RecordCache<R> RecordCache<R>() where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordCache"), typeof(RecordCache<R>)) is RecordCache<R> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RecordCache<R>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GenerateRecordUri(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateRecordUri", ownerId, recordId), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public Task<CloudResult<R>> GetRecordCached<R>(ResoniteBridge.ResoniteBridgeValue recordUri, System.String accessKey = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordCached", recordUri, accessKey), typeof(Task<CloudResult<R>>)) is Task<CloudResult<R>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<R>>");
			}
		}

		public Task<CloudResult<R>> GetRecord<R>(ResoniteBridge.ResoniteBridgeValue recordUri, System.String accessKey = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", recordUri, accessKey), typeof(Task<CloudResult<R>>)) is Task<CloudResult<R>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<R>>");
			}
		}

		public Task<CloudResult<R>> GetRecord<R>(System.String ownerId, System.String recordId, System.String accessKey = null, System.Boolean includeDeleted = false) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId, accessKey, includeDeleted), typeof(Task<CloudResult<R>>)) is Task<CloudResult<R>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<R>>");
			}
		}

		public Task<CloudResult<R>> GetRecordAtPath<R>(System.String ownerId, System.String path, System.String accessKey = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAtPath", ownerId, path, accessKey), typeof(Task<CloudResult<R>>)) is Task<CloudResult<R>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<R>>");
			}
		}

		public Task<CloudResult<List<R>>> GetRecords<R>(List<RecordId> ids) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ids), typeof(Task<CloudResult<List<R>>>)) is Task<CloudResult<List<R>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<R>>>");
			}
		}

		public Task<CloudResult<List<R>>> GetRecords<R>(System.String ownerId, System.String tag = null, System.String path = null) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, tag, path), typeof(Task<CloudResult<List<R>>>)) is Task<CloudResult<List<R>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<R>>>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue GetRecordsInHierarchy<R>(System.String ownerId, System.String path) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordsInHierarchy", ownerId, path), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<R>");
			}
		}

		public Task<CloudResult<SearchResults<R>>> FindRecords<R>(SearchParameters search, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FindRecords", search, timeout, throwOnError), typeof(Task<CloudResult<SearchResults<R>>>)) is Task<CloudResult<SearchResults<R>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<SearchResults<R>>>");
			}
		}

		public Task<CloudResult<CloudMessage>> UpsertRecord<R>(R record, System.Boolean ensureFolder = true) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertRecord", record, ensureFolder), typeof(Task<CloudResult<CloudMessage>>)) is Task<CloudResult<CloudMessage>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<CloudMessage>>");
			}
		}

		public Task<CloudResult<RecordPreprocessStatus>> PreprocessRecord<R>(R record) where R : class, IRecord, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PreprocessRecord", record), typeof(Task<CloudResult<RecordPreprocessStatus>>)) is Task<CloudResult<RecordPreprocessStatus>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<RecordPreprocessStatus>>");
			}
		}

		public Task<CloudResult<RecordPreprocessStatus>> GetPreprocessStatus(RecordPreprocessStatus status)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPreprocessStatus", status), typeof(Task<CloudResult<RecordPreprocessStatus>>)) is Task<CloudResult<RecordPreprocessStatus>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<RecordPreprocessStatus>>");
			}
		}

		public Task<CloudResult<RecordPreprocessStatus>> GetPreprocessStatus(System.String ownerId, System.String recordId, System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPreprocessStatus", ownerId, recordId, id), typeof(Task<CloudResult<RecordPreprocessStatus>>)) is Task<CloudResult<RecordPreprocessStatus>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<RecordPreprocessStatus>>");
			}
		}

		public Task<CloudResult> DeleteRecord(IRecord record)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecord", record), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> DeleteRecord(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecord", ownerId, recordId), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> AddTag(System.String ownerId, System.String recordId, System.String tag)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddTag", ownerId, recordId, tag), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<List<RecordAuditInfo>>> GetRecordAuditLog(System.String ownerId, ResoniteBridge.ResoniteBridgeValue from, ResoniteBridge.ResoniteBridgeValue to)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId, from, to), typeof(Task<CloudResult<List<RecordAuditInfo>>>)) is Task<CloudResult<List<RecordAuditInfo>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<RecordAuditInfo>>>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue EnumerateRecordAuditLog()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnumerateRecordAuditLog"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<RecordAuditInfo>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue EnumerateRecordAuditLog(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnumerateRecordAuditLog", ownerId), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to IAsyncEnumerable<RecordAuditInfo>");
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

		public RecordsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RecordsManager()
		{
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

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public CryptoData()
		{
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SecurityManager", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateCryptoData"), typeof(Task<CryptoData>)) is Task<CryptoData> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CryptoData>");
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
				throw new InvalidCastException("Cannot cast result to byte[]");
			}
		}

		public Task<CloudResult<OneTimeVerificationKey>> CreateKey(System.String baseId, VerificationKeyUse use, System.Int32 expirationSeconds = 0)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateKey", baseId, use, expirationSeconds), typeof(Task<CloudResult<OneTimeVerificationKey>>)) is Task<CloudResult<OneTimeVerificationKey>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<OneTimeVerificationKey>>");
			}
		}

		public Task<CloudResult<bool>> CheckContact(CheckContactData data)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CheckContact", data), typeof(Task<CloudResult<bool>>)) is Task<CloudResult<bool>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<bool>>");
			}
		}

		public Task<CloudResult<TOTP_Key>> InitializeTOTP()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeTOTP"), typeof(Task<CloudResult<TOTP_Key>>)) is Task<CloudResult<TOTP_Key>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<TOTP_Key>>");
			}
		}

		public Task<CloudResult> ActivateTOTP(System.String code)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ActivateTOTP", code), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> DeactivateTOTP(System.String code)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeactivateTOTP", code), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public ValueTask EnsureIPAllowed()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureIPAllowed"), typeof(ValueTask)) is ValueTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask");
			}
		}

		public Task<CloudResult> TemporarilyAllowIP()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TemporarilyAllowIP"), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
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

		public SecurityManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SecurityManager()
		{
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

		internal ResoniteBridge.ResoniteBridgeValue AuthenticationHeader
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthenticationHeader"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
		}

		public event Action<UserSession> SessionChanged;

		public event Action<User> UserUpdated;

		public event Action<List<Task>> OnFinalizeSession;

		public void ScheduleUpdateCurrentUserInfo()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleUpdateCurrentUserInfo");
		}

		public Task<CloudResult<User>> UpdateCurrentUserInfo()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserInfo"), typeof(Task<CloudResult<User>>)) is Task<CloudResult<User>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<User>>");
			}
		}

		public Task<CloudResult<UserSessionResult<UserSession>>> Login(System.String credential, LoginAuthentication authentication, System.String secretMachineId, System.Boolean rememberMe, System.String totp)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Login", credential, authentication, secretMachineId, rememberMe, totp), typeof(Task<CloudResult<UserSessionResult<UserSession>>>)) is Task<CloudResult<UserSessionResult<UserSession>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<UserSessionResult<UserSession>>>");
			}
		}

		private Dictionary<string, object> GenerateLegacyLogin(System.String credential, System.String password, System.String secretMachineId, System.Boolean rememberMe = false, System.String totp = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateLegacyLogin", credential, password, secretMachineId, rememberMe, totp), typeof(Dictionary<string, object>)) is Dictionary<string, object> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Dictionary<string, object>");
			}
		}

		public Task ActivateSession(UserSession session, CryptoData cryptoData)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ActivateSession", session, cryptoData), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task FinalizeSession()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeSession"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task Logout(System.Boolean isManual)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Logout", isManual), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		internal void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task<CloudResult> LogoutAll(System.Boolean keepCurrent, System.String secretMachineId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogoutAll", keepCurrent, secretMachineId), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<UserSession>> GetExternalLogin(System.String key)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExternalLogin", key), typeof(Task<CloudResult<UserSession>>)) is Task<CloudResult<UserSession>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<UserSession>>");
			}
		}

		public Task<CloudResult> DeleteExternalLogin(System.String key)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteExternalLogin", key), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> ExtendSession(System.Boolean updateToken = true, System.String secretMachineId = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtendSession", updateToken, secretMachineId), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<bool> LoginSaml2(System.String samlEntityId, System.String secretMachineId, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LoginSaml2", samlEntityId, secretMachineId, cancellationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		private Task LogoutSaml2(UserSession session)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogoutSaml2", session), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public SessionManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SessionManager()
		{
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetInfo", sessionId), typeof(SessionInfo)) is SessionInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SessionInfo");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MatchSessionInfo", status, metadata), typeof(SessionInfo)) is SessionInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SessionInfo");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ShouldRemoveSession", data), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateSessions", update), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<SessionInfo>> GetSession(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSession", sessionId), typeof(Task<CloudResult<SessionInfo>>)) is Task<CloudResult<SessionInfo>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<SessionInfo>>");
			}
		}

		public Task<CloudResult<List<SessionInfo>>> GetSessions(System.String name = null, System.String universeId = null, System.String hostName = null, System.String hostId = null, System.Int32 minActiveUsers = null, System.Boolean includeEmptyHeadless = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessions", name, universeId, hostName, hostId, minActiveUsers, includeEmptyHeadless), typeof(Task<CloudResult<List<SessionInfo>>>)) is Task<CloudResult<List<SessionInfo>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<SessionInfo>>>");
			}
		}

		public Task<CloudResult> UpdateSessionMetadata(CloudSessionMetadata metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateSessionMetadata", metadata), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<List<string>>> GetSessionURLs(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionURLs", sessionId), typeof(Task<CloudResult<List<string>>>)) is Task<CloudResult<List<string>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<string>>>");
			}
		}

		public System.String PrintoutSessions()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrintoutSessions"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
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

		public SessionsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SessionsManager()
		{
		}
	}
	public class DefaultSessionListingSettings : ISessionListingSettings, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public System.Boolean HasUniverse
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasUniverse"), typeof(System.Boolean));
			}
		}

		public System.String UniverseId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseId"), typeof(System.String));
			}
		}

		public System.Boolean AcceptSession(SessionInfo sessionInfo)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AcceptSession", sessionInfo), typeof(System.Boolean)) is System.Boolean __retCasted)
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

		public DefaultSessionListingSettings(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task<CloudResult> HealthCheck()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HealthCheck"), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> Ping()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Ping"), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> NotifyOnlineInstance(System.String machineId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NotifyOnlineInstance", machineId), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<ServerStatistics>> GetServerStatistics()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetServerStatistics"), typeof(Task<CloudResult<ServerStatistics>>)) is Task<CloudResult<ServerStatistics>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<ServerStatistics>>");
			}
		}

		public Task<OnlineStats> GetOnlineStats()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOnlineStats"), typeof(Task<OnlineStats>)) is Task<OnlineStats> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<OnlineStats>");
			}
		}

		public Task<CloudStats> GetCloudStats()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCloudStats"), typeof(Task<CloudStats>)) is Task<CloudStats> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudStats>");
			}
		}

		public Task<CloudResult<List<CreditUser>>> GetUserCredits(CreditType type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCredits", type), typeof(Task<CloudResult<List<CreditUser>>>)) is Task<CloudResult<List<CreditUser>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<CreditUser>>>");
			}
		}

		public Task<List<CreditUser>> GetUserCreditsCached(CreditType type)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCreditsCached", type), typeof(Task<List<CreditUser>>)) is Task<List<CreditUser>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<List<CreditUser>>");
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

		public StatisticsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public StatisticsManager()
		{
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

		public System.Int64 CurrentStorageQuota
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorageQuota"), typeof(System.Int64));
			}
		}

		public System.Int64 CurrentStorageUsed
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorageUsed"), typeof(System.Int64));
			}
		}

		public System.Int64 CurrentStorageFree
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorageFree"), typeof(System.Int64));
			}
		}

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

		public Task<CloudResult<Storage>> UpdateCurrentUserStorage()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserStorage"), typeof(Task<CloudResult<Storage>>)) is Task<CloudResult<Storage>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Storage>>");
			}
		}

		public Task UpdateStorage(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStorage", ownerId), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStorage", ownerId), typeof(Task<CloudResult<Storage>>)) is Task<CloudResult<Storage>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Storage>>");
			}
		}

		public Task<CloudResult<Storage>> GetMemberStorage(System.String ownerId, System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMemberStorage", ownerId, userId), typeof(Task<CloudResult<Storage>>)) is Task<CloudResult<Storage>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<Storage>>");
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

		public StorageManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public StorageManager()
		{
		}
	}
	public class UsersManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Task<CloudResult<User>> GetUser(System.String userId, System.String banAccessKey = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser", userId, banAccessKey), typeof(Task<CloudResult<User>>)) is Task<CloudResult<User>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<User>>");
			}
		}

		public Task<CloudResult<User>> GetUserByName(System.String username)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserByName", username), typeof(Task<CloudResult<User>>)) is Task<CloudResult<User>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<User>>");
			}
		}

		public Task<CloudResult<User>> GetUserByNameLegacy(System.String username)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserByNameLegacy", username), typeof(Task<CloudResult<User>>)) is Task<CloudResult<User>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<User>>");
			}
		}

		public Task<CloudResult<List<User>>> GetUsers(System.String searchName)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUsers", searchName), typeof(Task<CloudResult<List<User>>>)) is Task<CloudResult<List<User>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<User>>>");
			}
		}

		public Task<CloudResult<RSAParametersData>> GetPublicKey(System.String userId, System.String userSessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPublicKey", userId, userSessionId), typeof(Task<CloudResult<RSAParametersData>>)) is Task<CloudResult<RSAParametersData>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<RSAParametersData>>");
			}
		}

		public Task<CloudResult> UpdatePublicKey(System.String userId, System.String userSessionId, RSAParametersData key)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdatePublicKey", userId, userSessionId, key), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<User>> GetUserCached(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCached", userId), typeof(Task<CloudResult<User>>)) is Task<CloudResult<User>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<User>>");
			}
		}

		public Task<CloudResult> RequestAccountDeletion(LoginCredentials credentials, System.String totp)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestAccountDeletion", credentials, totp), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> CancelAccountDeletion(LoginCredentials credentials, System.String totp)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CancelAccountDeletion", credentials, totp), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<UserSessionResult<User>>> Register(System.String username, System.String email, System.String password, DateTimeOffset dateOfBirth, System.String migrationCredential = null, System.String migrationPassword = null, System.String migrationTotp = null, System.Boolean resetUserId = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Register", username, email, password, dateOfBirth, migrationCredential, migrationPassword, migrationTotp, resetUserId), typeof(Task<CloudResult<UserSessionResult<User>>>)) is Task<CloudResult<UserSessionResult<User>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<UserSessionResult<User>>>");
			}
		}

		public Task<CloudResult> RequestRecoveryCode(System.String email)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestRecoveryCode", email), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult<List<PatreonFundingEvent>>> GetPatreonFundingEvents()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<CloudResult<List<PatreonFundingEvent>>>)) is Task<CloudResult<List<PatreonFundingEvent>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<PatreonFundingEvent>>>");
			}
		}

		public Task<CloudResult<List<ExitMessage>>> GetExitMessages()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExitMessages"), typeof(Task<CloudResult<List<ExitMessage>>>)) is Task<CloudResult<List<ExitMessage>>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<ExitMessage>>>");
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

		public UsersManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public UsersManager()
		{
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

		public System.String UserSessionId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionId"), typeof(System.String));
			}
		}

		public System.Boolean LoadingOnlineStatus
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadingOnlineStatus"), typeof(System.Boolean));
			}
		}

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

		internal Task SignOut()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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

		public UserStatusManager()
		{
		}
	}
	public class VisitsManager : SkyFrostModule, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public Task<CloudResult> LogVisit(Visit visit)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogVisit", visit), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
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

		public VisitsManager(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public VisitsManager()
		{
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
		public ResoniteBridge.ResoniteBridgeValue TotalTime
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalTime"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
		}

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
		public System.Int32 TotalMigratedMemberCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalMigratedMemberCount"), typeof(System.Int32));
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalMigratedVariableCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalMigratedVariableCount"), typeof(System.Int32));
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalMigratedVariableDefinitionCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalMigratedVariableDefinitionCount"), typeof(System.Int32));
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalRecordCount"), typeof(System.Int32));
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
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public System.Int32 TotalFailedRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalFailedRecordCount"), typeof(System.Int32));
			}
		}

		public void RegisterMissingAsset(System.String hash)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterMissingAsset", hash);
		}

		public GroupMigrationStatus GetGroupStatus(System.String ownerId, System.String groupName)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroupStatus", ownerId, groupName), typeof(GroupMigrationStatus)) is GroupMigrationStatus __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to GroupMigrationStatus");
			}
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
		public System.Int32 TotalProcessedRecordCount
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalProcessedRecordCount"), typeof(System.Int32));
			}
		}

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

		public static TimeSpan SESSION_UPDATE_INTERVAL
		{
			get
			{
				return (TimeSpan)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "SESSION_UPDATE_INTERVAL"), typeof(TimeSpan));
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
		public RecordId ActualCorrespondingWorldId
		{
			get
			{
				return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActualCorrespondingWorldId"), typeof(RecordId));
			}
		}

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
		public System.String NormalizedSessionId
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NormalizedSessionId"), typeof(System.String));
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
		public System.Boolean IsOnLAN
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsOnLAN"), typeof(System.Boolean));
			}
		}

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
		public System.Boolean IsExpired
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsExpired"), typeof(System.Boolean));
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.Single ExpirationProgress
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpirationProgress"), typeof(System.Single));
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.String SanitizedHostUsername
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SanitizedHostUsername"), typeof(System.String));
			}
		}

		public System.Boolean HasEnded
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasEnded"), typeof(System.Boolean));
			}
		}

		public System.Boolean IsValid
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsValid"), typeof(System.Boolean));
			}
		}

		public static System.String NormalizeId(System.String id)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "NormalizeId", id), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.Boolean IsTimestampExpired(DateTime lastUpdate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsTimestampExpired", lastUpdate), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Single TimestampExpirationProgress(DateTime lastUpdate)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "TimestampExpirationProgress", lastUpdate), typeof(System.Single)) is System.Single __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to float");
			}
		}

		public static System.Boolean IsAllowedName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsAllowedName", name), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean IsCustomSessionId(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsCustomSessionId", sessionId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.String GetCustomSessionIdOwner(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCustomSessionIdOwner", sessionId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.Boolean IsValidSessionId(System.String sessionId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidSessionId", sessionId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static System.Boolean IsValidVersion(System.String version)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "IsValidVersion", version), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public List<ResoniteBridge.ResoniteBridgeValue> GetSessionURLs()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionURLs"), typeof(List<ResoniteBridge.ResoniteBridgeValue>)) is List<ResoniteBridge.ResoniteBridgeValue> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to List<Uri>");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasTag", tag), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void Trim()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Trim");
		}

		public CloudSessionMetadata GetMetadata()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMetadata"), typeof(CloudSessionMetadata)) is CloudSessionMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CloudSessionMetadata");
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
				throw new InvalidCastException("Cannot cast result to string");
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
		public System.String SanitizedUsername
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SanitizedUsername"), typeof(System.String));
			}
		}

		public System.Boolean Equals(SessionUser other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
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

		public SessionUser(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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

		public static SkyFrostConfig DEFAULT_PRODUCTION
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PRODUCTION"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig DEFAULT_PRODUCTION_DIRECT
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PRODUCTION_DIRECT"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig DEFAULT_STAGING
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_STAGING"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig DEFAULT_LOCAL
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_LOCAL"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig DURIAN_LOCAL
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN_LOCAL"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig DURIAN_STAGING
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN_STAGING"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig DURIAN_PRODUCTION
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN_PRODUCTION"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig SKYFROST_LOCAL
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_LOCAL"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig SKYFROST_STAGING
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_STAGING"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig SKYFROST_PRODUCTION
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_PRODUCTION"), typeof(SkyFrostConfig));
			}
		}

		public static SkyFrostConfig SKYFROST_PRODUCTION_DIRECT
		{
			get
			{
				return (SkyFrostConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_PRODUCTION_DIRECT"), typeof(SkyFrostConfig));
			}
		}

		public SkyFrostConfig WithUserAgent(System.String product, System.String version = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithUserAgent", product, version), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
			}
		}

		public SkyFrostConfig WithGzip(System.Boolean enabled)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithGzip", enabled), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
			}
		}

		public SkyFrostConfig WithoutSignalR()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithoutSignalR"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
			}
		}

		public SkyFrostConfig WithUniverse(System.String universeId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithUniverse", universeId), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
			}
		}

		public SkyFrostConfig WithProxy(ProxyConfig proxy)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WithProxy", proxy), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
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

		public SkyFrostConfig(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
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

		public UserSessionMetadata(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class OnlineStatusHelper
	{
		public static System.Boolean DefaultPrivate(this OnlineStatus status)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "OnlineStatusHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "DefaultPrivate", status), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
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
		public System.Boolean IsExpired
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsExpired"), typeof(System.Boolean));
			}
		}

		public UserStatus Clone()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Clone"), typeof(UserStatus)) is UserStatus __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UserStatus");
			}
		}

		public void InitializeSessionList()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeSessionList");
		}

		public UserSessionMetadata AddSession(SessionInfo info, System.Boolean isFocused)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddSession", info, isFocused), typeof(UserSessionMetadata)) is UserSessionMetadata __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to UserSessionMetadata");
			}
		}

		public SessionInfo MatchSessionInfo(IEnumerable<SessionInfo> infos, UserSessionMetadata metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MatchSessionInfo", infos, metadata), typeof(SessionInfo)) is SessionInfo __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to SessionInfo");
			}
		}

		public System.Boolean IsMatchingSession(SessionInfo info, UserSessionMetadata metadata)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsMatchingSession", info, metadata), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public void CreateSessionMap(IEnumerable<SessionInfo> infos, Dictionary<string, SessionInfo> map)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateSessionMap", infos, map);
		}

		public System.Boolean IsDominantOver(UserStatus status)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsDominantOver", status), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
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
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.Boolean Equals(UserStatus other)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean)) is System.Boolean __retCasted)
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

		public UserStatus(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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

		public static System.String CommonAvatar
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CommonAvatar"), typeof(System.String));
			}
		}

		public static System.String CommonTool
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CommonTool"), typeof(System.String));
			}
		}

		public static System.String ProfileIcon
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfileIcon"), typeof(System.String));
			}
		}

		public static System.String MessageItem
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MessageItem"), typeof(System.String));
			}
		}

		public static System.String WorldOrb
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "WorldOrb"), typeof(System.String));
			}
		}

		public static System.String AudioPlayer
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "AudioPlayer"), typeof(System.String));
			}
		}

		public static System.String VideoPlayer
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VideoPlayer"), typeof(System.String));
			}
		}

		public static System.String VirtualKeyboard
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VirtualKeyboard"), typeof(System.String));
			}
		}

		public static System.String InteractiveCamera
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "InteractiveCamera"), typeof(System.String));
			}
		}

		public static System.String Facet
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Facet"), typeof(System.String));
			}
		}

		public static System.String ProgressBar
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ProgressBar"), typeof(System.String));
			}
		}

		public static System.String WorldLoadingProgress
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "WorldLoadingProgress"), typeof(System.String));
			}
		}

		public static System.String AudioStreamInterface
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "AudioStreamInterface"), typeof(System.String));
			}
		}

		public static System.String TextDisplay
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "TextDisplay"), typeof(System.String));
			}
		}

		public static System.String DocumentDisplay
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "DocumentDisplay"), typeof(System.String));
			}
		}

		public static System.String UrlDisplay
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "UrlDisplay"), typeof(System.String));
			}
		}

		public static System.String NameplateTemplate
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "NameplateTemplate"), typeof(System.String));
			}
		}

		public static System.String NoticeDisplay
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "NoticeDisplay"), typeof(System.String));
			}
		}

		public static System.String ColorDialog
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ColorDialog"), typeof(System.String));
			}
		}

		public static System.String Photo
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Photo"), typeof(System.String));
			}
		}

		public static System.String VRPhoto
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VRPhoto"), typeof(System.String));
			}
		}

		public static System.String Photo360
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Photo360"), typeof(System.String));
			}
		}

		public static System.String PhotoStereo
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "PhotoStereo"), typeof(System.String));
			}
		}

		public static System.String RawFile
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "RawFile"), typeof(System.String));
			}
		}

		public static System.String AudioClip
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "AudioClip"), typeof(System.String));
			}
		}

		public static System.String VideoClip
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VideoClip"), typeof(System.String));
			}
		}

		public static System.String RawFileAsset(System.String url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "RawFileAsset", url), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String TextureAsset(System.String url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "TextureAsset", url), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String ClipAsset(System.String url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ClipAsset", url), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String ClipLength(System.Double length)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ClipLength", length), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String LocationName(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationName", name), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String LocationHost(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationHost", userId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String LocationAccessLevel(SessionAccessLevel accessLevel)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationAccessLevel", accessLevel), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String LocationHiddenFromListing(System.Boolean hidden)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "LocationHiddenFromListing", hidden), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String PresentUser(System.String userId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "PresentUser", userId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String Timestamp(DateTime time)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Timestamp", time), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String CorrespondingMessageId(System.String messageId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CorrespondingMessageId", messageId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String CorrespondingWorldUrl(System.String worldUrl)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CorrespondingWorldUrl", worldUrl), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String GetCorrespondingMessageId(HashSet<string> tags)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCorrespondingMessageId", tags), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public static System.String GetCorrespondingWorldUrl(HashSet<string> tags)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GetCorrespondingWorldUrl", tags), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private static System.String ExtractValue(HashSet<string> tags, System.String prefix)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractValue", tags, prefix), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
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

		public User CurrentUser
		{
			get
			{
				return (User)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User));
			}
		}

		public System.String CurrentUserID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserID"), typeof(System.String));
			}
		}

		public System.String CurrentUsername
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUsername"), typeof(System.String));
			}
		}

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

		protected virtual System.Boolean UseAlternateWebsocket
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseAlternateWebsocket"), typeof(System.Boolean));
			}
		}

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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MetadataBatch"), typeof(MetadataBatchQuery<M>)) is MetadataBatchQuery<M> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to MetadataBatchQuery<M>");
			}
		}

		protected virtual Task OnLogin()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnLogin"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		protected virtual Task OnLogout(System.Boolean isManual)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnLogout", isManual), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual Task OnSessionTokenRefresh()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionTokenRefresh"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		protected virtual void InstallConfigFile(System.String path, System.String content)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InstallConfigFile", path, content);
		}

		protected virtual Task<bool> RunInitialAnonymousHubConnection()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunInitialAnonymousHubConnection"), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		private void AuthenticateApiRequest(ResoniteBridge.ResoniteBridgeValue request, System.String totpCode)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AuthenticateApiRequest", request, totpCode);
		}

		internal Task ConnectToHub(System.String source)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectToHub", source), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private static Task Connect(ResoniteBridge.ResoniteBridgeValue connection, System.String source, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Connect", connection, source, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private Task DisconnectFromHub()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DisconnectFromHub"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public virtual void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		internal Task Login()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Login"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task FinalizeSession()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeSession"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		internal Task BeginLogout(System.Boolean isManual)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginLogout", isManual), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasPotentialAccess", ownerId), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public Task<bool> InteractiveConsoleLogin(System.Boolean tryUseCommandLineArgs = false)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InteractiveConsoleLogin", tryUseCommandLineArgs), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public Task<T> HandleConsoleLogin<T>(ConsoleLoginHandler<T> handler) where T : CloudResult
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HandleConsoleLogin", handler), typeof(Task<T>)) is Task<T> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<T>");
			}
		}

		public Task<bool> InteractiveConsoleRegister()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InteractiveConsoleRegister"), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		public System.String GetOwnerPath(System.String ownerId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOwnerPath", ownerId), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		internal void ProcessUserSessionResult<T>(UserSessionResult<T> result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessUserSessionResult", result);
		}

		public Task<ExitMessage> GetRandomExitMessage()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRandomExitMessage"), typeof(Task<ExitMessage>)) is Task<ExitMessage> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<ExitMessage>");
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

		public SkyFrostInterface(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SkyFrostInterface()
		{
		}
	}
	public abstract class SkyFrostModule : ResoniteBridge.ResoniteBridgeValueHolder
	{
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

		public ApiClient Api
		{
			get
			{
				return (ApiClient)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient));
			}
		}

		public IPlatformProfile Platform
		{
			get
			{
				return (IPlatformProfile)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Platform"), typeof(IPlatformProfile));
			}
		}

		public System.Boolean IsUserSignedIn
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUserSignedIn"), typeof(System.Boolean));
			}
		}

		public User CurrentUser
		{
			get
			{
				return (User)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User));
			}
		}

		public System.String CurrentUserID
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserID"), typeof(System.String));
			}
		}

		public System.String CurrentUsername
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUsername"), typeof(System.String));
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GET", resource, timeout, throwOnError), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<T>> HEAD<T>(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true) where T : class, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HEAD", resource, timeout, throwOnError), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<T>> POST<T>(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, System.Boolean throwOnError = true, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null) where T : class, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST", resource, entity, timeout, totpCode, throwOnError, postprocessRequest), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<T>> POST_File<T>(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator) where T : class, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_File", resource, filePath, fileMIME, progressIndicator), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<T>> PUT<T>(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null) where T : class, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<T>> PATCH<T>(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null) where T : class, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PATCH", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult<T>> DELETE<T>(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, System.Boolean throwOnError = true) where T : class, new()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DELETE", resource, timeout, totpCode, throwOnError), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
			}
		}

		public Task<CloudResult> GET(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GET", resource, timeout, throwOnError), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> HEAD(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HEAD", resource, timeout, throwOnError), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> COPY(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "COPY", resource, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> POST(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, System.Boolean throwOnError = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST", resource, entity, timeout, totpCode, throwOnError), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> POST_FileMultipart(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_FileMultipart", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> POST_FileDirect(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_FileDirect", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> PUT_FileMultipart(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT_FileMultipart", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> PUT_FileDirect(System.String resource, System.String filePath, System.String fileMIME = null, ResoniteBridge.ResoniteBridgeValue progressIndicator, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT_FileDirect", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> PUT(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT", resource, entity, timeout, throwOnError), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> PATCH(System.String resource, System.Object entity, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError = true, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocessRequest = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PATCH", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public Task<CloudResult> DELETE(System.String resource, ResoniteBridge.ResoniteBridgeValue timeout, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocess = null, System.Boolean throwOnError = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DELETE", resource, timeout, totpCode, postprocess, throwOnError), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue CreateRequest(System.String resource, ResoniteBridge.ResoniteBridgeValue method, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocess = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateRequest", resource, method, totpCode, postprocess), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to HttpRequestMessage");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue CreateRequest(ResoniteBridge.ResoniteBridgeValue resource, System.Boolean authenticate, ResoniteBridge.ResoniteBridgeValue method, System.String totpCode = null, Action<ResoniteBridge.ResoniteBridgeValue> postprocess = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateRequest", resource, authenticate, method, totpCode, postprocess), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to HttpRequestMessage");
			}
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

		internal Task<CloudResult> RunRequest(Func<ResoniteBridge.ResoniteBridgeValue> requestSource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunRequest", requestSource, timeout, throwOnError), typeof(Task<CloudResult>)) is Task<CloudResult> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult>");
			}
		}

		internal Task<CloudResult<T>> RunRequest<T>(Func<ResoniteBridge.ResoniteBridgeValue> requestSource, ResoniteBridge.ResoniteBridgeValue timeout, System.Boolean throwOnError) where T : class
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunRequest", requestSource, timeout, throwOnError), typeof(Task<CloudResult<T>>)) is Task<CloudResult<T>> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<CloudResult<T>>");
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

		public ApiClient(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public ApiClient()
		{
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
		public System.Int32 DEFAULT_CONCURRENT_DOWNLOADS
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DEFAULT_CONCURRENT_DOWNLOADS"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DEFAULT_CONCURRENT_DOWNLOADS", value);
			}
		}

		public System.Int32 DEFAULT_MAX_ATTEMPTS
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DEFAULT_MAX_ATTEMPTS"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DEFAULT_MAX_ATTEMPTS", value);
			}
		}

		public System.Int32 BufferSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BufferSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BufferSize", value);
			}
		}

		public System.Int32 MaximumAttempts
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MaximumAttempts"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MaximumAttempts", value);
			}
		}

		public System.String TemporaryPath
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "TemporaryPath"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "TemporaryPath", value);
			}
		}

		private ResoniteBridge.ResoniteBridgeValue buffers
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "buffers"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "buffers", value);
			}
		}

		private System.Int64 _totalBytesPerSecond
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_totalBytesPerSecond"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_totalBytesPerSecond", value);
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

		private System.Object _speedLock
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_speedLock"), typeof(System.Object));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_speedLock", value);
			}
		}

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

		public System.Int64 TotalBytesPerSecond
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalBytesPerSecond"), typeof(System.Int64));
			}
		}

		internal byte[] BorrowBuffer()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BorrowBuffer"), typeof(byte[])) is byte[] __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to byte[]");
			}
		}

		internal void ReturnBuffer(byte[] buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReturnBuffer", buffer);
		}

		internal void BytesDownloaded(System.Int64 bytes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BytesDownloaded", bytes);
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		}

		private Task ProcessJob(System.Object category)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessJob", category), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public void SetCategoryParallelism(System.Object category, System.Int32 concurrentJobs)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetCategoryParallelism", category, concurrentJobs);
		}

		private ResoniteBridge.ResoniteBridgeValue SetCategoryParallelismIntern(System.Object category, System.Int32 concurrentJobs)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetCategoryParallelismIntern", category, concurrentJobs), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ActionBlock<object>");
			}
		}

		public G Gather(ResoniteBridge.ResoniteBridgeValue url, System.Single priority = 0f, Action<G> initialize = null)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Gather", url, priority, initialize), typeof(G)) is G __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to G");
			}
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

		public AssetGatherer()
		{
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
					return (Query)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "query"), typeof(Query));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "query", value);
				}
			}

			public Result result
			{
				get
				{
					return (Result)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "result"), typeof(Result));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "result", value);
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

			public QueryResult(ResoniteBridge.ResoniteBridgeValue value)
			{
				__backing = value;
			}

			public QueryResult()
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

		private Dictionary<Query, TaskCompletionSource<Result>> queue
		{
			get
			{
				return (Dictionary<Query, TaskCompletionSource<Result>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "queue"), typeof(Dictionary<Query, TaskCompletionSource<Result>>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "queue", value);
			}
		}

		private TaskCompletionSource<bool> immediateDispatch
		{
			get
			{
				return (TaskCompletionSource<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "immediateDispatch"), typeof(TaskCompletionSource<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "immediateDispatch", value);
			}
		}

		private System.Boolean dispatchScheduled
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dispatchScheduled"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dispatchScheduled", value);
			}
		}

		public System.Int32 MaxBatchSize
		{
			get
			{
				return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxBatchSize"), typeof(System.Int32));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxBatchSize", value);
			}
		}

		public System.Single DelaySeconds
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DelaySeconds"), typeof(System.Single));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DelaySeconds", value);
			}
		}

		public Task<Result> Request(Query query)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Request", query), typeof(Task<Result>)) is Task<Result> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<Result>");
			}
		}

		private Task SendBatch()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendBatch"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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
		}

		public System.Boolean IsError
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsError"), typeof(System.Boolean));
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
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		public System.String TryGetHeaderValue(System.String name)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetHeaderValue", name), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
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

		public CloudResult(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public CloudResult()
		{
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

		public CloudResult<E> AsResult<E>() where E : class
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AsResult"), typeof(CloudResult<E>)) is CloudResult<E> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to CloudResult<E>");
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
				throw new InvalidCastException("Cannot cast result to string");
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

		public virtual System.Object CategoryKey
		{
			get
			{
				return (System.Object)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CategoryKey"), typeof(System.Object));
			}
		}

		public System.Single Progress
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Progress"), typeof(System.Single));
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

		public Task Task
		{
			get
			{
				return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Task"), typeof(Task));
			}
		}

		public event Action<float> ProgressUpdated;

		internal void Initialize(AssetGatherer gatherer, ResoniteBridge.ResoniteBridgeValue url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", gatherer, url);
		}

		private ResoniteBridge.ResoniteBridgeValue ResolveURL(ResoniteBridge.ResoniteBridgeValue url, DB_Endpoint endpoint)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResolveURL", url, endpoint), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public Task Download()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Download"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
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

		protected virtual Task RunDownload()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunDownload"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		protected virtual Task<string> FinishGather()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishGather"), typeof(Task<string>)) is Task<string> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<string>");
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
				throw new InvalidCastException("Cannot cast result to string");
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

		public GatherJob(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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

		public ResoniteBridge.ResoniteBridgeValue NextRetryDelay(ResoniteBridge.ResoniteBridgeValue retryContext)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NextRetryDelay", retryContext), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to TimeSpan?");
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

		public InfiniteRetryPolicy(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
	public static class IPAddressExtensions
	{
		public static System.Boolean IsLinkLocalAddress(this ResoniteBridge.ResoniteBridgeValue ipAddress)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "IPAddressExtensions", ResoniteBridge.ResoniteBridgeValueType.Type), "IsLinkLocalAddress", ipAddress), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
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

		protected override Task RunBatch(List<QueryResult> batch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public MetadataBatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public MetadataBatchQuery()
		{
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

		protected override Task RunBatch(List<QueryResult> batch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public Task<TRecord> Get(System.String ownerId, System.String recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Get", ownerId, recordId), typeof(Task<TRecord>)) is Task<TRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<TRecord>");
			}
		}

		public Task<TRecord> Get(RecordId recordId)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Get", recordId), typeof(Task<TRecord>)) is Task<TRecord> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<TRecord>");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetKey", record), typeof(RecordId)) is RecordId __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RecordId");
			}
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EqualsParameters", other), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public ValueTask GetResultsSlice(System.Int32 offset, System.Int32 count, List<R> results, System.Int32 attempts = 5, System.Boolean throwOnError = true)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResultsSlice", offset, count, results, attempts, throwOnError), typeof(ValueTask)) is ValueTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask");
			}
		}

		public ValueTask<bool> EnsureResults(System.Int32 count, System.Int32 attempts = 5, System.Boolean throwOnError = true, System.Int32 delayMilliseconds = 250, ResoniteBridge.ResoniteBridgeValue timeout)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureResults", count, attempts, throwOnError, delayMilliseconds, timeout), typeof(ValueTask<bool>)) is ValueTask<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask<bool>");
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

		public RecordSearch(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RecordSearch()
		{
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

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public static implicit operator AssetData(Stream stream)
		{
			return (AssetData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetData", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", stream), typeof(AssetData));
		}

		public static implicit operator AssetData(ResoniteBridge.ResoniteBridgeValue url)
		{
			return (AssetData)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetData", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", url), typeof(AssetData));
		}

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
					return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "appDBURL"), typeof(ResoniteBridge.ResoniteBridgeValue));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "appDBURL", value);
				}
			}

			public System.Int64 bytes
			{
				get
				{
					return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "bytes"), typeof(System.Int64));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "bytes", value);
				}
			}

			public System.String appDBSig
			{
				get
				{
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "appDBSig"), typeof(System.String));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "appDBSig", value);
				}
			}

			public AssetInfo cloudInfo
			{
				get
				{
					return (AssetInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "cloudInfo"), typeof(AssetInfo));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "cloudInfo", value);
				}
			}

			public System.String localFile
			{
				get
				{
					return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "localFile"), typeof(System.String));
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "localFile", value);
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

		protected static System.Boolean LOG_PROGRESS
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordUploadTaskBase", ResoniteBridge.ResoniteBridgeValueType.Type), "LOG_PROGRESS"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordUploadTaskBase", ResoniteBridge.ResoniteBridgeValueType.Type), "LOG_PROGRESS", value);
			}
		}

		private System.String _stageDescription
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_stageDescription"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_stageDescription", value);
			}
		}

		private System.Single preprocessProgress
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "preprocessProgress"), typeof(System.Single));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "preprocessProgress", value);
			}
		}

		private TaskCompletionSource<bool> _completionSource
		{
			get
			{
				return (TaskCompletionSource<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_completionSource"), typeof(TaskCompletionSource<bool>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_completionSource", value);
			}
		}

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

		public System.Boolean IsFinished
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsFinished"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsFinished", value);
			}
		}

		public System.Boolean Failed
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Failed"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Failed", value);
			}
		}

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

		public System.Boolean WasAlreadySynced
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WasAlreadySynced"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WasAlreadySynced", value);
			}
		}

		public System.Single Progress
		{
			get
			{
				return (System.Single)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Progress"), typeof(System.Single));
			}
		}

		public System.String StageDescription
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StageDescription"), typeof(System.String));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StageDescription", value);
			}
		}

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

		public System.Int64 AssetsToUpload
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsToUpload"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsToUpload", value);
			}
		}

		public System.Int64 AssetsUploaded
		{
			get
			{
				return (System.Int64)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsUploaded"), typeof(System.Int64));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsUploaded", value);
			}
		}

		public Task Task
		{
			get
			{
				return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Task"), typeof(Task));
			}
		}

		public R Record
		{
			get
			{
				return (R)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Record"), typeof(R));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Record", value);
			}
		}

		public System.Boolean EnsureFolder
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EnsureFolder"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EnsureFolder", value);
			}
		}

		public List<AssetDiff> AssetDiffs
		{
			get
			{
				return (List<AssetDiff>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetDiffs"), typeof(List<AssetDiff>));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetDiffs", value);
			}
		}

		public System.Boolean ForceConflictSync
		{
			get
			{
				return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceConflictSync"), typeof(System.Boolean));
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForceConflictSync", value);
			}
		}

		public event Action<AssetDiff> AssetToUploadAdded;

		public event Action<long> BytesUploadedAdded;

		public event Action AssetUploaded;

		public event Action<string> AssetMissing;

		protected abstract Task<bool> PrepareFilesForUpload(CancellationToken cancellationToken);

		protected abstract Task StoreSyncedRecord(R record);

		protected abstract ValueTask<AssetData> ReadFile(System.String signature);

		protected virtual ValueTask UploadStarted(System.String signature)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadStarted", signature), typeof(ValueTask)) is ValueTask __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ValueTask");
			}
		}

		protected void Fail(System.String error)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Fail", error);
		}

		protected void FailConflict()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FailConflict");
		}

		private void RemoveManifestDuplicates()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveManifestDuplicates");
		}

		private Task EnsureManifestAssetSizes()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureManifestAssetSizes"), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public Task RunUpload(CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunUpload", cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		private Task<bool> CheckCloudVersion(CancellationToken cancelationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CheckCloudVersion", cancelationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		protected abstract Task<bool> PrepareRecord(CancellationToken cancelationToken);

		private Task<bool> PreprocessRecord(CancellationToken cancelationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PreprocessRecord", cancelationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		private Task<bool> UploadAssets(CancellationToken cancelationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadAssets", cancelationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		private Task<bool> UpsertRecord(CancellationToken cancelationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertRecord", cancelationToken), typeof(Task<bool>)) is Task<bool> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<bool>");
			}
		}

		private Task RunUploadInternal(CancellationToken cancelationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunUploadInternal", cancelationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		private ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public CloudVariableInfo()
		{
		}
	}
	public static class SettingsCloudVariables
	{
		public static CloudVariableInfo LAST_MUTE_STATUS
		{
			get
			{
				return (CloudVariableInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "LAST_MUTE_STATUS"), typeof(CloudVariableInfo));
			}
		}

		public static CloudVariableInfo LAST_ONLINE_STATUS
		{
			get
			{
				return (CloudVariableInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "LAST_ONLINE_STATUS"), typeof(CloudVariableInfo));
			}
		}

		public static ResoniteBridge.ResoniteBridgeValue DEFAULT_DASH_OFFSET
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DASH_OFFSET"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
		}

		public static CloudVariableInfo DASH_OFFSET
		{
			get
			{
				return (CloudVariableInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DASH_OFFSET"), typeof(CloudVariableInfo));
			}
		}

		public static CloudVariableInfo DASH_SCALE
		{
			get
			{
				return (CloudVariableInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DASH_SCALE"), typeof(CloudVariableInfo));
			}
		}

		public static CloudVariableInfo DASH_FREEFORM
		{
			get
			{
				return (CloudVariableInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DASH_FREEFORM"), typeof(CloudVariableInfo));
			}
		}

		public static IEnumerable<CloudVariableInfo> AllSettings
		{
			get
			{
				return (IEnumerable<CloudVariableInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "AllSettings"), typeof(IEnumerable<CloudVariableInfo>));
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

		public override ResoniteBridge.ResoniteBridgeValue CloseStatus
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CloseStatus"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
		}

		public override System.String CloseStatusDescription
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CloseStatusDescription"), typeof(System.String));
			}
		}

		public override System.String SubProtocol
		{
			get
			{
				return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubProtocol"), typeof(System.String));
			}
		}

		public override ResoniteBridge.ResoniteBridgeValue State
		{
			get
			{
				return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(ResoniteBridge.ResoniteBridgeValue));
			}
		}

		public static Task<SignalRWebSocket> Create(ResoniteBridge.ResoniteBridgeValue context, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SignalRWebSocket", ResoniteBridge.ResoniteBridgeValueType.Type), "Create", context, cancellationToken), typeof(Task<SignalRWebSocket>)) is Task<SignalRWebSocket> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<SignalRWebSocket>");
			}
		}

		public Task Connect(ResoniteBridge.ResoniteBridgeValue uri, ResoniteBridge.ResoniteBridgeValue options, CancellationToken token)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Connect", uri, options, token), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public override void Abort()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Abort");
		}

		public override Task CloseAsync(ResoniteBridge.ResoniteBridgeValue closeStatus, System.String statusDescription, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloseAsync", closeStatus, statusDescription, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public override Task CloseOutputAsync(ResoniteBridge.ResoniteBridgeValue closeStatus, System.String statusDescription, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloseOutputAsync", closeStatus, statusDescription, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
			}
		}

		public override void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public override Task<ResoniteBridge.ResoniteBridgeValue> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveAsync", buffer, cancellationToken), typeof(Task<ResoniteBridge.ResoniteBridgeValue>)) is Task<ResoniteBridge.ResoniteBridgeValue> __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task<WebSocketReceiveResult>");
			}
		}

		public override Task SendAsync(ArraySegment<byte> buffer, ResoniteBridge.ResoniteBridgeValue messageType, System.Boolean endOfMessage, CancellationToken cancellationToken)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendAsync", buffer, messageType, endOfMessage, cancellationToken), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public SignalRWebSocket(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SignalRWebSocket()
		{
		}
	}
	public static class TemporaryUtility
	{
		public static System.String FilterViveportUsername(System.String username)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "TemporaryUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "FilterViveportUsername", username), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}
	}
	public static class UID
	{
		public static System.String Compute()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UID", ResoniteBridge.ResoniteBridgeValueType.Type), "Compute"), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
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

		protected override Task RunBatch(List<QueryResult> batch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public VariableReadBatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public VariableReadBatchQuery()
		{
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

		protected override Task RunBatch(List<QueryResult> batch)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task)) is Task __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Task");
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

		public VariableWriteBatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public VariableWriteBatchQuery()
		{
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

		public static RegistryProxyConfiguration From(System.String proxyServer = "", System.String proxyOverride = "")
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RegistryProxyConfiguration", ResoniteBridge.ResoniteBridgeValueType.Type), "From", proxyServer, proxyOverride), typeof(RegistryProxyConfiguration)) is RegistryProxyConfiguration __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RegistryProxyConfiguration");
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

		public RegistryProxyConfiguration(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RegistryProxyConfiguration()
		{
		}
	}
	public class WebProxyUtility : ResoniteBridge.ResoniteBridgeValueHolder
	{
		private static ResoniteBridge.ResoniteBridgeValue SetupCredentials(ProxyConfig config)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "SetupCredentials", config), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ICredentials");
			}
		}

		public static ResoniteBridge.ResoniteBridgeValue CreateProxy(ProxyConfig config)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateProxy", config), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to WebProxy?");
			}
		}

		public static ResoniteBridge.ResoniteBridgeValue MakeAbsolouteProxyAddress(ResoniteBridge.ResoniteBridgeValue uri)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "MakeAbsolouteProxyAddress", uri), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to Uri");
			}
		}

		public static System.String MakeAbsolouteProxyAddress(System.String str)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "MakeAbsolouteProxyAddress", str), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string");
			}
		}

		private static ProxyConfig HydrateProxyConfiguration(ProxyConfig initialConfig)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "HydrateProxyConfiguration", initialConfig), typeof(ProxyConfig)) is ProxyConfig __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ProxyConfig");
			}
		}

		private static ProxyConfig GenerateProxySettingsFromDefaultWebProxy(ProxyConfig initialConfig)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateProxySettingsFromDefaultWebProxy", initialConfig), typeof(ProxyConfig)) is ProxyConfig __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ProxyConfig");
			}
		}

		private static ResoniteBridge.ResoniteBridgeValue GetProxyConfigFromRegistry()
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GetProxyConfigFromRegistry"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to RegistryProxyConfiguration?");
			}
		}

		public static ResoniteBridge.ResoniteBridgeValue GenerateProxyConfigFromRegistry(ResoniteBridge.ResoniteBridgeValue registryValues)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateProxyConfigFromRegistry", registryValues), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to ProxyConfig?");
			}
		}

		private static System.String GetDomainFromProxyOverride(System.String domain)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GetDomainFromProxyOverride", domain), typeof(System.String)) is System.String __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to string?");
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

		public WebProxyUtility(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}
	}
}
