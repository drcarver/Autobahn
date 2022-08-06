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
        /// The complete <see cref="RefCourseCreditBasisType"> List
         /// </summary>
        public static List<RefCourseCreditBasisType> RefCourseCreditBasisTypeList = new List<RefCourseCreditBasisType>
        {
            new RefCourseCreditBasisType { Id=Guid.Parse("75e1f154-0d53-4811-bb5c-1c1fb9160272"), Code="Regular", Description="Regular/general enrollment", Definition="Regular/general enrollment is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("562e943e-07d2-4e5e-a3ea-e58daa177618"), Code="Major", Description="Credit associated with the student's major", Definition="Credit associated with the student's major is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("82c0e29b-9fdf-462e-81a5-b68caa1ef8fd"), Code="AcademicRenewal", Description="Academic Renewal", Definition="Academic Renewal is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("24f7cf31-f6cc-4e8f-82bd-23e8a2b9b414"), Code="AdultBasic", Description="Adult Basic", Definition="Adult Basic is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("b71161f0-aeaf-47c0-a63d-cd63c80489fe"), Code="AdvancedPlacement", Description="Advanced Placement", Definition="Advanced Placement is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("4fb5153d-846d-4759-8680-d3ade05869d2"), Code="AdvancedStanding", Description="Advanced Standing", Definition="Advanced Standing is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("817ea3d4-2561-4f10-80aa-b9fabce8a8f3"), Code="Correspondence", Description="Correspondence", Definition="Correspondence is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("24c2049d-3735-48e0-9c3f-aebb85c96b4f"), Code="ContinuingEducation", Description="Continuing Education", Definition="Continuing Education is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("e7c82e62-c3cf-43d3-84b8-4a4757417b11"), Code="Exemption", Description="Exemption", Definition="Exemption is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("04d05b4b-ddf6-42df-860c-e26ad5b216ba"), Code="Equivalence", Description="Equivalence", Definition="Equivalence is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("378a93fc-563a-4bc4-a9a8-00e8a8806b7d"), Code="InternationalBaccalaureate", Description="International Baccalaureate", Definition="International Baccalaureate is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("f379092b-c27e-4505-b493-f30a4a616809"), Code="Military", Description="Military", Definition="Military is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("bd70c30b-f620-431c-b26d-b8d15dc796c2"), Code="Remedial", Description="Remedial/developmental", Definition="Remedial/developmental is specified as the  type of enrollment associated with the credit hours for the course.", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("be118675-1584-469a-9c68-ba1849d76760"), Code="CreditByExam", Description="Credit granted from successful score on a standardized test of comprehension or proficiency.", Definition="Credit granted for the course based on successful score on a standardized test of comprehension or proficiency.", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("a0d5ccea-79fe-4669-ad5b-3a75b3014ccd"), Code="HighSchoolTransferCredit", Description="Credit from a high school course is transferred to the college.", Definition="Credit granted for a course from a high school course is transferred to the college.", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("6b8a5cbf-6e83-4b56-a790-685193577186"), Code="HighSchoolCreditOnly", Description="Credit from a college course is transferred back to high school and not counted by the college.", Definition="Credit granted for a course from a college course is transferred back to high school and not counted by the college.", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("9352987b-8d75-48f9-a045-5cc7fe893cb3"), Code="HighSchoolDualCredit", Description="Credit from a college course is counted at both the college and high school.", Definition="Credit for a course from a college course is counted at both the college and high school.", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("dcbe1d2f-0783-45ac-9305-5e0dd8466f50"), Code="JuniorHighSchoolCredit", Description="Credit from a junior high school course is counted at the high school.", Definition="Credit for a course from a junior high school course counted at the high school.", SortOrder=Convert.ToDecimal("36.00") },
        };

        /// <summary>
        /// The RefCourseCreditBasisType Pick List
         /// </summary>
        public static List<RefCourseCreditBasisType> RefCourseCreditBasisTypePickList = new List<RefCourseCreditBasisType>
        {
            new RefCourseCreditBasisType { Id=Guid.Parse("75e1f154-0d53-4811-bb5c-1c1fb9160272"), Code="Regular", Description="Regular/general enrollment", SortOrder=Convert.ToDecimal("2.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("562e943e-07d2-4e5e-a3ea-e58daa177618"), Code="Major", Description="Credit associated with the student's major", SortOrder=Convert.ToDecimal("4.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("82c0e29b-9fdf-462e-81a5-b68caa1ef8fd"), Code="AcademicRenewal", Description="Academic Renewal", SortOrder=Convert.ToDecimal("6.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("24f7cf31-f6cc-4e8f-82bd-23e8a2b9b414"), Code="AdultBasic", Description="Adult Basic", SortOrder=Convert.ToDecimal("8.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("b71161f0-aeaf-47c0-a63d-cd63c80489fe"), Code="AdvancedPlacement", Description="Advanced Placement", SortOrder=Convert.ToDecimal("10.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("4fb5153d-846d-4759-8680-d3ade05869d2"), Code="AdvancedStanding", Description="Advanced Standing", SortOrder=Convert.ToDecimal("12.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("817ea3d4-2561-4f10-80aa-b9fabce8a8f3"), Code="Correspondence", Description="Correspondence", SortOrder=Convert.ToDecimal("14.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("24c2049d-3735-48e0-9c3f-aebb85c96b4f"), Code="ContinuingEducation", Description="Continuing Education", SortOrder=Convert.ToDecimal("16.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("e7c82e62-c3cf-43d3-84b8-4a4757417b11"), Code="Exemption", Description="Exemption", SortOrder=Convert.ToDecimal("18.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("04d05b4b-ddf6-42df-860c-e26ad5b216ba"), Code="Equivalence", Description="Equivalence", SortOrder=Convert.ToDecimal("20.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("378a93fc-563a-4bc4-a9a8-00e8a8806b7d"), Code="InternationalBaccalaureate", Description="International Baccalaureate", SortOrder=Convert.ToDecimal("22.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("f379092b-c27e-4505-b493-f30a4a616809"), Code="Military", Description="Military", SortOrder=Convert.ToDecimal("24.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("bd70c30b-f620-431c-b26d-b8d15dc796c2"), Code="Remedial", Description="Remedial/developmental", SortOrder=Convert.ToDecimal("26.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("be118675-1584-469a-9c68-ba1849d76760"), Code="CreditByExam", Description="Credit granted from successful score on a standardized test of comprehension or proficiency.", SortOrder=Convert.ToDecimal("28.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("a0d5ccea-79fe-4669-ad5b-3a75b3014ccd"), Code="HighSchoolTransferCredit", Description="Credit from a high school course is transferred to the college.", SortOrder=Convert.ToDecimal("30.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("6b8a5cbf-6e83-4b56-a790-685193577186"), Code="HighSchoolCreditOnly", Description="Credit from a college course is transferred back to high school and not counted by the college.", SortOrder=Convert.ToDecimal("32.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("9352987b-8d75-48f9-a045-5cc7fe893cb3"), Code="HighSchoolDualCredit", Description="Credit from a college course is counted at both the college and high school.", SortOrder=Convert.ToDecimal("34.00") },
            new RefCourseCreditBasisType { Id=Guid.Parse("dcbe1d2f-0783-45ac-9305-5e0dd8466f50"), Code="JuniorHighSchoolCredit", Description="Credit from a junior high school course is counted at the high school.", SortOrder=Convert.ToDecimal("36.00") },
       };
   }
}
