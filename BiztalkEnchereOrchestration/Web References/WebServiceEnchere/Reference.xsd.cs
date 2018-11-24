namespace BiztalkEnchereOrchestration.WebServiceEnchere {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"BO_DemandeCreationEnchere", @"BO_Utilisateur", @"BO_EncherissementGagnant", @"BO_Encherissement", @"BO_Paiement", @"BO_Enchere"})]
    public sealed class Reference : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:tns=""http://tempuri.org/"" elementFormDefault=""qualified"" targetNamespace=""http://tempuri.org/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""BO_DemandeCreationEnchere"" nillable=""true"" type=""tns:BO_DemandeCreationEnchere"" />
  <xs:complexType name=""BO_DemandeCreationEnchere"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdUtilisateur_Vendeur"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NomEnchere"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""PrixMinimum"" type=""xs:decimal"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""OptionTransport"" type=""xs:string"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""Duree"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""TypeEnchere"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Categorie"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""MotsCles"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""AutresInformations"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""BO_Utilisateur"" nillable=""true"" type=""tns:BO_Utilisateur"" />
  <xs:complexType name=""BO_Utilisateur"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdUtilisateur"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""NomUtilisateur"" type=""xs:string"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Courriel"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""BO_EncherissementGagnant"" nillable=""true"" type=""tns:BO_EncherissementGagnant"" />
  <xs:complexType name=""BO_EncherissementGagnant"">
    <xs:sequence>
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Encherissement"" type=""tns:BO_Encherissement"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Utilisateur_Vendeur"" type=""tns:BO_Utilisateur"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""Utilisateur_EncherisseurGagnant"" type=""tns:BO_Utilisateur"" />
    </xs:sequence>
  </xs:complexType>
  <xs:complexType name=""BO_Encherissement"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdUtilisateur_Encherisseur"" type=""xs:int"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdEnchere"" type=""xs:int"" />
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""OffreMaximale"" type=""xs:decimal"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""BO_Encherissement"" nillable=""true"" type=""tns:BO_Encherissement"" />
  <xs:element name=""BO_Paiement"" nillable=""true"" type=""tns:BO_Paiement"" />
  <xs:complexType name=""BO_Paiement"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdEnchere"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""InfosPaiement"" type=""xs:string"" />
    </xs:sequence>
  </xs:complexType>
  <xs:element name=""BO_Enchere"" nillable=""true"" type=""tns:BO_Enchere"" />
  <xs:complexType name=""BO_Enchere"">
    <xs:sequence>
      <xs:element minOccurs=""1"" maxOccurs=""1"" name=""IdEnchere"" type=""xs:int"" />
      <xs:element minOccurs=""0"" maxOccurs=""1"" name=""DemandeCreationEnchere"" type=""tns:BO_DemandeCreationEnchere"" />
    </xs:sequence>
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
                string[] _RootElements = new string [6];
                _RootElements[0] = "BO_DemandeCreationEnchere";
                _RootElements[1] = "BO_Utilisateur";
                _RootElements[2] = "BO_EncherissementGagnant";
                _RootElements[3] = "BO_Encherissement";
                _RootElements[4] = "BO_Paiement";
                _RootElements[5] = "BO_Enchere";
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
        
        [Schema(@"http://tempuri.org/",@"BO_DemandeCreationEnchere")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BO_DemandeCreationEnchere"})]
        public sealed class BO_DemandeCreationEnchere : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BO_DemandeCreationEnchere() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BO_DemandeCreationEnchere";
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
        
        [Schema(@"http://tempuri.org/",@"BO_Utilisateur")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BO_Utilisateur"})]
        public sealed class BO_Utilisateur : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BO_Utilisateur() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BO_Utilisateur";
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
        
        [Schema(@"http://tempuri.org/",@"BO_EncherissementGagnant")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BO_EncherissementGagnant"})]
        public sealed class BO_EncherissementGagnant : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BO_EncherissementGagnant() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BO_EncherissementGagnant";
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
        
        [Schema(@"http://tempuri.org/",@"BO_Encherissement")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BO_Encherissement"})]
        public sealed class BO_Encherissement : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BO_Encherissement() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BO_Encherissement";
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
        
        [Schema(@"http://tempuri.org/",@"BO_Paiement")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BO_Paiement"})]
        public sealed class BO_Paiement : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BO_Paiement() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BO_Paiement";
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
        
        [Schema(@"http://tempuri.org/",@"BO_Enchere")]
        [System.SerializableAttribute()]
        [SchemaRoots(new string[] {@"BO_Enchere"})]
        public sealed class BO_Enchere : Microsoft.XLANGs.BaseTypes.SchemaBase {
            
            [System.NonSerializedAttribute()]
            private static object _rawSchema;
            
            public BO_Enchere() {
            }
            
            public override string XmlContent {
                get {
                    return _strSchema;
                }
            }
            
            public override string[] RootNodes {
                get {
                    string[] _RootElements = new string [1];
                    _RootElements[0] = "BO_Enchere";
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
}
