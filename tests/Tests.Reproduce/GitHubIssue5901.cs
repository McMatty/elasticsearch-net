// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information

using System;
using Elastic.Elasticsearch.Xunit.XunitPlumbing;
using Elasticsearch.Net;
using FluentAssertions;
using Nest;

namespace Tests.Reproduce
{
	public class GitHubIssue5901
	{
		[U]
		public void WhenIndexDoesNotExistResponseShouldBeValid()
		{
			var pool = new SingleNodeConnectionPool(new Uri($"http://localhost:9200"));
			var settings = new ConnectionSettings(pool, new InMemoryConnection(Array.Empty<byte>(), 404));
			var client = new ElasticClient(settings);

			var response = client.Indices.Exists("test");

			response.IsValid.Should().BeTrue();
			response.Exists.Should().BeFalse();
		}
	}
}