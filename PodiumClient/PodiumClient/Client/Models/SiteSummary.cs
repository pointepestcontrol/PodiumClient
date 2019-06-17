using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class SiteSummary
    {
        public override bool Equals(object obj)
        {
            return obj is SiteSummary summary &&
                   EqualityComparer<double?>.Default.Equals(AverageRating, summary.AverageRating) &&
                   EqualityComparer<long?>.Default.Equals(ReviewCount, summary.ReviewCount) &&
                   SiteName == summary.SiteName;
        }

        public override int GetHashCode()
        {
            var hashCode = 1176859234;
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(AverageRating);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(ReviewCount);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SiteName);
            return hashCode;
        }

        public static bool operator ==(SiteSummary left, SiteSummary right)
        {
            return EqualityComparer<SiteSummary>.Default.Equals(left, right);
        }

        public static bool operator !=(SiteSummary left, SiteSummary right)
        {
            return !(left == right);
        }
    }
}
