//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ServicePlanViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ServicePlanViewModel
     /// </summary>
    public partial class ServicePlanViewModel : ViewModelBase, Interfaces.IServicePlan
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ServicePlan";

        // member variable for the DeclinedServicesDate property
        private  _DeclinedServicesDate;

        // member variable for the ExtendsOutsideSchoolYear property
        private  _ExtendsOutsideSchoolYear;

        // member variable for the InclusiveSettingIndicator property
        private  _InclusiveSettingIndicator;

        // member variable for the ReasonForDeclinedServices property
        private Guid? _ReasonForDeclinedServices;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the SettingDescription property
        private  _SettingDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  DeclinedServicesDate { get => _DeclinedServicesDate; set => SetProperty(ref _DeclinedServicesDate, value); }

        /// <summary>
        /// </summary>
        public  ExtendsOutsideSchoolYear { get => _ExtendsOutsideSchoolYear; set => SetProperty(ref _ExtendsOutsideSchoolYear, value); }

        /// <summary>
        /// </summary>
        public  InclusiveSettingIndicator { get => _InclusiveSettingIndicator; set => SetProperty(ref _InclusiveSettingIndicator, value); }

        /// <summary>
        /// </summary>
        public Guid? ReasonForDeclinedServices { get => _ReasonForDeclinedServices; set => SetProperty(ref _ReasonForDeclinedServices, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  SettingDescription { get => _SettingDescription; set => SetProperty(ref _SettingDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IServicePlan model)
        {
            IsBusy = true;
            Id = model.Id;
            DeclinedServicesDate = model.DeclinedServicesDate; // 
            ExtendsOutsideSchoolYear = model.ExtendsOutsideSchoolYear; // 
            InclusiveSettingIndicator = model.InclusiveSettingIndicator; // 
            ReasonForDeclinedServices = model.ReasonForDeclinedServices; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            SettingDescription = model.SettingDescription; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
