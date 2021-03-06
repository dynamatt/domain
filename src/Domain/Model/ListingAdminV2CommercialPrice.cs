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
    /// Commercial component for price
    /// </summary>
    [DataContract]
        public partial class ListingAdminV2CommercialPrice :  IEquatable<ListingAdminV2CommercialPrice>, IValidatableObject
    {
        /// <summary>
        /// Price Unit type. Can have the values \&quot;TotalAmount\&quot;, \&quot;PerSqm\&quot;. Default &#x3D; \&quot;TotalAmount\&quot;
        /// </summary>
        /// <value>Price Unit type. Can have the values \&quot;TotalAmount\&quot;, \&quot;PerSqm\&quot;. Default &#x3D; \&quot;TotalAmount\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PriceUnitTypeEnum
        {
            /// <summary>
            /// Enum TotalAmount for value: totalAmount
            /// </summary>
            [EnumMember(Value = "totalAmount")]
            TotalAmount = 1,
            /// <summary>
            /// Enum PerSqm for value: perSqm
            /// </summary>
            [EnumMember(Value = "perSqm")]
            PerSqm = 2        }
        /// <summary>
        /// Price Unit type. Can have the values \&quot;TotalAmount\&quot;, \&quot;PerSqm\&quot;. Default &#x3D; \&quot;TotalAmount\&quot;
        /// </summary>
        /// <value>Price Unit type. Can have the values \&quot;TotalAmount\&quot;, \&quot;PerSqm\&quot;. Default &#x3D; \&quot;TotalAmount\&quot;</value>
        [DataMember(Name="priceUnitType", EmitDefaultValue=false)]
        public PriceUnitTypeEnum? PriceUnitType { get; set; }
        /// <summary>
        /// Type can have the values \&quot;Gross\&quot;, \&quot;Net\&quot;. Default \&quot;Net\&quot;
        /// </summary>
        /// <value>Type can have the values \&quot;Gross\&quot;, \&quot;Net\&quot;. Default \&quot;Net\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PriceTypeEnum
        {
            /// <summary>
            /// Enum Gross for value: gross
            /// </summary>
            [EnumMember(Value = "gross")]
            Gross = 1,
            /// <summary>
            /// Enum Net for value: net
            /// </summary>
            [EnumMember(Value = "net")]
            Net = 2        }
        /// <summary>
        /// Type can have the values \&quot;Gross\&quot;, \&quot;Net\&quot;. Default \&quot;Net\&quot;
        /// </summary>
        /// <value>Type can have the values \&quot;Gross\&quot;, \&quot;Net\&quot;. Default \&quot;Net\&quot;</value>
        [DataMember(Name="priceType", EmitDefaultValue=false)]
        public PriceTypeEnum? PriceType { get; set; }
        /// <summary>
        /// GST Option Type. Can have the values \&quot;NA\&quot;, \&quot;Inc\&quot;, \&quot;Ex\&quot;. Default &#x3D; \&quot;NA\&quot;
        /// </summary>
        /// <value>GST Option Type. Can have the values \&quot;NA\&quot;, \&quot;Inc\&quot;, \&quot;Ex\&quot;. Default &#x3D; \&quot;NA\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GstOptionTypeEnum
        {
            /// <summary>
            /// Enum NA for value: nA
            /// </summary>
            [EnumMember(Value = "nA")]
            NA = 1,
            /// <summary>
            /// Enum Inc for value: inc
            /// </summary>
            [EnumMember(Value = "inc")]
            Inc = 2,
            /// <summary>
            /// Enum Ex for value: ex
            /// </summary>
            [EnumMember(Value = "ex")]
            Ex = 3        }
        /// <summary>
        /// GST Option Type. Can have the values \&quot;NA\&quot;, \&quot;Inc\&quot;, \&quot;Ex\&quot;. Default &#x3D; \&quot;NA\&quot;
        /// </summary>
        /// <value>GST Option Type. Can have the values \&quot;NA\&quot;, \&quot;Inc\&quot;, \&quot;Ex\&quot;. Default &#x3D; \&quot;NA\&quot;</value>
        [DataMember(Name="gstOptionType", EmitDefaultValue=false)]
        public GstOptionTypeEnum? GstOptionType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2CommercialPrice" /> class.
        /// </summary>
        /// <param name="priceUnitType">Price Unit type. Can have the values \&quot;TotalAmount\&quot;, \&quot;PerSqm\&quot;. Default &#x3D; \&quot;TotalAmount\&quot;.</param>
        /// <param name="priceType">Type can have the values \&quot;Gross\&quot;, \&quot;Net\&quot;. Default \&quot;Net\&quot;.</param>
        /// <param name="gstOptionType">GST Option Type. Can have the values \&quot;NA\&quot;, \&quot;Inc\&quot;, \&quot;Ex\&quot;. Default &#x3D; \&quot;NA\&quot;.</param>
        /// <param name="priceReduction">Indicates if this property is under price reduction.</param>
        /// <param name="displayText">When provided this will be shown instead of the price range, e.g.: \&quot;Offers over $450K considered\&quot;.</param>
        /// <param name="from">Lowest price the property is expected to sell/rent for to set search price. For a fixed price, set this value the same as To (required).</param>
        /// <param name="to">Highest price the property is expected to sell/rent for to set search price.   For a fixed price, set this value the same as From (required).</param>
        public ListingAdminV2CommercialPrice(PriceUnitTypeEnum? priceUnitType = default(PriceUnitTypeEnum?), PriceTypeEnum? priceType = default(PriceTypeEnum?), GstOptionTypeEnum? gstOptionType = default(GstOptionTypeEnum?), bool? priceReduction = default(bool?), string displayText = default(string), int? from = default(int?), int? to = default(int?))
        {
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new InvalidDataException("from is a required property for ListingAdminV2CommercialPrice and cannot be null");
            }
            else
            {
                this.From = from;
            }
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new InvalidDataException("to is a required property for ListingAdminV2CommercialPrice and cannot be null");
            }
            else
            {
                this.To = to;
            }
            this.PriceUnitType = priceUnitType;
            this.PriceType = priceType;
            this.GstOptionType = gstOptionType;
            this.PriceReduction = priceReduction;
            this.DisplayText = displayText;
        }
        



        /// <summary>
        /// Indicates if this property is under price reduction
        /// </summary>
        /// <value>Indicates if this property is under price reduction</value>
        [DataMember(Name="priceReduction", EmitDefaultValue=false)]
        public bool? PriceReduction { get; set; }

        /// <summary>
        /// When provided this will be shown instead of the price range, e.g.: \&quot;Offers over $450K considered\&quot;
        /// </summary>
        /// <value>When provided this will be shown instead of the price range, e.g.: \&quot;Offers over $450K considered\&quot;</value>
        [DataMember(Name="displayText", EmitDefaultValue=false)]
        public string DisplayText { get; set; }

        /// <summary>
        /// Lowest price the property is expected to sell/rent for to set search price. For a fixed price, set this value the same as To
        /// </summary>
        /// <value>Lowest price the property is expected to sell/rent for to set search price. For a fixed price, set this value the same as To</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public int? From { get; set; }

        /// <summary>
        /// Highest price the property is expected to sell/rent for to set search price.   For a fixed price, set this value the same as From
        /// </summary>
        /// <value>Highest price the property is expected to sell/rent for to set search price.   For a fixed price, set this value the same as From</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public int? To { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2CommercialPrice {\n");
            sb.Append("  PriceUnitType: ").Append(PriceUnitType).Append("\n");
            sb.Append("  PriceType: ").Append(PriceType).Append("\n");
            sb.Append("  GstOptionType: ").Append(GstOptionType).Append("\n");
            sb.Append("  PriceReduction: ").Append(PriceReduction).Append("\n");
            sb.Append("  DisplayText: ").Append(DisplayText).Append("\n");
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
            return this.Equals(input as ListingAdminV2CommercialPrice);
        }

        /// <summary>
        /// Returns true if ListingAdminV2CommercialPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2CommercialPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2CommercialPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PriceUnitType == input.PriceUnitType ||
                    (this.PriceUnitType != null &&
                    this.PriceUnitType.Equals(input.PriceUnitType))
                ) && 
                (
                    this.PriceType == input.PriceType ||
                    (this.PriceType != null &&
                    this.PriceType.Equals(input.PriceType))
                ) && 
                (
                    this.GstOptionType == input.GstOptionType ||
                    (this.GstOptionType != null &&
                    this.GstOptionType.Equals(input.GstOptionType))
                ) && 
                (
                    this.PriceReduction == input.PriceReduction ||
                    (this.PriceReduction != null &&
                    this.PriceReduction.Equals(input.PriceReduction))
                ) && 
                (
                    this.DisplayText == input.DisplayText ||
                    (this.DisplayText != null &&
                    this.DisplayText.Equals(input.DisplayText))
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
                if (this.PriceUnitType != null)
                    hashCode = hashCode * 59 + this.PriceUnitType.GetHashCode();
                if (this.PriceType != null)
                    hashCode = hashCode * 59 + this.PriceType.GetHashCode();
                if (this.GstOptionType != null)
                    hashCode = hashCode * 59 + this.GstOptionType.GetHashCode();
                if (this.PriceReduction != null)
                    hashCode = hashCode * 59 + this.PriceReduction.GetHashCode();
                if (this.DisplayText != null)
                    hashCode = hashCode * 59 + this.DisplayText.GetHashCode();
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
