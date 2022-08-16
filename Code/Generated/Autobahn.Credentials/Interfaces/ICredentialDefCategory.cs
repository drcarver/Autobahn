//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialDefCategory.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialDefCategory Interface
     /// </summary>
    public partial interface ICredentialDefCategory : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Category { get; set; }

        /// <summary>
        /// 
        /// </summary>
         CategorySystem { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RecordStartDateTime { get; set; }

    }
}
