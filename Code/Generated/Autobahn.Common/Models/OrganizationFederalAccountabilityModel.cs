//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationFederalAccountabilityModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationFederalAccountability Model
     /// </summary>
    public partial class OrganizationFederalAccountabilityModel : AutobahnBase, Interfaces.IOrganizationFederalAccountability
    {
        /// <summary>
        /// The title of the accountability report.
        /// </summary>
        public System.String AccountabilityReportTitle { get; set; }

    }
}
