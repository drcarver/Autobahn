//**********************************************************
//* DomainName: Common Models
//* FileName:   ActivityRecognitionViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The ActivityRecognition View Model
     /// </summary>
    public partial class ActivityRecognitionViewModel : ViewModelBase, Interfaces.IActivityRecognition
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ActivityRecognition";

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // RefActivityRecognitionTypeId -- (backing property for Recognition for Participation or Performance in an Activity)
        private Guid _RefActivityRecognitionTypeId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Recognition for Participation or Performance in an Activity
        /// <para>
        /// The nature of recognition given to the student for accomplishments in a co-curricular, or extra-curricular activity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19229">Recognition for Participation or Performance in an Activity</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid RefActivityRecognitionTypeId { get => _RefActivityRecognitionTypeId; set => SetProperty(ref _RefActivityRecognitionTypeId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IActivityRecognition model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefActivityRecognitionTypeId = model.RefActivityRecognitionTypeId; // Recognition for Participation or Performance in an Activity
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
