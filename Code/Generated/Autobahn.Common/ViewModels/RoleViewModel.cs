//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleViewModel
     /// </summary>
    public partial class RoleViewModel : ViewModelBase, Interfaces.IRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Role";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        // member variable for the RefRoleId property
        private  _RefRoleId;

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
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRole"/> model
        /// </summary>
        public  RefRoleId { get => _RefRoleId; set => SetProperty(ref _RefRoleId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRole model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefRoleId = model.RefRoleId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
