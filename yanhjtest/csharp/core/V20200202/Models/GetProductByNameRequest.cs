// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.YanhjTest20200202.Models
{
    public class GetProductByNameRequest : TeaModel {
        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// market
        /// </summary>
        [NameInMap("Market")]
        [Validation(Required=false)]
        public int? Market { get; set; }

        /// <summary>
        /// name
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// bucUid
        /// </summary>
        [NameInMap("EmpId")]
        [Validation(Required=false)]
        public long? EmpId { get; set; }

    }

}
