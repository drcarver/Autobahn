//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefInstructionLocationTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefInstructionLocationType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefInstructionLocationTypeModel"> List
         /// </summary>
        public static List<RefInstructionLocationTypeModel> RefInstructionLocationTypeList = new List<RefInstructionLocationTypeModel>
        {
            new RefInstructionLocationType { Id=Guid.Parse("1a13ec1a-7fa4-4bf5-ada3-3adc08b26e9c"), Code="00997", Description="Business", Definition="Business is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionLocationType { Id=Guid.Parse("55594ecf-702f-492d-95e6-3766cdc79561"), Code="00752", Description="Community facility", Definition="Community facility is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionLocationType { Id=Guid.Parse("374c6a1d-bf14-4ce2-a7e5-763717162534"), Code="00753", Description="Home of student", Definition="Home of student is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionLocationType { Id=Guid.Parse("9ee13a38-4e16-4bc1-a901-8afebcbf3a79"), Code="00754", Description="Hospital", Definition="Hospital is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionLocationType { Id=Guid.Parse("0e867cc9-96e6-43e1-97d0-9d612f72ab02"), Code="03018", Description="Library/media center", Definition="Library/media center is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstructionLocationType { Id=Guid.Parse("06d4b771-bd8b-4263-bda0-cd5954707471"), Code="03506", Description="Mobile", Definition="Mobile is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstructionLocationType { Id=Guid.Parse("b9122dd6-d4c0-4c9b-8ae3-13780e697cf3"), Code="09999", Description="Other", Definition="The type of location at which instruction or service takes place is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstructionLocationType { Id=Guid.Parse("85b3a03c-efe9-448e-a03e-51238517980b"), Code="00341", Description="Other K-12 educational institution", Definition="Other K-12 educational institution is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("8.00") },
            new RefInstructionLocationType { Id=Guid.Parse("661a9d74-af57-4dcf-a154-a0f92d078c10"), Code="00342", Description="Postsecondary facility", Definition="Postsecondary facility is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("9.00") },
            new RefInstructionLocationType { Id=Guid.Parse("42dd2118-1821-4f94-8e7a-0c4beeb8c19d"), Code="00675", Description="School", Definition="School is the type of location at which instruction or service takes place.", SortOrder=Convert.ToDecimal("10.00") },
        };

        /// <summary>
        /// The Reference RefInstructionLocationType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefInstructionLocationTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefInstructionLocationType { Id=Guid.Parse("1a13ec1a-7fa4-4bf5-ada3-3adc08b26e9c"), Description="Business", SortOrder=Convert.ToDecimal("1.00") },
            new RefInstructionLocationType { Id=Guid.Parse("55594ecf-702f-492d-95e6-3766cdc79561"), Description="Community facility", SortOrder=Convert.ToDecimal("2.00") },
            new RefInstructionLocationType { Id=Guid.Parse("374c6a1d-bf14-4ce2-a7e5-763717162534"), Description="Home of student", SortOrder=Convert.ToDecimal("3.00") },
            new RefInstructionLocationType { Id=Guid.Parse("9ee13a38-4e16-4bc1-a901-8afebcbf3a79"), Description="Hospital", SortOrder=Convert.ToDecimal("4.00") },
            new RefInstructionLocationType { Id=Guid.Parse("0e867cc9-96e6-43e1-97d0-9d612f72ab02"), Description="Library/media center", SortOrder=Convert.ToDecimal("5.00") },
            new RefInstructionLocationType { Id=Guid.Parse("06d4b771-bd8b-4263-bda0-cd5954707471"), Description="Mobile", SortOrder=Convert.ToDecimal("6.00") },
            new RefInstructionLocationType { Id=Guid.Parse("b9122dd6-d4c0-4c9b-8ae3-13780e697cf3"), Description="Other", SortOrder=Convert.ToDecimal("7.00") },
            new RefInstructionLocationType { Id=Guid.Parse("85b3a03c-efe9-448e-a03e-51238517980b"), Description="Other K-12 educational institution", SortOrder=Convert.ToDecimal("8.00") },
            new RefInstructionLocationType { Id=Guid.Parse("661a9d74-af57-4dcf-a154-a0f92d078c10"), Description="Postsecondary facility", SortOrder=Convert.ToDecimal("9.00") },
            new RefInstructionLocationType { Id=Guid.Parse("42dd2118-1821-4f94-8e7a-0c4beeb8c19d"), Description="School", SortOrder=Convert.ToDecimal("10.00") },
       };
   }
}
