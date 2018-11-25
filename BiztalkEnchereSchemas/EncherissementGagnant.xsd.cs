namespace BiztalkEnchereSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.EncherissementGagnant",@"EncherissementGagnant")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.CommonIdUtilisateur_Vendeur), XPath = @"/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Utilisateur_Vendeur' and namespace-uri()='']/*[local-name()='IdUtilisateur' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.CommonIdUtilisateur_EncherisseurGagnant), XPath = @"/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Utilisateur_Encherisseur' and namespace-uri()='']/*[local-name()='IdUtilisateur' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.PropertySchema.IdEnchere), XPath = @"/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Encherissement' and namespace-uri()='']/*[local-name()='IdEnchere' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.CommonIdEnchere), XPath = @"/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Encherissement' and namespace-uri()='']/*[local-name()='IdEnchere' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EncherissementGagnant"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.CorrelationSchema", typeof(global::BiztalkEnchereSchemas.CorrelationSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.PropertySchema.PropertySchema", typeof(global::BiztalkEnchereSchemas.PropertySchema.PropertySchema))]
    public sealed class EncherissementGagnant : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.EncherissementGagnant"" xmlns:ns1=""https://BiztalkEnchereSchemas.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BiztalkEnchereSchemas.CorrelationSchema"" targetNamespace=""http://BiztalkEnchereSchemas.EncherissementGagnant"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BiztalkEnchereSchemas.CorrelationSchema"" location=""BiztalkEnchereSchemas.CorrelationSchema"" />
        <b:namespace prefix=""ns1"" uri=""https://BiztalkEnchereSchemas.PropertySchema"" location=""BiztalkEnchereSchemas.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""EncherissementGagnant"" nillable=""true"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:CommonIdUtilisateur_Vendeur"" xpath=""/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Utilisateur_Vendeur' and namespace-uri()='']/*[local-name()='IdUtilisateur' and namespace-uri()='']"" />
          <b:property name=""ns0:CommonIdUtilisateur_EncherisseurGagnant"" xpath=""/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Utilisateur_Encherisseur' and namespace-uri()='']/*[local-name()='IdUtilisateur' and namespace-uri()='']"" />
          <b:property name=""ns1:IdEnchere"" xpath=""/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Encherissement' and namespace-uri()='']/*[local-name()='IdEnchere' and namespace-uri()='']"" />
          <b:property name=""ns0:CommonIdEnchere"" xpath=""/*[local-name()='EncherissementGagnant' and namespace-uri()='http://BiztalkEnchereSchemas.EncherissementGagnant']/*[local-name()='Encherissement' and namespace-uri()='']/*[local-name()='IdEnchere' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Encherissement"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""IdEnchere"" type=""xs:int"" />
              <xs:element name=""OffreMaximale"" type=""xs:decimal"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Utilisateur_Vendeur"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""IdUtilisateur"" type=""xs:int"" />
              <xs:element name=""NomUtilisateur"" type=""xs:string"" />
              <xs:element name=""Courriel"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element name=""Utilisateur_Encherisseur"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""IdUtilisateur"" type=""xs:int"" />
              <xs:element name=""NomUtilisateur"" type=""xs:string"" />
              <xs:element name=""Courriel"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public EncherissementGagnant() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "EncherissementGagnant";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
