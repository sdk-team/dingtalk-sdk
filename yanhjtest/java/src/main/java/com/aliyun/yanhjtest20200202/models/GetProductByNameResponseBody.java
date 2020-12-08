// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class GetProductByNameResponseBody extends TeaModel {
    // code
    @NameInMap("Code")
    public String code;

    // 产品信息
    @NameInMap("Data")
    public GetProductByNameResponseBodyData data;

    // Id of the request
    @NameInMap("RequestId")
    public String requestId;

    // success
    @NameInMap("Success")
    public Boolean success;

    public static GetProductByNameResponseBody build(java.util.Map<String, ?> map) throws Exception {
        GetProductByNameResponseBody self = new GetProductByNameResponseBody();
        return TeaModel.build(map, self);
    }

    public GetProductByNameResponseBody setCode(String code) {
        this.code = code;
        return this;
    }
    public String getCode() {
        return this.code;
    }

    public GetProductByNameResponseBody setData(GetProductByNameResponseBodyData data) {
        this.data = data;
        return this;
    }
    public GetProductByNameResponseBodyData getData() {
        return this.data;
    }

    public GetProductByNameResponseBody setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetProductByNameResponseBody setSuccess(Boolean success) {
        this.success = success;
        return this;
    }
    public Boolean getSuccess() {
        return this.success;
    }

    public static class GetProductByNameResponseBodyData extends TeaModel {
        // title
        @NameInMap("Title")
        public String title;

        // 版本
        @NameInMap("Versions")
        public java.util.List<String> versions;

        // name
        @NameInMap("Name")
        public String name;

        // domain
        @NameInMap("Domain")
        public String domain;

        public static GetProductByNameResponseBodyData build(java.util.Map<String, ?> map) throws Exception {
            GetProductByNameResponseBodyData self = new GetProductByNameResponseBodyData();
            return TeaModel.build(map, self);
        }

        public GetProductByNameResponseBodyData setTitle(String title) {
            this.title = title;
            return this;
        }
        public String getTitle() {
            return this.title;
        }

        public GetProductByNameResponseBodyData setVersions(java.util.List<String> versions) {
            this.versions = versions;
            return this;
        }
        public java.util.List<String> getVersions() {
            return this.versions;
        }

        public GetProductByNameResponseBodyData setName(String name) {
            this.name = name;
            return this;
        }
        public String getName() {
            return this.name;
        }

        public GetProductByNameResponseBodyData setDomain(String domain) {
            this.domain = domain;
            return this;
        }
        public String getDomain() {
            return this.domain;
        }

    }

}
