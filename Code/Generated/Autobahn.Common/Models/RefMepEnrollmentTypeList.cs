//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefMepEnrollmentTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefMepEnrollmentType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefMepEnrollmentTypeModel"> List
         /// </summary>
        public static List<RefMepEnrollmentTypeModel> RefMepEnrollmentTypeList = new List<RefMepEnrollmentTypeModel>
        {
            new RefMepEnrollmentType { Id=Guid.Parse("d1a57319-b84f-434f-a5d8-169790d749ec"), Code="01", Description="Basic School Program", Definition="Basic School Program is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("defb8187-99d0-4659-b7e9-341e5d5d623d"), Code="02", Description="Regular Term MEP-Funded Project", Definition="Regular Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("b9c535f3-0dcf-4cdf-ba62-e0bfa51a4d7d"), Code="03", Description="Summer/Intersession MEP-Funded Project", Definition="Summer/Intersession MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("f7624d23-9ea4-4a13-8373-04e7c3494205"), Code="04", Description="Year Round MEP-Funded Project", Definition="Year Round MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("88cfc12f-3292-4f3c-9a2b-5d8cc93b9ea9"), Code="05", Description="Basic School Program and Regular-Term MEP-Funded Project", Definition="Basic School Program and Regular-Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("fced9f40-4fcc-488d-ac05-1c41447b2e82"), Code="06", Description="Residency Only (none of the above)", Definition="Residency Only (none of the above)", SortOrder=Convert.ToDecimal("6.00") },
        };

        /// <summary>
        /// The Reference RefMepEnrollmentType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefMepEnrollmentTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefMepEnrollmentType { Id=Guid.Parse("d1a57319-b84f-434f-a5d8-169790d749ec"), Description="Basic School Program", SortOrder=Convert.ToDecimal("1.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("defb8187-99d0-4659-b7e9-341e5d5d623d"), Description="Regular Term MEP-Funded Project", SortOrder=Convert.ToDecimal("2.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("b9c535f3-0dcf-4cdf-ba62-e0bfa51a4d7d"), Description="Summer/Intersession MEP-Funded Project", SortOrder=Convert.ToDecimal("3.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("f7624d23-9ea4-4a13-8373-04e7c3494205"), Description="Year Round MEP-Funded Project", SortOrder=Convert.ToDecimal("4.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("88cfc12f-3292-4f3c-9a2b-5d8cc93b9ea9"), Description="Basic School Program and Regular-Term MEP-Funded Project", SortOrder=Convert.ToDecimal("5.00") },
            new RefMepEnrollmentType { Id=Guid.Parse("fced9f40-4fcc-488d-ac05-1c41447b2e82"), Description="Residency Only (none of the above)", SortOrder=Convert.ToDecimal("6.00") },
       };
   }
}
