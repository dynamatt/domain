# Domain.Api.ListingsApi

All URIs are relative to *http://api.domain.com.au/*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ListingsUpsertbusinessoffmarket**](ListingsApi.md#listingsupsertbusinessoffmarket) | **POST** /v2/listings/business/offmarket | Creates an externally sold business listing; or takes an existing business listing off the market.
[**ListingsUpsertcommerciallisting**](ListingsApi.md#listingsupsertcommerciallisting) | **PUT** /v2/listings/commercial | Creates a commercial listing.
[**ListingsUpsertcommercialoffmarket**](ListingsApi.md#listingsupsertcommercialoffmarket) | **POST** /v2/listings/commercial/offmarket | Creates an externally sold or leased commercial listing; or takes an existing commercial listing off the market.
[**ListingsUpsertresidentialoffmarket**](ListingsApi.md#listingsupsertresidentialoffmarket) | **POST** /v2/listings/residential/offmarket | Creates an externally sold or leased residential listing; or takes an existing residential listing off the market.
[**PreMarketGet**](ListingsApi.md#premarketget) | **GET** /v2/premarket/listings/{id} | Retrieves a pre-portal listing.
[**PreMarketPatch**](ListingsApi.md#premarketpatch) | **PATCH** /v2/premarket/listings/{id} | Patch document based on the listing Id
[**PreMarketPost**](ListingsApi.md#premarketpost) | **POST** /v2/premarket/listings | Creates or updates a pre-portal listing.

<a name="listingsupsertbusinessoffmarket"></a>
# **ListingsUpsertbusinessoffmarket**
> ListingAdminV2ListingResponse ListingsUpsertbusinessoffmarket (ListingAdminV2BusinessOffMarketListing body)

Creates an externally sold business listing; or takes an existing business listing off the market.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class ListingsUpsertbusinessoffmarketExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListingsApi();
            var body = new ListingAdminV2BusinessOffMarketListing(); // ListingAdminV2BusinessOffMarketListing | Listing data

            try
            {
                // Creates an externally sold business listing; or takes an existing business listing off the market.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertbusinessoffmarket(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertbusinessoffmarket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListingAdminV2BusinessOffMarketListing**](ListingAdminV2BusinessOffMarketListing.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listingsupsertcommerciallisting"></a>
# **ListingsUpsertcommerciallisting**
> ListingAdminV2ListingResponse ListingsUpsertcommerciallisting (ListingAdminV2CommercialListingV2 body)

Creates a commercial listing.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class ListingsUpsertcommerciallistingExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListingsApi();
            var body = new ListingAdminV2CommercialListingV2(); // ListingAdminV2CommercialListingV2 | Listing data

            try
            {
                // Creates a commercial listing.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertcommerciallisting(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertcommerciallisting: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListingAdminV2CommercialListingV2**](ListingAdminV2CommercialListingV2.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listingsupsertcommercialoffmarket"></a>
# **ListingsUpsertcommercialoffmarket**
> ListingAdminV2ListingResponse ListingsUpsertcommercialoffmarket (ListingAdminV2CommercialOffMarketListing body)

Creates an externally sold or leased commercial listing; or takes an existing commercial listing off the market.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class ListingsUpsertcommercialoffmarketExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListingsApi();
            var body = new ListingAdminV2CommercialOffMarketListing(); // ListingAdminV2CommercialOffMarketListing | Listing data

            try
            {
                // Creates an externally sold or leased commercial listing; or takes an existing commercial listing off the market.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertcommercialoffmarket(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertcommercialoffmarket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListingAdminV2CommercialOffMarketListing**](ListingAdminV2CommercialOffMarketListing.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="listingsupsertresidentialoffmarket"></a>
# **ListingsUpsertresidentialoffmarket**
> ListingAdminV2ListingResponse ListingsUpsertresidentialoffmarket (ListingAdminV2ResidentialOffMarketListing body)

Creates an externally sold or leased residential listing; or takes an existing residential listing off the market.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class ListingsUpsertresidentialoffmarketExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListingsApi();
            var body = new ListingAdminV2ResidentialOffMarketListing(); // ListingAdminV2ResidentialOffMarketListing | Listing data

            try
            {
                // Creates an externally sold or leased residential listing; or takes an existing residential listing off the market.
                ListingAdminV2ListingResponse result = apiInstance.ListingsUpsertresidentialoffmarket(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.ListingsUpsertresidentialoffmarket: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ListingAdminV2ResidentialOffMarketListing**](ListingAdminV2ResidentialOffMarketListing.md)| Listing data | 

### Return type

[**ListingAdminV2ListingResponse**](ListingAdminV2ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="premarketget"></a>
# **PreMarketGet**
> PreMarketV1ListingResponse PreMarketGet (string id)

Retrieves a pre-portal listing.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class PreMarketGetExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListingsApi();
            var id = id_example;  // string | Pre-portal listing ID.

            try
            {
                // Retrieves a pre-portal listing.
                PreMarketV1ListingResponse result = apiInstance.PreMarketGet(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.PreMarketGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Pre-portal listing ID. | 

### Return type

[**PreMarketV1ListingResponse**](PreMarketV1ListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="premarketpatch"></a>
# **PreMarketPatch**
> PreMarketV1ListingRequest PreMarketPatch (string id, PreMarketV1ListingRequestJsonPatchDocument body = null)

Patch document based on the listing Id

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class PreMarketPatchExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListingsApi();
            var id = id_example;  // string | 
            var body = new PreMarketV1ListingRequestJsonPatchDocument(); // PreMarketV1ListingRequestJsonPatchDocument | ```
Examples:
[
{
	"op": "replace",
	"path": "/bedrooms",
	"value": 3
   },
{
	"op": "replace",
	"path": "/listingStatus",
	"value": "sold"
},
{
	"op": "remove",
	"path": "/StatementOfInformation"
},
{
	"op": "add",
	"path": "/contacts/-",
	"value": {
		"firstName": "lily",
		"lastName": "li",
		"email": "lily.li@domain.com.au",
		"phone": "0411111111",
		"mobile": null,
		"fax": null
	}
}
]
``` (optional) 

            try
            {
                // Patch document based on the listing Id
                PreMarketV1ListingRequest result = apiInstance.PreMarketPatch(id, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.PreMarketPatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**|  | 
 **body** | [**PreMarketV1ListingRequestJsonPatchDocument**](PreMarketV1ListingRequestJsonPatchDocument.md)| &#x60;&#x60;&#x60;
Examples:
[
{
	&quot;op&quot;: &quot;replace&quot;,
	&quot;path&quot;: &quot;/bedrooms&quot;,
	&quot;value&quot;: 3
   },
{
	&quot;op&quot;: &quot;replace&quot;,
	&quot;path&quot;: &quot;/listingStatus&quot;,
	&quot;value&quot;: &quot;sold&quot;
},
{
	&quot;op&quot;: &quot;remove&quot;,
	&quot;path&quot;: &quot;/StatementOfInformation&quot;
},
{
	&quot;op&quot;: &quot;add&quot;,
	&quot;path&quot;: &quot;/contacts/-&quot;,
	&quot;value&quot;: {
		&quot;firstName&quot;: &quot;lily&quot;,
		&quot;lastName&quot;: &quot;li&quot;,
		&quot;email&quot;: &quot;lily.li@domain.com.au&quot;,
		&quot;phone&quot;: &quot;0411111111&quot;,
		&quot;mobile&quot;: null,
		&quot;fax&quot;: null
	}
}
]
&#x60;&#x60;&#x60; | [optional] 

### Return type

[**PreMarketV1ListingRequest**](PreMarketV1ListingRequest.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="premarketpost"></a>
# **PreMarketPost**
> PreMarketV1CreateOrUpdateListingResponse PreMarketPost (PreMarketV1ListingRequest body = null)

Creates or updates a pre-portal listing.

### Example
```csharp
using System;
using System.Diagnostics;
using Domain.Api;
using Domain.Client;
using Domain.Model;

namespace Example
{
    public class PreMarketPostExample
    {
        public void main()
        {
            // Configure API key authorization: apikey
            Configuration.Default.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ListingsApi();
            var body = new PreMarketV1ListingRequest(); // PreMarketV1ListingRequest | Pre-portal listing request. (optional) 

            try
            {
                // Creates or updates a pre-portal listing.
                PreMarketV1CreateOrUpdateListingResponse result = apiInstance.PreMarketPost(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ListingsApi.PreMarketPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PreMarketV1ListingRequest**](PreMarketV1ListingRequest.md)| Pre-portal listing request. | [optional] 

### Return type

[**PreMarketV1CreateOrUpdateListingResponse**](PreMarketV1CreateOrUpdateListingResponse.md)

### Authorization

[apikey](../README.md#apikey), [oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
