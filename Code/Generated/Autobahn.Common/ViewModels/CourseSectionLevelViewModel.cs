//**********************************************************
//* DomainName: Common Models
//* FileName:   CourseSectionLevelViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The CourseSectionLevel View Model
     /// </summary>
    public partial class CourseSectionLevelViewModel : ViewModelBase, Interfaces.ICourseSectionLevel
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionLevel";

        // member variable for the CourseSectionId property
        private Guid _CourseSectionId;

        // RefCourseLevelTypeId -- (backing property for Course Level Type)
        private Guid _RefCourseLevelTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ICourseSection"/> model
        /// </summary>
        public Guid CourseSectionId { get => _CourseSectionId; set => SetProperty(ref _CourseSectionId, value); }

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
        public Guid RefCourseLevelTypeId { get => _RefCourseLevelTypeId; set => SetProperty(ref _RefCourseLevelTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionLevel model)
        {
            IsBusy = true;
            Id = model.Id;
            CourseSectionId = model.CourseSectionId; // 
            RefCourseLevelTypeId = model.RefCourseLevelTypeId; // Course Level Type
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
