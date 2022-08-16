//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AuthorizationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AuthorizationViewModel
     /// </summary>
    public partial class AuthorizationViewModel : ViewModelBase, Interfaces.IAuthorization
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Authorization";

        // member variable for the ApplicationRoleName property
        private Guid? _ApplicationRoleName;

        // member variable for the EndDate property
        private  _EndDate;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the StartDate property
        private  _StartDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? ApplicationRoleName { get => _ApplicationRoleName; set => SetProperty(ref _ApplicationRoleName, value); }

        /// <summary>
        /// </summary>
        public  EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAuthorization model)
        {
            IsBusy = true;
            Id = model.Id;
            ApplicationRoleName = model.ApplicationRoleName; // 
            EndDate = model.EndDate; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            StartDate = model.StartDate; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
