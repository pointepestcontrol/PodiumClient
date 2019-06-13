using System;
using System.Collections.Generic;
using System.Text;

namespace Podium.Client.Models
{
    public partial class Review
    {
        public override bool Equals(object obj)
        {
            return obj is Review review &&
                   EqualityComparer<long?>.Default.Equals(Id, review.Id) &&
                   SiteReviewId == review.SiteReviewId &&
                   SiteName == review.SiteName &&
                   EqualityComparer<long?>.Default.Equals(LocationId, review.LocationId) &&
                   EqualityComparer<DateTime?>.Default.Equals(CreatedAt, review.CreatedAt) &&
                   EqualityComparer<DateTime?>.Default.Equals(PublishDate, review.PublishDate) &&
                   EqualityComparer<DateTime?>.Default.Equals(UpdatedAt, review.UpdatedAt) &&
                   EqualityComparer<double?>.Default.Equals(Rating, review.Rating) &&
                   ReviewBody == review.ReviewBody &&
                   EqualityComparer<long?>.Default.Equals(ReviewInvitationId, review.ReviewInvitationId) &&
                   ReviewUrl == review.ReviewUrl &&
                   Author == review.Author &&
                   AuthorId == review.AuthorId;
        }

        public override int GetHashCode()
        {
            var hashCode = -243601419;
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SiteReviewId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(SiteName);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(LocationId);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(CreatedAt);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(PublishDate);
            hashCode = hashCode * -1521134295 + EqualityComparer<DateTime?>.Default.GetHashCode(UpdatedAt);
            hashCode = hashCode * -1521134295 + EqualityComparer<double?>.Default.GetHashCode(Rating);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReviewBody);
            hashCode = hashCode * -1521134295 + EqualityComparer<long?>.Default.GetHashCode(ReviewInvitationId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ReviewUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Author);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AuthorId);
            return hashCode;
        }

        public static bool operator ==(Review left, Review right)
        {
            return EqualityComparer<Review>.Default.Equals(left, right);
        }

        public static bool operator !=(Review left, Review right)
        {
            return !(left == right);
        }
    }
}
