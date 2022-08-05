//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPDActivityEducationLevel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPDActivityEducationLevel
     /// </summary>
    public partial interface IPDActivityEducationLevel : IAutobahnBase
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="ProfessionalDevelopmentActivity"/> model
        /// </summary>
        Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// Reference to a required instance of the <see cref="RefPDActivityEducationLevelsAddressed"/> model
        /// </summary>
        Guid RefPDActivityEducationLevelsAddressedId { get; set; }

    }
}
