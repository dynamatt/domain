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
    /// PreMarketV1ListingRequestJsonPatchDocument
    /// </summary>
    [DataContract]
        public partial class PreMarketV1ListingRequestJsonPatchDocument :  IEquatable<PreMarketV1ListingRequestJsonPatchDocument>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PreMarketV1ListingRequestJsonPatchDocument" /> class.
        /// </summary>
        /// <param name="contractResolver">contractResolver.</param>
        public PreMarketV1ListingRequestJsonPatchDocument(PreMarketV1IContractResolver contractResolver = default(PreMarketV1IContractResolver))
        {
            this.ContractResolver = contractResolver;
        }
        
        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name="operations", EmitDefaultValue=false)]
        public List<PreMarketV1ListingRequestOperation> Operations { get; private set; }

        /// <summary>
        /// Gets or Sets ContractResolver
        /// </summary>
        [DataMember(Name="contractResolver", EmitDefaultValue=false)]
        public PreMarketV1IContractResolver ContractResolver { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreMarketV1ListingRequestJsonPatchDocument {\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  ContractResolver: ").Append(ContractResolver).Append("\n");
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
            return this.Equals(input as PreMarketV1ListingRequestJsonPatchDocument);
        }

        /// <summary>
        /// Returns true if PreMarketV1ListingRequestJsonPatchDocument instances are equal
        /// </summary>
        /// <param name="input">Instance of PreMarketV1ListingRequestJsonPatchDocument to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PreMarketV1ListingRequestJsonPatchDocument input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    input.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
                ) && 
                (
                    this.ContractResolver == input.ContractResolver ||
                    (this.ContractResolver != null &&
                    this.ContractResolver.Equals(input.ContractResolver))
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
                if (this.Operations != null)
                    hashCode = hashCode * 59 + this.Operations.GetHashCode();
                if (this.ContractResolver != null)
                    hashCode = hashCode * 59 + this.ContractResolver.GetHashCode();
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
