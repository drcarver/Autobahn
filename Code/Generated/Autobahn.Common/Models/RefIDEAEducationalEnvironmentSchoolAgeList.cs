//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefIDEAEducationalEnvironmentSchoolAgeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefIDEAEducationalEnvironmentSchoolAge Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefIDEAEducationalEnvironmentSchoolAgeModel"> List
         /// </summary>
        public static List<RefIDEAEducationalEnvironmentSchoolAgeModel> RefIDEAEducationalEnvironmentSchoolAgeList = new List<RefIDEAEducationalEnvironmentSchoolAgeModel>
        {
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cf23d4e8-50aa-4e44-8364-c888236acb73"), Code="RC80", Description="Inside regular class 80% or more of the day", Definition="Inside regular class 80% or more of the day is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("8c0f91a6-a074-49a8-b423-3357586281a4"), Code="RC79TO40", Description="Inside regular class 40% through 79% of the day", Definition="Inside regular class 40% through 79% of the day is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("413b5888-7376-40f7-a22b-189ccc67eb81"), Code="RC39", Description="Inside regular class less than 40% of the day", Definition="Inside regular class less than 40% of the day is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("0debf3a3-7be6-47a9-8042-e74a4a048520"), Code="SS", Description="Separate school", Definition="Separate school is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("fccccbe3-9971-41b2-8b11-f0cb9bfabf35"), Code="RF", Description="Residential facility", Definition="Residential facility is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("2a5ae9ec-4973-462c-973d-6f1e426dd1dd"), Code="HH", Description="Homebound/hospital", Definition="Homebound/hospital is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("96b94265-20fb-4dc2-878d-f8524c5ef0f2"), Code="CF", Description="Correctional facility", Definition="Correctional facility is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("9fdc6fd7-3f20-4385-895c-cc51b99980af"), Code="PPPS", Description="Parentally placed in private school", Definition="Parentally placed in private school is the setting in which children ages 6 through 21, receive special education and related services.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefIDEAEducationalEnvironmentSchoolAge Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefIDEAEducationalEnvironmentSchoolAgeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("cf23d4e8-50aa-4e44-8364-c888236acb73"), Description="Inside regular class 80% or more of the day", SortOrder=Convert.ToDecimal("1.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("8c0f91a6-a074-49a8-b423-3357586281a4"), Description="Inside regular class 40% through 79% of the day", SortOrder=Convert.ToDecimal("2.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("413b5888-7376-40f7-a22b-189ccc67eb81"), Description="Inside regular class less than 40% of the day", SortOrder=Convert.ToDecimal("3.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("0debf3a3-7be6-47a9-8042-e74a4a048520"), Description="Separate school", SortOrder=Convert.ToDecimal("4.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("fccccbe3-9971-41b2-8b11-f0cb9bfabf35"), Description="Residential facility", SortOrder=Convert.ToDecimal("5.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("2a5ae9ec-4973-462c-973d-6f1e426dd1dd"), Description="Homebound/hospital", SortOrder=Convert.ToDecimal("6.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("96b94265-20fb-4dc2-878d-f8524c5ef0f2"), Description="Correctional facility", SortOrder=Convert.ToDecimal("7.00") },
            new RefIDEAEducationalEnvironmentSchoolAge { Id=Guid.Parse("9fdc6fd7-3f20-4385-895c-cc51b99980af"), Description="Parentally placed in private school", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
