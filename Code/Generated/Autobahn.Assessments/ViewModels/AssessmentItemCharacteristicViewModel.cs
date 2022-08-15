//**********************************************************
//* DomainName: Assessments
//* FileName:   AssessmentItemCharacteristicViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The AssessmentItemCharacteristicViewModel
     /// </summary>
    public partial class AssessmentItemCharacteristicViewModel : ViewModelBase, Interfaces.IAssessmentItemCharacteristic
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AssessmentItemCharacteristic";

        // member variable for the RefAssessmentItemCharacteristicTypeId property
        private Guid? _RefAssessmentItemCharacteristicTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the AssessmentItemCharacteristicViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAssessmentItemCharacteristicType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19384">Assessment Item Characteristic Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Assessment Item Characteristic Type")]
        public Guid? RefAssessmentItemCharacteristicTypeId { get => _RefAssessmentItemCharacteristicTypeId; set => SetProperty(ref _RefAssessmentItemCharacteristicTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAssessmentItemCharacteristic model)
        {
            IsBusy = true;
            Id = model.Id;
            RefAssessmentItemCharacteristicTypeId = model.RefAssessmentItemCharacteristicTypeId; // Assessment Item Characteristic Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
