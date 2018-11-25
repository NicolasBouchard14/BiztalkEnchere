namespace BiztalkEnchereSchemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.Enchere", typeof(global::BiztalkEnchereSchemas.Enchere))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.ErreurProcessusEnchere", typeof(global::BiztalkEnchereSchemas.ErreurProcessusEnchere))]
    public sealed class MapEnchereToErreurProcessusEnchere : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"" xmlns:ns0=""http://BiztalkEnchereSchemas.ErreurProcessusEnchere"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Enchere"" />
  </xsl:template>
  <xsl:template match=""/s0:Enchere"">
    <ns0:ErreurProcessusEnchere>
      <IdEnchere>
        <xsl:value-of select=""IdEnchere/text()"" />
      </IdEnchere>
      <IdUtilisateur_Vendeur>
        <xsl:value-of select=""IdUtilisateur_Vendeur/text()"" />
      </IdUtilisateur_Vendeur>
      <Description>
        <xsl:text>Erreur lors du processus de traitement de l'enchère, une exception a été levée.</xsl:text>
      </Description>
    </ns0:ErreurProcessusEnchere>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereSchemas.Enchere";
        
        private const global::BiztalkEnchereSchemas.Enchere _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BiztalkEnchereSchemas.ErreurProcessusEnchere";
        
        private const global::BiztalkEnchereSchemas.ErreurProcessusEnchere _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BiztalkEnchereSchemas.Enchere";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkEnchereSchemas.ErreurProcessusEnchere";
                return _TrgSchemas;
            }
        }
    }
}
