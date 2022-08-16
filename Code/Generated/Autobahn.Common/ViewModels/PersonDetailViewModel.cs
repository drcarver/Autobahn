//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonDetailViewModel
     /// </summary>
    public partial class PersonDetailViewModel : ViewModelBase, Interfaces.IPersonDetail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonDetail";

        // member variable for the Birthdate property
        private Guid? _Birthdate;

        // member variable for the BirthdateVerification property
        private  _BirthdateVerification;

        // member variable for the FirstName property
        private  _FirstName;

        // member variable for the GenerationCode property
        private  _GenerationCode;

        // member variable for the HispanicLatinoEthnicity property
        private  _HispanicLatinoEthnicity;

        // member variable for the LastName property
        private  _LastName;

        // member variable for the MiddleName property
        private  _MiddleName;

        // member variable for the Prefix property
        private  _Prefix;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefHighestEducationLevelCompletedId property
        private  _RefHighestEducationLevelCompletedId;

        // member variable for the RefProofOfResidencyTypeId property
        private  _RefProofOfResidencyTypeId;

        // member variable for the RefSexId property
        private  _RefSexId;

        // member variable for the RefStateOfResidenceId property
        private  _RefStateOfResidenceId;

        // member variable for the RefTribalAffiliationId property
        private  _RefTribalAffiliationId;

        // member variable for the RefUSCitizenshipStatusId property
        private  _RefUSCitizenshipStatusId;

        // member variable for the RefVisaTypeId property
        private  _RefVisaTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Birthdate { get => _Birthdate; set => SetProperty(ref _Birthdate, value); }

        /// <summary>
        /// </summary>
        public  BirthdateVerification { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        /// <summary>
        /// </summary>
        public  FirstName { get => _FirstName; set => SetProperty(ref _FirstName, value); }

        /// <summary>
        /// </summary>
        public  GenerationCode { get => _GenerationCode; set => SetProperty(ref _GenerationCode, value); }

        /// <summary>
        /// </summary>
        public  HispanicLatinoEthnicity { get => _HispanicLatinoEthnicity; set => SetProperty(ref _HispanicLatinoEthnicity, value); }

        /// <summary>
        /// </summary>
        public  LastName { get => _LastName; set => SetProperty(ref _LastName, value); }

        /// <summary>
        /// </summary>
        public  MiddleName { get => _MiddleName; set => SetProperty(ref _MiddleName, value); }

        /// <summary>
        /// </summary>
        public  Prefix { get => _Prefix; set => SetProperty(ref _Prefix, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        public  RefHighestEducationLevelCompletedId { get => _RefHighestEducationLevelCompletedId; set => SetProperty(ref _RefHighestEducationLevelCompletedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        public  RefProofOfResidencyTypeId { get => _RefProofOfResidencyTypeId; set => SetProperty(ref _RefProofOfResidencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSex"/> model
        /// </summary>
        public  RefSexId { get => _RefSexId; set => SetProperty(ref _RefSexId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateOfResidence"/> model
        /// </summary>
        public  RefStateOfResidenceId { get => _RefStateOfResidenceId; set => SetProperty(ref _RefStateOfResidenceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTribalAffiliation"/> model
        /// </summary>
        public  RefTribalAffiliationId { get => _RefTribalAffiliationId; set => SetProperty(ref _RefTribalAffiliationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefUSCitizenshipStatus"/> model
        /// </summary>
        public  RefUSCitizenshipStatusId { get => _RefUSCitizenshipStatusId; set => SetProperty(ref _RefUSCitizenshipStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisaType"/> model
        /// </summary>
        public  RefVisaTypeId { get => _RefVisaTypeId; set => SetProperty(ref _RefVisaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            Birthdate = model.Birthdate; // 
            BirthdateVerification = model.BirthdateVerification; // 
            FirstName = model.FirstName; // 
            GenerationCode = model.GenerationCode; // 
            HispanicLatinoEthnicity = model.HispanicLatinoEthnicity; // 
            LastName = model.LastName; // 
            MiddleName = model.MiddleName; // 
            Prefix = model.Prefix; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId; // 
            RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId; // 
            RefSexId = model.RefSexId; // 
            RefStateOfResidenceId = model.RefStateOfResidenceId; // 
            RefTribalAffiliationId = model.RefTribalAffiliationId; // 
            RefUSCitizenshipStatusId = model.RefUSCitizenshipStatusId; // 
            RefVisaTypeId = model.RefVisaTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
