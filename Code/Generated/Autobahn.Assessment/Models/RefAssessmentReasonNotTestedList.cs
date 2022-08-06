//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAssessmentReasonNotTestedList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAssessmentReasonNotTested Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAssessmentReasonNotTested"> List
         /// </summary>
        public static List<RefAssessmentReasonNotTested> RefAssessmentReasonNotTestedList = new List<RefAssessmentReasonNotTested> =
        {
            new RefAssessmentReasonNotTested { Id=Guid.Parse("d39bbf8a-2882-4913-bab7-a3626c00451d"), Code="Absent is the primary reason the student was not tested.", Description="03451", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("eb803c29-faeb-4e10-aaf9-32a021e40b06"), Code="Disruptive behavior is the primary reason the student was not tested.", Description="03455", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("9e494b40-8e09-4e9f-a9c5-43d1521d34a4"), Code="Medical waiver is the primary reason the student was not tested.", Description="03454", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("43c485c4-76ef-47da-af77-92ae636f7b9b"), Code="Previously passed the examination is the primary reason the student was not tested.", Description="03456", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("b41b9891-d00d-4f98-9e6c-2e50cb207bb1"), Code="Refusal by parent is the primary reason the student was not tested.", Description="03452", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("118ee4cf-1f30-4785-9588-c403254f1fb8"), Code="Refusal by student is the primary reason the student was not tested.", Description="03453", Definition="", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("f51585cd-1c2f-418d-9679-6acb2cc0dbb1"), Code="The primary reason the student was not tested is in a category not yet defined in CEDS.", Description="09999", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefAssessmentReasonNotTested Pick List
         /// </summary>
        public static List<RefAssessmentReasonNotTested> RefAssessmentReasonNotTestedPickList = new List<RefAssessmentReasonNotTested> =
        {
            new RefAssessmentReasonNotTested { Id=Guid.Parse("d39bbf8a-2882-4913-bab7-a3626c00451d"), Code="Absent is the primary reason the student was not tested.", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("eb803c29-faeb-4e10-aaf9-32a021e40b06"), Code="Disruptive behavior is the primary reason the student was not tested.", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("9e494b40-8e09-4e9f-a9c5-43d1521d34a4"), Code="Medical waiver is the primary reason the student was not tested.", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("43c485c4-76ef-47da-af77-92ae636f7b9b"), Code="Previously passed the examination is the primary reason the student was not tested.", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("b41b9891-d00d-4f98-9e6c-2e50cb207bb1"), Code="Refusal by parent is the primary reason the student was not tested.", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("118ee4cf-1f30-4785-9588-c403254f1fb8"), Code="Refusal by student is the primary reason the student was not tested.", SortOrder=0 },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("f51585cd-1c2f-418d-9679-6acb2cc0dbb1"), Code="The primary reason the student was not tested is in a category not yet defined in CEDS.", SortOrder=0 },
       };
   }
}
