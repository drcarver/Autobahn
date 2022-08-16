//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffCredentialViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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
        private  _CardiopulmonaryResuscitationCertification;

        // member variable for the CTEInstructorIndustryCertification property
        private  _CTEInstructorIndustryCertification;

        // member variable for the DiplomaOrCredentialAwardDate property
        private Guid? _DiplomaOrCredentialAwardDate;

        // member variable for the FirstAidCertification property
        private  _FirstAidCertification;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefAeCertificationTypeId property
        private  _RefAeCertificationTypeId;

        // member variable for the RefChildDevAssociateTypeId property
        private  _RefChildDevAssociateTypeId;

        // member variable for the RefParaprofessionalQualificationId property
        private  _RefParaprofessionalQualificationId;

        // member variable for the RefProgramSponsorTypeId property
        private  _RefProgramSponsorTypeId;

        // member variable for the RefTeachingCredentialBasisId property
        private  _RefTeachingCredentialBasisId;

        // member variable for the RefTeachingCredentialTypeId property
        private  _RefTeachingCredentialTypeId;

        // member variable for the TechnologySkillsStandardsMet property
        private  _TechnologySkillsStandardsMet;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  CardiopulmonaryResuscitationCertification { get => _CardiopulmonaryResuscitationCertification; set => SetProperty(ref _CardiopulmonaryResuscitationCertification, value); }

        /// <summary>
        /// </summary>
        public  CTEInstructorIndustryCertification { get => _CTEInstructorIndustryCertification; set => SetProperty(ref _CTEInstructorIndustryCertification, value); }

        /// <summary>
        /// </summary>
        public Guid? DiplomaOrCredentialAwardDate { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        /// <summary>
        /// </summary>
        public  FirstAidCertification { get => _FirstAidCertification; set => SetProperty(ref _FirstAidCertification, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeCertificationType"/> model
        /// </summary>
        public  RefAeCertificationTypeId { get => _RefAeCertificationTypeId; set => SetProperty(ref _RefAeCertificationTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevAssociateType"/> model
        /// </summary>
        public  RefChildDevAssociateTypeId { get => _RefChildDevAssociateTypeId; set => SetProperty(ref _RefChildDevAssociateTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParaprofessionalQualification"/> model
        /// </summary>
        public  RefParaprofessionalQualificationId { get => _RefParaprofessionalQualificationId; set => SetProperty(ref _RefParaprofessionalQualificationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramSponsorType"/> model
        /// </summary>
        public  RefProgramSponsorTypeId { get => _RefProgramSponsorTypeId; set => SetProperty(ref _RefProgramSponsorTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasis"/> model
        /// </summary>
        public  RefTeachingCredentialBasisId { get => _RefTeachingCredentialBasisId; set => SetProperty(ref _RefTeachingCredentialBasisId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialType"/> model
        /// </summary>
        public  RefTeachingCredentialTypeId { get => _RefTeachingCredentialTypeId; set => SetProperty(ref _RefTeachingCredentialTypeId, value); }

        /// <summary>
        /// </summary>
        public  TechnologySkillsStandardsMet { get => _TechnologySkillsStandardsMet; set => SetProperty(ref _TechnologySkillsStandardsMet, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            CardiopulmonaryResuscitationCertification = model.CardiopulmonaryResuscitationCertification; // 
            CTEInstructorIndustryCertification = model.CTEInstructorIndustryCertification; // 
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate; // 
            FirstAidCertification = model.FirstAidCertification; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefAeCertificationTypeId = model.RefAeCertificationTypeId; // 
            RefChildDevAssociateTypeId = model.RefChildDevAssociateTypeId; // 
            RefParaprofessionalQualificationId = model.RefParaprofessionalQualificationId; // 
            RefProgramSponsorTypeId = model.RefProgramSponsorTypeId; // 
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId; // 
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId; // 
            TechnologySkillsStandardsMet = model.TechnologySkillsStandardsMet; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
