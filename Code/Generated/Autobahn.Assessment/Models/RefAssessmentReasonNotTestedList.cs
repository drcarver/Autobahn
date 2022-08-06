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
        public static List<RefAssessmentReasonNotTested> RefAssessmentReasonNotTestedList = new List<RefAssessmentReasonNotTested>
        {
            new RefAssessmentReasonNotTested { Id=Guid.Parse("5c472c32-4983-4101-a6de-f7c63ad04dc9"), Code="03451", Description="Absent", Definition="Absent is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("cc7a7424-ea3d-47e7-b94c-797ad117e112"), Code="03455", Description="Disruptive behavior", Definition="Disruptive behavior is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("51907085-6518-4ff0-94c4-a504d755fc95"), Code="03454", Description="Medical waiver", Definition="Medical waiver is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("e91ce630-26a9-455b-9dde-f4a36eea5afa"), Code="03456", Description="Previously passed the examination", Definition="Previously passed the examination is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("202433f8-8a74-4e74-9bd8-e9cffddcc862"), Code="03452", Description="Refusal by parent", Definition="Refusal by parent is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("05831033-b3df-429d-980c-678e012f36bc"), Code="03453", Description="Refusal by student", Definition="Refusal by student is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("aa170888-0e44-4710-a1f4-bced119cff7c"), Code="09999", Description="Other", Definition="The primary reason the student was not tested is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefAssessmentReasonNotTested Pick List
         /// </summary>
        public static List<RefAssessmentReasonNotTested> RefAssessmentReasonNotTestedPickList = new List<RefAssessmentReasonNotTested>
        {
            new RefAssessmentReasonNotTested { Id=Guid.Parse("5c472c32-4983-4101-a6de-f7c63ad04dc9"), Code="03451", Description="Absent", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("cc7a7424-ea3d-47e7-b94c-797ad117e112"), Code="03455", Description="Disruptive behavior", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("51907085-6518-4ff0-94c4-a504d755fc95"), Code="03454", Description="Medical waiver", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("e91ce630-26a9-455b-9dde-f4a36eea5afa"), Code="03456", Description="Previously passed the examination", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("202433f8-8a74-4e74-9bd8-e9cffddcc862"), Code="03452", Description="Refusal by parent", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("05831033-b3df-429d-980c-678e012f36bc"), Code="03453", Description="Refusal by student", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("aa170888-0e44-4710-a1f4-bced119cff7c"), Code="09999", Description="Other", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
