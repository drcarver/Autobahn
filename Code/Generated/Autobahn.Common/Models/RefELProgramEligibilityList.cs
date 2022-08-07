//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefELProgramEligibilityList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefELProgramEligibility Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELProgramEligibilityModel"> List
         /// </summary>
        public static List<RefELProgramEligibilityModel> RefELProgramEligibilityList = new List<RefELProgramEligibilityModel>
        {
            new RefELProgramEligibility { Id=Guid.Parse("114b9423-c2e0-4278-b9d1-45def1d029d5"), Code="Age", Description="Age", Definition="Age is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELProgramEligibility { Id=Guid.Parse("daee339b-49b7-41f8-9b61-538eb8398f88"), Code="FamilyIncome", Description="Family income", Definition="Family income is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("2.00") },
            new RefELProgramEligibility { Id=Guid.Parse("b8d7de02-f6b5-4677-84ff-bf77515cefcb"), Code="DisabilityStatus", Description="Disability Status", Definition="Disability Status is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELProgramEligibility { Id=Guid.Parse("cfcafce9-2593-4e18-bd54-4a3fe527ad2a"), Code="SSSI", Description="Supplemental social security income", Definition="Supplemental social security income is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("4.00") },
            new RefELProgramEligibility { Id=Guid.Parse("086374c7-87f9-4713-9b45-5ee042dab39e"), Code="WIC", Description="Women, infants, and children", Definition="Women, infants, and children is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELProgramEligibility { Id=Guid.Parse("a575301a-3c01-4252-a0c5-cea8327987ca"), Code="TANF", Description="Temporary assistance for needy families", Definition="Temporary assistance for needy families is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("6.00") },
            new RefELProgramEligibility { Id=Guid.Parse("1e69de39-0c79-42b1-8a62-b6f53d95978e"), Code="OtherPublicAssistance", Description="Other public assistance", Definition="Other public assistance is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("7.00") },
            new RefELProgramEligibility { Id=Guid.Parse("a78ad435-bb29-4800-9fdc-70f156df195e"), Code="Foster", Description="Foster", Definition="Foster is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("8.00") },
            new RefELProgramEligibility { Id=Guid.Parse("b3e7a70d-2a34-467c-928a-1aea266f02b1"), Code="MilitaryFamily", Description="Military family", Definition="Military family is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELProgramEligibility { Id=Guid.Parse("8624e0cf-d1b5-4ab6-a7df-0968b168173d"), Code="ELL", Description="Home language other than English", Definition="Home language other than English is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("10.00") },
            new RefELProgramEligibility { Id=Guid.Parse("bd4b696a-ac85-4e5a-97c4-9e1046a329fd"), Code="OtherFamilyRisk", Description="Other family risk factors", Definition="Other family risk factors is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("11.00") },
            new RefELProgramEligibility { Id=Guid.Parse("4d9f5811-2e7d-48b2-a8d5-68526a560990"), Code="OtherChildRisk", Description="Other child risk factors", Definition="Other child risk factors is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("12.00") },
            new RefELProgramEligibility { Id=Guid.Parse("ea350e41-55b8-4908-81f0-726b5a4bfe1f"), Code="AtRisk", Description="At-risk of having a substantial developmental delay", Definition="At-risk of having a substantial developmental delay is the category under which the person is eligible for an early childhood program or service.", SortOrder=Convert.ToDecimal("20.00") },
            new RefELProgramEligibility { Id=Guid.Parse("d531aa93-d3e0-4a22-8c5c-ca80eef0c94b"), Code="Other", Description="Other", Definition="The category under which the person is eligible for an early childhood program or service is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("21.00") },
        };

        /// <summary>
        /// The Reference RefELProgramEligibility Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELProgramEligibilityViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELProgramEligibility { Id=Guid.Parse("114b9423-c2e0-4278-b9d1-45def1d029d5"), Description="Age", SortOrder=Convert.ToDecimal("1.00") },
            new RefELProgramEligibility { Id=Guid.Parse("daee339b-49b7-41f8-9b61-538eb8398f88"), Description="Family income", SortOrder=Convert.ToDecimal("2.00") },
            new RefELProgramEligibility { Id=Guid.Parse("b8d7de02-f6b5-4677-84ff-bf77515cefcb"), Description="Disability Status", SortOrder=Convert.ToDecimal("3.00") },
            new RefELProgramEligibility { Id=Guid.Parse("cfcafce9-2593-4e18-bd54-4a3fe527ad2a"), Description="Supplemental social security income", SortOrder=Convert.ToDecimal("4.00") },
            new RefELProgramEligibility { Id=Guid.Parse("086374c7-87f9-4713-9b45-5ee042dab39e"), Description="Women, infants, and children", SortOrder=Convert.ToDecimal("5.00") },
            new RefELProgramEligibility { Id=Guid.Parse("a575301a-3c01-4252-a0c5-cea8327987ca"), Description="Temporary assistance for needy families", SortOrder=Convert.ToDecimal("6.00") },
            new RefELProgramEligibility { Id=Guid.Parse("1e69de39-0c79-42b1-8a62-b6f53d95978e"), Description="Other public assistance", SortOrder=Convert.ToDecimal("7.00") },
            new RefELProgramEligibility { Id=Guid.Parse("a78ad435-bb29-4800-9fdc-70f156df195e"), Description="Foster", SortOrder=Convert.ToDecimal("8.00") },
            new RefELProgramEligibility { Id=Guid.Parse("b3e7a70d-2a34-467c-928a-1aea266f02b1"), Description="Military family", SortOrder=Convert.ToDecimal("9.00") },
            new RefELProgramEligibility { Id=Guid.Parse("8624e0cf-d1b5-4ab6-a7df-0968b168173d"), Description="Home language other than English", SortOrder=Convert.ToDecimal("10.00") },
            new RefELProgramEligibility { Id=Guid.Parse("bd4b696a-ac85-4e5a-97c4-9e1046a329fd"), Description="Other family risk factors", SortOrder=Convert.ToDecimal("11.00") },
            new RefELProgramEligibility { Id=Guid.Parse("4d9f5811-2e7d-48b2-a8d5-68526a560990"), Description="Other child risk factors", SortOrder=Convert.ToDecimal("12.00") },
            new RefELProgramEligibility { Id=Guid.Parse("ea350e41-55b8-4908-81f0-726b5a4bfe1f"), Description="At-risk of having a substantial developmental delay", SortOrder=Convert.ToDecimal("20.00") },
            new RefELProgramEligibility { Id=Guid.Parse("d531aa93-d3e0-4a22-8c5c-ca80eef0c94b"), Description="Other", SortOrder=Convert.ToDecimal("21.00") },
       };
   }
}
