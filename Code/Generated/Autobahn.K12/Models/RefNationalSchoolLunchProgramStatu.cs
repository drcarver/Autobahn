//**********************************************************
//* DomainName: Autobahn.K12
//* FileName:   RefNationalSchoolLunchProgramStatu.cs
//**********************************************************

using Autobahn.Common.Models;
using Autobahn.K12.Interfaces;

namespace Autobahn.K12.Models
{
     /// <summary>
     /// The RefNationalSchoolLunchProgramStatu Model
     /// </summary>
    public partial class RefNationalSchoolLunchProgramStatu : ReferenceModelBase, IRefNationalSchoolLunchProgramStatu
    {
        /// <summary>
        /// Reference to a required instance of the <see cref="RefNationalSchoolLunchProgramStatus"/> model
        /// </summary>
        public Guid RefNationalSchoolLunchProgramStatusId { get; set; }

    }
}
