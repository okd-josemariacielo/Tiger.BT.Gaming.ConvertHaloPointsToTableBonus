namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.gamingstandards.com/s2s/schemas/v1.2.6/",@"s2sMessage")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"s2sMessage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance_app1", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance_app1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance_app2", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance_app2))]
    public sealed class BallyRequestPlayerBalance : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:pli2=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli2"" xmlns:s2s=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:pli=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance_app1"" namespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" />
  <xs:import schemaLocation=""Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance_app2"" namespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli2"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli2"" />
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" />
        <reference targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:attribute name=""transDateTime"" type=""xs:dateTime"" />
  <xs:attribute name=""timeToLive"" type=""xs:int"" />
  <xs:attribute name=""sessionType"" type=""xs:string"" />
  <xs:attribute name=""sessionRetry"" type=""xs:int"" />
  <xs:attribute name=""sessionId"" type=""xs:long"" />
  <xs:attribute name=""retryCount"" type=""xs:int"" />
  <xs:attribute name=""propertyId"" type=""xs:string"" />
  <xs:attribute name=""gameDate"" type=""xs:dateTime"" />
  <xs:attribute name=""dateTime"" type=""xs:dateTime"" />
  <xs:attribute name=""commandId"" type=""xs:long"" />
  <xs:attribute name=""clientType"" type=""xs:string"" />
  <xs:attribute name=""clientId"" type=""xs:string"" />
  <xs:element name=""s2sMessage"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""s2sHeader"">
          <xs:complexType>
            <xs:attribute form=""qualified"" name=""toSystem"" type=""xs:anyURI"" use=""required"" />
            <xs:attribute form=""qualified"" name=""referenceMessageId"" type=""xs:long"" use=""optional"" />
            <xs:attribute form=""qualified"" name=""messageId"" type=""xs:long"" use=""required"" />
            <xs:attribute form=""qualified"" name=""fromSystem"" type=""xs:anyURI"" use=""required"" />
            <xs:attribute form=""qualified"" name=""dateTimeSent"" type=""xs:dateTime"" use=""required"" />
          </xs:complexType>
        </xs:element>
        <xs:element name=""s2sBody"">
          <xs:complexType>
            <xs:sequence>
              <xs:element ref=""pli:playerInfo"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BallyRequestPlayerBalance() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "s2sMessage";
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
