//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELEnrollmentOtherFundingModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The ELEnrollmentOtherFunding Model
     /// </summary>
    public partial class ELEnrollmentOtherFundingModel : AutobahnBase, Interfaces.IELEnrollmentOtherFunding
    {
        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Early Learning Other Federal Funding Sources
        /// <para>
        /// The other contributing funding sources.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20302">Early Learning Other Federal Funding Sources</a>
        /// </para>
        /// </summary>
        public Guid RefELOtherFederalFundingSourcesId { get; set; }

    }
}
