//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefAdmissionConsiderationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefAdmissionConsiderationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAdmissionConsiderationType"> List
         /// </summary>
        public static List<RefAdmissionConsiderationType> RefAdmissionConsiderationTypeList = new List<RefAdmissionConsiderationType>
        {
            new RefAdmissionConsiderationType { Id=Guid.Parse("7f4117de-a2db-4487-a8b1-de1b0cada1ac"), Code="SecondarySchoolGPA", Description="Secondary school GPA", Definition="Secondary school GPA is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("4af75915-b47b-402b-b712-186840389a86"), Code="SecondarySchoolRank", Description="Secondary school rank", Definition="Secondary school rank is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("3f098505-2700-42f4-9510-98b9b244d589"), Code="SecondarySchoolRecord", Description="Secondary school record", Definition="Secondary school record is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("82e15274-8502-4bb2-bed6-fc02671e24ea"), Code="CompletionOfCollegePrepProgram", Description="Completion of college-preparatory program", Definition="Completion of college-preparatory program is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("76edaf78-0060-499c-94f5-c9a68391b486"), Code="Recommendations", Description="Recommendations", Definition="Recommendations is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("d548183c-1ec1-4bb3-9377-92d9f457990d"), Code="FormalDemonstrationOfCompetencies", Description="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments)", Definition="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments) is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("8e4baf92-f3db-4c11-b96f-2413d1051da2"), Code="AdmissionTestScores", Description="Admission test scores", Definition="Admission test scores is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("ec0a8ba4-6eee-40da-b432-b95f0bd2c6d1"), Code="SAT_ACT", Description="SAT / ACT", Definition="SAT / ACT is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("de576584-ab9c-4aa2-b66c-5933bcee6fc5"), Code="TOEFL", Description="Test of English as a Foreign Language", Definition="Test of English as a Foreign Language is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("3a93411b-f55a-44ed-828d-6e6e5a525427"), Code="OtherTest", Description="Other Test (ABT, Wonderlic, WISC-III, etc.)", Definition="Other Test (ABT, Wonderlic, WISC-III, etc.) is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("17.00") },
        };

        /// <summary>
        /// The RefAdmissionConsiderationType Pick List
         /// </summary>
        public static List<RefAdmissionConsiderationType> RefAdmissionConsiderationTypePickList = new List<RefAdmissionConsiderationType>
        {
            new RefAdmissionConsiderationType { Id=Guid.Parse("7f4117de-a2db-4487-a8b1-de1b0cada1ac"), Code="SecondarySchoolGPA", Description="Secondary school GPA", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("4af75915-b47b-402b-b712-186840389a86"), Code="SecondarySchoolRank", Description="Secondary school rank", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("3f098505-2700-42f4-9510-98b9b244d589"), Code="SecondarySchoolRecord", Description="Secondary school record", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("82e15274-8502-4bb2-bed6-fc02671e24ea"), Code="CompletionOfCollegePrepProgram", Description="Completion of college-preparatory program", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("76edaf78-0060-499c-94f5-c9a68391b486"), Code="Recommendations", Description="Recommendations", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("d548183c-1ec1-4bb3-9377-92d9f457990d"), Code="FormalDemonstrationOfCompetencies", Description="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments)", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("8e4baf92-f3db-4c11-b96f-2413d1051da2"), Code="AdmissionTestScores", Description="Admission test scores", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("ec0a8ba4-6eee-40da-b432-b95f0bd2c6d1"), Code="SAT_ACT", Description="SAT / ACT", SortOrder=Convert.ToDecimal("13.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("de576584-ab9c-4aa2-b66c-5933bcee6fc5"), Code="TOEFL", Description="Test of English as a Foreign Language", SortOrder=Convert.ToDecimal("15.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("3a93411b-f55a-44ed-828d-6e6e5a525427"), Code="OtherTest", Description="Other Test (ABT, Wonderlic, WISC-III, etc.)", SortOrder=Convert.ToDecimal("17.00") },
       };
   }
}
