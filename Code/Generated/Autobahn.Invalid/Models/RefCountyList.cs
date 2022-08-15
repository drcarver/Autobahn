//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefCountyList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefCounty Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCountyModel"> List
         /// </summary>
        public static List<RefCountyModel> RefCountyList = new List<RefCountyModel>
        {
        };

        /// <summary>
        /// The Reference RefCounty Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCountyViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
