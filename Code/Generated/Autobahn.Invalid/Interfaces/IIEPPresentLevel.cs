//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IIEPPresentLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IIEPPresentLevel Interface
     /// </summary>
    public partial interface IIEPPresentLevel : IAutobahnBase
    {
        /// <summary>
        /// How the child's disability affects the child's academic achievement.
        /// </summary>
        System.String AcademicDescription { get; set; }

    }
}
