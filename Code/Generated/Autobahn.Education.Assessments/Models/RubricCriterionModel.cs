//**********************************************************
//* DomainName: Assessments
//* FileName:   RubricCriterionModel.cs
//***************************************************************************

using Autobahn.Education.Interfaces.Assessments;

namespace Autobahn.Education.Assessments.Models
{
     /// <summary>
     /// The RubricCriterion Model
     /// </summary>
    public partial class RubricCriterionModel : IRubricCriterion
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

        #region IRubricCriterion
        /// <summary>
        /// Rubric Criterion Category
        /// <para>
        /// A textual label for category by which Rubric Criterion may be grouped.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20441">Rubric Criterion Category</a>
        /// </para>
        /// </summary>
        public System.String Category { get; set; }

        /// <summary>
        /// Rubric Criterion Position
        /// <para>
        /// A numeric value representing this criterion's position in the criteria list for this rubric.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20448">Rubric Criterion Position</a>
        /// </para>
        /// </summary>
        public Int32? Position { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRubric"/> model
        /// </summary>
        public Guid RubricId { get; set; }

        /// <summary>
        /// Rubric Criterion Title
        /// <para>
        /// The title of the rubric criterion.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20449">Rubric Criterion Title</a>
        /// </para>
        /// </summary>
        public System.String Title { get; set; }

        /// <summary>
        /// Rubric Criterion Weight
        /// <para>
        /// A numeric weight assigned to this Rubric Criterion, used for scored rubrics.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20450">Rubric Criterion Weight</a>
        /// </para>
        /// </summary>
        public Decimal? Weight { get; set; }

        #endregion
    }
}
