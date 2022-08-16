//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarCrisisViewModel
     /// </summary>
    public partial class OrganizationCalendarCrisisViewModel : ViewModelBase, Interfaces.IOrganizationCalendarCrisis
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarCrisis";

        // member variable for the Code property
        private Guid? _Code;

        // member variable for the CrisisDescription property
        private  _CrisisDescription;

        // member variable for the CrisisEndDate property
        private  _CrisisEndDate;

        // member variable for the EndDate property
        private  _EndDate;

        // member variable for the Name property
        private  _Name;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the StartDate property
        private  _StartDate;

        // member variable for the Type property
        private  _Type;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Code { get => _Code; set => SetProperty(ref _Code, value); }

        /// <summary>
        /// </summary>
        public  CrisisDescription { get => _CrisisDescription; set => SetProperty(ref _CrisisDescription, value); }

        /// <summary>
        /// </summary>
        public  CrisisEndDate { get => _CrisisEndDate; set => SetProperty(ref _CrisisEndDate, value); }

        /// <summary>
        /// </summary>
        public  EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// </summary>
        public  Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// </summary>
        public  Type { get => _Type; set => SetProperty(ref _Type, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarCrisis model)
        {
            IsBusy = true;
            Id = model.Id;
            Code = model.Code; // 
            CrisisDescription = model.CrisisDescription; // 
            CrisisEndDate = model.CrisisEndDate; // 
            EndDate = model.EndDate; // 
            Name = model.Name; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            StartDate = model.StartDate; // 
            Type = model.Type; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
