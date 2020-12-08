// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class SendCommondResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public SendCommondResponseBody body;

    public static SendCommondResponse build(java.util.Map<String, ?> map) throws Exception {
        SendCommondResponse self = new SendCommondResponse();
        return TeaModel.build(map, self);
    }

    public SendCommondResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public SendCommondResponse setBody(SendCommondResponseBody body) {
        this.body = body;
        return this;
    }
    public SendCommondResponseBody getBody() {
        return this.body;
    }

}
