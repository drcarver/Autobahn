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
        public static List<RefEducationVerificationMethod> RefEducationVerificationMethodList = new List<RefEducationVerificationMethod> =
        {
            new RefEducationVerificationMethod { Id=Guid.Parse("549012fa-cd16-40d9-ba42-8461b6f70a3f"), Code="Official transcript is the method by which the formal education is verified.", Description="OfficialTranscript", Definition="", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("83b727a0-a47b-440a-86c3-fac952c38b2a"), Code="Transcript copy is the method by which the formal education is verified.", Description="TranscriptCopy", Definition="", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("35c743f7-2e28-46cd-8467-e37ebea06ee4"), Code="Degree copy is the method by which the formal education is verified.", Description="DegreeCopy", Definition="", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("565e9c7d-12fa-40ec-a72a-7a69b58d3170"), Code="Grade report is the method by which the formal education is verified.", Description="GradeReport", Definition="", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("e16e30f2-eef3-4274-b782-09ba167e6bb9"), Code="The method by which the formal education is verified is in a category not yet defined by CEDS.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefEducationVerificationMethod Pick List
         /// </summary>
        public static List<RefEducationVerificationMethod> RefEducationVerificationMethodPickList = new List<RefEducationVerificationMethod> =
        {
            new RefEducationVerificationMethod { Id=Guid.Parse("549012fa-cd16-40d9-ba42-8461b6f70a3f"), Code="Official transcript is the method by which the formal education is verified.", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("83b727a0-a47b-440a-86c3-fac952c38b2a"), Code="Transcript copy is the method by which the formal education is verified.", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("35c743f7-2e28-46cd-8467-e37ebea06ee4"), Code="Degree copy is the method by which the formal education is verified.", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("565e9c7d-12fa-40ec-a72a-7a69b58d3170"), Code="Grade report is the method by which the formal education is verified.", SortOrder=0 },
            new RefEducationVerificationMethod { Id=Guid.Parse("e16e30f2-eef3-4274-b782-09ba167e6bb9"), Code="The method by which the formal education is verified is in a category not yet defined by CEDS.", SortOrder=0 },
       };
   }
}
