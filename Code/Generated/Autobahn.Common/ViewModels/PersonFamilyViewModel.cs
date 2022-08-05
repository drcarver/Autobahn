//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonFamilyViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonFamilyViewModel
     /// </summary>
    public partial class PersonFamilyViewModel : ViewModelBase, Interfaces.IPersonFamily
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PersonFamily";

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the FamilyIdentifier property
        private System.String _FamilyIdentifier;

        // member variable for the NumberOfPeopleInFamily property
        private System.Int32? _NumberOfPeopleInFamily;

        // member variable for the NumberOfPeopleInHousehold property
        private System.Int32? _NumberOfPeopleInHousehold;

        // member variable for the FamilyIncome property
        private System.Decimal? _FamilyIncome;

        // member variable for the RefFamilyIncomeSourceId property
        private Guid? _RefFamilyIncomeSourceId;

        // member variable for the RefIncomeCalculationMethodId property
        private Guid? _RefIncomeCalculationMethodId;

        // member variable for the RefProofOfResidencyTypeId property
        private Guid? _RefProofOfResidencyTypeId;

        // member variable for the RefELProgramEligibilityId property
        private Guid? _RefELProgramEligibilityId;

        // member variable for the RefHighestEducationLevelCompletedId property
        private Guid? _RefHighestEducationLevelCompletedId;

        // member variable for the RefCommunicationMethodId property
        private Guid? _RefCommunicationMethodId;

        // member variable for the IncludedInCountedFamilySize property
        private System.Boolean? _IncludedInCountedFamilySize;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the NumberOfHouseholdCollegeStudents property
        private System.Int32? _NumberOfHouseholdCollegeStudents;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PersonFamilyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        public System.String FamilyIdentifier  { get => _FamilyIdentifier; set => SetProperty(ref _FamilyIdentifier, value); }

        public System.Int32? NumberOfPeopleInFamily { get => _NumberOfPeopleInFamily; set => SetProperty(ref _NumberOfPeopleInFamily, value); }

        public System.Int32? NumberOfPeopleInHousehold { get => _NumberOfPeopleInHousehold; set => SetProperty(ref _NumberOfPeopleInHousehold, value); }

        public System.Decimal? FamilyIncome { get => _FamilyIncome; set => SetProperty(ref _FamilyIncome, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFamilyIncomeSourceId"/> model
        /// </summary>
        public Guid? RefFamilyIncomeSourceId { get => _RefFamilyIncomeSourceId; set => SetProperty(ref _RefFamilyIncomeSourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncomeCalculationMethodId"/> model
        /// </summary>
        public Guid? RefIncomeCalculationMethodId { get => _RefIncomeCalculationMethodId; set => SetProperty(ref _RefIncomeCalculationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyTypeId"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get => _RefProofOfResidencyTypeId; set => SetProperty(ref _RefProofOfResidencyTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibilityId"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityId { get => _RefELProgramEligibilityId; set => SetProperty(ref _RefELProgramEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompletedId"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get => _RefHighestEducationLevelCompletedId; set => SetProperty(ref _RefHighestEducationLevelCompletedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunicationMethodId"/> model
        /// </summary>
        public Guid? RefCommunicationMethodId { get => _RefCommunicationMethodId; set => SetProperty(ref _RefCommunicationMethodId, value); }

        public System.Boolean? IncludedInCountedFamilySize { get => _IncludedInCountedFamilySize; set => SetProperty(ref _IncludedInCountedFamilySize, value); }

        public System.Int32? NumberOfHouseholdCollegeStudents { get => _NumberOfHouseholdCollegeStudents; set => SetProperty(ref _NumberOfHouseholdCollegeStudents, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonFamily model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            FamilyIdentifier = model.FamilyIdentifier;
            NumberOfPeopleInFamily = model.NumberOfPeopleInFamily;
            NumberOfPeopleInHousehold = model.NumberOfPeopleInHousehold;
            FamilyIncome = model.FamilyIncome;
            RefFamilyIncomeSourceId = model.RefFamilyIncomeSourceId;
            RefIncomeCalculationMethodId = model.RefIncomeCalculationMethodId;
            RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId;
            RefELProgramEligibilityId = model.RefELProgramEligibilityId;
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId;
            RefCommunicationMethodId = model.RefCommunicationMethodId;
            IncludedInCountedFamilySize = model.IncludedInCountedFamilySize;
            NumberOfHouseholdCollegeStudents = model.NumberOfHouseholdCollegeStudents;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
