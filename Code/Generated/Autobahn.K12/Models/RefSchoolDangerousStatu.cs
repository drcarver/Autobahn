//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSchoolDangerousStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefSchoolDangerousStatu Model
     /// </summary>
    public partial class RefSchoolDangerousStatu : ReferenceModelBase, IRefSchoolDangerousStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolDangerousStatus"/> model
        /// </summary>
        public Guid RefSchoolDangerousStatusId { get; set; }

    }
}
