//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ClassroomViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Invalid.ViewModels
{
     /// <summary>
     /// The ClassroomViewModel
     /// </summary>
    public partial class ClassroomViewModel : ViewModelBase, Interfaces.IClassroom
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Classroom";

        // member variable for the ClassroomIdentifier property
        private System.String _ClassroomIdentifier;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ClassroomViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
        /// </para>
        /// </summary>
        [DisplayName("Classroom Identifier")]
        public System.String ClassroomIdentifier { get => _ClassroomIdentifier; set => SetProperty(ref _ClassroomIdentifier, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IClassroom model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassroomIdentifier = model.ClassroomIdentifier; // Classroom Identifier
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
