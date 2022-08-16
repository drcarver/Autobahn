//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IApplication.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IApplication Interface
     /// </summary>
    public partial interface IApplication : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         Uri { get; set; }

    }
}
