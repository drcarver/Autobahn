//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationAccreditation.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationAccreditation Interface
     /// </summary>
    public partial interface IOrganizationAccreditation : IAutobahnBase
    {
        /// <summary>
        /// An indication of the accreditation status of a higher education institution.
        /// </summary>
        Guid? RefHigherEducationInstitutionAccreditationStatusId { get; set; }

    }
}
