//**********************************************************
//* DomainName: Autobahn.Facilities
//* FileName:   FacilitySchoolDesignViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Facilities.Interfaces;

namespace Autobahn.Facilities.ViewModels
{
     /// <summary>
     /// The FacilitySchoolDesignViewModel
     /// </summary>
    public partial class FacilitySchoolDesignViewModel : BindableBase, IFacilitySchoolDesign
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="FacilityDesignId"/> model
        /// </summary>
        public Guid FacilityDesignId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefBuildingSchoolDesignTypeId"/> model
        /// </summary>
        public Guid RefBuildingSchoolDesignTypeId { get; set; }

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
        public void Load(IFacilitySchoolDesign model)
        {
            IsBusy = true;
            Id = model.Id;
            FacilityDesignId = model.FacilityDesignId;
            RefBuildingSchoolDesignTypeId = model.RefBuildingSchoolDesignTypeId;
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
