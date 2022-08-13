//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   DataCollectionViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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
        private System.String _DataCollectionAcademicSchoolYear;

        // member variable for the DataCollectionCloseDate property
        private System.DateTime? _DataCollectionCloseDate;

        // member variable for the DataCollectionDescription property
        private System.String _DataCollectionDescription;

        // member variable for the DataCollectionName property
        private System.String _DataCollectionName;

        // member variable for the DataCollectionOpenDate property
        private System.DateTime? _DataCollectionOpenDate;

        // member variable for the DataCollectionSchoolYear property
        private System.String _DataCollectionSchoolYear;

        // member variable for the RefDataCollectionStatusId property
        private Guid? _RefDataCollectionStatusId;

        // member variable for the SourceSystemDataCollectionIdentifier property
        private System.String _SourceSystemDataCollectionIdentifier;

        // member variable for the SourceSystemName property
        private System.String _SourceSystemName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the DataCollectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionAcademicSchoolYear { get => _DataCollectionAcademicSchoolYear; set => SetProperty(ref _DataCollectionAcademicSchoolYear, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.DateTime? DataCollectionCloseDate { get => _DataCollectionCloseDate; set => SetProperty(ref _DataCollectionCloseDate, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionDescription { get => _DataCollectionDescription; set => SetProperty(ref _DataCollectionDescription, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionName { get => _DataCollectionName; set => SetProperty(ref _DataCollectionName, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.DateTime? DataCollectionOpenDate { get => _DataCollectionOpenDate; set => SetProperty(ref _DataCollectionOpenDate, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String DataCollectionSchoolYear { get => _DataCollectionSchoolYear; set => SetProperty(ref _DataCollectionSchoolYear, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDataCollectionStatus"/> model
        /// </summary>
        public Guid? RefDataCollectionStatusId { get => _RefDataCollectionStatusId; set => SetProperty(ref _RefDataCollectionStatusId, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String SourceSystemDataCollectionIdentifier { get => _SourceSystemDataCollectionIdentifier; set => SetProperty(ref _SourceSystemDataCollectionIdentifier, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// </summary>
        public System.String SourceSystemName { get => _SourceSystemName; set => SetProperty(ref _SourceSystemName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IDataCollection model)
        {
            IsBusy = true;
            Id = model.Id;
            DataCollectionAcademicSchoolYear = model.DataCollectionAcademicSchoolYear;
            DataCollectionCloseDate = model.DataCollectionCloseDate;
            DataCollectionDescription = model.DataCollectionDescription;
            DataCollectionName = model.DataCollectionName;
            DataCollectionOpenDate = model.DataCollectionOpenDate;
            DataCollectionSchoolYear = model.DataCollectionSchoolYear;
            RefDataCollectionStatusId = model.RefDataCollectionStatusId;
            SourceSystemDataCollectionIdentifier = model.SourceSystemDataCollectionIdentifier;
            SourceSystemName = model.SourceSystemName;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
