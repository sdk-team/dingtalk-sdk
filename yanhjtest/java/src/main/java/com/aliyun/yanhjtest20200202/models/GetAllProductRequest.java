// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class GetAllProductRequest extends TeaModel {
    // requestId
    @NameInMap("RequestId")
    public String requestId;

    // pop产品
    @NameInMap("Product")
    public String product;

    // 环境
    @NameInMap("Env")
    public String env;

    public static GetAllProductRequest build(java.util.Map<String, ?> map) throws Exception {
        GetAllProductRequest self = new GetAllProductRequest();
        return TeaModel.build(map, self);
    }

    public GetAllProductRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetAllProductRequest setProduct(String product) {
        this.product = product;
        return this;
    }
    public String getProduct() {
        return this.product;
    }

    public GetAllProductRequest setEnv(String env) {
        this.env = env;
        return this;
    }
    public String getEnv() {
        return this.env;
    }

}
