//**********************************************************
//* DomainName: Autobahn.Reference
//* FileName:   RefOrganizationElementTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Reference.Models
{
     /// <summary>
     /// The list of RefOrganizationElementType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOrganizationElementTypeModel"> List
         /// </summary>
        public static List<RefOrganizationElementTypeModel> RefOrganizationElementTypeList = new List<RefOrganizationElementTypeModel>
        {
            new RefOrganizationElementType { Id=Guid.Parse("1207f4df-25ba-48db-93da-c1934c7a3072"), Code="001078", Description="Adult Education Provider Type", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefOrganizationElementType { Id=Guid.Parse("40fa638b-0a27-4f06-852b-9d9736dae730"), Code="001156", Description="Organization Type", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefOrganizationElementType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefOrganizationElementTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefOrganizationElementType { Id=Guid.Parse("1207f4df-25ba-48db-93da-c1934c7a3072"), Description="Adult Education Provider Type", SortOrder=Convert.ToDecimal("") },
            new RefOrganizationElementType { Id=Guid.Parse("40fa638b-0a27-4f06-852b-9d9736dae730"), Description="Organization Type", SortOrder=Convert.ToDecimal("") },
       };
   }
}
