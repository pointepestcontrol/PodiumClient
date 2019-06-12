using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class Location
    {
        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   EqualityComparer<long?>.Default.Equals(LocationId, location.LocationId) &&
                   LocationName == location.LocationName;
        }

        public override int GetHashCode()
        {
            var hashCode = 2080988408;
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(LocationId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LocationName);
            return hashCode;
        }

        public static bool operator ==(Location left, Location right)
        {
            return EqualityComparer<Location>.Default.Equals(left, right);
        }

        public static bool operator !=(Location left, Location right)
        {
            return !(left == right);
        }
    }
}
