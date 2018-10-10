using System;
using System.Collections.Generic;
using System.Text;

namespace UBNT.Models
{
    
        public class InfoUsuario
        {
            public int id { get; set; }
            public string userIdent { get; set; }
            public object previousIsp { get; set; }
            public bool isLead { get; set; }
            public int clientType { get; set; }
            public object companyName { get; set; }
            public object companyRegistrationNumber { get; set; }
            public object companyTaxId { get; set; }
            public object companyWebsite { get; set; }
            public string street1 { get; set; }
            public object street2 { get; set; }
            public string city { get; set; }
            public int countryId { get; set; }
            public object stateId { get; set; }
            public string zipCode { get; set; }
            public object invoiceStreet1 { get; set; }
            public object invoiceStreet2 { get; set; }
            public object invoiceCity { get; set; }
            public object invoiceStateId { get; set; }
            public object invoiceCountryId { get; set; }
            public object invoiceZipCode { get; set; }
            public bool invoiceAddressSameAsContact { get; set; }
            public string note { get; set; }
            public object sendInvoiceByPost { get; set; }
            public object invoiceMaturityDays { get; set; }
            public object stopServiceDue { get; set; }
            public object stopServiceDueDays { get; set; }
            public int organizationId { get; set; }
            public object tax1Id { get; set; }
            public object tax2Id { get; set; }
            public object tax3Id { get; set; }
            public DateTime registrationDate { get; set; }
            public object companyContactFirstName { get; set; }
            public object companyContactLastName { get; set; }
            public bool isActive { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string username { get; set; }
            public Contact[] contacts { get; set; }
            public object[] attributes { get; set; }
            public float accountBalance { get; set; }
            public int accountCredit { get; set; }
            public float accountOutstanding { get; set; }
            public string currencyCode { get; set; }
            public string organizationName { get; set; }
            public object[] bankAccounts { get; set; }
            public object[] tags { get; set; }
            public DateTime invitationEmailSentDate { get; set; }
            public string avatarColor { get; set; }
            public object addressGpsLat { get; set; }
            public object addressGpsLon { get; set; }
        }

        public class Contact
        {
            public int id { get; set; }
            public int clientId { get; set; }
            public string email { get; set; }
            public string phone { get; set; }
            public object name { get; set; }
            public bool isBilling { get; set; }
            public bool isContact { get; set; }
            public Type[] types { get; set; }
        }

        public class Type
        {
            public int id { get; set; }
            public string name { get; set; }
        }
}
