//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefServiceOptionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefServiceOption Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefServiceOptionModel"> List
         /// </summary>
        public static List<RefServiceOptionModel> RefServiceOptionList = new List<RefServiceOptionModel>
        {
            new RefServiceOption { Id=Guid.Parse("a2b5e5b2-e49f-4d69-bc9a-5d13f412057d"), Code="FullDayFullYear", Description="Full-day/full-year", Definition="Full-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("1.00") },
            new RefServiceOption { Id=Guid.Parse("20f9843e-d034-44a1-81e3-a3971cdd969c"), Code="FullDayPartYear", Description="Full-day/part-year", Definition="Full-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceOption { Id=Guid.Parse("885ca0c9-4efd-43a0-ac58-136556a1fd33"), Code="PartDayFullYear", Description="Part-day/full-year", Definition="Part-day/full-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("3.00") },
            new RefServiceOption { Id=Guid.Parse("61d19eda-8063-4183-afa3-1c5a8b134807"), Code="PartDayPartYear", Description="Part-day/part-year", Definition="Part-day/part-year is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceOption { Id=Guid.Parse("d1967a90-7a92-497c-a20b-eab4904bfb7e"), Code="HomeBased", Description="Home based", Definition="Home based is the nature of the early childhood program, class or group in which a person is enrolled.", SortOrder=Convert.ToDecimal("5.00") },
            new RefServiceOption { Id=Guid.Parse("25fbe50d-4fed-42c2-8ab6-b10b8bbfdec2"), Code="NA", Description="Not applicable", Definition="The nature of the early childhood program, class or group in which a person is enrolled is not applicable.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefServiceOption Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefServiceOptionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefServiceOption { Id=Guid.Parse("a2b5e5b2-e49f-4d69-bc9a-5d13f412057d"), Description="Full-day/full-year", SortOrder=Convert.ToDecimal("1.00") },
            new RefServiceOption { Id=Guid.Parse("20f9843e-d034-44a1-81e3-a3971cdd969c"), Description="Full-day/part-year", SortOrder=Convert.ToDecimal("2.00") },
            new RefServiceOption { Id=Guid.Parse("885ca0c9-4efd-43a0-ac58-136556a1fd33"), Description="Part-day/full-year", SortOrder=Convert.ToDecimal("3.00") },
            new RefServiceOption { Id=Guid.Parse("61d19eda-8063-4183-afa3-1c5a8b134807"), Description="Part-day/part-year", SortOrder=Convert.ToDecimal("4.00") },
            new RefServiceOption { Id=Guid.Parse("d1967a90-7a92-497c-a20b-eab4904bfb7e"), Description="Home based", SortOrder=Convert.ToDecimal("5.00") },
            new RefServiceOption { Id=Guid.Parse("25fbe50d-4fed-42c2-8ab6-b10b8bbfdec2"), Description="Not applicable", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
