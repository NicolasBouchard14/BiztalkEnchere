namespace BiztalkEnchereSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.Enchere",@"Enchere")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.PropertySchema.Duree), XPath = @"/*[local-name()='Enchere' and namespace-uri()='http://BiztalkEnchereSchemas.Enchere']/*[local-name()='Duree' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.CommonIdUtilisateur_Vendeur), XPath = @"/*[local-name()='Enchere' and namespace-uri()='http://BiztalkEnchereSchemas.Enchere']/*[local-name()='IdUtilisateur_Vendeur' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.CommonIdEnchere), XPath = @"/*[local-name()='Enchere' and namespace-uri()='http://BiztalkEnchereSchemas.Enchere']/*[local-name()='IdEnchere' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Enchere"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.CorrelationSchema", typeof(global::BiztalkEnchereSchemas.CorrelationSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.PropertySchema.PropertySchema", typeof(global::BiztalkEnchereSchemas.PropertySchema.PropertySchema))]
    public sealed class Enchere : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.Enchere"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns1=""https://BiztalkEnchereSchemas.CorrelationSchema"" xmlns:ns0=""https://BiztalkEnchereSchemas.PropertySchema"" targetNamespace=""http://BiztalkEnchereSchemas.Enchere"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns1"" uri=""https://BiztalkEnchereSchemas.CorrelationSchema"" location=""BiztalkEnchereSchemas.CorrelationSchema"" />
        <b:namespace prefix=""ns0"" uri=""https://BiztalkEnchereSchemas.PropertySchema"" location=""BiztalkEnchereSchemas.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Enchere"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:Duree"" xpath=""/*[local-name()='Enchere' and namespace-uri()='http://BiztalkEnchereSchemas.Enchere']/*[local-name()='Duree' and namespace-uri()='']"" />
          <b:property name=""ns1:CommonIdUtilisateur_Vendeur"" xpath=""/*[local-name()='Enchere' and namespace-uri()='http://BiztalkEnchereSchemas.Enchere']/*[local-name()='IdUtilisateur_Vendeur' and namespace-uri()='']"" />
          <b:property name=""ns1:CommonIdEnchere"" xpath=""/*[local-name()='Enchere' and namespace-uri()='http://BiztalkEnchereSchemas.Enchere']/*[local-name()='IdEnchere' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""IdUtilisateur_Vendeur"" type=""xs:int"" />
        <xs:element name=""IdEnchere"" type=""xs:int"" />
        <xs:element name=""NomEnchere"" type=""xs:string"" />
        <xs:element name=""PrixMinimum"">
          <xs:simpleType>
            <xs:restriction base=""xs:decimal"" />
          </xs:simpleType>
        </xs:element>
        <xs:element name=""OptionTransport"" type=""xs:string"" />
        <xs:element name=""Duree"" type=""xs:int"" />
        <xs:element name=""TypeEnchere"" type=""xs:string"" />
        <xs:element name=""Categorie"" type=""xs:string"" />
        <xs:element name=""MotsCles"" type=""xs:string"" />
        <xs:element name=""AutresInformations"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Enchere() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Enchere";
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
