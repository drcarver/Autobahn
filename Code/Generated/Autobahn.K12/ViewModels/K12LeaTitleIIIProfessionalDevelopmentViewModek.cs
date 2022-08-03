//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   K12LeaTitleIIIProfessionalDevelopmentViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.K12.Interfaces;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12LeaTitleIIIProfessionalDevelopmentViewModel
     /// </summary>
    public partial class K12LeaTitleIIIProfessionalDevelopmentViewModel : BindableBase, IK12LeaTitleIIIProfessionalDevelopment
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEATitleIIIProfessionalDevelopmentId"/> model
        /// </summary>
        public Guid K12LEATitleIIIProfessionalDevelopmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12LeaId"/> model
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIIProfessionalDevelopmentTypeId"/> model
        /// </summary>
        public Guid RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

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
        public void Load(IK12LeaTitleIIIProfessionalDevelopment model)
        {
            IsBusy = true;
            Id = model.Id;
            K12LEATitleIIIProfessionalDevelopmentId = model.K12LEATitleIIIProfessionalDevelopmentId;
            K12LeaId = model.K12LeaId;
            RefTitleIIIProfessionalDevelopmentTypeId = model.RefTitleIIIProfessionalDevelopmentTypeId;
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
