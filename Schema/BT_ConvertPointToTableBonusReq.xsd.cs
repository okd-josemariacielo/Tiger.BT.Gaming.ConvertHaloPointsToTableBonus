namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq",@"PointTableBonusConversion")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "PatronID", XPath = @"/*[local-name()='PointTableBonusConversion' and namespace-uri()='http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq']/*[local-name()='PatronID' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PointTableBonusConversion"})]
    public sealed class BT_ConvertPointToTableBonusReq : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PointTableBonusConversion"">
    <xs:annotation>
      <xs:appinfo>
        <b:recordInfo rootTypeName=""PointTableBonusConversion"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='PointTableBonusConversion' and namespace-uri()='http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq']/*[local-name()='PatronID' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FromSystem"" type=""xs:string"" />
        <xs:element name=""ToSystem"" type=""xs:string"" />
        <xs:element name=""MessageID"" type=""xs:string"" />
        <xs:element name=""PatronID"" type=""xs:string"" />
        <xs:element name=""Points"" type=""xs:string"" />
        <xs:element name=""Amount"" type=""xs:string"" />
        <xs:element name=""RequestingSystem"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BT_ConvertPointToTableBonusReq() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "PointTableBonusConversion";
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
