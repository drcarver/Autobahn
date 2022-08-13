//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentNeedApipControlViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipControlViewModel
     /// </summary>
    public partial class AssessmentNeedApipControlViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipControl
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipControl";

        // member variable for the AssessmentNeedTimeMultiplier property
        private System.String _AssessmentNeedTimeMultiplier;

        // member variable for the AssessmentPersonalNeedsProfileControlId property
        private Guid _AssessmentPersonalNeedsProfileControlId;

        // member variable for the BackgroundColor property
        private System.String _BackgroundColor;

        // member variable for the LineReaderHighlightColor property
        private System.String _LineReaderHighlightColor;

        // member variable for the OverlayColor property
        private System.String _OverlayColor;

        // member variable for the RefAssessmentNeedIncreasedWhitespacingTypeId property
        private Guid? _RefAssessmentNeedIncreasedWhitespacingTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedApipControlViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        public System.String AssessmentNeedTimeMultiplier { get => _AssessmentNeedTimeMultiplier; set => SetProperty(ref _AssessmentNeedTimeMultiplier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentPersonalNeedsProfileControl"/> model
        /// </summary>
        public Guid AssessmentPersonalNeedsProfileControlId { get => _AssessmentPersonalNeedsProfileControlId; set => SetProperty(ref _AssessmentPersonalNeedsProfileControlId, value); }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        public System.String BackgroundColor { get => _BackgroundColor; set => SetProperty(ref _BackgroundColor, value); }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        public System.String LineReaderHighlightColor { get => _LineReaderHighlightColor; set => SetProperty(ref _LineReaderHighlightColor, value); }

        /// <summary>
        /// Defines the multiplier to be applied to the time limit to determine the total testing time allowed when Additional Testing Time is specified as part of an Assessment Personal Needs Profile.  If the value is `unlimited' then there is no time limit for the test.
        /// </summary>
        public System.String OverlayColor { get => _OverlayColor; set => SetProperty(ref _OverlayColor, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentNeedIncreasedWhitespacingType"/> model
        /// </summary>
        public Guid? RefAssessmentNeedIncreasedWhitespacingTypeId { get => _RefAssessmentNeedIncreasedWhitespacingTypeId; set => SetProperty(ref _RefAssessmentNeedIncreasedWhitespacingTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipControl model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentNeedTimeMultiplier = model.AssessmentNeedTimeMultiplier;
            AssessmentPersonalNeedsProfileControlId = model.AssessmentPersonalNeedsProfileControlId;
            BackgroundColor = model.BackgroundColor;
            LineReaderHighlightColor = model.LineReaderHighlightColor;
            OverlayColor = model.OverlayColor;
            RefAssessmentNeedIncreasedWhitespacingTypeId = model.RefAssessmentNeedIncreasedWhitespacingTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
