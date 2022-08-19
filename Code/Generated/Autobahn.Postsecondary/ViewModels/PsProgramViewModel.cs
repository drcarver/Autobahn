//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsProgramViewModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.ViewModels;

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Postsecondary.ViewModels
{
     /// <summary>
     /// The PsProgram View Model
     /// </summary>
    public partial class PsProgramViewModel : ViewModelBase, Interfaces.IPsProgram
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from PsProgram";

        // NormalLengthTimeForCompletion -- (backing property for Normal Length of Time for Completion)
        private System.String _NormalLengthTimeForCompletion;

        // member variable for the OrganizationId property
        private Guid _OrganizationId;

        // ProgramLengthHours -- (backing property for Program Length Hours)
        private System.Decimal? _ProgramLengthHours;

        // RefCipCodeId -- (backing property for Classification of Instructional Program Code)
        private Guid? _RefCipCodeId;

        // RefCipVersionId -- (backing property for Classification of Instructional Program Version)
        private Guid? _RefCipVersionId;

        // RefDQPCategoriesOfLearningId -- (backing property for DQP Categories of Learning)
        private Guid? _RefDQPCategoriesOfLearningId;

        // RefProgramLengthHoursTypeId -- (backing property for Program Length Hours Type)
        private Guid? _RefProgramLengthHoursTypeId;

        // RefPSProgramLevelId -- (backing property for Postsecondary Program Level)
        private Guid? _RefPSProgramLevelId;

        // RefTimeForCompletionUnitsId -- (backing property for Normal Length of Time for Completion Units)
        private Guid? _RefTimeForCompletionUnitsId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Normal Length of Time for Completion
        /// <para>
        /// The amount of time necessary for a person to complete all requirements for a degree or certificate according to the institution's catalog. This is typically 4 years (8 semesters or trimesters, or 12 quarters, excluding summer terms) for a bachelor's degree in a standard term-based institution; 2 years (4 semesters or trimesters, or 6 quarters, excluding summer terms) for an associate's degree in a standard term-based institution; and the various scheduled times for certificate programs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19197">Normal Length of Time for Completion</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String NormalLengthTimeForCompletion { get => _NormalLengthTimeForCompletion; set => SetProperty(ref _NormalLengthTimeForCompletion, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get => _OrganizationId; set => SetProperty(ref _OrganizationId, value); }

        /// <summary>
        /// Program Length Hours
        /// <para>
        /// The normal length in credit/contact hours of a person's program as published in the institution's catalogue, website, or other official documents.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19223">Program Length Hours</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Decimal? ProgramLengthHours { get => _ProgramLengthHours; set => SetProperty(ref _ProgramLengthHours, value); }

        /// <summary>
        /// Classification of Instructional Program Code
        /// <para>
        /// A six-digit code in the form xx.xxxx that identifies instructional program specialties within educational institutions.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19043">Classification of Instructional Program Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCipCodeId { get => _RefCipCodeId; set => SetProperty(ref _RefCipCodeId, value); }

        /// <summary>
        /// Classification of Instructional Program Version
        /// <para>
        /// The version of CIP being reported.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19045">Classification of Instructional Program Version</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefCipVersionId { get => _RefCipVersionId; set => SetProperty(ref _RefCipVersionId, value); }

        /// <summary>
        /// DQP Categories of Learning
        /// <para>
        /// The Lumina Foundation's Degree Qualifications Profile offers reference points for what students should know and be able to do upon completion of associate, bachelor's and master's degrees - in any field of study. The DQP Categories of Learning provide a profile of what degrees mean within which specific proficiencies may be defined.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20622">DQP Categories of Learning</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefDQPCategoriesOfLearningId { get => _RefDQPCategoriesOfLearningId; set => SetProperty(ref _RefDQPCategoriesOfLearningId, value); }

        /// <summary>
        /// Program Length Hours Type
        /// <para>
        /// The type of hours (credit or contact) by which the normal length of a program of study is measured.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19224">Program Length Hours Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefProgramLengthHoursTypeId { get => _RefProgramLengthHoursTypeId; set => SetProperty(ref _RefProgramLengthHoursTypeId, value); }

        /// <summary>
        /// Postsecondary Program Level
        /// <para>
        /// The level describing the concentration of study for a postsecondary program.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20595">Postsecondary Program Level</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefPSProgramLevelId { get => _RefPSProgramLevelId; set => SetProperty(ref _RefPSProgramLevelId, value); }

        /// <summary>
        /// Normal Length of Time for Completion Units
        /// <para>
        /// The unit of measurement for length of time for completion.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19198">Normal Length of Time for Completion Units</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefTimeForCompletionUnitsId { get => _RefTimeForCompletionUnitsId; set => SetProperty(ref _RefTimeForCompletionUnitsId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IPsProgram model)
        {
            IsBusy = true;
            Id = model.Id;
            NormalLengthTimeForCompletion = model.NormalLengthTimeForCompletion; // Normal Length of Time for Completion
            OrganizationId = model.OrganizationId; // 
            ProgramLengthHours = model.ProgramLengthHours; // Program Length Hours
            RefCipCodeId = model.RefCipCodeId; // Classification of Instructional Program Code
            RefCipVersionId = model.RefCipVersionId; // Classification of Instructional Program Version
            RefDQPCategoriesOfLearningId = model.RefDQPCategoriesOfLearningId; // DQP Categories of Learning
            RefProgramLengthHoursTypeId = model.RefProgramLengthHoursTypeId; // Program Length Hours Type
            RefPSProgramLevelId = model.RefPSProgramLevelId; // Postsecondary Program Level
            RefTimeForCompletionUnitsId = model.RefTimeForCompletionUnitsId; // Normal Length of Time for Completion Units
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefProgramLengthHoursType List
        /// <summary>
        /// The complete <see cref="RefProgramLengthHoursType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefProgramLengthHoursTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("3bf1f79c-08c8-410d-8d1a-5a9341717b95"), Code="Credit", Description="Credit", Definition="Credit is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("47d52393-5096-4475-9778-3cdfe411aabe"), Code="Contact", Description="Contact", Definition="Contact is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefPSProgramLevel List
        /// <summary>
        /// The complete <see cref="RefPSProgramLevel"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPSProgramLevelList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("fe1bec70-610c-403d-a309-d10b4f0d68aa"), Code="Major", Description="Major", Definition="Major is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("6aa67e42-4762-43ef-8a86-358c3e65c678"), Code="Minor", Description="Minor", Definition="Minor is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ad23c443-526b-434c-a052-62778141c245"), Code="Certificate", Description="Certificate", Definition="Certificate is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("593154e0-dd94-4389-8533-d52d60a8fe68"), Code="Other", Description="Other", Definition="The concentration of study for the postsecondary program is in a category not yet defined in CEDS. ", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefTimeForCompletionUnits List
        /// <summary>
        /// The complete <see cref="RefTimeForCompletionUnits"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTimeForCompletionUnitsList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("0cf7d147-6746-45fc-acc4-04c6d2f7ac52"), Code="Hours", Description="Hours", Definition="The value given for Normal Length of Time for Completion is in Hours.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("311af1e0-6d39-48ce-b0da-dcca479690aa"), Code="Weeks", Description="Weeks", Definition="The value given for Normal Length of Time for Completion is in Weeks.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("7c910478-0290-43c8-af20-53665a3b6f8b"), Code="Quarters", Description="Quarters", Definition="The value given for Normal Length of Time for Completion is in Quarters.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("8a6b4a45-aff3-49d9-8fb6-e5bcec8480a3"), Code="Semesters", Description="Semesters", Definition="The value given for Normal Length of Time for Completion is in Semesters.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("96b67127-e502-41d2-a42d-37956903d7e6"), Code="Years", Description="Years", Definition="The value given for Normal Length of Time for Completion is in Years.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
