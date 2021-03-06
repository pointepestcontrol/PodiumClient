﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class UserSummary
    {
        public override bool Equals(object obj)
        {
            return obj is UserSummary summary &&
                   EqualityComparer<double?>.Default.Equals(AverageRating, summary.AverageRating) &&
                   EqualityComparer<long?>.Default.Equals(Clicked, summary.Clicked) &&
                   EqualityComparer<long?>.Default.Equals(InviteCount, summary.InviteCount) &&
                   EqualityComparer<long?>.Default.Equals(Recommended, summary.Recommended) &&
                   UserName == summary.UserName;
        }

        public override int GetHashCode()
        {
            var hashCode = 1184996767;
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(AverageRating);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Clicked);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(InviteCount);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Recommended);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UserName);
            return hashCode;
        }

        public static bool operator ==(UserSummary left, UserSummary right)
        {
            return EqualityComparer<UserSummary>.Default.Equals(left, right);
        }

        public static bool operator !=(UserSummary left, UserSummary right)
        {
            return !(left == right);
        }
    }
}
