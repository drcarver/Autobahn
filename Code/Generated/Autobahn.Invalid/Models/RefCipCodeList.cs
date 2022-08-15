//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefCipCodeList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefCipCode Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCipCodeModel"> List
         /// </summary>
        public static List<RefCipCodeModel> RefCipCodeList = new List<RefCipCodeModel>
        {
        };

        /// <summary>
        /// The Reference RefCipCode Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCipCodeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
