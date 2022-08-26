//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   ApplicationModel.cs
//***************************************************************************

using Autobahn.Common.Models;
using IApplication = Autobahn.Interfaces.Authorization.IApplication;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The Application Model
     /// </summary>
    public partial class ApplicationModel : AutobahnBase, IApplication
    {
        /// <summary>
        /// Authorization Application Name
        /// <para>
        /// The name of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20127">Authorization Application Name</a>
        /// </para>
        /// </summary>
        public System.String Name { get; set; }

        /// <summary>
        /// Authorization Application URI
        /// <para>
        /// The Uniform Resource Identifier (URI) of a data system or application which an authenticated person may access.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20128">Authorization Application URI</a>
        /// </para>
        /// </summary>
        public System.String Uri { get; set; }

    }
}
