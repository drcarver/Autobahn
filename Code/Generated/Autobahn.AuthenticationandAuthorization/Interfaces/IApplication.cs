//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   IApplication.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AuthenticationandAuthorization.Interfaces
{
     /// <summary>
     /// The IApplication
     /// </summary>
    public partial interface IApplication : IAutobahnBase
    {
        /// <summary>
        /// Defines the Application.Name non nullable property
        /// </summary>
        System.String Name { get; set; }

        /// <summary>
        /// Defines the Application.Uri non nullable property
        /// </summary>
        System.String Uri { get; set; }

    }
}
