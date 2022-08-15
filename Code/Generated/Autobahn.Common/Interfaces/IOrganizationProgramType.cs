//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationProgramType.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationProgramType Interface
     /// </summary>
    public partial interface IOrganizationProgramType : IAutobahnBase
    {
        /// <summary>
        /// The system outlining instructional or non-instructional activities and procedures designed to accomplish a predetermined educational objective or set of objectives or to provide support services to a person and/or the community.
        /// </summary>
        Guid RefProgramTypeId { get; set; }

    }
}
