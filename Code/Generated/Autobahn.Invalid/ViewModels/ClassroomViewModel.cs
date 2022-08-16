//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ClassroomViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ClassroomViewModel
     /// </summary>
    public partial class ClassroomViewModel : ViewModelBase, Interfaces.IClassroom
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Classroom";

        // member variable for the ClassroomIdentifier property
        private Guid? _ClassroomIdentifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ClassroomIdentifier { get => _ClassroomIdentifier; set => SetProperty(ref _ClassroomIdentifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IClassroom model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassroomIdentifier = model.ClassroomIdentifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
