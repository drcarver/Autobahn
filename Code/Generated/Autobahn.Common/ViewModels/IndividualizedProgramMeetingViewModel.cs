//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramMeetingViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramMeeting View Model
     /// </summary>
    public partial class IndividualizedProgramMeetingViewModel : ViewModelBase, Interfaces.IIndividualizedProgramMeeting
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramMeeting";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // MeetingDate -- (backing property for Individualized Program Service Plan Meeting Date)
        private System.DateTime? _MeetingDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IIndividualizedProgram"/> model
        /// </summary>
        public Guid IndividualizedProgramId { get => _IndividualizedProgramId; set => SetProperty(ref _IndividualizedProgramId, value); }

        /// <summary>
        /// Individualized Program Service Plan Meeting Date
        /// <para>
        /// The date on which a child's service plan meeting is held.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20665">Individualized Program Service Plan Meeting Date</a>
        /// </para>
        /// </summary>
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
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            MeetingDate = model.MeetingDate; // Individualized Program Service Plan Meeting Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
