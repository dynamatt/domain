/* 
 * Domain Public API
 *
 * See https://developer.domain.com.au for more information
 *
 * OpenAPI spec version: v2
 * Contact: api@domain.com.au
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Domain.Client;
using Domain.Model;

namespace Domain.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface ISchoolsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieve the details of a school by Id
        /// </summary>
        /// <remarks>
        /// Domain School Ids can be obtained from the search by location endpoint.
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>School</returns>
        School SchoolsGetById (int? id);

        /// <summary>
        /// Retrieve the details of a school by Id
        /// </summary>
        /// <remarks>
        /// Domain School Ids can be obtained from the search by location endpoint.
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>ApiResponse of School</returns>
        ApiResponse<School> SchoolsGetByIdWithHttpInfo (int? id);
        /// <summary>
        /// Search for a school in a location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>List&lt;SchoolWithDistance&gt;</returns>
        List<SchoolWithDistance> SchoolsSearchByLocation (double? latitude, double? longitude);

        /// <summary>
        /// Search for a school in a location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>ApiResponse of List&lt;SchoolWithDistance&gt;</returns>
        ApiResponse<List<SchoolWithDistance>> SchoolsSearchByLocationWithHttpInfo (double? latitude, double? longitude);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieve the details of a school by Id
        /// </summary>
        /// <remarks>
        /// Domain School Ids can be obtained from the search by location endpoint.
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>Task of School</returns>
        System.Threading.Tasks.Task<School> SchoolsGetByIdAsync (int? id);

        /// <summary>
        /// Retrieve the details of a school by Id
        /// </summary>
        /// <remarks>
        /// Domain School Ids can be obtained from the search by location endpoint.
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>Task of ApiResponse (School)</returns>
        System.Threading.Tasks.Task<ApiResponse<School>> SchoolsGetByIdAsyncWithHttpInfo (int? id);
        /// <summary>
        /// Search for a school in a location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>Task of List&lt;SchoolWithDistance&gt;</returns>
        System.Threading.Tasks.Task<List<SchoolWithDistance>> SchoolsSearchByLocationAsync (double? latitude, double? longitude);

        /// <summary>
        /// Search for a school in a location
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>Task of ApiResponse (List&lt;SchoolWithDistance&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SchoolWithDistance>>> SchoolsSearchByLocationAsyncWithHttpInfo (double? latitude, double? longitude);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class SchoolsApi : ISchoolsApi
    {
        private Domain.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SchoolsApi(String basePath)
        {
            this.Configuration = new Domain.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Domain.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolsApi"/> class
        /// </summary>
        /// <returns></returns>
        public SchoolsApi()
        {
            this.Configuration = Domain.Client.Configuration.Default;

            ExceptionFactory = Domain.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SchoolsApi(Domain.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Domain.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Domain.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Domain.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Domain.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Retrieve the details of a school by Id Domain School Ids can be obtained from the search by location endpoint.
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>School</returns>
        public School SchoolsGetById (int? id)
        {
             ApiResponse<School> localVarResponse = SchoolsGetByIdWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieve the details of a school by Id Domain School Ids can be obtained from the search by location endpoint.
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>ApiResponse of School</returns>
        public ApiResponse< School > SchoolsGetByIdWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SchoolsApi->SchoolsGetById");

            var localVarPath = "/v2/schools/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarHeaderParams["x-api-key"] = this.Configuration.GetApiKeyWithPrefix("x-api-key");
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SchoolsGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<School>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (School) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(School)));
        }

        /// <summary>
        /// Retrieve the details of a school by Id Domain School Ids can be obtained from the search by location endpoint.
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>Task of School</returns>
        public async System.Threading.Tasks.Task<School> SchoolsGetByIdAsync (int? id)
        {
             ApiResponse<School> localVarResponse = await SchoolsGetByIdAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieve the details of a school by Id Domain School Ids can be obtained from the search by location endpoint.
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">School id</param>
        /// <returns>Task of ApiResponse (School)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<School>> SchoolsGetByIdAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SchoolsApi->SchoolsGetById");

            var localVarPath = "/v2/schools/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarHeaderParams["x-api-key"] = this.Configuration.GetApiKeyWithPrefix("x-api-key");
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SchoolsGetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<School>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (School) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(School)));
        }

        /// <summary>
        /// Search for a school in a location 
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>List&lt;SchoolWithDistance&gt;</returns>
        public List<SchoolWithDistance> SchoolsSearchByLocation (double? latitude, double? longitude)
        {
             ApiResponse<List<SchoolWithDistance>> localVarResponse = SchoolsSearchByLocationWithHttpInfo(latitude, longitude);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search for a school in a location 
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>ApiResponse of List&lt;SchoolWithDistance&gt;</returns>
        public ApiResponse< List<SchoolWithDistance> > SchoolsSearchByLocationWithHttpInfo (double? latitude, double? longitude)
        {
            // verify the required parameter 'latitude' is set
            if (latitude == null)
                throw new ApiException(400, "Missing required parameter 'latitude' when calling SchoolsApi->SchoolsSearchByLocation");
            // verify the required parameter 'longitude' is set
            if (longitude == null)
                throw new ApiException(400, "Missing required parameter 'longitude' when calling SchoolsApi->SchoolsSearchByLocation");

            var localVarPath = "/v2/schools/{latitude}/{longitude}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (latitude != null) localVarPathParams.Add("latitude", this.Configuration.ApiClient.ParameterToString(latitude)); // path parameter
            if (longitude != null) localVarPathParams.Add("longitude", this.Configuration.ApiClient.ParameterToString(longitude)); // path parameter
            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarHeaderParams["x-api-key"] = this.Configuration.GetApiKeyWithPrefix("x-api-key");
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SchoolsSearchByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SchoolWithDistance>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SchoolWithDistance>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SchoolWithDistance>)));
        }

        /// <summary>
        /// Search for a school in a location 
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>Task of List&lt;SchoolWithDistance&gt;</returns>
        public async System.Threading.Tasks.Task<List<SchoolWithDistance>> SchoolsSearchByLocationAsync (double? latitude, double? longitude)
        {
             ApiResponse<List<SchoolWithDistance>> localVarResponse = await SchoolsSearchByLocationAsyncWithHttpInfo(latitude, longitude);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search for a school in a location 
        /// </summary>
        /// <exception cref="Domain.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="latitude">Latitude to search</param>
        /// <param name="longitude">Longitude to search</param>
        /// <returns>Task of ApiResponse (List&lt;SchoolWithDistance&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SchoolWithDistance>>> SchoolsSearchByLocationAsyncWithHttpInfo (double? latitude, double? longitude)
        {
            // verify the required parameter 'latitude' is set
            if (latitude == null)
                throw new ApiException(400, "Missing required parameter 'latitude' when calling SchoolsApi->SchoolsSearchByLocation");
            // verify the required parameter 'longitude' is set
            if (longitude == null)
                throw new ApiException(400, "Missing required parameter 'longitude' when calling SchoolsApi->SchoolsSearchByLocation");

            var localVarPath = "/v2/schools/{latitude}/{longitude}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (latitude != null) localVarPathParams.Add("latitude", this.Configuration.ApiClient.ParameterToString(latitude)); // path parameter
            if (longitude != null) localVarPathParams.Add("longitude", this.Configuration.ApiClient.ParameterToString(longitude)); // path parameter
            // authentication (apikey) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("x-api-key")))
            {
                localVarHeaderParams["x-api-key"] = this.Configuration.GetApiKeyWithPrefix("x-api-key");
            }
            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SchoolsSearchByLocation", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SchoolWithDistance>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (List<SchoolWithDistance>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SchoolWithDistance>)));
        }

    }
}
