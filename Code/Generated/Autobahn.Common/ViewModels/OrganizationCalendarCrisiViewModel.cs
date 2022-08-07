//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationCalendarCrisiViewModel.cs
//**********************************************************


namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarCrisiViewModel
     /// </summary>
    public partial class OrganizationCalendarCrisiViewModel : ViewModelBase, Interfaces.IOrganizationCalendarCrisiViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarCrisi";

        // member variable for the OrganizationCalendarCrisisId property
        private Guid _OrganizationCalendarCrisisId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the Code property
        private System.String _Code;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the Type property
        private System.String _Type;

        // member variable for the CrisisDescription property
        private System.String _CrisisDescription;

        // member variable for the CrisisEndDate property
        private System.DateTime? _CrisisEndDate;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarCrisiViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationCalendarCrisisId"/> model
        /// </summary>
        public Guid OrganizationCalendarCrisisId { get => _OrganizationCalendarCrisisId; set => SetProperty(ref _OrganizationCalendarCrisisId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        public System.String Code  { get => _Code; set => SetProperty(ref _Code, value); }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        public System.String Type  { get => _Type; set => SetProperty(ref _Type, value); }

        public System.String CrisisDescription  { get => _CrisisDescription; set => SetProperty(ref _CrisisDescription, value); }

        public System.DateTime? CrisisEndDate { get => _CrisisEndDate; set => SetProperty(ref _CrisisEndDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarCrisi model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationCalendarCrisisId = model.OrganizationCalendarCrisisId;
            OrganizationId = model.OrganizationId;
            Code = model.Code;
            Name = model.Name;
            StartDate = model.StartDate;
            EndDate = model.EndDate;
            Type = model.Type;
            CrisisDescription = model.CrisisDescription;
            CrisisEndDate = model.CrisisEndDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
