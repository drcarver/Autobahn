//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearnerActivityLearningResourceViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearnerActivityLearningResource View Model
     /// </summary>
    public partial class LearnerActivityLearningResourceViewModel : ViewModelBase, Interfaces.ILearnerActivityLearningResource
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerActivityLearningResource";

        // member variable for the LearnerActivityId property
        private Guid _LearnerActivityId;

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearnerActivity"/> model
        /// </summary>
        public Guid LearnerActivityId { get => _LearnerActivityId; set => SetProperty(ref _LearnerActivityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerActivityLearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            LearnerActivityId = model.LearnerActivityId; // 
            LearningResourceId = model.LearningResourceId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
