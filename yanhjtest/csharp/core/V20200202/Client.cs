// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.YanhjTest20200202.Models;

namespace AlibabaCloud.SDK.YanhjTest20200202
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("yanhjtest", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
        }


        public string GetEndpoint(string productId, string regionId, string endpointRule, string network, string suffix, Dictionary<string, string> endpointMap, string endpoint)
        {
            if (!AlibabaCloud.TeaUtil.Common.Empty(endpoint))
            {
                return endpoint;
            }
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(endpointMap) && !AlibabaCloud.TeaUtil.Common.Empty(endpointMap.Get(regionId)))
            {
                return endpointMap.Get(regionId);
            }
            return AlibabaCloud.EndpointUtil.Common.GetEndpointRules(productId, regionId, endpointRule, network, suffix);
        }

        public UpdateApiResponse UpdateApiWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<UpdateApiResponse>(DoRPCRequest("UpdateApi", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateApiResponse> UpdateApiWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<UpdateApiResponse>(await DoRPCRequestAsync("UpdateApi", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateApiResponse UpdateApi()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateApiWithOptions(runtime);
        }

        public async Task<UpdateApiResponse> UpdateApiAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateApiWithOptionsAsync(runtime);
        }

        public SendCommondResponse SendCommondWithOptions(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<SendCommondResponse>(DoRPCRequest("SendCommond", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<SendCommondResponse> SendCommondWithOptionsAsync(AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest();
            return TeaModel.ToObject<SendCommondResponse>(await DoRPCRequestAsync("SendCommond", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public SendCommondResponse SendCommond()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return SendCommondWithOptions(runtime);
        }

        public async Task<SendCommondResponse> SendCommondAsync()
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await SendCommondWithOptionsAsync(runtime);
        }

        public GetAllProductResponse GetAllProductWithOptions(GetAllProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllProductResponse>(DoRPCRequest("GetAllProduct", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetAllProductResponse> GetAllProductWithOptionsAsync(GetAllProductRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetAllProductResponse>(await DoRPCRequestAsync("GetAllProduct", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetAllProductResponse GetAllProduct(GetAllProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetAllProductWithOptions(request, runtime);
        }

        public async Task<GetAllProductResponse> GetAllProductAsync(GetAllProductRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetAllProductWithOptionsAsync(request, runtime);
        }

        public GetProductByNameResponse GetProductByNameWithOptions(GetProductByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetProductByNameResponse>(DoRPCRequest("GetProductByName", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetProductByNameResponse> GetProductByNameWithOptionsAsync(GetProductByNameRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetProductByNameResponse>(await DoRPCRequestAsync("GetProductByName", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetProductByNameResponse GetProductByName(GetProductByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetProductByNameWithOptions(request, runtime);
        }

        public async Task<GetProductByNameResponse> GetProductByNameAsync(GetProductByNameRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetProductByNameWithOptionsAsync(request, runtime);
        }

    }
}
