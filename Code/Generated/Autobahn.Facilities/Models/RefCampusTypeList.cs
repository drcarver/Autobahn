//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   RefCampusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Facilities.Models
{
     /// <summary>
     /// The list of RefCampusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCampusTypeModel"> List
         /// </summary>
        public static List<RefCampusTypeModel> RefCampusTypeList = new List<RefCampusTypeModel>
        {
            new RefCampusType { Id=Guid.Parse("f0d7a436-1dfb-420d-8d46-3bae12be9bb2"), Code="Administration", Description="Administration", Definition="Administration is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusType { Id=Guid.Parse("e70f3447-18b5-4661-8c20-8f63ef532ae9"), Code="Education", Description="Education", Definition="Education is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusType { Id=Guid.Parse("ec717abb-f6bc-4950-9a3b-6e67ffc7bb2c"), Code="Operations", Description="Operations", Definition="Operations is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusType { Id=Guid.Parse("a09033b2-e600-400c-9493-81970790c14a"), Code="Residential", Description="Residential", Definition="Residential is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCampusType { Id=Guid.Parse("214454e1-c449-4d7d-ba02-0dda0aa370f1"), Code="Other", Description="Other", Definition="Other is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefCampusType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCampusTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCampusType { Id=Guid.Parse("f0d7a436-1dfb-420d-8d46-3bae12be9bb2"), Description="Administration", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusType { Id=Guid.Parse("e70f3447-18b5-4661-8c20-8f63ef532ae9"), Description="Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusType { Id=Guid.Parse("ec717abb-f6bc-4950-9a3b-6e67ffc7bb2c"), Description="Operations", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusType { Id=Guid.Parse("a09033b2-e600-400c-9493-81970790c14a"), Description="Residential", SortOrder=Convert.ToDecimal("4.00") },
            new RefCampusType { Id=Guid.Parse("214454e1-c449-4d7d-ba02-0dda0aa370f1"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
