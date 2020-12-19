# Domain.Model.PreMarketV1ListingResponse
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Pre-portal listing ID. | 
**ListingStatus** | [**PreMarketV1ListingStatus**](PreMarketV1ListingStatus.md) |  | 
**ProviderDetails** | [**PreMarketV1ProviderDetails**](PreMarketV1ProviderDetails.md) |  | [optional] 
**Address** | [**PreMarketV1Address**](PreMarketV1Address.md) |  | [optional] 
**AdvertiserIdentifiers** | [**PreMarketV1AdvertiserIdentifiers**](PreMarketV1AdvertiserIdentifiers.md) |  | [optional] 
**Bedrooms** | **float?** | Total number of bedrooms in the property | 
**Bathrooms** | **float?** | Total number of bathrooms in the property | 
**Carspaces** | **float?** | Total number of car spaces in the property. | 
**Headline** | **string** | The short description of the property provided by the advertiser | [optional] 
**Description** | **string** | The long description of the property provided by the advertiser | [optional] 
**AuthorityExecutedDate** | **DateTime?** | The date on which the authority contract was executed.  The date is compliant with the ISO 8601 and is in the UTC format, e.g. 2009-06-15T13:45:30.0000000Z. | 
**EstimatedSalePrice** | [**PreMarketV1Price**](PreMarketV1Price.md) |  | 
**PropertyTypes** | [**List&lt;PreMarketV1PropertyType&gt;**](PreMarketV1PropertyType.md) | The property types (e.g. house, apartment/unit/flat, etc.). | [optional] 
**AuthorityType** | [**PreMarketV1AuthorityType**](PreMarketV1AuthorityType.md) |  | 
**ExclusivePeriodDays** | **int?** | The time (in days) that the agent has exclusive authority to sell the property. | [optional] 
**ExclusiveContinuingPeriodDays** | **int?** | The time (in days) that exclusive authority has been extended. | [optional] 
**ExclusivePeriodStartDate** | **DateTime?** | Start date of the exclusivity period.  The date is compliant with the ISO 8601 and is in the UTC format, e.g. 2009-06-15T13:45:30.0000000Z. | [optional] 
**GeoLocation** | [**PreMarketV1GeoLocation**](PreMarketV1GeoLocation.md) |  | [optional] 
**MapCertainty** | **int?** | Map certainty of the property location. | [optional] 
**Media** | [**List&lt;PreMarketV1PropertyMedia&gt;**](PreMarketV1PropertyMedia.md) | The media associated with the property provided by the advertiser | [optional] 
**PropertyId** | **string** | The identifier which uniquely identifies the property being advertised.   This may be empty if the Address of property is poorly described | [optional] 
**StatementOfInformation** | [**PreMarketV1StatementOfInformation**](PreMarketV1StatementOfInformation.md) |  | [optional] 
**DateCreated** | **DateTime?** | The date/time the listing was created  The date is compliant with the ISO 8601 and is in the UTC format, e.g. 2009-06-15T13:45:30.0000000Z. | [optional] 
**DateUpdated** | **DateTime?** | The date/time the listing was last updated  The date is compliant with the ISO 8601 and is in the UTC format, e.g. 2009-06-15T13:45:30.0000000Z. | [optional] 
**DateWithdrawn** | **DateTime?** | The date property was withdrawn | [optional] 
**DateListed** | **DateTime?** | The date property was listed | [optional] 
**DateSold** | **DateTime?** | The date property was sold | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Optional listing metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

