//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12SchoolIndicatorStatusModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The K12SchoolIndicatorStatus Model
     /// </summary>
    public partial class K12SchoolIndicatorStatusModel : AutobahnBase, Interfaces.IK12SchoolIndicatorStatus
    {
        public System.String IndicatorStatus { get; set; }

        public System.String IndicatorStatusSubgroup { get; set; }

        /// <summary>
        /// Accreditation Agency Name
        /// <para>
        /// The full name of an agency that accredited a school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20500">Accreditation Agency Name</a>
        /// </para>
        /// </summary>
        public Guid K12SchoolId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStateDefinedStatus"/> model
        /// </summary>
        public Guid? RefIndicatorStateDefinedStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusCustomType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusCustomTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusSubgroupType"/> model
        /// </summary>
        public Guid? RefIndicatorStatusSubgroupTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefIndicatorStatusType"/> model
        /// </summary>
        public Guid RefIndicatorStatusTypeId { get; set; }

    }
}
