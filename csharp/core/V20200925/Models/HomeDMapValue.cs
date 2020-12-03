// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200925.Models
{
    public class HomeDMapValue : TeaModel {
        /// <summary>
        /// detail
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// location
        /// </summary>
        [NameInMap("Location")]
        [Validation(Required=false)]
        public HomeDMapValueLocation Location { get; set; }
        public class HomeDMapValueLocation : TeaModel {
            [NameInMap("Late")]
            [Validation(Required=false)]
            public long? Late { get; set; }
            [NameInMap("Lon")]
            [Validation(Required=false)]
            public long? Lon { get; set; }
        };

    }

}
