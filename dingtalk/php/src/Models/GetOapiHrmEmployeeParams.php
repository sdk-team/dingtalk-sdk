<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\SDK_DATA_1598238000612\Models;

use AlibabaCloud\Tea\Model;

class GetOapiHrmEmployeeParams extends Model {
    protected $_name = [
        'userid' => 'userid',
    ];
    public function validate() {
        Model::validateRequired('userid', $this->userid, true);
    }
    public function toMap() {
        $res = [];
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }
        return $res;
    }
    /**
     * @param array $map
     * @return GetOapiHrmEmployeeParams
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['userid'])){
            $model->userid = $map['userid'];
        }
        return $model;
    }
    /**
     * @description 查询用户userid
     * @var string
     */
    public $userid;

}
