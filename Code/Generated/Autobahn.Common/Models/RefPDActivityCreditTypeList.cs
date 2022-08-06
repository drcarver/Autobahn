//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefPDActivityCreditTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefPDActivityCreditType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefPDActivityCreditType"> List
         /// </summary>
        public static List<RefPDActivityCreditType> RefPDActivityCreditTypeList = new List<RefPDActivityCreditType>
        {
            new RefPDActivityCreditType { Id=Guid.Parse("09bd4fcc-fec5-44c4-8b05-6cb2fb11b0a3"), Code="Hours", Description="Hours", Definition="Hours is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("787b837d-4bbf-4037-b612-7b072cbe9590"), Code="CEUs", Description="Continuing Education Units", Definition="Continuing Education Units is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("1aafe570-9729-4e23-a956-aa9249bff860"), Code="QuarterCredits", Description="Quarter credits", Definition="Quarter credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("84c943f2-ca63-416d-a9fd-ecdc87e36016"), Code="SemesterCredits", Description="Semester credits", Definition="Semester credits is the type of professional development credit awarded.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The RefPDActivityCreditType Pick List
         /// </summary>
        public static List<RefPDActivityCreditType> RefPDActivityCreditTypePickList = new List<RefPDActivityCreditType>
        {
            new RefPDActivityCreditType { Id=Guid.Parse("09bd4fcc-fec5-44c4-8b05-6cb2fb11b0a3"), Code="Hours", Description="Hours", SortOrder=Convert.ToDecimal("2.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("787b837d-4bbf-4037-b612-7b072cbe9590"), Code="CEUs", Description="Continuing Education Units", SortOrder=Convert.ToDecimal("4.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("1aafe570-9729-4e23-a956-aa9249bff860"), Code="QuarterCredits", Description="Quarter credits", SortOrder=Convert.ToDecimal("6.00") },
            new RefPDActivityCreditType { Id=Guid.Parse("84c943f2-ca63-416d-a9fd-ecdc87e36016"), Code="SemesterCredits", Description="Semester credits", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
