//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisiViewModel.cs
//**********************************************************

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarCrisiViewModel
     /// </summary>
    public partial class OrganizationCalendarCrisiViewModel : ViewModelBase, Interfaces.IOrganizationCalendarCrisi
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarCrisi";

        // member variable for the CrisisDescription property
        private System.String _CrisisDescription;

        // member variable for the CrisisEndDate property
        private System.DateTime? _CrisisEndDate;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the OrganizationCalendarCrisisId property
        private Guid _OrganizationCalendarCrisisId;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the Type property
        private System.String _Type;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarCrisiViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.String CrisisDescription { get => _CrisisDescription; set => SetProperty(ref _CrisisDescription, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? CrisisEndDate { get => _CrisisEndDate; set => SetProperty(ref _CrisisEndDate, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationCalendarCrisis"/> model
        /// </summary>
        public Guid OrganizationCalendarCrisisId { get => _OrganizationCalendarCrisisId; set => SetProperty(ref _OrganizationCalendarCrisisId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// 
        /// </summary>
        public System.String Type { get => _Type; set => SetProperty(ref _Type, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarCrisi model)
        {
            IsBusy = true;
            Id = model.Id;
            CrisisDescription = model.CrisisDescription;
            CrisisEndDate = model.CrisisEndDate;
            EndDate = model.EndDate;
            Name = model.Name;
            OrganizationCalendarCrisisId = model.OrganizationCalendarCrisisId;
            OrganizationId = model.OrganizationId;
            StartDate = model.StartDate;
            Type = model.Type;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
