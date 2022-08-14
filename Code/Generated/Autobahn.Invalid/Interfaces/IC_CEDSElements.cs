//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IC_CEDSElements.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IC_CEDSElements Interface
     /// </summary>
    public partial interface IC_CEDSElements : IAutobahnBase
    {
        /// <summary>
        /// 
        /// </summary>
        System.String AltName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.String ChangedInThisVersionInd { get; set; }

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
        System.String GlobalID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.Boolean HasOptionSet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        System.Int32 TermID { get; set; }

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
