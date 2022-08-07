//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDisabilityTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDisabilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisabilityTypeModel"> List
         /// </summary>
        public static List<RefDisabilityTypeModel> RefDisabilityTypeList = new List<RefDisabilityTypeModel>
        {
            new RefDisabilityType { Id=Guid.Parse("7a615da8-f324-4c51-a173-29815fd1bf53"), Code="AUT", Description="Autism", Definition="Autism is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityType { Id=Guid.Parse("0ee084da-3141-4923-8aea-114a6b62a79b"), Code="DB", Description="Deaf-blindness", Definition="Deaf-blindness is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityType { Id=Guid.Parse("736273a4-e60e-4ddf-91f8-c030615b0017"), Code="DD", Description="Developmental delay", Definition="Developmental delay is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityType { Id=Guid.Parse("891238ff-4270-4717-9a42-374ab6143c32"), Code="EMN", Description="Emotional disturbance", Definition="Emotional disturbance is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisabilityType { Id=Guid.Parse("5140dc3b-59bb-4f16-a7f1-d5c6da1bbb06"), Code="HI", Description="Hearing impairment", Definition="Hearing impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityType { Id=Guid.Parse("acfb0b2e-7e00-41e1-b4e2-3eae5184d086"), Code="ID", Description="Intellectual Disability", Definition="Intellectual Disability is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityType { Id=Guid.Parse("13c46c0d-4ecc-4d26-be30-c53c3ac83003"), Code="MD", Description="Multiple disabilities", Definition="Multiple disabilities is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisabilityType { Id=Guid.Parse("e2554b40-08ca-4b40-b0ec-05f7da1def5c"), Code="OI", Description="Orthopedic impairment", Definition="Orthopedic impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityType { Id=Guid.Parse("de79fd98-511f-443c-9ae4-4dc4736dbe85"), Code="OHI", Description="Other health impairment", Definition="Other health impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisabilityType { Id=Guid.Parse("5ec0e72e-41ef-4376-b02c-9f4a0d42547e"), Code="SLD", Description="Specific learning disability", Definition="Specific learning disability is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityType { Id=Guid.Parse("eb592ecd-2cfe-4946-857c-fb78830297fe"), Code="SLI", Description="Speech or language impairment", Definition="Speech or language impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("13.00") },
            new RefDisabilityType { Id=Guid.Parse("e153f32a-f87b-4b5c-97df-cd6fed52b384"), Code="TBI", Description="Traumatic brain injury", Definition="Traumatic brain injury is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityType { Id=Guid.Parse("49d5b181-d6f6-4b33-95f5-7e2471ffa359"), Code="VI", Description="Visual impairment", Definition="Visual impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("15.00") },
        };

        /// <summary>
        /// The Reference RefDisabilityType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefDisabilityTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefDisabilityType { Id=Guid.Parse("7a615da8-f324-4c51-a173-29815fd1bf53"), Description="Autism", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityType { Id=Guid.Parse("0ee084da-3141-4923-8aea-114a6b62a79b"), Description="Deaf-blindness", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityType { Id=Guid.Parse("736273a4-e60e-4ddf-91f8-c030615b0017"), Description="Developmental delay", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityType { Id=Guid.Parse("891238ff-4270-4717-9a42-374ab6143c32"), Description="Emotional disturbance", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisabilityType { Id=Guid.Parse("5140dc3b-59bb-4f16-a7f1-d5c6da1bbb06"), Description="Hearing impairment", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityType { Id=Guid.Parse("acfb0b2e-7e00-41e1-b4e2-3eae5184d086"), Description="Intellectual Disability", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityType { Id=Guid.Parse("13c46c0d-4ecc-4d26-be30-c53c3ac83003"), Description="Multiple disabilities", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisabilityType { Id=Guid.Parse("e2554b40-08ca-4b40-b0ec-05f7da1def5c"), Description="Orthopedic impairment", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityType { Id=Guid.Parse("de79fd98-511f-443c-9ae4-4dc4736dbe85"), Description="Other health impairment", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisabilityType { Id=Guid.Parse("5ec0e72e-41ef-4376-b02c-9f4a0d42547e"), Description="Specific learning disability", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityType { Id=Guid.Parse("eb592ecd-2cfe-4946-857c-fb78830297fe"), Description="Speech or language impairment", SortOrder=Convert.ToDecimal("13.00") },
            new RefDisabilityType { Id=Guid.Parse("e153f32a-f87b-4b5c-97df-cd6fed52b384"), Description="Traumatic brain injury", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityType { Id=Guid.Parse("49d5b181-d6f6-4b33-95f5-7e2471ffa359"), Description="Visual impairment", SortOrder=Convert.ToDecimal("15.00") },
       };
   }
}
