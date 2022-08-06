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
        /// The complete <see cref="RefCampusType"> List
         /// </summary>
        public static List<RefCampusType> RefCampusTypeList = new List<RefCampusType>
        {
            new RefCampusType { Id=Guid.Parse("e4465b01-6647-4a95-9c70-0ad252396815"), Code="Administration", Description="Administration", Definition="Administration is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusType { Id=Guid.Parse("4a75eed2-8394-41a0-a845-a1e9b61be0dc"), Code="Education", Description="Education", Definition="Education is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusType { Id=Guid.Parse("92d4e438-34be-48fa-b001-9cac5d184400"), Code="Operations", Description="Operations", Definition="Operations is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusType { Id=Guid.Parse("922e642f-dbd7-4c19-8d6b-42242b20d506"), Code="Residential", Description="Residential", Definition="Residential is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCampusType { Id=Guid.Parse("18d0e3bb-935a-44e1-8952-00eb639f6b1b"), Code="Other", Description="Other", Definition="Other is specified as the primary purpose for which a campus is designed and/or used.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The RefCampusType Pick List
         /// </summary>
        public static List<RefCampusType> RefCampusTypePickList = new List<RefCampusType>
        {
            new RefCampusType { Id=Guid.Parse("e4465b01-6647-4a95-9c70-0ad252396815"), Code="Administration", Description="Administration", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusType { Id=Guid.Parse("4a75eed2-8394-41a0-a845-a1e9b61be0dc"), Code="Education", Description="Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusType { Id=Guid.Parse("92d4e438-34be-48fa-b001-9cac5d184400"), Code="Operations", Description="Operations", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusType { Id=Guid.Parse("922e642f-dbd7-4c19-8d6b-42242b20d506"), Code="Residential", Description="Residential", SortOrder=Convert.ToDecimal("4.00") },
            new RefCampusType { Id=Guid.Parse("18d0e3bb-935a-44e1-8952-00eb639f6b1b"), Code="Other", Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
