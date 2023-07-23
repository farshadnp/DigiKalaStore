using System.Collections.Generic;
using AutoMapper;


namespace DigiKala.WebAPI.HelperClassess
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<AddAccountTypeDto, AccountType>();
            //CreateMap<Aggregates.Groups.Group, GetAllGroupsResult>();
            //CreateMap<GroupMT5, GetAllGroupsResult>();


            //CreateMap<UserRecord,
            //    EditClientAccountDto>();

            //CreateMap<ProfitAndBalanceDto, ProfitAndBalanceModel>();
            //CreateMap<IBRequestDto, IBRequest>();
            //CreateMap<List<IBClientInfoDataQueryResultDto>, List<IBClientInfo>>();
            //CreateMap<GetWalletFinancialReportDto, WalletFinancialReportDto>();

            //CreateMap<SendCodeDto, ValidationRequest>();
            //CreateMap<VerifyCodeDto, VerifyRequest>();

            //CreateMap<ValidationResult, SendCodeResult>();
            //CreateMap<VerifyResult, VerifyCodeResult>();
            //CreateMap<Account, InsertOrUpdateAccountDto>();
            //CreateMap<AddTradeEvent, Trade>();

            //CreateMap<Aggregates.Groups.Group, GroupResult>()
            //    .ForMember(x => x.Id, o => o.MapFrom(src => src.Id))
            //    .ForMember(x => x.Name, o => o.MapFrom(src => src.Name));

            //CreateMap<RealListResult, AccountInformationDto>().ReverseMap();
            //CreateMap<DemoListResult, AccountInformationDto>().ReverseMap();

            //CreateMap<List<AccountInformationDto>,List<RealLoginResult>>().ReverseMap();

            //CreateMap<User, UserProfileCompletedEvent>();


            //#region IB Paln
            //CreateMap<SymbolsRebateDto, BrokerIBPlanDefaultConfigSymbolsRebate>().IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<DefaultConfigDto, BrokerIBPlanDefaultConfig>().IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBSymbol, BrokerIBSymbolResult>()
            //    .ForMember(des=>des.AccountTypeName,opt=>opt.MapFrom(src=>src.AccountType.Name))
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBPlanDefaultConfigSymbolsRebate, SymbolsRebateResult>()
            //    .ForMember(dest => dest.BrokerIBSymbolResult,
            //    opt => opt.MapFrom(src => src.BrokerIBSymbol)
            //    ).IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBPlanDefaultConfig, GetIBPlanDefaultConfigResult>().ForMember(
            //    dest => dest.SymbolsRebateList,
            //    opt => opt.MapFrom(src => src.BrokerIBPlanDefaultConfigSymbolsRebate)
            //    ).IgnoreAllPropertiesWithAnInaccessibleSetter();

            ////add CreateNewBrokerIBPlan ================================
            ////CreateMap<BrokerIBPlanConfigSymbolsRebateDto, BrokerIBPlanConfigSymbolsRebate>().IgnoreAllPropertiesWithAnInaccessibleSetter();
            ////CreateMap<BrokerIBPlanConfigDto, BrokerIBPlanConfig>()
            ////    .ForMember(des => des.BrokerIBPlanConfigSymbolsRebate, opt => opt.MapFrom(src => src.BrokerIBPlanConfigSymbolsRebateDtos))
            ////    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<CreateNewBrokerIBPlanDto, BrokerIBPlan>()
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();


            //CreateMap<BrokerIBPlanDefaultConfigSymbolsRebate, BrokerIBPlanConfigSymbolsRebate>()
            //    .ForMember(des => des.Id, opt => opt.Ignore())
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBPlanDefaultConfig, BrokerIBPlanConfig>()
            //    .ForMember(des => des.BrokerIBPlanConfigSymbolsRebate, opt => opt.MapFrom(src => src.BrokerIBPlanDefaultConfigSymbolsRebate))
            //    .ForMember(des => des.Id, opt => opt.Ignore())
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBPlan, GetAllBrokerIBPlanResult>().IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBPlanConfigSymbolsRebate, BrokerIBPlanConfigSymbolsRebateResult>()
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBPlanConfig, BrokerIBPlanConfigResult>()
            //    .ForMember(des => des.BrokerIBPlanConfigSymbolsRebate, opt => opt.MapFrom(src => src.BrokerIBPlanConfigSymbolsRebate))
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<BrokerIBPlan, GetBrokerIBPlanResult>()
            //    .ForMember(des => des.BrokerIBPlanConfig, opt => opt.MapFrom(src => src.BrokerIBPlanConfig))
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<IBPlanLevel, GetIBPlanLevelsResult>()
            //    .ForMember(des => des.IBPlanLevelId, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(des => des.PlanName, opt => opt.MapFrom(src => src.BrokerIBPlan.PlanName))
            //    .ForMember(des => des.PlanVersion, opt => opt.MapFrom(src => src.BrokerIBPlan.Version))
            //    .ForMember(des => des.PlanPoint, opt => opt.MapFrom(src => src.BrokerIBPlan.Point))
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();

            //CreateMap<IBPlanLevel, GetActivePlanLevelResult>()
            //    .ForMember(des => des.IBPlanLevelId, opt => opt.MapFrom(src => src.Id))
            //    .ForMember(des => des.PlanName, opt => opt.MapFrom(src => src.BrokerIBPlan.PlanName))
            //    .ForMember(des => des.PlanVersion, opt => opt.MapFrom(src => src.BrokerIBPlan.Version))
            //    .ForMember(des => des.PlanPoint, opt => opt.MapFrom(src => src.BrokerIBPlan.Point))
            //    .IgnoreAllPropertiesWithAnInaccessibleSetter();



        }
    }
}
