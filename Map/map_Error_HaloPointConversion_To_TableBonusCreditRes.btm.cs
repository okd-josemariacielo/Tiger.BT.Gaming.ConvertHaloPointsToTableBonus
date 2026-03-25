namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Map {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes))]
    public sealed class map_HaloPointConversion_To_TableBonusCreditRes_Copy : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s1 userCSharp"" version=""1.0"" xmlns:s0=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:ns0=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes"" xmlns:s1=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;FAILED&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:PointTableBonusConversion>
      <FromSystem>
        <xsl:value-of select=""InputMessagePart_0/s1:PointTableBonusConversion/FromSystem/text()"" />
      </FromSystem>
      <ToSystem>
        <xsl:value-of select=""InputMessagePart_0/s1:PointTableBonusConversion/ToSystem/text()"" />
      </ToSystem>
      <MessageID>
        <xsl:value-of select=""InputMessagePart_0/s1:PointTableBonusConversion/MessageID/text()"" />
      </MessageID>
      <PatronID>
        <xsl:value-of select=""InputMessagePart_0/s1:PointTableBonusConversion/PatronID/text()"" />
      </PatronID>
      <ConversionStatus>
        <xsl:value-of select=""$var:v1"" />
      </ConversionStatus>
      <Date>
        <xsl:value-of select=""$var:v2"" />
      </Date>
      <xsl:if test=""InputMessagePart_1/s0:s2sMessage/s0:s2sBody/s0:WAT/@s0:errorCode"">
        <ErrorCode>
          <xsl:value-of select=""InputMessagePart_1/s0:s2sMessage/s0:s2sBody/s0:WAT/@s0:errorCode"" />
        </ErrorCode>
      </xsl:if>
      <xsl:if test=""InputMessagePart_1/s0:s2sMessage/s0:s2sBody/s0:WAT/@s0:errorText"">
        <ErrorDescription>
          <xsl:value-of select=""InputMessagePart_1/s0:s2sMessage/s0:s2sBody/s0:WAT/@s0:errorText"" />
        </ErrorDescription>
      </xsl:if>
    </ns0:PointTableBonusConversion>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1";
        
        private const global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1 _srcSchemaTypeReference1 = null;
        
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
                _SrcSchemas[0] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq";
                _SrcSchemas[1] = @"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.Halo1.HaloPointAdjustmentResponse1";
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
