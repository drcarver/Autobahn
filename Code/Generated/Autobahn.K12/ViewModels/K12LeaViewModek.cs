//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaViewModel
     /// </summary>
    public partial class K12LeaViewModel : BindableBase, IK12Lea
    {
#region "Backing Fields"
        // member variable for the SupervisoryUnionIdentificationNumber property
        private System.String _SupervisoryUnionIdentificationNumber;

        // member variable for the CharterSchoolIndicator property
        private System.Boolean? _CharterSchoolIndicator;

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

        public System.String SupervisoryUnionIdentificationNumber  { get => _SupervisoryUnionIdentificationNumber; set => SetProperty(ref _SupervisoryUnionIdentificationNumber, value); }

        public System.Boolean? CharterSchoolIndicator { get => _CharterSchoolIndicator; set => SetProperty(ref _CharterSchoolIndicator, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaTypeId"/> model
        /// </summary>
        public Guid? RefLeaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaImprovementStatusId"/> model
        /// </summary>
        public Guid? RefLeaImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatusId"/> model
        /// </summary>
        public Guid? RefPublicSchoolChoiceStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterLeaStatusId"/> model
        /// </summary>
        public Guid? RefCharterLeaStatusId { get; set; }

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
        public void Load(IK12Lea model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId;
            SupervisoryUnionIdentificationNumber = model.SupervisoryUnionIdentificationNumber;
            CharterSchoolIndicator = model.CharterSchoolIndicator;
            RefLeaTypeId = model.RefLeaTypeId;
            RefLeaImprovementStatusId = model.RefLeaImprovementStatusId;
            RefPublicSchoolChoiceStatusId = model.RefPublicSchoolChoiceStatusId;
            RefCharterLeaStatusId = model.RefCharterLeaStatusId;
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
