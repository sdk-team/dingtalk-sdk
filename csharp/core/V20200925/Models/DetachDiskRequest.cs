// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200925.Models
{
    public class DetachDiskRequest : TeaModel {
        /// <summary>
        /// 需要销毁关系的资源类型A的ID
        /// </summary>
        [NameInMap("InstanceTestId")]
        [Validation(Required=false)]
        public string InstanceTestId { get; set; }

        /// <summary>
        /// 需要销毁关系的资源类型B的ID
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// a
        /// </summary>
        [NameInMap("A")]
        [Validation(Required=false)]
        public DetachDiskRequestA A { get; set; }
        public class DetachDiskRequestA : TeaModel {
            [NameInMap("b")]
            [Validation(Required=false)]
            public string B { get; set; }
        };

        /// <summary>
        /// a
        /// </summary>
        [NameInMap("Fuccccc")]
        [Validation(Required=false)]
        public string Fuccccc { get; set; }

    }

}
