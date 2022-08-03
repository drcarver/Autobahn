//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAdmissionTestViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAdmissionTestViewModel
     /// </summary>
    public partial class PsStudentAdmissionTestViewModel : BindableBase, IPsStudentAdmissionTest
    {
#region "Backing Fields"
        // member variable for the StandardizedAdmissionTestScore property
        private System.Decimal? _StandardizedAdmissionTestScore;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefStandardizedAdmissionTestId"/> model
        /// </summary>
        public Guid RefStandardizedAdmissionTestId { get; set; }

        public System.Decimal? StandardizedAdmissionTestScore { get => _StandardizedAdmissionTestScore; set => SetProperty(ref _StandardizedAdmissionTestScore, value); }

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
        public void Load(IPsStudentAdmissionTest model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefStandardizedAdmissionTestId = model.RefStandardizedAdmissionTestId;
            StandardizedAdmissionTestScore = model.StandardizedAdmissionTestScore;
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
