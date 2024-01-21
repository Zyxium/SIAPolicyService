namespace SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;

public class ValidateTokenRequest
{
    public string partnerReferenceCode { get; set; }
    public string agreementDate { get; set; }
    public string insuredType { get; set; }
    public Insured insured { get; set; }
    public string receiptAs { get; set; }
    public string receiptType { get; set; }
    public Receipt receipt { get; set; }
    public PolicyDeliveryMethod policyDeliveryMethod { get; set; }
    public Intermediary intermediary { get; set; }
    public Payment payment { get; set; }
    public Vehicle vehicle { get; set; }
    public Coverage coverage { get; set; }
}

public class Address
{
    public string addressType { get; set; }
    public string houseNumber { get; set; }
    public string moo { get; set; }
    public string street { get; set; }
    public string buildingVillage { get; set; }
    public string soi { get; set; }
    public string subdistrict { get; set; }
    public string district { get; set; }
    public string province { get; set; }
    public string postalCode { get; set; }
    public string country { get; set; }
}

public class Coverage
{
    public string periodType { get; set; }
    public string startDate { get; set; }
}

public class IdentityDocument
{
    public string documentType { get; set; }
    public string documentNumber { get; set; }
}

public class Insured
{
    public string title { get; set; }
    public string firstName { get; set; }
    public string middleName { get; set; }
    public string lastName { get; set; }
    public string email { get; set; }
    public string countryCode { get; set; }
    public string moblieNumber { get; set; }
    public string telephone { get; set; }
    public string gender { get; set; }
    public string maritalStatus { get; set; }
    public string nationality { get; set; }
    public string birthdate { get; set; }
    public string occupation { get; set; }
    public IdentityDocument identityDocument { get; set; }
    public Address address { get; set; }
}

public class Intermediary
{
    public string saleMethod { get; set; }
    public string title { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string subSaleCode { get; set; }
    public string email { get; set; }
    public string dealerCode { get; set; }
}

public class Payment
{
    public int premiumBeforeDiscount { get; set; }
    public int discount { get; set; }
    public int netPremium { get; set; }
    public double vat { get; set; }
    public int stamp { get; set; }
    public double grossPremium { get; set; }
    public int paidPremium { get; set; }
}

public class PolicyDeliveryMethod
{
    public bool sms { get; set; }
    public bool email { get; set; }
    public bool postMail { get; set; }
}

public class Receipt
{
    public string title { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string corporateName { get; set; }
    public string receiptBranchCode { get; set; }
    public IdentityDocument identityDocument { get; set; }
    public Address address { get; set; }
}

public class Vehicle
{
    public string brand { get; set; }
    public string model { get; set; }
    public string registrationYear { get; set; }
    public int cc { get; set; }
    public int seat { get; set; }
    public int weight { get; set; }
    public string plateNumber { get; set; }
    public string plateProvince { get; set; }
    public string plateCountry { get; set; }
    public string chassisNumber { get; set; }
    public string engineNumber { get; set; }
    public string vehicleTypeCode { get; set; }
    public string color { get; set; }
}