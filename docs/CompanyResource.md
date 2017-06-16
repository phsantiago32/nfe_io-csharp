# IO.Swagger.Model.CompanyResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identificação | [optional] 
**Name** | **string** | Nome ou Razão Social | 
**TradeName** | **string** | Nome fantasia | [optional] 
**FederalTaxNumber** | **long?** | CNPJ ou CPF | 
**Email** | **string** | Email | 
**Address** | [**Address**](Address.md) | Endereço | 
**OpenningDate** | **DateTime?** | Data abertura da empresa | 
**TaxRegime** | **string** | Tipo do Regime Tributário | 
**SpecialTaxRegime** | **string** | Tipo do regime especial de tributação | [optional] 
**LegalNature** | **string** | Código da Natureza Jurídica | 
**EconomicActivities** | [**List&lt;EconomicActivity&gt;**](EconomicActivity.md) | Atividades da Empresa | [optional] 
**CompanyRegistryNumber** | **long?** | Número de Inscricação na Junta Comercial | [optional] 
**RegionalTaxNumber** | **long?** | Número de Inscricação na SEFAZ (IE) | [optional] 
**MunicipalTaxNumber** | **string** | Número de Inscricação na Prefeitura (CCM) | 
**RpsSerialNumber** | **string** | RPS número serie | [optional] 
**RpsNumber** | **long?** | RPS número | [optional] 
**Environment** | **string** | Ambiente de processamento | [optional] 
**FiscalStatus** | **string** | Status no sistema | [optional] 
**Certificate** | [**CompanyCertificate**](CompanyCertificate.md) | Certificado | [optional] 
**CreatedOn** | **DateTime?** | Data de criação | [optional] 
**ModifiedOn** | **DateTime?** | Data da última modificação | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

