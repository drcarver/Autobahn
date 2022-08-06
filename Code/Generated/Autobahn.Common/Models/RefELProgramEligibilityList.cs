//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefELProgramEligibilityList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefELProgramEligibility Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELProgramEligibility"> List
         /// </summary>
        public static List<RefELProgramEligibility> RefELProgramEligibilityList = new List<RefELProgramEligibility>
        {
            new RefELProgramEligibility { Id=Guid.Parse("3a703fc8-c1a7-47d9-9431-9308bd6bb478"), Code="Age", Description="Age", Definition="Age is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELProgramEligibility { Id=Guid.Parse("855b1906-3673-488d-b1c6-95f23a384cf7"), Code="FamilyIncome", Description="Family income", Definition="Family income is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("2.00") },
            new RefELProgramEligibility { Id=Guid.Parse("e59bf670-2b0f-4610-84c2-bc5c1130817d"), Code="DisabilityStatus", Description="Disability Status", Definition="Disability Status is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELProgramEligibility { Id=Guid.Parse("80911aad-7beb-41c6-8e00-a2b78aaf9a55"), Code="SSSI", Description="Supplemental social security income", Definition="Supplemental social security income is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("4.00") },
            new RefELProgramEligibility { Id=Guid.Parse("c1098303-d6f5-47d9-be58-b282b61a902a"), Code="WIC", Description="Women, infants, and children", Definition="Women, infants, and children is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELProgramEligibility { Id=Guid.Parse("7b64381a-a2d3-4f69-81b3-efaaba69c861"), Code="TANF", Description="Temporary assistance for needy families", Definition="Temporary assistance for needy families is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("6.00") },
            new RefELProgramEligibility { Id=Guid.Parse("9be234c2-5b85-4447-96cf-16b936178069"), Code="OtherPublicAssistance", Description="Other public assistance", Definition="Other public assistance is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("7.00") },
            new RefELProgramEligibility { Id=Guid.Parse("61ff29a9-0589-4e6b-9f6e-9ccb8db39ddb"), Code="Foster", Description="Foster", Definition="Foster is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("8.00") },
            new RefELProgramEligibility { Id=Guid.Parse("6e4e7cfd-a1fd-4a13-9ba6-b3c2af594e27"), Code="MilitaryFamily", Description="Military family", Definition="Military family is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELProgramEligibility { Id=Guid.Parse("40aa9109-af6a-4363-9b4c-df2a0c11c43a"), Code="ELL", Description="Home language other than English", Definition="Home language other than English is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("10.00") },
            new RefELProgramEligibility { Id=Guid.Parse("ac7b84fa-86a1-4806-8301-9e6027340182"), Code="OtherFamilyRisk", Description="Other family risk factors", Definition="Other family risk factors is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("11.00") },
            new RefELProgramEligibility { Id=Guid.Parse("1edea07c-aa75-4bf4-adef-08894c8c26ea"), Code="OtherChildRisk", Description="Other child risk factors", Definition="Other child risk factors is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("12.00") },
            new RefELProgramEligibility { Id=Guid.Parse("2408eeaf-dfd5-4861-a1cb-781d806bf02e"), Code="AtRisk", Description="At-risk of having a substantial developmental delay", Definition="At-risk of having a substantial developmental delay is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("20.00") },
            new RefELProgramEligibility { Id=Guid.Parse("96509f1f-f958-401d-8441-fd930ea15cd0"), Code="Other", Description="Other", Definition="The category under which the person is eligible for an early childhood program or service is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The RefELProgramEligibility Pick List
         /// </summary>
        public static List<RefELProgramEligibility> RefELProgramEligibilityPickList = new List<RefELProgramEligibility>
        {
            new RefELProgramEligibility { Id=Guid.Parse("3a703fc8-c1a7-47d9-9431-9308bd6bb478"), Code="Age", Description="Age", SortOrder=Convert.ToDecimal("1.00") },
            new RefELProgramEligibility { Id=Guid.Parse("855b1906-3673-488d-b1c6-95f23a384cf7"), Code="FamilyIncome", Description="Family income", SortOrder=Convert.ToDecimal("2.00") },
            new RefELProgramEligibility { Id=Guid.Parse("e59bf670-2b0f-4610-84c2-bc5c1130817d"), Code="DisabilityStatus", Description="Disability Status", SortOrder=Convert.ToDecimal("3.00") },
            new RefELProgramEligibility { Id=Guid.Parse("80911aad-7beb-41c6-8e00-a2b78aaf9a55"), Code="SSSI", Description="Supplemental social security income", SortOrder=Convert.ToDecimal("4.00") },
            new RefELProgramEligibility { Id=Guid.Parse("c1098303-d6f5-47d9-be58-b282b61a902a"), Code="WIC", Description="Women, infants, and children", SortOrder=Convert.ToDecimal("5.00") },
            new RefELProgramEligibility { Id=Guid.Parse("7b64381a-a2d3-4f69-81b3-efaaba69c861"), Code="TANF", Description="Temporary assistance for needy families", SortOrder=Convert.ToDecimal("6.00") },
            new RefELProgramEligibility { Id=Guid.Parse("9be234c2-5b85-4447-96cf-16b936178069"), Code="OtherPublicAssistance", Description="Other public assistance", SortOrder=Convert.ToDecimal("7.00") },
            new RefELProgramEligibility { Id=Guid.Parse("61ff29a9-0589-4e6b-9f6e-9ccb8db39ddb"), Code="Foster", Description="Foster", SortOrder=Convert.ToDecimal("8.00") },
            new RefELProgramEligibility { Id=Guid.Parse("6e4e7cfd-a1fd-4a13-9ba6-b3c2af594e27"), Code="MilitaryFamily", Description="Military family", SortOrder=Convert.ToDecimal("9.00") },
            new RefELProgramEligibility { Id=Guid.Parse("40aa9109-af6a-4363-9b4c-df2a0c11c43a"), Code="ELL", Description="Home language other than English", SortOrder=Convert.ToDecimal("10.00") },
            new RefELProgramEligibility { Id=Guid.Parse("ac7b84fa-86a1-4806-8301-9e6027340182"), Code="OtherFamilyRisk", Description="Other family risk factors", SortOrder=Convert.ToDecimal("11.00") },
            new RefELProgramEligibility { Id=Guid.Parse("1edea07c-aa75-4bf4-adef-08894c8c26ea"), Code="OtherChildRisk", Description="Other child risk factors", SortOrder=Convert.ToDecimal("12.00") },
            new RefELProgramEligibility { Id=Guid.Parse("2408eeaf-dfd5-4861-a1cb-781d806bf02e"), Code="AtRisk", Description="At-risk of having a substantial developmental delay", SortOrder=Convert.ToDecimal("20.00") },
            new RefELProgramEligibility { Id=Guid.Parse("96509f1f-f958-401d-8441-fd930ea15cd0"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
