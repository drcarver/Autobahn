//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefSpecialEducationStaffCategoryList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefSpecialEducationStaffCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefSpecialEducationStaffCategoryModel"> List
         /// </summary>
        public static List<RefSpecialEducationStaffCategoryModel> RefSpecialEducationStaffCategoryList = new List<RefSpecialEducationStaffCategoryModel>
        {
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("0d8a14a2-9a0a-4d23-9e09-d001022195ca"), Code="PSYCH", Description="Psychologists", Definition="The special education staff member is categorized as a Psychologist.", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("8d6eec2c-1aea-48db-9174-955922cd0075"), Code="SOCIALWORK", Description="Social Workers", Definition="The special education staff member is categorized as a Social Worker.", SortOrder=Convert.ToDecimal("2.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("1e447b2e-64b4-4b33-9e74-73d682833084"), Code="OCCTHERAP", Description="Occupational Therapists", Definition="The special education staff member is categorized as a Occupational Therapist.", SortOrder=Convert.ToDecimal("3.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("5b30ebf9-9304-4210-94e8-db9735f83d0d"), Code="AUDIO", Description="Audiologists", Definition="The special education staff member is categorized as a Audiologist.", SortOrder=Convert.ToDecimal("4.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("97e420b8-6c99-4b91-89b3-dacb720e96e4"), Code="PEANDREC", Description="Physical Education Teachers and Recreation and Therapeutic Recreation Specialists", Definition="The special education staff member is categorized as a Physical Education Teacher/Recreation and Therapeutic Recreation Specialist.", SortOrder=Convert.ToDecimal("5.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("36820556-bc6d-41ed-aa23-7f929f6fc571"), Code="PHYSTHERAP", Description="Physical Therapists", Definition="The special education staff member is categorized as a Physical Therapist.", SortOrder=Convert.ToDecimal("6.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("b2635073-1a8e-41eb-a7da-4c5761199c95"), Code="SPEECHPATH", Description="Speech-Language Pathologists", Definition="The special education staff member is categorized as a Speech-Language Pathologist.", SortOrder=Convert.ToDecimal("7.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("9999d0b0-34f9-41cf-888c-7e1c62c19a12"), Code="INTERPRET", Description="Interpreters", Definition="The special education staff member is categorized as a Interpreter.", SortOrder=Convert.ToDecimal("8.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("1d791a28-2966-4f6e-a9b7-ddc8bec6e9f0"), Code="COUNSELOR", Description="Counselors and Rehabilitation Counselors", Definition="The special education staff member is categorized as a Counselor/Rehabilitation Counselor.", SortOrder=Convert.ToDecimal("9.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("30cd2c2b-ba45-416f-8310-0784dbc28f20"), Code="ORIENTMOBIL", Description="Orientation and Mobility Specialists", Definition="The special education staff member is categorized as a Orientation and Mobility Specialist.", SortOrder=Convert.ToDecimal("10.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("701669e1-364a-4c20-a451-8318b4597bdb"), Code="MEDNURSE", Description="Medical/Nursing Service Staff", Definition="The special education staff member is categorized as Medical/Nursing Service Staff.", SortOrder=Convert.ToDecimal("11.00") },
        };

        /// <summary>
        /// The Reference RefSpecialEducationStaffCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefSpecialEducationStaffCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("0d8a14a2-9a0a-4d23-9e09-d001022195ca"), Description="Psychologists", SortOrder=Convert.ToDecimal("1.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("8d6eec2c-1aea-48db-9174-955922cd0075"), Description="Social Workers", SortOrder=Convert.ToDecimal("2.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("1e447b2e-64b4-4b33-9e74-73d682833084"), Description="Occupational Therapists", SortOrder=Convert.ToDecimal("3.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("5b30ebf9-9304-4210-94e8-db9735f83d0d"), Description="Audiologists", SortOrder=Convert.ToDecimal("4.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("97e420b8-6c99-4b91-89b3-dacb720e96e4"), Description="Physical Education Teachers and Recreation and Therapeutic Recreation Specialists", SortOrder=Convert.ToDecimal("5.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("36820556-bc6d-41ed-aa23-7f929f6fc571"), Description="Physical Therapists", SortOrder=Convert.ToDecimal("6.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("b2635073-1a8e-41eb-a7da-4c5761199c95"), Description="Speech-Language Pathologists", SortOrder=Convert.ToDecimal("7.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("9999d0b0-34f9-41cf-888c-7e1c62c19a12"), Description="Interpreters", SortOrder=Convert.ToDecimal("8.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("1d791a28-2966-4f6e-a9b7-ddc8bec6e9f0"), Description="Counselors and Rehabilitation Counselors", SortOrder=Convert.ToDecimal("9.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("30cd2c2b-ba45-416f-8310-0784dbc28f20"), Description="Orientation and Mobility Specialists", SortOrder=Convert.ToDecimal("10.00") },
            new RefSpecialEducationStaffCategory { Id=Guid.Parse("701669e1-364a-4c20-a451-8318b4597bdb"), Description="Medical/Nursing Service Staff", SortOrder=Convert.ToDecimal("11.00") },
       };
   }
}
