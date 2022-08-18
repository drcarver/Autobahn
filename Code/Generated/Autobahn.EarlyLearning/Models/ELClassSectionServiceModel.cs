//**********************************************************
//* DomainName: Early Learning (EL)
//* FileName:   ELClassSectionServiceModel.cs
//***************************************************************************

using Autobahn.Common.Interfaces;
using Autobahn.Common.Models;

namespace Autobahn.EarlyLearning.Models
{
     /// <summary>
     /// The ELClassSectionService Model
     /// </summary>
    public partial class ELClassSectionServiceModel : AutobahnBase, Interfaces.IELClassSectionService
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
        public System.String ELClassGroupCurriculumType { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="IELClassSection"/> model
        /// </summary>
        public Guid ELClassSectionId { get; set; }

        /// <summary>
        /// Early Learning Oldest Age Authorized to Serve
        /// <para>
        /// The oldest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=20189">Early Learning Oldest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        public System.Int32? OldestAgeServed { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefELGroupSizeStandardMet"/> model
        /// </summary>
        public Guid? RefELGroupSizeStandardMetId { get; set; }

        /// <summary>
        /// Reference to an optional instance of the <see cref="RefFrequencyOfService"/> model
        /// </summary>
        public Guid? RefFrequencyOfServiceId { get; set; }

        /// <summary>
        /// Serves Children with Special Needs
        /// <para>
        /// An indication of whether a class or group serves children with special needs.
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19821">Serves Children with Special Needs</a>
        /// </para>
        /// </summary>
        public System.Boolean? ServesChildrenWithSpecialNeeds { get; set; }

        /// <summary>
        /// Early Learning Youngest Age Authorized to Serve
        /// <para>
        /// The youngest age of children a class/group is authorized or licensed to serve.  (Age is specified in months)
        /// </para>
        /// <para>
        /// <a href="https://ceds.ed.gov/CEDSElementDetails.aspx?TermId=19626">Early Learning Youngest Age Authorized to Serve</a>
        /// </para>
        /// </summary>
        public System.Int32? YoungestAgeServed { get; set; }

    }
}
