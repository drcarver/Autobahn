//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressGoalViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressGoalViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressGoalViewModel : BindableBase, IIndividualizedProgramProgressGoal
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="GoalPerformanceId"/> model
        /// </summary>
        public Guid GoalPerformanceId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReportId"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportId { get; set; }

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
        public void Load(IIndividualizedProgramProgressGoal model)
        {
            IsBusy = true;
            Id = model.Id;
            GoalPerformanceId = model.GoalPerformanceId;
            IndividualizedProgramProgressReportId = model.IndividualizedProgramProgressReportId;
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