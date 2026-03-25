namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes",@"PointTableBonusConversion")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"PointTableBonusConversion"})]
    public sealed class BT_ConvertPointToTableBonusRes : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""PointTableBonusConversion"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""FromSystem"" type=""xs:string"" />
        <xs:element name=""ToSystem"" type=""xs:string"" />
        <xs:element name=""MessageID"" type=""xs:string"" />
        <xs:element name=""PatronID"" type=""xs:string"" />
        <xs:element name=""ConversionStatus"" type=""xs:string"" />
        <xs:element name=""Date"" type=""xs:string"" />
        <xs:element maxOccurs=""unbounded"" name=""PlayerBalance"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""AccountID"">
                <xs:simpleType>
                  <xs:restriction base=""xs:string"" />
                </xs:simpleType>
              </xs:element>
              <xs:element name=""IsFrozen"">
                <xs:simpleType>
                  <xs:restriction base=""xs:boolean"" />
                </xs:simpleType>
              </xs:element>
              <xs:element name=""BalancePoints"">
                <xs:simpleType>
                  <xs:restriction base=""xs:decimal"" />
                </xs:simpleType>
              </xs:element>
              <xs:element name=""AvailablePoints"">
                <xs:simpleType>
                  <xs:restriction base=""xs:decimal"" />
                </xs:simpleType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""ErrorCode"" type=""xs:string"" />
        <xs:element name=""ErrorDescription"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public BT_ConvertPointToTableBonusRes() {
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
