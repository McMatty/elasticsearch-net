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
using System;
using System.Threading;
using System.Threading.Tasks;
using Elastic.Transport;

#nullable restore
namespace Nest
{
    public class EqlDeleteRequestParameters : RequestParameters<EqlDeleteRequestParameters>
    {
    }

    public class EqlGetRequestParameters : RequestParameters<EqlGetRequestParameters>
    {
        public Time? KeepAlive { get => Q<Time?>("keep_alive"); set => Q("keep_alive", value); }

        public Time? WaitForCompletionTimeout { get => Q<Time?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
    }

    public class EqlGetStatusRequestParameters : RequestParameters<EqlGetStatusRequestParameters>
    {
    }

    public class EqlSearchRequestParameters : RequestParameters<EqlSearchRequestParameters>
    {
        public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

        public ExpandWildcards? ExpandWildcards { get => Q<ExpandWildcards?>("expand_wildcards"); set => Q("expand_wildcards", value); }

        public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

        public Time? KeepAlive { get => Q<Time?>("keep_alive"); set => Q("keep_alive", value); }

        public bool? KeepOnCompletion { get => Q<bool?>("keep_on_completion"); set => Q("keep_on_completion", value); }

        public Time? WaitForCompletionTimeout { get => Q<Time?>("wait_for_completion_timeout"); set => Q("wait_for_completion_timeout", value); }
    }
}