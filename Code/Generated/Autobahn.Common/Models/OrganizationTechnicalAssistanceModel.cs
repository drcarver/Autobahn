//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationTechnicalAssistanceModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationTechnicalAssistance Model
     /// </summary>
    public partial class OrganizationTechnicalAssistanceModel : AutobahnBase, Interfaces.IOrganizationTechnicalAssistance
    {
        /// <summary>
        /// Indicates whether or not the technical assistance was approved.
        /// </summary>
        public System.Boolean? TechnicalAssistanceApprovedInd { get; set; }

    }
}
