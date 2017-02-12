// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Protos.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Proto {

  /// <summary>Holder for reflection information generated from Protos.proto</summary>
  public static partial class ProtosReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProtosReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQcm90b3MucHJvdG8SBWFjdG9yIiIKA1BJRBIPCgdBZGRyZXNzGAEgASgJ",
            "EgoKAklkGAIgASgJIgwKClBvaXNvblBpbGwiJAoFV2F0Y2gSGwoHd2F0Y2hl",
            "chgBIAEoCzIKLmFjdG9yLlBJRCImCgdVbndhdGNoEhsKB3dhdGNoZXIYASAB",
            "KAsyCi5hY3Rvci5QSUQiQAoKVGVybWluYXRlZBIXCgN3aG8YASABKAsyCi5h",
            "Y3Rvci5QSUQSGQoRQWRkcmVzc1Rlcm1pbmF0ZWQYAiABKAgiBgoEU3RvcEII",
            "qgIFUHJvdG9iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.PID), global::Proto.PID.Parser, new[]{ "Address", "Id" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.PoisonPill), global::Proto.PoisonPill.Parser, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Watch), global::Proto.Watch.Parser, new[]{ "Watcher" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Unwatch), global::Proto.Unwatch.Parser, new[]{ "Watcher" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Terminated), global::Proto.Terminated.Parser, new[]{ "Who", "AddressTerminated" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Proto.Stop), global::Proto.Stop.Parser, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PID : pb::IMessage<PID> {
    private static readonly pb::MessageParser<PID> _parser = new pb::MessageParser<PID>(() => new PID());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PID> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtosReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PID() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PID(PID other) : this() {
      address_ = other.address_;
      id_ = other.id_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PID Clone() {
      return new PID(this);
    }

    /// <summary>Field number for the "Address" field.</summary>
    public const int AddressFieldNumber = 1;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 2;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PID);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PID other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Address != other.Address) return false;
      if (Id != other.Id) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Address.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Address);
      }
      if (Id.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Id);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PID other) {
      if (other == null) {
        return;
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            Address = input.ReadString();
            break;
          }
          case 18: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// user messages
  /// </summary>
  public sealed partial class PoisonPill : pb::IMessage<PoisonPill> {
    private static readonly pb::MessageParser<PoisonPill> _parser = new pb::MessageParser<PoisonPill>(() => new PoisonPill());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PoisonPill> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtosReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoisonPill() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoisonPill(PoisonPill other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PoisonPill Clone() {
      return new PoisonPill(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PoisonPill);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PoisonPill other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PoisonPill other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  /// <summary>
  /// system messages
  /// </summary>
  public sealed partial class Watch : pb::IMessage<Watch> {
    private static readonly pb::MessageParser<Watch> _parser = new pb::MessageParser<Watch>(() => new Watch());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Watch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtosReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Watch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Watch(Watch other) : this() {
      Watcher = other.watcher_ != null ? other.Watcher.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Watch Clone() {
      return new Watch(this);
    }

    /// <summary>Field number for the "watcher" field.</summary>
    public const int WatcherFieldNumber = 1;
    private global::Proto.PID watcher_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID Watcher {
      get { return watcher_; }
      set {
        watcher_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Watch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Watch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Watcher, other.Watcher)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (watcher_ != null) hash ^= Watcher.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (watcher_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Watcher);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (watcher_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Watcher);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Watch other) {
      if (other == null) {
        return;
      }
      if (other.watcher_ != null) {
        if (watcher_ == null) {
          watcher_ = new global::Proto.PID();
        }
        Watcher.MergeFrom(other.Watcher);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (watcher_ == null) {
              watcher_ = new global::Proto.PID();
            }
            input.ReadMessage(watcher_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Unwatch : pb::IMessage<Unwatch> {
    private static readonly pb::MessageParser<Unwatch> _parser = new pb::MessageParser<Unwatch>(() => new Unwatch());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Unwatch> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtosReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unwatch() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unwatch(Unwatch other) : this() {
      Watcher = other.watcher_ != null ? other.Watcher.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Unwatch Clone() {
      return new Unwatch(this);
    }

    /// <summary>Field number for the "watcher" field.</summary>
    public const int WatcherFieldNumber = 1;
    private global::Proto.PID watcher_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID Watcher {
      get { return watcher_; }
      set {
        watcher_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Unwatch);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Unwatch other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Watcher, other.Watcher)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (watcher_ != null) hash ^= Watcher.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (watcher_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Watcher);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (watcher_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Watcher);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Unwatch other) {
      if (other == null) {
        return;
      }
      if (other.watcher_ != null) {
        if (watcher_ == null) {
          watcher_ = new global::Proto.PID();
        }
        Watcher.MergeFrom(other.Watcher);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (watcher_ == null) {
              watcher_ = new global::Proto.PID();
            }
            input.ReadMessage(watcher_);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Terminated : pb::IMessage<Terminated> {
    private static readonly pb::MessageParser<Terminated> _parser = new pb::MessageParser<Terminated>(() => new Terminated());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Terminated> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtosReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Terminated() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Terminated(Terminated other) : this() {
      Who = other.who_ != null ? other.Who.Clone() : null;
      addressTerminated_ = other.addressTerminated_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Terminated Clone() {
      return new Terminated(this);
    }

    /// <summary>Field number for the "who" field.</summary>
    public const int WhoFieldNumber = 1;
    private global::Proto.PID who_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Proto.PID Who {
      get { return who_; }
      set {
        who_ = value;
      }
    }

    /// <summary>Field number for the "AddressTerminated" field.</summary>
    public const int AddressTerminatedFieldNumber = 2;
    private bool addressTerminated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool AddressTerminated {
      get { return addressTerminated_; }
      set {
        addressTerminated_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Terminated);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Terminated other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Who, other.Who)) return false;
      if (AddressTerminated != other.AddressTerminated) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (who_ != null) hash ^= Who.GetHashCode();
      if (AddressTerminated != false) hash ^= AddressTerminated.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (who_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Who);
      }
      if (AddressTerminated != false) {
        output.WriteRawTag(16);
        output.WriteBool(AddressTerminated);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (who_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Who);
      }
      if (AddressTerminated != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Terminated other) {
      if (other == null) {
        return;
      }
      if (other.who_ != null) {
        if (who_ == null) {
          who_ = new global::Proto.PID();
        }
        Who.MergeFrom(other.Who);
      }
      if (other.AddressTerminated != false) {
        AddressTerminated = other.AddressTerminated;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (who_ == null) {
              who_ = new global::Proto.PID();
            }
            input.ReadMessage(who_);
            break;
          }
          case 16: {
            AddressTerminated = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Stop : pb::IMessage<Stop> {
    private static readonly pb::MessageParser<Stop> _parser = new pb::MessageParser<Stop>(() => new Stop());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Stop> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Proto.ProtosReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stop() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stop(Stop other) : this() {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Stop Clone() {
      return new Stop(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Stop);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Stop other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Stop other) {
      if (other == null) {
        return;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
