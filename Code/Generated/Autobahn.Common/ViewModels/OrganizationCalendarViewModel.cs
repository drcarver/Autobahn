//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarViewModel.cs
//* Name:       Calendar Code
//* Definition: A unique number assigned by a school district to a school calendar.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// A unique number assigned by a school district to a school calendar.
     /// </summary>
    public partial class OrganizationCalendarViewModel : ViewModelBase, Interfaces.IOrganizationCalendar
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendar";

        // CalendarCode -- (backing property for Calendar Code)
        private System.String _CalendarCode;

        // CalendarDescription -- (backing property for Calendar Description)
        private System.String _CalendarDescription;

        // CalendarYear -- (backing property for School Year)
        private System.String _CalendarYear;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Calendar Code
        /// <para>
        /// A unique number assigned by a school district to a school calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19485">Calendar Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CalendarCode { get => _CalendarCode; set => SetProperty(ref _CalendarCode, value); }

        /// <summary>
        /// Calendar Description
        /// <para>
        /// A description or identification of the calendar.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19486">Calendar Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CalendarDescription { get => _CalendarDescription; set => SetProperty(ref _CalendarDescription, value); }

        /// <summary>
        /// School Year
        /// <para>
        /// The year for a reported school session.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19243">School Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CalendarYear { get => _CalendarYear; set => SetProperty(ref _CalendarYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendar model)
        {
            IsBusy = true;
            Id = model.Id;
            CalendarCode = model.CalendarCode; // Calendar Code
            CalendarDescription = model.CalendarDescription; // Calendar Description
            CalendarYear = model.CalendarYear; // School Year
            OrganizationId = model.OrganizationId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
