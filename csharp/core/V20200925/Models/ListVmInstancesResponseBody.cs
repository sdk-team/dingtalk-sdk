// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200925.Models
{
    public class ListVmInstancesResponseBody : TeaModel {
        /// <summary>
        /// 数组，返回示例目录。
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public List<ListVmInstancesResponseBodyInstances> Instances { get; set; }
        public class ListVmInstancesResponseBodyInstances : TeaModel {
            /// <summary>
            /// 创建时间
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// 磁盘id
            /// </summary>
            [NameInMap("DataDiskId")]
            [Validation(Required=false)]
            public string DataDiskId { get; set; }

            /// <summary>
            /// 主机名称
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// 实例id
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// 实例类型
            /// </summary>
            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            /// <summary>
            /// 系统类型
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            /// <summary>
            /// 状态
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// 当总结果个数大于MaxResults时，用于翻页的token。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public int? NextToken { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 总记录数。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
