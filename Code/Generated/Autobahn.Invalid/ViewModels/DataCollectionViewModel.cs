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
        private System.String _DataCollectionAcademicSchoolYear;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the DataCollectionViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year for a reported school session for which the data is applicable.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20920">Data Collection Academic School Year</a>
        /// </para>
        /// </summary>
        [DisplayName("Data Collection Academic School Year")]
        public System.String DataCollectionAcademicSchoolYear { get => _DataCollectionAcademicSchoolYear; set => SetProperty(ref _DataCollectionAcademicSchoolYear, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IDataCollection model)
        {
            IsBusy = true;
            Id = model.Id;
            DataCollectionAcademicSchoolYear = model.DataCollectionAcademicSchoolYear; // Data Collection Academic School Year
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
