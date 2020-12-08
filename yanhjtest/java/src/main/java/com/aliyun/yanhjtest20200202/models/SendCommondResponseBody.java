// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class SendCommondResponseBody extends TeaModel {
    // Id of the request
    @NameInMap("RequestId")
    public String requestId;

    public static SendCommondResponseBody build(java.util.Map<String, ?> map) throws Exception {
        SendCommondResponseBody self = new SendCommondResponseBody();
        return TeaModel.build(map, self);
    }

    public SendCommondResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

}
