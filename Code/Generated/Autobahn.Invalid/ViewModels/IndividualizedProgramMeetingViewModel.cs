//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramMeetingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramMeetingViewModel
     /// </summary>
    public partial class IndividualizedProgramMeetingViewModel : ViewModelBase, Interfaces.IIndividualizedProgramMeeting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramMeeting";

        // member variable for the MeetingDate property
        private System.DateTime? _MeetingDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramMeetingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The date on which a child's service plan meeting is held.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20665">Individualized Program Service Plan Meeting Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Individualized Program Service Plan Meeting Date")]
        public System.DateTime? MeetingDate { get => _MeetingDate; set => SetProperty(ref _MeetingDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramMeeting model)
        {
            IsBusy = true;
            Id = model.Id;
            MeetingDate = model.MeetingDate; // Individualized Program Service Plan Meeting Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
