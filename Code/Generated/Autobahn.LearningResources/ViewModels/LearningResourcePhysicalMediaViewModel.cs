//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourcePhysicalMediaViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourcePhysicalMediaViewModel
     /// </summary>
    public partial class LearningResourcePhysicalMediaViewModel : ViewModelBase, Interfaces.ILearningResourcePhysicalMedia
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourcePhysicalMedia";

        // member variable for the RefLearningResourcePhysicalMediaTypeId property
        private Guid _RefLearningResourcePhysicalMediaTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourcePhysicalMediaViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourcePhysicalMediaType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20370">Learning Resource Physical Media Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Learning Resource Physical Media Type")]
        public Guid RefLearningResourcePhysicalMediaTypeId { get => _RefLearningResourcePhysicalMediaTypeId; set => SetProperty(ref _RefLearningResourcePhysicalMediaTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourcePhysicalMedia model)
        {
            IsBusy = true;
            Id = model.Id;
            RefLearningResourcePhysicalMediaTypeId = model.RefLearningResourcePhysicalMediaTypeId; // Learning Resource Physical Media Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
