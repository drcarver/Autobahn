//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IIDSVersion.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IIDSVersion Interface
     /// </summary>
    public partial interface IIDSVersion : IAutobahnBase
    {
        System.Boolean CurrentVersion { get; set; }

        System.DateTime IDSVersionDate { get; set; }

        System.String IDSVersionNumber { get; set; }

    }
}
