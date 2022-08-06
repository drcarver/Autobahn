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
        public static List<RefFacilitiesPlanType> RefFacilitiesPlanTypeList = new List<RefFacilitiesPlanType>
        {
            new RefFacilitiesPlanType { Id=Guid.Parse("f4c821da-f06b-49df-9c82-141a9cb3d116"), Code="02828", Description="Capital improvement plan", Definition="A 5- or 6-year plan, based on the master plan, that sets priorities and budgets for school-specific major capital projects, such as component replacement, system upgrades, whole or partial school modernization, new construction, and site acquisition.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("5b7dbf0c-4158-4cfd-b76a-b76f9f064849"), Code="02827", Description="Educational facilities master plan", Definition="A long-term plan (often 10 years) that describes the scope, schedule, and cost estimates to bring all facilities up to desired standards from current conditions.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("386dd495-1c13-41bb-b449-a45950d38a31"), Code="02825", Description="Emergency response plan", Definition="A plan that addresses the immediate and short-term effects of an emergency or disaster. Response includes immediate actions to save lives, protect property, and meet basic human needs.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("b529b6cf-152b-4292-a002-61db01188bc9"), Code="02829", Description="Energy management plan", Definition="A plan that includes historical utility consumption and cost data and targets, with scope of work and schedule to meet cost and consumption targets.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("4afaf7d5-b20c-4375-865d-4c5309eda11c"), Code="02830", Description="Hazardous materials management plan", Definition="A plan that identifies hazardous materials in the building and/or site and describes scope of work, schedule, cost, and appropriate entities to carry out the plan.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("d2c28114-3d9d-48f6-9b2c-0c11ce3a170d"), Code="02826", Description="Maintenance plan", Definition="A plan that includes the specific scope, schedule, responsible party, estimated cost, and source of funds for routine, preventive, and predictive maintenance of a district or school.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("945d9f10-b557-40d9-86fd-9ccb2a0261cc"), Code="09999", Description="Other", Definition="Other is specified as the type of management and accountability plan.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefFacilitiesPlanType Pick List
         /// </summary>
        public static List<RefFacilitiesPlanType> RefFacilitiesPlanTypePickList = new List<RefFacilitiesPlanType>
        {
            new RefFacilitiesPlanType { Id=Guid.Parse("f4c821da-f06b-49df-9c82-141a9cb3d116"), Code="02828", Description="Capital improvement plan", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("5b7dbf0c-4158-4cfd-b76a-b76f9f064849"), Code="02827", Description="Educational facilities master plan", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("386dd495-1c13-41bb-b449-a45950d38a31"), Code="02825", Description="Emergency response plan", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("b529b6cf-152b-4292-a002-61db01188bc9"), Code="02829", Description="Energy management plan", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("4afaf7d5-b20c-4375-865d-4c5309eda11c"), Code="02830", Description="Hazardous materials management plan", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("d2c28114-3d9d-48f6-9b2c-0c11ce3a170d"), Code="02826", Description="Maintenance plan", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitiesPlanType { Id=Guid.Parse("945d9f10-b557-40d9-86fd-9ccb2a0261cc"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
