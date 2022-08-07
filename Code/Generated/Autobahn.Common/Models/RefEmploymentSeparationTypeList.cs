//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefEmploymentSeparationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefEmploymentSeparationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefEmploymentSeparationTypeModel"> List
         /// </summary>
        public static List<RefEmploymentSeparationTypeModel> RefEmploymentSeparationTypeList = new List<RefEmploymentSeparationTypeModel>
        {
            new RefEmploymentSeparationType { Id=Guid.Parse("32007f90-bdf0-4efa-895d-a4774a5c3b2c"), Code="Involuntary", Description="Involuntary separation", Definition="Involuntary separation is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("e1d48493-4b56-4932-a846-1f7a4e05c364"), Code="MutualAgreement", Description="Mutual agreement", Definition="Mutual agreement is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("90e4551a-e5a6-43b8-ad62-bbbfe692570d"), Code="Other", Description="Other", Definition="The type of separation occurring between a person and the organization is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("e0183489-437a-4f78-ac21-7fe05e9a303a"), Code="Voluntary", Description="Voluntary separation", Definition="Voluntary separation is the type of separation occurring between a person and the organization.", SortOrder=Convert.ToDecimal("4.00") },
        };

        /// <summary>
        /// The Reference RefEmploymentSeparationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefEmploymentSeparationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefEmploymentSeparationType { Id=Guid.Parse("32007f90-bdf0-4efa-895d-a4774a5c3b2c"), Description="Involuntary separation", SortOrder=Convert.ToDecimal("1.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("e1d48493-4b56-4932-a846-1f7a4e05c364"), Description="Mutual agreement", SortOrder=Convert.ToDecimal("2.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("90e4551a-e5a6-43b8-ad62-bbbfe692570d"), Description="Other", SortOrder=Convert.ToDecimal("3.00") },
            new RefEmploymentSeparationType { Id=Guid.Parse("e0183489-437a-4f78-ac21-7fe05e9a303a"), Description="Voluntary separation", SortOrder=Convert.ToDecimal("4.00") },
       };
   }
}
