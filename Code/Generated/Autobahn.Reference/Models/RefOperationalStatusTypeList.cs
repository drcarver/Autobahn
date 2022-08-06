//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefOperationalStatusTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The list of RefOperationalStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOperationalStatusType"> List
         /// </summary>
        public static List<RefOperationalStatusType> RefOperationalStatusTypeList = new List<RefOperationalStatusType>
        {
            new RefOperationalStatusType { Id=Guid.Parse("4e693b99-2cd0-4acb-b7f2-12ab42504db5"), Code="000174", Description="Local Education Agency Operational Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("3c10fda2-9cf9-4bb3-8abc-fdb9e49f730e"), Code="000533", Description="School Operational Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("398f4fc6-7c1d-47e8-ae2c-054928161345"), Code="001418", Description="Organization Operational Status", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The RefOperationalStatusType Pick List
         /// </summary>
        public static List<RefOperationalStatusType> RefOperationalStatusTypePickList = new List<RefOperationalStatusType>
        {
            new RefOperationalStatusType { Id=Guid.Parse("4e693b99-2cd0-4acb-b7f2-12ab42504db5"), Code="000174", Description="Local Education Agency Operational Status", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("3c10fda2-9cf9-4bb3-8abc-fdb9e49f730e"), Code="000533", Description="School Operational Status", SortOrder=Convert.ToDecimal("") },
            new RefOperationalStatusType { Id=Guid.Parse("398f4fc6-7c1d-47e8-ae2c-054928161345"), Code="001418", Description="Organization Operational Status", SortOrder=Convert.ToDecimal("") },
       };
   }
}
