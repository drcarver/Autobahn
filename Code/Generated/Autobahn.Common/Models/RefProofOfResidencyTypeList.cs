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
        public static List<RefProofOfResidencyType> RefProofOfResidencyTypeList = new List<RefProofOfResidencyType> =
        {
            new RefProofOfResidencyType { Id=Guid.Parse("3bdebdee-416c-4ba7-a06f-6559000d6ae8"), Code="Bank statement was used as proof of residency.", Description="BankStatement", Definition="", SortOrder=0 },
            new RefProofOfResidencyType { Id=Guid.Parse("b1205797-5767-47e3-9e00-79c0dad4e428"), Code="Utility bill was used as proof of residency.", Description="UtilityBill", Definition="", SortOrder=0 },
            new RefProofOfResidencyType { Id=Guid.Parse("916580ed-1b74-47ae-b33e-44208d878e27"), Code="Lease was used as proof of residency.", Description="Lease", Definition="", SortOrder=0 },
            new RefProofOfResidencyType { Id=Guid.Parse("4ee74e42-7917-4849-b0e9-72966e756b03"), Code="Other was used as proof of residency.", Description="Other", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefProofOfResidencyType Pick List
         /// </summary>
        public static List<RefProofOfResidencyType> RefProofOfResidencyTypePickList = new List<RefProofOfResidencyType> =
        {
            new RefProofOfResidencyType { Id=Guid.Parse("3bdebdee-416c-4ba7-a06f-6559000d6ae8"), Code="Bank statement was used as proof of residency.", SortOrder=0 },
            new RefProofOfResidencyType { Id=Guid.Parse("b1205797-5767-47e3-9e00-79c0dad4e428"), Code="Utility bill was used as proof of residency.", SortOrder=0 },
            new RefProofOfResidencyType { Id=Guid.Parse("916580ed-1b74-47ae-b33e-44208d878e27"), Code="Lease was used as proof of residency.", SortOrder=0 },
            new RefProofOfResidencyType { Id=Guid.Parse("4ee74e42-7917-4849-b0e9-72966e756b03"), Code="Other was used as proof of residency.", SortOrder=0 },
       };
   }
}
