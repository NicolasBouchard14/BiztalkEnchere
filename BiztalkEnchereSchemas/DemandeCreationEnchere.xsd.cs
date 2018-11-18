namespace BiztalkEnchereSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.DemandeCreationEnchere",@"DemandeCreationEnchere")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DemandeCreationEnchere"})]
    public sealed class DemandeCreationEnchere : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DemandeCreationEnchere"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""NomEnchere"" type=""xs:string"" />
        <xs:element name=""PrixMinimum"">
          <xs:simpleType>
            <xs:restriction base=""xs:decimal"" />
          </xs:simpleType>
        </xs:element>
        <xs:element name=""OptionTransport"" type=""xs:string"" />
        <xs:element name=""Duree"">
          <xs:simpleType>
            <xs:restriction base=""xs:time"" />
          </xs:simpleType>
        </xs:element>
        <xs:element name=""TypeEnchere"" type=""xs:string"" />
        <xs:element name=""Categorie"" type=""xs:string"" />
        <xs:element name=""MotsCles"" type=""xs:string"" />
        <xs:element name=""Autre"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public DemandeCreationEnchere() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "DemandeCreationEnchere";
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
