namespace BiztalkEnchereSchemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"CommonIdEnchere", @"CommonIdUtilisateur_Vendeur", @"CommonIdUtilisateur_EncherisseurGagnant"})]
    public sealed class CorrelationSchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.CorrelationSchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://BiztalkEnchereSchemas.CorrelationSchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""CommonIdEnchere"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""5d006c21-f272-41de-8e56-b9ff92c68e4d"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CommonIdUtilisateur_Vendeur"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""4c2f4f52-7a37-4a0b-9a13-de157b91ffb9"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""CommonIdUtilisateur_EncherisseurGagnant"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""79eca1b3-15af-4fd0-8756-cbb7d92b75ec"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public CorrelationSchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "CommonIdEnchere";
                _RootElements[1] = "CommonIdUtilisateur_Vendeur";
                _RootElements[2] = "CommonIdUtilisateur_EncherisseurGagnant";
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
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"CommonIdEnchere",@"https://BiztalkEnchereSchemas.CorrelationSchema","int","System.Int32")]
    [PropertyGuidAttribute(@"5d006c21-f272-41de-8e56-b9ff92c68e4d")]
    public sealed class CommonIdEnchere : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"CommonIdEnchere", @"https://BiztalkEnchereSchemas.CorrelationSchema");
        
        private static int PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(int);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"CommonIdUtilisateur_Vendeur",@"https://BiztalkEnchereSchemas.CorrelationSchema","int","System.Int32")]
    [PropertyGuidAttribute(@"4c2f4f52-7a37-4a0b-9a13-de157b91ffb9")]
    public sealed class CommonIdUtilisateur_Vendeur : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"CommonIdUtilisateur_Vendeur", @"https://BiztalkEnchereSchemas.CorrelationSchema");
        
        private static int PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(int);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"CommonIdUtilisateur_EncherisseurGagnant",@"https://BiztalkEnchereSchemas.CorrelationSchema","int","System.Int32")]
    [PropertyGuidAttribute(@"79eca1b3-15af-4fd0-8756-cbb7d92b75ec")]
    public sealed class CommonIdUtilisateur_EncherisseurGagnant : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"CommonIdUtilisateur_EncherisseurGagnant", @"https://BiztalkEnchereSchemas.CorrelationSchema");
        
        private static int PropertyValueType {
            get {
                throw new System.NotSupportedException();
            }
        }
        
        public override System.Xml.XmlQualifiedName Name {
            get {
                return _QName;
            }
        }
        
        public override System.Type Type {
            get {
                return typeof(int);
            }
        }
    }
}
