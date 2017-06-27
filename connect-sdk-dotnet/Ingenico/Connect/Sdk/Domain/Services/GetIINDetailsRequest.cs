/*
 * This class was auto-generated from the API references found at
 * https://epayments-api.developer-ingenico.com/s2sapi/v1/
 */
using Ingenico.Connect.Sdk.Domain.Services.Definitions;

namespace Ingenico.Connect.Sdk.Domain.Services
{
    public class GetIINDetailsRequest
    {
        public string Bin { get; set; } = null;

        public PaymentContext PaymentContext { get; set; } = null;
    }
}
