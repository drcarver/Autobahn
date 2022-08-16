//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationEmployeeBenefit Model
     /// </summary>
    public partial class OrganizationEmployeeBenefitModel : AutobahnBase, Interfaces.IOrganizationEmployeeBenefit
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PartTimeBenefitIndicator { get; set; }

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
        public  RefEmployeeBenefitId { get; set; }

    }
}
