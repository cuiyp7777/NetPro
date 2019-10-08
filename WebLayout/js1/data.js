//第一个导航的琴列，及琴下内容
var Accord_content_1 = [
    { "id": "t1_1", "content": "能流可视" },
    { "id": "t1_2", "content": "仪表直采参数" },
    { "id": "t1_3", "content": "基础能耗指标" },
    { "id": "t1_4", "content": "复合能耗指标" },
    { "id": "t1_5", "content": "能耗查询" }
];
var Accord_data_1 = [
   {
       "id": "t1_1_nl", "text": '能流图', state: 'open', children: [
              { "id": "t1_1_nl1", "text": '电力能流1', "href": "content1/dl/dl_sankey.html" },
              { "id": "t1_1_nl2", "text": '电力能流2', "href": "content1/dl/dl_nll_sankey.html" },
              { "id": "t1_1_nl3", "text": '水能流1', "href": "content1/dl/ys_sankey.html" },
              { "id": "t1_1_nl4", "text": '气能流1', "href": "content1/dl/yq_sankey.html" },
              { "id": "t1_1_nl5", "text": '气能流2', "href": "content1/dl/yq_nll_sankey.html" },
              { "id": "t1_1_nl6", "text": '整体能流1', "href": "content1/dl/nh_sankey.html" },
              { "id": "t1_1_nl7", "text": '整体能流2', "href": "content1/dl/nh_nll_sankey.html" }
       ]
   },
    {
        "id": "t1_1_tp", "text": '系统拓扑图', state: 'open', children: [
           { "id": "t1_1_tp1", "text": '电力系统', "href": "dl/dl_show.html" },
           { "id": "t1_1_tp2", "text": '输气系统', "href": "nxpj/sczt_dy_zs.html" },
           { "id": "t1_1_tp3", "text": '供水系统', "href": "nxpj/sczt_dy_zs.html" },
        ]
    },
    {
        "id": "t1_1_gylc", "text": '站库工艺流程图', state: 'open', children: [
           { "id": "t1_1_gylc1", "text": '电力流程', "href": "nxpj/sczt_jsyy.html" },
           { "id": "t1_1_gylc2", "text": '站库流程', "href": "nxpj/sczt_jsyy.html" }
        ]
    }
];
//第二个导航的琴列，及琴下内容
var Accord_content_2 = [
    { "id": "t2_1", "content": "首页" },
    { "id": "t2_2", "content": "举升报警" },
    { "id": "t2_3", "content": "注水报警" },
    { "id": "t2_4", "content": "集输报警" }
];
//首页
var Accord_data2 = [
    { "id": "t2_1_1", "text": '首页', "href": "erji/nxbj/nxbj_1_1.html" }
];
//举升报警
var Accord_data2_2 = [
    { "id": "t2_2_1", "text": '报警处置', "href": "erji/nxbj/nxbj_2_1.html" },
    { "id": "t2_2_2", "text": '报警记录', "href": "erji/nxbj/nxbj_2_2.html" },
    { "id": "t2_2_3", "text": '阈值设置', "href": "erji/nxbj/nxbj_2_3.html" }
];
//注水报警
var Accord_data2_3 = [
    { "id": "t2_3_1", "text": '报警处置', "href": "erji/nxbj/nxbj_3_1.html" },
    { "id": "t2_3_2", "text": '报警记录', "href": "erji/nxbj/nxbj_3_2.html" },
    { "id": "t2_3_3", "text": '阈值设置', "href": "erji/nxbj/nxbj_3_3.html" }
];

//集输报警
var Accord_data2_4 = [
    { "id": "t2_4_1", "text": '报警处置', "href": "erji/nxbj/nxbj_4_1.html" },
    { "id": "t2_4_2", "text": '报警记录', "href": "erji/nxbj/nxbj_4_2.html" },
    { "id": "t2_4_3", "text": '阈值设置', "href": "erji/nxbj/nxbj_4_3.html" }
];




//分析评价
var Accord_content_3 = [
    { "id": "t3_1", "content": "举升系统" },
    { "id": "t3_2", "content": "注水系统" },
    { "id": "t3_3", "content": "集输系统" }
];
//举升系统
var Accord_data_3 = [
    {
        "id": "t3_3_gb", "text": '运行状态', state: 'open', children: [
        	{ "id": "t3_3_gb1", "text": '单位运行状态', "href": "erji/nhfx/nhfx_1_1.html" },
            { "id": "t3_3_gb2", "text": '单元运行状态', "href": "erji/nhfx/nhfx_1_3.html" }
        ]
    },
    {
        "id": "t3_3_gb", "text": '能耗分析', state: 'open', children: [
        	{ "id": "t3_3_gb1", "text": '单位能耗分析', "href": "erji/nhfx/nhfx_1_2.html" },
            { "id": "t3_3_gb2", "text": '单元能耗分析', "href": "erji/nhfx/nhfx_1_4.html" },
            { "id": "t3_3_gb2", "text": '举升方式能耗分析', "href": "erji/nhfx/nhfx_1_5.html" },
            { "id": "t3_3_gb2", "text": '系统效率分析', "href": "erji/nhfx/nhfx_1_6.html" }
        ]
    },
    {
        "id": "t3_3_gb", "text": '能耗评价', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '基本情况', "href": "nxpj/nhpj_js.html" },
        	{
        	    "id": "t3_3_gb", "text": '国家标准', state: 'open', children: [
		        	{ "id": "t3_3_gb1", "text": '系统效率', "href": "nxpj/bzpj_qy.html" },
		            { "id": "t3_3_gb2", "text": '抽油机井', "href": "erji/nhpj/nhpj_2_2.html" },
		            { "id": "t3_3_gb2", "text": '电泵井', "href": "erji/nhpj/nhpj_2_3.html" }
        	    ]
        	},
		    {
		        "id": "t3_3_gb", "text": '行业标准', state: 'open', children: [
		        	{ "id": "t3_3_gb1", "text": '系统效率', "href": "erji/nhpj/nhpj_3_1.html" }
		        ]
		    },
            { "id": "t3_3_gb2", "text": '降耗率评价', "href": "erji/nhpj/nhpj_4_1.html" },
            { "id": "t3_3_gb2", "text": '百米吨液耗电评价', "href": "erji/nhpj/nhpj_5_1.html" }
        ]
    },
    {
        "id": "t3_3_gb", "text": '标准管理', state: 'open', children: [
        	{
        	    "id": "t3_3_gb", "text": '国家标准', state: 'open', children: [
		        	{ "id": "t3_3_gb1", "text": '抽油机', "href": "erji/bzgl/bzgl_1_1.html" },
		            { "id": "t3_3_gb2", "text": '电泵', "href": "erji/bzgl/bzgl_1_2.html" }
        	    ]
        	},
		    {
		        "id": "t3_3_gb", "text": '行业标准', state: 'open', children: [
		        	{ "id": "t3_3_gb1", "text": '抽油机', "href": "erji/bzgl/bzgl_2_1.html" },
		            { "id": "t3_3_gb2", "text": '电泵', "href": "erji/bzgl/bzgl_2_2.html" }
		        ]
		    }
        ]
    }
];

//注水系统
var Accord_data_3_2 = [
    {
        "id": "t3_3_gb", "text": '运行状态', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '单位运行状态', "href": "erji/nhfx/nhfx_4_1.html" },
            { "id": "t3_3_gb2", "text": '单元运行状态', "href": "erji/nhfx/nhfx_2_3.html" }
        ]
    },
    {
        "id": "t3_3_gb", "text": '能耗分析', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '单位能耗分析', "href": "erji/nhfx/nhfx_2_2.html" }
        ]
    },
    {
        "id": "t3_3_gb", "text": '能耗评价', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '国家标准', "href": "erji/nhpj/nhpj_6_1.html" },
    		{ "id": "t3_3_gb2", "text": '行业标准', "href": "erji/nhpj/nhpj_7_1.html" }
        ]
    },
    {
        "id": "t3_3_gb", "text": '标准管理', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '国家标准', "href": "erji/bzgl/bzgl_3_1.html" },
    		{ "id": "t3_3_gb2", "text": '行业标准', "href": "erji/bzgl/bzgl_3_2.html" }
        ]
    }
];

//集输系统
var Accord_data_3_3 = [
	{
	    "id": "t3_3_gb", "text": '运行状态', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '单位运行状态', "href": "erji/nhfx/nhfx_3_1.html" }
	    ]
	},
    {
        "id": "t3_3_gb", "text": '能耗分析', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '单位能耗分析', "href": "erji/nhfx/nhfx_3_2.html" }
        ]
    },
    {
        "id": "t3_3_gb", "text": '能耗评价', state: 'open', children: [
    		{
    		    "id": "t3_3_gb", "text": '国家标准', state: 'open', children: [
		        	{ "id": "t3_3_gb1", "text": '输油泵', "href": "erji/nhpj/nhpj_8_1.html" },
		            { "id": "t3_3_gb2", "text": '加热炉', "href": "erji/nhpj/nhpj_8_2.html" }
    		    ]
    		}
        ]
    },
    {
        "id": "t3_3_gb", "text": '标准管理', state: 'open', children: [
    		{ "id": "t3_3_gb2", "text": '输油泵', "href": "erji/bzgl/bzgl_4_1.html" },
    		{ "id": "t3_3_gb2", "text": '加热炉', "href": "erji/bzgl/bzgl_4_2.html" }
        ]
    }
];


//举升评价
//var Accord_data_3 = [
//	{"id": "t3_1_1", "text": '基本情况', "href": "nxpj/nhpj_js.html"},
//  {
//  	"id": "t3_1_gb", "text": '国家标准', state: 'open', children: [
//      	{ "id": "t3_2_gb1", "text": '系统效率', "href": "nxpj/bzpj_qy.html" },
//          { "id": "t3_2_gb2", "text": '抽油机井', "href": "erji/nhpj/nhpj_2_2.html" },
//          { "id": "t3_2_gb3", "text": '电泵井', "href": "erji/nhpj/nhpj_2_3.html" }
//      ]
//  },
//  {
//      "id": "t3_1_hb", "text": '行业标准', state: 'open', children: [
//          { "id": "t5_3_hb1", "text": '系统效率', "href": "erji/nhpj/nhpj_3_1.html" }
//      ]
//  },
//  {"id": "t3_1_4", "text": '降耗率评价', "href": "erji/nhpj/nhpj_4_1.html"},
//  {"id": "t3_1_5", "text": '百米吨液耗电评价', "href": "erji/nhpj/nhpj_5_1.html"}
//];

//注水评价
//var Accord_data_3_2 = [
//  {"id": "t3_2_1", "text": '国家标准', "href": "erji/nhpj/nhpj_6_1.html"},
//  {"id": "t3_2_2", "text": '行业标准', "href": "erji/nhpj/nhpj_7_1.html"}
//];

//集输评价
//var Accord_data_3_3 = [
//  {
//  	"id": "t3_3_gb", "text": '国家标准', state: 'open', children: [
//      	{ "id": "t3_3_gb1", "text": '输油泵', "href": "erji/nhpj/nhpj_8_1.html" },
//          { "id": "t3_3_gb2", "text": '加热炉', "href": "erji/nhpj/nhpj_8_2.html" }
//      ]
//  }
//];


//第四个导航及琴下内容
var Accord_content_4 = [
    { "id": "t4_1", "content": "举升优化" },
    { "id": "t4_2", "content": "注水优化" },
    { "id": "t4_3", "content": "集输优化" }
];
//举升优化
var Accord_data_4 = [
    { "id": "t4_1_1", "text": '待优化井', "href": "erji/nxyh/nxyh_1_1.html" },
    { "id": "t4_1_2", "text": '措施建议', "href": "erji/nxyh/nxyh_1_2.html" },
    { "id": "t4_1_3", "text": '产能预测', "href": "erji/nxyh/nxyh_1_3.html" },
    { "id": "t4_1_4", "text": '优化设计', "href": "erji/nxyh/nxyh_1_4.html" },
    { "id": "t4_1_5", "text": '措施统计', "href": "erji/nxyh/nxyh_1_5.html" },
    { "id": "t4_1_6", "text": '效果跟踪', "href": "erji/nxyh/nxyh_1_6.html" },
    { "id": "t4_1_7", "text": '整改措施管理', "href": "erji/nxyh/nxyh_1_7.html" }
];
//注水优化
var Accord_data_4_2 = [
    { "id": "t4_2_1", "text": '待优化机组', "href": "erji/nxyh/nxyh_2_1.html" },
    { "id": "t4_2_2", "text": '效果跟踪', "href": "erji/nxyh/nxyh_2_2.html" }
];
//集输优化
var Accord_data_4_3 = [
     {
         "id": "t4_3_jz", "text": '机组', state: 'open', children: [
            { "id": "t4_3_jz1", "text": '待优化机组', "href": "erji/nxyh/nxyh_3_1.html" },
            { "id": "t4_3_jz2", "text": '效果跟踪', "href": "erji/nxyh/nxyh_3_2.html" }
         ]
     },
    {
        "id": "t4_3_gl", "text": '锅炉', state: 'open', children: [
            { "id": "t4_3_gl1", "text": '待优化锅炉', "href": "erji/nxyh/nxyh_3_3.html" },
            { "id": "t4_3_gl2", "text": '效果跟踪', "href": "erji/nxyh/nxyh_3_4.html" }
        ]
    }
];



//第五个导航

var Accord_content_5 = [
    { "id": "t5_1", "content": "举升分析" },
    { "id": "t5_2", "content": "注水分析" },
    { "id": "t5_3", "content": "集输分析" }
];

//举升分析
var Accord_data_5 = [
	{ "id": "t5_1_1", "text": '运行状态', "href": "erji/nhfx/nhfx_1_1.html" },
	{ "id": "t5_1_2", "text": '能耗分析', "href": "erji/nhfx/nhfx_1_2.html" }
];

//注水分析
var Accord_data_5_2 = [
    { "id": "t5_2_1", "text": '运行状态', "href": "erji/nhfx/nhfx_2_1.html" },
    { "id": "t5_2_2", "text": '能耗分析', "href": "erji/nhfx/nhfx_2_2.html" }
];

//集输评价
var Accord_data_5_3 = [
    { "id": "t5_3_1", "text": '运行状态', "href": "erji/nhfx/nhfx_3_1.html" },
    { "id": "t5_3_2", "text": '能耗分析', "href": "erji/nhfx/nhfx_3_2.html" }
];

//第六个导航
var Accord_content_6 = [
    { "id": "t5_1", "content": "机构管理" },
    { "id": "t5_2", "content": "权限管理" },
    { "id": "t5_3", "content": "流程配置" },
    { "id": "t5_4", "content": "日志管理" },
    { "id": "t5_5", "content": "身份认证" }
];