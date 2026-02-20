using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using NUnit.Framework;

namespace DeveloperDailyHub.ApiTests
{
    internal class StatusEndpointTests
    {
        [Test]
        public async Task Get_Status_Returns_Ok_And_Expected_Fields()
        {
            // Arrange
            await using var factory = new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder => builder.UseEnvironment("Testing"));
            using var client = factory.CreateClient();

            // Act
            var response = await client.GetAsync("/api/status");
            var json = await response.Content.ReadAsStringAsync();

            // Assert
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));

            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            Assert.That(root.TryGetProperty("name", out _), Is.True);
            Assert.That(root.TryGetProperty("version", out _), Is.True);
            Assert.That(root.TryGetProperty("serverTime", out _), Is.True);
        }
    }
}
