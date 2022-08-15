//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationCalendarDayViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationCalendarDayViewModel
     /// </summary>
    public partial class OrganizationCalendarDayViewModel : ViewModelBase, Interfaces.IOrganizationCalendarDay
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationCalendarDay";

        // member variable for the AlternateDayName property
        private System.String _AlternateDayName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the OrganizationCalendarDayViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An alternate name used for the school day, typically used for the bell schedule (e.g., Blue day, Red day).
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19591">Alternate Day Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Alternate Day Name")]
        public System.String AlternateDayName { get => _AlternateDayName; set => SetProperty(ref _AlternateDayName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationCalendarDay model)
        {
            IsBusy = true;
            Id = model.Id;
            AlternateDayName = model.AlternateDayName; // Alternate Day Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
