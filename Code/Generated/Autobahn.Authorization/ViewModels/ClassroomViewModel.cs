//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ClassroomViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Authorization.ViewModels
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

        // member variable for the LocationId property
        private Guid _LocationId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the ClassroomViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// A unique number or alphanumeric code assigned to a room by a school, school system, state, or other agency or entity.
        /// </summary>
        public System.String ClassroomIdentifier { get => _ClassroomIdentifier; set => SetProperty(ref _ClassroomIdentifier, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="Location"/> model
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
            ClassroomIdentifier = model.ClassroomIdentifier;
            LocationId = model.LocationId;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
