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
    /// A Date Regularity
    /// </summary>
    [JsonConverter(typeof(DateRegularityJsonConverter))]
    [DataContract(Name = "DateRegularity")]
    public partial class DateRegularity : AbstractOpenAPISchema, IEquatable<DateRegularity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRegularity" /> class
        /// with the <see cref="DayRegularity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of DayRegularity.</param>
        public DateRegularity(DayRegularity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRegularity" /> class
        /// with the <see cref="RelativeMonthRegularity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of RelativeMonthRegularity.</param>
        public DateRegularity(RelativeMonthRegularity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRegularity" /> class
        /// with the <see cref="SpecificMonthRegularity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of SpecificMonthRegularity.</param>
        public DateRegularity(SpecificMonthRegularity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRegularity" /> class
        /// with the <see cref="WeekRegularity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of WeekRegularity.</param>
        public DateRegularity(WeekRegularity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DateRegularity" /> class
        /// with the <see cref="YearRegularity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of YearRegularity.</param>
        public DateRegularity(YearRegularity actualInstance)
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
                if (value.GetType() == typeof(DayRegularity) || value is DayRegularity)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(RelativeMonthRegularity) || value is RelativeMonthRegularity)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(SpecificMonthRegularity) || value is SpecificMonthRegularity)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(WeekRegularity) || value is WeekRegularity)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(YearRegularity) || value is YearRegularity)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: DayRegularity, RelativeMonthRegularity, SpecificMonthRegularity, WeekRegularity, YearRegularity");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `DayRegularity`. If the actual instance is not `DayRegularity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of DayRegularity</returns>
        public DayRegularity GetDayRegularity()
        {
            return (DayRegularity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `RelativeMonthRegularity`. If the actual instance is not `RelativeMonthRegularity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of RelativeMonthRegularity</returns>
        public RelativeMonthRegularity GetRelativeMonthRegularity()
        {
            return (RelativeMonthRegularity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `SpecificMonthRegularity`. If the actual instance is not `SpecificMonthRegularity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of SpecificMonthRegularity</returns>
        public SpecificMonthRegularity GetSpecificMonthRegularity()
        {
            return (SpecificMonthRegularity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `WeekRegularity`. If the actual instance is not `WeekRegularity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of WeekRegularity</returns>
        public WeekRegularity GetWeekRegularity()
        {
            return (WeekRegularity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `YearRegularity`. If the actual instance is not `YearRegularity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of YearRegularity</returns>
        public YearRegularity GetYearRegularity()
        {
            return (YearRegularity)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DateRegularity {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, DateRegularity.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of DateRegularity
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of DateRegularity</returns>
        public static DateRegularity FromJson(string jsonString)
        {
            DateRegularity newDateRegularity = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newDateRegularity;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(DayRegularity).GetProperty("AdditionalProperties") == null)
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<DayRegularity>(jsonString, DateRegularity.SerializerSettings));
                }
                else
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<DayRegularity>(jsonString, DateRegularity.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("DayRegularity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into DayRegularity: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(RelativeMonthRegularity).GetProperty("AdditionalProperties") == null)
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<RelativeMonthRegularity>(jsonString, DateRegularity.SerializerSettings));
                }
                else
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<RelativeMonthRegularity>(jsonString, DateRegularity.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("RelativeMonthRegularity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into RelativeMonthRegularity: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(SpecificMonthRegularity).GetProperty("AdditionalProperties") == null)
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<SpecificMonthRegularity>(jsonString, DateRegularity.SerializerSettings));
                }
                else
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<SpecificMonthRegularity>(jsonString, DateRegularity.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("SpecificMonthRegularity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into SpecificMonthRegularity: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(WeekRegularity).GetProperty("AdditionalProperties") == null)
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<WeekRegularity>(jsonString, DateRegularity.SerializerSettings));
                }
                else
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<WeekRegularity>(jsonString, DateRegularity.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("WeekRegularity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into WeekRegularity: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(YearRegularity).GetProperty("AdditionalProperties") == null)
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<YearRegularity>(jsonString, DateRegularity.SerializerSettings));
                }
                else
                {
                    newDateRegularity = new DateRegularity(JsonConvert.DeserializeObject<YearRegularity>(jsonString, DateRegularity.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("YearRegularity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into YearRegularity: {1}", jsonString, exception.ToString()));
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
            return newDateRegularity;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DateRegularity);
        }

        /// <summary>
        /// Returns true if DateRegularity instances are equal
        /// </summary>
        /// <param name="input">Instance of DateRegularity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateRegularity input)
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
    /// Custom JSON converter for DateRegularity
    /// </summary>
    public class DateRegularityJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(DateRegularity).GetMethod("ToJson").Invoke(value, null)));
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
                    return DateRegularity.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return DateRegularity.FromJson(JArray.Load(reader).ToString(Formatting.None));
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
