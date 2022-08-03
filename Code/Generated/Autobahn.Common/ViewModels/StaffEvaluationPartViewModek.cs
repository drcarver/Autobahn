//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffEvaluationPartViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEvaluationPartViewModel
     /// </summary>
    public partial class StaffEvaluationPartViewModel : BindableBase, IStaffEvaluationPart
    {
#region "Backing Fields"
        // member variable for the PartName property
        private System.String _PartName;

        // member variable for the Scale property
        private System.String _Scale;

        // member variable for the ScoreOrRating property
        private System.String _ScoreOrRating;

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

        public System.String PartName  { get => _PartName; set => SetProperty(ref _PartName, value); }

        public System.String Scale  { get => _Scale; set => SetProperty(ref _Scale, value); }

        public System.String ScoreOrRating  { get => _ScoreOrRating; set => SetProperty(ref _ScoreOrRating, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="StaffEvaluationId"/> model
        /// </summary>
        public Guid? StaffEvaluationId { get; set; }

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
        public void Load(IStaffEvaluationPart model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PartName = model.PartName;
            Scale = model.Scale;
            ScoreOrRating = model.ScoreOrRating;
            StaffEvaluationId = model.StaffEvaluationId;
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
