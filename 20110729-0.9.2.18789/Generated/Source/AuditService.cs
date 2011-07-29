//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Audit.V1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Activities : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<Activity> items;
        
        private string kind;
        
        private string next;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>Each record in read response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Activity> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>Kind of list response this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Next page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("next")]
        public virtual string Next {
            get {
                return this.next;
            }
            set {
                this.next = value;
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
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
    
    public class Activity {
        
        private Activity.ActorData actor;
        
        private IList<Activity.EventsData> events;
        
        private Activity.IdData id;
        
        private string ipAddress;
        
        private string kind;
        
        private string ownerDomain;
        
        /// <summary>User doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Activity.ActorData Actor {
            get {
                return this.actor;
            }
            set {
                this.actor = value;
            }
        }
        
        /// <summary>Activity events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual IList<Activity.EventsData> Events {
            get {
                return this.events;
            }
            set {
                this.events = value;
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual Activity.IdData Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>IP Address of the user doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress {
            get {
                return this.ipAddress;
            }
            set {
                this.ipAddress = value;
            }
        }
        
        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Domain of source customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDomain")]
        public virtual string OwnerDomain {
            get {
                return this.ownerDomain;
            }
            set {
                this.ownerDomain = value;
            }
        }
        
        /// <summary>User doing the action.</summary>
        public class ActorData {
            
            private string applicationId;
            
            private string callerType;
            
            private string email;
            
            private string key;
            
            /// <summary>ID of application which interacted on behalf of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this.applicationId;
                }
                set {
                    this.applicationId = value;
                }
            }
            
            /// <summary>User or OAuth 2LO request.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("callerType")]
            public virtual string CallerType {
                get {
                    return this.callerType;
                }
                set {
                    this.callerType = value;
                }
            }
            
            /// <summary>Email address of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("email")]
            public virtual string Email {
                get {
                    return this.email;
                }
                set {
                    this.email = value;
                }
            }
            
            /// <summary>For OAuth 2LO API requests, consumer_key of the requestor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("key")]
            public virtual string Key {
                get {
                    return this.key;
                }
                set {
                    this.key = value;
                }
            }
        }
        
        public class EventsData {
            
            private string eventType;
            
            private string name;
            
            private IList<EventsData.ParametersData> parameters;
            
            /// <summary>Type of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
            public virtual string EventType {
                get {
                    return this.eventType;
                }
                set {
                    this.eventType = value;
                }
            }
            
            /// <summary>Name of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name {
                get {
                    return this.name;
                }
                set {
                    this.name = value;
                }
            }
            
            /// <summary>Event parameters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
            public virtual IList<EventsData.ParametersData> Parameters {
                get {
                    return this.parameters;
                }
                set {
                    this.parameters = value;
                }
            }
            
            public class ParametersData {
                
                private string name;
                
                private string value;
                
                /// <summary>Name of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("name")]
                public virtual string Name {
                    get {
                        return this.name;
                    }
                    set {
                        this.name = value;
                    }
                }
                
                /// <summary>Value of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value {
                    get {
                        return this.value;
                    }
                    set {
                        this.value = value;
                    }
                }
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        public class IdData {
            
            private string applicationId;
            
            private string customerId;
            
            private string time;
            
            private string uniqQualifier;
            
            /// <summary>Application ID of the source application.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this.applicationId;
                }
                set {
                    this.applicationId = value;
                }
            }
            
            /// <summary>Obfuscated customer ID of the source customer.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
            public virtual string CustomerId {
                get {
                    return this.customerId;
                }
                set {
                    this.customerId = value;
                }
            }
            
            /// <summary>Time of occurrence of the activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("time")]
            public virtual string Time {
                get {
                    return this.time;
                }
                set {
                    this.time = value;
                }
            }
            
            /// <summary>Unique qualifier if multiple events have the same time.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("uniqQualifier")]
            public virtual string UniqQualifier {
                get {
                    return this.uniqQualifier;
                }
                set {
                    this.uniqQualifier = value;
                }
            }
        }
    }
}
namespace Google.Apis.Audit.V1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class AuditService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string Version = "v1";
        
        private const string Name = "audit";
        
        private const string BaseUri = "https://www.googleapis.com/apps/reporting/audit/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string developerKey;
        
        private ActivitiesResource activities;
        
        public AuditService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.activities = new ActivitiesResource(this);
        }
        
        public AuditService() : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.CachedWebDiscoveryDevice(new System.Uri(string.Format("https://www.googleapis.com/discovery/v1/apis/{0}/{1}/rest", AuditService.Name, AuditService.Version)))).GetService(AuditService.Version, AuditService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(AuditService.BaseUri))), Google.Apis.Authentication.AuthenticatorFactory.GetInstance().GetRegisteredAuthenticator()) {
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
        
        public virtual ActivitiesResource Activities {
            get {
                return this.activities;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(DeveloperKey)) {
                request = request.WithDeveloperKey(this.DeveloperKey);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class ActivitiesResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "activities";
        
        private log4net.ILog logger = log4net.LogManager.GetLogger(typeof(ActivitiesResource));
        
        public ActivitiesResource(AuditService service) {
            this.service = service;
        }
        
        /// <summary>Retrieves a list of activities for a specific customer and application.</summary>
        /// <param name="customerId">Required - Must match pattern C.+ - Represents the customer who is the owner of target object on which action was performed.</param>
        /// <param name="applicationId">Required - Minimum value of -9223372036854775808 - Maximum value of 9223372036854775807 - Application ID of the application on which the event was performed.</param>
        public virtual ListRequest List(string customerId, long applicationId) {
            return new ListRequest(service, customerId, applicationId);
        }
        
        /// <summary>Retrieves a list of activities for a specific customer and application.</summary>
        /// <param name="customerId">Required - Must match pattern C.+ - Represents the customer who is the owner of target object on which action was performed.</param>
        /// <param name="applicationId">Required - Minimum value of -9223372036854775808 - Maximum value of 9223372036854775807 - Application ID of the application on which the event was performed.</param>
        /// <param name="actorEmail">Optional - Email address of the user who performed the action.</param>
        /// <param name="caller">Optional - Must be one of the following values [application_owner, customer] - Type of the caller.</param>
        /// <param name="continuationToken">Optional - Next page URL.</param>
        /// <param name="endTime">Optional - Return events which occured at or before this time.</param>
        /// <param name="eventName">Optional - Name of the event being queried.</param>
        /// <param name="maxResults">Optional - Minimum value of 1 - Maximum value of 1000 - Number of activity records to be shown in each page.</param>
        /// <param name="parameters">Optional - Event parameters in the form
        ///:
        ///.</param>
        /// <param name="startTime">Optional - Return events which occured at or after this time.</param>
        public virtual ListRequest List(string customerId, long applicationId, [System.Runtime.InteropServices.OptionalAttribute()] string actorEmail, [System.Runtime.InteropServices.OptionalAttribute()] Caller? caller, [System.Runtime.InteropServices.OptionalAttribute()] string continuationToken, [System.Runtime.InteropServices.OptionalAttribute()] string endTime, [System.Runtime.InteropServices.OptionalAttribute()] string eventName, [System.Runtime.InteropServices.OptionalAttribute()] System.Int64? maxResults, [System.Runtime.InteropServices.OptionalAttribute()] string parameters, [System.Runtime.InteropServices.OptionalAttribute()] string startTime) {
            return new ListRequest(service, customerId, applicationId, actorEmail, caller, continuationToken, endTime, eventName, maxResults, parameters, startTime);
        }
        
        /// <summary>Type of the caller.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Caller {
            
            /// <summary>Caller is an application owner.</summary>
            [Google.Apis.Util.StringValueAttribute("application_owner")]
            Application_owner,
            
            /// <summary>Caller is a customer.</summary>
            [Google.Apis.Util.StringValueAttribute("customer")]
            Customer,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Audit.V1.Data.Activities> {
            
            private string actorEmail;
            
            private long applicationId;
            
            private Caller? caller;
            
            private string continuationToken;
            
            private string customerId;
            
            private string endTime;
            
            private string eventName;
            
            private System.Int64? maxResults;
            
            private string parameters;
            
            private string startTime;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, string customerId, long applicationId) : 
                    base(service) {
                this.customerId = customerId;
                this.applicationId = applicationId;
            }
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, string customerId, long applicationId, [System.Runtime.InteropServices.OptionalAttribute()] string actorEmail, [System.Runtime.InteropServices.OptionalAttribute()] Caller? caller, [System.Runtime.InteropServices.OptionalAttribute()] string continuationToken, [System.Runtime.InteropServices.OptionalAttribute()] string endTime, [System.Runtime.InteropServices.OptionalAttribute()] string eventName, [System.Runtime.InteropServices.OptionalAttribute()] System.Int64? maxResults, [System.Runtime.InteropServices.OptionalAttribute()] string parameters, [System.Runtime.InteropServices.OptionalAttribute()] string startTime) : 
                    base(service) {
                this.customerId = customerId;
                this.applicationId = applicationId;
                this.actorEmail = actorEmail;
                this.caller = caller;
                this.continuationToken = continuationToken;
                this.endTime = endTime;
                this.eventName = eventName;
                this.maxResults = maxResults;
                this.parameters = parameters;
                this.startTime = startTime;
            }
            
            /// <summary>Email address of the user who performed the action.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorEmail")]
            public virtual string ActorEmail {
                get {
                    return this.actorEmail;
                }
                set {
                    this.actorEmail = value;
                }
            }
            
            /// <summary>Application ID of the application on which the event was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId")]
            public virtual long ApplicationId {
                get {
                    return this.applicationId;
                }
            }
            
            /// <summary>Type of the caller.</summary>
            [Google.Apis.Util.RequestParameterAttribute("caller")]
            public virtual Caller? Caller {
                get {
                    return this.caller;
                }
                set {
                    this.caller = value;
                }
            }
            
            /// <summary>Next page URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("continuationToken")]
            public virtual string ContinuationToken {
                get {
                    return this.continuationToken;
                }
                set {
                    this.continuationToken = value;
                }
            }
            
            /// <summary>Represents the customer who is the owner of target object on which action was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId")]
            public virtual string CustomerId {
                get {
                    return this.customerId;
                }
            }
            
            /// <summary>Return events which occured at or before this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endTime")]
            public virtual string EndTime {
                get {
                    return this.endTime;
                }
                set {
                    this.endTime = value;
                }
            }
            
            /// <summary>Name of the event being queried.</summary>
            [Google.Apis.Util.RequestParameterAttribute("eventName")]
            public virtual string EventName {
                get {
                    return this.eventName;
                }
                set {
                    this.eventName = value;
                }
            }
            
            /// <summary>Number of activity records to be shown in each page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults")]
            public virtual System.Int64? MaxResults {
                get {
                    return this.maxResults;
                }
                set {
                    this.maxResults = value;
                }
            }
            
            /// <summary>Event parameters in the form
            ///:
            ///.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parameters")]
            public virtual string Parameters {
                get {
                    return this.parameters;
                }
                set {
                    this.parameters = value;
                }
            }
            
            /// <summary>Return events which occured at or after this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startTime")]
            public virtual string StartTime {
                get {
                    return this.startTime;
                }
                set {
                    this.startTime = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "activities";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
}
