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
using System.Reflection;

namespace Finbourne.Workflow.Sdk.Model
{
    /// <summary>
    /// Abstracts the kinds of Actions available
    /// </summary>
    [JsonConverter(typeof(ActionDetailsJsonConverter))]
    [DataContract(Name = "ActionDetails")]
    public partial class ActionDetails : AbstractOpenAPISchema, IEquatable<ActionDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDetails" /> class
        /// with the <see cref="CreateChildTasksAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CreateChildTasksAction.</param>
        public ActionDetails(CreateChildTasksAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDetails" /> class
        /// with the <see cref="RunWorkerAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RunWorkerAction.</param>
        public ActionDetails(RunWorkerAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionDetails" /> class
        /// with the <see cref="TriggerParentTaskAction" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TriggerParentTaskAction.</param>
        public ActionDetails(TriggerParentTaskAction actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(CreateChildTasksAction) || value is CreateChildTasksAction)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RunWorkerAction) || value is RunWorkerAction)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TriggerParentTaskAction) || value is TriggerParentTaskAction)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: CreateChildTasksAction, RunWorkerAction, TriggerParentTaskAction");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CreateChildTasksAction`. If the actual instance is not `CreateChildTasksAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CreateChildTasksAction</returns>
        public CreateChildTasksAction GetCreateChildTasksAction()
        {
            return (CreateChildTasksAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RunWorkerAction`. If the actual instance is not `RunWorkerAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RunWorkerAction</returns>
        public RunWorkerAction GetRunWorkerAction()
        {
            return (RunWorkerAction)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TriggerParentTaskAction`. If the actual instance is not `TriggerParentTaskAction`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TriggerParentTaskAction</returns>
        public TriggerParentTaskAction GetTriggerParentTaskAction()
        {
            return (TriggerParentTaskAction)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ActionDetails {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, ActionDetails.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of ActionDetails
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of ActionDetails</returns>
        public static ActionDetails FromJson(string jsonString)
        {
            ActionDetails newActionDetails = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newActionDetails;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CreateChildTasksAction).GetProperty("AdditionalProperties") == null)
                {
                    newActionDetails = new ActionDetails(JsonConvert.DeserializeObject<CreateChildTasksAction>(jsonString, ActionDetails.SerializerSettings));
                }
                else
                {
                    newActionDetails = new ActionDetails(JsonConvert.DeserializeObject<CreateChildTasksAction>(jsonString, ActionDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("CreateChildTasksAction");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CreateChildTasksAction: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RunWorkerAction).GetProperty("AdditionalProperties") == null)
                {
                    newActionDetails = new ActionDetails(JsonConvert.DeserializeObject<RunWorkerAction>(jsonString, ActionDetails.SerializerSettings));
                }
                else
                {
                    newActionDetails = new ActionDetails(JsonConvert.DeserializeObject<RunWorkerAction>(jsonString, ActionDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RunWorkerAction");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RunWorkerAction: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TriggerParentTaskAction).GetProperty("AdditionalProperties") == null)
                {
                    newActionDetails = new ActionDetails(JsonConvert.DeserializeObject<TriggerParentTaskAction>(jsonString, ActionDetails.SerializerSettings));
                }
                else
                {
                    newActionDetails = new ActionDetails(JsonConvert.DeserializeObject<TriggerParentTaskAction>(jsonString, ActionDetails.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TriggerParentTaskAction");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TriggerParentTaskAction: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newActionDetails;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ActionDetails);
        }

        /// <summary>
        /// Returns true if ActionDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ActionDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActionDetails input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for ActionDetails
    /// </summary>
    public class ActionDetailsJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(ActionDetails).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return ActionDetails.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return ActionDetails.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
