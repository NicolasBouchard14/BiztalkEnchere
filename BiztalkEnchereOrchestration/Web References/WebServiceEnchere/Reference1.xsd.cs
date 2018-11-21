namespace BiztalkEnchereOrchestration.WebServiceEnchere {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.Encherissement",@"Encherissement")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Encherissement"})]
    public sealed class Reference1 : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://BiztalkEnchereSchemas.Encherissement"" elementFormDefault=""qualified"" targetNamespace=""http://BiztalkEnchereSchemas.Encherissement"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Encherissement"" nillable=""true"" type=""tns:Encherissement"" />
  <xs:complexType name=""Encherissement"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdUtilisateur_Encherisseur"" type=""xs:int"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdEnchere"" type=""xs:int"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""OffreMaximale"" type=""xs:decimal"" />
    </xs:sequence>
  </xs:complexType>
</xs:schema>";
        
        public Reference1() {
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
