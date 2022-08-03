//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RecordStatusViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The RecordStatusViewModel
     /// </summary>
    public partial class RecordStatusViewModel : BindableBase, IRecordStatus
    {
#region "Backing Fields"
        // member variable for the RecordStatusDate property
        private System.DateTime? _RecordStatusDate;

#endregion

#region Properties
        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorOrganizationId"/> model
        /// </summary>
        public Guid? RecordStatusCreatorOrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusCreatorPersonId"/> model
        /// </summary>
        public Guid? RecordStatusCreatorPersonId { get; set; }

        public System.DateTime? RecordStatusDate { get => _RecordStatusDate; set => SetProperty(ref _RecordStatusDate, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefRecordStatusTypeId"/> model
        /// </summary>
        public Guid RefRecordStatusTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefRecordStatusCreatorEntityId"/> model
        /// </summary>
        public Guid? RefRecordStatusCreatorEntityId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IRecordStatus model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordStatusCreatorOrganizationId = model.RecordStatusCreatorOrganizationId;
            RecordStatusCreatorPersonId = model.RecordStatusCreatorPersonId;
            RecordStatusDate = model.RecordStatusDate;
            RefRecordStatusTypeId = model.RefRecordStatusTypeId;
            RefRecordStatusCreatorEntityId = model.RefRecordStatusCreatorEntityId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
