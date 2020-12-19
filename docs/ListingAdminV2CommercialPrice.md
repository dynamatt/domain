# Domain.Model.ListingAdminV2CommercialPrice
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PriceUnitType** | **string** | Price Unit type. Can have the values \&quot;TotalAmount\&quot;, \&quot;PerSqm\&quot;. Default &#x3D; \&quot;TotalAmount\&quot; | [optional] 
**PriceType** | **string** | Type can have the values \&quot;Gross\&quot;, \&quot;Net\&quot;. Default \&quot;Net\&quot; | [optional] 
**GstOptionType** | **string** | GST Option Type. Can have the values \&quot;NA\&quot;, \&quot;Inc\&quot;, \&quot;Ex\&quot;. Default &#x3D; \&quot;NA\&quot; | [optional] 
**PriceReduction** | **bool?** | Indicates if this property is under price reduction | [optional] 
**DisplayText** | **string** | When provided this will be shown instead of the price range, e.g.: \&quot;Offers over $450K considered\&quot; | [optional] 
**From** | **int?** | Lowest price the property is expected to sell/rent for to set search price. For a fixed price, set this value the same as To | 
**To** | **int?** | Highest price the property is expected to sell/rent for to set search price.   For a fixed price, set this value the same as From | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

