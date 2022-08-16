//***************************************************************************
//* DomainName: Credentials Interfaces (used by both models and View Models
//* FileName:   ICredentialCriteriaCourse.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Credentials.Interfaces
{
     /// <summary>
     /// The ICredentialCriteriaCourse Interface
     /// </summary>
    public partial interface ICredentialCriteriaCourse : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
         RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid? RecordStartDateTime { get; set; }

    }
}
