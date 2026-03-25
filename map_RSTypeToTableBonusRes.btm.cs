namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes))]
    public sealed class map_RSTypeToTableBonusRes : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s3 s1"" version=""1.0"" xmlns:s0=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:ns0=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes"" xmlns:s3=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:s1=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"" />
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse";
                _SrcSchemas[1] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes";
                return _TrgSchemas;
            }
        }
    }
}
