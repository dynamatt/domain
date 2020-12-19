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
    /// Parking Details
    /// </summary>
    [DataContract]
        public partial class ListingAdminV2Parking :  IEquatable<ListingAdminV2Parking>, IValidatableObject
    {
        /// <summary>
        /// Can have the value \&quot;OnSite\&quot;, \&quot;OnStreet\&quot;, \&quot;NoParking\&quot;. Default \&quot;NoParking\&quot;
        /// </summary>
        /// <value>Can have the value \&quot;OnSite\&quot;, \&quot;OnStreet\&quot;, \&quot;NoParking\&quot;. Default \&quot;NoParking\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ParkingTypeEnum
        {
            /// <summary>
            /// Enum OnSite for value: onSite
            /// </summary>
            [EnumMember(Value = "onSite")]
            OnSite = 1,
            /// <summary>
            /// Enum OnStreet for value: onStreet
            /// </summary>
            [EnumMember(Value = "onStreet")]
            OnStreet = 2,
            /// <summary>
            /// Enum NoParking for value: noParking
            /// </summary>
            [EnumMember(Value = "noParking")]
            NoParking = 3        }
        /// <summary>
        /// Can have the value \&quot;OnSite\&quot;, \&quot;OnStreet\&quot;, \&quot;NoParking\&quot;. Default \&quot;NoParking\&quot;
        /// </summary>
        /// <value>Can have the value \&quot;OnSite\&quot;, \&quot;OnStreet\&quot;, \&quot;NoParking\&quot;. Default \&quot;NoParking\&quot;</value>
        [DataMember(Name="parkingType", EmitDefaultValue=false)]
        public ParkingTypeEnum? ParkingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2Parking" /> class.
        /// </summary>
        /// <param name="parkingType">Can have the value \&quot;OnSite\&quot;, \&quot;OnStreet\&quot;, \&quot;NoParking\&quot;. Default \&quot;NoParking\&quot;.</param>
        /// <param name="numberOnSite">Number On Site.</param>
        /// <param name="information">Additional information regarding the parking condition.</param>
        public ListingAdminV2Parking(ParkingTypeEnum? parkingType = default(ParkingTypeEnum?), int? numberOnSite = default(int?), string information = default(string))
        {
            this.ParkingType = parkingType;
            this.NumberOnSite = numberOnSite;
            this.Information = information;
        }
        

        /// <summary>
        /// Number On Site
        /// </summary>
        /// <value>Number On Site</value>
        [DataMember(Name="numberOnSite", EmitDefaultValue=false)]
        public int? NumberOnSite { get; set; }

        /// <summary>
        /// Additional information regarding the parking condition
        /// </summary>
        /// <value>Additional information regarding the parking condition</value>
        [DataMember(Name="information", EmitDefaultValue=false)]
        public string Information { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2Parking {\n");
            sb.Append("  ParkingType: ").Append(ParkingType).Append("\n");
            sb.Append("  NumberOnSite: ").Append(NumberOnSite).Append("\n");
            sb.Append("  Information: ").Append(Information).Append("\n");
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
            return this.Equals(input as ListingAdminV2Parking);
        }

        /// <summary>
        /// Returns true if ListingAdminV2Parking instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2Parking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2Parking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ParkingType == input.ParkingType ||
                    (this.ParkingType != null &&
                    this.ParkingType.Equals(input.ParkingType))
                ) && 
                (
                    this.NumberOnSite == input.NumberOnSite ||
                    (this.NumberOnSite != null &&
                    this.NumberOnSite.Equals(input.NumberOnSite))
                ) && 
                (
                    this.Information == input.Information ||
                    (this.Information != null &&
                    this.Information.Equals(input.Information))
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
                if (this.ParkingType != null)
                    hashCode = hashCode * 59 + this.ParkingType.GetHashCode();
                if (this.NumberOnSite != null)
                    hashCode = hashCode * 59 + this.NumberOnSite.GetHashCode();
                if (this.Information != null)
                    hashCode = hashCode * 59 + this.Information.GetHashCode();
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
