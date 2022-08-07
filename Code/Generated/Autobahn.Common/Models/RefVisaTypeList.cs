//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefVisaTypeList.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefVisaType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefVisaTypeModel"> List
         /// </summary>
        public static List<RefVisaTypeModel> RefVisaTypeList = new List<RefVisaTypeModel>
        {
            new RefVisaType { Id=Guid.Parse("26e2779d-6c09-4374-ad4a-7c0635a52daf"), Code="F1", Description="Foreign Student Visa", Definition="The non-US citizen's Visa type is Foreign Student Visa.", SortOrder=Convert.ToDecimal("1.00") },
            new RefVisaType { Id=Guid.Parse("6497228c-c69f-41ff-a56e-5b6675f6a70c"), Code="M1", Description="Foreign Student pursuing vocational or non-academic studies Visa", Definition="The non-US citizen's Visa type is Foreign Student pursuing vocational or non-academic studies Visa.", SortOrder=Convert.ToDecimal("2.00") },
            new RefVisaType { Id=Guid.Parse("9fc0b44f-8bba-4d68-81d8-fce44685f5ce"), Code="H1", Description="Employment Visa", Definition="The non-US citizen's Visa type is Employment Visa.", SortOrder=Convert.ToDecimal("3.00") },
            new RefVisaType { Id=Guid.Parse("3467bd54-8d96-4b08-ace7-77658e9b7b62"), Code="B1", Description="Business Visa", Definition="The non-US citizen's Visa type is Business Visa.", SortOrder=Convert.ToDecimal("4.00") },
            new RefVisaType { Id=Guid.Parse("98a92660-4502-4198-9177-236fea34cb09"), Code="B2", Description="Tourist Visa", Definition="The non-US citizen's Visa type is Tourist Visa.", SortOrder=Convert.ToDecimal("5.00") },
            new RefVisaType { Id=Guid.Parse("a698dce8-ff2d-43f5-b2e7-ff3128976e76"), Code="J1", Description="Exchange Scholar Visa", Definition="The non-US citizen's Visa type is Exchange Scholar Visa.", SortOrder=Convert.ToDecimal("6.00") },
            new RefVisaType { Id=Guid.Parse("a3f62712-0f9e-4472-b861-2227b1ea9f31"), Code="OV", Description="Other Visa", Definition="The non-US citizen's Visa type is Other Visa.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The Reference RefVisaType Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefVisaTypeViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefVisaType { Id=Guid.Parse("26e2779d-6c09-4374-ad4a-7c0635a52daf"), Description="Foreign Student Visa", SortOrder=Convert.ToDecimal("1.00") },
            new RefVisaType { Id=Guid.Parse("6497228c-c69f-41ff-a56e-5b6675f6a70c"), Description="Foreign Student pursuing vocational or non-academic studies Visa", SortOrder=Convert.ToDecimal("2.00") },
            new RefVisaType { Id=Guid.Parse("9fc0b44f-8bba-4d68-81d8-fce44685f5ce"), Description="Employment Visa", SortOrder=Convert.ToDecimal("3.00") },
            new RefVisaType { Id=Guid.Parse("3467bd54-8d96-4b08-ace7-77658e9b7b62"), Description="Business Visa", SortOrder=Convert.ToDecimal("4.00") },
            new RefVisaType { Id=Guid.Parse("98a92660-4502-4198-9177-236fea34cb09"), Description="Tourist Visa", SortOrder=Convert.ToDecimal("5.00") },
            new RefVisaType { Id=Guid.Parse("a698dce8-ff2d-43f5-b2e7-ff3128976e76"), Description="Exchange Scholar Visa", SortOrder=Convert.ToDecimal("6.00") },
            new RefVisaType { Id=Guid.Parse("a3f62712-0f9e-4472-b861-2227b1ea9f31"), Description="Other Visa", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
