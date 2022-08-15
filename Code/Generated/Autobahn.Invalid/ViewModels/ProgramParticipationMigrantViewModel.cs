//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationMigrantViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationMigrantViewModel
     /// </summary>
    public partial class ProgramParticipationMigrantViewModel : ViewModelBase, Interfaces.IProgramParticipationMigrant
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationMigrant";

        // member variable for the LastQualifyingMoveDate property
        private System.DateTime? _LastQualifyingMoveDate;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationMigrantViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19171">Last Qualifying Move Date</a>
        /// </para>
        /// </summary>
        [DisplayName("Last Qualifying Move Date")]
        public System.DateTime? LastQualifyingMoveDate { get => _LastQualifyingMoveDate; set => SetProperty(ref _LastQualifyingMoveDate, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationMigrant model)
        {
            IsBusy = true;
            Id = model.Id;
            LastQualifyingMoveDate = model.LastQualifyingMoveDate; // Last Qualifying Move Date
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
