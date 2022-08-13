//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonDetailViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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
        private System.DateTime? _Birthdate;

        // member variable for the BirthdateVerification property
        private System.String _BirthdateVerification;

        // member variable for the FirstName property
        private System.String _FirstName;

        // member variable for the GenerationCode property
        private System.String _GenerationCode;

        // member variable for the HispanicLatinoEthnicity property
        private System.Boolean? _HispanicLatinoEthnicity;

        // member variable for the LastName property
        private System.String _LastName;

        // member variable for the MiddleName property
        private System.String _MiddleName;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the Prefix property
        private System.String _Prefix;

        // member variable for the RefHighestEducationLevelCompletedId property
        private Guid? _RefHighestEducationLevelCompletedId;

        // member variable for the RefProofOfResidencyTypeId property
        private Guid? _RefProofOfResidencyTypeId;

        // member variable for the RefSexId property
        private Guid? _RefSexId;

        // member variable for the RefStateOfResidenceId property
        private Guid? _RefStateOfResidenceId;

        // member variable for the RefTribalAffiliationId property
        private Guid? _RefTribalAffiliationId;

        // member variable for the RefUSCitizenshipStatusId property
        private Guid? _RefUSCitizenshipStatusId;

        // member variable for the RefVisaTypeId property
        private Guid? _RefVisaTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonDetailViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.DateTime? Birthdate { get => _Birthdate; set => SetProperty(ref _Birthdate, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String BirthdateVerification { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String FirstName { get => _FirstName; set => SetProperty(ref _FirstName, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String GenerationCode { get => _GenerationCode; set => SetProperty(ref _GenerationCode, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.Boolean? HispanicLatinoEthnicity { get => _HispanicLatinoEthnicity; set => SetProperty(ref _HispanicLatinoEthnicity, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String LastName { get => _LastName; set => SetProperty(ref _LastName, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String MiddleName { get => _MiddleName; set => SetProperty(ref _MiddleName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// The year, month and day on which a person was born.
        /// </summary>
        public System.String Prefix { get => _Prefix; set => SetProperty(ref _Prefix, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get => _RefHighestEducationLevelCompletedId; set => SetProperty(ref _RefHighestEducationLevelCompletedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get => _RefProofOfResidencyTypeId; set => SetProperty(ref _RefProofOfResidencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSex"/> model
        /// </summary>
        public Guid? RefSexId { get => _RefSexId; set => SetProperty(ref _RefSexId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStateOfResidence"/> model
        /// </summary>
        public Guid? RefStateOfResidenceId { get => _RefStateOfResidenceId; set => SetProperty(ref _RefStateOfResidenceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTribalAffiliation"/> model
        /// </summary>
        public Guid? RefTribalAffiliationId { get => _RefTribalAffiliationId; set => SetProperty(ref _RefTribalAffiliationId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefUSCitizenshipStatus"/> model
        /// </summary>
        public Guid? RefUSCitizenshipStatusId { get => _RefUSCitizenshipStatusId; set => SetProperty(ref _RefUSCitizenshipStatusId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefVisaType"/> model
        /// </summary>
        public Guid? RefVisaTypeId { get => _RefVisaTypeId; set => SetProperty(ref _RefVisaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            Birthdate = model.Birthdate;
            BirthdateVerification = model.BirthdateVerification;
            FirstName = model.FirstName;
            GenerationCode = model.GenerationCode;
            HispanicLatinoEthnicity = model.HispanicLatinoEthnicity;
            LastName = model.LastName;
            MiddleName = model.MiddleName;
            PersonId = model.PersonId;
            Prefix = model.Prefix;
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId;
            RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId;
            RefSexId = model.RefSexId;
            RefStateOfResidenceId = model.RefStateOfResidenceId;
            RefTribalAffiliationId = model.RefTribalAffiliationId;
            RefUSCitizenshipStatusId = model.RefUSCitizenshipStatusId;
            RefVisaTypeId = model.RefVisaTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
