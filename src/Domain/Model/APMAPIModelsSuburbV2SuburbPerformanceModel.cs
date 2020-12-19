/* 
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * OpenAPI spec version: v2
 * Contact: api@domain.com.au
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Domain.Client.SwaggerDateConverter;

namespace Domain.Model
{
    /// <summary>
    /// APMAPIModelsSuburbV2SuburbPerformanceModel
    /// </summary>
    [DataContract]
        public partial class APMAPIModelsSuburbV2SuburbPerformanceModel :  IEquatable<APMAPIModelsSuburbV2SuburbPerformanceModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="APMAPIModelsSuburbV2SuburbPerformanceModel" /> class.
        /// </summary>
        /// <param name="header">header.</param>
        /// <param name="series">series.</param>
        public APMAPIModelsSuburbV2SuburbPerformanceModel(APMAPIModelsSuburbV2SeriesHeaderModel header = default(APMAPIModelsSuburbV2SeriesHeaderModel), APMAPIModelsSuburbV2SeriesModel series = default(APMAPIModelsSuburbV2SeriesModel))
        {
            this.Header = header;
            this.Series = series;
        }
        
        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name="header", EmitDefaultValue=false)]
        public APMAPIModelsSuburbV2SeriesHeaderModel Header { get; set; }

        /// <summary>
        /// Gets or Sets Series
        /// </summary>
        [DataMember(Name="series", EmitDefaultValue=false)]
        public APMAPIModelsSuburbV2SeriesModel Series { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APMAPIModelsSuburbV2SuburbPerformanceModel {\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Series: ").Append(Series).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as APMAPIModelsSuburbV2SuburbPerformanceModel);
        }

        /// <summary>
        /// Returns true if APMAPIModelsSuburbV2SuburbPerformanceModel instances are equal
        /// </summary>
        /// <param name="input">Instance of APMAPIModelsSuburbV2SuburbPerformanceModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APMAPIModelsSuburbV2SuburbPerformanceModel input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Header == input.Header ||
                    (this.Header != null &&
                    this.Header.Equals(input.Header))
                ) && 
                (
                    this.Series == input.Series ||
                    (this.Series != null &&
                    this.Series.Equals(input.Series))
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
                if (this.Header != null)
                    hashCode = hashCode * 59 + this.Header.GetHashCode();
                if (this.Series != null)
                    hashCode = hashCode * 59 + this.Series.GetHashCode();
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