//**********************************************************
//* DomainName: Autobahn.EarlyLearning
//* FileName:   RefELServiceTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The list of RefELServiceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefELServiceTypeModel"> List
         /// </summary>
        public static List<RefELServiceTypeModel> RefELServiceTypeList = new List<RefELServiceTypeModel>
        {
            new RefELServiceType { Id=Guid.Parse("645df9b3-ff10-4bc7-8d16-d1d45165af2f"), Code="MentalHealth", Description="Mental health", Definition="Mental health is the type of service provided to a child.", SortOrder=Convert.ToDecimal("1.00") },
            new RefELServiceType { Id=Guid.Parse("5aeb682a-d8b1-46c7-964b-b5a7f062ba72"), Code="Nutritional", Description="Nutritional", Definition="Nutritional is the type of service provided to a child.", SortOrder=Convert.ToDecimal("3.00") },
            new RefELServiceType { Id=Guid.Parse("5b9162e1-a444-4ce2-9242-1a2a699494be"), Code="Educational", Description="Educational", Definition="Educational is the type of service provided to a child.", SortOrder=Convert.ToDecimal("5.00") },
            new RefELServiceType { Id=Guid.Parse("c88b962e-b24c-4f75-a983-ac6334433c0e"), Code="PhysicalRehabilitation", Description="Physical rehabilitation", Definition="Physical rehabilitation", SortOrder=Convert.ToDecimal("7.00") },
            new RefELServiceType { Id=Guid.Parse("07ae2ff3-7342-48e7-af2d-8b6670eba92d"), Code="DentalHealth", Description="Dental Health", Definition="Dental Health is the type of service provided to a child.", SortOrder=Convert.ToDecimal("9.00") },
            new RefELServiceType { Id=Guid.Parse("dec1db63-5f65-4516-a8fd-729d4dae5975"), Code="Other", Description="Other", Definition="The type of service provided to a child is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("99.00") },
        };

        /// <summary>
        /// The Reference RefELServiceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefELServiceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefELServiceType { Id=Guid.Parse("645df9b3-ff10-4bc7-8d16-d1d45165af2f"), Description="Mental health", SortOrder=Convert.ToDecimal("1.00") },
            new RefELServiceType { Id=Guid.Parse("5aeb682a-d8b1-46c7-964b-b5a7f062ba72"), Description="Nutritional", SortOrder=Convert.ToDecimal("3.00") },
            new RefELServiceType { Id=Guid.Parse("5b9162e1-a444-4ce2-9242-1a2a699494be"), Description="Educational", SortOrder=Convert.ToDecimal("5.00") },
            new RefELServiceType { Id=Guid.Parse("c88b962e-b24c-4f75-a983-ac6334433c0e"), Description="Physical rehabilitation", SortOrder=Convert.ToDecimal("7.00") },
            new RefELServiceType { Id=Guid.Parse("07ae2ff3-7342-48e7-af2d-8b6670eba92d"), Description="Dental Health", SortOrder=Convert.ToDecimal("9.00") },
            new RefELServiceType { Id=Guid.Parse("dec1db63-5f65-4516-a8fd-729d4dae5975"), Description="Other", SortOrder=Convert.ToDecimal("99.00") },
       };
   }
}
