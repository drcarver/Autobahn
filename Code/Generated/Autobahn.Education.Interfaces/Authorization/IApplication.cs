//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IApplication.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Interfaces.Authorization
{
     /// <summary>
     /// The IApplication Interface
     /// </summary>
    public partial interface IApplication : IAutobahnBase
    {
        #region IApplication
        /// <summary>
        /// Authorization Application Name
        /// <para>
        /// The name of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20127">Authorization Application Name</a>
        /// </para>
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Authorization Application URI
        /// <para>
        /// The Uniform Resource Identifier (URI) of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20128">Authorization Application URI</a>
        /// </para>
        /// </summary>
        System.String Uri { get; set; }

        #endregion
    }
}
