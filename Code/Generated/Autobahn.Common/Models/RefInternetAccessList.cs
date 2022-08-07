//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInternetAccessList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInternetAccess Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInternetAccessModel"> List
         /// </summary>
        public static List<RefInternetAccessModel> RefInternetAccessList = new List<RefInternetAccessModel>
        {
            new RefInternetAccess { Id=Guid.Parse("cc920f33-071d-47f8-9527-084ada80fe6b"), Code="HighSpeed", Description="High speed connectivity", Definition="High speed internet connectivity is available.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccess { Id=Guid.Parse("f27440d6-6ca2-4669-8be4-f0786af2bc47"), Code="LessThanHighSpeed", Description="Less than high speed connectivity", Definition="Less than high speed internet connectivity is available.", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefInternetAccess Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInternetAccessViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInternetAccess { Id=Guid.Parse("cc920f33-071d-47f8-9527-084ada80fe6b"), Description="High speed connectivity", SortOrder=Convert.ToDecimal("1.00") },
            new RefInternetAccess { Id=Guid.Parse("f27440d6-6ca2-4669-8be4-f0786af2bc47"), Description="Less than high speed connectivity", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
