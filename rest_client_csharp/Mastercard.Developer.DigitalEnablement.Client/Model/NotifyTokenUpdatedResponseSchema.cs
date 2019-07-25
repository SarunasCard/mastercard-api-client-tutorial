/* 
 * MDES for Merchants
 *
 * The MDES APIs are designed as RPC style stateless web services where each API endpoint represents an operation to be performed.  All request and response payloads are sent in the JSON (JavaScript Object Notation) data-interchange format. Each endpoint in the API specifies the HTTP Method used to access it. All strings in request and response objects are to be UTF-8 encoded.  Each API URI includes the major and minor version of API that it conforms to.  This will allow multiple concurrent versions of the API to be deployed simultaneously.  
 *
 * The version of the OpenAPI document: 1.2.7
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Mastercard.Developer.DigitalEnablement.Client.Client.OpenAPIDateConverter;

namespace Mastercard.Developer.DigitalEnablement.Client.Model
{
    /// <summary>
    /// NotifyTokenUpdatedResponseSchema
    /// </summary>
    [DataContract]
    public partial class NotifyTokenUpdatedResponseSchema :  IEquatable<NotifyTokenUpdatedResponseSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotifyTokenUpdatedResponseSchema" /> class.
        /// </summary>
        /// <param name="responseHost">The host that originated the request. Future calls in the same conversation may be routed to this host. .</param>
        /// <param name="responseId">Unique identifier for the response. .</param>
        public NotifyTokenUpdatedResponseSchema(string responseHost = default(string), string responseId = default(string))
        {
            this.ResponseHost = responseHost;
            this.ResponseId = responseId;
        }
        
        /// <summary>
        /// The host that originated the request. Future calls in the same conversation may be routed to this host. 
        /// </summary>
        /// <value>The host that originated the request. Future calls in the same conversation may be routed to this host. </value>
        [DataMember(Name="responseHost", EmitDefaultValue=false)]
        public string ResponseHost { get; set; }

        /// <summary>
        /// Unique identifier for the response. 
        /// </summary>
        /// <value>Unique identifier for the response. </value>
        [DataMember(Name="responseId", EmitDefaultValue=false)]
        public string ResponseId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NotifyTokenUpdatedResponseSchema {\n");
            sb.Append("  ResponseHost: ").Append(ResponseHost).Append("\n");
            sb.Append("  ResponseId: ").Append(ResponseId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as NotifyTokenUpdatedResponseSchema);
        }

        /// <summary>
        /// Returns true if NotifyTokenUpdatedResponseSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of NotifyTokenUpdatedResponseSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotifyTokenUpdatedResponseSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResponseHost == input.ResponseHost ||
                    (this.ResponseHost != null &&
                    this.ResponseHost.Equals(input.ResponseHost))
                ) && 
                (
                    this.ResponseId == input.ResponseId ||
                    (this.ResponseId != null &&
                    this.ResponseId.Equals(input.ResponseId))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ResponseHost != null)
                    hashCode = hashCode * 59 + this.ResponseHost.GetHashCode();
                if (this.ResponseId != null)
                    hashCode = hashCode * 59 + this.ResponseId.GetHashCode();
                return hashCode;
            }
        }
    }

}
