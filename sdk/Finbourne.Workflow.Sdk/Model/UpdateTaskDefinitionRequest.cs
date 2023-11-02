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
    /// Contains required info to update a Task Definition
    /// </summary>
    [DataContract(Name = "UpdateTaskDefinitionRequest")]
    public partial class UpdateTaskDefinitionRequest : IEquatable<UpdateTaskDefinitionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTaskDefinitionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateTaskDefinitionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTaskDefinitionRequest" /> class.
        /// </summary>
        /// <param name="displayName">Human readable name (required).</param>
        /// <param name="description">Human readable description.</param>
        /// <param name="states">The states this Task Definition operates over (required).</param>
        /// <param name="fieldSchema">Defines the fields associated with this Task.</param>
        /// <param name="initialState">initialState (required).</param>
        /// <param name="triggers">Triggers.</param>
        /// <param name="transitions">Transitions.</param>
        /// <param name="actions">Actions.</param>
        public UpdateTaskDefinitionRequest(string displayName = default(string), string description = default(string), List<TaskStateDefinition> states = default(List<TaskStateDefinition>), List<TaskFieldDefinition> fieldSchema = default(List<TaskFieldDefinition>), InitialState initialState = default(InitialState), List<TransitionTriggerDefinition> triggers = default(List<TransitionTriggerDefinition>), List<TaskTransitionDefinition> transitions = default(List<TaskTransitionDefinition>), List<ActionDefinition> actions = default(List<ActionDefinition>))
        {
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for UpdateTaskDefinitionRequest and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "states" is required (not null)
            if (states == null)
            {
                throw new ArgumentNullException("states is a required property for UpdateTaskDefinitionRequest and cannot be null");
            }
            this.States = states;
            // to ensure "initialState" is required (not null)
            if (initialState == null)
            {
                throw new ArgumentNullException("initialState is a required property for UpdateTaskDefinitionRequest and cannot be null");
            }
            this.InitialState = initialState;
            this.Description = description;
            this.FieldSchema = fieldSchema;
            this.Triggers = triggers;
            this.Transitions = transitions;
            this.Actions = actions;
        }

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
        /// The states this Task Definition operates over
        /// </summary>
        /// <value>The states this Task Definition operates over</value>
        [DataMember(Name = "states", IsRequired = true, EmitDefaultValue = true)]
        public List<TaskStateDefinition> States { get; set; }

        /// <summary>
        /// Defines the fields associated with this Task
        /// </summary>
        /// <value>Defines the fields associated with this Task</value>
        [DataMember(Name = "fieldSchema", EmitDefaultValue = true)]
        public List<TaskFieldDefinition> FieldSchema { get; set; }

        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [DataMember(Name = "initialState", IsRequired = true, EmitDefaultValue = true)]
        public InitialState InitialState { get; set; }

        /// <summary>
        /// Triggers
        /// </summary>
        /// <value>Triggers</value>
        [DataMember(Name = "triggers", EmitDefaultValue = true)]
        public List<TransitionTriggerDefinition> Triggers { get; set; }

        /// <summary>
        /// Transitions
        /// </summary>
        /// <value>Transitions</value>
        [DataMember(Name = "transitions", EmitDefaultValue = true)]
        public List<TaskTransitionDefinition> Transitions { get; set; }

        /// <summary>
        /// Actions
        /// </summary>
        /// <value>Actions</value>
        [DataMember(Name = "actions", EmitDefaultValue = true)]
        public List<ActionDefinition> Actions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateTaskDefinitionRequest {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  FieldSchema: ").Append(FieldSchema).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  Transitions: ").Append(Transitions).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
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
            return this.Equals(input as UpdateTaskDefinitionRequest);
        }

        /// <summary>
        /// Returns true if UpdateTaskDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTaskDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTaskDefinitionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.FieldSchema == input.FieldSchema ||
                    this.FieldSchema != null &&
                    input.FieldSchema != null &&
                    this.FieldSchema.SequenceEqual(input.FieldSchema)
                ) && 
                (
                    this.InitialState == input.InitialState ||
                    (this.InitialState != null &&
                    this.InitialState.Equals(input.InitialState))
                ) && 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.Transitions == input.Transitions ||
                    this.Transitions != null &&
                    input.Transitions != null &&
                    this.Transitions.SequenceEqual(input.Transitions)
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
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
                if (this.DisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.States != null)
                {
                    hashCode = (hashCode * 59) + this.States.GetHashCode();
                }
                if (this.FieldSchema != null)
                {
                    hashCode = (hashCode * 59) + this.FieldSchema.GetHashCode();
                }
                if (this.InitialState != null)
                {
                    hashCode = (hashCode * 59) + this.InitialState.GetHashCode();
                }
                if (this.Triggers != null)
                {
                    hashCode = (hashCode * 59) + this.Triggers.GetHashCode();
                }
                if (this.Transitions != null)
                {
                    hashCode = (hashCode * 59) + this.Transitions.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
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

            yield break;
        }
    }
}
