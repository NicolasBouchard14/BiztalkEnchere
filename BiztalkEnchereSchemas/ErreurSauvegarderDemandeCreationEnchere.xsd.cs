namespace BiztalkEnchereSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BiztalkEnchereSchemas.ErreurSauvegarderDemandeCreationEnchere",@"ErreurSauvegarderDemandeCreationEnchere")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"ErreurSauvegarderDemandeCreationEnchere"})]
    public sealed class ErreurSauvegarderDemandeCreationEnchere : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.ErreurSauvegarderDemandeCreationEnchere"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BiztalkEnchereSchemas.ErreurSauvegarderDemandeCreationEnchere"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""ErreurSauvegarderDemandeCreationEnchere"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""IdUtilisateur_Vendeur"" type=""xs:int"" />
        <xs:element name=""NomEnchere"" type=""xs:string"" />
        <xs:element name=""PrixMinimum"" type=""xs:decimal"" />
        <xs:element name=""OptionTransport"" type=""xs:string"" />
        <xs:element name=""Duree"" type=""xs:int"" />
        <xs:element name=""TypeEnchere"" type=""xs:string"" />
        <xs:element name=""Categorie"" type=""xs:string"" />
        <xs:element name=""MotsCles"" type=""xs:string"" />
        <xs:element name=""AutresInformations"" type=""xs:string"" />
        <xs:element default=""Une erreur est survenu lors de la sauvegarde de la demande de création d'enchère."" name=""DescriptionErreur"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public ErreurSauvegarderDemandeCreationEnchere() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "ErreurSauvegarderDemandeCreationEnchere";
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
