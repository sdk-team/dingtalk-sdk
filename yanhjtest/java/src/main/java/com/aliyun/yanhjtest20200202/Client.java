// This file is auto-generated, don't edit it. Thanks.
package com.aliyun.yanhjtest20200202;

import com.aliyun.tea.*;
import com.aliyun.yanhjtest20200202.models.*;

public class Client extends com.aliyun.teaopenapi.Client {

    public Client(com.aliyun.teaopenapi.models.Config config) throws Exception {
        super(config);
        this._endpointRule = "";
        this.checkConfig(config);
        this._endpoint = this.getEndpoint("yanhjtest", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
    }


    public String getEndpoint(String productId, String regionId, String endpointRule, String network, String suffix, java.util.Map<String, String> endpointMap, String endpoint) throws Exception {
        if (!com.aliyun.teautil.Common.empty(endpoint)) {
            return endpoint;
        }

        if (!com.aliyun.teautil.Common.isUnset(endpointMap) && !com.aliyun.teautil.Common.empty(endpointMap.get(regionId))) {
            return endpointMap.get(regionId);
        }

        return com.aliyun.endpointutil.Client.getEndpointRules(productId, regionId, endpointRule, network, suffix);
    }

    public UpdateApiResponse updateApiWithOptions(com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = new com.aliyun.teaopenapi.models.OpenApiRequest();
        return TeaModel.toModel(this.doRPCRequest("UpdateApi", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime), new UpdateApiResponse());
    }

    public UpdateApiResponse updateApi() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        return this.updateApiWithOptions(runtime);
    }

    public SendCommondResponse sendCommondWithOptions(com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teaopenapi.models.OpenApiRequest req = new com.aliyun.teaopenapi.models.OpenApiRequest();
        return TeaModel.toModel(this.doRPCRequest("SendCommond", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime), new SendCommondResponse());
    }

    public SendCommondResponse sendCommond() throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        return this.sendCommondWithOptions(runtime);
    }

    public GetAllProductResponse getAllProductWithOptions(GetAllProductRequest request, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> query = com.aliyun.openapiutil.Client.query(com.aliyun.teautil.Common.toMap(request));
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("query", query)
        ));
        return TeaModel.toModel(this.doRPCRequest("GetAllProduct", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime), new GetAllProductResponse());
    }

    public GetAllProductResponse getAllProduct(GetAllProductRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        return this.getAllProductWithOptions(request, runtime);
    }

    public GetProductByNameResponse getProductByNameWithOptions(GetProductByNameRequest request, com.aliyun.teautil.models.RuntimeOptions runtime) throws Exception {
        com.aliyun.teautil.Common.validateModel(request);
        java.util.Map<String, String> query = com.aliyun.openapiutil.Client.query(com.aliyun.teautil.Common.toMap(request));
        com.aliyun.teaopenapi.models.OpenApiRequest req = com.aliyun.teaopenapi.models.OpenApiRequest.build(TeaConverter.buildMap(
            new TeaPair("query", query)
        ));
        return TeaModel.toModel(this.doRPCRequest("GetProductByName", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime), new GetProductByNameResponse());
    }

    public GetProductByNameResponse getProductByName(GetProductByNameRequest request) throws Exception {
        com.aliyun.teautil.models.RuntimeOptions runtime = new com.aliyun.teautil.models.RuntimeOptions();
        return this.getProductByNameWithOptions(request, runtime);
    }
}
