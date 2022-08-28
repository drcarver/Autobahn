//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAuthentication.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Authorization
{
     /// <summary>
     /// The IAuthentication Interface
     /// </summary>
    public partial interface IAuthentication : IAutobahnBase
    {
        #region IAuthentication
        /// <summary>
        /// Authentication Identity Provider End Date
        /// <para>
        /// The date after which the  an associated person is no longer allowed to use the specified Authentication Identity Provider to authenticate identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20126">Authentication Identity Provider End Date</a>
        /// </para>
        /// </summary>
        DateTime? EndDate { get; set; }

        /// <summary>
        /// Authentication Identity Provider Name
        /// <para>
        /// The name of a provider that can authenticate the identity of an person.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20122">Authentication Identity Provider Name</a>
        /// </para>
        /// </summary>
        System.String IdentityProviderName { get; set; }

        /// <summary>
        /// Authentication Identity Provider URI
        /// <para>
        /// The Uniform Resource Identifier (URI) of the  Authentication Identity Provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20123">Authentication Identity Provider URI</a>
        /// </para>
        /// </summary>
        System.String IdentityProviderUri { get; set; }

        /// <summary>
        /// Authentication Identity Provider Login Identifier
        /// <para>
        /// The login identifier for the person for the specified Authentication Identity Provider.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20124">Authentication Identity Provider Login Identifier</a>
        /// </para>
        /// </summary>
        System.String LoginIdentifier { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganizationPersonRole"/> model
        /// </summary>
        Guid OrganizationPersonRoleId { get; set; }

        /// <summary>
        /// Authentication Identity Provider Start Date
        /// <para>
        /// The date on which the  an associated person may begin to use the specified Authentication Identity Provider to authenticate identity.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20125">Authentication Identity Provider Start Date</a>
        /// </para>
        /// </summary>
        DateTime? StartDate { get; set; }

        #endregion
    }
}
