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
    /// Defines a Task created based on a Task Definition
    /// </summary>
    [DataContract(Name = "Task")]
    public partial class Task : IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Task() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id">The unique id for this Task (required).</param>
        /// <param name="taskDefinitionId">taskDefinitionId (required).</param>
        /// <param name="taskDefinitionVersion">taskDefinitionVersion (required).</param>
        /// <param name="taskDefinitionDisplayName">The display name of the Task Definition used by this Task (required).</param>
        /// <param name="state">Current State (required).</param>
        /// <param name="ultimateParentTask">ultimateParentTask (required).</param>
        /// <param name="parentTask">parentTask.</param>
        /// <param name="childTasks">This Task&#39;s child tasks.</param>
        /// <param name="correlationIds">User-provided ID used to link entities and tasks.</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="terminalState">True if no onward transitions are possible (required).</param>
        /// <param name="asAtLastTransition">Last Transition timestamp.</param>
        /// <param name="fields">Fields and their latest values - should correspond with the Task Definition field schema.</param>
        /// <param name="stackingKey">The key used to determine which stack to add the Task to.</param>
        /// <param name="stack">stack.</param>
        /// <param name="actionLogIdCreated">The Id of the Action that created this Task.</param>
        /// <param name="actionLogIdModified">The Id of the Action that last modified this Task.</param>
        /// <param name="actionLogIdSubmitted">The Id of the last Action submitted by this Task.</param>
        public Task(Guid id = default(Guid), ResourceId taskDefinitionId = default(ResourceId), TaskDefinitionVersion taskDefinitionVersion = default(TaskDefinitionVersion), string taskDefinitionDisplayName = default(string), string state = default(string), TaskSummary ultimateParentTask = default(TaskSummary), TaskSummary parentTask = default(TaskSummary), List<TaskSummary> childTasks = default(List<TaskSummary>), List<string> correlationIds = default(List<string>), VersionInfo varVersion = default(VersionInfo), bool terminalState = default(bool), DateTimeOffset? asAtLastTransition = default(DateTimeOffset?), List<TaskInstanceField> fields = default(List<TaskInstanceField>), string stackingKey = default(string), Stack stack = default(Stack), Guid? actionLogIdCreated = default(Guid?), Guid? actionLogIdModified = default(Guid?), Guid? actionLogIdSubmitted = default(Guid?))
        {
            this.Id = id;
            // to ensure "taskDefinitionId" is required (not null)
            if (taskDefinitionId == null)
            {
                throw new ArgumentNullException("taskDefinitionId is a required property for Task and cannot be null");
            }
            this.TaskDefinitionId = taskDefinitionId;
            // to ensure "taskDefinitionVersion" is required (not null)
            if (taskDefinitionVersion == null)
            {
                throw new ArgumentNullException("taskDefinitionVersion is a required property for Task and cannot be null");
            }
            this.TaskDefinitionVersion = taskDefinitionVersion;
            // to ensure "taskDefinitionDisplayName" is required (not null)
            if (taskDefinitionDisplayName == null)
            {
                throw new ArgumentNullException("taskDefinitionDisplayName is a required property for Task and cannot be null");
            }
            this.TaskDefinitionDisplayName = taskDefinitionDisplayName;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for Task and cannot be null");
            }
            this.State = state;
            // to ensure "ultimateParentTask" is required (not null)
            if (ultimateParentTask == null)
            {
                throw new ArgumentNullException("ultimateParentTask is a required property for Task and cannot be null");
            }
            this.UltimateParentTask = ultimateParentTask;
            this.TerminalState = terminalState;
            this.ParentTask = parentTask;
            this.ChildTasks = childTasks;
            this.CorrelationIds = correlationIds;
            this.VarVersion = varVersion;
            this.AsAtLastTransition = asAtLastTransition;
            this.Fields = fields;
            this.StackingKey = stackingKey;
            this.Stack = stack;
            this.ActionLogIdCreated = actionLogIdCreated;
            this.ActionLogIdModified = actionLogIdModified;
            this.ActionLogIdSubmitted = actionLogIdSubmitted;
        }

        /// <summary>
        /// The unique id for this Task
        /// </summary>
        /// <value>The unique id for this Task</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionId
        /// </summary>
        [DataMember(Name = "taskDefinitionId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId TaskDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionVersion
        /// </summary>
        [DataMember(Name = "taskDefinitionVersion", IsRequired = true, EmitDefaultValue = true)]
        public TaskDefinitionVersion TaskDefinitionVersion { get; set; }

        /// <summary>
        /// The display name of the Task Definition used by this Task
        /// </summary>
        /// <value>The display name of the Task Definition used by this Task</value>
        [DataMember(Name = "taskDefinitionDisplayName", IsRequired = true, EmitDefaultValue = true)]
        public string TaskDefinitionDisplayName { get; set; }

        /// <summary>
        /// Current State
        /// </summary>
        /// <value>Current State</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets UltimateParentTask
        /// </summary>
        [DataMember(Name = "ultimateParentTask", IsRequired = true, EmitDefaultValue = true)]
        public TaskSummary UltimateParentTask { get; set; }

        /// <summary>
        /// Gets or Sets ParentTask
        /// </summary>
        [DataMember(Name = "parentTask", EmitDefaultValue = false)]
        public TaskSummary ParentTask { get; set; }

        /// <summary>
        /// This Task&#39;s child tasks
        /// </summary>
        /// <value>This Task&#39;s child tasks</value>
        [DataMember(Name = "childTasks", EmitDefaultValue = true)]
        public List<TaskSummary> ChildTasks { get; set; }

        /// <summary>
        /// User-provided ID used to link entities and tasks
        /// </summary>
        /// <value>User-provided ID used to link entities and tasks</value>
        [DataMember(Name = "correlationIds", EmitDefaultValue = true)]
        public List<string> CorrelationIds { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public VersionInfo VarVersion { get; set; }

        /// <summary>
        /// True if no onward transitions are possible
        /// </summary>
        /// <value>True if no onward transitions are possible</value>
        [DataMember(Name = "terminalState", IsRequired = true, EmitDefaultValue = true)]
        public bool TerminalState { get; set; }

        /// <summary>
        /// Last Transition timestamp
        /// </summary>
        /// <value>Last Transition timestamp</value>
        [DataMember(Name = "asAtLastTransition", EmitDefaultValue = true)]
        public DateTimeOffset? AsAtLastTransition { get; set; }

        /// <summary>
        /// Fields and their latest values - should correspond with the Task Definition field schema
        /// </summary>
        /// <value>Fields and their latest values - should correspond with the Task Definition field schema</value>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<TaskInstanceField> Fields { get; set; }

        /// <summary>
        /// The key used to determine which stack to add the Task to
        /// </summary>
        /// <value>The key used to determine which stack to add the Task to</value>
        [DataMember(Name = "stackingKey", EmitDefaultValue = true)]
        public string StackingKey { get; set; }

        /// <summary>
        /// Gets or Sets Stack
        /// </summary>
        [DataMember(Name = "stack", EmitDefaultValue = false)]
        public Stack Stack { get; set; }

        /// <summary>
        /// The Id of the Action that created this Task
        /// </summary>
        /// <value>The Id of the Action that created this Task</value>
        [DataMember(Name = "actionLogIdCreated", EmitDefaultValue = true)]
        public Guid? ActionLogIdCreated { get; set; }

        /// <summary>
        /// The Id of the Action that last modified this Task
        /// </summary>
        /// <value>The Id of the Action that last modified this Task</value>
        [DataMember(Name = "actionLogIdModified", EmitDefaultValue = true)]
        public Guid? ActionLogIdModified { get; set; }

        /// <summary>
        /// The Id of the last Action submitted by this Task
        /// </summary>
        /// <value>The Id of the last Action submitted by this Task</value>
        [DataMember(Name = "actionLogIdSubmitted", EmitDefaultValue = true)]
        public Guid? ActionLogIdSubmitted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskDefinitionId: ").Append(TaskDefinitionId).Append("\n");
            sb.Append("  TaskDefinitionVersion: ").Append(TaskDefinitionVersion).Append("\n");
            sb.Append("  TaskDefinitionDisplayName: ").Append(TaskDefinitionDisplayName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UltimateParentTask: ").Append(UltimateParentTask).Append("\n");
            sb.Append("  ParentTask: ").Append(ParentTask).Append("\n");
            sb.Append("  ChildTasks: ").Append(ChildTasks).Append("\n");
            sb.Append("  CorrelationIds: ").Append(CorrelationIds).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  TerminalState: ").Append(TerminalState).Append("\n");
            sb.Append("  AsAtLastTransition: ").Append(AsAtLastTransition).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  StackingKey: ").Append(StackingKey).Append("\n");
            sb.Append("  Stack: ").Append(Stack).Append("\n");
            sb.Append("  ActionLogIdCreated: ").Append(ActionLogIdCreated).Append("\n");
            sb.Append("  ActionLogIdModified: ").Append(ActionLogIdModified).Append("\n");
            sb.Append("  ActionLogIdSubmitted: ").Append(ActionLogIdSubmitted).Append("\n");
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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
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
                    this.TaskDefinitionId == input.TaskDefinitionId ||
                    (this.TaskDefinitionId != null &&
                    this.TaskDefinitionId.Equals(input.TaskDefinitionId))
                ) && 
                (
                    this.TaskDefinitionVersion == input.TaskDefinitionVersion ||
                    (this.TaskDefinitionVersion != null &&
                    this.TaskDefinitionVersion.Equals(input.TaskDefinitionVersion))
                ) && 
                (
                    this.TaskDefinitionDisplayName == input.TaskDefinitionDisplayName ||
                    (this.TaskDefinitionDisplayName != null &&
                    this.TaskDefinitionDisplayName.Equals(input.TaskDefinitionDisplayName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.UltimateParentTask == input.UltimateParentTask ||
                    (this.UltimateParentTask != null &&
                    this.UltimateParentTask.Equals(input.UltimateParentTask))
                ) && 
                (
                    this.ParentTask == input.ParentTask ||
                    (this.ParentTask != null &&
                    this.ParentTask.Equals(input.ParentTask))
                ) && 
                (
                    this.ChildTasks == input.ChildTasks ||
                    this.ChildTasks != null &&
                    input.ChildTasks != null &&
                    this.ChildTasks.SequenceEqual(input.ChildTasks)
                ) && 
                (
                    this.CorrelationIds == input.CorrelationIds ||
                    this.CorrelationIds != null &&
                    input.CorrelationIds != null &&
                    this.CorrelationIds.SequenceEqual(input.CorrelationIds)
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
                ) && 
                (
                    this.TerminalState == input.TerminalState ||
                    this.TerminalState.Equals(input.TerminalState)
                ) && 
                (
                    this.AsAtLastTransition == input.AsAtLastTransition ||
                    (this.AsAtLastTransition != null &&
                    this.AsAtLastTransition.Equals(input.AsAtLastTransition))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.StackingKey == input.StackingKey ||
                    (this.StackingKey != null &&
                    this.StackingKey.Equals(input.StackingKey))
                ) && 
                (
                    this.Stack == input.Stack ||
                    (this.Stack != null &&
                    this.Stack.Equals(input.Stack))
                ) && 
                (
                    this.ActionLogIdCreated == input.ActionLogIdCreated ||
                    (this.ActionLogIdCreated != null &&
                    this.ActionLogIdCreated.Equals(input.ActionLogIdCreated))
                ) && 
                (
                    this.ActionLogIdModified == input.ActionLogIdModified ||
                    (this.ActionLogIdModified != null &&
                    this.ActionLogIdModified.Equals(input.ActionLogIdModified))
                ) && 
                (
                    this.ActionLogIdSubmitted == input.ActionLogIdSubmitted ||
                    (this.ActionLogIdSubmitted != null &&
                    this.ActionLogIdSubmitted.Equals(input.ActionLogIdSubmitted))
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
                if (this.TaskDefinitionId != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionId.GetHashCode();
                }
                if (this.TaskDefinitionVersion != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionVersion.GetHashCode();
                }
                if (this.TaskDefinitionDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionDisplayName.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.UltimateParentTask != null)
                {
                    hashCode = (hashCode * 59) + this.UltimateParentTask.GetHashCode();
                }
                if (this.ParentTask != null)
                {
                    hashCode = (hashCode * 59) + this.ParentTask.GetHashCode();
                }
                if (this.ChildTasks != null)
                {
                    hashCode = (hashCode * 59) + this.ChildTasks.GetHashCode();
                }
                if (this.CorrelationIds != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationIds.GetHashCode();
                }
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TerminalState.GetHashCode();
                if (this.AsAtLastTransition != null)
                {
                    hashCode = (hashCode * 59) + this.AsAtLastTransition.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.StackingKey != null)
                {
                    hashCode = (hashCode * 59) + this.StackingKey.GetHashCode();
                }
                if (this.Stack != null)
                {
                    hashCode = (hashCode * 59) + this.Stack.GetHashCode();
                }
                if (this.ActionLogIdCreated != null)
                {
                    hashCode = (hashCode * 59) + this.ActionLogIdCreated.GetHashCode();
                }
                if (this.ActionLogIdModified != null)
                {
                    hashCode = (hashCode * 59) + this.ActionLogIdModified.GetHashCode();
                }
                if (this.ActionLogIdSubmitted != null)
                {
                    hashCode = (hashCode * 59) + this.ActionLogIdSubmitted.GetHashCode();
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
            // TaskDefinitionDisplayName (string) minLength
            if (this.TaskDefinitionDisplayName != null && this.TaskDefinitionDisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaskDefinitionDisplayName, length must be greater than 1.", new [] { "TaskDefinitionDisplayName" });
            }

            // State (string) minLength
            if (this.State != null && this.State.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be greater than 1.", new [] { "State" });
            }

            yield break;
        }
    }
}
