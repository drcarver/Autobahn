//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationTitleIViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ProgramParticipationTitleIViewModel
     /// </summary>
    public partial class ProgramParticipationTitleIViewModel : ViewModelBase, Interfaces.IProgramParticipationTitleI
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationTitleI";

        // member variable for the RefTitleIIndicatorId property
        private Guid? _RefTitleIIndicatorId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ProgramParticipationTitleIViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIIndicator"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19281">Title I Indicator</a>
        /// </para>
        /// </summary>
        [DisplayName("Title I Indicator")]
        public Guid? RefTitleIIndicatorId { get => _RefTitleIIndicatorId; set => SetProperty(ref _RefTitleIIndicatorId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationTitleI model)
        {
            IsBusy = true;
            Id = model.Id;
            RefTitleIIndicatorId = model.RefTitleIIndicatorId; // Title I Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
