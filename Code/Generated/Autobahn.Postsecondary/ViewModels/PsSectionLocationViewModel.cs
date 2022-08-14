//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsSectionLocationViewModel
     /// </summary>
    public partial class PsSectionLocationViewModel : ViewModelBase, Interfaces.IPsSectionLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsSectionLocation";

        // member variable for the CourseInstructionSiteName property
        private System.String _CourseInstructionSiteName;

        // member variable for the PsSectionId property
        private Guid _PsSectionId;

        // member variable for the RefCourseInstructionSiteTypeId property
        private Guid? _RefCourseInstructionSiteTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsSectionLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of the location at which the course is taught.
        /// </summary>
        public System.String CourseInstructionSiteName { get => _CourseInstructionSiteName; set => SetProperty(ref _CourseInstructionSiteName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="PsSection"/> model
        /// </summary>
        public Guid PsSectionId { get => _PsSectionId; set => SetProperty(ref _PsSectionId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionSiteType"/> model
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
            CourseInstructionSiteName = model.CourseInstructionSiteName;
            PsSectionId = model.PsSectionId;
            RefCourseInstructionSiteTypeId = model.RefCourseInstructionSiteTypeId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
