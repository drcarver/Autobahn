//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffCredentialViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffCredentialViewModel
     /// </summary>
    public partial class StaffCredentialViewModel : BindableBase, IStaffCredential
    {
#region "Backing Fields"
        // member variable for the TechnologySkillsStandardsMet property
        private System.Boolean? _TechnologySkillsStandardsMet;

        // member variable for the DiplomaOrCredentialAwardDate property
        private System.String _DiplomaOrCredentialAwardDate;

        // member variable for the CTEInstructorIndustryCertification property
        private System.Boolean? _CTEInstructorIndustryCertification;

        // member variable for the CardiopulmonaryResuscitationCertification property
        private System.DateTime? _CardiopulmonaryResuscitationCertification;

        // member variable for the FirstAidCertification property
        private System.DateTime? _FirstAidCertification;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonCredentialId"/> model
        /// </summary>
        public Guid PersonCredentialId { get; set; }

        public System.Boolean? TechnologySkillsStandardsMet { get => _TechnologySkillsStandardsMet; set => SetProperty(ref _TechnologySkillsStandardsMet, value); }

        public System.String DiplomaOrCredentialAwardDate  { get => _DiplomaOrCredentialAwardDate; set => SetProperty(ref _DiplomaOrCredentialAwardDate, value); }

        public System.Boolean? CTEInstructorIndustryCertification { get => _CTEInstructorIndustryCertification; set => SetProperty(ref _CTEInstructorIndustryCertification, value); }

        public System.DateTime? CardiopulmonaryResuscitationCertification { get => _CardiopulmonaryResuscitationCertification; set => SetProperty(ref _CardiopulmonaryResuscitationCertification, value); }

        public System.DateTime? FirstAidCertification { get => _FirstAidCertification; set => SetProperty(ref _FirstAidCertification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialTypeId"/> model
        /// </summary>
        public Guid? RefTeachingCredentialTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTeachingCredentialBasisId"/> model
        /// </summary>
        public Guid? RefTeachingCredentialBasisId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefChildDevAssociateTypeId"/> model
        /// </summary>
        public Guid? RefChildDevAssociateTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefParaprofessionalQualificationId"/> model
        /// </summary>
        public Guid? RefParaprofessionalQualificationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramSponsorTypeId"/> model
        /// </summary>
        public Guid? RefProgramSponsorTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAeCertificationTypeId"/> model
        /// </summary>
        public Guid? RefAeCertificationTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IStaffCredential model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonCredentialId = model.PersonCredentialId;
            TechnologySkillsStandardsMet = model.TechnologySkillsStandardsMet;
            DiplomaOrCredentialAwardDate = model.DiplomaOrCredentialAwardDate;
            CTEInstructorIndustryCertification = model.CTEInstructorIndustryCertification;
            CardiopulmonaryResuscitationCertification = model.CardiopulmonaryResuscitationCertification;
            FirstAidCertification = model.FirstAidCertification;
            RefTeachingCredentialTypeId = model.RefTeachingCredentialTypeId;
            RefTeachingCredentialBasisId = model.RefTeachingCredentialBasisId;
            RefChildDevAssociateTypeId = model.RefChildDevAssociateTypeId;
            RefParaprofessionalQualificationId = model.RefParaprofessionalQualificationId;
            RefProgramSponsorTypeId = model.RefProgramSponsorTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RefAeCertificationTypeId = model.RefAeCertificationTypeId;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
