# Domain.Api.DemographicsApi

All URIs are relative to *http://api.domain.com.au/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DemographicsGetByNamedSuburb**](DemographicsApi.md#demographicsgetbynamedsuburb) | **GET** /v2/demographics/{state}/{suburb}/{postcode} | Search for demographics in a given geographic level.
[**DemographicsGetByNamedSuburbWithoutPostcode**](DemographicsApi.md#demographicsgetbynamedsuburbwithoutpostcode) | **GET** /v2/demographics/{state}/{suburb} | Search for demographics in a given geographic level.

<a name="demographicsgetbynamedsuburb"></a>
# **DemographicsGetByNamedSuburb**
> DemographicsResultsModel DemographicsGetByNamedSuburb (string state, string suburb, string postcode, string types = null, int? year = null)

Search for demographics in a given geographic level.

<br>Where available, all available topics and years will be returned if not supplied.  <br>Note that not all suburbs will have data available for all years and topics.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class DemographicsGetByNamedSuburbExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsApi();
            var state = state_example;  // string | The Australian state abbreviation
            var suburb = suburb_example;  // string | Suburb name to retrieve data for
            var postcode = postcode_example;  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var types = types_example;  // string | Comma separated list of census topics to retrieve demographic data for. Possible values include:              `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`,              `Occupation`, `GeographicalPopulation`, `DwellingStructure`,              `EducationAttendance`, `HousingLoanRepayment`, `MaritalStatus`,              `Religion`, `TransportToWork`, `FamilyComposition`,              `HouseholdIncome`, `Rent`, `LabourForceStatus` (optional) 
            var year = 56;  // int? | Census Year of data to return (optional) 

            try
            {
                // Search for demographics in a given geographic level.
                DemographicsResultsModel result = apiInstance.DemographicsGetByNamedSuburb(state, suburb, postcode, types, year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DemographicsApi.DemographicsGetByNamedSuburb: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| The Australian state abbreviation | 
 **suburb** | **string**| Suburb name to retrieve data for | 
 **postcode** | **string**| Suburb Post Code, optional, but required for suburbs with official post codes. | 
 **types** | **string**| Comma separated list of census topics to retrieve demographic data for. Possible values include:              &#x60;AgeGroupOfPopulation&#x60;, &#x60;CountryOfBirth&#x60;, &#x60;NatureOfOccupancy&#x60;,              &#x60;Occupation&#x60;, &#x60;GeographicalPopulation&#x60;, &#x60;DwellingStructure&#x60;,              &#x60;EducationAttendance&#x60;, &#x60;HousingLoanRepayment&#x60;, &#x60;MaritalStatus&#x60;,              &#x60;Religion&#x60;, &#x60;TransportToWork&#x60;, &#x60;FamilyComposition&#x60;,              &#x60;HouseholdIncome&#x60;, &#x60;Rent&#x60;, &#x60;LabourForceStatus&#x60; | [optional] 
 **year** | **int?**| Census Year of data to return | [optional] 

### Return type

[**DemographicsResultsModel**](DemographicsResultsModel.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="demographicsgetbynamedsuburbwithoutpostcode"></a>
# **DemographicsGetByNamedSuburbWithoutPostcode**
> DemographicsResultsModel DemographicsGetByNamedSuburbWithoutPostcode (string state, string suburb, string postcode, string types = null, int? year = null)

Search for demographics in a given geographic level.

<br>Where available, all available topics and years will be returned if not supplied.  <br>Note that not all suburbs will have data available for all years and topics.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class DemographicsGetByNamedSuburbWithoutPostcodeExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DemographicsApi();
            var state = state_example;  // string | The Australian state abbreviation
            var suburb = suburb_example;  // string | Suburb name to retrieve data for
            var postcode = postcode_example;  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var types = types_example;  // string | Comma separated list of census topics to retrieve demographic data for. Possible values include:              `AgeGroupOfPopulation`, `CountryOfBirth`, `NatureOfOccupancy`,              `Occupation`, `GeographicalPopulation`, `DwellingStructure`,              `EducationAttendance`, `HousingLoanRepayment`, `MaritalStatus`,              `Religion`, `TransportToWork`, `FamilyComposition`,              `HouseholdIncome`, `Rent`, `LabourForceStatus` (optional) 
            var year = 56;  // int? | Census Year of data to return (optional) 

            try
            {
                // Search for demographics in a given geographic level.
                DemographicsResultsModel result = apiInstance.DemographicsGetByNamedSuburbWithoutPostcode(state, suburb, postcode, types, year);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DemographicsApi.DemographicsGetByNamedSuburbWithoutPostcode: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **string**| The Australian state abbreviation | 
 **suburb** | **string**| Suburb name to retrieve data for | 
 **postcode** | **string**| Suburb Post Code, optional, but required for suburbs with official post codes. | 
 **types** | **string**| Comma separated list of census topics to retrieve demographic data for. Possible values include:              &#x60;AgeGroupOfPopulation&#x60;, &#x60;CountryOfBirth&#x60;, &#x60;NatureOfOccupancy&#x60;,              &#x60;Occupation&#x60;, &#x60;GeographicalPopulation&#x60;, &#x60;DwellingStructure&#x60;,              &#x60;EducationAttendance&#x60;, &#x60;HousingLoanRepayment&#x60;, &#x60;MaritalStatus&#x60;,              &#x60;Religion&#x60;, &#x60;TransportToWork&#x60;, &#x60;FamilyComposition&#x60;,              &#x60;HouseholdIncome&#x60;, &#x60;Rent&#x60;, &#x60;LabourForceStatus&#x60; | [optional] 
 **year** | **int?**| Census Year of data to return | [optional] 

### Return type

[**DemographicsResultsModel**](DemographicsResultsModel.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
