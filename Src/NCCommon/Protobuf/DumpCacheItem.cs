//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DumpCacheItem.proto
// Note: requires additional types generated from: Commands/TagInfo.proto
// Note: requires additional types generated from: Commands/Dependency.proto
// Note: requires additional types generated from: Commands/NamedTagInfo.proto
// Note: requires additional types generated from: ModuleInfo.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DumpCacheItem")]
  public partial class DumpCacheItem : global::ProtoBuf.IExtensible
  {
    public DumpCacheItem() {}
    

    private long _lockTicks = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"lockTicks", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long lockTicks
    {
      get { return _lockTicks; }
      set { _lockTicks = value; }
    }

    private int _priority = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int priority
    {
      get { return _priority; }
      set { _priority = value; }
    }

    private bool _hasExpired = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"hasExpired", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool hasExpired
    {
      get { return _hasExpired; }
      set { _hasExpired = value; }
    }

    private bool _needsResync = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"needsResync", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool needsResync
    {
      get { return _needsResync; }
      set { _needsResync = value; }
    }

    private long _absExp = default(long);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"absExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long absExp
    {
      get { return _absExp; }
      set { _absExp = value; }
    }

    private long _sldExp = default(long);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"sldExp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long sldExp
    {
      get { return _sldExp; }
      set { _sldExp = value; }
    }

    private int _flag = default(int);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"flag", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int flag
    {
      get { return _flag; }
      set { _flag = value; }
    }

    private ulong _version = default(ulong);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong version
    {
      get { return _version; }
      set { _version = value; }
    }

    private long _creationTime = default(long);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"creationTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long creationTime
    {
      get { return _creationTime; }
      set { _creationTime = value; }
    }

    private string _group = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"group", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string group
    {
      get { return _group; }
      set { _group = value; }
    }

    private string _subGroup = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"subGroup", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string subGroup
    {
      get { return _subGroup; }
      set { _subGroup = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.TagInfo _tagInfo = null;
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"tagInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.TagInfo tagInfo
    {
      get { return _tagInfo; }
      set { _tagInfo = value; }
    }
    private string _key = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private long _remainingabs = default(long);
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"remainingabs", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long remainingabs
    {
      get { return _remainingabs; }
      set { _remainingabs = value; }
    }

    private string _provider = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"provider", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string provider
    {
      get { return _provider; }
      set { _provider = value; }
    }

    private byte[] _onevalue = null;
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"onevalue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] onevalue
    {
      get { return _onevalue; }
      set { _onevalue = value; }
    }

    private bool _isModuleData = default(bool);
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"isModuleData", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isModuleData
    {
      get { return _isModuleData; }
      set { _isModuleData = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.ModuleInfo _moduleInfo = null;
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"moduleInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.ModuleInfo moduleInfo
    {
      get { return _moduleInfo; }
      set { _moduleInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}