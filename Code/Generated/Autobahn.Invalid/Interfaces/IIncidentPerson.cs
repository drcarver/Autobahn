//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIncidentPerson.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIncidentPerson Interface
     /// </summary>
    public partial interface IIncidentPerson : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        Guid? Identifier { get; set; }

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
         RefIncidentPersonRoleTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
         RefIncidentPersonTypeId { get; set; }

    }
}
