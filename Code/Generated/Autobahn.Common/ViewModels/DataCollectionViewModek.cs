//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   DataCollectionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The DataCollectionViewModel
     /// </summary>
    public partial class DataCollectionViewModel : BindableBase, IDataCollection
    {
#region "Backing Fields"
        // member variable for the DataCollectionAcademicSchoolYear property
        private System.String _DataCollectionAcademicSchoolYear;

        // member variable for the DataCollectionCloseDate property
        private System.DateTime? _DataCollectionCloseDate;

        // member variable for the DataCollectionDescription property
        private System.String _DataCollectionDescription;

        // member variable for the DataCollectionName property
        private System.String _DataCollectionName;

        // member variable for the DataCollectionSchoolYear property
        private System.String _DataCollectionSchoolYear;

        // member variable for the SourceSystemDataCollectionIdentifier property
        private System.String _SourceSystemDataCollectionIdentifier;

        // member variable for the SourceSystemName property
        private System.String _SourceSystemName;

        // member variable for the DataCollectionOpenDate property
        private System.DateTime? _DataCollectionOpenDate;

#endregion

#region Properties
        public System.String DataCollectionAcademicSchoolYear  { get => _DataCollectionAcademicSchoolYear; set => SetProperty(ref _DataCollectionAcademicSchoolYear, value); }

        public System.DateTime? DataCollectionCloseDate { get => _DataCollectionCloseDate; set => SetProperty(ref _DataCollectionCloseDate, value); }

        public System.String DataCollectionDescription  { get => _DataCollectionDescription; set => SetProperty(ref _DataCollectionDescription, value); }

        public System.String DataCollectionName  { get => _DataCollectionName; set => SetProperty(ref _DataCollectionName, value); }

        public System.String DataCollectionSchoolYear  { get => _DataCollectionSchoolYear; set => SetProperty(ref _DataCollectionSchoolYear, value); }

        public System.String SourceSystemDataCollectionIdentifier  { get => _SourceSystemDataCollectionIdentifier; set => SetProperty(ref _SourceSystemDataCollectionIdentifier, value); }

        public System.String SourceSystemName  { get => _SourceSystemName; set => SetProperty(ref _SourceSystemName, value); }

        public System.DateTime? DataCollectionOpenDate { get => _DataCollectionOpenDate; set => SetProperty(ref _DataCollectionOpenDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefDataCollectionStatusId"/> model
        /// </summary>
        public Guid? RefDataCollectionStatusId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IDataCollection model)
        {
            IsBusy = true;
            Id = model.Id;
            DataCollectionAcademicSchoolYear = model.DataCollectionAcademicSchoolYear;
            DataCollectionCloseDate = model.DataCollectionCloseDate;
            DataCollectionDescription = model.DataCollectionDescription;
            DataCollectionName = model.DataCollectionName;
            DataCollectionSchoolYear = model.DataCollectionSchoolYear;
            SourceSystemDataCollectionIdentifier = model.SourceSystemDataCollectionIdentifier;
            SourceSystemName = model.SourceSystemName;
            DataCollectionOpenDate = model.DataCollectionOpenDate;
            RefDataCollectionStatusId = model.RefDataCollectionStatusId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
