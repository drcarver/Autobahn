//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12OrganizationStudentResponsibilityViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.K12.ViewModels
{
     /// <summary>
     /// The K12OrganizationStudentResponsibilityViewModel
     /// </summary>
    public partial class K12OrganizationStudentResponsibilityViewModel : ViewModelBase, Interfaces.IK12OrganizationStudentResponsibility
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from K12OrganizationStudentResponsibility";

        // member variable for the RecordEndDateTime property
        private  _RecordEndDateTime;

        // member variable for the RecordStartDateTime property
        private  _RecordStartDateTime;

        // member variable for the RefK12ResponsibilityTypeId property
        private Guid? _RefK12ResponsibilityTypeId;

        // member variable for the RefStudentSchoolAffiliationStateDefinedStatusId property
        private  _RefStudentSchoolAffiliationStateDefinedStatusId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// </summary>
        public  RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// </summary>
        public  RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefK12ResponsibilityType"/> model
        /// </summary>
        public Guid? RefK12ResponsibilityTypeId { get => _RefK12ResponsibilityTypeId; set => SetProperty(ref _RefK12ResponsibilityTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefStudentSchoolAffiliationStateDefinedStatus"/> model
        /// </summary>
        public  RefStudentSchoolAffiliationStateDefinedStatusId { get => _RefStudentSchoolAffiliationStateDefinedStatusId; set => SetProperty(ref _RefStudentSchoolAffiliationStateDefinedStatusId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IK12OrganizationStudentResponsibility model)
        {
            IsBusy = true;
            Id = model.Id;
            RecordEndDateTime = model.RecordEndDateTime; // 
            RecordStartDateTime = model.RecordStartDateTime; // 
            RefK12ResponsibilityTypeId = model.RefK12ResponsibilityTypeId; // 
            RefStudentSchoolAffiliationStateDefinedStatusId = model.RefStudentSchoolAffiliationStateDefinedStatusId; // 
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
