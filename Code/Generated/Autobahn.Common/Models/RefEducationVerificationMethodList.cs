//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEducationVerificationMethodList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEducationVerificationMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEducationVerificationMethodModel"> List
         /// </summary>
        public static List<RefEducationVerificationMethodModel> RefEducationVerificationMethodList = new List<RefEducationVerificationMethodModel>
        {
            new RefEducationVerificationMethod { Id=Guid.Parse("62e118e3-2c93-4912-a650-0f05d243521b"), Code="OfficialTranscript", Description="Official transcript", Definition="Official transcript is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("56d6593b-b618-4e45-94e8-227d2081c2b2"), Code="TranscriptCopy", Description="Transcript copy", Definition="Transcript copy is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("a721bca5-1ff8-494e-8504-7d2b78ebd785"), Code="DegreeCopy", Description="Degree copy", Definition="Degree copy is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("d66fc192-f6ee-4f5b-b8a7-264ff8b9559a"), Code="GradeReport", Description="Grade report", Definition="Grade report is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("7.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("29dc7c91-cbeb-489b-8788-524e46f23656"), Code="Other", Description="Other", Definition="The method by which the formal education is verified is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The Reference RefEducationVerificationMethod Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEducationVerificationMethodViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEducationVerificationMethod { Id=Guid.Parse("62e118e3-2c93-4912-a650-0f05d243521b"), Description="Official transcript", SortOrder=Convert.ToDecimal("1.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("56d6593b-b618-4e45-94e8-227d2081c2b2"), Description="Transcript copy", SortOrder=Convert.ToDecimal("3.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("a721bca5-1ff8-494e-8504-7d2b78ebd785"), Description="Degree copy", SortOrder=Convert.ToDecimal("5.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("d66fc192-f6ee-4f5b-b8a7-264ff8b9559a"), Description="Grade report", SortOrder=Convert.ToDecimal("7.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("29dc7c91-cbeb-489b-8788-524e46f23656"), Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
