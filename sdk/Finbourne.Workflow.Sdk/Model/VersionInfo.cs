/*
 * FINBOURNE Workflow API
 *
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Finbourne.Workflow.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Workflow.Sdk.Model
{
    /// <summary>
    /// The version metadata.
    /// </summary>
    [DataContract(Name = "VersionInfo")]
    public partial class VersionInfo : IEquatable<VersionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VersionInfo" /> class.
        /// </summary>
        /// <param name="asAtCreated">The asAt datetime at which this entity was first created..</param>
        /// <param name="userIdCreated">The unique id of the user who created this entity..</param>
        /// <param name="requestIdCreated">The request id of the request that created this entity..</param>
        /// <param name="asAtModified">The asAt datetime at which this entity was last updated..</param>
        /// <param name="userIdModified">The unique id of the user who last updated this entity..</param>
        /// <param name="requestIdModified">The request id of the request that last updated this entity..</param>
        /// <param name="asAtVersionNumber">The integer version number for this entity (the entity was created at version 1)..</param>
        public VersionInfo(DateTimeOffset? asAtCreated = default(DateTimeOffset?), string userIdCreated = default(string), string requestIdCreated = default(string), DateTimeOffset? asAtModified = default(DateTimeOffset?), string userIdModified = default(string), string requestIdModified = default(string), int? asAtVersionNumber = default(int?))
        {
            this.AsAtCreated = asAtCreated;
            this.UserIdCreated = userIdCreated;
            this.RequestIdCreated = requestIdCreated;
            this.AsAtModified = asAtModified;
            this.UserIdModified = userIdModified;
            this.RequestIdModified = requestIdModified;
            this.AsAtVersionNumber = asAtVersionNumber;
        }

        /// <summary>
        /// The asAt datetime at which this entity was first created.
        /// </summary>
        /// <value>The asAt datetime at which this entity was first created.</value>
        [DataMember(Name = "asAtCreated", EmitDefaultValue = true)]
        public DateTimeOffset? AsAtCreated { get; set; }

        /// <summary>
        /// The unique id of the user who created this entity.
        /// </summary>
        /// <value>The unique id of the user who created this entity.</value>
        [DataMember(Name = "userIdCreated", EmitDefaultValue = true)]
        public string UserIdCreated { get; set; }

        /// <summary>
        /// The request id of the request that created this entity.
        /// </summary>
        /// <value>The request id of the request that created this entity.</value>
        [DataMember(Name = "requestIdCreated", EmitDefaultValue = true)]
        public string RequestIdCreated { get; set; }

        /// <summary>
        /// The asAt datetime at which this entity was last updated.
        /// </summary>
        /// <value>The asAt datetime at which this entity was last updated.</value>
        [DataMember(Name = "asAtModified", EmitDefaultValue = true)]
        public DateTimeOffset? AsAtModified { get; set; }

        /// <summary>
        /// The unique id of the user who last updated this entity.
        /// </summary>
        /// <value>The unique id of the user who last updated this entity.</value>
        [DataMember(Name = "userIdModified", EmitDefaultValue = true)]
        public string UserIdModified { get; set; }

        /// <summary>
        /// The request id of the request that last updated this entity.
        /// </summary>
        /// <value>The request id of the request that last updated this entity.</value>
        [DataMember(Name = "requestIdModified", EmitDefaultValue = true)]
        public string RequestIdModified { get; set; }

        /// <summary>
        /// The integer version number for this entity (the entity was created at version 1).
        /// </summary>
        /// <value>The integer version number for this entity (the entity was created at version 1).</value>
        [DataMember(Name = "asAtVersionNumber", EmitDefaultValue = true)]
        public int? AsAtVersionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VersionInfo {\n");
            sb.Append("  AsAtCreated: ").Append(AsAtCreated).Append("\n");
            sb.Append("  UserIdCreated: ").Append(UserIdCreated).Append("\n");
            sb.Append("  RequestIdCreated: ").Append(RequestIdCreated).Append("\n");
            sb.Append("  AsAtModified: ").Append(AsAtModified).Append("\n");
            sb.Append("  UserIdModified: ").Append(UserIdModified).Append("\n");
            sb.Append("  RequestIdModified: ").Append(RequestIdModified).Append("\n");
            sb.Append("  AsAtVersionNumber: ").Append(AsAtVersionNumber).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as VersionInfo);
        }

        /// <summary>
        /// Returns true if VersionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VersionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VersionInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AsAtCreated == input.AsAtCreated ||
                    (this.AsAtCreated != null &&
                    this.AsAtCreated.Equals(input.AsAtCreated))
                ) && 
                (
                    this.UserIdCreated == input.UserIdCreated ||
                    (this.UserIdCreated != null &&
                    this.UserIdCreated.Equals(input.UserIdCreated))
                ) && 
                (
                    this.RequestIdCreated == input.RequestIdCreated ||
                    (this.RequestIdCreated != null &&
                    this.RequestIdCreated.Equals(input.RequestIdCreated))
                ) && 
                (
                    this.AsAtModified == input.AsAtModified ||
                    (this.AsAtModified != null &&
                    this.AsAtModified.Equals(input.AsAtModified))
                ) && 
                (
                    this.UserIdModified == input.UserIdModified ||
                    (this.UserIdModified != null &&
                    this.UserIdModified.Equals(input.UserIdModified))
                ) && 
                (
                    this.RequestIdModified == input.RequestIdModified ||
                    (this.RequestIdModified != null &&
                    this.RequestIdModified.Equals(input.RequestIdModified))
                ) && 
                (
                    this.AsAtVersionNumber == input.AsAtVersionNumber ||
                    (this.AsAtVersionNumber != null &&
                    this.AsAtVersionNumber.Equals(input.AsAtVersionNumber))
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
                if (this.AsAtCreated != null)
                {
                    hashCode = (hashCode * 59) + this.AsAtCreated.GetHashCode();
                }
                if (this.UserIdCreated != null)
                {
                    hashCode = (hashCode * 59) + this.UserIdCreated.GetHashCode();
                }
                if (this.RequestIdCreated != null)
                {
                    hashCode = (hashCode * 59) + this.RequestIdCreated.GetHashCode();
                }
                if (this.AsAtModified != null)
                {
                    hashCode = (hashCode * 59) + this.AsAtModified.GetHashCode();
                }
                if (this.UserIdModified != null)
                {
                    hashCode = (hashCode * 59) + this.UserIdModified.GetHashCode();
                }
                if (this.RequestIdModified != null)
                {
                    hashCode = (hashCode * 59) + this.RequestIdModified.GetHashCode();
                }
                if (this.AsAtVersionNumber != null)
                {
                    hashCode = (hashCode * 59) + this.AsAtVersionNumber.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
