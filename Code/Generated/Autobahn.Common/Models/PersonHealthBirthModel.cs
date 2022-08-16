//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonHealthBirthModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonHealthBirth Model
     /// </summary>
    public partial class PersonHealthBirthModel : AutobahnBase, Interfaces.IPersonHealthBirth
    {
        /// <summary>
        /// 
        /// </summary>
        public  MultipleBirthIndicator { get; set; }

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
        public  RefTrimesterWhenPrenatalCareBeganId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  WeeksOfGestation { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? WeightAtBirth { get; set; }

    }
}
