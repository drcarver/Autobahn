//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Common;

namespace Autobahn.Education.Common.Models
{
     /// <summary>
     /// The PersonHealthBirth Model
     /// </summary>
    public partial class PersonHealthBirthModel : IPersonHealthBirth
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

        #region IPersonHealthBirth
        /// <summary>
        /// Multiple Birth Indicator
        /// <para>
        /// An indication that the person is a twin, triplet, etc.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19421">Multiple Birth Indicator</a>
        /// </para>
        /// </summary>
        public Boolean? MultipleBirthIndicator { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IPerson"/> model
        /// </summary>
        public Guid PersonId { get; set; }

        /// <summary>
        /// Trimester When Prenatal Care Began
        /// <para>
        /// The trimester of pregnancy in which a child's mother began receiving prenatal health care.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20611">Trimester When Prenatal Care Began</a>
        /// </para>
        /// </summary>
        public Guid? RefTrimesterWhenPrenatalCareBeganId { get; set; }

        /// <summary>
        /// Weeks of Gestation
        /// <para>
        /// The number of weeks during gestational period.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19313">Weeks of Gestation</a>
        /// </para>
        /// </summary>
        public Int32? WeeksOfGestation { get; set; }

        /// <summary>
        /// Weight at Birth
        /// <para>
        /// The weight of a child at birth in pounds and ounces.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19312">Weight at Birth</a>
        /// </para>
        /// </summary>
        public System.String WeightAtBirth { get; set; }

        #endregion
    }
}