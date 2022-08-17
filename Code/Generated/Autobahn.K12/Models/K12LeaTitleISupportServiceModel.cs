//**********************************************************
//* DomainName: Elementary and Secondary (K12)
//* FileName:   K12LeaTitleISupportServiceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.K12.Interfaces
{
     /// <summary>
     /// The K12LeaTitleISupportService Model
     /// </summary>
    public partial class K12LeaTitleISupportServiceModel : AutobahnBase, Interfaces.IK12LeaTitleISupportService
    {
        /// <summary>
        /// Charter School Indicator
        /// <para>
        /// An indication that a public school provides free public elementary and/or secondary education to eligible students under a specific charter executed, pursuant to a state charter school law, by an authorized chartering agency/authority and that is designated by such authority to be a public charter school.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19039">Charter School Indicator</a>
        /// </para>
        /// </summary>
        public Guid K12LeaId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefK12LeaTitleISupportService"/> model
        /// </summary>
        public Guid RefK12LeaTitleISupportServiceId { get; set; }

    }
}
