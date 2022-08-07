//**********************************************************
//* DomainName: Autobahn.Assessment
//* FileName:   RubricViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Assessment.ViewModels
{
     /// <summary>
     /// The RubricViewModel
     /// </summary>
    public partial class RubricViewModel : ViewModelBase, Interfaces.IRubricViewModel
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

        // member variable for the Description property
        private System.String _Description;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the RubricViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        public System.String Title  { get => _Title; set => SetProperty(ref _Title, value); }

        public System.String UrlReference  { get => _UrlReference; set => SetProperty(ref _UrlReference, value); }

        public System.String Description  { get => _Description; set => SetProperty(ref _Description, value); }

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
            Description = model.Description;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
