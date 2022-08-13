//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The OrganizationPopulationServed Model
     /// </summary>
    public partial class OrganizationPopulationServedModel : AutobahnBase, Interfaces.IOrganizationPopulationServed
    {
        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.String AgeUnit { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public Guid? RefPopulationServedId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        public System.Int32? YoungestAgeServed { get; set; }

    }
}
