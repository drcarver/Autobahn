//***************************************************************************
//* DomainName: Common Models Interfaces (used by both models and View Models
//* FileName:   IOrganizationEmail.cs
//***************************************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationEmail Interface
     /// </summary>
    public partial interface IOrganizationEmail : IAutobahnBase
    {
        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        System.String ElectronicMailAddress { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// The numbers, letters, and symbols used to identify an electronic mail (e-mail) user within the network to which the person or organization belongs.
        /// </summary>
        Guid? RefEmailTypeId { get; set; }

    }
}
