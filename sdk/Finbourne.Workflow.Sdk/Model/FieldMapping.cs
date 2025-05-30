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
    /// Defines a single Field map
    /// </summary>
    [DataContract(Name = "FieldMapping")]
    public partial class FieldMapping : IEquatable<FieldMapping>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldMapping" /> class.
        /// </summary>
        /// <param name="mapFrom">The field to map from.</param>
        /// <param name="setTo">The (constant) value to set.</param>
        public FieldMapping(string mapFrom = default(string), Object setTo = default(Object))
        {
            this.MapFrom = mapFrom;
            this.SetTo = setTo;
        }

        /// <summary>
        /// The field to map from
        /// </summary>
        /// <value>The field to map from</value>
        [DataMember(Name = "mapFrom", EmitDefaultValue = true)]
        public string MapFrom { get; set; }

        /// <summary>
        /// The (constant) value to set
        /// </summary>
        /// <value>The (constant) value to set</value>
        [DataMember(Name = "setTo", EmitDefaultValue = true)]
        public Object SetTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FieldMapping {\n");
            sb.Append("  MapFrom: ").Append(MapFrom).Append("\n");
            sb.Append("  SetTo: ").Append(SetTo).Append("\n");
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
            return this.Equals(input as FieldMapping);
        }

        /// <summary>
        /// Returns true if FieldMapping instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldMapping to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldMapping input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MapFrom == input.MapFrom ||
                    (this.MapFrom != null &&
                    this.MapFrom.Equals(input.MapFrom))
                ) && 
                (
                    this.SetTo == input.SetTo ||
                    (this.SetTo != null &&
                    this.SetTo.Equals(input.SetTo))
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
                if (this.MapFrom != null)
                {
                    hashCode = (hashCode * 59) + this.MapFrom.GetHashCode();
                }
                if (this.SetTo != null)
                {
                    hashCode = (hashCode * 59) + this.SetTo.GetHashCode();
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
            // MapFrom (string) maxLength
            if (this.MapFrom != null && this.MapFrom.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MapFrom, length must be less than 1024.", new [] { "MapFrom" });
            }

            // MapFrom (string) minLength
            if (this.MapFrom != null && this.MapFrom.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MapFrom, length must be greater than 1.", new [] { "MapFrom" });
            }

            yield break;
        }
    }
}
