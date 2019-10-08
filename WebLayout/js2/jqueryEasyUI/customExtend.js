jQuery.getWebPath=function(){
    	var strFullPath=window.document.location.href; 
    	var strPath=window.document.location.pathname; 
    	var pos=strFullPath.indexOf(strPath); 
    	var prePath=strFullPath.substring(0,pos); 
    	var postPath=strPath.substring(0,strPath.substr(1).indexOf('/')+1); 
    	return(prePath+postPath); 
    }
    
$.extend($.fn.datagrid.defaults.editors, { datetimebox: {//datetimebox就是你要自定义editor的名称 
init: function(container, options){ 
  var input = $('<input class="easyuidatetimebox">').appendTo(container); 
  return input.datetimebox(	{ 
   formatter:function(date){ 
   //return new Date(date).format("yyyy-MM-dd hh:mm:ss"); 
   return myformatter(date);
   } 
   }); 
   },
    getValue: function(target){
     return $(target).parent().find('input.combo-value').val(); 
     }, 
   setValue: function(target, value){
     //$(target).datetimebox("setValue",value); 
     $(target).datetimebox("setValue",function(){myparser(value)});
     },
    resize: function(target, width){
      var input = $(target); 
      if ($.boxModel == true){ 
      input.width(width - (input.outerWidth() - input.width())); } 
      else { input.width(width); } } 
      } });
      
$.extend($.fn.datagrid.defaults.editors, {   
 
      textarea2: {   
	 init: function(container, options){
	 	
	             var input = $('<textarea style="width:98%" class="datagrid-editable-input" rows='+options.rows+'></textarea>').appendTo(container);   
	             return input;   
	          },   
	 getValue: function(target){   
	             return $(target).val();   
	         },   
	 setValue: function(target, value){   
	             $(target).val(value);   
	        },   
	 resize: function(target, width){   
	 
	             var input = $(target);   
	             if ($.boxModel == true){   
	                 input.width(width - (input.outerWidth() - input.width()));   
	             } else {   
	                 input.width(width);   
	             }   
	         }   
	     }   
	 }); 
function myformatter(date){
			var y = date.getFullYear();
			var m = date.getMonth()+1;
			var d = date.getDate();
			var h = date.getHours();
			var mi = date.getMinutes();
			var se = date.getSeconds();
			return y+'-'+(m<10?('0'+m):m)+'-'+(d<10?('0'+d):d)+" "+(h<10?('0'+h):h)+":"+(mi<10?('0'+mi):mi)+":"+(se<10?('0'+se):se);
		}

function myparser(s){
			if (!s) return new Date();
			var ss = (s.split('-'));
			var y = parseInt(ss[0],10);
			var m = parseInt(ss[1],10);
			//var d = parseInt(ss[2],10);
			//alert(ss[2].substring(3,5));
			var d =ss[2].substring(0,2);
			var h = ss[2].substring(3,5);
			var mi = ss[2].substring(6,8);
			var se = ss[2].substring(9,11);
			
			if (!isNaN(y) && !isNaN(m) && !isNaN(d) && !isNaN(h)&& !isNaN(mi)&& !isNaN(se)){
			     return new Date(y,m-1,d,h,mi,se);
			} else {
				return new Date();
			}
		}
		
   // JSON转换为字符串
	function JSONstringify(Json){
	    if($.browser.msie){
	       if($.browser.version=="7.0"||$.browser.version=="6.0"){
	          var  result=jQuery.parseJSON(Json);
	       }else{
	          var result=JSON.stringify(Json);  
	       }       
	    }else{
	        var result=JSON.stringify(Json);           
	    }
	    return result;
	}
	
	
	/**
* json对象转字符串形式
*/
function json2str(o) {
	var arr = [];
	var fmt = function(s) {
	if (typeof s == 'object' && s != null) return json2str(s);
	return /^(string|number)$/.test(typeof s) ? "'" + s + "'" : s;
	}
	for (var i in o) arr.push("'" + i + "':" + fmt(o[i]));
	return '{' + arr.join(',') + '}';
} 



	/**
	*JsonAarry转换为字符串,目的为了传给后台参数
	*/
	function JsonArrayToStringCfz(jsonArray){
		var JsonArrayString = "[";
		for(var i=0;i<jsonArray.length;i++){
			JsonArrayString=JsonArrayString+json2str(jsonArray[i])+",";
		}
		JsonArrayString = JsonArrayString.substring(0,JsonArrayString.length-1)+"]";
		return JsonArrayString;
	}
	/**
	*
	*/
	function setFieldDate(data){
		var jsono = data;
		$("td[field]").each(function(){
			da = jsono[$(this).attr("field")];
			if(da!=""){
				$(this).html(da);
			}
		});
		$("div[field]").each(function(){
			da = jsono[$(this).attr("field")];
			if(da!=""){
				$(this).html(da);
			}
		});
		$("span[field]").each(function(){
			da = jsono[$(this).attr("field")];
			if(da!=""){
				$(this).html(da);
			}
		});
	}
//表体，居左
function tbodyAlignLeft(value){
	var html = [];
	html.push('<div style="text-align:left;">');
	html.push(value);
	html.push('</div>');
	return  html.join('');
}
//表体，居右
function tbodyAlignRight(value){
	var html = [];
	html.push('<div style="text-align:right;">');
	html.push(value);
	html.push('</div>');
	return  html.join('');
}
//等待提示
function progress(){
	var win = $.messager.progress({
	title:'Please waiting',
	msg:'Loading data...'
	});
	setTimeout(function(){
		$.messager.progress('close');
	},5000
	)
}
//等待提示
function progress2Second(){
	var win = $.messager.progress({
	title:'Please waiting',
	msg:'Loading data...'
	});
	setTimeout(function(){
		$.messager.progress('close');
	},1000
	)
}

	function replaceTextarea1(str){//把textarea里的\n神马的东西替换成<br>用来提交给后台
		if(str == null){
			return "";
		}
		
		var reg=new RegExp("\n","g"); 
		var reg1=new RegExp(" ","g"); 
		var reg2=new RegExp("\r","g"); 
		
		str = str.replace(reg,"＜br＞"); 
		str = str.replace(reg1,"＜p＞"); 
		str = str.replace(reg2,"＜br＞"); 
		
		return str; 
	}
	
	
	function replaceTextarea2(str){//把后台拿出来的东西里的<br>替换成\n显示在textarea
		if(str == null){
			return "";
		}
		var reg=new RegExp("＜br＞","g"); 
		var reg1=new RegExp("＜p＞","g"); 
		
		str = str.replace(reg,"\n"); 
		str = str.replace(reg1," "); 
		
		return str; 
	} 
	
/***********************************************************window,panel************************************************************/        
/**
*window、panel控件的销毁事件，主要是用于添加iframe的机制，为减少关闭后依然存在的iframe开销
*/
 var destroyFrameAndFreeTheMemory = function(){
              //  alert('onBeforeDestroy')
                var frame=$('iframe', this);
                if(frame.length>0){
                	//frame[0].src="www.baidu.com";
                	//var path = $.getWebPath();
                	//$(frame[0]).attr("src",path+"/easyui/destory.jsp");
                	$(frame[0]).removeAttr("src");
                	//alert("frame[0].src::"+frame[0].src);
                    //frame[0].contentWindow.document.write('');
                    frame[0].contentWindow.close();
                    frame.remove();
                    if(navigator.userAgent.indexOf('MSIE')>0){
                        CollectGarbage();
                    }
                }
            }

$.fn.window.defaults.onBeforeDestroy = destroyFrameAndFreeTheMemory ;
$.fn.panel.defaults.onBeforeDestroy = destroyFrameAndFreeTheMemory;
	
$.extend($.fn.validatebox.defaults.rules, {
	selectValueRequired: {  
        validator: function (value, param) {  
            if (value == "" || value.indexOf('请选择') >= 0 || value.indexOf('全部') >= 0) { return false; }  
            else { return true; }  
        },  
        message: '该下拉框为必选项'  
    },
    idcard: {// 验证身份证
        validator: function (value) {
            return /^\d{15}(\d{2}[A-Za-z0-9])?$/i.test(value);
        },
        message: '身份证号码格式不正确'
    },
    minLength: {
        validator: function (value, param) {
            return value.length >= param[0];
        },
        message: '请输入至少（2）个字符.'
    },
    length: { validator: function (value, param) {
        var s = $.trim(value);
        var l = 0; 
		var a = s.split(""); 
		for (var i=0;i<a.length;i++) {
			if (a[i].charCodeAt(0)<299) {
				l++;  
			} else {
				l+=2;  
			} 
		}
        return l >= param[0] && l <= param[1];
    },
        message: "输入内容长度必须介于{0}和{1}之间."
    },
    phone: {// 验证电话号码
        validator: function (value) {
            return /^((\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$/i.test(value);
        },
        message: '格式不正确,请使用下面格式:020-88888888'
    },
    mobile: {// 验证手机号码
        validator: function (value) {
            return /^(13|15|18)\d{9}$/i.test(value);
        },
        message: '手机号码格式不正确'
    },
    intOrFloat: {// 验证整数或小数
        validator: function (value) {
            return /^\d+(\.\d+)?$/i.test(value);
        },
        message: '请输入数字，并确保格式正确'
    },
    currency: {// 验证货币
        validator: function (value) {
            return /^\d+(\.\d+)?$/i.test(value);
        },
        message: '货币格式不正确'
    },
    qq: {// 验证QQ,从10000开始
        validator: function (value) {
            return /^[1-9]\d{4,9}$/i.test(value);
        },
        message: 'QQ号码格式不正确'
    },
    integer: {// 验证整数 可正负数
        validator: function (value) {
            //return /^[+]?[1-9]+\d*$/i.test(value);

           return /^([+]?[0-9])|([-]?[0-9])+\d*$/i.test(value);
        },
        message: '请输入整数'
    },
    age: {// 验证年龄
        validator: function (value) {
            return /^(?:[1-9][0-9]?|1[01][0-9]|120)$/i.test(value);
        },
        message: '年龄必须是0到120之间的整数'
    },

   chinese: {// 验证中文
        validator: function (value) {
            return /^[\Α-\￥]+$/i.test(value);
        },
        message: '请输入中文'
    },
    english: {// 验证英语
        validator: function (value) {
            return /^[A-Za-z]+$/i.test(value);
        },
        message: '请输入英文'
    },
    unnormal: {// 验证是否包含空格和非法字符
        validator: function (value) {
            return /.+/i.test(value);
        },
        message: '输入值不能为空和包含其他非法字符'
    },
    username: {// 验证用户名
        validator: function (value) {
            return /^[a-zA-Z][a-zA-Z0-9_]{5,15}$/i.test(value);
        },
        message: '用户名不合法（字母开头，允许6-16字节，允许字母数字下划线）'
    },
    faxno: {// 验证传真
        validator: function (value) {
            //            return /^[+]{0,1}(\d){1,3}[ ]?([-]?((\d)|[ ]){1,12})+$/i.test(value);
            return /^((\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$/i.test(value);
        },
        message: '传真号码不正确'
    },
    zip: {// 验证邮政编码
        validator: function (value) {
            return /^[1-9]\d{5}$/i.test(value);
        },
        message: '邮政编码格式不正确'
    },
    ip: {// 验证IP地址
        validator: function (value) {
            return /d+.d+.d+.d+/i.test(value);
        },
        message: 'IP地址格式不正确'
    },
    name: {// 验证姓名，可以是中文或英文
        validator: function (value) {
            return /^[\Α-\￥]+$/i.test(value) | /^\w+[\w\s]+\w+$/i.test(value);
        },
        message: '请输入姓名'
    },
    date: {// 验证姓名，可以是中文或英文
        validator: function (value) {
            //格式yyyy-MM-dd或yyyy-M-d
            return /^(?:(?!0000)[0-9]{4}([-]?)(?:(?:0?[1-9]|1[0-2])\1(?:0?[1-9]|1[0-9]|2[0-8])|(?:0?[13-9]|1[0-2])\1(?:29|30)|(?:0?[13578]|1[02])\1(?:31))|(?:[0-9]{2}(?:0[48]|[2468][048]|[13579][26])|(?:0[48]|[2468][048]|[13579][26])00)([-]?)0?2\2(?:29))$/i.test(value);
        },
        message: '清输入合适的日期格式'
    },
    msn: {
        validator: function (value) {
            return /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/.test(value);
        },
        message: '请输入有效的msn账号(例：abc@hotnail(msn/live).com)'
    },
    same: {
        validator: function (value, param) {
            if ($("#" + param[0]).val() != "" && value != "") {
                return $("#" + param[0]).val() == value;
            } else {
                return true;
            }
        },
        message: '两次输入的密码不一致！'
    }
}); 



//弹出选择人或单位的窗口
function openSelectWindow(url,tit,windowWidth,windowHeight){
	
	var frameWith=windowWidth-16;
     $('<div id="wind1" style="width:'+windowWidth+'px;height:'+windowHeight+'px;padding:0px;"></div>').appendTo("body");
	 var content = '<iframe scrolling="no" frameborder="0" src="'+url+'" style="width:'+frameWith+'px;height:99%;"></iframe>';
	 $('#wind1').html(content);
     $('#wind1').window({modal: true,title:tit,cache: false,
      onClose: function(){
	      $(this).window('destroy');
		  
	  }
     });
}
//关闭上面打开的页面
function closeSelectWinow(){
	$("#wind1").window('destroy');
}


//var maxWindowState ;
/**
*author wangchen 20140111
*最大化窗口方法，该方法会铺满所在页面
*url
*tit
*winId 最大窗口的id，可以不填
*ifheader是否需要窗口的header(true)，如果不填则默认不显示
*/
 function windowMaxOpen(url,tit,winId,ifheader){
	  
	   if(!winId){
	       winId = "maxWindow1";
	   }
	   var noHeader;
	   if(!ifheader){
	       noHeader = true;
	   }else{
	       noHeader = false;
	   }
	   if(!tit){
	       tit ="  ";
	   }else{
	   	tit="&nbsp;"+tit;
	   }
	   
	    $('<div id="'+winId+'" style="padding:0px"></div>').appendTo("body");
	 var content = '<iframe scrolling="yes" frameborder="0"  src="'+url+'" style="width:100%;height:99%;"></iframe>';
	 $('#'+winId).html(content);
     $('#'+winId).window({modal: true,title:tit,cache: false,fit:true,noheader:noHeader,
      onClose: function(){
          maxWindowState = "close";
	      $(this).window('destroy');
	  },
	  onOpen:function(){
	        maxWindowState = "open";
	   		windowMaxOpenSetCss(winId);
	  }
     });
	  $("#"+winId).window("open").window("maximize");
	  
	  windowResize(winId);
	}
	function  windowResize(id){
	    $(window).resize(function() {           
			if(maxWindowState =="open"){
	       $('#'+id).window("open").window('maximize');
		  }
	    });
	}
//close
function windowMaxClose(winId){
    if(!winId){
	       winId = "maxWindow1";
	   }
	    $("#"+winId).window("close")
}
function windowMaxOpenSetCss(winId){
	 $('.window').each(function (){
	     if($('.window #'+winId).length>0){
		     $(this).css("border-radius","0px").css("-moz-border-radius","0px").css("-webkit-border-radius","0px").css("border","0px").css("padding","1px");
		 }
	 });
	 
	 $('.window-shadow').each(function (){
	     if($('.window-shadow #'+winId).length>0){
		     $(this).css("border-radius","0px").css("-moz-border-radius","0px").css("-webkit-border-radius","0px");
			 $(this).css("background","#E0ECFF")
		.css("-moz-box-shadow","0px")
		.css("-webkit-box-shadow","0px")
		.css("box-shadow","0px")
		.css("filter","progid:DXImageTransform.Microsoft.Blur(pixelRadius=0,MakeShadow=false,ShadowOpacity=1)");
		 }
	 });
	 
	}
	
//确定是否是某个浏览器
function getBrowserDecider(){
 var Sys = {};
  var ua = navigator.userAgent.toLowerCase();

  		if (ua.indexOf('msie') != -1&&ua.indexOf('mozilla') == -1)
		   Sys.ie = ua.match(/msie ([\d.]+)/)[1]
		else if (ua.indexOf('firefox') != -1)
		   Sys.firefox = ua.match(/firefox\/([\d.]+)/)[1]
		else if (ua.indexOf('safari') != -1)
		   Sys.safari = ua.match(/safari\/([\d.]+)/)[1]
		else if (ua.indexOf('chrome') != -1)
		   Sys.chrome = ua.match(/chrome\/([\d.]+)/)[1]
		else if (ua.indexOf('opera') != -1)
		   Sys.opera = ua.match(/opera.([\d.]+)/)[1];
		else if (ua.indexOf('mozilla') != -1)
		   Sys.mozilla = ua.match(/mozilla.([\d.]+)/)[1];
return Sys;
}
//页面所有iframe自适应高度
function iframeAutoHeight(){
   var Sys = getBrowserDecider();
   if(Sys.ie){
      adjustIframeHeight(3);
   }
   if(Sys.chrome||Sys.safari||Sys.firefox||Sys.mozilla){
       adjustIframeHeight(4);
      
   }
}
//调整iframe的高度
function adjustIframeHeight(dis){
 $("iframe").each(function(){
          var height = $(this).attr("height");
         // if($(this).is(":hidden") ||$(this).parent().is(":hidden")){         
           
              id = $(this).attr("id");
               if(height =="100%" || typeof height == "undefined" ||height ==""){
                   height = $(this).parent().height()-dis;
                   $(this).height(height);
                   $(this).css("overflow","hidden");
                  
               }
             
       });
         var tabsIframeHeight = 0;
               $(".easyui-tabs iframe").each(function(){
                   if($(this).height()>0 && tabsIframeHeight==0){
                       tabsIframeHeight = $(this).height();
                   }else{
                       $(this).height(tabsIframeHeight);
                   }
               });
}

	document.write('<script type="text/javascript" src="' + $.getWebPath() +
		'/scyxgk/common/easyui/jquery.datagrid.js"  type="text/css" ></script>');
	
	$(document).ready(function(){
	    iframeAutoHeight();
	});

	function initPageInfo(datagridName,totalCount,pagesize,pagenum,totalPage){
		var p = $('#'+datagridName).datagrid('getPager');  
		var start = 1+(pagenum-1)*parseInt(pagesize);
		var end = start + parseInt(pagesize)-1;
		var datagridPagenum = pagenum;
		
		if(pagenum==1){
			datagridPagenum = 0;
		}
		if(pagenum == totalPage){
			end = totalCount;
		}
		
		var rownumbers = $('.datagrid-cell-rownumber');
		var i=0;
		while(i<=end-start){
			//alert(i+start);
			$(rownumbers[i]).html(i+start);
			i++;
		}
		
	    $(p).pagination({
			total: totalCount,

	        pageSize: pagesize,//每页显示的记录条数，默认为10  

			pageNumber: parseInt(datagridPagenum),

	        pageList: [10,20,30],//可以设置每页记录条数的列表  

	        beforePageText: '第',//页数文本框前显示的汉字  

	        afterPageText: '页  共 '+totalPage+' 页',  
	
	        displayMsg: '当前显示 '+start+'-'+end+' 条记录 共 '+totalCount+' 条记录',  
	
	    });  
    	$(p).pagination({
    		
			onBeforeRefresh:function(pageNum, pageSize){
				//alert('RefreshpageNumber:'+pageNum+',pageSize:'+pageSize);
				
				$("#pagesize").val(pageSize);
				$("#pagenum").val(pageNum);
				baseQuery();
			},
			onSelectPage:function(pageNum, pageSize){
				//alert('pageNumber:'+pageNum+',pageSize:'+pageSize);

				$("#pagesize").val(pageSize);
				$("#pagenum").val(pageNum);
				baseQuery();
			}
			
			
		});
	}
	
	function initPageInfoDataForm(datagridName,totalCount,pagesize,pagenum){
		var totalPage = Math.ceil(totalCount/pagesize);
		var p = $('#'+datagridName).datagrid('getPager');  
		var start = 1+(pagenum-1)*parseInt(pagesize);
		var end = start + parseInt(pagesize)-1;
		var datagridPagenum = pagenum;
		
		if(pagenum==1){
			datagridPagenum = 0;
		}
		if(pagenum == totalPage){
			end = totalCount;
		}
		
		var rownumbers = $('.datagrid-cell-rownumber');
		var i=0;
		while(i<=end-start){
			//alert(i+start);
			$(rownumbers[i]).html(i+start);
			i++;
		}
		
	    $(p).pagination({
			total: totalCount,

	        pageSize: pagesize,//每页显示的记录条数，默认为10  

			pageNumber: parseInt(datagridPagenum),

	        pageList: [10,20,30],//可以设置每页记录条数的列表  

	        beforePageText: '第',//页数文本框前显示的汉字  

	        afterPageText: '页  共 '+totalPage+' 页',  
	
	        displayMsg: '当前显示 '+start+'-'+end+' 条记录 共 '+totalCount+' 条记录',  
	
	    });  
    	$(p).pagination({
    		
			onBeforeRefresh:function(pageNum, pageSize){
				//alert('RefreshpageNumber:'+pageNum+',pageSize:'+pageSize);
				
				$("#pagesize").val(pageSize);
				$("#pagenum").val(pageNum);
				baseQuery();
			},
			onSelectPage:function(pageNum, pageSize){
				//alert('pageNumber:'+pageNum+',pageSize:'+pageSize);

				$("#pagesize").val(pageSize);
				$("#pagenum").val(pageNum);
				baseQuery();
			}
			
			
		});
		
	}

	function dmzdmmcFormat(dmzs,listJson,splitLabel){//用逗号隔开的代码值字符串，转换为代码名称串
		var dmmcs = "";
		var dmzArray = dmzs.split(",");
	 	if(dmzs!=''){
	 		for(var i=0; i<dmzArray.length; i++){
	 			for(var j=0; j<listJson.length; j++){
		 			if(listJson[j].DMZ==dmzArray[i]){
		 				if(i==0){
		 					dmmcs +=listJson[j].DMMC;
		 				}else{
		 					dmmcs +=splitLabel+listJson[j].DMMC;
		 				}
		 				
		 			}
		 		}
	 		}
	 	}else{
	 		return dmzs;
	 	}
	 	return dmmcs;
	}
	
	