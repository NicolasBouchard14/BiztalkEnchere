namespace BiztalkEnchereSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.Encherissement",@"Encherissement")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.CommonIdEnchere), XPath = @"/*[local-name()='Encherissement' and namespace-uri()='http://BiztalkEnchereSchemas.Encherissement']/*[local-name()='IdEnchere' and namespace-uri()='']", XsdType = @"int")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BiztalkEnchereSchemas.CommonIdUtilisateur_Encherisseur), XPath = @"/*[local-name()='Encherissement' and namespace-uri()='http://BiztalkEnchereSchemas.Encherissement']/*[local-name()='IdUtilisateur_Encherisseur' and namespace-uri()='']", XsdType = @"int")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Encherissement"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BiztalkEnchereSchemas.CorrelationSchema", typeof(global::BiztalkEnchereSchemas.CorrelationSchema))]
    public sealed class Encherissement : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.Encherissement"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BiztalkEnchereSchemas.CorrelationSchema"" targetNamespace=""http://BiztalkEnchereSchemas.Encherissement"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BiztalkEnchereSchemas.CorrelationSchema"" location=""BiztalkEnchereSchemas.CorrelationSchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Encherissement"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:CommonIdEnchere"" xpath=""/*[local-name()='Encherissement' and namespace-uri()='http://BiztalkEnchereSchemas.Encherissement']/*[local-name()='IdEnchere' and namespace-uri()='']"" />
          <b:property name=""ns0:CommonIdUtilisateur_Encherisseur"" xpath=""/*[local-name()='Encherissement' and namespace-uri()='http://BiztalkEnchereSchemas.Encherissement']/*[local-name()='IdUtilisateur_Encherisseur' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""IdUtilisateur_Encherisseur"" type=""xs:int"" />
        <xs:element name=""IdEnchere"" type=""xs:int"" />
        <xs:element name=""OffreMaximale"">
          <xs:simpleType>
            <xs:restriction base=""xs:decimal"" />
          </xs:simpleType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Encherissement() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Encherissement";
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
