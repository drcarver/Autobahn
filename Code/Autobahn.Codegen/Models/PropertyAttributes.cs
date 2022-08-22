using Microsoft.EntityFrameworkCore;
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
    internal class PropertyAttributes
    {
        internal PropertyAttributes(Type type)
        {
            ColumnAttribute = type.GetCustomAttributes<ColumnAttribute>().FirstOrDefault();
            CommentAttribute = type.GetCustomAttributes<CommentAttribute>().FirstOrDefault();
            ConcurrencyCheckAttribute = type.GetCustomAttributes<ConcurrencyCheckAttribute>().FirstOrDefault();
            DatabaseGeneratedAttribute = type.GetCustomAttributes<DatabaseGeneratedAttribute>().FirstOrDefault();
            ForeignKeyAttribute = type.GetCustomAttributes<ForeignKeyAttribute>().FirstOrDefault();
            InversePropertyAttribute = type.GetCustomAttributes<InversePropertyAttribute>().FirstOrDefault();
            KeyAttribute = type.GetCustomAttributes<KeyAttribute>().FirstOrDefault();
            KeylessAttribute = type.GetCustomAttributes<KeylessAttribute>().FirstOrDefault();
            MaxLengthAttribute = type.GetCustomAttributes<MaxLengthAttribute>().FirstOrDefault();
            NotMappedAttribute = type.GetCustomAttributes<NotMappedAttribute>().FirstOrDefault();
            PrecisionAttribute = type.GetCustomAttributes<PrecisionAttribute>().FirstOrDefault();
            RequiredAttribute = type.GetCustomAttributes<RequiredAttribute>().FirstOrDefault();
            TimestampAttribute = type.GetCustomAttributes<TimestampAttribute>().FirstOrDefault();
            UnicodeAttribute = type.GetCustomAttributes<UnicodeAttribute>().FirstOrDefault();
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
        internal TimestampAttribute? TimestampAttribute { get; set; }
        internal UnicodeAttribute? UnicodeAttribute { get; set; }
    }
}
