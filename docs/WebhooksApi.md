# IO.Swagger.Api.WebhooksApi

All URIs are relative to *http://api.nfe.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**WebhooksDelete**](WebhooksApi.md#webhooksdelete) | **DELETE** /v1/hooks/{hook_id} | Excluir um webhook da conta
[**WebhooksGet**](WebhooksApi.md#webhooksget) | **GET** /v1/hooks | Listar os webhooks da conta
[**WebhooksGet_0**](WebhooksApi.md#webhooksget_0) | **GET** /v1/hooks/{hook_id} | Obter os detalhes de um webhook da conta
[**WebhooksPost**](WebhooksApi.md#webhookspost) | **POST** /v1/hooks | Criar um webhook da conta
[**WebhooksPut**](WebhooksApi.md#webhooksput) | **PUT** /v1/hooks/{hook_id} | Atualizar um webhook da conta


<a name="webhooksdelete"></a>
# **WebhooksDelete**
> Object WebhooksDelete (long? hookId)

Excluir um webhook da conta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var hookId = 789;  // long? | ID do webhook

            try
            {
                // Excluir um webhook da conta
                Object result = apiInstance.WebhooksDelete(hookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hookId** | **long?**| ID do webhook | 

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksget"></a>
# **WebhooksGet**
> WebhookCollectionResource WebhooksGet ()

Listar os webhooks da conta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();

            try
            {
                // Listar os webhooks da conta
                WebhookCollectionResource result = apiInstance.WebhooksGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WebhookCollectionResource**](WebhookCollectionResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksget_0"></a>
# **WebhooksGet_0**
> WebhookSingleResource WebhooksGet_0 (long? hookId)

Obter os detalhes de um webhook da conta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksGet_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var hookId = 789;  // long? | ID do webhook

            try
            {
                // Obter os detalhes de um webhook da conta
                WebhookSingleResource result = apiInstance.WebhooksGet_0(hookId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hookId** | **long?**| ID do webhook | 

### Return type

[**WebhookSingleResource**](WebhookSingleResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhookspost"></a>
# **WebhooksPost**
> WebhookSingleResource WebhooksPost (WebhookResource item)

Criar um webhook da conta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var item = new WebhookResource(); // WebhookResource | Dados do webhook

            try
            {
                // Criar um webhook da conta
                WebhookSingleResource result = apiInstance.WebhooksPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**WebhookResource**](WebhookResource.md)| Dados do webhook | 

### Return type

[**WebhookSingleResource**](WebhookSingleResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/bson, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="webhooksput"></a>
# **WebhooksPut**
> WebhookSingleResource WebhooksPut (long? hookId, WebhookResource item)

Atualizar um webhook da conta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class WebhooksPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new WebhooksApi();
            var hookId = 789;  // long? | ID do webhook
            var item = new WebhookResource(); // WebhookResource | Dados do webhook

            try
            {
                // Atualizar um webhook da conta
                WebhookSingleResource result = apiInstance.WebhooksPut(hookId, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WebhooksApi.WebhooksPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **hookId** | **long?**| ID do webhook | 
 **item** | [**WebhookResource**](WebhookResource.md)| Dados do webhook | 

### Return type

[**WebhookSingleResource**](WebhookSingleResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/bson, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

