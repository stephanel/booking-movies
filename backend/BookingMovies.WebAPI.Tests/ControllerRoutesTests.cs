﻿using BookingMovies.Core.Domain.Entities;
using BookingMovies.Core.Domain.Interfaces.Repositories;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace BookingMovies.WebAPI.Tests
{
    public class ControllerRoutesTests
        : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly WebApplicationFactory<Startup> factory;

        private readonly Mock<IMovieRepository> mockMovieRepository
            = new Mock<IMovieRepository>();

        public ControllerRoutesTests(WebApplicationFactory<Startup> factory)
        {
            this.factory = factory;

            mockMovieRepository.Setup(repository => repository.GetAll())
                .ReturnsAsync(new List<Movie>());
        }

        [Theory]
        [InlineData("/api/movies")]
        [Trait("Category", "IntegrationTests")]
        public async Task Get_EndpointsReturnSuccessAndCorrectContentType(string url)
        {
            // Arrange
            var client = CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            response.EnsureSuccessStatusCode(); // Status Code 200-299
            Assert.Equal("application/json; charset=utf-8",
                response.Content.Headers.ContentType.ToString());
        }

        private HttpClient CreateClient()
        {
            return this.factory.WithWebHostBuilder(builder =>
            {
                builder.ConfigureTestServices(services =>
                {
                    services.AddScoped<IMovieRepository>((sp) => this.mockMovieRepository.Object);
                });
            })
            .CreateClient(new WebApplicationFactoryClientOptions
            {
                AllowAutoRedirect = false
            });
        }
    }
}
