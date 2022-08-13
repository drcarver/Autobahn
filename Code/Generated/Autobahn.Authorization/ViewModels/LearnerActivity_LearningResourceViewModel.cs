//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearnerActivity_LearningResourceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The LearnerActivity_LearningResourceViewModel
     /// </summary>
    public partial class LearnerActivity_LearningResourceViewModel : ViewModelBase, Interfaces.ILearnerActivity_LearningResource
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearnerActivity_LearningResource";

        // member variable for the LearnerActivityId property
        private Guid _LearnerActivityId;

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearnerActivity_LearningResourceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearnerActivity"/> model
        /// </summary>
        public Guid LearnerActivityId { get => _LearnerActivityId; set => SetProperty(ref _LearnerActivityId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearnerActivity_LearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            LearnerActivityId = model.LearnerActivityId;
            LearningResourceId = model.LearningResourceId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
