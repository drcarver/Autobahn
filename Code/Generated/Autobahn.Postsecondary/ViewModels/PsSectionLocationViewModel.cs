//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsSectionLocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsSectionLocationViewModel
     /// </summary>
    public partial class PsSectionLocationViewModel : ViewModelBase, Interfaces.IPsSectionLocationViewModel
    {
#region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsSectionLocation";

        // member variable for the PsSectionId property
        private Guid _PsSectionId;

        // member variable for the CourseInstructionSiteName property
        private System.String _CourseInstructionSiteName;

        // member variable for the RefCourseInstructionSiteTypeId property
        private Guid? _RefCourseInstructionSiteTypeId;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

        // member variable for the RecordStatusId property
        private Guid? _RecordStatusId;

        // member variable for the DataCollectionId property
        private Guid? _DataCollectionId;

#endregion

        #region Properties
        /// <summary>
        /// The title of the PsSectionLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to a required instance of the <see cref="PsSectionId"/> model
        /// </summary>
        public Guid PsSectionId { get => _PsSectionId; set => SetProperty(ref _PsSectionId, value); }

        public System.String CourseInstructionSiteName  { get => _CourseInstructionSiteName; set => SetProperty(ref _CourseInstructionSiteName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionSiteTypeId"/> model
        /// </summary>
        public Guid? RefCourseInstructionSiteTypeId { get => _RefCourseInstructionSiteTypeId; set => SetProperty(ref _RefCourseInstructionSiteTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            PsSectionId = model.PsSectionId;
            CourseInstructionSiteName = model.CourseInstructionSiteName;
            RefCourseInstructionSiteTypeId = model.RefCourseInstructionSiteTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
