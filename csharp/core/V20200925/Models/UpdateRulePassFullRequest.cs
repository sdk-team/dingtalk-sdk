// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200925.Models
{
    public class UpdateRulePassFullRequest : TeaModel {
        /// <summary>
        /// 实例 ID。
        /// </summary>
        [NameInMap("RulePassFullId")]
        [Validation(Required=false)]
        public string RulePassFullId { get; set; }

        /// <summary>
        /// 用于保证请求的幂等性。由客户端生成该参数值，要保证在不同请求间唯一。只支持 ASCII 字符，且不能超过 64 个字符
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 付费类型
        /// </summary>
        [NameInMap("PaymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// 一级ID
        /// </summary>
        [NameInMap("FirstId")]
        [Validation(Required=false)]
        public string FirstId { get; set; }

        /// <summary>
        /// a
        /// </summary>
        [NameInMap("Fuccccc")]
        [Validation(Required=false)]
        public string Fuccccc { get; set; }

    }

}
