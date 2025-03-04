# Finbourne.Workflow.Sdk.Api.TaskDefinitionsApi

All URIs are relative to *https://fbn-prd.lusid.com/workflow*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTaskDefinition**](TaskDefinitionsApi.md#createtaskdefinition) | **POST** /api/taskdefinitions | CreateTaskDefinition: Create a new Task Definition |
| [**DeleteTaskDefinition**](TaskDefinitionsApi.md#deletetaskdefinition) | **DELETE** /api/taskdefinitions/{scope}/{code} | DeleteTaskDefinition: Delete a Task Definition |
| [**GetTaskDefinition**](TaskDefinitionsApi.md#gettaskdefinition) | **GET** /api/taskdefinitions/{scope}/{code} | GetTaskDefinition: Get a Task Definition |
| [**ListTaskDefinitions**](TaskDefinitionsApi.md#listtaskdefinitions) | **GET** /api/taskdefinitions | ListTaskDefinitions: List Task Definitions |
| [**ListTasksForTaskDefinition**](TaskDefinitionsApi.md#listtasksfortaskdefinition) | **GET** /api/taskdefinitions/{scope}/{code}/tasks | ListTasksForTaskDefinition: List Tasks for a Task Definition |
| [**UpdateTaskDefinition**](TaskDefinitionsApi.md#updatetaskdefinition) | **PUT** /api/taskdefinitions/{scope}/{code} | UpdateTaskDefinition: Update an existing Task Definition |

<a id="createtaskdefinition"></a>
# **CreateTaskDefinition**
> TaskDefinition CreateTaskDefinition (CreateTaskDefinitionRequest createTaskDefinitionRequest)

CreateTaskDefinition: Create a new Task Definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaskDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaskDefinitionsApi>();
            var createTaskDefinitionRequest = new CreateTaskDefinitionRequest(); // CreateTaskDefinitionRequest | The data to create a Task Definition

            try
            {
                // uncomment the below to set overrides at the request level
                // TaskDefinition result = apiInstance.CreateTaskDefinition(createTaskDefinitionRequest, opts: opts);

                // CreateTaskDefinition: Create a new Task Definition
                TaskDefinition result = apiInstance.CreateTaskDefinition(createTaskDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaskDefinitionsApi.CreateTaskDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTaskDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateTaskDefinition: Create a new Task Definition
    ApiResponse<TaskDefinition> response = apiInstance.CreateTaskDefinitionWithHttpInfo(createTaskDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaskDefinitionsApi.CreateTaskDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTaskDefinitionRequest** | [**CreateTaskDefinitionRequest**](CreateTaskDefinitionRequest.md) | The data to create a Task Definition |  |

### Return type

[**TaskDefinition**](TaskDefinition.md)

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

<a id="deletetaskdefinition"></a>
# **DeleteTaskDefinition**
> DeletedEntityResponse DeleteTaskDefinition (string scope, string code)

DeleteTaskDefinition: Delete a Task Definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaskDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaskDefinitionsApi>();
            var scope = "scope_example";  // string | The scope that identifies a Task Definition
            var code = "code_example";  // string | The code that identifies a Task Definition

            try
            {
                // uncomment the below to set overrides at the request level
                // DeletedEntityResponse result = apiInstance.DeleteTaskDefinition(scope, code, opts: opts);

                // DeleteTaskDefinition: Delete a Task Definition
                DeletedEntityResponse result = apiInstance.DeleteTaskDefinition(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaskDefinitionsApi.DeleteTaskDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTaskDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteTaskDefinition: Delete a Task Definition
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTaskDefinitionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaskDefinitionsApi.DeleteTaskDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a Task Definition |  |
| **code** | **string** | The code that identifies a Task Definition |  |

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
| **404** | Task Definition not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gettaskdefinition"></a>
# **GetTaskDefinition**
> TaskDefinition GetTaskDefinition (string scope, string code, DateTimeOffset? asAt = null)

GetTaskDefinition: Get a Task Definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaskDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaskDefinitionsApi>();
            var scope = "scope_example";  // string | The scope that identifies a Task Definition
            var code = "code_example";  // string | The code that identifies a Task Definition
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Task Definition. Defaults to returning the latest version of the Task Definition if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // TaskDefinition result = apiInstance.GetTaskDefinition(scope, code, asAt, opts: opts);

                // GetTaskDefinition: Get a Task Definition
                TaskDefinition result = apiInstance.GetTaskDefinition(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaskDefinitionsApi.GetTaskDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetTaskDefinition: Get a Task Definition
    ApiResponse<TaskDefinition> response = apiInstance.GetTaskDefinitionWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaskDefinitionsApi.GetTaskDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a Task Definition |  |
| **code** | **string** | The code that identifies a Task Definition |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Task Definition. Defaults to returning the latest version of the Task Definition if not specified. | [optional]  |

### Return type

[**TaskDefinition**](TaskDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Task Definition not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listtaskdefinitions"></a>
# **ListTaskDefinitions**
> PagedResourceListOfTaskDefinition ListTaskDefinitions (DateTimeOffset? asAt = null, string? filter = null, List<string>? sortBy = null, int? limit = null, string? page = null)

ListTaskDefinitions: List Task Definitions

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaskDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaskDefinitionsApi>();
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Task Definitions. Defaults to return the latest version of each Task Definition if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here: https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var limit = 10;  // int? | When paginating, limit the number of returned results to this many. (optional)  (default to 10)
            var page = "page_example";  // string? | The pagination token to use to continue listing task definitions from a previous call to list task definitions. This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields must not have changed since the original request. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfTaskDefinition result = apiInstance.ListTaskDefinitions(asAt, filter, sortBy, limit, page, opts: opts);

                // ListTaskDefinitions: List Task Definitions
                PagedResourceListOfTaskDefinition result = apiInstance.ListTaskDefinitions(asAt, filter, sortBy, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaskDefinitionsApi.ListTaskDefinitions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTaskDefinitionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListTaskDefinitions: List Task Definitions
    ApiResponse<PagedResourceListOfTaskDefinition> response = apiInstance.ListTaskDefinitionsWithHttpInfo(asAt, filter, sortBy, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaskDefinitionsApi.ListTaskDefinitionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Task Definitions. Defaults to return the latest version of each Task Definition if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here: https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional] [default to 10] |
| **page** | **string?** | The pagination token to use to continue listing task definitions from a previous call to list task definitions. This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields must not have changed since the original request. | [optional]  |

### Return type

[**PagedResourceListOfTaskDefinition**](PagedResourceListOfTaskDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Task Definitions |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No Task Definitions found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listtasksfortaskdefinition"></a>
# **ListTasksForTaskDefinition**
> ResourceListOfTask ListTasksForTaskDefinition (string scope, string code, DateTimeOffset? asAt = null)

ListTasksForTaskDefinition: List Tasks for a Task Definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaskDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaskDefinitionsApi>();
            var scope = "scope_example";  // string | The scope that identifies a Task Definition
            var code = "code_example";  // string | The code that identifies a Task Definition
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Tasks. Defaults to return the latest version of each Task if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfTask result = apiInstance.ListTasksForTaskDefinition(scope, code, asAt, opts: opts);

                // ListTasksForTaskDefinition: List Tasks for a Task Definition
                ResourceListOfTask result = apiInstance.ListTasksForTaskDefinition(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaskDefinitionsApi.ListTasksForTaskDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTasksForTaskDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListTasksForTaskDefinition: List Tasks for a Task Definition
    ApiResponse<ResourceListOfTask> response = apiInstance.ListTasksForTaskDefinitionWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaskDefinitionsApi.ListTasksForTaskDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a Task Definition |  |
| **code** | **string** | The code that identifies a Task Definition |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Tasks. Defaults to return the latest version of each Task if not specified. | [optional]  |

### Return type

[**ResourceListOfTask**](ResourceListOfTask.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No tasks found for this Task Definition. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatetaskdefinition"></a>
# **UpdateTaskDefinition**
> TaskDefinition UpdateTaskDefinition (string scope, string code, UpdateTaskDefinitionRequest updateTaskDefinitionRequest)

UpdateTaskDefinition: Update an existing Task Definition

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<TaskDefinitionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<TaskDefinitionsApi>();
            var scope = "scope_example";  // string | The scope that identifies a Task Definition
            var code = "code_example";  // string | The code that identifies a Task Definition
            var updateTaskDefinitionRequest = new UpdateTaskDefinitionRequest(); // UpdateTaskDefinitionRequest | The data to update a Task Definition

            try
            {
                // uncomment the below to set overrides at the request level
                // TaskDefinition result = apiInstance.UpdateTaskDefinition(scope, code, updateTaskDefinitionRequest, opts: opts);

                // UpdateTaskDefinition: Update an existing Task Definition
                TaskDefinition result = apiInstance.UpdateTaskDefinition(scope, code, updateTaskDefinitionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling TaskDefinitionsApi.UpdateTaskDefinition: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTaskDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateTaskDefinition: Update an existing Task Definition
    ApiResponse<TaskDefinition> response = apiInstance.UpdateTaskDefinitionWithHttpInfo(scope, code, updateTaskDefinitionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling TaskDefinitionsApi.UpdateTaskDefinitionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope that identifies a Task Definition |  |
| **code** | **string** | The code that identifies a Task Definition |  |
| **updateTaskDefinitionRequest** | [**UpdateTaskDefinitionRequest**](UpdateTaskDefinitionRequest.md) | The data to update a Task Definition |  |

### Return type

[**TaskDefinition**](TaskDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Task Definition not found. |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

