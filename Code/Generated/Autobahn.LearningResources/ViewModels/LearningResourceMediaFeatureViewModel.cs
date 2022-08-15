//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceMediaFeatureViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceMediaFeatureViewModel
     /// </summary>
    public partial class LearningResourceMediaFeatureViewModel : ViewModelBase, Interfaces.ILearningResourceMediaFeature
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResourceMediaFeature";

        // member variable for the RefLearningResourceMediaFeatureTypeId property
        private Guid _RefLearningResourceMediaFeatureTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourceMediaFeatureViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLearningResourceMediaFeatureType"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20368">Learning Resource Media Feature Type</a>
        /// </para>
        /// </summary>
        [DisplayName("Learning Resource Media Feature Type")]
        public Guid RefLearningResourceMediaFeatureTypeId { get => _RefLearningResourceMediaFeatureTypeId; set => SetProperty(ref _RefLearningResourceMediaFeatureTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResourceMediaFeature model)
        {
            IsBusy = true;
            Id = model.Id;
            RefLearningResourceMediaFeatureTypeId = model.RefLearningResourceMediaFeatureTypeId; // Learning Resource Media Feature Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
