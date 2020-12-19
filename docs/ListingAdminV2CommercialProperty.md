# Domain.Model.ListingAdminV2CommercialProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyType** | **List&lt;string&gt;** | Commercial property types [&#x27;aquaculture&#x27;, &#x27;dairyFarming&#x27;, &#x27;developmentLand&#x27;, &#x27;fishingForestry&#x27;, &#x27;hotelLeisure&#x27;, &#x27;industrialWarehouse&#x27;, &#x27;irrigationServices&#x27;, &#x27;livestock&#x27;, &#x27;internationalCommercial&#x27;, &#x27;medicalConsulting&#x27;, &#x27;offices&#x27;, &#x27;parkingCarSpace&#x27;, &#x27;retail&#x27;, &#x27;ruralCommercialFarming&#x27;, &#x27;showroomsBulkyGoods&#x27;, &#x27;servicedOffices&#x27;, &#x27;other&#x27;, &#x27;cropping&#x27;, &#x27;viticulture&#x27;, &#x27;mixedFarming&#x27;, &#x27;grazing&#x27;, &#x27;horticulture&#x27;, &#x27;equine&#x27;, &#x27;farmlet&#x27;, &#x27;orchard&#x27;, &#x27;ruralLifestyle&#x27;]. | 
**BuildingType** | **string** | Building Type | [optional] 
**Parking** | [**ListingAdminV2Parking**](ListingAdminV2Parking.md) |  | [optional] 
**Pdfs** | [**List&lt;ListingAdminV2PropertyPdf&gt;**](ListingAdminV2PropertyPdf.md) | List of PDF files related to the listing | [optional] 
**IsMarkedForLiveability** | **bool?** | Is the property liveability compliant | [optional] 
**PropertyName** | **string** | Name of the property up to 70 characters | [optional] 
**Location** | **string** | Short location information up to 30 character, e.g.: Greenhills Beach | [optional] 
**Images** | [**List&lt;ListingAdminV2PropertyMedia&gt;**](ListingAdminV2PropertyMedia.md) | List of image files, photos or floor plans related to the listing. | [optional] 
**Address** | [**ListingAdminV2Address**](ListingAdminV2Address.md) |  | 
**Area** | [**ListingAdminV2Area**](ListingAdminV2Area.md) |  | [optional] 
**LandArea** | [**ListingAdminV2LandArea**](ListingAdminV2LandArea.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

