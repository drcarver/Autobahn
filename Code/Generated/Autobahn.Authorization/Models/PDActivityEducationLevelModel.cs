//**********************************************************
//* DomainName: Authentication and Authorization
//* FileName:   PDActivityEducationLevelModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Authorization.Models
{
     /// <summary>
     /// The PDActivityEducationLevel Model
     /// </summary>
    public partial class PDActivityEducationLevelModel : AutobahnBase, Interfaces.IPDActivityEducationLevel
    {
        /// <summary>
        /// An age group or education level to which the professional development activity's content pertains.
        /// </summary>
        public Guid ProfessionalDevelopmentActivityId { get; set; }

        /// <summary>
        /// An age group or education level to which the professional development activity's content pertains.
        /// </summary>
        public Guid RefPDActivityEducationLevelsAddressedId { get; set; }

    }
}
