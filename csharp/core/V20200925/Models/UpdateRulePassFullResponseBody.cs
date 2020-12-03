// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200925.Models
{
    public class UpdateRulePassFullResponseBody : TeaModel {
        /// <summary>
        /// 实例的名称
        /// </summary>
        [NameInMap("RulePassFullName")]
        [Validation(Required=false)]
        public string RulePassFullName { get; set; }

        /// <summary>
        /// 资源实例ID，如ECS实例的创建接口CreateInstance应返回InstanceId。
        /// </summary>
        [NameInMap("RulePassFullId")]
        [Validation(Required=false)]
        public string RulePassFullId { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 实例的规格。
        /// </summary>
        [NameInMap("RulePassFullSpecification")]
        [Validation(Required=false)]
        public string RulePassFullSpecification { get; set; }

    }

}
