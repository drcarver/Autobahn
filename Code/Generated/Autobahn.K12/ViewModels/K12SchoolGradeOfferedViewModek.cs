//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12SchoolGradeOfferedViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolGradeOfferedViewModel
     /// </summary>
    public partial class K12SchoolGradeOfferedViewModel : BindableBase, IK12SchoolGradeOffered
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12SchoolId"/> model
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefGradeLevelId"/> model
        /// </summary>
        public Guid RefGradeLevelId { get; set; }

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
        public void Load(IK12SchoolGradeOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            RefGradeLevelId = model.RefGradeLevelId;
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
