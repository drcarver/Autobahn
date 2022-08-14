//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramMeetingViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

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

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // member variable for the MeetingDate property
        private System.DateTime? _MeetingDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramMeetingViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// The date on which a child's service plan meeting is held.
        /// </summary>
        public System.DateTime? MeetingDate { get => _MeetingDate; set => SetProperty(ref _MeetingDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramMeeting model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId;
            MeetingDate = model.MeetingDate;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
