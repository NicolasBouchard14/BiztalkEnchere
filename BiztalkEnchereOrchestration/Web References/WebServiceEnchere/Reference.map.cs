//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Ce code source a été automatiquement généré par Microsoft.VisualStudio.BizTalkProject.Generators, Version 4.0.30319.42000.
// 
namespace BiztalkEnchereOrchestration.WebServiceEnchere {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2556.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ServiceEnchere_NBSoap", Namespace="http://tempuri.org/")]
    [Microsoft.XLANGs.BaseTypes.WebServiceUrlAttribute("http://localhost:55661/ServiceEnchere_NB.asmx")]
    public partial class ServiceEnchere_NB : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public ServiceEnchere_NB() {
            string urlSetting = System.Configuration.ConfigurationManager.AppSettings["BiztalkEnchereOrchestration.WebServiceEnchere.ServiceEnchere_NB"];
            if ((urlSetting != null)) {
                this.Url = string.Concat(urlSetting, "");
            }
            else {
                this.Url = "http://localhost:55661/ServiceEnchere_NB.asmx";
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SauvegarderDemandeCreationEnchere", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BO_Enchere SauvegarderDemandeCreationEnchere(BO_DemandeCreationEnchere pDemandeCreationEnchere) {
            object[] results = this.Invoke("SauvegarderDemandeCreationEnchere", new object[] {
                        pDemandeCreationEnchere});
            return ((BO_Enchere)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSauvegarderDemandeCreationEnchere(BO_DemandeCreationEnchere pDemandeCreationEnchere, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SauvegarderDemandeCreationEnchere", new object[] {
                        pDemandeCreationEnchere}, callback, asyncState);
        }
        
        /// <remarks/>
        public BO_Enchere EndSauvegarderDemandeCreationEnchere(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((BO_Enchere)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SauvegarderEncherissement", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SauvegarderEncherissement(BO_Encherissement pEncherissement) {
            object[] results = this.Invoke("SauvegarderEncherissement", new object[] {
                        pEncherissement});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSauvegarderEncherissement(BO_Encherissement pEncherissement, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SauvegarderEncherissement", new object[] {
                        pEncherissement}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSauvegarderEncherissement(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BannirEncherisseurGagnant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool BannirEncherisseurGagnant(int pIdUtilisateur_EncherisseurGagnant) {
            object[] results = this.Invoke("BannirEncherisseurGagnant", new object[] {
                        pIdUtilisateur_EncherisseurGagnant});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginBannirEncherisseurGagnant(int pIdUtilisateur_EncherisseurGagnant, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("BannirEncherisseurGagnant", new object[] {
                        pIdUtilisateur_EncherisseurGagnant}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndBannirEncherisseurGagnant(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SauvegarderInfosPaiement", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool SauvegarderInfosPaiement(BO_Paiement pPaiement) {
            object[] results = this.Invoke("SauvegarderInfosPaiement", new object[] {
                        pPaiement});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSauvegarderInfosPaiement(BO_Paiement pPaiement, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SauvegarderInfosPaiement", new object[] {
                        pPaiement}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndSauvegarderInfosPaiement(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SauvegarderEvaluation", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string SauvegarderEvaluation() {
            object[] results = this.Invoke("SauvegarderEvaluation", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSauvegarderEvaluation(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("SauvegarderEvaluation", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndSauvegarderEvaluation(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AffecterEvaluationAgent", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string AffecterEvaluationAgent() {
            object[] results = this.Invoke("AffecterEvaluationAgent", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAffecterEvaluationAgent(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AffecterEvaluationAgent", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndAffecterEvaluationAgent(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/BannirVendeur", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string BannirVendeur() {
            object[] results = this.Invoke("BannirVendeur", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginBannirVendeur(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("BannirVendeur", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndBannirVendeur(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/RecupererEncherissementGagnant", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public BO_EncherissementGagnant RecupererEncherissementGagnant(int idEnchere) {
            object[] results = this.Invoke("RecupererEncherissementGagnant", new object[] {
                        idEnchere});
            return ((BO_EncherissementGagnant)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginRecupererEncherissementGagnant(int idEnchere, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("RecupererEncherissementGagnant", new object[] {
                        idEnchere}, callback, asyncState);
        }
        
        /// <remarks/>
        public BO_EncherissementGagnant EndRecupererEncherissementGagnant(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((BO_EncherissementGagnant)(results[0]));
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BO_DemandeCreationEnchere {
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int IdUtilisateur_Vendeur;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string NomEnchere;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public decimal PrixMinimum;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string OptionTransport;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int Duree;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string TypeEnchere;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string Categorie;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string MotsCles;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string AutresInformations;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BO_Utilisateur {
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int IdUtilisateur;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string NomUtilisateur;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string Courriel;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BO_EncherissementGagnant {
        
        /// <remarks/>
        public BO_Encherissement Encherissement;
        
        /// <remarks/>
        public BO_Utilisateur Utilisateur_Vendeur;
        
        /// <remarks/>
        public BO_Utilisateur Utilisateur_EncherisseurGagnant;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BO_Encherissement {
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int IdUtilisateur_Encherisseur;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int IdEnchere;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public decimal OffreMaximale;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BO_Paiement {
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int IdEnchere;
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public string InfosPaiement;
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2556.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class BO_Enchere {
        
        /// <remarks/>
        [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute()]
        public int IdEnchere;
        
        /// <remarks/>
        public BO_DemandeCreationEnchere DemandeCreationEnchere;
    }
}
