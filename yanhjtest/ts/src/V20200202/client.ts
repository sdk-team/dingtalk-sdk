// This file is auto-generated, don't edit it
/**
 *
 */
import Util, * as $Util from '@alicloud/tea-util';
import OpenApi, * as $OpenApi from '@alicloud/openapi-client';
import OpenApiUtil from '@alicloud/openapi-util';
import EndpointUtil from '@alicloud/endpoint-util';
import * as $tea from '@alicloud/tea-typescript';

export class UpdateApiResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'RequestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class UpdateApiResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: UpdateApiResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: UpdateApiResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendCommondResponseBody extends $tea.Model {
  requestId?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'RequestId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class SendCommondResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: SendCommondResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: SendCommondResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllProductRequest extends $tea.Model {
  requestId?: string;
  product?: string;
  env?: string;
  static names(): { [key: string]: string } {
    return {
      requestId: 'RequestId',
      product: 'Product',
      env: 'Env',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      product: 'string',
      env: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllProductResponseBody extends $tea.Model {
  code?: string;
  data?: GetAllProductResponseBodyData;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'Code',
      data: 'Data',
      requestId: 'RequestId',
      success: 'Success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: GetAllProductResponseBodyData,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllProductResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetAllProductResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetAllProductResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProductByNameRequest extends $tea.Model {
  requestId?: string;
  market?: number;
  name?: string;
  empId?: number;
  static names(): { [key: string]: string } {
    return {
      requestId: 'RequestId',
      market: 'Market',
      name: 'Name',
      empId: 'EmpId',
    };
  }

  static types(): { [key: string]: any } {
    return {
      requestId: 'string',
      market: 'number',
      name: 'string',
      empId: 'number',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProductByNameResponseBody extends $tea.Model {
  code?: string;
  data?: GetProductByNameResponseBodyData;
  requestId?: string;
  success?: boolean;
  static names(): { [key: string]: string } {
    return {
      code: 'Code',
      data: 'Data',
      requestId: 'RequestId',
      success: 'Success',
    };
  }

  static types(): { [key: string]: any } {
    return {
      code: 'string',
      data: GetProductByNameResponseBodyData,
      requestId: 'string',
      success: 'boolean',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProductByNameResponse extends $tea.Model {
  headers: { [key: string]: string };
  body: GetProductByNameResponseBody;
  static names(): { [key: string]: string } {
    return {
      headers: 'headers',
      body: 'body',
    };
  }

  static types(): { [key: string]: any } {
    return {
      headers: { 'type': 'map', 'keyType': 'string', 'valueType': 'string' },
      body: GetProductByNameResponseBody,
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetAllProductResponseBodyData extends $tea.Model {
  description?: string;
  domains?: string[];
  nameSpace?: string;
  product?: string;
  type?: string;
  static names(): { [key: string]: string } {
    return {
      description: 'Description',
      domains: 'Domains',
      nameSpace: 'NameSpace',
      product: 'Product',
      type: 'Type',
    };
  }

  static types(): { [key: string]: any } {
    return {
      description: 'string',
      domains: { 'type': 'array', 'itemType': 'string' },
      nameSpace: 'string',
      product: 'string',
      type: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}

export class GetProductByNameResponseBodyData extends $tea.Model {
  title?: string;
  versions?: string[];
  name?: string;
  domain?: string;
  static names(): { [key: string]: string } {
    return {
      title: 'Title',
      versions: 'Versions',
      name: 'Name',
      domain: 'Domain',
    };
  }

  static types(): { [key: string]: any } {
    return {
      title: 'string',
      versions: { 'type': 'array', 'itemType': 'string' },
      name: 'string',
      domain: 'string',
    };
  }

  constructor(map?: { [key: string]: any }) {
    super(map);
  }
}


export default class Client extends OpenApi {

  constructor(config: $OpenApi.Config) {
    super(config);
    this._endpointRule = "";
    this.checkConfig(config);
    this._endpoint = this.getEndpoint("yanhjtest", this._regionId, this._endpointRule, this._network, this._suffix, this._endpointMap, this._endpoint);
  }


  getEndpoint(productId: string, regionId: string, endpointRule: string, network: string, suffix: string, endpointMap: {[key: string ]: string}, endpoint: string): string {
    if (!Util.empty(endpoint)) {
      return endpoint;
    }

    if (!Util.isUnset(endpointMap) && !Util.empty(endpointMap[regionId])) {
      return endpointMap[regionId];
    }

    return EndpointUtil.getEndpointRules(productId, regionId, endpointRule, network, suffix);
  }

  async updateApiWithOptions(runtime: $Util.RuntimeOptions): Promise<UpdateApiResponse> {
    let req = new $OpenApi.OpenApiRequest({ });
    return $tea.cast<UpdateApiResponse>(await this.doRPCRequest("UpdateApi", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime), new UpdateApiResponse({}));
  }

  async updateApi(): Promise<UpdateApiResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    return await this.updateApiWithOptions(runtime);
  }

  async sendCommondWithOptions(runtime: $Util.RuntimeOptions): Promise<SendCommondResponse> {
    let req = new $OpenApi.OpenApiRequest({ });
    return $tea.cast<SendCommondResponse>(await this.doRPCRequest("SendCommond", "2020-02-02", "HTTPS", "POST", "AK", "json", req, runtime), new SendCommondResponse({}));
  }

  async sendCommond(): Promise<SendCommondResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    return await this.sendCommondWithOptions(runtime);
  }

  async getAllProductWithOptions(request: GetAllProductRequest, runtime: $Util.RuntimeOptions): Promise<GetAllProductResponse> {
    Util.validateModel(request);
    let query = OpenApiUtil.query(Util.toMap(request));
    let req = new $OpenApi.OpenApiRequest({
      query: query,
    });
    return $tea.cast<GetAllProductResponse>(await this.doRPCRequest("GetAllProduct", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime), new GetAllProductResponse({}));
  }

  async getAllProduct(request: GetAllProductRequest): Promise<GetAllProductResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    return await this.getAllProductWithOptions(request, runtime);
  }

  async getProductByNameWithOptions(request: GetProductByNameRequest, runtime: $Util.RuntimeOptions): Promise<GetProductByNameResponse> {
    Util.validateModel(request);
    let query = OpenApiUtil.query(Util.toMap(request));
    let req = new $OpenApi.OpenApiRequest({
      query: query,
    });
    return $tea.cast<GetProductByNameResponse>(await this.doRPCRequest("GetProductByName", "2020-02-02", "HTTPS", "GET", "AK", "json", req, runtime), new GetProductByNameResponse({}));
  }

  async getProductByName(request: GetProductByNameRequest): Promise<GetProductByNameResponse> {
    let runtime = new $Util.RuntimeOptions({ });
    return await this.getProductByNameWithOptions(request, runtime);
  }

}
