// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200101.models;

import com.aliyun.tea.*;

public class GetVersionRequest extends TeaModel {
    @NameInMap("Name")
    public String name;

    public static GetVersionRequest build(java.util.Map<String, ?> map) throws Exception {
        GetVersionRequest self = new GetVersionRequest();
        return TeaModel.build(map, self);
    }

    public GetVersionRequest setName(String name) {
        this.name = name;
        return this;
    }
    public String getName() {
        return this.name;
    }

}
