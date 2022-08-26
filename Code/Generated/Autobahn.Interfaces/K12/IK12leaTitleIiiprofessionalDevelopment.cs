//***************************************************************************
//* DomainName: Elementary and Secondary (K12) Interfaces (used by both models and View Models
//* FileName:   IK12leaTitleIiiprofessionalDevelopment.cs
//***************************************************************************

using Autobahn.Interfaces.Common;

namespace Autobahn.Interfaces.K12
{
     /// <summary>
     /// The IK12leaTitleIiiprofessionalDevelopment Interface
     /// </summary>
    public partial interface IK12leaTitleIiiprofessionalDevelopment : IAutobahnBase
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12lea"/> model
        /// </summary>
        Guid K12leaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IK12leatitleIiiprofessionalDevelopment"/> model
        /// </summary>
        Guid K12leatitleIiiprofessionalDevelopmentId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefTitleIiiprofessionalDevelopmentType"/> model
        /// </summary>
        Guid RefTitleIiiprofessionalDevelopmentTypeId { get; set; }

    }
}
