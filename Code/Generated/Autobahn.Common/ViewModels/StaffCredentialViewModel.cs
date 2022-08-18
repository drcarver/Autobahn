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
            new ReferenceModelBase { Id=Guid.Parse("7d6ebc2a-2416-41e3-a36a-63d957994150"), Code="Qualified", Description="Qualified", Definition="The paraprofessional is qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("bd535a65-a809-4b41-ae58-30ba6ba9cecf"), Code="NotQualified", Description="Not Qualified", Definition="The paraprofessional is NOT qualified for their assignment according to state definition.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefProgramSponsorType List
        /// <summary>
        /// The complete Cardiopulmonary Resuscitation Certification Expiration Date List
        /// </summary>
        private static List<ReferenceModelBase> RefProgramSponsorTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("623608a4-cbf7-4b3d-9e6e-4e8ed28ff05e"), Code="Business", Description="Business", Definition="A business is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("dd2ef998-2aa7-4683-823a-dfd1019dc03f"), Code="EducationOrganizationNetwork", Description="Education organization network", Definition="An education organization network is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("9d21c09d-f578-4ea6-bd5b-2b67b1b3956e"), Code="EducationServiceCenter", Description="Education Service Center", Definition="An education Service Center is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("e757c592-7fb4-4a96-837a-8cb9e45095cb"), Code="Federal", Description="Federal government", Definition="The federal government is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("6ac83f26-7836-45b5-8205-476058848afe"), Code="LEA", Description="Local education agency", Definition="The local education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("7fb17457-d460-479c-8ad5-6fa673e19027"), Code="NonProfit", Description="Non-profit organization", Definition="A non-profit organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("7.00") },
            new ReferenceModelBase { Id=Guid.Parse("972b9e99-021b-432c-9ed5-546d3f8d548c"), Code="Postsecondary", Description="Postsecondary institution", Definition="A postsecondary institution is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("9.00") },
            new ReferenceModelBase { Id=Guid.Parse("03c85dda-44c3-4891-8a10-8e896994d1c1"), Code="Private", Description="Private organization", Definition="A private organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("11.00") },
            new ReferenceModelBase { Id=Guid.Parse("592b78a3-6f61-41be-b737-9552ef40c842"), Code="Regional", Description="Regional or intermediate education agency", Definition="A regional or intermediate education agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("13.00") },
            new ReferenceModelBase { Id=Guid.Parse("de5d520b-66ae-430b-bcaa-17202f5206e3"), Code="Religious", Description="Religious organization", Definition="A religious organization is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("15.00") },
            new ReferenceModelBase { Id=Guid.Parse("5d8285ca-995e-4511-84e6-9c75f4532733"), Code="School", Description="School", Definition="The school is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("17.00") },
            new ReferenceModelBase { Id=Guid.Parse("be9035ac-2a9d-45bd-8488-8a653fa983a2"), Code="SEA", Description="State Education Agency", Definition="The State Education Agency is providing funds for a particular educational or service program or activity or for an individual's participation in the program or activity.", SortOrder=Convert.ToDecimal("19.00") },
            new ReferenceModelBase { Id=Guid.Parse("e7cf070e-9d14-42f7-8ff9-8895b0008635"), Code="Other", Description="Other", Definition="The category of organization providing funds for the particular educational or service program or activity or for an individual's participation in the program or activity is not yet defined in CEDS.", SortOrder=Convert.ToDecimal("21.00") },
        };
        #endregion
    }
}
