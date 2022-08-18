//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaModel.cs
//* Name:       Charter School Indicator
//* Definition: An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
     /// </summary>
    public partial class K12LeaModel : AutobahnBase, Interfaces.IK12Lea
    {
        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefCharterLeaStatus"/> model
        /// </summary>
        public Guid? RefCharterLeaStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaImprovementStatus"/> model
        /// </summary>
        public Guid? RefLeaImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefLeaType"/> model
        /// </summary>
        public Guid? RefLeaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefPublicSchoolChoiceStatus"/> model
        /// </summary>
        public Guid? RefPublicSchoolChoiceStatusId { get; set; }

        /// <summary>
        /// Local Education Agency Supervisory Union Identification Number
        /// <para>
        /// The three-digit unique identifier assigned to the supervisory union by the state.  
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19175">Local Education Agency Supervisory Union Identification Number</a>
        /// </para>
        /// </summary>
        public System.String SupervisoryUnionIdentificationNumber { get; set; }

    }
}
