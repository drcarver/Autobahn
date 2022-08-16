//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServiceStaffViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ServiceStaffViewModel
     /// </summary>
    public partial class ServiceStaffViewModel : ViewModelBase, Interfaces.IServiceStaff
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServiceStaff";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefSpecialEducationStaffCategoryId property
        private Guid? _RefSpecialEducationStaffCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefSpecialEducationStaffCategory"/> model
        /// </summary>
        public Guid? RefSpecialEducationStaffCategoryId { get => _RefSpecialEducationStaffCategoryId; set => SetProperty(ref _RefSpecialEducationStaffCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServiceStaff model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefSpecialEducationStaffCategoryId = model.RefSpecialEducationStaffCategoryId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
