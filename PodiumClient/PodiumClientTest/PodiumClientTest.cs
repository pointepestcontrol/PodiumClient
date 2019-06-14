using Microsoft.Rest;
using NUnit.Framework;
using Podium.Client;
using Podium.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodiumClientTest
{
    public class PodiumClientTest
    {
        private PodiumAPI Client { get; set; }
        private long OrgId { get; set; }

        [SetUp]
        public void Setup()
        {
            Client = new PodiumAPI(new PodiumCredentials(TestContext.Parameters["podiumKey"]));
            OrgId = long.Parse(TestContext.Parameters["orgId"]);
        }

        [Test]
        public async Task TestGetLocationsById()
        {
            LocationsByOrgIdGetOKResponse response = await Client.LocationsByOrgIdGetAsync(OrgId);
            Assert.NotNull(response.Locations);
            Assert.IsNotEmpty(response.Locations);
            Assert.That(response.Locations, Is.Unique);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public async Task TestGetLocationsByIdWithPageSize(long pageSize)
        {
            LocationsByOrgIdGetOKResponse response = await Client.LocationsByOrgIdGetAsync(OrgId, pagesize: pageSize);
            Assert.NotNull(response.Locations);
            Assert.IsNotEmpty(response.Locations);
            Assert.That(response.Locations, Is.Unique);
            Assert.LessOrEqual(response.Locations.Count, pageSize);
        }

        [Test]
        public async Task TestGetLocationsByIdWithPage()
        {
            LocationsByOrgIdGetOKResponse response = await Client.LocationsByOrgIdGetAsync(OrgId);
            Assert.NotNull(response.Locations);
            Assert.IsNotEmpty(response.Locations);
            for (int i = 1; i < response.Locations.Count + 1; i++)
            {
                LocationsByOrgIdGetOKResponse response2 = await Client.LocationsByOrgIdGetAsync(OrgId, pagenumber: i, pagesize: 1);
                Assert.NotNull(response2.Locations);
                Assert.IsNotEmpty(response2.Locations);
                Assert.AreEqual(response.Locations[i - 1], response2.Locations[0]);
            }
        }

        [Test]
        public async Task TestGetInvitesByLocationId()
        {
            LocationsByOrgIdGetOKResponse response = await Client.LocationsByOrgIdGetAsync(OrgId);
            Assert.NotNull(response.Locations);
            Assert.IsNotEmpty(response.Locations);
            var location = TestContext.CurrentContext.Random.Next(response.Locations.Count - 1); 
            InvitationsByLocationGetOKResponse invitationResponse = await Client.InvitationsByLocationGetAsync(response.Locations[location].LocationId);
            Assert.NotNull(invitationResponse.Invites);
            Assert.IsNotEmpty(invitationResponse.Invites);
        }

        [Test]
        public async Task TestGetInvitationsWithPage()
        {
            LocationsByOrgIdGetOKResponse response = await Client.LocationsByOrgIdGetAsync(OrgId);
            Assert.NotNull(response.Locations);
            Assert.IsNotEmpty(response.Locations);
            var location = TestContext.CurrentContext.Random.Next(response.Locations.Count - 1);
            InvitationsByLocationGetOKResponse invitationResponse = await Client.InvitationsByLocationGetAsync(response.Locations[location].LocationId,1, 10);
            InvitationsByLocationGetOKResponse invitationResponse2 = await Client.InvitationsByLocationGetAsync(response.Locations[location].LocationId, 2, 5);
            foreach(var invite in invitationResponse.Invites.Skip(5).Take(5))
            {
                Assert.Contains(invite, invitationResponse2.Invites.ToArray());
            }
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        [TestCase(5)]
        public async Task TestGetInvitationsWithPageSize(long pageSize)
        {

            LocationsByOrgIdGetOKResponse response = await Client.LocationsByOrgIdGetAsync(OrgId);
            Assert.NotNull(response.Locations);
            Assert.IsNotEmpty(response.Locations);
            var location = TestContext.CurrentContext.Random.Next(response.Locations.Count - 1);
            InvitationsByLocationGetOKResponse invitationResponse = await Client.InvitationsByLocationGetAsync(response.Locations[location].LocationId, 1, pageSize);
            Assert.That(invitationResponse.Invites, Is.Unique);
            Assert.LessOrEqual(invitationResponse.Invites.Count, pageSize);
        }
        [Test]
        public async Task TestGetInvitationsWithDateRange()
        {
            LocationsByOrgIdGetOKResponse response = await Client.LocationsByOrgIdGetAsync(OrgId);
            Assert.NotNull(response.Locations);
            Assert.IsNotEmpty(response.Locations);
            var location = TestContext.CurrentContext.Random.Next(response.Locations.Count - 1);
            DateTime fromDate = DateTime.Now.AddDays(-30).Date;
            DateTime toDate = DateTime.Now.AddDays(-15).Date;
            InvitationsByLocationGetOKResponse invitationResponse = await Client.InvitationsByLocationGetAsync(response.Locations[location].LocationId, fromDate: fromDate, toDate: toDate);
            foreach(var invite in invitationResponse.Invites)
            {
                Assert.GreaterOrEqual(invite.CreatedAt, fromDate);
                Assert.LessOrEqual(invite.CreatedAt, toDate);
            }
        }
    }
}
