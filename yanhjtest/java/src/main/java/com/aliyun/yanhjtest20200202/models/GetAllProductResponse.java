// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class GetAllProductResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetAllProductResponseBody body;

    public static GetAllProductResponse build(java.util.Map<String, ?> map) throws Exception {
        GetAllProductResponse self = new GetAllProductResponse();
        return TeaModel.build(map, self);
    }

    public GetAllProductResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetAllProductResponse setBody(GetAllProductResponseBody body) {
        this.body = body;
        return this;
    }
    public GetAllProductResponseBody getBody() {
        return this.body;
    }

}
