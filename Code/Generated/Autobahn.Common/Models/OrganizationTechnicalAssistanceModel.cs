//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTechnicalAssistanceModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTechnicalAssistance Model
     /// </summary>
    public partial class OrganizationTechnicalAssistanceModel : AutobahnBase, Interfaces.IOrganizationTechnicalAssistance
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceDeliveryType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTechnicalAssistanceType"/> model
        /// </summary>
        public Guid? RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// Technical Assistance Approved Indicator
        /// <para>
        /// Indicates whether or not the technical assistance was approved.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20465">Technical Assistance Approved Indicator</a>
        /// </para>
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

    }
}
