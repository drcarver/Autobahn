//**********************************************************
//* DomainName: Common Models
//* FileName:   DataCollectionViewModel.cs
//* Name:       Data Collection Academic School Year
//* Definition: The year for a reported school session for which the data is applicable.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The year for a reported school session for which the data is applicable.
     /// </summary>
    public partial class DataCollectionViewModel : ViewModelBase, Interfaces.IDataCollection
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from DataCollection";

        // DataCollectionAcademicSchoolYear -- (backing property for Data Collection Academic School Year)
        private System.String _DataCollectionAcademicSchoolYear;

        // DataCollectionCloseDate -- (backing property for Data Collection Close Date)
        private System.DateTime? _DataCollectionCloseDate;

        // DataCollectionDescription -- (backing property for Data Collection Description)
        private System.String _DataCollectionDescription;

        // DataCollectionName -- (backing property for Data Collection Name)
        private System.String _DataCollectionName;

        // DataCollectionOpenDate -- (backing property for Data Collection Open Date)
        private System.DateTime? _DataCollectionOpenDate;

        // DataCollectionSchoolYear -- (backing property for Data Collection School Year)
        private System.String _DataCollectionSchoolYear;

        // RefDataCollectionStatusId -- (backing property for Data Collection Status)
        private Guid? _RefDataCollectionStatusId;

        // SourceSystemDataCollectionIdentifier -- (backing property for Source System Data Collection Identifier)
        private System.String _SourceSystemDataCollectionIdentifier;

        // SourceSystemName -- (backing property for Source System Name)
        private System.String _SourceSystemName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Data Collection Academic School Year
        /// <para>
        /// The year for a reported school session for which the data is applicable.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20920">Data Collection Academic School Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DataCollectionAcademicSchoolYear { get => _DataCollectionAcademicSchoolYear; set => SetProperty(ref _DataCollectionAcademicSchoolYear, value); }

        /// <summary>
        /// Data Collection Close Date
        /// <para>
        /// The date the data collection closes or ends.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20921">Data Collection Close Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DataCollectionCloseDate { get => _DataCollectionCloseDate; set => SetProperty(ref _DataCollectionCloseDate, value); }

        /// <summary>
        /// Data Collection Description
        /// <para>
        /// The description of what is included in the data within the context of the data collection based on the source system and collection period as defined by the Data Collection Open Date and Data Collection Close Date.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20922">Data Collection Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DataCollectionDescription { get => _DataCollectionDescription; set => SetProperty(ref _DataCollectionDescription, value); }

        /// <summary>
        /// Data Collection Name
        /// <para>
        /// A human readable name used to identify the data within the collection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20923">Data Collection Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DataCollectionName { get => _DataCollectionName; set => SetProperty(ref _DataCollectionName, value); }

        /// <summary>
        /// Data Collection Open Date
        /// <para>
        /// The date the data collection opens or commences.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20924">Data Collection Open Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? DataCollectionOpenDate { get => _DataCollectionOpenDate; set => SetProperty(ref _DataCollectionOpenDate, value); }

        /// <summary>
        /// Data Collection School Year
        /// <para>
        /// The year for a reported school session in which the data collection occurs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20925">Data Collection School Year</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String DataCollectionSchoolYear { get => _DataCollectionSchoolYear; set => SetProperty(ref _DataCollectionSchoolYear, value); }

        /// <summary>
        /// Data Collection Status
        /// <para>
        /// A process indicator of the level of stability, quality, and/or preparedness of the collection of data.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20926">Data Collection Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDataCollectionStatusId { get => _RefDataCollectionStatusId; set => SetProperty(ref _RefDataCollectionStatusId, value); }

        /// <summary>
        /// Source System Data Collection Identifier
        /// <para>
        /// The identifier specified by the source system that uniquely identifies the data collection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20960">Source System Data Collection Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String SourceSystemDataCollectionIdentifier { get => _SourceSystemDataCollectionIdentifier; set => SetProperty(ref _SourceSystemDataCollectionIdentifier, value); }

        /// <summary>
        /// Source System Name
        /// <para>
        /// The name of the source system that provided the data within the collection.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20961">Source System Name</a>
        /// </para>
        /// </summary>
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
            DataCollectionAcademicSchoolYear = model.DataCollectionAcademicSchoolYear; // Data Collection Academic School Year
            DataCollectionCloseDate = model.DataCollectionCloseDate; // Data Collection Close Date
            DataCollectionDescription = model.DataCollectionDescription; // Data Collection Description
            DataCollectionName = model.DataCollectionName; // Data Collection Name
            DataCollectionOpenDate = model.DataCollectionOpenDate; // Data Collection Open Date
            DataCollectionSchoolYear = model.DataCollectionSchoolYear; // Data Collection School Year
            RefDataCollectionStatusId = model.RefDataCollectionStatusId; // Data Collection Status
            SourceSystemDataCollectionIdentifier = model.SourceSystemDataCollectionIdentifier; // Source System Data Collection Identifier
            SourceSystemName = model.SourceSystemName; // Source System Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
