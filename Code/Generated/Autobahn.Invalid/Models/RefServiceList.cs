//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefServiceList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefService Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefServiceModel"> List
         /// </summary>
        public static List<RefServiceModel> RefServiceList = new List<RefServiceModel>
        {
        };

        /// <summary>
        /// The Reference RefService Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefServiceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
