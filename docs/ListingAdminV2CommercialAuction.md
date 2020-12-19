# Domain.Model.ListingAdminV2CommercialAuction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuctionTerms** | **string** | Terms for the auctions, up to 200 characters. Example: \&quot;10% deposit, balance 60 days\&quot; | [optional] 
**DateTime** | **DateTime?** | Date of the auction. format: yyyy-MM-ddTHH:mm:ss | 
**Location** | **string** | Optional. Venue for the Auction. String max 100 characters. If the Location is omitted, or included but empty, the Venue will default to \&quot;On Site\&quot;. | [optional] 
**Url** | **string** | Optional on-line auction URL. Must be a valid URL and maximum 255 characters. If an empty string is received, the property will be re-set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

