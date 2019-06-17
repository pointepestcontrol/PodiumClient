using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class LocationSummary
    {
        public override bool Equals(object obj)
        {
            return obj is LocationSummary summary &&
                   EqualityComparer<double?>.Default.Equals(AverageRating, summary.AverageRating) &&
                   EqualityComparer<double?>.Default.Equals(ClickRate, summary.ClickRate) &&
                   EqualityComparer<long?>.Default.Equals(InviteCount, summary.InviteCount) &&
                   EqualityComparer<long?>.Default.Equals(Recommended, summary.Recommended) &&
                   EqualityComparer<long?>.Default.Equals(TotalReviews, summary.TotalReviews);
        }

        public override int GetHashCode()
        {
            var hashCode = -1686159613;
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(AverageRating);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(ClickRate);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(InviteCount);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Recommended);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(TotalReviews);
            return hashCode;
        }

        public static bool operator ==(LocationSummary left, LocationSummary right)
        {
            return EqualityComparer<LocationSummary>.Default.Equals(left, right);
        }

        public static bool operator !=(LocationSummary left, LocationSummary right)
        {
            return !(left == right);
        }
    }
}
