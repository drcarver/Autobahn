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
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTechnicalAssistanceDeliveryTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefTechnicalAssistanceTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? TechnicalAssistanceApprovedInd { get; set; }

    }
}
