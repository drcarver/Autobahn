//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarSessionViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarSessionViewModel
     /// </summary>
    public partial class OrganizationCalendarSessionViewModel : ViewModelBase, Interfaces.IOrganizationCalendarSession
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarSession";

        // member variable for the BeginDate property
        private System.DateTime? _BeginDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarSessionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day an instance of a course officially began.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19054">Course Begin Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Course Begin Date")]
        public System.DateTime? BeginDate { get => _BeginDate; set => SetProperty(ref _BeginDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarSession model)
        {
            IsBusy = true;
            Id = model.Id;
            BeginDate = model.BeginDate; // Course Begin Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
