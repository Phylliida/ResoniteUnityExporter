using ResoniteBridge;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Sockets;
using System.Net.WebSockets;
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
using System.Threading.Tasks.Dataflow;
using Elements.Assets;
using Elements.Core;
using EnumsNET;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Http.Connections.Client;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.CodeAnalysis;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SignalR.Strong;

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
		public IAccountDataStore source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "source"), typeof(IAccountDataStore)) is IAccountDataStore __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IAccountDataStore");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "source", value);
			}
		}

		public AccountDataStoreUploadTask(SkyFrostInterface cloud, IAccountDataStore source, Record record)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AccountDataStoreUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), cloud, source, record);
		}

		public override ValueTask<AssetData> ReadFile(System.String signature)
		{
			return (ValueTask<AssetData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadFile", signature), typeof(ValueTask<AssetData>));
		}

		public override Task<bool> PrepareFilesForUpload(CancellationToken cancellationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrepareFilesForUpload", cancellationToken), typeof(Task<bool>));
		}

		public override Task<bool> PrepareRecord(CancellationToken cancelationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PrepareRecord", cancelationToken), typeof(Task<bool>));
		}

		public override Task StoreSyncedRecord(Record record)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreSyncedRecord", record), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public IAccountDataStore source
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "source"), typeof(IAccountDataStore)) is IAccountDataStore __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IAccountDataStore");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "source", value);
			}
		}

		public IAccountDataStore target
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "target"), typeof(IAccountDataStore)) is IAccountDataStore __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IAccountDataStore");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "target", value);
			}
		}

		public AccountMigrationConfig config
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "config"), typeof(AccountMigrationConfig)) is AccountMigrationConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AccountMigrationConfig");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProgressMessage"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactsCompleted"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactsCompleted", value);
			}
		}

		public System.Boolean UserOwnedCompleted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserOwnedCompleted"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserOwnedCompleted", value);
			}
		}

		public HashSet<string> GroupsCompleted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupsCompleted"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupsCompleted", value);
			}
		}

		public AccountMigrationStatus Status
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(AccountMigrationStatus)) is AccountMigrationStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AccountMigrationStatus");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Status", value);
			}
		}

		public event Action<string> ProgressMessagePosted;

		public AccountTransferController(IAccountDataStore source, IAccountDataStore target, System.String migrationId, AccountMigrationConfig config)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AccountTransferController", ResoniteBridge.ResoniteBridgeValueType.Type), source, target, migrationId, config);
		}

		public void SetProgressMessage(System.String message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetProgressMessage", message);
		}

		public System.Boolean ProcessRecord(Record record)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessRecord", record), typeof(System.Boolean));
		}

		public System.Boolean ProcessContact(Contact contact)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessContact", contact), typeof(System.Boolean));
		}

		public System.Boolean ProcessGroup(Group group)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessGroup", group), typeof(System.Boolean));
		}

		public Task<bool> Transfer(CancellationToken cancellationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Transfer", cancellationToken), typeof(Task<bool>));
		}

		public Task TransferUserProfileData()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferUserProfileData"), typeof(Task));
		}

		public Task TransferFundingEvents()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferFundingEvents"), typeof(Task));
		}

		public Task TransferExitMessages()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferExitMessages"), typeof(Task));
		}

		public Task TransferOwned(System.String ownerId, RecordMigrationStatus recordsStatus, VariableMigrationStatus variablesStatus, List<string> recordsToMigrate, List<string> variablesToMigrate, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferOwned", ownerId, recordsStatus, variablesStatus, recordsToMigrate, variablesToMigrate, cancellationToken), typeof(Task));
		}

		public Task TrasnferRecordAuditLog(System.String ownerId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TrasnferRecordAuditLog", ownerId), typeof(Task));
		}

		public Task TransferSelectedRecords(System.String ownerId, RecordMigrationStatus recordsStatus, List<string> recordsToMigrate)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferSelectedRecords", ownerId, recordsStatus, recordsToMigrate), typeof(Task));
		}

		public Task TransferVariables(System.String ownerId, VariableMigrationStatus status, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferVariables", ownerId, status, cancellationToken), typeof(Task));
		}

		public Task TransferVariableDefinitions(System.String ownerId, VariableMigrationStatus status, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferVariableDefinitions", ownerId, status, cancellationToken), typeof(Task));
		}

		public RecordStatusCallbacks SetupCallbacks(RecordMigrationStatus status)
		{
			return (RecordStatusCallbacks)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetupCallbacks", status), typeof(RecordStatusCallbacks));
		}

		public Task TransferRecords(System.String ownerId, RecordMigrationStatus status, System.Boolean onlyNew, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferRecords", ownerId, status, onlyNew, cancellationToken), typeof(Task));
		}

		public Task TransferContacts(CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferContacts", cancellationToken), typeof(Task));
		}

		public Task TransferMessages(Contact contact, System.String contactId, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferMessages", contact, contactId, cancellationToken), typeof(Task));
		}

		public Task TransferMembers(Group group, GroupMigrationStatus groupStatus, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TransferMembers", group, groupStatus, cancellationToken), typeof(Task));
		}

		public void HandleRecordError(RecordMigrationStatus status, Record record, System.String error)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HandleRecordError", status, record, error);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Cloud"), typeof(SkyFrostInterface)) is SkyFrostInterface __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Cloud", value);
			}
		}

		public static HashSet<string> CONFLICTING_IDS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudAccountDataStore", ResoniteBridge.ResoniteBridgeValueType.Type), "CONFLICTING_IDS"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudAccountDataStore", ResoniteBridge.ResoniteBridgeValueType.Type), "CONFLICTING_IDS", value);
			}
		}

		public Dictionary<string, int> _fetchedRecords
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

		public System.Boolean PreserveOldHome
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreserveOldHome"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreserveOldHome", value);
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
		}

		public event Action<string> ProgressMessage;

		public System.Int32 FetchedRecordCount(System.String ownerId)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchedRecordCount", ownerId), typeof(System.Int32));
		}

		public CloudAccountDataStore(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudAccountDataStore", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public virtual Task Prepare()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Prepare"), typeof(Task));
		}

		public virtual Task Complete()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Complete"), typeof(Task));
		}

		public virtual Task<User> GetUser()
		{
			return (Task<User>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser"), typeof(Task<User>));
		}

		public virtual Task<List<ExitMessage>> GetExitMessages()
		{
			return (Task<List<ExitMessage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetExitMessages"), typeof(Task<List<ExitMessage>>));
		}

		public virtual Task<List<PatreonFundingEvent>> GetPatreonFundingEvents()
		{
			return (Task<List<PatreonFundingEvent>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<List<PatreonFundingEvent>>));
		}

		public virtual Task<List<Contact>> GetContacts()
		{
			return (Task<List<Contact>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetContacts"), typeof(Task<List<Contact>>));
		}

		public virtual IAsyncEnumerable<Message> GetMessages(System.String contactId, DateTime? from)
		{
			return (IAsyncEnumerable<Message>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", contactId, from), typeof(IAsyncEnumerable<Message>));
		}

		public virtual IAsyncEnumerable<GroupData> GetGroups()
		{
			return (IAsyncEnumerable<GroupData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroups"), typeof(IAsyncEnumerable<GroupData>));
		}

		public virtual Task<List<MemberData>> GetMembers(System.String groupId)
		{
			return (Task<List<MemberData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMembers", groupId), typeof(Task<List<MemberData>>));
		}

		public virtual Task<Record> GetRecord(System.String ownerId, System.String recordId)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId), typeof(Task<Record>));
		}

		public virtual IAsyncEnumerable<Record> GetRecords(System.String ownerId, DateTime? from, Action<string> searchProgressReport = null)
		{
			return (IAsyncEnumerable<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(IAsyncEnumerable<Record>));
		}

		public IAsyncEnumerable<RecordAuditInfo> GetRecordAuditLog(System.String ownerId)
		{
			return (IAsyncEnumerable<RecordAuditInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId), typeof(IAsyncEnumerable<RecordAuditInfo>));
		}

		public Task<Record> FillRecordDetails(Record r)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FillRecordDetails", r), typeof(Task<Record>));
		}

		public virtual Task<List<CloudVariableDefinition>> GetVariableDefinitions(System.String ownerId)
		{
			return (Task<List<CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariableDefinitions", ownerId), typeof(Task<List<CloudVariableDefinition>>));
		}

		public virtual Task<List<CloudVariable>> GetVariables(System.String ownerId)
		{
			return (Task<List<CloudVariable>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariables", ownerId), typeof(Task<List<CloudVariable>>));
		}

		public virtual Task<CloudVariable> GetVariable(System.String ownerId, System.String path)
		{
			return (Task<CloudVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", ownerId, path), typeof(Task<CloudVariable>));
		}

		public virtual Task<DateTime> GetLatestMessageTime(System.String contactId)
		{
			return (Task<DateTime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestMessageTime", contactId), typeof(Task<DateTime>));
		}

		public virtual Task<DateTime?> GetLatestRecordTime(System.String ownerId)
		{
			return (Task<DateTime?>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestRecordTime", ownerId), typeof(Task<DateTime?>));
		}

		public virtual Task StoreDefinitions(List<CloudVariableDefinition> definitions, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreDefinitions", definitions, source), typeof(Task));
		}

		public virtual Task StoreContact(Contact contact, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreContact", contact, source), typeof(Task));
		}

		public virtual Task StoreMessage(Message message, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message, source), typeof(Task));
		}

		public virtual Task StoreVariables(List<CloudVariable> variables, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVariables", variables, source), typeof(Task));
		}

		public virtual Task StoreGroup(Group group, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreGroup", group, storage, source), typeof(Task));
		}

		public virtual Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMember", group, member, storage, source), typeof(Task));
		}

		public virtual Task StoreUserData(User user)
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

		public virtual Task<StoreResultData> StoreRecord(Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks, System.Boolean overwriteOnConflict)
		{
			return (Task<StoreResultData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecord", record, source, statusCallbacks, overwriteOnConflict), typeof(Task<StoreResultData>));
		}

		public virtual Task DownloadAsset(System.String hash, System.String targetPath)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DownloadAsset", hash, targetPath), typeof(Task));
		}

		public virtual Task<long> GetAssetSize(System.String hash)
		{
			return (Task<long>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetSize", hash), typeof(Task<long>));
		}

		public virtual Task<string> GetAsset(System.String hash)
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAsset", hash), typeof(Task<string>));
		}

		public virtual Task<AssetData> ReadAsset(System.String hash)
		{
			return (Task<AssetData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadAsset", hash), typeof(Task<AssetData>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "result"), typeof(RecordStoreResult)) is RecordStoreResult __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordStoreResult");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "error"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "error", value);
			}
		}

		public StoreResultData(RecordStoreResult result, System.String error = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "StoreResultData", ResoniteBridge.ResoniteBridgeValueType.Type), result, error);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "group"), typeof(Group)) is Group __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Group");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "storage"), typeof(Storage)) is Storage __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Storage");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "storage", value);
			}
		}

		public GroupData(Group group, Storage storage)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "GroupData", ResoniteBridge.ResoniteBridgeValueType.Type), group, storage);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "member"), typeof(Member)) is Member __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Member");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "storage"), typeof(Storage)) is Storage __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Storage");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "storage", value);
			}
		}

		public MemberData(Member member, Storage storage)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MemberData", ResoniteBridge.ResoniteBridgeValueType.Type), member, storage);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetToUploadAdded"), typeof(Action<AssetDiff>)) is Action<AssetDiff> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<AssetDiff>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BytesUploaded"), typeof(Action<long>)) is Action<long> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<long>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetUploaded"), typeof(Action)) is Action __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetMissing"), typeof(Action<string>)) is Action<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<string>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MigrationStarted"), typeof(Action<string>)) is Action<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<string>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MigrationFinished"), typeof(Action<string>)) is Action<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MigrationFinished", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		IPlatformProfile PlatformProfile
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
		}

		System.String MigrationId
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

		System.String UserId
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
		}

		System.String Username
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
		}

		System.Int32 FetchedGroupCount
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

		IAsyncEnumerable<GroupData> GetGroups();

		Task<List<MemberData>> GetMembers(System.String groupId);

		Task<Record> GetRecord(System.String ownerId, System.String recordId);

		IAsyncEnumerable<Record> GetRecords(System.String ownerId, DateTime? from, Action<string> searchProgressReport = null);

		IAsyncEnumerable<RecordAuditInfo> GetRecordAuditLog(System.String ownerId);

		Task<List<Contact>> GetContacts();

		IAsyncEnumerable<Message> GetMessages(System.String contactId, DateTime? from);

		Task<DateTime?> GetLatestRecordTime(System.String ownerId);

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
		public struct AssetJob : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public System.String hash
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "hash"), typeof(System.String)) is System.String __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to string");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "hash", value);
				}
			}

			public IAccountDataStore source
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "source"), typeof(IAccountDataStore)) is IAccountDataStore __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to IAccountDataStore");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "source", value);
				}
			}

			public AssetJob(System.String hash, IAccountDataStore source)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetJob", ResoniteBridge.ResoniteBridgeValueType.Type), hash, source);
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

		public ActionBlock<AssetJob> downloadProcessor
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "downloadProcessor"), typeof(ActionBlock<AssetJob>)) is ActionBlock<AssetJob> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ActionBlock<AssetJob>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "downloadProcessor", value);
			}
		}

		public HashSet<string> scheduledAssets
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "scheduledAssets"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "scheduledAssets", value);
			}
		}

		public System.String BasePath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BasePath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AssetsPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AssetsPath", value);
			}
		}

		public Dictionary<string, int> _fetchedRecords
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

		public event Action<string> ProgressMessage;

		public System.Int32 FetchedRecordCount(System.String ownerId)
		{
			return (System.Int32)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchedRecordCount", ownerId), typeof(System.Int32));
		}

		public LocalAccountDataStore(IPlatformProfile platform, System.String userId, System.String basePath, System.String assetsPath)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "LocalAccountDataStore", ResoniteBridge.ResoniteBridgeValueType.Type), platform, userId, basePath, assetsPath);
		}

		public Task Prepare()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Prepare"), typeof(Task));
		}

		public Task Complete()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Complete"), typeof(Task));
		}

		public void InitDownloadProcessor()
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

		public IAsyncEnumerable<RecordAuditInfo> GetRecordAuditLog(System.String ownerId)
		{
			return (IAsyncEnumerable<RecordAuditInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId), typeof(IAsyncEnumerable<RecordAuditInfo>));
		}

		public Task<User> GetUser()
		{
			return (Task<User>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUser"), typeof(Task<User>));
		}

		public Task<List<PatreonFundingEvent>> GetPatreonFundingEvents()
		{
			return (Task<List<PatreonFundingEvent>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetPatreonFundingEvents"), typeof(Task<List<PatreonFundingEvent>>));
		}

		public IAsyncEnumerable<Message> GetMessages(System.String contactId, DateTime? from)
		{
			return (IAsyncEnumerable<Message>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessages", contactId, from), typeof(IAsyncEnumerable<Message>));
		}

		public Task<Record> GetRecord(System.String ownerId, System.String recordId)
		{
			return (Task<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecord", ownerId, recordId), typeof(Task<Record>));
		}

		public IAsyncEnumerable<Record> GetRecords(System.String ownerId, DateTime? from, Action<string> searchProgressReport = null)
		{
			return (IAsyncEnumerable<Record>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecords", ownerId, from, searchProgressReport), typeof(IAsyncEnumerable<Record>));
		}

		public Task<List<CloudVariableDefinition>> GetVariableDefinitions(System.String ownerId)
		{
			return (Task<List<CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariableDefinitions", ownerId), typeof(Task<List<CloudVariableDefinition>>));
		}

		public Task<List<CloudVariable>> GetVariables(System.String ownerId)
		{
			return (Task<List<CloudVariable>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariables", ownerId), typeof(Task<List<CloudVariable>>));
		}

		public Task<CloudVariable> GetVariable(System.String ownerId, System.String path)
		{
			return (Task<CloudVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetVariable", ownerId, path), typeof(Task<CloudVariable>));
		}

		public IAsyncEnumerable<GroupData> GetGroups()
		{
			return (IAsyncEnumerable<GroupData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGroups"), typeof(IAsyncEnumerable<GroupData>));
		}

		public Task<List<MemberData>> GetMembers(System.String groupId)
		{
			return (Task<List<MemberData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMembers", groupId), typeof(Task<List<MemberData>>));
		}

		public Task<List<T>> GetEntities<T>(System.String path)
		{
			return (Task<List<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEntities", path), typeof(Task<List<T>>));
		}

		public T GetEntity<T>(System.String path)
		{
			return (T)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetEntity", path), typeof(T));
		}

		public Task StoreDefinitions(List<CloudVariableDefinition> definitions, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreDefinitions", definitions, source), typeof(Task));
		}

		public Task StoreVariables(List<CloudVariable> variables, IAccountDataStore source)
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

		public Task<StoreResultData> StoreRecord(Record record, IAccountDataStore source, RecordStatusCallbacks statusCallbacks, System.Boolean overwriteOnConflict)
		{
			return (Task<StoreResultData>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecord", record, source, statusCallbacks, overwriteOnConflict), typeof(Task<StoreResultData>));
		}

		public Task StoreGroup(Group group, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreGroup", group, storage, source), typeof(Task));
		}

		public Task StoreMember(Group group, Member member, Storage storage, IAccountDataStore source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMember", group, member, storage, source), typeof(Task));
		}

		public Task StoreRecordAudit(RecordAuditInfo info)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreRecordAudit", info), typeof(Task));
		}

		public Task StoreUserData(User user)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreUserData", user), typeof(Task));
		}

		public Task StoreFundingEvent(PatreonFundingEvent fundingEvent)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreFundingEvent", fundingEvent), typeof(Task));
		}

		public Task StoreExitMessage(ExitMessage exitMessage)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreExitMessage", exitMessage), typeof(Task));
		}

		public Task StoreEntity<T>(T entity, System.String path)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreEntity", entity, path), typeof(Task));
		}

		public System.String UserPath()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UserPath"), typeof(System.String));
		}

		public System.String PatreonPath()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PatreonPath"), typeof(System.String));
		}

		public System.String ExitMessagesPath()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExitMessagesPath"), typeof(System.String));
		}

		public System.String VariableDefinitionPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariableDefinitionPath", ownerId), typeof(System.String));
		}

		public System.String VariablePath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "VariablePath", ownerId), typeof(System.String));
		}

		public System.String ContactsPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactsPath", ownerId), typeof(System.String));
		}

		public System.String MessagesPath(System.String ownerId, System.String contactId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MessagesPath", ownerId, contactId), typeof(System.String));
		}

		public System.String RecordsPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordsPath", ownerId), typeof(System.String));
		}

		public System.String RecordAuditPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordAuditPath", ownerId), typeof(System.String));
		}

		public System.String GroupsPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GroupsPath", ownerId), typeof(System.String));
		}

		public System.String MembersPath(System.String ownerId, System.String groupId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MembersPath", ownerId, groupId), typeof(System.String));
		}

		public System.String GetAssetPath(System.String hash)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetPath", hash), typeof(System.String));
		}

		public Task<DateTime> GetLatestMessageTime(System.String contactId)
		{
			return (Task<DateTime>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestMessageTime", contactId), typeof(Task<DateTime>));
		}

		public Task<DateTime?> GetLatestRecordTime(System.String ownerId)
		{
			return (Task<DateTime?>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetLatestRecordTime", ownerId), typeof(Task<DateTime?>));
		}

		public void ScheduleAsset(System.String hash, IAccountDataStore store)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public LocalAccountDataStore()
		{
		}
	}
	public static class MigrationHelper
	{
		public struct MigrationGroup : IEquatable<MigrationGroup>, ResoniteBridge.ResoniteBridgeValueHolder
		{
			public IPlatformProfile from
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "from"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "from", value);
				}
			}

			public IPlatformProfile to
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "to"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "to", value);
				}
			}

			public MigrationGroup(IPlatformProfile from, IPlatformProfile to)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), from, to);
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}

			public static bool operator !=(MigrationGroup left, MigrationGroup right)
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationGroup", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

		public static ResoniteBridge.ResoniteBridgeValue migrationStrings
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "migrationStrings"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<MigrationGroup, SortedDictionary<string, string>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "migrationStrings", value);
			}
		}

		public static SortedDictionary<string, string> GetMigrationStrings(IPlatformProfile from, IPlatformProfile to)
		{
			return (SortedDictionary<string, string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMigrationStrings", from, to), typeof(SortedDictionary<string, string>));
		}

		public static System.Uri MigrateLegacyURL(this System.Uri url, IPlatformProfile to)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateLegacyURL", url, to), typeof(System.Uri));
		}

		public static System.Uri MigrateURL(this System.Uri url, IPlatformProfile from, IPlatformProfile to)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationHelper", ResoniteBridge.ResoniteBridgeValueType.Type), "MigrateURL", url, from, to), typeof(System.Uri));
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

		[System.Text.Json.Serialization.JsonIgnore]
		public ApiClient Api
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient)) is ApiClient __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ApiClient");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public User CurrentUser
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User)) is User __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to User");
				}
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		public System.String CurrentUserID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserID"), typeof(System.String)) is System.String __retCasted)
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
		}

		public void Initialize(SkyFrostInterface cloud)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", cloud);
		}

		public abstract System.Uri DBToHttp(System.Uri productDBUri, DB_Endpoint endpoint);

		public abstract System.Uri ThumbnailToHttp(ThumbnailInfo thumbnail);

		public Task<Stream> GatherAsset(System.String signature)
		{
			return (Task<Stream>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GatherAsset", signature), typeof(Task<Stream>));
		}

		public System.Uri FilterDatabaseURL(System.Uri assetURL)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FilterDatabaseURL", assetURL), typeof(System.Uri));
		}

		public System.Uri GenerateURL(System.String signature)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateURL", signature), typeof(System.Uri));
		}

		public System.Uri GenerateURLWithExtension(System.String signature, System.String extension)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateURLWithExtension", signature, extension), typeof(System.Uri));
		}

		public System.String DBSignature(System.Uri dbUri, System.Boolean ignoreScheme = false)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBSignature", dbUri, ignoreScheme), typeof(System.String));
		}

		public System.String DBSignature(System.Uri dbUri, out System.String extension, System.Boolean ignoreScheme = false)
		{
			string __finalResult = (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethodWithRefsAndOuts(__Backing, "DBSignature", out ResoniteBridge.ResoniteBridgeValue[] __outVars, dbUri, ignoreScheme), typeof(System.String));
			extension = (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.String));
			return __finalResult;
		}

		public System.String DBQuery(System.Uri dbUri)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBQuery", dbUri), typeof(System.String));
		}

		public System.String DBFilename(System.Uri dbUri)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBFilename", dbUri), typeof(System.String));
		}

		public System.Boolean IsValidDBUri(System.String uri)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidDBUri", uri), typeof(System.Boolean));
		}

		public System.Boolean IsValidDBUri(System.Uri uri)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidDBUri", uri), typeof(System.Boolean));
		}

		public System.Boolean IsLegacyDB(System.Uri uri)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsLegacyDB", uri), typeof(System.Boolean));
		}

		public Task<CloudResult<AssetInfo>> GetGlobalAssetInfo(System.String hash)
		{
			return (Task<CloudResult<AssetInfo>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetGlobalAssetInfo", hash), typeof(Task<CloudResult<AssetInfo>>));
		}

		public Task<CloudResult<AssetInfo>> GetUserAssetInfo(System.String hash)
		{
			return (Task<CloudResult<AssetInfo>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserAssetInfo", hash), typeof(Task<CloudResult<AssetInfo>>));
		}

		public Task<CloudResult<AssetInfo>> GetAssetInfo(System.String ownerId, System.String hash)
		{
			return (Task<CloudResult<AssetInfo>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetInfo", ownerId, hash), typeof(Task<CloudResult<AssetInfo>>));
		}

		public Task<bool> IsValidShader(System.String hash)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "IsValidShader", hash), typeof(Task<bool>));
		}

		public AssetUploadTask CreateFileAssetUploadTask(System.String ownerId, System.String signature, System.String variant, System.String assetPath, IProgressIndicator progress = null, System.Int32 retries = 5)
		{
			return (AssetUploadTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateFileAssetUploadTask", ownerId, signature, variant, assetPath, progress, retries), typeof(AssetUploadTask));
		}

		public AssetUploadTask CreateStreamAssetUploadTask(System.String ownerId, System.String signature, System.String variant, Stream assetStream, IProgressIndicator progress = null, long? bytes = null, System.Int32 retries = 5)
		{
			return (AssetUploadTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateStreamAssetUploadTask", ownerId, signature, variant, assetStream, progress, bytes, retries), typeof(AssetUploadTask));
		}

		public AssetUploadTask CreateURLAssetUploadTask(System.String ownerId, System.String signature, System.String variant, System.Uri assetURL, IProgressIndicator progress = null, long? bytes = null, System.Int32 retries = 5)
		{
			return (AssetUploadTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateURLAssetUploadTask", ownerId, signature, variant, assetURL, progress, bytes, retries), typeof(AssetUploadTask));
		}

		public Task<CloudResult> GetAssetMime(System.Uri url)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMime", url), typeof(Task<CloudResult>));
		}

		public abstract Task<CloudResult> GetAssetMime(System.String hash);

		public abstract Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String session);

		public abstract AssetUploadTask CreateEmptyAssetUploadTask();

		public System.String GetAssetBaseURL(System.String ownerId, System.String hash, System.String variant)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetBaseURL", ownerId, hash, variant), typeof(System.String));
		}

		public Task<CloudResult<List<string>>> GetAvailableVariants(System.Uri dbUrl)
		{
			return (Task<CloudResult<List<string>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAvailableVariants", dbUrl), typeof(Task<CloudResult<List<string>>>));
		}

		public abstract Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash);

		public Task<CloudResult<List<T>>> GetAssetMetadata<T>(List<string> hashes) where T : class, IAssetMetadata, new()
		{
			return (Task<CloudResult<List<T>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMetadata", hashes), typeof(Task<CloudResult<List<T>>>));
		}

		public Task<CloudResult<IAssetMetadata>> GetAssetMetadata(AssetVariantType variantType, System.String hash)
		{
			return (Task<CloudResult<IAssetMetadata>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMetadata", variantType, hash), typeof(Task<CloudResult<IAssetMetadata>>));
		}

		public Task<CloudResult<T>> GetAssetMetadata<T>(System.String hash) where T : class, IAssetMetadata, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMetadata", hash), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<List<string>>> RequestAssetVariant(System.String hash, IAssetVariantDescriptor descriptor)
		{
			return (Task<CloudResult<List<string>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestAssetVariant", hash, descriptor), typeof(Task<CloudResult<List<string>>>));
		}

		public Task<CloudResult> StoreAssetMetadata(IAssetMetadata metadata)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreAssetMetadata", metadata), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<BitmapMetadata>> GetBitmapMetadata(System.String hash)
		{
			return (Task<CloudResult<BitmapMetadata>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBitmapMetadata", hash), typeof(Task<CloudResult<BitmapMetadata>>));
		}

		public Task<CloudResult<List<BitmapMetadata>>> GetBitmapMetadata(List<string> hashes)
		{
			return (Task<CloudResult<List<BitmapMetadata>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBitmapMetadata", hashes), typeof(Task<CloudResult<List<BitmapMetadata>>>));
		}

		public Task<CloudResult> StoreBitmapMetadata(System.String hash, BitmapMetadata metadata)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreBitmapMetadata", hash, metadata), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<CubemapMetadata>> GetCubemapMetadata(System.String hash)
		{
			return (Task<CloudResult<CubemapMetadata>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCubemapMetadata", hash), typeof(Task<CloudResult<CubemapMetadata>>));
		}

		public Task<CloudResult<List<CubemapMetadata>>> GetCubemapMetadata(List<string> hashes)
		{
			return (Task<CloudResult<List<CubemapMetadata>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCubemapMetadata", hashes), typeof(Task<CloudResult<List<CubemapMetadata>>>));
		}

		public Task<CloudResult> StoreCubemapMetadata(System.String hash, CubemapMetadata metadata)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreCubemapMetadata", hash, metadata), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> StoreVolumeMetadata(System.String hash, VolumeMetadata metadata)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreVolumeMetadata", hash, metadata), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> StoreMeshMetadata(System.String hash, MeshMetadata metadata)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMeshMetadata", hash, metadata), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> StoreShaderMetadata(System.String hash, ShaderMetadata metadata)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreShaderMetadata", hash, metadata), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>> GetAssetComputationTask(System.Boolean usePoisonQueue = false)
		{
			return (Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetComputationTask", usePoisonQueue), typeof(Task<CloudResult<ExternalQueueObject<AssetVariantComputationTask>>>));
		}

		public Task<CloudResult> ExtendAssetComputationTask(ExternalQueueObject<AssetVariantComputationTask> task)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtendAssetComputationTask", task), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> FinishAssetComputation(ExternalQueueObject<AssetVariantComputationTask> task)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishAssetComputation", task), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> FinishVariantComputation(System.String hash, System.String variantId)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishVariantComputation", hash, variantId), typeof(Task<CloudResult>));
		}

		public static System.String GetMetadataURLSegment(Type type)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "GetMetadataURLSegment", type), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetInterface(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_UPLOAD"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_UPLOAD", value);
			}
		}

		public Stream assetStream
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetStream"), typeof(Stream)) is Stream __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stream");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetStream", value);
			}
		}

		public System.String assetPath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetPath", value);
			}
		}

		public System.Uri assetURL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetURL"), typeof(System.Uri)) is System.Uri __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetURL", value);
			}
		}

		public System.String assetFileName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetFileName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		public ApiClient Api
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient)) is ApiClient __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ApiClient");
				}
			}
		}

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

		public System.Int32 Retries
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Retries"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Retries", value);
			}
		}

		public System.Boolean IsOptional
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsOptional"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsOptional", value);
			}
		}

		public IProgressIndicator Progress
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Progress"), typeof(IProgressIndicator)) is IProgressIndicator __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IProgressIndicator");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadData"), typeof(CloudResult<AssetUploadData>)) is CloudResult<AssetUploadData> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudResult<AssetUploadData>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadStarted"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadStarted", value);
			}
		}

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

		public System.Int32 EnqueuedChunks
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EnqueuedChunks"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EnqueuedChunks", value);
			}
		}

		public System.Int32 UploadedChunks
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UploadedChunks"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UploadedChunks", value);
			}
		}

		public abstract System.Int32 MaxParallelChunks { get; }

		public void InitializeWithFile(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, System.String assetPath, IProgressIndicator progress = null, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeWithFile", cloud, ownerId, signature, variant, assetPath, progress, retries);
		}

		public void InitializeWithStream(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, Stream assetStream, IProgressIndicator progress = null, long? bytes = null, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeWithStream", cloud, ownerId, signature, variant, assetStream, progress, bytes, retries);
		}

		public void InitializeWithURL(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, System.Uri url, IProgressIndicator progress = null, long? bytes = null, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeWithURL", cloud, ownerId, signature, variant, url, progress, bytes, retries);
		}

		public void Initialize(SkyFrostInterface cloud, System.String ownerId, System.String signature, System.String variant, System.String assetPath, Stream assetStream, System.Uri assetURL, IProgressIndicator progress = null, long? bytes = null, System.Int32 retries = 5)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", cloud, ownerId, signature, variant, assetPath, assetStream, assetURL, progress, bytes, retries);
		}

		public Task<CloudResult<AssetUploadData>> RunUpload()
		{
			return (Task<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunUpload"), typeof(Task<CloudResult<AssetUploadData>>));
		}

		public abstract Task<CloudResult<AssetUploadData>> UploadAssetData();

		public abstract ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing();

		public virtual void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		public void DisposeOfStream()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DisposeOfStream");
		}

		public virtual void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public AssetUploadTask()
		{
		}
	}
	public abstract class AssetUploadTask<TChunkResult> : AssetUploadTask, ResoniteBridge.ResoniteBridgeValueHolder where TChunkResult : class
	{
		public class UploadChunkBuffer : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public byte[] data
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "data"), typeof(byte[])) is byte[] __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "data", value);
				}
			}

			public Task<CloudResult<TChunkResult>> task
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "task"), typeof(Task<CloudResult<TChunkResult>>)) is Task<CloudResult<TChunkResult>> __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Task<CloudResult<TChunkResult>>");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "chunk"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "chunk", value);
				}
			}

			public System.Int32 length
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "length"), typeof(System.Int32)) is System.Int32 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "length", value);
				}
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

		public void EnqueueChunk(UploadChunkBuffer buffer, List<UploadChunkBuffer> processingBuffers)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnqueueChunk", buffer, processingBuffers);
		}

		public Task<UploadChunkBuffer> TakeFinishedBuffer(List<UploadChunkBuffer> buffers)
		{
			return (Task<UploadChunkBuffer>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TakeFinishedBuffer", buffers), typeof(Task<UploadChunkBuffer>));
		}

		public override Task<CloudResult<AssetUploadData>> UploadAssetData()
		{
			return (Task<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadAssetData"), typeof(Task<CloudResult<AssetUploadData>>));
		}

		public Task<CloudResult<AssetUploadData>> Upload()
		{
			return (Task<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Upload"), typeof(Task<CloudResult<AssetUploadData>>));
		}

		public abstract Task<CloudResult<AssetUploadData>> InitiateUpload();

		public virtual Task UploadInitiated(AssetUploadData data)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadInitiated", data), typeof(Task));
		}

		public abstract HttpRequestMessage CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length);

		public abstract void ProcessChunkUploadResult(System.Int32 chunkIndex, TChunkResult result);

		public abstract Task<CloudResult> FinalizeChunkUpload();

		public ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing(System.String apiUrl)
		{
			return (ValueTask<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing", apiUrl), typeof(ValueTask<CloudResult<AssetUploadData>>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AssetUploadTask(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "COMPUTE_VERSION"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

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
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethodWithRefsAndOuts(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetUtil", ResoniteBridge.ResoniteBridgeValueType.Type), "SplitIdentifier", out ResoniteBridge.ResoniteBridgeValue[] __outVars, identifier);
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

		[JsonProperty(PropertyName = "variantIdentifier")]
		[JsonPropertyName("variantIdentifier")]
		public System.String VariantIdentifier
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantIdentifier"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariantIdentifier", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BlobEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LegacyBlobEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsEndpoint"), typeof(System.String)) is System.String __retCasted)
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
		public System.String InstallsEndpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InstallsEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public AzureAssetInterface(System.String blobEndpoint, System.String thumbnailEndpoint, System.String legacyBlobEndpoint)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AzureAssetInterface", ResoniteBridge.ResoniteBridgeValueType.Type), blobEndpoint, thumbnailEndpoint, legacyBlobEndpoint);
		}

		public override System.Uri DBToHttp(System.Uri productDBUri, DB_Endpoint endpoint)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBToHttp", productDBUri, endpoint), typeof(System.Uri));
		}

		public override System.Uri ThumbnailToHttp(ThumbnailInfo thumbnail)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailToHttp", thumbnail), typeof(System.Uri));
		}

		public System.Uri ThumbnailIdToHttp(System.String id)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailIdToHttp", id), typeof(System.Uri));
		}

		public override AssetUploadTask CreateEmptyAssetUploadTask()
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AzureAssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "UPLOAD_DEGREE_OF_PARALLELISM"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AzureAssetUploadTask", ResoniteBridge.ResoniteBridgeValueType.Type), "UPLOAD_DEGREE_OF_PARALLELISM", value);
			}
		}

		public System.String baseUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "baseUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxParallelChunks"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public override void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		public override Task<CloudResult<AssetUploadData>> InitiateUpload()
		{
			return (Task<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitiateUpload"), typeof(Task<CloudResult<AssetUploadData>>));
		}

		public override HttpRequestMessage CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length)
		{
			return (HttpRequestMessage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateChunkUploadRequest", chunkIndex, data, length), typeof(HttpRequestMessage));
		}

		public override Task<CloudResult> FinalizeChunkUpload()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeChunkUpload"), typeof(Task<CloudResult>));
		}

		public override void ProcessChunkUploadResult(System.Int32 chunkIndex, CloudMessage result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessChunkUploadResult", chunkIndex, result);
		}

		public override ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing()
		{
			return (ValueTask<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing"), typeof(ValueTask<CloudResult<AssetUploadData>>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApiEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariantsEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailsEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ThumbnailsEndpoint", value);
			}
		}

		public CloudflareAssetInterface(System.String apiEndpoint, System.String assetsEndpoint, System.String variantsEndpoint, System.String thumbnailsEndpoint)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudflareAssetInterface", ResoniteBridge.ResoniteBridgeValueType.Type), apiEndpoint, assetsEndpoint, variantsEndpoint, thumbnailsEndpoint);
		}

		public override System.Uri DBToHttp(System.Uri dbUri, DB_Endpoint endpoint)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DBToHttp", dbUri, endpoint), typeof(System.Uri));
		}

		public override System.Uri ThumbnailToHttp(ThumbnailInfo thumbnail)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ThumbnailToHttp", thumbnail), typeof(System.Uri));
		}

		public Task<CloudResult<BlobMetadata>> GetAssetMedata(System.String hash)
		{
			return (Task<CloudResult<BlobMetadata>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMedata", hash), typeof(Task<CloudResult<BlobMetadata>>));
		}

		public override Task<CloudResult> GetAssetMime(System.String hash)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAssetMime", hash), typeof(Task<CloudResult>));
		}

		public override Task<CloudResult<List<string>>> GetAvailableVariants(System.String hash)
		{
			return (Task<CloudResult<List<string>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetAvailableVariants", hash), typeof(Task<CloudResult<List<string>>>));
		}

		public override Task<CloudResult<ThumbnailInfo>> UploadThumbnail(System.String path, System.String sessionId)
		{
			return (Task<CloudResult<ThumbnailInfo>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadThumbnail", path, sessionId), typeof(Task<CloudResult<ThumbnailInfo>>));
		}

		public override AssetUploadTask CreateEmptyAssetUploadTask()
		{
			return (AssetUploadTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateEmptyAssetUploadTask"), typeof(AssetUploadTask));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ETag"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ETag", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public System.String apiBaseUrl
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "apiBaseUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "apiBaseUrl", value);
			}
		}

		public List<AssetChunk> parts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "parts"), typeof(List<AssetChunk>)) is List<AssetChunk> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "parts", value);
			}
		}

		public override System.Int32 MaxParallelChunks
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxParallelChunks"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public override void OnInitialize()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnInitialize");
		}

		public override Task UploadInitiated(AssetUploadData data)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadInitiated", data), typeof(Task));
		}

		public override HttpRequestMessage CreateChunkUploadRequest(System.Int32 chunkIndex, byte[] data, System.Int32 length)
		{
			return (HttpRequestMessage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateChunkUploadRequest", chunkIndex, data, length), typeof(HttpRequestMessage));
		}

		public override Task<CloudResult<AssetUploadData>> InitiateUpload()
		{
			return (Task<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitiateUpload"), typeof(Task<CloudResult<AssetUploadData>>));
		}

		public override Task<CloudResult> FinalizeChunkUpload()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeChunkUpload"), typeof(Task<CloudResult>));
		}

		public override void ProcessChunkUploadResult(System.Int32 chunkIndex, CloudflareChunkResult result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessChunkUploadResult", chunkIndex, result);
		}

		public override ValueTask<CloudResult<AssetUploadData>> WaitForAssetFinishProcessing()
		{
			return (ValueTask<CloudResult<AssetUploadData>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WaitForAssetFinishProcessing"), typeof(ValueTask<CloudResult<AssetUploadData>>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public static Dictionary<string, string> map
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "LegacyAssetMap", ResoniteBridge.ResoniteBridgeValueType.Type), "map"), typeof(Dictionary<string, string>)) is Dictionary<string, string> __retCasted)
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ownerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		public CloudVariableIdentity(System.String ownerId, System.String path)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableIdentity", ResoniteBridge.ResoniteBridgeValueType.Type), ownerId, path);
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
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableIdentity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Equality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public static bool operator !=(CloudVariableIdentity left, CloudVariableIdentity right)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableIdentity", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Inequality", left, right), typeof(System.Boolean)) is System.Boolean __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to bool");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public DateTimeOffset? timestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "timestamp"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "timestamp", value);
			}
		}

		public TimestampedCloudVariable(T value, DateTimeOffset? timestamp)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "TimestampedCloudVariable", ResoniteBridge.ResoniteBridgeValueType.Type), value, timestamp);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public Dictionary<CloudVariableIdentity, CloudVariableProxy> _variableProxies
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_variableProxies"), typeof(Dictionary<CloudVariableIdentity, CloudVariableProxy>)) is Dictionary<CloudVariableIdentity, CloudVariableProxy> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<CloudVariableIdentity, CloudVariableProxy>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_variableProxies", value);
			}
		}

		public HashSet<CloudVariableProxy> _changedVariables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_changedVariables"), typeof(HashSet<CloudVariableProxy>)) is HashSet<CloudVariableProxy> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HashSet<CloudVariableProxy>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_changedVariables", value);
			}
		}

		public VariableReadBatchQuery _readBatch
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_readBatch"), typeof(VariableReadBatchQuery)) is VariableReadBatchQuery __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VariableReadBatchQuery");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_readBatch", value);
			}
		}

		public VariableWriteBatchQuery _writeBatch
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_writeBatch"), typeof(VariableWriteBatchQuery)) is VariableWriteBatchQuery __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VariableWriteBatchQuery");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LocalAccessor"), typeof(ILocalVariableAccessor)) is ILocalVariableAccessor __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILocalVariableAccessor");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LocalAccessor", value);
			}
		}

		public System.Object Lock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Lock"), typeof(System.Object)) is System.Object __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Lock", value);
			}
		}

		public void SetLocalAccessor(ILocalVariableAccessor accessor)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetLocalAccessor", accessor);
		}

		public Task<VariableReadResult<CloudVariable, CloudVariableDefinition>> ReadVariable(System.String ownerId, System.String path)
		{
			return (Task<VariableReadResult<CloudVariable, CloudVariableDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadVariable", ownerId, path), typeof(Task<VariableReadResult<CloudVariable, CloudVariableDefinition>>));
		}

		public Task<CloudVariable> WriteVariable(CloudVariable variable)
		{
			return (Task<CloudVariable>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteVariable", variable), typeof(Task<CloudVariable>));
		}

		public void RegisterChanged(CloudVariableProxy proxies)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterChanged", proxies);
		}

		public CloudVariableManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
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
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task));
		}

		public Task SaveAllChangedVariables()
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

		public System.Boolean TryUnregisterProxy(CloudVariableProxy proxy)
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

		public Task<CloudResult<TimestampedCloudVariable<T>>> ReadWithTimestamp<T>(System.String ownerId, System.String path, System.String variableType = null)
		{
			return (Task<CloudResult<TimestampedCloudVariable<T>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReadWithTimestamp", ownerId, path, variableType), typeof(Task<CloudResult<TimestampedCloudVariable<T>>>));
		}

		public Task<CloudResult<T>> Read<T>(System.String ownerId, System.String path, System.String variableType = null)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "WRITE_DELAY_SECONDS"), typeof(System.Double)) is System.Double __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "WRITE_DELAY_SECONDS", value);
			}
		}

		public System.Double REFRESH_INTERVAL_SECONDS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "REFRESH_INTERVAL_SECONDS"), typeof(System.Double)) is System.Double __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "REFRESH_INTERVAL_SECONDS", value);
			}
		}

		public System.Double UNREGISTER_DELAY_SECONDS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "UNREGISTER_DELAY_SECONDS"), typeof(System.Double)) is System.Double __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "UNREGISTER_DELAY_SECONDS", value);
			}
		}

		public CloudVariableDefinition _definition
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_definition"), typeof(CloudVariableDefinition)) is CloudVariableDefinition __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableDefinition");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_definition", value);
			}
		}

		public CloudVariable _variable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_variable"), typeof(CloudVariable)) is CloudVariable __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariable");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_variable", value);
			}
		}

		public System.Boolean _isLocalVariable
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_isLocalVariable"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_isLocalVariable", value);
			}
		}

		public System.String _definitionOwnerId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_definitionOwnerId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_definitionOwnerId", value);
			}
		}

		public System.String _definitionSubpath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_definitionSubpath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_definitionSubpath", value);
			}
		}

		public CloudVariableManager _manager
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_manager"), typeof(CloudVariableManager)) is CloudVariableManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableManager");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_manager", value);
			}
		}

		public ILocalVariableAccessor _localVariableAccessor
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_localVariableAccessor"), typeof(ILocalVariableAccessor)) is ILocalVariableAccessor __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ILocalVariableAccessor");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_localVariableAccessor", value);
			}
		}

		public Task _readTask
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_readTask"), typeof(Task)) is Task __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Task");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_readTask", value);
			}
		}

		public CancellationTokenSource _readCancel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_readCancel"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_readCancel", value);
			}
		}

		public Task _writeTask
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_writeTask"), typeof(Task)) is Task __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Task");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_writeTask", value);
			}
		}

		public CancellationTokenSource _unregisterCancel
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_unregisterCancel"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_unregisterCancel", value);
			}
		}

		public System.Object _lock
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

		public CloudVariableState State
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(CloudVariableState)) is CloudVariableState __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableState");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasValidValue"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public DateTime LastCloudWrite
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastCloudWrite"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastCloudWrite", value);
			}
		}

		public DateTime LastCloudRead
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastCloudRead"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastCloudRead", value);
			}
		}

		public CloudVariableIdentity Identity
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Identity"), typeof(CloudVariableIdentity)) is CloudVariableIdentity __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableIdentity");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasListeners"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.String RawValue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RawValue"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Boolean IsDefinitionOwner
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsDefinitionOwner"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean IsVariableOwner
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsVariableOwner"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean PublicRead
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicRead"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicRead", value);
			}
		}

		public System.Boolean PublicWrite
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicWrite"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicWrite", value);
			}
		}

		public System.Boolean PrivateWrite
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrivateWrite"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrivateWrite", value);
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
		}

		private event CloudVariableEventHandler _valueChanged;

		public CloudVariableProxy(CloudVariableIdentity identity, CloudVariableManager manager, ILocalVariableAccessor localReader)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableProxy", ResoniteBridge.ResoniteBridgeValueType.Type), identity, manager, localReader);
		}

		public void Register(CloudVariableEventHandler onChanged)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Register", onChanged);
		}

		public void Unregister(CloudVariableEventHandler onChanged)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Unregister", onChanged);
		}

		public void ScheduleUnregistration()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleUnregistration");
		}

		public System.Boolean WriteToCloud()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "WriteToCloud"), typeof(System.Boolean));
		}

		public Task ForceWriteToCloud()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceWriteToCloud"), typeof(Task));
		}

		public Task Refresh()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Refresh"), typeof(Task));
		}

		public System.Boolean CanAccessInPublic(List<string> permissions)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPublic", permissions), typeof(System.Boolean));
		}

		public System.Boolean CanAccessInPrivate(List<string> permissions)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CanAccessInPrivate", permissions), typeof(System.Boolean));
		}

		public System.Boolean CanAccessInPrivate(System.String perm)
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

		public void RunChangedEvent()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunChangedEvent");
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public CancellationTokenSource _cancellation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cancellation"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Hub"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HubConnection");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Hub", value);
			}
		}

		public CancellationToken Token
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Token"), typeof(CancellationToken)) is CancellationToken __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationToken");
				}
			}
		}

		public System.Boolean IsClosed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsClosed"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public AppHub(ResoniteBridge.ResoniteBridgeValue hub)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AppHub", ResoniteBridge.ResoniteBridgeValueType.Type), hub);
		}

		public void Disconnect()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Disconnect");
		}

		public ValueTask EnsureConnectedHub()
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

		public Task Ping(System.Int32 index)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Ping", index), typeof(Task));
		}

		public Task SendMessage(Message message)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendMessage", message), typeof(Task));
		}

		public Task MarkMessagesRead(MarkReadBatch markReadBatch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkMessagesRead", markReadBatch), typeof(Task));
		}

		public Task BroadcastStatus(UserStatus status, BroadcastTarget target)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastStatus", status, target), typeof(Task));
		}

		public Task<bool> UpdateContact(Contact contact)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContact", contact), typeof(Task<bool>));
		}

		public Task ListenOnContact(System.String contactId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenOnContact", contactId), typeof(Task));
		}

		public Task ListenOnKey(System.String broadcastKey)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenOnKey", broadcastKey), typeof(Task));
		}

		public Task RequestStatus(System.String userId = null, System.Boolean invisible = false)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestStatus", userId, invisible), typeof(Task));
		}

		public Task<StatusInitializationResult> InitializeStatus()
		{
			return (Task<StatusInitializationResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeStatus"), typeof(Task<StatusInitializationResult>));
		}

		public IAsyncEnumerable<Contact> InitializeContacts(CancellationToken cancellationToken)
		{
			return (IAsyncEnumerable<Contact>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeContacts", cancellationToken), typeof(IAsyncEnumerable<Contact>));
		}

		public Task BroadcastSession(SessionInfo session, BroadcastTarget target)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastSession", session, target), typeof(Task));
		}

		public Task BroadcastSessionEnded(System.String sessionId, DateTime timestamp, BroadcastTarget target)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BroadcastSessionEnded", sessionId, timestamp, target), typeof(Task));
		}

		public Task ListenForLNLPokeRequests(System.String universeId, System.String connectionUrl)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ListenForLNLPokeRequests", universeId, connectionUrl), typeof(Task));
		}

		public Task RequestLNLPoke(System.String universeId, System.String connectionUrl, System.String address, System.Int32 port)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RequestLNLPoke", universeId, connectionUrl, address, port), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public AppHub()
		{
		}
	}
	public class HubStatusController : IHubStatusClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public CancellationTokenSource _initializationCancellation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initializationCancellation"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initializationCancellation", value);
			}
		}

		public System.Int32 exceptionCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "exceptionCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "exceptionCount", value);
			}
		}

		public System.Boolean Initialized
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Initialized"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Initialized", value);
			}
		}

		public System.Boolean Initializing
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Initializing"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
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

		public event Action<string> OnUserStatusRequested;

		public event Action<string, string> OnKeyListenerAdded;

		public HubStatusController(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "HubStatusController", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public void ResetInitializationStatus()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetInitializationStatus");
		}

		public void Initialize(CancellationToken token)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", token);
		}

		public void RunInitialization(CancellationToken cancellation)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunInitialization", cancellation);
		}

		public Task SignOut()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task));
		}

		public Task ReceiveStatusUpdate(UserStatus status)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveStatusUpdate", status), typeof(Task));
		}

		public Task SendStatusToUser(System.String userId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendStatusToUser", userId), typeof(Task));
		}

		public Task ContactAddedOrUpdated(Contact contact)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactAddedOrUpdated", contact), typeof(Task));
		}

		public Task KeyListenerAdded(System.String broadcastKey, System.String connectionId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "KeyListenerAdded", broadcastKey, connectionId), typeof(Task));
		}

		public ValueTask WaitForInitialized()
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		IAsyncEnumerable<Contact> InitializeContacts(CancellationToken cancellationToken);

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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasUniverse"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.String UniverseId
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
		}

		System.Boolean AcceptSession(SessionInfo sessionInfo);
	}
	public interface IUserStatusSource : ResoniteBridge.ResoniteBridgeValueHolder
	{
		System.Boolean LoadingOnlineStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadingOnlineStatus"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		System.String AppVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppVersion"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		System.Boolean IsMobile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMobile"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		UserSessionType SessionType
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionType"), typeof(UserSessionType)) is UserSessionType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserSessionType");
				}
			}
		}

		System.Boolean IsUserPresent
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUserPresent"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		DateTime LastPresenceTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPresenceTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
			}
		}

		OutputDevice? OutputDevice
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDevice"), typeof(OutputDevice)) is OutputDevice __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OutputDevice");
				}
			}
		}

		DateTime LastSessionChangeTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastSessionChangeTimestamp"), typeof(DateTime)) is DateTime __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DateTime");
				}
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
		public Universe? Universe
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Universe"), typeof(Universe)) is Universe __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Universe");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Universe", value);
			}
		}

		public AppsManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AppsManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public Task<CloudResult<List<SamlIdentityProvider>>> GetSamlProviders(System.String universeId)
		{
			return (Task<CloudResult<List<SamlIdentityProvider>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSamlProviders", universeId), typeof(Task<CloudResult<List<SamlIdentityProvider>>>));
		}

		public Task Initialize(System.String universeId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", universeId), typeof(Task));
		}

		public Task<CloudResult<Universe>> GetUniverse(System.String universeId)
		{
			return (Task<CloudResult<Universe>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUniverse", universeId), typeof(Task<CloudResult<Universe>>));
		}

		public Task UpdateCurrentUniverse(System.String universeId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUniverse", universeId), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public ResoniteBridge.ResoniteBridgeValue _cachedBadges
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cachedBadges"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<EntityId, BadgeDefinition>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cachedBadges", value);
			}
		}

		public BadgeManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "BadgeManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public Task<CloudResult<BadgeDefinition>> GetBadge(System.String ownerId, System.String badgeId, System.Boolean allowCache = true)
		{
			return (Task<CloudResult<BadgeDefinition>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetBadge", ownerId, badgeId, allowCache), typeof(Task<CloudResult<BadgeDefinition>>));
		}

		public Task<CloudResult> UpdateBadge(BadgeDefinition badge)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBadge", badge), typeof(Task<CloudResult>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public Dictionary<string, UserStatus> statuses
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "statuses"), typeof(Dictionary<string, UserStatus>)) is Dictionary<string, UserStatus> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, UserStatus>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactManager"), typeof(ContactManager)) is ContactManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ContactManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface)) is SkyFrostInterface __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostInterface");
				}
			}
		}

		public Contact Contact
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contact"), typeof(Contact)) is Contact __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Contact");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public UserStatus CurrentStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStatus"), typeof(UserStatus)) is UserStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreviousStatus"), typeof(UserStatus)) is UserStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSessionInfo"), typeof(SessionInfo)) is SessionInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SessionInfo");
				}
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

		public ContactData(ContactManager manager, Contact contact)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ContactData", ResoniteBridge.ResoniteBridgeValueType.Type), manager, contact);
		}

		public UserStatus GetStatus(System.String userSessionId)
		{
			return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetStatus", userSessionId), typeof(UserStatus));
		}

		public void DecodeSessions(HashSet<SessionInfo> infos, List<UserSessionMetadata> undecoded = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DecodeSessions", infos, undecoded);
		}

		public System.Boolean UpdateStatus(UserStatus status)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStatus", status), typeof(System.Boolean));
		}

		public System.Boolean ClearExpired()
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearExpired"), typeof(System.Boolean));
		}

		public void UpdateAggregate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateAggregate");
		}

		public System.Boolean TryMatchNewSession(SessionInfo info)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryMatchNewSession", info), typeof(System.Boolean));
		}

		public System.Boolean TryUpdateSession(SessionInfo info)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryUpdateSession", info), typeof(System.Boolean));
		}

		public System.Boolean TryRemoveSession(System.String sessionId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryRemoveSession", sessionId), typeof(System.Boolean));
		}

		public UserStatus GetDefaultStatus()
		{
			return (UserStatus)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetDefaultStatus"), typeof(UserStatus));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public System.String _contactPath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_contactPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_contactPath", value);
			}
		}

		public Dictionary<string, ContactData> contacts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "contacts"), typeof(Dictionary<string, ContactData>)) is Dictionary<string, ContactData> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, ContactData>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "contacts", value);
			}
		}

		public List<ContactData> contactDataList
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "contactDataList"), typeof(List<ContactData>)) is List<ContactData> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<ContactData>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "contactDataList", value);
			}
		}

		public HashSet<string> sessionBroadcastKeys
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sessionBroadcastKeys"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sessionBroadcastKeys", value);
			}
		}

		public System.Object _lock
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

		public System.Int32 updateListIndex
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "updateListIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "updateListIndex", value);
			}
		}

		public System.Int32 ContactRequestCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactRequestCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactRequestCount", value);
			}
		}

		public System.Boolean ContactListLoaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactListLoaded"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactListLoaded", value);
			}
		}

		public System.Int32 ContactCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public event Action<ContactData> ContactAdded;

		public event Action<ContactData> ContactUpdated;

		public event Action<ContactData> ContactRemoved;

		public event Action<int> ContactRequestCountChanged;

		public event Action<ContactData> ContactStatusChanged;

		public ContactManager(SkyFrostInterface cloud, System.String contactPath)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ContactManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud, contactPath);
		}

		public void OnSessionRemoved(SessionInfo info)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionRemoved", info);
		}

		public void OnSessionUpdated(SessionInfo info)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionUpdated", info);
		}

		public void OnSessionAdded(SessionInfo info)
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

		public Task<bool> UpdateContact(Contact contact)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContact", contact), typeof(Task<bool>));
		}

		public void LoadContact(Contact contact, ref System.Int32 requests)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethodWithRefsAndOuts(__Backing, "LoadContact", out ResoniteBridge.ResoniteBridgeValue[] __outVars, contact, requests);
		}

		public void FinalizeLoading(System.Int32 requests)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeLoading", requests);
		}

		public void ContactStatusUpdated(UserStatus status)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactStatusUpdated", status);
		}

		public void ContactAddedOrUpdated(Contact contact)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ContactAddedOrUpdated", contact);
		}

		public void UpdateContactRequestCount()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateContactRequestCount");
		}

		public void Reconnecting()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reconnecting");
		}

		public void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public void Update()
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public System.Object _groupsLock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupsLock"), typeof(System.Object)) is System.Object __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupsLock", value);
			}
		}

		public Dictionary<string, Member> _groupMemberInfos
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupMemberInfos"), typeof(Dictionary<string, Member>)) is Dictionary<string, Member> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, Member>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupMemberInfos", value);
			}
		}

		public Dictionary<string, Group> _groups
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groups"), typeof(Dictionary<string, Group>)) is Dictionary<string, Group> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, Group>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groups", value);
			}
		}

		public Dictionary<string, Storage> _groupStorages
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupStorages"), typeof(Dictionary<string, Storage>)) is Dictionary<string, Storage> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, Storage>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupStorages", value);
			}
		}

		public Dictionary<string, Storage> _groupMemberStorages
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupMemberStorages"), typeof(Dictionary<string, Storage>)) is Dictionary<string, Storage> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, Storage>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_groupMemberStorages", value);
			}
		}

		public List<Membership> _groupMemberships
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_groupMemberships"), typeof(List<Membership>)) is List<Membership> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Membership>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserMemberships"), typeof(IEnumerable<Membership>)) is IEnumerable<Membership> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<Membership>");
				}
			}
		}

		public IEnumerable<Member> CurrentUserMemberInfos
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserMemberInfos"), typeof(IEnumerable<Member>)) is IEnumerable<Member> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<Member>");
				}
			}
		}

		public event Action<IEnumerable<Membership>> MembershipsUpdated;

		public event Action<Group> GroupUpdated;

		public event Action<Member> GroupMemberUpdated;

		public GroupsManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "GroupsManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
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

		public void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public void SetMemberships(IEnumerable<Membership> memberships)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetMemberships", memberships);
		}

		public void ClearMemberships()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearMemberships");
		}

		public void AddMembership(Membership membership)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMembership", membership);
		}

		public Task RunMembershipsUpdated()
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

		public Task<CloudResult> UpdateCurrentUserMemberships()
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

		public Task UpdateGroupInfo(System.String groupId)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public CancellationTokenSource _fetchCancellation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_fetchCancellation"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_fetchCancellation", value);
			}
		}

		public System.Boolean _initialFetchRunning
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initialFetchRunning"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initialFetchRunning", value);
			}
		}

		public System.Object _messagesLock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messagesLock"), typeof(System.Object)) is System.Object __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messagesLock", value);
			}
		}

		public Dictionary<string, UserMessages> _messages
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messages"), typeof(Dictionary<string, UserMessages>)) is Dictionary<string, UserMessages> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, UserMessages>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messages", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue _messagesWaitingForConfirmation
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messagesWaitingForConfirmation"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<string, TaskCompletionSource<bool>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messagesWaitingForConfirmation", value);
			}
		}

		public System.Boolean _unreadCountDirty
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_unreadCountDirty"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_unreadCountDirty", value);
			}
		}

		public System.Boolean SendReadNotification
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SendReadNotification"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SendReadNotification", value);
			}
		}

		public System.Boolean InitialUnreadMessagesFetched
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InitialUnreadMessagesFetched"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InitialUnreadMessagesFetched", value);
			}
		}

		public System.Int32 TotalUnreadCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalUnreadCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalUnreadCount", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue UnreadCountByUser
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnreadCountByUser"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<string, int>");
				}
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
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MessageManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public Task ReceiveMessage(Message message)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveMessage", message), typeof(Task));
		}

		public void ProcessReceivedMessage(Message message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessReceivedMessage", message);
		}

		public void ProcessSentMessage(Message message)
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

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public void FetchInitialMessages()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FetchInitialMessages");
		}

		public void RegisterMessageWaitingForConfirmation(Message message, TaskCompletionSource<bool> completion)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterMessageWaitingForConfirmation", message, completion);
		}

		public void UnregisterMessageWaitingForConfirmation(Message message)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterMessageWaitingForConfirmation", message);
		}

		public void MarkUnreadCountDirty()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MarkUnreadCountDirty");
		}

		public void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public Task<CloudResult<Message>> StoreMessage(Message message)
		{
			return (Task<CloudResult<Message>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StoreMessage", message), typeof(Task<CloudResult<Message>>));
		}

		public Task<CloudResult<List<Message>>> GetUnreadMessages(DateTime? fromTime = null)
		{
			return (Task<CloudResult<List<Message>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUnreadMessages", fromTime), typeof(Task<CloudResult<List<Message>>>));
		}

		public Task<CloudResult<List<Message>>> GetMessageHistory(System.String user, System.Int32 maxItems = 100)
		{
			return (Task<CloudResult<List<Message>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetMessageHistory", user, maxItems), typeof(Task<CloudResult<List<Message>>>));
		}

		public Task<CloudResult<List<Message>>> GetMessages(DateTime? fromTime, System.Int32 maxItems, System.String user, System.Boolean unreadOnly, TimeSpan? timeout = null)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public HashSet<string> _messageIds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_messageIds"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_messageIds", value);
			}
		}

		public System.Object _lock
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

		public Task<CloudResult<List<Message>>> _historyLoadTask
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_historyLoadTask"), typeof(Task<CloudResult<List<Message>>>)) is Task<CloudResult<List<Message>>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Task<CloudResult<List<Message>>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_historyLoadTask", value);
			}
		}

		public System.Boolean _historyLoaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_historyLoaded"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_historyLoaded", value);
			}
		}

		public static System.Int32 MAX_READ_HISTORY
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserMessages", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_READ_HISTORY"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public static System.Int32 MAX_UNREAD_HISTORY
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserMessages", ResoniteBridge.ResoniteBridgeValueType.Type), "MAX_UNREAD_HISTORY"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public MessageManager Manager
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Manager"), typeof(MessageManager)) is MessageManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MessageManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Cloud"), typeof(SkyFrostInterface)) is SkyFrostInterface __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostInterface");
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

		public List<Message> Messages
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Messages"), typeof(List<Message>)) is List<Message> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<Message>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UnreadCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UnreadCount", value);
			}
		}

		public UserMessages(System.String userId, MessageManager manager)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserMessages", ResoniteBridge.ResoniteBridgeValueType.Type), userId, manager);
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

		public Task<bool> SendMessage(Message message)
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

		public Task EnsureHistory()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureHistory"), typeof(Task));
		}

		public System.Boolean AddMessage(Message message)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public ResoniteBridge.ResoniteBridgeValue _migrationTasks
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_migrationTasks"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<string, AccountMigrationTask>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_migrationTasks", value);
			}
		}

		public DateTime nextMigrationTaskUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "nextMigrationTaskUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "nextMigrationTaskUpdate", value);
			}
		}

		public IEnumerable<AccountMigrationTask> MigrationTasks
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrationTasks"), typeof(IEnumerable<AccountMigrationTask>)) is IEnumerable<AccountMigrationTask> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<AccountMigrationTask>");
				}
			}
		}

		public MigrationManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MigrationManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public void Reset()
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

		public void TryScheduleMigrationTaskUpdate()
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public ModerationManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ModerationManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public Task<CloudResult<bool>> IsPublicBanned(System.String id)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Nodes"), typeof(List<NetworkNodeInfo>)) is List<NetworkNodeInfo> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<NetworkNodeInfo>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Nodes", value);
			}
		}

		public event Action<INetworkNodeManager> AvailableNodesChanged;

		public FixedNetworkNodeSource(List<NetworkNodeInfo> nodes)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "FixedNetworkNodeSource", ResoniteBridge.ResoniteBridgeValueType.Type), nodes);
		}

		public Task ForceUpdate()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceUpdate"), typeof(Task));
		}

		public IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, NetworkNodePreference? preference, System.String universeId)
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

		public ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id)
		{
			return (ValueTask<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNodeWithRefetch", id), typeof(ValueTask<NetworkNodeInfo>));
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, NetworkNodePreference? preference, System.String universeId);

		NetworkNodeInfo TryGetNode(System.String id);

		ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id);

		void Update();
	}
	public delegate void LNL_PokeRequestHandler(System.String connectionUrl, System.String targetAddress, System.Int32 targetPort);
	public class NetworkNodeManager : INetworkNodeManager, IHubNetworkingClient, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public List<NetworkNodeInfo> _nodes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_nodes"), typeof(List<NetworkNodeInfo>)) is List<NetworkNodeInfo> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<NetworkNodeInfo>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_nodes", value);
			}
		}

		public DateTime _lastUpdateTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastUpdateTime"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastUpdateTime", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
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

		[System.Text.Json.Serialization.JsonIgnore]
		public ApiClient Api
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient)) is ApiClient __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ApiClient");
				}
			}
		}

		public event Action<INetworkNodeManager> AvailableNodesChanged;

		public event LNL_PokeRequestHandler OnLNLPokeRequested;

		public void Initialize(SkyFrostInterface SkyFrost)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", SkyFrost);
		}

		public IEnumerable<NetworkNodeInfo> GetNodes(NetworkNodeType type, System.Int32 protocolVersion, NetworkNodePreference? preference, System.String universeId)
		{
			return (IEnumerable<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetNodes", type, protocolVersion, preference, universeId), typeof(IEnumerable<NetworkNodeInfo>));
		}

		public NetworkNodeInfo TryGetNode(System.String id)
		{
			return (NetworkNodeInfo)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNode", id), typeof(NetworkNodeInfo));
		}

		public ValueTask<NetworkNodeInfo> TryGetNodeWithRefetch(System.String id)
		{
			return (ValueTask<NetworkNodeInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetNodeWithRefetch", id), typeof(ValueTask<NetworkNodeInfo>));
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task ForceUpdate()
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public System.Uri[] _favorites
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favorites"), typeof(System.Uri[])) is System.Uri[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Uri[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favorites", value);
			}
		}

		public Action<ResoniteBridge.ResoniteBridgeValue>[] _favoriteListeners
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favoriteListeners"), typeof(Action<ResoniteBridge.ResoniteBridgeValue>[])) is Action<ResoniteBridge.ResoniteBridgeValue>[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<Uri>[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favoriteListeners", value);
			}
		}

		public CloudVariableProxy[] _favoriteProxies
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favoriteProxies"), typeof(CloudVariableProxy[])) is CloudVariableProxy[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableProxy[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favoriteProxies", value);
			}
		}

		public string[] _favoriteVariablePaths
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_favoriteVariablePaths"), typeof(string[])) is string[] __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_favoriteVariablePaths", value);
			}
		}

		public ProfileManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ProfileManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public System.Uri GetCurrentFavorite(FavoriteEntity entity)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCurrentFavorite", entity), typeof(System.Uri));
		}

		public void SetFavorite(FavoriteEntity entity, System.Uri url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetFavorite", entity, url);
		}

		public Task EnsureInitialized(FavoriteEntity entity)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureInitialized", entity), typeof(Task));
		}

		public void RegisterListener(FavoriteEntity entity, Action<System.Uri> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RegisterListener", entity, callback);
		}

		public void UnregisterListener(FavoriteEntity entity, Action<System.Uri> callback)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UnregisterListener", entity, callback);
		}

		public Task SignIn()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignIn"), typeof(Task));
		}

		public void Reset()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Reset");
		}

		public void OnCloudVariableChanged(CloudVariableProxy proxy)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnCloudVariableChanged", proxy);
		}

		public System.Uri FilterUrl(System.Uri url)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FilterUrl", url), typeof(System.Uri));
		}

		public void SafeInvoke(Action<System.Uri> events, System.Uri arg)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public ResoniteBridge.ResoniteBridgeValue _recordBatchQueries
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_recordBatchQueries"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, object>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_recordBatchQueries", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue _recordCaches
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_recordCaches"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, object>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cachedRecords"), typeof(Dictionary<Type, Dictionary<ResoniteBridge.ResoniteBridgeValue, CloudResult>>)) is Dictionary<Type, Dictionary<ResoniteBridge.ResoniteBridgeValue, CloudResult>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Type, Dictionary<Uri, CloudResult>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cachedRecords", value);
			}
		}

		public RecordsManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordsManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public RecordBatchQuery<R> RecordBatch<R>() where R : class, IRecord, new()
		{
			return (RecordBatchQuery<R>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordBatch"), typeof(RecordBatchQuery<R>));
		}

		public RecordCache<R> RecordCache<R>() where R : class, IRecord, new()
		{
			return (RecordCache<R>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RecordCache"), typeof(RecordCache<R>));
		}

		public System.Uri GenerateRecordUri(System.String ownerId, System.String recordId)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateRecordUri", ownerId, recordId), typeof(System.Uri));
		}

		public System.Boolean ExtractRecordID(System.Uri recordUri, out System.String ownerId, out System.String recordId)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethodWithRefsAndOuts(__Backing, "ExtractRecordID", out ResoniteBridge.ResoniteBridgeValue[] __outVars, recordUri), typeof(System.Boolean));
			ownerId = (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.String));
			recordId = (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[1], typeof(System.String));
			return __finalResult;
		}

		public System.Boolean ExtractRecordPath(System.Uri recordUri, out System.String ownerId, out System.String recordPath)
		{
			bool __finalResult = (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethodWithRefsAndOuts(__Backing, "ExtractRecordPath", out ResoniteBridge.ResoniteBridgeValue[] __outVars, recordUri), typeof(System.Boolean));
			ownerId = (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[0], typeof(System.String));
			recordPath = (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(__outVars[1], typeof(System.String));
			return __finalResult;
		}

		public Task<CloudResult<R>> GetRecordCached<R>(System.Uri recordUri, System.String accessKey = null) where R : class, IRecord, new()
		{
			return (Task<CloudResult<R>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordCached", recordUri, accessKey), typeof(Task<CloudResult<R>>));
		}

		public Task<CloudResult<R>> GetRecord<R>(System.Uri recordUri, System.String accessKey = null) where R : class, IRecord, new()
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

		public IAsyncEnumerable<R> GetRecordsInHierarchy<R>(System.String ownerId, System.String path) where R : class, IRecord, new()
		{
			return (IAsyncEnumerable<R>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordsInHierarchy", ownerId, path), typeof(IAsyncEnumerable<R>));
		}

		public Task<CloudResult<SearchResults<R>>> FindRecords<R>(SearchParameters search, TimeSpan? timeout = null, System.Boolean throwOnError = true) where R : class, IRecord, new()
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

		public Task<CloudResult> DeleteRecord(System.String ownerId, System.String recordId)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DeleteRecord", ownerId, recordId), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> AddTag(System.String ownerId, System.String recordId, System.String tag)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddTag", ownerId, recordId, tag), typeof(Task<CloudResult>));
		}

		public Task<CloudResult<List<RecordAuditInfo>>> GetRecordAuditLog(System.String ownerId, DateTime? from, DateTime? to)
		{
			return (Task<CloudResult<List<RecordAuditInfo>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRecordAuditLog", ownerId, from, to), typeof(Task<CloudResult<List<RecordAuditInfo>>>));
		}

		public IAsyncEnumerable<RecordAuditInfo> EnumerateRecordAuditLog()
		{
			return (IAsyncEnumerable<RecordAuditInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnumerateRecordAuditLog"), typeof(IAsyncEnumerable<RecordAuditInfo>));
		}

		public IAsyncEnumerable<RecordAuditInfo> EnumerateRecordAuditLog(System.String ownerId)
		{
			return (IAsyncEnumerable<RecordAuditInfo>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnumerateRecordAuditLog", ownerId), typeof(IAsyncEnumerable<RecordAuditInfo>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public RSACryptoServiceProvider provider
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "provider"), typeof(RSACryptoServiceProvider)) is RSACryptoServiceProvider __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "provider", value);
			}
		}

		public RSAParameters parameters
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "parameters"), typeof(RSAParameters)) is RSAParameters __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "parameters", value);
			}
		}

		public CryptoData(RSACryptoServiceProvider provider, RSAParameters parameters)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CryptoData", ResoniteBridge.ResoniteBridgeValueType.Type), provider, parameters);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public RSACryptoServiceProvider _cryptoProvider
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_cryptoProvider"), typeof(RSACryptoServiceProvider)) is RSACryptoServiceProvider __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_cryptoProvider", value);
			}
		}

		public RSAParameters PublicKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicKey"), typeof(RSAParameters)) is RSAParameters __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PublicKey", value);
			}
		}

		public SecurityManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SecurityManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public void ActivateSession(CryptoData cryptoData)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ActivateSession", cryptoData);
		}

		public void Reset()
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

		public Task<CloudResult<bool>> CheckContact(CheckContactData data)
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

		public ValueTask EnsureIPAllowed()
		{
			return (ValueTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureIPAllowed"), typeof(ValueTask));
		}

		public Task<CloudResult> TemporarilyAllowIP()
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TemporarilyAllowIP"), typeof(Task<CloudResult>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), "SESSION_EXTEND_INTERVAL"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), "TOKEN_UPDATE_INTERVAL"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), "TOKEN_UPDATE_INTERVAL", value);
			}
		}

		public DateTime _lastSessionUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastSessionUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastSessionUpdate", value);
			}
		}

		public DateTime _lastTokenRefresh
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastTokenRefresh"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastTokenRefresh", value);
			}
		}

		public System.Boolean _updateCurrentUserInfo
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_updateCurrentUserInfo"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_updateCurrentUserInfo", value);
			}
		}

		public System.String _saml2Endpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_saml2Endpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_saml2Endpoint", value);
			}
		}

		public System.Boolean _useLegacyLogin
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_useLegacyLogin"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_useLegacyLogin", value);
			}
		}

		public UserSession _currentSession
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentSession"), typeof(UserSession)) is UserSession __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserSession");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentSession", value);
			}
		}

		public User _currentUser
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentUser"), typeof(User)) is User __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to User");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentUser", value);
			}
		}

		public AuthenticationHeaderValue _currentAuthenticationHeader
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentAuthenticationHeader"), typeof(AuthenticationHeaderValue)) is AuthenticationHeaderValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AuthenticationHeaderValue");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentAuthenticationHeader", value);
			}
		}

		public System.Object _sessionLock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionLock"), typeof(System.Object)) is System.Object __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionLock", value);
			}
		}

		public DateTime InitialSessionActivationTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "InitialSessionActivationTime"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "InitialSessionActivationTime", value);
			}
		}

		public new User CurrentUser
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User)) is User __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to User");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSession"), typeof(UserSession)) is UserSession __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserSession");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentSession", value);
			}
		}

		public AuthenticationHeaderValue AuthenticationHeader
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AuthenticationHeader"), typeof(AuthenticationHeaderValue)) is AuthenticationHeaderValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AuthenticationHeaderValue");
				}
			}
		}

		public event Action<UserSession> SessionChanged;

		public event Action<User> UserUpdated;

		public event Action<List<Task>> OnFinalizeSession;

		public SessionManager(SkyFrostInterface cloud, System.String saml2Endpoint, System.Boolean useLegacyLogin)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud, saml2Endpoint, useLegacyLogin);
		}

		public void ScheduleUpdateCurrentUserInfo()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ScheduleUpdateCurrentUserInfo");
		}

		public Task<CloudResult<User>> UpdateCurrentUserInfo()
		{
			return (Task<CloudResult<User>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserInfo"), typeof(Task<CloudResult<User>>));
		}

		public Task<CloudResult<UserSessionResult<UserSession>>> Login(System.String credential, LoginAuthentication authentication, System.String secretMachineId, System.Boolean rememberMe, System.String totp)
		{
			return (Task<CloudResult<UserSessionResult<UserSession>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Login", credential, authentication, secretMachineId, rememberMe, totp), typeof(Task<CloudResult<UserSessionResult<UserSession>>>));
		}

		public Dictionary<string, object> GenerateLegacyLogin(System.String credential, System.String password, System.String secretMachineId, System.Boolean rememberMe = false, System.String totp = null)
		{
			return (Dictionary<string, object>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GenerateLegacyLogin", credential, password, secretMachineId, rememberMe, totp), typeof(Dictionary<string, object>));
		}

		public Task ActivateSession(UserSession session, CryptoData cryptoData)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ActivateSession", session, cryptoData), typeof(Task));
		}

		public Task FinalizeSession()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeSession"), typeof(Task));
		}

		public Task Logout(System.Boolean isManual)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Logout", isManual), typeof(Task));
		}

		public void Update()
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

		public Task<CloudResult> ExtendSession(System.Boolean updateToken = true, System.String secretMachineId = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ExtendSession", updateToken, secretMachineId), typeof(Task<CloudResult>));
		}

		public Task<bool> LoginSaml2(System.String samlEntityId, System.String secretMachineId, CancellationToken cancellationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LoginSaml2", samlEntityId, secretMachineId, cancellationToken), typeof(Task<bool>));
		}

		public Task LogoutSaml2(UserSession session)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogoutSaml2", session), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public struct SessionInfoData : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public SessionInfo info
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "info"), typeof(SessionInfo)) is SessionInfo __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to SessionInfo");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "info", value);
				}
			}

			public DateTime lastExternalUpdate
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "lastExternalUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "lastExternalUpdate", value);
				}
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

		public System.Object _lock
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

		public Dictionary<string, SessionInfoData> sessions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "sessions"), typeof(Dictionary<string, SessionInfoData>)) is Dictionary<string, SessionInfoData> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, SessionInfoData>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "sessions", value);
			}
		}

		public System.Boolean _sessionsChanged
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionsChanged"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionsChanged", value);
			}
		}

		public System.Boolean _sessionsAddedOrRemoved
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionsAddedOrRemoved"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionsAddedOrRemoved", value);
			}
		}

		public System.Boolean _initialPublicSessionsFetched
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initialPublicSessionsFetched"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initialPublicSessionsFetched", value);
			}
		}

		public System.Boolean _forceFetchRequested
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_forceFetchRequested"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_forceFetchRequested", value);
			}
		}

		public Task _initialPublicSessionFetchTask
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_initialPublicSessionFetchTask"), typeof(Task)) is Task __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Task");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_initialPublicSessionFetchTask", value);
			}
		}

		public Dictionary<string, DateTime> _removedPublicSessions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_removedPublicSessions"), typeof(Dictionary<string, DateTime>)) is Dictionary<string, DateTime> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<string, DateTime>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_removedPublicSessions", value);
			}
		}

		public DateTime lastCleanup
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "lastCleanup"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "lastCleanup", value);
			}
		}

		public DictionaryList<string, Action<SessionInfo>> _sessionIdListeners
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_sessionIdListeners"), typeof(DictionaryList<string, Action<SessionInfo>>)) is DictionaryList<string, Action<SessionInfo>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DictionaryList<string, Action<SessionInfo>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_sessionIdListeners", value);
			}
		}

		public DictionaryList<RecordId, Action<IReadOnlyList<SessionInfo>>> _worldIdListeners
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_worldIdListeners"), typeof(DictionaryList<RecordId, Action<IReadOnlyList<SessionInfo>>>)) is DictionaryList<RecordId, Action<IReadOnlyList<SessionInfo>>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DictionaryList<RecordId, Action<IReadOnlyList<SessionInfo>>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_worldIdListeners", value);
			}
		}

		public System.Boolean ShouldDoFullFetch
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ShouldDoFullFetch"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public ISessionListingSettings? ListingSettings
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ListingSettings"), typeof(ISessionListingSettings)) is ISessionListingSettings __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ISessionListingSettings");
				}
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
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionsManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
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

		public void RunSessionUpdated(SessionInfo info, System.String normalizedSessionId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunSessionUpdated", info, normalizedSessionId);
		}

		public void UpdateSessionInfo(SessionInfo info, System.Boolean localUpdate = false)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateSessionInfo", info, localUpdate);
		}

		public System.Boolean ShouldRemoveSession(SessionInfoData data)
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

		public Task<CloudResult<List<SessionInfo>>> GetSessions(System.String name = null, System.String universeId = null, System.String hostName = null, System.String hostId = null, int? minActiveUsers = null, System.Boolean includeEmptyHeadless = true)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasUniverse"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

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
		}

		public System.Boolean AcceptSession(SessionInfo sessionInfo)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AcceptSession", sessionInfo), typeof(System.Boolean));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public Dictionary<CreditType, List<CreditUser>> _userCredits
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_userCredits"), typeof(Dictionary<CreditType, List<CreditUser>>)) is Dictionary<CreditType, List<CreditUser>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<CreditType, List<CreditUser>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_userCredits", value);
			}
		}

		public DateTime _lastServerStatsUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastServerStatsUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastServerStatsUpdate", value);
			}
		}

		public DateTime _lastOnlineStatsUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastOnlineStatsUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastOnlineStatsUpdate", value);
			}
		}

		public System.String ServerStatusEndpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerStatusEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerStatus"), typeof(ServerStatus)) is ServerStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ServerStatus");
				}
			}
		}

		public OnlineStats OnlineStats
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlineStats"), typeof(OnlineStats)) is OnlineStats __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OnlineStats");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerResponseTime"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ServerResponseTime", value);
			}
		}

		public DateTime LastServerUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastServerUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastServerUpdate", value);
			}
		}

		public DateTime LastServerStateFetch
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastServerStateFetch"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastServerStateFetch", value);
			}
		}

		public DateTime LastLocalServerResponse
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastLocalServerResponse"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastLocalServerResponse", value);
			}
		}

		public StatisticsManager(SkyFrostInterface cloud, System.String serverStatusEndpoint)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "StatisticsManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud, serverStatusEndpoint);
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

		public Task<CloudResult<ServerStatistics>> GetServerStatistics()
		{
			return (Task<CloudResult<ServerStatistics>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetServerStatistics"), typeof(Task<CloudResult<ServerStatistics>>));
		}

		public Task<OnlineStats> GetOnlineStats()
		{
			return (Task<OnlineStats>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOnlineStats"), typeof(Task<OnlineStats>));
		}

		public Task<CloudStats> GetCloudStats()
		{
			return (Task<CloudStats>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetCloudStats"), typeof(Task<CloudStats>));
		}

		public Task<CloudResult<List<CreditUser>>> GetUserCredits(CreditType type)
		{
			return (Task<CloudResult<List<CreditUser>>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCredits", type), typeof(Task<CloudResult<List<CreditUser>>>));
		}

		public Task<List<CreditUser>> GetUserCreditsCached(CreditType type)
		{
			return (Task<List<CreditUser>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetUserCreditsCached", type), typeof(Task<List<CreditUser>>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "StorageManager", ResoniteBridge.ResoniteBridgeValueType.Type), "storageUpdateDelays"), typeof(float[])) is float[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to float[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "StorageManager", ResoniteBridge.ResoniteBridgeValueType.Type), "storageUpdateDelays", value);
			}
		}

		public System.Boolean _updateCurrentUserStorage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_updateCurrentUserStorage"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_updateCurrentUserStorage", value);
			}
		}

		public Storage _currentUserStorage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_currentUserStorage"), typeof(Storage)) is Storage __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Storage");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_currentUserStorage", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue _storageDirty
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_storageDirty"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<string, bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_storageDirty", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue _updatingStorage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_updatingStorage"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<string, bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_updatingStorage", value);
			}
		}

		public long? CurrentStorageQuota
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorageQuota"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		public long? CurrentStorageUsed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorageUsed"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		public long? CurrentStorageFree
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorageFree"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		public Storage CurrentStorage
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentStorage"), typeof(Storage)) is Storage __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Storage");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentStorage", value);
			}
		}

		public event Action<Storage> StorageUpdated;

		public StorageManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "StorageManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
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

		public Task<CloudResult<Storage>> UpdateCurrentUserStorage()
		{
			return (Task<CloudResult<Storage>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateCurrentUserStorage"), typeof(Task<CloudResult<Storage>>));
		}

		public Task UpdateStorage(System.String ownerId)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStorage", ownerId), typeof(Task));
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public void Reset()
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public UsersManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UsersManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
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

		public Task<CloudResult<User>> GetUserCached(System.String userId)
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

		public Task<CloudResult<UserSessionResult<User>>> Register(System.String username, System.String email, System.String password, DateTimeOffset dateOfBirth, System.String migrationCredential = null, System.String migrationPassword = null, System.String migrationTotp = null, System.Boolean resetUserId = false)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "QuietMode"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "QuietMode", value);
			}
		}

		public System.Single AwayActivateSeconds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "AwayActivateSeconds"), typeof(System.Single)) is System.Single __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "AwayActivateSeconds", value);
			}
		}

		public OnlineStatus _onlineStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_onlineStatus"), typeof(OnlineStatus)) is OnlineStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OnlineStatus");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_onlineStatus", value);
			}
		}

		public UserStatus status
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "status"), typeof(UserStatus)) is UserStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserStatus");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "status", value);
			}
		}

		public DateTime lastSessionChangeTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "lastSessionChangeTimestamp"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "lastSessionChangeTimestamp", value);
			}
		}

		public DateTime lastPublicKeyUpdateTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "lastPublicKeyUpdateTimestamp"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "lastPublicKeyUpdateTimestamp", value);
			}
		}

		public CancellationTokenSource publicKeyCancellationToken
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "publicKeyCancellationToken"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "publicKeyCancellationToken", value);
			}
		}

		public System.Boolean _forceUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_forceUpdate"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_forceUpdate", value);
			}
		}

		public System.Object _lock
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

		public System.Boolean ForceInvisible
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceInvisible"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForceInvisible", value);
			}
		}

		public IUserStatusSource StatusSource
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StatusSource"), typeof(IUserStatusSource)) is IUserStatusSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IUserStatusSource");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Boolean LoadingOnlineStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LoadingOnlineStatus"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public OnlineStatus OnlineStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlineStatus"), typeof(OnlineStatus)) is OnlineStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OnlineStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPresent"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPresent", value);
			}
		}

		public System.Boolean IsAutoAway
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsAutoAway"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsAutoAway", value);
			}
		}

		public UserStatusManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserStatusManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public void ForceUpdate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ForceUpdate");
		}

		public void UpdatePublicKey()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdatePublicKey");
		}

		public void UpdateStatus()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateStatus");
		}

		public void DoUpdate()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DoUpdate");
		}

		public void SignIn()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignIn");
		}

		public void SendStatusToUser(System.String userId)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendStatusToUser", userId);
		}

		public Task SignOut()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SignOut"), typeof(Task));
		}

		public void SetStatusToOffline()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetStatusToOffline");
		}

		public void InitializeNewStatus()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InitializeNewStatus");
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public VisitsManager(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "VisitsManager", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public Task<CloudResult> LogVisit(Visit visit)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "LogVisit", visit), typeof(Task<CloudResult>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateUserProfile"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateUserProfile", value);
			}
		}

		[JsonProperty(PropertyName = "migrateFundingEvents")]
		[JsonPropertyName("migrateFundingEvents")]
		public System.Boolean MigrateFundingEvents
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateFundingEvents"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateFundingEvents", value);
			}
		}

		[JsonProperty(PropertyName = "migrateExitMessages")]
		[JsonPropertyName("migrateExitMessages")]
		public System.Boolean MigrateExitMessages
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateExitMessages"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateExitMessages", value);
			}
		}

		[JsonProperty(PropertyName = "migrateContacts")]
		[JsonPropertyName("migrateContacts")]
		public System.Boolean MigrateContacts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateContacts"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateContacts", value);
			}
		}

		[JsonProperty(PropertyName = "migrateMessageHistory")]
		[JsonPropertyName("migrateMessageHistory")]
		public System.Boolean MigrateMessageHistory
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateMessageHistory"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateMessageHistory", value);
			}
		}

		[JsonProperty(PropertyName = "migrateCloudVariables")]
		[JsonPropertyName("migrateCloudVariables")]
		public System.Boolean MigrateCloudVariables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateCloudVariables"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateCloudVariables", value);
			}
		}

		[JsonProperty(PropertyName = "migrateCloudVariableDefinitions")]
		[JsonPropertyName("migrateCloudVariableDefinitions")]
		public System.Boolean MigrateCloudVariableDefinitions
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateCloudVariableDefinitions"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateCloudVariableDefinitions", value);
			}
		}

		[JsonProperty(PropertyName = "migrateUserRecords")]
		[JsonPropertyName("migrateUserRecords")]
		public System.Boolean MigrateUserRecords
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateUserRecords"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateUserRecords", value);
			}
		}

		[JsonProperty(PropertyName = "migrateRecordAuditLog")]
		[JsonPropertyName("migrateRecordAuditLog")]
		public System.Boolean MigrateRecordAuditLog
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateRecordAuditLog"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateRecordAuditLog", value);
			}
		}

		[JsonProperty(PropertyName = "preserveOldHome")]
		[JsonPropertyName("preserveOldHome")]
		public System.Boolean PreserveOldHome
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PreserveOldHome"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PreserveOldHome", value);
			}
		}

		[JsonProperty(PropertyName = "recordsToMigrate")]
		[JsonPropertyName("recordsToMigrate")]
		public List<string> RecordsToMigrate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordsToMigrate"), typeof(List<string>)) is List<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordsToMigrate", value);
			}
		}

		[JsonProperty(PropertyName = "variablesToMigrate")]
		[JsonPropertyName("variablesToMigrate")]
		public List<string> VariablesToMigrate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariablesToMigrate"), typeof(List<string>)) is List<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariablesToMigrate", value);
			}
		}

		[JsonProperty(PropertyName = "onlyNewRecords")]
		[JsonPropertyName("onlyNewRecords")]
		public System.Boolean OnlyNewRecords
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlyNewRecords"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "OnlyNewRecords", value);
			}
		}

		[JsonProperty(PropertyName = "forceOverwrite")]
		[JsonPropertyName("forceOverwrite")]
		public System.Boolean ForceOverwrite
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceOverwrite"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForceOverwrite", value);
			}
		}

		[JsonProperty(PropertyName = "migrateGroups")]
		[JsonPropertyName("migrateGroups")]
		public System.Boolean MigrateGroups
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigrateGroups"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigrateGroups", value);
			}
		}

		[JsonProperty(PropertyName = "groupsToMigrate")]
		[JsonPropertyName("groupsToMigrate")]
		public HashSet<string> GroupsToMigrate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupsToMigrate"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupsToMigrate", value);
			}
		}

		public System.Boolean IsMigratingSomething
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMigratingSomething"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public void ClearAll()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ClearAll");
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public DateTime? _lastSnapshot
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastSnapshot"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastSnapshot", value);
			}
		}

		public System.Int32 _lastMigratedRecords
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastMigratedRecords"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastMigratedRecords", value);
			}
		}

		[System.Text.Json.Serialization.JsonIgnore]
		[Newtonsoft.Json.JsonIgnore]
		public TimeSpan? TotalTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalTime"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
			}
		}

		[JsonProperty(PropertyName = "phase")]
		[JsonPropertyName("phase")]
		public System.String Phase
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Phase"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Phase", value);
			}
		}

		[JsonProperty(PropertyName = "startedOn")]
		[JsonPropertyName("startedOn")]
		public DateTimeOffset? StartedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StartedOn"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StartedOn", value);
			}
		}

		[JsonProperty(PropertyName = "completedOn")]
		[JsonPropertyName("completedOn")]
		public DateTimeOffset? CompletedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CompletedOn"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CompletedOn", value);
			}
		}

		[JsonProperty(PropertyName = "userRecordsStatus")]
		[JsonPropertyName("userRecordsStatus")]
		public RecordMigrationStatus UserRecordsStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserRecordsStatus"), typeof(RecordMigrationStatus)) is RecordMigrationStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordMigrationStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserVariablesStatus"), typeof(VariableMigrationStatus)) is VariableMigrationStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VariableMigrationStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordsPerMinute"), typeof(System.Double)) is System.Double __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RecordsPerMinute", value);
			}
		}

		[JsonProperty(PropertyName = "currentlyMigratingName")]
		[JsonPropertyName("currentlyMigratingName")]
		public System.String CurrentlyMigratingName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentlyMigratingName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentlyMigratingItem"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalContactCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalContactCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedContactCount")]
		[JsonPropertyName("migratedContactCount")]
		public System.Int32 MigratedContactCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedContactCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedContactCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedMessageCount")]
		[JsonPropertyName("migratedMessageCount")]
		public System.Int32 MigratedMessageCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedMessageCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedMessageCount", value);
			}
		}

		[JsonProperty(PropertyName = "totalGroupCount")]
		[JsonPropertyName("totalGroupCount")]
		public System.Int32 TotalGroupCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalGroupCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalGroupCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedGroupCount")]
		[JsonPropertyName("migratedGroupCount")]
		public System.Int32 MigratedGroupCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedGroupCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedGroupCount", value);
			}
		}

		[JsonProperty(PropertyName = "missingAssets")]
		[JsonPropertyName("missingAssets")]
		public HashSet<string> MissingAssets
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MissingAssets"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MissingAssets", value);
			}
		}

		[JsonProperty(PropertyName = "error")]
		[JsonPropertyName("error")]
		public System.String Error
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Error"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MessagesFailed"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MessagesFailed", value);
			}
		}

		[JsonProperty(PropertyName = "abort")]
		[JsonPropertyName("abort")]
		public System.Boolean Abort
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Abort"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Abort", value);
			}
		}

		[JsonProperty(PropertyName = "groupStatuses")]
		[JsonPropertyName("groupStatuses")]
		public List<GroupMigrationStatus> GroupStatuses
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupStatuses"), typeof(List<GroupMigrationStatus>)) is List<GroupMigrationStatus> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<GroupMigrationStatus>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalMigratedMemberCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
		public System.Int32 TotalMigratedVariableCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalMigratedVariableCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
		public System.Int32 TotalMigratedVariableDefinitionCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalMigratedVariableDefinitionCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
		public System.Int32 TotalRecordCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
		public System.Int32 TotalProcessedRecordCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalProcessedRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
		public System.Int32 TotalFailedRecordCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalFailedRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public System.String TaskId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TaskId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		[JsonProperty(PropertyName = "state")]
		[JsonPropertyName("state")]
		public MigrationState State
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(MigrationState)) is MigrationState __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MigrationState");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		[JsonProperty(PropertyName = "estimatedQueuePosition")]
		[JsonPropertyName("estimatedQueuePosition")]
		public int? EstimatedQueuePosition
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EstimatedQueuePosition"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EstimatedQueuePosition", value);
			}
		}

		[JsonProperty(PropertyName = "createdOn")]
		[JsonPropertyName("createdOn")]
		public DateTimeOffset CreatedOn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CreatedOn"), typeof(DateTimeOffset)) is DateTimeOffset __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CreatedOn", value);
			}
		}

		[JsonProperty(PropertyName = "startCount")]
		[JsonPropertyName("startCount")]
		public System.Int32 StartCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StartCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "StartCount", value);
			}
		}

		[JsonProperty(PropertyName = "lastError")]
		[JsonPropertyName("lastError")]
		public System.String LastError
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastError"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Config"), typeof(AccountMigrationConfig)) is AccountMigrationConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AccountMigrationConfig");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(AccountMigrationStatus)) is AccountMigrationStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AccountMigrationStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactsCompleted"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContactsCompleted", value);
			}
		}

		[JsonProperty(PropertyName = "userOwnedCompleted")]
		[JsonPropertyName("userOwnedCompleted")]
		public System.Boolean UserOwnedCompleted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserOwnedCompleted"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UserOwnedCompleted", value);
			}
		}

		[JsonProperty(PropertyName = "groupsCompleted")]
		[JsonPropertyName("groupsCompleted")]
		public HashSet<string> GroupsCompleted
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GroupsCompleted"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GroupsCompleted", value);
			}
		}

		[JsonProperty(PropertyName = "runStatuses")]
		[JsonPropertyName("runStatuses")]
		public List<AccountMigrationStatus> RunStatuses
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RunStatuses"), typeof(List<AccountMigrationStatus>)) is List<AccountMigrationStatus> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<AccountMigrationStatus>");
				}
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		[JsonProperty(PropertyName = "migratedMemberCount")]
		[JsonPropertyName("migratedMemberCount")]
		public System.Int32 MigratedMemberCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedMemberCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedMemberCount", value);
			}
		}

		[JsonProperty(PropertyName = "recordsStatus")]
		[JsonPropertyName("recordsStatus")]
		public RecordMigrationStatus RecordsStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordsStatus"), typeof(RecordMigrationStatus)) is RecordMigrationStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordMigrationStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "VariablesStatus"), typeof(VariableMigrationStatus)) is VariableMigrationStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VariableMigrationStatus");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "VariablesStatus", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceCloudConfig"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceLogin"), typeof(LoginCredentials)) is LoginCredentials __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SourceLogin", value);
			}
		}

		[JsonProperty(PropertyName = "sourceTOTP")]
		[JsonPropertyName("sourceTOTP")]
		public System.String SourceTOTP
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceTOTP"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceSession"), typeof(UserSession)) is UserSession __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserSession");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceUID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SourceSecretMachineID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Config"), typeof(AccountMigrationConfig)) is AccountMigrationConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AccountMigrationConfig");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Config", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		[JsonProperty(PropertyName = "recordName")]
		[JsonPropertyName("recordName")]
		public System.String RecordName
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordName"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FailureReason"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "FailureReason", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedRecordCount")]
		[JsonPropertyName("migratedRecordCount")]
		public System.Int32 MigratedRecordCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "alreadyMigratedRecordCount")]
		[JsonPropertyName("alreadyMigratedRecordCount")]
		public System.Int32 AlreadyMigratedRecordCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AlreadyMigratedRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AlreadyMigratedRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "conflictedRecordCount")]
		[JsonPropertyName("conflictedRecordCount")]
		public System.Int32 ConflictedRecordCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ConflictedRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ConflictedRecordCount", value);
			}
		}

		[JsonProperty(PropertyName = "totalProcessedRecordCount")]
		[JsonPropertyName("totalProcessedRecordCount")]
		public System.Int32 TotalProcessedRecordCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalProcessedRecordCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		[JsonProperty(PropertyName = "recordSearchPhase")]
		[JsonPropertyName("recordSearchPhase")]
		public System.String RecordSearchPhase
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RecordSearchPhase"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesToUpload"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesToUpload", value);
			}
		}

		[JsonProperty(PropertyName = "bytesUploaded")]
		[JsonPropertyName("bytesUploaded")]
		public System.Int64 BytesUploaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesUploaded"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesUploaded", value);
			}
		}

		[JsonProperty(PropertyName = "assetsToUpload")]
		[JsonPropertyName("assetsToUpload")]
		public System.Int32 AssetsToUpload
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsToUpload"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsToUpload", value);
			}
		}

		[JsonProperty(PropertyName = "assetsUploaded")]
		[JsonPropertyName("assetsUploaded")]
		public System.Int32 AssetsUploaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsUploaded"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsUploaded", value);
			}
		}

		[JsonProperty(PropertyName = "lastUpdated")]
		[JsonPropertyName("lastUpdated")]
		public DateTime LastUpdated
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastUpdated"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastUpdated", value);
			}
		}

		[JsonProperty(PropertyName = "currentlyMigratingRecords")]
		[JsonPropertyName("currentlyMigratingRecords")]
		public HashSet<string> CurrentlyMigratingRecords
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentlyMigratingRecords"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentlyMigratingRecords", value);
			}
		}

		[JsonProperty(PropertyName = "failedRecords")]
		[JsonPropertyName("failedRecords")]
		public List<RecordMigrationFailure> FailedRecords
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FailedRecords"), typeof(List<RecordMigrationFailure>)) is List<RecordMigrationFailure> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<RecordMigrationFailure>");
				}
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedVariableCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedVariableCount", value);
			}
		}

		[JsonProperty(PropertyName = "migratedVariableDefinitionCount")]
		[JsonPropertyName("migratedVariableDefinitionCount")]
		public System.Int32 MigratedVariableDefinitionCount
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MigratedVariableDefinitionCount"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MigratedVariableDefinitionCount", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_DLL_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_DLL_LENGTH", value);
			}
		}

		public System.Int32 MAX_NAME_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_NAME_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_NAME_LENGTH", value);
			}
		}

		public System.Int32 MAX_DESCRIPTION_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_DESCRIPTION_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_DESCRIPTION_LENGTH", value);
			}
		}

		public System.Int32 MAX_TAG_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_TAG_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_TAG_LENGTH", value);
			}
		}

		public System.Int32 MAX_TAGS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_TAGS"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_TAGS", value);
			}
		}

		public System.Int32 MAX_PARENT_SESSION_IDS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_PARENT_SESSION_IDS"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_PARENT_SESSION_IDS", value);
			}
		}

		public System.Int32 MAX_NESTED_SESSION_IDS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_NESTED_SESSION_IDS"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_NESTED_SESSION_IDS", value);
			}
		}

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

		public System.Int32 MAX_URL_LENGTH
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_URL_LENGTH"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_URL_LENGTH", value);
			}
		}

		public System.Int32 MAX_USER_COUNT
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MAX_USER_COUNT"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MAX_USER_COUNT", value);
			}
		}

		public static TimeSpan SESSION_UPDATE_INTERVAL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), "SESSION_UPDATE_INTERVAL"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
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
		public RecordId ActualCorrespondingWorldId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActualCorrespondingWorldId"), typeof(RecordId)) is RecordId __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordId");
				}
			}
		}

		[JsonProperty(PropertyName = "correspondingWorldId")]
		[JsonPropertyName("correspondingWorldId")]
		public RecordId CorrespondingWorldId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CorrespondingWorldId"), typeof(RecordId)) is RecordId __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CorrespondingWorldId", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public RecordId PrivateCorrespondingWorldId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PrivateCorrespondingWorldId"), typeof(RecordId)) is RecordId __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "PrivateCorrespondingWorldId", value);
			}
		}

		[JsonProperty(PropertyName = "tags")]
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

		[JsonProperty(PropertyName = "normalizedSessionId")]
		[JsonPropertyName("normalizedSessionId")]
		public System.String NormalizedSessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NormalizedSessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		[JsonProperty(PropertyName = "hostMachineId")]
		[JsonPropertyName("hostMachineId")]
		public System.String HostMachineId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostMachineId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		[JsonProperty(PropertyName = "systemCompatibilityHash")]
		[JsonPropertyName("systemCompatibilityHash")]
		public System.String SystemCompatibilityHash
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SystemCompatibilityHash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DataModelAssemblies"), typeof(List<AssemblyInfo>)) is List<AssemblyInfo> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<AssemblyInfo>");
				}
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

		[JsonProperty(PropertyName = "appVersion")]
		[JsonPropertyName("appVersion")]
		public System.String AppVersion
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppVersion"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HeadlessHost"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HeadlessHost", value);
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

		[JsonProperty(PropertyName = "nestedSessionIds")]
		[JsonPropertyName("nestedSessionIds")]
		public List<string> NestedSessionIds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NestedSessionIds"), typeof(List<string>)) is List<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "NestedSessionIds", value);
			}
		}

		[JsonProperty(PropertyName = "sessionUsers")]
		[JsonPropertyName("sessionUsers")]
		public List<SessionUser> SessionUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionUsers"), typeof(List<SessionUser>)) is List<SessionUser> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<SessionUser>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ThumbnailUrl"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		[JsonProperty(PropertyName = "totalJoinedUsers")]
		[JsonPropertyName("totalJoinedUsers")]
		public System.Int32 TotalJoinedUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalJoinedUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalJoinedUsers", value);
			}
		}

		[JsonProperty(PropertyName = "totalActiveUsers")]
		[JsonPropertyName("totalActiveUsers")]
		public System.Int32 TotalActiveUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalActiveUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "TotalActiveUsers", value);
			}
		}

		[JsonProperty(PropertyName = "maxUsers")]
		[JsonPropertyName("maxUsers")]
		public System.Int32 MaximumUsers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaximumUsers"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaximumUsers", value);
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

		[JsonProperty(PropertyName = "sessionBeginTime")]
		[JsonPropertyName("sessionBeginTime")]
		public DateTime SessionBeginTime
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionBeginTime"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SessionBeginTime", value);
			}
		}

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

		[JsonProperty(PropertyName = "hideFromListing")]
		[JsonPropertyName("hideFromListing")]
		public System.Boolean HideFromListing
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HideFromListing"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "HideFromListing", value);
			}
		}

		[JsonProperty(PropertyName = "broadcastKey")]
		[JsonPropertyName("broadcastKey")]
		public System.String BroadcastKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BroadcastKey"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BroadcastKey", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public ushort? LAN_Port
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LAN_Port"), typeof(System.UInt16)) is System.UInt16 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LAN_Port", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.String LAN_URL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LAN_URL"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsOnLAN"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
		public DateTime LastLAN_Update
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastLAN_Update"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastLAN_Update", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime LastWorldConfigurationUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastWorldConfigurationUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastWorldConfigurationUpdate", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime LastWorldUserUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastWorldUserUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastWorldUserUpdate", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public DateTime LastInviteListUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastInviteListUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastInviteListUpdate", value);
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
		public System.Single ExpirationProgress
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ExpirationProgress"), typeof(System.Single)) is System.Single __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to float");
				}
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public System.String SanitizedHostUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SanitizedHostUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Boolean HasEnded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HasEnded"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
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
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type));
		}

		public SessionInfo(System.String sessionId)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SessionInfo", ResoniteBridge.ResoniteBridgeValueType.Type), sessionId);
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

		public List<System.Uri> GetSessionURLs()
		{
			return (List<System.Uri>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetSessionURLs"), typeof(List<System.Uri>));
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HostedSessions"), typeof(List<SessionInfo>)) is List<SessionInfo> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<SessionInfo>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RemovedSessions"), typeof(List<string>)) is List<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RemovedSessions", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		[JsonProperty(PropertyName = "userID")]
		[JsonPropertyName("userID")]
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

		[JsonProperty(PropertyName = "userSessionId")]
		[JsonPropertyName("userSessionId")]
		public System.String UserSessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPresent"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPresent", value);
			}
		}

		[JsonProperty(PropertyName = "outputDevice")]
		[JsonPropertyName("outputDevice")]
		[Newtonsoft.Json.JsonConverter(typeof(NewtonsoftJsonTransitionEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonTransitionEnumConverter<OutputDevice>))]
		public OutputDevice? OutputDevice
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDevice"), typeof(OutputDevice)) is OutputDevice __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OutputDevice");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SanitizedUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.Boolean Equals(SessionUser other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Equals", other), typeof(System.Boolean));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SECRET_CLIENT_KEY"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "CLOUDFLARE_DURIAN_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DURIAN_ASSET_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DURIAN_VARIANT_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DURIAN_THUMBNAIL_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "CLOUDFLARE_SKYFROST_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SKYFROST_ASSET_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SKYFROST_VARIANT_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SKYFROST_THUMBNAIL_ENDPOINT"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Platform"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Platform", value);
			}
		}

		[JsonPropertyName("userAgentProduct")]
		public System.String UserAgentProduct
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentProduct"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentVersion"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GZip"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GZip", value);
			}
		}

		[JsonPropertyName("proxyConfig")]
		public ProxyConfig ProxyConfig
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProxyConfig"), typeof(ProxyConfig)) is ProxyConfig __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ProxyConfig", value);
			}
		}

		[JsonPropertyName("apiEndpoint")]
		public System.String ApiEndpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApiEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SignalREndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ServerStatusEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SecretClientAccessKey"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Saml2Endpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DefaultTimeout"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetInterface"), typeof(AssetInterface)) is AssetInterface __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AssetInterface");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkNodes"), typeof(INetworkNodeManager)) is INetworkNodeManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INetworkNodeManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContactPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseLegacyLogin"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "UseLegacyLogin", value);
			}
		}

		[JsonPropertyName("universeId")]
		public System.String UniverseID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		public static SkyFrostConfig DEFAULT_PRODUCTION
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PRODUCTION"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig DEFAULT_PRODUCTION_DIRECT
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_PRODUCTION_DIRECT"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig DEFAULT_STAGING
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_STAGING"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig DEFAULT_LOCAL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_LOCAL"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig DURIAN_LOCAL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN_LOCAL"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig DURIAN_STAGING
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN_STAGING"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig DURIAN_PRODUCTION
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "DURIAN_PRODUCTION"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig SKYFROST_LOCAL
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_LOCAL"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig SKYFROST_STAGING
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_STAGING"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig SKYFROST_PRODUCTION
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_PRODUCTION"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

		public static SkyFrostConfig SKYFROST_PRODUCTION_DIRECT
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostConfig", ResoniteBridge.ResoniteBridgeValueType.Type), "SKYFROST_PRODUCTION_DIRECT"), typeof(SkyFrostConfig)) is SkyFrostConfig __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SkyFrostConfig");
				}
			}
		}

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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionHash"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		[JsonProperty(PropertyName = "isHost")]
		[JsonPropertyName("isHost")]
		public System.Boolean IsHost
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsHost"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsHost", value);
			}
		}

		[JsonProperty(PropertyName = "broadcastKey")]
		[JsonPropertyName("broadcastKey")]
		public System.String BroadcastKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BroadcastKey"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserStatus", ResoniteBridge.ResoniteBridgeValueType.Type), "StatusExpiration"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "UserStatus", ResoniteBridge.ResoniteBridgeValueType.Type), "StatusHeartbeat"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
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

		[JsonProperty(PropertyName = "userSessionId")]
		[JsonPropertyName("userSessionId")]
		public System.String UserSessionId
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserSessionId"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SessionType"), typeof(UserSessionType)) is UserSessionType __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserSessionType");
				}
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
		public OutputDevice? OutputDevice
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OutputDevice"), typeof(OutputDevice)) is OutputDevice __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OutputDevice");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsMobile"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsMobile", value);
			}
		}

		[JsonProperty(PropertyName = "onlineStatus")]
		[JsonPropertyName("onlineStatus")]
		[Newtonsoft.Json.JsonConverter(typeof(StringEnumConverter))]
		[System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverter))]
		public OnlineStatus? OnlineStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "OnlineStatus"), typeof(OnlineStatus)) is OnlineStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to OnlineStatus");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsPresent"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsPresent", value);
			}
		}

		[JsonProperty(PropertyName = "lastPresenceTimestamp")]
		[JsonPropertyName("lastPresenceTimestamp")]
		public DateTime? LastPresenceTimestamp
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastPresenceTimestamp"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastPresenceTimestamp", value);
			}
		}

		[JsonProperty(PropertyName = "lastStatusChange")]
		[JsonPropertyName("lastStatusChange")]
		public DateTime LastStatusChange
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastStatusChange"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastStatusChange", value);
			}
		}

		[JsonProperty(PropertyName = "hashSalt")]
		[JsonPropertyName("hashSalt")]
		public System.String HashSalt
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HashSalt"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppVersion"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		[JsonProperty(PropertyName = "publicRSAKey")]
		[JsonPropertyName("publicRSAKey")]
		public RSAParametersData PublicRSAKey
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "PublicRSAKey"), typeof(RSAParametersData)) is RSAParametersData __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RSAParametersData");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Sessions"), typeof(List<UserSessionMetadata>)) is List<UserSessionMetadata> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<UserSessionMetadata>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSessionIndex"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "CurrentSessionIndex", value);
			}
		}

		[Newtonsoft.Json.JsonIgnore]
		[System.Text.Json.Serialization.JsonIgnore]
		public UserSessionMetadata CurrentSession
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentSession"), typeof(UserSessionMetadata)) is UserSessionMetadata __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserSessionMetadata");
				}
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public static HashSet<string> IGNORE_TAGS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "IGNORE_TAGS"), typeof(HashSet<string>)) is HashSet<string> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "IGNORE_TAGS", value);
			}
		}

		public static System.String CommonAvatar
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CommonAvatar"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String CommonTool
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "CommonTool"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String ProfileIcon
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfileIcon"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String MessageItem
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "MessageItem"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String WorldOrb
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "WorldOrb"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String AudioPlayer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "AudioPlayer"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VideoPlayer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VideoPlayer"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VirtualKeyboard
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VirtualKeyboard"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String InteractiveCamera
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "InteractiveCamera"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Facet
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Facet"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String ProgressBar
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ProgressBar"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String WorldLoadingProgress
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "WorldLoadingProgress"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String AudioStreamInterface
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "AudioStreamInterface"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String TextDisplay
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "TextDisplay"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String DocumentDisplay
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "DocumentDisplay"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String UrlDisplay
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "UrlDisplay"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String NameplateTemplate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "NameplateTemplate"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String NoticeDisplay
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "NoticeDisplay"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String ColorDialog
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ColorDialog"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Photo
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Photo"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VRPhoto
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VRPhoto"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String Photo360
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "Photo360"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String PhotoStereo
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "PhotoStereo"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String RawFile
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "RawFile"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String AudioClip
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "AudioClip"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public static System.String VideoClip
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "VideoClip"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

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

		public static System.String ExtractValue(HashSet<string> tags, System.String prefix)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "ExtractValue", tags, prefix), typeof(System.String));
		}

		public static void GenerateTagsFromName(System.String name, HashSet<string> tags)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordTags", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateTagsFromName", name, tags);
		}

		public static void ExtractTag(StringBuilder tagBuilder, HashSet<string> tags)
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_REQUESTS"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "DEBUG_REQUESTS", value);
			}
		}

		public static System.Boolean UseNewtonsoftJson
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "UseNewtonsoftJson"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "UseNewtonsoftJson", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue SignalRTransports
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SignalRTransports"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpTransportType");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfilerBeginSampleCallback"), typeof(Action<string>)) is Action<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<string>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "ProfilerEndSampleCallback"), typeof(Action)) is Action __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MemoryStreamAllocator"), typeof(Func<MemoryStream>)) is Func<MemoryStream> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Func<MemoryStream>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "MemoryStreamAllocator", value);
			}
		}

		public CancellationTokenSource _hubConnectionToken
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_hubConnectionToken"), typeof(CancellationTokenSource)) is CancellationTokenSource __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CancellationTokenSource");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_hubConnectionToken", value);
			}
		}

		public ResoniteBridge.ResoniteBridgeValue _metadataBatchQueries
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_metadataBatchQueries"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ConcurrentDictionary<Type, object>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_metadataBatchQueries", value);
			}
		}

		public System.Int32 SignalRConnectionAttempts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SignalRConnectionAttempts"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SignalRConnectionAttempts", value);
			}
		}

		public System.String UID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		public System.String UserAgentProduct
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentProduct"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgentVersion"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ApiEndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SignalREndpoint"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "SignalREndpoint", value);
			}
		}

		public ProductInfoHeaderValue UserAgent
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UserAgent"), typeof(ProductInfoHeaderValue)) is ProductInfoHeaderValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ProductInfoHeaderValue");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User)) is User __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to User");
				}
			}
		}

		public System.String CurrentUserID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.String CurrentUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.String UniverseID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UniverseID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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

		public IPlatformProfile Platform
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Platform"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Platform", value);
			}
		}

		public ApiClient Api
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient)) is ApiClient __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ApiClient");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Api", value);
			}
		}

		public HttpClient SafeHttpClient
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SafeHttpClient"), typeof(HttpClient)) is HttpClient __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpClient");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Proxy"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to WebProxy");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HubClient"), typeof(AppHub)) is AppHub __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AppHub");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetGatherer"), typeof(AssetGatherer)) is AssetGatherer __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AssetGatherer");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Assets"), typeof(AssetInterface)) is AssetInterface __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AssetInterface");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ProxyConfig"), typeof(ProxyConfig)) is ProxyConfig __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ProxyConfig", value);
			}
		}

		public virtual System.Boolean UseAlternateWebsocket
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "UseAlternateWebsocket"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public HubStatusController HubStatusController
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "HubStatusController"), typeof(HubStatusController)) is HubStatusController __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HubStatusController");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Session"), typeof(SessionManager)) is SessionManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SessionManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Users"), typeof(UsersManager)) is UsersManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UsersManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Storage"), typeof(StorageManager)) is StorageManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to StorageManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Security"), typeof(SecurityManager)) is SecurityManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SecurityManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Profile"), typeof(ProfileManager)) is ProfileManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ProfileManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Stats"), typeof(StatisticsManager)) is StatisticsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to StatisticsManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Records"), typeof(RecordsManager)) is RecordsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordsManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Sessions"), typeof(SessionsManager)) is SessionsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SessionsManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Variables"), typeof(CloudVariableManager)) is CloudVariableManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Status"), typeof(UserStatusManager)) is UserStatusManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to UserStatusManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Contacts"), typeof(ContactManager)) is ContactManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ContactManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Groups"), typeof(GroupsManager)) is GroupsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GroupsManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Messages"), typeof(MessageManager)) is MessageManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MessageManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "NetworkNodes"), typeof(INetworkNodeManager)) is INetworkNodeManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to INetworkNodeManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Migration"), typeof(MigrationManager)) is MigrationManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MigrationManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Visits"), typeof(VisitsManager)) is VisitsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to VisitsManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Badges"), typeof(BadgeManager)) is BadgeManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to BadgeManager");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Moderation"), typeof(ModerationManager)) is ModerationManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ModerationManager");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Moderation", value);
			}
		}

		[Conditional("PROFILE")]
		public void ProfilerBeginSample(System.String name)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerBeginSample", name);
		}

		[Conditional("PROFILE")]
		public void ProfilerEndSample()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerEndSample");
		}

		public MetadataBatchQuery<M> MetadataBatch<M>() where M : class, IAssetMetadata, new()
		{
			return (MetadataBatchQuery<M>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "MetadataBatch"), typeof(MetadataBatchQuery<M>));
		}

		public virtual Task OnLogin()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnLogin"), typeof(Task));
		}

		public virtual Task OnLogout(System.Boolean isManual)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnLogout", isManual), typeof(Task));
		}

		public virtual Task OnSessionTokenRefresh()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "OnSessionTokenRefresh"), typeof(Task));
		}

		public virtual void InstallConfigFile(System.String path, System.String content)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InstallConfigFile", path, content);
		}

		public SkyFrostInterface(System.String uid, System.String secretMachineId, SkyFrostConfig config)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), uid, secretMachineId, config);
		}

		public virtual Task<bool> RunInitialAnonymousHubConnection()
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunInitialAnonymousHubConnection"), typeof(Task<bool>));
		}

		public void AuthenticateApiRequest(HttpRequestMessage request, System.String totpCode)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AuthenticateApiRequest", request, totpCode);
		}

		public Task ConnectToHub(System.String source)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ConnectToHub", source), typeof(Task));
		}

		public static Task Connect(ResoniteBridge.ResoniteBridgeValue connection, System.String source, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostInterface", ResoniteBridge.ResoniteBridgeValueType.Type), "Connect", connection, source, cancellationToken), typeof(Task));
		}

		public Task DisconnectFromHub()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DisconnectFromHub"), typeof(Task));
		}

		public virtual void Update()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Update");
		}

		public Task Login()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Login"), typeof(Task));
		}

		public Task FinalizeSession()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinalizeSession"), typeof(Task));
		}

		public Task BeginLogout(System.Boolean isManual)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BeginLogout", isManual), typeof(Task));
		}

		public void ResetModules()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResetModules");
		}

		public void CompleteLogout(System.Boolean isManual)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CompleteLogout", isManual);
		}

		public System.Boolean HasPotentialAccess(System.String ownerId)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HasPotentialAccess", ownerId), typeof(System.Boolean));
		}

		public Task<bool> InteractiveConsoleLogin(System.Boolean tryUseCommandLineArgs = false)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InteractiveConsoleLogin", tryUseCommandLineArgs), typeof(Task<bool>));
		}

		public Task<T> HandleConsoleLogin<T>(ConsoleLoginHandler<T> handler) where T : CloudResult
		{
			return (Task<T>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HandleConsoleLogin", handler), typeof(Task<T>));
		}

		public Task<bool> InteractiveConsoleRegister()
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "InteractiveConsoleRegister"), typeof(Task<bool>));
		}

		public System.String GetOwnerPath(System.String ownerId)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetOwnerPath", ownerId), typeof(System.String));
		}

		public void ProcessUserSessionResult<T>(UserSessionResult<T> result)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessUserSessionResult", result);
		}

		public Task<ExitMessage> GetRandomExitMessage()
		{
			return (Task<ExitMessage>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetRandomExitMessage"), typeof(Task<ExitMessage>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public ApiClient Api
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Api"), typeof(ApiClient)) is ApiClient __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ApiClient");
				}
			}
		}

		public IPlatformProfile Platform
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Platform"), typeof(IPlatformProfile)) is IPlatformProfile __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IPlatformProfile");
				}
			}
		}

		public System.Boolean IsUserSignedIn
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsUserSignedIn"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public User CurrentUser
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUser"), typeof(User)) is User __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to User");
				}
			}
		}

		public System.String CurrentUserID
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUserID"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public System.String CurrentUsername
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CurrentUsername"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public SkyFrostModule(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SkyFrostModule", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public SkyFrostModule(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public SkyFrostModule()
		{
		}
	}
	public delegate void ApiAuthenticator(HttpRequestMessage request, System.String totpCode);
	public delegate MemoryStream MemoryStreamAllocator();
	public class ApiClient : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static MediaTypeHeaderValue JSON_MEDIA_TYPE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "JSON_MEDIA_TYPE"), typeof(MediaTypeHeaderValue)) is MediaTypeHeaderValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MediaTypeHeaderValue");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "JSON_MEDIA_TYPE", value);
			}
		}

		public static HttpMethod PATCH_METHOD
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "PATCH_METHOD"), typeof(HttpMethod)) is HttpMethod __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpMethod");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "PATCH_METHOD", value);
			}
		}

		public static HttpMethod COPY_METHOD
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), "COPY_METHOD"), typeof(HttpMethod)) is HttpMethod __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpMethod");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultTimeout"), typeof(TimeSpan)) is TimeSpan __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DefaultRetries"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DefaultRetries", value);
			}
		}

		public HttpClient Client
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Client"), typeof(HttpClient)) is HttpClient __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpClient");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ApiBase"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ApiBase", value);
			}
		}

		public ProductInfoHeaderValue UserAgent
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "UserAgent"), typeof(ProductInfoHeaderValue)) is ProductInfoHeaderValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ProductInfoHeaderValue");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "SecretClientAccessKey"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "SecretClientAccessKey", value);
			}
		}

		public ApiAuthenticator authenticator
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "authenticator"), typeof(ApiAuthenticator)) is ApiAuthenticator __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to ApiAuthenticator");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "authenticator", value);
			}
		}

		public MemoryStreamAllocator memoryAllocator
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "memoryAllocator"), typeof(MemoryStreamAllocator)) is MemoryStreamAllocator __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to MemoryStreamAllocator");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "memoryAllocator", value);
			}
		}

		public Action<string> profilerBeginSampleCallback
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "profilerBeginSampleCallback"), typeof(Action<string>)) is Action<string> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action<string>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "profilerBeginSampleCallback", value);
			}
		}

		public Action profilerEndSampleCallback
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "profilerEndSampleCallback"), typeof(Action)) is Action __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Action");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "LastServerResponse"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "LastServerResponse", value);
			}
		}

		public ApiClient(HttpClient client, System.String apiBase, ApiAuthenticator authenticator, ProductInfoHeaderValue userAgent, System.String secretClientAccessKey = null, MemoryStreamAllocator memoryAllocator = null, Action<string> profilerBeginSampleCallback = null, Action profilerEndSampleCallback = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "ApiClient", ResoniteBridge.ResoniteBridgeValueType.Type), client, apiBase, authenticator, userAgent, secretClientAccessKey, memoryAllocator, profilerBeginSampleCallback, profilerEndSampleCallback);
		}

		[Conditional("PROFILE")]
		public void ProfilerBeginSample(System.String name)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerBeginSample", name);
		}

		[Conditional("PROFILE")]
		public void ProfilerEndSample()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProfilerEndSample");
		}

		public Task<CloudResult<T>> GET<T>(System.String resource, TimeSpan? timeout = null, System.Boolean throwOnError = true) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GET", resource, timeout, throwOnError), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> HEAD<T>(System.String resource, TimeSpan? timeout = null, System.Boolean throwOnError = true) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "HEAD", resource, timeout, throwOnError), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> POST<T>(System.String resource, System.Object entity, TimeSpan? timeout = null, System.String totpCode = null, System.Boolean throwOnError = true, Action<HttpRequestMessage> postprocessRequest = null) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST", resource, entity, timeout, totpCode, throwOnError, postprocessRequest), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> POST_File<T>(System.String resource, System.String filePath, System.String fileMIME = null, IProgressIndicator progressIndicator = null) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_File", resource, filePath, fileMIME, progressIndicator), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> PUT<T>(System.String resource, System.Object entity, TimeSpan? timeout = null, System.Boolean throwOnError = true, System.String totpCode = null, Action<HttpRequestMessage> postprocessRequest = null) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> PATCH<T>(System.String resource, System.Object entity, TimeSpan? timeout = null, System.Boolean throwOnError = true, System.String totpCode = null, Action<HttpRequestMessage> postprocessRequest = null) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PATCH", resource, entity, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult<T>> DELETE<T>(System.String resource, TimeSpan? timeout = null, System.String totpCode = null, System.Boolean throwOnError = true) where T : class, new()
		{
			return (Task<CloudResult<T>>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DELETE", resource, timeout, totpCode, throwOnError), typeof(Task<CloudResult<T>>));
		}

		public Task<CloudResult> COPY(System.String resource, TimeSpan? timeout = null, System.Boolean throwOnError = true, System.String totpCode = null, Action<HttpRequestMessage> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "COPY", resource, timeout, throwOnError, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> POST(System.String resource, System.Object entity, TimeSpan? timeout = null, System.String totpCode = null, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST", resource, entity, timeout, totpCode, throwOnError), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> POST_FileMultipart(System.String resource, System.String filePath, System.String fileMIME = null, IProgressIndicator progressIndicator = null, System.String totpCode = null, Action<HttpRequestMessage> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_FileMultipart", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> POST_FileDirect(System.String resource, System.String filePath, System.String fileMIME = null, IProgressIndicator progressIndicator = null, System.String totpCode = null, Action<HttpRequestMessage> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "POST_FileDirect", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> PUT_FileMultipart(System.String resource, System.String filePath, System.String fileMIME = null, IProgressIndicator progressIndicator = null, System.String totpCode = null, Action<HttpRequestMessage> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT_FileMultipart", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> PUT_FileDirect(System.String resource, System.String filePath, System.String fileMIME = null, IProgressIndicator progressIndicator = null, System.String totpCode = null, Action<HttpRequestMessage> postprocessRequest = null)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT_FileDirect", resource, filePath, fileMIME, progressIndicator, totpCode, postprocessRequest), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> PUT(System.String resource, System.Object entity, TimeSpan? timeout = null, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PUT", resource, entity, timeout, throwOnError), typeof(Task<CloudResult>));
		}

		public Task<CloudResult> DELETE(System.String resource, TimeSpan? timeout = null, System.String totpCode = null, Action<HttpRequestMessage> postprocess = null, System.Boolean throwOnError = true)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "DELETE", resource, timeout, totpCode, postprocess, throwOnError), typeof(Task<CloudResult>));
		}

		public HttpRequestMessage CreateRequest(System.String resource, HttpMethod method, System.String totpCode = null, Action<HttpRequestMessage> postprocess = null)
		{
			return (HttpRequestMessage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateRequest", resource, method, totpCode, postprocess), typeof(HttpRequestMessage));
		}

		public HttpRequestMessage CreateRequest(System.Uri resource, System.Boolean authenticate, HttpMethod method, System.String totpCode = null, Action<HttpRequestMessage> postprocess = null)
		{
			return (HttpRequestMessage)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CreateRequest", resource, authenticate, method, totpCode, postprocess), typeof(HttpRequestMessage));
		}

		public void AddFileToRequest(HttpRequestMessage request, System.String filePath, System.String mime = null, IProgressIndicator progressIndicator = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddFileToRequest", request, filePath, mime, progressIndicator);
		}

		public void AddMultipartFileToRequest(HttpRequestMessage request, System.String filePath, System.String mime = null, IProgressIndicator progressIndicator = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddMultipartFileToRequest", request, filePath, mime, progressIndicator);
		}

		public void AddBody(HttpRequestMessage message, System.Object entity)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddBody", message, entity);
		}

		public Task<CloudResult> RunRequest(Func<HttpRequestMessage> requestSource, TimeSpan? timeout, System.Boolean throwOnError)
		{
			return (Task<CloudResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunRequest", requestSource, timeout, throwOnError), typeof(Task<CloudResult>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DEFAULT_CONCURRENT_DOWNLOADS"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DEFAULT_CONCURRENT_DOWNLOADS", value);
			}
		}

		public System.Int32 DEFAULT_MAX_ATTEMPTS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DEFAULT_MAX_ATTEMPTS"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DEFAULT_MAX_ATTEMPTS", value);
			}
		}

		public System.Int32 BufferSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BufferSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BufferSize", value);
			}
		}

		public System.Int32 MaximumAttempts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "MaximumAttempts"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "MaximumAttempts", value);
			}
		}

		public System.String TemporaryPath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "TemporaryPath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "TemporaryPath", value);
			}
		}

		public Stack<byte[]> buffers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "buffers"), typeof(Stack<byte[]>)) is Stack<byte[]> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stack<byte[]>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "buffers", value);
			}
		}

		public System.Int64 _totalBytesPerSecond
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_totalBytesPerSecond"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_totalBytesPerSecond", value);
			}
		}

		public DateTime _lastSpeedUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastSpeedUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastSpeedUpdate", value);
			}
		}

		public System.Int64 _speedAccumulatedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_speedAccumulatedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_speedAccumulatedBytes", value);
			}
		}

		public System.Object _speedLock
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_speedLock"), typeof(System.Object)) is System.Object __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_speedLock", value);
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

		public System.Int64 TotalBytesPerSecond
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "TotalBytesPerSecond"), typeof(System.Int64)) is System.Int64 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to long");
				}
			}
		}

		public AssetGatherer(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetGatherer", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public byte[] BorrowBuffer()
		{
			return (byte[])ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BorrowBuffer"), typeof(byte[]));
		}

		public void ReturnBuffer(byte[] buffer)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReturnBuffer", buffer);
		}

		public void BytesDownloaded(System.Int64 bytes)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "BytesDownloaded", bytes);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
	public class AssetGatherer<G> : AssetGatherer, ResoniteBridge.ResoniteBridgeValueHolder where G : GatherJob, new()
	{
		public Dictionary<object, ActionBlock<object>> processors
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "processors"), typeof(Dictionary<object, ActionBlock<object>>)) is Dictionary<object, ActionBlock<object>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<object, ActionBlock<object>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "processors", value);
			}
		}

		public Dictionary<object, List<G>> waitingJobs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "waitingJobs"), typeof(Dictionary<object, List<G>>)) is Dictionary<object, List<G>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<object, List<G>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "waitingJobs", value);
			}
		}

		public Dictionary<System.Uri, G> jobs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "jobs"), typeof(Dictionary<System.Uri, G>)) is Dictionary<System.Uri, G> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Uri, G>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "jobs", value);
			}
		}

		public List<G> activeJobs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "activeJobs"), typeof(List<G>)) is List<G> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to List<G>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ActiveJobCount"), typeof(System.Int32)) is System.Int32 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to int");
				}
			}
		}

		public AssetGatherer(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetGatherer", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public Task ProcessJob(System.Object category)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ProcessJob", category), typeof(Task));
		}

		public void SetCategoryParallelism(System.Object category, System.Int32 concurrentJobs)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetCategoryParallelism", category, concurrentJobs);
		}

		public ActionBlock<object> SetCategoryParallelismIntern(System.Object category, System.Int32 concurrentJobs)
		{
			return (ActionBlock<object>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SetCategoryParallelismIntern", category, concurrentJobs), typeof(ActionBlock<object>));
		}

		public G Gather(System.Uri url, System.Single priority = 0f, Action<G> initialize = null)
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

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public class QueryResult : ResoniteBridge.ResoniteBridgeValueHolder
		{
			public Query query
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "query"), typeof(Query)) is Query __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Query");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "result"), typeof(Result)) is Result __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to Result");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "result", value);
				}
			}

			public QueryResult(Query query)
			{
				__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "QueryResult", ResoniteBridge.ResoniteBridgeValueType.Type), query);
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

		public System.Object _lock
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

		public Dictionary<Query, TaskCompletionSource<Result>> queue
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "queue"), typeof(Dictionary<Query, TaskCompletionSource<Result>>)) is Dictionary<Query, TaskCompletionSource<Result>> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<Query, TaskCompletionSource<Result>>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "queue", value);
			}
		}

		public TaskCompletionSource<bool> immediateDispatch
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "immediateDispatch"), typeof(TaskCompletionSource<bool>)) is TaskCompletionSource<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TaskCompletionSource<bool>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "immediateDispatch", value);
			}
		}

		public System.Boolean dispatchScheduled
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "dispatchScheduled"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "dispatchScheduled", value);
			}
		}

		public System.Int32 MaxBatchSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "MaxBatchSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "MaxBatchSize", value);
			}
		}

		public System.Single DelaySeconds
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DelaySeconds"), typeof(System.Single)) is System.Single __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DelaySeconds", value);
			}
		}

		public BatchQuery(System.Int32 maxBatchSize = 32, System.Single delaySeconds = 0.25f)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "BatchQuery", ResoniteBridge.ResoniteBridgeValueType.Type), maxBatchSize, delaySeconds);
		}

		public Task<Result> Request(Query query)
		{
			return (Task<Result>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Request", query), typeof(Task<Result>));
		}

		public Task SendBatch()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendBatch"), typeof(Task));
		}

		public abstract Task RunBatch(List<QueryResult> batch);

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public BatchQuery(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public BatchQuery()
		{
		}
	}
	public class CloudResult : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ResoniteBridge.ResoniteBridgeValue State
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpStatusCode");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "State", value);
			}
		}

		public HttpResponseHeaders Headers
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Headers"), typeof(HttpResponseHeaders)) is HttpResponseHeaders __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpResponseHeaders");
				}
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

		public long? ContentLength
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ContentLength"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ContentLength", value);
			}
		}

		public DateTimeOffset? LastModified
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

		public System.Int32 RequestAttempts
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "RequestAttempts"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "RequestAttempts", value);
			}
		}

		public System.Boolean IsOK
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsOK"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public System.Boolean IsError
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsError"), typeof(System.Boolean)) is System.Boolean __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to bool");
				}
			}
		}

		public CloudResult(ResoniteBridge.ResoniteBridgeValue state, HttpResponseHeaders headers, System.Int32 requestAttempts, System.String content, System.String contentType = null, long? contentSize = null, DateTimeOffset? lastModified = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudResult", ResoniteBridge.ResoniteBridgeValueType.Type), state, headers, requestAttempts, content, contentType, contentSize, lastModified);
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public System.String TryGetHeaderValue(System.String name)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "TryGetHeaderValue", name), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudResult", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSensitive"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudResult", ResoniteBridge.ResoniteBridgeValueType.Type), "IsSensitive", value);
			}
		}

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

		static CloudResult()
		{
		}

		public CloudResult(T result, CloudResult sourceEntity)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudResult", ResoniteBridge.ResoniteBridgeValueType.Type), result, sourceEntity);
		}

		public CloudResult(T result, ResoniteBridge.ResoniteBridgeValue state, HttpResponseHeaders headers, System.Int32 requestAttempts, System.String content = null, System.String contentType = null, long? contentLength = null, DateTimeOffset? lastModified = null)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudResult", ResoniteBridge.ResoniteBridgeValueType.Type), result, state, headers, requestAttempts, content, contentType, contentLength, lastModified);
		}

		public CloudResult<E> AsResult<E>() where E : class
		{
			return (CloudResult<E>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AsResult"), typeof(CloudResult<E>));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
	public class GatherJob : ResoniteBridge.ResoniteBridgeValueHolder
	{
		public static System.Object DEFAULT_CATEGORY
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "GatherJob", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CATEGORY"), typeof(System.Object)) is System.Object __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "GatherJob", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_CATEGORY", value);
			}
		}

		public TaskCompletionSource<dummy> _taskSource
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_taskSource"), typeof(TaskCompletionSource<dummy>)) is TaskCompletionSource<dummy> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TaskCompletionSource<dummy>");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_taskSource", value);
			}
		}

		public DateTime _lastSpeedUpdate
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_lastSpeedUpdate"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_lastSpeedUpdate", value);
			}
		}

		public System.Int64 _speedAccumulatedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_speedAccumulatedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_speedAccumulatedBytes", value);
			}
		}

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

		public AssetGatherer Gatherer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Gatherer"), typeof(AssetGatherer)) is AssetGatherer __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AssetGatherer");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CategoryKey"), typeof(System.Object)) is System.Object __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to object");
				}
			}
		}

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
		}

		public GatherJobState State
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(GatherJobState)) is GatherJobState __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to GatherJobState");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StatusCode"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to HttpStatusCode");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Priority"), typeof(System.Single)) is System.Single __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Priority", value);
			}
		}

		public System.String FilePath
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "FilePath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Error"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Exception"), typeof(Exception)) is Exception __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Exception");
				}
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

		public System.Int64 DownloadedBytes
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "DownloadedBytes"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "DownloadedBytes", value);
			}
		}

		public System.Int32 BytesPerSecond
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesPerSecond"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesPerSecond", value);
			}
		}

		public System.Int32 AttemptsLeft
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AttemptsLeft"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AttemptsLeft", value);
			}
		}

		public System.Boolean Active
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Active"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Active", value);
			}
		}

		public System.Boolean Completed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Completed"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Completed", value);
			}
		}

		public DB_Endpoint AppDB_Endpoint
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AppDB_Endpoint"), typeof(DB_Endpoint)) is DB_Endpoint __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to DB_Endpoint");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GatheringStarted"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GatheringStarted", value);
			}
		}

		public DateTime GatheringFinished
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "GatheringFinished"), typeof(DateTime)) is DateTime __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "GatheringFinished", value);
			}
		}

		public Task Task
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Task"), typeof(Task)) is Task __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Task");
				}
			}
		}

		public event Action<float> ProgressUpdated;

		public void Initialize(AssetGatherer gatherer, System.Uri url)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Initialize", gatherer, url);
		}

		public System.Uri ResolveURL(System.Uri url, DB_Endpoint endpoint)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ResolveURL", url, endpoint), typeof(System.Uri));
		}

		public Task Download()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Download"), typeof(Task));
		}

		public void StartGathering()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "StartGathering");
		}

		public void FinishGathering(System.String newFilePath = null)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishGathering", newFilePath);
		}

		public void Fail(System.String reason, System.Boolean nonRecoverable, Exception exception = null, ResoniteBridge.ResoniteBridgeValue statusCode = default(ResoniteBridge.ResoniteBridgeValue))
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Fail", reason, nonRecoverable, exception, statusCode);
		}

		public void AddDownloadedBytes(System.Int64 delta)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "AddDownloadedBytes", delta);
		}

		public void UpdateBytes(System.Int64 total, System.Int64 received)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpdateBytes", total, received);
		}

		public virtual Task RunDownload()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunDownload"), typeof(Task));
		}

		public virtual Task<string> FinishGather()
		{
			return (Task<string>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FinishGather"), typeof(Task<string>));
		}

		public override System.String ToString()
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ToString"), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Intervals"), typeof(TimeSpan[])) is TimeSpan[] __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TimeSpan[]");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Intervals", value);
			}
		}

		public InfiniteRetryPolicy(params int[] secondIntervals)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "InfiniteRetryPolicy", ResoniteBridge.ResoniteBridgeValueType.Type), secondIntervals);
		}

		public InfiniteRetryPolicy(params TimeSpan[] intervals)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "InfiniteRetryPolicy", ResoniteBridge.ResoniteBridgeValueType.Type), intervals);
		}

		public TimeSpan? NextRetryDelay(RetryContext retryContext)
		{
			return (TimeSpan?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "NextRetryDelay", retryContext), typeof(TimeSpan));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public InfiniteRetryPolicy()
		{
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
		public AssetInterface assetInterface
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "assetInterface"), typeof(AssetInterface)) is AssetInterface __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to AssetInterface");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "assetInterface", value);
			}
		}

		public MetadataBatchQuery(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "MetadataBatchQuery", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public override Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public RecordsManager records
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "records"), typeof(RecordsManager)) is RecordsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordsManager");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "records", value);
			}
		}

		public RecordBatchQuery(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordBatchQuery", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public RecordBatchQuery(RecordsManager records)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordBatchQuery", ResoniteBridge.ResoniteBridgeValueType.Type), records);
		}

		public override Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public RecordBatchQuery()
		{
		}
	}
	public class RecordCache<TRecord> : ResoniteBridge.ResoniteBridgeValueHolder where TRecord : class, IRecord, new()
	{
		public Dictionary<RecordId, TRecord> cached
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cached"), typeof(Dictionary<RecordId, TRecord>)) is Dictionary<RecordId, TRecord> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Dictionary<RecordId, TRecord>");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Records"), typeof(RecordsManager)) is RecordsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordsManager");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Records", value);
			}
		}

		public RecordCache(RecordsManager records)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordCache", ResoniteBridge.ResoniteBridgeValueType.Type), records);
		}

		public RecordCache(SkyFrostInterface cloud)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordCache", ResoniteBridge.ResoniteBridgeValueType.Type), cloud);
		}

		public Task<TRecord> Get(System.String ownerId, System.String recordId)
		{
			return (Task<TRecord>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Get", ownerId, recordId), typeof(Task<TRecord>));
		}

		public Task<TRecord> Get(RecordId recordId)
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

		public RecordId GetKey(IRecord record)
		{
			return (RecordId)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetKey", record), typeof(RecordId));
		}

		public void CacheIntern(RecordId key, TRecord record)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CacheIntern", key, record);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public RecordCache()
		{
		}
	}
	public class RecordSearch<R> : ResoniteBridge.ResoniteBridgeValueHolder where R : class, IRecord, new()
	{
		public System.Int32 DEFAULT_BATCH_SIZE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "DEFAULT_BATCH_SIZE"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "DEFAULT_BATCH_SIZE", value);
			}
		}

		public System.Int32 BatchSize
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "BatchSize"), typeof(System.Int32)) is System.Int32 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "BatchSize", value);
			}
		}

		public SearchParameters searchParameters
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "searchParameters"), typeof(SearchParameters)) is SearchParameters __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to SearchParameters");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "searchParameters", value);
			}
		}

		public RecordsManager recordsManager
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "recordsManager"), typeof(RecordsManager)) is RecordsManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to RecordsManager");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "recordsManager", value);
			}
		}

		public System.Boolean cache
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cache"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "cache", value);
			}
		}

		public List<R> Records
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "Records"), typeof(List<R>)) is List<R> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "Records", value);
			}
		}

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

		public System.Boolean EqualsParameters(SearchParameters other)
		{
			return (System.Boolean)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EqualsParameters", other), typeof(System.Boolean));
		}

		public RecordSearch(SearchParameters searchParameters, SkyFrostInterface cloud, System.Boolean cache = true)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordSearch", ResoniteBridge.ResoniteBridgeValueType.Type), searchParameters, cloud, cache);
		}

		public ValueTask GetResultsSlice(System.Int32 offset, System.Int32 count, List<R> results, System.Int32 attempts = 5, System.Boolean throwOnError = true)
		{
			return (ValueTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "GetResultsSlice", offset, count, results, attempts, throwOnError), typeof(ValueTask));
		}

		public ValueTask<bool> EnsureResults(System.Int32 count, System.Int32 attempts = 5, System.Boolean throwOnError = true, System.Int32 delayMilliseconds = 250, TimeSpan? timeout = null)
		{
			return (ValueTask<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureResults", count, attempts, throwOnError, delayMilliseconds, timeout), typeof(ValueTask<bool>));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public System.Uri url
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "url"), typeof(System.Uri)) is System.Uri __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "url", value);
			}
		}

		public Stream stream
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "stream"), typeof(Stream)) is Stream __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Stream");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "stream", value);
			}
		}

		public AssetData(System.Uri url)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetData", ResoniteBridge.ResoniteBridgeValueType.Type), url);
		}

		public AssetData(Stream stream)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetData", ResoniteBridge.ResoniteBridgeValueType.Type), stream);
		}

		public void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public static implicit operator AssetData(Stream stream)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetData", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", stream), typeof(AssetData)) is AssetData __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AssetData");
			}
		}

		public static implicit operator AssetData(System.Uri url)
		{
			if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "AssetData", ResoniteBridge.ResoniteBridgeValueType.Type), "op_Implicit", url), typeof(AssetData)) is AssetData __retCasted)
			{
				return __retCasted;
			}
			else
			{
				throw new InvalidCastException("Cannot cast result to AssetData");
			}
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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

		public AssetData()
		{
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
			public System.Uri appDBURL
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "appDBURL"), typeof(System.Uri)) is System.Uri __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "appDBURL", value);
				}
			}

			public System.Int64 bytes
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "bytes"), typeof(System.Int64)) is System.Int64 __retCasted)
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
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "bytes", value);
				}
			}

			public System.String appDBSig
			{
				get
				{
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "appDBSig"), typeof(System.String)) is System.String __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to string");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "cloudInfo"), typeof(AssetInfo)) is AssetInfo __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to AssetInfo");
					}
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
					if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "localFile"), typeof(System.String)) is System.String __retCasted)
					{
						return __retCasted;
					}
					else
					{
						throw new InvalidCastException("Cannot cast result to string");
					}
				}
				set
				{
					ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "localFile", value);
				}
			}

			public ResoniteBridge.ResoniteBridgeValue __backing;

			public ResoniteBridge.ResoniteBridgeValue __Backing
			{
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

		public static System.Boolean LOG_PROGRESS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordUploadTaskBase", ResoniteBridge.ResoniteBridgeValueType.Type), "LOG_PROGRESS"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordUploadTaskBase", ResoniteBridge.ResoniteBridgeValueType.Type), "LOG_PROGRESS", value);
			}
		}

		public System.String _stageDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_stageDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_stageDescription", value);
			}
		}

		public System.Single preprocessProgress
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "preprocessProgress"), typeof(System.Single)) is System.Single __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "preprocessProgress", value);
			}
		}

		public TaskCompletionSource<bool> _completionSource
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_completionSource"), typeof(TaskCompletionSource<bool>)) is TaskCompletionSource<bool> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to TaskCompletionSource<bool>");
				}
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

		public System.Boolean IsFinished
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "IsFinished"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "IsFinished", value);
			}
		}

		public System.Boolean Failed
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Failed"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "Failed", value);
			}
		}

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

		public System.Boolean WasAlreadySynced
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "WasAlreadySynced"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "WasAlreadySynced", value);
			}
		}

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
		}

		public System.String StageDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "StageDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesToUpload"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesToUpload", value);
			}
		}

		public System.Int64 BytesUploaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "BytesUploaded"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "BytesUploaded", value);
			}
		}

		public System.Int64 AssetsToUpload
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsToUpload"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsToUpload", value);
			}
		}

		public System.Int64 AssetsUploaded
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetsUploaded"), typeof(System.Int64)) is System.Int64 __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetsUploaded", value);
			}
		}

		public Task Task
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Task"), typeof(Task)) is Task __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to Task");
				}
			}
		}

		public R Record
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "Record"), typeof(R)) is R __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to R");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "EnsureFolder"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "EnsureFolder", value);
			}
		}

		public List<AssetDiff> AssetDiffs
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "AssetDiffs"), typeof(List<AssetDiff>)) is List<AssetDiff> __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "AssetDiffs", value);
			}
		}

		public System.Boolean ForceConflictSync
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "ForceConflictSync"), typeof(System.Boolean)) is System.Boolean __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetProperty(__Backing, "ForceConflictSync", value);
			}
		}

		public event Action<AssetDiff> AssetToUploadAdded;

		public event Action<long> BytesUploadedAdded;

		public event Action AssetUploaded;

		public event Action<string> AssetMissing;

		public abstract Task<bool> PrepareFilesForUpload(CancellationToken cancellationToken);

		public abstract Task StoreSyncedRecord(R record);

		public abstract ValueTask<AssetData> ReadFile(System.String signature);

		public virtual ValueTask UploadStarted(System.String signature)
		{
			return (ValueTask)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadStarted", signature), typeof(ValueTask));
		}

		public RecordUploadTaskBase(SkyFrostInterface cloud, R record, System.Boolean ensureFolder = true)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RecordUploadTaskBase", ResoniteBridge.ResoniteBridgeValueType.Type), cloud, record, ensureFolder);
		}

		public void Fail(System.String error)
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Fail", error);
		}

		public void FailConflict()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "FailConflict");
		}

		public void RemoveManifestDuplicates()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RemoveManifestDuplicates");
		}

		public Task EnsureManifestAssetSizes()
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "EnsureManifestAssetSizes"), typeof(Task));
		}

		public Task RunUpload(CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunUpload", cancellationToken), typeof(Task));
		}

		public Task<bool> CheckCloudVersion(CancellationToken cancelationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CheckCloudVersion", cancelationToken), typeof(Task<bool>));
		}

		public abstract Task<bool> PrepareRecord(CancellationToken cancelationToken);

		public Task<bool> PreprocessRecord(CancellationToken cancelationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "PreprocessRecord", cancelationToken), typeof(Task<bool>));
		}

		public Task<bool> UploadAssets(CancellationToken cancelationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UploadAssets", cancelationToken), typeof(Task<bool>));
		}

		public Task<bool> UpsertRecord(CancellationToken cancelationToken)
		{
			return (Task<bool>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "UpsertRecord", cancelationToken), typeof(Task<bool>));
		}

		public Task RunUploadInternal(CancellationToken cancelationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunUploadInternal", cancelationToken), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
			get
			{
				return __backing;
			}
			set
			{
				__backing = value;
			}
		}

		public RecordUploadTaskBase(ResoniteBridge.ResoniteBridgeValue value)
		{
			__backing = value;
		}

		public RecordUploadTaskBase()
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "subpath"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "type"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "defaultValue"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "defaultValue", value);
			}
		}

		public CloudVariableInfo(System.String path, System.String type, System.String defaultValue)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "CloudVariableInfo", ResoniteBridge.ResoniteBridgeValueType.Type), path, type, defaultValue);
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "LAST_MUTE_STATUS"), typeof(CloudVariableInfo)) is CloudVariableInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableInfo");
				}
			}
		}

		public static CloudVariableInfo LAST_ONLINE_STATUS
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "LAST_ONLINE_STATUS"), typeof(CloudVariableInfo)) is CloudVariableInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableInfo");
				}
			}
		}

		public static float3 DEFAULT_DASH_OFFSET
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DEFAULT_DASH_OFFSET"), typeof(float3)) is float3 __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to float3");
				}
			}
		}

		public static CloudVariableInfo DASH_OFFSET
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DASH_OFFSET"), typeof(CloudVariableInfo)) is CloudVariableInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableInfo");
				}
			}
		}

		public static CloudVariableInfo DASH_SCALE
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DASH_SCALE"), typeof(CloudVariableInfo)) is CloudVariableInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableInfo");
				}
			}
		}

		public static CloudVariableInfo DASH_FREEFORM
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "DASH_FREEFORM"), typeof(CloudVariableInfo)) is CloudVariableInfo __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableInfo");
				}
			}
		}

		public static IEnumerable<CloudVariableInfo> AllSettings
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SettingsCloudVariables", ResoniteBridge.ResoniteBridgeValueType.Type), "AllSettings"), typeof(IEnumerable<CloudVariableInfo>)) is IEnumerable<CloudVariableInfo> __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to IEnumerable<CloudVariableInfo>");
				}
			}
		}
	}
	public class SignalRWebSocket : WebSocket, ResoniteBridge.ResoniteBridgeValueHolder
	{
		public ResoniteBridge.ResoniteBridgeValue _client
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "_client"), typeof(ResoniteBridge.ResoniteBridgeValue)) is ResoniteBridge.ResoniteBridgeValue __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to System.Net.WebSockets.Managed.ClientWebSocket");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "_client", value);
			}
		}

		public override WebSocketCloseStatus? CloseStatus
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CloseStatus"), typeof(WebSocketCloseStatus)) is WebSocketCloseStatus __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to WebSocketCloseStatus");
				}
			}
		}

		public override System.String CloseStatusDescription
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "CloseStatusDescription"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override System.String SubProtocol
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "SubProtocol"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
		}

		public override WebSocketState State
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetProperty(__Backing, "State"), typeof(WebSocketState)) is WebSocketState __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to WebSocketState");
				}
			}
		}

		public static Task<SignalRWebSocket> Create(WebSocketConnectionContext context, CancellationToken cancellationToken)
		{
			return (Task<SignalRWebSocket>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SignalRWebSocket", ResoniteBridge.ResoniteBridgeValueType.Type), "Create", context, cancellationToken), typeof(Task<SignalRWebSocket>));
		}

		public SignalRWebSocket()
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "SignalRWebSocket", ResoniteBridge.ResoniteBridgeValueType.Type));
		}

		public Task Connect(System.Uri uri, HttpConnectionOptions options, CancellationToken token)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Connect", uri, options, token), typeof(Task));
		}

		public override void Abort()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Abort");
		}

		public override Task CloseAsync(WebSocketCloseStatus closeStatus, System.String statusDescription, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloseAsync", closeStatus, statusDescription, cancellationToken), typeof(Task));
		}

		public override Task CloseOutputAsync(WebSocketCloseStatus closeStatus, System.String statusDescription, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "CloseOutputAsync", closeStatus, statusDescription, cancellationToken), typeof(Task));
		}

		public override void Dispose()
		{
			ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "Dispose");
		}

		public override Task<WebSocketReceiveResult> ReceiveAsync(ArraySegment<byte> buffer, CancellationToken cancellationToken)
		{
			return (Task<WebSocketReceiveResult>)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "ReceiveAsync", buffer, cancellationToken), typeof(Task<WebSocketReceiveResult>));
		}

		public override Task SendAsync(ArraySegment<byte> buffer, WebSocketMessageType messageType, System.Boolean endOfMessage, CancellationToken cancellationToken)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "SendAsync", buffer, messageType, endOfMessage, cancellationToken), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public CloudVariableManager variables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "variables"), typeof(CloudVariableManager)) is CloudVariableManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableManager");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "variables", value);
			}
		}

		public VariableReadBatchQuery(CloudVariableManager variables)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "VariableReadBatchQuery", ResoniteBridge.ResoniteBridgeValueType.Type), variables);
		}

		public override Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public CloudVariableManager variables
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "variables"), typeof(CloudVariableManager)) is CloudVariableManager __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to CloudVariableManager");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "variables", value);
			}
		}

		public VariableWriteBatchQuery(CloudVariableManager variables)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "VariableWriteBatchQuery", ResoniteBridge.ResoniteBridgeValueType.Type), variables);
		}

		public override Task RunBatch(List<QueryResult> batch)
		{
			return (Task)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(__Backing, "RunBatch", batch), typeof(Task));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ProxyOverride"), typeof(System.String)) is System.String __retCasted)
				{
					return __retCasted;
				}
				else
				{
					throw new InvalidCastException("Cannot cast result to string");
				}
			}
			set
			{
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ProxyOverride", value);
			}
		}

		public System.Uri ProxyServer
		{
			get
			{
				if (ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.GetField(__Backing, "ProxyServer"), typeof(System.Uri)) is System.Uri __retCasted)
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
				ResoniteBridge.ResoniteBridgeClientWrappers.SetField(__Backing, "ProxyServer", value);
			}
		}

		public RegistryProxyConfiguration(System.Uri proxyServer, string? proxyOverride)
		{
			__backing = ResoniteBridge.ResoniteBridgeClientWrappers.CallConstructor(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RegistryProxyConfiguration", ResoniteBridge.ResoniteBridgeValueType.Type), proxyServer, proxyOverride);
		}

		public static RegistryProxyConfiguration From(string? proxyServer = "", string? proxyOverride = "")
		{
			return (RegistryProxyConfiguration)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "RegistryProxyConfiguration", ResoniteBridge.ResoniteBridgeValueType.Type), "From", proxyServer, proxyOverride), typeof(RegistryProxyConfiguration));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
		public static ResoniteBridge.ResoniteBridgeValue SetupCredentials(ProxyConfig config)
		{
			return (ResoniteBridge.ResoniteBridgeValue)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "SetupCredentials", config), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static ResoniteBridge.ResoniteBridgeValue? CreateProxy(ProxyConfig config)
		{
			return (ResoniteBridge.ResoniteBridgeValue?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "CreateProxy", config), typeof(ResoniteBridge.ResoniteBridgeValue));
		}

		public static System.Uri MakeAbsolouteProxyAddress(System.Uri uri)
		{
			return (System.Uri)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "MakeAbsolouteProxyAddress", uri), typeof(System.Uri));
		}

		public static System.String MakeAbsolouteProxyAddress(System.String str)
		{
			return (System.String)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "MakeAbsolouteProxyAddress", str), typeof(System.String));
		}

		public static ProxyConfig HydrateProxyConfiguration(ProxyConfig initialConfig)
		{
			return (ProxyConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "HydrateProxyConfiguration", initialConfig), typeof(ProxyConfig));
		}

		public static ProxyConfig GenerateProxySettingsFromDefaultWebProxy(ProxyConfig initialConfig)
		{
			return (ProxyConfig)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateProxySettingsFromDefaultWebProxy", initialConfig), typeof(ProxyConfig));
		}

		public static RegistryProxyConfiguration? GetProxyConfigFromRegistry()
		{
			return (RegistryProxyConfiguration?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GetProxyConfigFromRegistry"), typeof(RegistryProxyConfiguration));
		}

		public static ProxyConfig? GenerateProxyConfigFromRegistry(RegistryProxyConfiguration? registryValues)
		{
			return (ProxyConfig?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GenerateProxyConfigFromRegistry", registryValues), typeof(ProxyConfig));
		}

		public static string? GetDomainFromProxyOverride(System.String domain)
		{
			return (string?)ResoniteBridge.ResoniteBridgeClientWrappers.CastValue(ResoniteBridge.ResoniteBridgeClientWrappers.CallMethod(new ResoniteBridge.ResoniteBridgeValue(null, "SkyFrost.Base", "WebProxyUtility", ResoniteBridge.ResoniteBridgeValueType.Type), "GetDomainFromProxyOverride", domain), typeof(System.String));
		}

		public ResoniteBridge.ResoniteBridgeValue __backing;

		public ResoniteBridge.ResoniteBridgeValue __Backing
		{
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
