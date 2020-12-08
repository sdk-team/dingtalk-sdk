// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class GetAllProductResponseBody extends TeaModel {
    // code
    @NameInMap("Code")
    public String code;

    // 产品信息
    @NameInMap("Data")
    public GetAllProductResponseBodyData data;

    // Id of the request
    @NameInMap("RequestId")
    public String requestId;

    // success
    @NameInMap("Success")
    public Boolean success;

    public static GetAllProductResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetAllProductResponseBody self = new GetAllProductResponseBody();
        return TeaModel.build(map, self);
    }

    public GetAllProductResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetAllProductResponseBody setData(GetAllProductResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetAllProductResponseBodyData getData() {
        return this.data;
    }

    public GetAllProductResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetAllProductResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetAllProductResponseBodyData extends TeaModel {
        // description
        @NameInMap("Description")
        public String description;

        // 域名
        @NameInMap("Domains")
        public java.util.List<String> domains;

        // nameSpace
        @NameInMap("NameSpace")
        public String nameSpace;

        // product
        @NameInMap("Product")
        public String product;

        // type
        @NameInMap("Type")
        public String type;

        public static GetAllProductResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetAllProductResponseBodyData self = new GetAllProductResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetAllProductResponseBodyData setDescription(String description) {
            this.description = description;
            return this;
        }
        public String getDescription() {
            return this.description;
        }

        public GetAllProductResponseBodyData setDomains(java.util.List<String> domains) {
            this.domains = domains;
            return this;
        }
        public java.util.List<String> getDomains() {
            return this.domains;
        }

        public GetAllProductResponseBodyData setNameSpace(String nameSpace) {
            this.nameSpace = nameSpace;
            return this;
        }
        public String getNameSpace() {
            return this.nameSpace;
        }

        public GetAllProductResponseBodyData setProduct(String product) {
            this.product = product;
            return this;
        }
        public String getProduct() {
            return this.product;
        }

        public GetAllProductResponseBodyData setType(String type) {
            this.type = type;
            return this;
        }
        public String getType() {
            return this.type;
        }

    }

}
