# Domain.Api.SchoolsApi

All URIs are relative to *http://api.domain.com.au/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SchoolsGetById**](SchoolsApi.md#schoolsgetbyid) | **GET** /v2/schools/{id} | Retrieve the details of a school by Id
[**SchoolsSearchByLocation**](SchoolsApi.md#schoolssearchbylocation) | **GET** /v2/schools/{latitude}/{longitude} | Search for a school in a location

<a name="schoolsgetbyid"></a>
# **SchoolsGetById**
> School SchoolsGetById (int? id)

Retrieve the details of a school by Id

Domain School Ids can be obtained from the search by location endpoint.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class SchoolsGetByIdExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsApi();
            var id = 56;  // int? | School id

            try
            {
                // Retrieve the details of a school by Id
                School result = apiInstance.SchoolsGetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolsApi.SchoolsGetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| School id | 

### Return type

[**School**](School.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="schoolssearchbylocation"></a>
# **SchoolsSearchByLocation**
> List<SchoolWithDistance> SchoolsSearchByLocation (double? latitude, double? longitude)

Search for a school in a location

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class SchoolsSearchByLocationExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchoolsApi();
            var latitude = 1.2;  // double? | Latitude to search
            var longitude = 1.2;  // double? | Longitude to search

            try
            {
                // Search for a school in a location
                List&lt;SchoolWithDistance&gt; result = apiInstance.SchoolsSearchByLocation(latitude, longitude);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SchoolsApi.SchoolsSearchByLocation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **latitude** | **double?**| Latitude to search | 
 **longitude** | **double?**| Longitude to search | 

### Return type

[**List<SchoolWithDistance>**](SchoolWithDistance.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
