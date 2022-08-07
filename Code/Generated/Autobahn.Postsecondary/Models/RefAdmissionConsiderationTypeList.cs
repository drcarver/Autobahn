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
        /// The complete <see cref="RefAdmissionConsiderationTypeModel"> List
         /// </summary>
        public static List<RefAdmissionConsiderationTypeModel> RefAdmissionConsiderationTypeList = new List<RefAdmissionConsiderationTypeModel>
        {
            new RefAdmissionConsiderationType { Id=Guid.Parse("6fdff2fd-fd55-496c-85dd-d4854ec66bc5"), Code="SecondarySchoolGPA", Description="Secondary school GPA", Definition="Secondary school GPA is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("01f2bc59-7dc0-4e2e-87fd-1c7ba871bdd0"), Code="SecondarySchoolRank", Description="Secondary school rank", Definition="Secondary school rank is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("b9c82e9f-16ed-4031-b7c6-e311f360b54d"), Code="SecondarySchoolRecord", Description="Secondary school record", Definition="Secondary school record is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("9ff4ea4e-e854-48f9-bbdf-05ea14fdf442"), Code="CompletionOfCollegePrepProgram", Description="Completion of college-preparatory program", Definition="Completion of college-preparatory program is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("c83cacd2-f7f6-421c-8780-78340975ce9b"), Code="Recommendations", Description="Recommendations", Definition="Recommendations is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("2eb79235-1885-441f-a880-359381eba34d"), Code="FormalDemonstrationOfCompetencies", Description="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments)", Definition="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments) is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("69d8b072-6ddc-44a0-a6bc-b40a71e860ad"), Code="AdmissionTestScores", Description="Admission test scores", Definition="Admission test scores is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("81a098f2-319e-4627-a612-bafeb70e98bb"), Code="SAT_ACT", Description="SAT / ACT", Definition="SAT / ACT is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("13.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("8c4f3dec-15c0-4412-9103-f207d7757a0a"), Code="TOEFL", Description="Test of English as a Foreign Language", Definition="Test of English as a Foreign Language is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("15.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("f04a69f1-a7d9-4e1f-b19c-423be0365035"), Code="OtherTest", Description="Other Test (ABT, Wonderlic, WISC-III, etc.)", Definition="Other Test (ABT, Wonderlic, WISC-III, etc.) is specified as a type of admission consideration used at an institution during the selection process.", SortOrder=Convert.ToDecimal("17.00") },
        };

        /// <summary>
        /// The Reference RefAdmissionConsiderationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAdmissionConsiderationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAdmissionConsiderationType { Id=Guid.Parse("6fdff2fd-fd55-496c-85dd-d4854ec66bc5"), Description="Secondary school GPA", SortOrder=Convert.ToDecimal("1.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("01f2bc59-7dc0-4e2e-87fd-1c7ba871bdd0"), Description="Secondary school rank", SortOrder=Convert.ToDecimal("2.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("b9c82e9f-16ed-4031-b7c6-e311f360b54d"), Description="Secondary school record", SortOrder=Convert.ToDecimal("3.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("9ff4ea4e-e854-48f9-bbdf-05ea14fdf442"), Description="Completion of college-preparatory program", SortOrder=Convert.ToDecimal("5.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("c83cacd2-f7f6-421c-8780-78340975ce9b"), Description="Recommendations", SortOrder=Convert.ToDecimal("7.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("2eb79235-1885-441f-a880-359381eba34d"), Description="Formal demonstration of competencies (e.g., portfolios, certificates of mastery, assessment instruments)", SortOrder=Convert.ToDecimal("9.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("69d8b072-6ddc-44a0-a6bc-b40a71e860ad"), Description="Admission test scores", SortOrder=Convert.ToDecimal("11.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("81a098f2-319e-4627-a612-bafeb70e98bb"), Description="SAT / ACT", SortOrder=Convert.ToDecimal("13.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("8c4f3dec-15c0-4412-9103-f207d7757a0a"), Description="Test of English as a Foreign Language", SortOrder=Convert.ToDecimal("15.00") },
            new RefAdmissionConsiderationType { Id=Guid.Parse("f04a69f1-a7d9-4e1f-b19c-423be0365035"), Description="Other Test (ABT, Wonderlic, WISC-III, etc.)", SortOrder=Convert.ToDecimal("17.00") },
       };
   }
}
