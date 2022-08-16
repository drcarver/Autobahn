//**********************************************************
//* DomainName: Common Models
//* FileName:   PersonAddressModel.cs
//**********************************************************


namespace Autobahn.Common.Models
{
     /// <summary>
     /// The PersonAddress Model
     /// </summary>
    public partial class PersonAddressModel : AutobahnBase, Interfaces.IPersonAddress
    {
        /// <summary>
        /// 
        /// </summary>
        public  AddressCountyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? ApartmentRoomOrSuiteNumber { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  DoNotPublishIndicator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Latitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  Longitude { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  PostalCode { get; set; }

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
        public  RefCountryId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPersonalInformationVerificationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefPersonLocationTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  RefStateId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public  StreetNumberAndName { get; set; }

    }
}
