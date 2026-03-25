namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest))]
    public sealed class map_HaloPointsRequest_To_PointBucketDeductRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 ScriptNS0 userCSharp"" version=""1.0"" xmlns:s0=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq"" xmlns:ns0=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:ScriptNS0=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:PointTableBonusConversion"" />
  </xsl:template>
  <xsl:template match=""/s0:PointTableBonusConversion"">
    <xsl:variable name=""var:v3"" select=""userCSharp:DateCurrentDateTime()"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:StringConcat(&quot;3000&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:StringConcat(&quot;request&quot;)"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:StringConcat(&quot;2&quot;)"" />
    <xsl:variable name=""var:v7"" select=""userCSharp:StringConcat(&quot;0&quot;)"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringConcat(&quot;1933&quot;)"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:StringConcat(&quot;S2S_system&quot;)"" />
    <xsl:variable name=""var:v11"" select=""userCSharp:StringConcat(&quot;S2S_client&quot;)"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:StringConcat(&quot;withdraw&quot;)"" />
    <ns0:s2sMessage>
      <ns0:s2sHeader>
        <xsl:variable name=""var:v1"" select=""ScriptNS0:GetConfitg(&quot;ToSystem&quot;)"" />
        <xsl:attribute name=""ns0:toSystem"">
          <xsl:value-of select=""$var:v1"" />
        </xsl:attribute>
        <xsl:attribute name=""ns0:referenceMessageId"">
          <xsl:value-of select=""MessageID/text()"" />
        </xsl:attribute>
        <xsl:attribute name=""ns0:messageId"">
          <xsl:value-of select=""MessageID/text()"" />
        </xsl:attribute>
        <xsl:variable name=""var:v2"" select=""ScriptNS0:GetConfitg(&quot;FromSystem&quot;)"" />
        <xsl:attribute name=""ns0:fromSystem"">
          <xsl:value-of select=""$var:v2"" />
        </xsl:attribute>
        <xsl:attribute name=""ns0:dateTimeSent"">
          <xsl:value-of select=""$var:v3"" />
        </xsl:attribute>
      </ns0:s2sHeader>
      <ns0:s2sBody>
        <ns0:WAT>
          <xsl:attribute name=""ns0:transDateTime"">
            <xsl:value-of select=""$var:v3"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:timeToLive"">
            <xsl:value-of select=""$var:v4"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:sessionType"">
            <xsl:value-of select=""$var:v5"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:sessionRetry"">
            <xsl:value-of select=""$var:v6"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:retryCount"">
            <xsl:value-of select=""$var:v7"" />
          </xsl:attribute>
          <xsl:variable name=""var:v8"" select=""ScriptNS0:GetConfitg(&quot;PropertyID&quot;)"" />
          <xsl:attribute name=""ns0:propertyId"">
            <xsl:value-of select=""$var:v8"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:gameDate"">
            <xsl:value-of select=""$var:v3"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:dateTime"">
            <xsl:value-of select=""$var:v3"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:commandId"">
            <xsl:value-of select=""$var:v9"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:clientType"">
            <xsl:value-of select=""$var:v10"" />
          </xsl:attribute>
          <xsl:attribute name=""ns0:clientId"">
            <xsl:value-of select=""$var:v11"" />
          </xsl:attribute>
          <ns0:requestTransfer>
            <xsl:attribute name=""ns0:watAmount"">
              <xsl:value-of select=""Amount/text()"" />
            </xsl:attribute>
            <xsl:attribute name=""ns0:transferAction"">
              <xsl:value-of select=""$var:v12"" />
            </xsl:attribute>
            <xsl:attribute name=""ns0:playerId"">
              <xsl:value-of select=""PatronID/text()"" />
            </xsl:attribute>
          </ns0:requestTransfer>
        </ns0:WAT>
      </ns0:s2sBody>
    </ns0:s2sMessage>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}


public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects>
  <ExtensionObject Namespace=""http://schemas.microsoft.com/BizTalk/2003/ScriptNS0"" AssemblyName=""Tiger.BT.Gaming.Configuration.Functoid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=f9f64cc1380cd5df"" ClassName=""Tiger.BT.Gaming.Configuration.Functoid.ConfigurationFunctoid"" />
</ExtensionObjects>";
        
        private const string _strSrcSchemasList0 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo.BallyPointAdjustmentRequest";
                return _TrgSchemas;
            }
        }
    }
}
