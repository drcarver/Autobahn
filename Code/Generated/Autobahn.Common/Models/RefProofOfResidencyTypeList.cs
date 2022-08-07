//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefProofOfResidencyTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefProofOfResidencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefProofOfResidencyTypeModel"> List
         /// </summary>
        public static List<RefProofOfResidencyTypeModel> RefProofOfResidencyTypeList = new List<RefProofOfResidencyTypeModel>
        {
            new RefProofOfResidencyType { Id=Guid.Parse("b72b226d-7e5c-4fc0-8116-f2f04a9b1fa6"), Code="BankStatement", Description="Bank statement", Definition="Bank statement was used as proof of residency.", SortOrder=Convert.ToDecimal("1.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("abae65a7-8f86-4612-b5b7-86696b62fa85"), Code="UtilityBill", Description="Utility bill", Definition="Utility bill was used as proof of residency.", SortOrder=Convert.ToDecimal("2.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("1e437d21-4a29-4105-9e0c-97be98d0e258"), Code="Lease", Description="Lease", Definition="Lease was used as proof of residency.", SortOrder=Convert.ToDecimal("3.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("fd566fa9-b707-4093-bf51-09d07b4ae1d7"), Code="Other", Description="Other", Definition="Other was used as proof of residency.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefProofOfResidencyType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefProofOfResidencyTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefProofOfResidencyType { Id=Guid.Parse("b72b226d-7e5c-4fc0-8116-f2f04a9b1fa6"), Description="Bank statement", SortOrder=Convert.ToDecimal("1.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("abae65a7-8f86-4612-b5b7-86696b62fa85"), Description="Utility bill", SortOrder=Convert.ToDecimal("2.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("1e437d21-4a29-4105-9e0c-97be98d0e258"), Description="Lease", SortOrder=Convert.ToDecimal("3.00") },
            new RefProofOfResidencyType { Id=Guid.Parse("fd566fa9-b707-4093-bf51-09d07b4ae1d7"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
