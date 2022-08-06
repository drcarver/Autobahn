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
        public static List<RefAdmissionConsiderationType> RefAdmissionConsiderationTypeList = new List<RefAdmissionConsiderationType> =
        {
            new RefAdmissionConsiderationType { Id=Guid.Parse("11d89cfc-3dd5-4ebe-a8c0-f20bd5979728"), Code="Secondary school GPA is specified as a type of admission consideration used at an institution during the selection process.", Description="SecondarySchoolGPA", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("eacba65c-0ad1-4e8c-8348-35f1fd4015ab"), Code="Secondary school rank is specified as a type of admission consideration used at an institution during the selection process.", Description="SecondarySchoolRank", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("73326023-b126-4227-83eb-1ab55bafb441"), Code="Secondary school record is specified as a type of admission consideration used at an institution during the selection process.", Description="SecondarySchoolRecord", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("a5bc360c-7bc1-4d9d-aa5e-16067744b4f3"), Code="Completion of college-preparatory program is specified as a type of admission consideration used at an institution during the selection process.", Description="CompletionOfCollegePrepProgram", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("714161b9-f7d1-4195-b3df-0d68628dc99e"), Code="Recommendations is specified as a type of admission consideration used at an institution during the selection process.", Description="Recommendations", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("9d5e6cdf-f181-487e-b7b0-257dc9956643"), Code="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments) is specified as a type of admission consideration used at an institution during the selection process.", Description="FormalDemonstrationOfCompetencies", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("faa1b090-52fc-4ecf-8f83-8a3e51c56329"), Code="Admission test scores is specified as a type of admission consideration used at an institution during the selection process.", Description="AdmissionTestScores", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("988ebead-a1f3-458f-873e-57f297d3f08b"), Code="SAT / ACT is specified as a type of admission consideration used at an institution during the selection process.", Description="SAT_ACT", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("81f835f7-eb2b-44dc-9c42-6dafc3064237"), Code="Test of English as a Foreign Language is specified as a type of admission consideration used at an institution during the selection process.", Description="TOEFL", Definition="", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("8e98cb39-d631-4a3f-ba1d-3f3b62f66f4e"), Code="Other Test (ABT, Wonderlic, WISC-III, etc.) is specified as a type of admission consideration used at an institution during the selection process.", Description="OtherTest", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAdmissionConsiderationType Pick List
         /// </summary>
        public static List<RefAdmissionConsiderationType> RefAdmissionConsiderationTypePickList = new List<RefAdmissionConsiderationType> =
        {
            new RefAdmissionConsiderationType { Id=Guid.Parse("11d89cfc-3dd5-4ebe-a8c0-f20bd5979728"), Code="Secondary school GPA is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("eacba65c-0ad1-4e8c-8348-35f1fd4015ab"), Code="Secondary school rank is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("73326023-b126-4227-83eb-1ab55bafb441"), Code="Secondary school record is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("a5bc360c-7bc1-4d9d-aa5e-16067744b4f3"), Code="Completion of college-preparatory program is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("714161b9-f7d1-4195-b3df-0d68628dc99e"), Code="Recommendations is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("9d5e6cdf-f181-487e-b7b0-257dc9956643"), Code="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments) is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("faa1b090-52fc-4ecf-8f83-8a3e51c56329"), Code="Admission test scores is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("988ebead-a1f3-458f-873e-57f297d3f08b"), Code="SAT / ACT is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("81f835f7-eb2b-44dc-9c42-6dafc3064237"), Code="Test of English as a Foreign Language is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
            new RefAdmissionConsiderationType { Id=Guid.Parse("8e98cb39-d631-4a3f-ba1d-3f3b62f66f4e"), Code="Other Test (ABT, Wonderlic, WISC-III, etc.) is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=0 },
       };
   }
}
