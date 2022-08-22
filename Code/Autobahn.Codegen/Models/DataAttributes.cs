using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Autobahn.Codegen.Models
{
    internal class DataAttributes
    {
        internal DataAttributes(Type type)
        {
            Columns = type.GetCustomAttributes<ColumnAttribute>().ToList();
            ForeignKeys = type.GetCustomAttributes<ForeignKeyAttribute>().ToList();
            Compares = type.GetCustomAttributes<CompareAttribute>().ToList();
            ConcurrencyChecks = type.GetCustomAttributes<ConcurrencyCheckAttribute>().ToList();
            CreditCardAttributes = type.GetCustomAttributes<CreditCardAttribute>().ToList();
            CustomValidationAttributes = type.GetCustomAttributes<CustomValidationAttribute>().ToList();
            DataTypeAttributes = type.GetCustomAttributes<DataTypeAttribute>().ToList();
            DisplayAttributes = type.GetCustomAttributes<DisplayAttribute>().ToList();
            DisplayColumnAttributes = type.GetCustomAttributes<DisplayColumnAttribute>().ToList();
            DisplayFormatAttributes = type.GetCustomAttributes<DisplayFormatAttribute>().ToList();
            EditableAttributes = type.GetCustomAttributes<EditableAttribute>().ToList();
            EmailAddressAttributes = type.GetCustomAttributes<EmailAddressAttribute>().ToList();
            EnumDataTypeAttributes = type.GetCustomAttributes<EnumDataTypeAttribute>().ToList();
            FileExtensionsAttributes = type.GetCustomAttributes<FileExtensionsAttribute>().ToList();
            KeyAttributes = type.GetCustomAttributes<KeyAttribute>().ToList();
            MaxLengthAttributes = type.GetCustomAttributes<MaxLengthAttribute>().ToList();
            MetadataTypeAttributes = type.GetCustomAttributes<MetadataTypeAttribute>().ToList();
            MinLengthAttributes = type.GetCustomAttributes<MinLengthAttribute>().ToList();
            PhoneAttributes = type.GetCustomAttributes<PhoneAttribute>().ToList();
            TableAttributes = type.GetCustomAttributes<TableAttribute>().ToList();
        }
        internal List<ColumnAttribute>? Columns { get; set; }
        internal List<ForeignKeyAttribute>? ForeignKeys { get; set; }
        internal List<CompareAttribute>? Compares { get; set; }
        internal List<ConcurrencyCheckAttribute>? ConcurrencyChecks { get; set; }
        internal List<CreditCardAttribute>? CreditCardAttributes { get; set; }
        internal List<CustomValidationAttribute>? CustomValidationAttributes { get; set; }
        internal List<DataTypeAttribute>? DataTypeAttributes { get; set; }
        internal List<DisplayAttribute>? DisplayAttributes { get; set; }
        internal List<DisplayColumnAttribute>? DisplayColumnAttributes { get; set; }
        internal List<DisplayFormatAttribute>? DisplayFormatAttributes { get; set; }
        internal List<EditableAttribute>? EditableAttributes { get; set; }
        internal List<EmailAddressAttribute>? EmailAddressAttributes { get; set; }
        internal List<EnumDataTypeAttribute>? EnumDataTypeAttributes { get; set; }
        internal List<FileExtensionsAttribute>? FileExtensionsAttributes { get; set; }
        internal List<KeyAttribute>? KeyAttributes { get; set; }
        internal List<MaxLengthAttribute>? MaxLengthAttributes { get; set; }
        internal List<MetadataTypeAttribute>? MetadataTypeAttributes { get; set; }
        internal List<MinLengthAttribute>? MinLengthAttributes { get; set; }
        internal List<PhoneAttribute>? PhoneAttributes { get; set; }
        internal List<TableAttribute>? TableAttributes { get; set; }
    }
}
