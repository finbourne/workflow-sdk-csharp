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
    /// Information about the Worker
    /// </summary>
    [DataContract(Name = "Worker")]
    public partial class Worker : IEquatable<Worker>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Worker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Worker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Worker" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">Human readable name (required).</param>
        /// <param name="description">Human readable description.</param>
        /// <param name="workerConfiguration">workerConfiguration (required).</param>
        /// <param name="varVersion">varVersion.</param>
        /// <param name="parameters">The Parameters this Worker accepts or requires..</param>
        /// <param name="resultFields">The Fields that the Worker results will come back with..</param>
        /// <param name="links">links.</param>
        public Worker(ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), WorkerConfigurationResponse workerConfiguration = default(WorkerConfigurationResponse), VersionInfo varVersion = default(VersionInfo), List<Parameter> parameters = default(List<Parameter>), List<ResultField> resultFields = default(List<ResultField>), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Worker and cannot be null");
            }
            this.Id = id;
            // to ensure "displayName" is required (not null)
            if (displayName == null)
            {
                throw new ArgumentNullException("displayName is a required property for Worker and cannot be null");
            }
            this.DisplayName = displayName;
            // to ensure "workerConfiguration" is required (not null)
            if (workerConfiguration == null)
            {
                throw new ArgumentNullException("workerConfiguration is a required property for Worker and cannot be null");
            }
            this.WorkerConfiguration = workerConfiguration;
            this.Description = description;
            this.VarVersion = varVersion;
            this.Parameters = parameters;
            this.ResultFields = resultFields;
            this.Links = links;
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
        /// Gets or Sets WorkerConfiguration
        /// </summary>
        [DataMember(Name = "workerConfiguration", IsRequired = true, EmitDefaultValue = true)]
        public WorkerConfigurationResponse WorkerConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets VarVersion
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public VersionInfo VarVersion { get; set; }

        /// <summary>
        /// The Parameters this Worker accepts or requires.
        /// </summary>
        /// <value>The Parameters this Worker accepts or requires.</value>
        [DataMember(Name = "parameters", EmitDefaultValue = true)]
        public List<Parameter> Parameters { get; set; }

        /// <summary>
        /// The Fields that the Worker results will come back with.
        /// </summary>
        /// <value>The Fields that the Worker results will come back with.</value>
        [DataMember(Name = "resultFields", EmitDefaultValue = true)]
        public List<ResultField> ResultFields { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Worker {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WorkerConfiguration: ").Append(WorkerConfiguration).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
            sb.Append("  ResultFields: ").Append(ResultFields).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as Worker);
        }

        /// <summary>
        /// Returns true if Worker instances are equal
        /// </summary>
        /// <param name="input">Instance of Worker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Worker input)
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
                    this.WorkerConfiguration == input.WorkerConfiguration ||
                    (this.WorkerConfiguration != null &&
                    this.WorkerConfiguration.Equals(input.WorkerConfiguration))
                ) && 
                (
                    this.VarVersion == input.VarVersion ||
                    (this.VarVersion != null &&
                    this.VarVersion.Equals(input.VarVersion))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    input.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
                ) && 
                (
                    this.ResultFields == input.ResultFields ||
                    this.ResultFields != null &&
                    input.ResultFields != null &&
                    this.ResultFields.SequenceEqual(input.ResultFields)
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.WorkerConfiguration != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerConfiguration.GetHashCode();
                }
                if (this.VarVersion != null)
                {
                    hashCode = (hashCode * 59) + this.VarVersion.GetHashCode();
                }
                if (this.Parameters != null)
                {
                    hashCode = (hashCode * 59) + this.Parameters.GetHashCode();
                }
                if (this.ResultFields != null)
                {
                    hashCode = (hashCode * 59) + this.ResultFields.GetHashCode();
                }
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
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
