//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IIndividualizedProgram.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IIndividualizedProgram Interface
     /// </summary>
    public partial interface IIndividualizedProgram : IAutobahnBase
    {
        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.Int32? InclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.Boolean? InclusiveSettingIndicator { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.DateTime? IndividualizedProgramDate { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.Int32? NonInclusionMinutesPerWeek { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.Int32? RefIndividualizedProgramDateType { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        Guid? RefIndividualizedProgramLocationId { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        Guid? RefIndividualizedProgramTransitionTypeId { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        Guid? RefIndividualizedProgramTypeId { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        Guid? RefStudentSupportServiceTypeId { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.DateTime? ServicePlanDate { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.DateTime? ServicePlanEndDate { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.String ServicePlanMeetingParticipants { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.DateTime? ServicePlanReevaluationDate { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.DateTime? ServicePlanSignatureDate { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.String ServicePlanSignedBy { get; set; }

        /// <summary>
        /// Type of related or ancillary services offered or provided to a person or a group of persons within the formal educational system or by an outside agency which provides non-instructional services to support the general welfare of students. This includes physical and emotional health, the ability to select an appropriate course of study, admission to appropriate educational programs, and the ability to adjust to and remain in school through the completion of programs. In serving a student with an identified disability, related services include developmental, corrective, or supportive services required to ensure that the person benefits from special education.
        /// </summary>
        System.String TransferOfRightsStatement { get; set; }

    }
}
