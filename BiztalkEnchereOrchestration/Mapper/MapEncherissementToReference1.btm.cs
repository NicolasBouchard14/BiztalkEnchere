namespace BiztalkEnchereOrchestration.Mapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.Encherissement", typeof(global::BiztalkEnchereSchemas.Encherissement))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Encherissement", typeof(global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Encherissement))]
    public sealed class MapEncherissementToReference1 : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BiztalkEnchereSchemas.Encherissement"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Encherissement"" />
  </xsl:template>
  <xsl:template match=""/s0:Encherissement"">
    <ns0:BO_Encherissement>
      <ns0:IdUtilisateur_Encherisseur>
        <xsl:value-of select=""IdUtilisateur_Encherisseur/text()"" />
      </ns0:IdUtilisateur_Encherisseur>
      <ns0:IdEnchere>
        <xsl:value-of select=""IdEnchere/text()"" />
      </ns0:IdEnchere>
      <ns0:OffreMaximale>
        <xsl:value-of select=""OffreMaximale/text()"" />
      </ns0:OffreMaximale>
    </ns0:BO_Encherissement>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereSchemas.Encherissement";
        
        private const global::BiztalkEnchereSchemas.Encherissement _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Encherissement";
        
        private const global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Encherissement _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BiztalkEnchereSchemas.Encherissement";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Encherissement";
                return _TrgSchemas;
            }
        }
    }
}
