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
        /// The complete <see cref="RefAssessmentPurpose"> List
         /// </summary>
        public static List<RefAssessmentPurpose> RefAssessmentPurposeList = new List<RefAssessmentPurpose>
        {
            new RefAssessmentPurpose { Id=Guid.Parse("37c559a8-293f-4e81-a4bb-c263e6d5ff45"), Code="00050", Description="Admission", Definition="Admission is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("7efc18a1-6885-4f4e-9090-365ec6122637"), Code="00051", Description="Assessment of student's progress", Definition="Assessment of student's progress is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("e83dfc84-7c52-4f54-b9b9-43246a884655"), Code="73055", Description="College Readiness", Definition="College Readiness is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("ebc424ca-e525-4d0e-ac07-2cfe7c504e2d"), Code="00063", Description="Course credit", Definition="Course credit is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("56c74955-bc1c-499d-a272-9e9516e39f1a"), Code="00064", Description="Course requirement", Definition="Course requirement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("cf5a419c-21a5-4553-a25f-e951c84681c8"), Code="73069", Description="Diagnosis", Definition="Diagnosis is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("8d63d37c-e7f2-4bd3-91d1-15ef63ebe16d"), Code="03459", Description="Federal accountability", Definition="Federal accountability is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("0ca2d03e-423e-48e8-b582-1e96a7cfc28e"), Code="73068", Description="Inform local or state policy", Definition="Inform local or state policy is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("0bb8e21d-554d-4c38-a1be-a8f08b0f376f"), Code="00055", Description="Instructional decision", Definition="Instructional decision is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("2d465e85-865a-49ac-9ac3-dc31228c50a2"), Code="03457", Description="Local accountability", Definition="Local accountability is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("88f05111-cad1-4012-ba08-3dffa121a6f5"), Code="02404", Description="Local graduation requirement", Definition="Local graduation requirement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("e5ce037a-a9cf-43d3-a4d8-03f76d0289af"), Code="73042", Description="Obtain a state- or industry-recognized certificate or license", Definition="Obtain a state- or industry-recognized certificate or license is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("27fd1fdd-71c5-4e5d-a398-96e0ae542ac8"), Code="73043", Description="Obtain postsecondary credit for the course", Definition="Obtain postsecondary credit for the course is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("3bcd5cba-8d6f-4a8f-809c-d267a13d5d17"), Code="73067", Description="Program eligibility", Definition="Program eligibility is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("21.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("5a186688-b00b-4905-9c1c-8ee64f461332"), Code="00057", Description="Program evaluation", Definition="Program evaluation is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("6f5748fa-442d-4f7b-a36a-74aa598f385e"), Code="00058", Description="Program placement", Definition="Program placement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("825364b4-c6bf-46e2-b6ce-0d7cee89897c"), Code="00062", Description="Promotion to or retention in a grade or program", Definition="Promotion to or retention in a grade or program is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1f362d5f-0c9d-4056-8081-e2b4a18c4218"), Code="00061", Description="Screening", Definition="Screening is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("354c5dc6-1d87-406b-b368-fa00d05ec27d"), Code="03458", Description="State accountability", Definition="State accountability is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("19292991-4db6-4ad1-b8db-6d157758ef01"), Code="09999", Description="Other", Definition="Other is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("153f6076-79b3-482d-8792-529c6893eebc"), Code="00054", Description="State graduation requirement", Definition="State graduation requirement is specified as the reason for which an assessment is designed or delivered.", SortOrder=Convert.ToDecimal("32.00") },
        };

        /// <summary>
        /// The RefAssessmentPurpose Pick List
         /// </summary>
        public static List<RefAssessmentPurpose> RefAssessmentPurposePickList = new List<RefAssessmentPurpose>
        {
            new RefAssessmentPurpose { Id=Guid.Parse("37c559a8-293f-4e81-a4bb-c263e6d5ff45"), Code="00050", Description="Admission", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("7efc18a1-6885-4f4e-9090-365ec6122637"), Code="00051", Description="Assessment of student's progress", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("e83dfc84-7c52-4f54-b9b9-43246a884655"), Code="73055", Description="College Readiness", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("ebc424ca-e525-4d0e-ac07-2cfe7c504e2d"), Code="00063", Description="Course credit", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("56c74955-bc1c-499d-a272-9e9516e39f1a"), Code="00064", Description="Course requirement", SortOrder=Convert.ToDecimal("8.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("cf5a419c-21a5-4553-a25f-e951c84681c8"), Code="73069", Description="Diagnosis", SortOrder=Convert.ToDecimal("9.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("8d63d37c-e7f2-4bd3-91d1-15ef63ebe16d"), Code="03459", Description="Federal accountability", SortOrder=Convert.ToDecimal("10.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("0ca2d03e-423e-48e8-b582-1e96a7cfc28e"), Code="73068", Description="Inform local or state policy", SortOrder=Convert.ToDecimal("11.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("0bb8e21d-554d-4c38-a1be-a8f08b0f376f"), Code="00055", Description="Instructional decision", SortOrder=Convert.ToDecimal("12.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("2d465e85-865a-49ac-9ac3-dc31228c50a2"), Code="03457", Description="Local accountability", SortOrder=Convert.ToDecimal("14.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("88f05111-cad1-4012-ba08-3dffa121a6f5"), Code="02404", Description="Local graduation requirement", SortOrder=Convert.ToDecimal("16.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("e5ce037a-a9cf-43d3-a4d8-03f76d0289af"), Code="73042", Description="Obtain a state- or industry-recognized certificate or license", SortOrder=Convert.ToDecimal("18.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("27fd1fdd-71c5-4e5d-a398-96e0ae542ac8"), Code="73043", Description="Obtain postsecondary credit for the course", SortOrder=Convert.ToDecimal("20.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("3bcd5cba-8d6f-4a8f-809c-d267a13d5d17"), Code="73067", Description="Program eligibility", SortOrder=Convert.ToDecimal("21.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("5a186688-b00b-4905-9c1c-8ee64f461332"), Code="00057", Description="Program evaluation", SortOrder=Convert.ToDecimal("22.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("6f5748fa-442d-4f7b-a36a-74aa598f385e"), Code="00058", Description="Program placement", SortOrder=Convert.ToDecimal("24.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("825364b4-c6bf-46e2-b6ce-0d7cee89897c"), Code="00062", Description="Promotion to or retention in a grade or program", SortOrder=Convert.ToDecimal("26.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("1f362d5f-0c9d-4056-8081-e2b4a18c4218"), Code="00061", Description="Screening", SortOrder=Convert.ToDecimal("28.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("354c5dc6-1d87-406b-b368-fa00d05ec27d"), Code="03458", Description="State accountability", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("19292991-4db6-4ad1-b8db-6d157758ef01"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("30.00") },
            new RefAssessmentPurpose { Id=Guid.Parse("153f6076-79b3-482d-8792-529c6893eebc"), Code="00054", Description="State graduation requirement", SortOrder=Convert.ToDecimal("32.00") },
       };
   }
}
