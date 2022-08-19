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
            new ReferenceModelBase { Id=Guid.Parse("6f3a1442-f573-49c9-9af6-00a28cc1fd8a"), Code="73056", Description="Adult Basic Education", Definition="Adult Basic Education", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("81bd4e5c-005e-4072-a284-e75c73d53af2"), Code="73058", Description="Adult English as a Second Language", Definition="Adult English as a Second Language", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("09acb829-19e1-4a1c-a5ad-b3a81af97a15"), Code="73057", Description="Adult Secondary Education", Definition="Adult Secondary Education", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("cdbfd825-fc61-460b-afa7-2f945f3538e8"), Code="04961", Description="Alternative Education", Definition="Alternative Education", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("977cfb29-cc14-437e-93e2-8a0e858350b6"), Code="04932", Description="Athletics", Definition="Athletics", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("5361e26f-d20b-4be8-9286-b00c52b599c6"), Code="04923", Description="Bilingual education program", Definition="Bilingual education program", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("6c3edce3-c0e3-4898-b649-cfb52dc86329"), Code="04906", Description="Career and Technical Education", Definition="Career and Technical Education", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("890f0369-1d52-4743-b169-3cc8f3476700"), Code="04931", Description="Cocurricular programs", Definition="Cocurricular programs", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("bf92110a-c4e7-4ce6-be55-c4df15e02934"), Code="04958", Description="College preparatory", Definition="College preparatory", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("96053bbf-1512-461e-96ad-4058349bfd08"), Code="04945", Description="Community service program", Definition="Community service program", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("c8c7a67a-dce5-4c55-860a-30d2a4a4c17f"), Code="04944", Description="Community/junior college education program", Definition="Community/junior college education program", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("1cfbe0ef-ab44-4fd2-95f0-bd842b03f6aa"), Code="04922", Description="Compensatory services for disadvantaged students", Definition="Compensatory services for disadvantaged students", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("1aad419f-d1c0-42a5-b24b-7fb3756b4d70"), Code="73059", Description="Continuing Education", Definition="Continuing Education", SortOrder=Convert.ToDecimal("25.00") },
            new ReferenceModelBase { Id=Guid.Parse("b82cd4ce-bef6-4873-9caa-90452b169bf9"), Code="04956", Description="Counseling services", Definition="Counseling services", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("a1c275d0-7280-4932-bdd8-114fb5d64b89"), Code="14609", Description="Early Head Start", Definition="Early Head Start", SortOrder=Convert.ToDecimal("27.00") },
            new ReferenceModelBase { Id=Guid.Parse("fe7de0bf-78c0-4ab1-9a94-c1be15e3fc74"), Code="04928", Description="English as a second language (ESL) program", Definition="English as a second language (ESL) program", SortOrder=Convert.ToDecimal("28.00") },
            new ReferenceModelBase { Id=Guid.Parse("3c4b0177-dfd5-4bc2-8011-9ec86b3c8f69"), Code="04919", Description="Even Start", Definition="Even Start", SortOrder=Convert.ToDecimal("30.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f3f3777-56b1-4ae5-a75b-474c8d87c1a7"), Code="04955", Description="Extended day/child care services", Definition="Extended day/child care services", SortOrder=Convert.ToDecimal("32.00") },
            new ReferenceModelBase { Id=Guid.Parse("19d62c05-3b49-4d24-adb6-d9c5fdd000b6"), Code="75000", Description="Foster Care", Definition="Foster Care", SortOrder=Convert.ToDecimal("33.00") },
            new ReferenceModelBase { Id=Guid.Parse("fdfc55d7-a107-40d9-991a-09c71cea4c86"), Code="04930", Description="Gifted and talented program", Definition="Gifted and talented program", SortOrder=Convert.ToDecimal("34.00") },
            new ReferenceModelBase { Id=Guid.Parse("7171a419-d780-4a01-9c1e-8339aa80172a"), Code="04918", Description="Head start", Definition="Head start", SortOrder=Convert.ToDecimal("36.00") },
            new ReferenceModelBase { Id=Guid.Parse("215333e2-5482-4a3c-8b3a-faaddb873182"), Code="04963", Description="Health Services Program", Definition="Health Services Program", SortOrder=Convert.ToDecimal("38.00") },
            new ReferenceModelBase { Id=Guid.Parse("04bc57e5-83cc-4bd5-b841-cf1eae43802c"), Code="04957", Description="Immigrant education", Definition="Immigrant education", SortOrder=Convert.ToDecimal("40.00") },
            new ReferenceModelBase { Id=Guid.Parse("42b8e45c-5837-4e1b-bb2c-cef87504940f"), Code="04921", Description="Indian education", Definition="Indian education", SortOrder=Convert.ToDecimal("42.00") },
            new ReferenceModelBase { Id=Guid.Parse("98c2ed8f-d2ff-491e-9424-06c461dd9f03"), Code="04959", Description="International Baccalaureate", Definition="International Baccalaureate", SortOrder=Convert.ToDecimal("44.00") },
            new ReferenceModelBase { Id=Guid.Parse("04e93326-03df-4992-aeb4-9e31b62c775d"), Code="04962", Description="Library/Media Services Program", Definition="Library/Media Services Program", SortOrder=Convert.ToDecimal("46.00") },
            new ReferenceModelBase { Id=Guid.Parse("5bc368b7-8e18-40c4-ae4a-481c0a118bc2"), Code="04960", Description="Magnet/Special Program Emphasis", Definition="Magnet/Special Program Emphasis", SortOrder=Convert.ToDecimal("48.00") },
            new ReferenceModelBase { Id=Guid.Parse("8337892b-a79e-4ac5-915a-9d5cb126de87"), Code="04920", Description="Migrant education", Definition="Migrant education", SortOrder=Convert.ToDecimal("50.00") },
            new ReferenceModelBase { Id=Guid.Parse("33a42108-7ad5-4062-a5c5-d6f3aec98801"), Code="04887", Description="Regular education", Definition="Regular education", SortOrder=Convert.ToDecimal("52.00") },
            new ReferenceModelBase { Id=Guid.Parse("a2f75844-5f91-4c57-9c57-e52332e4ed74"), Code="04964", Description="Remedial education", Definition="Remedial education", SortOrder=Convert.ToDecimal("54.00") },
            new ReferenceModelBase { Id=Guid.Parse("4ae8a3e1-5de0-4882-95ad-f135b483e711"), Code="04967", Description="Section 504 Placement", Definition="Section 504 Placement", SortOrder=Convert.ToDecimal("56.00") },
            new ReferenceModelBase { Id=Guid.Parse("12be4078-7e86-49b8-820a-d9c9116303e8"), Code="04966", Description="Service learning", Definition="Service learning", SortOrder=Convert.ToDecimal("58.00") },
            new ReferenceModelBase { Id=Guid.Parse("ae25daab-c033-4a62-af17-d89fcc8436ea"), Code="04888", Description="Special Education Services", Definition="Special Education Services", SortOrder=Convert.ToDecimal("60.00") },
            new ReferenceModelBase { Id=Guid.Parse("18f2813b-78af-4f3e-afa9-6a0bd0b2db2c"), Code="04954", Description="Student retention/ Dropout Prevention", Definition="Student retention/ Dropout Prevention", SortOrder=Convert.ToDecimal("62.00") },
            new ReferenceModelBase { Id=Guid.Parse("bac06678-e25b-4371-a3c7-50e37c3e60a9"), Code="04953", Description="Substance abuse education/prevention", Definition="Substance abuse education/prevention", SortOrder=Convert.ToDecimal("64.00") },
            new ReferenceModelBase { Id=Guid.Parse("6578adcf-43ae-44a5-bdf7-114a319deba8"), Code="73204", Description="Targeted intervention program", Definition="Targeted intervention program", SortOrder=Convert.ToDecimal("65.00") },
            new ReferenceModelBase { Id=Guid.Parse("baab69c4-2eeb-4af8-a109-8411407e0dda"), Code="04968", Description="Teacher professional development / Mentoring", Definition="Teacher professional development / Mentoring", SortOrder=Convert.ToDecimal("66.00") },
            new ReferenceModelBase { Id=Guid.Parse("463eea1d-5141-4319-926a-26e75bd268ca"), Code="04917", Description="Technical preparatory", Definition="Technical preparatory", SortOrder=Convert.ToDecimal("68.00") },
            new ReferenceModelBase { Id=Guid.Parse("c8883dc9-4a84-4bbe-bdef-4ad2884041dd"), Code="75001", Description="Title I", Definition="Title I", SortOrder=Convert.ToDecimal("69.00") },
            new ReferenceModelBase { Id=Guid.Parse("3d0d893a-8d12-4601-b18b-4b2768937845"), Code="73090", Description="Work-based Learning Opportunities", Definition="Work-based Learning Opportunities", SortOrder=Convert.ToDecimal("70.00") },
            new ReferenceModelBase { Id=Guid.Parse("da36a6ae-0570-4532-881c-ac1a0e7b8700"), Code="75014", Description="Autism program", Definition="A program specifically designed for students with the IDEA Disability Type autism.", SortOrder=Convert.ToDecimal("71.00") },
            new ReferenceModelBase { Id=Guid.Parse("1dcae134-c3a5-4293-973c-aa8898338493"), Code="09999", Description="Other", Definition="The program type is in a category not yet defined in CEDS.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("2ce11d6b-78aa-4f83-b0b4-df17ace67c07"), Code="75015", Description="Early childhood special education tier one program", Definition="A program specifically designed for early childhood special education students that provides services to special education students with an intensity defined by the state or other authoritative organization.", SortOrder=Convert.ToDecimal("72.00") },
            new ReferenceModelBase { Id=Guid.Parse("ee20771b-6843-4170-8a1b-58f6c37b051a"), Code="75016", Description="Early childhood special education tier two program", Definition="A program specifically designed for early childhood special education students that provides services to special education students with an intensity, as defined by the state or other authoritative organization, greater than the early childhood special education tier one program.", SortOrder=Convert.ToDecimal("73.00") },
            new ReferenceModelBase { Id=Guid.Parse("9c1ec0f3-7af9-4b2e-b614-79d6d4a062e9"), Code="75002", Description="Early College", Definition="A program of study in which students participate in a comprehensive plan that integrates their high school course of study and an intentionally designed authentic postsecondary experience leading to their regular high school diploma, an official college transcript, and transferable college credit towards a recognized postsecondary degree or credential.", SortOrder=Convert.ToDecimal("74.00") },
            new ReferenceModelBase { Id=Guid.Parse("cd2b33b7-d073-4852-a716-09d130b409a4"), Code="75006", Description="Emotional disturbance program", Definition="A program specifically designed for students with the IDEA Disability Type emotional disturbance.", SortOrder=Convert.ToDecimal("75.00") },
            new ReferenceModelBase { Id=Guid.Parse("1d186df7-3741-4ec3-82ce-108a1fe446e0"), Code="75008", Description="Hearing impairment program", Definition="A program specifically designed for students with the IDEA Disability Type hearing impairment.", SortOrder=Convert.ToDecimal("76.00") },
            new ReferenceModelBase { Id=Guid.Parse("36a22689-d340-44dd-9ef4-67acb121d31b"), Code="75017", Description="K12 Resource Program", Definition="A program designed to provide additional resources to special education students.", SortOrder=Convert.ToDecimal("77.00") },
            new ReferenceModelBase { Id=Guid.Parse("b670e81f-27ab-4374-bdf5-0870cbf5f97f"), Code="75003", Description="Mild cognitive disability program", Definition="A program specifically designed for students who have been determined to have a mild cognitive disability.", SortOrder=Convert.ToDecimal("78.00") },
            new ReferenceModelBase { Id=Guid.Parse("bc46b877-e537-47c5-91eb-b4faa7ac353b"), Code="75004", Description="Moderate cognitive disability program", Definition="A program specifically designed for students who have been determined to have a moderate cognitive disability.", SortOrder=Convert.ToDecimal("79.00") },
            new ReferenceModelBase { Id=Guid.Parse("e8cd7a75-97fc-49e4-a9b2-85a2ffb36aec"), Code="75012", Description="Multiple disabilities program", Definition="A program specifically designed for students with the IDEA Disability type   multiple disabilities.", SortOrder=Convert.ToDecimal("80.00") },
            new ReferenceModelBase { Id=Guid.Parse("fa22dffb-2f87-4f92-a8ce-5966b0d3991f"), Code="75011", Description="Orthopedic impairment", Definition="A program specifically designed for students with the IDEA Disability Type orthopedic impairments.", SortOrder=Convert.ToDecimal("81.00") },
            new ReferenceModelBase { Id=Guid.Parse("b49888d9-74d0-492f-87a4-6dfbb95dcc3c"), Code="75010", Description="Other health impairment", Definition="A program specifically designed for students with the IDEA Disability Type other health impairments.", SortOrder=Convert.ToDecimal("82.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b33fe66-c792-4f42-894b-609c20e72fd6"), Code="75005", Description="Significant cognitive disability program", Definition="A program specifically designed for students who have been determined to have a significant cognitive disability.", SortOrder=Convert.ToDecimal("83.00") },
            new ReferenceModelBase { Id=Guid.Parse("bea8e008-59cd-46c9-a87b-9770e5b52e2d"), Code="75007", Description="Specific learning disability program", Definition="A program specifically designed for students with the IDEA Disability Type specific learning disability", SortOrder=Convert.ToDecimal("84.00") },
            new ReferenceModelBase { Id=Guid.Parse("6af0202e-f4c5-47c2-8116-6f069face526"), Code="75013", Description="Speech or language impairment program", Definition="A program specifically designed for students with the IDEA Disability Type speech or language impairment.", SortOrder=Convert.ToDecimal("85.00") },
            new ReferenceModelBase { Id=Guid.Parse("f5a4b381-7bcd-4539-a000-4f6458c70a9a"), Code="75009", Description="Visual impairment program", Definition="A program specifically designed for students with the IDEA Disability Type visual health impairment.", SortOrder=Convert.ToDecimal("86.00") },
        };
        #endregion
    }
}
