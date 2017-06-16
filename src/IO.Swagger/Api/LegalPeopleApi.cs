/* 
 * Service Invoice API (api.nfe.io)
 *
 * Seja bem-vindo a documentação do NFe.io!    Nossa API foi criada utilizando o padrão REST que possibilita a integração de seu sistema ao nosso, sendo assim você também pode extender ou   recriar as funcionalidades existentes na nossa plataforma, tudo isso consumindo a API que está documentada abaixo.    ### Como usar a documentação?  Logo a seguir você encontrará todos os recursos e metódos suportados pela API, sendo que essa página possibilita que você teste os recursos e métodos dirementamente através dela.     ### Como funciona a autenticação?  Você precisa de uma **chave de API (API Key)** para identificar a conta que está realizando solicitações para a API. Para isso você deve colocar sua chave de API no campo que se encontra topo desta página para que os métodos funcionem corretamente.  No seu código e integração temos suporte para autenticação de diversas formas sendo eles: **HTTP Header (Authorization ou X-NFEIO-APIKEY)** ou **HTTP Query String (api_key)** nos dois modos passando o valor da sua chave de api (API Key).  
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILegalPeopleApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Listar as pessoas jurídicas ativas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>LegalPersonResource</returns>
        LegalPersonResource LegalPeopleGet (string companyId);

        /// <summary>
        /// Listar as pessoas jurídicas ativas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>ApiResponse of LegalPersonResource</returns>
        ApiResponse<LegalPersonResource> LegalPeopleGetWithHttpInfo (string companyId);
        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>LegalPersonSingleResource</returns>
        LegalPersonSingleResource LegalPeopleGet_0 (string companyId, string id);

        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>ApiResponse of LegalPersonSingleResource</returns>
        ApiResponse<LegalPersonSingleResource> LegalPeopleGet_0WithHttpInfo (string companyId, string id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Listar as pessoas jurídicas ativas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>Task of LegalPersonResource</returns>
        System.Threading.Tasks.Task<LegalPersonResource> LegalPeopleGetAsync (string companyId);

        /// <summary>
        /// Listar as pessoas jurídicas ativas
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>Task of ApiResponse (LegalPersonResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<LegalPersonResource>> LegalPeopleGetAsyncWithHttpInfo (string companyId);
        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>Task of LegalPersonSingleResource</returns>
        System.Threading.Tasks.Task<LegalPersonSingleResource> LegalPeopleGet_0Async (string companyId, string id);

        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>Task of ApiResponse (LegalPersonSingleResource)</returns>
        System.Threading.Tasks.Task<ApiResponse<LegalPersonSingleResource>> LegalPeopleGet_0AsyncWithHttpInfo (string companyId, string id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LegalPeopleApi : ILegalPeopleApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LegalPeopleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LegalPeopleApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LegalPeopleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LegalPeopleApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Listar as pessoas jurídicas ativas 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>LegalPersonResource</returns>
        public LegalPersonResource LegalPeopleGet (string companyId)
        {
             ApiResponse<LegalPersonResource> localVarResponse = LegalPeopleGetWithHttpInfo(companyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Listar as pessoas jurídicas ativas 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>ApiResponse of LegalPersonResource</returns>
        public ApiResponse< LegalPersonResource > LegalPeopleGetWithHttpInfo (string companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling LegalPeopleApi->LegalPeopleGet");

            var localVarPath = "/v1/companies/{company_id}/legalpeople";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LegalPeopleGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LegalPersonResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegalPersonResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegalPersonResource)));
            
        }

        /// <summary>
        /// Listar as pessoas jurídicas ativas 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>Task of LegalPersonResource</returns>
        public async System.Threading.Tasks.Task<LegalPersonResource> LegalPeopleGetAsync (string companyId)
        {
             ApiResponse<LegalPersonResource> localVarResponse = await LegalPeopleGetAsyncWithHttpInfo(companyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Listar as pessoas jurídicas ativas 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <returns>Task of ApiResponse (LegalPersonResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LegalPersonResource>> LegalPeopleGetAsyncWithHttpInfo (string companyId)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling LegalPeopleApi->LegalPeopleGet");

            var localVarPath = "/v1/companies/{company_id}/legalpeople";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LegalPeopleGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LegalPersonResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegalPersonResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegalPersonResource)));
            
        }

        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>LegalPersonSingleResource</returns>
        public LegalPersonSingleResource LegalPeopleGet_0 (string companyId, string id)
        {
             ApiResponse<LegalPersonSingleResource> localVarResponse = LegalPeopleGet_0WithHttpInfo(companyId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>ApiResponse of LegalPersonSingleResource</returns>
        public ApiResponse< LegalPersonSingleResource > LegalPeopleGet_0WithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling LegalPeopleApi->LegalPeopleGet_0");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LegalPeopleApi->LegalPeopleGet_0");

            var localVarPath = "/v1/companies/{company_id}/legalpeople/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LegalPeopleGet_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LegalPersonSingleResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegalPersonSingleResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegalPersonSingleResource)));
            
        }

        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>Task of LegalPersonSingleResource</returns>
        public async System.Threading.Tasks.Task<LegalPersonSingleResource> LegalPeopleGet_0Async (string companyId, string id)
        {
             ApiResponse<LegalPersonSingleResource> localVarResponse = await LegalPeopleGet_0AsyncWithHttpInfo(companyId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Obter os detalhes de uma pessoa jurídica 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="companyId">ID da empresa</param>
        /// <param name="id">ID da pessoa juridica</param>
        /// <returns>Task of ApiResponse (LegalPersonSingleResource)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LegalPersonSingleResource>> LegalPeopleGet_0AsyncWithHttpInfo (string companyId, string id)
        {
            // verify the required parameter 'companyId' is set
            if (companyId == null)
                throw new ApiException(400, "Missing required parameter 'companyId' when calling LegalPeopleApi->LegalPeopleGet_0");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling LegalPeopleApi->LegalPeopleGet_0");

            var localVarPath = "/v1/companies/{company_id}/legalpeople/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json", 
                "text/json", 
                "application/bson", 
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (companyId != null) localVarPathParams.Add("company_id", Configuration.ApiClient.ParameterToString(companyId)); // path parameter
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter

            // authentication (apiKey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("LegalPeopleGet_0", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<LegalPersonSingleResource>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LegalPersonSingleResource) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LegalPersonSingleResource)));
            
        }

    }
}