//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentPurposeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentPurpose Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentPurposeModel"> List
         /// </summary>
        public static List<RefAssessmentPurposeModel> RefAssessmentPurposeList = new List<RefAssessmentPurposeModel>
        {
            new RefAssessmentPurpose { Id=Guid.Parse("704e742d-071f-4474-a626-9ee1c1c8296b"), Code="00050", Description="Admission", Definition="Admission is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("4597386b-645a-49a3-ac9f-9f5589e20a05"), Code="00051", Description="Assessment of student's progress", Definition="Assessment of student's progress is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1c723af5-1fff-491c-8c46-e54036cdc63e"), Code="73055", Description="College Readiness", Definition="College Readiness is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b2b7e69f-cd17-485e-901f-58ddb59395ed"), Code="00063", Description="Course credit", Definition="Course credit is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1ca9f1e3-4a5e-4bdd-bb55-311bfd88a7ab"), Code="00064", Description="Course requirement", Definition="Course requirement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("bd9994b1-7b75-4381-8646-a53464462a72"), Code="73069", Description="Diagnosis", Definition="Diagnosis is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("17ac99f7-d51a-437b-8404-ab768c66877b"), Code="03459", Description="Federal accountability", Definition="Federal accountability is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("e754bc1a-6533-460d-8a1d-373a112bbe33"), Code="73068", Description="Inform local or state policy", Definition="Inform local or state policy is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("183c0abc-4e7e-4b97-aed3-44e8d9d94d4f"), Code="00055", Description="Instructional decision", Definition="Instructional decision is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b65361d1-a1ec-4d00-b637-4fb2aeb1c32e"), Code="03457", Description="Local accountability", Definition="Local accountability is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("74e0ae62-8373-458d-a7c9-5d80d671390c"), Code="02404", Description="Local graduation requirement", Definition="Local graduation requirement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("bc81536d-2937-470a-8f13-b29786eb3d54"), Code="73042", Description="Obtain a state- or industry-recognized certificate or license", Definition="Obtain a state- or industry-recognized certificate or license is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b8cc5095-b69f-4bfd-973a-d321bfe0c100"), Code="73043", Description="Obtain postsecondary credit for the course", Definition="Obtain postsecondary credit for the course is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("c3b12bcf-abb9-4c08-8ebc-2ab6aab7eec3"), Code="73067", Description="Program eligibility", Definition="Program eligibility is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("21.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("6325453d-29c1-406b-a102-83980f4a4729"), Code="00057", Description="Program evaluation", Definition="Program evaluation is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("45cdad2e-a2d8-4a57-9119-86e56d814a30"), Code="00058", Description="Program placement", Definition="Program placement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("c1142417-baeb-4d02-8fd4-5182878b2253"), Code="00062", Description="Promotion to or retention in a grade or program", Definition="Promotion to or retention in a grade or program is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b5803761-1ffa-4e08-a93d-760cc622a238"), Code="00061", Description="Screening", Definition="Screening is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("74d713c2-a839-4749-aa61-c3afc29fdc60"), Code="03458", Description="State accountability", Definition="State accountability is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("f35393d4-4451-4153-abae-9ad93aca07ef"), Code="09999", Description="Other", Definition="Other is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1ee745eb-c5cb-483d-b441-b2c7574b9cf3"), Code="00054", Description="State graduation requirement", Definition="State graduation requirement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("32.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentPurpose Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentPurposeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentPurpose { Id=Guid.Parse("704e742d-071f-4474-a626-9ee1c1c8296b"), Description="Admission", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("4597386b-645a-49a3-ac9f-9f5589e20a05"), Description="Assessment of student's progress", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1c723af5-1fff-491c-8c46-e54036cdc63e"), Description="College Readiness", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b2b7e69f-cd17-485e-901f-58ddb59395ed"), Description="Course credit", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1ca9f1e3-4a5e-4bdd-bb55-311bfd88a7ab"), Description="Course requirement", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("bd9994b1-7b75-4381-8646-a53464462a72"), Description="Diagnosis", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("17ac99f7-d51a-437b-8404-ab768c66877b"), Description="Federal accountability", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("e754bc1a-6533-460d-8a1d-373a112bbe33"), Description="Inform local or state policy", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("183c0abc-4e7e-4b97-aed3-44e8d9d94d4f"), Description="Instructional decision", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b65361d1-a1ec-4d00-b637-4fb2aeb1c32e"), Description="Local accountability", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("74e0ae62-8373-458d-a7c9-5d80d671390c"), Description="Local graduation requirement", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("bc81536d-2937-470a-8f13-b29786eb3d54"), Description="Obtain a state- or industry-recognized certificate or license", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b8cc5095-b69f-4bfd-973a-d321bfe0c100"), Description="Obtain postsecondary credit for the course", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("c3b12bcf-abb9-4c08-8ebc-2ab6aab7eec3"), Description="Program eligibility", SortOrder=Convert.ToDecimal("21.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("6325453d-29c1-406b-a102-83980f4a4729"), Description="Program evaluation", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("45cdad2e-a2d8-4a57-9119-86e56d814a30"), Description="Program placement", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("c1142417-baeb-4d02-8fd4-5182878b2253"), Description="Promotion to or retention in a grade or program", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("b5803761-1ffa-4e08-a93d-760cc622a238"), Description="Screening", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("74d713c2-a839-4749-aa61-c3afc29fdc60"), Description="State accountability", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("f35393d4-4451-4153-abae-9ad93aca07ef"), Description="Other", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1ee745eb-c5cb-483d-b441-b2c7574b9cf3"), Description="State graduation requirement", SortOrder=Convert.ToDecimal("32.00") },
       };
   }
}
