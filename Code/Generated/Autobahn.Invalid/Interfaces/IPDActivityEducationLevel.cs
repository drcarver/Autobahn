//***************************************************************************
//* DomainName: Invalid or Unreferenced Models Interfaces (used by both models and View Models
//* FileName:   IPDActivityEducationLevel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.Invalid.Interfaces
{
     /// <summary>
     /// The IPDActivityEducationLevel Interface
     /// </summary>
    public partial interface IPDActivityEducationLevel : IAutobahnBase
    {
        /// <summary>
        /// An age group or education level to which the professional development activity's content pertains.
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// An age group or education level to which the professional development activity's content pertains.
        /// </summary>
        Guid RefPDActivityEducationLevelsAddressedId { get; set; }

    }
}
