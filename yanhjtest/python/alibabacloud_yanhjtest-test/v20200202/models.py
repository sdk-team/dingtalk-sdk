# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
try:
    from typing import Dict, List
except ImportError:
    pass


class UpdateApiResponseBody(TeaModel):
    def __init__(self, request_id=None):
        # Id of the request
        self.request_id = request_id    # type: str

    def validate(self):
        pass

    def to_map(self):
        result = {}
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        return result

    def from_map(self, map={}):
        if map.get('RequestId') is not None:
            self.request_id = map.get('RequestId')
        return self


class UpdateApiResponse(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = headers          # type: Dict[str, str]
        self.body = body                # type: UpdateApiResponseBody

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, map={}):
        if map.get('headers') is not None:
            self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = UpdateApiResponseBody()
            self.body = temp_model.from_map(map['body'])
        return self


class SendCommondResponseBody(TeaModel):
    def __init__(self, request_id=None):
        # Id of the request
        self.request_id = request_id    # type: str

    def validate(self):
        pass

    def to_map(self):
        result = {}
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        return result

    def from_map(self, map={}):
        if map.get('RequestId') is not None:
            self.request_id = map.get('RequestId')
        return self


class SendCommondResponse(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = headers          # type: Dict[str, str]
        self.body = body                # type: SendCommondResponseBody

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, map={}):
        if map.get('headers') is not None:
            self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = SendCommondResponseBody()
            self.body = temp_model.from_map(map['body'])
        return self


class GetAllProductRequest(TeaModel):
    def __init__(self, request_id=None, product=None, env=None):
        # requestId
        self.request_id = request_id    # type: str
        # pop产品
        self.product = product          # type: str
        # 环境
        self.env = env                  # type: str

    def validate(self):
        pass

    def to_map(self):
        result = {}
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        if self.product is not None:
            result['Product'] = self.product
        if self.env is not None:
            result['Env'] = self.env
        return result

    def from_map(self, map={}):
        if map.get('RequestId') is not None:
            self.request_id = map.get('RequestId')
        if map.get('Product') is not None:
            self.product = map.get('Product')
        if map.get('Env') is not None:
            self.env = map.get('Env')
        return self


class GetAllProductResponseBody(TeaModel):
    def __init__(self, code=None, data=None, request_id=None, success=None):
        # code
        self.code = code                # type: str
        # 产品信息
        self.data = data                # type: GetAllProductResponseBodyData
        # Id of the request
        self.request_id = request_id    # type: str
        # success
        self.success = success          # type: bool

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        result = {}
        if self.code is not None:
            result['Code'] = self.code
        if self.data is not None:
            result['Data'] = self.data.to_map()
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        if self.success is not None:
            result['Success'] = self.success
        return result

    def from_map(self, map={}):
        if map.get('Code') is not None:
            self.code = map.get('Code')
        if map.get('Data') is not None:
            temp_model = GetAllProductResponseBodyData()
            self.data = temp_model.from_map(map['Data'])
        if map.get('RequestId') is not None:
            self.request_id = map.get('RequestId')
        if map.get('Success') is not None:
            self.success = map.get('Success')
        return self


class GetAllProductResponseBodyData(TeaModel):
    def __init__(self, description=None, domains=None, name_space=None, product=None, type=None):
        # description
        self.description = description  # type: str
        # 域名
        self.domains = domains          # type: List[str]
        # nameSpace
        self.name_space = name_space    # type: str
        # product
        self.product = product          # type: str
        # type
        self.type = type                # type: str

    def validate(self):
        pass

    def to_map(self):
        result = {}
        if self.description is not None:
            result['Description'] = self.description
        if self.domains is not None:
            result['Domains'] = self.domains
        if self.name_space is not None:
            result['NameSpace'] = self.name_space
        if self.product is not None:
            result['Product'] = self.product
        if self.type is not None:
            result['Type'] = self.type
        return result

    def from_map(self, map={}):
        if map.get('Description') is not None:
            self.description = map.get('Description')
        if map.get('Domains') is not None:
            self.domains = map.get('Domains')
        if map.get('NameSpace') is not None:
            self.name_space = map.get('NameSpace')
        if map.get('Product') is not None:
            self.product = map.get('Product')
        if map.get('Type') is not None:
            self.type = map.get('Type')
        return self


class GetAllProductResponse(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = headers          # type: Dict[str, str]
        self.body = body                # type: GetAllProductResponseBody

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, map={}):
        if map.get('headers') is not None:
            self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetAllProductResponseBody()
            self.body = temp_model.from_map(map['body'])
        return self


class GetProductByNameRequest(TeaModel):
    def __init__(self, request_id=None, market=None, name=None, emp_id=None):
        # requestId
        self.request_id = request_id    # type: str
        # market
        self.market = market            # type: int
        # name
        self.name = name                # type: str
        # bucUid
        self.emp_id = emp_id            # type: int

    def validate(self):
        pass

    def to_map(self):
        result = {}
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        if self.market is not None:
            result['Market'] = self.market
        if self.name is not None:
            result['Name'] = self.name
        if self.emp_id is not None:
            result['EmpId'] = self.emp_id
        return result

    def from_map(self, map={}):
        if map.get('RequestId') is not None:
            self.request_id = map.get('RequestId')
        if map.get('Market') is not None:
            self.market = map.get('Market')
        if map.get('Name') is not None:
            self.name = map.get('Name')
        if map.get('EmpId') is not None:
            self.emp_id = map.get('EmpId')
        return self


class GetProductByNameResponseBody(TeaModel):
    def __init__(self, code=None, data=None, request_id=None, success=None):
        # code
        self.code = code                # type: str
        # 产品信息
        self.data = data                # type: GetProductByNameResponseBodyData
        # Id of the request
        self.request_id = request_id    # type: str
        # success
        self.success = success          # type: bool

    def validate(self):
        if self.data:
            self.data.validate()

    def to_map(self):
        result = {}
        if self.code is not None:
            result['Code'] = self.code
        if self.data is not None:
            result['Data'] = self.data.to_map()
        if self.request_id is not None:
            result['RequestId'] = self.request_id
        if self.success is not None:
            result['Success'] = self.success
        return result

    def from_map(self, map={}):
        if map.get('Code') is not None:
            self.code = map.get('Code')
        if map.get('Data') is not None:
            temp_model = GetProductByNameResponseBodyData()
            self.data = temp_model.from_map(map['Data'])
        if map.get('RequestId') is not None:
            self.request_id = map.get('RequestId')
        if map.get('Success') is not None:
            self.success = map.get('Success')
        return self


class GetProductByNameResponseBodyData(TeaModel):
    def __init__(self, title=None, versions=None, name=None, domain=None):
        # title
        self.title = title              # type: str
        # 版本
        self.versions = versions        # type: List[str]
        # name
        self.name = name                # type: str
        # domain
        self.domain = domain            # type: str

    def validate(self):
        pass

    def to_map(self):
        result = {}
        if self.title is not None:
            result['Title'] = self.title
        if self.versions is not None:
            result['Versions'] = self.versions
        if self.name is not None:
            result['Name'] = self.name
        if self.domain is not None:
            result['Domain'] = self.domain
        return result

    def from_map(self, map={}):
        if map.get('Title') is not None:
            self.title = map.get('Title')
        if map.get('Versions') is not None:
            self.versions = map.get('Versions')
        if map.get('Name') is not None:
            self.name = map.get('Name')
        if map.get('Domain') is not None:
            self.domain = map.get('Domain')
        return self


class GetProductByNameResponse(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = headers          # type: Dict[str, str]
        self.body = body                # type: GetProductByNameResponseBody

    def validate(self):
        self.validate_required(self.headers, 'headers')
        self.validate_required(self.body, 'body')
        if self.body:
            self.body.validate()

    def to_map(self):
        result = {}
        if self.headers is not None:
            result['headers'] = self.headers
        if self.body is not None:
            result['body'] = self.body.to_map()
        return result

    def from_map(self, map={}):
        if map.get('headers') is not None:
            self.headers = map.get('headers')
        if map.get('body') is not None:
            temp_model = GetProductByNameResponseBody()
            self.body = temp_model.from_map(map['body'])
        return self
