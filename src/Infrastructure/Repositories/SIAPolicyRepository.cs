using System.Text;
using Core.DotNet.Extensions.Utilities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate;
using SIAPolicyService.Domain.AggregatesModel.SIAPolicyAggregate.Interface;
using SIAPolicyService.Domain.AggregatesModel.VIBPolicyAggregate;
using SIAPolicyService.Infrastructure.DbContexts;

namespace SIAPolicyService.Infrastructure.Repositories;

public class SIAPolicyRepository : ISIAPolicyRepository
{
    private readonly SIADbContext _dbContext;
    
    public SIAPolicyRepository(SIADbContext context)
    {
        _dbContext = context;
    }

    public string CreatePolicyPersonAsync(ValidatePersonTokenRequest request, string agent_code)
    {
        var sb = new StringBuilder();
        sb.AppendLine("exec sp_policy_insert @TRAN_ID, @Payer_Id_Card, @Payer_Type_Id, @Payer_Type_Desc, @Payer_TitleId, @Payer_Title_text, @Payer_Firstname,");
        sb.AppendLine("@Payer_Lastname, @Payer_Company_Prefix, @Payer_Company_Name, @Payer_Company_Suffix, @Payer_Company_branch, @Payer_Company_branch_number,");
        sb.AppendLine("@Payer_HomeNo, @Payer_Moo, @Payer_Building, @Payer_Trok, @Payer_Soi, @Payer_Street, @Payer_SubDistrictID, @Payer_SubDistrictName, @Payer_DistrictID,");
        sb.AppendLine("@Payer_DistrictName, @Payer_ProvinceID, @Payer_ProvinceName, @Payer_Zipcode, @Payer_Phone, @Brand_code, @Brand_name, @Model_code, @Model_name,");
        sb.AppendLine("@License_no1, @License_no2, @License_ProvinceID, @License_Province, @Engine_no, @Chassis_no, @CC, @No_of_Seat, @Weight, @Cmi_MotCode, @Cmi_Policy_no,");
        sb.AppendLine("@Cmi_Sign_no, @Cmi_Agree_date, @Cmi_Start_date, @Cmi_End_date, @CountDay, @Cmi_Premium, @Cmi_Stamp, @Cmi_Vat, @Cmi_Total, @Cmi_Comm, @Cmi_CommTax,");
        sb.AppendLine("@Cmi_Discount, @Cmi_Payment, @AgentCode, @BrokerCode, @InsurCode, @IsPayment, @IsTrans, @IsCancel, @CreateBy, @UpdateBy, @Url_Policy, ");
        sb.AppendLine("@Color_code, @Color_name, @CountryCode");
        
        var insuredType = request.insuredType.GetEnum<InsuredType>();
        var payer_type_id = "";
        var payer_type_desc = "";
        switch (insuredType)
        {
            case InsuredType.person:
                payer_type_id = "C";
                payer_type_desc = "บัตรประชาชน";
                break;
            case InsuredType.corporate:
                payer_type_id = "B";
                payer_type_desc = "เลขที่จดทะเบียนบริษัท";
                break;
            case InsuredType.passport:
                payer_type_id = "P";
                payer_type_desc = "หนังสือเดินทาง";
                break;
        }
        
        try
        {
            var result = _dbContext.Database.ExecuteSqlRaw(sb.ToString(),
                new SqlParameter("@TRAN_ID", request.partnerReferenceCode),
                new SqlParameter("@Payer_Id_Card", request.insured.identityDocument.documentNumber),
                new SqlParameter("@Payer_Type_Id", payer_type_id),
                new SqlParameter("@Payer_Type_Desc", payer_type_desc),
                new SqlParameter("@Payer_TitleId", request.insured.titleId),//
                new SqlParameter("@Payer_Title_text", request.insured.title),
                new SqlParameter("@Payer_Firstname", request.insured.firstName),
                new SqlParameter("@Payer_Lastname", request.insured.lastName),
                new SqlParameter("@Payer_Company_Prefix", request.insured.corporateTitle),
                new SqlParameter("@Payer_Company_Name", request.insured.corporateName),
                new SqlParameter("@Payer_Company_Suffix", request.insured.corporateSuffix),//
                new SqlParameter("@Payer_Company_branch", request.insured.insuredBranchName),//
                new SqlParameter("@Payer_Company_branch_number", request.insured.insuredBranchCode),
                new SqlParameter("@Payer_HomeNo", request.insured.address.houseNumber),
                new SqlParameter("@Payer_Moo", request.insured.address.moo),
                new SqlParameter("@Payer_Building", request.insured.address.buildingVillage),
                new SqlParameter("@Payer_Trok", request.insured.address.trok),//
                new SqlParameter("@Payer_Soi", request.insured.address.soi),
                new SqlParameter("@Payer_Street", request.insured.address.street),
                new SqlParameter("@Payer_SubDistrictID", request.insured.address.subdistrictId),//
                new SqlParameter("@Payer_SubDistrictName", request.insured.address.subdistrictName),//
                new SqlParameter("@Payer_DistrictID", request.insured.address.districtId),//
                new SqlParameter("@Payer_DistrictName", request.insured.address.subdistrictName),//
                new SqlParameter("@Payer_ProvinceID", request.insured.address.provinceId),//
                new SqlParameter("@Payer_ProvinceName", request.insured.address.provinceName),//
                new SqlParameter("@Payer_Zipcode", request.insured.address.postalCode),
                new SqlParameter("@Payer_Phone", request.insured.telephone),
                new SqlParameter("@Brand_code", request.vehicle.brandCode),//
                new SqlParameter("@Brand_name", request.vehicle.brand),
                new SqlParameter("@Model_code", request.vehicle.modelCode),//
                new SqlParameter("@Model_name", request.vehicle.model),
                new SqlParameter("@License_no1", request.vehicle.License_no1),//
                new SqlParameter("@License_no2", request.vehicle.License_no2),//
                new SqlParameter("@License_ProvinceID", request.vehicle.License_ProvinceID),//
                new SqlParameter("@License_Province", request.vehicle.plateProvince),
                new SqlParameter("@Engine_no", request.vehicle.engineNumber),
                new SqlParameter("@Chassis_no", request.vehicle.chassisNumber),
                new SqlParameter("@CC", request.vehicle.cc),
                new SqlParameter("@No_of_Seat", request.vehicle.seat),
                new SqlParameter("@Weight", request.vehicle.weight),
                new SqlParameter("@Cmi_MotCode", request.vehicle.vehicleTypeCode),
                new SqlParameter("@Cmi_Policy_no", ""),//update from vib
                new SqlParameter("@Cmi_Sign_no", ""),
                new SqlParameter("@Cmi_Agree_date", request.agreementDate),
                new SqlParameter("@Cmi_Start_date", request.coverage.startDate),
                new SqlParameter("@Cmi_End_date", request.coverage.expiryDate),
                new SqlParameter("@CountDay", request.coverage.CountDay),//
                new SqlParameter("@Cmi_Premium", request.payment.netPremium),
                new SqlParameter("@Cmi_Stamp", request.payment.stamp),
                new SqlParameter("@Cmi_Vat", request.payment.vat),
                new SqlParameter("@Cmi_Total", request.payment.grossPremium),
                new SqlParameter("@Cmi_Comm", "0"),
                new SqlParameter("@Cmi_CommTax", "0"),
                new SqlParameter("@Cmi_Discount", "0"),
                new SqlParameter("@Cmi_Payment", request.payment.grossPremium),
                new SqlParameter("@AgentCode", agent_code),
                new SqlParameter("@BrokerCode", ""),
                new SqlParameter("@InsurCode", "VIB"),
                new SqlParameter("@IsPayment", "0"),
                new SqlParameter("@IsTrans", "0"),
                new SqlParameter("@IsCancel", "0"),
                new SqlParameter("@CreateBy", agent_code),
                new SqlParameter("@UpdateBy", agent_code),
                new SqlParameter("@Url_Policy", ""),
                new SqlParameter("@Color_code", "999"),
                new SqlParameter("@Color_name", request.vehicle.color),
                new SqlParameter("@CountryCode",request.insured.countryCode )
        
            );
            return request.partnerReferenceCode;
        }
        catch (Exception e)
        {
            return "";
        }
    }

    public string CreatePolicyCorporateAsync(ValidateCorporateDataRequest request)
    {
        // var tranId = Guid.NewGuid() + "-" + request.AgentCode;
        // var sb = new StringBuilder();
        // sb.AppendLine("exec sp_policy_insert @TRAN_ID, @Payer_Id_Card, @Payer_Type_Id, @Payer_Type_Desc, @Payer_TitleId, @Payer_Title_text, @Payer_Firstname,");
        // sb.AppendLine("@Payer_Lastname, @Payer_Company_Prefix, @Payer_Company_Name, @Payer_Company_Suffix, @Payer_Company_branch, @Payer_Company_branch_number,");
        // sb.AppendLine("@Payer_HomeNo, @Payer_Moo, @Payer_Building, @Payer_Trok, @Payer_Soi, @Payer_Street, @Payer_SubDistrictID, @Payer_SubDistrictName, @Payer_DistrictID,");
        // sb.AppendLine("@Payer_DistrictName, @Payer_ProvinceID, @Payer_ProvinceName, @Payer_Zipcode, @Payer_Phone, @Brand_code, @Brand_name, @Model_code, @Model_name,");
        // sb.AppendLine("@License_no1, @License_no2, @License_ProvinceID, @License_Province, @Engine_no, @Chassis_no, @CC, @No_of_Seat, @Weight, @Cmi_MotCode, @Cmi_Policy_no,");
        // sb.AppendLine("@Cmi_Sign_no, @Cmi_Agree_date, @Cmi_Start_date, @Cmi_End_date, @CountDay, @Cmi_Premium, @Cmi_Stamp, @Cmi_Vat, @Cmi_Total, @Cmi_Comm, @Cmi_CommTax,");
        // sb.AppendLine("@Cmi_Discount, @Cmi_Payment, @AgentCode, @BrokerCode, @InsurCode, @IsPayment, @IsTrans, @IsCancel, @CreateBy, @UpdateBy, @Url_Policy, ");
        // sb.AppendLine("@Color_code, @Color_name, @CountryCode");
        //
        // try
        // {
        //     var result = _dbContext.Database.ExecuteSqlRaw(sb.ToString(),
        //         new SqlParameter("@TRAN_ID", tranId),
        //         new SqlParameter("@Payer_Id_Card", request.insured.identityDocument.documentNumber),
        //         new SqlParameter("@Payer_Type_Id", "B"),
        //         new SqlParameter("@Payer_Type_Desc", "เลขที่จดทะเบียนบริษัท"),
        //         new SqlParameter("@Payer_TitleId", request.insured.corporateTitleId),
        //         new SqlParameter("@Payer_Title_text", ""),
        //         new SqlParameter("@Payer_Firstname", ""),
        //         new SqlParameter("@Payer_Lastname", ""),
        //         new SqlParameter("@Payer_Company_Prefix", request.insured.corporateTitle),
        //         new SqlParameter("@Payer_Company_Name", request.insured.corporateName),
        //         new SqlParameter("@Payer_Company_Suffix", request.insured.corporateSuffix),
        //         new SqlParameter("@Payer_Company_branch", request.insured.insuredBranchName),
        //         new SqlParameter("@Payer_Company_branch_number", request.insured.insuredBranchCode),
        //         new SqlParameter("@Payer_HomeNo", request.insured.address.houseNumber),
        //         new SqlParameter("@Payer_Moo", request.insured.address.moo),
        //         new SqlParameter("@Payer_Building", request.insured.address.buildingVillage),
        //         new SqlParameter("@Payer_Trok", request.insured.address.Trok),
        //         new SqlParameter("@Payer_Soi", request.insured.address.soi),
        //         new SqlParameter("@Payer_Street", request.insured.address.street),
        //         new SqlParameter("@Payer_SubDistrictID", request.insured.address.subdistrictId),
        //         new SqlParameter("@Payer_SubDistrictName", request.insured.address.subdistrictName),
        //         new SqlParameter("@Payer_DistrictID", request.insured.address.districtId),
        //
        //         new SqlParameter("@Payer_DistrictName", request.insured.address.districtName),
        //         new SqlParameter("@Payer_ProvinceID", request.insured.address.provinceId),
        //         new SqlParameter("@Payer_ProvinceName", request.insured.address.provinceName),
        //         new SqlParameter("@Payer_Zipcode", request.insured.address.postalCode),
        //         new SqlParameter("@Payer_Phone", request.insured.telephone),
        //         new SqlParameter("@Brand_code", request.vehicle.brandCode),
        //         new SqlParameter("@Brand_name", request.vehicle.brand),
        //         new SqlParameter("@Model_code", request.vehicle.modelCode),
        //         new SqlParameter("@Model_name", request.vehicle.model),
        //         new SqlParameter("@License_no1", request.vehicle.License_no1),
        //         new SqlParameter("@License_no2", request.vehicle.License_no2),
        //         new SqlParameter("@License_ProvinceID", request.vehicle.License_ProvinceID),
        //         new SqlParameter("@License_Province", request.vehicle.plateProvince),
        //         new SqlParameter("@Engine_no", request.vehicle.engineNumber),
        //         new SqlParameter("@Chassis_no", request.vehicle.chassisNumber),
        //         new SqlParameter("@CC", request.vehicle.cc),
        //         new SqlParameter("@No_of_Seat", request.vehicle.seat),
        //         new SqlParameter("@Weight", request.vehicle.weight),
        //         new SqlParameter("@Cmi_MotCode", request.vehicle.vehicleTypeCode),
        //         new SqlParameter("@Cmi_Policy_no", ""),//update from vib
        //         new SqlParameter("@Cmi_Sign_no", ""),
        //
        //         new SqlParameter("@Cmi_Agree_date", request.agreementDate),
        //         new SqlParameter("@Cmi_Start_date", request.coverage.startDate),
        //         new SqlParameter("@Cmi_End_date", request.coverage.expiryDate),
        //         new SqlParameter("@CountDay", request.coverage.CountDay),
        //         new SqlParameter("@Cmi_Premium", request.payment.netPremium),
        //         new SqlParameter("@Cmi_Stamp", request.payment.stamp),
        //         new SqlParameter("@Cmi_Vat", request.payment.vat),
        //         new SqlParameter("@Cmi_Total", request.payment.grossPremium),
        //         new SqlParameter("@Cmi_Comm", "0"),
        //         new SqlParameter("@Cmi_CommTax", "0"),
        //         new SqlParameter("@Cmi_Discount", "0"),
        //         new SqlParameter("@Cmi_Payment", request.payment.grossPremium),
        //         new SqlParameter("@AgentCode", request.AgentCode),
        //         new SqlParameter("@BrokerCode", ""),
        //         new SqlParameter("@InsurCode", "VIB"),
        //         new SqlParameter("@IsPayment", "0"),
        //         new SqlParameter("@IsTrans", "0"),
        //         new SqlParameter("@IsCancel", "0"),
        //         new SqlParameter("@CreateBy", request.AgentCode),
        //         new SqlParameter("@UpdateBy", request.AgentCode),
        //         new SqlParameter("@Url_Policy", ""),
        //         new SqlParameter("@Color_code", "999"),
        //         new SqlParameter("@Color_name", request.vehicle.color),
        //         new SqlParameter("@CountryCode",request.insured.countryCode )
        //
        //     );
        //     return tranId;
        // }
        // catch (Exception e)
        // {
        //     return "";
        // }
        return "";
    }

    public int UpdatePolicyPersonAsync(string tran_id, string Cmi_Policy_no, string Cmi_Sign_no, string Url_Policy)
    {
        try
        {
            var result = _dbContext.Database.ExecuteSqlRaw("exec sp_policy_update_success @TRAN_ID, @Cmi_Policy_no, @Cmi_Sign_no, @Url_Policy",
                new SqlParameter("@TRAN_ID", tran_id),
                new SqlParameter("@Cmi_Policy_no", Cmi_Policy_no),
                new SqlParameter("@Cmi_Sign_no", Cmi_Sign_no),
                new SqlParameter("@Url_Policy", Url_Policy)
            );
            return result;
        }
        catch (Exception e)
        {
            return -1;
        }
    }

    public int UpdatePolicyCorporateAsync(ValidateCorporateDataRequest request)
    {
        throw new NotImplementedException();
    }
}