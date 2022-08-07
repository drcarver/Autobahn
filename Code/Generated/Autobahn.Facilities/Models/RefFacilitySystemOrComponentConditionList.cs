//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefFacilitySystemOrComponentConditionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefFacilitySystemOrComponentCondition Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefFacilitySystemOrComponentConditionModel"> List
         /// </summary>
        public static List<RefFacilitySystemOrComponentConditionModel> RefFacilitySystemOrComponentConditionList = new List<RefFacilitySystemOrComponentConditionModel>
        {
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("1da6a73c-2163-464d-8bd9-01fb576a6f12"), Code="02563", Description="Adequate system or component condition", Definition="Some preventive maintenance and/or corrective repair is required.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("1475db35-6a9a-456c-baf3-f199776cec84"), Code="02567", Description="Emergency system or component condition", Definition="A condition that will result in injury, loss of life, or major damage.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b2d3509a-6316-4dc8-ae39-21f16c9a46bf"), Code="02561", Description="Excellent System or Component Condition", Definition="New or easily restorable to `like new` condition; only minimal routine maintenance is required.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b9b4c9c7-643a-4309-89f5-a39a57600208"), Code="02564", Description="Fair System or Component Condition", Definition="Sometimes fails to meet code or functional requirements; failure(s) are inconvenient to school operation.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("772b4950-c4e2-4cb3-9859-5056fc1795f5"), Code="02562", Description="Good System or Component Condition", Definition="Only routine maintenance or minor repair is required.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("36d80ff1-d4c6-4089-8a5d-5cea37bc036a"), Code="02983", Description="Nonoperable system or component condition", Definition="The system or component exists in a significantly substandard level and cannot be used or operated. Replacement is required.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("55a3f6dc-f2dc-424c-9089-5ab49c7a4d47"), Code="02565", Description="Poor System or Component Condition", Definition="Consistently substandard performance; failure(s) are disruptive and costly; fails most code and functional requirements; requires constant attention, renovation, or replacement. Major corrective repair or overhaul is required.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("fb8a4487-720b-42ee-aba0-bfb99aedb2a5"), Code="02566", Description="Urgent building system or component condition", Definition="A condition that will seriously affect the safety, environment, and/or educational mission, or could result in possible damage to the facility or inhabitants.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefFacilitySystemOrComponentCondition Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefFacilitySystemOrComponentConditionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("1da6a73c-2163-464d-8bd9-01fb576a6f12"), Description="Adequate system or component condition", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("1475db35-6a9a-456c-baf3-f199776cec84"), Description="Emergency system or component condition", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b2d3509a-6316-4dc8-ae39-21f16c9a46bf"), Description="Excellent System or Component Condition", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b9b4c9c7-643a-4309-89f5-a39a57600208"), Description="Fair System or Component Condition", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("772b4950-c4e2-4cb3-9859-5056fc1795f5"), Description="Good System or Component Condition", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("36d80ff1-d4c6-4089-8a5d-5cea37bc036a"), Description="Nonoperable system or component condition", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("55a3f6dc-f2dc-424c-9089-5ab49c7a4d47"), Description="Poor System or Component Condition", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("fb8a4487-720b-42ee-aba0-bfb99aedb2a5"), Description="Urgent building system or component condition", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
