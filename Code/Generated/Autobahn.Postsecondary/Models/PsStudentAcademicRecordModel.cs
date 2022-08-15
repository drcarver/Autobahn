//**********************************************************
//* DomainName: Postsecondary (PS)
//* FileName:   PsStudentAcademicRecordModel.cs
//**********************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.Postsecondary.Models
{
     /// <summary>
     /// The PsStudentAcademicRecord Model
     /// </summary>
    public partial class PsStudentAcademicRecordModel : AutobahnBase, Interfaces.IPsStudentAcademicRecord
    {
        /// <summary>
        /// The number of credits awarded a student by the postsecondary institution based on successful completion of advanced placement courses and/or advanced placement tests. 
        /// </summary>
        public System.Int32? AdvancedPlacementCreditsAwarded { get; set; }

    }
}
