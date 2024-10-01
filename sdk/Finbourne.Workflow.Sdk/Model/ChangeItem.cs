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
    /// Defines a change that occured to a Task
    /// </summary>
    [DataContract(Name = "ChangeItem")]
    public partial class ChangeItem : IEquatable<ChangeItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeItem" /> class.
        /// </summary>
        /// <param name="asAtModified">The AsAt time of the change (required).</param>
        /// <param name="userIdModified">The User ID that performed the change (required).</param>
        /// <param name="requestIdModified">The Request ID of the request that caused the change (required).</param>
        /// <param name="asAtVersionNumber">The AsAt Version number (required).</param>
        /// <param name="action">The Action that resulted in the change (required).</param>
        /// <param name="attributeName">The name of the attribute that has been change (required).</param>
        /// <param name="previousValue">The value of the attribute prior to the change.</param>
        /// <param name="newValue">The value of the attribute following the change (required).</param>
        public ChangeItem(DateTimeOffset asAtModified = default(DateTimeOffset), string userIdModified = default(string), string requestIdModified = default(string), int asAtVersionNumber = default(int), string action = default(string), string attributeName = default(string), Object previousValue = default(Object), Object newValue = default(Object))
        {
            this.AsAtModified = asAtModified;
            // to ensure "userIdModified" is required (not null)
            if (userIdModified == null)
            {
                throw new ArgumentNullException("userIdModified is a required property for ChangeItem and cannot be null");
            }
            this.UserIdModified = userIdModified;
            // to ensure "requestIdModified" is required (not null)
            if (requestIdModified == null)
            {
                throw new ArgumentNullException("requestIdModified is a required property for ChangeItem and cannot be null");
            }
            this.RequestIdModified = requestIdModified;
            this.AsAtVersionNumber = asAtVersionNumber;
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new ArgumentNullException("action is a required property for ChangeItem and cannot be null");
            }
            this.Action = action;
            // to ensure "attributeName" is required (not null)
            if (attributeName == null)
            {
                throw new ArgumentNullException("attributeName is a required property for ChangeItem and cannot be null");
            }
            this.AttributeName = attributeName;
            // to ensure "newValue" is required (not null)
            if (newValue == null)
            {
                throw new ArgumentNullException("newValue is a required property for ChangeItem and cannot be null");
            }
            this.NewValue = newValue;
            this.PreviousValue = previousValue;
        }

        /// <summary>
        /// The AsAt time of the change
        /// </summary>
        /// <value>The AsAt time of the change</value>
        [DataMember(Name = "asAtModified", IsRequired = true, EmitDefaultValue = true)]
        public DateTimeOffset AsAtModified { get; set; }

        /// <summary>
        /// The User ID that performed the change
        /// </summary>
        /// <value>The User ID that performed the change</value>
        [DataMember(Name = "userIdModified", IsRequired = true, EmitDefaultValue = true)]
        public string UserIdModified { get; set; }

        /// <summary>
        /// The Request ID of the request that caused the change
        /// </summary>
        /// <value>The Request ID of the request that caused the change</value>
        [DataMember(Name = "requestIdModified", IsRequired = true, EmitDefaultValue = true)]
        public string RequestIdModified { get; set; }

        /// <summary>
        /// The AsAt Version number
        /// </summary>
        /// <value>The AsAt Version number</value>
        [DataMember(Name = "asAtVersionNumber", IsRequired = true, EmitDefaultValue = true)]
        public int AsAtVersionNumber { get; set; }

        /// <summary>
        /// The Action that resulted in the change
        /// </summary>
        /// <value>The Action that resulted in the change</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// The name of the attribute that has been change
        /// </summary>
        /// <value>The name of the attribute that has been change</value>
        [DataMember(Name = "attributeName", IsRequired = true, EmitDefaultValue = true)]
        public string AttributeName { get; set; }

        /// <summary>
        /// The value of the attribute prior to the change
        /// </summary>
        /// <value>The value of the attribute prior to the change</value>
        [DataMember(Name = "previousValue", EmitDefaultValue = true)]
        public Object PreviousValue { get; set; }

        /// <summary>
        /// The value of the attribute following the change
        /// </summary>
        /// <value>The value of the attribute following the change</value>
        [DataMember(Name = "newValue", IsRequired = true, EmitDefaultValue = true)]
        public Object NewValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChangeItem {\n");
            sb.Append("  AsAtModified: ").Append(AsAtModified).Append("\n");
            sb.Append("  UserIdModified: ").Append(UserIdModified).Append("\n");
            sb.Append("  RequestIdModified: ").Append(RequestIdModified).Append("\n");
            sb.Append("  AsAtVersionNumber: ").Append(AsAtVersionNumber).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AttributeName: ").Append(AttributeName).Append("\n");
            sb.Append("  PreviousValue: ").Append(PreviousValue).Append("\n");
            sb.Append("  NewValue: ").Append(NewValue).Append("\n");
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
            return this.Equals(input as ChangeItem);
        }

        /// <summary>
        /// Returns true if ChangeItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ChangeItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChangeItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.AsAtVersionNumber.Equals(input.AsAtVersionNumber)
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AttributeName == input.AttributeName ||
                    (this.AttributeName != null &&
                    this.AttributeName.Equals(input.AttributeName))
                ) && 
                (
                    this.PreviousValue == input.PreviousValue ||
                    (this.PreviousValue != null &&
                    this.PreviousValue.Equals(input.PreviousValue))
                ) && 
                (
                    this.NewValue == input.NewValue ||
                    (this.NewValue != null &&
                    this.NewValue.Equals(input.NewValue))
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
                hashCode = (hashCode * 59) + this.AsAtVersionNumber.GetHashCode();
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.AttributeName != null)
                {
                    hashCode = (hashCode * 59) + this.AttributeName.GetHashCode();
                }
                if (this.PreviousValue != null)
                {
                    hashCode = (hashCode * 59) + this.PreviousValue.GetHashCode();
                }
                if (this.NewValue != null)
                {
                    hashCode = (hashCode * 59) + this.NewValue.GetHashCode();
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
            // UserIdModified (string) minLength
            if (this.UserIdModified != null && this.UserIdModified.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserIdModified, length must be greater than 1.", new [] { "UserIdModified" });
            }

            // RequestIdModified (string) minLength
            if (this.RequestIdModified != null && this.RequestIdModified.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestIdModified, length must be greater than 1.", new [] { "RequestIdModified" });
            }

            // Action (string) minLength
            if (this.Action != null && this.Action.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Action, length must be greater than 1.", new [] { "Action" });
            }

            // AttributeName (string) minLength
            if (this.AttributeName != null && this.AttributeName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttributeName, length must be greater than 1.", new [] { "AttributeName" });
            }

            yield break;
        }
    }
}