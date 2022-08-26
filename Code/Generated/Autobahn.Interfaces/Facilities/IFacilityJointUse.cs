//***************************************************************************
//* DomainName: Facilities Interfaces (used by both models and View Models
//* FileName:   IFacilityJointUse.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.Facilities
{
     /// <summary>
     /// The IFacilityJointUse Interface
     /// </summary>
    public partial interface IFacilityJointUse : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IFacility"/> model
        /// </summary>
        Guid FacilityId { get; set; }

        /// <summary>
        /// Building Joint Use Rationale Type
        /// <para>
        /// The reasons for permitting and participating in joint-use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20833">Building Joint Use Rationale Type</a>
        /// </para>
        /// </summary>
        Guid? RefBuildingJointUseRationaleTypeId { get; set; }

        /// <summary>
        /// Building Joint User Type
        /// <para>
        /// The types of users sharing school district controlled, owned, or utilized facilities.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20835">Building Joint User Type</a>
        /// </para>
        /// </summary>
        Guid? RefBuildingJointUserTypeId { get; set; }

        /// <summary>
        /// Building Joint Use Scheduling Type
        /// <para>
        /// The type of designation of non school district users by the amount of time they have access to public school for joint use.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20834">Building Joint Use Scheduling Type</a>
        /// </para>
        /// </summary>
        Guid? RefBuildingJointUseSchedulingTypeId { get; set; }

    }
}
