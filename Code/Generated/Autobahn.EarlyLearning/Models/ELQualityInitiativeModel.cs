//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELQualityInitiativeModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELQualityInitiative Model
     /// </summary>
    public partial class ELQualityInitiativeModel : AutobahnBase, Interfaces.IELQualityInitiative
    {
        /// <summary>
        /// An indication of whether a program uses a health or safety checklist or documentation.
        /// </summary>
        public System.Boolean? ProgramHeathSafetyChecklistUseStatus { get; set; }

    }
}
