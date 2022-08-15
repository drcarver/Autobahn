//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaPreKEligibleAgesIDEAViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaPreKEligibleAgesIDEAViewModel
     /// </summary>
    public partial class K12LeaPreKEligibleAgesIDEAViewModel : ViewModelBase, Interfaces.IK12LeaPreKEligibleAgesIDEA
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaPreKEligibleAgesIDEA";

        // member variable for the RefPreKEligibleAgesNonIDEAId property
        private Guid _RefPreKEligibleAgesNonIDEAId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaPreKEligibleAgesIDEAViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPreKEligibleAgesNonIDEA"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19217">Prekindergarten Eligible Ages for Non-IDEA Students</a>
        /// </para>
        /// </summary>
        [DisplayName("Prekindergarten Eligible Ages for Non-IDEA Students")]
        public Guid RefPreKEligibleAgesNonIDEAId { get => _RefPreKEligibleAgesNonIDEAId; set => SetProperty(ref _RefPreKEligibleAgesNonIDEAId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaPreKEligibleAgesIDEA model)
        {
            IsBusy = true;
            Id = model.Id;
            RefPreKEligibleAgesNonIDEAId = model.RefPreKEligibleAgesNonIDEAId; // Prekindergarten Eligible Ages for Non-IDEA Students
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
