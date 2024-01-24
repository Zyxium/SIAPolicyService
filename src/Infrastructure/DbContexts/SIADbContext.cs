using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Core.DotNet.Extensions.DbContext;
using Core.DotNet.Extensions.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SIAPolicyService.Domain.AggregatesModel.EntityAggregate;
using SIAPolicyService.Infrastructure.DbContexts.EntityTypeConfigurations;

namespace SIAPolicyService.Infrastructure.DbContexts;

public partial class SIADbContext : DbContext
{
    #region Table
    
     public virtual DbSet<AagiCarbrand> AagiCarbrands { get; set; }

    public virtual DbSet<AagiCarmaping> AagiCarmapings { get; set; }

    public virtual DbSet<AagiCarmodel> AagiCarmodels { get; set; }

    public virtual DbSet<AagiDistrict> AagiDistricts { get; set; }

    public virtual DbSet<AagiMotorcode> AagiMotorcodes { get; set; }

    public virtual DbSet<AagiMotorcodeOth> AagiMotorcodeOths { get; set; }

    public virtual DbSet<AagiNationality> AagiNationalities { get; set; }

    public virtual DbSet<AagiProvince> AagiProvinces { get; set; }

    public virtual DbSet<AagiSubdistrict> AagiSubdistricts { get; set; }

    public virtual DbSet<AagiTitle> AagiTitles { get; set; }

    public virtual DbSet<AagiTitleCorporate> AagiTitleCorporates { get; set; }

    public virtual DbSet<AagiVmiModellist> AagiVmiModellists { get; set; }

    public virtual DbSet<AagiVmiPremium> AagiVmiPremia { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AxaCarbrand> AxaCarbrands { get; set; }

    public virtual DbSet<AxaCarcolor> AxaCarcolors { get; set; }

    public virtual DbSet<AxaCarmodel> AxaCarmodels { get; set; }

    public virtual DbSet<AxaTitle> AxaTitles { get; set; }

    public virtual DbSet<AxaTitleCorporate> AxaTitleCorporates { get; set; }

    public virtual DbSet<CartDebitItem> CartDebitItems { get; set; }

    public virtual DbSet<CartInvoice> CartInvoices { get; set; }

    public virtual DbSet<CartItem> CartItems { get; set; }

    public virtual DbSet<CartQuotation> CartQuotations { get; set; }

    public virtual DbSet<ChrCarbrand> ChrCarbrands { get; set; }

    public virtual DbSet<ChrCarcolor> ChrCarcolors { get; set; }

    public virtual DbSet<ChrCarmodel> ChrCarmodels { get; set; }

    public virtual DbSet<ChrMotorcode> ChrMotorcodes { get; set; }

    public virtual DbSet<ChrMotorcodeOth> ChrMotorcodeOths { get; set; }

    public virtual DbSet<ChrTitle> ChrTitles { get; set; }

    public virtual DbSet<ChrTitleCorporate> ChrTitleCorporates { get; set; }

    public virtual DbSet<CmiCancel> CmiCancels { get; set; }

    public virtual DbSet<CmiCmi> CmiCmis { get; set; }

    public virtual DbSet<CmiCmiDocumentLink> CmiCmiDocumentLinks { get; set; }

    public virtual DbSet<CmiCmiTemp> CmiCmiTemps { get; set; }

    public virtual DbSet<CmiCommission> CmiCommissions { get; set; }

    public virtual DbSet<CmiCommissionInsure> CmiCommissionInsures { get; set; }

    public virtual DbSet<CmiPayinsurnceCart> CmiPayinsurnceCarts { get; set; }

    public virtual DbSet<CmiPayinsurnceDt> CmiPayinsurnceDts { get; set; }

    public virtual DbSet<CmiPayinsurnceDt2> CmiPayinsurnceDt2s { get; set; }

    public virtual DbSet<CmiPayinsurnceHd> CmiPayinsurnceHds { get; set; }

    public virtual DbSet<CmiPayinsurncePay> CmiPayinsurncePays { get; set; }

    public virtual DbSet<CmiReceiptCart> CmiReceiptCarts { get; set; }

    public virtual DbSet<CmiReceiptDt> CmiReceiptDts { get; set; }

    public virtual DbSet<CmiReceiptHd> CmiReceiptHds { get; set; }

    public virtual DbSet<CmiReceiptPay> CmiReceiptPays { get; set; }

    public virtual DbSet<CmiSignPayDt> CmiSignPayDts { get; set; }

    public virtual DbSet<CmiSignPayHd> CmiSignPayHds { get; set; }

    public virtual DbSet<CmiSignReceiveDt> CmiSignReceiveDts { get; set; }

    public virtual DbSet<CmiSignReceiveHd> CmiSignReceiveHds { get; set; }

    public virtual DbSet<CmiSmsLog> CmiSmsLogs { get; set; }

    public virtual DbSet<CmiStockpaper> CmiStockpapers { get; set; }

    public virtual DbSet<CmiTranid> CmiTranids { get; set; }

    public virtual DbSet<DhpMotorcode> DhpMotorcodes { get; set; }

    public virtual DbSet<DhpMotorcode2> DhpMotorcode2s { get; set; }

    public virtual DbSet<DhpMotorcodeOth> DhpMotorcodeOths { get; set; }

    public virtual DbSet<ErgoCarbrand> ErgoCarbrands { get; set; }

    public virtual DbSet<ErgoCarcolor> ErgoCarcolors { get; set; }

    public virtual DbSet<ErgoCarmodel> ErgoCarmodels { get; set; }

    public virtual DbSet<ErgoDistrict> ErgoDistricts { get; set; }

    public virtual DbSet<ErgoMotorcode> ErgoMotorcodes { get; set; }

    public virtual DbSet<ErgoMotorcode1> ErgoMotorcode1s { get; set; }

    public virtual DbSet<ErgoProvince> ErgoProvinces { get; set; }

    public virtual DbSet<ErgoSubdistrict> ErgoSubdistricts { get; set; }

    public virtual DbSet<FciCarbrand> FciCarbrands { get; set; }

    public virtual DbSet<FciCarmodel> FciCarmodels { get; set; }

    public virtual DbSet<FciMotorcode> FciMotorcodes { get; set; }

    public virtual DbSet<FciMotorcodeOth> FciMotorcodeOths { get; set; }

    public virtual DbSet<FciTitle> FciTitles { get; set; }

    public virtual DbSet<FciTitleCorporate> FciTitleCorporates { get; set; }

    public virtual DbSet<IciCarbrand> IciCarbrands { get; set; }

    public virtual DbSet<IciCarcolor> IciCarcolors { get; set; }

    public virtual DbSet<IciCarmodel> IciCarmodels { get; set; }

    public virtual DbSet<IciMotorcode> IciMotorcodes { get; set; }

    public virtual DbSet<IciMotorcodeOth> IciMotorcodeOths { get; set; }

    public virtual DbSet<IciSubdistrict> IciSubdistricts { get; set; }

    public virtual DbSet<IciTitle> IciTitles { get; set; }

    public virtual DbSet<IciTitleCorporate> IciTitleCorporates { get; set; }

    public virtual DbSet<IniCarbrand> IniCarbrands { get; set; }

    public virtual DbSet<IniCarcolor> IniCarcolors { get; set; }

    public virtual DbSet<IniCarmodel> IniCarmodels { get; set; }

    public virtual DbSet<IniMotorcode> IniMotorcodes { get; set; }

    public virtual DbSet<IniMotorcodeOth> IniMotorcodeOths { get; set; }

    public virtual DbSet<IniSubdistrict> IniSubdistricts { get; set; }

    public virtual DbSet<IniTitle> IniTitles { get; set; }

    public virtual DbSet<IniTitleCorporate> IniTitleCorporates { get; set; }

    public virtual DbSet<MigrationHistory> MigrationHistories { get; set; }

    public virtual DbSet<MotorPremiumSet> MotorPremiumSets { get; set; }

    public virtual DbSet<MtiCarbrand> MtiCarbrands { get; set; }

    public virtual DbSet<MtiCarcolor> MtiCarcolors { get; set; }

    public virtual DbSet<MtiCarmodel> MtiCarmodels { get; set; }

    public virtual DbSet<MtiMotorcode> MtiMotorcodes { get; set; }

    public virtual DbSet<MtiMotorcode1> MtiMotorcode1s { get; set; }

    public virtual DbSet<MtiVehicledetail> MtiVehicledetails { get; set; }

    public virtual DbSet<NonCarrier> NonCarriers { get; set; }

    public virtual DbSet<NonCarrierFile> NonCarrierFiles { get; set; }

    public virtual DbSet<NonCarrierTranid> NonCarrierTranids { get; set; }

    public virtual DbSet<NonPmi> NonPmis { get; set; }

    public virtual DbSet<NonTranid> NonTranids { get; set; }

    public virtual DbSet<OldDistrict> OldDistricts { get; set; }

    public virtual DbSet<OldProvince> OldProvinces { get; set; }

    public virtual DbSet<OldSubdistrict> OldSubdistricts { get; set; }

    public virtual DbSet<PmiCancel> PmiCancels { get; set; }

    public virtual DbSet<PmiPmi> PmiPmis { get; set; }

    public virtual DbSet<PmiPmiFileupload> PmiPmiFileuploads { get; set; }

    public virtual DbSet<PmiPmiImage> PmiPmiImages { get; set; }

    public virtual DbSet<PmiSmsLog> PmiSmsLogs { get; set; }

    public virtual DbSet<PmiTranid> PmiTranids { get; set; }

    public virtual DbSet<SagiCarbrand> SagiCarbrands { get; set; }

    public virtual DbSet<SagiCarmodel> SagiCarmodels { get; set; }

    public virtual DbSet<SagiDistrict> SagiDistricts { get; set; }

    public virtual DbSet<SagiMotorcode> SagiMotorcodes { get; set; }

    public virtual DbSet<SagiMotorcodeOth> SagiMotorcodeOths { get; set; }

    public virtual DbSet<SagiNationality> SagiNationalities { get; set; }

    public virtual DbSet<SagiProvince> SagiProvinces { get; set; }

    public virtual DbSet<SagiSubdistrict> SagiSubdistricts { get; set; }

    public virtual DbSet<SagiSubdistrictBkk> SagiSubdistrictBkks { get; set; }

    public virtual DbSet<SagiSubdistrictTemp> SagiSubdistrictTemps { get; set; }

    public virtual DbSet<SagiTitle> SagiTitles { get; set; }

    public virtual DbSet<SagiTitleCorporate> SagiTitleCorporates { get; set; }

    public virtual DbSet<StyMotorcode> StyMotorcodes { get; set; }

    public virtual DbSet<StyMotorcodeOth> StyMotorcodeOths { get; set; }

    public virtual DbSet<StyMotorcodeOth1> StyMotorcodeOth1s { get; set; }

    public virtual DbSet<StyPolicy> StyPolicies { get; set; }

    public virtual DbSet<TbAgent> TbAgents { get; set; }

    public virtual DbSet<TbAgentTemp> TbAgentTemps { get; set; }

    public virtual DbSet<TbAgenttype> TbAgenttypes { get; set; }

    public virtual DbSet<TbBankaccount> TbBankaccounts { get; set; }

    public virtual DbSet<TbBankaccountInsure> TbBankaccountInsures { get; set; }

    public virtual DbSet<TbCarbodytype> TbCarbodytypes { get; set; }

    public virtual DbSet<TbCarbrand> TbCarbrands { get; set; }

    public virtual DbSet<TbCarcolor> TbCarcolors { get; set; }

    public virtual DbSet<TbCarmodel> TbCarmodels { get; set; }

    public virtual DbSet<TbCommission> TbCommissions { get; set; }

    public virtual DbSet<TbCommissionTemp> TbCommissionTemps { get; set; }

    public virtual DbSet<TbCommissiontype> TbCommissiontypes { get; set; }

    public virtual DbSet<TbCountry> TbCountries { get; set; }

    public virtual DbSet<TbCredit> TbCredits { get; set; }

    public virtual DbSet<TbCreditTemp> TbCreditTemps { get; set; }

    public virtual DbSet<TbCreditteamLog> TbCreditteamLogs { get; set; }

    public virtual DbSet<TbCredittransaction> TbCredittransactions { get; set; }

    public virtual DbSet<TbCustomertype> TbCustomertypes { get; set; }

    public virtual DbSet<TbDaliveryTracking> TbDaliveryTrackings { get; set; }

    public virtual DbSet<TbDeliverySource> TbDeliverySources { get; set; }

    public virtual DbSet<TbDiscounttype> TbDiscounttypes { get; set; }

    public virtual DbSet<TbDistrict> TbDistricts { get; set; }

    public virtual DbSet<TbEndorse> TbEndorses { get; set; }

    public virtual DbSet<TbInsurance> TbInsurances { get; set; }

    public virtual DbSet<TbInsuranceCommission> TbInsuranceCommissions { get; set; }

    public virtual DbSet<TbInvoiceDt> TbInvoiceDts { get; set; }

    public virtual DbSet<TbInvoiceHd> TbInvoiceHds { get; set; }

    public virtual DbSet<TbLogCmi> TbLogCmis { get; set; }

    public virtual DbSet<TbLogVmi> TbLogVmis { get; set; }

    public virtual DbSet<TbMessage> TbMessages { get; set; }

    public virtual DbSet<TbMotorDebitDt> TbMotorDebitDts { get; set; }

    public virtual DbSet<TbMotorDebitHd> TbMotorDebitHds { get; set; }

    public virtual DbSet<TbMotorDebitPay> TbMotorDebitPays { get; set; }

    public virtual DbSet<TbMotorPayinsureDt> TbMotorPayinsureDts { get; set; }

    public virtual DbSet<TbMotorPayinsureHd> TbMotorPayinsureHds { get; set; }

    public virtual DbSet<TbMotorProduct> TbMotorProducts { get; set; }

    public virtual DbSet<TbMotorProducttype> TbMotorProducttypes { get; set; }

    public virtual DbSet<TbMotorQoutationDt> TbMotorQoutationDts { get; set; }

    public virtual DbSet<TbMotorQoutationHd> TbMotorQoutationHds { get; set; }

    public virtual DbSet<TbMotorReceiptDt> TbMotorReceiptDts { get; set; }

    public virtual DbSet<TbMotorReceiptHd> TbMotorReceiptHds { get; set; }

    public virtual DbSet<TbMotorReceiptPay> TbMotorReceiptPays { get; set; }

    public virtual DbSet<TbMotorRequest> TbMotorRequests { get; set; }

    public virtual DbSet<TbMotorRequestCmi> TbMotorRequestCmis { get; set; }

    public virtual DbSet<TbMotorcode> TbMotorcodes { get; set; }

    public virtual DbSet<TbMotorcodeVmi> TbMotorcodeVmis { get; set; }

    public virtual DbSet<TbNewEvent> TbNewEvents { get; set; }

    public virtual DbSet<TbNonmotorReceiptDt> TbNonmotorReceiptDts { get; set; }

    public virtual DbSet<TbNonmotorReceiptHd> TbNonmotorReceiptHds { get; set; }

    public virtual DbSet<TbOccupation> TbOccupations { get; set; }

    public virtual DbSet<TbPaymentstatus> TbPaymentstatuses { get; set; }

    public virtual DbSet<TbPaymenttran> TbPaymenttrans { get; set; }

    public virtual DbSet<TbPaymenttype> TbPaymenttypes { get; set; }

    public virtual DbSet<TbPremiumRate> TbPremiumRates { get; set; }

    public virtual DbSet<TbProduct> TbProducts { get; set; }

    public virtual DbSet<TbProvince> TbProvinces { get; set; }

    public virtual DbSet<TbReceiptAndPay> TbReceiptAndPays { get; set; }

    public virtual DbSet<TbReceiptDt> TbReceiptDts { get; set; }

    public virtual DbSet<TbReceiptHd> TbReceiptHds { get; set; }

    public virtual DbSet<TbReceiptPay> TbReceiptPays { get; set; }

    public virtual DbSet<TbReportsource> TbReportsources { get; set; }

    public virtual DbSet<TbSector> TbSectors { get; set; }

    public virtual DbSet<TbSeiCarbrand> TbSeiCarbrands { get; set; }

    public virtual DbSet<TbSeiCarmodel> TbSeiCarmodels { get; set; }

    public virtual DbSet<TbSeiTitle> TbSeiTitles { get; set; }

    public virtual DbSet<TbSubdistrict> TbSubdistricts { get; set; }

    public virtual DbSet<TbTaxtype> TbTaxtypes { get; set; }

    public virtual DbSet<TbTempcar> TbTempcars { get; set; }

    public virtual DbSet<TbTitle> TbTitles { get; set; }

    public virtual DbSet<TbTitleCorporate> TbTitleCorporates { get; set; }

    public virtual DbSet<TbTransactionLog> TbTransactionLogs { get; set; }

    public virtual DbSet<TbTree> TbTrees { get; set; }

    public virtual DbSet<TbTreeSupportInsurance> TbTreeSupportInsurances { get; set; }

    public virtual DbSet<TempPolicyNo> TempPolicyNos { get; set; }

    public virtual DbSet<TroCarcheck> TroCarchecks { get; set; }

    public virtual DbSet<TroCarcheckTemp> TroCarcheckTemps { get; set; }

    public virtual DbSet<TroCartype> TroCartypes { get; set; }

    public virtual DbSet<TroSmsLog> TroSmsLogs { get; set; }

    public virtual DbSet<TroTranid> TroTranids { get; set; }

    public virtual DbSet<TsiCarbrand> TsiCarbrands { get; set; }

    public virtual DbSet<TsiCarcolor> TsiCarcolors { get; set; }

    public virtual DbSet<TsiCarmodel> TsiCarmodels { get; set; }

    public virtual DbSet<TsiMotorcode> TsiMotorcodes { get; set; }

    public virtual DbSet<TsiMotorcode1> TsiMotorcode1s { get; set; }

    public virtual DbSet<TsiTitle> TsiTitles { get; set; }

    public virtual DbSet<TsiTitleCorporate> TsiTitleCorporates { get; set; }

    public virtual DbSet<UppCarbrand> UppCarbrands { get; set; }

    public virtual DbSet<UppCountry> UppCountries { get; set; }

    public virtual DbSet<UppMotorcode> UppMotorcodes { get; set; }

    public virtual DbSet<UppTitle> UppTitles { get; set; }

    public virtual DbSet<UppTitleCorporate> UppTitleCorporates { get; set; }

    public virtual DbSet<VAgentList> VAgentLists { get; set; }

    public virtual DbSet<VAgentcommList> VAgentcommLists { get; set; }

    public virtual DbSet<VCreditList> VCreditLists { get; set; }

    public virtual DbSet<VInsurecommList> VInsurecommLists { get; set; }

    public virtual DbSet<VInvoiceList> VInvoiceLists { get; set; }

    public virtual DbSet<VPmiPmi> VPmiPmis { get; set; }

    public virtual DbSet<VPmiRequest> VPmiRequests { get; set; }

    public virtual DbSet<VReceiptMotorList> VReceiptMotorLists { get; set; }

    public virtual DbSet<VReceiptPolicy> VReceiptPolicies { get; set; }

    public virtual DbSet<VReceiptPolicyMaster> VReceiptPolicyMasters { get; set; }

    public virtual DbSet<VUserlist> VUserlists { get; set; }

    public virtual DbSet<VcmiCmi> VcmiCmis { get; set; }

    public virtual DbSet<ViiCarbrand> ViiCarbrands { get; set; }

    public virtual DbSet<ViiCarmodel> ViiCarmodels { get; set; }

    public virtual DbSet<ViiCarmodelTemp> ViiCarmodelTemps { get; set; }

    public virtual DbSet<ViiMotorcode> ViiMotorcodes { get; set; }

    public virtual DbSet<ViiMotorcodeNocomm> ViiMotorcodeNocomms { get; set; }

    public virtual DbSet<ViiMotorcodeOth> ViiMotorcodeOths { get; set; }

    public virtual DbSet<ViiMotorcodeTruck> ViiMotorcodeTrucks { get; set; }

    public virtual DbSet<ViiTitle> ViiTitles { get; set; }

    public virtual DbSet<ViiTitleCorporate> ViiTitleCorporates { get; set; }

    public virtual DbSet<ViiVmiCarmodel> ViiVmiCarmodels { get; set; }

    public virtual DbSet<ViiVmiPackageRate> ViiVmiPackageRates { get; set; }

    public virtual DbSet<VmiCommission> VmiCommissions { get; set; }

    public virtual DbSet<VmiCommissionInsure> VmiCommissionInsures { get; set; }

    public virtual DbSet<VmiMotor> VmiMotors { get; set; }

    public virtual DbSet<VmiPayinsuranceCart> VmiPayinsuranceCarts { get; set; }

    public virtual DbSet<VmiPayinsuranceDt> VmiPayinsuranceDts { get; set; }

    public virtual DbSet<VmiPayinsuranceHd> VmiPayinsuranceHds { get; set; }

    public virtual DbSet<VmiPayinsurancePay> VmiPayinsurancePays { get; set; }

    public virtual DbSet<VpmiQuotation> VpmiQuotations { get; set; }

    public virtual DbSet<VtroList> VtroLists { get; set; }
    
    #endregion
    
    public SIADbContext(DbContextOptions<SIADbContext> options) : base(options)
    {
        Debug.WriteLine("AuthenticationDbContext::ctor ->" + GetHashCode());
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region ModelBuilder
   
              modelBuilder.Entity<AagiCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("aagi_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandAagi)
                .HasMaxLength(10)
                .HasColumnName("Brand_aagi");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(10);
        });

        modelBuilder.Entity<AagiCarmaping>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("aagi_carmaping");

            entity.Property(e => e.BrandId)
                .HasMaxLength(50)
                .HasColumnName("BrandID");
            entity.Property(e => e.ModelId).HasMaxLength(50);
            entity.Property(e => e.ModelName).HasMaxLength(50);
        });

        modelBuilder.Entity<AagiCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("aagi_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdAagi)
                .HasMaxLength(10)
                .HasColumnName("ModelId_aagi");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<AagiDistrict>(entity =>
        {
            entity.HasKey(e => new { e.DistrictCode, e.ProvinceCode });

            entity.ToTable("aagi_district");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictCodeAagi).HasColumnName("DistrictCode_aagi");
            entity.Property(e => e.DistrictName).HasMaxLength(150);
            entity.Property(e => e.ProvinceCodeAagi).HasColumnName("ProvinceCode_aagi");
        });

        modelBuilder.Entity<AagiMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("aagi_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AagiMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("aagi_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AagiNationality>(entity =>
        {
            entity.HasKey(e => e.NationalityCode);

            entity.ToTable("aagi_nationality");

            entity.Property(e => e.NationalityCode).HasMaxLength(5);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NationalityName).HasMaxLength(150);
        });

        modelBuilder.Entity<AagiProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceCode).HasName("PK_azcp_province");

            entity.ToTable("aagi_province");

            entity.Property(e => e.ProvinceCode).ValueGeneratedNever();
            entity.Property(e => e.CreaDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.ProvinceCodeAagi).HasColumnName("ProvinceCode_Aagi");
            entity.Property(e => e.ProvinceDesc).HasMaxLength(5);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(5);
        });

        modelBuilder.Entity<AagiSubdistrict>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode });

            entity.ToTable("aagi_subdistrict");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictCodeAagi).HasColumnName("DistrictCode_aagi");
            entity.Property(e => e.ProvinceCodeAagi).HasColumnName("ProvinceCode_aagi");
            entity.Property(e => e.SubDistrictCodeAagi).HasColumnName("SubDistrictCode_aagi");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<AagiTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("aagi_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleCodeAagi)
                .HasMaxLength(50)
                .HasColumnName("TitleCode_aagi");
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdAagi)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Aagi");
        });

        modelBuilder.Entity<AagiTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("aagi_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleCodeAagi)
                .HasMaxLength(50)
                .HasColumnName("TitleCode_aagi");
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdAagi)
                .HasMaxLength(10)
                .HasColumnName("TitleID_aagi");
        });

        modelBuilder.Entity<AagiVmiModellist>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("aagi_vmi_modellist");

            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CoverType).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.ModelId).HasMaxLength(50);
            entity.Property(e => e.Modelname).HasMaxLength(250);
            entity.Property(e => e.PackageId).HasMaxLength(20);
        });

        modelBuilder.Entity<AagiVmiPremium>(entity =>
        {
            entity.HasKey(e => e.Packaged);

            entity.ToTable("aagi_vmi_premium");

            entity.Property(e => e.Packaged).HasMaxLength(50);
            entity.Property(e => e.Bb)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BB");
            entity.Property(e => e.CoverType).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Deductible).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Flood).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GarageType).HasMaxLength(50);
            entity.Property(e => e.GrossTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.MaxAge).HasColumnName("Max_Age");
            entity.Property(e => e.Me)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ME");
            entity.Property(e => e.MinAge).HasColumnName("Min_Age");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Pa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PA");
            entity.Property(e => e.RegionType).HasMaxLength(50);
            entity.Property(e => e.RoadsideAssistance)
                .HasMaxLength(50)
                .HasColumnName("Roadside_Assistance");
            entity.Property(e => e.Stamp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SumInsured).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TpbiAccident)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPBI_Accident");
            entity.Property(e => e.TpbiPerson)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPBI_Person");
            entity.Property(e => e.Tppd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPPD");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VehicleUsage).HasMaxLength(50);
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetRoles");

            entity.HasIndex(e => e.Name, "RoleNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUsers");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(256);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "AspNetUserRole",
                    r => r.HasOne<AspNetRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId"),
                    l => l.HasOne<AspNetUser>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK_dbo.AspNetUserRoles");
                        j.ToTable("AspNetUserRoles");
                        j.HasIndex(new[] { "RoleId" }, "IX_RoleId");
                        j.HasIndex(new[] { "UserId" }, "IX_UserId");
                        j.IndexerProperty<string>("UserId").HasMaxLength(128);
                        j.IndexerProperty<string>("RoleId").HasMaxLength(128);
                    });
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.AspNetUserClaims");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.UserId)
                .IsRequired()
                .HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserClaims)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId }).HasName("PK_dbo.AspNetUserLogins");

            entity.HasIndex(e => e.UserId, "IX_UserId");

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);

            entity.HasOne(d => d.User).WithMany(p => p.AspNetUserLogins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
        });

        modelBuilder.Entity<AxaCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("axa_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdAxa)
                .HasMaxLength(5)
                .HasColumnName("BrandId_axa");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<AxaCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("axa_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorIdAxa)
                .HasMaxLength(10)
                .HasColumnName("ColorID_axa");
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<AxaCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("axa_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdAxa)
                .HasMaxLength(10)
                .HasColumnName("ModelId_axa");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<AxaTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("axa_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdAxa)
                .HasMaxLength(10)
                .HasColumnName("TitleID_axa");
        });

        modelBuilder.Entity<AxaTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("axa_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdAxa)
                .HasMaxLength(10)
                .HasColumnName("TitleID_axa");
        });

        modelBuilder.Entity<CartDebitItem>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.Property(e => e.ItemId).HasMaxLength(128);
            entity.Property(e => e.InsurCode).HasMaxLength(50);
            entity.Property(e => e.PmiDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Discount");
            entity.Property(e => e.PmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Payment");
            entity.Property(e => e.PmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Premium");
            entity.Property(e => e.PmiStamp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Stamp");
            entity.Property(e => e.PmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Total");
            entity.Property(e => e.PmiVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Vat");
            entity.Property(e => e.PolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Policy_No");
            entity.Property(e => e.TranIdPmi)
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID_PMI");
        });

        modelBuilder.Entity<CartInvoice>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_dbo.CartInvoices");

            entity.Property(e => e.ItemId).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ProductNoNavigation).WithMany(p => p.CartInvoices)
                .HasForeignKey(d => d.ProductNo)
                .HasConstraintName("FK_dbo.CartInvoices_dbo.tb_product_ProductNo");
        });

        modelBuilder.Entity<CartItem>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_dbo.CartItems");

            entity.Property(e => e.ItemId).HasMaxLength(128);
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.ProductNoNavigation).WithMany(p => p.CartItems)
                .HasForeignKey(d => d.ProductNo)
                .HasConstraintName("FK_dbo.CartItems_dbo.tb_product_ProductNo");
        });

        modelBuilder.Entity<CartQuotation>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("CartQuotation");

            entity.Property(e => e.ItemId).HasMaxLength(128);
            entity.Property(e => e.CampaignCode).HasMaxLength(50);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.DriverInsurance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DriverTypeCd).HasMaxLength(50);
            entity.Property(e => e.GarageTypeCd).HasMaxLength(50);
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.InsureName).HasMaxLength(250);
            entity.Property(e => e.LossMedicalAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerDedugAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerFireAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerTimeAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPaperPassengerAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerAmt");
            entity.Property(e => e.LossPerAssetAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerDedugAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerSonAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerTimeAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NoOfSeat)
                .HasMaxLength(50)
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Premium");
            entity.Property(e => e.PmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Total");
            entity.Property(e => e.ProductTypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<ChrCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("chr_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdChr)
                .HasMaxLength(10)
                .HasColumnName("BrandId_Chr");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<ChrCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("chr_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorIdChr)
                .HasMaxLength(10)
                .HasColumnName("ColorID_Chr");
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ChrCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("chr_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdChr)
                .HasMaxLength(50)
                .HasColumnName("ModelId_chr");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<ChrMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("chr_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ChrMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("chr_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ChrTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("chr_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdChr)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Chr");
        });

        modelBuilder.Entity<ChrTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("chr_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdChr)
                .HasMaxLength(10)
                .HasColumnName("TitleID_chr");
        });

        modelBuilder.Entity<CmiCancel>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("cmi_cancel");

            entity.Property(e => e.TranId).HasMaxLength(50);
            entity.Property(e => e.AgentCode).HasMaxLength(20);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InsCode).HasMaxLength(10);
            entity.Property(e => e.PolicyNo).HasMaxLength(30);
            entity.Property(e => e.RefCode).HasMaxLength(50);
            entity.Property(e => e.RefUrl).HasMaxLength(250);
            entity.Property(e => e.SignNo).HasMaxLength(50);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmiCmi>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("cmi_cmi");

            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.Cc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CmiAgreeDate).HasColumnName("Cmi_Agree_date");
            entity.Property(e => e.CmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Comm");
            entity.Property(e => e.CmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_CommTax");
            entity.Property(e => e.CmiDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Discount");
            entity.Property(e => e.CmiEndDate).HasColumnName("Cmi_End_date");
            entity.Property(e => e.CmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Cmi_MotCode");
            entity.Property(e => e.CmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Payment");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(30)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPremium)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiSignNo)
                .HasMaxLength(100)
                .HasColumnName("Cmi_Sign_no");
            entity.Property(e => e.CmiStamp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Stamp");
            entity.Property(e => e.CmiStartDate).HasColumnName("Cmi_Start_date");
            entity.Property(e => e.CmiTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CmiVat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Vat");
            entity.Property(e => e.ColorCode)
                .HasMaxLength(10)
                .HasColumnName("Color_code");
            entity.Property(e => e.ColorName)
                .HasMaxLength(50)
                .HasColumnName("Color_name");
            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.IsTrans).HasDefaultValue(0);
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_code");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_name");
            entity.Property(e => e.NoOfSeat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CmiCmiDocumentLink>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("cmi_cmi_document_link");

            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Header).HasColumnName("header");
            entity.Property(e => e.Insurcode)
                .HasMaxLength(10)
                .HasColumnName("insurcode");
            entity.Property(e => e.Layer)
                .HasMaxLength(50)
                .HasColumnName("layer");
            entity.Property(e => e.Link)
                .HasMaxLength(250)
                .HasColumnName("link");
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("tran_id");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .HasColumnName("type");
        });

        modelBuilder.Entity<CmiCmiTemp>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("cmi_cmi_temp");

            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CmiAgreeDate).HasColumnName("Cmi_Agree_date");
            entity.Property(e => e.CmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Comm");
            entity.Property(e => e.CmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_CommTax");
            entity.Property(e => e.CmiDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Discount");
            entity.Property(e => e.CmiEndDate).HasColumnName("Cmi_End_date");
            entity.Property(e => e.CmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Cmi_MotCode");
            entity.Property(e => e.CmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Payment");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiSignNo)
                .HasMaxLength(100)
                .HasColumnName("Cmi_Sign_no");
            entity.Property(e => e.CmiStamp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Stamp");
            entity.Property(e => e.CmiStartDate).HasColumnName("Cmi_Start_date");
            entity.Property(e => e.CmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CmiVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Vat");
            entity.Property(e => e.ColorCode)
                .HasMaxLength(10)
                .HasColumnName("Color_code");
            entity.Property(e => e.ColorName)
                .HasMaxLength(50)
                .HasColumnName("Color_name");
            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.InsurCode).HasMaxLength(10);
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_code");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_name");
            entity.Property(e => e.NoOfSeat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CmiCommission>(entity =>
        {
            entity.HasKey(e => new { e.AgentCode, e.InsureCode, e.MotorCode }).HasName("PK_cmi_commission_1");

            entity.ToTable("cmi_commission");

            entity.Property(e => e.AgentCode).HasMaxLength(15);
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.MotorCode).HasMaxLength(10);
            entity.Property(e => e.CommTypeCode)
                .IsRequired()
                .HasMaxLength(2);
            entity.Property(e => e.CommissionNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CmiCommissionInsure>(entity =>
        {
            entity.HasKey(e => new { e.InsureCode, e.MotorCode });

            entity.ToTable("cmi_commission_insure");

            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.MotorCode).HasMaxLength(10);
            entity.Property(e => e.CommTypeCode1).HasMaxLength(2);
            entity.Property(e => e.CommTypeCode2).HasMaxLength(2);
            entity.Property(e => e.CommTypeCode3).HasMaxLength(2);
            entity.Property(e => e.CommTypeCode4).HasMaxLength(2);
            entity.Property(e => e.CommissionNet)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<CmiPayinsurnceCart>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_cmi_payinsurnce_dt_dummy");

            entity.ToTable("cmi_payinsurnce_cart");

            entity.Property(e => e.ItemId).HasMaxLength(128);
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(550)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiTotal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CommissionAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetPremiumAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CmiPayinsurnceDt>(entity =>
        {
            entity.HasKey(e => new { e.RowNumber, e.DocNo });

            entity.ToTable("cmi_payinsurnce_dt");

            entity.Property(e => e.RowNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.CmiAgreeDate)
                .HasColumnType("datetime")
                .HasColumnName("Cmi_Agree_date");
            entity.Property(e => e.CmiEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Cmi_End_date");
            entity.Property(e => e.CmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Cmi_MotCode");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Cmi_Start_date");
            entity.Property(e => e.CmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CommTypeCode1).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode2).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode3).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode4).HasMaxLength(5);
            entity.Property(e => e.Commission1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commission2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commission3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commission4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.NetPremiumAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CmiPayinsurnceDt2>(entity =>
        {
            entity.HasKey(e => new { e.RowNumber, e.DocNo });

            entity.ToTable("cmi_payinsurnce_dt2");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.CmiAgreeDate)
                .HasColumnType("datetime")
                .HasColumnName("Cmi_Agree_date");
            entity.Property(e => e.CmiEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Cmi_End_date");
            entity.Property(e => e.CmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Cmi_MotCode");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Cmi_Start_date");
            entity.Property(e => e.CmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CommTypeCode1).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode2).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode3).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode4).HasMaxLength(5);
            entity.Property(e => e.Commission1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Commission2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Commission3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Commission4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionAmount1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionAmount2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionAmount3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionAmount4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTaxAmount1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTaxAmount2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTaxAmount3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTaxAmount4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVatAmount1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVatAmount2).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVatAmount3).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVatAmount4).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.NetPremiumAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CmiPayinsurnceHd>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("cmi_payinsurnce_hd");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiTotal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CommissionAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CountPolicy).HasDefaultValue(0);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.InsureName).HasMaxLength(250);
            entity.Property(e => e.NetPremiumAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CmiPayinsurncePay>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("cmi_payinsurnce_pay");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranch).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BankTranDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocnoRef).HasMaxLength(30);
            entity.Property(e => e.Img64File).HasColumnName("img64File");
            entity.Property(e => e.ImgName)
                .HasMaxLength(50)
                .HasColumnName("imgName");
            entity.Property(e => e.ImgType)
                .HasMaxLength(50)
                .HasColumnName("imgType");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentTypeDesc).HasMaxLength(150);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmiReceiptCart>(entity =>
        {
            entity.HasKey(e => e.ItemId);

            entity.ToTable("cmi_receipt_cart");

            entity.Property(e => e.ItemId).HasMaxLength(128);
            entity.Property(e => e.InsureCode).HasMaxLength(20);
            entity.Property(e => e.NetComm).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PolicyNo)
                .IsRequired()
                .HasMaxLength(30);
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CmiReceiptDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.PolicyNo }).HasName("PK_cmi_RCDT");

            entity.ToTable("cmi_receipt_dt");

            entity.Property(e => e.DocNo).HasMaxLength(20);
            entity.Property(e => e.PolicyNo).HasMaxLength(30);
            entity.Property(e => e.InsureCode).HasMaxLength(20);
            entity.Property(e => e.NetComm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CmiReceiptHd>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("cmi_receipt_hd");

            entity.Property(e => e.DocNo).HasMaxLength(20);
            entity.Property(e => e.AgentCode).HasMaxLength(20);
            entity.Property(e => e.AgentName).HasMaxLength(200);
            entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ReceivedConfirmBy).HasMaxLength(50);
            entity.Property(e => e.ReceivedConfrimDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedStatusId).HasColumnName("ReceivedStatusID");
            entity.Property(e => e.TeamAgentCode).HasMaxLength(50);
            entity.Property(e => e.TeamAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(20);
        });

        modelBuilder.Entity<CmiReceiptPay>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("cmi_receipt_pay");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranch).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BankTranDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocnoRef).HasMaxLength(30);
            entity.Property(e => e.Img64File).HasColumnName("img64File");
            entity.Property(e => e.ImgName)
                .HasMaxLength(50)
                .HasColumnName("imgName");
            entity.Property(e => e.ImgType)
                .HasMaxLength(50)
                .HasColumnName("imgType");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentTypeDesc).HasMaxLength(150);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmiSignPayDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.SignNo });

            entity.ToTable("cmi_sign_pay_dt");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.SignNo).HasMaxLength(50);
            entity.Property(e => e.IsUseDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmiSignPayHd>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("cmi_sign_pay_hd");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
        });

        modelBuilder.Entity<CmiSignReceiveDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.SignNo }).HasName("PK_cmi_sign_receipt_dt");

            entity.ToTable("cmi_sign_receive_dt");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.SignNo).HasMaxLength(50);
            entity.Property(e => e.DealToAgent).HasMaxLength(50);
            entity.Property(e => e.DealToDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<CmiSignReceiveHd>(entity =>
        {
            entity.HasKey(e => e.DocNo).HasName("PK_cmi_sign_receipt_hd");

            entity.ToTable("cmi_sign_receive_hd");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.SignYear).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<CmiSmsLog>(entity =>
        {
            entity.HasKey(e => e.No);

            entity.ToTable("cmi_sms_log");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.LicenseNo).HasMaxLength(50);
            entity.Property(e => e.Msisdn)
                .HasMaxLength(50)
                .HasColumnName("MSISDN");
            entity.Property(e => e.SmslogDesc).HasColumnName("SMSLogDesc");
            entity.Property(e => e.UseCredit).HasDefaultValue(0);
        });

        modelBuilder.Entity<CmiStockpaper>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("cmi_stockpaper");

            entity.Property(e => e.TranId).HasColumnName("tran_Id");
            entity.Property(e => e.Agentcode)
                .HasMaxLength(50)
                .HasColumnName("agentcode");
            entity.Property(e => e.Agentname)
                .HasMaxLength(150)
                .HasColumnName("agentname");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasDefaultValue("system")
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Insurecode)
                .HasMaxLength(50)
                .HasColumnName("insurecode");
            entity.Property(e => e.Insurename)
                .HasMaxLength(150)
                .HasColumnName("insurename");
            entity.Property(e => e.Qty)
                .HasDefaultValue(0)
                .HasColumnName("qty");
            entity.Property(e => e.Remark)
                .HasMaxLength(250)
                .HasColumnName("remark");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("tran_date");
        });

        modelBuilder.Entity<CmiTranid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("cmi_tranid");

            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
        });

        modelBuilder.Entity<DhpMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("dhp_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.VoluntaryCode).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<DhpMotorcode2>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("dhp_motorcode_2");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.VoluntaryCode).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<DhpMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("dhp_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.VoluntaryCode).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ErgoCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("ergo_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(10);
        });

        modelBuilder.Entity<ErgoCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("ergo_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<ErgoCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("ergo_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InEanable).HasDefaultValue(0);
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<ErgoDistrict>(entity =>
        {
            entity.HasKey(e => new { e.DistrictCode, e.ProvinceCode }).HasName("PK_ergo_District");

            entity.ToTable("ergo_district");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictName).HasMaxLength(150);
        });

        modelBuilder.Entity<ErgoMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("ergo_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ErgoMotorcode1>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("ergo_motorcode_1");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ErgoProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceCode).HasName("PK_ergo_Province");

            entity.ToTable("ergo_province");

            entity.Property(e => e.ProvinceCode).ValueGeneratedNever();
            entity.Property(e => e.CreaDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.ProvinceDesc).HasMaxLength(5);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(5);
        });

        modelBuilder.Entity<ErgoSubdistrict>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode }).HasName("PK_ergo_SubDistrict");

            entity.ToTable("ergo_subdistrict");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<FciCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("fci_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdFci)
                .HasMaxLength(5)
                .HasColumnName("BrandId_fci");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<FciCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("fci_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdFci)
                .HasMaxLength(50)
                .HasColumnName("ModelId_fci");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<FciMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("fci_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FciMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("fci_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<FciTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("fci_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdFci)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Fci");
        });

        modelBuilder.Entity<FciTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("fci_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdFci)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Fci");
        });

        modelBuilder.Entity<IciCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("ici_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdIci)
                .HasMaxLength(10)
                .HasColumnName("BrandId_ici");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<IciCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("ici_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorIdIci)
                .HasMaxLength(10)
                .HasColumnName("ColorID_ici");
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IciCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("ici_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandIdIci)
                .HasMaxLength(10)
                .HasColumnName("BrandId_ici");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdIci)
                .HasMaxLength(20)
                .HasColumnName("ModelId_ici");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<IciMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("ici_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<IciMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("ici_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<IciSubdistrict>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode }).HasName("PK_ici_SubDistrict");

            entity.ToTable("ici_subdistrict");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<IciTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("ici_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdIci)
                .HasMaxLength(10)
                .HasColumnName("TitleID_ici");
        });

        modelBuilder.Entity<IciTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("ici_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdIci)
                .HasMaxLength(10)
                .HasColumnName("TitleID_ici");
        });

        modelBuilder.Entity<IniCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("ini_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdIni)
                .HasMaxLength(10)
                .HasColumnName("BrandId_ini");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<IniCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("ini_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorIdIni)
                .HasMaxLength(10)
                .HasColumnName("ColorID_ini");
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<IniCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("ini_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandIdIni)
                .HasMaxLength(10)
                .HasColumnName("BrandId_ini");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdIni)
                .HasMaxLength(20)
                .HasColumnName("ModelId_ini");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<IniMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("ini_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<IniMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("ini_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<IniSubdistrict>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode });

            entity.ToTable("ini_subdistrict");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.OldDistrictCode).HasColumnName("old_DistrictCode");
            entity.Property(e => e.OldProvinceCode).HasColumnName("old_ProvinceCode");
            entity.Property(e => e.OldSubDistrictCode).HasColumnName("old_SubDistrictCode");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<IniTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("ini_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdIni)
                .HasMaxLength(10)
                .HasColumnName("TitleID_ini");
        });

        modelBuilder.Entity<IniTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("ini_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdIni)
                .HasMaxLength(10)
                .HasColumnName("TitleID_ini");
        });

        modelBuilder.Entity<MigrationHistory>(entity =>
        {
            entity.HasKey(e => new { e.MigrationId, e.ContextKey }).HasName("PK_dbo.__MigrationHistory");

            entity.ToTable("__MigrationHistory");

            entity.Property(e => e.MigrationId).HasMaxLength(150);
            entity.Property(e => e.ContextKey).HasMaxLength(300);
            entity.Property(e => e.Model).IsRequired();
            entity.Property(e => e.ProductVersion)
                .IsRequired()
                .HasMaxLength(32);
        });

        modelBuilder.Entity<MotorPremiumSet>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("motor_premium_set");

            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DriverInsurance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerDriver1Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerFireAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPaperDriver1Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerDriver1Amt");
            entity.Property(e => e.LossPaperPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerAmt");
            entity.Property(e => e.LossPaperPassengerNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerNo");
            entity.Property(e => e.LossPerAssetAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerSonAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PremiumTitle)
                .HasMaxLength(150)
                .HasColumnName("Premium_Title");
            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
        });

        modelBuilder.Entity<MtiCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("mti_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandIdMti)
                .HasMaxLength(10)
                .HasColumnName("BrandId_mti");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(20);
        });

        modelBuilder.Entity<MtiCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("mti_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorIdMti)
                .HasMaxLength(10)
                .HasColumnName("ColorID_mti");
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<MtiCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("mti_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdMti)
                .HasMaxLength(50)
                .HasColumnName("ModelId_mti");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<MtiMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("mti_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MtiMotorcode1>(entity =>
        {
            entity.HasKey(e => e.MotCode).HasName("PK_mti_motorcode_oth");

            entity.ToTable("mti_motorcode_1");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<MtiVehicledetail>(entity =>
        {
            entity.HasKey(e => e.VehicleKey);

            entity.ToTable("mti_vehicledetail");

            entity.Property(e => e.VehicleKey).HasMaxLength(20);
            entity.Property(e => e.BodyStyle).HasMaxLength(50);
            entity.Property(e => e.CarTypeDesc).HasMaxLength(50);
            entity.Property(e => e.CarTypeMap).HasMaxLength(50);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Drive).HasMaxLength(50);
            entity.Property(e => e.EngineSize).HasMaxLength(50);
            entity.Property(e => e.Family).HasMaxLength(20);
            entity.Property(e => e.FuelType).HasMaxLength(50);
            entity.Property(e => e.MakeCode).HasMaxLength(10);
            entity.Property(e => e.Mtikey)
                .HasMaxLength(10)
                .HasColumnName("MTIKey");
            entity.Property(e => e.Transmission).HasMaxLength(50);
            entity.Property(e => e.VehCode).HasMaxLength(50);
            entity.Property(e => e.YearGroupId)
                .HasMaxLength(50)
                .HasColumnName("YearGroupID");
        });

        modelBuilder.Entity<NonCarrier>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("non_carrier");

            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("tran_id");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.ApproveBy)
                .HasMaxLength(50)
                .HasColumnName("approve_by");
            entity.Property(e => e.ApproveDate)
                .HasColumnType("datetime")
                .HasColumnName("approve_date");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasColumnName("create_by");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("create_date");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.IsApproved)
                .HasDefaultValue(0)
                .HasColumnName("isApproved");
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.IsPolicy).HasDefaultValue(0);
            entity.Property(e => e.IsReceive).HasDefaultValue(0);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.Remark).HasColumnName("remark");
            entity.Property(e => e.Sec1Building)
                .HasMaxLength(100)
                .HasColumnName("sec1_building");
            entity.Property(e => e.Sec1CompanyBranch)
                .HasMaxLength(100)
                .HasColumnName("sec1_company_branch");
            entity.Property(e => e.Sec1CompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("sec1_Company_branch_number");
            entity.Property(e => e.Sec1CompanyName)
                .HasMaxLength(100)
                .HasColumnName("sec1_company_name");
            entity.Property(e => e.Sec1CompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("sec1_company_prefix");
            entity.Property(e => e.Sec1CompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("sec1_company_suffix");
            entity.Property(e => e.Sec1Districtid)
                .HasDefaultValue(0)
                .HasColumnName("sec1_districtid");
            entity.Property(e => e.Sec1Districtname)
                .HasMaxLength(100)
                .HasColumnName("sec1_districtname");
            entity.Property(e => e.Sec1Firstname)
                .HasMaxLength(100)
                .HasColumnName("sec1_firstname");
            entity.Property(e => e.Sec1Homeno)
                .HasMaxLength(20)
                .HasColumnName("sec1_homeno");
            entity.Property(e => e.Sec1IdCard)
                .HasMaxLength(50)
                .HasColumnName("sec1_id_card");
            entity.Property(e => e.Sec1Lastname)
                .HasMaxLength(100)
                .HasColumnName("sec1_lastname");
            entity.Property(e => e.Sec1Moo)
                .HasMaxLength(20)
                .HasColumnName("sec1_moo");
            entity.Property(e => e.Sec1Phone)
                .HasMaxLength(50)
                .HasColumnName("sec1_phone");
            entity.Property(e => e.Sec1Provinceid)
                .HasDefaultValue(0)
                .HasColumnName("sec1_provinceid");
            entity.Property(e => e.Sec1Provincename)
                .HasMaxLength(100)
                .HasColumnName("sec1_provincename");
            entity.Property(e => e.Sec1Soi)
                .HasMaxLength(100)
                .HasColumnName("sec1_soi");
            entity.Property(e => e.Sec1Street)
                .HasMaxLength(100)
                .HasColumnName("sec1_street");
            entity.Property(e => e.Sec1Subdistrictid)
                .HasDefaultValue(0)
                .HasColumnName("sec1_subdistrictid");
            entity.Property(e => e.Sec1Subdistrictname)
                .HasMaxLength(100)
                .HasColumnName("sec1_subdistrictname");
            entity.Property(e => e.Sec1TitleId)
                .HasDefaultValue(0)
                .HasColumnName("sec1_titleId");
            entity.Property(e => e.Sec1TitleText)
                .HasMaxLength(60)
                .HasColumnName("sec1_title_text");
            entity.Property(e => e.Sec1Trok)
                .HasMaxLength(100)
                .HasColumnName("sec1_trok");
            entity.Property(e => e.Sec1TypeDesc)
                .HasMaxLength(50)
                .HasColumnName("sec1_type_desc");
            entity.Property(e => e.Sec1TypeId)
                .HasMaxLength(2)
                .HasColumnName("sec1_type_id");
            entity.Property(e => e.Sec1Zipcode)
                .HasMaxLength(10)
                .HasColumnName("sec1_zipcode");
            entity.Property(e => e.Sec2Description).HasColumnName("sec2_description");
            entity.Property(e => e.Sec2Group1)
                .HasDefaultValue(0)
                .HasColumnName("sec2_group1");
            entity.Property(e => e.Sec2Group2)
                .HasDefaultValue(0)
                .HasColumnName("sec2_group2");
            entity.Property(e => e.Sec2Group3)
                .HasDefaultValue(0)
                .HasColumnName("sec2_group3");
            entity.Property(e => e.Sec2Group4)
                .HasDefaultValue(0)
                .HasColumnName("sec2_group4");
            entity.Property(e => e.Sec2Group5)
                .HasDefaultValue(0)
                .HasColumnName("sec2_group5");
            entity.Property(e => e.Sec2Group6)
                .HasDefaultValue(0)
                .HasColumnName("sec2_group6");
            entity.Property(e => e.Sec2Group7)
                .HasDefaultValue(0)
                .HasColumnName("sec2_group7");
            entity.Property(e => e.Sec3BrandCode)
                .HasMaxLength(10)
                .HasColumnName("sec3_brand_code");
            entity.Property(e => e.Sec3BrandName)
                .HasMaxLength(100)
                .HasColumnName("sec3_brand_name");
            entity.Property(e => e.Sec3Car10w1)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car10w_1");
            entity.Property(e => e.Sec3Car10w2)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car10w_2");
            entity.Property(e => e.Sec3Car4w1)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car4w_1");
            entity.Property(e => e.Sec3Car4w2)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car4w_2");
            entity.Property(e => e.Sec3Car6w1)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car6w_1");
            entity.Property(e => e.Sec3Car6w2)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car6w_2");
            entity.Property(e => e.Sec3CarOther1)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car_other_1");
            entity.Property(e => e.Sec3CarOther2)
                .HasDefaultValue(0)
                .HasColumnName("sec3_car_other_2");
            entity.Property(e => e.Sec3ChassisNo)
                .HasMaxLength(100)
                .HasColumnName("sec3_chassis_no");
            entity.Property(e => e.Sec3EngineNo)
                .HasMaxLength(100)
                .HasColumnName("sec3_engine_no");
            entity.Property(e => e.Sec3LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("sec3_license_no1");
            entity.Property(e => e.Sec3LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("sec3_license_no2");
            entity.Property(e => e.Sec3LicenseProvince)
                .HasMaxLength(10)
                .HasColumnName("sec3_license_province");
            entity.Property(e => e.Sec3LicenseProvinceid)
                .HasDefaultValue(0)
                .HasColumnName("sec3_license_provinceid");
            entity.Property(e => e.Sec3Spec1)
                .HasDefaultValue(0)
                .HasColumnName("sec3_spec1");
            entity.Property(e => e.Sec3Spec2)
                .HasDefaultValue(0)
                .HasColumnName("sec3_spec2");
            entity.Property(e => e.Sec3SubBrandCode)
                .HasMaxLength(10)
                .HasColumnName("sec3_sub_brand_code");
            entity.Property(e => e.Sec3SubBrandName)
                .HasMaxLength(100)
                .HasColumnName("sec3_sub_brand_name");
            entity.Property(e => e.Sec3SubChassisNo)
                .HasMaxLength(100)
                .HasColumnName("sec3_sub_chassis_no");
            entity.Property(e => e.Sec3SubLicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("sec3_sub_license_no1");
            entity.Property(e => e.Sec3SubLicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("sec3_sub_license_no2");
            entity.Property(e => e.Sec3SubLicenseProvince)
                .HasMaxLength(10)
                .HasColumnName("sec3_sub_license_province");
            entity.Property(e => e.Sec3SubLicenseProvinceid)
                .HasDefaultValue(0)
                .HasColumnName("sec3_sub_license_provinceid");
            entity.Property(e => e.Sec4EndDate)
                .HasColumnType("datetime")
                .HasColumnName("sec4_end_date");
            entity.Property(e => e.Sec4EndLocation)
                .HasMaxLength(150)
                .HasColumnName("sec4_end_location");
            entity.Property(e => e.Sec4InCountry)
                .HasDefaultValue(0)
                .HasColumnName("sec4_in_country");
            entity.Property(e => e.Sec4IsOnly)
                .HasDefaultValue(0)
                .HasColumnName("sec4_is_only");
            entity.Property(e => e.Sec4IsTime)
                .HasDefaultValue(0)
                .HasColumnName("sec4_is_time");
            entity.Property(e => e.Sec4OutCountry)
                .HasDefaultValue(0)
                .HasColumnName("sec4_out_country");
            entity.Property(e => e.Sec4OutCountryDesc)
                .HasMaxLength(150)
                .HasColumnName("sec4_out_country_desc");
            entity.Property(e => e.Sec4StartDate)
                .HasColumnType("datetime")
                .HasColumnName("sec4_start_date");
            entity.Property(e => e.Sec4StartLocation)
                .HasMaxLength(150)
                .HasColumnName("sec4_start_location");
            entity.Property(e => e.Sec521suminsure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec5_21suminsure");
            entity.Property(e => e.Sec522suminsure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec5_22suminsure");
            entity.Property(e => e.Sec53suminsure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec5_3suminsure");
            entity.Property(e => e.Sec5Suminsure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec5_suminsure");
            entity.Property(e => e.Sec6Premium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec6_premium");
            entity.Property(e => e.Sec6Stamp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec6_stamp");
            entity.Property(e => e.Sec6Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec6_total");
            entity.Property(e => e.Sec6Vat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("sec6_vat");
            entity.Property(e => e.Sec7Desription)
                .HasMaxLength(150)
                .HasColumnName("sec7_desription");
            entity.Property(e => e.Sec8Desription)
                .HasMaxLength(150)
                .HasColumnName("sec8_desription");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("tran_date");
        });

        modelBuilder.Entity<NonCarrierFile>(entity =>
        {
            entity.HasKey(e => e.RowNumber);

            entity.ToTable("non_carrier_file");

            entity.Property(e => e.RowNumber).HasColumnName("row_number");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Img64File)
                .IsUnicode(false)
                .HasColumnName("img64File");
            entity.Property(e => e.ImgName)
                .HasMaxLength(150)
                .HasColumnName("imgName");
            entity.Property(e => e.ImgType)
                .HasMaxLength(50)
                .HasColumnName("imgType");
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("Tran_id");
        });

        modelBuilder.Entity<NonCarrierTranid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("non_carrier_tranid");

            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
        });

        modelBuilder.Entity<NonPmi>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("non_pmi");

            entity.Property(e => e.TranId)
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.AreaLocationDesc).HasColumnName("Area_Location_desc");
            entity.Property(e => e.AreaTypeAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Area_Type_amount");
            entity.Property(e => e.AreaTypeDesc).HasColumnName("Area_Type_desc");
            entity.Property(e => e.Beneficiary1).HasMaxLength(150);
            entity.Property(e => e.Beneficiary2).HasMaxLength(150);
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.CampaignCode).HasMaxLength(50);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FlagReNew)
                .HasDefaultValue(0)
                .HasColumnName("Flag_ReNew");
            entity.Property(e => e.FurnitureAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Furniture_amount");
            entity.Property(e => e.FurnitureDesc).HasColumnName("Furniture_desc");
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsDebitNote).HasDefaultValue(0);
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.IsTrans).HasDefaultValue(0);
            entity.Property(e => e.MachineAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Machine_amount");
            entity.Property(e => e.MachineDesc).HasColumnName("Machine_desc");
            entity.Property(e => e.NonAgreeDate).HasColumnName("Non_Agree_date");
            entity.Property(e => e.NonComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_Comm");
            entity.Property(e => e.NonCommAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_CommAmt");
            entity.Property(e => e.NonCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_CommTax");
            entity.Property(e => e.NonCommTaxAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_CommTaxAmt");
            entity.Property(e => e.NonCommType)
                .HasMaxLength(10)
                .HasColumnName("Non_CommType");
            entity.Property(e => e.NonEndDate).HasColumnName("Non_End_date");
            entity.Property(e => e.NonPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_Payment");
            entity.Property(e => e.NonPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Non_Policy_No");
            entity.Property(e => e.NonPremium)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_Premium");
            entity.Property(e => e.NonSignNo)
                .HasMaxLength(20)
                .HasColumnName("Non_Sign_No");
            entity.Property(e => e.NonStamp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_Stamp");
            entity.Property(e => e.NonStartDate).HasColumnName("Non_Start_date");
            entity.Property(e => e.NonSumInsurance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_SumInsurance");
            entity.Property(e => e.NonTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_Total");
            entity.Property(e => e.NonVat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Non_Vat");
            entity.Property(e => e.OldPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Old_Policy_no");
            entity.Property(e => e.PayerBlock)
                .HasMaxLength(100)
                .HasColumnName("Payer_block");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerOccupation)
                .HasMaxLength(100)
                .HasColumnName("Payer_Occupation");
            entity.Property(e => e.PayerOccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Occupation_code");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSex)
                .HasMaxLength(5)
                .HasColumnName("Payer_Sex");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.ProductTypeCode).HasMaxLength(20);
            entity.Property(e => e.ProductTypeDesc).HasMaxLength(250);
            entity.Property(e => e.ResponsNumber).HasMaxLength(50);
            entity.Property(e => e.StockAmount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Stock_amount");
            entity.Property(e => e.StockDesc).HasColumnName("Stock_desc");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
        });

        modelBuilder.Entity<NonTranid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("non_tranid");

            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
        });

        modelBuilder.Entity<OldDistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("old_district");

            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DistrictName).HasMaxLength(150);
            entity.Property(e => e.OldDistrictCode).HasColumnName("old_DistrictCode");
            entity.Property(e => e.OldProvinceCode).HasColumnName("old_ProvinceCode");
        });

        modelBuilder.Entity<OldProvince>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("old_province");

            entity.Property(e => e.CreaDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.OldProvinceCode).HasColumnName("old_ProvinceCode");
            entity.Property(e => e.ProvinceDesc).HasMaxLength(5);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
        });

        modelBuilder.Entity<OldSubdistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("old_subdistrict");

            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.OldDistrictCode).HasColumnName("old_DistrictCode");
            entity.Property(e => e.OldProvinceCode).HasColumnName("old_ProvinceCode");
            entity.Property(e => e.OldSubDistrictCode).HasColumnName("old_SubDistrictCode");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<PmiCancel>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("pmi_cancel");

            entity.Property(e => e.TranId).HasMaxLength(30);
            entity.Property(e => e.AgentCode).HasMaxLength(20);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InsCode).HasMaxLength(10);
            entity.Property(e => e.PolicyNo).HasMaxLength(30);
            entity.Property(e => e.SignNo).HasMaxLength(30);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PmiPmi>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("pmi_pmi");

            entity.Property(e => e.TranId)
                .HasMaxLength(100)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.Beneficiary).HasMaxLength(150);
            entity.Property(e => e.BodyTypeId).HasMaxLength(10);
            entity.Property(e => e.BodyTypeName).HasMaxLength(50);
            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_Code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_Name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.CampaignCode).HasMaxLength(50);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CarAccessories).HasMaxLength(200);
            entity.Property(e => e.CarTypeCode).HasMaxLength(10);
            entity.Property(e => e.Cc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DriverInsurance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.FlagCctv)
                .HasMaxLength(10)
                .HasColumnName("FlagCCTV");
            entity.Property(e => e.FlagReNew)
                .HasDefaultValue(0)
                .HasColumnName("Flag_ReNew");
            entity.Property(e => e.GarageTypeDesc)
                .HasMaxLength(100)
                .HasDefaultValue("อู่ประกัน");
            entity.Property(e => e.ImgUrlCarCopy).HasMaxLength(150);
            entity.Property(e => e.ImgUrlForm).HasMaxLength(150);
            entity.Property(e => e.ImgUrlPersonalCard).HasMaxLength(150);
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsDebitNote).HasDefaultValue(0);
            entity.Property(e => e.IsPayerDriver1)
                .HasDefaultValue(0)
                .HasColumnName("IsPayer_Driver1");
            entity.Property(e => e.IsPayerDriver2)
                .HasDefaultValue(0)
                .HasColumnName("IsPayer_Driver2");
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.IsTrans).HasDefaultValue(0);
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.LossDistPerDriver1Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerNo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalNo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerFireAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPaperDriver1Amt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerDriver1Amt");
            entity.Property(e => e.LossPaperPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerAmt");
            entity.Property(e => e.LossPaperPassengerNo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerNo");
            entity.Property(e => e.LossPerAssetAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerSonAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_Code");
            entity.Property(e => e.ModelColorId)
                .HasMaxLength(10)
                .HasColumnName("Model_ColorID");
            entity.Property(e => e.ModelColorName)
                .HasMaxLength(50)
                .HasColumnName("Model_ColorName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_Name");
            entity.Property(e => e.ModelYear)
                .HasMaxLength(5)
                .HasColumnName("Model_Year");
            entity.Property(e => e.NoOfSeat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.OldPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Old_Policy_no");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerDriver1BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Payer_Driver1_BirthDate");
            entity.Property(e => e.PayerDriver1CardId)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_CardID");
            entity.Property(e => e.PayerDriver1FirstName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_FirstName");
            entity.Property(e => e.PayerDriver1LastName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_LastName");
            entity.Property(e => e.PayerDriver1Occupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Driver1_Occupation");
            entity.Property(e => e.PayerDriver1OccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Driver1_Occupation_code");
            entity.Property(e => e.PayerDriver1TitleId).HasColumnName("Payer_Driver1_TitleId");
            entity.Property(e => e.PayerDriver1TitleText)
                .HasMaxLength(30)
                .HasColumnName("Payer_Driver1_Title_text");
            entity.Property(e => e.PayerDriver2BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Payer_Driver2_BirthDate");
            entity.Property(e => e.PayerDriver2CardId)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_CardID");
            entity.Property(e => e.PayerDriver2FirstName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_FirstName");
            entity.Property(e => e.PayerDriver2LastName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_LastName");
            entity.Property(e => e.PayerDriver2Occupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Driver2_Occupation");
            entity.Property(e => e.PayerDriver2OccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Driver2_Occupation_code");
            entity.Property(e => e.PayerDriver2TitleId).HasColumnName("Payer_Driver2_TitleId");
            entity.Property(e => e.PayerDriver2TitleText)
                .HasMaxLength(30)
                .HasColumnName("Payer_Driver2_Title_text");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerOccupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Occupation");
            entity.Property(e => e.PayerOccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Occupation_code");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSex)
                .HasMaxLength(5)
                .HasColumnName("Payer_Sex");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.PmiAgreeDate).HasColumnName("Pmi_Agree_date");
            entity.Property(e => e.PmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Comm");
            entity.Property(e => e.PmiCommAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_CommAmt");
            entity.Property(e => e.PmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_CommTax");
            entity.Property(e => e.PmiCommTaxAmt)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Pmi_CommTaxAmt");
            entity.Property(e => e.PmiCommType)
                .HasMaxLength(10)
                .HasColumnName("Pmi_CommType");
            entity.Property(e => e.PmiEndDate).HasColumnName("Pmi_End_date");
            entity.Property(e => e.PmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Pmi_MotCode");
            entity.Property(e => e.PmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Payment");
            entity.Property(e => e.PmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Pmi_Policy_No");
            entity.Property(e => e.PmiPremium)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Premium");
            entity.Property(e => e.PmiStamp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Stamp");
            entity.Property(e => e.PmiStartDate).HasColumnName("Pmi_Start_date");
            entity.Property(e => e.PmiTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Total");
            entity.Property(e => e.PmiVat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Vat");
            entity.Property(e => e.ProductTypeCode).HasMaxLength(10);
            entity.Property(e => e.ProductTypeDesc).HasMaxLength(150);
            entity.Property(e => e.ResponsNumber).HasMaxLength(50);
            entity.Property(e => e.SubModelCode)
                .HasMaxLength(50)
                .HasColumnName("SubModel_Code");
            entity.Property(e => e.SubModelName)
                .HasMaxLength(150)
                .HasColumnName("SubModel_Name");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<PmiPmiFileupload>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.TranId });

            entity.ToTable("pmi_pmi_fileupload");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.FileName)
                .HasMaxLength(150)
                .HasColumnName("fileName");
            entity.Property(e => e.FilePath)
                .HasMaxLength(250)
                .HasColumnName("filePath");
            entity.Property(e => e.FileType)
                .HasMaxLength(150)
                .HasColumnName("fileType");
        });

        modelBuilder.Entity<PmiPmiImage>(entity =>
        {
            entity.ToTable("pmi_pmi_image");

            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("Tran_Id");
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<PmiSmsLog>(entity =>
        {
            entity.HasKey(e => e.No);

            entity.ToTable("pmi_sms_log");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.LicenseNo).HasMaxLength(50);
            entity.Property(e => e.Msisdn)
                .HasMaxLength(50)
                .HasColumnName("MSISDN");
            entity.Property(e => e.SmslogDesc).HasColumnName("SMSLogDesc");
            entity.Property(e => e.UseCredit).HasDefaultValue(0);
        });

        modelBuilder.Entity<PmiTranid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pmi_tranid");

            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
        });

        modelBuilder.Entity<SagiCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("sagi_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.BrandSagi)
                .HasMaxLength(10)
                .HasColumnName("Brand_sagi");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(20);
        });

        modelBuilder.Entity<SagiCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("sagi_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdSagi)
                .HasMaxLength(10)
                .HasColumnName("ModelId_sagi");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<SagiDistrict>(entity =>
        {
            entity.HasKey(e => new { e.DistrictCode, e.ProvinceCode });

            entity.ToTable("sagi_district");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictCodeSagi).HasColumnName("DistrictCode_Sagi");
            entity.Property(e => e.DistrictName).HasMaxLength(150);
            entity.Property(e => e.ProvinceCodeSagi).HasColumnName("ProvinceCode_Sagi");
        });

        modelBuilder.Entity<SagiMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("sagi_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.BodyTypeId)
                .HasDefaultValue(0)
                .HasColumnName("Body_Type_Id");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SagiMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("sagi_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.BodyTypeId)
                .HasDefaultValue(0)
                .HasColumnName("Body_Type_Id");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<SagiNationality>(entity =>
        {
            entity.HasKey(e => e.NationalityCode);

            entity.ToTable("sagi_nationality");

            entity.Property(e => e.NationalityCode).HasMaxLength(5);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NationalityName).HasMaxLength(150);
        });

        modelBuilder.Entity<SagiProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceCode);

            entity.ToTable("sagi_province");

            entity.Property(e => e.ProvinceCode).ValueGeneratedNever();
            entity.Property(e => e.CreaDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.ProvinceCodeSagi).HasColumnName("ProvinceCode_Sagi");
            entity.Property(e => e.ProvinceDesc).HasMaxLength(5);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(5);
        });

        modelBuilder.Entity<SagiSubdistrict>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode });

            entity.ToTable("sagi_subdistrict");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictCodeSagi).HasColumnName("DistrictCode_sagi");
            entity.Property(e => e.ProvinceCodeSagi).HasColumnName("ProvinceCode_sagi");
            entity.Property(e => e.SubDistrictCodeSagi).HasColumnName("SubDistrictCode_sagi");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<SagiSubdistrictBkk>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode });

            entity.ToTable("sagi_subdistrict_bkk");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictCodeSagi).HasColumnName("DistrictCode_sagi");
            entity.Property(e => e.ProvinceCodeSagi).HasColumnName("ProvinceCode_sagi");
            entity.Property(e => e.SubDistrictCodeSagi).HasColumnName("SubDistrictCode_sagi");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<SagiSubdistrictTemp>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode });

            entity.ToTable("sagi_subdistrict_temp");

            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
        });

        modelBuilder.Entity<SagiTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("sagi_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdSagi)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Sagi");
        });

        modelBuilder.Entity<SagiTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("sagi_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdSagi)
                .HasMaxLength(10)
                .HasColumnName("TitleID_sagi");
        });

        modelBuilder.Entity<StyMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("sty_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<StyMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("sty_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<StyMotorcodeOth1>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("sty_motorcode_oth1");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<StyPolicy>(entity =>
        {
            entity.HasKey(e => new { e.PolicyNo, e.StickerNo });

            entity.ToTable("sty_policy");

            entity.Property(e => e.PolicyNo).HasMaxLength(30);
            entity.Property(e => e.StickerNo).HasMaxLength(30);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.No).ValueGeneratedOnAdd();
            entity.Property(e => e.UsingBy).HasMaxLength(50);
            entity.Property(e => e.UsingDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbAgent>(entity =>
        {
            entity.HasKey(e => e.AgentCode);

            entity.ToTable("tb_agent");

            entity.Property(e => e.AgentCode).HasMaxLength(15);
            entity.Property(e => e.AgentTypeCode).HasMaxLength(5);
            entity.Property(e => e.AgentTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Agent_Type_Desc");
            entity.Property(e => e.AgentTypeId)
                .HasMaxLength(2)
                .HasColumnName("Agent_Type_ID");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(150);
            entity.Property(e => e.IdcartNumber)
                .HasMaxLength(20)
                .HasColumnName("IDCartNumber");
            entity.Property(e => e.IsEnable).HasDefaultValue(0);
            entity.Property(e => e.LastName).HasMaxLength(150);
            entity.Property(e => e.LicenseNo).HasMaxLength(50);
            entity.Property(e => e.Mobile).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.SubDistrictName).HasMaxLength(100);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.ZipCode).HasMaxLength(5);
        });

        modelBuilder.Entity<TbAgentTemp>(entity =>
        {
            entity.HasKey(e => e.AgentCode);

            entity.ToTable("tb_agent_temp");

            entity.Property(e => e.AgentCode).HasMaxLength(15);
            entity.Property(e => e.AgentTypeCode).HasMaxLength(5);
            entity.Property(e => e.AgentTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Agent_Type_Desc");
            entity.Property(e => e.AgentTypeId)
                .HasMaxLength(2)
                .HasColumnName("Agent_Type_ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(150);
            entity.Property(e => e.IdcartNumber)
                .HasMaxLength(20)
                .HasColumnName("IDCartNumber");
            entity.Property(e => e.LastName).HasMaxLength(150);
            entity.Property(e => e.Mobile).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.SubDistrictName).HasMaxLength(100);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.ZipCode).HasMaxLength(5);
        });

        modelBuilder.Entity<TbAgenttype>(entity =>
        {
            entity.HasKey(e => e.AgentTypeCode);

            entity.ToTable("tb_agenttype");

            entity.Property(e => e.AgentTypeCode).HasMaxLength(5);
            entity.Property(e => e.AgentTypeName).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbBankaccount>(entity =>
        {
            entity.HasKey(e => new { e.BankCode, e.AccountNo });

            entity.ToTable("tb_bankaccount");

            entity.Property(e => e.BankCode).HasMaxLength(10);
            entity.Property(e => e.AccountNo).HasMaxLength(15);
            entity.Property(e => e.AccountBranch).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(150);
            entity.Property(e => e.AccountType).HasMaxLength(150);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("systen");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbBankaccountInsure>(entity =>
        {
            entity.HasKey(e => new { e.BankCode, e.AccountNo });

            entity.ToTable("tb_bankaccount_insure");

            entity.Property(e => e.BankCode).HasMaxLength(10);
            entity.Property(e => e.AccountNo).HasMaxLength(15);
            entity.Property(e => e.AccountBranch).HasMaxLength(50);
            entity.Property(e => e.AccountName).HasMaxLength(150);
            entity.Property(e => e.AccountType).HasMaxLength(150);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("systen");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCarbodytype>(entity =>
        {
            entity.HasKey(e => e.BodyTypeId);

            entity.ToTable("tb_carbodytype");

            entity.Property(e => e.BodyTypeId).HasMaxLength(50);
            entity.Property(e => e.BodyTypeName).HasMaxLength(150);
            entity.Property(e => e.MotorCode).HasMaxLength(10);
        });

        modelBuilder.Entity<TbCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("tb_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<TbCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("tb_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("tb_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<TbCommission>(entity =>
        {
            entity.HasKey(e => new { e.InsureCode, e.AgentCode, e.CommTypeCode });

            entity.ToTable("tb_commission");

            entity.Property(e => e.InsureCode).HasMaxLength(5);
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.CommTypeCode).HasMaxLength(5);
            entity.Property(e => e.CommissionNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MotorCode).HasMaxLength(20);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<TbCommissionTemp>(entity =>
        {
            entity.HasKey(e => new { e.InsureCode, e.AgentCode, e.CommTypeCode });

            entity.ToTable("tb_commission_temp");

            entity.Property(e => e.InsureCode).HasMaxLength(5);
            entity.Property(e => e.AgentCode).HasMaxLength(15);
            entity.Property(e => e.CommTypeCode).HasMaxLength(5);
            entity.Property(e => e.CommissionNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<TbCommissiontype>(entity =>
        {
            entity.HasKey(e => e.CommTypeCode);

            entity.ToTable("tb_commissiontype");

            entity.Property(e => e.CommTypeCode).HasMaxLength(5);
            entity.Property(e => e.ComTypeName).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCountry>(entity =>
        {
            entity.HasKey(e => e.CountryCode);

            entity.ToTable("tb_country");

            entity.Property(e => e.CountryCode).HasMaxLength(5);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("Description_EN");
            entity.Property(e => e.DescriptionTh)
                .HasMaxLength(150)
                .HasColumnName("Description_TH");
        });

        modelBuilder.Entity<TbCredit>(entity =>
        {
            entity.HasKey(e => e.AgentCode);

            entity.ToTable("tb_credit");

            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditBalances).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditUsesage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCreditTemp>(entity =>
        {
            entity.HasKey(e => e.AgentCode);

            entity.ToTable("tb_credit_temp");

            entity.Property(e => e.AgentCode).HasMaxLength(10);
            entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditBalances).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditUsesage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbCreditteamLog>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tb_creditteam_log");

            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.BalanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SupAgentCode).HasMaxLength(50);
            entity.Property(e => e.SupBalanceAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SupCreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SupUsageAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UsageAmount).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbCredittransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_credittransaction");

            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("systen");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditBalance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditUsage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TranId)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.UseFor).HasMaxLength(150);
        });

        modelBuilder.Entity<TbCustomertype>(entity =>
        {
            entity.HasKey(e => e.CustTypeCode);

            entity.ToTable("tb_customertype");

            entity.Property(e => e.CustTypeCode).HasMaxLength(10);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbDaliveryTracking>(entity =>
        {
            entity.HasKey(e => new { e.TranId, e.Department });

            entity.ToTable("tb_dalivery_tracking");

            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("Tran_Id");
            entity.Property(e => e.Department)
                .HasMaxLength(50)
                .HasColumnName("department");
            entity.Property(e => e.Createby)
                .HasMaxLength(50)
                .HasColumnName("createby");
            entity.Property(e => e.Createdate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.DeliveryCode)
                .HasMaxLength(50)
                .HasColumnName("delivery_code");
            entity.Property(e => e.TrackingDate)
                .HasColumnType("datetime")
                .HasColumnName("tracking_date");
            entity.Property(e => e.TrackingNumber)
                .HasMaxLength(50)
                .HasColumnName("tracking_number");
        });

        modelBuilder.Entity<TbDeliverySource>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("tb_delivery_source");

            entity.Property(e => e.Code).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(150);
            entity.Property(e => e.TrackingLink)
                .HasMaxLength(150)
                .HasColumnName("Tracking_Link");
        });

        modelBuilder.Entity<TbDiscounttype>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("tb_discounttype");

            entity.Property(e => e.TypeId).HasMaxLength(10);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbDistrict>(entity =>
        {
            entity.HasKey(e => new { e.DistrictCode, e.ProvinceCode }).HasName("PK_tb_District");

            entity.ToTable("tb_district");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DistrictName).HasMaxLength(150);
        });

        modelBuilder.Entity<TbEndorse>(entity =>
        {
            entity.HasKey(e => e.TranId).HasName("PK_tb_cmi_endorse");

            entity.ToTable("tb_endorse");

            entity.Property(e => e.ComfirmBy).HasMaxLength(50);
            entity.Property(e => e.ConfirmDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.LicenseNo).HasMaxLength(50);
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeDesc).HasMaxLength(100);
        });

        modelBuilder.Entity<TbInsurance>(entity =>
        {
            entity.HasKey(e => e.InsureCode).HasName("PK_cmi_Insure2");

            entity.ToTable("tb_insurance");

            entity.Property(e => e.InsureCode).HasMaxLength(5);
            entity.Property(e => e.BranceName).HasMaxLength(100);
            entity.Property(e => e.ContactName).HasMaxLength(100);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InsureEmail).HasMaxLength(150);
            entity.Property(e => e.InsureFax).HasMaxLength(50);
            entity.Property(e => e.InsurePhone).HasMaxLength(150);
            entity.Property(e => e.InsureWebsite).HasMaxLength(50);
            entity.Property(e => e.IsCarrier).HasDefaultValue(0);
            entity.Property(e => e.IsCmi).HasColumnName("IsCMI");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.IsSeviceCancel).HasDefaultValue(0);
            entity.Property(e => e.IsVmi).HasColumnName("IsVMI");
            entity.Property(e => e.Orderbycase)
                .HasMaxLength(5)
                .HasColumnName("orderbycase");
            entity.Property(e => e.TaxId)
                .HasMaxLength(50)
                .HasColumnName("TaxID");
        });

        modelBuilder.Entity<TbInsuranceCommission>(entity =>
        {
            entity.HasKey(e => new { e.InsureCode, e.CommTypeCode });

            entity.ToTable("tb_insurance_commission");

            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.CommTypeCode).HasMaxLength(5);
            entity.Property(e => e.CommissionNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DueDate).HasDefaultValue(0);
            entity.Property(e => e.Ov)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OV");
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<TbInvoiceDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.UserId, e.ProductNo });

            entity.ToTable("tb_invoice_dt");

            entity.Property(e => e.DocNo).HasMaxLength(20);
            entity.Property(e => e.UserId).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbInvoiceHd>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.UserId });

            entity.ToTable("tb_invoice_hd");

            entity.Property(e => e.DocNo).HasMaxLength(20);
            entity.Property(e => e.UserId).HasMaxLength(20);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustAddress).HasColumnName("Cust_Address");
            entity.Property(e => e.CustCardId)
                .HasMaxLength(20)
                .HasColumnName("Cust_CardId");
            entity.Property(e => e.CustFirstname)
                .HasMaxLength(150)
                .HasColumnName("Cust_Firstname");
            entity.Property(e => e.CustLastname)
                .HasMaxLength(150)
                .HasColumnName("Cust_Lastname");
            entity.Property(e => e.CustTitleId).HasColumnName("Cust_TitleId");
            entity.Property(e => e.CustTitleText)
                .HasMaxLength(100)
                .HasColumnName("Cust_Title_text");
            entity.Property(e => e.CustType)
                .HasMaxLength(10)
                .HasColumnName("Cust_Type");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Amt");
            entity.Property(e => e.DiscountType).HasMaxLength(10);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocType).HasMaxLength(10);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.PayTypeDesc).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(100);
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.ProvinceName).HasMaxLength(100);
            entity.Property(e => e.SubDistrictId).HasColumnName("SubDistrictID");
            entity.Property(e => e.SubDistrictName).HasMaxLength(100);
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VatAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vat_Amt");
            entity.Property(e => e.VatType).HasMaxLength(10);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<TbLogCmi>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("tb_log_cmi");

            entity.Property(e => e.LogId).HasColumnName("Log_Id");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(150)
                .HasColumnName("License_no");
            entity.Property(e => e.LogType)
                .HasMaxLength(50)
                .HasColumnName("Log_type");
        });

        modelBuilder.Entity<TbLogVmi>(entity =>
        {
            entity.HasKey(e => e.LogId);

            entity.ToTable("tb_log_vmi");

            entity.Property(e => e.LogId).HasColumnName("Log_Id");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(150)
                .HasColumnName("License_no");
            entity.Property(e => e.LogType)
                .HasMaxLength(50)
                .HasColumnName("Log_type");
        });

        modelBuilder.Entity<TbMessage>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tb_message");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(20)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.IsRead).HasDefaultValue(0);
            entity.Property(e => e.MessageTitle)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.ToAgent).HasMaxLength(50);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbMotorDebitDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.TranId }).HasName("PK_tb_motor_debit_dt_1");

            entity.ToTable("tb_motor_debit_dt");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.CommAmt).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CommTax).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CommTaxAmt).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CommType).HasMaxLength(10);
            entity.Property(e => e.CommValue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.InsureCode).HasMaxLength(20);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Stamp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorDebitHd>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("tb_motor_debit_hd");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.AgentName).HasMaxLength(200);
            entity.Property(e => e.CommAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("systen");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayTypeDesc).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(200);
            entity.Property(e => e.Stamp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TeamAgentCode).HasMaxLength(50);
            entity.Property(e => e.TeamAmount).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorDebitPay>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tb_motor_debit_pay");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranch).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BankTranDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocnoRef).HasMaxLength(30);
            entity.Property(e => e.Img64File).HasColumnName("img64File");
            entity.Property(e => e.ImgName)
                .HasMaxLength(50)
                .HasColumnName("imgName");
            entity.Property(e => e.ImgType)
                .HasMaxLength(50)
                .HasColumnName("imgType");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentTypeDesc).HasMaxLength(150);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbMotorPayinsureDt>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("tb_motor_payinsure_dt");

            entity.Property(e => e.RowId).HasColumnName("rowId");
            entity.Property(e => e.AmtPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommBath).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommTaxBath).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommTaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustName).HasMaxLength(150);
            entity.Property(e => e.DocNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PolicyNo).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorPayinsureHd>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("tb_motor_payinsure_hd");

            entity.Property(e => e.DocNo).HasMaxLength(20);
            entity.Property(e => e.AmtPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommBath).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommTaxBath).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommTaxPercent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.IsCmi).HasColumnName("isCmi");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PolicyDateEnd).HasColumnType("datetime");
            entity.Property(e => e.PolicyDateStart).HasColumnType("datetime");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorProduct>(entity =>
        {
            entity.HasKey(e => e.ProductNo);

            entity.ToTable("tb_motor_product");

            entity.Property(e => e.AddedHistoryPrem)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DiscountDeducAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountGroupAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountHistoryAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountOtherAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocAttachmentPrem)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DriverInsurance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Duty)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.GarageTypeCd)
                .HasMaxLength(50)
                .HasDefaultValue("อู่ประกัน");
            entity.Property(e => e.InsureCode).HasMaxLength(5);
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.LossDistPerDriver1Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerFireAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPaperDriver1Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerDriver1Amt");
            entity.Property(e => e.LossPaperPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerAmt");
            entity.Property(e => e.LossPaperPassengerNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerNo");
            entity.Property(e => e.LossPerAssetAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerSonAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MotCode).HasMaxLength(10);
            entity.Property(e => e.NetPrem)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.OrderByList)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.PrimaryCoverPrem)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductCode).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Sum13Prem)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Sum_1_3_Prem");
            entity.Property(e => e.Tax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorProducttype>(entity =>
        {
            entity.HasKey(e => e.ProductTypeCode);

            entity.ToTable("tb_motor_producttype");

            entity.Property(e => e.ProductTypeCode).ValueGeneratedNever();
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ProductTypeName).HasMaxLength(200);
            entity.Property(e => e.UseFor).HasMaxLength(50);
        });

        modelBuilder.Entity<TbMotorQoutationDt>(entity =>
        {
            entity.HasKey(e => new { e.RowId, e.TranId }).HasName("PK_tb_motor_quotation_dt");

            entity.ToTable("tb_motor_qoutation_dt");

            entity.Property(e => e.RowId).HasColumnName("Row_ID");
            entity.Property(e => e.TranId)
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.DiscountAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Amt");
            entity.Property(e => e.DiscountType)
                .HasMaxLength(10)
                .HasColumnName("Discount_type");
            entity.Property(e => e.DiscountValue)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_value");
            entity.Property(e => e.DriverInsurance).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DriverTypeCd).HasDefaultValue(0);
            entity.Property(e => e.GarageTypeCd).HasDefaultValue(0);
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.LossDistPerDriver1Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerNo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalNo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerDedugAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerFireAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerTimeAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPaperDriver1Amt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerDriver1Amt");
            entity.Property(e => e.LossPaperPassengerAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerAmt");
            entity.Property(e => e.LossPaperPassengerNo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerNo");
            entity.Property(e => e.LossPerAssetAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerDedugAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerSonAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerTimeAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Premium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Stamp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SumPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Sum_Premium");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorQoutationHd>(entity =>
        {
            entity.HasKey(e => e.TranId).HasName("PK_tb_motor_quotation_hd");

            entity.ToTable("tb_motor_qoutation_hd");

            entity.Property(e => e.TranId)
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AdditionalDesc).HasColumnName("Additional_Desc");
            entity.Property(e => e.ApproveBy).HasMaxLength(50);
            entity.Property(e => e.ApproveDate).HasColumnType("datetime");
            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_Code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_Name");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_Code");
            entity.Property(e => e.ModelColorId)
                .HasMaxLength(10)
                .HasColumnName("Model_ColorID");
            entity.Property(e => e.ModelColorName)
                .HasMaxLength(50)
                .HasColumnName("Model_ColorName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_Name");
            entity.Property(e => e.ModelYear)
                .HasMaxLength(5)
                .HasColumnName("Model_Year");
            entity.Property(e => e.MotCode).HasMaxLength(50);
            entity.Property(e => e.NoOfSeat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerOccupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Occupation");
            entity.Property(e => e.PayerOccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Occupation_code");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSex)
                .HasMaxLength(5)
                .HasColumnName("Payer_Sex");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.SubModelCode)
                .HasMaxLength(50)
                .HasColumnName("SubModel_Code");
            entity.Property(e => e.SubModelName)
                .HasMaxLength(150)
                .HasColumnName("SubModel_Name");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorReceiptDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.TranId });

            entity.ToTable("tb_motor_receipt_dt");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.CommAmt).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CommTax).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CommTaxAmt).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CommType).HasMaxLength(10);
            entity.Property(e => e.CommValue).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.InsureCode).HasMaxLength(20);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Stamp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorReceiptHd>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("tb_motor_receipt_hd");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.AgentName).HasMaxLength(200);
            entity.Property(e => e.CommAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayTypeDesc).HasMaxLength(50);
            entity.Property(e => e.Remark).HasMaxLength(200);
            entity.Property(e => e.Stamp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TeamAgentCode).HasMaxLength(50);
            entity.Property(e => e.TeamAmount).HasColumnType("numeric(18, 4)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateBy).HasMaxLength(50);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorReceiptPay>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tb_motor_receipt_pay");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranch).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BankTranDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocnoRef).HasMaxLength(30);
            entity.Property(e => e.Img64File).HasColumnName("img64File");
            entity.Property(e => e.ImgName)
                .HasMaxLength(50)
                .HasColumnName("imgName");
            entity.Property(e => e.ImgType)
                .HasMaxLength(50)
                .HasColumnName("imgType");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentTypeDesc).HasMaxLength(150);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbMotorRequest>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tb_motor_request");

            entity.Property(e => e.TranId)
                .HasMaxLength(100)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.Beneficiary).HasMaxLength(150);
            entity.Property(e => e.BodyTypeId).HasMaxLength(10);
            entity.Property(e => e.BodyTypeName).HasMaxLength(50);
            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_Code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_Name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.CampaignCode).HasMaxLength(50);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CarAccessories).HasMaxLength(200);
            entity.Property(e => e.CarTypeCode).HasMaxLength(10);
            entity.Property(e => e.Cc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DriverInsurance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.FlagCctv)
                .HasMaxLength(10)
                .HasColumnName("FlagCCTV");
            entity.Property(e => e.FlagReNew)
                .HasDefaultValue(0)
                .HasColumnName("Flag_ReNew");
            entity.Property(e => e.GarageTypeDesc)
                .HasMaxLength(100)
                .HasDefaultValue("อู่ประกัน");
            entity.Property(e => e.ImgUrlCarCopy).HasMaxLength(150);
            entity.Property(e => e.ImgUrlForm).HasMaxLength(150);
            entity.Property(e => e.ImgUrlPersonalCard).HasMaxLength(150);
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsDebitNote).HasDefaultValue(0);
            entity.Property(e => e.IsPayerDriver1)
                .HasDefaultValue(0)
                .HasColumnName("IsPayer_Driver1");
            entity.Property(e => e.IsPayerDriver2)
                .HasDefaultValue(0)
                .HasColumnName("IsPayer_Driver2");
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.IsTrans).HasDefaultValue(0);
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.LossDistPerDriver1Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerFireAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPaperDriver1Amt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerDriver1Amt");
            entity.Property(e => e.LossPaperPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerAmt");
            entity.Property(e => e.LossPaperPassengerNo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerNo");
            entity.Property(e => e.LossPerAssetAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerSonAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_Code");
            entity.Property(e => e.ModelColorId)
                .HasMaxLength(10)
                .HasColumnName("Model_ColorID");
            entity.Property(e => e.ModelColorName)
                .HasMaxLength(50)
                .HasColumnName("Model_ColorName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_Name");
            entity.Property(e => e.ModelYear)
                .HasMaxLength(5)
                .HasColumnName("Model_Year");
            entity.Property(e => e.NoOfSeat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.OldPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Old_Policy_no");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerDriver1BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Payer_Driver1_BirthDate");
            entity.Property(e => e.PayerDriver1CardId)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_CardID");
            entity.Property(e => e.PayerDriver1FirstName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_FirstName");
            entity.Property(e => e.PayerDriver1LastName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_LastName");
            entity.Property(e => e.PayerDriver1Occupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Driver1_Occupation");
            entity.Property(e => e.PayerDriver1OccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Driver1_Occupation_code");
            entity.Property(e => e.PayerDriver1TitleId).HasColumnName("Payer_Driver1_TitleId");
            entity.Property(e => e.PayerDriver1TitleText)
                .HasMaxLength(30)
                .HasColumnName("Payer_Driver1_Title_text");
            entity.Property(e => e.PayerDriver2BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Payer_Driver2_BirthDate");
            entity.Property(e => e.PayerDriver2CardId)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_CardID");
            entity.Property(e => e.PayerDriver2FirstName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_FirstName");
            entity.Property(e => e.PayerDriver2LastName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_LastName");
            entity.Property(e => e.PayerDriver2Occupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Driver2_Occupation");
            entity.Property(e => e.PayerDriver2OccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Driver2_Occupation_code");
            entity.Property(e => e.PayerDriver2TitleId).HasColumnName("Payer_Driver2_TitleId");
            entity.Property(e => e.PayerDriver2TitleText)
                .HasMaxLength(30)
                .HasColumnName("Payer_Driver2_Title_text");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerOccupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Occupation");
            entity.Property(e => e.PayerOccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Occupation_code");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSex)
                .HasMaxLength(5)
                .HasColumnName("Payer_Sex");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.PmiAgreeDate).HasColumnName("Pmi_Agree_date");
            entity.Property(e => e.PmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Comm");
            entity.Property(e => e.PmiCommAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_CommAmt");
            entity.Property(e => e.PmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_CommTax");
            entity.Property(e => e.PmiCommTaxAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_CommTaxAmt");
            entity.Property(e => e.PmiCommType)
                .HasMaxLength(10)
                .HasColumnName("Pmi_CommType");
            entity.Property(e => e.PmiEndDate).HasColumnName("Pmi_End_date");
            entity.Property(e => e.PmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Pmi_MotCode");
            entity.Property(e => e.PmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Payment");
            entity.Property(e => e.PmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Pmi_Policy_No");
            entity.Property(e => e.PmiPremium)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Premium");
            entity.Property(e => e.PmiStamp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Stamp");
            entity.Property(e => e.PmiStartDate).HasColumnName("Pmi_Start_date");
            entity.Property(e => e.PmiTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Total");
            entity.Property(e => e.PmiVat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Vat");
            entity.Property(e => e.ProductTypeCode).HasMaxLength(10);
            entity.Property(e => e.ProductTypeDesc).HasMaxLength(150);
            entity.Property(e => e.ResponsNumber).HasMaxLength(50);
            entity.Property(e => e.SubModelCode)
                .HasMaxLength(50)
                .HasColumnName("SubModel_Code");
            entity.Property(e => e.SubModelName)
                .HasMaxLength(150)
                .HasColumnName("SubModel_Name");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorRequestCmi>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tb_motor_request_cmi");

            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.Cc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CmiAgreeDate).HasColumnName("Cmi_Agree_date");
            entity.Property(e => e.CmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Comm");
            entity.Property(e => e.CmiCommAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_CommAmt");
            entity.Property(e => e.CmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_CommTax");
            entity.Property(e => e.CmiCommTaxAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_CommTaxAmt");
            entity.Property(e => e.CmiCommType)
                .HasMaxLength(10)
                .HasColumnName("Cmi_CommType");
            entity.Property(e => e.CmiDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Discount");
            entity.Property(e => e.CmiEndDate).HasColumnName("Cmi_End_date");
            entity.Property(e => e.CmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Cmi_MotCode");
            entity.Property(e => e.CmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Payment");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(30)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPremium)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiSignNo)
                .HasMaxLength(100)
                .HasColumnName("Cmi_Sign_no");
            entity.Property(e => e.CmiStamp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Stamp");
            entity.Property(e => e.CmiStartDate).HasColumnName("Cmi_Start_date");
            entity.Property(e => e.CmiTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CmiVat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Vat");
            entity.Property(e => e.ColorCode)
                .HasMaxLength(10)
                .HasColumnName("Color_code");
            entity.Property(e => e.ColorName)
                .HasMaxLength(50)
                .HasColumnName("Color_name");
            entity.Property(e => e.CountryCode).HasMaxLength(10);
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsPayment).HasDefaultValue(0);
            entity.Property(e => e.IsTrans).HasDefaultValue(0);
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_code");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_name");
            entity.Property(e => e.NoOfSeat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.Tax1Percent).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranReq)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("TRAN_Req");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("tb_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbMotorcodeVmi>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("tb_motorcode_vmi");

            entity.Property(e => e.MotCode).HasMaxLength(10);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
        });

        modelBuilder.Entity<TbNewEvent>(entity =>
        {
            entity.ToTable("tb_new_event");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsUsage).HasDefaultValue(0);
            entity.Property(e => e.Toppic).HasMaxLength(50);
        });

        modelBuilder.Entity<TbNonmotorReceiptDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.PolicyNo });

            entity.ToTable("tb_nonmotor_receipt_dt");

            entity.Property(e => e.DocNo).HasMaxLength(20);
            entity.Property(e => e.PolicyNo).HasMaxLength(30);
            entity.Property(e => e.InsureCode).HasMaxLength(20);
            entity.Property(e => e.NetComm).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbNonmotorReceiptHd>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("tb_nonmotor_receipt_hd");

            entity.Property(e => e.DocNo).HasMaxLength(20);
            entity.Property(e => e.AgentCode).HasMaxLength(20);
            entity.Property(e => e.AgentName).HasMaxLength(200);
            entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentCount).HasDefaultValue(0);
            entity.Property(e => e.Remark).HasMaxLength(200);
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasMaxLength(20);
        });

        modelBuilder.Entity<TbOccupation>(entity =>
        {
            entity.HasKey(e => e.OccupationCode);

            entity.ToTable("tb_occupation");

            entity.Property(e => e.OccupationCode).HasMaxLength(20);
            entity.Property(e => e.OccupationDescEn)
                .HasMaxLength(150)
                .HasColumnName("OccupationDescEN");
            entity.Property(e => e.OccupationDescTh)
                .HasMaxLength(150)
                .HasColumnName("OccupationDescTH");
        });

        modelBuilder.Entity<TbPaymentstatus>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("tb_paymentstatus");

            entity.Property(e => e.TypeId)
                .ValueGeneratedNever()
                .HasColumnName("TypeID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<TbPaymenttran>(entity =>
        {
            entity.ToTable("tb_paymenttrans");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranch).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BankTranDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocnoRef).HasMaxLength(50);
            entity.Property(e => e.InstallmentNo).HasColumnName("Installment_No");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentTypeDesc).HasMaxLength(150);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbPaymenttype>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("tb_paymenttype");

            entity.Property(e => e.TypeId)
                .ValueGeneratedNever()
                .HasColumnName("TypeID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<TbPremiumRate>(entity =>
        {
            entity.ToTable("tb_premium_rate");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreaDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.DaysHigherLimit).HasColumnName("Days_Higher_Limit");
            entity.Property(e => e.DaysLowerLimit).HasColumnName("Days_Lower_Limit");
            entity.Property(e => e.ShortPerc).HasColumnName("Short_Perc");
        });

        modelBuilder.Entity<TbProduct>(entity =>
        {
            entity.HasKey(e => e.ProductNo);

            entity.ToTable("tb_product");

            entity.Property(e => e.ProductNo).ValueGeneratedNever();
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(2);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceCode).HasName("PK_tb_Province");

            entity.ToTable("tb_province");

            entity.Property(e => e.ProvinceCode).ValueGeneratedNever();
            entity.Property(e => e.CreaDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.ProvinceDesc).HasMaxLength(5);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(5);
        });

        modelBuilder.Entity<TbReceiptAndPay>(entity =>
        {
            entity.HasKey(e => e.DocNo);

            entity.ToTable("tb_receipt_and_pay");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Pay).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(200);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Receipt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UserId).HasMaxLength(20);
        });

        modelBuilder.Entity<TbReceiptDt>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.UserId, e.ProductNo });

            entity.ToTable("tb_receipt_dt");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Discount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.Qty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TbReceiptHd>(entity =>
        {
            entity.HasKey(e => new { e.DocNo, e.UserId });

            entity.ToTable("tb_receipt_hd");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(20);
            entity.Property(e => e.Amount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.CustAddress).HasColumnName("Cust_Address");
            entity.Property(e => e.CustCardId)
                .HasMaxLength(20)
                .HasColumnName("Cust_CardId");
            entity.Property(e => e.CustCompanyNme)
                .HasMaxLength(150)
                .HasColumnName("Cust_Company_Nme");
            entity.Property(e => e.CustCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Cust_Company_Prefix");
            entity.Property(e => e.CustCompanySurfix)
                .HasMaxLength(150)
                .HasColumnName("Cust_Company_Surfix");
            entity.Property(e => e.CustFirstname)
                .HasMaxLength(150)
                .HasColumnName("Cust_Firstname");
            entity.Property(e => e.CustLastname)
                .HasMaxLength(150)
                .HasColumnName("Cust_Lastname");
            entity.Property(e => e.CustTitleId).HasColumnName("Cust_TitleId");
            entity.Property(e => e.CustTitleText)
                .HasMaxLength(100)
                .HasColumnName("Cust_Title_text");
            entity.Property(e => e.CustTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Cust_Type_Desc");
            entity.Property(e => e.CustTypeId)
                .HasMaxLength(2)
                .HasColumnName("Cust_Type_Id");
            entity.Property(e => e.Discount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DiscountAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Amt");
            entity.Property(e => e.DiscountType).HasMaxLength(10);
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocType).HasMaxLength(10);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(100)
                .HasColumnName("License_no");
            entity.Property(e => e.PayTypeDesc).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(100);
            entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");
            entity.Property(e => e.ProvinceName).HasMaxLength(100);
            entity.Property(e => e.SubDistrictId).HasColumnName("SubDistrictID");
            entity.Property(e => e.SubDistrictName).HasMaxLength(100);
            entity.Property(e => e.Total)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VatAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vat_Amt");
            entity.Property(e => e.VatType).HasMaxLength(10);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<TbReceiptPay>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tb_receipt_pay");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranch).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankTranDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocnoRef).HasMaxLength(30);
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbReportsource>(entity =>
        {
            entity.ToTable("tb_reportsource");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CratetDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.ReportDesc).HasMaxLength(250);
            entity.Property(e => e.ReportName).HasMaxLength(150);
            entity.Property(e => e.ReportPath).HasMaxLength(250);
            entity.Property(e => e.ReportType).HasMaxLength(50);
        });

        modelBuilder.Entity<TbSector>(entity =>
        {
            entity.HasKey(e => e.SectorId);

            entity.ToTable("tb_sector");

            entity.Property(e => e.SectorId)
                .HasMaxLength(2)
                .HasColumnName("SectorID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("systen");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SectorName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbSeiCarbrand>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_sei_carbrand");

            entity.Property(e => e.BrandId)
                .IsRequired()
                .HasMaxLength(5);
            entity.Property(e => e.BrandIdSei)
                .HasMaxLength(5)
                .HasColumnName("BrandId_Sei");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<TbSeiCarmodel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_sei_carmodel");

            entity.Property(e => e.BrandId)
                .IsRequired()
                .HasMaxLength(5);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ModelId)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.ModelIdSei)
                .HasMaxLength(10)
                .HasColumnName("ModelId_Sei");
            entity.Property(e => e.ModelName).HasMaxLength(150);
        });

        modelBuilder.Entity<TbSeiTitle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_sei_title");

            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.TitleIdSei)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Sei");
        });

        modelBuilder.Entity<TbSubdistrict>(entity =>
        {
            entity.HasKey(e => new { e.ProvinceCode, e.DistrictCode, e.SubDistrictCode }).HasName("PK_tb_SubDistrict");

            entity.ToTable("tb_subdistrict");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SubDistrictName).HasMaxLength(150);
            entity.Property(e => e.Zipcode).HasMaxLength(5);
        });

        modelBuilder.Entity<TbTaxtype>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("tb_taxtype");

            entity.Property(e => e.TypeId)
                .HasMaxLength(10)
                .HasColumnName("TypeID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TbTempcar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_tempcar");

            entity.Property(e => e.Ccode)
                .HasMaxLength(50)
                .HasColumnName("ccode");
            entity.Property(e => e.Cname).HasColumnName("cname");
            entity.Property(e => e.Mcode)
                .HasMaxLength(50)
                .HasColumnName("mcode");
            entity.Property(e => e.Mname).HasColumnName("mname");
        });

        modelBuilder.Entity<TbTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("tb_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
        });

        modelBuilder.Entity<TbTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("tb_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
        });

        modelBuilder.Entity<TbTransactionLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tb_transaction_log");

            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("systen");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRAN_Date");
            entity.Property(e => e.TranId)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<TbTree>(entity =>
        {
            entity.HasKey(e => new { e.NodeParent, e.NodeChild });

            entity.ToTable("tb_tree");

            entity.Property(e => e.NodeParent).HasMaxLength(15);
            entity.Property(e => e.NodeChild).HasMaxLength(15);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TbTreeSupportInsurance>(entity =>
        {
            entity.HasKey(e => new { e.NodeParent, e.NodeChild });

            entity.ToTable("tb_tree_support_insurance");

            entity.Property(e => e.NodeParent).HasMaxLength(15);
            entity.Property(e => e.NodeChild).HasMaxLength(15);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TempPolicyNo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("temp_policy_no");

            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("cmi_policy_no");
        });

        modelBuilder.Entity<TroCarcheck>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("tro_carcheck");

            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TranID");
            entity.Property(e => e.BrandCode).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(50)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustBuilding)
                .HasMaxLength(100)
                .HasColumnName("Cust_Building");
            entity.Property(e => e.CustDistrictId).HasColumnName("Cust_DistrictID");
            entity.Property(e => e.CustDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Cust_DistrictName");
            entity.Property(e => e.CustFirstname)
                .HasMaxLength(100)
                .HasColumnName("Cust_Firstname");
            entity.Property(e => e.CustHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Cust_HomeNo");
            entity.Property(e => e.CustIdcard)
                .HasMaxLength(20)
                .HasColumnName("Cust_IDCard");
            entity.Property(e => e.CustLastname)
                .HasMaxLength(100)
                .HasColumnName("Cust_Lastname");
            entity.Property(e => e.CustMoo)
                .HasMaxLength(20)
                .HasColumnName("Cust_Moo");
            entity.Property(e => e.CustPhone)
                .HasMaxLength(20)
                .HasColumnName("Cust_Phone");
            entity.Property(e => e.CustProvinceId).HasColumnName("Cust_ProvinceID");
            entity.Property(e => e.CustProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Cust_ProvinceName");
            entity.Property(e => e.CustSoi)
                .HasMaxLength(100)
                .HasColumnName("Cust_Soi");
            entity.Property(e => e.CustStreet)
                .HasMaxLength(100)
                .HasColumnName("Cust_Street");
            entity.Property(e => e.CustSubDistrictId).HasColumnName("Cust_SubDistrictID");
            entity.Property(e => e.CustSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Cust_SubDistrictName");
            entity.Property(e => e.CustTitleId).HasColumnName("Cust_TitleId");
            entity.Property(e => e.CustTitleText)
                .HasMaxLength(60)
                .HasColumnName("Cust_Title_text");
            entity.Property(e => e.CustTrok)
                .HasMaxLength(100)
                .HasColumnName("Cust_Trok");
            entity.Property(e => e.CustTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Cust_Type_Desc");
            entity.Property(e => e.CustTypeId)
                .HasMaxLength(10)
                .HasColumnName("Cust_Type_Id");
            entity.Property(e => e.CustZipcode)
                .HasMaxLength(5)
                .HasColumnName("Cust_Zipcode");
            entity.Property(e => e.DateOfRegister).HasColumnType("datetime");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(50)
                .HasColumnName("Engine_no");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(50)
                .HasColumnName("Inspection_ID");
            entity.Property(e => e.InspectionTech)
                .HasMaxLength(100)
                .HasColumnName("Inspection_Tech");
            entity.Property(e => e.LicNo1)
                .HasMaxLength(10)
                .HasColumnName("Lic_no1");
            entity.Property(e => e.LicNo2)
                .HasMaxLength(10)
                .HasColumnName("Lic_no2");
            entity.Property(e => e.LicProvince)
                .HasMaxLength(3)
                .HasColumnName("Lic_Province");
            entity.Property(e => e.LicProvinceId).HasColumnName("Lic_ProvinceID");
            entity.Property(e => e.ServiceCharge).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TranDate).HasColumnType("datetime");
            entity.Property(e => e.TypeCode).HasMaxLength(10);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<TroCarcheckTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tro_carcheck_temp");

            entity.Property(e => e.BrandCode).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(50)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustBuilding)
                .HasMaxLength(100)
                .HasColumnName("Cust_Building");
            entity.Property(e => e.CustDistrictId).HasColumnName("Cust_DistrictID");
            entity.Property(e => e.CustDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Cust_DistrictName");
            entity.Property(e => e.CustFirstname)
                .HasMaxLength(100)
                .HasColumnName("Cust_Firstname");
            entity.Property(e => e.CustHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Cust_HomeNo");
            entity.Property(e => e.CustIdcard)
                .HasMaxLength(20)
                .HasColumnName("Cust_IDCard");
            entity.Property(e => e.CustLastname)
                .HasMaxLength(100)
                .HasColumnName("Cust_Lastname");
            entity.Property(e => e.CustMoo)
                .HasMaxLength(20)
                .HasColumnName("Cust_Moo");
            entity.Property(e => e.CustPhone)
                .HasMaxLength(20)
                .HasColumnName("Cust_Phone");
            entity.Property(e => e.CustProvinceId).HasColumnName("Cust_ProvinceID");
            entity.Property(e => e.CustProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Cust_ProvinceName");
            entity.Property(e => e.CustSoi)
                .HasMaxLength(100)
                .HasColumnName("Cust_Soi");
            entity.Property(e => e.CustStreet)
                .HasMaxLength(100)
                .HasColumnName("Cust_Street");
            entity.Property(e => e.CustSubDistrictId).HasColumnName("Cust_SubDistrictID");
            entity.Property(e => e.CustSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Cust_SubDistrictName");
            entity.Property(e => e.CustTitleId).HasColumnName("Cust_TitleId");
            entity.Property(e => e.CustTitleText)
                .HasMaxLength(60)
                .HasColumnName("Cust_Title_text");
            entity.Property(e => e.CustTrok)
                .HasMaxLength(100)
                .HasColumnName("Cust_Trok");
            entity.Property(e => e.CustTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Cust_Type_Desc");
            entity.Property(e => e.CustTypeId)
                .HasMaxLength(10)
                .HasColumnName("Cust_Type_Id");
            entity.Property(e => e.CustZipcode)
                .HasMaxLength(5)
                .HasColumnName("Cust_Zipcode");
            entity.Property(e => e.DateOfRegister).HasColumnType("datetime");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(50)
                .HasColumnName("Engine_no");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(50)
                .HasColumnName("Inspection_ID");
            entity.Property(e => e.InspectionTech)
                .HasMaxLength(100)
                .HasColumnName("Inspection_Tech");
            entity.Property(e => e.LicNo1)
                .HasMaxLength(10)
                .HasColumnName("Lic_no1");
            entity.Property(e => e.LicNo2)
                .HasMaxLength(10)
                .HasColumnName("Lic_no2");
            entity.Property(e => e.LicProvince)
                .HasMaxLength(3)
                .HasColumnName("Lic_Province");
            entity.Property(e => e.LicProvinceId).HasColumnName("Lic_ProvinceID");
            entity.Property(e => e.ServiceCharge).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TranDate).HasColumnType("datetime");
            entity.Property(e => e.TranId)
                .HasMaxLength(50)
                .HasColumnName("TranID");
            entity.Property(e => e.TypeCode).HasMaxLength(10);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<TroCartype>(entity =>
        {
            entity.HasKey(e => e.TypeId).HasName("PK_tro_MotorType");

            entity.ToTable("tro_cartype");

            entity.Property(e => e.TypeId)
                .ValueGeneratedNever()
                .HasColumnName("TypeID");
            entity.Property(e => e.TypeCode).HasMaxLength(10);
            entity.Property(e => e.TypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<TroSmsLog>(entity =>
        {
            entity.HasKey(e => e.No);

            entity.ToTable("tro_sms_log");

            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.LicenseNo).HasMaxLength(50);
            entity.Property(e => e.Msisdn)
                .HasMaxLength(50)
                .HasColumnName("MSISDN");
            entity.Property(e => e.SmslogDesc).HasColumnName("SMSLogDesc");
        });

        modelBuilder.Entity<TroTranid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tro_tranid");

            entity.Property(e => e.TranDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId).HasColumnName("TRAN_ID");
        });

        modelBuilder.Entity<TsiCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("tsi_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdTsi)
                .HasMaxLength(5)
                .HasColumnName("BrandId_Tsi");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<TsiCarcolor>(entity =>
        {
            entity.HasKey(e => e.ColorId);

            entity.ToTable("tsi_carcolor");

            entity.Property(e => e.ColorId)
                .HasMaxLength(10)
                .HasColumnName("ColorID");
            entity.Property(e => e.ColorEngDesc).HasMaxLength(50);
            entity.Property(e => e.ColorIdTsi)
                .HasMaxLength(10)
                .HasColumnName("ColorID_tsi");
            entity.Property(e => e.ColorThaiDesc).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<TsiCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("tsi_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandIdTsi)
                .HasMaxLength(10)
                .HasColumnName("BrandId_tsi");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdTsi)
                .HasMaxLength(10)
                .HasColumnName("ModelId_tsi");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<TsiMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("tsi_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TsiMotorcode1>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("tsi_motorcode_1");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<TsiTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("tsi_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdTsi)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Tsi");
        });

        modelBuilder.Entity<TsiTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("tsi_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdTsi)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Tsi");
        });

        modelBuilder.Entity<UppCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("upp_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdUpp)
                .HasMaxLength(20)
                .HasColumnName("BrandId_Upp");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<UppCountry>(entity =>
        {
            entity.HasKey(e => e.CountryCode);

            entity.ToTable("upp_country");

            entity.Property(e => e.CountryCode).HasMaxLength(5);
            entity.Property(e => e.DescriptionEn)
                .HasMaxLength(150)
                .HasColumnName("Description_EN");
            entity.Property(e => e.DescriptionTh)
                .HasMaxLength(150)
                .HasColumnName("Description_TH");
            entity.Property(e => e.IsEnable).HasColumnName("isEnable");
        });

        modelBuilder.Entity<UppMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("upp_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(10);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<UppTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("upp_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdUpp)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Upp");
            entity.Property(e => e.TitleIdUppDesc)
                .HasMaxLength(50)
                .HasColumnName("TitleID_UppDesc");
        });

        modelBuilder.Entity<UppTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("upp_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdUpp)
                .HasMaxLength(10)
                .HasColumnName("TitleID_Upp");
        });

        modelBuilder.Entity<VAgentList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_agent_list");

            entity.Property(e => e.AgentCode)
                .IsRequired()
                .HasMaxLength(15);
            entity.Property(e => e.AgentTypeName).HasMaxLength(50);
            entity.Property(e => e.DistrictName).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(30);
            entity.Property(e => e.Fax).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(150);
            entity.Property(e => e.FullName).HasMaxLength(319);
            entity.Property(e => e.IdcartNumber)
                .HasMaxLength(20)
                .HasColumnName("IDCartNumber");
            entity.Property(e => e.LastName)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Mobile).HasMaxLength(30);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProvinceName).HasMaxLength(50);
            entity.Property(e => e.SubDistrictName).HasMaxLength(100);
            entity.Property(e => e.TitleId).HasColumnName("TitleID");
            entity.Property(e => e.TitleName).HasMaxLength(50);
            entity.Property(e => e.ZipCode).HasMaxLength(5);
        });

        modelBuilder.Entity<VAgentcommList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_agentcomm_list");

            entity.Property(e => e.AgentCode)
                .IsRequired()
                .HasMaxLength(15);
            entity.Property(e => e.AgentName).HasMaxLength(301);
            entity.Property(e => e.ComTypeName).HasMaxLength(50);
            entity.Property(e => e.CommTypeCode).HasMaxLength(5);
            entity.Property(e => e.CommissionNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InsureCode).HasMaxLength(5);
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<VCreditList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_credit_list");

            entity.Property(e => e.AgentCode)
                .IsRequired()
                .HasMaxLength(15);
            entity.Property(e => e.AgentName).HasMaxLength(301);
            entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CreditAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditBalances).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreditUsesage).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VInsurecommList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_insurecomm_list");

            entity.Property(e => e.ComTypeName).HasMaxLength(50);
            entity.Property(e => e.CommTypeCode).HasMaxLength(5);
            entity.Property(e => e.CommissionNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InsureCode).HasMaxLength(5);
            entity.Property(e => e.Ov)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("OV");
            entity.Property(e => e.Remark).HasMaxLength(250);
        });

        modelBuilder.Entity<VInvoiceList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_InvoiceList");

            entity.Property(e => e.AgentCode)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CustName).HasMaxLength(401);
            entity.Property(e => e.DiscountAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Discount_Amt");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNo)
                .IsRequired()
                .HasMaxLength(50);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(100)
                .HasColumnName("License_no");
            entity.Property(e => e.PayTypeDesc).HasMaxLength(100);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VatAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vat_Amt");
            entity.Property(e => e.VatType).HasMaxLength(10);
        });

        modelBuilder.Entity<VPmiPmi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPmi_pmi");

            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.AgentName).HasMaxLength(351);
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_Name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.CampaignCode).HasMaxLength(50);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CarTypeCode).HasMaxLength(10);
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CustName).HasMaxLength(374);
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.FlagCctv)
                .HasMaxLength(10)
                .HasColumnName("FlagCCTV");
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(22)
                .HasColumnName("License_no");
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LongAddress).HasMaxLength(796);
            entity.Property(e => e.ModelColorId)
                .HasMaxLength(10)
                .HasColumnName("Model_ColorID");
            entity.Property(e => e.ModelColorName)
                .HasMaxLength(50)
                .HasColumnName("Model_ColorName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_Name");
            entity.Property(e => e.ModelYear)
                .HasMaxLength(10)
                .HasColumnName("Model_Year");
            entity.Property(e => e.NoOfSeat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.Payment)
                .IsRequired()
                .HasMaxLength(54)
                .IsUnicode(false);
            entity.Property(e => e.PmiAgreeDate).HasColumnName("Pmi_Agree_date");
            entity.Property(e => e.PmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Comm");
            entity.Property(e => e.PmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_CommTax");
            entity.Property(e => e.PmiDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Discount");
            entity.Property(e => e.PmiEndDate).HasColumnName("Pmi_End_date");
            entity.Property(e => e.PmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Payment");
            entity.Property(e => e.PmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Pmi_Policy_No");
            entity.Property(e => e.PmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Premium");
            entity.Property(e => e.PmiSignNo)
                .HasMaxLength(50)
                .HasColumnName("Pmi_Sign_No");
            entity.Property(e => e.PmiStamp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Stamp");
            entity.Property(e => e.PmiStartDate).HasColumnName("Pmi_Start_date");
            entity.Property(e => e.PmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Total");
            entity.Property(e => e.PmiVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Vat");
            entity.Property(e => e.ProductTypeName).HasMaxLength(200);
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VPmiRequest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vPmi_request");

            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.AgentName).HasMaxLength(351);
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_Name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.CampaignCode).HasMaxLength(50);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CarTypeCode).HasMaxLength(10);
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CustName).HasMaxLength(374);
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.FlagCctv)
                .HasMaxLength(10)
                .HasColumnName("FlagCCTV");
            entity.Property(e => e.FlagReNew)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Flag_ReNew");
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.IsPolicy)
                .IsRequired()
                .HasMaxLength(58)
                .IsUnicode(false);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(22)
                .HasColumnName("License_no");
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LongAddress).HasMaxLength(796);
            entity.Property(e => e.ModelColorId)
                .HasMaxLength(10)
                .HasColumnName("Model_ColorID");
            entity.Property(e => e.ModelColorName)
                .HasMaxLength(50)
                .HasColumnName("Model_ColorName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_Name");
            entity.Property(e => e.ModelYear)
                .HasMaxLength(5)
                .HasColumnName("Model_Year");
            entity.Property(e => e.NoOfSeat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.PmiAgreeDate).HasColumnName("Pmi_Agree_date");
            entity.Property(e => e.PmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Comm");
            entity.Property(e => e.PmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_CommTax");
            entity.Property(e => e.PmiDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Discount");
            entity.Property(e => e.PmiEndDate).HasColumnName("Pmi_End_date");
            entity.Property(e => e.PmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Payment");
            entity.Property(e => e.PmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Pmi_Policy_No");
            entity.Property(e => e.PmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Premium");
            entity.Property(e => e.PmiStamp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Stamp");
            entity.Property(e => e.PmiStartDate).HasColumnName("Pmi_Start_date");
            entity.Property(e => e.PmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Total");
            entity.Property(e => e.PmiVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pmi_Vat");
            entity.Property(e => e.ProductTypeName).HasMaxLength(200);
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VReceiptMotorList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_receipt_motor_list");

            entity.Property(e => e.AgentCode).HasMaxLength(20);
            entity.Property(e => e.AgentName).HasMaxLength(200);
            entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentName).HasMaxLength(100);
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<VReceiptPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_receipt_policy");

            entity.Property(e => e.AgentCode).HasMaxLength(20);
            entity.Property(e => e.AgentName).HasMaxLength(200);
            entity.Property(e => e.CashAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.InsureCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<VReceiptPolicyMaster>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_receipt_policy_master");

            entity.Property(e => e.AgentCode).HasMaxLength(20);
            entity.Property(e => e.AgentName).HasMaxLength(200);
            entity.Property(e => e.CashAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Commission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.DocNo)
                .IsRequired()
                .HasMaxLength(20);
            entity.Property(e => e.InsureCode)
                .IsRequired()
                .HasMaxLength(10);
            entity.Property(e => e.NetPayment).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NetPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TotalPremium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TypeName).HasMaxLength(100);
        });

        modelBuilder.Entity<VUserlist>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_userlist");

            entity.Property(e => e.AgentName).HasMaxLength(301);
            entity.Property(e => e.CodeName).HasMaxLength(558);
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.Id)
                .IsRequired()
                .HasMaxLength(128);
            entity.Property(e => e.UserName)
                .IsRequired()
                .HasMaxLength(256);
        });

        modelBuilder.Entity<VcmiCmi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vcmi_cmi");

            entity.Property(e => e.AgentCode).HasMaxLength(15);
            entity.Property(e => e.AgentName).HasMaxLength(150);
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_name");
            entity.Property(e => e.CmiAgreeDate).HasColumnName("Cmi_Agree_date");
            entity.Property(e => e.CmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Comm");
            entity.Property(e => e.CmiDiscount)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Discount");
            entity.Property(e => e.CmiEndDate).HasColumnName("Cmi_End_date");
            entity.Property(e => e.CmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Cmi_MotCode");
            entity.Property(e => e.CmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Payment");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(30)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Premium");
            entity.Property(e => e.CmiSignNo)
                .HasMaxLength(30)
                .HasColumnName("Cmi_Sign_no");
            entity.Property(e => e.CmiStamp)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Stamp");
            entity.Property(e => e.CmiStartDate).HasColumnName("Cmi_Start_date");
            entity.Property(e => e.CmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Total");
            entity.Property(e => e.CmiVat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Cmi_Vat");
            entity.Property(e => e.CustName).HasMaxLength(361);
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(22)
                .HasColumnName("License_no");
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .IsRequired()
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LongAddress).HasMaxLength(796);
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(100)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.Payment)
                .IsRequired()
                .HasMaxLength(54)
                .IsUnicode(false);
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
        });

        modelBuilder.Entity<ViiCarbrand>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("vii_carbrand");

            entity.Property(e => e.BrandId).HasMaxLength(5);
            entity.Property(e => e.BrandIdVii)
                .HasMaxLength(5)
                .HasColumnName("BrandId_Vii");
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.OrderBy).HasMaxLength(5);
        });

        modelBuilder.Entity<ViiCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("vii_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdVii)
                .HasMaxLength(10)
                .HasColumnName("ModelId_vii");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<ViiCarmodelTemp>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("vii_carmodel_temp");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.ModelName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViiMotorcode>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("vii_motorcode");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ViiMotorcodeNocomm>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("vii_motorcode_nocomm");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ViiMotorcodeOth>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("vii_motorcode_oth");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ViiMotorcodeTruck>(entity =>
        {
            entity.HasKey(e => e.MotCode);

            entity.ToTable("vii_motorcode_truck");

            entity.Property(e => e.MotCode)
                .HasMaxLength(6)
                .IsFixedLength();
            entity.Property(e => e.BodyType)
                .HasMaxLength(50)
                .HasColumnName("Body_Type");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.Duty).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DutyPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.NetPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Seat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Tax).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaxPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalPrem).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Usage).HasMaxLength(50);
            entity.Property(e => e.UsageCode).HasMaxLength(5);
            entity.Property(e => e.Weigth).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ViiTitle>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("vii_title");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdVii).HasColumnName("TitleID_Vii");
        });

        modelBuilder.Entity<ViiTitleCorporate>(entity =>
        {
            entity.HasKey(e => e.TitleId);

            entity.ToTable("vii_title_corporate");

            entity.Property(e => e.TitleId)
                .ValueGeneratedNever()
                .HasColumnName("TitleID");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnable).HasDefaultValue(1);
            entity.Property(e => e.Sex).HasMaxLength(50);
            entity.Property(e => e.TitleDesc).HasMaxLength(50);
            entity.Property(e => e.TitleIdVii)
                .HasMaxLength(10)
                .HasColumnName("TitleID_vii");
        });

        modelBuilder.Entity<ViiVmiCarmodel>(entity =>
        {
            entity.HasKey(e => e.ModelTranId);

            entity.ToTable("vii_vmi_carmodel");

            entity.Property(e => e.ModelTranId).HasMaxLength(20);
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.Cc).HasColumnName("CC");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ModelCountry).HasMaxLength(10);
            entity.Property(e => e.ModelGroupId)
                .HasMaxLength(10)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelIdVii)
                .HasMaxLength(10)
                .HasColumnName("ModelId_vii");
            entity.Property(e => e.ModelName).HasMaxLength(150);
            entity.Property(e => e.SubModelDesc).HasMaxLength(250);
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(150);
            entity.Property(e => e.YearBegin).HasMaxLength(10);
            entity.Property(e => e.YearEnd).HasMaxLength(10);
        });

        modelBuilder.Entity<ViiVmiPackageRate>(entity =>
        {
            entity.HasKey(e => e.RowId);

            entity.ToTable("vii_vmi_package_rate");

            entity.Property(e => e.AccessoriesSumInsure).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.BbSumStd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("BB_SumStd");
            entity.Property(e => e.BrandId).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(50);
            entity.Property(e => e.CarCamera).HasMaxLength(2);
            entity.Property(e => e.CarCc).HasColumnName("CarCC");
            entity.Property(e => e.CarGroup).HasMaxLength(50);
            entity.Property(e => e.CarnameCode).HasMaxLength(50);
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Deduct).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DrvCompensate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DRV_Compensate");
            entity.Property(e => e.DrvSumInsure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DRV_SumInsure");
            entity.Property(e => e.FireTheft)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Fire_Theft");
            entity.Property(e => e.FlagDriver)
                .HasMaxLength(10)
                .HasColumnName("Flag_Driver");
            entity.Property(e => e.FlagRepairType).HasMaxLength(2);
            entity.Property(e => e.MeSuminsureStd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ME_SuminsureStd");
            entity.Property(e => e.ModelId).HasMaxLength(10);
            entity.Property(e => e.ModelName).HasMaxLength(50);
            entity.Property(e => e.PeriodType).HasMaxLength(50);
            entity.Property(e => e.Premium).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PsgCompensate)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PSG_Compensate");
            entity.Property(e => e.PsgPermDisable)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PSG_PermDisable");
            entity.Property(e => e.PsgSumInsure)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PSG_SumInsure");
            entity.Property(e => e.PsgTempDisable)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("PSG_TempDisable");
            entity.Property(e => e.QuotationNumber).HasMaxLength(50);
            entity.Property(e => e.RateCode).HasMaxLength(20);
            entity.Property(e => e.RegistrationYear).HasMaxLength(10);
            entity.Property(e => e.Stamp).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StopDate).HasColumnType("datetime");
            entity.Property(e => e.SubModelId).HasMaxLength(10);
            entity.Property(e => e.SubModelName).HasMaxLength(250);
            entity.Property(e => e.SumInsure).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TerrorismExclusion)
                .HasMaxLength(10)
                .HasColumnName("Terrorism_Exclusion");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TpbiPersonSumStd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPBI_Person_SumStd");
            entity.Property(e => e.TpbiTimeSumStd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPBI_Time_SumStd");
            entity.Property(e => e.TppdDeduct)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPPD_Deduct");
            entity.Property(e => e.TppdTimeSumStd)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TPPD_time_SumStd");
            entity.Property(e => e.Vat).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VehicleTypeCode).HasMaxLength(5);
        });

        modelBuilder.Entity<VmiCommission>(entity =>
        {
            entity.HasKey(e => new { e.AgentCode, e.InsureCode, e.MotorProductTypeCode });

            entity.ToTable("vmi_commission");

            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.MotorProductTypeCode).HasMaxLength(10);
            entity.Property(e => e.CommTypeCode)
                .IsRequired()
                .HasMaxLength(2);
            entity.Property(e => e.CommissionNet).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<VmiCommissionInsure>(entity =>
        {
            entity.HasKey(e => new { e.InsureCode, e.ProductTypeCode });

            entity.ToTable("vmi_commission_insure");

            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.ProductTypeCode).HasMaxLength(10);
            entity.Property(e => e.CommTypeCode1).HasMaxLength(2);
            entity.Property(e => e.CommTypeCode2).HasMaxLength(2);
            entity.Property(e => e.CommTypeCode3).HasMaxLength(2);
            entity.Property(e => e.CommTypeCode4).HasMaxLength(2);
            entity.Property(e => e.CommissionNet)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionNet4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionTax4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionValue4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CommissionVat4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("System");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
        });

        modelBuilder.Entity<VmiMotor>(entity =>
        {
            entity.HasKey(e => e.TranId);

            entity.ToTable("vmi_motor");

            entity.Property(e => e.TranId)
                .HasMaxLength(100)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.AgentCode).HasMaxLength(50);
            entity.Property(e => e.Beneficiary).HasMaxLength(150);
            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_Code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_Name");
            entity.Property(e => e.BrokerCode).HasMaxLength(25);
            entity.Property(e => e.CampaignCode).HasMaxLength(50);
            entity.Property(e => e.CampaignName).HasMaxLength(150);
            entity.Property(e => e.CarAccessories).HasMaxLength(200);
            entity.Property(e => e.Cc)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Cmi_Policy_no");
            entity.Property(e => e.CmiPolicyNoOld)
                .HasMaxLength(50)
                .HasColumnName("Cmi_Policy_no_Old");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DebitNoteRef).HasMaxLength(50);
            entity.Property(e => e.DeliveryRef).HasMaxLength(50);
            entity.Property(e => e.DriverInsurance)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.FlagCctv)
                .HasMaxLength(10)
                .HasColumnName("FlagCCTV");
            entity.Property(e => e.FlagReNew)
                .HasDefaultValue(0)
                .HasColumnName("Flag_ReNew");
            entity.Property(e => e.GarageTypeDesc)
                .HasMaxLength(100)
                .HasDefaultValue("อู่ประกัน");
            entity.Property(e => e.InsurCode).HasMaxLength(5);
            entity.Property(e => e.InsureRefNumber1).HasMaxLength(50);
            entity.Property(e => e.InsureRefNumber2).HasMaxLength(50);
            entity.Property(e => e.IsCancel).HasDefaultValue(0);
            entity.Property(e => e.IsDebitNote).HasDefaultValue(0);
            entity.Property(e => e.IsPayInsureRef).HasMaxLength(50);
            entity.Property(e => e.IsPayerDriver1)
                .HasDefaultValue(0)
                .HasColumnName("IsPayer_Driver1");
            entity.Property(e => e.IsPayerDriver2)
                .HasDefaultValue(0)
                .HasColumnName("IsPayer_Driver2");
            entity.Property(e => e.LicenseDesc)
                .HasMaxLength(20)
                .HasColumnName("License_Desc");
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvince)
                .HasMaxLength(2)
                .HasColumnName("License_Province");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.LossDistPerDriver1Amt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerAmt).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossDistPerPassengerNo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMedicalNo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerFireAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossMotorPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPaperDriver1Amt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerDriver1Amt");
            entity.Property(e => e.LossPaperPassengerAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerAmt");
            entity.Property(e => e.LossPaperPassengerNo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("LossPAPerPassengerNo");
            entity.Property(e => e.LossPerAssetAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerDedugAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerSonAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LossPerTimeAmt)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_Code");
            entity.Property(e => e.ModelColorId)
                .HasMaxLength(10)
                .HasColumnName("Model_ColorID");
            entity.Property(e => e.ModelColorName)
                .HasMaxLength(50)
                .HasColumnName("Model_ColorName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_Name");
            entity.Property(e => e.ModelYear)
                .HasMaxLength(5)
                .HasColumnName("Model_Year");
            entity.Property(e => e.NoOfSeat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayerBuilding)
                .HasMaxLength(100)
                .HasColumnName("Payer_Building");
            entity.Property(e => e.PayerCompanyBranch)
                .HasMaxLength(50)
                .HasColumnName("Payer_Company_branch");
            entity.Property(e => e.PayerCompanyBranchNumber)
                .HasMaxLength(10)
                .HasColumnName("Payer_Company_branch_number");
            entity.Property(e => e.PayerCompanyName)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Name");
            entity.Property(e => e.PayerCompanyPrefix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Prefix");
            entity.Property(e => e.PayerCompanySuffix)
                .HasMaxLength(100)
                .HasColumnName("Payer_Company_Suffix");
            entity.Property(e => e.PayerDistrictId).HasColumnName("Payer_DistrictID");
            entity.Property(e => e.PayerDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_DistrictName");
            entity.Property(e => e.PayerDriver1BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Payer_Driver1_BirthDate");
            entity.Property(e => e.PayerDriver1CardId)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_CardID");
            entity.Property(e => e.PayerDriver1FirstName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_FirstName");
            entity.Property(e => e.PayerDriver1LastName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver1_LastName");
            entity.Property(e => e.PayerDriver1Occupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Driver1_Occupation");
            entity.Property(e => e.PayerDriver1OccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Driver1_Occupation_code");
            entity.Property(e => e.PayerDriver1TitleId).HasColumnName("Payer_Driver1_TitleId");
            entity.Property(e => e.PayerDriver1TitleText)
                .HasMaxLength(30)
                .HasColumnName("Payer_Driver1_Title_text");
            entity.Property(e => e.PayerDriver2BirthDate)
                .HasColumnType("datetime")
                .HasColumnName("Payer_Driver2_BirthDate");
            entity.Property(e => e.PayerDriver2CardId)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_CardID");
            entity.Property(e => e.PayerDriver2FirstName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_FirstName");
            entity.Property(e => e.PayerDriver2LastName)
                .HasMaxLength(50)
                .HasColumnName("Payer_Driver2_LastName");
            entity.Property(e => e.PayerDriver2Occupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Driver2_Occupation");
            entity.Property(e => e.PayerDriver2OccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Driver2_Occupation_code");
            entity.Property(e => e.PayerDriver2TitleId).HasColumnName("Payer_Driver2_TitleId");
            entity.Property(e => e.PayerDriver2TitleText)
                .HasMaxLength(30)
                .HasColumnName("Payer_Driver2_Title_text");
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Payer_HomeNo");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerMoo)
                .HasMaxLength(20)
                .HasColumnName("Payer_Moo");
            entity.Property(e => e.PayerOccupation)
                .HasMaxLength(150)
                .HasColumnName("Payer_Occupation");
            entity.Property(e => e.PayerOccupationCode)
                .HasMaxLength(20)
                .HasColumnName("Payer_Occupation_code");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerProvinceId).HasColumnName("Payer_ProvinceID");
            entity.Property(e => e.PayerProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Payer_ProvinceName");
            entity.Property(e => e.PayerSex)
                .HasMaxLength(5)
                .HasColumnName("Payer_Sex");
            entity.Property(e => e.PayerSoi)
                .HasMaxLength(100)
                .HasColumnName("Payer_Soi");
            entity.Property(e => e.PayerStreet)
                .HasMaxLength(100)
                .HasColumnName("Payer_Street");
            entity.Property(e => e.PayerSubDistrictId).HasColumnName("Payer_SubDistrictID");
            entity.Property(e => e.PayerSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Payer_SubDistrictName");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.PayerTrok)
                .HasMaxLength(100)
                .HasColumnName("Payer_Trok");
            entity.Property(e => e.PayerTypeDesc)
                .HasMaxLength(50)
                .HasColumnName("Payer_Type_Desc");
            entity.Property(e => e.PayerTypeId)
                .HasMaxLength(2)
                .HasColumnName("Payer_Type_Id");
            entity.Property(e => e.PayerZipcode)
                .HasMaxLength(5)
                .HasColumnName("Payer_Zipcode");
            entity.Property(e => e.ProductTypeCode).HasMaxLength(10);
            entity.Property(e => e.ProductTypeDesc).HasMaxLength(150);
            entity.Property(e => e.ReceiptRef).HasMaxLength(50);
            entity.Property(e => e.SubModelCode)
                .HasMaxLength(50)
                .HasColumnName("SubModel_Code");
            entity.Property(e => e.SubModelName)
                .HasMaxLength(150)
                .HasColumnName("SubModel_Name");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.UrlPolicy).HasColumnName("Url_Policy");
            entity.Property(e => e.VmiAgreeDate).HasColumnName("Vmi_Agree_date");
            entity.Property(e => e.VmiComm)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_Comm");
            entity.Property(e => e.VmiCommAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_CommAmt");
            entity.Property(e => e.VmiCommTax)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_CommTax");
            entity.Property(e => e.VmiCommTax1per)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_CommTax1per");
            entity.Property(e => e.VmiCommTax1perAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_CommTax1perAmt");
            entity.Property(e => e.VmiCommTaxAmt)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_CommTaxAmt");
            entity.Property(e => e.VmiCommType)
                .HasMaxLength(10)
                .HasColumnName("Vmi_CommType");
            entity.Property(e => e.VmiEndDate).HasColumnName("Vmi_End_date");
            entity.Property(e => e.VmiIssueDate).HasColumnName("Vmi_Issue_date");
            entity.Property(e => e.VmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("Vmi_MotCode");
            entity.Property(e => e.VmiPayment)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_Payment");
            entity.Property(e => e.VmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("Vmi_Policy_no");
            entity.Property(e => e.VmiPolicyNoOld)
                .HasMaxLength(50)
                .HasColumnName("Vmi_Policy_no_Old");
            entity.Property(e => e.VmiPremium)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_Premium");
            entity.Property(e => e.VmiStamp)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_Stamp");
            entity.Property(e => e.VmiStartDate).HasColumnName("Vmi_Start_date");
            entity.Property(e => e.VmiTotal)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_Total");
            entity.Property(e => e.VmiVat)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Vmi_Vat");
            entity.Property(e => e.Weight)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VmiPayinsuranceCart>(entity =>
        {
            entity.HasKey(e => e.ItemId).HasName("PK_vmi_payinsurnce_cart");

            entity.ToTable("vmi_payinsurance_cart");

            entity.Property(e => e.ItemId).HasMaxLength(128);
            entity.Property(e => e.CommissionAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NetPremiumAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VmiPolicyNo)
                .HasMaxLength(550)
                .HasColumnName("vmi_Policy_no");
            entity.Property(e => e.VmiPremium)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("vmi_Premium");
            entity.Property(e => e.VmiTotal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("vmi_Total");
        });

        modelBuilder.Entity<VmiPayinsuranceDt>(entity =>
        {
            entity.HasKey(e => new { e.RowNumber, e.DocNo }).HasName("PK_vmi_payinsurnce_dt");

            entity.ToTable("vmi_payinsurance_dt");

            entity.Property(e => e.RowNumber).ValueGeneratedOnAdd();
            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.CommTypeCode1).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode2).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode3).HasMaxLength(5);
            entity.Property(e => e.CommTypeCode4).HasMaxLength(5);
            entity.Property(e => e.Commission1).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commission2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commission3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Commission4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTax4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVat4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(50);
            entity.Property(e => e.NetPremiumAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VmiAgreeDate)
                .HasColumnType("datetime")
                .HasColumnName("vmi_Agree_date");
            entity.Property(e => e.VmiEndDate)
                .HasColumnType("datetime")
                .HasColumnName("vmi_End_date");
            entity.Property(e => e.VmiMotCode)
                .HasMaxLength(10)
                .HasColumnName("vmi_MotCode");
            entity.Property(e => e.VmiPolicyNo)
                .HasMaxLength(50)
                .HasColumnName("vmi_Policy_no");
            entity.Property(e => e.VmiPremium)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("vmi_Premium");
            entity.Property(e => e.VmiStartDate)
                .HasColumnType("datetime")
                .HasColumnName("vmi_Start_date");
            entity.Property(e => e.VmiTotal)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("vmi_Total");
        });

        modelBuilder.Entity<VmiPayinsuranceHd>(entity =>
        {
            entity.HasKey(e => e.DocNo).HasName("PK_vmi_payinsurnce_hd");

            entity.ToTable("vmi_payinsurance_hd");

            entity.Property(e => e.DocNo).HasMaxLength(50);
            entity.Property(e => e.CommissionAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionTaxAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CommissionVatAmount4)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.CountPolicy).HasDefaultValue(0);
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocDate).HasColumnType("datetime");
            entity.Property(e => e.InsureCode).HasMaxLength(10);
            entity.Property(e => e.InsureName).HasMaxLength(250);
            entity.Property(e => e.NetPremiumAmount)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VmiPremium)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("vmi_Premium");
            entity.Property(e => e.VmiTotal)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("vmi_Total");
        });

        modelBuilder.Entity<VmiPayinsurancePay>(entity =>
        {
            entity.HasKey(e => e.TranId).HasName("PK_vmi_payinsurnce_pay");

            entity.ToTable("vmi_payinsurance_pay");

            entity.Property(e => e.BankAccountNo).HasMaxLength(50);
            entity.Property(e => e.BankBranch).HasMaxLength(150);
            entity.Property(e => e.BankCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BankTranDate).HasColumnType("datetime");
            entity.Property(e => e.CreateBy)
                .HasMaxLength(50)
                .HasDefaultValue("system");
            entity.Property(e => e.CreateDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.DocnoRef).HasMaxLength(30);
            entity.Property(e => e.Img64File).HasColumnName("img64File");
            entity.Property(e => e.ImgName)
                .HasMaxLength(50)
                .HasColumnName("imgName");
            entity.Property(e => e.ImgType)
                .HasMaxLength(50)
                .HasColumnName("imgType");
            entity.Property(e => e.PayAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PaymentTypeDesc).HasMaxLength(150);
            entity.Property(e => e.TranDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<VpmiQuotation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vpmi_quotation");

            entity.Property(e => e.BrandCode)
                .HasMaxLength(10)
                .HasColumnName("Brand_Code");
            entity.Property(e => e.BrandName)
                .HasMaxLength(100)
                .HasColumnName("Brand_Name");
            entity.Property(e => e.Cc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CC");
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(30)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CreateBy).HasMaxLength(20);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustName).HasMaxLength(361);
            entity.Property(e => e.EngineNo)
                .HasMaxLength(30)
                .HasColumnName("Engine_no");
            entity.Property(e => e.GroupName).HasMaxLength(617);
            entity.Property(e => e.LicenseNo)
                .HasMaxLength(22)
                .HasColumnName("License_no");
            entity.Property(e => e.LicenseNo1)
                .HasMaxLength(10)
                .HasColumnName("License_no1");
            entity.Property(e => e.LicenseNo2)
                .HasMaxLength(10)
                .HasColumnName("License_no2");
            entity.Property(e => e.LicenseProvinceId).HasColumnName("License_ProvinceID");
            entity.Property(e => e.ModelCode)
                .HasMaxLength(10)
                .HasColumnName("Model_Code");
            entity.Property(e => e.ModelColorId)
                .HasMaxLength(10)
                .HasColumnName("Model_ColorID");
            entity.Property(e => e.ModelColorName)
                .HasMaxLength(50)
                .HasColumnName("Model_ColorName");
            entity.Property(e => e.ModelName)
                .HasMaxLength(100)
                .HasColumnName("Model_Name");
            entity.Property(e => e.ModelYear)
                .HasMaxLength(5)
                .HasColumnName("Model_Year");
            entity.Property(e => e.NoOfSeat)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("No_of_Seat");
            entity.Property(e => e.PayType)
                .IsRequired()
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PayerFirstname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Firstname");
            entity.Property(e => e.PayerIdCard)
                .HasMaxLength(20)
                .HasColumnName("Payer_Id_Card");
            entity.Property(e => e.PayerLastname)
                .HasMaxLength(150)
                .HasColumnName("Payer_Lastname");
            entity.Property(e => e.PayerPhone)
                .HasMaxLength(25)
                .HasColumnName("Payer_Phone");
            entity.Property(e => e.PayerTitleId).HasColumnName("Payer_TitleId");
            entity.Property(e => e.PayerTitleText)
                .HasMaxLength(60)
                .HasColumnName("Payer_Title_text");
            entity.Property(e => e.TranDate)
                .HasColumnType("datetime")
                .HasColumnName("TRAN_DATE");
            entity.Property(e => e.TranId)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("TRAN_ID");
            entity.Property(e => e.UpdateBy).HasMaxLength(20);
            entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VtroList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vtro_list");

            entity.Property(e => e.AgentCode).HasMaxLength(15);
            entity.Property(e => e.BrandCode).HasMaxLength(10);
            entity.Property(e => e.BrandName).HasMaxLength(150);
            entity.Property(e => e.ChassisNo)
                .HasMaxLength(50)
                .HasColumnName("Chassis_no");
            entity.Property(e => e.CreateBy).HasMaxLength(50);
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.CustBuilding)
                .HasMaxLength(100)
                .HasColumnName("Cust_Building");
            entity.Property(e => e.CustDistrictId).HasColumnName("Cust_DistrictID");
            entity.Property(e => e.CustDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Cust_DistrictName");
            entity.Property(e => e.CustFirstname)
                .HasMaxLength(100)
                .HasColumnName("Cust_Firstname");
            entity.Property(e => e.CustHomeNo)
                .HasMaxLength(20)
                .HasColumnName("Cust_HomeNo");
            entity.Property(e => e.CustIdcard)
                .HasMaxLength(20)
                .HasColumnName("Cust_IDCard");
            entity.Property(e => e.CustLastname)
                .HasMaxLength(100)
                .HasColumnName("Cust_Lastname");
            entity.Property(e => e.CustMoo)
                .HasMaxLength(20)
                .HasColumnName("Cust_Moo");
            entity.Property(e => e.CustPhone)
                .HasMaxLength(20)
                .HasColumnName("Cust_Phone");
            entity.Property(e => e.CustProvinceId).HasColumnName("Cust_ProvinceID");
            entity.Property(e => e.CustProvinceName)
                .HasMaxLength(50)
                .HasColumnName("Cust_ProvinceName");
            entity.Property(e => e.CustSoi)
                .HasMaxLength(100)
                .HasColumnName("Cust_Soi");
            entity.Property(e => e.CustStreet)
                .HasMaxLength(100)
                .HasColumnName("Cust_Street");
            entity.Property(e => e.CustSubDistrictId).HasColumnName("Cust_SubDistrictID");
            entity.Property(e => e.CustSubDistrictName)
                .HasMaxLength(100)
                .HasColumnName("Cust_SubDistrictName");
            entity.Property(e => e.CustTitleId).HasColumnName("Cust_TitleId");
            entity.Property(e => e.CustTitleText)
                .HasMaxLength(60)
                .HasColumnName("Cust_Title_text");
            entity.Property(e => e.CustTrok)
                .HasMaxLength(100)
                .HasColumnName("Cust_Trok");
            entity.Property(e => e.CustZipcode)
                .HasMaxLength(5)
                .HasColumnName("Cust_Zipcode");
            entity.Property(e => e.DateOfRegister).HasColumnType("datetime");
            entity.Property(e => e.EngineNo)
                .HasMaxLength(50)
                .HasColumnName("Engine_no");
            entity.Property(e => e.InspectionId)
                .HasMaxLength(50)
                .HasColumnName("Inspection_ID");
            entity.Property(e => e.InspectionTech)
                .HasMaxLength(100)
                .HasColumnName("Inspection_Tech");
            entity.Property(e => e.LicNo1)
                .HasMaxLength(10)
                .HasColumnName("Lic_no1");
            entity.Property(e => e.LicNo2)
                .HasMaxLength(10)
                .HasColumnName("Lic_no2");
            entity.Property(e => e.LicProvince)
                .HasMaxLength(3)
                .HasColumnName("Lic_Province");
            entity.Property(e => e.LicProvinceId).HasColumnName("Lic_ProvinceID");
            entity.Property(e => e.Licno).HasMaxLength(23);
            entity.Property(e => e.ServiceCharge).HasColumnType("decimal(8, 2)");
            entity.Property(e => e.TranDate).HasColumnType("datetime");
            entity.Property(e => e.TranId)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("TranID");
            entity.Property(e => e.TroName).HasMaxLength(351);
            entity.Property(e => e.TypeCode).HasMaxLength(10);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");
            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
        });
        
        #endregion
        
        OnModelCreatingPartial(modelBuilder);
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

[ExcludeFromCodeCoverage]
public class SIADbContextDesignFactory : IDesignTimeDbContextFactory<SIADbContext>
{
    public SIADbContext CreateDbContext(string[] args)
    {
        var connectionString = ConfigurationExtension
            .CreateConfigurationBuilder("API")
            .AddJsonFile($"appsettings.Development.json", true, true)
            .AddEnvironmentVariables()
            .Build()["SQLSERVER_CONNECTIONSTRING"];

        var dbContextOptions = new DbContextOptionsBuilder<SIADbContext>()
            .UseSqlServer(connectionString)
            .Options;

        return new SIADbContext(dbContextOptions);
    }
}