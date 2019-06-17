using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class Meta
    {
        public override bool Equals(object obj)
        {
            return obj is Meta meta &&
                   EqualityComparer<Page>.Default.Equals(Page, meta.Page) &&
                   EqualityComparer<long?>.Default.Equals(TotalItems, meta.TotalItems);
        }

        public override int GetHashCode()
        {
            var hashCode = 2069604573;
            hashCode = hashCode * -1521134295 + EqualityComparer<Page>.Default.GetHashCode(Page);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(TotalItems);
            return hashCode;
        }

        public static bool operator ==(Meta left, Meta right)
        {
            return EqualityComparer<Meta>.Default.Equals(left, right);
        }

        public static bool operator !=(Meta left, Meta right)
        {
            return !(left == right);
        }
    }
}
