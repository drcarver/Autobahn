//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsPriceOfAttendanceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsPriceOfAttendanceViewModel
     /// </summary>
    public partial class PsPriceOfAttendanceViewModel : ViewModelBase, Interfaces.IPsPriceOfAttendance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsPriceOfAttendance";

        // member variable for the SessionDesignator property
        private System.String _SessionDesignator;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsPriceOfAttendanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The academic session for which the data are recorded and applicable.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19252">Session Designator</a>
        /// </para>
        /// </summary>
        [DisplayName("Session Designator")]
        public System.String SessionDesignator { get => _SessionDesignator; set => SetProperty(ref _SessionDesignator, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsPriceOfAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            SessionDesignator = model.SessionDesignator; // Session Designator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
