//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   LearningResourceEducationLevelViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
{
     /// <summary>
     /// The LearningResourceEducationLevelViewModel
     /// </summary>
    public partial class LearningResourceEducationLevelViewModel : ViewModelBase, Interfaces.ILearningResourceEducationLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceEducationLevel";

        // member variable for the LearningResourceId property
        private Guid _LearningResourceId;

        // member variable for the RefEducationLevelId property
        private Guid _RefEducationLevelId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourceEducationLevelViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="LearningResource"/> model
        /// </summary>
        public Guid LearningResourceId { get => _LearningResourceId; set => SetProperty(ref _LearningResourceId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEducationLevel"/> model
        /// </summary>
        public Guid RefEducationLevelId { get => _RefEducationLevelId; set => SetProperty(ref _RefEducationLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceEducationLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            LearningResourceId = model.LearningResourceId;
            RefEducationLevelId = model.RefEducationLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
