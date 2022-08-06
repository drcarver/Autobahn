//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProofOfResidencyTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProofOfResidencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProofOfResidencyType"> List
         /// </summary>
        public static List<RefProofOfResidencyType> RefProofOfResidencyTypeList = new List<RefProofOfResidencyType>
        {
            new RefProofOfResidencyType { Id=Guid.Parse("403b775a-8987-43c6-9f91-2ce48e0040b9"), Code="BankStatement", Description="Bank statement", Definition="Bank statement was used as proof of residency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("dd6e7653-0053-4057-a6a6-92a7304a8a1d"), Code="UtilityBill", Description="Utility bill", Definition="Utility bill was used as proof of residency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("07d0b190-0312-4209-b855-12917d03ffd4"), Code="Lease", Description="Lease", Definition="Lease was used as proof of residency.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("c54f92f6-a267-4bf1-a564-acaaf6746236"), Code="Other", Description="Other", Definition="Other was used as proof of residency.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The RefProofOfResidencyType Pick List
         /// </summary>
        public static List<RefProofOfResidencyType> RefProofOfResidencyTypePickList = new List<RefProofOfResidencyType>
        {
            new RefProofOfResidencyType { Id=Guid.Parse("403b775a-8987-43c6-9f91-2ce48e0040b9"), Code="BankStatement", Description="Bank statement", SortOrder=Convert.ToDecimal("1.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("dd6e7653-0053-4057-a6a6-92a7304a8a1d"), Code="UtilityBill", Description="Utility bill", SortOrder=Convert.ToDecimal("2.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("07d0b190-0312-4209-b855-12917d03ffd4"), Code="Lease", Description="Lease", SortOrder=Convert.ToDecimal("3.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("c54f92f6-a267-4bf1-a564-acaaf6746236"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
