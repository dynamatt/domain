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
    /// Sold Details
    /// </summary>
    [DataContract]
        public partial class ListingAdminV2SoldDetails :  IEquatable<ListingAdminV2SoldDetails>, IValidatableObject
    {
        /// <summary>
        /// Sold Type
        /// </summary>
        /// <value>Sold Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum SoldTypeEnum
        {
            /// <summary>
            /// Enum Auction for value: auction
            /// </summary>
            [EnumMember(Value = "auction")]
            Auction = 1,
            /// <summary>
            /// Enum PrivateTreaty for value: privateTreaty
            /// </summary>
            [EnumMember(Value = "privateTreaty")]
            PrivateTreaty = 2,
            /// <summary>
            /// Enum PriorToAuction for value: priorToAuction
            /// </summary>
            [EnumMember(Value = "priorToAuction")]
            PriorToAuction = 3        }
        /// <summary>
        /// Sold Type
        /// </summary>
        /// <value>Sold Type</value>
        [DataMember(Name="soldType", EmitDefaultValue=false)]
        public SoldTypeEnum SoldType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2SoldDetails" /> class.
        /// </summary>
        /// <param name="soldType">Sold Type (required).</param>
        /// <param name="soldPrice">Price property was sold for (required).</param>
        /// <param name="displaySoldPrice">Indicates how the price will be displayed for free to the general public, default to true if value not provided.</param>
        public ListingAdminV2SoldDetails(SoldTypeEnum soldType = default(SoldTypeEnum), int? soldPrice = default(int?), bool? displaySoldPrice = default(bool?))
        {
            // to ensure "soldType" is required (not null)
            if (soldType == null)
            {
                throw new InvalidDataException("soldType is a required property for ListingAdminV2SoldDetails and cannot be null");
            }
            else
            {
                this.SoldType = soldType;
            }
            // to ensure "soldPrice" is required (not null)
            if (soldPrice == null)
            {
                throw new InvalidDataException("soldPrice is a required property for ListingAdminV2SoldDetails and cannot be null");
            }
            else
            {
                this.SoldPrice = soldPrice;
            }
            this.DisplaySoldPrice = displaySoldPrice;
        }
        

        /// <summary>
        /// Price property was sold for
        /// </summary>
        /// <value>Price property was sold for</value>
        [DataMember(Name="soldPrice", EmitDefaultValue=false)]
        public int? SoldPrice { get; set; }

        /// <summary>
        /// Indicates how the price will be displayed for free to the general public, default to true if value not provided
        /// </summary>
        /// <value>Indicates how the price will be displayed for free to the general public, default to true if value not provided</value>
        [DataMember(Name="displaySoldPrice", EmitDefaultValue=false)]
        public bool? DisplaySoldPrice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2SoldDetails {\n");
            sb.Append("  SoldType: ").Append(SoldType).Append("\n");
            sb.Append("  SoldPrice: ").Append(SoldPrice).Append("\n");
            sb.Append("  DisplaySoldPrice: ").Append(DisplaySoldPrice).Append("\n");
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
            return this.Equals(input as ListingAdminV2SoldDetails);
        }

        /// <summary>
        /// Returns true if ListingAdminV2SoldDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2SoldDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2SoldDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SoldType == input.SoldType ||
                    (this.SoldType != null &&
                    this.SoldType.Equals(input.SoldType))
                ) && 
                (
                    this.SoldPrice == input.SoldPrice ||
                    (this.SoldPrice != null &&
                    this.SoldPrice.Equals(input.SoldPrice))
                ) && 
                (
                    this.DisplaySoldPrice == input.DisplaySoldPrice ||
                    (this.DisplaySoldPrice != null &&
                    this.DisplaySoldPrice.Equals(input.DisplaySoldPrice))
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
                if (this.SoldType != null)
                    hashCode = hashCode * 59 + this.SoldType.GetHashCode();
                if (this.SoldPrice != null)
                    hashCode = hashCode * 59 + this.SoldPrice.GetHashCode();
                if (this.DisplaySoldPrice != null)
                    hashCode = hashCode * 59 + this.DisplaySoldPrice.GetHashCode();
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
