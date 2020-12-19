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
    /// Commercial off market listing
    /// </summary>
    [DataContract]
        public partial class ListingAdminV2CommercialOffMarketListing :  IEquatable<ListingAdminV2CommercialOffMarketListing>, IValidatableObject
    {
        /// <summary>
        /// Sale or Rent
        /// </summary>
        /// <value>Sale or Rent</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ListingActionEnum
        {
            /// <summary>
            /// Enum Sale for value: sale
            /// </summary>
            [EnumMember(Value = "sale")]
            Sale = 1,
            /// <summary>
            /// Enum Rent for value: rent
            /// </summary>
            [EnumMember(Value = "rent")]
            Rent = 2        }
        /// <summary>
        /// Sale or Rent
        /// </summary>
        /// <value>Sale or Rent</value>
        [DataMember(Name="listingAction", EmitDefaultValue=false)]
        public ListingActionEnum ListingAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2CommercialOffMarketListing" /> class.
        /// </summary>
        /// <param name="unitsOffered">Integer value of units offered for sale or lease.</param>
        /// <param name="unitDetails">Units details.</param>
        /// <param name="annualReturn">Integer value of percentage return on this property or business..</param>
        /// <param name="nabers">The NABERS Rating is the energy efficiency rating that the property has been measured to have.   This rating is measured in increments of .5 and can range from 0 to 6.   The NABERS rating is required for spaces within office buildings of 1000 square metres or more.  For more information on the NABERS rating system please visit http://www.nabers.gov.au.</param>
        /// <param name="highlights">Highlight Items.</param>
        /// <param name="inspectionDetails">inspectionDetails.</param>
        /// <param name="listingProvider">A string identifying the data provider.</param>
        /// <param name="domainAgencyID">The Domain Agency ID (required).</param>
        /// <param name="providerAdId">External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa). (required).</param>
        /// <param name="description">Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade.</param>
        /// <param name="summary">&#x27;Headline&#x27; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters..</param>
        /// <param name="contacts">Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found..</param>
        /// <param name="listingAction">Sale or Rent (required).</param>
        /// <param name="offMarketDetails">offMarketDetails (required).</param>
        /// <param name="propertyDetails">propertyDetails (required).</param>
        public ListingAdminV2CommercialOffMarketListing(int? unitsOffered = default(int?), List<ListingAdminV2SpecificUnitDetail> unitDetails = default(List<ListingAdminV2SpecificUnitDetail>), int? annualReturn = default(int?), double? nabers = default(double?), List<string> highlights = default(List<string>), ListingAdminV2InspectionDetails inspectionDetails = default(ListingAdminV2InspectionDetails), string listingProvider = default(string), int? domainAgencyID = default(int?), string providerAdId = default(string), string description = default(string), string summary = default(string), List<ListingAdminV2Contact> contacts = default(List<ListingAdminV2Contact>), ListingActionEnum listingAction = default(ListingActionEnum), ListingAdminV2OffMarketDetailsBase offMarketDetails = default(ListingAdminV2OffMarketDetailsBase), ListingAdminV2CommercialOffMarketProperty propertyDetails = default(ListingAdminV2CommercialOffMarketProperty))
        {
            // to ensure "domainAgencyID" is required (not null)
            if (domainAgencyID == null)
            {
                throw new InvalidDataException("domainAgencyID is a required property for ListingAdminV2CommercialOffMarketListing and cannot be null");
            }
            else
            {
                this.DomainAgencyID = domainAgencyID;
            }
            // to ensure "providerAdId" is required (not null)
            if (providerAdId == null)
            {
                throw new InvalidDataException("providerAdId is a required property for ListingAdminV2CommercialOffMarketListing and cannot be null");
            }
            else
            {
                this.ProviderAdId = providerAdId;
            }
            // to ensure "listingAction" is required (not null)
            if (listingAction == null)
            {
                throw new InvalidDataException("listingAction is a required property for ListingAdminV2CommercialOffMarketListing and cannot be null");
            }
            else
            {
                this.ListingAction = listingAction;
            }
            // to ensure "offMarketDetails" is required (not null)
            if (offMarketDetails == null)
            {
                throw new InvalidDataException("offMarketDetails is a required property for ListingAdminV2CommercialOffMarketListing and cannot be null");
            }
            else
            {
                this.OffMarketDetails = offMarketDetails;
            }
            // to ensure "propertyDetails" is required (not null)
            if (propertyDetails == null)
            {
                throw new InvalidDataException("propertyDetails is a required property for ListingAdminV2CommercialOffMarketListing and cannot be null");
            }
            else
            {
                this.PropertyDetails = propertyDetails;
            }
            this.UnitsOffered = unitsOffered;
            this.UnitDetails = unitDetails;
            this.AnnualReturn = annualReturn;
            this.Nabers = nabers;
            this.Highlights = highlights;
            this.InspectionDetails = inspectionDetails;
            this.ListingProvider = listingProvider;
            this.Description = description;
            this.Summary = summary;
            this.Contacts = contacts;
        }
        
        /// <summary>
        /// Integer value of units offered for sale or lease
        /// </summary>
        /// <value>Integer value of units offered for sale or lease</value>
        [DataMember(Name="unitsOffered", EmitDefaultValue=false)]
        public int? UnitsOffered { get; set; }

        /// <summary>
        /// Units details
        /// </summary>
        /// <value>Units details</value>
        [DataMember(Name="unitDetails", EmitDefaultValue=false)]
        public List<ListingAdminV2SpecificUnitDetail> UnitDetails { get; set; }

        /// <summary>
        /// Integer value of percentage return on this property or business.
        /// </summary>
        /// <value>Integer value of percentage return on this property or business.</value>
        [DataMember(Name="annualReturn", EmitDefaultValue=false)]
        public int? AnnualReturn { get; set; }

        /// <summary>
        /// The NABERS Rating is the energy efficiency rating that the property has been measured to have.   This rating is measured in increments of .5 and can range from 0 to 6.   The NABERS rating is required for spaces within office buildings of 1000 square metres or more.  For more information on the NABERS rating system please visit http://www.nabers.gov.au
        /// </summary>
        /// <value>The NABERS Rating is the energy efficiency rating that the property has been measured to have.   This rating is measured in increments of .5 and can range from 0 to 6.   The NABERS rating is required for spaces within office buildings of 1000 square metres or more.  For more information on the NABERS rating system please visit http://www.nabers.gov.au</value>
        [DataMember(Name="nabers", EmitDefaultValue=false)]
        public double? Nabers { get; set; }

        /// <summary>
        /// Highlight Items
        /// </summary>
        /// <value>Highlight Items</value>
        [DataMember(Name="highlights", EmitDefaultValue=false)]
        public List<string> Highlights { get; set; }

        /// <summary>
        /// Domain Ad ID
        /// </summary>
        /// <value>Domain Ad ID</value>
        [DataMember(Name="domainAdId", EmitDefaultValue=false)]
        public int? DomainAdId { get; private set; }

        /// <summary>
        /// Gets or Sets InspectionDetails
        /// </summary>
        [DataMember(Name="inspectionDetails", EmitDefaultValue=false)]
        public ListingAdminV2InspectionDetails InspectionDetails { get; set; }

        /// <summary>
        /// True if the property is rural
        /// </summary>
        /// <value>True if the property is rural</value>
        [DataMember(Name="isRural", EmitDefaultValue=false)]
        public bool? IsRural { get; private set; }

        /// <summary>
        /// A string identifying the data provider
        /// </summary>
        /// <value>A string identifying the data provider</value>
        [DataMember(Name="listingProvider", EmitDefaultValue=false)]
        public string ListingProvider { get; set; }

        /// <summary>
        /// The Domain Agency ID
        /// </summary>
        /// <value>The Domain Agency ID</value>
        [DataMember(Name="domainAgencyID", EmitDefaultValue=false)]
        public int? DomainAgencyID { get; set; }

        /// <summary>
        /// External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa).
        /// </summary>
        /// <value>External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa).</value>
        [DataMember(Name="providerAdId", EmitDefaultValue=false)]
        public string ProviderAdId { get; set; }

        /// <summary>
        /// Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade
        /// </summary>
        /// <value>Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// &#x27;Headline&#x27; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters.
        /// </summary>
        /// <value>&#x27;Headline&#x27; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters.</value>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found.
        /// </summary>
        /// <value>Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found.</value>
        [DataMember(Name="contacts", EmitDefaultValue=false)]
        public List<ListingAdminV2Contact> Contacts { get; set; }


        /// <summary>
        /// Gets or Sets OffMarketDetails
        /// </summary>
        [DataMember(Name="offMarketDetails", EmitDefaultValue=false)]
        public ListingAdminV2OffMarketDetailsBase OffMarketDetails { get; set; }

        /// <summary>
        /// Gets or Sets PropertyDetails
        /// </summary>
        [DataMember(Name="propertyDetails", EmitDefaultValue=false)]
        public ListingAdminV2CommercialOffMarketProperty PropertyDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2CommercialOffMarketListing {\n");
            sb.Append("  UnitsOffered: ").Append(UnitsOffered).Append("\n");
            sb.Append("  UnitDetails: ").Append(UnitDetails).Append("\n");
            sb.Append("  AnnualReturn: ").Append(AnnualReturn).Append("\n");
            sb.Append("  Nabers: ").Append(Nabers).Append("\n");
            sb.Append("  Highlights: ").Append(Highlights).Append("\n");
            sb.Append("  DomainAdId: ").Append(DomainAdId).Append("\n");
            sb.Append("  InspectionDetails: ").Append(InspectionDetails).Append("\n");
            sb.Append("  IsRural: ").Append(IsRural).Append("\n");
            sb.Append("  ListingProvider: ").Append(ListingProvider).Append("\n");
            sb.Append("  DomainAgencyID: ").Append(DomainAgencyID).Append("\n");
            sb.Append("  ProviderAdId: ").Append(ProviderAdId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
            sb.Append("  ListingAction: ").Append(ListingAction).Append("\n");
            sb.Append("  OffMarketDetails: ").Append(OffMarketDetails).Append("\n");
            sb.Append("  PropertyDetails: ").Append(PropertyDetails).Append("\n");
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
            return this.Equals(input as ListingAdminV2CommercialOffMarketListing);
        }

        /// <summary>
        /// Returns true if ListingAdminV2CommercialOffMarketListing instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2CommercialOffMarketListing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2CommercialOffMarketListing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UnitsOffered == input.UnitsOffered ||
                    (this.UnitsOffered != null &&
                    this.UnitsOffered.Equals(input.UnitsOffered))
                ) && 
                (
                    this.UnitDetails == input.UnitDetails ||
                    this.UnitDetails != null &&
                    input.UnitDetails != null &&
                    this.UnitDetails.SequenceEqual(input.UnitDetails)
                ) && 
                (
                    this.AnnualReturn == input.AnnualReturn ||
                    (this.AnnualReturn != null &&
                    this.AnnualReturn.Equals(input.AnnualReturn))
                ) && 
                (
                    this.Nabers == input.Nabers ||
                    (this.Nabers != null &&
                    this.Nabers.Equals(input.Nabers))
                ) && 
                (
                    this.Highlights == input.Highlights ||
                    this.Highlights != null &&
                    input.Highlights != null &&
                    this.Highlights.SequenceEqual(input.Highlights)
                ) && 
                (
                    this.DomainAdId == input.DomainAdId ||
                    (this.DomainAdId != null &&
                    this.DomainAdId.Equals(input.DomainAdId))
                ) && 
                (
                    this.InspectionDetails == input.InspectionDetails ||
                    (this.InspectionDetails != null &&
                    this.InspectionDetails.Equals(input.InspectionDetails))
                ) && 
                (
                    this.IsRural == input.IsRural ||
                    (this.IsRural != null &&
                    this.IsRural.Equals(input.IsRural))
                ) && 
                (
                    this.ListingProvider == input.ListingProvider ||
                    (this.ListingProvider != null &&
                    this.ListingProvider.Equals(input.ListingProvider))
                ) && 
                (
                    this.DomainAgencyID == input.DomainAgencyID ||
                    (this.DomainAgencyID != null &&
                    this.DomainAgencyID.Equals(input.DomainAgencyID))
                ) && 
                (
                    this.ProviderAdId == input.ProviderAdId ||
                    (this.ProviderAdId != null &&
                    this.ProviderAdId.Equals(input.ProviderAdId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
                ) && 
                (
                    this.ListingAction == input.ListingAction ||
                    (this.ListingAction != null &&
                    this.ListingAction.Equals(input.ListingAction))
                ) && 
                (
                    this.OffMarketDetails == input.OffMarketDetails ||
                    (this.OffMarketDetails != null &&
                    this.OffMarketDetails.Equals(input.OffMarketDetails))
                ) && 
                (
                    this.PropertyDetails == input.PropertyDetails ||
                    (this.PropertyDetails != null &&
                    this.PropertyDetails.Equals(input.PropertyDetails))
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
                if (this.UnitsOffered != null)
                    hashCode = hashCode * 59 + this.UnitsOffered.GetHashCode();
                if (this.UnitDetails != null)
                    hashCode = hashCode * 59 + this.UnitDetails.GetHashCode();
                if (this.AnnualReturn != null)
                    hashCode = hashCode * 59 + this.AnnualReturn.GetHashCode();
                if (this.Nabers != null)
                    hashCode = hashCode * 59 + this.Nabers.GetHashCode();
                if (this.Highlights != null)
                    hashCode = hashCode * 59 + this.Highlights.GetHashCode();
                if (this.DomainAdId != null)
                    hashCode = hashCode * 59 + this.DomainAdId.GetHashCode();
                if (this.InspectionDetails != null)
                    hashCode = hashCode * 59 + this.InspectionDetails.GetHashCode();
                if (this.IsRural != null)
                    hashCode = hashCode * 59 + this.IsRural.GetHashCode();
                if (this.ListingProvider != null)
                    hashCode = hashCode * 59 + this.ListingProvider.GetHashCode();
                if (this.DomainAgencyID != null)
                    hashCode = hashCode * 59 + this.DomainAgencyID.GetHashCode();
                if (this.ProviderAdId != null)
                    hashCode = hashCode * 59 + this.ProviderAdId.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.Contacts != null)
                    hashCode = hashCode * 59 + this.Contacts.GetHashCode();
                if (this.ListingAction != null)
                    hashCode = hashCode * 59 + this.ListingAction.GetHashCode();
                if (this.OffMarketDetails != null)
                    hashCode = hashCode * 59 + this.OffMarketDetails.GetHashCode();
                if (this.PropertyDetails != null)
                    hashCode = hashCode * 59 + this.PropertyDetails.GetHashCode();
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
