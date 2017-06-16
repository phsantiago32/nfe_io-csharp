# IO.Swagger.Api.ServiceInvoicesApi

All URIs are relative to *http://api.nfe.io*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ServiceInvoicesDelete**](ServiceInvoicesApi.md#serviceinvoicesdelete) | **DELETE** /v1/companies/{company_id}/serviceinvoices/{id} | Cancelar uma Nota Fiscal de Serviços (NFSE)
[**ServiceInvoicesGet**](ServiceInvoicesApi.md#serviceinvoicesget) | **GET** /v1/companies/{company_id}/serviceinvoices | Listar as Notas Fiscais de Serviço (NFSE)
[**ServiceInvoicesGetDocumentPdf**](ServiceInvoicesApi.md#serviceinvoicesgetdocumentpdf) | **GET** /v1/companies/{company_id}/serviceinvoices/{id}/pdf | Download do PDF da Nota Fiscal de Serviço (NFSE)
[**ServiceInvoicesGetDocumentXml**](ServiceInvoicesApi.md#serviceinvoicesgetdocumentxml) | **GET** /v1/companies/{company_id}/serviceinvoices/{id}/xml | Download do XML da Nota Fiscal de Serviço (NFSE)
[**ServiceInvoicesGet_0**](ServiceInvoicesApi.md#serviceinvoicesget_0) | **GET** /v1/companies/{company_id}/serviceinvoices/{id} | Obter os detalhes de uma Nota Fiscal de Serviço (NFSE)
[**ServiceInvoicesPost**](ServiceInvoicesApi.md#serviceinvoicespost) | **POST** /v1/companies/{company_id}/serviceinvoices | Emitir uma Nota Fiscal de Serviço (NFSE)
[**ServiceInvoicesPullProcess**](ServiceInvoicesApi.md#serviceinvoicespullprocess) | **PUT** /v1/companies/{company_id}/serviceinvoices/pull | Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura
[**ServiceInvoicesSendEmail**](ServiceInvoicesApi.md#serviceinvoicessendemail) | **PUT** /v1/companies/{company_id}/serviceinvoices/{id}/sendemail | Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE)


<a name="serviceinvoicesdelete"></a>
# **ServiceInvoicesDelete**
> string ServiceInvoicesDelete (string companyId, string id)

Cancelar uma Nota Fiscal de Serviços (NFSE)

Você precisará do APIKEY da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesDeleteExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var id = id_example;  // string | ID da Nota Fiscal de Serviço (NFSE)

            try
            {
                // Cancelar uma Nota Fiscal de Serviços (NFSE)
                string result = apiInstance.ServiceInvoicesDelete(companyId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **id** | **string**| ID da Nota Fiscal de Serviço (NFSE) | 

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceinvoicesget"></a>
# **ServiceInvoicesGet**
> ServiceInvoiceCollectionResource ServiceInvoicesGet (string companyId, int? pageCount = null, int? pageIndex = null)

Listar as Notas Fiscais de Serviço (NFSE)

Você precisará do APIKEY da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesGetExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var pageCount = 56;  // int? | Items por página (optional) 
            var pageIndex = 56;  // int? | Número da página (optional) 

            try
            {
                // Listar as Notas Fiscais de Serviço (NFSE)
                ServiceInvoiceCollectionResource result = apiInstance.ServiceInvoicesGet(companyId, pageCount, pageIndex);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **pageCount** | **int?**| Items por página | [optional] 
 **pageIndex** | **int?**| Número da página | [optional] 

### Return type

[**ServiceInvoiceCollectionResource**](ServiceInvoiceCollectionResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceinvoicesgetdocumentpdf"></a>
# **ServiceInvoicesGetDocumentPdf**
> string ServiceInvoicesGetDocumentPdf (string companyId, string id)

Download do PDF da Nota Fiscal de Serviço (NFSE)

Você precisará do APIKEY da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesGetDocumentPdfExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var id = id_example;  // string | ID da Nota Fiscal de Serviço (NFSE)

            try
            {
                // Download do PDF da Nota Fiscal de Serviço (NFSE)
                string result = apiInstance.ServiceInvoicesGetDocumentPdf(companyId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesGetDocumentPdf: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **id** | **string**| ID da Nota Fiscal de Serviço (NFSE) | 

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceinvoicesgetdocumentxml"></a>
# **ServiceInvoicesGetDocumentXml**
> string ServiceInvoicesGetDocumentXml (string companyId, string id)

Download do XML da Nota Fiscal de Serviço (NFSE)

Você precisará do APIKEY da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesGetDocumentXmlExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var id = id_example;  // string | ID da Nota Fiscal de Serviço (NFSE)

            try
            {
                // Download do XML da Nota Fiscal de Serviço (NFSE)
                string result = apiInstance.ServiceInvoicesGetDocumentXml(companyId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesGetDocumentXml: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **id** | **string**| ID da Nota Fiscal de Serviço (NFSE) | 

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceinvoicesget_0"></a>
# **ServiceInvoicesGet_0**
> ServiceInvoiceResource ServiceInvoicesGet_0 (string companyId, string id)

Obter os detalhes de uma Nota Fiscal de Serviço (NFSE)

Você precisará do API Key da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesGet_0Example
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var id = id_example;  // string | ID da Nota Fiscal de Serviço (NFSE)

            try
            {
                // Obter os detalhes de uma Nota Fiscal de Serviço (NFSE)
                ServiceInvoiceResource result = apiInstance.ServiceInvoicesGet_0(companyId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **id** | **string**| ID da Nota Fiscal de Serviço (NFSE) | 

### Return type

[**ServiceInvoiceResource**](ServiceInvoiceResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceinvoicespost"></a>
# **ServiceInvoicesPost**
> ServiceInvoiceResource ServiceInvoicesPost (string companyId, ServiceInvoiceIssueMessage item)

Emitir uma Nota Fiscal de Serviço (NFSE)

Você precisará do APIKEY da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesPostExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var item = new ServiceInvoiceIssueMessage(); // ServiceInvoiceIssueMessage | Dados da nota fiscal de serviço

            try
            {
                // Emitir uma Nota Fiscal de Serviço (NFSE)
                ServiceInvoiceResource result = apiInstance.ServiceInvoicesPost(companyId, item);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **item** | [**ServiceInvoiceIssueMessage**](ServiceInvoiceIssueMessage.md)| Dados da nota fiscal de serviço | 

### Return type

[**ServiceInvoiceResource**](ServiceInvoiceResource.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/bson, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/bson

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceinvoicespullprocess"></a>
# **ServiceInvoicesPullProcess**
> string ServiceInvoicesPullProcess (string companyId, DateRange dateRange)

Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura

Você precisará do APIKEY da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesPullProcessExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var dateRange = new DateRange(); // DateRange | 

            try
            {
                // Consulta Notas Fiscais de Serviço (NFSE) da Prefeitura
                string result = apiInstance.ServiceInvoicesPullProcess(companyId, dateRange);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesPullProcess: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **dateRange** | [**DateRange**](DateRange.md)|  | 

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/bson, text/xml, application/x-www-form-urlencoded
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="serviceinvoicessendemail"></a>
# **ServiceInvoicesSendEmail**
> string ServiceInvoicesSendEmail (string companyId, string id)

Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE)

Você precisará do APIKEY da Empresa

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class ServiceInvoicesSendEmailExample
    {
        public void main()
        {
            
            // Configure API key authorization: apiKey
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new ServiceInvoicesApi();
            var companyId = companyId_example;  // string | ID da empresa
            var id = id_example;  // string | ID da Nota Fiscal de Serviço (NFSE)

            try
            {
                // Enviar email para o Tomador com a Nota Fiscal de Serviço (NFSE)
                string result = apiInstance.ServiceInvoicesSendEmail(companyId, id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ServiceInvoicesApi.ServiceInvoicesSendEmail: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **companyId** | **string**| ID da empresa | 
 **id** | **string**| ID da Nota Fiscal de Serviço (NFSE) | 

### Return type

**string**

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/bson, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

