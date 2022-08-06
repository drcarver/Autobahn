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
        public static List<RefPsEnrollmentType> RefPsEnrollmentTypeList = new List<RefPsEnrollmentType>
        {
            new RefPsEnrollmentType { Id=Guid.Parse("1b38a07a-6e96-418d-8eff-f0fd7ee715e5"), Code="FirstTime", Description="First time at institution, non-transfer in", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: First time at institution, non-transfer in.", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("5c2439fd-7f81-474a-8393-853767fa45aa"), Code="Continuing", Description="Continuing", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Continuing.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("b18963c8-53ed-4042-99eb-055b8ad9a844"), Code="Re-admit", Description="Re-admit", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Re-admit.", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("c4d69c9a-fbc1-4f60-87f6-429d0e66bf3a"), Code="TransferIn", Description="Transfer in", Definition="The person's enrollment type associated with the enrollment award level at the beginning of a term is: Transfer in.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefPsEnrollmentType Pick List
         /// </summary>
        public static List<RefPsEnrollmentType> RefPsEnrollmentTypePickList = new List<RefPsEnrollmentType>
        {
            new RefPsEnrollmentType { Id=Guid.Parse("1b38a07a-6e96-418d-8eff-f0fd7ee715e5"), Code="FirstTime", Description="First time at institution, non-transfer in", SortOrder=Convert.ToDecimal("1.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("5c2439fd-7f81-474a-8393-853767fa45aa"), Code="Continuing", Description="Continuing", SortOrder=Convert.ToDecimal("2.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("b18963c8-53ed-4042-99eb-055b8ad9a844"), Code="Re-admit", Description="Re-admit", SortOrder=Convert.ToDecimal("3.00") },
            new RefPsEnrollmentType { Id=Guid.Parse("c4d69c9a-fbc1-4f60-87f6-429d0e66bf3a"), Code="TransferIn", Description="Transfer in", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
