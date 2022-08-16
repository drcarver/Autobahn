//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   DataCollectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The DataCollectionViewModel
     /// </summary>
    public partial class DataCollectionViewModel : ViewModelBase, Interfaces.IDataCollection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from DataCollection";

        // member variable for the DataCollectionAcademicSchoolYear property
        private Guid? _DataCollectionAcademicSchoolYear;

        // member variable for the DataCollectionCloseDate property
        private  _DataCollectionCloseDate;

        // member variable for the DataCollectionDescription property
        private  _DataCollectionDescription;

        // member variable for the DataCollectionName property
        private  _DataCollectionName;

        // member variable for the DataCollectionOpenDate property
        private  _DataCollectionOpenDate;

        // member variable for the DataCollectionSchoolYear property
        private  _DataCollectionSchoolYear;

        // member variable for the RefDataCollectionStatusId property
        private  _RefDataCollectionStatusId;

        // member variable for the SourceSystemDataCollectionIdentifier property
        private  _SourceSystemDataCollectionIdentifier;

        // member variable for the SourceSystemName property
        private  _SourceSystemName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? DataCollectionAcademicSchoolYear { get => _DataCollectionAcademicSchoolYear; set => SetProperty(ref _DataCollectionAcademicSchoolYear, value); }

        /// <summary>
        /// </summary>
        public  DataCollectionCloseDate { get => _DataCollectionCloseDate; set => SetProperty(ref _DataCollectionCloseDate, value); }

        /// <summary>
        /// </summary>
        public  DataCollectionDescription { get => _DataCollectionDescription; set => SetProperty(ref _DataCollectionDescription, value); }

        /// <summary>
        /// </summary>
        public  DataCollectionName { get => _DataCollectionName; set => SetProperty(ref _DataCollectionName, value); }

        /// <summary>
        /// </summary>
        public  DataCollectionOpenDate { get => _DataCollectionOpenDate; set => SetProperty(ref _DataCollectionOpenDate, value); }

        /// <summary>
        /// </summary>
        public  DataCollectionSchoolYear { get => _DataCollectionSchoolYear; set => SetProperty(ref _DataCollectionSchoolYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDataCollectionStatus"/> model
        /// </summary>
        public  RefDataCollectionStatusId { get => _RefDataCollectionStatusId; set => SetProperty(ref _RefDataCollectionStatusId, value); }

        /// <summary>
        /// </summary>
        public  SourceSystemDataCollectionIdentifier { get => _SourceSystemDataCollectionIdentifier; set => SetProperty(ref _SourceSystemDataCollectionIdentifier, value); }

        /// <summary>
        /// </summary>
        public  SourceSystemName { get => _SourceSystemName; set => SetProperty(ref _SourceSystemName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IDataCollection model)
        {
            IsBusy = true;
            Id = model.Id;
            DataCollectionAcademicSchoolYear = model.DataCollectionAcademicSchoolYear; // 
            DataCollectionCloseDate = model.DataCollectionCloseDate; // 
            DataCollectionDescription = model.DataCollectionDescription; // 
            DataCollectionName = model.DataCollectionName; // 
            DataCollectionOpenDate = model.DataCollectionOpenDate; // 
            DataCollectionSchoolYear = model.DataCollectionSchoolYear; // 
            RefDataCollectionStatusId = model.RefDataCollectionStatusId; // 
            SourceSystemDataCollectionIdentifier = model.SourceSystemDataCollectionIdentifier; // 
            SourceSystemName = model.SourceSystemName; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
