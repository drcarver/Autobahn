//**********************************************************
//* DomainName: Learning Resources
//* FileName:   LearningResourceViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.LearningResources.ViewModels
{
     /// <summary>
     /// The LearningResourceViewModel
     /// </summary>
    public partial class LearningResourceViewModel : ViewModelBase, Interfaces.ILearningResource
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from LearningResource";

        // member variable for the Url property
        private System.String _Url;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the LearningResourceViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The Uniform Resource Locator where the resource may be accessed, or a proxy for the resource, such as an information page for a commercially available resource.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19911">Learning Resource URL</a>
        /// </para>
        /// </summary>
        [DisplayName("Learning Resource URL")]
        public System.String Url { get => _Url; set => SetProperty(ref _Url, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ILearningResource model)
        {
            IsBusy = true;
            Id = model.Id;
            Url = model.Url; // Learning Resource URL
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
