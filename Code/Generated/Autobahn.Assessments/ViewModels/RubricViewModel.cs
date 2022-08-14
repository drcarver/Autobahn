//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessments.ViewModels
{
     /// <summary>
     /// The RubricViewModel
     /// </summary>
    public partial class RubricViewModel : ViewModelBase, Interfaces.IRubric
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Rubric";

        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the Title property
        private System.String _Title;

        // member variable for the UrlReference property
        private System.String _UrlReference;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the RubricViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The title of the rubric.
        /// </summary>
        public System.String Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// The title of the rubric.
        /// </summary>
        public System.String Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// The title of the rubric.
        /// </summary>
        public System.String UrlReference { get => _UrlReference; set => SetProperty(ref _UrlReference, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubric model)
        {
            IsBusy = true;
            Id = model.Id;
            Identifier = model.Identifier;
            Title = model.Title;
            UrlReference = model.UrlReference;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
