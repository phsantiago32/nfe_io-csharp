using IO.Swagger.Model;
using Ploeh.AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nfeio.Client.Test.Factory
{
    public class ServiceInvoiceIssueMessageFactory
    {
        public static ServiceInvoiceIssueMessage GetObj()
        {
            var fix = new Fixture();

            var myObj = fix.Create<ServiceInvoiceIssueMessage>();

            myObj.ServicesAmount = 0.01;
            myObj.RpsNumber = 1;
            myObj.IssTaxAmount = 0.01;
            myObj.IssRate = 0.01;
            myObj.Borrower.Address.Country = "BRA";
            myObj.ApproximateTax = new ServiceInvoiceApproximateTaxesResource { TotalRate = 0.5 };
            myObj.Borrower.FederalTaxNumber = 0;

            return myObj;
        }

    }
}
