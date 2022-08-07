//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefCredentialTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefCredentialType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefCredentialTypeModel"> List
         /// </summary>
        public static List<RefCredentialTypeModel> RefCredentialTypeList = new List<RefCredentialTypeModel>
        {
            new RefCredentialType { Id=Guid.Parse("ad2d9768-2b04-4a88-9d2b-cdd9fc9c3d1c"), Code="Certification", Description="Certification", Definition="Certification is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialType { Id=Guid.Parse("2c6dd63b-8e15-459c-ae03-8b5f66b91211"), Code="Endorsement", Description="Endorsement", Definition="Endorsement is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialType { Id=Guid.Parse("6c66e438-1600-4fbc-8113-fee0c239c414"), Code="Licensure", Description="Licensure", Definition="Licensure is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialType { Id=Guid.Parse("19c25aea-e31a-47bb-959c-3d78b8ae6cc3"), Code="Other", Description="Other", Definition="Other is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialType { Id=Guid.Parse("047847c3-3411-4966-92f2-a472a457b1eb"), Code="Registration", Description="Registration", Definition="Registration is specified as the  category of credential a person holds.", SortOrder=Convert.ToDecimal("5.00") },
        };

        /// <summary>
        /// The Reference RefCredentialType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefCredentialTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefCredentialType { Id=Guid.Parse("ad2d9768-2b04-4a88-9d2b-cdd9fc9c3d1c"), Description="Certification", SortOrder=Convert.ToDecimal("1.00") },
            new RefCredentialType { Id=Guid.Parse("2c6dd63b-8e15-459c-ae03-8b5f66b91211"), Description="Endorsement", SortOrder=Convert.ToDecimal("2.00") },
            new RefCredentialType { Id=Guid.Parse("6c66e438-1600-4fbc-8113-fee0c239c414"), Description="Licensure", SortOrder=Convert.ToDecimal("3.00") },
            new RefCredentialType { Id=Guid.Parse("19c25aea-e31a-47bb-959c-3d78b8ae6cc3"), Description="Other", SortOrder=Convert.ToDecimal("4.00") },
            new RefCredentialType { Id=Guid.Parse("047847c3-3411-4966-92f2-a472a457b1eb"), Description="Registration", SortOrder=Convert.ToDecimal("5.00") },
       };
   }
}
