namespace BiztalkEnchereSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.Courriel",@"CourrielUtilisateurBanni")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.PropertySchema.Message), XPath = @"/*[local-name()='CourrielUtilisateurBanni' and namespace-uri()='http://BiztalkEnchereSchemas.Courriel']/*[local-name()='Message' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.PropertySchema.NomEnchere), XPath = @"/*[local-name()='CourrielUtilisateurBanni' and namespace-uri()='http://BiztalkEnchereSchemas.Courriel']/*[local-name()='NomEnchere' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CourrielUtilisateurBanni"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.PropertySchema.PropertySchema", typeof(global::BiztalkEnchereSchemas.PropertySchema.PropertySchema))]
    public sealed class CourrielUtilisateurBanni : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.Courriel"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BiztalkEnchereSchemas.PropertySchema"" targetNamespace=""http://BiztalkEnchereSchemas.Courriel"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BiztalkEnchereSchemas.PropertySchema"" location=""BiztalkEnchereSchemas.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CourrielUtilisateurBanni"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Message"" xpath=""/*[local-name()='CourrielUtilisateurBanni' and namespace-uri()='http://BiztalkEnchereSchemas.Courriel']/*[local-name()='Message' and namespace-uri()='']"" />
          <b:property name=""ns0:NomEnchere"" xpath=""/*[local-name()='CourrielUtilisateurBanni' and namespace-uri()='http://BiztalkEnchereSchemas.Courriel']/*[local-name()='NomEnchere' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element default=""Vous avez été bannis car vous n'avez pas payé l'enchère dans un délai de 24 heures!"" name=""Message"" type=""xs:string"" />
        <xs:element name=""NomUtilisateur"" type=""xs:string"" />
        <xs:element name=""NomEnchere"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public CourrielUtilisateurBanni() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "CourrielUtilisateurBanni";
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
