//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployedAfterExitList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmployedAfterExit Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmployedAfterExitModel"> List
         /// </summary>
        public static List<RefEmployedAfterExitModel> RefEmployedAfterExitList = new List<RefEmployedAfterExitModel>
        {
            new RefEmployedAfterExit { Id=Guid.Parse("2b3428ea-adb1-471f-837d-6a24c4dd3da1"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedAfterExit { Id=Guid.Parse("9f52a1c5-9970-4581-af0c-ca93f73b9199"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefEmployedAfterExit Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEmployedAfterExitViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEmployedAfterExit { Id=Guid.Parse("2b3428ea-adb1-471f-837d-6a24c4dd3da1"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedAfterExit { Id=Guid.Parse("9f52a1c5-9970-4581-af0c-ca93f73b9199"), Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
