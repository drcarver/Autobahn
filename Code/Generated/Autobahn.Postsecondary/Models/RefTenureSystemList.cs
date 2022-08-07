//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefTenureSystemList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefTenureSystem Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefTenureSystemModel"> List
         /// </summary>
        public static List<RefTenureSystemModel> RefTenureSystemList = new List<RefTenureSystemModel>
        {
            new RefTenureSystem { Id=Guid.Parse("7c1e96c9-b60e-44b5-8c37-ce0eb97108ed"), Code="Yes", Description="Yes", Definition="", SortOrder=Convert.ToDecimal("1.00") },
            new RefTenureSystem { Id=Guid.Parse("0b5824a5-4c6e-4056-bf6a-9c80772329b9"), Code="No", Description="No", Definition="", SortOrder=Convert.ToDecimal("2.00") },
        };

        /// <summary>
        /// The Reference RefTenureSystem Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefTenureSystemViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefTenureSystem { Id=Guid.Parse("7c1e96c9-b60e-44b5-8c37-ce0eb97108ed"), Description="Yes", SortOrder=Convert.ToDecimal("1.00") },
            new RefTenureSystem { Id=Guid.Parse("0b5824a5-4c6e-4056-bf6a-9c80772329b9"), Description="No", SortOrder=Convert.ToDecimal("2.00") },
       };
   }
}
