//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaPreKEligibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaPreKEligibilityViewModel
     /// </summary>
    public partial class K12LeaPreKEligibilityViewModel : ViewModelBase, Interfaces.IK12LeaPreKEligibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12LeaPreKEligibility";

        // member variable for the RefPrekindergartenEligibilityId property
        private Guid _RefPrekindergartenEligibilityId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12LeaPreKEligibilityViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPrekindergartenEligibility"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19216">Prekindergarten Eligibility</a>
        /// </para>
        /// </summary>
        [DisplayName("Prekindergarten Eligibility")]
        public Guid RefPrekindergartenEligibilityId { get => _RefPrekindergartenEligibilityId; set => SetProperty(ref _RefPrekindergartenEligibilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12LeaPreKEligibility model)
        {
            IsBusy = true;
            Id = model.Id;
            RefPrekindergartenEligibilityId = model.RefPrekindergartenEligibilityId; // Prekindergarten Eligibility
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
