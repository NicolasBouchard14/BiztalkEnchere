namespace BiztalkEnchereOrchestration.Mapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.EvaluationTransaction", typeof(global::BiztalkEnchereSchemas.EvaluationTransaction))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Evaluation", typeof(global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Evaluation))]
    public sealed class MapEvaluationTransactionToSauvegarderEvaluationRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BiztalkEnchereSchemas.EvaluationTransaction"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:EvaluationTransaction"" />
  </xsl:template>
  <xsl:template match=""/s0:EvaluationTransaction"">
    <ns0:BO_Evaluation>
      <ns0:IdEnchere>
        <xsl:value-of select=""IdEnchere/text()"" />
      </ns0:IdEnchere>
      <ns0:IdUtilisateur>
        <xsl:value-of select=""IdUtilisateur/text()"" />
      </ns0:IdUtilisateur>
      <ns0:EvaluationGlobale>
        <xsl:value-of select=""EvaluationGlobale/text()"" />
      </ns0:EvaluationGlobale>
      <ns0:Message>
        <xsl:value-of select=""Message/text()"" />
      </ns0:Message>
      <ns0:FonctionnementProduit>
        <xsl:value-of select=""FonctionnementProduit/text()"" />
      </ns0:FonctionnementProduit>
    </ns0:BO_Evaluation>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereSchemas.EvaluationTransaction";
        
        private const global::BiztalkEnchereSchemas.EvaluationTransaction _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Evaluation";
        
        private const global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Evaluation _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
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
                _SrcSchemas[0] = @"BiztalkEnchereSchemas.EvaluationTransaction";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Evaluation";
                return _TrgSchemas;
            }
        }
    }
}
