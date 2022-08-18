//**********************************************************
//* DomainName: Common Models
//* FileName:   IncidentViewModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using System.ComponentModel;
using System.Windows.Input;

namespace Autobahn.Common.ViewModels
{
     /// <summary>
     /// The Incident View Model
     /// </summary>
    public partial class IncidentViewModel : ViewModelBase, Interfaces.IIncident
    {
        #region "Backing Fields"
        // Every viewmodel has a Title property
        private string _viewTitle = "Hello from Incident";

        // IncidentCost -- (backing property for Incident Cost)
        private System.String _IncidentCost;

        // IncidentDate -- (backing property for Incident Date)
        private System.DateTime? _IncidentDate;

        // IncidentDescription -- (backing property for Incident Description)
        private System.String _IncidentDescription;

        // IncidentIdentifier -- (backing property for Incident Identifier)
        private System.String _IncidentIdentifier;

        // IncidentReporterId -- (backing property for Reporter Identifier)
        private Guid? _IncidentReporterId;

        // IncidentTime -- (backing property for Incident Time)
        private System.TimeSpan? _IncidentTime;

        // member variable for the OrganizationPersonRoleId property
        private Guid? _OrganizationPersonRoleId;

        // RefFirearmTypeId -- (backing property for Firearm Type)
        private Guid? _RefFirearmTypeId;

        // RefIncidentBehaviorId -- (backing property for Incident Behavior)
        private Guid? _RefIncidentBehaviorId;

        // RefIncidentBehaviorSecondaryId -- (backing property for Secondary Incident Behavior)
        private Guid? _RefIncidentBehaviorSecondaryId;

        // RefIncidentInjuryTypeId -- (backing property for Incident Injury Type)
        private Guid? _RefIncidentInjuryTypeId;

        // RefIncidentLocationId -- (backing property for Incident Location)
        private Guid? _RefIncidentLocationId;

        // RefIncidentMultipleOffenseTypeId -- (backing property for Incident Multiple Offense Type)
        private Guid? _RefIncidentMultipleOffenseTypeId;

        // RefIncidentPerpetratorInjuryTypeId -- (backing property for Incident Perpetrator Injury Type)
        private Guid? _RefIncidentPerpetratorInjuryTypeId;

        // RefIncidentReporterTypeId -- (backing property for Incident Reporter Type)
        private Guid? _RefIncidentReporterTypeId;

        // RefIncidentTimeDescriptionCodeId -- (backing property for Incident Time Description Code)
        private Guid? _RefIncidentTimeDescriptionCodeId;

        // RefWeaponTypeId -- (backing property for Weapon Type)
        private Guid? _RefWeaponTypeId;

        // RegulationViolatedDescription -- (backing property for Incident Regulation Violated Description)
        private System.String _RegulationViolatedDescription;

        // RelatedToDisabilityManifestationInd -- (backing property for Incident Related to Disability Manifestation)
        private System.Boolean? _RelatedToDisabilityManifestationInd;

        // ReportedToLawEnforcementInd -- (backing property for Incident Reported to Law Enforcement Indicator)
        private System.Boolean? _ReportedToLawEnforcementInd;

        #endregion

        #region Properties
        /// <summary>
        /// The title of the View Model
        /// </summary>
        public string ViewTitle { get => _viewTitle; set => SetProperty(ref _viewTitle, value); }

        /// <summary>
        /// Incident Cost
        /// <para>
        /// The value of any quantifiable monetary loss directly resulting from the incident. Examples include the value of repairs necessitated by vandalism of a school facility, the value of personnel resources used for repairs or consumed by the incident, the value of stolen items, and the value of time consumed by an incident (e.g., instructional time involved in evacuating a school during a false fire alarm).  Cost may be reported by specific monetary amount or range.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19496">Incident Cost</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String IncidentCost { get => _IncidentCost; set => SetProperty(ref _IncidentCost, value); }

        /// <summary>
        /// Incident Date
        /// <para>
        /// The year, month and day on which the incident occurred.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19493">Incident Date</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.DateTime? IncidentDate { get => _IncidentDate; set => SetProperty(ref _IncidentDate, value); }

        /// <summary>
        /// Incident Description
        /// <para>
        /// The description for an incident.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19499">Incident Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String IncidentDescription { get => _IncidentDescription; set => SetProperty(ref _IncidentDescription, value); }

        /// <summary>
        /// Incident Identifier
        /// <para>
        /// A locally assigned unique identifier (within the school or school district) to identify each specific incident or occurrence. The same identifier should be used to document the entire incident even if it included multiple offenses and multiple offenders.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19492">Incident Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String IncidentIdentifier { get => _IncidentIdentifier; set => SetProperty(ref _IncidentIdentifier, value); }

        /// <summary>
        /// Reporter Identifier
        /// <para>
        /// Identifies the reporter of the incident using  a pre-existing unique student identifier or unique staff identifier, when the reporter is a student or staff member.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19498">Reporter Identifier</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? IncidentReporterId { get => _IncidentReporterId; set => SetProperty(ref _IncidentReporterId, value); }

        /// <summary>
        /// Incident Time
        /// <para>
        /// An indication of the time of day the incident took place.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19494">Incident Time</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.TimeSpan? IncidentTime { get => _IncidentTime; set => SetProperty(ref _IncidentTime, value); }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        public Guid? OrganizationPersonRoleId { get => _OrganizationPersonRoleId; set => SetProperty(ref _OrganizationPersonRoleId, value); }

        /// <summary>
        /// Firearm Type
        /// <para>
        /// The type of firearm.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19548">Firearm Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefFirearmTypeId { get => _RefFirearmTypeId; set => SetProperty(ref _RefFirearmTypeId, value); }

        /// <summary>
        /// Incident Behavior
        /// <para>
        /// Categories of behavior coded for use in describing an incident.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19500">Incident Behavior</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentBehaviorId { get => _RefIncidentBehaviorId; set => SetProperty(ref _RefIncidentBehaviorId, value); }

        /// <summary>
        /// Secondary Incident Behavior
        /// <para>
        /// Supplemental information about an incident when the primary offense is more serious in nature than alcohol or drug, etc. offenses.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19620">Secondary Incident Behavior</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentBehaviorSecondaryId { get => _RefIncidentBehaviorSecondaryId; set => SetProperty(ref _RefIncidentBehaviorSecondaryId, value); }

        /// <summary>
        /// Incident Injury Type
        /// <para>
        /// An indication of the occurrence of physical injury to participants involved in the incident and, if so, the level of injury sustained.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19501">Incident Injury Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentInjuryTypeId { get => _RefIncidentInjuryTypeId; set => SetProperty(ref _RefIncidentInjuryTypeId, value); }

        /// <summary>
        /// Incident Location
        /// <para>
        /// Identifies where the incident occurred and whether or not it occurred on campus.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19610">Incident Location</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentLocationId { get => _RefIncidentLocationId; set => SetProperty(ref _RefIncidentLocationId, value); }

        /// <summary>
        /// Incident Multiple Offense Type
        /// <para>
        /// An indication of whether the offense was primary or secondary in nature when a single incident included more than one type of offense.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20337">Incident Multiple Offense Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentMultipleOffenseTypeId { get => _RefIncidentMultipleOffenseTypeId; set => SetProperty(ref _RefIncidentMultipleOffenseTypeId, value); }

        /// <summary>
        /// Incident Perpetrator Injury Type
        /// <para>
        /// An indication of the occurrence of physical injury to the perpetrator(s) (participants) involved in the incident and, if so, the level of injury sustained.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20339">Incident Perpetrator Injury Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentPerpetratorInjuryTypeId { get => _RefIncidentPerpetratorInjuryTypeId; set => SetProperty(ref _RefIncidentPerpetratorInjuryTypeId, value); }

        /// <summary>
        /// Incident Reporter Type
        /// <para>
        /// Information on the type of person who reported the incident. When known and/or if useful, use a more specific option code (e.g., "Counselor" rather than "Professional Staff").
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19497">Incident Reporter Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentReporterTypeId { get => _RefIncidentReporterTypeId; set => SetProperty(ref _RefIncidentReporterTypeId, value); }

        /// <summary>
        /// Incident Time Description Code
        /// <para>
        /// A code for the description of the time of day that an incident took place.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19506">Incident Time Description Code</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefIncidentTimeDescriptionCodeId { get => _RefIncidentTimeDescriptionCodeId; set => SetProperty(ref _RefIncidentTimeDescriptionCodeId, value); }

        /// <summary>
        /// Weapon Type
        /// <para>
        /// Identifies the type of weapon used during an incident.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20178">Weapon Type</a>
        /// </para>
        /// </summary>
        /// </summary>
        public Guid? RefWeaponTypeId { get => _RefWeaponTypeId; set => SetProperty(ref _RefWeaponTypeId, value); }

        /// <summary>
        /// Incident Regulation Violated Description
        /// <para>
        /// A description of the rule, regulation, or standard that was violated when an incident occurred (e.g., the identification of a relevant law, conduct standard, or acceptable use policy).
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20342">Incident Regulation Violated Description</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.String RegulationViolatedDescription { get => _RegulationViolatedDescription; set => SetProperty(ref _RegulationViolatedDescription, value); }

        /// <summary>
        /// Incident Related to Disability Manifestation
        /// <para>
        /// An indication whether a student's behavior (offense) was a manifestation of, or related to, a disability condition.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20343">Incident Related to Disability Manifestation</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? RelatedToDisabilityManifestationInd { get => _RelatedToDisabilityManifestationInd; set => SetProperty(ref _RelatedToDisabilityManifestationInd, value); }

        /// <summary>
        /// Incident Reported to Law Enforcement Indicator
        /// <para>
        /// An indication that the school resource officer or any other law enforcement official was notified about the incident, regardless of whether official action is taken.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20345">Incident Reported to Law Enforcement Indicator</a>
        /// </para>
        /// </summary>
        /// </summary>
        public System.Boolean? ReportedToLawEnforcementInd { get => _ReportedToLawEnforcementInd; set => SetProperty(ref _ReportedToLawEnforcementInd, value); }

        #endregion

        /// <summary>
        /// Load the viewmodel from a model
        /// </summary>
        public void Load(Interfaces.IIncident model)
        {
            IsBusy = true;
            Id = model.Id;
            IncidentCost = model.IncidentCost; // Incident Cost
            IncidentDate = model.IncidentDate; // Incident Date
            IncidentDescription = model.IncidentDescription; // Incident Description
            IncidentIdentifier = model.IncidentIdentifier; // Incident Identifier
            IncidentReporterId = model.IncidentReporterId; // Reporter Identifier
            IncidentTime = model.IncidentTime; // Incident Time
            OrganizationPersonRoleId = model.OrganizationPersonRoleId; // 
            RefFirearmTypeId = model.RefFirearmTypeId; // Firearm Type
            RefIncidentBehaviorId = model.RefIncidentBehaviorId; // Incident Behavior
            RefIncidentBehaviorSecondaryId = model.RefIncidentBehaviorSecondaryId; // Secondary Incident Behavior
            RefIncidentInjuryTypeId = model.RefIncidentInjuryTypeId; // Incident Injury Type
            RefIncidentLocationId = model.RefIncidentLocationId; // Incident Location
            RefIncidentMultipleOffenseTypeId = model.RefIncidentMultipleOffenseTypeId; // Incident Multiple Offense Type
            RefIncidentPerpetratorInjuryTypeId = model.RefIncidentPerpetratorInjuryTypeId; // Incident Perpetrator Injury Type
            RefIncidentReporterTypeId = model.RefIncidentReporterTypeId; // Incident Reporter Type
            RefIncidentTimeDescriptionCodeId = model.RefIncidentTimeDescriptionCodeId; // Incident Time Description Code
            RefWeaponTypeId = model.RefWeaponTypeId; // Weapon Type
            RegulationViolatedDescription = model.RegulationViolatedDescription; // Incident Regulation Violated Description
            RelatedToDisabilityManifestationInd = model.RelatedToDisabilityManifestationInd; // Incident Related to Disability Manifestation
            ReportedToLawEnforcementInd = model.ReportedToLawEnforcementInd; // Incident Reported to Law Enforcement Indicator
            _isChanged = false;
            IsNew = false;
            IsBusy = false;
        }

        #region RefWeaponType List
        /// <summary>
        /// The complete <see cref="RefWeaponType"> List
        /// </summary>
        private static List<ReferenceModelBase> RefWeaponTypeList = new List<ReferenceModelBase>
        {
            new ReferenceModelBase { Id=Guid.Parse("88edba64-e242-40ae-bdd7-5c50c59b43f0"), Code="Firearm", Description="Firearm", Definition="Any weapon (including a starter gun) which will or is designed to or may readily be converted to expel a projectile by the action of an explosive;  the frame or receiver of any such weapon; any firearm muffler or firearm silencer; or any destructive device.", SortOrder=Convert.ToDecimal("0.00") },
            new ReferenceModelBase { Id=Guid.Parse("df289cdd-0d14-4bfa-a9eb-4749b98bd7d0"), Code="Handgun", Description="Handgun", Definition="Any firearm which has a short stock and is designed to be held and fired by the use of a single hand.", SortOrder=Convert.ToDecimal("2.00") },
            new ReferenceModelBase { Id=Guid.Parse("725bd940-c03b-48a0-b785-c2417e0adb50"), Code="Shotgun", Description="Shotgun", Definition="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the  energy of an explosive to fire through a smooth bore either a number of ball shots or a single projectile for each single pull of the trigger.", SortOrder=Convert.ToDecimal("4.00") },
            new ReferenceModelBase { Id=Guid.Parse("c6d6a971-aa24-41a8-88ee-d0332cf82807"), Code="Rifle", Description="Rifle", Definition="A weapon designed or redesigned, made or remade, and intended to be fired from the shoulder and designed or redesigned and made or remade to use the energy of an explosive to fire only a single projectile through a rifled bore for each single pull of the trigger.", SortOrder=Convert.ToDecimal("6.00") },
            new ReferenceModelBase { Id=Guid.Parse("32f76392-185b-4d9c-a8c6-584f8cf683c0"), Code="OtherFirearm", Description="Other Firearm", Definition="Other type of firearm", SortOrder=Convert.ToDecimal("8.00") },
            new ReferenceModelBase { Id=Guid.Parse("c0c919f2-66d2-40ce-b1c9-b49310cbb711"), Code="Knife", Description="Knife", Definition="The weapon involved was a knife.", SortOrder=Convert.ToDecimal("10.00") },
            new ReferenceModelBase { Id=Guid.Parse("3ac55eb3-2ae3-4d67-aea4-d002b4c18ce0"), Code="KnifeLessThanTwoPointFiveInches", Description="Knife Less Than 2.5 Inches", Definition="Knife with blade length less than 2.5 inches - the weapon involved was a knife with a blade less than 2.5 inches in length.", SortOrder=Convert.ToDecimal("12.00") },
            new ReferenceModelBase { Id=Guid.Parse("e703b904-e716-4237-8b39-f415b388e986"), Code="KnifeLessThanThreeInches", Description="Knife Less Than Three Inches", Definition="Knife with blade length less than 3 inches in length - the weapon involved was a knife with a blade at least 2.5 inches in length, but less than 3 inches in length.", SortOrder=Convert.ToDecimal("14.00") },
            new ReferenceModelBase { Id=Guid.Parse("5ec061ae-40ec-4755-b194-8588f19a0757"), Code="KnifeGreaterThanThreeInches", Description="Knife Greater Than Three Inches", Definition="Knife with blade length greater than or equal to 3 inches - the weapon involved was a knife with a blade 3 inches or greater in length.", SortOrder=Convert.ToDecimal("16.00") },
            new ReferenceModelBase { Id=Guid.Parse("6692b06a-b9c0-45c5-a9b9-1bc205606d90"), Code="OtherSharpObject", Description="Other sharp object", Definition="The weapon involved was another type of sharp object, (e.g., razor blade, ice pick, dirk, Chinese star, other pointed instrument [used as a weapon]).", SortOrder=Convert.ToDecimal("18.00") },
            new ReferenceModelBase { Id=Guid.Parse("3f4d18fb-ef2d-4fa6-af1d-a7c03f4eeb73"), Code="OtherObject", Description="Other object", Definition="The weapon involved was another known object (e.g., chain, nunchakus, brass knuckle, billy club, electrical weapon or device [stun gun], BB or pellet gun).", SortOrder=Convert.ToDecimal("20.00") },
            new ReferenceModelBase { Id=Guid.Parse("d616eaf2-ec42-4dfe-aab4-453f78712f1f"), Code="Substance", Description="Substance used as weapon", Definition="The weapon involved was a substance (e.g., mace, tear gas) that was used as a weapon.", SortOrder=Convert.ToDecimal("22.00") },
            new ReferenceModelBase { Id=Guid.Parse("d25fe323-df25-469e-bc96-d990ee074168"), Code="OtherWeapon", Description="Other weapon", Definition="The incident involved a weapon other than those described above.", SortOrder=Convert.ToDecimal("24.00") },
            new ReferenceModelBase { Id=Guid.Parse("5a0ad621-b9ca-4e66-8007-09409c775de3"), Code="None", Description="None", Definition="No weapon was used in the incident", SortOrder=Convert.ToDecimal("26.00") },
            new ReferenceModelBase { Id=Guid.Parse("123ef227-e7cd-4c9d-8adf-3c91d279c0c5"), Code="Unknown", Description="Unknown weapon", Definition="A weapon was used in the incident, but the type is unknown.", SortOrder=Convert.ToDecimal("28.00") },
        };
        #endregion
    }
}
