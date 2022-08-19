//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialViewModel.cs
//* Name:       Cardiopulmonary Resuscitation Certification Expiration Date
//* Definition: The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
     /// </summary>
    public partial class StaffCredentialViewModel : ViewModelBase, Interfaces.IStaffCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffCredential";

        // CardiopulmonaryResuscitationCertification -- (backing property for Cardiopulmonary Resuscitation Certification Expiration Date)
        private System.DateTime? _CardiopulmonaryResuscitationCertification;

        // CTEInstructorIndustryCertification -- (backing property for Career and Technical Education Instructor Industry Certification)
        private System.Boolean? _CTEInstructorIndustryCertification;

        // DiplomaOrCredentialAwardDate -- (backing property for Diploma or Credential Award Date)
        private System.String _DiplomaOrCredentialAwardDate;

        // FirstAidCertification -- (backing property for First Aid Certification Expiration Date)
        private System.DateTime? _FirstAidCertification;

        // member variable for the PersonCredentialId property
        private Guid _PersonCredentialId;

        // RefAeCertificationTypeId -- (backing property for Adult Education Certification Type)
        private Guid? _RefAeCertificationTypeId;

        // RefChildDevAssociateTypeId -- (backing property for Child Development Associate Type)
        private Guid? _RefChildDevAssociateTypeId;

        // RefParaprofessionalQualificationId -- (backing property for Paraprofessional Qualification Status)
        private Guid? _RefParaprofessionalQualificationId;

        // RefProgramSponsorTypeId -- (backing property for Program Sponsor Type)
        private Guid? _RefProgramSponsorTypeId;

        // RefTeachingCredentialBasisId -- (backing property for Teaching Credential Basis)
        private Guid? _RefTeachingCredentialBasisId;

        // RefTeachingCredentialTypeId -- (backing property for Teaching Credential Type)
        private Guid? _RefTeachingCredentialTypeId;

        // TechnologySkillsStandardsMet -- (backing property for Technology Skills Standards Met)
        private System.Boolean? _TechnologySkillsStandardsMet;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Cardiopulmonary Resuscitation Certification Expiration Date
        /// <para>
        /// The date an individual's cardiopulmonary resuscitation (CPR) training certification expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20065">Cardiopulmonary Resuscitation Certification Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CardiopulmonaryResuscitationCertification { get => _CardiopulmonaryResuscitationCertification; set => SetProperty(ref _CardiopulmonaryResuscitationCertification, value); }

        /// <summary>
        /// Career and Technical Education Instructor Industry Certification
        /// <para>
        /// An indication of whether a Career and Technical Education (CTE) instructor holds a current industry-recognized credential related to their teaching field.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20284">Career and Technical Education Instructor Industry Certification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? CTEInstructorIndustryCertification { get => _CTEInstructorIndustryCertification; set => SetProperty(ref _CTEInstructorIndustryCertification, value); }

        /// <summary>
        /// Diploma or Credential Award Date
        /// <para>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19081">Diploma or Credential Award Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// First Aid Certification Expiration Date
        /// <para>
        /// The date an individual's first aid training certification expires.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20066">First Aid Certification Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? FirstAidCertification { get => _FirstAidCertification; set => SetProperty(ref _FirstAidCertification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonCredential"/> model
        /// </summary>
        public Guid PersonCredentialId { get => _PersonCredentialId; set => SetProperty(ref _PersonCredentialId, value); }

        /// <summary>
        /// Adult Education Certification Type
        /// <para>
        /// An indication of the category of the adult education certification a person holds.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19775">Adult Education Certification Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefAeCertificationTypeId { get => _RefAeCertificationTypeId; set => SetProperty(ref _RefAeCertificationTypeId, value); }

        /// <summary>
        /// Child Development Associate Type
        /// <para>
        /// Type of Child Development Associate credential as defined by options.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19805">Child Development Associate Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefChildDevAssociateTypeId { get => _RefChildDevAssociateTypeId; set => SetProperty(ref _RefChildDevAssociateTypeId, value); }

        /// <summary>
        /// Paraprofessional Qualification Status
        /// <para>
        /// An indication of whether paraprofessionals are classified as qualified for their assignment according to state definition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19207">Paraprofessional Qualification Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefParaprofessionalQualificationId { get => _RefParaprofessionalQualificationId; set => SetProperty(ref _RefParaprofessionalQualificationId, value); }

        /// <summary>
        /// Program Sponsor Type
        /// <para>
        /// A type of organization providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19692">Program Sponsor Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProgramSponsorTypeId { get => _RefProgramSponsorTypeId; set => SetProperty(ref _RefProgramSponsorTypeId, value); }

        /// <summary>
        /// Teaching Credential Basis
        /// <para>
        /// An indication of the pre-determined criteria for granting the teaching credential that a person holds.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19277">Teaching Credential Basis</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get => _RefTeachingCredentialBasisId; set => SetProperty(ref _RefTeachingCredentialBasisId, value); }

        /// <summary>
        /// Teaching Credential Type
        /// <para>
        /// An indication of the category of a legal document giving authorization to perform teaching assignment services.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19278">Teaching Credential Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get => _RefTeachingCredentialTypeId; set => SetProperty(ref _RefTeachingCredentialTypeId, value); }

        /// <summary>
        /// Technology Skills Standards Met
        /// <para>
        /// An indication that the person has achieved acceptable performance on a standards-based profile of technology user skills as defined by the state.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19537">Technology Skills Standards Met</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? TechnologySkillsStandardsMet { get => _TechnologySkillsStandardsMet; set => SetProperty(ref _TechnologySkillsStandardsMet, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            CardiopulmonaryResuscitationCertification = model.CardiopulmonaryResuscitationCertification; // Cardiopulmonary Resuscitation Certification Expiration Date
            CTEInstructorIndustryCertification = model.CTEInstructorIndustryCertification; // Career and Technical Education Instructor Industry Certification
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // Diploma or Credential Award Date
            FirstAidCertification = model.FirstAidCertification; // First Aid Certification Expiration Date
            PersonCredentialId = model.PersonCredentialId; // 
            RefAeCertificationTypeId = model.RefAeCertificationTypeId; // Adult Education Certification Type
            RefChildDevAssociateTypeId = model.RefChildDevAssociateTypeId; // Child Development Associate Type
            RefParaprofessionalQualificationId = model.RefParaprofessionalQualificationId; // Paraprofessional Qualification Status
            RefProgramSponsorTypeId = model.RefProgramSponsorTypeId; // Program Sponsor Type
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId; // Teaching Credential Basis
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId; // Teaching Credential Type
            TechnologySkillsStandardsMet = model.TechnologySkillsStandardsMet; // Technology Skills Standards Met
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefChildDevAssociateType List
        /// <summary>
        /// The complete Cardiopulmonary Resuscitation Certification Expiration Date List
        /// </summary>
        private static List<ReferenceModelBase> RefChildDevAssociateTypeList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefParaprofessionalQualification List
        /// <summary>
        /// The complete Cardiopulmonary Resuscitation Certification Expiration Date List
        /// </summary>
        private static List<ReferenceModelBase> RefParaprofessionalQualificationList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("1ce1329a-c95d-47cc-8f85-2ad053edb9c4"), Code="Qualified", Description="Qualified", Definition="The paraprofessional is qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("47f53687-2fbd-4074-b24a-21a59551549e"), Code="NotQualified", Description="Not Qualified", Definition="The paraprofessional is NOT qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefProgramSponsorType List
        /// <summary>
        /// The complete Cardiopulmonary Resuscitation Certification Expiration Date List
        /// </summary>
        private static List<ReferenceModelBase> RefProgramSponsorTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("7737ec30-2d8b-4d80-a5df-e2634b92fd65"), Code="Business", Description="Business", Definition="A business is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("a0886c51-3813-4eda-b23e-fc529eed6603"), Code="EducationOrganizationNetwork", Description="Education organization network", Definition="An education organization network is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("68cb5963-3a17-45b9-8bb8-77a07b9ea633"), Code="EducationServiceCenter", Description="Education Service Center", Definition="An education Service Center is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("2cf31a44-222a-4c13-b8df-af91a55eeab9"), Code="Federal", Description="Federal government", Definition="The federal government is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("8a2e6e22-1fd1-49f4-8875-13466c5eade2"), Code="LEA", Description="Local education agency", Definition="The local education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("3b4b0160-5e70-4d55-a826-e3e6111a3725"), Code="NonProfit", Description="Non-profit organization", Definition="A non-profit organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("52422934-7df2-4550-afbf-6341ee7ed699"), Code="Postsecondary", Description="Postsecondary institution", Definition="A postsecondary institution is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("cb158bab-4462-4323-bba3-e980f623d514"), Code="Private", Description="Private organization", Definition="A private organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("a4cfaa6f-ed1f-4bcf-af51-3aa955a676e3"), Code="Regional", Description="Regional or intermediate education agency", Definition="A regional or intermediate education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("84606781-8718-496b-83f5-ee5496b8231e"), Code="Religious", Description="Religious organization", Definition="A religious organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("58484df2-b312-421f-a559-01ba3daaf30e"), Code="School", Description="School", Definition="The school is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("73602be0-a34f-48ca-b13b-c4ca34b07baf"), Code="SEA", Description="State Education Agency", Definition="The State Education Agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("f3965cb6-777e-46f2-8cbb-57afc0ec47ba"), Code="Other", Description="Other", Definition="The category of organization providing funds for the particular educational or service program or activity or for an individual's participation in the program or activity is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("21.00") },
        };
        #endregion
    }
}
