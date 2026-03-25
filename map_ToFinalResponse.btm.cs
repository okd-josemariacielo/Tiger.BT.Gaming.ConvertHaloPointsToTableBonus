namespace Tiger.BT.Gaming.ConvertHaloPointsToTableBonus {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BallyGetPropertyBalancesResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes", typeof(global::Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes))]
    public sealed class map_ToFinalResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s2 s3 s1 userCSharp"" version=""1.0"" xmlns:s0=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/"" xmlns:ns0=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusRes"" xmlns:s3=""http://www.gamingstandards.com/s2s/schemas/v1.2.6/pli"" xmlns:s1=""http://Tiger.BT.Gaming.ConvertHaloPointsToTableBonus.Schema.BT_ConvertPointToTableBonusReq"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SUCCESS&quot;)"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:PointTableBonusConversion>
      <FromSystem>
        <xsl:value-of select=""InputMessagePart_1/s1:PointTableBonusConversion/FromSystem/text()"" />
      </FromSystem>
      <ToSystem>
        <xsl:value-of select=""InputMessagePart_1/s1:PointTableBonusConversion/ToSystem/text()"" />
      </ToSystem>
      <MessageID>
        <xsl:value-of select=""InputMessagePart_1/s1:PointTableBonusConversion/MessageID/text()"" />
      </MessageID>
      <PatronID>
        <xsl:value-of select=""InputMessagePart_0/s0:s2sMessage/s0:s2sBody/s3:playerInfo/s3:playerBalanceList/@s3:playerId"" />
      </PatronID>
      <ConversionStatus>
        <xsl:value-of select=""$var:v1"" />
      </ConversionStatus>
      <Date>
        <xsl:value-of select=""$var:v2"" />
      </Date>
      <xsl:for-each select=""InputMessagePart_0/s0:s2sMessage/s0:s2sBody/s3:playerInfo/s3:playerBalanceList/s3:playerBalance"">
        <xsl:variable name=""var:v3"" select=""userCSharp:StringUpperCase(string(../../../../../../InputMessagePart_1/s1:PointTableBonusConversion/Points/text()))"" />
        <xsl:variable name=""var:v4"" select=""userCSharp:StringUpperCase(string(@s3:accountId))"" />
        <xsl:variable name=""var:v5"" select=""userCSharp:LogicalEq(string($var:v3) , string($var:v4))"" />
        <xsl:if test=""$var:v5"">
          <xsl:variable name=""var:v6"" select=""userCSharp:MathDivide(string(@s3:accountBalance) , &quot;100000&quot;)"" />
          <xsl:variable name=""var:v7"" select=""userCSharp:MathDivide(string(@s3:accountAvailability) , &quot;100000&quot;)"" />
          <PlayerBalance>
            <xsl:if test=""@s3:accountId"">
              <AccountID>
                <xsl:value-of select=""@s3:accountId"" />
              </AccountID>
            </xsl:if>
            <xsl:if test=""@s3:accountFrozen"">
              <IsFrozen>
                <xsl:value-of select=""@s3:accountFrozen"" />
              </IsFrozen>
            </xsl:if>
            <BalancePoints>
              <xsl:value-of select=""$var:v6"" />
            </BalancePoints>
            <AvailablePoints>
              <xsl:value-of select=""$var:v7"" />
            </AvailablePoints>
          </PlayerBalance>
        </xsl:if>
      </xsl:for-each>
      <xsl:if test=""InputMessagePart_0/s0:s2sMessage/s0:s2sBody/s3:playerInfo/@s0:errorCode"">
        <ErrorCode>
          <xsl:value-of select=""InputMessagePart_0/s0:s2sMessage/s0:s2sBody/s3:playerInfo/@s0:errorCode"" />
        </ErrorCode>
      </xsl:if>
      <xsl:if test=""InputMessagePart_0/s0:s2sMessage/s0:s2sBody/s3:playerInfo/@s0:errorText"">
        <ErrorDescription>
          <xsl:value-of select=""InputMessagePart_0/s0:s2sMessage/s0:s2sBody/s3:playerInfo/@s0:errorText"" />
        </ErrorDescription>
      </xsl:if>
    </ns0:PointTableBonusConversion>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string MathDivide(string val1, string val2)
{
	string retval = """";
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		if (d2 != 0)
		{
			double ret = d1 / d2;
			retval = ret.ToString(System.Globalization.CultureInfo.InvariantCulture);
		}
	}
	return retval;
}


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


public bool LogicalEq(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 == d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) == 0;
	}
	return ret;
}


public string StringUpperCase(string str)
{
	if (str == null)
	{
		return """";
	}
	return str.ToUpper(System.Globalization.CultureInfo.InvariantCulture);
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}


]]></msxsl:script>
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
