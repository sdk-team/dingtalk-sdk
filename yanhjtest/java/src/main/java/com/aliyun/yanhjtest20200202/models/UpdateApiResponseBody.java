// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class UpdateApiResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("RequestId")
    public String requestId;

    public static UpdateApiResponseBody build(java.util.Map<String, ?> map) throws Exception {
        UpdateApiResponseBody self = new UpdateApiResponseBody();
        return TeaModel.build(map, self);
    }

    public UpdateApiResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
