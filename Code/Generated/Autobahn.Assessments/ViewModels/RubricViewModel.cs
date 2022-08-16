//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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

        // member variable for the Description property
        private  _Description;

        // member variable for the Identifier property
        private  _Identifier;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the Title property
        private Guid? _Title;

        // member variable for the UrlReference property
        private  _UrlReference;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  Description { get => _Description; set => SetProperty(ref _Description, value); }

        /// <summary>
        /// </summary>
        public  Identifier { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public Guid? Title { get => _Title; set => SetProperty(ref _Title, value); }

        /// <summary>
        /// </summary>
        public  UrlReference { get => _UrlReference; set => SetProperty(ref _UrlReference, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IRubric model)
        {
            IsBusy = true;
            Id = model.Id;
            Description = model.Description; // 
            Identifier = model.Identifier; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            Title = model.Title; // 
            UrlReference = model.UrlReference; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
