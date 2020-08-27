<?php

// This file is auto-generated, don't edit it. Thanks.
namespace AlibabaCloud\SDK\SDK_DATA_1598238000612\Models\AddOapiAttendanceShiftParams;

use AlibabaCloud\Tea\Model;

use AlibabaCloud\SDK\SDK_DATA_1598238000612\Models\AddOapiAttendanceShiftParams\shift\sections;
use AlibabaCloud\SDK\SDK_DATA_1598238000612\Models\AddOapiAttendanceShiftParams\shift\setting;

class shift extends Model {
    protected $_name = [
        'owner' => 'owner',
        'classGroupName' => 'class_group_name',
        'corpId' => 'corp_id',
        'name' => 'name',
        'id' => 'id',
        'sections' => 'sections',
        'setting' => 'setting',
    ];
    public function validate() {
        Model::validateRequired('name', $this->name, true);
        Model::validateRequired('sections', $this->sections, true);
    }
    public function toMap() {
        $res = [];
        if (null !== $this->owner) {
            $res['owner'] = $this->owner;
        }
        if (null !== $this->classGroupName) {
            $res['class_group_name'] = $this->classGroupName;
        }
        if (null !== $this->corpId) {
            $res['corp_id'] = $this->corpId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->sections) {
            $res['sections'] = [];
            if(null !== $this->sections && is_array($this->sections)){
                $n = 0;
                foreach($this->sections as $item){
                    $res['sections'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->setting) {
            $res['setting'] = null !== $this->setting ? $this->setting->toMap() : null;
        }
        return $res;
    }
    /**
     * @param array $map
     * @return shift
     */
    public static function fromMap($map = []) {
        $model = new self();
        if(isset($map['owner'])){
            $model->owner = $map['owner'];
        }
        if(isset($map['class_group_name'])){
            $model->classGroupName = $map['class_group_name'];
        }
        if(isset($map['corp_id'])){
            $model->corpId = $map['corp_id'];
        }
        if(isset($map['name'])){
            $model->name = $map['name'];
        }
        if(isset($map['id'])){
            $model->id = $map['id'];
        }
        if(isset($map['sections'])){
            if(!empty($map['sections'])){
                $model->sections = [];
                $n = 0;
                foreach($map['sections'] as $item) {
                    $model->sections[$n++] = null !== $item ? sections::fromMap($item) : $item;
                }
            }
        }
        if(isset($map['setting'])){
            $model->setting = setting::fromMap($map['setting']);
        }
        return $model;
    }
    /**
     * @description 班次owner
     * @var string
     */
    public $owner;

    /**
     * @description 班次组名
     * @var string
     */
    public $classGroupName;

    /**
     * @description corpId
     * @var string
     */
    public $corpId;

    /**
     * @description 班次名称
     * @var string
     */
    public $name;

    /**
     * @description 班次id
     * @var int
     */
    public $id;

    /**
     * @description sections
     * @var array
     */
    public $sections;

    /**
     * @description 设置
     * @var setting
     */
    public $setting;

}
