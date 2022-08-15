//**********************************************************
//* DomainName: Common Models
//* FileName:   RoleAttendanceViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RoleAttendanceViewModel
     /// </summary>
    public partial class RoleAttendanceViewModel : ViewModelBase, Interfaces.IRoleAttendance
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from RoleAttendance";

        // member variable for the NumberOfDaysAbsent property
        private System.Decimal? _NumberOfDaysAbsent;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RoleAttendanceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The number of days a person is absent when school is in session during a given reporting period.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19201">Number of Days Absent</a>
        /// </para>
        /// </summary>
        [DisplayName("Number of Days Absent")]
        public System.Decimal? NumberOfDaysAbsent { get => _NumberOfDaysAbsent; set => SetProperty(ref _NumberOfDaysAbsent, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRoleAttendance model)
        {
            IsBusy = true;
            Id = model.Id;
            NumberOfDaysAbsent = model.NumberOfDaysAbsent; // Number of Days Absent
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
