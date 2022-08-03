//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsSectionLocationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsSectionLocationViewModel
     /// </summary>
    public partial class PsSectionLocationViewModel : BindableBase, IPsSectionLocation
    {
#region "Backing Fields"
        // member variable for the CourseInstructionSiteName property
        private System.String _CourseInstructionSiteName;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="PsSectionId"/> model
        /// </summary>
        public Guid PsSectionId { get; set; }

        public System.String CourseInstructionSiteName  { get => _CourseInstructionSiteName; set => SetProperty(ref _CourseInstructionSiteName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionSiteTypeId"/> model
        /// </summary>
        public Guid? RefCourseInstructionSiteTypeId { get; set; }

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
        public void Load(IPsSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            PsSectionId = model.PsSectionId;
            CourseInstructionSiteName = model.CourseInstructionSiteName;
            RefCourseInstructionSiteTypeId = model.RefCourseInstructionSiteTypeId;
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
