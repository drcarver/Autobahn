//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The LearnerActionViewModel
     /// </summary>
    public partial class LearnerActionViewModel : ViewModelBase, Interfaces.ILearnerAction
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerAction";

        // member variable for the RefLearnerActionTypeId property
        private Guid? _RefLearnerActionTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearnerActionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearnerActionType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19935">Learner Action Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Learner Action Type")]
        public Guid? RefLearnerActionTypeId { get => _RefLearnerActionTypeId; set => SetProperty(ref _RefLearnerActionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerAction model)
        {
            IsBusy = true;
            Id = model.Id;
            RefLearnerActionTypeId = model.RefLearnerActionTypeId; // Learner Action Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
