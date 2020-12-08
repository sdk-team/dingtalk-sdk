# -*- coding: utf-8 -*-
# This file is auto-generated, don't edit it. Thanks.
from Tea.model import TeaModel
try:
    from typing import Dict
except ImportError:
    pass


class GetVersionRequest(TeaModel):
    def __init__(self, name=None):
        self.name = name                # type: str

    def validate(self):
        pass

    def to_map(self):
        result = {}
        if self.name is not None:
            result['Name'] = self.name
        return result

    def from_map(self, map={}):
        if map.get('Name') is not None:
            self.name = map.get('Name')
        return self


class GetVersionResponseBody(TeaModel):
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


class GetVersionResponse(TeaModel):
    def __init__(self, headers=None, body=None):
        self.headers = headers          # type: Dict[str, str]
        self.body = body                # type: GetVersionResponseBody

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
            temp_model = GetVersionResponseBody()
            self.body = temp_model.from_map(map['body'])
        return self
