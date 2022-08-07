//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCharterSchoolManagementOrganizationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCharterSchoolManagementOrganizationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCharterSchoolManagementOrganizationTypeModel"> List
         /// </summary>
        public static List<RefCharterSchoolManagementOrganizationTypeModel> RefCharterSchoolManagementOrganizationTypeList = new List<RefCharterSchoolManagementOrganizationTypeModel>
        {
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("4142ffc2-9228-48a7-80cc-0a0fe2dbd022"), Code="CMO", Description="Charter Management Organization", Definition="A non-profit organization that operates or manages multiple charter schools (i.e., either through a contract with the charter schools or as the charter holder) linked by centralized support, operations, and oversight.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("106e732b-090e-4400-9d56-8fe0bc13566c"), Code="EMO", Description="Education Management Organization", Definition="A for-profit entity that contracts with new or existing public school districts, charter school districts, and charter schools to manage charter schools by centralizing support, operations, and oversight.  ", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("75a0dc0a-3902-430c-abb1-3c47e7ca4fe4"), Code="SMFP", Description="Single Management (for-profit)", Definition="A for-profit entity that is not a CMO or EMO and that provides management services to one charter school.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("ab1c4917-ed2f-4434-bfbe-a960309293c6"), Code="SMNP", Description="Single Management (non-profit)", Definition="A non-profit organization that is not a CMO or EMO and that provides management services.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefCharterSchoolManagementOrganizationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCharterSchoolManagementOrganizationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("4142ffc2-9228-48a7-80cc-0a0fe2dbd022"), Description="Charter Management Organization", SortOrder=Convert.ToDecimal("1.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("106e732b-090e-4400-9d56-8fe0bc13566c"), Description="Education Management Organization", SortOrder=Convert.ToDecimal("2.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("75a0dc0a-3902-430c-abb1-3c47e7ca4fe4"), Description="Single Management (for-profit)", SortOrder=Convert.ToDecimal("3.00") },
            new RefCharterSchoolManagementOrganizationType { Id=Guid.Parse("ab1c4917-ed2f-4434-bfbe-a960309293c6"), Description="Single Management (non-profit)", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
