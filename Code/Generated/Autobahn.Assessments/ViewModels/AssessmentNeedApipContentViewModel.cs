//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentNeedApipContentViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentNeedApipContentViewModel
     /// </summary>
    public partial class AssessmentNeedApipContentViewModel : ViewModelBase, Interfaces.IAssessmentNeedApipContent
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentNeedApipContent";

        // member variable for the ItemTranslationDisplayLanguageTypeId property
        private Guid? _ItemTranslationDisplayLanguageTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentNeedApipContentViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ItemTranslationDisplayLanguageType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20042">Assessment Need Item Translation Display Language Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Need Item Translation Display Language Type")]
        public Guid? ItemTranslationDisplayLanguageTypeId { get => _ItemTranslationDisplayLanguageTypeId; set => SetProperty(ref _ItemTranslationDisplayLanguageTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentNeedApipContent model)
        {
            IsBusy = true;
            Id = model.Id;
            ItemTranslationDisplayLanguageTypeId = model.ItemTranslationDisplayLanguageTypeId; // Assessment Need Item Translation Display Language Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region "ICommands for Navigation Properties"
        /// <summary>
        /// Defines as part of an Assessment Personal Needs Profile the default language for the displayed translation.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20042">Assessment Need Item Translation Display Language Type</a>
        /// </para>
        /// </summary>
        public ICommand ItemTranslationDisplayLanguageTypeCommand { get; set; }

        #endregion
    }
}
