//**********************************************************
//* DomainName: Common Models
//* FileName:   IndividualizedProgramAmendmentViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IndividualizedProgramAmendment View Model
     /// </summary>
    public partial class IndividualizedProgramAmendmentViewModel : ViewModelBase, Interfaces.IIndividualizedProgramAmendment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from IndividualizedProgramAmendment";

        // member variable for the IndividualizedProgramId property
        private Guid _IndividualizedProgramId;

        // ReasonDescription -- (backing property for Individualized Program Service Plan Amendment Reason Description)
        private System.String _ReasonDescription;

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
        /// Individualized Program Service Plan Amendment Reason Description
        /// <para>
        /// Description of the reason changes were made to the individualized program service plan.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20669">Individualized Program Service Plan Amendment Reason Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ReasonDescription { get => _ReasonDescription; set => SetProperty(ref _ReasonDescription, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIndividualizedProgramAmendment model)
        {
            IsBusy = true;
            Id = model.Id;
            IndividualizedProgramId = model.IndividualizedProgramId; // 
            ReasonDescription = model.ReasonDescription; // Individualized Program Service Plan Amendment Reason Description
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
