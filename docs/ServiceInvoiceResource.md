# IO.Swagger.Model.ServiceInvoiceResource
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Identificação | [optional] 
**Environment** | **string** | Ambiente de Processamento | 
**FlowStatus** | **string** | Status do processamento | [optional] 
**FlowMessage** | **string** | Mensagem de processamento | [optional] 
**Provider** | [**LegalPerson**](LegalPerson.md) | Prestador dos serviços | [optional] 
**Borrower** | [**Person**](Person.md) | Tomador dos serviços | [optional] 
**BatchNumber** | **long?** | Número do lote da RPS | [optional] 
**BatchCheckNumber** | **string** | Número do protocolo do lote da RPS | [optional] 
**Number** | **long?** | Número do NFE | [optional] 
**CheckCode** | **string** | Código de Verificação da NFE | [optional] 
**Status** | **string** | Status da NFE | [optional] 
**RpsType** | **string** | Tipo da RPS | [optional] 
**RpsStatus** | **string** | Status da RPS | [optional] 
**TaxationType** | **string** | Tipo da tributação | [optional] 
**IssuedOn** | **DateTime?** | Data de emissão | [optional] 
**CancelledOn** | **DateTime?** | Data de cancelamento | [optional] 
**RpsSerialNumber** | **string** | Número de serie da RPS | [optional] 
**RpsNumber** | **long?** | Número da RPS | [optional] 
**CityServiceCode** | **string** | Código do servico prestado no Municipio | [optional] 
**FederalServiceCode** | **string** | Código do servico prestado federal | [optional] 
**Description** | **string** | Descrição do serviço no municipio | [optional] 
**ServicesAmount** | **double?** | Valor do serviços | [optional] 
**DeductionsAmount** | **double?** | Valor de deduções | [optional] 
**DiscountUnconditionedAmount** | **double?** | Valor do desconto incondicionado | [optional] 
**DiscountConditionedAmount** | **double?** | Valor do desconto condicionado | [optional] 
**BaseTaxAmount** | **double?** | Valor da base de calculo de impostos | [optional] 
**IssRate** | **double?** | Aliquota do ISS | [optional] 
**IssTaxAmount** | **double?** | Valor do ISS | [optional] 
**IrAmountWithheld** | **double?** | Valor retido do Imposto de Renda (IR) | [optional] 
**PisAmountWithheld** | **double?** | Valor retido do PIS | [optional] 
**CofinsAmountWithheld** | **double?** | Valor retido do COFINS | [optional] 
**CsllAmountWithheld** | **double?** | Valor retido do CSLL | [optional] 
**InssAmountWithheld** | **double?** | Valor retido do INSS | [optional] 
**IssAmountWithheld** | **double?** | Valor retido do ISS | [optional] 
**OthersAmountWithheld** | **double?** | Valor de outras retenções | [optional] 
**AmountWithheld** | **double?** | Valor das retenções | [optional] 
**AmountNet** | **double?** | Valor líquido | [optional] 
**ApproximateTax** | [**ServiceInvoiceApproximateTaxesResource**](ServiceInvoiceApproximateTaxesResource.md) | Tributos aproximados | [optional] 
**CreatedOn** | **DateTime?** | Data de criação | [optional] 
**ModifiedOn** | **DateTime?** | Data da última modificação | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

