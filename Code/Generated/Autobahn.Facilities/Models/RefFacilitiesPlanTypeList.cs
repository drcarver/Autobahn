//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitiesPlanTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilitiesPlanType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilitiesPlanTypeModel"> List
         /// </summary>
        public static List<RefFacilitiesPlanTypeModel> RefFacilitiesPlanTypeList = new List<RefFacilitiesPlanTypeModel>
        {
            new RefFacilitiesPlanType { Id=Guid.Parse("033775dd-11e3-4bce-b4be-cde958498179"), Code="02828", Description="Capital improvement plan", Definition="A 5- or 6-year plan, based on the master plan, that sets priorities and budgets for school-specific major capital projects, such as component replacement, system upgrades, whole or partial school modernization, new construction, and site acquisition.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("1a40813c-5106-4f60-ad89-a4b5f00e09ce"), Code="02827", Description="Educational facilities master plan", Definition="A long-term plan (often 10 years) that describes the scope, schedule, and cost estimates to bring all facilities up to desired standards from current conditions.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("6447281e-b198-4c64-bc5f-a7b51da47104"), Code="02825", Description="Emergency response plan", Definition="A plan that addresses the immediate and short-term effects of an emergency or disaster. Response includes immediate actions to save lives, protect property, and meet basic human needs.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("d12873a5-b13b-4825-a27a-735b76d8c6e3"), Code="02829", Description="Energy management plan", Definition="A plan that includes historical utility consumption and cost data and targets, with scope of work and schedule to meet cost and consumption targets.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("d71a32b1-88f8-4ebc-8d57-0e0696ada1cd"), Code="02830", Description="Hazardous materials management plan", Definition="A plan that identifies hazardous materials in the building and/or site and describes scope of work, schedule, cost, and appropriate entities to carry out the plan.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("f84b1a95-eaf4-4308-8c1d-4d6a4236c767"), Code="02826", Description="Maintenance plan", Definition="A plan that includes the specific scope, schedule, responsible party, estimated cost, and source of funds for routine, preventive, and predictive maintenance of a district or school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("6e69ef7e-c67c-4fb5-b6ab-bf4301350029"), Code="09999", Description="Other", Definition="Other is specified as the type of management and accountability plan.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefFacilitiesPlanType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilitiesPlanTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilitiesPlanType { Id=Guid.Parse("033775dd-11e3-4bce-b4be-cde958498179"), Description="Capital improvement plan", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("1a40813c-5106-4f60-ad89-a4b5f00e09ce"), Description="Educational facilities master plan", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("6447281e-b198-4c64-bc5f-a7b51da47104"), Description="Emergency response plan", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("d12873a5-b13b-4825-a27a-735b76d8c6e3"), Description="Energy management plan", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("d71a32b1-88f8-4ebc-8d57-0e0696ada1cd"), Description="Hazardous materials management plan", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("f84b1a95-eaf4-4308-8c1d-4d6a4236c767"), Description="Maintenance plan", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("6e69ef7e-c67c-4fb5-b6ab-bf4301350029"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
