//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefPsEnrollmentTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefPsEnrollmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPsEnrollmentType"> List
         /// </summary>
        public static List<RefPsEnrollmentType> RefPsEnrollmentTypeList = new List<RefPsEnrollmentType> =
        {
            new RefPsEnrollmentType { Id=Guid.Parse("69b58989-0cc2-49f7-b970-f8aac2acfbc5"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: First time at institution, non-transfer in.", Description="FirstTime", Definition="", SortOrder=0 },
            new RefPsEnrollmentType { Id=Guid.Parse("89a1d011-8681-4eac-ab3c-305fd5bbb43d"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Continuing.", Description="Continuing", Definition="", SortOrder=0 },
            new RefPsEnrollmentType { Id=Guid.Parse("977bd662-1a6e-4c86-b80d-34055368bbca"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Re-admit.", Description="Re-admit", Definition="", SortOrder=0 },
            new RefPsEnrollmentType { Id=Guid.Parse("a7209df8-0fb2-422f-b25e-7aa0bb4c3372"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Transfer in.", Description="TransferIn", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefPsEnrollmentType Pick List
         /// </summary>
        public static List<RefPsEnrollmentType> RefPsEnrollmentTypePickList = new List<RefPsEnrollmentType> =
        {
            new RefPsEnrollmentType { Id=Guid.Parse("69b58989-0cc2-49f7-b970-f8aac2acfbc5"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: First time at institution, non-transfer in.", SortOrder=0 },
            new RefPsEnrollmentType { Id=Guid.Parse("89a1d011-8681-4eac-ab3c-305fd5bbb43d"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Continuing.", SortOrder=0 },
            new RefPsEnrollmentType { Id=Guid.Parse("977bd662-1a6e-4c86-b80d-34055368bbca"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Re-admit.", SortOrder=0 },
            new RefPsEnrollmentType { Id=Guid.Parse("a7209df8-0fb2-422f-b25e-7aa0bb4c3372"), Code="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Transfer in.", SortOrder=0 },
       };
   }
}
