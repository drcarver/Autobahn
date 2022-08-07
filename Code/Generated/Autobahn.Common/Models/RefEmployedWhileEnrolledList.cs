//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmployedWhileEnrolledList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmployedWhileEnrolled Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmployedWhileEnrolledModel"> List
         /// </summary>
        public static List<RefEmployedWhileEnrolledModel> RefEmployedWhileEnrolledList = new List<RefEmployedWhileEnrolledModel>
        {
            new RefEmployedWhileEnrolled { Id=Guid.Parse("cb307e2e-83c0-4bc1-b576-e76e1d1d60db"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedWhileEnrolled { Id=Guid.Parse("a63690db-6dd1-4f6b-9049-1c750da41e62"), Code="Unknown", Description="Unknown", Definition="", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefEmployedWhileEnrolled Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEmployedWhileEnrolledViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEmployedWhileEnrolled { Id=Guid.Parse("cb307e2e-83c0-4bc1-b576-e76e1d1d60db"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmployedWhileEnrolled { Id=Guid.Parse("a63690db-6dd1-4f6b-9049-1c750da41e62"), Description="Unknown", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
