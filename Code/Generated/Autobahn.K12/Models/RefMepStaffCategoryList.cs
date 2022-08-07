//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefMepStaffCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The list of RefMepStaffCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepStaffCategoryModel"> List
         /// </summary>
        public static List<RefMepStaffCategoryModel> RefMepStaffCategoryList = new List<RefMepStaffCategoryModel>
        {
            new RefMepStaffCategory { Id=Guid.Parse("487accf4-1f04-4552-9419-cb0eaf47ba64"), Code="Teachers", Description="Teachers", Definition="Teachers is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepStaffCategory { Id=Guid.Parse("08dc115b-7c75-4145-b041-f253626deda8"), Code="Paraprofessionals", Description="Paraprofessionals", Definition="Paraprofessionals  is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepStaffCategory { Id=Guid.Parse("9cc26b79-4f12-4b75-a48a-2c6123587318"), Code="Counselors", Description="Counselors", Definition="Counselors is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepStaffCategory { Id=Guid.Parse("fdcfb89c-729a-4db8-9e2a-56d4b13ab813"), Code="Administrators", Description="Administrators", Definition="Administrators is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepStaffCategory { Id=Guid.Parse("b23c6069-6d7b-4113-b288-399143807cf0"), Code="Recruiters", Description="Recruiters", Definition="Recruiters is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepStaffCategory { Id=Guid.Parse("ddb50692-15e2-4175-97be-a364580467e2"), Code="RecordsTransferStaff", Description="Records Transfer Staff", Definition="Records Transfer Staff is the category of staff working in the Migrant Education Program.", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefMepStaffCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMepStaffCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMepStaffCategory { Id=Guid.Parse("487accf4-1f04-4552-9419-cb0eaf47ba64"), Description="Teachers", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepStaffCategory { Id=Guid.Parse("08dc115b-7c75-4145-b041-f253626deda8"), Description="Paraprofessionals", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepStaffCategory { Id=Guid.Parse("9cc26b79-4f12-4b75-a48a-2c6123587318"), Description="Counselors", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepStaffCategory { Id=Guid.Parse("fdcfb89c-729a-4db8-9e2a-56d4b13ab813"), Description="Administrators", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepStaffCategory { Id=Guid.Parse("b23c6069-6d7b-4113-b288-399143807cf0"), Description="Recruiters", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepStaffCategory { Id=Guid.Parse("ddb50692-15e2-4175-97be-a364580467e2"), Description="Records Transfer Staff", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
