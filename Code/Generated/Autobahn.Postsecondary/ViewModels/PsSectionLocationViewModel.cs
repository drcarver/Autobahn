//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

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
        private Guid? _CourseInstructionSiteName;

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefCourseInstructionSiteTypeId property
        private  _RefCourseInstructionSiteTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public Guid? CourseInstructionSiteName { get => _CourseInstructionSiteName; set => SetProperty(ref _CourseInstructionSiteName, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCourseInstructionSiteType"/> model
        /// </summary>
        public  RefCourseInstructionSiteTypeId { get => _RefCourseInstructionSiteTypeId; set => SetProperty(ref _RefCourseInstructionSiteTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseInstructionSiteName = model.CourseInstructionSiteName; // 
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefCourseInstructionSiteTypeId = model.RefCourseInstructionSiteTypeId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
