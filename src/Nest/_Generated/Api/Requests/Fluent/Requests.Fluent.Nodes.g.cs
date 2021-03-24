// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
// Run the following in the root of the repository:
//
// TODO - RUN INSTRUCTIONS
//
// ------------------------------------------------

using Elastic.Transport;

#nullable restore
namespace Nest
{
	public class NodesHotThreadsDescriptor : RequestDescriptorBase<NodesHotThreadsDescriptor, NodesHotThreadsRequestParameters, INodesHotThreadsRequest>, INodesHotThreadsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesHotThreads;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class NodesInfoDescriptor : RequestDescriptorBase<NodesInfoDescriptor, NodesInfoRequestParameters, INodesInfoRequest>, INodesInfoRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesInfo;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class ReloadSecureSettingsDescriptor : RequestDescriptorBase<ReloadSecureSettingsDescriptor, ReloadSecureSettingsRequestParameters, IReloadSecureSettingsRequest>, IReloadSecureSettingsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesReloadSecureSettings;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
	}

	public class NodesStatsDescriptor : RequestDescriptorBase<NodesStatsDescriptor, NodesStatsRequestParameters, INodesStatsRequest>, INodesStatsRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}

	public class NodesUsageDescriptor : RequestDescriptorBase<NodesUsageDescriptor, NodesUsageRequestParameters, INodesUsageRequest>, INodesUsageRequest
	{
		internal override ApiUrls ApiUrls => ApiUrlsLookups.NodesUsage;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
	}
}