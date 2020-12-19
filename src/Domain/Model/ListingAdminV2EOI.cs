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
    /// Express of Interest
    /// </summary>
    [DataContract]
        public partial class ListingAdminV2EOI :  IEquatable<ListingAdminV2EOI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2EOI" /> class.
        /// </summary>
        /// <param name="address">Street address, up to 100 characters.</param>
        /// <param name="endDate">End date of EOI (required).</param>
        /// <param name="recipientName">The recipient name of the EOI, up to 50 characters.</param>
        public ListingAdminV2EOI(string address = default(string), DateTime? endDate = default(DateTime?), string recipientName = default(string))
        {
            // to ensure "endDate" is required (not null)
            if (endDate == null)
            {
                throw new InvalidDataException("endDate is a required property for ListingAdminV2EOI and cannot be null");
            }
            else
            {
                this.EndDate = endDate;
            }
            this.Address = address;
            this.RecipientName = recipientName;
        }
        
        /// <summary>
        /// Street address, up to 100 characters
        /// </summary>
        /// <value>Street address, up to 100 characters</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// End date of EOI
        /// </summary>
        /// <value>End date of EOI</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The recipient name of the EOI, up to 50 characters
        /// </summary>
        /// <value>The recipient name of the EOI, up to 50 characters</value>
        [DataMember(Name="recipientName", EmitDefaultValue=false)]
        public string RecipientName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2EOI {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  RecipientName: ").Append(RecipientName).Append("\n");
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
            return this.Equals(input as ListingAdminV2EOI);
        }

        /// <summary>
        /// Returns true if ListingAdminV2EOI instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2EOI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2EOI input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.RecipientName == input.RecipientName ||
                    (this.RecipientName != null &&
                    this.RecipientName.Equals(input.RecipientName))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.RecipientName != null)
                    hashCode = hashCode * 59 + this.RecipientName.GetHashCode();
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