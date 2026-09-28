# Finbourne.Workflow.Sdk.Api.LaunchersApi

All URIs are relative to *https://fbn-prd.lusid.com/workflow*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateLauncher**](LaunchersApi.md#createlauncher) | **POST** /api/workflows/{scope}/{code}/launchers | [EXPERIMENTAL] CreateLauncher: Create a new Launcher on a Workflow |
| [**DeleteLauncher**](LaunchersApi.md#deletelauncher) | **DELETE** /api/workflows/{scope}/{code}/launchers/{launcherId} | [EXPERIMENTAL] DeleteLauncher: Delete a Launcher of a Workflow |
| [**GetLauncher**](LaunchersApi.md#getlauncher) | **GET** /api/workflows/{scope}/{code}/launchers/{launcherId} | [EXPERIMENTAL] GetLauncher: Get a Launcher of a Workflow |
| [**ListLaunchers**](LaunchersApi.md#listlaunchers) | **GET** /api/workflows/{scope}/{code}/launchers | [EXPERIMENTAL] ListLaunchers: List the Launchers of a Workflow |
| [**UpdateLauncher**](LaunchersApi.md#updatelauncher) | **PUT** /api/workflows/{scope}/{code}/launchers/{launcherId} | [EXPERIMENTAL] UpdateLauncher: Update an existing Launcher of a Workflow |

<a id="createlauncher"></a>
# **CreateLauncher**
> LauncherResponse CreateLauncher (string scope, string code, CreateLauncherRequest createLauncherRequest)

[EXPERIMENTAL] CreateLauncher: Create a new Launcher on a Workflow

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Extensions;
using Finbourne.Workflow.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""workflowUrl"": ""https://<your-domain>.lusid.com/workflow"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LaunchersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LaunchersApi>();
            var scope = "scope_example";  // string | The scope that identifies the Workflow that owns the Launcher
            var code = "code_example";  // string | The code that identifies the Workflow that owns the Launcher
            var createLauncherRequest = new CreateLauncherRequest(); // CreateLauncherRequest | The data to create a Launcher

            try
            {
                // uncomment the below to set overrides at the request level
                // LauncherResponse result = apiInstance.CreateLauncher(scope, code, createLauncherRequest, opts: opts);

                // [EXPERIMENTAL] CreateLauncher: Create a new Launcher on a Workflow
                LauncherResponse result = apiInstance.CreateLauncher(scope, code, createLauncherRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LaunchersApi.CreateLauncher: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateLauncherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateLauncher: Create a new Launcher on a Workflow
    ApiResponse<LauncherResponse> response = apiInstance.CreateLauncherWithHttpInfo(scope, code, createLauncherRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LaunchersApi.CreateLauncherWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies the Workflow that owns the Launcher |  |
| **code** | **string** | The code that identifies the Workflow that owns the Launcher |  |
| **createLauncherRequest** | [**CreateLauncherRequest**](CreateLauncherRequest.md) | The data to create a Launcher |  |

### Return type

[**LauncherResponse**](LauncherResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Workflow not found. |  -  |
| **409** | Launcher already exists. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletelauncher"></a>
# **DeleteLauncher**
> DeletedEntityResponse DeleteLauncher (string scope, string code, string launcherId)

[EXPERIMENTAL] DeleteLauncher: Delete a Launcher of a Workflow

If the Launcher does not exist a failure will be returned

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Extensions;
using Finbourne.Workflow.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""workflowUrl"": ""https://<your-domain>.lusid.com/workflow"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LaunchersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LaunchersApi>();
            var scope = "scope_example";  // string | The scope that identifies the Workflow that owns the Launcher
            var code = "code_example";  // string | The code that identifies the Workflow that owns the Launcher
            var launcherId = "launcherId_example";  // string | The identifier of the Launcher inside its Workflow

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteLauncher(scope, code, launcherId, opts: opts);

                // [EXPERIMENTAL] DeleteLauncher: Delete a Launcher of a Workflow
                DeletedEntityResponse result = apiInstance.DeleteLauncher(scope, code, launcherId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LaunchersApi.DeleteLauncher: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteLauncherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteLauncher: Delete a Launcher of a Workflow
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteLauncherWithHttpInfo(scope, code, launcherId);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LaunchersApi.DeleteLauncherWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies the Workflow that owns the Launcher |  |
| **code** | **string** | The code that identifies the Workflow that owns the Launcher |  |
| **launcherId** | **string** | The identifier of the Launcher inside its Workflow |  |

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Launcher not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getlauncher"></a>
# **GetLauncher**
> LauncherResponse GetLauncher (string scope, string code, string launcherId, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetLauncher: Get a Launcher of a Workflow

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Extensions;
using Finbourne.Workflow.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""workflowUrl"": ""https://<your-domain>.lusid.com/workflow"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LaunchersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LaunchersApi>();
            var scope = "scope_example";  // string | The scope that identifies the Workflow that owns the Launcher
            var code = "code_example";  // string | The code that identifies the Workflow that owns the Launcher
            var launcherId = "launcherId_example";  // string | The identifier of the Launcher inside its Workflow
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Launcher. Defaults to returning the latest             version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // LauncherResponse result = apiInstance.GetLauncher(scope, code, launcherId, asAt, opts: opts);

                // [EXPERIMENTAL] GetLauncher: Get a Launcher of a Workflow
                LauncherResponse result = apiInstance.GetLauncher(scope, code, launcherId, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LaunchersApi.GetLauncher: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLauncherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetLauncher: Get a Launcher of a Workflow
    ApiResponse<LauncherResponse> response = apiInstance.GetLauncherWithHttpInfo(scope, code, launcherId, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LaunchersApi.GetLauncherWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies the Workflow that owns the Launcher |  |
| **code** | **string** | The code that identifies the Workflow that owns the Launcher |  |
| **launcherId** | **string** | The identifier of the Launcher inside its Workflow |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Launcher. Defaults to returning the latest             version if not specified. | [optional]  |

### Return type

[**LauncherResponse**](LauncherResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Launcher not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listlaunchers"></a>
# **ListLaunchers**
> PagedResourceListOfLauncherResponse ListLaunchers (string scope, string code, DateTimeOffset? asAt = null, string? filter = null, List<string>? sortBy = null, int? limit = null, string? page = null)

[EXPERIMENTAL] ListLaunchers: List the Launchers of a Workflow

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Extensions;
using Finbourne.Workflow.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""workflowUrl"": ""https://<your-domain>.lusid.com/workflow"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LaunchersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LaunchersApi>();
            var scope = "scope_example";  // string | The scope that identifies the Workflow that owns the Launchers
            var code = "code_example";  // string | The code that identifies the Workflow that owns the Launchers
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Launchers. Defaults to return the latest version             of each Launcher if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:             https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". Defaults to             \"launcherId ASC\" if not specified. (optional) 
            var limit = 10;  // int? | When paginating, limit the number of returned results to this many. (optional)  (default to 10)
            var page = "page_example";  // string? | The pagination token to use to continue listing Launchers from a previous call to list             Launchers. This value is returned from the previous call. If a pagination token is provided the sortBy,             filter, and asAt fields must not have changed since the original request. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfLauncherResponse result = apiInstance.ListLaunchers(scope, code, asAt, filter, sortBy, limit, page, opts: opts);

                // [EXPERIMENTAL] ListLaunchers: List the Launchers of a Workflow
                PagedResourceListOfLauncherResponse result = apiInstance.ListLaunchers(scope, code, asAt, filter, sortBy, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LaunchersApi.ListLaunchers: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLaunchersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListLaunchers: List the Launchers of a Workflow
    ApiResponse<PagedResourceListOfLauncherResponse> response = apiInstance.ListLaunchersWithHttpInfo(scope, code, asAt, filter, sortBy, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LaunchersApi.ListLaunchersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies the Workflow that owns the Launchers |  |
| **code** | **string** | The code that identifies the Workflow that owns the Launchers |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Launchers. Defaults to return the latest version             of each Launcher if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:             https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. Defaults to             \&quot;launcherId ASC\&quot; if not specified. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional] [default to 10] |
| **page** | **string?** | The pagination token to use to continue listing Launchers from a previous call to list             Launchers. This value is returned from the previous call. If a pagination token is provided the sortBy,             filter, and asAt fields must not have changed since the original request. | [optional]  |

### Return type

[**PagedResourceListOfLauncherResponse**](PagedResourceListOfLauncherResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Workflow not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatelauncher"></a>
# **UpdateLauncher**
> LauncherResponse UpdateLauncher (string scope, string code, string launcherId, UpdateLauncherRequest updateLauncherRequest)

[EXPERIMENTAL] UpdateLauncher: Update an existing Launcher of a Workflow

The type of a Launcher cannot be changed

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Extensions;
using Finbourne.Workflow.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""workflowUrl"": ""https://<your-domain>.lusid.com/workflow"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<LaunchersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<LaunchersApi>();
            var scope = "scope_example";  // string | The scope that identifies the Workflow that owns the Launcher
            var code = "code_example";  // string | The code that identifies the Workflow that owns the Launcher
            var launcherId = "launcherId_example";  // string | The identifier of the Launcher inside its Workflow
            var updateLauncherRequest = new UpdateLauncherRequest(); // UpdateLauncherRequest | The data to update a Launcher

            try
            {
                // uncomment the below to set overrides at the request level
                // LauncherResponse result = apiInstance.UpdateLauncher(scope, code, launcherId, updateLauncherRequest, opts: opts);

                // [EXPERIMENTAL] UpdateLauncher: Update an existing Launcher of a Workflow
                LauncherResponse result = apiInstance.UpdateLauncher(scope, code, launcherId, updateLauncherRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling LaunchersApi.UpdateLauncher: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateLauncherWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateLauncher: Update an existing Launcher of a Workflow
    ApiResponse<LauncherResponse> response = apiInstance.UpdateLauncherWithHttpInfo(scope, code, launcherId, updateLauncherRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling LaunchersApi.UpdateLauncherWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies the Workflow that owns the Launcher |  |
| **code** | **string** | The code that identifies the Workflow that owns the Launcher |  |
| **launcherId** | **string** | The identifier of the Launcher inside its Workflow |  |
| **updateLauncherRequest** | [**UpdateLauncherRequest**](UpdateLauncherRequest.md) | The data to update a Launcher |  |

### Return type

[**LauncherResponse**](LauncherResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Launcher not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

