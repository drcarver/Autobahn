//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12StudentLiteracyAssessmentViewModel
     /// </summary>
    public partial class K12StudentLiteracyAssessmentViewModel : ViewModelBase, Interfaces.IK12StudentLiteracyAssessment
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12StudentLiteracyAssessment";

        // member variable for the RefLiteracyAssessmentId property
        private Guid? _RefLiteracyAssessmentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentLiteracyAssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19456">Literacy Assessment Administered Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Literacy Assessment Administered Type")]
        public Guid? RefLiteracyAssessmentId { get => _RefLiteracyAssessmentId; set => SetProperty(ref _RefLiteracyAssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentLiteracyAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            RefLiteracyAssessmentId = model.RefLiteracyAssessmentId; // Literacy Assessment Administered Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
