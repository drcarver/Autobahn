//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RefAcademicSubjectList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Assessment.Models
{
     /// <summary>
     /// The list of RefAcademicSubject Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefAcademicSubjectModel"> List
         /// </summary>
        public static List<RefAcademicSubjectModel> RefAcademicSubjectList = new List<RefAcademicSubjectModel>
        {
            new RefAcademicSubject { Id=Guid.Parse("e4e35a88-5352-4265-9891-545730d39991"), Code="13371", Description="Arts", Definition="Arts is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicSubject { Id=Guid.Parse("169b15c0-c05e-4512-9381-c43b98111e4b"), Code="73065", Description="Career and Technical Education", Definition="Career and Technical Education is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicSubject { Id=Guid.Parse("e55ede23-75b1-4a3a-b330-e06fff6a9ae4"), Code="13372", Description="English", Definition="English is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicSubject { Id=Guid.Parse("f9e19d67-c6b1-43d2-8a0e-c0944ae56015"), Code="00256", Description="English as a second language (ESL)", Definition="English as a second language (ESL) is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicSubject { Id=Guid.Parse("e5ba2662-6ae3-41f2-b4ef-04cf817e1deb"), Code="00546", Description="Foreign Languages", Definition="Foreign Languages is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicSubject { Id=Guid.Parse("c0f9a3fc-1c60-42fd-bbbe-5a7feea4b587"), Code="73088", Description="History Government - US", Definition="History Government - US is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicSubject { Id=Guid.Parse("e96e2cae-a664-431f-88ad-761d022b5469"), Code="73089", Description="History Government - World", Definition="History Government - World is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicSubject { Id=Guid.Parse("b38131ed-7bac-487c-b346-2f9ad0d6acb3"), Code="00554", Description="Language arts", Definition="Language arts is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicSubject { Id=Guid.Parse("d4f277dc-fb27-40ef-a68b-805e60af9879"), Code="01166", Description="Mathematics", Definition="Mathematics is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicSubject { Id=Guid.Parse("befee44d-eaf7-4fbf-b329-386dedffa4fa"), Code="00560", Description="Reading", Definition="Reading is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicSubject { Id=Guid.Parse("b85e2f85-9517-4025-84a3-c1550630510a"), Code="13373", Description="Reading/Language Arts", Definition="Reading/Language Arts is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicSubject { Id=Guid.Parse("4d3f8f65-b8c8-45f5-99c8-8fe113f5e370"), Code="00562", Description="Science", Definition="Science is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("18.00") },
            new RefAcademicSubject { Id=Guid.Parse("1aa13ca5-dbfd-4c2f-903d-2385807b2a8d"), Code="73086", Description="Science - Life", Definition="Science - Life is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("20.00") },
            new RefAcademicSubject { Id=Guid.Parse("8b6925f4-3c19-4737-a26e-bef8e41ff3b9"), Code="73087", Description="Science - Physical", Definition="Science - Physical is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("22.00") },
            new RefAcademicSubject { Id=Guid.Parse("7fdd8bb9-1046-4efe-9826-c67a69852e17"), Code="13374", Description="Social Sciences (History, Geography, Economics, Civics and Government)", Definition="Social Sciences (History, Geography, Economics, Civics and Government) is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("24.00") },
            new RefAcademicSubject { Id=Guid.Parse("871664b6-8645-499e-9fec-0087d2103075"), Code="02043", Description="Special education", Definition="Special education is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("26.00") },
            new RefAcademicSubject { Id=Guid.Parse("f0d61b65-7c13-49ea-988c-31329cfaeffd"), Code="01287", Description="Writing", Definition="Writing is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("28.00") },
            new RefAcademicSubject { Id=Guid.Parse("89e4c19f-cc7d-4292-b382-2bb9b50b4127"), Code="09999", Description="Other", Definition="Other is specified as the academic content or subject area being evaluated.", SortOrder=Convert.ToDecimal("30.00") },
        };

        /// <summary>
        /// The Reference RefAcademicSubject Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefAcademicSubjectViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefAcademicSubject { Id=Guid.Parse("e4e35a88-5352-4265-9891-545730d39991"), Description="Arts", SortOrder=Convert.ToDecimal("1.00") },
            new RefAcademicSubject { Id=Guid.Parse("169b15c0-c05e-4512-9381-c43b98111e4b"), Description="Career and Technical Education", SortOrder=Convert.ToDecimal("2.00") },
            new RefAcademicSubject { Id=Guid.Parse("e55ede23-75b1-4a3a-b330-e06fff6a9ae4"), Description="English", SortOrder=Convert.ToDecimal("3.00") },
            new RefAcademicSubject { Id=Guid.Parse("f9e19d67-c6b1-43d2-8a0e-c0944ae56015"), Description="English as a second language (ESL)", SortOrder=Convert.ToDecimal("4.00") },
            new RefAcademicSubject { Id=Guid.Parse("e5ba2662-6ae3-41f2-b4ef-04cf817e1deb"), Description="Foreign Languages", SortOrder=Convert.ToDecimal("5.00") },
            new RefAcademicSubject { Id=Guid.Parse("c0f9a3fc-1c60-42fd-bbbe-5a7feea4b587"), Description="History Government - US", SortOrder=Convert.ToDecimal("7.00") },
            new RefAcademicSubject { Id=Guid.Parse("e96e2cae-a664-431f-88ad-761d022b5469"), Description="History Government - World", SortOrder=Convert.ToDecimal("8.00") },
            new RefAcademicSubject { Id=Guid.Parse("b38131ed-7bac-487c-b346-2f9ad0d6acb3"), Description="Language arts", SortOrder=Convert.ToDecimal("9.00") },
            new RefAcademicSubject { Id=Guid.Parse("d4f277dc-fb27-40ef-a68b-805e60af9879"), Description="Mathematics", SortOrder=Convert.ToDecimal("12.00") },
            new RefAcademicSubject { Id=Guid.Parse("befee44d-eaf7-4fbf-b329-386dedffa4fa"), Description="Reading", SortOrder=Convert.ToDecimal("14.00") },
            new RefAcademicSubject { Id=Guid.Parse("b85e2f85-9517-4025-84a3-c1550630510a"), Description="Reading/Language Arts", SortOrder=Convert.ToDecimal("16.00") },
            new RefAcademicSubject { Id=Guid.Parse("4d3f8f65-b8c8-45f5-99c8-8fe113f5e370"), Description="Science", SortOrder=Convert.ToDecimal("18.00") },
            new RefAcademicSubject { Id=Guid.Parse("1aa13ca5-dbfd-4c2f-903d-2385807b2a8d"), Description="Science - Life", SortOrder=Convert.ToDecimal("20.00") },
            new RefAcademicSubject { Id=Guid.Parse("8b6925f4-3c19-4737-a26e-bef8e41ff3b9"), Description="Science - Physical", SortOrder=Convert.ToDecimal("22.00") },
            new RefAcademicSubject { Id=Guid.Parse("7fdd8bb9-1046-4efe-9826-c67a69852e17"), Description="Social Sciences (History, Geography, Economics, Civics and Government)", SortOrder=Convert.ToDecimal("24.00") },
            new RefAcademicSubject { Id=Guid.Parse("871664b6-8645-499e-9fec-0087d2103075"), Description="Special education", SortOrder=Convert.ToDecimal("26.00") },
            new RefAcademicSubject { Id=Guid.Parse("f0d61b65-7c13-49ea-988c-31329cfaeffd"), Description="Writing", SortOrder=Convert.ToDecimal("28.00") },
            new RefAcademicSubject { Id=Guid.Parse("89e4c19f-cc7d-4292-b382-2bb9b50b4127"), Description="Other", SortOrder=Convert.ToDecimal("30.00") },
       };
   }
}
