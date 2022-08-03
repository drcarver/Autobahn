//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   StaffExperienceViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffExperienceViewModel
     /// </summary>
    public partial class StaffExperienceViewModel : BindableBase, IStaffExperience
    {
#region "Backing Fields"
        // member variable for the YearsOfPriorTeachingExperience property
        private System.Decimal? _YearsOfPriorTeachingExperience;

        // member variable for the YearsOfPriorAETeachingExperience property
        private System.Decimal? _YearsOfPriorAETeachingExperience;

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

        public System.Decimal? YearsOfPriorTeachingExperience { get => _YearsOfPriorTeachingExperience; set => SetProperty(ref _YearsOfPriorTeachingExperience, value); }

        public System.Decimal? YearsOfPriorAETeachingExperience { get => _YearsOfPriorAETeachingExperience; set => SetProperty(ref _YearsOfPriorAETeachingExperience, value); }

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
        public void Load(IStaffExperience model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            YearsOfPriorTeachingExperience = model.YearsOfPriorTeachingExperience;
            YearsOfPriorAETeachingExperience = model.YearsOfPriorAETeachingExperience;
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
