//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonFamilyViewModel.cs
//**********************************************************

using CommunityToolkit.Maui;

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
        private System.String _FamilyIdentifier;

        // member variable for the FamilyIncome property
        private System.Decimal? _FamilyIncome;

        // member variable for the IncludedInCountedFamilySize property
        private System.Boolean? _IncludedInCountedFamilySize;

        // member variable for the NumberOfHouseholdCollegeStudents property
        private System.Int32? _NumberOfHouseholdCollegeStudents;

        // member variable for the NumberOfPeopleInFamily property
        private System.Int32? _NumberOfPeopleInFamily;

        // member variable for the NumberOfPeopleInHousehold property
        private System.Int32? _NumberOfPeopleInHousehold;

        // member variable for the PersonId property
        private Guid _PersonId;

        // member variable for the RefCommunicationMethodId property
        private Guid? _RefCommunicationMethodId;

        // member variable for the RefELProgramEligibilityId property
        private Guid? _RefELProgramEligibilityId;

        // member variable for the RefFamilyIncomeSourceId property
        private Guid? _RefFamilyIncomeSourceId;

        // member variable for the RefHighestEducationLevelCompletedId property
        private Guid? _RefHighestEducationLevelCompletedId;

        // member variable for the RefIncomeCalculationMethodId property
        private Guid? _RefIncomeCalculationMethodId;

        // member variable for the RefProofOfResidencyTypeId property
        private Guid? _RefProofOfResidencyTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PersonFamilyViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.String FamilyIdentifier { get => _FamilyIdentifier; set => SetProperty(ref _FamilyIdentifier, value); }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Decimal? FamilyIncome { get => _FamilyIncome; set => SetProperty(ref _FamilyIncome, value); }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Boolean? IncludedInCountedFamilySize { get => _IncludedInCountedFamilySize; set => SetProperty(ref _IncludedInCountedFamilySize, value); }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Int32? NumberOfHouseholdCollegeStudents { get => _NumberOfHouseholdCollegeStudents; set => SetProperty(ref _NumberOfHouseholdCollegeStudents, value); }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Int32? NumberOfPeopleInFamily { get => _NumberOfPeopleInFamily; set => SetProperty(ref _NumberOfPeopleInFamily, value); }

        /// <summary>
        /// The extent of formal instruction a person has received (e.g., the highest grade in school completed or its equivalent or the highest degree received).
        /// </summary>
        public System.Int32? NumberOfPeopleInHousehold { get => _NumberOfPeopleInHousehold; set => SetProperty(ref _NumberOfPeopleInHousehold, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Person"/> model
        /// </summary>
        public Guid PersonId { get => _PersonId; set => SetProperty(ref _PersonId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunicationMethod"/> model
        /// </summary>
        public Guid? RefCommunicationMethodId { get => _RefCommunicationMethodId; set => SetProperty(ref _RefCommunicationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibility"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityId { get => _RefELProgramEligibilityId; set => SetProperty(ref _RefELProgramEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFamilyIncomeSource"/> model
        /// </summary>
        public Guid? RefFamilyIncomeSourceId { get => _RefFamilyIncomeSourceId; set => SetProperty(ref _RefFamilyIncomeSourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompleted"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get => _RefHighestEducationLevelCompletedId; set => SetProperty(ref _RefHighestEducationLevelCompletedId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncomeCalculationMethod"/> model
        /// </summary>
        public Guid? RefIncomeCalculationMethodId { get => _RefIncomeCalculationMethodId; set => SetProperty(ref _RefIncomeCalculationMethodId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyType"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get => _RefProofOfResidencyTypeId; set => SetProperty(ref _RefProofOfResidencyTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPersonFamily model)
        {
            IsBusy = true;
            Id = model.Id;
            FamilyIdentifier = model.FamilyIdentifier;
            FamilyIncome = model.FamilyIncome;
            IncludedInCountedFamilySize = model.IncludedInCountedFamilySize;
            NumberOfHouseholdCollegeStudents = model.NumberOfHouseholdCollegeStudents;
            NumberOfPeopleInFamily = model.NumberOfPeopleInFamily;
            NumberOfPeopleInHousehold = model.NumberOfPeopleInHousehold;
            PersonId = model.PersonId;
            RefCommunicationMethodId = model.RefCommunicationMethodId;
            RefELProgramEligibilityId = model.RefELProgramEligibilityId;
            RefFamilyIncomeSourceId = model.RefFamilyIncomeSourceId;
            RefHighestEducationLevelCompletedId = model.RefHighestEducationLevelCompletedId;
            RefIncomeCalculationMethodId = model.RefIncomeCalculationMethodId;
            RefProofOfResidencyTypeId = model.RefProofOfResidencyTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
