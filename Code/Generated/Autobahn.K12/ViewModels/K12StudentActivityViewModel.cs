//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentActivityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentActivityViewModel
     /// </summary>
    public partial class K12StudentActivityViewModel : ViewModelBase, Interfaces.IK12StudentActivity
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentActivity";

        // member variable for the ActivityTimeInvolved property
        private System.Decimal? _ActivityTimeInvolved;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentActivityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The amount of time the student participated in the events and procedures of an activity, such as a co-curricular or extra-curricular activity that is offered at an education institution.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20502">Activity Time Involved</a>
        /// </para>
        /// </summary>
        [DisplayName("Activity Time Involved")]
        public System.Decimal? ActivityTimeInvolved { get => _ActivityTimeInvolved; set => SetProperty(ref _ActivityTimeInvolved, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentActivity model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivityTimeInvolved = model.ActivityTimeInvolved; // Activity Time Involved
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
