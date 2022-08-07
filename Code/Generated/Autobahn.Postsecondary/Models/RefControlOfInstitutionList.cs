//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefControlOfInstitutionList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefControlOfInstitution Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefControlOfInstitutionModel"> List
         /// </summary>
        public static List<RefControlOfInstitutionModel> RefControlOfInstitutionList = new List<RefControlOfInstitutionModel>
        {
            new RefControlOfInstitution { Id=Guid.Parse("6e55ea8d-60f4-46ee-9f55-e219675b9bed"), Code="Public", Description="Public", Definition="The postsecondary institution is operated by publicly elected or appointed officials.", SortOrder=Convert.ToDecimal("1.00") },
            new RefControlOfInstitution { Id=Guid.Parse("02912a43-661e-4b94-900c-89d5a9a8b287"), Code="PrivateNFP", Description="Private, not for profit", Definition="The postsecondary institution is operated by privately elected or appointed officials and is organized as a not for profit entity.", SortOrder=Convert.ToDecimal("2.00") },
            new RefControlOfInstitution { Id=Guid.Parse("6b4d2f58-74f5-41a7-be21-37557ff1edcb"), Code="PrivateFP", Description="Private, for profit", Definition="The postsecondary institution is operated by privately elected or appointed officials and is organized as a for profit entity.", SortOrder=Convert.ToDecimal("3.00") },
        };

        /// <summary>
        /// The Reference RefControlOfInstitution Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefControlOfInstitutionViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefControlOfInstitution { Id=Guid.Parse("6e55ea8d-60f4-46ee-9f55-e219675b9bed"), Description="Public", SortOrder=Convert.ToDecimal("1.00") },
            new RefControlOfInstitution { Id=Guid.Parse("02912a43-661e-4b94-900c-89d5a9a8b287"), Description="Private, not for profit", SortOrder=Convert.ToDecimal("2.00") },
            new RefControlOfInstitution { Id=Guid.Parse("6b4d2f58-74f5-41a7-be21-37557ff1edcb"), Description="Private, for profit", SortOrder=Convert.ToDecimal("3.00") },
       };
   }
}
