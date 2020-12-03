// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200925.Models
{
    public class CreateRuleInstanceResponseBody : TeaModel {
        /// <summary>
        /// 资源实例ID，如ECS实例的创建接口CreateInstance应返回InstanceId。
        /// </summary>
        [NameInMap("RuleInstanceId")]
        [Validation(Required=false)]
        public string RuleInstanceId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 若创建接口为异步实现，则需返回明确的JobId。
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

    }

}
