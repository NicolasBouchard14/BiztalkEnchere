namespace BiztalkEnchereOrchestration.Mapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Enchere", typeof(global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Enchere))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.Enchere", typeof(global::BiztalkEnchereSchemas.Enchere))]
    public sealed class MapSauvegardeEnchereResponseToDemandeCreationEnchere : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://tempuri.org/"" xmlns:ns0=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:BO_Enchere"" />
  </xsl:template>
  <xsl:template match=""/s0:BO_Enchere"">
    <ns0:Enchere>
      <IdEnchere>
        <xsl:value-of select=""s0:IdEnchere/text()"" />
      </IdEnchere>
      <IdUtilisateur_Vendeur>
        <xsl:value-of select=""s0:DemandeCreationEnchere/s0:IdUtilisateur_Vendeur/text()"" />
      </IdUtilisateur_Vendeur>
      <xsl:if test=""s0:DemandeCreationEnchere/s0:NomEnchere"">
        <NomEnchere>
          <xsl:value-of select=""s0:DemandeCreationEnchere/s0:NomEnchere/text()"" />
        </NomEnchere>
      </xsl:if>
      <PrixMinimum>
        <xsl:value-of select=""s0:DemandeCreationEnchere/s0:PrixMinimum/text()"" />
      </PrixMinimum>
      <xsl:if test=""s0:DemandeCreationEnchere/s0:OptionTransport"">
        <OptionTransport>
          <xsl:value-of select=""s0:DemandeCreationEnchere/s0:OptionTransport/text()"" />
        </OptionTransport>
      </xsl:if>
      <Duree>
        <xsl:value-of select=""s0:DemandeCreationEnchere/s0:Duree/text()"" />
      </Duree>
      <xsl:if test=""s0:DemandeCreationEnchere/s0:TypeEnchere"">
        <TypeEnchere>
          <xsl:value-of select=""s0:DemandeCreationEnchere/s0:TypeEnchere/text()"" />
        </TypeEnchere>
      </xsl:if>
      <xsl:if test=""s0:DemandeCreationEnchere/s0:Categorie"">
        <Categorie>
          <xsl:value-of select=""s0:DemandeCreationEnchere/s0:Categorie/text()"" />
        </Categorie>
      </xsl:if>
      <xsl:if test=""s0:DemandeCreationEnchere/s0:MotsCles"">
        <MotsCles>
          <xsl:value-of select=""s0:DemandeCreationEnchere/s0:MotsCles/text()"" />
        </MotsCles>
      </xsl:if>
      <xsl:if test=""s0:DemandeCreationEnchere/s0:AutresInformations"">
        <AutresInformations>
          <xsl:value-of select=""s0:DemandeCreationEnchere/s0:AutresInformations/text()"" />
        </AutresInformations>
      </xsl:if>
    </ns0:Enchere>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Enchere";
        
        private const global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_Enchere _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_Enchere";
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
