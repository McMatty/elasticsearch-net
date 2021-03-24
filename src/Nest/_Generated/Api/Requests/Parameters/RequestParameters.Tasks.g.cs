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
    public class CancelTasksRequestParameters : RequestParameters<CancelTasksRequestParameters>
    {
        public string? ParentTaskId { get => Q<string?>("parent_task_id"); set => Q("parent_task_id", value); }
    }

    public class GetTaskRequestParameters : RequestParameters<GetTaskRequestParameters>
    {
        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
    }

    public class ListTasksRequestParameters : RequestParameters<ListTasksRequestParameters>
    {
        public string? Actions { get => Q<string?>("actions"); set => Q("actions", value); }

        public bool? Detailed { get => Q<bool?>("detailed"); set => Q("detailed", value); }

        public GroupBy? GroupBy { get => Q<GroupBy?>("group_by"); set => Q("group_by", value); }

        public Id? ParentTaskId { get => Q<Id?>("parent_task_id"); set => Q("parent_task_id", value); }

        public Time? Timeout { get => Q<Time?>("timeout"); set => Q("timeout", value); }

        public bool? WaitForCompletion { get => Q<bool?>("wait_for_completion"); set => Q("wait_for_completion", value); }
    }
}