//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentAccommodationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentAccommodationViewModel
     /// </summary>
    public partial class AssessmentAccommodationViewModel : ViewModelBase, Interfaces.IAssessmentAccommodation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentAccommodation";

        // member variable for the RefAssessmentAccommodationCategoryId property
        private Guid? _RefAssessmentAccommodationCategoryId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentAccommodationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentAccommodationCategory"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19374">Assessment Accommodation Category</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Accommodation Category")]
        public Guid? RefAssessmentAccommodationCategoryId { get => _RefAssessmentAccommodationCategoryId; set => SetProperty(ref _RefAssessmentAccommodationCategoryId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentAccommodation model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentAccommodationCategoryId = model.RefAssessmentAccommodationCategoryId; // Assessment Accommodation Category
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
