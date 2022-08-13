//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12LeaTitleIIIProfessionalDevelopment.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaTitleIIIProfessionalDevelopment Interface
     /// </summary>
    public partial interface IK12LeaTitleIIIProfessionalDevelopment : IAutobahnBase
    {
        /// <summary>
        /// The type of Title III professional development utilized.
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// The type of Title III professional development utilized.
        /// </summary>
        Guid K12LEATitleIIIProfessionalDevelopmentId { get; set; }

        /// <summary>
        /// The type of Title III professional development utilized.
        /// </summary>
        Guid RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

    }
}
