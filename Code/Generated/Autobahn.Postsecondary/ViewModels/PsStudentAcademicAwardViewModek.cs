//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentAcademicAwardViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAcademicAwardViewModel
     /// </summary>
    public partial class PsStudentAcademicAwardViewModel : BindableBase, IPsStudentAcademicAward
    {
#region "Backing Fields"
        // member variable for the AcademicAwardDate property
        private System.String _AcademicAwardDate;

        // member variable for the AcademicAwardTitle property
        private System.String _AcademicAwardTitle;

        // member variable for the RequirementsURL property
        private System.String _RequirementsURL;

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

        public System.String AcademicAwardDate  { get => _AcademicAwardDate; set => SetProperty(ref _AcademicAwardDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardLevelId"/> model
        /// </summary>
        public Guid? RefAcademicAwardLevelId { get; set; }

        public System.String AcademicAwardTitle  { get => _AcademicAwardTitle; set => SetProperty(ref _AcademicAwardTitle, value); }

        public System.String RequirementsURL  { get => _RequirementsURL; set => SetProperty(ref _RequirementsURL, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardPrerequisiteTypeId"/> model
        /// </summary>
        public Guid? RefAcademicAwardPrerequisiteTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPESCAwardLevelTypeId"/> model
        /// </summary>
        public Guid? RefPESCAwardLevelTypeId { get; set; }

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
        public void Load(IPsStudentAcademicAward model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            AcademicAwardDate = model.AcademicAwardDate;
            RefAcademicAwardLevelId = model.RefAcademicAwardLevelId;
            AcademicAwardTitle = model.AcademicAwardTitle;
            RequirementsURL = model.RequirementsURL;
            RefAcademicAwardPrerequisiteTypeId = model.RefAcademicAwardPrerequisiteTypeId;
            RefPESCAwardLevelTypeId = model.RefPESCAwardLevelTypeId;
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
