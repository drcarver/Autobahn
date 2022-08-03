//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonFamilyViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonFamilyViewModel
     /// </summary>
    public partial class PersonFamilyViewModel : BindableBase, IPersonFamily
    {
#region "Backing Fields"
        // member variable for the FamilyIdentifier property
        private System.String _FamilyIdentifier;

        // member variable for the NumberOfPeopleInFamily property
        private System.Int32? _NumberOfPeopleInFamily;

        // member variable for the NumberOfPeopleInHousehold property
        private System.Int32? _NumberOfPeopleInHousehold;

        // member variable for the FamilyIncome property
        private System.Decimal? _FamilyIncome;

        // member variable for the IncludedInCountedFamilySize property
        private System.Boolean? _IncludedInCountedFamilySize;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the NumberOfHouseholdCollegeStudents property
        private System.Int32? _NumberOfHouseholdCollegeStudents;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.String FamilyIdentifier  { get => _FamilyIdentifier; set => SetProperty(ref _FamilyIdentifier, value); }

        public System.Int32? NumberOfPeopleInFamily { get => _NumberOfPeopleInFamily; set => SetProperty(ref _NumberOfPeopleInFamily, value); }

        public System.Int32? NumberOfPeopleInHousehold { get => _NumberOfPeopleInHousehold; set => SetProperty(ref _NumberOfPeopleInHousehold, value); }

        public System.Decimal? FamilyIncome { get => _FamilyIncome; set => SetProperty(ref _FamilyIncome, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFamilyIncomeSourceId"/> model
        /// </summary>
        public Guid? RefFamilyIncomeSourceId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncomeCalculationMethodId"/> model
        /// </summary>
        public Guid? RefIncomeCalculationMethodId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProofOfResidencyTypeId"/> model
        /// </summary>
        public Guid? RefProofOfResidencyTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELProgramEligibilityId"/> model
        /// </summary>
        public Guid? RefELProgramEligibilityId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefHighestEducationLevelCompletedId"/> model
        /// </summary>
        public Guid? RefHighestEducationLevelCompletedId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCommunicationMethodId"/> model
        /// </summary>
        public Guid? RefCommunicationMethodId { get; set; }

        public System.Boolean? IncludedInCountedFamilySize { get => _IncludedInCountedFamilySize; set => SetProperty(ref _IncludedInCountedFamilySize, value); }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        public System.Int32? NumberOfHouseholdCollegeStudents { get => _NumberOfHouseholdCollegeStudents; set => SetProperty(ref _NumberOfHouseholdCollegeStudents, value); }

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
        public void Load(IPersonFamily model)
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
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            NumberOfHouseholdCollegeStudents = model.NumberOfHouseholdCollegeStudents;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
