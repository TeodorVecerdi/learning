// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: addressbook.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protocol.Protobuf {

  /// <summary>Holder for reflection information generated from addressbook.proto</summary>
  public static partial class AddressbookReflection {

    #region Descriptor
    /// <summary>File descriptor for addressbook.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddressbookReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFhZGRyZXNzYm9vay5wcm90bxIIdHV0b3JpYWwaH2dvb2dsZS9wcm90b2J1",
            "Zi90aW1lc3RhbXAucHJvdG8ijgIKBlBlcnNvbhIMCgRuYW1lGAEgASgJEgoK",
            "AmlkGAIgASgFEjIKDHBob25lTnVtYmVycxgEIAMoCzIcLnR1dG9yaWFsLlBl",
            "cnNvbi5QaG9uZU51bWJlchIvCgtsYXN0VXBkYXRlZBgFIAEoCzIaLmdvb2ds",
            "ZS5wcm90b2J1Zi5UaW1lc3RhbXASDwoHYWRkcmVzcxgGIAEoCRpHCgtQaG9u",
            "ZU51bWJlchIOCgZudW1iZXIYASABKAkSKAoEdHlwZRgCIAEoDjIaLnR1dG9y",
            "aWFsLlBlcnNvbi5QaG9uZVR5cGUiKwoJUGhvbmVUeXBlEgoKBk1PQklMRRAA",
            "EggKBEhPTUUQARIICgRXT1JLEAIiLwoLQWRkcmVzc0Jvb2sSIAoGcGVvcGxl",
            "GAEgAygLMhAudHV0b3JpYWwuUGVyc29uQhSqAhFQcm90b2NvbC5Qcm90b2J1",
            "ZmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.Protobuf.Person), global::Protocol.Protobuf.Person.Parser, new[]{ "Name", "Id", "PhoneNumbers", "LastUpdated", "Address" }, null, new[]{ typeof(global::Protocol.Protobuf.Person.Types.PhoneType) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.Protobuf.Person.Types.PhoneNumber), global::Protocol.Protobuf.Person.Types.PhoneNumber.Parser, new[]{ "Number", "Type" }, null, null, null, null)}),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.Protobuf.AddressBook), global::Protocol.Protobuf.AddressBook.Parser, new[]{ "People" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Person : pb::IMessage<Person>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Person> _parser = new pb::MessageParser<Person>(() => new Person());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Person> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.Protobuf.AddressbookReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person(Person other) : this() {
      name_ = other.name_;
      id_ = other.id_;
      phoneNumbers_ = other.phoneNumbers_.Clone();
      lastUpdated_ = other.lastUpdated_ != null ? other.lastUpdated_.Clone() : null;
      address_ = other.address_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Person Clone() {
      return new Person(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private int id_;
    /// <summary>
    ///  string email = 3;
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "phoneNumbers" field.</summary>
    public const int PhoneNumbersFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Protocol.Protobuf.Person.Types.PhoneNumber> _repeated_phoneNumbers_codec
        = pb::FieldCodec.ForMessage(34, global::Protocol.Protobuf.Person.Types.PhoneNumber.Parser);
    private readonly pbc::RepeatedField<global::Protocol.Protobuf.Person.Types.PhoneNumber> phoneNumbers_ = new pbc::RepeatedField<global::Protocol.Protobuf.Person.Types.PhoneNumber>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Protocol.Protobuf.Person.Types.PhoneNumber> PhoneNumbers {
      get { return phoneNumbers_; }
    }

    /// <summary>Field number for the "lastUpdated" field.</summary>
    public const int LastUpdatedFieldNumber = 5;
    private global::Google.Protobuf.WellKnownTypes.Timestamp lastUpdated_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp LastUpdated {
      get { return lastUpdated_; }
      set {
        lastUpdated_ = value;
      }
    }

    /// <summary>Field number for the "address" field.</summary>
    public const int AddressFieldNumber = 6;
    private string address_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Address {
      get { return address_; }
      set {
        address_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Person);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Person other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Id != other.Id) return false;
      if(!phoneNumbers_.Equals(other.phoneNumbers_)) return false;
      if (!object.Equals(LastUpdated, other.LastUpdated)) return false;
      if (Address != other.Address) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Id != 0) hash ^= Id.GetHashCode();
      hash ^= phoneNumbers_.GetHashCode();
      if (lastUpdated_ != null) hash ^= LastUpdated.GetHashCode();
      if (Address.Length != 0) hash ^= Address.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
      phoneNumbers_.WriteTo(output, _repeated_phoneNumbers_codec);
      if (lastUpdated_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LastUpdated);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Id != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Id);
      }
      phoneNumbers_.WriteTo(ref output, _repeated_phoneNumbers_codec);
      if (lastUpdated_ != null) {
        output.WriteRawTag(42);
        output.WriteMessage(LastUpdated);
      }
      if (Address.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
      }
      size += phoneNumbers_.CalculateSize(_repeated_phoneNumbers_codec);
      if (lastUpdated_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastUpdated);
      }
      if (Address.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Address);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Person other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      phoneNumbers_.Add(other.phoneNumbers_);
      if (other.lastUpdated_ != null) {
        if (lastUpdated_ == null) {
          LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        LastUpdated.MergeFrom(other.LastUpdated);
      }
      if (other.Address.Length != 0) {
        Address = other.Address;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 34: {
            phoneNumbers_.AddEntriesFrom(input, _repeated_phoneNumbers_codec);
            break;
          }
          case 42: {
            if (lastUpdated_ == null) {
              LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastUpdated);
            break;
          }
          case 50: {
            Address = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Id = input.ReadInt32();
            break;
          }
          case 34: {
            phoneNumbers_.AddEntriesFrom(ref input, _repeated_phoneNumbers_codec);
            break;
          }
          case 42: {
            if (lastUpdated_ == null) {
              LastUpdated = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(LastUpdated);
            break;
          }
          case 50: {
            Address = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Person message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      public enum PhoneType {
        [pbr::OriginalName("MOBILE")] Mobile = 0,
        [pbr::OriginalName("HOME")] Home = 1,
        [pbr::OriginalName("WORK")] Work = 2,
      }

      public sealed partial class PhoneNumber : pb::IMessage<PhoneNumber>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PhoneNumber> _parser = new pb::MessageParser<PhoneNumber>(() => new PhoneNumber());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<PhoneNumber> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Protocol.Protobuf.Person.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber(PhoneNumber other) : this() {
          number_ = other.number_;
          type_ = other.type_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public PhoneNumber Clone() {
          return new PhoneNumber(this);
        }

        /// <summary>Field number for the "number" field.</summary>
        public const int NumberFieldNumber = 1;
        private string number_ = "";
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Number {
          get { return number_; }
          set {
            number_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "type" field.</summary>
        public const int TypeFieldNumber = 2;
        private global::Protocol.Protobuf.Person.Types.PhoneType type_ = global::Protocol.Protobuf.Person.Types.PhoneType.Mobile;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Protocol.Protobuf.Person.Types.PhoneType Type {
          get { return type_; }
          set {
            type_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as PhoneNumber);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(PhoneNumber other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Number != other.Number) return false;
          if (Type != other.Type) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Number.Length != 0) hash ^= Number.GetHashCode();
          if (Type != global::Protocol.Protobuf.Person.Types.PhoneType.Mobile) hash ^= Type.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (Number.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Number);
          }
          if (Type != global::Protocol.Protobuf.Person.Types.PhoneType.Mobile) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (Number.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Number);
          }
          if (Type != global::Protocol.Protobuf.Person.Types.PhoneType.Mobile) {
            output.WriteRawTag(16);
            output.WriteEnum((int) Type);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Number.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Number);
          }
          if (Type != global::Protocol.Protobuf.Person.Types.PhoneType.Mobile) {
            size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(PhoneNumber other) {
          if (other == null) {
            return;
          }
          if (other.Number.Length != 0) {
            Number = other.Number;
          }
          if (other.Type != global::Protocol.Protobuf.Person.Types.PhoneType.Mobile) {
            Type = other.Type;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Number = input.ReadString();
                break;
              }
              case 16: {
                Type = (global::Protocol.Protobuf.Person.Types.PhoneType) input.ReadEnum();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 10: {
                Number = input.ReadString();
                break;
              }
              case 16: {
                Type = (global::Protocol.Protobuf.Person.Types.PhoneType) input.ReadEnum();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  public sealed partial class AddressBook : pb::IMessage<AddressBook>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddressBook> _parser = new pb::MessageParser<AddressBook>(() => new AddressBook());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddressBook> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.Protobuf.AddressbookReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook(AddressBook other) : this() {
      people_ = other.people_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddressBook Clone() {
      return new AddressBook(this);
    }

    /// <summary>Field number for the "people" field.</summary>
    public const int PeopleFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Protocol.Protobuf.Person> _repeated_people_codec
        = pb::FieldCodec.ForMessage(10, global::Protocol.Protobuf.Person.Parser);
    private readonly pbc::RepeatedField<global::Protocol.Protobuf.Person> people_ = new pbc::RepeatedField<global::Protocol.Protobuf.Person>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Protocol.Protobuf.Person> People {
      get { return people_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddressBook);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddressBook other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!people_.Equals(other.people_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= people_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      people_.WriteTo(output, _repeated_people_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      people_.WriteTo(ref output, _repeated_people_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += people_.CalculateSize(_repeated_people_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddressBook other) {
      if (other == null) {
        return;
      }
      people_.Add(other.people_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            people_.AddEntriesFrom(input, _repeated_people_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            people_.AddEntriesFrom(ref input, _repeated_people_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
