//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   ClassroomViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ClassroomViewModel
     /// </summary>
    public partial class ClassroomViewModel : BindableBase, IClassroom
    {
#region "Backing Fields"
        // member variable for the ClassroomIdentifier property
        private System.String _ClassroomIdentifier;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="LocationId"/> model
        /// </summary>
        public Guid LocationId { get; set; }

        public System.String ClassroomIdentifier  { get => _ClassroomIdentifier; set => SetProperty(ref _ClassroomIdentifier, value); }

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
        public void Load(IClassroom model)
        {
            IsBusy = true;
            Id = model.Id;
            LocationId = model.LocationId;
            ClassroomIdentifier = model.ClassroomIdentifier;
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
