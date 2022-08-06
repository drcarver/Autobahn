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
        /// The complete <see cref="RefFacilitySystemOrComponentCondition"> List
         /// </summary>
        public static List<RefFacilitySystemOrComponentCondition> RefFacilitySystemOrComponentConditionList = new List<RefFacilitySystemOrComponentCondition>
        {
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("d181ed4a-a9b9-4bd8-8f21-f5972078fc3c"), Code="02563", Description="Adequate system or component condition", Definition="Some preventive maintenance and/or corrective repair is required.", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("5642b3a6-cecf-4048-8c5a-cfe1df47506d"), Code="02567", Description="Emergency system or component condition", Definition="A condition that will result in injury, loss of life, or major damage.", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("a28f6cae-2eaa-45f6-99c2-304c7d9abaf8"), Code="02561", Description="Excellent System or Component Condition", Definition="New or easily restorable to `like new` condition; only minimal routine maintenance is required.", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("d2a66b1f-6378-49c3-9b64-89e1c5f40b2f"), Code="02564", Description="Fair System or Component Condition", Definition="Sometimes fails to meet code or functional requirements; failure(s) are inconvenient to school operation.", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("8e67d929-79ab-4a89-96f7-07482bce42eb"), Code="02562", Description="Good System or Component Condition", Definition="Only routine maintenance or minor repair is required.", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("96e56122-4a6d-448f-80b4-c66a5cb858cb"), Code="02983", Description="Nonoperable system or component condition", Definition="The system or component exists in a significantly substandard level and cannot be used or operated. Replacement is required.", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("502d0da9-d930-4aa7-a0b8-3ca6b42036e2"), Code="02565", Description="Poor System or Component Condition", Definition="Consistently substandard performance; failure(s) are disruptive and costly; fails most code and functional requirements; requires constant attention, renovation, or replacement. Major corrective repair or overhaul is required.", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("e1d3a41b-d3d1-47c2-87fa-077687a2efbe"), Code="02566", Description="Urgent building system or component condition", Definition="A condition that will seriously affect the safety, environment, and/or educational mission, or could result in possible damage to the facility or inhabitants.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefFacilitySystemOrComponentCondition Pick List
         /// </summary>
        public static List<RefFacilitySystemOrComponentCondition> RefFacilitySystemOrComponentConditionPickList = new List<RefFacilitySystemOrComponentCondition>
        {
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("d181ed4a-a9b9-4bd8-8f21-f5972078fc3c"), Code="02563", Description="Adequate system or component condition", SortOrder=Convert.ToDecimal("1.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("5642b3a6-cecf-4048-8c5a-cfe1df47506d"), Code="02567", Description="Emergency system or component condition", SortOrder=Convert.ToDecimal("2.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("a28f6cae-2eaa-45f6-99c2-304c7d9abaf8"), Code="02561", Description="Excellent System or Component Condition", SortOrder=Convert.ToDecimal("3.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("d2a66b1f-6378-49c3-9b64-89e1c5f40b2f"), Code="02564", Description="Fair System or Component Condition", SortOrder=Convert.ToDecimal("4.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("8e67d929-79ab-4a89-96f7-07482bce42eb"), Code="02562", Description="Good System or Component Condition", SortOrder=Convert.ToDecimal("5.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("96e56122-4a6d-448f-80b4-c66a5cb858cb"), Code="02983", Description="Nonoperable system or component condition", SortOrder=Convert.ToDecimal("6.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("502d0da9-d930-4aa7-a0b8-3ca6b42036e2"), Code="02565", Description="Poor System or Component Condition", SortOrder=Convert.ToDecimal("7.00") },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("e1d3a41b-d3d1-47c2-87fa-077687a2efbe"), Code="02566", Description="Urgent building system or component condition", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
