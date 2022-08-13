//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   AssessmentFormSection_AssessmentItemViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The AssessmentFormSection_AssessmentItemViewModel
     /// </summary>
    public partial class AssessmentFormSection_AssessmentItemViewModel : ViewModelBase, Interfaces.IAssessmentFormSection_AssessmentItem
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentFormSection_AssessmentItem";

        // member variable for the AssessmentFormSectionId property
        private Guid _AssessmentFormSectionId;

        // member variable for the AssessmentFormSectionItemId property
        private Guid _AssessmentFormSectionItemId;

        // member variable for the AssessmentItemId property
        private Guid _AssessmentItemId;

        // member variable for the SequenceNumber property
        private System.Int32 _SequenceNumber;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentFormSection_AssessmentItemViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSection"/> model
        /// </summary>
        public Guid AssessmentFormSectionId { get => _AssessmentFormSectionId; set => SetProperty(ref _AssessmentFormSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentFormSectionItem"/> model
        /// </summary>
        public Guid AssessmentFormSectionItemId { get => _AssessmentFormSectionItemId; set => SetProperty(ref _AssessmentFormSectionItemId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="AssessmentItem"/> model
        /// </summary>
        public Guid AssessmentItemId { get => _AssessmentItemId; set => SetProperty(ref _AssessmentItemId, value); }

        /// <summary>
        /// The position of the assessment section presented in the sequence of sections within an assessment form.
        /// </summary>
        public System.Int32 SequenceNumber { get => _SequenceNumber; set => SetProperty(ref _SequenceNumber, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentFormSection_AssessmentItem model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentFormSectionId = model.AssessmentFormSectionId;
            AssessmentFormSectionItemId = model.AssessmentFormSectionItemId;
            AssessmentItemId = model.AssessmentItemId;
            SequenceNumber = model.SequenceNumber;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
