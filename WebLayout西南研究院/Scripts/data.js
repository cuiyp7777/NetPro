//导航一
var Accord_content_1 = [
    { "id": "t1_1", "content": "采气工艺" },
    { "id": "t1_2", "content": "地面工程" },
    { "id": "t1_3", "content": "生物除硫" }
];
//采气工艺
var Accord_data_1 = [
    {
        "id": "t1_1_tp", "text": '积液诊断', state: 'open', children: [
           { "id": "t1_1_jyzd", "text": '积液查询', "href": "Gyjk/cqgy_jyzd_cx.html" }
        ]
    },
    {
        "id": "t1_1_gylc", "text": '泡排加注自控', state: 'open', children: [
           { "id": "t1_1_ppjz", "text": '泡排加注查询', "href": "Gyjk/cqgy_ppjz_cx.html" }
        ]
    }
    ,
    {
        "id": "t1_1_gylc", "text": '柱塞气举自控', state: 'open', children: [
           { "id": "t1_1_ssqj", "text": '柱塞气举查询', "href": "Gyjk/cqgy_zsqj_cx.html" }
        ]
    }
];
//地面工程
var Accord_data_2 = [
    {
        "id": "t1_2_gylc", "text": '多相流试验数据', state: 'open', children: [
           { "id": "t1_1_dxl", "text": '详细查询', "href": "Gyjk/dmjs_dxl_cx.html" }
        ]
    }
    ,
    {
        "id": "t1_2_gylc", "text": '引射试验数据', state: 'open', children: [
           { "id": "t1_1_yssy", "text": '数据查询', "href": "Gyjk/dmjs_yssy_cx.html" }
        ]
    }
];
//生物除硫
var Accord_data_3 = [
    {
        "id": "t1_2_gylc", "text": '水样查询', state: 'open', "href": "Gyjk/swcl_cx.html"
    }
];
//导航二
var Accord_content_2 = [
    { "id": "t2_1", "content": "设备监控" }
];
//设备监控
var Accord_data2_1 = [
    {
        "id": "t2_1_sb", "text": '设备列表', state: 'open', children: [
           { "id": "t2_1_zdzj", "text": '自动注剂装备', "href": "yckz/sbjk_zdzj.html" },
           { "id": "t2_1_zsqj", "text": '柱塞气举远控设备', "href": "yckz/sbjk_zsqj.html" },
        ]
    }
    , {
        "id": "t2_2_sb", "text": '样板设备', state: 'open', children: [
           { "id": "t2_2_ybsb", "text": '样板表', "href": "Yckz/sbjk_cx.html" }
        ]
    }
];

//导航三 预警处置
var Accord_content_3 = [
    { "id": "t3_1", "content": "预警处置" }
];
//采气工艺
var Accord_data_3_1 = [
    {
        "id": "t3_1_yj", "text": '预警管理', state: 'open', children: [
           { "id": "t3_1_yj_rwgl", "text": '任务管理', "href": "Yjgl/rwgl_cx.html" }
        ]
    }
];