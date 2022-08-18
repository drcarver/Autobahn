//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   AeCourseViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.AdultEducation.ViewModels
{
     /// <summary>
     /// The AeCourse View Model
     /// </summary>
    public partial class AeCourseViewModel : ViewModelBase, Interfaces.IAeCourse
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from AeCourse";

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // RefCareerClusterId -- (backing property for Career Cluster)
        private Guid? _RefCareerClusterId;

        // RefCourseLevelTypeId -- (backing property for Course Level Type)
        private Guid? _RefCourseLevelTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Career Cluster
        /// <para>
        /// The career cluster that defines the industry or occupational focus which may be associated with a career pathways program, plan of study, or course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20254">Career Cluster</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCareerClusterId { get => _RefCareerClusterId; set => SetProperty(ref _RefCareerClusterId, value); }

        /// <summary>
        /// Course Level Type
        /// <para>
        /// The level of work which is reflected in the credits associated with the academic course being described or the level of the typical individual taking the academic course.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20278">Course Level Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCourseLevelTypeId { get => _RefCourseLevelTypeId; set => SetProperty(ref _RefCourseLevelTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IAeCourse model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationId = model.OrganizationId; // 
            RefCareerClusterId = model.RefCareerClusterId; // Career Cluster
            RefCourseLevelTypeId = model.RefCourseLevelTypeId; // Course Level Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
