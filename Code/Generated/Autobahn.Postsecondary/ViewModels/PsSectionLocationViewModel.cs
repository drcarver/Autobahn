//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsSectionLocationViewModel.cs
//* Name:       Course Instruction Site Name
//* Definition: The name of the location at which the course is taught.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The name of the location at which the course is taught.
     /// </summary>
    public partial class PsSectionLocationViewModel : ViewModelBase, Interfaces.IPsSectionLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsSectionLocation";

        // CourseInstructionSiteName -- (backing property for Course Instruction Site Name)
        private System.String _CourseInstructionSiteName;

        // member variable for the PsSectionId property
        private Guid _PsSectionId;

        // RefCourseInstructionSiteTypeId -- (backing property for Course Instruction Site Type)
        private Guid? _RefCourseInstructionSiteTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Course Instruction Site Name
        /// <para>
        /// The name of the location at which the course is taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20275">Course Instruction Site Name</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String CourseInstructionSiteName { get => _CourseInstructionSiteName; set => SetProperty(ref _CourseInstructionSiteName, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPsSection"/> model
        /// </summary>
        public Guid PsSectionId { get => _PsSectionId; set => SetProperty(ref _PsSectionId, value); }

        /// <summary>
        /// Course Instruction Site Type
        /// <para>
        /// An indication of the type of location at which the course is taught.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20276">Course Instruction Site Type</a>
        /// </para>
        /// </summary>
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
            CourseInstructionSiteName = model.CourseInstructionSiteName; // Course Instruction Site Name
            PsSectionId = model.PsSectionId; // 
            RefCourseInstructionSiteTypeId = model.RefCourseInstructionSiteTypeId; // Course Instruction Site Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
