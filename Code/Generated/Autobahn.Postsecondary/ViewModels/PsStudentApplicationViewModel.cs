//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentApplicationViewModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;
using CommunityToolkit.Maui;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentApplicationViewModel
     /// </summary>
    public partial class PsStudentApplicationViewModel : ViewModelBase, Interfaces.IPsStudentApplication
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsStudentApplication";

        // member variable for the GradePointAverageCumulative property
        private System.Decimal? _GradePointAverageCumulative;

        // member variable for the HighSchoolGraduatingClassSize property
        private System.Int32? _HighSchoolGraduatingClassSize;

        // member variable for the HighSchoolPercentile property
        private System.Decimal? _HighSchoolPercentile;

        // member variable for the HighSchoolStudentClassRank property
        private System.Int32? _HighSchoolStudentClassRank;

        // member variable for the OrganizationPersonRoleId property
        private Guid _OrganizationPersonRoleId;

        // member variable for the PostsecondaryApplicant property
        private System.Boolean? _PostsecondaryApplicant;

        // member variable for the RefAdmittedStudentId property
        private Guid? _RefAdmittedStudentId;

        // member variable for the RefGpaWeightedIndicatorId property
        private Guid? _RefGpaWeightedIndicatorId;

        // member variable for the RefGradePointAverageDomainId property
        private Guid? _RefGradePointAverageDomainId;

        // member variable for the WaitListedStudent property
        private System.Boolean? _WaitListedStudent;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the PsStudentApplicationViewModel
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Int32? HighSchoolGraduatingClassSize { get => _HighSchoolGraduatingClassSize; set => SetProperty(ref _HighSchoolGraduatingClassSize, value); }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Decimal? HighSchoolPercentile { get => _HighSchoolPercentile; set => SetProperty(ref _HighSchoolPercentile, value); }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Int32? HighSchoolStudentClassRank { get => _HighSchoolStudentClassRank; set => SetProperty(ref _HighSchoolStudentClassRank, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="OrganizationPersonRole"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Boolean? PostsecondaryApplicant { get => _PostsecondaryApplicant; set => SetProperty(ref _PostsecondaryApplicant, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmittedStudent"/> model
        /// </summary>
        public Guid? RefAdmittedStudentId { get => _RefAdmittedStudentId; set => SetProperty(ref _RefAdmittedStudentId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicator"/> model
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get => _RefGpaWeightedIndicatorId; set => SetProperty(ref _RefGpaWeightedIndicatorId, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradePointAverageDomain"/> model
        /// </summary>
        public Guid? RefGradePointAverageDomainId { get => _RefGradePointAverageDomainId; set => SetProperty(ref _RefGradePointAverageDomainId, value); }

        /// <summary>
        /// The academic rank of a student in relation to his or her high school graduating class (e.g., 1, 2, 3) based on high school GPA.
        /// </summary>
        public System.Boolean? WaitListedStudent { get => _WaitListedStudent; set => SetProperty(ref _WaitListedStudent, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsStudentApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            GradePointAverageCumulative = model.GradePointAverageCumulative;
            HighSchoolGraduatingClassSize = model.HighSchoolGraduatingClassSize;
            HighSchoolPercentile = model.HighSchoolPercentile;
            HighSchoolStudentClassRank = model.HighSchoolStudentClassRank;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PostsecondaryApplicant = model.PostsecondaryApplicant;
            RefAdmittedStudentId = model.RefAdmittedStudentId;
            RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId;
            RefGradePointAverageDomainId = model.RefGradePointAverageDomainId;
            WaitListedStudent = model.WaitListedStudent;
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
