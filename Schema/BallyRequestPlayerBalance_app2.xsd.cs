namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance))]
    public sealed class BallyRequestPlayerBalance_app2 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:pli2=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli2"" xmlns:s2s=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:pli=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli2"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance"" namespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli2"" />
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" />
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:attribute name=""meterDenom"" type=""xs:long"" />
  <xs:attribute name=""gameId"" type=""xs:string"" />
  <xs:attribute name=""machineId"" type=""xs:long"" />
</xs:schema>";
        
        public BallyRequestPlayerBalance_app2() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [0];
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
