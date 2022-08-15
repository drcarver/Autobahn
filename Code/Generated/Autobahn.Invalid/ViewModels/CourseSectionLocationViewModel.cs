//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   CourseSectionLocationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The CourseSectionLocationViewModel
     /// </summary>
    public partial class CourseSectionLocationViewModel : ViewModelBase, Interfaces.ICourseSectionLocation
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from CourseSectionLocation";

        // member variable for the ClassroomId property
        private Guid _ClassroomId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the CourseSectionLocationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Classroom"/> model
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
        /// </para>
        /// </summary>
        [DisplayName("Classroom Identifier")]
        public Guid ClassroomId { get => _ClassroomId; set => SetProperty(ref _ClassroomId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.ICourseSectionLocation model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassroomId = model.ClassroomId; // Classroom Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region "ICommands for Navigation Properties"
        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
        /// </para>
        /// </summary>
        public ICommand ClassroomCommand { get; set; }

        #endregion
    }
}
