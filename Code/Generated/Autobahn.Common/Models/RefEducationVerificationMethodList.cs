//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEducationVerificationMethodList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEducationVerificationMethod Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEducationVerificationMethod"> List
         /// </summary>
        public static List<RefEducationVerificationMethod> RefEducationVerificationMethodList = new List<RefEducationVerificationMethod>
        {
            new RefEducationVerificationMethod { Id=Guid.Parse("bdd4ff4e-7302-4d94-b808-c1abb762c831"), Code="OfficialTranscript", Description="Official transcript", Definition="Official transcript is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("a36a4eda-7d0e-4d8c-8c8b-fa66cddd2a1a"), Code="TranscriptCopy", Description="Transcript copy", Definition="Transcript copy is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("b0e359c4-2414-41df-bad4-ceaf4f854988"), Code="DegreeCopy", Description="Degree copy", Definition="Degree copy is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("5.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("f8a6e382-7090-4f78-813a-54fbd87ea29f"), Code="GradeReport", Description="Grade report", Definition="Grade report is the method by which the formal education is verified.", SortOrder=Convert.ToDecimal("7.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("3ac0f323-4cde-40f5-97d7-705850037419"), Code="Other", Description="Other", Definition="The method by which the formal education is verified is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("9.00") },
        };

        /// <summary>
        /// The RefEducationVerificationMethod Pick List
         /// </summary>
        public static List<RefEducationVerificationMethod> RefEducationVerificationMethodPickList = new List<RefEducationVerificationMethod>
        {
            new RefEducationVerificationMethod { Id=Guid.Parse("bdd4ff4e-7302-4d94-b808-c1abb762c831"), Code="OfficialTranscript", Description="Official transcript", SortOrder=Convert.ToDecimal("1.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("a36a4eda-7d0e-4d8c-8c8b-fa66cddd2a1a"), Code="TranscriptCopy", Description="Transcript copy", SortOrder=Convert.ToDecimal("3.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("b0e359c4-2414-41df-bad4-ceaf4f854988"), Code="DegreeCopy", Description="Degree copy", SortOrder=Convert.ToDecimal("5.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("f8a6e382-7090-4f78-813a-54fbd87ea29f"), Code="GradeReport", Description="Grade report", SortOrder=Convert.ToDecimal("7.00") },
            new RefEducationVerificationMethod { Id=Guid.Parse("3ac0f323-4cde-40f5-97d7-705850037419"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("9.00") },
       };
   }
}
