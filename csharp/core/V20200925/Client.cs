// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

using Tea;
using Tea.Utils;

using AlibabaCloud.SDK.Dingtalk20200925.Models;

namespace AlibabaCloud.SDK.Dingtalk20200925
{
    public class Client : AlibabaCloud.OpenApiClient.Client
    {

        public Client(AlibabaCloud.OpenApiClient.Models.Config config): base(config)
        {
            this._endpointRule = "";
            CheckConfig(config);
            this._endpoint = GetEndpoint("dingtalk", _regionId, _endpointRule, _network, _suffix, _endpointMap, _endpoint);
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

        public DetachDiskResponse DetachDiskWithOptions(DetachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDiskResponse>(DoRPCRequest("DetachDisk", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DetachDiskResponse> DetachDiskWithOptionsAsync(DetachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DetachDiskResponse>(await DoRPCRequestAsync("DetachDisk", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DetachDiskResponse DetachDisk(DetachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DetachDiskWithOptions(request, runtime);
        }

        public async Task<DetachDiskResponse> DetachDiskAsync(DetachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DetachDiskWithOptionsAsync(request, runtime);
        }

        public DeleteRulePassFullResponse DeleteRulePassFullWithOptions(DeleteRulePassFullRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRulePassFullResponse>(DoRPCRequest("DeleteRulePassFull", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteRulePassFullResponse> DeleteRulePassFullWithOptionsAsync(DeleteRulePassFullRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteRulePassFullResponse>(await DoRPCRequestAsync("DeleteRulePassFull", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteRulePassFullResponse DeleteRulePassFull(DeleteRulePassFullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteRulePassFullWithOptions(request, runtime);
        }

        public async Task<DeleteRulePassFullResponse> DeleteRulePassFullAsync(DeleteRulePassFullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteRulePassFullWithOptionsAsync(request, runtime);
        }

        public CreateRuleInstanceResponse CreateRuleInstanceWithOptions(CreateRuleInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleInstanceResponse>(DoRPCRequest("CreateRuleInstance", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRuleInstanceResponse> CreateRuleInstanceWithOptionsAsync(CreateRuleInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRuleInstanceResponse>(await DoRPCRequestAsync("CreateRuleInstance", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRuleInstanceResponse CreateRuleInstance(CreateRuleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRuleInstanceWithOptions(request, runtime);
        }

        public async Task<CreateRuleInstanceResponse> CreateRuleInstanceAsync(CreateRuleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRuleInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateRulePassFullResponse UpdateRulePassFullWithOptions(UpdateRulePassFullRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRulePassFullResponse>(DoRPCRequest("UpdateRulePassFull", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRulePassFullResponse> UpdateRulePassFullWithOptionsAsync(UpdateRulePassFullRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRulePassFullResponse>(await DoRPCRequestAsync("UpdateRulePassFull", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRulePassFullResponse UpdateRulePassFull(UpdateRulePassFullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRulePassFullWithOptions(request, runtime);
        }

        public async Task<UpdateRulePassFullResponse> UpdateRulePassFullAsync(UpdateRulePassFullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRulePassFullWithOptionsAsync(request, runtime);
        }

        public ListRulePassFullsResponse ListRulePassFullsWithOptions(ListRulePassFullsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRulePassFullsResponse>(DoRPCRequest("ListRulePassFulls", "2020-09-25", "HTTPS", "GET", "AK", "none", req, runtime));
        }

        public async Task<ListRulePassFullsResponse> ListRulePassFullsWithOptionsAsync(ListRulePassFullsRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListRulePassFullsResponse>(await DoRPCRequestAsync("ListRulePassFulls", "2020-09-25", "HTTPS", "GET", "AK", "none", req, runtime));
        }

        public ListRulePassFullsResponse ListRulePassFulls(ListRulePassFullsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListRulePassFullsWithOptions(request, runtime);
        }

        public async Task<ListRulePassFullsResponse> ListRulePassFullsAsync(ListRulePassFullsRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListRulePassFullsWithOptionsAsync(request, runtime);
        }

        public CreateVmInstanceResponse CreateVmInstanceWithOptions(CreateVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVmInstanceResponse>(DoRPCRequest("CreateVmInstance", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVmInstanceResponse> CreateVmInstanceWithOptionsAsync(CreateVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVmInstanceResponse>(await DoRPCRequestAsync("CreateVmInstance", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVmInstanceResponse CreateVmInstance(CreateVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVmInstanceWithOptions(request, runtime);
        }

        public async Task<CreateVmInstanceResponse> CreateVmInstanceAsync(CreateVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVmInstanceWithOptionsAsync(request, runtime);
        }

        public GetVmInstancesResponse GetVmInstancesWithOptions(GetVmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmInstancesResponse>(DoRPCRequest("GetVmInstances", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetVmInstancesResponse> GetVmInstancesWithOptionsAsync(GetVmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmInstancesResponse>(await DoRPCRequestAsync("GetVmInstances", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetVmInstancesResponse GetVmInstances(GetVmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVmInstancesWithOptions(request, runtime);
        }

        public async Task<GetVmInstancesResponse> GetVmInstancesAsync(GetVmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVmInstancesWithOptionsAsync(request, runtime);
        }

        public CreateVmInstancesResponse CreateVmInstancesWithOptions(CreateVmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVmInstancesResponse>(DoRPCRequest("CreateVmInstances", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateVmInstancesResponse> CreateVmInstancesWithOptionsAsync(CreateVmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateVmInstancesResponse>(await DoRPCRequestAsync("CreateVmInstances", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateVmInstancesResponse CreateVmInstances(CreateVmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateVmInstancesWithOptions(request, runtime);
        }

        public async Task<CreateVmInstancesResponse> CreateVmInstancesAsync(CreateVmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateVmInstancesWithOptionsAsync(request, runtime);
        }

        public GetVmInstanceResponse GetVmInstanceWithOptions(GetVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmInstanceResponse>(DoRPCRequest("GetVmInstance", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetVmInstanceResponse> GetVmInstanceWithOptionsAsync(GetVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetVmInstanceResponse>(await DoRPCRequestAsync("GetVmInstance", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetVmInstanceResponse GetVmInstance(GetVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetVmInstanceWithOptions(request, runtime);
        }

        public async Task<GetVmInstanceResponse> GetVmInstanceAsync(GetVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetVmInstanceWithOptionsAsync(request, runtime);
        }

        public CreateRulePassFullResponse CreateRulePassFullWithOptions(CreateRulePassFullRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRulePassFullResponse>(DoRPCRequest("CreateRulePassFull", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<CreateRulePassFullResponse> CreateRulePassFullWithOptionsAsync(CreateRulePassFullRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<CreateRulePassFullResponse>(await DoRPCRequestAsync("CreateRulePassFull", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public CreateRulePassFullResponse CreateRulePassFull(CreateRulePassFullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return CreateRulePassFullWithOptions(request, runtime);
        }

        public async Task<CreateRulePassFullResponse> CreateRulePassFullAsync(CreateRulePassFullRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await CreateRulePassFullWithOptionsAsync(request, runtime);
        }

        public UpdateRulePassResponse UpdateRulePassWithOptions(UpdateRulePassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRulePassResponse>(DoRPCRequest("UpdateRulePass", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<UpdateRulePassResponse> UpdateRulePassWithOptionsAsync(UpdateRulePassRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<UpdateRulePassResponse>(await DoRPCRequestAsync("UpdateRulePass", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public UpdateRulePassResponse UpdateRulePass(UpdateRulePassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateRulePassWithOptions(request, runtime);
        }

        public async Task<UpdateRulePassResponse> UpdateRulePassAsync(UpdateRulePassRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateRulePassWithOptionsAsync(request, runtime);
        }

        public AttachDiskResponse AttachDiskWithOptions(AttachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDiskResponse>(DoRPCRequest("AttachDisk", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<AttachDiskResponse> AttachDiskWithOptionsAsync(AttachDiskRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<AttachDiskResponse>(await DoRPCRequestAsync("AttachDisk", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public AttachDiskResponse AttachDisk(AttachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return AttachDiskWithOptions(request, runtime);
        }

        public async Task<AttachDiskResponse> AttachDiskAsync(AttachDiskRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await AttachDiskWithOptionsAsync(request, runtime);
        }

        public ListVmInstancesResponse ListVmInstancesWithOptions(ListVmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVmInstancesResponse>(DoRPCRequest("ListVmInstances", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<ListVmInstancesResponse> ListVmInstancesWithOptionsAsync(ListVmInstancesRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<ListVmInstancesResponse>(await DoRPCRequestAsync("ListVmInstances", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public ListVmInstancesResponse ListVmInstances(ListVmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return ListVmInstancesWithOptions(request, runtime);
        }

        public async Task<ListVmInstancesResponse> ListVmInstancesAsync(ListVmInstancesRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await ListVmInstancesWithOptionsAsync(request, runtime);
        }

        public GetRuleInstanceResponse GetRuleInstanceWithOptions(GetRuleInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetRuleInstanceResponse>(DoRPCRequest("GetRuleInstance", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<GetRuleInstanceResponse> GetRuleInstanceWithOptionsAsync(GetRuleInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<GetRuleInstanceResponse>(await DoRPCRequestAsync("GetRuleInstance", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public GetRuleInstanceResponse GetRuleInstance(GetRuleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return GetRuleInstanceWithOptions(request, runtime);
        }

        public async Task<GetRuleInstanceResponse> GetRuleInstanceAsync(GetRuleInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await GetRuleInstanceWithOptionsAsync(request, runtime);
        }

        public UpdateVmInstanceResponse UpdateVmInstanceWithOptions(UpdateVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateVmInstanceResponse>(DoRPCRequest("UpdateVmInstance", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public async Task<UpdateVmInstanceResponse> UpdateVmInstanceWithOptionsAsync(UpdateVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            Dictionary<string, string> query = AlibabaCloud.OpenApiUtil.Client.Query(AlibabaCloud.TeaUtil.Common.ToMap(request));
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Query = query,
            };
            return TeaModel.ToObject<UpdateVmInstanceResponse>(await DoRPCRequestAsync("UpdateVmInstance", "2020-09-25", "HTTPS", "GET", "AK", "json", req, runtime));
        }

        public UpdateVmInstanceResponse UpdateVmInstance(UpdateVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return UpdateVmInstanceWithOptions(request, runtime);
        }

        public async Task<UpdateVmInstanceResponse> UpdateVmInstanceAsync(UpdateVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await UpdateVmInstanceWithOptionsAsync(request, runtime);
        }

        public DeleteVmInstanceResponse DeleteVmInstanceWithOptions(DeleteVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVmInstanceResponse>(DoRPCRequest("DeleteVmInstance", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<DeleteVmInstanceResponse> DeleteVmInstanceWithOptionsAsync(DeleteVmInstanceRequest request, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(request);
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<DeleteVmInstanceResponse>(await DoRPCRequestAsync("DeleteVmInstance", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public DeleteVmInstanceResponse DeleteVmInstance(DeleteVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return DeleteVmInstanceWithOptions(request, runtime);
        }

        public async Task<DeleteVmInstanceResponse> DeleteVmInstanceAsync(DeleteVmInstanceRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await DeleteVmInstanceWithOptionsAsync(request, runtime);
        }

        public HuichengTestApiResponse HuichengTestApiWithOptions(HuichengTestApiRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HuichengTestApiShrinkRequest request = new HuichengTestApiShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Home.ToMap()))
            {
                request.HomeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Home.ToMap(), "Home", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HuichengTestApiResponse>(DoRPCRequest("HuichengTestApi", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public async Task<HuichengTestApiResponse> HuichengTestApiWithOptionsAsync(HuichengTestApiRequest tmpReq, AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime)
        {
            AlibabaCloud.TeaUtil.Common.ValidateModel(tmpReq);
            HuichengTestApiShrinkRequest request = new HuichengTestApiShrinkRequest();
            AlibabaCloud.OpenApiUtil.Client.Convert(tmpReq, request);
            if (!AlibabaCloud.TeaUtil.Common.IsUnset(tmpReq.Home.ToMap()))
            {
                request.HomeShrink = AlibabaCloud.OpenApiUtil.Client.ArrayToStringWithSpecifiedStyle(tmpReq.Home.ToMap(), "Home", "json");
            }
            AlibabaCloud.OpenApiClient.Models.OpenApiRequest req = new AlibabaCloud.OpenApiClient.Models.OpenApiRequest
            {
                Body = AlibabaCloud.TeaUtil.Common.ToMap(request),
            };
            return TeaModel.ToObject<HuichengTestApiResponse>(await DoRPCRequestAsync("HuichengTestApi", "2020-09-25", "HTTPS", "POST", "AK", "json", req, runtime));
        }

        public HuichengTestApiResponse HuichengTestApi(HuichengTestApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return HuichengTestApiWithOptions(request, runtime);
        }

        public async Task<HuichengTestApiResponse> HuichengTestApiAsync(HuichengTestApiRequest request)
        {
            AlibabaCloud.TeaUtil.Models.RuntimeOptions runtime = new AlibabaCloud.TeaUtil.Models.RuntimeOptions();
            return await HuichengTestApiWithOptionsAsync(request, runtime);
        }

    }
}
