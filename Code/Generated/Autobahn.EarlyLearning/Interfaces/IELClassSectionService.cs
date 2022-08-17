//***************************************************************************
//* DomainName: Early Learning (EL) Interfaces (used by both models and View Models
//* FileName:   IELClassSectionService.cs
//***************************************************************************

using Autobahn.Common.Interfaces;

namespace Autobahn.EarlyLearning.Interfaces
{
     /// <summary>
     /// The IELClassSectionService Interface
     /// </summary>
    public partial interface IELClassSectionService : IAutobahnBase
    {
        /// <summary>
        /// Early Learning Class Group Curriculum Type
        /// <para>
        /// The type of curriculum used in an early learning classroom or group.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19822">Early Learning Class Group Curriculum Type</a>
        /// </para>
        /// </summary>
        System.String ELClassGroupCurriculumType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IELClassSection"/> model
        /// </summary>
        Guid ELClassSectionId { get; set; }

        /// <summary>
        /// Early Learning Oldest Age Authorized to Serve
        /// <para>
        /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefELGroupSizeStandardMet"/> model
        /// </summary>
        Guid? RefELGroupSizeStandardMetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IRefFrequencyOfService"/> model
        /// </summary>
        Guid? RefFrequencyOfServiceId { get; set; }

        /// <summary>
        /// Serves Children with Special Needs
        /// <para>
        /// An indication of whether a class or group serves children with special needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19821">Serves Children with Special Needs</a>
        /// </para>
        /// </summary>
        System.Boolean? ServesChildrenWithSpecialNeeds { get; set; }

        /// <summary>
        /// Early Learning Youngest Age Authorized to Serve
        /// <para>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        System.Int32? YoungestAgeServed { get; set; }

    }
}
