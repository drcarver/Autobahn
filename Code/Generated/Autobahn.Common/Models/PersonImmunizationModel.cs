//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonImmunizationModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonImmunization Model
     /// </summary>
    public partial class PersonImmunizationModel : AutobahnBase, Interfaces.IPersonImmunization
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? ImmunizationDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordEndDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RecordStartDateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefImmunizationTypeId { get; set; }

    }
}
