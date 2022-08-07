//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefOrganizationLocationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefOrganizationLocationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefOrganizationLocationTypeModel"> List
         /// </summary>
        public static List<RefOrganizationLocationTypeModel> RefOrganizationLocationTypeList = new List<RefOrganizationLocationTypeModel>
        {
            new RefOrganizationLocationType { Id=Guid.Parse("5bdbec4d-19d8-4014-a761-d8942ba42360"), Code="Mailing", Description="Mailing", Definition="Mailing is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("11e07d80-dca3-4206-9c08-a220146735c9"), Code="Physical", Description="Physical", Definition="Physical is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("9f3b21fb-5447-49b4-83ec-fb6f4249d483"), Code="Shipping", Description="Shipping", Definition="Shipping is specified as the type of address listed for an organization.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefOrganizationLocationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefOrganizationLocationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefOrganizationLocationType { Id=Guid.Parse("5bdbec4d-19d8-4014-a761-d8942ba42360"), Description="Mailing", SortOrder=Convert.ToDecimal("1.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("11e07d80-dca3-4206-9c08-a220146735c9"), Description="Physical", SortOrder=Convert.ToDecimal("2.00") },
            new RefOrganizationLocationType { Id=Guid.Parse("9f3b21fb-5447-49b4-83ec-fb6f4249d483"), Description="Shipping", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
