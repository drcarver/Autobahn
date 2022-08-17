//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12Lea.cs
//* Name:       Charter School Indicator
//* Definition: 
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// 
     /// </summary>
    public partial interface IK12Lea : IAutobahnBase
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
        System.Boolean? CharterSchoolIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefCharterLeaStatus"/> model
        /// </summary>
        Guid? RefCharterLeaStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLeaImprovementStatus"/> model
        /// </summary>
        Guid? RefLeaImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLEAImprovementStatus"/> model
        /// </summary>
         RefLEAImprovementStatusId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefLeaType"/> model
        /// </summary>
        Guid? RefLeaTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPublicSchoolChoiceStatus"/> model
        /// </summary>
        Guid? RefPublicSchoolChoiceStatusId { get; set; }

        /// <summary>
        /// Local Education Agency Supervisory Union Identification Number
        /// <para>
        /// The three-digit unique identifier assigned to the supervisory union by the state.  
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19175">Local Education Agency Supervisory Union Identification Number</a>
        /// </para>
        /// </summary>
        System.String SupervisoryUnionIdentificationNumber { get; set; }

    }
}
