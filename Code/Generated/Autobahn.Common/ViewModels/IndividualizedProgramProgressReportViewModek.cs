//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IndividualizedProgramProgressReportViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramProgressReportViewModel
     /// </summary>
    public partial class IndividualizedProgramProgressReportViewModel : BindableBase, IIndividualizedProgramProgressReport
    {
#region "Backing Fields"
        // member variable for the ProgressDescription property
        private System.String _ProgressDescription;

        // member variable for the ProgressReportDate property
        private System.DateTime? _ProgressReportDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramId"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="IndividualizedProgramProgressReportPlanId"/> model
        /// </summary>
        public Guid IndividualizedProgramProgressReportPlanId { get; set; }

        public System.String ProgressDescription  { get => _ProgressDescription; set => SetProperty(ref _ProgressDescription, value); }

        public System.DateTime? ProgressReportDate { get => _ProgressReportDate; set => SetProperty(ref _ProgressReportDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIPSPProgressReportTypeId"/> model
        /// </summary>
        public Guid? RefIPSPProgressReportTypeId { get; set; }

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
        public void Load(IIndividualizedProgramProgressReport model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            IndividualizedProgramProgressReportPlanId = model.IndividualizedProgramProgressReportPlanId;
            ProgressDescription = model.ProgressDescription;
            ProgressReportDate = model.ProgressReportDate;
            RefIPSPProgressReportTypeId = model.RefIPSPProgressReportTypeId;
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
