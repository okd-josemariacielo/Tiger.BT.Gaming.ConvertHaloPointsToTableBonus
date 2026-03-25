namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.gamingstandards.com/s2s/schemas/v1.2.6/",@"s2sMessage")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "s2sBody.WAT.errorCode", XPath = @"/*[local-name()='s2sMessage' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']/*[local-name()='s2sBody' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']/*[local-name()='WAT' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']/@*[local-name()='errorCode' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"s2sMessage"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PropertySchema.PropertySchema", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PropertySchema.PropertySchema))]
    public sealed class HaloPointAdjustmentResponse1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:s2s=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:ns0=""https://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PropertySchema"" elementFormDefault=""qualified"" targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PropertySchema"" location=""Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""s2sMessage"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property distinguished=""true"" xpath=""/*[local-name()='s2sMessage' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']/*[local-name()='s2sBody' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']/*[local-name()='WAT' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']/@*[local-name()='errorCode' and namespace-uri()='http://www.gamingstandards.com/s2s/schemas/v1.2.6/']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
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
              <xs:element name=""WAT"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""authorizeTransfer"">
                      <xs:complexType>
                        <xs:attribute form=""qualified"" name=""watAmount"" type=""xs:long"" use=""required"" />
                        <xs:attribute form=""qualified"" name=""transferAction"" type=""xs:string"" use=""required"" />
                        <xs:attribute form=""qualified"" name=""playerId"" type=""xs:string"" use=""required"" />
                        <xs:attribute form=""qualified"" name=""creditType"" type=""xs:string"" use=""required"" />
                        <xs:attribute form=""qualified"" name=""accountId"" type=""xs:string"" use=""required"" />
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                  <xs:attribute form=""qualified"" name=""errorCode"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""errorText"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""transAction"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""transDateTime"" type=""xs:dateTime"" />
                  <xs:attribute form=""qualified"" name=""timeToLive"" type=""xs:int"" />
                  <xs:attribute form=""qualified"" name=""sessionType"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""sessionRetry"" type=""xs:int"" />
                  <xs:attribute form=""qualified"" name=""sessionId"" type=""xs:long"" />
                  <xs:attribute form=""qualified"" name=""retryCount"" type=""xs:int"" />
                  <xs:attribute form=""qualified"" name=""propertyId"" type=""xs:string"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""gameDate"" type=""xs:dateTime"" />
                  <xs:attribute form=""qualified"" name=""dateTime"" type=""xs:dateTime"" use=""required"" />
                  <xs:attribute form=""qualified"" name=""commandId"" type=""xs:long"" />
                  <xs:attribute form=""qualified"" name=""clientType"" type=""xs:string"" />
                  <xs:attribute form=""qualified"" name=""clientId"" type=""xs:string"" />
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public HaloPointAdjustmentResponse1() {
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
