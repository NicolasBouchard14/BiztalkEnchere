namespace BiztalkEnchereOrchestration.WebServiceEnchere {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.DemandeCreationEnchere",@"DemandeCreationEnchere")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"DemandeCreationEnchere"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"" elementFormDefault=""qualified"" targetNamespace=""http://BiztalkEnchereSchemas.DemandeCreationEnchere"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""DemandeCreationEnchere"" nillable=""true"" type=""tns:DemandeCreationEnchere"" />
  <xs:complexType name=""DemandeCreationEnchere"">
    <xs:attribute name=""NomEnchere"" type=""xs:string"" />
    <xs:attribute name=""PrixMinimum"" type=""xs:decimal"" use=""required"" />
    <xs:attribute name=""OptionTransport"" type=""xs:string"" />
    <xs:attribute name=""Duree"" type=""xs:int"" use=""required"" />
    <xs:attribute name=""TypeEnchere"" type=""xs:string"" />
    <xs:attribute name=""Categorie"" type=""xs:string"" />
    <xs:attribute name=""MotsCles"" type=""xs:string"" />
    <xs:attribute name=""AutresInformations"" type=""xs:string"" />
  </xs:complexType>
</xs:schema>";
        
        public Reference() {
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
