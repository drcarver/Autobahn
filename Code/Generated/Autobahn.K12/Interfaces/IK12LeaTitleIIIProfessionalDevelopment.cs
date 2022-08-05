//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   IK12LeaTitleIIIProfessionalDevelopment.cs
//**********************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The IK12LeaTitleIIIProfessionalDevelopment
     /// </summary>
    public partial interface IK12LeaTitleIIIProfessionalDevelopment : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="K12LEATitleIIIProfessionalDevelopment"/> model
        /// </summary>
        Guid K12LEATitleIIIProfessionalDevelopmentId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="K12Lea"/> model
        /// </summary>
        Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefTitleIIIProfessionalDevelopmentType"/> model
        /// </summary>
        Guid RefTitleIIIProfessionalDevelopmentTypeId { get; set; }

    }
}
