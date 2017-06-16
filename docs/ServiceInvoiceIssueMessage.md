# IO.Swagger.Model.ServiceInvoiceIssueMessage
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Borrower** | [**Borrower**](Borrower.md) | Tomador dos serviços | 
**CityServiceCode** | **string** | Código do serviço no municipio | 
**FederalServiceCode** | **string** | Código federal do servico (Item da lista de serviço LC 116) | [optional] 
**CnaeCode** | **string** | Código CNAE (somente quando necessario na cidade) | [optional] 
**Description** | **string** | Descrição dos serviços | 
**ServicesAmount** | **double?** | Valor do serviços | 
**RpsSerialNumber** | **string** | Número de Serie da RPS | [optional] 
**IssuedOn** | **DateTime?** | Data da emissão | [optional] 
**RpsNumber** | **long?** | Número da RPS | [optional] 
**TaxationType** | **string** | Tipo da tributação | [optional] 
**IssRate** | **double?** | Aliquota do ISS | [optional] 
**IssTaxAmount** | **double?** | Valor do ISS | [optional] 
**DeductionsAmount** | **double?** | Valor de deduções | [optional] 
**DiscountUnconditionedAmount** | **double?** | Valor do desconto incondicionado | [optional] 
**DiscountConditionedAmount** | **double?** | Valor do desconto condicionado | [optional] 
**IrAmountWithheld** | **double?** | Valor retido do Imposto de Renda (IR) | [optional] 
**PisAmountWithheld** | **double?** | Valor retido do PIS | [optional] 
**CofinsAmountWithheld** | **double?** | Valor retido do COFINS | [optional] 
**CsllAmountWithheld** | **double?** | Valor retido do CSLL | [optional] 
**InssAmountWithheld** | **double?** | Valor retido do INSS | [optional] 
**IssAmountWithheld** | **double?** | Valor retido do ISS | [optional] 
**OthersAmountWithheld** | **double?** | Valor de outras retenções | [optional] 
**ApproximateTax** | [**ServiceInvoiceApproximateTaxesResource**](ServiceInvoiceApproximateTaxesResource.md) | Tributos aproximados | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

