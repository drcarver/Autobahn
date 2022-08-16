//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationDetailViewModel.cs
//**********************************************************

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationDetailViewModel
     /// </summary>
    public partial class OrganizationDetailViewModel : ViewModelBase, Interfaces.IOrganizationDetail
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from OrganizationDetail";

        // member variable for the Name property
        private Guid? _Name;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RegionGeoJSON property
        private  _RegionGeoJSON;

        // member variable for the ShortName property
        private  _ShortName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? Name { get => _Name; set => SetProperty(ref _Name, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// </summary>
        public  RegionGeoJSON { get => _RegionGeoJSON; set => SetProperty(ref _RegionGeoJSON, value); }

        /// <summary>
        /// </summary>
        public  ShortName { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IOrganizationDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            Name = model.Name; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RegionGeoJSON = model.RegionGeoJSON; // 
            ShortName = model.ShortName; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
