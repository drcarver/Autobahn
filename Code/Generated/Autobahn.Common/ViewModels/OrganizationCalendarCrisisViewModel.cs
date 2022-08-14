//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisViewModel.cs
//**********************************************************

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

        // member variable for the CrisisDescription property
        private System.String _CrisisDescription;

        // member variable for the CrisisEndDate property
        private System.DateTime? _CrisisEndDate;

        // member variable for the EndDate property
        private System.DateTime? _EndDate;

        // member variable for the Name property
        private System.String _Name;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // member variable for the StartDate property
        private System.DateTime? _StartDate;

        // member variable for the Type property
        private System.String _Type;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarCrisisViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
        /// </summary>
        public System.String CrisisDescription { get => _CrisisDescription; set => SetProperty(ref _CrisisDescription, value); }

        /// <summary>
        /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
        /// </summary>
        public System.DateTime? CrisisEndDate { get => _CrisisEndDate; set => SetProperty(ref _CrisisEndDate, value); }

        /// <summary>
        /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Organization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
        /// </summary>
        public System.String Type { get => _Type; set => SetProperty(ref _Type, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarCrisis model)
        {
            IsBusy = true;
            Id = model.Id;
            CrisisDescription = model.CrisisDescription;
            CrisisEndDate = model.CrisisEndDate;
            EndDate = model.EndDate;
            Name = model.Name;
            OrganizationId = model.OrganizationId;
            StartDate = model.StartDate;
            Type = model.Type;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
