//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSexList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSex Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSexModel"> List
         /// </summary>
        public static List<RefSexModel> RefSexList = new List<RefSexModel>
        {
            new RefSex { Id=Guid.Parse("7d543d37-0182-4738-bf36-ffb9f1eb8396"), Code="Male", Description="Male", Definition="Male", SortOrder=Convert.ToDecimal("1.00") },
            new RefSex { Id=Guid.Parse("96b00bf4-6406-402e-b8b8-3b05092444bc"), Code="Female", Description="Female", Definition="Female", SortOrder=Convert.ToDecimal("2.00") },
            new RefSex { Id=Guid.Parse("1503961d-223b-4800-ba4b-47ca1bafc6f5"), Code="NotSelected", Description="Not selected", Definition="Gender is not selected", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefSex Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSexViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSex { Id=Guid.Parse("7d543d37-0182-4738-bf36-ffb9f1eb8396"), Description="Male", SortOrder=Convert.ToDecimal("1.00") },
            new RefSex { Id=Guid.Parse("96b00bf4-6406-402e-b8b8-3b05092444bc"), Description="Female", SortOrder=Convert.ToDecimal("2.00") },
            new RefSex { Id=Guid.Parse("1503961d-223b-4800-ba4b-47ca1bafc6f5"), Description="Not selected", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
