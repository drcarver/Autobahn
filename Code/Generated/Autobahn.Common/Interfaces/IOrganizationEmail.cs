//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IOrganizationEmail.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IOrganizationEmail
     /// </summary>
    public partial interface IOrganizationEmail : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="Organization"/> model
        /// </summary>
        Guid OrganizationId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmail.ElectronicMailAddress non nullable property
        /// </summary>
        System.String ElectronicMailAddress { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefEmailType"/> model
        /// </summary>
        Guid? RefEmailTypeId { get; set; }

        /// <summary>
        /// Defines the OrganizationEmail.DoNotPublishIndicator nullable property
        /// </summary>
        System.Boolean? DoNotPublishIndicator { get; set; }

    }
}
