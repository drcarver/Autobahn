//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCourseCreditBasisTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCourseCreditBasisType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCourseCreditBasisTypeModel"> List
         /// </summary>
        public static List<RefCourseCreditBasisTypeModel> RefCourseCreditBasisTypeList = new List<RefCourseCreditBasisTypeModel>
        {
            new RefCourseCreditBasisType { Id=Guid.Parse("869033a3-995b-4f4d-add9-f3474f31e1bd"), Code="Regular", Description="Regular/general enrollment", Definition="Regular/general enrollment is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("9775ae5b-d9d7-40e5-b2d8-acc8d8796fd0"), Code="Major", Description="Credit associated with the student's major", Definition="Credit associated with the student's major is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("dca56a2c-f09e-429b-9b39-3dc9d4122dd6"), Code="AcademicRenewal", Description="Academic Renewal", Definition="Academic Renewal is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("ad6090c2-2974-4925-9d57-b25be01d2215"), Code="AdultBasic", Description="Adult Basic", Definition="Adult Basic is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("1df00c58-ceb6-4dca-a40a-098df1c104e8"), Code="AdvancedPlacement", Description="Advanced Placement", Definition="Advanced Placement is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("a2530698-28a1-4549-8b47-6b199674109c"), Code="AdvancedStanding", Description="Advanced Standing", Definition="Advanced Standing is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("1e14580e-64d9-4fd6-a9d5-0d84993c6b8a"), Code="Correspondence", Description="Correspondence", Definition="Correspondence is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("7b722ca1-6f32-4479-bd43-0977a1e4a506"), Code="ContinuingEducation", Description="Continuing Education", Definition="Continuing Education is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("769af0bf-4f4b-4252-84e2-a872dbcc230e"), Code="Exemption", Description="Exemption", Definition="Exemption is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("88f29930-1892-460d-9021-f055ab389227"), Code="Equivalence", Description="Equivalence", Definition="Equivalence is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("63b2e8c5-be60-4ddd-aa23-fa5337e64e00"), Code="InternationalBaccalaureate", Description="International Baccalaureate", Definition="International Baccalaureate is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("55cb17b1-cf10-4712-b130-7d521d3604b7"), Code="Military", Description="Military", Definition="Military is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("b06189e6-e198-4a8d-b4f1-2de48139c1f7"), Code="Remedial", Description="Remedial/developmental", Definition="Remedial/developmental is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("72f99d74-7ba4-4a28-90e2-3aa26553d489"), Code="CreditByExam", Description="Credit granted from successful score on a standardized test of comprehension or proficiency.", Definition="Credit granted for the course based on successful score on a standardized test of comprehension or proficiency.", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("2f9d6080-6f45-49b7-8b84-3860acb35da6"), Code="HighSchoolTransferCredit", Description="Credit from a high school course is transferred to the college.", Definition="Credit granted for a course from a high school course is transferred to the college.", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("63b376d0-0e18-41ce-9421-d88a73114281"), Code="HighSchoolCreditOnly", Description="Credit from a college course is transferred back to high school and not counted by the college.", Definition="Credit granted for a course from a college course is transferred back to high school and not counted by the college.", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("7281f79f-efa2-4595-a94a-ac22613d9aca"), Code="HighSchoolDualCredit", Description="Credit from a college course is counted at both the college and high school.", Definition="Credit for a course from a college course is counted at both the college and high school.", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("44af4454-f3a6-4dd4-8591-71eaece1f0d9"), Code="JuniorHighSchoolCredit", Description="Credit from a junior high school course is counted at the high school.", Definition="Credit for a course from a junior high school course counted at the high school.", SortOrder=Convert.ToDecimal("36.00") },
        };

        /// <summary>
        /// The Reference RefCourseCreditBasisType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCourseCreditBasisTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCourseCreditBasisType { Id=Guid.Parse("869033a3-995b-4f4d-add9-f3474f31e1bd"), Description="Regular/general enrollment", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("9775ae5b-d9d7-40e5-b2d8-acc8d8796fd0"), Description="Credit associated with the student's major", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("dca56a2c-f09e-429b-9b39-3dc9d4122dd6"), Description="Academic Renewal", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("ad6090c2-2974-4925-9d57-b25be01d2215"), Description="Adult Basic", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("1df00c58-ceb6-4dca-a40a-098df1c104e8"), Description="Advanced Placement", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("a2530698-28a1-4549-8b47-6b199674109c"), Description="Advanced Standing", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("1e14580e-64d9-4fd6-a9d5-0d84993c6b8a"), Description="Correspondence", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("7b722ca1-6f32-4479-bd43-0977a1e4a506"), Description="Continuing Education", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("769af0bf-4f4b-4252-84e2-a872dbcc230e"), Description="Exemption", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("88f29930-1892-460d-9021-f055ab389227"), Description="Equivalence", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("63b2e8c5-be60-4ddd-aa23-fa5337e64e00"), Description="International Baccalaureate", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("55cb17b1-cf10-4712-b130-7d521d3604b7"), Description="Military", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("b06189e6-e198-4a8d-b4f1-2de48139c1f7"), Description="Remedial/developmental", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("72f99d74-7ba4-4a28-90e2-3aa26553d489"), Description="Credit granted from successful score on a standardized test of comprehension or proficiency.", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("2f9d6080-6f45-49b7-8b84-3860acb35da6"), Description="Credit from a high school course is transferred to the college.", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("63b376d0-0e18-41ce-9421-d88a73114281"), Description="Credit from a college course is transferred back to high school and not counted by the college.", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("7281f79f-efa2-4595-a94a-ac22613d9aca"), Description="Credit from a college course is counted at both the college and high school.", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("44af4454-f3a6-4dd4-8591-71eaece1f0d9"), Description="Credit from a junior high school course is counted at the high school.", SortOrder=Convert.ToDecimal("36.00") },
       };
   }
}
