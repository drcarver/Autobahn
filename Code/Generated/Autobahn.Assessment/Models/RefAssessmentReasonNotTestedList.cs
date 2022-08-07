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
        /// The complete <see cref="RefAssessmentReasonNotTestedModel"> List
         /// </summary>
        public static List<RefAssessmentReasonNotTestedModel> RefAssessmentReasonNotTestedList = new List<RefAssessmentReasonNotTestedModel>
        {
            new RefAssessmentReasonNotTested { Id=Guid.Parse("858bf9b9-c4af-4b12-8211-c51233de5d16"), Code="03451", Description="Absent", Definition="Absent is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("58c9a312-4366-4a8f-899e-81734119c548"), Code="03455", Description="Disruptive behavior", Definition="Disruptive behavior is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("129a3c62-36f8-4395-a268-869278eef8dd"), Code="03454", Description="Medical waiver", Definition="Medical waiver is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("e7780d32-e08e-40f3-91e9-6a949344564d"), Code="03456", Description="Previously passed the examination", Definition="Previously passed the examination is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("cd3afa7c-4a01-4c98-8f76-251b48d2693d"), Code="03452", Description="Refusal by parent", Definition="Refusal by parent is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("687427de-a495-4b7d-bc9f-0e9a0df287f1"), Code="03453", Description="Refusal by student", Definition="Refusal by student is the primary reason the student was not tested.", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("064eadbc-eb5c-4764-90df-c54f19be360b"), Code="09999", Description="Other", Definition="The primary reason the student was not tested is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefAssessmentReasonNotTested Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAssessmentReasonNotTestedViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAssessmentReasonNotTested { Id=Guid.Parse("858bf9b9-c4af-4b12-8211-c51233de5d16"), Description="Absent", SortOrder=Convert.ToDecimal("1.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("58c9a312-4366-4a8f-899e-81734119c548"), Description="Disruptive behavior", SortOrder=Convert.ToDecimal("2.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("129a3c62-36f8-4395-a268-869278eef8dd"), Description="Medical waiver", SortOrder=Convert.ToDecimal("3.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("e7780d32-e08e-40f3-91e9-6a949344564d"), Description="Previously passed the examination", SortOrder=Convert.ToDecimal("4.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("cd3afa7c-4a01-4c98-8f76-251b48d2693d"), Description="Refusal by parent", SortOrder=Convert.ToDecimal("5.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("687427de-a495-4b7d-bc9f-0e9a0df287f1"), Description="Refusal by student", SortOrder=Convert.ToDecimal("6.00") },
            new RefAssessmentReasonNotTested { Id=Guid.Parse("064eadbc-eb5c-4764-90df-c54f19be360b"), Description="Other", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
