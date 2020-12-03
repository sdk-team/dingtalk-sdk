// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200923.Models
{
    public class AttachDiskRequest : TeaModel {
        /// <summary>
        /// 需要建立关系的资源类型A的ID
        /// </summary>
        [NameInMap("InstanceTestId")]
        [Validation(Required=false)]
        public string InstanceTestId { get; set; }

        /// <summary>
        /// 需要建立关系的资源类型B的ID
        /// </summary>
        [NameInMap("DiskId")]
        [Validation(Required=false)]
        public string DiskId { get; set; }

        /// <summary>
        /// s
        /// </summary>
        [NameInMap("A")]
        [Validation(Required=false)]
        public AttachDiskRequestA A { get; set; }
        public class AttachDiskRequestA : TeaModel {
            [NameInMap("v")]
            [Validation(Required=false)]
            public string V { get; set; }
        };

        /// <summary>
        /// a
        /// </summary>
        [NameInMap("Fuccccc")]
        [Validation(Required=false)]
        public string Fuccccc { get; set; }

    }

}
