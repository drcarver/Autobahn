//**********************************************************
//* DomainName: Adult Education (AE)
//* FileName:   ProgramParticipationAEModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.AdultEducation.Models
{
     /// <summary>
     /// The ProgramParticipationAE Model
     /// </summary>
    public partial class ProgramParticipationAEModel : AutobahnBase, Interfaces.IProgramParticipationAE
    {
        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Boolean? DisplacedHomemakerIndicator { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Decimal? InstructionalActivityHoursCompleted { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Boolean? OutOfWorkforceIndicator { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid PersonProgramParticipationId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.DateTime? PostsecondaryTransitionDate { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public System.Decimal? ProxyContactHours { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefAdultEducationProgramExitReasonId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefAeFunctioningLevelAtIntakeId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefAeFunctioningLevelAtPosttestId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefAeInstructionalProgramTypeId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefAePostsecondaryTransitionActionId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefAeSpecialProgramTypeId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefCorrectionalEducationFacilityTypeId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefGoalsForAttendingAdultEducationId { get; set; }

        /// <summary>
        /// A person who ; (A) (i) has worked primarily without remuneration to care for a home and family, and for that reason has diminished marketable skills;    (ii) has been dependent on the income of another family member but is no longer supported by that income; or    (iii) is a parent whose youngest dependent child will become ineligible to receive assistance under part A of title IV of the Social Security Act (42 U.S.C. 601 et seq.) not later than 2 years after the date on which the parent applies for assistance under such title; and (B)   is unemployed or underemployed and is experiencing difficulty in obtaining or upgrading employment.
        /// </summary>
        public Guid? RefWorkbasedLearningOpportunityTypeId { get; set; }

    }
}
