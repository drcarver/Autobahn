//**********************************************************
//* DomainName: Common Models
//* FileName:   ClassroomViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The Classroom View Model
     /// </summary>
    public partial class ClassroomViewModel : ViewModelBase, Interfaces.IClassroom
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Classroom";

        // ClassroomIdentifier -- (backing property for Classroom Identifier)
        private System.String _ClassroomIdentifier;

        // member variable for the LocationId property
        private Guid _LocationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Classroom Identifier
        /// <para>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19507">Classroom Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String ClassroomIdentifier { get => _ClassroomIdentifier; set => SetProperty(ref _ClassroomIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="ILocation"/> model
        /// </summary>
        public Guid LocationId { get => _LocationId; set => SetProperty(ref _LocationId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IClassroom model)
        {
            IsBusy = true;
            Id = model.Id;
            ClassroomIdentifier = model.ClassroomIdentifier; // Classroom Identifier
            LocationId = model.LocationId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
