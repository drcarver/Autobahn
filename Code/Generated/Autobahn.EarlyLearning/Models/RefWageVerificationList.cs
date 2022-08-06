//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefWageVerificationList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefWageVerification Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefWageVerification"> List
         /// </summary>
        public static List<RefWageVerification> RefWageVerificationList = new List<RefWageVerification>
        {
            new RefWageVerification { Id=Guid.Parse("386d9133-29ee-4e31-b258-58604f668e4c"), Code="01", Description="Verified", Definition="The wage information has been verified.", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageVerification { Id=Guid.Parse("a027b955-a149-4805-90b5-c5c595a939b6"), Code="02", Description="Not verified", Definition="The wage information has NOT been verified.", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageVerification { Id=Guid.Parse("6200f0e7-65b1-40bb-8f37-0923a96b169a"), Code="03", Description="Wage data not present", Definition="Wage data not present.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The RefWageVerification Pick List
         /// </summary>
        public static List<RefWageVerification> RefWageVerificationPickList = new List<RefWageVerification>
        {
            new RefWageVerification { Id=Guid.Parse("386d9133-29ee-4e31-b258-58604f668e4c"), Code="01", Description="Verified", SortOrder=Convert.ToDecimal("1.00") },
            new RefWageVerification { Id=Guid.Parse("a027b955-a149-4805-90b5-c5c595a939b6"), Code="02", Description="Not verified", SortOrder=Convert.ToDecimal("2.00") },
            new RefWageVerification { Id=Guid.Parse("6200f0e7-65b1-40bb-8f37-0923a96b169a"), Code="03", Description="Wage data not present", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
