//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   IndividualizedProgramAmendmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAmendmentViewModel
     /// </summary>
    public partial class IndividualizedProgramAmendmentViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAmendment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAmendment";

        // member variable for the ReasonDescription property
        private System.String _ReasonDescription;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the IndividualizedProgramAmendmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Description of the reason changes were made to the individualized program service plan.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20669">Individualized Program Service Plan Amendment Reason Description</a>
        /// </para>
        /// </summary>
        [DisplayName("Individualized Program Service Plan Amendment Reason Description")]
        public System.String ReasonDescription { get => _ReasonDescription; set => SetProperty(ref _ReasonDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAmendment model)
        {
            IsBusy = true;
            Id = model.Id;
            ReasonDescription = model.ReasonDescription; // Individualized Program Service Plan Amendment Reason Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
