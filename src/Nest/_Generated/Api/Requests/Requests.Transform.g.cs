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
// ------------------------------------------------

using System;
using System.Text.Json.Serialization;
using Elastic.Transport;

#nullable restore
namespace Nest
{
	[JsonInterfaceConverter(typeof(InterfaceConverter<IDeleteTransformRequest, DeleteTransformRequest>))]
	public interface IDeleteTransformRequest : IRequest<DeleteTransformRequestParameters>
	{
	}

	public class DeleteTransformRequest : PlainRequestBase<DeleteTransformRequestParameters>, IDeleteTransformRequest
	{
		protected IDeleteTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformDeleteTransform;
		protected override HttpMethod HttpMethod => HttpMethod.DELETE;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_transform/{transform_id}</summary>
        public DeleteTransformRequest(Name transformId) : base(r => r.Required("transform_id", transformId))
		{
		}

		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetTransformRequest, GetTransformRequest>))]
	public interface IGetTransformRequest : IRequest<GetTransformRequestParameters>
	{
	}

	public class GetTransformRequest : PlainRequestBase<GetTransformRequestParameters>, IGetTransformRequest
	{
		protected IGetTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformGetTransform;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_transform/{transform_id}</summary>
        public GetTransformRequest(Name transformId) : base(r => r.Optional("transform_id", transformId))
		{
		}

		///<summary>/_transform</summary>
        public GetTransformRequest() : base()
		{
		}

		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public int? From { get => Q<int?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public int? Size { get => Q<int?>("size"); set => Q("size", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IGetTransformStatsRequest, GetTransformStatsRequest>))]
	public interface IGetTransformStatsRequest : IRequest<GetTransformStatsRequestParameters>
	{
	}

	public class GetTransformStatsRequest : PlainRequestBase<GetTransformStatsRequestParameters>, IGetTransformStatsRequest
	{
		protected IGetTransformStatsRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformGetTransformStats;
		protected override HttpMethod HttpMethod => HttpMethod.GET;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_transform/{transform_id}/_stats</summary>
        public GetTransformStatsRequest(Name transformId) : base(r => r.Required("transform_id", transformId))
		{
		}

		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public long? From { get => Q<long?>("from"); set => Q("from", value); }

		[JsonIgnore]
		public long? Size { get => Q<long?>("size"); set => Q("size", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IPreviewTransformRequest, PreviewTransformRequest>))]
	public interface IPreviewTransformRequest : IRequest<PreviewTransformRequestParameters>
	{
	}

	public class PreviewTransformRequest : PlainRequestBase<PreviewTransformRequestParameters>, IPreviewTransformRequest
	{
		protected IPreviewTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformPreviewTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Description is null;
		///<summary>/_transform/_preview</summary>
        public PreviewTransformRequest() : base()
		{
		}

		[JsonPropertyName("description")]
		public string? Description
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IPutTransformRequest, PutTransformRequest>))]
	public interface IPutTransformRequest : IRequest<PutTransformRequestParameters>
	{
	}

	public class PutTransformRequest : PlainRequestBase<PutTransformRequestParameters>, IPutTransformRequest
	{
		protected IPutTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformPutTransform;
		protected override HttpMethod HttpMethod => HttpMethod.PUT;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Description is null;
		///<summary>/_transform/{transform_id}</summary>
        public PutTransformRequest(Name transformId) : base(r => r.Required("transform_id", transformId))
		{
		}

		[JsonIgnore]
		public bool? DeferValidation { get => Q<bool?>("defer_validation"); set => Q("defer_validation", value); }

		[JsonPropertyName("description")]
		public string? Description
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStartTransformRequest, StartTransformRequest>))]
	public interface IStartTransformRequest : IRequest<StartTransformRequestParameters>
	{
	}

	public class StartTransformRequest : PlainRequestBase<StartTransformRequestParameters>, IStartTransformRequest
	{
		protected IStartTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformStartTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_transform/{transform_id}/_start</summary>
        public StartTransformRequest(Name transformId) : base(r => r.Required("transform_id", transformId))
		{
		}

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IStopTransformRequest, StopTransformRequest>))]
	public interface IStopTransformRequest : IRequest<StopTransformRequestParameters>
	{
	}

	public class StopTransformRequest : PlainRequestBase<StopTransformRequestParameters>, IStopTransformRequest
	{
		protected IStopTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformStopTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => false;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => true;
		///<summary>/_transform/{transform_id}/_stop</summary>
        public StopTransformRequest(Name transformId) : base(r => r.Required("transform_id", transformId))
		{
		}

		[JsonIgnore]
		public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

		[JsonIgnore]
		public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }

		[JsonIgnore]
		public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

		[JsonIgnore]
		public bool? WaitForCheckpoint { get => Q<bool?>("wait_for_checkpoint"); set => Q("wait_for_checkpoint", value); }

		[JsonIgnore]
		public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
	}

	[JsonInterfaceConverter(typeof(InterfaceConverter<IUpdateTransformRequest, UpdateTransformRequest>))]
	public interface IUpdateTransformRequest : IRequest<UpdateTransformRequestParameters>
	{
	}

	public class UpdateTransformRequest : PlainRequestBase<UpdateTransformRequestParameters>, IUpdateTransformRequest
	{
		protected IUpdateTransformRequest Self => this;
		internal override ApiUrls ApiUrls => ApiUrlsLookups.TransformUpdateTransform;
		protected override HttpMethod HttpMethod => HttpMethod.POST;
		protected override bool SupportsBody => true;
		protected override bool CanBeEmpty => true;
		protected override bool IsEmpty => Description is null;
		///<summary>/_transform/{transform_id}/_update</summary>
        public UpdateTransformRequest(Name transformId) : base(r => r.Required("transform_id", transformId))
		{
		}

		[JsonIgnore]
		public bool? DeferValidation { get => Q<bool?>("defer_validation"); set => Q("defer_validation", value); }

		[JsonPropertyName("description")]
		public string? Description
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}
	}
}