//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarCrisisViewModel.cs
//* Name:       Crisis Code
//* Definition: A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A unique number or alphanumeric code used to identify a crisis. This code should be able to accommodate numerous crises within a single school year. It is associated with the displaced student identifier in order to link a crisis to a student who was displaced or otherwise affected by the event. If the same code values are to be used over multiple years, it is important to have enough crisis-specific items (e.g., school year, date/time) to keep the events unique over time.
     /// </summary>
    public partial class OrganizationCalendarCrisisViewModel : ViewModelBase, Interfaces.IOrganizationCalendarCrisis
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarCrisis";

        // CrisisDescription -- (backing property for Crisis Description)
        private System.String _CrisisDescription;

        // CrisisEndDate -- (backing property for Crisis End Date)
        private System.DateTime? _CrisisEndDate;

        // EndDate -- (backing property for Crisis End Date)
        private System.DateTime? _EndDate;

        // Name -- (backing property for Crisis Name)
        private System.String _Name;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // StartDate -- (backing property for Crisis Start Date)
        private System.DateTime? _StartDate;

        // Type -- (backing property for Crisis Type)
        private System.String _Type;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Crisis Description
        /// <para>
        /// A description of the crisis that caused the displacement of students.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20526">Crisis Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CrisisDescription { get => _CrisisDescription; set => SetProperty(ref _CrisisDescription, value); }

        /// <summary>
        /// Crisis End Date
        /// <para>
        /// The date on which the crisis ceased to affect the agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? CrisisEndDate { get => _CrisisEndDate; set => SetProperty(ref _CrisisEndDate, value); }

        /// <summary>
        /// Crisis End Date
        /// <para>
        /// The date on which the crisis ceased to affect the agency.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20528">Crisis End Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? EndDate { get => _EndDate; set => SetProperty(ref _EndDate, value); }

        /// <summary>
        /// Crisis Name
        /// <para>
        /// The name of the crisis that caused the displacement of students.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19605">Crisis Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Crisis Start Date
        /// <para>
        /// The year, month and day on which the crisis affected the agency. This date may not be the same as the date the crisis occurred if evacuation orders are implemented in anticipation of a crisis.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19607">Crisis Start Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? StartDate { get => _StartDate; set => SetProperty(ref _StartDate, value); }

        /// <summary>
        /// Crisis Type
        /// <para>
        /// The type or category of crisis (ex., chemical, earthquake, flood, wildfire, etc.).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19606">Crisis Type</a>
        /// </para>
        /// </summary>
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
            CrisisDescription = model.CrisisDescription; // Crisis Description
            CrisisEndDate = model.CrisisEndDate; // Crisis End Date
            EndDate = model.EndDate; // Crisis End Date
            Name = model.Name; // Crisis Name
            OrganizationId = model.OrganizationId; // 
            StartDate = model.StartDate; // Crisis Start Date
            Type = model.Type; // Crisis Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
