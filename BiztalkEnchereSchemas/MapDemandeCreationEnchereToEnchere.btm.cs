namespace BiztalkEnchereSchemas {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.DemandeCreationEnchere", typeof(global::BiztalkEnchereSchemas.DemandeCreationEnchere))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.Enchere", typeof(global::BiztalkEnchereSchemas.Enchere))]
    public sealed class MapDemandeCreationEnchereToEnchere : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var"" version=""1.0"" xmlns:ns0=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/ns0:DemandeCreationEnchere"" />
  </xsl:template>
  <xsl:template match=""/ns0:DemandeCreationEnchere"">
    <ns0:Enchere>
      <IdEnchere>
        <xsl:text>0</xsl:text>
      </IdEnchere>
      <IdUtilisateur_Vendeur>
        <xsl:value-of select=""IdUtilisateur_Vendeur/text()"" />
      </IdUtilisateur_Vendeur>
      <NomEnchere>
        <xsl:value-of select=""NomEnchere/text()"" />
      </NomEnchere>
      <PrixMinimum>
        <xsl:value-of select=""PrixMinimum/text()"" />
      </PrixMinimum>
      <OptionTransport>
        <xsl:value-of select=""OptionTransport/text()"" />
      </OptionTransport>
      <Duree>
        <xsl:value-of select=""Duree/text()"" />
      </Duree>
      <TypeEnchere>
        <xsl:value-of select=""TypeEnchere/text()"" />
      </TypeEnchere>
      <Categorie>
        <xsl:value-of select=""Categorie/text()"" />
      </Categorie>
      <MotsCles>
        <xsl:value-of select=""MotsCles/text()"" />
      </MotsCles>
      <AutresInformations>
        <xsl:value-of select=""AutresInformations/text()"" />
      </AutresInformations>
    </ns0:Enchere>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereSchemas.DemandeCreationEnchere";
        
        private const global::BiztalkEnchereSchemas.DemandeCreationEnchere _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BiztalkEnchereSchemas.Enchere";
        
        private const global::BiztalkEnchereSchemas.Enchere _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BiztalkEnchereSchemas.DemandeCreationEnchere";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkEnchereSchemas.Enchere";
                return _TrgSchemas;
            }
        }
    }
}
