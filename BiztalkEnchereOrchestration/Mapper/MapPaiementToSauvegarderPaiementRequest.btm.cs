namespace BiztalkEnchereOrchestration.Mapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.Paiement", typeof(global::BiztalkEnchereSchemas.Paiement))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Paiement", typeof(global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Paiement))]
    public sealed class MapPaiementToSauvegarderPaiementInfosRequest : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BiztalkEnchereSchemas.Paiement"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Paiement"" />
  </xsl:template>
  <xsl:template match=""/s0:Paiement"">
    <ns0:BO_Paiement>
      <ns0:IdEnchere>
        <xsl:value-of select=""IdEnchere/text()"" />
      </ns0:IdEnchere>
      <ns0:InfosPaiement>
        <xsl:value-of select=""InfosPaiement/text()"" />
      </ns0:InfosPaiement>
    </ns0:BO_Paiement>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereSchemas.Paiement";
        
        private const global::BiztalkEnchereSchemas.Paiement _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Paiement";
        
        private const global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Paiement _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BiztalkEnchereSchemas.Paiement";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Paiement";
                return _TrgSchemas;
            }
        }
    }
}
