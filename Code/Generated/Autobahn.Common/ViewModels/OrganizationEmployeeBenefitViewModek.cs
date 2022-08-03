//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   OrganizationEmployeeBenefitViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The OrganizationEmployeeBenefitViewModel
     /// </summary>
    public partial class OrganizationEmployeeBenefitViewModel : BindableBase, IOrganizationEmployeeBenefit
    {
#region "Backing Fields"
        // member variable for the FullTimeBenefitIndicator property
        private System.Boolean? _FullTimeBenefitIndicator;

        // member variable for the PartTimeBenefitIndicator property
        private System.Boolean? _PartTimeBenefitIndicator;

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

        public System.Boolean? FullTimeBenefitIndicator { get => _FullTimeBenefitIndicator; set => SetProperty(ref _FullTimeBenefitIndicator, value); }

        public System.Boolean? PartTimeBenefitIndicator { get => _PartTimeBenefitIndicator; set => SetProperty(ref _PartTimeBenefitIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmployeeBenefitId"/> model
        /// </summary>
        public Guid? RefEmployeeBenefitId { get; set; }

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
        public void Load(IOrganizationEmployeeBenefit model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            FullTimeBenefitIndicator = model.FullTimeBenefitIndicator;
            PartTimeBenefitIndicator = model.PartTimeBenefitIndicator;
            RefEmployeeBenefitId = model.RefEmployeeBenefitId;
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
