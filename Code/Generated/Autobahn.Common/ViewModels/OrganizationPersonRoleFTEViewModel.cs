//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPersonRoleFTEViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationPersonRoleFTEViewModel
     /// </summary>
    public partial class OrganizationPersonRoleFTEViewModel : ViewModelBase, Interfaces.IOrganizationPersonRoleFTE
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationPersonRoleFTE";

        // member variable for the FullTimeEquivalency property
        private  _FullTimeEquivalency;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private Guid? _RecordStartDateTime;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationPersonRoleFTE model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeEquivalency = model.FullTimeEquivalency; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
