//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   IPDActivityEducationLevelModel.cs
//**********************************************************


namespace Autobahn.Common.Interfaces
{
     /// <summary>
     /// The IPDActivityEducationLevelModel Interface
     /// </summary>
    public partial interface IPDActivityEducationLevelModel : IAutobahnBase
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
