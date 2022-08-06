//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCharterSchoolManagementOrganizationTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCharterSchoolManagementOrganizationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCharterSchoolManagementOrganizationType"> List
         /// </summary>
        public static List<RefCharterSchoolManagementOrganizationType> RefCharterSchoolManagementOrganizationTypeList = new List<RefCharterSchoolManagementOrganizationType> =
        {
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("fb408282-badf-4a6a-b6ee-31bfa81d33de"), Code="A non-profit organization that operates or manages multiple charter schools (i.e., either through a contract with the charter schools or as the charter holder) linked by centralized support, operations, and oversight.", Description="CMO", Definition="", SortOrder=0 },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("89489a08-8f08-4f5a-b8bd-bd06d97f41c9"), Code="A for-profit entity that contracts with new or existing public school districts, charter school districts, and charter schools to manage charter schools by centralizing support, operations, and oversight.  ", Description="EMO", Definition="", SortOrder=0 },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("2b14c6a9-a31d-41a9-a62e-6c09bab3a00b"), Code="A for-profit entity that is not a CMO or EMO and that provides management services to one charter school.", Description="SMFP", Definition="", SortOrder=0 },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("985ea826-961a-4b9a-ab8d-daa81b4079cf"), Code="A non-profit organization that is not a CMO or EMO and that provides management services.", Description="SMNP", Definition="", SortOrder=0 },
        };

        /// <summary>
        /// The RefCharterSchoolManagementOrganizationType Pick List
         /// </summary>
        public static List<RefCharterSchoolManagementOrganizationType> RefCharterSchoolManagementOrganizationTypePickList = new List<RefCharterSchoolManagementOrganizationType> =
        {
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("fb408282-badf-4a6a-b6ee-31bfa81d33de"), Code="A non-profit organization that operates or manages multiple charter schools (i.e., either through a contract with the charter schools or as the charter holder) linked by centralized support, operations, and oversight.", SortOrder=0 },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("89489a08-8f08-4f5a-b8bd-bd06d97f41c9"), Code="A for-profit entity that contracts with new or existing public school districts, charter school districts, and charter schools to manage charter schools by centralizing support, operations, and oversight.  ", SortOrder=0 },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("2b14c6a9-a31d-41a9-a62e-6c09bab3a00b"), Code="A for-profit entity that is not a CMO or EMO and that provides management services to one charter school.", SortOrder=0 },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("985ea826-961a-4b9a-ab8d-daa81b4079cf"), Code="A non-profit organization that is not a CMO or EMO and that provides management services.", SortOrder=0 },
       };
   }
}
