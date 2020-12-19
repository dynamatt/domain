# Domain.Model.ListingAdminV2ResidentialOffMarketProperty
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyType** | **List&lt;string&gt;** | Residential property types&lt;br /&gt;  &#x27;Retirement&#x27; requires at least one more property type to be specified with it (for example: \&quot;Retirement, ApartmentUnitFlat\&quot;) [&#x27;acreageSemiRural&#x27;, &#x27;apartmentUnitFlat&#x27;, &#x27;aquaculture&#x27;, &#x27;blockOfUnits&#x27;, &#x27;carSpace&#x27;, &#x27;dairyFarming&#x27;, &#x27;developmentSite&#x27;, &#x27;duplex&#x27;, &#x27;farm&#x27;, &#x27;fishingForestry&#x27;, &#x27;newHomeDesigns&#x27;, &#x27;house&#x27;, &#x27;newHouseLand&#x27;, &#x27;irrigationServices&#x27;, &#x27;newLand&#x27;, &#x27;livestock&#x27;, &#x27;newApartments&#x27;, &#x27;penthouse&#x27;, &#x27;retirement&#x27;, &#x27;rural&#x27;, &#x27;semiDetached&#x27;, &#x27;specialistFarm&#x27;, &#x27;studio&#x27;, &#x27;terrace&#x27;, &#x27;townhouse&#x27;, &#x27;vacantLand&#x27;, &#x27;villa&#x27;, &#x27;cropping&#x27;, &#x27;viticulture&#x27;, &#x27;mixedFarming&#x27;, &#x27;grazing&#x27;, &#x27;horticulture&#x27;, &#x27;equine&#x27;, &#x27;farmlet&#x27;, &#x27;orchard&#x27;, &#x27;ruralLifestyle&#x27;]. | 
**BedRooms** | **int?** | Number of bedrooms | [optional] 
**BathRooms** | **int?** | Number of bathrooms | [optional] 
**ParkingInfo** | [**ListingAdminV2ParkingInfo**](ListingAdminV2ParkingInfo.md) |  | [optional] 
**Images** | [**List&lt;ListingAdminV2PropertyMedia&gt;**](ListingAdminV2PropertyMedia.md) | List of image files, photos or floor plans related to the listing. | [optional] 
**Address** | [**ListingAdminV2Address**](ListingAdminV2Address.md) |  | 
**Area** | [**ListingAdminV2Area**](ListingAdminV2Area.md) |  | [optional] 
**LandArea** | [**ListingAdminV2LandArea**](ListingAdminV2LandArea.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

