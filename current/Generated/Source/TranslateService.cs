//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Translate.V2.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class DetectionsListResponse : Google.Apis.Requests.IResponse {
        
        private IList<DetectionsResource> detections;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>A detections contains detection results of several text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual IList<DetectionsResource> Detections {
            get {
                return this.detections;
            }
            set {
                this.detections = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
    }
    
    /// <summary>An array of languages which we detect for the given text The most likely language list first.</summary>
    public class DetectionsResource : List<DetectionsResource.Entry> {
        
        public class Entry {
            
            private double confidence;
            
            private bool isReliable;
            
            private string language;
            
            /// <summary>The confidence of the detection resul of this language.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("confidence")]
            public virtual double Confidence {
                get {
                    return this.confidence;
                }
                set {
                    this.confidence = value;
                }
            }
            
            /// <summary>A boolean to indicate is the language detection result reliable.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("isReliable")]
            public virtual bool IsReliable {
                get {
                    return this.isReliable;
                }
                set {
                    this.isReliable = value;
                }
            }
            
            /// <summary>The language we detect</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("language")]
            public virtual string Language {
                get {
                    return this.language;
                }
                set {
                    this.language = value;
                }
            }
        }
    }
    
    public class LanguagesListResponse : Google.Apis.Requests.IResponse {
        
        private IList<LanguagesResource> languages;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>List of source/target languages supported by the translation API. If target parameter is unspecified, the list is sorted by the ASCII code point order of the language code. If target parameter is specified, the list is sorted by the collation order of the language name in the target language.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("languages")]
        public virtual IList<LanguagesResource> Languages {
            get {
                return this.languages;
            }
            set {
                this.languages = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
    }
    
    public class LanguagesResource {
        
        private string language;
        
        private string name;
        
        /// <summary>The language code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("language")]
        public virtual string Language {
            get {
                return this.language;
            }
            set {
                this.language = value;
            }
        }
        
        /// <summary>The localized name of the language if target parameter is given.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name {
            get {
                return this.name;
            }
            set {
                this.name = value;
            }
        }
    }
    
    public class TranslationsListResponse : Google.Apis.Requests.IResponse {
        
        private IList<TranslationsResource> translations;
        
        private Google.Apis.Requests.RequestError error;
        
        /// <summary>Translations contains list of translation results of given text</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translations")]
        public virtual IList<TranslationsResource> Translations {
            get {
                return this.translations;
            }
            set {
                this.translations = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
    }
    
    public class TranslationsResource {
        
        private string detectedSourceLanguage;
        
        private string translatedText;
        
        /// <summary>Detected source language if source parameter is unspecified.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detectedSourceLanguage")]
        public virtual string DetectedSourceLanguage {
            get {
                return this.detectedSourceLanguage;
            }
            set {
                this.detectedSourceLanguage = value;
            }
        }
        
        /// <summary>The translation.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("translatedText")]
        public virtual string TranslatedText {
            get {
                return this.translatedText;
            }
            set {
                this.translatedText = value;
            }
        }
    }
}
namespace Google.Apis.Translate.V2 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class TranslateService : Google.Apis.Discovery.IRequestExecutor, Google.Apis.Discovery.ISchemaAwareRequestExecutor {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v2";
        
        private const string Name = "translate";
        
        private const string BaseUri = "https://www.googleapis.com/language/translate/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private DetectionsResource detections;
        
        private LanguagesResource languages;
        
        private TranslationsResource translations;
        
        public TranslateService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.detections = new DetectionsResource(this);
            this.languages = new LanguagesResource(this);
            this.translations = new TranslationsResource(this);
        }
        
        public TranslateService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.WebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", TranslateService.Name, TranslateService.Version)))).GetService(TranslateService.Version, TranslateService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(TranslateService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
        }
        
        /// <summary>Sets the DeveloperKey which this service uses for all requests</summary>
        public virtual string DeveloperKey {
            get {
                return this.developerKey;
            }
            set {
                this.developerKey = value;
            }
        }
        
        public virtual DetectionsResource Detections {
            get {
                return this.detections;
            }
        }
        
        public virtual LanguagesResource Languages {
            get {
                return this.languages;
            }
        }
        
        public virtual TranslationsResource Translations {
            get {
                return this.translations;
            }
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, string body, System.Collections.Generic.IDictionary<string, object> parameters) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (string.IsNullOrEmpty(DeveloperKey) == false) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithParameters(parameters).WithAuthentication(authenticator).WithBody(body).ExecuteRequest();
        }
        
        public virtual System.IO.Stream ExecuteRequest(string resource, string method, object body, System.Collections.Generic.IDictionary<string, object> parameters) {
            return this.ExecuteRequest(resource, method, this.ObjectToJson(body), parameters);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string ObjectToJson(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T JsonToObject<T>(System.IO.Stream stream)
         {
            return genericService.DeserializeResponse<T>(stream);
        }
    }
    
    public class DetectionsResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "detections";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(DetectionsResource));
        
        public DetectionsResource(TranslateService service) {
            this.service = service;
        }
        
        /// <summary>Detect the language of text.</summary>
        /// <param name="q">Required - The text to detect</param>
        public virtual System.IO.Stream ListAsStream(Google.Apis.Util.Repeatable<string> q) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["q"] = q;
            logger.Debug("Executing detections.list");
            System.IO.Stream ret = this.service.ExecuteRequest(DetectionsResource.Resource, "list", body, parameters);
            logger.Debug("Done Executing detections.list");
            return ret;
        }
        
        /// <summary>Detect the language of text.</summary>
        /// <param name="q">Required - The text to detect</param>
        public virtual Google.Apis.Translate.V2.Data.DetectionsListResponse List(Google.Apis.Util.Repeatable<string> q) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["q"] = q;
            logger.Debug("Executing detections.list");
            Google.Apis.Translate.V2.Data.DetectionsListResponse ret = this.service.JsonToObject<Google.Apis.Translate.V2.Data.DetectionsListResponse>(this.service.ExecuteRequest(DetectionsResource.Resource, "list", body, parameters));
            logger.Debug("Done Executing detections.list");
            return ret;
        }
    }
    
    public class LanguagesResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "languages";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(LanguagesResource));
        
        public LanguagesResource(TranslateService service) {
            this.service = service;
        }
        
        /// <summary>List the source/target languages supported by the API</summary>
        /// <param name="target">Optional - the language and collation in which the localized results should be returned</param>
        public virtual System.IO.Stream ListAsStream(string target) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["target"] = target;
            logger.Debug("Executing languages.list");
            System.IO.Stream ret = this.service.ExecuteRequest(LanguagesResource.Resource, "list", body, parameters);
            logger.Debug("Done Executing languages.list");
            return ret;
        }
        
        /// <summary>List the source/target languages supported by the API</summary>
        /// <param name="target">Optional - the language and collation in which the localized results should be returned</param>
        public virtual Google.Apis.Translate.V2.Data.LanguagesListResponse List(string target) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["target"] = target;
            logger.Debug("Executing languages.list");
            Google.Apis.Translate.V2.Data.LanguagesListResponse ret = this.service.JsonToObject<Google.Apis.Translate.V2.Data.LanguagesListResponse>(this.service.ExecuteRequest(LanguagesResource.Resource, "list", body, parameters));
            logger.Debug("Done Executing languages.list");
            return ret;
        }
    }
    
    public class TranslationsResource {
        
        private Google.Apis.Discovery.ISchemaAwareRequestExecutor service;
        
        private const string Resource = "translations";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(TranslationsResource));
        
        public TranslationsResource(TranslateService service) {
            this.service = service;
        }
        
        /// <summary>Returns text translations from one language to another.</summary>
        /// <param name="q">Required - The text to translate</param>
        /// <param name="target">Required - The target language into which the text should be translated</param>
        /// <param name="cid">Optional - The customization id for translate</param>
        /// <param name="format">Optional - Must be one of the following values [html, text] - The format of the text</param>
        /// <param name="source">Optional - The source language of the text</param>
        public virtual System.IO.Stream ListAsStream(Google.Apis.Util.Repeatable<string> q, string target, Google.Apis.Util.Repeatable<string> cid, Format? format, string source) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["q"] = q;
            parameters["target"] = target;
            parameters["cid"] = cid;
            parameters["format"] = format;
            parameters["source"] = source;
            logger.Debug("Executing translations.list");
            System.IO.Stream ret = this.service.ExecuteRequest(TranslationsResource.Resource, "list", body, parameters);
            logger.Debug("Done Executing translations.list");
            return ret;
        }
        
        /// <summary>Returns text translations from one language to another.</summary>
        /// <param name="q">Required - The text to translate</param>
        /// <param name="target">Required - The target language into which the text should be translated</param>
        /// <param name="cid">Optional - The customization id for translate</param>
        /// <param name="format">Optional - Must be one of the following values [html, text] - The format of the text</param>
        /// <param name="source">Optional - The source language of the text</param>
        public virtual Google.Apis.Translate.V2.Data.TranslationsListResponse List(Google.Apis.Util.Repeatable<string> q, string target, Google.Apis.Util.Repeatable<string> cid, Format? format, string source) {
            string body = null;
            System.Collections.Generic.Dictionary<string, object> parameters = new System.Collections.Generic.Dictionary<string, object>();
            parameters["q"] = q;
            parameters["target"] = target;
            parameters["cid"] = cid;
            parameters["format"] = format;
            parameters["source"] = source;
            logger.Debug("Executing translations.list");
            Google.Apis.Translate.V2.Data.TranslationsListResponse ret = this.service.JsonToObject<Google.Apis.Translate.V2.Data.TranslationsListResponse>(this.service.ExecuteRequest(TranslationsResource.Resource, "list", body, parameters));
            logger.Debug("Done Executing translations.list");
            return ret;
        }
        
        /// <summary>The format of the text</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Format {
            
            /// <summary>Specifies the input is in HTML</summary>
            [Google.Apis.Util.StringValueAttribute("html")]
            Html,
            
            /// <summary>Specifies the input is in plain textual format</summary>
            [Google.Apis.Util.StringValueAttribute("text")]
            Text,
        }
    }
}
