//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the FamilyIdentifier property
        private  _FamilyIdentifier;

        // member variable for the FamilyIncome property
        private  _FamilyIncome;

        // member variable for the IncludedInCountedFamilySize property
        private  _IncludedInCountedFamilySize;

        // member variable for the NumberOfHouseholdCollegeStudents property
        private  _NumberOfHouseholdCollegeStudents;

        // member variable for the NumberOfPeopleInFamily property
        private  _NumberOfPeopleInFamily;

        // member variable for the NumberOfPeopleInHousehold property
        private  _NumberOfPeopleInHousehold;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCommunicationMethodId property
        private  _RefCommunicationMethodId;

        // member variable for the RefELProgramEligibilityId property
        private  _RefELProgramEligibilityId;

        // member variable for the RefFamilyIncomeSourceId property
        private  _RefFamilyIncomeSourceId;

        // member variable for the RefHighestEducationLevelCompletedId property
        private Guid? _RefHighestEducationLevelCompletedId;

        // member variable for the RefIncomeCalculationMethodId property
        private  _RefIncomeCalculationMethodId;

        // member variable for the RefProofOfResidencyTypeId property
        private  _RefProofOfResidencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FamilyIdentifier { get => _FamilyIdentifier; set => SetProperty(ref _FamilyIdentifier, value); }

        /// <summary>
        /// </summary>
        public  FamilyIncome { get => _FamilyIncome; set => SetProperty(ref _FamilyIncome, value); }

        /// <summary>
        /// </summary>
        public  IncludedInCountedFamilySize { get => _IncludedInCountedFamilySize; set => SetProperty(ref _IncludedInCountedFamilySize, value); }

        /// <summary>
        /// </summary>
        public  NumberOfHouseholdCollegeStudents { get => _NumberOfHouseholdCollegeStudents; set => SetProperty(ref _NumberOfHouseholdCollegeStudents, value); }

        /// <summary>
        /// </summary>
        public  NumberOfPeopleInFamily { get => _NumberOfPeopleInFamily; set => SetProperty(ref _NumberOfPeopleInFamily, value); }

        /// <summary>
        /// </summary>
        public  NumberOfPeopleInHousehold { get => _NumberOfPeopleInHousehold; set => SetProperty(ref _NumberOfPeopleInHousehold, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunicationMethod"/> model
        /// </summary>
        public  RefCommunicationMethodId { get => _RefCommunicationMethodId; set => SetProperty(ref _RefCommunicationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibility"/> model
        /// </summary>
        public  RefELProgramEligibilityId { get => _RefELProgramEligibilityId; set => SetProperty(ref _RefELProgramEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFamilyIncomeSource"/> model
        /// </summary>
        public  RefFamilyIncomeSourceId { get => _RefFamilyIncomeSourceId; set => SetProperty(ref _RefFamilyIncomeSourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get => _RefHighestEducationLevelCompletedId; set => SetProperty(ref _RefHighestEducationLevelCompletedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncomeCalculationMethod"/> model
        /// </summary>
        public  RefIncomeCalculationMethodId { get => _RefIncomeCalculationMethodId; set => SetProperty(ref _RefIncomeCalculationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        public  RefProofOfResidencyTypeId { get => _RefProofOfResidencyTypeId; set => SetProperty(ref _RefProofOfResidencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonFamily model)
        {
            IsBusy = true;
            Id = model.Id;
            FamilyIdentifier = model.FamilyIdentifier; // 
            FamilyIncome = model.FamilyIncome; // 
            IncludedInCountedFamilySize = model.IncludedInCountedFamilySize; // 
            NumberOfHouseholdCollegeStudents = model.NumberOfHouseholdCollegeStudents; // 
            NumberOfPeopleInFamily = model.NumberOfPeopleInFamily; // 
            NumberOfPeopleInHousehold = model.NumberOfPeopleInHousehold; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCommunicationMethodId = model.RefCommunicationMethodId; // 
            RefELProgramEligibilityId = model.RefELProgramEligibilityId; // 
            RefFamilyIncomeSourceId = model.RefFamilyIncomeSourceId; // 
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId; // 
            RefIncomeCalculationMethodId = model.RefIncomeCalculationMethodId; // 
            RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
