//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationDetailViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationDetailViewModel
     /// </summary>
    public partial class OrganizationDetailViewModel : BindableBase, IOrganizationDetail
    {
#region "Backing Fields"
        // member variable for the Name property
        private System.String _Name;

        // member variable for the ShortName property
        private System.String _ShortName;

        // member variable for the RegionGeoJSON property
        private System.String _RegionGeoJSON;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationId"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        public System.String Name  { get => _Name; set => SetProperty(ref _Name, value); }

        public System.String ShortName  { get => _ShortName; set => SetProperty(ref _ShortName, value); }

        public System.String RegionGeoJSON  { get => _RegionGeoJSON; set => SetProperty(ref _RegionGeoJSON, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationTypeId"/> model
        /// </summary>
        public Guid? RefOrganizationTypeId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IOrganizationDetail model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            Name = model.Name;
            ShortName = model.ShortName;
            RegionGeoJSON = model.RegionGeoJSON;
            RefOrganizationTypeId = model.RefOrganizationTypeId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
