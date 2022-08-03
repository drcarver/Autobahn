//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationViewModel
     /// </summary>
    public partial class StaffEvaluationViewModel : BindableBase, IStaffEvaluation
    {
#region "Backing Fields"
        // member variable for the System property
        private System.String _System;

        // member variable for the Scale property
        private System.String _Scale;

        // member variable for the ScoreOrRating property
        private System.String _ScoreOrRating;

        // member variable for the Outcome property
        private System.String _Outcome;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.String System  { get => _System; set => SetProperty(ref _System, value); }

        public System.String Scale  { get => _Scale; set => SetProperty(ref _Scale, value); }

        public System.String ScoreOrRating  { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        public System.String Outcome  { get => _Outcome; set => SetProperty(ref _Outcome, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStaffPerformanceLevelId"/> model
        /// </summary>
        public Guid? RefStaffPerformanceLevelId { get; set; }

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
        public void Load(IStaffEvaluation model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            System = model.System;
            Scale = model.Scale;
            ScoreOrRating = model.ScoreOrRating;
            Outcome = model.Outcome;
            RefStaffPerformanceLevelId = model.RefStaffPerformanceLevelId;
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
