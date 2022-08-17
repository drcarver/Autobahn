//***************************************************************************
//* DomainName: Authentication and Authorization Interfaces (used by both models and View Models
//* FileName:   IAutobahnElement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Authorization.Interfaces
{
     /// <summary>
     /// The IAutobahnElement Interface
     /// </summary>
    public partial interface IAutobahnElement : IAutobahnBase
    {
        System.String AltName { get; set; }

        System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnDomainList { get; set; }

        System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnTableList { get; set; }

        System.String ChangeNotes { get; set; }

        System.String ElementName { get; set; }

        System.String Format { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IGlobal"/> model
        /// </summary>
        Guid GlobalId { get; set; }

        System.String HasOptionSet { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="I"/> model
        /// </summary>
        Guid Id { get; set; }

        System.String TechnicalName { get; set; }

        System.String TermID { get; set; }

        System.String URL { get; set; }

        System.String UsageNotes { get; set; }

        System.String Version { get; set; }

    }
}
