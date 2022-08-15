//**********************************************************
//* DomainName: Common Models
//* FileName:   StaffEmploymentViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The StaffEmploymentViewModel
     /// </summary>
    public partial class StaffEmploymentViewModel : ViewModelBase, Interfaces.IStaffEmployment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from StaffEmployment";

        // member variable for the FullTimeEquivalency property
        private System.Decimal? _FullTimeEquivalency;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the StaffEmploymentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The ratio between the hours of work expected in a position and the hours of work normally expected in a full-time position in the same setting.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19118">Staff Full Time Equivalency</a>
        /// </para>
        /// </summary>
        [DisplayName("Staff Full Time Equivalency")]
        public System.Decimal? FullTimeEquivalency { get => _FullTimeEquivalency; set => SetProperty(ref _FullTimeEquivalency, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IStaffEmployment model)
        {
            IsBusy = true;
            Id = model.Id;
            FullTimeEquivalency = model.FullTimeEquivalency; // Staff Full Time Equivalency
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
