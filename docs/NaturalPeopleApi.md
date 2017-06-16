# IO.Swagger.Api.NaturalPeopleApi

All URIs are relative to *http://api.nfe.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**NaturalPeopleGet**](NaturalPeopleApi.md#naturalpeopleget) | **GET** /v1/companies/{company_id}/naturalpeople | Listar as pessoas físicas ativas
[**NaturalPeopleGet_0**](NaturalPeopleApi.md#naturalpeopleget_0) | **GET** /v1/companies/{company_id}/naturalpeople/{id} | Obter os detalhes de uma pessoa física


<a name="naturalpeopleget"></a>
# **NaturalPeopleGet**
> NaturalPersonCollectionResource NaturalPeopleGet (string companyId)

Listar as pessoas físicas ativas

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NaturalPeopleGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new NaturalPeopleApi();
            var companyId = companyId_example;  // string | ID da empresa

            try
            {
                // Listar as pessoas físicas ativas
                NaturalPersonCollectionResource result = apiInstance.NaturalPeopleGet(companyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPeopleApi.NaturalPeopleGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 

### Return type

[**NaturalPersonCollectionResource**](NaturalPersonCollectionResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="naturalpeopleget_0"></a>
# **NaturalPeopleGet_0**
> NaturalPersonResource NaturalPeopleGet_0 (string companyId, string id)

Obter os detalhes de uma pessoa física

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class NaturalPeopleGet_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new NaturalPeopleApi();
            var companyId = companyId_example;  // string | ID da empresa
            var id = id_example;  // string | ID da pessoa física

            try
            {
                // Obter os detalhes de uma pessoa física
                NaturalPersonResource result = apiInstance.NaturalPeopleGet_0(companyId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NaturalPeopleApi.NaturalPeopleGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **id** | **string**| ID da pessoa física | 

### Return type

[**NaturalPersonResource**](NaturalPersonResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

