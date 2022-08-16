//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsProgramViewModel
     /// </summary>
    public partial class PsProgramViewModel : ViewModelBase, Interfaces.IPsProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsProgram";

        // member variable for the NormalLengthTimeForCompletion property
        private  _NormalLengthTimeForCompletion;

        // member variable for the ProgramLengthHours property
        private  _ProgramLengthHours;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCipCodeId property
        private Guid? _RefCipCodeId;

        // member variable for the RefCipVersionId property
        private  _RefCipVersionId;

        // member variable for the RefDQPCategoriesOfLearningId property
        private  _RefDQPCategoriesOfLearningId;

        // member variable for the RefProgramLengthHoursTypeId property
        private  _RefProgramLengthHoursTypeId;

        // member variable for the RefPSProgramLevelId property
        private  _RefPSProgramLevelId;

        // member variable for the RefTimeForCompletionUnitsId property
        private  _RefTimeForCompletionUnitsId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  NormalLengthTimeForCompletion { get => _NormalLengthTimeForCompletion; set => SetProperty(ref _NormalLengthTimeForCompletion, value); }

        /// <summary>
        /// </summary>
        public  ProgramLengthHours { get => _ProgramLengthHours; set => SetProperty(ref _ProgramLengthHours, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipCode"/> model
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCipVersion"/> model
        /// </summary>
        public  RefCipVersionId { get => _RefCipVersionId; set => SetProperty(ref _RefCipVersionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDQPCategoriesOfLearning"/> model
        /// </summary>
        public  RefDQPCategoriesOfLearningId { get => _RefDQPCategoriesOfLearningId; set => SetProperty(ref _RefDQPCategoriesOfLearningId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefProgramLengthHoursType"/> model
        /// </summary>
        public  RefProgramLengthHoursTypeId { get => _RefProgramLengthHoursTypeId; set => SetProperty(ref _RefProgramLengthHoursTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPSProgramLevel"/> model
        /// </summary>
        public  RefPSProgramLevelId { get => _RefPSProgramLevelId; set => SetProperty(ref _RefPSProgramLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTimeForCompletionUnits"/> model
        /// </summary>
        public  RefTimeForCompletionUnitsId { get => _RefTimeForCompletionUnitsId; set => SetProperty(ref _RefTimeForCompletionUnitsId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            NormalLengthTimeForCompletion = model.NormalLengthTimeForCompletion; // 
            ProgramLengthHours = model.ProgramLengthHours; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCipCodeId = model.RefCipCodeId; // 
            RefCipVersionId = model.RefCipVersionId; // 
            RefDQPCategoriesOfLearningId = model.RefDQPCategoriesOfLearningId; // 
            RefProgramLengthHoursTypeId = model.RefProgramLengthHoursTypeId; // 
            RefPSProgramLevelId = model.RefPSProgramLevelId; // 
            RefTimeForCompletionUnitsId = model.RefTimeForCompletionUnitsId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
