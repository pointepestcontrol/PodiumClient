using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class Page
    {
        public override bool Equals(object obj)
        {
            return obj is Page page &&
                   EqualityComparer<long?>.Default.Equals(Number, page.Number) &&
                   EqualityComparer<long?>.Default.Equals(Size, page.Size) &&
                   EqualityComparer<long?>.Default.Equals(Total, page.Total);
        }

        public override int GetHashCode()
        {
            var hashCode = -1297784263;
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Number);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Size);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Total);
            return hashCode;
        }

        public static bool operator ==(Page left, Page right)
        {
            return EqualityComparer<Page>.Default.Equals(left, right);
        }

        public static bool operator !=(Page left, Page right)
        {
            return !(left == right);
        }
    }
}
