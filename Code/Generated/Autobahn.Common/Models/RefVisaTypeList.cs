//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefVisaTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefVisaType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefVisaType"> List
         /// </summary>
        public static List<RefVisaType> RefVisaTypeList = new List<RefVisaType>
        {
            new RefVisaType { Id=Guid.Parse("d79725cf-512d-4ecb-9158-d31459d96b8e"), Code="F1", Description="Foreign Student Visa", Definition="The non-US citizen's Visa type is Foreign Student Visa.", SortOrder=Convert.ToDecimal("1.00") },
            new RefVisaType { Id=Guid.Parse("b43f7f2a-ff95-4bfe-9148-e31b7b507dd4"), Code="M1", Description="Foreign Student pursuing vocational or non-academic studies Visa", Definition="The non-US citizen's Visa type is Foreign Student pursuing vocational or non-academic studies Visa.", SortOrder=Convert.ToDecimal("2.00") },
            new RefVisaType { Id=Guid.Parse("228ed8d6-f923-47bb-be8c-d0ad843345c6"), Code="H1", Description="Employment Visa", Definition="The non-US citizen's Visa type is Employment Visa.", SortOrder=Convert.ToDecimal("3.00") },
            new RefVisaType { Id=Guid.Parse("37ad7182-46e3-4171-a31a-80725f31f044"), Code="B1", Description="Business Visa", Definition="The non-US citizen's Visa type is Business Visa.", SortOrder=Convert.ToDecimal("4.00") },
            new RefVisaType { Id=Guid.Parse("81e68f60-0cac-4f80-9c78-3a80b8b10ddb"), Code="B2", Description="Tourist Visa", Definition="The non-US citizen's Visa type is Tourist Visa.", SortOrder=Convert.ToDecimal("5.00") },
            new RefVisaType { Id=Guid.Parse("4a5eb374-acfb-4b9f-8522-c96610bd3e02"), Code="J1", Description="Exchange Scholar Visa", Definition="The non-US citizen's Visa type is Exchange Scholar Visa.", SortOrder=Convert.ToDecimal("6.00") },
            new RefVisaType { Id=Guid.Parse("41b7a00b-4a32-45d7-aa55-87fbeffd7a0b"), Code="OV", Description="Other Visa", Definition="The non-US citizen's Visa type is Other Visa.", SortOrder=Convert.ToDecimal("7.00") },
        };

        /// <summary>
        /// The RefVisaType Pick List
         /// </summary>
        public static List<RefVisaType> RefVisaTypePickList = new List<RefVisaType>
        {
            new RefVisaType { Id=Guid.Parse("d79725cf-512d-4ecb-9158-d31459d96b8e"), Code="F1", Description="Foreign Student Visa", SortOrder=Convert.ToDecimal("1.00") },
            new RefVisaType { Id=Guid.Parse("b43f7f2a-ff95-4bfe-9148-e31b7b507dd4"), Code="M1", Description="Foreign Student pursuing vocational or non-academic studies Visa", SortOrder=Convert.ToDecimal("2.00") },
            new RefVisaType { Id=Guid.Parse("228ed8d6-f923-47bb-be8c-d0ad843345c6"), Code="H1", Description="Employment Visa", SortOrder=Convert.ToDecimal("3.00") },
            new RefVisaType { Id=Guid.Parse("37ad7182-46e3-4171-a31a-80725f31f044"), Code="B1", Description="Business Visa", SortOrder=Convert.ToDecimal("4.00") },
            new RefVisaType { Id=Guid.Parse("81e68f60-0cac-4f80-9c78-3a80b8b10ddb"), Code="B2", Description="Tourist Visa", SortOrder=Convert.ToDecimal("5.00") },
            new RefVisaType { Id=Guid.Parse("4a5eb374-acfb-4b9f-8522-c96610bd3e02"), Code="J1", Description="Exchange Scholar Visa", SortOrder=Convert.ToDecimal("6.00") },
            new RefVisaType { Id=Guid.Parse("41b7a00b-4a32-45d7-aa55-87fbeffd7a0b"), Code="OV", Description="Other Visa", SortOrder=Convert.ToDecimal("7.00") },
       };
   }
}
