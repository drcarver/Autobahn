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
            new ReferenceModelBase { Id=Guid.Parse("1abf3ee6-d24e-4dea-ab56-360a93fbf508"), Code="1.1", Description="Certificate of completion", Definition="Certificate of completion", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a2f77e1b-c9f7-4764-901f-f6762c069667"), Code="1.2", Description="Certificate of proficiency", Definition="Certificate of proficiency", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("0e88b551-541a-4426-b8de-2769fe433cff"), Code="2.0", Description="Certificate", Definition="Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("fc3f4780-5c3d-4d26-b789-8a259c3d9b8d"), Code="2.1", Description="Postsecondary Certificate Or Diploma (less than one year)", Definition="Postsecondary Certificate Or Diploma (less than one year)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a153ab99-e626-4c8f-bbf1-e9ec1cb90028"), Code="2.2", Description="Postsecondary Certificate Or Diploma (one year or more but less than four years)", Definition="Postsecondary Certificate Or Diploma (one year or more but less than four years)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("496d183c-1aee-418b-be8e-257544090b71"), Code="2.3", Description="Associate Degree (e.g., Associate In Arts, Associate In Science)", Definition="Associate Degree (e.g., Associate In Arts, Associate In Science)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8bdeb2cb-05ec-4cb0-9964-402923f0a853"), Code="2.4", Description="Baccalaureate Degree", Definition="Baccalaureate Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("2601c082-7ca2-43d7-a0a7-ab8483bee18e"), Code="2.5", Description="Baccalaureate (Honors) Degree", Definition="Baccalaureate (Honors) Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5ec63957-9440-40c2-8a13-6700e8e76df5"), Code="2.6", Description="Postsecondary Certificate Or Diploma (one year or more but less than two years)", Definition="Postsecondary Certificate Or Diploma (one year or more but less than two years)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("22421c6f-4157-4ac9-bfdb-1dfa1d5bce68"), Code="2.7", Description="Postsecondary Certificate Or Diploma (two years or more but less than four years)", Definition="Postsecondary Certificate Or Diploma (two years or more but less than four years)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1488c058-1e48-4135-9249-bdb80a6075da"), Code="3.1", Description="First Professional Degree", Definition="First Professional Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("1ef7d433-57c7-4652-81d5-30c447d9324f"), Code="3.2", Description="Post-Professional Degree", Definition="Post-Professional Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("903bfd38-063e-40d0-8af4-1a011d0fcbbe"), Code="4.1", Description="Graduate Certificate", Definition="Graduate Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("83ab7b06-3cab-4fd2-9cf1-6c021fb79cba"), Code="4.2", Description="Master's Degree", Definition="Master's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c7ced3c8-670b-41a2-ae95-b7a4d63f0701"), Code="4.3", Description="Intermediate Graduate Degree", Definition="Intermediate Graduate Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("cdba5298-de14-4bcd-93b5-7dda9e8e0d9d"), Code="4.4", Description="Doctoral Degree", Definition="Doctoral Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6c4ce844-31ea-412f-ad70-e8546ef6ef08"), Code="4.5", Description="Post-doctoral Award", Definition="Post-doctoral Award", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("7632afd1-99a6-40fc-b3f9-46fe8611b8ff"), Code="B17", Description="Did not complete secondary school", Definition="Did not complete secondary school", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("48127bf4-8204-4d22-9a13-e7fa4d290d9d"), Code="B18", Description="Standard High School Diploma which may or may not include an exit test", Definition="Standard High School Diploma which may or may not include an exit test", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("ff370214-345e-42d0-a815-41b95bebefb6"), Code="B19", Description="Advanced or honors diploma", Definition="Advanced or honors diploma", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("85d1bb68-a78b-4563-ac4f-1007a6f13b49"), Code="B20", Description="Vocational diploma", Definition="Vocational diploma", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("fb6e2df6-8c70-4bc7-b6a0-1bbb28fce9b4"), Code="B21", Description="Special Education Diploma normally for students with a disability", Definition="Special Education Diploma normally for students with a disability", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("63fadef2-79b3-45d4-a3be-799e26d10f08"), Code="B22", Description="Certificate of completion or attendance", Definition="Certificate of completion or attendance", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("40320fd0-b4bf-433f-9cfb-77e5288d1c3e"), Code="B23", Description="Special certificate of completion or attendance", Definition="Special certificate of completion or attendance", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("294f7e68-ba1d-4eb3-8e18-c03fac1e0445"), Code="B24", Description="General Education Development Test Diploma (GED)", Definition="General Education Development Test Diploma (GED)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("fc6702ca-756d-476b-b588-68cb9a920dc8"), Code="B25", Description="Other high school equivalency diploma", Definition="Other high school equivalency diploma", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8adfd569-7a0f-4d8c-9472-5aeb6ee4b250"), Code="B26", Description="International diploma or certificate (such as International Baccalaureate)", Definition="International diploma or certificate (such as International Baccalaureate)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("8aff13ff-d338-4edd-8f8f-315c41982fbc"), Code="B27", Description="Standard High School Diploma with only 3 year curriculum", Definition="Standard High School Diploma with only 3 year curriculum", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("ae63df46-56f7-477b-9157-2e9efb063a76"), Code="B28", Description="Met all graduation requirements except for required exit test", Definition="Met all graduation requirements except for required exit test", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6c13fce6-e355-427b-9385-68ea566e1708"), Code="IPEDS1", Description="Postsecondary award, certificate, or diploma of less than one academic year (less than 900 contact or clock hours)", Definition="Postsecondary award, certificate, or diploma of less than one academic year (less than 900 contact or clock hours)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("f0f1d4bf-70f3-4215-8e63-585360c3327f"), Code="IPEDS10", Description="First-Professional Degree", Definition="First-Professional Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("400f7629-2e61-4de2-98b7-40539202fab6"), Code="IPEDS11", Description="First-Professional Certificate (Post-Degree)", Definition="First-Professional Certificate (Post-Degree)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("07c20b90-c848-4bb7-b0e0-3e5b9ce534e6"), Code="IPEDS17", Description="Doctor's degree - research/scholarship", Definition="Doctor's degree - research/scholarship", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("0f78bb61-09ec-4139-918f-41c096c84bea"), Code="IPEDS18", Description="Doctor's degree - professional practice", Definition="Doctor's degree - professional practice", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("21901860-adfb-43b0-a2d1-f78b3a539900"), Code="IPEDS19", Description="Doctor's degree - other Award Levels", Definition="Doctor's degree - other Award Levels", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("a7d0d07f-d426-4e45-b8c8-3037d2370b9a"), Code="IPEDS2", Description="Postsecondary award, certificate, or diploma of at least one but less than two academic years (at least 900 but less than 1800 contact or clock hours)", Definition="Postsecondary award, certificate, or diploma of at least one but less than two academic years (at least 900 but less than 1800 contact or clock hours)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("ebba9251-74c0-4551-b3ae-949e9193694a"), Code="IPEDS3", Description="Associate's Degree", Definition="Associate's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("c39cf20a-6b33-4b77-9122-0addb260103b"), Code="IPEDS4", Description="Postsecondary award, certificate, or diploma of at least two but less than four academic years (at least 1800 contact or clock hours)", Definition="Postsecondary award, certificate, or diploma of at least two but less than four academic years (at least 1800 contact or clock hours)", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("cd2cdd26-b106-4c2f-81a3-a94b2d688b61"), Code="IPEDS5", Description="Bachelor's Degree or equivalent", Definition="Bachelor's Degree or equivalent", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("5b4eb53e-fd2f-43ea-8ea9-bf9b99ce8ad0"), Code="IPEDS6", Description="Postbaccalaureate Certificate", Definition="Postbaccalaureate Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("438e026a-22b7-478f-9b98-059e7aed7701"), Code="IPEDS7", Description="Master's Degree", Definition="Master's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("e6cd9a9a-0a41-48d7-a1b5-d1bce8648099"), Code="IPEDS8", Description="Post Masters Certificate", Definition="Post Masters Certificate", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("6ba02df0-4623-4dd5-a5d4-056c1d4918b1"), Code="IPEDS9", Description="Doctor's Degree", Definition="Doctor's Degree", SortOrder=Convert.ToDecimal("") },
            new ReferenceModelBase { Id=Guid.Parse("9e308c29-8044-405b-983d-d86a59906e27"), Code="CEGEP", Description="CEGEP (an award made by Canadian secondary schools that is typically equivalent to a high school diploma plus one year of college level courses)", Definition="CEGEP (an award made by Canadian secondary schools that is typically equivalent to a high school diploma plus one year of college level courses)", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2060a4dd-a6a8-48bd-beba-52eafe61ca71"), Code="FrenchBaccalaureate", Description="French Baccalaureate (award made to high school students that allows French and international students to obtain a standardized qualification)", Definition="French Baccalaureate (an award made to high school students who complete a rigorous program of study including foreign languages. It allows French and international students to obtain a standardized qualification, typically at the age of 18)", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a33b7b7-d0f0-4630-ba91-35adaf7a4e73"), Code="4.0", Description="Graduate non-degree - value to represent an award from graduate coursework that is not a certificate or degree", Definition="Graduate non-degree - value to represent an award from graduate coursework that is not a certificate or degree", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("4870891b-79e0-44c5-a7ba-d3192368c0c6"), Code="3.3", Description="Graduate Professional - value to represent an award from graduate coursework in a professional program", Definition="Graduate Professional - value to represent an award from graduate coursework in a professional program", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("83817118-5443-421e-a654-0b8e07efa53f"), Code="0.0", Description="Other - value to represent an award that does not otherwise fit existing enumerations", Definition="Other - value to represent an award that does not otherwise fit existing enumerations", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("bedc7559-3db2-4855-b7dd-a1ea1c1978a5"), Code="1.5", Description="Statement of achievement", Definition="Statement of achievement", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("73155af7-9bb6-4844-b1e4-f4cad1b208f5"), Code="1.4", Description="Statement of completion", Definition="Statement of completion", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("476d9add-bdbb-4da4-9e74-256214f79163"), Code="1.3", Description="Statement of participation", Definition="Statement of participation", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("b8ef1986-cb68-4f08-8a77-9a0090c935d5"), Code="2.8", Description="Undergraduate non-degree - value to represent an award from undergraduate coursework that is not a certificate or degree", Definition="Undergraduate non-degree - value to represent an award from undergraduate coursework that is not a certificate or degree", SortOrder=Convert.ToDecimal("9.00") },
        };
        #endregion
    }
}
