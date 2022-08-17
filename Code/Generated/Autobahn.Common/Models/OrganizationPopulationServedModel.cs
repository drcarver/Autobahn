//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationPopulationServedModel.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The OrganizationPopulationServed Model
     /// </summary>
    public partial class OrganizationPopulationServedModel : AutobahnBase, Interfaces.IOrganizationPopulationServed
    {
        public System.String AgeUnit { get; set; }

        /// <summary>
        /// Early Learning Oldest Age Authorized to Serve
        /// <para>
        /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        public System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefPopulationServed"/> model
        /// </summary>
        public Guid? RefPopulationServedId { get; set; }

        /// <summary>
        /// Early Learning Youngest Age Authorized to Serve
        /// <para>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        public System.Int32? YoungestAgeServed { get; set; }

    }
}
