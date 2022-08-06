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
        public static List<RefFacilitySystemOrComponentCondition> RefFacilitySystemOrComponentConditionList = new List<RefFacilitySystemOrComponentCondition> =
        {
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("820603a8-a1a3-4b00-af87-81937ea72580"), Code="Some preventive maintenance and/or corrective repair is required.", Description="02563", Definition="", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b01b8565-f310-439e-8706-4789117dbf81"), Code="A condition that will result in injury, loss of life, or major damage.", Description="02567", Definition="", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("7068b57b-e097-4250-b546-3393d341605e"), Code="New or easily restorable to `like new` condition; only minimal routine maintenance is required.", Description="02561", Definition="", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("84d19080-6eff-415f-b80f-b1ebf402674d"), Code="Sometimes fails to meet code or functional requirements; failure(s) are inconvenient to school operation.", Description="02564", Definition="", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("9d2dfd2a-9d1b-4849-8fa8-b33b6dd1962a"), Code="Only routine maintenance or minor repair is required.", Description="02562", Definition="", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("59cbfe11-a44c-4de9-b5ed-b677c7466003"), Code="The system or component exists in a significantly substandard level and cannot be used or operated. Replacement is required.", Description="02983", Definition="", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b60d686f-9671-455f-b3a6-a1be2a6f7090"), Code="Consistently substandard performance; failure(s) are disruptive and costly; fails most code and functional requirements; requires constant attention, renovation, or replacement. Major corrective repair or overhaul is required.", Description="02565", Definition="", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("8517a50c-437e-4d9e-bf16-ee87c2f2f8ee"), Code="A condition that will seriously affect the safety, environment, and/or educational mission, or could result in possible damage to the facility or inhabitants.", Description="02566", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefFacilitySystemOrComponentCondition Pick List
         /// </summary>
        public static List<RefFacilitySystemOrComponentCondition> RefFacilitySystemOrComponentConditionPickList = new List<RefFacilitySystemOrComponentCondition> =
        {
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("820603a8-a1a3-4b00-af87-81937ea72580"), Code="Some preventive maintenance and/or corrective repair is required.", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b01b8565-f310-439e-8706-4789117dbf81"), Code="A condition that will result in injury, loss of life, or major damage.", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("7068b57b-e097-4250-b546-3393d341605e"), Code="New or easily restorable to `like new` condition; only minimal routine maintenance is required.", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("84d19080-6eff-415f-b80f-b1ebf402674d"), Code="Sometimes fails to meet code or functional requirements; failure(s) are inconvenient to school operation.", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("9d2dfd2a-9d1b-4849-8fa8-b33b6dd1962a"), Code="Only routine maintenance or minor repair is required.", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("59cbfe11-a44c-4de9-b5ed-b677c7466003"), Code="The system or component exists in a significantly substandard level and cannot be used or operated. Replacement is required.", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("b60d686f-9671-455f-b3a6-a1be2a6f7090"), Code="Consistently substandard performance; failure(s) are disruptive and costly; fails most code and functional requirements; requires constant attention, renovation, or replacement. Major corrective repair or overhaul is required.", SortOrder=0 },
            new RefFacilitySystemOrComponentCondition { Id=Guid.Parse("8517a50c-437e-4d9e-bf16-ee87c2f2f8ee"), Code="A condition that will seriously affect the safety, environment, and/or educational mission, or could result in possible damage to the facility or inhabitants.", SortOrder=0 },
       };
   }
}
