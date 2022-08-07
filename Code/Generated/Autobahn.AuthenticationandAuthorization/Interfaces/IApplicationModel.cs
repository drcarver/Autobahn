//**********************************************************
//* DomainName: Autobahn.AuthenticationandAuthorization
//* FileName:   IApplicationModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.AuthenticationandAuthorization.Interfaces
{
     /// <summary>
     /// The IApplicationModel Interface
     /// </summary>
    public partial interface IApplicationModel : IAutobahnBase
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
