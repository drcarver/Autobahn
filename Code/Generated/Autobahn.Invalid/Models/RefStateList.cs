//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefStateList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefState Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefStateModel"> List
         /// </summary>
        public static List<RefStateModel> RefStateList = new List<RefStateModel>
        {
        };

        /// <summary>
        /// The Reference RefState Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefStateViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
