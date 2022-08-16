//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramGoalViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramGoalViewModel
     /// </summary>
    public partial class IndividualizedProgramGoalViewModel : ViewModelBase, Interfaces.IIndividualizedProgramGoal
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramGoal";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefIEPGoalTypeId property
        private Guid? _RefIEPGoalTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIEPGoalType"/> model
        /// </summary>
        public Guid? RefIEPGoalTypeId { get => _RefIEPGoalTypeId; set => SetProperty(ref _RefIEPGoalTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefIEPGoalTypeId = model.RefIEPGoalTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
