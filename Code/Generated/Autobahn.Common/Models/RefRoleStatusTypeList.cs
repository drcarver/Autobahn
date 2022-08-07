//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefRoleStatusTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefRoleStatusType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefRoleStatusTypeModel"> List
         /// </summary>
        public static List<RefRoleStatusTypeModel> RefRoleStatusTypeList = new List<RefRoleStatusTypeModel>
        {
            new RefRoleStatusType { Id=Guid.Parse("89dbe3df-5955-4a70-af3e-f364183a0c4f"), Code="000094", Description="Enrollment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("ef39c278-4a3a-4846-858a-bb5f5703a2e6"), Code="000096", Description="Postsecondary Enrollment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("9d595712-0164-40b3-b4be-2a51e9e79f51"), Code="000347", Description="Employment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("e55bd368-688b-4088-a574-17db8cd10001"), Code="000767", Description="Teacher Preparation Program Enrollment Status", Definition="", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("bc7edf70-054c-4300-a68c-50e1af84e535"), Code="000976", Description="Course Section Enrollment Status Type", Definition="", SortOrder=Convert.ToDecimal("") },
        };

        /// <summary>
        /// The Reference RefRoleStatusType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefRoleStatusTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefRoleStatusType { Id=Guid.Parse("89dbe3df-5955-4a70-af3e-f364183a0c4f"), Description="Enrollment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("ef39c278-4a3a-4846-858a-bb5f5703a2e6"), Description="Postsecondary Enrollment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("9d595712-0164-40b3-b4be-2a51e9e79f51"), Description="Employment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("e55bd368-688b-4088-a574-17db8cd10001"), Description="Teacher Preparation Program Enrollment Status", SortOrder=Convert.ToDecimal("") },
            new RefRoleStatusType { Id=Guid.Parse("bc7edf70-054c-4300-a68c-50e1af84e535"), Description="Course Section Enrollment Status Type", SortOrder=Convert.ToDecimal("") },
       };
   }
}
