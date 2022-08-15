//**********************************************************
//* DomainName: Assessments
//* FileName:   LearnerActivityLearningResourceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The LearnerActivityLearningResourceViewModel
     /// </summary>
    public partial class LearnerActivityLearningResourceViewModel : ViewModelBase, Interfaces.ILearnerActivityLearningResource
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerActivityLearningResource";

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearnerActivityLearningResourceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerActivityLearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
