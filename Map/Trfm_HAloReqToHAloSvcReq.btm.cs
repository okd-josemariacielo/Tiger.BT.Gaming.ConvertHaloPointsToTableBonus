namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest", typeof(global::Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest))]
    public sealed class Trfm_HAloReqToHAloSvcReq : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s2 s0 s1"" version=""1.0"" xmlns:s2=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:ns0=""http://www.gamingstandards.com/s2s/wsdl/v1.1/S2SMessageService.wsdl"" xmlns:s0=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:s1=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli2"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:s2sMessage"" />
  </xsl:template>
  <xsl:template match=""/s2:s2sMessage"">
    <ns0:s2sRequest>
      <xsl:call-template name=""xml-to-string-called-template"">
        <xsl:with-param name=""param1"" select=""string(./text())"" />
      </xsl:call-template>
    </ns0:s2sRequest>
  </xsl:template>
  <xsl:template name=""xml-to-string-called-template"">
    <xsl:param name=""param1"" />
           <xsl:element name=""ns0:request"">
                 <xsl:text disable-output-escaping=""yes"">&lt;![CDATA[</xsl:text>
                 <xsl:call-template name=""identity"" />
                 <xsl:text disable-output-escaping=""yes"">]]&gt;</xsl:text>
            </xsl:element>
 </xsl:template>
  <xsl:template name=""identity"" match=""@*|node()"">
    <xsl:copy>
 <xsl:apply-templates select=""@*|node()"" />
    </xsl:copy>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest";
        
        private const global::Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl.s2sRequest _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyRequestPlayerBalance";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Tiger.BT.Gaming.HAloS2S.S2SMessagePostPortType_www_gamingstandards_com_s2s_wsdl_v1_1_S2SMessageService_wsdl+s2sRequest";
                return _TrgSchemas;
            }
        }
    }
}
