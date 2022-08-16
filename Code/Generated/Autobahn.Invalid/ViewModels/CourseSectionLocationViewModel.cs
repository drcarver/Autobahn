//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionLocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CourseSectionLocationViewModel
     /// </summary>
    public partial class CourseSectionLocationViewModel : ViewModelBase, Interfaces.ICourseSectionLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionLocation";

        // member variable for the ClassroomId property
        private Guid? _ClassroomId;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefInstructionLocationTypeId property
        private  _RefInstructionLocationTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Classroom"/> model
        /// </summary>
        public Guid? ClassroomId { get => _ClassroomId; set => SetProperty(ref _ClassroomId, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefInstructionLocationType"/> model
        /// </summary>
        public  RefInstructionLocationTypeId { get => _RefInstructionLocationTypeId; set => SetProperty(ref _RefInstructionLocationTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassroomId = model.ClassroomId; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefInstructionLocationTypeId = model.RefInstructionLocationTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
