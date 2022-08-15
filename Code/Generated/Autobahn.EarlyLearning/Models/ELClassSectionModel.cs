//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELClassSection Model
     /// </summary>
    public partial class ELClassSectionModel : AutobahnBase, Interfaces.IELClassSection
    {
        /// <summary>
        /// Nature of early childhood program, class or group in which a person is enrolled.
        /// </summary>
        public Guid? RefServiceOptionId { get; set; }

    }
}
