// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202.models;

import com.aliyun.tea.*;

public class GetProductByNameRequest extends TeaModel {
    // requestId
    @NameInMap("RequestId")
    public String requestId;

    // market
    @NameInMap("Market")
    public Integer market;

    // name
    @NameInMap("Name")
    public String name;

    // bucUid
    @NameInMap("EmpId")
    public Long empId;

    public static GetProductByNameRequest build(java.util.Map<String, ?> map) throws Exception {
        GetProductByNameRequest self = new GetProductByNameRequest();
        return TeaModel.build(map, self);
    }

    public GetProductByNameRequest setRequestId(String requestId) {
        this.requestId = requestId;
        return this;
    }
    public String getRequestId() {
        return this.requestId;
    }

    public GetProductByNameRequest setMarket(Integer market) {
        this.market = market;
        return this;
    }
    public Integer getMarket() {
        return this.market;
    }

    public GetProductByNameRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

    public GetProductByNameRequest setEmpId(Long empId) {
        this.empId = empId;
        return this;
    }
    public Long getEmpId() {
        return this.empId;
    }

}
