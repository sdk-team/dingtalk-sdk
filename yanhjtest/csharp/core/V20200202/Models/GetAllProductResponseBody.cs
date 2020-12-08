// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.YanhjTest20200202.Models
{
    public class GetAllProductResponseBody : TeaModel {
        /// <summary>
        /// code
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// 产品信息
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAllProductResponseBodyData Data { get; set; }
        public class GetAllProductResponseBodyData : TeaModel {
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<string> Domains { get; set; }
            [NameInMap("NameSpace")]
            [Validation(Required=false)]
            public string NameSpace { get; set; }
            [NameInMap("Product")]
            [Validation(Required=false)]
            public string Product { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// success
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
