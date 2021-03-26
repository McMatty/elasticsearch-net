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

#nullable restore
namespace Nest
{
	public class CatTransformsRecord
	{
		[JsonInclude, JsonPropertyName("c")]
		private string? _c = default;
		[JsonInclude, JsonPropertyName("cdtea")]
		private string? _cdtea = default;
		[JsonInclude, JsonPropertyName("changes_last_detection_time")]
		private string? _changes_last_detection_time = default;
		[JsonInclude, JsonPropertyName("checkpoint")]
		private string? _checkpoint = default;
		[JsonInclude, JsonPropertyName("checkpoint_duration_time_exp_avg")]
		private string? _checkpoint_duration_time_exp_avg = default;
		[JsonInclude, JsonPropertyName("checkpoint_progress")]
		private string? _checkpoint_progress = default;
		[JsonInclude, JsonPropertyName("checkpointProgress")]
		private string? _checkpointProgress = default;
		[JsonInclude, JsonPropertyName("checkpointTimeExpAvg")]
		private string? _checkpointTimeExpAvg = default;
		[JsonInclude, JsonPropertyName("cldt")]
		private string? _cldt = default;
		[JsonInclude, JsonPropertyName("cp")]
		private string? _cp = default;
		[JsonInclude, JsonPropertyName("create_time")]
		private string? _create_time = default;
		[JsonInclude, JsonPropertyName("createTime")]
		private string? _createTime = default;
		[JsonInclude, JsonPropertyName("ct")]
		private string? _ct = default;
		[JsonInclude, JsonPropertyName("d")]
		private string? _d = default;
		[JsonInclude, JsonPropertyName("delete_time")]
		private string? _delete_time = default;
		[JsonInclude, JsonPropertyName("description")]
		private string? _description = default;
		[JsonInclude, JsonPropertyName("dest_index")]
		private string? _dest_index = default;
		[JsonInclude, JsonPropertyName("destIndex")]
		private string? _destIndex = default;
		[JsonInclude, JsonPropertyName("di")]
		private string? _di = default;
		[JsonInclude, JsonPropertyName("docd")]
		private string? _docd = default;
		[JsonInclude, JsonPropertyName("doci")]
		private string? _doci = default;
		[JsonInclude, JsonPropertyName("docp")]
		private string? _docp = default;
		[JsonInclude, JsonPropertyName("docs_per_second")]
		private string? _docs_per_second = default;
		[JsonInclude, JsonPropertyName("documents_deleted")]
		private string? _documents_deleted = default;
		[JsonInclude, JsonPropertyName("documents_indexed")]
		private string? _documents_indexed = default;
		[JsonInclude, JsonPropertyName("documents_processed")]
		private string? _documents_processed = default;
		[JsonInclude, JsonPropertyName("documentsProcessed")]
		private string? _documentsProcessed = default;
		[JsonInclude, JsonPropertyName("dps")]
		private string? _dps = default;
		[JsonInclude, JsonPropertyName("dtime")]
		private string? _dtime = default;
		[JsonInclude, JsonPropertyName("f")]
		private string? _f = default;
		[JsonInclude, JsonPropertyName("frequency")]
		private string? _frequency = default;
		[JsonInclude, JsonPropertyName("idea")]
		private string? _idea = default;
		[JsonInclude, JsonPropertyName("if")]
		private string? _if = default;
		[JsonInclude, JsonPropertyName("index_failure")]
		private string? _index_failure = default;
		[JsonInclude, JsonPropertyName("index_time")]
		private string? _index_time = default;
		[JsonInclude, JsonPropertyName("index_total")]
		private string? _index_total = default;
		[JsonInclude, JsonPropertyName("indexed_documents_exp_avg")]
		private string? _indexed_documents_exp_avg = default;
		[JsonInclude, JsonPropertyName("it")]
		private string? _it = default;
		[JsonInclude, JsonPropertyName("itime")]
		private string? _itime = default;
		[JsonInclude, JsonPropertyName("last_search_time")]
		private string? _last_search_time = default;
		[JsonInclude, JsonPropertyName("lastSearchTime")]
		private string? _lastSearchTime = default;
		[JsonInclude, JsonPropertyName("lst")]
		private string? _lst = default;
		[JsonInclude, JsonPropertyName("max_page_search_size")]
		private string? _max_page_search_size = default;
		[JsonInclude, JsonPropertyName("mpsz")]
		private string? _mpsz = default;
		[JsonInclude, JsonPropertyName("p")]
		private string? _p = default;
		[JsonInclude, JsonPropertyName("pages_processed")]
		private string? _pages_processed = default;
		[JsonInclude, JsonPropertyName("pdea")]
		private string? _pdea = default;
		[JsonInclude, JsonPropertyName("pipeline")]
		private string? _pipeline = default;
		[JsonInclude, JsonPropertyName("pp")]
		private string? _pp = default;
		[JsonInclude, JsonPropertyName("processed_documents_exp_avg")]
		private string? _processed_documents_exp_avg = default;
		[JsonInclude, JsonPropertyName("processing_time")]
		private string? _processing_time = default;
		[JsonInclude, JsonPropertyName("pt")]
		private string? _pt = default;
		[JsonInclude, JsonPropertyName("r")]
		private string? _r = default;
		[JsonInclude, JsonPropertyName("reason")]
		private string? _reason = default;
		[JsonInclude, JsonPropertyName("s")]
		private string? _s = default;
		[JsonInclude, JsonPropertyName("search_failure")]
		private string? _search_failure = default;
		[JsonInclude, JsonPropertyName("search_time")]
		private string? _search_time = default;
		[JsonInclude, JsonPropertyName("search_total")]
		private string? _search_total = default;
		[JsonInclude, JsonPropertyName("sf")]
		private string? _sf = default;
		[JsonInclude, JsonPropertyName("si")]
		private string? _si = default;
		[JsonInclude, JsonPropertyName("source_index")]
		private string? _source_index = default;
		[JsonInclude, JsonPropertyName("sourceIndex")]
		private string? _sourceIndex = default;
		[JsonInclude, JsonPropertyName("st")]
		private string? _st = default;
		[JsonInclude, JsonPropertyName("state")]
		private string? _state = default;
		[JsonInclude, JsonPropertyName("stime")]
		private string? _stime = default;
		[JsonInclude, JsonPropertyName("tc")]
		private string? _tc = default;
		[JsonInclude, JsonPropertyName("transform_type")]
		private string? _transform_type = default;
		[JsonInclude, JsonPropertyName("trigger_count")]
		private string? _trigger_count = default;
		[JsonInclude, JsonPropertyName("tt")]
		private string? _tt = default;
		[JsonInclude, JsonPropertyName("v")]
		private string? _v = default;
		[JsonInclude, JsonPropertyName("version")]
		private string? _version = default;
		public string? ChangesLastDetectionTime => _cldt ?? _changes_last_detection_time;
		public string? Checkpoint => _c ?? _checkpoint;
		public string? CheckpointDurationTimeExpAvg => _checkpoint_duration_time_exp_avg ?? _cdtea ?? _checkpointTimeExpAvg;
		public string? CheckpointProgress => _checkpoint_progress ?? _cp ?? _checkpointProgress;
		public string? CreateTime => _create_time ?? _ct ?? _createTime;
		public string? DeleteTime => _dtime ?? _delete_time;
		public string? Description => _d ?? _description;
		public string? DestIndex => _dest_index ?? _di ?? _destIndex;
		public string? DocsPerSecond => _dps ?? _docs_per_second;
		public string? DocumentsDeleted => _docd ?? _documents_deleted;
		public string? DocumentsIndexed => _doci ?? _documents_indexed;
		public string? DocumentsProcessed => _documents_processed ?? _docp ?? _documentsProcessed;
		public string? Frequency => _f ?? _frequency;
		[JsonPropertyName("id")]
		public string? Id
		{
			get;
#if NET5_0
            init;
#else
			internal set;
#endif
		}

		public string? IndexedDocumentsExpAvg => _idea ?? _indexed_documents_exp_avg;
		public string? IndexFailure => _if ?? _index_failure;
		public string? IndexTime => _itime ?? _index_time;
		public string? IndexTotal => _it ?? _index_total;
		public string? LastSearchTime => _last_search_time ?? _lst ?? _lastSearchTime;
		public string? MaxPageSearchSize => _mpsz ?? _max_page_search_size;
		public string? PagesProcessed => _pp ?? _pages_processed;
		public string? Pipeline => _p ?? _pipeline;
		public string? ProcessedDocumentsExpAvg => _pdea ?? _processed_documents_exp_avg;
		public string? ProcessingTime => _pt ?? _processing_time;
		public string? Reason => _r ?? _reason;
		public string? SearchFailure => _sf ?? _search_failure;
		public string? SearchTime => _stime ?? _search_time;
		public string? SearchTotal => _st ?? _search_total;
		public string? SourceIndex => _source_index ?? _si ?? _sourceIndex;
		public string? State => _s ?? _state;
		public string? TransformType => _tt ?? _transform_type;
		public string? TriggerCount => _tc ?? _trigger_count;
		public string? Version => _v ?? _version;
	}
}