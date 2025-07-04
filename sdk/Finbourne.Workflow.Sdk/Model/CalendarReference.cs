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
    /// Reference to a Calendar in LUSID
    /// </summary>
    [DataContract(Name = "CalendarReference")]
    public partial class CalendarReference : IEquatable<CalendarReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarReference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CalendarReference() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarReference" /> class.
        /// </summary>
        /// <param name="scope">The scope of the Calendar (required).</param>
        /// <param name="code">The code of the Calendar (required).</param>
        public CalendarReference(string scope = default(string), string code = default(string))
        {
            // to ensure "scope" is required (not null)
            if (scope == null)
            {
                throw new ArgumentNullException("scope is a required property for CalendarReference and cannot be null");
            }
            this.Scope = scope;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for CalendarReference and cannot be null");
            }
            this.Code = code;
        }

        /// <summary>
        /// The scope of the Calendar
        /// </summary>
        /// <value>The scope of the Calendar</value>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// The code of the Calendar
        /// </summary>
        /// <value>The code of the Calendar</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CalendarReference {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
            return this.Equals(input as CalendarReference);
        }

        /// <summary>
        /// Returns true if CalendarReference instances are equal
        /// </summary>
        /// <param name="input">Instance of CalendarReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CalendarReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                if (this.Scope != null)
                {
                    hashCode = (hashCode * 59) + this.Scope.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
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
            // Scope (string) maxLength
            if (this.Scope != null && this.Scope.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be less than 64.", new [] { "Scope" });
            }

            // Scope (string) minLength
            if (this.Scope != null && this.Scope.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, length must be greater than 1.", new [] { "Scope" });
            }

            // Scope (string) pattern
            Regex regexScope = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexScope.Match(this.Scope).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Scope, must match a pattern of " + regexScope, new [] { "Scope" });
            }

            // Code (string) maxLength
            if (this.Code != null && this.Code.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 64.", new [] { "Code" });
            }

            // Code (string) minLength
            if (this.Code != null && this.Code.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be greater than 1.", new [] { "Code" });
            }

            // Code (string) pattern
            Regex regexCode = new Regex(@"^[a-zA-Z0-9\-_]+$", RegexOptions.CultureInvariant);
            if (false == regexCode.Match(this.Code).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
            }

            yield break;
        }
    }
}
