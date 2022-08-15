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
        private System.String _CourseInstructionSiteName;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsSectionLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The name of the location at which the course is taught.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20275">Course Instruction Site Name</a>
        /// </para>
        /// </summary>
        [DisplayName("Course Instruction Site Name")]
        public System.String CourseInstructionSiteName { get => _CourseInstructionSiteName; set => SetProperty(ref _CourseInstructionSiteName, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseInstructionSiteName = model.CourseInstructionSiteName; // Course Instruction Site Name
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
