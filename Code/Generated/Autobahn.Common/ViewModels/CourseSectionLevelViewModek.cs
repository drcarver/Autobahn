//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   CourseSectionLevelViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionLevelViewModel
     /// </summary>
    public partial class CourseSectionLevelViewModel : BindableBase, ICourseSectionLevel
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="CourseSectionId"/> model
        /// </summary>
        public Guid CourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefCourseLevelTypeId"/> model
        /// </summary>
        public Guid RefCourseLevelTypeId { get; set; }

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
        public void Load(ICourseSectionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId;
            RefCourseLevelTypeId = model.RefCourseLevelTypeId;
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