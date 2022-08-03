//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   PersonMilitaryViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The PersonMilitaryViewModel
     /// </summary>
    public partial class PersonMilitaryViewModel : BindableBase, IPersonMilitary
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PersonId"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryActiveStudentIndicatorId"/> model
        /// </summary>
        public Guid? RefMilitaryActiveStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryConnectedStudentIndicatorId"/> model
        /// </summary>
        public Guid? RefMilitaryConnectedStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryVeteranStudentIndicatorId"/> model
        /// </summary>
        public Guid? RefMilitaryVeteranStudentIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefMilitaryBranchId"/> model
        /// </summary>
        public Guid? RefMilitaryBranchId { get; set; }

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
        public void Load(IPersonMilitary model)
        {
            IsBusy = true;
            Id = model.Id;
            PersonId = model.PersonId;
            RefMilitaryActiveStudentIndicatorId = model.RefMilitaryActiveStudentIndicatorId;
            RefMilitaryConnectedStudentIndicatorId = model.RefMilitaryConnectedStudentIndicatorId;
            RefMilitaryVeteranStudentIndicatorId = model.RefMilitaryVeteranStudentIndicatorId;
            RefMilitaryBranchId = model.RefMilitaryBranchId;
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
