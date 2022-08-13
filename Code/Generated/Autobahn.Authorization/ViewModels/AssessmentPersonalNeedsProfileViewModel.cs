//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentPersonalNeedsProfileViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentPersonalNeedsProfileViewModel
     /// </summary>
    public partial class AssessmentPersonalNeedsProfileViewModel : ViewModelBase, Interfaces.IAssessmentPersonalNeedsProfile
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentPersonalNeedsProfile";

        // member variable for the ActivateByDefault property
        private System.Boolean? _ActivateByDefault;

        // member variable for the AssessmentNeedType property
        private System.String _AssessmentNeedType;

        // member variable for the AssignedSupportFlag property
        private System.Boolean? _AssignedSupportFlag;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentPersonalNeedsProfileViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? ActivateByDefault { get => _ActivateByDefault; set => SetProperty(ref _ActivateByDefault, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.String AssessmentNeedType { get => _AssessmentNeedType; set => SetProperty(ref _AssessmentNeedType, value); }

        /// <summary>
        /// Defines whether or not the individual needs the kind of support defined by the entity.
        /// </summary>
        public System.Boolean? AssignedSupportFlag { get => _AssignedSupportFlag; set => SetProperty(ref _AssignedSupportFlag, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentPersonalNeedsProfile model)
        {
            IsBusy = true;
            Id = model.Id;
            ActivateByDefault = model.ActivateByDefault;
            AssessmentNeedType = model.AssessmentNeedType;
            AssignedSupportFlag = model.AssignedSupportFlag;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
