using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace Autobahn.Codegen.Models
{
    internal class PropertyAttributes
    {
        internal PropertyAttributes()
        {
        }

        internal PropertyAttributes(PropertyInfo property)
        {
            ColumnAttribute = property.GetCustomAttributes<ColumnAttribute>().FirstOrDefault();
            CommentAttribute = property.GetCustomAttributes<CommentAttribute>().FirstOrDefault();
            ConcurrencyCheckAttribute = property.GetCustomAttributes<ConcurrencyCheckAttribute>().FirstOrDefault();
            DatabaseGeneratedAttribute = property.GetCustomAttributes<DatabaseGeneratedAttribute>().FirstOrDefault();
            ForeignKeyAttribute = property.GetCustomAttributes<ForeignKeyAttribute>().FirstOrDefault();
            InversePropertyAttribute = property.GetCustomAttributes<InversePropertyAttribute>().FirstOrDefault();
            KeyAttribute = property.GetCustomAttributes<KeyAttribute>().FirstOrDefault();
            KeylessAttribute = property.GetCustomAttributes<KeylessAttribute>().FirstOrDefault();
            MaxLengthAttribute = property.GetCustomAttributes<MaxLengthAttribute>().FirstOrDefault();
            NotMappedAttribute = property.GetCustomAttributes<NotMappedAttribute>().FirstOrDefault();
            PrecisionAttribute = property.GetCustomAttributes<PrecisionAttribute>().FirstOrDefault();
            RequiredAttribute = property.GetCustomAttributes<RequiredAttribute>().FirstOrDefault();
            TimestampAttribute = property.GetCustomAttributes<TimestampAttribute>().FirstOrDefault();
            StringLengthAttribute = property.GetCustomAttributes<StringLengthAttribute>().FirstOrDefault();
            UnicodeAttribute = property.GetCustomAttributes<UnicodeAttribute>().FirstOrDefault();
        }
        internal ColumnAttribute? ColumnAttribute { get; set; }
        internal CommentAttribute? CommentAttribute { get; set; }
        internal ConcurrencyCheckAttribute? ConcurrencyCheckAttribute { get; set; }
        internal DatabaseGeneratedAttribute? DatabaseGeneratedAttribute { get; set; }
        internal ForeignKeyAttribute? ForeignKeyAttribute { get; set; }
        internal InversePropertyAttribute? InversePropertyAttribute { get; set; }
        internal KeyAttribute? KeyAttribute { get; set; }
        internal KeylessAttribute? KeylessAttribute { get; set; }
        internal MaxLengthAttribute? MaxLengthAttribute { get; set; }
        internal NotMappedAttribute? NotMappedAttribute { get; set; }
        internal PrecisionAttribute? PrecisionAttribute { get; set; }
        internal RequiredAttribute? RequiredAttribute { get; set; }
        internal StringLengthAttribute? StringLengthAttribute { get; set; }
        internal TimestampAttribute? TimestampAttribute { get; set; }
        internal UnicodeAttribute? UnicodeAttribute { get; set; }
    }
}
