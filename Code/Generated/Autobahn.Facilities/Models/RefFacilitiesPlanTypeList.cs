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
        /// The complete <see cref="RefFacilitiesPlanType"> List
         /// </summary>
        public static List<RefFacilitiesPlanType> RefFacilitiesPlanTypeList = new List<RefFacilitiesPlanType> =
        {
            new RefFacilitiesPlanType { Id=Guid.Parse("1c4c044f-b40f-4345-9a40-0b7a0038621b"), Code="A 5- or 6-year plan, based on the master plan, that sets priorities and budgets for school-specific major capital projects, such as component replacement, system upgrades, whole or partial school modernization, new construction, and site acquisition.", Description="02828", Definition="", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("9c7da2dc-bac6-4a95-8b64-07172a6e904a"), Code="A long-term plan (often 10 years) that describes the scope, schedule, and cost estimates to bring all facilities up to desired standards from current conditions.", Description="02827", Definition="", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("046ea852-d6fb-4485-a248-da3ed761dc9d"), Code="A plan that addresses the immediate and short-term effects of an emergency or disaster. Response includes immediate actions to save lives, protect property, and meet basic human needs.", Description="02825", Definition="", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("8b786639-d4cf-4265-97e7-4aca196a55a3"), Code="A plan that includes historical utility consumption and cost data and targets, with scope of work and schedule to meet cost and consumption targets.", Description="02829", Definition="", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("10bd87ed-7c50-4d93-870b-cd994df19f86"), Code="A plan that identifies hazardous materials in the building and/or site and describes scope of work, schedule, cost, and appropriate entities to carry out the plan.", Description="02830", Definition="", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("073368cf-78bb-4447-a691-5ae36b59117c"), Code="A plan that includes the specific scope, schedule, responsible party, estimated cost, and source of funds for routine, preventive, and predictive maintenance of a district or school.", Description="02826", Definition="", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("79d9f58f-8a59-4c14-9c09-fa151701a9ff"), Code="Other is specified as the type of management and accountability plan.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilitiesPlanType Pick List
         /// </summary>
        public static List<RefFacilitiesPlanType> RefFacilitiesPlanTypePickList = new List<RefFacilitiesPlanType> =
        {
            new RefFacilitiesPlanType { Id=Guid.Parse("1c4c044f-b40f-4345-9a40-0b7a0038621b"), Code="A 5- or 6-year plan, based on the master plan, that sets priorities and budgets for school-specific major capital projects, such as component replacement, system upgrades, whole or partial school modernization, new construction, and site acquisition.", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("9c7da2dc-bac6-4a95-8b64-07172a6e904a"), Code="A long-term plan (often 10 years) that describes the scope, schedule, and cost estimates to bring all facilities up to desired standards from current conditions.", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("046ea852-d6fb-4485-a248-da3ed761dc9d"), Code="A plan that addresses the immediate and short-term effects of an emergency or disaster. Response includes immediate actions to save lives, protect property, and meet basic human needs.", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("8b786639-d4cf-4265-97e7-4aca196a55a3"), Code="A plan that includes historical utility consumption and cost data and targets, with scope of work and schedule to meet cost and consumption targets.", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("10bd87ed-7c50-4d93-870b-cd994df19f86"), Code="A plan that identifies hazardous materials in the building and/or site and describes scope of work, schedule, cost, and appropriate entities to carry out the plan.", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("073368cf-78bb-4447-a691-5ae36b59117c"), Code="A plan that includes the specific scope, schedule, responsible party, estimated cost, and source of funds for routine, preventive, and predictive maintenance of a district or school.", SortOrder=0 },
            new RefFacilitiesPlanType { Id=Guid.Parse("79d9f58f-8a59-4c14-9c09-fa151701a9ff"), Code="Other is specified as the type of management and accountability plan.", SortOrder=0 },
       };
   }
}
