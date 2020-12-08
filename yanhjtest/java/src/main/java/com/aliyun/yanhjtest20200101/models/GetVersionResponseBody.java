// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200101.models;

import com.aliyun.tea.*;

public class GetVersionResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("RequestId")
    public String requestId;

    public static GetVersionResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetVersionResponseBody self = new GetVersionResponseBody();
        return TeaModel.build(map, self);
    }

    public GetVersionResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
