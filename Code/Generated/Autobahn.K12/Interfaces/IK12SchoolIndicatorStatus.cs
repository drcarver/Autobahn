//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12SchoolIndicatorStatus.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12SchoolIndicatorStatus Interface
     /// </summary>
    public partial interface IK12SchoolIndicatorStatus : IAutobahnBase
    {
        System.String IndicatorStatus { get; set; }

        System.String IndicatorStatusSubgroup { get; set; }

        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndicatorStateDefinedStatus"/> model
        /// </summary>
        Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndicatorStatusCustomType"/> model
        /// </summary>
        Guid? RefIndicatorStatusCustomTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndicatorStatusSubgroupType"/> model
        /// </summary>
        Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefIndicatorStatusType"/> model
        /// </summary>
        Guid RefIndicatorStatusTypeId { get; set; }

    }
}
