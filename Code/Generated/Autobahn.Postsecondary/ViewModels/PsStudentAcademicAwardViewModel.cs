//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardViewModel.cs
//* Name:       Academic Award Date
//* Definition: The year, month and day or year and month on which the academic award was conferred.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The year, month and day or year and month on which the academic award was conferred.
     /// </summary>
    public partial class PsStudentAcademicAwardViewModel : ViewModelBase, Interfaces.IPsStudentAcademicAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAcademicAward";

        // AcademicAwardDate -- (backing property for Academic Award Date)
        private System.String _AcademicAwardDate;

        // AcademicAwardTitle -- (backing property for Academic Award Title)
        private System.String _AcademicAwardTitle;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefAcademicAwardLevelId -- (backing property for Academic Award Level Conferred)
        private Guid? _RefAcademicAwardLevelId;

        // RefAcademicAwardPrerequisiteTypeId -- (backing property for Academic Award Prerequisite Type)
        private Guid? _RefAcademicAwardPrerequisiteTypeId;

        // RefPESCAwardLevelTypeId -- (backing property for PESC Award Level Type)
        private Guid? _RefPESCAwardLevelTypeId;

        // RequirementsURL -- (backing property for Academic Award Requirements URL)
        private System.String _RequirementsURL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Academic Award Date
        /// <para>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19001">Academic Award Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AcademicAwardDate { get => _AcademicAwardDate; set => SetProperty(ref _AcademicAwardDate, value); }

        /// <summary>
        /// Academic Award Title
        /// <para>
        /// The descriptive title for the academic award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19003">Academic Award Title</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String AcademicAwardTitle { get => _AcademicAwardTitle; set => SetProperty(ref _AcademicAwardTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Academic Award Level Conferred
        /// <para>
        /// An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.   
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19002">Academic Award Level Conferred</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAcademicAwardLevelId { get => _RefAcademicAwardLevelId; set => SetProperty(ref _RefAcademicAwardLevelId, value); }

        /// <summary>
        /// Academic Award Prerequisite Type
        /// <para>
        /// Prerequisite conditions for earning an academic award.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20647">Academic Award Prerequisite Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAcademicAwardPrerequisiteTypeId { get => _RefAcademicAwardPrerequisiteTypeId; set => SetProperty(ref _RefAcademicAwardPrerequisiteTypeId, value); }

        /// <summary>
        /// PESC Award Level Type
        /// <para>
        /// An indicator of the category of award conferred by a college, university, or other postsecondary education institution as official recognition for the successful completion of a program of study.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20649">PESC Award Level Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPESCAwardLevelTypeId { get => _RefPESCAwardLevelTypeId; set => SetProperty(ref _RefPESCAwardLevelTypeId, value); }

        /// <summary>
        /// Academic Award Requirements URL
        /// <para>
        /// A URL to a page that describes the requirements for the credential.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20646">Academic Award Requirements URL</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String RequirementsURL { get => _RequirementsURL; set => SetProperty(ref _RequirementsURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicAward model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicAwardDate = model.AcademicAwardDate; // Academic Award Date
            AcademicAwardTitle = model.AcademicAwardTitle; // Academic Award Title
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefAcademicAwardLevelId = model.RefAcademicAwardLevelId; // Academic Award Level Conferred
            RefAcademicAwardPrerequisiteTypeId = model.RefAcademicAwardPrerequisiteTypeId; // Academic Award Prerequisite Type
            RefPESCAwardLevelTypeId = model.RefPESCAwardLevelTypeId; // PESC Award Level Type
            RequirementsURL = model.RequirementsURL; // Academic Award Requirements URL
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefPESCAwardLevelType List
        /// <summary>
        /// The complete Academic Award Date List
        /// </summary>
        private static List<ReferenceModelBase> RefPESCAwardLevelTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("d6b2b85d-7c78-478d-8710-bec849482870"), Code="1.1", Description="Certificate of completion", Definition="Certificate of completion", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("7418d092-2130-46db-a6e7-8e769e48f01d"), Code="1.2", Description="Certificate of proficiency", Definition="Certificate of proficiency", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("335e21be-4339-40a1-bbad-3967e20d4ace"), Code="2.0", Description="Certificate", Definition="Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5b673a44-190a-4273-95de-16615acce057"), Code="2.1", Description="Postsecondary Certificate Or Diploma (less than one year)", Definition="Postsecondary Certificate Or Diploma (less than one year)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6c84dce3-4122-4dea-8823-b26adcd0b4a3"), Code="2.2", Description="Postsecondary Certificate Or Diploma (one year or more but less than four years)", Definition="Postsecondary Certificate Or Diploma (one year or more but less than four years)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a64b9120-5d20-4fd5-8ed1-02d09e2ff1dc"), Code="2.3", Description="Associate Degree (e.g., Associate In Arts, Associate In Science)", Definition="Associate Degree (e.g., Associate In Arts, Associate In Science)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1726c700-d998-4da7-baba-10325f7102ca"), Code="2.4", Description="Baccalaureate Degree", Definition="Baccalaureate Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("24b47725-5881-4a34-94b4-bc7d41877de9"), Code="2.5", Description="Baccalaureate (Honors) Degree", Definition="Baccalaureate (Honors) Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("77a25da4-12a8-4efa-ad09-839f04a5af87"), Code="2.6", Description="Postsecondary Certificate Or Diploma (one year or more but less than two years)", Definition="Postsecondary Certificate Or Diploma (one year or more but less than two years)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("bad99d09-0bcc-4474-b20d-0ec641e62977"), Code="2.7", Description="Postsecondary Certificate Or Diploma (two years or more but less than four years)", Definition="Postsecondary Certificate Or Diploma (two years or more but less than four years)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1cce92c4-ce4a-4349-9e89-b0a531c979a4"), Code="3.1", Description="First Professional Degree", Definition="First Professional Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("0bc41276-e022-4f08-928b-792ab24ba112"), Code="3.2", Description="Post-Professional Degree", Definition="Post-Professional Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("bde0e824-3899-4a23-b7ba-f593645f6760"), Code="4.1", Description="Graduate Certificate", Definition="Graduate Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("abc51561-fabc-444e-883a-8104284b26fb"), Code="4.2", Description="Master's Degree", Definition="Master's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("f5fc1b43-4389-4322-bd09-0caf393437e5"), Code="4.3", Description="Intermediate Graduate Degree", Definition="Intermediate Graduate Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("268b71a0-dbf3-45b4-80c6-39ffb6b1ff62"), Code="4.4", Description="Doctoral Degree", Definition="Doctoral Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("bffe9b69-8a95-42e3-bca5-070fa5048826"), Code="4.5", Description="Post-doctoral Award", Definition="Post-doctoral Award", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("cc9b46e9-1f9b-420f-a0e8-13dd8a272296"), Code="B17", Description="Did not complete secondary school", Definition="Did not complete secondary school", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a0ae89a1-efc8-45a8-8209-9dc2e877bf16"), Code="B18", Description="Standard High School Diploma which may or may not include an exit test", Definition="Standard High School Diploma which may or may not include an exit test", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("4125f890-d158-486f-8fd2-64655b7026f7"), Code="B19", Description="Advanced or honors diploma", Definition="Advanced or honors diploma", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5dbf44eb-34ef-4f0d-a6e6-55e343e195f7"), Code="B20", Description="Vocational diploma", Definition="Vocational diploma", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("fc022674-3043-4c64-abf0-de27bf33d70c"), Code="B21", Description="Special Education Diploma normally for students with a disability", Definition="Special Education Diploma normally for students with a disability", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("e56d16fc-a702-4165-a6c3-4465098a3ed8"), Code="B22", Description="Certificate of completion or attendance", Definition="Certificate of completion or attendance", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("601d3277-c6ea-4328-99de-911e8dc4600a"), Code="B23", Description="Special certificate of completion or attendance", Definition="Special certificate of completion or attendance", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("f73a2bd0-4b27-4931-be0b-fc850c7e2da1"), Code="B24", Description="General Education Development Test Diploma (GED)", Definition="General Education Development Test Diploma (GED)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("fecd7961-74d0-443e-8ede-23bcd03bdd63"), Code="B25", Description="Other high school equivalency diploma", Definition="Other high school equivalency diploma", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1886063d-182d-4407-8661-c32f370ce204"), Code="B26", Description="International diploma or certificate (such as International Baccalaureate)", Definition="International diploma or certificate (such as International Baccalaureate)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("de504e96-dbd5-4d7a-a1c4-cf1160b2dd1d"), Code="B27", Description="Standard High School Diploma with only 3 year curriculum", Definition="Standard High School Diploma with only 3 year curriculum", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("dedde43f-82ad-40f3-baa5-5910328f3810"), Code="B28", Description="Met all graduation requirements except for required exit test", Definition="Met all graduation requirements except for required exit test", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5b870206-e0f2-4c47-9d0b-6e958cdb1b7b"), Code="IPEDS1", Description="Postsecondary award, certificate, or diploma of less than one academic year (less than 900 contact or clock hours)", Definition="Postsecondary award, certificate, or diploma of less than one academic year (less than 900 contact or clock hours)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("712f7e5f-ac1c-465f-9b42-16a02d96f3a6"), Code="IPEDS10", Description="First-Professional Degree", Definition="First-Professional Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("49b0e8c4-cca8-46e9-93cb-40871650082e"), Code="IPEDS11", Description="First-Professional Certificate (Post-Degree)", Definition="First-Professional Certificate (Post-Degree)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("42b5176f-8b48-47c6-b920-f17bec76b3a9"), Code="IPEDS17", Description="Doctor's degree - research/scholarship", Definition="Doctor's degree - research/scholarship", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5f7e8677-39e3-40be-bb64-166ece541d11"), Code="IPEDS18", Description="Doctor's degree - professional practice", Definition="Doctor's degree - professional practice", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("0f1d24b6-a09d-4c4c-89c6-e80853bf31d9"), Code="IPEDS19", Description="Doctor's degree - other Award Levels", Definition="Doctor's degree - other Award Levels", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("38f1e7cf-fa81-45a9-b0b4-54f7eee17734"), Code="IPEDS2", Description="Postsecondary award, certificate, or diploma of at least one but less than two academic years (at least 900 but less than 1800 contact or clock hours)", Definition="Postsecondary award, certificate, or diploma of at least one but less than two academic years (at least 900 but less than 1800 contact or clock hours)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("d045c9bc-59ad-4ae3-8581-e1049e3c127e"), Code="IPEDS3", Description="Associate's Degree", Definition="Associate's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("4c99a3c8-0af5-47b1-a5c1-29feae3c70c2"), Code="IPEDS4", Description="Postsecondary award, certificate, or diploma of at least two but less than four academic years (at least 1800 contact or clock hours)", Definition="Postsecondary award, certificate, or diploma of at least two but less than four academic years (at least 1800 contact or clock hours)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5c9a51eb-3501-4082-9715-13dacea619a9"), Code="IPEDS5", Description="Bachelor's Degree or equivalent", Definition="Bachelor's Degree or equivalent", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("3102a3d2-4070-4ef5-8c2e-7a5c449d3672"), Code="IPEDS6", Description="Postbaccalaureate Certificate", Definition="Postbaccalaureate Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("359617ba-0d24-4162-839f-c68de9268c8c"), Code="IPEDS7", Description="Master's Degree", Definition="Master's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("d056a02d-4102-437e-810d-1ddd84bf739e"), Code="IPEDS8", Description="Post Masters Certificate", Definition="Post Masters Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("3cca23fc-dbfe-45f5-b14b-afd6731c1614"), Code="IPEDS9", Description="Doctor's Degree", Definition="Doctor's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("e02c2f02-848b-4156-aa67-37fb2c89eed2"), Code="CEGEP", Description="CEGEP (an award made by Canadian secondary schools that is typically equivalent to a high school diploma plus one year of college level courses)", Definition="CEGEP (an award made by Canadian secondary schools that is typically equivalent to a high school diploma plus one year of college level courses)", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("a55a33d0-39f0-43ab-90b2-781233b1a611"), Code="FrenchBaccalaureate", Description="French Baccalaureate (award made to high school students that allows French and international students to obtain a standardized qualification)", Definition="French Baccalaureate (an award made to high school students who complete a rigorous program of study including foreign languages. It allows French and international students to obtain a standardized qualification, typically at the age of 18)", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("00b44cab-8261-4119-87a1-a4c59c62cf28"), Code="4.0", Description="Graduate non-degree - value to represent an award from graduate coursework that is not a certificate or degree", Definition="Graduate non-degree - value to represent an award from graduate coursework that is not a certificate or degree", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("d764ad5f-5fc1-446f-a98d-355e6d2d97db"), Code="3.3", Description="Graduate Professional - value to represent an award from graduate coursework in a professional program", Definition="Graduate Professional - value to represent an award from graduate coursework in a professional program", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("72473938-92f7-4493-bd8f-7ab13c0afc90"), Code="0.0", Description="Other - value to represent an award that does not otherwise fit existing enumerations", Definition="Other - value to represent an award that does not otherwise fit existing enumerations", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("3270dd80-ae25-4436-9f61-1099d12b9672"), Code="1.5", Description="Statement of achievement", Definition="Statement of achievement", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("226d8727-a64c-4a98-8e28-bb85d72cf094"), Code="1.4", Description="Statement of completion", Definition="Statement of completion", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("3418b178-8495-45f6-9292-c07f88767707"), Code="1.3", Description="Statement of participation", Definition="Statement of participation", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("cc0b2ffb-ac40-4149-825a-04f9007ef76c"), Code="2.8", Description="Undergraduate non-degree - value to represent an award from undergraduate coursework that is not a certificate or degree", Definition="Undergraduate non-degree - value to represent an award from undergraduate coursework that is not a certificate or degree", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion
    }
}
