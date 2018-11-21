namespace BiztalkEnchereSchemas.PropertySchema {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Property)]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"EnchereTerminee", @"Duree", @"IdEnchere"})]
    public sealed class PropertySchema : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BiztalkEnchereSchemas.PropertySchema"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""https://BiztalkEnchereSchemas.PropertySchema"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:schemaInfo schema_type=""property"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" />
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""EnchereTerminee"" type=""xs:boolean"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""5985820c-307e-49f3-a6c7-ec45c5dcf2c6"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""Duree"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""ecce6636-db10-498c-a95c-3651b0933a5c"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
  <xs:element name=""IdEnchere"" type=""xs:int"">
    <xs:annotation>
      <xs:appinfo>
        <b:fieldInfo propertyGuid=""d82e2af4-da56-4280-ade5-35976f413d65"" />
      </xs:appinfo>
    </xs:annotation>
  </xs:element>
</xs:schema>";
        
        public PropertySchema() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [3];
                _RootElements[0] = "EnchereTerminee";
                _RootElements[1] = "Duree";
                _RootElements[2] = "IdEnchere";
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
    [PropertyType(@"EnchereTerminee",@"https://BiztalkEnchereSchemas.PropertySchema","boolean","System.Boolean")]
    [PropertyGuidAttribute(@"5985820c-307e-49f3-a6c7-ec45c5dcf2c6")]
    public sealed class EnchereTerminee : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"EnchereTerminee", @"https://BiztalkEnchereSchemas.PropertySchema");
        
        private static bool PropertyValueType {
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
                return typeof(bool);
            }
        }
    }
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.SerializableAttribute()]
    [PropertyType(@"Duree",@"https://BiztalkEnchereSchemas.PropertySchema","int","System.Int32")]
    [PropertyGuidAttribute(@"ecce6636-db10-498c-a95c-3651b0933a5c")]
    public sealed class Duree : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"Duree", @"https://BiztalkEnchereSchemas.PropertySchema");
        
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
    [PropertyType(@"IdEnchere",@"https://BiztalkEnchereSchemas.PropertySchema","int","System.Int32")]
    [PropertyGuidAttribute(@"d82e2af4-da56-4280-ade5-35976f413d65")]
    public sealed class IdEnchere : Microsoft.XLANGs.BaseTypes.MessageDataPropertyBase {
        
        [System.NonSerializedAttribute()]
        private static System.Xml.XmlQualifiedName _QName = new System.Xml.XmlQualifiedName(@"IdEnchere", @"https://BiztalkEnchereSchemas.PropertySchema");
        
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
