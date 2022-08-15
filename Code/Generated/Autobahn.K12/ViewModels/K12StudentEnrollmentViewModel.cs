//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentEnrollmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentEnrollmentViewModel
     /// </summary>
    public partial class K12StudentEnrollmentViewModel : ViewModelBase, Interfaces.IK12StudentEnrollment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentEnrollment";

        // member variable for the RefFoodServiceEligibilityId property
        private Guid? _RefFoodServiceEligibilityId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentEnrollmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFoodServiceEligibility"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19092">Eligibility Status for School Food Service Programs</a>
        /// </para>
        /// </summary>
        [DisplayName("Eligibility Status for School Food Service Programs")]
        public Guid? RefFoodServiceEligibilityId { get => _RefFoodServiceEligibilityId; set => SetProperty(ref _RefFoodServiceEligibilityId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentEnrollment model)
        {
            IsBusy = true;
            Id = model.Id;
            RefFoodServiceEligibilityId = model.RefFoodServiceEligibilityId; // Eligibility Status for School Food Service Programs
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
