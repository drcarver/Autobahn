//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildIndividualizedProgramViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.EarlyLearning.ViewModels
{
     /// <summary>
     /// The ELChildIndividualizedProgramViewModel
     /// </summary>
    public partial class ELChildIndividualizedProgramViewModel : ViewModelBase, Interfaces.IELChildIndividualizedProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ELChildIndividualizedProgram";

        // member variable for the RefIDEAIEPStatusId property
        private Guid? _RefIDEAIEPStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ELChildIndividualizedProgramViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIDEAIEPStatus"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20473">IDEA IEP Status</a>
        /// </para>
        /// </summary>
        [DisplayName("IDEA IEP Status")]
        public Guid? RefIDEAIEPStatusId { get => _RefIDEAIEPStatusId; set => SetProperty(ref _RefIDEAIEPStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IELChildIndividualizedProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            RefIDEAIEPStatusId = model.RefIDEAIEPStatusId; // IDEA IEP Status
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
