//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffCredentialViewModel
     /// </summary>
    public partial class StaffCredentialViewModel : ViewModelBase, Interfaces.IStaffCredential
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffCredential";

        // member variable for the CardiopulmonaryResuscitationCertification property
        private System.DateTime? _CardiopulmonaryResuscitationCertification;

        // member variable for the CTEInstructorIndustryCertification property
        private System.Boolean? _CTEInstructorIndustryCertification;

        // member variable for the DiplomaOrCredentialAwardDate property
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the FirstAidCertification property
        private System.DateTime? _FirstAidCertification;

        // member variable for the PersonCredentialId property
        private Guid _PersonCredentialId;

        // member variable for the RefAeCertificationTypeId property
        private Guid? _RefAeCertificationTypeId;

        // member variable for the RefChildDevAssociateTypeId property
        private Guid? _RefChildDevAssociateTypeId;

        // member variable for the RefParaprofessionalQualificationId property
        private Guid? _RefParaprofessionalQualificationId;

        // member variable for the RefProgramSponsorTypeId property
        private Guid? _RefProgramSponsorTypeId;

        // member variable for the RefTeachingCredentialBasisId property
        private Guid? _RefTeachingCredentialBasisId;

        // member variable for the RefTeachingCredentialTypeId property
        private Guid? _RefTeachingCredentialTypeId;

        // member variable for the TechnologySkillsStandardsMet property
        private System.Boolean? _TechnologySkillsStandardsMet;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffCredentialViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.DateTime? CardiopulmonaryResuscitationCertification { get => _CardiopulmonaryResuscitationCertification; set => SetProperty(ref _CardiopulmonaryResuscitationCertification, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.Boolean? CTEInstructorIndustryCertification { get => _CTEInstructorIndustryCertification; set => SetProperty(ref _CTEInstructorIndustryCertification, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.String DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
        /// </summary>
        public System.DateTime? FirstAidCertification { get => _FirstAidCertification; set => SetProperty(ref _FirstAidCertification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PersonCredential"/> model
        /// </summary>
        public Guid PersonCredentialId { get => _PersonCredentialId; set => SetProperty(ref _PersonCredentialId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeCertificationType"/> model
        /// </summary>
        public Guid? RefAeCertificationTypeId { get => _RefAeCertificationTypeId; set => SetProperty(ref _RefAeCertificationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevAssociateType"/> model
        /// </summary>
        public Guid? RefChildDevAssociateTypeId { get => _RefChildDevAssociateTypeId; set => SetProperty(ref _RefChildDevAssociateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParaprofessionalQualification"/> model
        /// </summary>
        public Guid? RefParaprofessionalQualificationId { get => _RefParaprofessionalQualificationId; set => SetProperty(ref _RefParaprofessionalQualificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramSponsorType"/> model
        /// </summary>
        public Guid? RefProgramSponsorTypeId { get => _RefProgramSponsorTypeId; set => SetProperty(ref _RefProgramSponsorTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get => _RefTeachingCredentialBasisId; set => SetProperty(ref _RefTeachingCredentialBasisId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get => _RefTeachingCredentialTypeId; set => SetProperty(ref _RefTeachingCredentialTypeId, value); }

        /// <summary>
        /// The month and year on which the diploma/credential is awarded to a student in recognition of his/her completion of the curricular requirements.
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
            CardiopulmonaryResuscitationCertification = model.CardiopulmonaryResuscitationCertification;
            CTEInstructorIndustryCertification = model.CTEInstructorIndustryCertification;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate;
            FirstAidCertification = model.FirstAidCertification;
            PersonCredentialId = model.PersonCredentialId;
            RefAeCertificationTypeId = model.RefAeCertificationTypeId;
            RefChildDevAssociateTypeId = model.RefChildDevAssociateTypeId;
            RefParaprofessionalQualificationId = model.RefParaprofessionalQualificationId;
            RefProgramSponsorTypeId = model.RefProgramSponsorTypeId;
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId;
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId;
            TechnologySkillsStandardsMet = model.TechnologySkillsStandardsMet;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
