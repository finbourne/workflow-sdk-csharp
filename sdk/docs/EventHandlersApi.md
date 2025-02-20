# Finbourne.Workflow.Sdk.Api.EventHandlersApi

All URIs are relative to *https://fbn-prd.lusid.com/workflow*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateEventHandler**](EventHandlersApi.md#createeventhandler) | **POST** /api/eventhandlers | [EXPERIMENTAL] CreateEventHandler: Create a new Event Handler |
| [**DeleteEventHandler**](EventHandlersApi.md#deleteeventhandler) | **DELETE** /api/eventhandlers/{scope}/{code} | [EXPERIMENTAL] DeleteEventHandler: Delete an Event Handler |
| [**GetEventHandler**](EventHandlersApi.md#geteventhandler) | **GET** /api/eventhandlers/{scope}/{code} | [EXPERIMENTAL] GetEventHandler: Get an Event Handler |
| [**ListEventHandlers**](EventHandlersApi.md#listeventhandlers) | **GET** /api/eventhandlers | [EXPERIMENTAL] ListEventHandlers: List Event Handlers |
| [**UpdateEventHandler**](EventHandlersApi.md#updateeventhandler) | **PUT** /api/eventhandlers/{scope}/{code} | [EXPERIMENTAL] UpdateEventHandler: Update an existing Event handler |

<a id="createeventhandler"></a>
# **CreateEventHandler**
> EventHandler CreateEventHandler (CreateEventHandlerRequest createEventHandlerRequest)

[EXPERIMENTAL] CreateEventHandler: Create a new Event Handler

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EventHandlersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EventHandlersApi>();
            var createEventHandlerRequest = new CreateEventHandlerRequest(); // CreateEventHandlerRequest | The data to create an Event Handler

            try
            {
                // uncomment the below to set overrides at the request level
                // EventHandler result = apiInstance.CreateEventHandler(createEventHandlerRequest, opts: opts);

                // [EXPERIMENTAL] CreateEventHandler: Create a new Event Handler
                EventHandler result = apiInstance.CreateEventHandler(createEventHandlerRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EventHandlersApi.CreateEventHandler: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateEventHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateEventHandler: Create a new Event Handler
    ApiResponse<EventHandler> response = apiInstance.CreateEventHandlerWithHttpInfo(createEventHandlerRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EventHandlersApi.CreateEventHandlerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createEventHandlerRequest** | [**CreateEventHandlerRequest**](CreateEventHandlerRequest.md) | The data to create an Event Handler |  |

### Return type

[**EventHandler**](EventHandler.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteeventhandler"></a>
# **DeleteEventHandler**
> DeletedEntityResponse DeleteEventHandler (string scope, string code)

[EXPERIMENTAL] DeleteEventHandler: Delete an Event Handler

If the Event Handler does not exist a failure will be returned

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EventHandlersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EventHandlersApi>();
            var scope = "scope_example";  // string | Scope of the event handler to be deleted
            var code = "code_example";  // string | Code of the event handler to be deleted

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteEventHandler(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteEventHandler: Delete an Event Handler
                DeletedEntityResponse result = apiInstance.DeleteEventHandler(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EventHandlersApi.DeleteEventHandler: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteEventHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteEventHandler: Delete an Event Handler
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteEventHandlerWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EventHandlersApi.DeleteEventHandlerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the event handler to be deleted |  |
| **code** | **string** | Code of the event handler to be deleted |  |

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
| **404** | Event Handler not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="geteventhandler"></a>
# **GetEventHandler**
> EventHandler GetEventHandler (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetEventHandler: Get an Event Handler

Will return a NotFound failure if the event handler does not exist

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EventHandlersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EventHandlersApi>();
            var scope = "scope_example";  // string | Scope of the event handler
            var code = "code_example";  // string | Code of the event handler
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the event handler. Defaults to returning the latest version of the event handler if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // EventHandler result = apiInstance.GetEventHandler(scope, code, asAt, opts: opts);

                // [EXPERIMENTAL] GetEventHandler: Get an Event Handler
                EventHandler result = apiInstance.GetEventHandler(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EventHandlersApi.GetEventHandler: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetEventHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetEventHandler: Get an Event Handler
    ApiResponse<EventHandler> response = apiInstance.GetEventHandlerWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EventHandlersApi.GetEventHandlerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the event handler |  |
| **code** | **string** | Code of the event handler |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the event handler. Defaults to returning the latest version of the event handler if not specified. | [optional]  |

### Return type

[**EventHandler**](EventHandler.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listeventhandlers"></a>
# **ListEventHandlers**
> PagedResourceListOfEventHandler ListEventHandlers (DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EXPERIMENTAL] ListEventHandlers: List Event Handlers

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EventHandlersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EventHandlersApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Event Handlers. Defaults to return the latest version of each Event Handler if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here: https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var limit = 10;  // int? | When paginating, limit the number of returned results to this many. (optional)  (default to 10)
            var page = "page_example";  // string? | The pagination token to use to continue listing event handlers from a previous call to list event handlers. This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields must not have changed since the original request. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfEventHandler result = apiInstance.ListEventHandlers(asAt, filter, limit, page, opts: opts);

                // [EXPERIMENTAL] ListEventHandlers: List Event Handlers
                PagedResourceListOfEventHandler result = apiInstance.ListEventHandlers(asAt, filter, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EventHandlersApi.ListEventHandlers: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListEventHandlersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListEventHandlers: List Event Handlers
    ApiResponse<PagedResourceListOfEventHandler> response = apiInstance.ListEventHandlersWithHttpInfo(asAt, filter, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EventHandlersApi.ListEventHandlersWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Event Handlers. Defaults to return the latest version of each Event Handler if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here: https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional] [default to 10] |
| **page** | **string?** | The pagination token to use to continue listing event handlers from a previous call to list event handlers. This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields must not have changed since the original request. | [optional]  |

### Return type

[**PagedResourceListOfEventHandler**](PagedResourceListOfEventHandler.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Event Handlers |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateeventhandler"></a>
# **UpdateEventHandler**
> EventHandler UpdateEventHandler (string scope, string code, UpdateEventHandlerRequest updateEventHandlerRequest)

[EXPERIMENTAL] UpdateEventHandler: Update an existing Event handler

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<EventHandlersApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<EventHandlersApi>();
            var scope = "scope_example";  // string | The scope that identifies an Event Handler
            var code = "code_example";  // string | The code that identifies an Event Handler
            var updateEventHandlerRequest = new UpdateEventHandlerRequest(); // UpdateEventHandlerRequest | The data to update an Event Handler

            try
            {
                // uncomment the below to set overrides at the request level
                // EventHandler result = apiInstance.UpdateEventHandler(scope, code, updateEventHandlerRequest, opts: opts);

                // [EXPERIMENTAL] UpdateEventHandler: Update an existing Event handler
                EventHandler result = apiInstance.UpdateEventHandler(scope, code, updateEventHandlerRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling EventHandlersApi.UpdateEventHandler: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateEventHandlerWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateEventHandler: Update an existing Event handler
    ApiResponse<EventHandler> response = apiInstance.UpdateEventHandlerWithHttpInfo(scope, code, updateEventHandlerRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling EventHandlersApi.UpdateEventHandlerWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies an Event Handler |  |
| **code** | **string** | The code that identifies an Event Handler |  |
| **updateEventHandlerRequest** | [**UpdateEventHandlerRequest**](UpdateEventHandlerRequest.md) | The data to update an Event Handler |  |

### Return type

[**EventHandler**](EventHandler.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Event Handler not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

