//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationPopulationServed.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationPopulationServed Interface
     /// </summary>
    public partial interface IOrganizationPopulationServed : IAutobahnBase
    {
        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        System.String AgeUnit { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        Guid? RefPopulationServedId { get; set; }

        /// <summary>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </summary>
        System.Int32? YoungestAgeServed { get; set; }

    }
}
