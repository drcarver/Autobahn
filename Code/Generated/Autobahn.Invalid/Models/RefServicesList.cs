//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefServicesList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefServices Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefServicesModel"> List
         /// </summary>
        public static List<RefServicesModel> RefServicesList = new List<RefServicesModel>
        {
        };

        /// <summary>
        /// The Reference RefServices Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefServicesViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
