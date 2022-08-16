//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IAutobahnElement.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IAutobahnElement Interface
     /// </summary>
    public partial interface IAutobahnElement : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        System.String AltName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnDomainList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.Collections.Generic.List`1[System.Nullable`1[System.Guid]] AutobahnTableList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String ChangeNotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String ElementName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String Format { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid GlobalId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String HasOptionSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        Guid Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String TechnicalName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String TermID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String URL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String UsageNotes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String Version { get; set; }

    }
}
