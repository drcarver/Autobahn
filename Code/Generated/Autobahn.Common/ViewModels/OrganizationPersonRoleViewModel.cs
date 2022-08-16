//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleViewModel
     /// </summary>
    public partial class OrganizationPersonRoleViewModel : ViewModelBase, Interfaces.IOrganizationPersonRole
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRole";

        // member variable for the EntryDate property
        private Guid? _EntryDate;

        // member variable for the ExitDate property
        private  _ExitDate;

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
        public Guid? EntryDate { get => _EntryDate; set => SetProperty(ref _EntryDate, value); }

        /// <summary>
        /// </summary>
        public  ExitDate { get => _ExitDate; set => SetProperty(ref _ExitDate, value); }

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
        public void Load(Interfaces.IOrganizationPersonRole model)
        {
            IsBusy = true;
            Id = model.Id;
            EntryDate = model.EntryDate; // 
            ExitDate = model.ExitDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
