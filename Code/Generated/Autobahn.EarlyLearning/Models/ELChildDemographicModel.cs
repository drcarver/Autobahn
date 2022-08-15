//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELChildDemographicModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELChildDemographic Model
     /// </summary>
    public partial class ELChildDemographicModel : AutobahnBase, Interfaces.IELChildDemographic
    {
        /// <summary>
        /// Race other than American Indian, Black, Asian, White, Native Pacific Islander
        /// </summary>
        public System.Boolean? OtherRaceIndicator { get; set; }

    }
}
