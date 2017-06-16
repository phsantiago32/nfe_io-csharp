# IO.Swagger.Api.LegalPeopleApi

All URIs are relative to *http://api.nfe.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**LegalPeopleGet**](LegalPeopleApi.md#legalpeopleget) | **GET** /v1/companies/{company_id}/legalpeople | Listar as pessoas jurídicas ativas
[**LegalPeopleGet_0**](LegalPeopleApi.md#legalpeopleget_0) | **GET** /v1/companies/{company_id}/legalpeople/{id} | Obter os detalhes de uma pessoa jurídica


<a name="legalpeopleget"></a>
# **LegalPeopleGet**
> LegalPersonResource LegalPeopleGet (string companyId)

Listar as pessoas jurídicas ativas

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LegalPeopleGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new LegalPeopleApi();
            var companyId = companyId_example;  // string | ID da empresa

            try
            {
                // Listar as pessoas jurídicas ativas
                LegalPersonResource result = apiInstance.LegalPeopleGet(companyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalPeopleApi.LegalPeopleGet: " + e.Message );
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

[**LegalPersonResource**](LegalPersonResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="legalpeopleget_0"></a>
# **LegalPeopleGet_0**
> LegalPersonSingleResource LegalPeopleGet_0 (string companyId, string id)

Obter os detalhes de uma pessoa jurídica

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class LegalPeopleGet_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new LegalPeopleApi();
            var companyId = companyId_example;  // string | ID da empresa
            var id = id_example;  // string | ID da pessoa juridica

            try
            {
                // Obter os detalhes de uma pessoa jurídica
                LegalPersonSingleResource result = apiInstance.LegalPeopleGet_0(companyId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LegalPeopleApi.LegalPeopleGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **id** | **string**| ID da pessoa juridica | 

### Return type

[**LegalPersonSingleResource**](LegalPersonSingleResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

