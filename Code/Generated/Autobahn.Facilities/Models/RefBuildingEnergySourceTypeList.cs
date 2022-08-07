//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefBuildingEnergySourceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefBuildingEnergySourceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefBuildingEnergySourceTypeModel"> List
         /// </summary>
        public static List<RefBuildingEnergySourceTypeModel> RefBuildingEnergySourceTypeList = new List<RefBuildingEnergySourceTypeModel>
        {
            new RefBuildingEnergySourceType { Id=Guid.Parse("ec4a21db-de9b-4bad-baf3-b7c0e0f44bf6"), Code="13655", Description="Biomass", Definition="Biomass is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("8d3ba494-7e2e-47be-96da-5a464a3f455a"), Code="02858", Description="Coal", Definition="Coal is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("e07ea934-478a-4213-8d3c-cf75dcc3a69a"), Code="02854", Description="Electric", Definition="Electric is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("b37c0aed-f4fe-460a-ae00-65666650e41c"), Code="02853", Description="Gas", Definition="Gas is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("55d08545-ba14-4cf6-8ed4-b809283cb8c8"), Code="02857", Description="Geothermal", Definition="Geothermal is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("b884fc0a-e246-402e-91fa-c140ca3d2794"), Code="02859", Description="Nuclear", Definition="Nuclear is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("93fd3de1-8455-4895-a8b0-e5d6b3d6693f"), Code="02842", Description="Oil", Definition="Oil is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("84181aad-d55f-4b3e-8240-565d5f0482de"), Code="02855", Description="Solar", Definition="Solar is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("ceec61a6-438f-45b2-b427-7fba22eaed97"), Code="02843", Description="Water", Definition="Water is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("9c1f0823-24b9-485a-b864-2eb69f17e408"), Code="02856", Description="Wind", Definition="Wind is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("6b475c76-b8c1-4f21-9c3f-4dd90b069fbb"), Code="09999", Description="Other", Definition="Other is specified as the source of energy that directly powers a school district facility or building system.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefBuildingEnergySourceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefBuildingEnergySourceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefBuildingEnergySourceType { Id=Guid.Parse("ec4a21db-de9b-4bad-baf3-b7c0e0f44bf6"), Description="Biomass", SortOrder=Convert.ToDecimal("1.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("8d3ba494-7e2e-47be-96da-5a464a3f455a"), Description="Coal", SortOrder=Convert.ToDecimal("2.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("e07ea934-478a-4213-8d3c-cf75dcc3a69a"), Description="Electric", SortOrder=Convert.ToDecimal("3.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("b37c0aed-f4fe-460a-ae00-65666650e41c"), Description="Gas", SortOrder=Convert.ToDecimal("4.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("55d08545-ba14-4cf6-8ed4-b809283cb8c8"), Description="Geothermal", SortOrder=Convert.ToDecimal("5.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("b884fc0a-e246-402e-91fa-c140ca3d2794"), Description="Nuclear", SortOrder=Convert.ToDecimal("6.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("93fd3de1-8455-4895-a8b0-e5d6b3d6693f"), Description="Oil", SortOrder=Convert.ToDecimal("7.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("84181aad-d55f-4b3e-8240-565d5f0482de"), Description="Solar", SortOrder=Convert.ToDecimal("8.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("ceec61a6-438f-45b2-b427-7fba22eaed97"), Description="Water", SortOrder=Convert.ToDecimal("9.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("9c1f0823-24b9-485a-b864-2eb69f17e408"), Description="Wind", SortOrder=Convert.ToDecimal("10.00") },
            new RefBuildingEnergySourceType { Id=Guid.Parse("6b475c76-b8c1-4f21-9c3f-4dd90b069fbb"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
