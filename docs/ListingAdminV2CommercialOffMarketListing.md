# Domain.Model.ListingAdminV2CommercialOffMarketListing
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnitsOffered** | **int?** | Integer value of units offered for sale or lease | [optional] 
**UnitDetails** | [**List&lt;ListingAdminV2SpecificUnitDetail&gt;**](ListingAdminV2SpecificUnitDetail.md) | Units details | [optional] 
**AnnualReturn** | **int?** | Integer value of percentage return on this property or business. | [optional] 
**Nabers** | **double?** | The NABERS Rating is the energy efficiency rating that the property has been measured to have.   This rating is measured in increments of .5 and can range from 0 to 6.   The NABERS rating is required for spaces within office buildings of 1000 square metres or more.  For more information on the NABERS rating system please visit http://www.nabers.gov.au | [optional] 
**Highlights** | **List&lt;string&gt;** | Highlight Items | [optional] 
**DomainAdId** | **int?** | Domain Ad ID | [optional] 
**InspectionDetails** | [**ListingAdminV2InspectionDetails**](ListingAdminV2InspectionDetails.md) |  | [optional] 
**IsRural** | **bool?** | True if the property is rural | [optional] 
**ListingProvider** | **string** | A string identifying the data provider | [optional] 
**DomainAgencyID** | **int?** | The Domain Agency ID | 
**ProviderAdId** | **string** | External Advertisement Id of up to 50 characters will be stored.&lt;br /&gt;  This value is used to identify an Advertisement for updates and should be unique for listing provider.&lt;br /&gt;  This value is case-insensitive (meaning AAAA will update aaaa). | 
**Description** | **string** | Description of the property.  6000 characters in length. The following HTML elements are permitted: &amp;lt;br /&amp;gt;, &amp;lt;p&amp;gt;&amp;lt;/p&amp;gt;, &amp;amp;nbsp;. HTML must be well-formed.  Carriage Returns are interpreted as line breaks. Foreign characters must be HTML encoded, e.g., façade for façade | [optional] 
**Summary** | **string** | &#x27;Headline&#x27; Any HTML stripped out.  If the Summary is less than 80 characters long then the description is concatenated to it and the total trimmed to 250 characters. | [optional] 
**Contacts** | [**List&lt;ListingAdminV2Contact&gt;**](ListingAdminV2Contact.md) | Minimum required attributes: First name, last name and E-mail.  If the DomainAgentId is provided, contact information will be based on the existing agent found for that id.  Otherwise first name, last name and email will be used to find the matching contact. A new contact will be created if no contact can be found. | [optional] 
**ListingAction** | **string** | Sale or Rent | 
**OffMarketDetails** | [**ListingAdminV2OffMarketDetailsBase**](ListingAdminV2OffMarketDetailsBase.md) |  | 
**PropertyDetails** | [**ListingAdminV2CommercialOffMarketProperty**](ListingAdminV2CommercialOffMarketProperty.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

