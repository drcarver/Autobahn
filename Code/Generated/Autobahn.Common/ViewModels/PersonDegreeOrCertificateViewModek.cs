//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDegreeOrCertificateViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDegreeOrCertificateViewModel
     /// </summary>
    public partial class PersonDegreeOrCertificateViewModel : BindableBase, IPersonDegreeOrCertificate
    {
#region "Backing Fields"
        // member variable for the DegreeOrCertificateTitleOrSubject property
        private System.String _DegreeOrCertificateTitleOrSubject;

        // member variable for the AwardDate property
        private System.DateTime? _AwardDate;

        // member variable for the NameOfInstitution property
        private System.String _NameOfInstitution;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.String DegreeOrCertificateTitleOrSubject  { get => _DegreeOrCertificateTitleOrSubject; set => SetProperty(ref _DegreeOrCertificateTitleOrSubject, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDegreeOrCertificateTypeId"/> model
        /// </summary>
        public Guid? RefDegreeOrCertificateTypeId { get; set; }

        public System.DateTime? AwardDate { get => _AwardDate; set => SetProperty(ref _AwardDate, value); }

        public System.String NameOfInstitution  { get => _NameOfInstitution; set => SetProperty(ref _NameOfInstitution, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHigherEducationInstitutionAccreditationStatusId"/> model
        /// </summary>
        public Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationVerificationMethodId"/> model
        /// </summary>
        public Guid? RefEducationVerificationMethodId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

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
        public void Load(IPersonDegreeOrCertificate model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            DegreeOrCertificateTitleOrSubject = model.DegreeOrCertificateTitleOrSubject;
            RefDegreeOrCertificateTypeId = model.RefDegreeOrCertificateTypeId;
            AwardDate = model.AwardDate;
            NameOfInstitution = model.NameOfInstitution;
            RefHigherEducationInstitutionAccreditationStatusId = model.RefHigherEducationInstitutionAccreditationStatusId;
            RefEducationVerificationMethodId = model.RefEducationVerificationMethodId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
