//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationIndicatorModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationIndicator Model
     /// </summary>
    public partial class OrganizationIndicatorModel : AutobahnBase, Interfaces.IOrganizationIndicator
    {
        /// <summary>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </summary>
        public System.String IndicatorValue { get; set; }

        /// <summary>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// An indication of whether the school has students who are ability grouped for classroom instruction in mathematics or English/reading/language arts.
        /// </summary>
        public Guid RefOrganizationIndicatorId { get; set; }

    }
}
