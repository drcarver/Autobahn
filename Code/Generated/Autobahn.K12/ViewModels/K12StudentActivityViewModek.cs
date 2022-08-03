//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12StudentActivityViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentActivityViewModel
     /// </summary>
    public partial class K12StudentActivityViewModel : BindableBase, IK12StudentActivity
    {
#region "Backing Fields"
        // member variable for the ActivityTimeInvolved property
        private System.Decimal? _ActivityTimeInvolved;

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

        public System.Decimal? ActivityTimeInvolved { get => _ActivityTimeInvolved; set => SetProperty(ref _ActivityTimeInvolved, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefActivityTimeMeasurementTypeId"/> model
        /// </summary>
        public Guid? RefActivityTimeMeasurementTypeId { get; set; }

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
        public void Load(IK12StudentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            ActivityTimeInvolved = model.ActivityTimeInvolved;
            RefActivityTimeMeasurementTypeId = model.RefActivityTimeMeasurementTypeId;
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
