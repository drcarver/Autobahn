//**********************************************************
//* DomainName: Career and Technical Education (CTE)
//* FileName:   ProgramParticipationCteViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.CTE.ViewModels
{
     /// <summary>
     /// The ProgramParticipationCteViewModel
     /// </summary>
    public partial class ProgramParticipationCteViewModel : ViewModelBase, Interfaces.IProgramParticipationCte
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationCte";

        // member variable for the CteCompleter property
        private System.Boolean? _CteCompleter;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationCteViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// An indication of a student who reached a state-defined threshold of a career and technical education program/pathway.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19036">Career and Technical Education Completer</a>
        /// </para>
        /// </summary>
        [DisplayName("Career and Technical Education Completer")]
        public System.Boolean? CteCompleter { get => _CteCompleter; set => SetProperty(ref _CteCompleter, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationCte model)
        {
            IsBusy = true;
            Id = model.Id;
            CteCompleter = model.CteCompleter; // Career and Technical Education Completer
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
