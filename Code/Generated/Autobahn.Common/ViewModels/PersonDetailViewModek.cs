//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonDetailViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDetailViewModel
     /// </summary>
    public partial class PersonDetailViewModel : BindableBase, IPersonDetail
    {
#region "Backing Fields"
        // member variable for the FirstName property
        private System.String _FirstName;

        // member variable for the MiddleName property
        private System.String _MiddleName;

        // member variable for the LastName property
        private System.String _LastName;

        // member variable for the GenerationCode property
        private System.String _GenerationCode;

        // member variable for the Prefix property
        private System.String _Prefix;

        // member variable for the Birthdate property
        private System.DateTime? _Birthdate;

        // member variable for the HispanicLatinoEthnicity property
        private System.Boolean? _HispanicLatinoEthnicity;

        // member variable for the BirthdateVerification property
        private System.String _BirthdateVerification;

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

        public System.String FirstName  { get => _FirstName; set => SetProperty(ref _FirstName, value); }

        public System.String MiddleName  { get => _MiddleName; set => SetProperty(ref _MiddleName, value); }

        public System.String LastName  { get => _LastName; set => SetProperty(ref _LastName, value); }

        public System.String GenerationCode  { get => _GenerationCode; set => SetProperty(ref _GenerationCode, value); }

        public System.String Prefix  { get => _Prefix; set => SetProperty(ref _Prefix, value); }

        public System.DateTime? Birthdate { get => _Birthdate; set => SetProperty(ref _Birthdate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSexId"/> model
        /// </summary>
        public Guid? RefSexId { get; set; }

        public System.Boolean? HispanicLatinoEthnicity { get => _HispanicLatinoEthnicity; set => SetProperty(ref _HispanicLatinoEthnicity, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefUSCitizenshipStatusId"/> model
        /// </summary>
        public Guid? RefUSCitizenshipStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisaTypeId"/> model
        /// </summary>
        public Guid? RefVisaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateOfResidenceId"/> model
        /// </summary>
        public Guid? RefStateOfResidenceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyTypeId"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompletedId"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        public System.String BirthdateVerification  { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTribalAffiliationId"/> model
        /// </summary>
        public Guid? RefTribalAffiliationId { get; set; }

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
        public void Load(IPersonDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            FirstName = model.FirstName;
            MiddleName = model.MiddleName;
            LastName = model.LastName;
            GenerationCode = model.GenerationCode;
            Prefix = model.Prefix;
            Birthdate = model.Birthdate;
            RefSexId = model.RefSexId;
            HispanicLatinoEthnicity = model.HispanicLatinoEthnicity;
            RefUSCitizenshipStatusId = model.RefUSCitizenshipStatusId;
            RefVisaTypeId = model.RefVisaTypeId;
            RefStateOfResidenceId = model.RefStateOfResidenceId;
            RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId;
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId;
            BirthdateVerification = model.BirthdateVerification;
            RefTribalAffiliationId = model.RefTribalAffiliationId;
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
