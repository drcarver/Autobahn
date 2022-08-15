//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   RefRaceList.cs
//**********************************************************

using Autobahn.Common.ViewModels;

namespace Invalid.Models
{
     /// <summary>
     /// The list of RefRace Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRaceModel"> List
         /// </summary>
        public static List<RefRaceModel> RefRaceList = new List<RefRaceModel>
        {
        };

        /// <summary>
        /// The Reference RefRace Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRaceViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
       };
   }
}
