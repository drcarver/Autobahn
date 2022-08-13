//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12StudentLiteracyAssessmentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

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

        // member variable for the LiteracyGoalMetStatus property
        private System.Boolean? _LiteracyGoalMetStatus;

        // member variable for the LiteracyPostTestStatus property
        private System.Boolean? _LiteracyPostTestStatus;

        // member variable for the LiteracyPreTestStatus property
        private System.Boolean? _LiteracyPreTestStatus;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefLiteracyAssessmentId property
        private Guid? _RefLiteracyAssessmentId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12StudentLiteracyAssessmentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public System.Boolean? LiteracyGoalMetStatus { get => _LiteracyGoalMetStatus; set => SetProperty(ref _LiteracyGoalMetStatus, value); }

        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public System.Boolean? LiteracyPostTestStatus { get => _LiteracyPostTestStatus; set => SetProperty(ref _LiteracyPostTestStatus, value); }

        /// <summary>
        /// The type of literacy test administered.
        /// </summary>
        public System.Boolean? LiteracyPreTestStatus { get => _LiteracyPreTestStatus; set => SetProperty(ref _LiteracyPreTestStatus, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLiteracyAssessment"/> model
        /// </summary>
        public Guid? RefLiteracyAssessmentId { get => _RefLiteracyAssessmentId; set => SetProperty(ref _RefLiteracyAssessmentId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12StudentLiteracyAssessment model)
        {
            IsBusy = true;
            Id = model.Id;
            LiteracyGoalMetStatus = model.LiteracyGoalMetStatus;
            LiteracyPostTestStatus = model.LiteracyPostTestStatus;
            LiteracyPreTestStatus = model.LiteracyPreTestStatus;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefLiteracyAssessmentId = model.RefLiteracyAssessmentId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
