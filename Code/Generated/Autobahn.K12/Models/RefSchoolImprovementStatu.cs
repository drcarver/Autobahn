//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefSchoolImprovementStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefSchoolImprovementStatu Model
     /// </summary>
    public partial class RefSchoolImprovementStatu : ReferenceModelBase, IRefSchoolImprovementStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefSchoolImprovementStatus"/> model
        /// </summary>
        public Guid RefSchoolImprovementStatusId { get; set; }

    }
}
