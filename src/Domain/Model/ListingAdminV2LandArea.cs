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
    /// Area information, Either single value or from and To must be provided
    /// </summary>
    [DataContract]
        public partial class ListingAdminV2LandArea :  IEquatable<ListingAdminV2LandArea>, IValidatableObject
    {
        /// <summary>
        /// Unit of measure
        /// </summary>
        /// <value>Unit of measure</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum UnitEnum
        {
            /// <summary>
            /// Enum SquareMetres for value: squareMetres
            /// </summary>
            [EnumMember(Value = "squareMetres")]
            SquareMetres = 1,
            /// <summary>
            /// Enum Acres for value: acres
            /// </summary>
            [EnumMember(Value = "acres")]
            Acres = 2,
            /// <summary>
            /// Enum Hectares for value: hectares
            /// </summary>
            [EnumMember(Value = "hectares")]
            Hectares = 3,
            /// <summary>
            /// Enum SquareFeet for value: squareFeet
            /// </summary>
            [EnumMember(Value = "squareFeet")]
            SquareFeet = 4,
            /// <summary>
            /// Enum SquareYards for value: squareYards
            /// </summary>
            [EnumMember(Value = "squareYards")]
            SquareYards = 5,
            /// <summary>
            /// Enum Squares for value: squares
            /// </summary>
            [EnumMember(Value = "squares")]
            Squares = 6        }
        /// <summary>
        /// Unit of measure
        /// </summary>
        /// <value>Unit of measure</value>
        [DataMember(Name="unit", EmitDefaultValue=false)]
        public UnitEnum Unit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2LandArea" /> class.
        /// </summary>
        /// <param name="unit">Unit of measure (required).</param>
        /// <param name="value">Area. Will be rounded to 2 decimals..</param>
        /// <param name="from">Minimum area.</param>
        /// <param name="to">Maximum area.</param>
        public ListingAdminV2LandArea(UnitEnum unit = default(UnitEnum), double? value = default(double?), double? from = default(double?), double? to = default(double?))
        {
            // to ensure "unit" is required (not null)
            if (unit == null)
            {
                throw new InvalidDataException("unit is a required property for ListingAdminV2LandArea and cannot be null");
            }
            else
            {
                this.Unit = unit;
            }
            this.Value = value;
            this.From = from;
            this.To = to;
        }
        

        /// <summary>
        /// Area. Will be rounded to 2 decimals.
        /// </summary>
        /// <value>Area. Will be rounded to 2 decimals.</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public double? Value { get; set; }

        /// <summary>
        /// Minimum area
        /// </summary>
        /// <value>Minimum area</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public double? From { get; set; }

        /// <summary>
        /// Maximum area
        /// </summary>
        /// <value>Maximum area</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public double? To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2LandArea {\n");
            sb.Append("  Unit: ").Append(Unit).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
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
            return this.Equals(input as ListingAdminV2LandArea);
        }

        /// <summary>
        /// Returns true if ListingAdminV2LandArea instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2LandArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2LandArea input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Unit == input.Unit ||
                    (this.Unit != null &&
                    this.Unit.Equals(input.Unit))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
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
                if (this.Unit != null)
                    hashCode = hashCode * 59 + this.Unit.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
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