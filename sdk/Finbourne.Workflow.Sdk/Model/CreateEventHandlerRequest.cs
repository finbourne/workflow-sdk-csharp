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
    /// Contains information for creating an Event Handler
    /// </summary>
    [DataContract(Name = "CreateEventHandlerRequest")]
    public partial class CreateEventHandlerRequest : IEquatable<CreateEventHandlerRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventHandlerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateEventHandlerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEventHandlerRequest" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">Human readable name (required).</param>
        /// <param name="description">Human readable description.</param>
        /// <param name="status">The current status of the event handler (required).</param>
        /// <param name="eventMatchingPattern">eventMatchingPattern (required).</param>
        /// <param name="runAsUserId">runAsUserId (required).</param>
        /// <param name="taskDefinitionId">taskDefinitionId (required).</param>
        /// <param name="taskDefinitionAsAt">AsAt of the required task definition.</param>
        /// <param name="taskActivity">taskActivity (required).</param>
        public CreateEventHandlerRequest(ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), string status = default(string), EventMatchingPattern eventMatchingPattern = default(EventMatchingPattern), EventHandlerMapping runAsUserId = default(EventHandlerMapping), ResourceId taskDefinitionId = default(ResourceId), DateTimeOffset? taskDefinitionAsAt = default(DateTimeOffset?), TaskActivity taskActivity = default(TaskActivity))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for CreateEventHandlerRequest and cannot be null");
            }
            this.Id = id;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for CreateEventHandlerRequest and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for CreateEventHandlerRequest and cannot be null");
            }
            this.Status = status;
            // to ensure "eventMatchingPattern" is required (not null)
            if (eventMatchingPattern == null)
            {
                throw new ArgumentNullException("eventMatchingPattern is a required property for CreateEventHandlerRequest and cannot be null");
            }
            this.EventMatchingPattern = eventMatchingPattern;
            // to ensure "runAsUserId" is required (not null)
            if (runAsUserId == null)
            {
                throw new ArgumentNullException("runAsUserId is a required property for CreateEventHandlerRequest and cannot be null");
            }
            this.RunAsUserId = runAsUserId;
            // to ensure "taskDefinitionId" is required (not null)
            if (taskDefinitionId == null)
            {
                throw new ArgumentNullException("taskDefinitionId is a required property for CreateEventHandlerRequest and cannot be null");
            }
            this.TaskDefinitionId = taskDefinitionId;
            // to ensure "taskActivity" is required (not null)
            if (taskActivity == null)
            {
                throw new ArgumentNullException("taskActivity is a required property for CreateEventHandlerRequest and cannot be null");
            }
            this.TaskActivity = taskActivity;
            this.Description = description;
            this.TaskDefinitionAsAt = taskDefinitionAsAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Human readable name
        /// </summary>
        /// <value>Human readable name</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Human readable description
        /// </summary>
        /// <value>Human readable description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The current status of the event handler
        /// </summary>
        /// <value>The current status of the event handler</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets EventMatchingPattern
        /// </summary>
        [DataMember(Name = "eventMatchingPattern", IsRequired = true, EmitDefaultValue = true)]
        public EventMatchingPattern EventMatchingPattern { get; set; }

        /// <summary>
        /// Gets or Sets RunAsUserId
        /// </summary>
        [DataMember(Name = "runAsUserId", IsRequired = true, EmitDefaultValue = true)]
        public EventHandlerMapping RunAsUserId { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionId
        /// </summary>
        [DataMember(Name = "taskDefinitionId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId TaskDefinitionId { get; set; }

        /// <summary>
        /// AsAt of the required task definition
        /// </summary>
        /// <value>AsAt of the required task definition</value>
        [DataMember(Name = "taskDefinitionAsAt", EmitDefaultValue = true)]
        public DateTimeOffset? TaskDefinitionAsAt { get; set; }

        /// <summary>
        /// Gets or Sets TaskActivity
        /// </summary>
        [DataMember(Name = "taskActivity", IsRequired = true, EmitDefaultValue = true)]
        public TaskActivity TaskActivity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateEventHandlerRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  EventMatchingPattern: ").Append(EventMatchingPattern).Append("\n");
            sb.Append("  RunAsUserId: ").Append(RunAsUserId).Append("\n");
            sb.Append("  TaskDefinitionId: ").Append(TaskDefinitionId).Append("\n");
            sb.Append("  TaskDefinitionAsAt: ").Append(TaskDefinitionAsAt).Append("\n");
            sb.Append("  TaskActivity: ").Append(TaskActivity).Append("\n");
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
            return this.Equals(input as CreateEventHandlerRequest);
        }

        /// <summary>
        /// Returns true if CreateEventHandlerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateEventHandlerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateEventHandlerRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.EventMatchingPattern == input.EventMatchingPattern ||
                    (this.EventMatchingPattern != null &&
                    this.EventMatchingPattern.Equals(input.EventMatchingPattern))
                ) && 
                (
                    this.RunAsUserId == input.RunAsUserId ||
                    (this.RunAsUserId != null &&
                    this.RunAsUserId.Equals(input.RunAsUserId))
                ) && 
                (
                    this.TaskDefinitionId == input.TaskDefinitionId ||
                    (this.TaskDefinitionId != null &&
                    this.TaskDefinitionId.Equals(input.TaskDefinitionId))
                ) && 
                (
                    this.TaskDefinitionAsAt == input.TaskDefinitionAsAt ||
                    (this.TaskDefinitionAsAt != null &&
                    this.TaskDefinitionAsAt.Equals(input.TaskDefinitionAsAt))
                ) && 
                (
                    this.TaskActivity == input.TaskActivity ||
                    (this.TaskActivity != null &&
                    this.TaskActivity.Equals(input.TaskActivity))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.EventMatchingPattern != null)
                {
                    hashCode = (hashCode * 59) + this.EventMatchingPattern.GetHashCode();
                }
                if (this.RunAsUserId != null)
                {
                    hashCode = (hashCode * 59) + this.RunAsUserId.GetHashCode();
                }
                if (this.TaskDefinitionId != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionId.GetHashCode();
                }
                if (this.TaskDefinitionAsAt != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionAsAt.GetHashCode();
                }
                if (this.TaskActivity != null)
                {
                    hashCode = (hashCode * 59) + this.TaskActivity.GetHashCode();
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
            // DisplayName (string) minLength
            if (this.DisplayName != null && this.DisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DisplayName, length must be greater than 1.", new [] { "DisplayName" });
            }

            // Status (string) minLength
            if (this.Status != null && this.Status.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, length must be greater than 1.", new [] { "Status" });
            }

            yield break;
        }
    }
}
