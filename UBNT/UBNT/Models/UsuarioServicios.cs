using System;
using System.Collections.Generic;
using System.Text;

namespace UBNT.Models
{

    public class UsuarioServicios
    {
        public int id { get; set; }
        public int clientId { get; set; }
        public int status { get; set; }
        public string name { get; set; }
        public string street1 { get; set; }
        public string street2 { get; set; }
        public string city { get; set; }
        public int countryId { get; set; }
        public int stateId { get; set; }
        public string zipCode { get; set; }
        public string note { get; set; }
        public float addressGpsLat { get; set; }
        public float addressGpsLon { get; set; }
        public int servicePlanId { get; set; }
        public int servicePlanPeriodId { get; set; }
        public float price { get; set; }
        public bool hasIndividualPrice { get; set; }
        public float totalPrice { get; set; }
        public string currencyCode { get; set; }
        public string invoiceLabel { get; set; }
        public string contractId { get; set; }
        public int contractLengthType { get; set; }
        public int minimumContractLengthMonths { get; set; }
        public DateTime activeFrom { get; set; }
        public DateTime activeTo { get; set; }
        public DateTime contractEndDate { get; set; }
        public int discountType { get; set; }
        public float discountValue { get; set; }
        public string discountInvoiceLabel { get; set; }
        public DateTime discountFrom { get; set; }
        public DateTime discountTo { get; set; }
        public int tax1Id { get; set; }
        public int tax2Id { get; set; }
        public int tax3Id { get; set; }
        public DateTime invoicingStart { get; set; }
        public string invoicingPeriodType { get; set; }
        public int invoicingPeriodStartDay { get; set; }
        public int nextInvoicingDayAdjustment { get; set; }
        public bool invoicingProratedSeparately { get; set; }
        public bool invoicingSeparately { get; set; }
        public bool sendEmailsAutomatically { get; set; }
        public bool useCreditAutomatically { get; set; }
        public string servicePlanName { get; set; }
        public float servicePlanPrice { get; set; }
        public int servicePlanPeriod { get; set; }
        public int downloadSpeed { get; set; }
        public float uploadSpeed { get; set; }
        public string[] ipRanges { get; set; }
        public bool hasOutage { get; set; }
    }
}
