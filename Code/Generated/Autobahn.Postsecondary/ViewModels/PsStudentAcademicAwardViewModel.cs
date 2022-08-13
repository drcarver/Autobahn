//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicAwardViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentAcademicAwardViewModel
     /// </summary>
    public partial class PsStudentAcademicAwardViewModel : ViewModelBase, Interfaces.IPsStudentAcademicAward
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentAcademicAward";

        // member variable for the AcademicAwardDate property
        private System.String _AcademicAwardDate;

        // member variable for the AcademicAwardTitle property
        private System.String _AcademicAwardTitle;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the RefAcademicAwardLevelId property
        private Guid? _RefAcademicAwardLevelId;

        // member variable for the RefAcademicAwardPrerequisiteTypeId property
        private Guid? _RefAcademicAwardPrerequisiteTypeId;

        // member variable for the RefPESCAwardLevelTypeId property
        private Guid? _RefPESCAwardLevelTypeId;

        // member variable for the RequirementsURL property
        private System.String _RequirementsURL;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentAcademicAwardViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </summary>
        public System.String AcademicAwardDate { get => _AcademicAwardDate; set => SetProperty(ref _AcademicAwardDate, value); }

        /// <summary>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </summary>
        public System.String AcademicAwardTitle { get => _AcademicAwardTitle; set => SetProperty(ref _AcademicAwardTitle, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardLevel"/> model
        /// </summary>
        public Guid? RefAcademicAwardLevelId { get => _RefAcademicAwardLevelId; set => SetProperty(ref _RefAcademicAwardLevelId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAcademicAwardPrerequisiteType"/> model
        /// </summary>
        public Guid? RefAcademicAwardPrerequisiteTypeId { get => _RefAcademicAwardPrerequisiteTypeId; set => SetProperty(ref _RefAcademicAwardPrerequisiteTypeId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPESCAwardLevelType"/> model
        /// </summary>
        public Guid? RefPESCAwardLevelTypeId { get => _RefPESCAwardLevelTypeId; set => SetProperty(ref _RefPESCAwardLevelTypeId, value); }

        /// <summary>
        /// The year, month and day or year and month on which the academic award was conferred.
        /// </summary>
        public System.String RequirementsURL { get => _RequirementsURL; set => SetProperty(ref _RequirementsURL, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentAcademicAward model)
        {
            IsBusy = true;
            Id = model.Id;
            AcademicAwardDate = model.AcademicAwardDate;
            AcademicAwardTitle = model.AcademicAwardTitle;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            RefAcademicAwardLevelId = model.RefAcademicAwardLevelId;
            RefAcademicAwardPrerequisiteTypeId = model.RefAcademicAwardPrerequisiteTypeId;
            RefPESCAwardLevelTypeId = model.RefPESCAwardLevelTypeId;
            RequirementsURL = model.RequirementsURL;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
