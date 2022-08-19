//**********************************************************
//* DomainName: Common Models
//* FileName:   ProgramParticipationMigrantViewModel.cs
//* Name:       Birthdate Verification
//* Definition: The evidence by which a child's date of birth is confirmed.
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The evidence by which a child's date of birth is confirmed.
     /// </summary>
    public partial class ProgramParticipationMigrantViewModel : ViewModelBase, Interfaces.IProgramParticipationMigrant
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from ProgramParticipationMigrant";

        // BirthdateVerification -- (backing property for Birthdate Verification)
        private System.String _BirthdateVerification;

        // ContinuationOfServicesStatus -- (backing property for Migrant Education Program Continuation of Services Status)
        private System.Boolean? _ContinuationOfServicesStatus;

        // DesignatedGraduationSchoolId -- (backing property for Designated Graduation School Identifier)
        private Guid? _DesignatedGraduationSchoolId;

        // ImmunizationRecordFlag -- (backing property for Immunization Record Flag)
        private System.Boolean? _ImmunizationRecordFlag;

        // LastQualifyingMoveDate -- (backing property for Last Qualifying Move Date)
        private System.DateTime? _LastQualifyingMoveDate;

        // MepEligibilityExpirationDate -- (backing property for Migrant Education Program Eligibility Expiration Date)
        private System.DateTime? _MepEligibilityExpirationDate;

        // MigrantStudentQualifyingArrivalDate -- (backing property for Migrant Student Qualifying Arrival Date)
        private System.DateTime? _MigrantStudentQualifyingArrivalDate;

        // member variable for the PersonProgramParticipationId property
        private Guid _PersonProgramParticipationId;

        // PrioritizedForServices -- (backing property for Migrant Prioritized for Services)
        private System.Boolean? _PrioritizedForServices;

        // QualifyingMoveFromCity -- (backing property for Qualifying Move From City)
        private System.String _QualifyingMoveFromCity;

        // RefContinuationOfServicesReasonId -- (backing property for Continuation of Services Reason)
        private Guid? _RefContinuationOfServicesReasonId;

        // RefMepEnrollmentTypeId -- (backing property for Migrant Education Program Enrollment Type)
        private Guid? _RefMepEnrollmentTypeId;

        // RefMepProjectBasedId -- (backing property for Migrant Education Program Project Based)
        private Guid? _RefMepProjectBasedId;

        // RefMepServiceTypeId -- (backing property for Migrant Education Program Services Type)
        private Guid? _RefMepServiceTypeId;

        // RefQualifyingMoveFromCountryId -- (backing property for Qualifying Move From Country)
        private Guid? _RefQualifyingMoveFromCountryId;

        // RefQualifyingMoveFromStateId -- (backing property for Qualifying Move From State)
        private Guid? _RefQualifyingMoveFromStateId;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Birthdate Verification
        /// <para>
        /// The evidence by which a child's date of birth is confirmed.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19418">Birthdate Verification</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String BirthdateVerification { get => _BirthdateVerification; set => SetProperty(ref _BirthdateVerification, value); }

        /// <summary>
        /// Migrant Education Program Continuation of Services Status
        /// <para>
        /// An indication that migrant children are receiving instructional or support services under the continuation of services authority ESEA Title III Section 1304(e)(2)-(3).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19555">Migrant Education Program Continuation of Services Status</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ContinuationOfServicesStatus { get => _ContinuationOfServicesStatus; set => SetProperty(ref _ContinuationOfServicesStatus, value); }

        /// <summary>
        /// Designated Graduation School Identifier
        /// <para>
        /// The NCES school identification number that identifies the school or facility from which a student expects to graduate.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19426">Designated Graduation School Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? DesignatedGraduationSchoolId { get => _DesignatedGraduationSchoolId; set => SetProperty(ref _DesignatedGraduationSchoolId, value); }

        /// <summary>
        /// Immunization Record Flag
        /// <para>
        /// Indicates whether the school or MEP program has immunization records on file for the student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19428">Immunization Record Flag</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ImmunizationRecordFlag { get => _ImmunizationRecordFlag; set => SetProperty(ref _ImmunizationRecordFlag, value); }

        /// <summary>
        /// Last Qualifying Move Date
        /// <para>
        /// The year, month and day of the last qualifying move of a migrant student.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19171">Last Qualifying Move Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? LastQualifyingMoveDate { get => _LastQualifyingMoveDate; set => SetProperty(ref _LastQualifyingMoveDate, value); }

        /// <summary>
        /// Migrant Education Program Eligibility Expiration Date
        /// <para>
        /// The year, month, and day on which the child is no longer eligible for the Migrant Education Program. This date should initially be a date equal to 36 months from the Qualifying Arrival Date to indicate the end of MEP eligibility or the student reaches 22 years of age, whichever comes first.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19420">Migrant Education Program Eligibility Expiration Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? MepEligibilityExpirationDate { get => _MepEligibilityExpirationDate; set => SetProperty(ref _MepEligibilityExpirationDate, value); }

        /// <summary>
        /// Migrant Student Qualifying Arrival Date
        /// <para>
        /// The qualifying arrival date (QAD) is the month, date, and year that the child completed a move with his or her parent to enable the parent to find qualifying employment. In some cases, the child and worker may not always move together, in which case the QAD would be the date that the child joins the worker who has  already moved, or the date the worker joins the child who has already moved. The QAD is the date the child's eligibility for the Migrant Education Program begins.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19422">Migrant Student Qualifying Arrival Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? MigrantStudentQualifyingArrivalDate { get => _MigrantStudentQualifyingArrivalDate; set => SetProperty(ref _MigrantStudentQualifyingArrivalDate, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPersonProgramParticipation"/> model
        /// </summary>
        public Guid PersonProgramParticipationId { get => _PersonProgramParticipationId; set => SetProperty(ref _PersonProgramParticipationId, value); }

        /// <summary>
        /// Migrant Prioritized for Services
        /// <para>
        /// An indication that a migratory child 1) is failing to meet, or most at risk of failing to meet, the state's challenging academic content standards and student academic achievement standards; and 2) has experienced interruptions in their education during the regular school year.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19554">Migrant Prioritized for Services</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? PrioritizedForServices { get => _PrioritizedForServices; set => SetProperty(ref _PrioritizedForServices, value); }

        /// <summary>
        /// Qualifying Move From City
        /// <para>
        /// The name of the city in which the child resided prior to the qualifying move.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19423">Qualifying Move From City</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String QualifyingMoveFromCity { get => _QualifyingMoveFromCity; set => SetProperty(ref _QualifyingMoveFromCity, value); }

        /// <summary>
        /// Continuation of Services Reason
        /// <para>
        /// Reason why the student is being served under the continuation of services provision of the MEP.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19419">Continuation of Services Reason</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefContinuationOfServicesReasonId { get => _RefContinuationOfServicesReasonId; set => SetProperty(ref _RefContinuationOfServicesReasonId, value); }

        /// <summary>
        /// Migrant Education Program Enrollment Type
        /// <para>
        /// The type of school/migrant education project in which instruction and/or support services are provided.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19427">Migrant Education Program Enrollment Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMepEnrollmentTypeId { get => _RefMepEnrollmentTypeId; set => SetProperty(ref _RefMepEnrollmentTypeId, value); }

        /// <summary>
        /// Migrant Education Program Project Based
        /// <para>
        /// Indicates the type of MEP project based on the location where the MEP services are held.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19430">Migrant Education Program Project Based</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMepProjectBasedId { get => _RefMepProjectBasedId; set => SetProperty(ref _RefMepProjectBasedId, value); }

        /// <summary>
        /// Migrant Education Program Services Type
        /// <para>
        /// The type of services received by participating migrant students in the migrant education program (MEP).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19186">Migrant Education Program Services Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefMepServiceTypeId { get => _RefMepServiceTypeId; set => SetProperty(ref _RefMepServiceTypeId, value); }

        /// <summary>
        /// Qualifying Move From Country
        /// <para>
        /// The abbreviation code for a country (other than the US) area in which the child resided prior to the qualifying move.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19424">Qualifying Move From Country</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefQualifyingMoveFromCountryId { get => _RefQualifyingMoveFromCountryId; set => SetProperty(ref _RefQualifyingMoveFromCountryId, value); }

        /// <summary>
        /// Qualifying Move From State
        /// <para>
        /// The postal abbreviation code for a state (within the United States) or outlying area in which the child resided prior to the qualifying move.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19425">Qualifying Move From State</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefQualifyingMoveFromStateId { get => _RefQualifyingMoveFromStateId; set => SetProperty(ref _RefQualifyingMoveFromStateId, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IProgramParticipationMigrant model)
        {
            IsBusy = true;
            Id = model.Id;
            BirthdateVerification = model.BirthdateVerification; // Birthdate Verification
            ContinuationOfServicesStatus = model.ContinuationOfServicesStatus; // Migrant Education Program Continuation of Services Status
            DesignatedGraduationSchoolId = model.DesignatedGraduationSchoolId; // Designated Graduation School Identifier
            ImmunizationRecordFlag = model.ImmunizationRecordFlag; // Immunization Record Flag
            LastQualifyingMoveDate = model.LastQualifyingMoveDate; // Last Qualifying Move Date
            MepEligibilityExpirationDate = model.MepEligibilityExpirationDate; // Migrant Education Program Eligibility Expiration Date
            MigrantStudentQualifyingArrivalDate = model.MigrantStudentQualifyingArrivalDate; // Migrant Student Qualifying Arrival Date
            PersonProgramParticipationId = model.PersonProgramParticipationId; // 
            PrioritizedForServices = model.PrioritizedForServices; // Migrant Prioritized for Services
            QualifyingMoveFromCity = model.QualifyingMoveFromCity; // Qualifying Move From City
            RefContinuationOfServicesReasonId = model.RefContinuationOfServicesReasonId; // Continuation of Services Reason
            RefMepEnrollmentTypeId = model.RefMepEnrollmentTypeId; // Migrant Education Program Enrollment Type
            RefMepProjectBasedId = model.RefMepProjectBasedId; // Migrant Education Program Project Based
            RefMepServiceTypeId = model.RefMepServiceTypeId; // Migrant Education Program Services Type
            RefQualifyingMoveFromCountryId = model.RefQualifyingMoveFromCountryId; // Qualifying Move From Country
            RefQualifyingMoveFromStateId = model.RefQualifyingMoveFromStateId; // Qualifying Move From State
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefMepEnrollmentType List
        /// <summary>
        /// The complete Birthdate Verification List
        /// </summary>
        private static List<ReferenceModelBase> RefMepEnrollmentTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("8a9e0b57-05c9-497f-b92e-53dd8d4f9ebc"), Code="01", Description="Basic School Program", Definition="Basic School Program is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("45ac8df8-c92d-4a4e-a496-53e5de21dfce"), Code="02", Description="Regular Term MEP-Funded Project", Definition="Regular Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("1f569020-c285-4845-ac9c-4382b9aa810a"), Code="03", Description="Summer/Intersession MEP-Funded Project", Definition="Summer/Intersession MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("492da832-5784-4e85-ac8d-b301c93238f1"), Code="04", Description="Year Round MEP-Funded Project", Definition="Year Round MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c845be38-9bf4-47e4-a393-f0f8d3f58606"), Code="05", Description="Basic School Program and Regular-Term MEP-Funded Project", Definition="Basic School Program and Regular-Term MEP-Funded Project is the type of school/migrant education project in which instruction and/or support services are provided.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("a137f352-922a-494b-b2b5-1336165c7ccd"), Code="06", Description="Residency Only (none of the above)", Definition="Residency Only (none of the above)", SortOrder=Convert.ToDecimal("6.00") },
        };
        #endregion

        #region RefMepProjectBased List
        /// <summary>
        /// The complete Birthdate Verification List
        /// </summary>
        private static List<ReferenceModelBase> RefMepProjectBasedList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("ed7f6693-0eca-4581-a4e0-346e6d87984c"), Code="SchoolBased", Description="School-based MEP Project", Definition="School-based Migrant Education Program Project", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("1c0aca1c-f748-4088-a159-1902fe832347"), Code="NonSchoolBased", Description="Non-school-based MEP project", Definition="Non-school-based Migrant Education Program project", SortOrder=Convert.ToDecimal("2.00") },
        };
        #endregion

        #region RefMepServiceType List
        /// <summary>
        /// The complete Birthdate Verification List
        /// </summary>
        private static List<ReferenceModelBase> RefMepServiceTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("d63176b5-d66b-454d-81bb-05156ee9422c"), Code="CounselingServices", Description="Counseling Services", Definition="Counseling Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("1.00") },
            new ReferenceModelBase { Id=Guid.Parse("03bba1b8-d23c-4de2-8b3c-beaf41dbd577"), Code="HighSchoolAccrual", Description="High School Accrual", Definition="High School Accrual provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("9a5a68b3-ed1a-4814-a22f-a49e71cb9ca6"), Code="InstructionalServices", Description="Instructional Services", Definition="Instructional Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("3.00") },
            new ReferenceModelBase { Id=Guid.Parse("a982aafd-9255-4db7-9fc5-9afe4d1b1ba5"), Code="MathematicsInstruction", Description="Mathematics Instruction", Definition="Mathematics Instruction provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("2f8c5319-0efc-453e-be76-d96914dba0c6"), Code="ReadingInstruction", Description="Reading Instruction", Definition="Reading Instruction provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("5.00") },
            new ReferenceModelBase { Id=Guid.Parse("364ace30-0fc3-4b4e-aca9-caf8c106e48a"), Code="ReferralServices", Description="Referral Services", Definition="Referral Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("c097f0a4-8fa2-4cf2-9856-aed660ec63d8"), Code="SupportServices", Description="Support Services", Definition="Support Services provided as part of a Migrant Education Program.", SortOrder=Convert.ToDecimal("7.00") },
        };
        #endregion

        #region RefQualifyingMoveFromCountry List
        /// <summary>
        /// The complete Birthdate Verification List
        /// </summary>
        private static List<ReferenceModelBase> RefQualifyingMoveFromCountryList = new List<ReferenceModelBase>
        {
        };
        #endregion

        #region RefQualifyingMoveFromState List
        /// <summary>
        /// The complete Birthdate Verification List
        /// </summary>
        private static List<ReferenceModelBase> RefQualifyingMoveFromStateList = new List<ReferenceModelBase>
        {
        };
        #endregion
    }
}
