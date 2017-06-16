# IO.Swagger.Api.CompaniesApi

All URIs are relative to *http://api.nfe.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CompaniesCertificateUpload**](CompaniesApi.md#companiescertificateupload) | **POST** /v1/companies/{company_id}/certificate | Upload do certificado digital da empresa usando o codificação multipart/form-data.
[**CompaniesDelete**](CompaniesApi.md#companiesdelete) | **DELETE** /v1/companies/{company_id} | Excluir uma empresa
[**CompaniesGet**](CompaniesApi.md#companiesget) | **GET** /v1/companies | Listar as empresas ativas de uma conta
[**CompaniesGet_0**](CompaniesApi.md#companiesget_0) | **GET** /v1/companies/{company_id_or_tax_number} | Obter os detalhes de uma empresa
[**CompaniesPost**](CompaniesApi.md#companiespost) | **POST** /v1/companies | Criar uma empresa
[**CompaniesPut**](CompaniesApi.md#companiesput) | **PUT** /v1/companies/{company_id} | Atualizar uma empresa


<a name="companiescertificateupload"></a>
# **CompaniesCertificateUpload**
> string CompaniesCertificateUpload (string companyId, System.IO.Stream file, string password)

Upload do certificado digital da empresa usando o codificação multipart/form-data.

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesCertificateUploadExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CompaniesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var file = new System.IO.Stream(); // System.IO.Stream | Arquivo do certificado digital com extensao PFX ou P12
            var password = password_example;  // string | Senha do arquivo do certificado digital

            try
            {
                // Upload do certificado digital da empresa usando o codificação multipart/form-data.
                string result = apiInstance.CompaniesCertificateUpload(companyId, file, password);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesCertificateUpload: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **file** | **System.IO.Stream**| Arquivo do certificado digital com extensao PFX ou P12 | 
 **password** | **string**| Senha do arquivo do certificado digital | 

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesdelete"></a>
# **CompaniesDelete**
> Object CompaniesDelete (string companyId)

Excluir uma empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CompaniesApi();
            var companyId = companyId_example;  // string | ID da empresa

            try
            {
                // Excluir uma empresa
                Object result = apiInstance.CompaniesDelete(companyId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesDelete: " + e.Message );
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

**Object**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesget"></a>
# **CompaniesGet**
> CompanyCollectionResource CompaniesGet ()

Listar as empresas ativas de uma conta

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CompaniesApi();

            try
            {
                // Listar as empresas ativas de uma conta
                CompanyCollectionResource result = apiInstance.CompaniesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CompanyCollectionResource**](CompanyCollectionResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesget_0"></a>
# **CompaniesGet_0**
> CompanySingleResource CompaniesGet_0 (string companyIdOrTaxNumber)

Obter os detalhes de uma empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesGet_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CompaniesApi();
            var companyIdOrTaxNumber = companyIdOrTaxNumber_example;  // string | ID da empresa ou Inscrição Federal (CNPJ)

            try
            {
                // Obter os detalhes de uma empresa
                CompanySingleResource result = apiInstance.CompaniesGet_0(companyIdOrTaxNumber);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyIdOrTaxNumber** | **string**| ID da empresa ou Inscrição Federal (CNPJ) | 

### Return type

[**CompanySingleResource**](CompanySingleResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiespost"></a>
# **CompaniesPost**
> CompanySingleResource CompaniesPost (CompanyResource item)

Criar uma empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CompaniesApi();
            var item = new CompanyResource(); // CompanyResource | Dados da empresa

            try
            {
                // Criar uma empresa
                CompanySingleResource result = apiInstance.CompaniesPost(item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **item** | [**CompanyResource**](CompanyResource.md)| Dados da empresa | 

### Return type

[**CompanySingleResource**](CompanySingleResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/bson, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="companiesput"></a>
# **CompaniesPut**
> CompanySingleResource CompaniesPut (string companyId, CompanyResource item)

Atualizar uma empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class CompaniesPutExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new CompaniesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var item = new CompanyResource(); // CompanyResource | Dados da empresa

            try
            {
                // Atualizar uma empresa
                CompanySingleResource result = apiInstance.CompaniesPut(companyId, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CompaniesApi.CompaniesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **item** | [**CompanyResource**](CompanyResource.md)| Dados da empresa | 

### Return type

[**CompanySingleResource**](CompanySingleResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/bson, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

