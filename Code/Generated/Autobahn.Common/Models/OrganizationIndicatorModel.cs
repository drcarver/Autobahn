//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorModel.cs
//***************************************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIndicator Model
     /// </summary>
    public partial class OrganizationIndicatorModel : AutobahnBase, Interfaces.IOrganizationIndicator
    {
        public System.String IndicatorValue { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefOrganizationIndicator"/> model
        /// </summary>
        public Guid RefOrganizationIndicatorId { get; set; }

    }
}
