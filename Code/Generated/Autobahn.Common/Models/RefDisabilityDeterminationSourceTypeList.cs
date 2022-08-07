//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDisabilityDeterminationSourceTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDisabilityDeterminationSourceType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisabilityDeterminationSourceTypeModel"> List
         /// </summary>
        public static List<RefDisabilityDeterminationSourceTypeModel> RefDisabilityDeterminationSourceTypeList = new List<RefDisabilityDeterminationSourceTypeModel>
        {
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("3649998d-b845-4cc9-b2da-f47c2796da14"), Code="01", Description="By physician", Definition="The disability determination was by a physician.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("f1f38c87-b751-4023-a5d2-38fe39c2ce35"), Code="02", Description="By health care provider", Definition="The disability determination was by a health care provider.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("6a0107e4-e411-41a2-a972-2a3a47c36bd9"), Code="03", Description="By school psychologist or other psychologist", Definition="The disability determination was by a school psychologist or other psychologist.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("ddba5e33-75a0-46d8-90d3-cb8e163ad34c"), Code="04", Description="By licensed physical therapist", Definition="The disability determination was by a licensed physical therapist.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("0305489b-e49a-4e9b-a42e-8c53c7233dc6"), Code="05", Description="Self-reported", Definition="The disability determination was self-reported.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("37116f7d-05ef-49b7-8c79-eb05aece3397"), Code="06", Description="By social service or other type of agency", Definition="The disability determination was by a social service or other type of agency.", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("5702c13d-f80a-46f4-8d81-6025100658d8"), Code="97", Description="Not applicable to the student", Definition="Disability determination is not applicable to the student.", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("49cb74c2-8515-4a36-8d4b-19cddbcd2dd8"), Code="98", Description="Unknown or Unreported", Definition="The disability determination source is unknown or unreported.", SortOrder=Convert.ToDecimal("16.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("7c539953-4af1-4e68-b16a-b4e5765097b9"), Code="99", Description="Other", Definition="The disability determination source is in a category not yet defined by CEDS.", SortOrder=Convert.ToDecimal("18.00") },
        };

        /// <summary>
        /// The Reference RefDisabilityDeterminationSourceType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDisabilityDeterminationSourceTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("3649998d-b845-4cc9-b2da-f47c2796da14"), Description="By physician", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("f1f38c87-b751-4023-a5d2-38fe39c2ce35"), Description="By health care provider", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("6a0107e4-e411-41a2-a972-2a3a47c36bd9"), Description="By school psychologist or other psychologist", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("ddba5e33-75a0-46d8-90d3-cb8e163ad34c"), Description="By licensed physical therapist", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("0305489b-e49a-4e9b-a42e-8c53c7233dc6"), Description="Self-reported", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("37116f7d-05ef-49b7-8c79-eb05aece3397"), Description="By social service or other type of agency", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("5702c13d-f80a-46f4-8d81-6025100658d8"), Description="Not applicable to the student", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("49cb74c2-8515-4a36-8d4b-19cddbcd2dd8"), Description="Unknown or Unreported", SortOrder=Convert.ToDecimal("16.00") },
            new RefDisabilityDeterminationSourceType { Id=Guid.Parse("7c539953-4af1-4e68-b16a-b4e5765097b9"), Description="Other", SortOrder=Convert.ToDecimal("18.00") },
       };
   }
}
