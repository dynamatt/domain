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
    /// Commercial off market property
    /// </summary>
    [DataContract]
        public partial class ListingAdminV2CommercialOffMarketProperty :  IEquatable<ListingAdminV2CommercialOffMarketProperty>, IValidatableObject
    {
        /// <summary>
        /// Defines PropertyType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PropertyTypeEnum
        {
            /// <summary>
            /// Enum Aquaculture for value: aquaculture
            /// </summary>
            [EnumMember(Value = "aquaculture")]
            Aquaculture = 1,
            /// <summary>
            /// Enum DairyFarming for value: dairyFarming
            /// </summary>
            [EnumMember(Value = "dairyFarming")]
            DairyFarming = 2,
            /// <summary>
            /// Enum DevelopmentLand for value: developmentLand
            /// </summary>
            [EnumMember(Value = "developmentLand")]
            DevelopmentLand = 3,
            /// <summary>
            /// Enum FishingForestry for value: fishingForestry
            /// </summary>
            [EnumMember(Value = "fishingForestry")]
            FishingForestry = 4,
            /// <summary>
            /// Enum HotelLeisure for value: hotelLeisure
            /// </summary>
            [EnumMember(Value = "hotelLeisure")]
            HotelLeisure = 5,
            /// <summary>
            /// Enum IndustrialWarehouse for value: industrialWarehouse
            /// </summary>
            [EnumMember(Value = "industrialWarehouse")]
            IndustrialWarehouse = 6,
            /// <summary>
            /// Enum IrrigationServices for value: irrigationServices
            /// </summary>
            [EnumMember(Value = "irrigationServices")]
            IrrigationServices = 7,
            /// <summary>
            /// Enum Livestock for value: livestock
            /// </summary>
            [EnumMember(Value = "livestock")]
            Livestock = 8,
            /// <summary>
            /// Enum InternationalCommercial for value: internationalCommercial
            /// </summary>
            [EnumMember(Value = "internationalCommercial")]
            InternationalCommercial = 9,
            /// <summary>
            /// Enum MedicalConsulting for value: medicalConsulting
            /// </summary>
            [EnumMember(Value = "medicalConsulting")]
            MedicalConsulting = 10,
            /// <summary>
            /// Enum Offices for value: offices
            /// </summary>
            [EnumMember(Value = "offices")]
            Offices = 11,
            /// <summary>
            /// Enum ParkingCarSpace for value: parkingCarSpace
            /// </summary>
            [EnumMember(Value = "parkingCarSpace")]
            ParkingCarSpace = 12,
            /// <summary>
            /// Enum Retail for value: retail
            /// </summary>
            [EnumMember(Value = "retail")]
            Retail = 13,
            /// <summary>
            /// Enum RuralCommercialFarming for value: ruralCommercialFarming
            /// </summary>
            [EnumMember(Value = "ruralCommercialFarming")]
            RuralCommercialFarming = 14,
            /// <summary>
            /// Enum ShowroomsBulkyGoods for value: showroomsBulkyGoods
            /// </summary>
            [EnumMember(Value = "showroomsBulkyGoods")]
            ShowroomsBulkyGoods = 15,
            /// <summary>
            /// Enum ServicedOffices for value: servicedOffices
            /// </summary>
            [EnumMember(Value = "servicedOffices")]
            ServicedOffices = 16,
            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 17,
            /// <summary>
            /// Enum Cropping for value: cropping
            /// </summary>
            [EnumMember(Value = "cropping")]
            Cropping = 18,
            /// <summary>
            /// Enum Viticulture for value: viticulture
            /// </summary>
            [EnumMember(Value = "viticulture")]
            Viticulture = 19,
            /// <summary>
            /// Enum MixedFarming for value: mixedFarming
            /// </summary>
            [EnumMember(Value = "mixedFarming")]
            MixedFarming = 20,
            /// <summary>
            /// Enum Grazing for value: grazing
            /// </summary>
            [EnumMember(Value = "grazing")]
            Grazing = 21,
            /// <summary>
            /// Enum Horticulture for value: horticulture
            /// </summary>
            [EnumMember(Value = "horticulture")]
            Horticulture = 22,
            /// <summary>
            /// Enum Equine for value: equine
            /// </summary>
            [EnumMember(Value = "equine")]
            Equine = 23,
            /// <summary>
            /// Enum Farmlet for value: farmlet
            /// </summary>
            [EnumMember(Value = "farmlet")]
            Farmlet = 24,
            /// <summary>
            /// Enum Orchard for value: orchard
            /// </summary>
            [EnumMember(Value = "orchard")]
            Orchard = 25,
            /// <summary>
            /// Enum RuralLifestyle for value: ruralLifestyle
            /// </summary>
            [EnumMember(Value = "ruralLifestyle")]
            RuralLifestyle = 26        }
        /// <summary>
        /// Commercial property types [&#x27;aquaculture&#x27;, &#x27;dairyFarming&#x27;, &#x27;developmentLand&#x27;, &#x27;fishingForestry&#x27;, &#x27;hotelLeisure&#x27;, &#x27;industrialWarehouse&#x27;, &#x27;irrigationServices&#x27;, &#x27;livestock&#x27;, &#x27;internationalCommercial&#x27;, &#x27;medicalConsulting&#x27;, &#x27;offices&#x27;, &#x27;parkingCarSpace&#x27;, &#x27;retail&#x27;, &#x27;ruralCommercialFarming&#x27;, &#x27;showroomsBulkyGoods&#x27;, &#x27;servicedOffices&#x27;, &#x27;other&#x27;, &#x27;cropping&#x27;, &#x27;viticulture&#x27;, &#x27;mixedFarming&#x27;, &#x27;grazing&#x27;, &#x27;horticulture&#x27;, &#x27;equine&#x27;, &#x27;farmlet&#x27;, &#x27;orchard&#x27;, &#x27;ruralLifestyle&#x27;].
        /// </summary>
        /// <value>Commercial property types [&#x27;aquaculture&#x27;, &#x27;dairyFarming&#x27;, &#x27;developmentLand&#x27;, &#x27;fishingForestry&#x27;, &#x27;hotelLeisure&#x27;, &#x27;industrialWarehouse&#x27;, &#x27;irrigationServices&#x27;, &#x27;livestock&#x27;, &#x27;internationalCommercial&#x27;, &#x27;medicalConsulting&#x27;, &#x27;offices&#x27;, &#x27;parkingCarSpace&#x27;, &#x27;retail&#x27;, &#x27;ruralCommercialFarming&#x27;, &#x27;showroomsBulkyGoods&#x27;, &#x27;servicedOffices&#x27;, &#x27;other&#x27;, &#x27;cropping&#x27;, &#x27;viticulture&#x27;, &#x27;mixedFarming&#x27;, &#x27;grazing&#x27;, &#x27;horticulture&#x27;, &#x27;equine&#x27;, &#x27;farmlet&#x27;, &#x27;orchard&#x27;, &#x27;ruralLifestyle&#x27;].</value>
        [DataMember(Name="propertyType", EmitDefaultValue=false)]
        public List<PropertyTypeEnum> PropertyType { get; set; }
        /// <summary>
        /// Building Type
        /// </summary>
        /// <value>Building Type</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum BuildingTypeEnum
        {
            /// <summary>
            /// Enum Whole for value: whole
            /// </summary>
            [EnumMember(Value = "whole")]
            Whole = 1,
            /// <summary>
            /// Enum Part for value: part
            /// </summary>
            [EnumMember(Value = "part")]
            Part = 2,
            /// <summary>
            /// Enum NA for value: nA
            /// </summary>
            [EnumMember(Value = "nA")]
            NA = 3        }
        /// <summary>
        /// Building Type
        /// </summary>
        /// <value>Building Type</value>
        [DataMember(Name="buildingType", EmitDefaultValue=false)]
        public BuildingTypeEnum? BuildingType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListingAdminV2CommercialOffMarketProperty" /> class.
        /// </summary>
        /// <param name="propertyType">Commercial property types [&#x27;aquaculture&#x27;, &#x27;dairyFarming&#x27;, &#x27;developmentLand&#x27;, &#x27;fishingForestry&#x27;, &#x27;hotelLeisure&#x27;, &#x27;industrialWarehouse&#x27;, &#x27;irrigationServices&#x27;, &#x27;livestock&#x27;, &#x27;internationalCommercial&#x27;, &#x27;medicalConsulting&#x27;, &#x27;offices&#x27;, &#x27;parkingCarSpace&#x27;, &#x27;retail&#x27;, &#x27;ruralCommercialFarming&#x27;, &#x27;showroomsBulkyGoods&#x27;, &#x27;servicedOffices&#x27;, &#x27;other&#x27;, &#x27;cropping&#x27;, &#x27;viticulture&#x27;, &#x27;mixedFarming&#x27;, &#x27;grazing&#x27;, &#x27;horticulture&#x27;, &#x27;equine&#x27;, &#x27;farmlet&#x27;, &#x27;orchard&#x27;, &#x27;ruralLifestyle&#x27;]. (required).</param>
        /// <param name="buildingType">Building Type.</param>
        /// <param name="parking">parking.</param>
        /// <param name="images">List of image files, photos or floor plans related to the listing..</param>
        /// <param name="address">address (required).</param>
        /// <param name="area">area.</param>
        /// <param name="landArea">landArea.</param>
        public ListingAdminV2CommercialOffMarketProperty(List<PropertyTypeEnum> propertyType = default(List<PropertyTypeEnum>), BuildingTypeEnum? buildingType = default(BuildingTypeEnum?), ListingAdminV2Parking parking = default(ListingAdminV2Parking), List<ListingAdminV2PropertyMedia> images = default(List<ListingAdminV2PropertyMedia>), ListingAdminV2Address address = default(ListingAdminV2Address), ListingAdminV2Area area = default(ListingAdminV2Area), ListingAdminV2LandArea landArea = default(ListingAdminV2LandArea))
        {
            // to ensure "propertyType" is required (not null)
            if (propertyType == null)
            {
                throw new InvalidDataException("propertyType is a required property for ListingAdminV2CommercialOffMarketProperty and cannot be null");
            }
            else
            {
                this.PropertyType = propertyType;
            }
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new InvalidDataException("address is a required property for ListingAdminV2CommercialOffMarketProperty and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            this.BuildingType = buildingType;
            this.Parking = parking;
            this.Images = images;
            this.Area = area;
            this.LandArea = landArea;
        }
        


        /// <summary>
        /// Gets or Sets Parking
        /// </summary>
        [DataMember(Name="parking", EmitDefaultValue=false)]
        public ListingAdminV2Parking Parking { get; set; }

        /// <summary>
        /// List of image files, photos or floor plans related to the listing.
        /// </summary>
        /// <value>List of image files, photos or floor plans related to the listing.</value>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<ListingAdminV2PropertyMedia> Images { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public ListingAdminV2Address Address { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public ListingAdminV2Area Area { get; set; }

        /// <summary>
        /// Gets or Sets LandArea
        /// </summary>
        [DataMember(Name="landArea", EmitDefaultValue=false)]
        public ListingAdminV2LandArea LandArea { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListingAdminV2CommercialOffMarketProperty {\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  BuildingType: ").Append(BuildingType).Append("\n");
            sb.Append("  Parking: ").Append(Parking).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  LandArea: ").Append(LandArea).Append("\n");
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
            return this.Equals(input as ListingAdminV2CommercialOffMarketProperty);
        }

        /// <summary>
        /// Returns true if ListingAdminV2CommercialOffMarketProperty instances are equal
        /// </summary>
        /// <param name="input">Instance of ListingAdminV2CommercialOffMarketProperty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListingAdminV2CommercialOffMarketProperty input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PropertyType == input.PropertyType ||
                    this.PropertyType != null &&
                    input.PropertyType != null &&
                    this.PropertyType.SequenceEqual(input.PropertyType)
                ) && 
                (
                    this.BuildingType == input.BuildingType ||
                    (this.BuildingType != null &&
                    this.BuildingType.Equals(input.BuildingType))
                ) && 
                (
                    this.Parking == input.Parking ||
                    (this.Parking != null &&
                    this.Parking.Equals(input.Parking))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.LandArea == input.LandArea ||
                    (this.LandArea != null &&
                    this.LandArea.Equals(input.LandArea))
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
                if (this.PropertyType != null)
                    hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                if (this.BuildingType != null)
                    hashCode = hashCode * 59 + this.BuildingType.GetHashCode();
                if (this.Parking != null)
                    hashCode = hashCode * 59 + this.Parking.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.LandArea != null)
                    hashCode = hashCode * 59 + this.LandArea.GetHashCode();
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
