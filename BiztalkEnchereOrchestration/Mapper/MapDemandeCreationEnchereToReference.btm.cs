namespace BiztalkEnchereOrchestration.Mapper {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.DemandeCreationEnchere", typeof(global::BiztalkEnchereSchemas.DemandeCreationEnchere))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_DemandeCreationEnchere", typeof(global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_DemandeCreationEnchere))]
    public sealed class MapDemandeCreationEnchereToReference : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"" xmlns:ns0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:DemandeCreationEnchere"" />
  </xsl:template>
  <xsl:template match=""/s0:DemandeCreationEnchere"">
    <ns0:BO_DemandeCreationEnchere>
      <ns0:IdUtilisateur_Vendeur>
        <xsl:value-of select=""IdUtilisateur_Vendeur/text()"" />
      </ns0:IdUtilisateur_Vendeur>
      <ns0:IdUtilisateur_Vendeur>
        <xsl:value-of select=""IdUtilisateur_Vendeur/text()"" />
      </ns0:IdUtilisateur_Vendeur>
      <ns0:NomEnchere>
        <xsl:value-of select=""NomEnchere/text()"" />
      </ns0:NomEnchere>
      <ns0:NomEnchere>
        <xsl:value-of select=""NomEnchere/text()"" />
      </ns0:NomEnchere>
      <ns0:PrixMinimum>
        <xsl:value-of select=""PrixMinimum/text()"" />
      </ns0:PrixMinimum>
      <ns0:PrixMinimum>
        <xsl:value-of select=""PrixMinimum/text()"" />
      </ns0:PrixMinimum>
      <ns0:OptionTransport>
        <xsl:value-of select=""OptionTransport/text()"" />
      </ns0:OptionTransport>
      <ns0:OptionTransport>
        <xsl:value-of select=""OptionTransport/text()"" />
      </ns0:OptionTransport>
      <ns0:Duree>
        <xsl:value-of select=""Duree/text()"" />
      </ns0:Duree>
      <ns0:Duree>
        <xsl:value-of select=""Duree/text()"" />
      </ns0:Duree>
      <ns0:TypeEnchere>
        <xsl:value-of select=""TypeEnchere/text()"" />
      </ns0:TypeEnchere>
      <ns0:TypeEnchere>
        <xsl:value-of select=""TypeEnchere/text()"" />
      </ns0:TypeEnchere>
      <ns0:Categorie>
        <xsl:value-of select=""Categorie/text()"" />
      </ns0:Categorie>
      <ns0:Categorie>
        <xsl:value-of select=""Categorie/text()"" />
      </ns0:Categorie>
      <ns0:MotsCles>
        <xsl:value-of select=""MotsCles/text()"" />
      </ns0:MotsCles>
      <ns0:MotsCles>
        <xsl:value-of select=""MotsCles/text()"" />
      </ns0:MotsCles>
      <ns0:AutresInformations>
        <xsl:value-of select=""AutresInformations/text()"" />
      </ns0:AutresInformations>
      <ns0:AutresInformations>
        <xsl:value-of select=""AutresInformations/text()"" />
      </ns0:AutresInformations>
    </ns0:BO_DemandeCreationEnchere>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BiztalkEnchereSchemas.DemandeCreationEnchere";
        
        private const global::BiztalkEnchereSchemas.DemandeCreationEnchere _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_DemandeCreationEnchere";
        
        private const global::BiztalkEnchereOrchestration.WebServiceEnchere.Reference.BO_DemandeCreationEnchere _trgSchemaTypeReference0 = null;
        
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
                _TrgSchemas[0] = @"BiztalkEnchereOrchestration.WebServiceEnchere.Reference+BO_DemandeCreationEnchere";
                return _TrgSchemas;
            }
        }
    }
}
