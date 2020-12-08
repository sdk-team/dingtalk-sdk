// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class GetProductByNameResponse extends TeaModel {
    @NameInMap("headers")
    @Validation(required = true)
    public java.util.Map<String, String> headers;

    @NameInMap("body")
    @Validation(required = true)
    public GetProductByNameResponseBody body;

    public static GetProductByNameResponse build(java.util.Map<String, ?> map) throws Exception {
        GetProductByNameResponse self = new GetProductByNameResponse();
        return TeaModel.build(map, self);
    }

    public GetProductByNameResponse setHeaders(java.util.Map<String, String> headers) {
        this.headers = headers;
        return this;
    }
    public java.util.Map<String, String> getHeaders() {
        return this.headers;
    }

    public GetProductByNameResponse setBody(GetProductByNameResponseBody body) {
        this.body = body;
        return this;
    }
    public GetProductByNameResponseBody getBody() {
        return this.body;
    }

}
