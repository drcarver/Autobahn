//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefCampusResidencyTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefCampusResidencyType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCampusResidencyTypeModel"> List
         /// </summary>
        public static List<RefCampusResidencyTypeModel> RefCampusResidencyTypeList = new List<RefCampusResidencyTypeModel>
        {
            new RefCampusResidencyType { Id=Guid.Parse("89a83343-782b-4a3e-b542-0a0cdaaaaa8b"), Code="OnCampus", Description="On campus", Definition="On campus is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusResidencyType { Id=Guid.Parse("abf4246f-f2cc-46ca-acfe-0ea8162eb029"), Code="OffCampusWFamily", Description="Off campus, with family", Definition="Off campus, with family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusResidencyType { Id=Guid.Parse("47975245-f6b8-448b-8b9f-7fa063fbd5a9"), Code="OffCampusWOFamily", Description="Off campus, without family", Definition="Off campus, without family is specified as a person's residency arrangement as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusResidencyType { Id=Guid.Parse("073a6a3a-1144-4cc0-8ecb-31abb030b319"), Code="Unknown", Description="Unknown", Definition="A person's residency arrangement is unknown as defined in the Free Application for Federal Student Aid (FAFSA).", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefCampusResidencyType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCampusResidencyTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCampusResidencyType { Id=Guid.Parse("89a83343-782b-4a3e-b542-0a0cdaaaaa8b"), Description="On campus", SortOrder=Convert.ToDecimal("1.00") },
            new RefCampusResidencyType { Id=Guid.Parse("abf4246f-f2cc-46ca-acfe-0ea8162eb029"), Description="Off campus, with family", SortOrder=Convert.ToDecimal("2.00") },
            new RefCampusResidencyType { Id=Guid.Parse("47975245-f6b8-448b-8b9f-7fa063fbd5a9"), Description="Off campus, without family", SortOrder=Convert.ToDecimal("3.00") },
            new RefCampusResidencyType { Id=Guid.Parse("073a6a3a-1144-4cc0-8ecb-31abb030b319"), Description="Unknown", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
