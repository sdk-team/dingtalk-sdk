// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200925.Models
{
    public class ListRulePassFullsRequest : TeaModel {
        /// <summary>
        /// 查询过滤参数，多个过滤参数之间是且的关系。例如:过滤实例名称为i-a123、i-b123，且实例状态为Stopped：&Filter.1.Name=InstanceName&Filter.1.Value.1=i-a123&Filter.1.Value.2=i-b123&Filter.2.Name=Status&Filter.2.Value=Stopped。
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public string Filter { get; set; }

        /// <summary>
        /// 一级id
        /// </summary>
        [NameInMap("FirstIds")]
        [Validation(Required=false)]
        public string FirstIds { get; set; }

        /// <summary>
        /// 返回结果的最大个数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 当总结果个数大于MaxResults时，用于翻页的token。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// a
        /// </summary>
        [NameInMap("Fuccccc")]
        [Validation(Required=false)]
        public string Fuccccc { get; set; }

    }

}
