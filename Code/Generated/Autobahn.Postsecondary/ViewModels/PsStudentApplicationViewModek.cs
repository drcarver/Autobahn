//**********************************************************
//* DomainName: Autobahn.Postsecondary
//* FileName:   PsStudentApplicationViewModel.cs
//**********************************************************

using Prism.Mvvm;
using Autobahn.Common.Interfaces;
using Autobahn.Autobahn.Postsecondary.Interfaces;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsStudentApplicationViewModel
     /// </summary>
    public partial class PsStudentApplicationViewModel : BindableBase, IPsStudentApplication
    {
#region "Backing Fields"
        // member variable for the PostsecondaryApplicant property
        private System.Boolean? _PostsecondaryApplicant;

        // member variable for the GradePointAverageCumulative property
        private System.Decimal? _GradePointAverageCumulative;

        // member variable for the HighSchoolPercentile property
        private System.Decimal? _HighSchoolPercentile;

        // member variable for the HighSchoolStudentClassRank property
        private System.Int32? _HighSchoolStudentClassRank;

        // member variable for the HighSchoolGraduatingClassSize property
        private System.Int32? _HighSchoolGraduatingClassSize;

        // member variable for the WaitListedStudent property
        private System.Boolean? _WaitListedStudent;

        // member variable for the RecordStartDateTime property
        private System.DateTime? _RecordStartDateTime;

        // member variable for the RecordEndDateTime property
        private System.DateTime? _RecordEndDateTime;

#endregion

#region Properties
        /// <summary>
        /// Reference to a required instance of the <see cref="OrganizationPersonRoleId"/> model
        /// </summary>
        public Guid OrganizationPersonRoleId { get; set; }

        public System.Boolean? PostsecondaryApplicant { get => _PostsecondaryApplicant; set => SetProperty(ref _PostsecondaryApplicant, value); }

        public System.Decimal? GradePointAverageCumulative { get => _GradePointAverageCumulative; set => SetProperty(ref _GradePointAverageCumulative, value); }

        public System.Decimal? HighSchoolPercentile { get => _HighSchoolPercentile; set => SetProperty(ref _HighSchoolPercentile, value); }

        public System.Int32? HighSchoolStudentClassRank { get => _HighSchoolStudentClassRank; set => SetProperty(ref _HighSchoolStudentClassRank, value); }

        public System.Int32? HighSchoolGraduatingClassSize { get => _HighSchoolGraduatingClassSize; set => SetProperty(ref _HighSchoolGraduatingClassSize, value); }

        public System.Boolean? WaitListedStudent { get => _WaitListedStudent; set => SetProperty(ref _WaitListedStudent, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGradePointAverageDomainId"/> model
        /// </summary>
        public Guid? RefGradePointAverageDomainId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefGpaWeightedIndicatorId"/> model
        /// </summary>
        public Guid? RefGpaWeightedIndicatorId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefAdmittedStudentId"/> model
        /// </summary>
        public Guid? RefAdmittedStudentId { get; set; }

        public System.DateTime? RecordStartDateTime { get => _RecordStartDateTime; set => SetProperty(ref _RecordStartDateTime, value); }

        public System.DateTime? RecordEndDateTime { get => _RecordEndDateTime; set => SetProperty(ref _RecordEndDateTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RecordStatusId"/> model
        /// </summary>
        public Guid? RecordStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="DataCollectionId"/> model
        /// </summary>
        public Guid? DataCollectionId { get; set; }

#endregion


        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(IPsStudentApplication model)
        {
            IsBusy = true;
            Id = model.Id;
            OrganizationPersonRoleId = model.OrganizationPersonRoleId;
            PostsecondaryApplicant = model.PostsecondaryApplicant;
            GradePointAverageCumulative = model.GradePointAverageCumulative;
            HighSchoolPercentile = model.HighSchoolPercentile;
            HighSchoolStudentClassRank = model.HighSchoolStudentClassRank;
            HighSchoolGraduatingClassSize = model.HighSchoolGraduatingClassSize;
            WaitListedStudent = model.WaitListedStudent;
            RefGradePointAverageDomainId = model.RefGradePointAverageDomainId;
            RefGpaWeightedIndicatorId = model.RefGpaWeightedIndicatorId;
            RefAdmittedStudentId = model.RefAdmittedStudentId;
            RecordStartDateTime = model.RecordStartDateTime;
            RecordEndDateTime = model.RecordEndDateTime;
            RecordStatusId = model.RecordStatusId;
            DataCollectionId = model.DataCollectionId;
            IsChanged = false;
            IsNew = false;
            IsBusy = false;
        }
    }
}
