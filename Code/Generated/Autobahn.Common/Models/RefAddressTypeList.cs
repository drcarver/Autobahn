//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefAddressTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefAddressType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAddressTypeModel"> List
         /// </summary>
        public static List<RefAddressTypeModel> RefAddressTypeList = new List<RefAddressTypeModel>
        {
            new RefAddressType { Id=Guid.Parse("781ec16a-a4cc-493d-b3a3-23f0ee88b3ff"), Code="000010", Description="Address Type for Learner or Family", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefAddressType { Id=Guid.Parse("46b186d6-5c4d-4566-9781-67df8bf8869a"), Code="000722", Description="Address Type for Staff", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefAddressType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAddressTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAddressType { Id=Guid.Parse("781ec16a-a4cc-493d-b3a3-23f0ee88b3ff"), Description="Address Type for Learner or Family", SortOrder=Convert.ToDecimal("") },
            new RefAddressType { Id=Guid.Parse("46b186d6-5c4d-4566-9781-67df8bf8869a"), Description="Address Type for Staff", SortOrder=Convert.ToDecimal("") },
       };
   }
}
