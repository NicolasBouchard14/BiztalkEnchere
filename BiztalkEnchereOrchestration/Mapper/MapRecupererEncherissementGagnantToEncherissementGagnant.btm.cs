namespace BiztalkEnchereOrchestration.Mapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_EncherissementGagnant", typeof(global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_EncherissementGagnant))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.EncherissementGagnant", typeof(global::BiztalkEnchereSchemas.EncherissementGagnant))]
    public sealed class MapRecupererEncherissementGagnantToEncherissementGagnant : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://BiztalkEnchereSchemas.EncherissementGagnant"" xmlns:s0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:BO_EncherissementGagnant"" />
  </xsl:template>
  <xsl:template match=""/s0:BO_EncherissementGagnant"">
    <ns0:EncherissementGagnant>
      <xsl:for-each select=""s0:Encherissement"">
        <Encherissement>
          <IdEnchere>
            <xsl:value-of select=""s0:IdEnchere/text()"" />
          </IdEnchere>
          <OffreMaximale>
            <xsl:value-of select=""s0:OffreMaximale/text()"" />
          </OffreMaximale>
        </Encherissement>
      </xsl:for-each>
      <xsl:for-each select=""s0:Utilisateur_Vendeur"">
        <Utilisateur_Vendeur>
          <IdUtilisateur>
            <xsl:value-of select=""s0:IdUtilisateur/text()"" />
          </IdUtilisateur>
          <xsl:if test=""s0:NomUtilisateur"">
            <NomUtilisateur>
              <xsl:value-of select=""s0:NomUtilisateur/text()"" />
            </NomUtilisateur>
          </xsl:if>
          <xsl:if test=""s0:Courriel"">
            <Courriel>
              <xsl:value-of select=""s0:Courriel/text()"" />
            </Courriel>
          </xsl:if>
        </Utilisateur_Vendeur>
      </xsl:for-each>
      <xsl:for-each select=""s0:Utilisateur_EncherisseurGagnant"">
        <Utilisateur_Encherisseur>
          <IdUtilisateur>
            <xsl:value-of select=""s0:IdUtilisateur/text()"" />
          </IdUtilisateur>
          <xsl:if test=""s0:NomUtilisateur"">
            <NomUtilisateur>
              <xsl:value-of select=""s0:NomUtilisateur/text()"" />
            </NomUtilisateur>
          </xsl:if>
          <xsl:if test=""s0:Courriel"">
            <Courriel>
              <xsl:value-of select=""s0:Courriel/text()"" />
            </Courriel>
          </xsl:if>
        </Utilisateur_Encherisseur>
      </xsl:for-each>
    </ns0:EncherissementGagnant>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_EncherissementGagnant";
        
        private const global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_EncherissementGagnant _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BiztalkEnchereSchemas.EncherissementGagnant";
        
        private const global::BiztalkEnchereSchemas.EncherissementGagnant _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_EncherissementGagnant";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BiztalkEnchereSchemas.EncherissementGagnant";
                return _TrgSchemas;
            }
        }
    }
}
