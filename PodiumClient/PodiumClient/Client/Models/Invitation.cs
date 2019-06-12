using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class Invitation
    {
        public override bool Equals(object obj)
        {
            return obj is Invitation invitation &&
                   EqualityComparer<long?>.Default.Equals(Id, invitation.Id) &&
                   PhoneNumber == invitation.PhoneNumber &&
                   EqualityComparer<bool?>.Default.Equals(LastInvitationSent, invitation.LastInvitationSent) &&
                   EqualityComparer<long?>.Default.Equals(OrganizationId, invitation.OrganizationId) &&
                   EqualityComparer<DateTime?>.Default.Equals(CreatedAt, invitation.CreatedAt) &&
                   EqualityComparer<DateTime?>.Default.Equals(UpdatedAt, invitation.UpdatedAt) &&
                   ReviewPageUrl == invitation.ReviewPageUrl &&
                   EqualityComparer<long?>.Default.Equals(UserId, invitation.UserId) &&
                   EqualityComparer<bool?>.Default.Equals(Test, invitation.Test) &&
                   EqualityComparer<long?>.Default.Equals(LocationId, invitation.LocationId) &&
                   EqualityComparer<long?>.Default.Equals(CustomerId, invitation.CustomerId) &&
                   Email == invitation.Email;
        }

        public override int GetHashCode()
        {
            var hashCode = -1031703259;
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(LastInvitationSent);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(OrganizationId);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(CreatedAt);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(UpdatedAt);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReviewPageUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(UserId);
            hashCode = hashCode * -1521134295 + EqualityComparer<bool?>.Default.GetHashCode(Test);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(LocationId);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(CustomerId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            return hashCode;
        }

        public static bool operator ==(Invitation left, Invitation right)
        {
            return EqualityComparer<Invitation>.Default.Equals(left, right);
        }

        public static bool operator !=(Invitation left, Invitation right)
        {
            return !(left == right);
        }
    }
}
