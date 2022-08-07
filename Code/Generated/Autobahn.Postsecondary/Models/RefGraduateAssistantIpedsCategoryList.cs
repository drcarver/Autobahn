//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   RefGraduateAssistantIpedsCategoryList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The list of RefGraduateAssistantIpedsCategory Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefGraduateAssistantIpedsCategoryModel"> List
         /// </summary>
        public static List<RefGraduateAssistantIpedsCategoryModel> RefGraduateAssistantIpedsCategoryList = new List<RefGraduateAssistantIpedsCategoryModel>
        {
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("c8ef59bf-173a-48ae-a2c1-fb65472b9a21"), Code="01", Description="Teaching", Definition="Teaching is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("1.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("51939929-0c99-4de2-b89b-e4487fd1c12b"), Code="02", Description="Research", Definition="Research is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("2.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("1f55a6b3-ec6a-4ac5-baf4-d23c916ac191"), Code="03", Description="Management Occupations", Definition="Management Occupations is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("3.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("6aae9a64-b6d1-42b4-a6d3-992eef090058"), Code="04", Description="Business and Financial Occupations", Definition="Business and Financial Occupations is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("4.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("cae39c77-c3de-4e1f-8e0e-054e5d081b7a"), Code="05", Description="Computer, Engineering and Science Occupations", Definition="Computer, Engineering and Science Occupations is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("5.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("bd468076-890b-4eb2-853b-9a46535a3312"), Code="06", Description="Community Service, Legal, Arts and Media Occupations", Definition="Community Service, Legal, Arts and Media Occupations is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("6.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("b22277db-ddea-4dc3-a28b-ac53dde2e903"), Code="07", Description="Library and Non-postsecondary Teaching", Definition="Library and Non-postsecondary Teaching is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("7.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("a503c79b-0c2c-4fcc-8633-ead95fd21ba1"), Code="08", Description="Healthcare Practitioners and Technical Occupations", Definition="Healthcare Practitioners and Technical Occupations is the Integrated Postsecondary Education Data System (IPEDS) occupational category used to report graduate assistants.", SortOrder=Convert.ToDecimal("8.00") },
        };

        /// <summary>
        /// The Reference RefGraduateAssistantIpedsCategory Pick List
         /// </summary>
        public static List<ReferencePickListItemViewModel> RefGraduateAssistantIpedsCategoryViewModelPickerList = new List<ReferencePickListItemViewModel>
        {
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("c8ef59bf-173a-48ae-a2c1-fb65472b9a21"), Description="Teaching", SortOrder=Convert.ToDecimal("1.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("51939929-0c99-4de2-b89b-e4487fd1c12b"), Description="Research", SortOrder=Convert.ToDecimal("2.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("1f55a6b3-ec6a-4ac5-baf4-d23c916ac191"), Description="Management Occupations", SortOrder=Convert.ToDecimal("3.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("6aae9a64-b6d1-42b4-a6d3-992eef090058"), Description="Business and Financial Occupations", SortOrder=Convert.ToDecimal("4.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("cae39c77-c3de-4e1f-8e0e-054e5d081b7a"), Description="Computer, Engineering and Science Occupations", SortOrder=Convert.ToDecimal("5.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("bd468076-890b-4eb2-853b-9a46535a3312"), Description="Community Service, Legal, Arts and Media Occupations", SortOrder=Convert.ToDecimal("6.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("b22277db-ddea-4dc3-a28b-ac53dde2e903"), Description="Library and Non-postsecondary Teaching", SortOrder=Convert.ToDecimal("7.00") },
            new RefGraduateAssistantIpedsCategory { Id=Guid.Parse("a503c79b-0c2c-4fcc-8633-ead95fd21ba1"), Description="Healthcare Practitioners and Technical Occupations", SortOrder=Convert.ToDecimal("8.00") },
       };
   }
}
