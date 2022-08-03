//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   TeacherStudentDataLinkExclusionViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Common.Interfaces;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The TeacherStudentDataLinkExclusionViewModel
     /// </summary>
    public partial class TeacherStudentDataLinkExclusionViewModel : BindableBase, ITeacherStudentDataLinkExclusion
    {
#region "Backing Fields"
        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="K12StudentCourseSectionId"/> model
        /// </summary>
        public Guid K12StudentCourseSectionId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12StaffAssignmentId"/> model
        /// </summary>
        public Guid K12StaffAssignmentId { get; set; }

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
        public void Load(ITeacherStudentDataLinkExclusion model)
        {
            IsBusy = true;
            Id = model.Id;
            K12StudentCourseSectionId = model.K12StudentCourseSectionId;
            K12StaffAssignmentId = model.K12StaffAssignmentId;
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
