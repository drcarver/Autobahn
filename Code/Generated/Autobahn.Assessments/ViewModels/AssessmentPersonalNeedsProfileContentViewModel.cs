//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentPersonalNeedsProfileContentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileContentViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileContentViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedsProfileContent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedsProfileContent";

        // member variable for the RefAssessmentNeedHazardTypeId property
        private Guid? _RefAssessmentNeedHazardTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedsProfileContentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedHazardType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20026">Assessment Need Hazard Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Need Hazard Type")]
        public Guid? RefAssessmentNeedHazardTypeId { get => _RefAssessmentNeedHazardTypeId; set => SetProperty(ref _RefAssessmentNeedHazardTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfileContent model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentNeedHazardTypeId = model.RefAssessmentNeedHazardTypeId; // Assessment Need Hazard Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
