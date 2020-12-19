# Domain.Api.SuburbPerformanceStatisticsApi

All URIs are relative to *http://api.domain.com.au/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SuburbPerformanceGetByNamedSuburb**](SuburbPerformanceStatisticsApi.md#suburbperformancegetbynamedsuburb) | **GET** /v2/suburbPerformanceStatistics/{state}/{suburb}/{postcode} | Search for sales statistics in a given geographic level.

<a name="suburbperformancegetbynamedsuburb"></a>
# **SuburbPerformanceGetByNamedSuburb**
> APMAPIModelsSuburbV2SuburbPerformanceModel SuburbPerformanceGetByNamedSuburb (string state, string suburb, string postcode, SuburbPerformancePropertyCategory propertyCategory = null, int? bedrooms = null, SuburbPerformancePeriodSize periodSize = null, int? startingPeriodRelativeToCurrent = null, int? totalPeriods = null)

Search for sales statistics in a given geographic level.

- Standard Auction Clearance Rate formula is: `AuctionNumberSold / (AuctionNumberAuctioned + AuctionNumberWithdrawn)`  - The Rate is considered Not Statistic Reliable if: `AuctionNumberAuctioned + AuctionNumberWithdrawn < 10`  - APM Standard Gross Rental Yield formula is: `(MedianRentListingPrice* 52) / MedianSoldPrice`  - The Yield is considered Not Available if: `MedianRentListingPrice is null or MedianSoldPrice is null`

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class SuburbPerformanceGetByNamedSuburbExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuburbPerformanceStatisticsApi();
            var state = state_example;  // string | The Australian state abbreviation
            var suburb = suburb_example;  // string | Suburb name to retrieve data for
            var postcode = postcode_example;  // string | Suburb Post Code, optional, but required for suburbs with official post codes.
            var propertyCategory = new SuburbPerformancePropertyCategory(); // SuburbPerformancePropertyCategory | Category of sales results to show. Possible values: `House`, `Unit` (optional) 
            var bedrooms = 56;  // int? | Number of bedrooms to use in the sales search (optional) 
            var periodSize = new SuburbPerformancePeriodSize(); // SuburbPerformancePeriodSize | Unit of the measurement period to use (optional) 
            var startingPeriodRelativeToCurrent = 56;  // int? | When to start stats from. 1 = current period, 2 = previous period, etc. (optional)  (default to 1)
            var totalPeriods = 56;  // int? | Number of total periods to show statistics for. i.e. 4 Quarters would be 1 full year (optional)  (default to 4)

            try
            {
                // Search for sales statistics in a given geographic level.
                APMAPIModelsSuburbV2SuburbPerformanceModel result = apiInstance.SuburbPerformanceGetByNamedSuburb(state, suburb, postcode, propertyCategory, bedrooms, periodSize, startingPeriodRelativeToCurrent, totalPeriods);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuburbPerformanceStatisticsApi.SuburbPerformanceGetByNamedSuburb: " + e.Message );
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
 **propertyCategory** | [**SuburbPerformancePropertyCategory**](SuburbPerformancePropertyCategory.md)| Category of sales results to show. Possible values: &#x60;House&#x60;, &#x60;Unit&#x60; | [optional] 
 **bedrooms** | **int?**| Number of bedrooms to use in the sales search | [optional] 
 **periodSize** | [**SuburbPerformancePeriodSize**](SuburbPerformancePeriodSize.md)| Unit of the measurement period to use | [optional] 
 **startingPeriodRelativeToCurrent** | **int?**| When to start stats from. 1 &#x3D; current period, 2 &#x3D; previous period, etc. | [optional] [default to 1]
 **totalPeriods** | **int?**| Number of total periods to show statistics for. i.e. 4 Quarters would be 1 full year | [optional] [default to 4]

### Return type

[**APMAPIModelsSuburbV2SuburbPerformanceModel**](APMAPIModelsSuburbV2SuburbPerformanceModel.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
