//**********************************************************
//* DomainName: Common Models
//* FileName:   OrganizationEmployeeBenefitModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The OrganizationEmployeeBenefit Model
     /// </summary>
    public partial class OrganizationEmployeeBenefitModel : IOrganizationEmployeeBenefit
    {
        // Concrete implementation of IAutobahnBase
        #region IAutobahnBase
        /// <summary>
        /// Gets the model's changed status.
        /// </summary>
        public bool IsChanged { get; private set; } = false;

        /// <summary>
        /// Resets the model's state to unchanged by accepting the modifications.
        /// </summary>
        public void AcceptChanges()
        {
             IsChanged = false;
             IsNew = false;
        }

        /// <summary>
        /// True if the model is new and unsaved.
        /// </summary>
        public bool IsNew { get; set; } =  false;

        /// <summary>
        /// Is it a deleted model?
        /// </summary>
        public bool IsDeleted { get; set; } = false;

        /// <summary>
        /// The Id of the Model
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();
        #endregion

        #region IOrganizationEmployeeBenefit
        /// <summary>
        /// Full-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        public Boolean? FullTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IOrganization"/> model
        /// </summary>
        public Guid OrganizationId { get; set; }

        /// <summary>
        /// Part-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for part-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19867">Part-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        public Boolean? PartTimeBenefitIndicator { get; set; }

        /// <summary>
        /// Full-Time Employee Benefits
        /// <para>
        /// The benefits offered by a program/facility/employer for full-time staff.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19866">Full-Time Employee Benefits</a>
        /// </para>
        /// </summary>
        public Guid? RefEmployeeBenefitId { get; set; }

        #endregion
    }
}
