//**********************************************************
//* DomainName: Autobahn.Common
//* FileName:   RefDisabilityTypeList.cs
//**********************************************************

using Autobahn.Common.Models;

namespace Autobahn.Common.Models
{
     /// <summary>
     /// The list of RefDisabilityType Models
     /// </summary>
    public static partial class ReferenceLists
    {
        /// <summary>
        /// The complete <see cref="RefDisabilityType"> List
         /// </summary>
        public static List<RefDisabilityType> RefDisabilityTypeList = new List<RefDisabilityType>
        {
            new RefDisabilityType { Id=Guid.Parse("b17666af-6215-4263-88fd-b6379985440d"), Code="AUT", Description="Autism", Definition="Autism is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityType { Id=Guid.Parse("2edb938e-462b-4db5-8ad1-498e28004e98"), Code="DB", Description="Deaf-blindness", Definition="Deaf-blindness is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityType { Id=Guid.Parse("c1e59354-f00c-4b02-bb00-291ec11a1682"), Code="DD", Description="Developmental delay", Definition="Developmental delay is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityType { Id=Guid.Parse("0f78273d-5251-450a-88de-8165842ad7bb"), Code="EMN", Description="Emotional disturbance", Definition="Emotional disturbance is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisabilityType { Id=Guid.Parse("0e411884-e08d-4174-b53a-c4e65c3119d7"), Code="HI", Description="Hearing impairment", Definition="Hearing impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityType { Id=Guid.Parse("5d3f98ee-31c8-4ef5-b0cc-e0655b18ddc7"), Code="ID", Description="Intellectual Disability", Definition="Intellectual Disability is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityType { Id=Guid.Parse("a19ab14a-ef89-4443-9bbd-243e3a4c045f"), Code="MD", Description="Multiple disabilities", Definition="Multiple disabilities is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisabilityType { Id=Guid.Parse("d6667b89-a3fd-41ac-b81a-1e970321f408"), Code="OI", Description="Orthopedic impairment", Definition="Orthopedic impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityType { Id=Guid.Parse("7c2c7806-6cd8-4241-a3aa-cb081fae6447"), Code="OHI", Description="Other health impairment", Definition="Other health impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisabilityType { Id=Guid.Parse("8aeb7c8c-0dd2-4919-a9bf-a66e1392127b"), Code="SLD", Description="Specific learning disability", Definition="Specific learning disability is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityType { Id=Guid.Parse("39cd47a8-f11f-4562-93d0-83aca13a9cd4"), Code="SLI", Description="Speech or language impairment", Definition="Speech or language impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("13.00") },
            new RefDisabilityType { Id=Guid.Parse("2676cb6c-7d06-4d53-9470-d3c94d12bfcf"), Code="TBI", Description="Traumatic brain injury", Definition="Traumatic brain injury is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityType { Id=Guid.Parse("5e9ec9b0-c0f4-4bd1-a7b5-bbeb62666dea"), Code="VI", Description="Visual impairment", Definition="Visual impairment is the major or overriding disability condition that best describes the person's impairment.", SortOrder=Convert.ToDecimal("15.00") },
        };

        /// <summary>
        /// The RefDisabilityType Pick List
         /// </summary>
        public static List<RefDisabilityType> RefDisabilityTypePickList = new List<RefDisabilityType>
        {
            new RefDisabilityType { Id=Guid.Parse("b17666af-6215-4263-88fd-b6379985440d"), Code="AUT", Description="Autism", SortOrder=Convert.ToDecimal("1.00") },
            new RefDisabilityType { Id=Guid.Parse("2edb938e-462b-4db5-8ad1-498e28004e98"), Code="DB", Description="Deaf-blindness", SortOrder=Convert.ToDecimal("2.00") },
            new RefDisabilityType { Id=Guid.Parse("c1e59354-f00c-4b02-bb00-291ec11a1682"), Code="DD", Description="Developmental delay", SortOrder=Convert.ToDecimal("4.00") },
            new RefDisabilityType { Id=Guid.Parse("0f78273d-5251-450a-88de-8165842ad7bb"), Code="EMN", Description="Emotional disturbance", SortOrder=Convert.ToDecimal("5.00") },
            new RefDisabilityType { Id=Guid.Parse("0e411884-e08d-4174-b53a-c4e65c3119d7"), Code="HI", Description="Hearing impairment", SortOrder=Convert.ToDecimal("6.00") },
            new RefDisabilityType { Id=Guid.Parse("5d3f98ee-31c8-4ef5-b0cc-e0655b18ddc7"), Code="ID", Description="Intellectual Disability", SortOrder=Convert.ToDecimal("8.00") },
            new RefDisabilityType { Id=Guid.Parse("a19ab14a-ef89-4443-9bbd-243e3a4c045f"), Code="MD", Description="Multiple disabilities", SortOrder=Convert.ToDecimal("9.00") },
            new RefDisabilityType { Id=Guid.Parse("d6667b89-a3fd-41ac-b81a-1e970321f408"), Code="OI", Description="Orthopedic impairment", SortOrder=Convert.ToDecimal("10.00") },
            new RefDisabilityType { Id=Guid.Parse("7c2c7806-6cd8-4241-a3aa-cb081fae6447"), Code="OHI", Description="Other health impairment", SortOrder=Convert.ToDecimal("11.00") },
            new RefDisabilityType { Id=Guid.Parse("8aeb7c8c-0dd2-4919-a9bf-a66e1392127b"), Code="SLD", Description="Specific learning disability", SortOrder=Convert.ToDecimal("12.00") },
            new RefDisabilityType { Id=Guid.Parse("39cd47a8-f11f-4562-93d0-83aca13a9cd4"), Code="SLI", Description="Speech or language impairment", SortOrder=Convert.ToDecimal("13.00") },
            new RefDisabilityType { Id=Guid.Parse("2676cb6c-7d06-4d53-9470-d3c94d12bfcf"), Code="TBI", Description="Traumatic brain injury", SortOrder=Convert.ToDecimal("14.00") },
            new RefDisabilityType { Id=Guid.Parse("5e9ec9b0-c0f4-4bd1-a7b5-bbeb62666dea"), Code="VI", Description="Visual impairment", SortOrder=Convert.ToDecimal("15.00") },
       };
   }
}
