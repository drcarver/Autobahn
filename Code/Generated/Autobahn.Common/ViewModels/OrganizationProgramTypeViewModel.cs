//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationProgramTypeViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationProgramType View Model
     /// </summary>
    public partial class OrganizationProgramTypeViewModel : ViewModelBase, Interfaces.IOrganizationProgramType
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationProgramType";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefProgramTypeId -- (backing property for Program Type)
        private Guid _RefProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Program Type
        /// <para>
        /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19225">Program Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefProgramTypeId { get => _RefProgramTypeId; set => SetProperty(ref _RefProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationProgramType model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefProgramTypeId = model.RefProgramTypeId; // Program Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefProgramType List
        /// <summary>
        /// The complete <see cref="RefProgramType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefProgramTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("06a14663-2eec-43fd-995e-deb653eea80b"), Code="73056", Description="Adult Basic Education", Definition="Adult Basic Education", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("1d15883c-3528-416d-84d3-08f984ca5c37"), Code="73058", Description="Adult English as a Second Language", Definition="Adult English as a Second Language", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("3697ba27-d748-48fb-b110-af1e0d1d4624"), Code="73057", Description="Adult Secondary Education", Definition="Adult Secondary Education", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("61e305d9-3329-48af-b636-79d5edda9e45"), Code="04961", Description="Alternative Education", Definition="Alternative Education", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("3df659f2-fa61-4a79-a99a-dc5ff030aea9"), Code="04932", Description="Athletics", Definition="Athletics", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("f1b3e3cf-1a81-4f6c-afd0-97ec64fc36f2"), Code="04923", Description="Bilingual education program", Definition="Bilingual education program", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d72b8a5-d2cf-49ff-82b2-42c1d767caac"), Code="04906", Description="Career and Technical Education", Definition="Career and Technical Education", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("0be704cb-c94d-4dc6-aec1-07255834734c"), Code="04931", Description="Cocurricular programs", Definition="Cocurricular programs", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("34e6e157-8f71-4239-8700-761c82a2849d"), Code="04958", Description="College preparatory", Definition="College preparatory", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("6a4de742-ccf4-4deb-992d-59db126d01d7"), Code="04945", Description="Community service program", Definition="Community service program", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("cab90bcd-4da6-4747-84a1-01b5664b8efe"), Code="04944", Description="Community/junior college education program", Definition="Community/junior college education program", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("8861a9b8-0bc5-4384-88a7-94725fe63fb5"), Code="04922", Description="Compensatory services for disadvantaged students", Definition="Compensatory services for disadvantaged students", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("aa83fc51-8c51-41b6-ad01-01396f5b032a"), Code="73059", Description="Continuing Education", Definition="Continuing Education", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("3c0c3f01-350e-487e-b28a-80eb377781d8"), Code="04956", Description="Counseling services", Definition="Counseling services", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("28b41153-3589-4fb8-8c1f-1dc0ec841e5f"), Code="14609", Description="Early Head Start", Definition="Early Head Start", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("8e1443db-4c00-4d3b-8b5c-e904e39a93fc"), Code="04928", Description="English as a second language (ESL) program", Definition="English as a second language (ESL) program", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("4b322abd-1c8c-44f1-ae0e-3fb678405f75"), Code="04919", Description="Even Start", Definition="Even Start", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("b676ab97-0621-4c9f-adeb-fbc28c9db6fc"), Code="04955", Description="Extended day/child care services", Definition="Extended day/child care services", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("491778dc-135d-4544-b4fe-76d33b8d3843"), Code="75000", Description="Foster Care", Definition="Foster Care", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("156006e9-0a19-4d4a-9f3a-2479dd1992e8"), Code="04930", Description="Gifted and talented program", Definition="Gifted and talented program", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("2e65a749-a8d8-4834-bcbf-6423d4862a5e"), Code="04918", Description="Head start", Definition="Head start", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("53511cfe-5af6-4cd9-9614-b2b7d9aaf3ed"), Code="04963", Description="Health Services Program", Definition="Health Services Program", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("7e3d8fcb-de95-4915-89f5-f65c31649eef"), Code="04957", Description="Immigrant education", Definition="Immigrant education", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("7055541a-eb0a-466e-8247-183e4defc5d0"), Code="04921", Description="Indian education", Definition="Indian education", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("68d1e960-416e-42a7-a40e-3f469d4c7559"), Code="04959", Description="International Baccalaureate", Definition="International Baccalaureate", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("6f39aaa3-c30f-404a-83f0-a81483939bd2"), Code="04962", Description="Library/Media Services Program", Definition="Library/Media Services Program", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdd7b339-973d-4d7b-b7af-256e24c88292"), Code="04960", Description="Magnet/Special Program Emphasis", Definition="Magnet/Special Program Emphasis", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("f635a951-1d72-454d-9768-7dba32ecd5db"), Code="04920", Description="Migrant education", Definition="Migrant education", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("543606ba-4795-41e2-b832-66789eb129a3"), Code="04887", Description="Regular education", Definition="Regular education", SortOrder=Convert.ToDecimal("52.00") },
            new ReferenceModelBase { Id=Guid.Parse("2510a0c7-20d0-4804-ac06-ef1cae2e60a4"), Code="04964", Description="Remedial education", Definition="Remedial education", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("513f15bf-3fd6-4cb4-af3d-0c845ce00bb0"), Code="04967", Description="Section 504 Placement", Definition="Section 504 Placement", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("e603e244-34a0-4e8d-9546-e83de7e0fb44"), Code="04966", Description="Service learning", Definition="Service learning", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("8cb2d0b9-05a9-4afc-84dd-ea0704baf588"), Code="04888", Description="Special Education Services", Definition="Special Education Services", SortOrder=Convert.ToDecimal("60.00") },
            new ReferenceModelBase { Id=Guid.Parse("298e7eb1-5f5e-41a9-a10a-234a0870dc44"), Code="04954", Description="Student retention/ Dropout Prevention", Definition="Student retention/ Dropout Prevention", SortOrder=Convert.ToDecimal("62.00") },
            new ReferenceModelBase { Id=Guid.Parse("5f8b8628-3415-4f88-a16b-c9507e58cb95"), Code="04953", Description="Substance abuse education/prevention", Definition="Substance abuse education/prevention", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("e61cc312-a637-4f5d-903a-a475472f8e02"), Code="73204", Description="Targeted intervention program", Definition="Targeted intervention program", SortOrder=Convert.ToDecimal("65.00") },
            new ReferenceModelBase { Id=Guid.Parse("0fb493f7-7a6d-4db6-b435-a216ba7b23de"), Code="04968", Description="Teacher professional development / Mentoring", Definition="Teacher professional development / Mentoring", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("775ebb5a-7c41-48be-9606-c5761ab1eb24"), Code="04917", Description="Technical preparatory", Definition="Technical preparatory", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("b703adf1-8f2a-447f-9ba4-7fcdd324d5e9"), Code="75001", Description="Title I", Definition="Title I", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("5243ce09-4da1-40e5-b39c-e425c1b22b68"), Code="73090", Description="Work-based Learning Opportunities", Definition="Work-based Learning Opportunities", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("6dc2ec78-d458-4360-8f3b-ae1d2d3110b3"), Code="75014", Description="Autism program", Definition="A program specifically designed for students with the IDEA Disability Type autism.", SortOrder=Convert.ToDecimal("71.00") },
            new ReferenceModelBase { Id=Guid.Parse("c3332894-1c08-4451-a5c3-2224cbdf18a9"), Code="09999", Description="Other", Definition="The program type is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("f1e849d2-fe4f-4a94-b545-ed2e29500cfd"), Code="75015", Description="Early childhood special education tier one program", Definition="A program specifically designed for early childhood special education students that provides services to special education students with an intensity defined by the state or other authoritative organization.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("7fc0fea9-154c-4935-93fa-768e1a2b0771"), Code="75016", Description="Early childhood special education tier two program", Definition="A program specifically designed for early childhood special education students that provides services to special education students with an intensity, as defined by the state or other authoritative organization, greater than the early childhood special education tier one program.", SortOrder=Convert.ToDecimal("73.00") },
            new ReferenceModelBase { Id=Guid.Parse("90cf9617-0cff-4f3b-b33d-f0de6ca043c9"), Code="75002", Description="Early College", Definition="A program of study in which students participate in a comprehensive plan that integrates their high school course of study and an intentionally designed authentic postsecondary experience leading to their regular high school diploma, an official college transcript, and transferable college credit towards a recognized postsecondary degree or credential.", SortOrder=Convert.ToDecimal("74.00") },
            new ReferenceModelBase { Id=Guid.Parse("8a2f905c-def7-4620-b7d1-0fc216c05ac5"), Code="75006", Description="Emotional disturbance program", Definition="A program specifically designed for students with the IDEA Disability Type emotional disturbance.", SortOrder=Convert.ToDecimal("75.00") },
            new ReferenceModelBase { Id=Guid.Parse("48f15aab-0566-4004-ab39-7b8b4ad1851d"), Code="75008", Description="Hearing impairment program", Definition="A program specifically designed for students with the IDEA Disability Type hearing impairment.", SortOrder=Convert.ToDecimal("76.00") },
            new ReferenceModelBase { Id=Guid.Parse("510c0813-e64c-4805-991d-e46884ee3d60"), Code="75017", Description="K12 Resource Program", Definition="A program designed to provide additional resources to special education students.", SortOrder=Convert.ToDecimal("77.00") },
            new ReferenceModelBase { Id=Guid.Parse("925d5e4e-13a6-4d09-b544-91a93aed3de8"), Code="75003", Description="Mild cognitive disability program", Definition="A program specifically designed for students who have been determined to have a mild cognitive disability.", SortOrder=Convert.ToDecimal("78.00") },
            new ReferenceModelBase { Id=Guid.Parse("75262647-8502-451d-aec5-5eaff7c02185"), Code="75004", Description="Moderate cognitive disability program", Definition="A program specifically designed for students who have been determined to have a moderate cognitive disability.", SortOrder=Convert.ToDecimal("79.00") },
            new ReferenceModelBase { Id=Guid.Parse("f3dd6bb9-0b17-417f-9bea-09253400fcd5"), Code="75012", Description="Multiple disabilities program", Definition="A program specifically designed for students with the IDEA Disability type   multiple disabilities.", SortOrder=Convert.ToDecimal("80.00") },
            new ReferenceModelBase { Id=Guid.Parse("cb5a207b-fae2-43a8-89fa-a20e2d037d02"), Code="75011", Description="Orthopedic impairment", Definition="A program specifically designed for students with the IDEA Disability Type orthopedic impairments.", SortOrder=Convert.ToDecimal("81.00") },
            new ReferenceModelBase { Id=Guid.Parse("93f856b4-29b1-4889-b061-581c59565207"), Code="75010", Description="Other health impairment", Definition="A program specifically designed for students with the IDEA Disability Type other health impairments.", SortOrder=Convert.ToDecimal("82.00") },
            new ReferenceModelBase { Id=Guid.Parse("728aabc2-a457-45f7-be41-5a876855cae1"), Code="75005", Description="Significant cognitive disability program", Definition="A program specifically designed for students who have been determined to have a significant cognitive disability.", SortOrder=Convert.ToDecimal("83.00") },
            new ReferenceModelBase { Id=Guid.Parse("f5e97d5e-7a60-463a-b030-9ea013b60d86"), Code="75007", Description="Specific learning disability program", Definition="A program specifically designed for students with the IDEA Disability Type specific learning disability", SortOrder=Convert.ToDecimal("84.00") },
            new ReferenceModelBase { Id=Guid.Parse("2858b8c1-6a38-4d56-87a9-55a1407fe0cd"), Code="75013", Description="Speech or language impairment program", Definition="A program specifically designed for students with the IDEA Disability Type speech or language impairment.", SortOrder=Convert.ToDecimal("85.00") },
            new ReferenceModelBase { Id=Guid.Parse("b89551a5-8bba-49e3-88d8-57c23cc1a8be"), Code="75009", Description="Visual impairment program", Definition="A program specifically designed for students with the IDEA Disability Type visual health impairment.", SortOrder=Convert.ToDecimal("86.00") },
        };
        #endregion
    }
}
