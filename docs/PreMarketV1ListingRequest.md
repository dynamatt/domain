# Domain.Model.PreMarketV1ListingRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ListingStatus** | [**PreMarketV1ListingStatus**](PreMarketV1ListingStatus.md) |  | 
**Address** | [**PreMarketV1Address**](PreMarketV1Address.md) |  | 
**DomainAgencyId** | **int?** | The Domain agency ID. Must match an existing Domain agency ID. | 
**ListingProvider** | **string** | A string identifying the source of the listing | [optional] 
**ProviderAdId** | **string** | External Advertisement Id of up to 50 characters will be stored.  This value is correlated with actual Domain listing when it is created, and it should be unique for the listing provider.   This value is case-insensitive (meaning AAAA will update aaaa). | [optional] 
**Contacts** | [**List&lt;PreMarketV1Contact&gt;**](PreMarketV1Contact.md) |  | [optional] 
**Bedrooms** | **float?** | Number of bedrooms divisible by 0.5. | 
**Bathrooms** | **float?** | Number of bathrooms divisible by 0.5. | 
**Carspaces** | **float?** | Number of car spaces divisible by 0.5. | 
**Summary** | **string** | Headline of the advertisement. Any HTML will be stripped out. | [optional] 
**Description** | **string** | Description of the property.  Allow up to 6000 characters in length. The following HTML elements are permitted: &#x60;&#x60;&#x60;&lt;br /&gt;, &lt;p&gt;&lt;/p&gt;, &amp;nbsp;&#x60;&#x60;&#x60; . HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade | [optional] 
**AuthorityExecutedDate** | **DateTime?** | The date on which the authority contract was executed.  The date must comply with the ISO 8601 and be in the UTC format, e.g. 2009-06-15T13:45:30.0000000Z. | 
**ReservePrice** | **double?** | Vendor reserve price. | [optional] 
**EstimatedSalePrice** | [**PreMarketV1Price**](PreMarketV1Price.md) |  | 
**PropertyTypes** | [**List&lt;PreMarketV1PropertyType&gt;**](PreMarketV1PropertyType.md) | The property types (e.g. house, apartment/unit/flat, etc.). | 
**AuthorityType** | [**PreMarketV1AuthorityType**](PreMarketV1AuthorityType.md) |  | 
**ExclusivePeriodDays** | **int?** | The time (in days) that the agent has exclusive authority to sell the property. | [optional] 
**ExclusiveContinuingPeriodDays** | **int?** | The time (in days) that exclusive authority has been extended. | [optional] 
**ExclusivePeriodStartDate** | **DateTime?** | Start date of the exclusivity period.  The date must comply with the ISO 8601 and be in the UTC format, e.g. 2009-06-15T13:45:30.0000000Z. | [optional] 
**ActionDate** | **DateTime?** | The date that this property was listed, sold or withdrawn. It is required if listing status is marked to be \&quot;sold, withdrawn, or listed\&quot;.  The date must comply with the ISO 8601 and be in the UTC format, e.g. 2009-06-15T13:45:30.0000000Z.   Only the date part will be saved, time part will be discarded. | 
**StatementOfInformation** | [**PreMarketV1StatementOfInformation**](PreMarketV1StatementOfInformation.md) |  | [optional] 
**Images** | [**List&lt;PreMarketV1PropertyMedia&gt;**](PreMarketV1PropertyMedia.md) |  | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Optional listing metadata. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

