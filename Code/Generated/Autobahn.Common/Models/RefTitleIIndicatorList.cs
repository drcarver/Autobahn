//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefTitleIIndicatorList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefTitleIIndicator Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTitleIIndicatorModel"> List
         /// </summary>
        public static List<RefTitleIIndicatorModel> RefTitleIIndicatorList = new List<RefTitleIIndicatorModel>
        {
            new RefTitleIIndicator { Id=Guid.Parse("be979443-2a1d-42c0-9dfb-76d141680bdb"), Code="01", Description="Public Targeted Assistance Program", Definition="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIndicator { Id=Guid.Parse("39ee9088-b7a6-4975-839d-86483965d3c0"), Code="02", Description="Public Schoolwide Program", Definition="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIndicator { Id=Guid.Parse("d0c6cd69-cddb-420c-8b8d-35b401e6f408"), Code="03", Description="Private school students participating", Definition="Private school students participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIndicator { Id=Guid.Parse("1c228138-a0d1-4df4-a989-b4a414d4eefd"), Code="04", Description="Local Neglected Program", Definition="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIndicator { Id=Guid.Parse("14a53f2f-94f4-4f94-8f65-69371464522d"), Code="05", Description="Was not served", Definition="Was not served", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefTitleIIndicator Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTitleIIndicatorViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTitleIIndicator { Id=Guid.Parse("be979443-2a1d-42c0-9dfb-76d141680bdb"), Description="Public Targeted Assistance Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefTitleIIndicator { Id=Guid.Parse("39ee9088-b7a6-4975-839d-86483965d3c0"), Description="Public Schoolwide Program", SortOrder=Convert.ToDecimal("2.00") },
            new RefTitleIIndicator { Id=Guid.Parse("d0c6cd69-cddb-420c-8b8d-35b401e6f408"), Description="Private school students participating", SortOrder=Convert.ToDecimal("3.00") },
            new RefTitleIIndicator { Id=Guid.Parse("1c228138-a0d1-4df4-a989-b4a414d4eefd"), Description="Local Neglected Program", SortOrder=Convert.ToDecimal("4.00") },
            new RefTitleIIndicator { Id=Guid.Parse("14a53f2f-94f4-4f94-8f65-69371464522d"), Description="Was not served", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
