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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Tomador dos serviços
    /// </summary>
    [DataContract]
    public partial class Borrower :  IEquatable<Borrower>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Borrower" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Borrower() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Borrower" /> class.
        /// </summary>
        /// <param name="Name">Nome / Razão Social (required).</param>
        /// <param name="FederalTaxNumber">CNPJ ou CPF.</param>
        /// <param name="MunicipalTaxNumber">Inscrição Municipal para Pessoas Jurídicas.</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="Address">Endereço (required).</param>
        public Borrower(string Name = default(string), long? FederalTaxNumber = default(long?), string MunicipalTaxNumber = default(string), string Email = default(string), Address Address = default(Address))
        {
            // to ensure "Name" is required (not null)
            if (Name == null)
            {
                throw new InvalidDataException("Name is a required property for Borrower and cannot be null");
            }
            else
            {
                this.Name = Name;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for Borrower and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "Address" is required (not null)
            if (Address == null)
            {
                throw new InvalidDataException("Address is a required property for Borrower and cannot be null");
            }
            else
            {
                this.Address = Address;
            }
            this.FederalTaxNumber = FederalTaxNumber;
            this.MunicipalTaxNumber = MunicipalTaxNumber;
        }
        
        /// <summary>
        /// Nome / Razão Social
        /// </summary>
        /// <value>Nome / Razão Social</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// CNPJ ou CPF
        /// </summary>
        /// <value>CNPJ ou CPF</value>
        [DataMember(Name="federalTaxNumber", EmitDefaultValue=false)]
        public long? FederalTaxNumber { get; set; }
        /// <summary>
        /// Inscrição Municipal para Pessoas Jurídicas
        /// </summary>
        /// <value>Inscrição Municipal para Pessoas Jurídicas</value>
        [DataMember(Name="municipalTaxNumber", EmitDefaultValue=false)]
        public string MunicipalTaxNumber { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Endereço
        /// </summary>
        /// <value>Endereço</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Borrower {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FederalTaxNumber: ").Append(FederalTaxNumber).Append("\n");
            sb.Append("  MunicipalTaxNumber: ").Append(MunicipalTaxNumber).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Borrower);
        }

        /// <summary>
        /// Returns true if Borrower instances are equal
        /// </summary>
        /// <param name="other">Instance of Borrower to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Borrower other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.FederalTaxNumber == other.FederalTaxNumber ||
                    this.FederalTaxNumber != null &&
                    this.FederalTaxNumber.Equals(other.FederalTaxNumber)
                ) && 
                (
                    this.MunicipalTaxNumber == other.MunicipalTaxNumber ||
                    this.MunicipalTaxNumber != null &&
                    this.MunicipalTaxNumber.Equals(other.MunicipalTaxNumber)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.FederalTaxNumber != null)
                    hash = hash * 59 + this.FederalTaxNumber.GetHashCode();
                if (this.MunicipalTaxNumber != null)
                    hash = hash * 59 + this.MunicipalTaxNumber.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}