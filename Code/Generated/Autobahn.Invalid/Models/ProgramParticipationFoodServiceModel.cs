//**********************************************************
//* DomainName: Invalid or Unreferenced Models
//* FileName:   ProgramParticipationFoodServiceModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Invalid.Models
{
     /// <summary>
     /// The ProgramParticipationFoodService Model
     /// </summary>
    public partial class ProgramParticipationFoodServiceModel : AutobahnBase, Interfaces.IProgramParticipationFoodService
    {
        /// <summary>
        /// An indication of a student's participation in free, reduced price, full price breakfast, lunch, snack, supper, and milk programs.
        /// </summary>
        public Guid RefSchoolFoodServiceProgramId { get; set; }

    }
}
