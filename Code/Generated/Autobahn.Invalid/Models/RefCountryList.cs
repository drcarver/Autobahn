//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefCountryList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefCountry Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCountryModel"> List
         /// </summary>
        public static List<RefCountryModel> RefCountryList = new List<RefCountryModel>
        {
        };

        /// <summary>
        /// The Reference RefCountry Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCountryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
