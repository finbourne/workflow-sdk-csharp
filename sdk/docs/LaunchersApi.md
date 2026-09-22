# Finbourne.Workflow.Sdk.Api.LaunchersApi

All URIs are relative to *https://fbn-prd.lusid.com/workflow*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateLauncher**](LaunchersApi.md#createlauncher) | **POST** /api/workflows/{scope}/{code}/launchers | [EXPERIMENTAL] CreateLauncher: Create a new Launcher on a Workflow |
| [**DeleteLauncher**](LaunchersApi.md#deletelauncher) | **DELETE** /api/workflows/{scope}/{code}/launchers/{launcherId} | [EXPERIMENTAL] DeleteLauncher: Delete a Launcher of a Workflow |
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

