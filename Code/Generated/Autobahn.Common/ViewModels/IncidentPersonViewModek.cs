//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IncidentPersonViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The IncidentPersonViewModel
     /// </summary>
    public partial class IncidentPersonViewModel : BindableBase, IIncidentPerson
    {
#region "Backing Fields"
        // member variable for the Identifier property
        private System.String _Identifier;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="IncidentId"/> model
        /// </summary>
        public Guid IncidentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        public System.String Identifier  { get => _Identifier; set => SetProperty(ref _Identifier, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefIncidentPersonRoleTypeId"/> model
        /// </summary>
        public Guid RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIncidentPersonTypeId"/> model
        /// </summary>
        public Guid? RefIncidentPersonTypeId { get; set; }

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
        public void Load(IIncidentPerson model)
        {
            IsBusy = true;
            Id = model.Id;
            IncidentId = model.IncidentId;
            PersonId = model.PersonId;
            Identifier = model.Identifier;
            RefIncidentPersonRoleTypeId = model.RefIncidentPersonRoleTypeId;
            RefIncidentPersonTypeId = model.RefIncidentPersonTypeId;
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
