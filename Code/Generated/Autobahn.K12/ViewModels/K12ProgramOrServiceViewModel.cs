//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12ProgramOrServiceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12ProgramOrServiceViewModel
     /// </summary>
    public partial class K12ProgramOrServiceViewModel : ViewModelBase, Interfaces.IK12ProgramOrService
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12ProgramOrService";

        // member variable for the ProgramInMultiplePurposeFacility property
        private  _ProgramInMultiplePurposeFacility;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefKindergartenDailyLengthId property
        private  _RefKindergartenDailyLengthId;

        // member variable for the RefMepProjectTypeId property
        private  _RefMepProjectTypeId;

        // member variable for the RefMepSessionTypeId property
        private Guid? _RefMepSessionTypeId;

        // member variable for the RefPrekindergartenDailyLengthId property
        private  _RefPrekindergartenDailyLengthId;

        // member variable for the RefProgramGiftedEligibilityId property
        private  _RefProgramGiftedEligibilityId;

        // member variable for the RefTitleIInstructionalServicesId property
        private  _RefTitleIInstructionalServicesId;

        // member variable for the RefTitleIProgramTypeId property
        private  _RefTitleIProgramTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  ProgramInMultiplePurposeFacility { get => _ProgramInMultiplePurposeFacility; set => SetProperty(ref _ProgramInMultiplePurposeFacility, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefKindergartenDailyLength"/> model
        /// </summary>
        public  RefKindergartenDailyLengthId { get => _RefKindergartenDailyLengthId; set => SetProperty(ref _RefKindergartenDailyLengthId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepProjectType"/> model
        /// </summary>
        public  RefMepProjectTypeId { get => _RefMepProjectTypeId; set => SetProperty(ref _RefMepProjectTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMepSessionType"/> model
        /// </summary>
        public Guid? RefMepSessionTypeId { get => _RefMepSessionTypeId; set => SetProperty(ref _RefMepSessionTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenDailyLength"/> model
        /// </summary>
        public  RefPrekindergartenDailyLengthId { get => _RefPrekindergartenDailyLengthId; set => SetProperty(ref _RefPrekindergartenDailyLengthId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramGiftedEligibility"/> model
        /// </summary>
        public  RefProgramGiftedEligibilityId { get => _RefProgramGiftedEligibilityId; set => SetProperty(ref _RefProgramGiftedEligibilityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIInstructionalServices"/> model
        /// </summary>
        public  RefTitleIInstructionalServicesId { get => _RefTitleIInstructionalServicesId; set => SetProperty(ref _RefTitleIInstructionalServicesId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIProgramType"/> model
        /// </summary>
        public  RefTitleIProgramTypeId { get => _RefTitleIProgramTypeId; set => SetProperty(ref _RefTitleIProgramTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12ProgramOrService model)
        {
            IsBusy = true;
            Id = model.Id;
            ProgramInMultiplePurposeFacility = model.ProgramInMultiplePurposeFacility; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefKindergartenDailyLengthId = model.RefKindergartenDailyLengthId; // 
            RefMepProjectTypeId = model.RefMepProjectTypeId; // 
            RefMepSessionTypeId = model.RefMepSessionTypeId; // 
            RefPrekindergartenDailyLengthId = model.RefPrekindergartenDailyLengthId; // 
            RefProgramGiftedEligibilityId = model.RefProgramGiftedEligibilityId; // 
            RefTitleIInstructionalServicesId = model.RefTitleIInstructionalServicesId; // 
            RefTitleIProgramTypeId = model.RefTitleIProgramTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
