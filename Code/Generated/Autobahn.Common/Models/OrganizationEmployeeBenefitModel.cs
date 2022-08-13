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
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </summary>
        public System.Boolean? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </summary>
        public System.Boolean? PartTimeBenefitIndicator { get; set; }

        /// <summary>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </summary>
        public Guid? RefEmployeeBenefitId { get; set; }

    }
}
