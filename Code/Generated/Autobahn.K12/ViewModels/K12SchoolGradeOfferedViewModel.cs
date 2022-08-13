//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolGradeOfferedViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12SchoolGradeOfferedViewModel
     /// </summary>
    public partial class K12SchoolGradeOfferedViewModel : ViewModelBase, Interfaces.IK12SchoolGradeOffered
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12SchoolGradeOffered";

        // member variable for the K12SchoolId property
        private Guid _K12SchoolId;

        // member variable for the RefGradeLevelId property
        private Guid _RefGradeLevelId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the K12SchoolGradeOfferedViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="K12School"/> model
        /// </summary>
        public Guid K12SchoolId { get => _K12SchoolId; set => SetProperty(ref _K12SchoolId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradeLevel"/> model
        /// </summary>
        public Guid RefGradeLevelId { get => _RefGradeLevelId; set => SetProperty(ref _RefGradeLevelId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12SchoolGradeOffered model)
        {
            IsBusy = true;
            Id = model.Id;
            K12SchoolId = model.K12SchoolId;
            RefGradeLevelId = model.RefGradeLevelId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
