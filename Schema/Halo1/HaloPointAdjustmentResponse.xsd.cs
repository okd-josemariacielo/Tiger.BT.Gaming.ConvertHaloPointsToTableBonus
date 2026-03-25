namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1 {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://www.gamingstandards.com/s2s/schemas/v1.2.6/",@"s2sMessage")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"s2sMessage"})]
    public sealed class BallyPointAdjustmentResponse : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:s2s=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" elementFormDefault=""qualified"" targetNamespace=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
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
        
        public BallyPointAdjustmentResponse() {
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
