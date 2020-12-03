// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dingtalk20200923.Models
{
    public class HuichengTestApiRequest : TeaModel {
        /// <summary>
        /// home
        /// </summary>
        [NameInMap("Home")]
        [Validation(Required=false)]
        public HuichengTestApiRequestHome Home { get; set; }
        public class HuichengTestApiRequestHome : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public HuichengTestApiRequestHomeAddress Address { get; set; }
            public class HuichengTestApiRequestHomeAddress : TeaModel {
                /// <summary>
                /// detail
                /// </summary>
                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                /// <summary>
                /// asdasd
                /// </summary>
                [NameInMap("Location")]
                [Validation(Required=false)]
                public HuichengTestApiRequestHomeAddressLocation Location { get; set; }
                public class HuichengTestApiRequestHomeAddressLocation : TeaModel {
                    [NameInMap("Late")]
                    [Validation(Required=false)]
                    public long? Late { get; set; }
                    [NameInMap("Lon")]
                    [Validation(Required=false)]
                    public long? Lon { get; set; }
                };

                /// <summary>
                /// t
                /// </summary>
                [NameInMap("T")]
                [Validation(Required=false)]
                public HuichengTestApiRequestHomeAddressT T { get; set; }
                public class HuichengTestApiRequestHomeAddressT : TeaModel {
                    [NameInMap("Class")]
                    [Validation(Required=false)]
                    public string Class { get; set; }
                };

            }
            [NameInMap("DMap")]
            [Validation(Required=false)]
            public Dictionary<string, string> DMap { get; set; }
            [NameInMap("Locations")]
            [Validation(Required=false)]
            public List<HuichengTestApiRequestHomeLocations> Locations { get; set; }
            public class HuichengTestApiRequestHomeLocations : TeaModel {
                public long? Late { get; set; }
                public long? Lon { get; set; }
            }
            [NameInMap("PhoneNumbers")]
            [Validation(Required=false)]
            public List<string> PhoneNumbers { get; set; }
            [NameInMap("T")]
            [Validation(Required=false)]
            public HuichengTestApiRequestHomeT T { get; set; }
            public class HuichengTestApiRequestHomeT : TeaModel {
                /// <summary>
                /// class
                /// </summary>
                [NameInMap("Class")]
                [Validation(Required=false)]
                public string Class { get; set; }

            }
        };

        /// <summary>
        /// a
        /// </summary>
        [NameInMap("Fuccccc")]
        [Validation(Required=false)]
        public string Fuccccc { get; set; }

    }

}
