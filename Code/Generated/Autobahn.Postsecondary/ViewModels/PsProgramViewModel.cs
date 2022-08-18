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
            new ReferenceModelBase { Id=Guid.Parse("76336c03-9869-424d-a319-d736c8913248"), Code="Credit", Description="Credit", Definition="Credit is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("688c77f3-68b4-4fed-85fa-63acf949875e"), Code="Contact", Description="Contact", Definition="Contact is the type of hours (credit or contact) by which the normal length of a program of study is measured.", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefPSProgramLevel List
        /// <summary>
        /// The complete <see cref="RefPSProgramLevel"> List
        /// </summary>
        private static List<ReferenceModelBase> RefPSProgramLevelList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("4670417c-6772-4beb-8e9a-4e15db100633"), Code="Major", Description="Major", Definition="Major is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f4236e7-b311-4f40-aef7-c6d01465fdd6"), Code="Minor", Description="Minor", Definition="Minor is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("871ac68e-0b84-4664-bd50-5a9f5839e62d"), Code="Certificate", Description="Certificate", Definition="Certificate is the  concentration of study for the postsecondary program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("8af39960-b18a-4a25-a029-b01f25e4e5fa"), Code="Other", Description="Other", Definition="The concentration of study for the postsecondary program is in a category not yet defined in CEDS. ", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefTimeForCompletionUnits List
        /// <summary>
        /// The complete <see cref="RefTimeForCompletionUnits"> List
        /// </summary>
        private static List<ReferenceModelBase> RefTimeForCompletionUnitsList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("f5e78efe-95a9-4243-b62d-d123ef09003f"), Code="Hours", Description="Hours", Definition="The value given for Normal Length of Time for Completion is in Hours.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("916571e1-4004-4576-b67d-86405bf1e43f"), Code="Weeks", Description="Weeks", Definition="The value given for Normal Length of Time for Completion is in Weeks.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("53b2ce75-8ed7-4469-a8cf-4c1976bdb12d"), Code="Quarters", Description="Quarters", Definition="The value given for Normal Length of Time for Completion is in Quarters.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("ff87f779-3416-4816-8ed0-af477d94184f"), Code="Semesters", Description="Semesters", Definition="The value given for Normal Length of Time for Completion is in Semesters.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("8450d6e2-8fcb-41bb-8811-fe5ad26f22d1"), Code="Years", Description="Years", Definition="The value given for Normal Length of Time for Completion is in Years.", SortOrder=Convert.ToDecimal("5.00") },
        };
        #endregion
    }
}
