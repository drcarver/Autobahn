//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   AssessmentLanguageViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The AssessmentLanguageViewModel
     /// </summary>
    public partial class AssessmentLanguageViewModel : ViewModelBase, Interfaces.IAssessmentLanguage
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentLanguage";

        // member variable for the AssessmentId property
        private Guid _AssessmentId;

        // member variable for the RefLanguageId property
        private Guid _RefLanguageId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentLanguageViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="AssessmentId"/> model
        /// </summary>
        public Guid AssessmentId { get => _AssessmentId; set => SetProperty(ref _AssessmentId, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefLanguageId"/> model
        /// </summary>
        public Guid RefLanguageId { get => _RefLanguageId; set => SetProperty(ref _RefLanguageId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentLanguage model)
        {
            IsBusy = true;
            Id = model.Id;
            AssessmentId = model.AssessmentId;
            RefLanguageId = model.RefLanguageId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
