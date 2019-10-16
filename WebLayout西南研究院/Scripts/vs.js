
var P_W = function(percent) {
    var bodyWidth = $(document).width();
    return bodyWidth * percent;
};

var P_H = function(percent) {
    var bodyHeight = $(document).height();
    return bodyHeight * percent;
};

//依赖jQuery 和 背景动画
;(function($) {
    $.fn.TwinkleBg = function(option) {
        var opt = option || {},
            def1 = ( opt.type && opt.type == 'add')? '#C9FCCE' : '#FAD8D8',
            col1 = opt.c1 || def1,
            col2 = opt.c2 || '#FFF',
            duration1 = opt.t1 || 'slow',
            duration2 = opt.t2 || 'slow';
        return this.each(function() {
            var $this = $(this);
            $this.animate({ backgroundColor: col1 }, duration1).animate({ backgroundColor: col2 }, duration2);
        });
    };
})(jQuery);

/**
* 提高浏览器兼容性,因为一些老浏览器不支持JSON对象
* 对一些原生不支持JSON的浏览器(如:IE6, IE7),扩展实现JSON,相应有两个方法:
* 1)  parse  2) stringify
*/
if (!window.JSON) {
    window.JSON = {
        parse: function (sJSON) { return eval("(" + sJSON + ")"); },
        stringify: function (vContent) {
            if (vContent instanceof Object) {
                var sOutput = "";
                if (vContent.constructor === Array) {
                    for (var nId = 0; nId < vContent.length; sOutput += this.stringify(vContent[nId]) + ",", nId++);
                    return "[" + sOutput.substr(0, sOutput.length - 1) + "]";
                }
                if (vContent.toString !== Object.prototype.toString) { return "\"" + vContent.toString().replace(/"/g, "\\$&") + "\""; }
                for (var sProp in vContent) { sOutput += "\"" + sProp.replace(/"/g, "\\$&") + "\":" + this.stringify(vContent[sProp]) + ","; }
                return "{" + sOutput.substr(0, sOutput.length - 1) + "}";
            }
            return typeof vContent === "string" ? "\"" + vContent.replace(/"/g, "\\$&") + "\"" : String(vContent);
        }
    };
}

// 扩展方法,日期字符串格式化
// alert(Date.formatDate("2010-04-30", "yyyy-MM-dd HH:mm:ss"));   
// alert(Date.formatDate("2010-4-29 1:50:00", "yyyy-MM-dd HH:mm:ss"));   
Date.formatDate= function(date, format) {
    if (!date) return;
    if (!format) format = "yyyy-MM-dd";
    switch (typeof date) {
        case "string":
            date = new Date(date.replace(/-/, "/"));
            break;
        case "number":
            date = new Date(date);
            break;
    }
    if (!date instanceof Date) return;
    var dict = {
        "yyyy": date.getFullYear(),
        "M": date.getMonth() + 1,
        "d": date.getDate(),
        "H": date.getHours(),
        "m": date.getMinutes(),
        "s": date.getSeconds(),
        "MM": ("" + (date.getMonth() + 101)).substr(1),
        "dd": ("" + (date.getDate() + 100)).substr(1),
        "HH": ("" + (date.getHours() + 100)).substr(1),
        "mm": ("" + (date.getMinutes() + 100)).substr(1),
        "ss": ("" + (date.getSeconds() + 100)).substr(1)
    };
    return format.replace(/(yyyy|MM?|dd?|HH?|ss?|mm?)/g, function () {
        return dict[arguments[0]];
    });
}   

/**
* 简易JS模板,用于字符串替换
*
* 说明： 这里主要用到了JS里String.prototype.replace函数支持正则和回调函数的功能。
* 	所以大家有自己的需求是很容易修改的。只要替换下上面的正则和回调函数就可以了。
* 	如果是JSON数据的话可以修改成这样的：
* 	Template.prototype.format = function (o) {
*		return this.str.replace(/\{(\w+)\}/g, function (a, b) {
*			return o.hasOwnProperty(b) ? : o[b] : 'null';
*		});
*	}
*/
; (function (window) {
    function Template(str) {
        this.str = str;
    }
    Template.prototype.format = function () {
        var arg = arguments[0] instanceof Array ? arguments[0] : arguments;
        return this.str.replace(/\{(\d+)\}/g, function (a, b) {
            return arg[b] || '';
        });
    }
    window.Template = Template;
})(window);

/**
* iframe 加上onload回调事件,如果节点不是IFRAME则不做任何操作
*/
$.fn.iframeOnload = function (callback) {
    return this.each(function () {
        var domE = this;
        if (domE.tagName != 'IFRAME') return;
        if (domE.attachEvent) {
            domE.attachEvent("onload", function () {
                if (callback instanceof Function) {
                    callback();
                }   
            });
        } else {
            domE.onload = function () {
                if (callback instanceof Function) {
                    callback();
                }
            };
        }
    });
};



/**
*自适应表格的宽度处理(适用于Jquery Easy Ui中的dataGrid的列宽),
*注：可以实现列表的各列宽度跟着浏览宽度的变化而变化，即采用该方法来设置DataGrid
*的列宽可以在不同分辨率的浏览器下自动伸缩从而满足不同分辨率浏览器的要求
*使用方法：(如:{field:'ymName',title:'编号',width:fillsize(0.08),align:'center'},)
*
*@parampercent当前列的列宽所占整个窗口宽度的百分比(以小数形式出现，如0.3代表30%)
*
*@return通过当前窗口和对应的百分比计算出来的具体宽度
*/
function fillsize(percent) {
    var bodyWidth = document.body.clientWidth;
    return (bodyWidth - 90) * percent;
}


 


//封装到vs.js,所有页面都引用,方便以后可以一次改成别的信息提示方式
function MyMessage(mes, callback) {
    if (callback && callback instanceof Function) {
        layer.alert(mes,function(index) {
            callback(index)
        });
    }else {
        layer.alert(mes);
    }
}

//封装到util.js,所有页面都引用,方便以后可以一次改成别的信息提示方式
function MyConfirm(mes, ok, cancel) {
    layer.confirm(mes, { icon: 0, title: false, closeBtn: false }, function (index, layero) {
        ok && ok instanceof Function && ok(index, layero);
    }, function (index) {
        cancel && cancel instanceof Function && cancel(index);
    });
}

function shortMsg(msg, title, type) {
    toastr.options = {
        "closeButton": false,
        "debug": false,
        "progressBar": true,
        "preventDuplicates": false,
        "positionClass": "toast-top-center",
        "onclick": null,
        "showDuration": "400",
        "hideDuration": "400",
        "timeOut": "1500",
        "extendedTimeOut": "500",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut"
    };

    toastr[type || 'error'](msg, title);
    
}

function layerShortMsg(msg) {
    var index = layer.msg(msg, { icon: 0, time: -1, shade: [0.3, '#393D49'] });
    return index;
}

//可选提交方式,利用EASYUI的FORM 
function EasySubmit(formid, goUrl) {
    
    var formObj = $(formid);

    formObj.form('submit', {
        url: formObj.attr('action'),
        onSubmit: function() {
            return formObj.form('validate');
        },
        success: function(data) {
            alert(data);
            if (goUrl) {
                window.location = goUrl;
            }
        },
        onLoadSuccess: function(data) {

        }
    });
}

//显示遮罩,默认内容 : 加载中... 依赖layer
function MyTipShow(content) {
    content = content || "加载中...";
    if (layer) {
        window._myTipIndex = layer.open({
            content: '<i class="fa fa-spinner fa-spin fa-2x fa-fw"></i><span style="font-size:16px">' + content + '</span>',
            time: 0,
            title: false,
            closeBtn: false,
            btn: false,
            resize: false,
            shade: 0.1
        });
    }
}

//关闭遮罩 依赖layer
function MyTipClose() {
    if (layer) {
        layer.close(window._myTipIndex);
    }
}

//可选提交方式(利用jquery.form.js)需要自己做提交前验证
function MySubmit(formid,beforeF,sucessF) {
    $(formid).ajaxSubmit({
        type: 'post',
        beforeSubmit: function () {
            if (beforeF && beforeF instanceof Function) {
                if (beforeF()) {
                    MyTipShow();
                    return true;
                } else {
                    return false;
                }
            } else {
                MyTipShow();
                return true;
            }
        },
        success: function (data) {
            MyTipClose();
            if (sucessF && sucessF instanceof Function) {
                sucessF(data);
            } else if (sucessF) {
                MyMessage(sucessF);
            }
        },
        error: function (XmlHttpRequest, textStatus, errorThrown) {
            MyTipClose();
            MyMessage("提交过程中发生错误");
        }
    }); 
}

//创建一个iframe
function createFrame(name,url){
	var s = '<iframe scrolling="auto" name="'+name+'" frameborder="0"  src="'+url+'" style="width:100%;height:100%;"></iframe>';
	return s;
}


/**
 * 页面验证
 * */
function validate(dataTable){
	var valFlag = true;
	$('#'+dataTable+' input').each(function () {
	    if ($(this).attr('required') || $(this).attr('validType')) {
		    if (!$(this).validatebox('isValid')) {
		    	valFlag = false;
		        return;
		    }
	    }
	});
	return valFlag;
}

//利用easyui dialog高级查询窗口的共通
function showQueryDialog(options) {
    if (window.__dlg__) {
        __dlg__.dialog('open');
    } else {
        var opts = options || {};
        var dialogId = opts.dialogId || 'params';
        __dlg__ = $('#' + dialogId);
        __dlg__.dialog({
            title: opts.title || '高级查询',
            width: opts.width || 800,
            height: opts.height || 500,
            closed: true,
            modal: true,
            buttons: [{
                text: '确定',
                iconCls: 'icon-ok',
                handler: function () {
                    __dlg__.dialog('close');
                    var param = {};
                    __dlg__.find('.query').each(function () {
                        var $this = $(this);
                        var name = $this.attr('name');
                        var val = $this.val();
                        if ($this.hasClass('datebox-f')) {
                            name = $this.attr('comboname');
                            val = $this.datebox('getValue');
                        } else if ($this.hasClass('combogrid-f')) {
                            name = $this.attr('comboname');
                            val = $this.combogrid('getValue');
                        } else if ($this.hasClass('combobox-f')) {
                            name = $this.attr('comboname');
                            val = $this.combobox('getValue');
                        }
                        param[name] = val;
                    });

                    //IE 6, 7, 8, 9下,EASYUI组件被渲染后,原来的CLASS会清空,要重新再获得一下
                    if (! +[1, ]) {
                        __dlg__.find('[comboName]').each(function () {
                            var $this = $(this);
                            var name = $this.attr('comboName');
                            var val = $this.val();
                            if (this.tagName == 'INPUT') {
                                val = $this.datebox('getValue');
                            } else if (this.tagName == 'SELECT') {
                                val = $this.combogrid('getValue');
                            }
                            param[name] = val;
                        });
                    }
                    opts.callback(param);
                }
            }, {
                text: '取消',
                iconCls: 'icon-cancel',
                handler: function () { __dlg__.dialog('close'); }
            }]
        });

        __dlg__.dialog('open');
    }
    
}

var GetQueryParams = function(id) {
    var param = {};
    var form = $('#' + id);
    form.find('.query').each(function () {
        var $this = $(this);
        var name = $this.attr('name');
        var val = $this.val();
        if ($this.hasClass('datebox-f')) {
            name = $this.attr('comboname');
            val = $this.datebox('getValue');
        } else if ($this.hasClass('combogrid-f')) {
            name = $this.attr('comboname');
            val = $this.combogrid('getValue');
        } else if ($this.hasClass('combobox-f')) {
            name = $this.attr('comboname');
            val = $this.combobox('getValue');
        }
        param[name] = val;
    });

    //IE 6, 7, 8, 9下,EASYUI组件被渲染后,原来的CLASS会清空,要重新再获得一下
    if (! +[1, ]) {
        form.find('[comboName]').each(function () {
            var $this = $(this);
            var name = $this.attr('comboName');
            var val = $this.val();
            if (this.tagName == 'INPUT') {
                val = $this.datebox('getValue');
            } else if (this.tagName == 'SELECT') {
                val = $this.combogrid('getValue');
            }
            param[name] = val;
        });
    }
    return param;
}

$.makeTree = function (data, opt) {
    opt = opt||{};
    var idFiled, textFiled, parentField;
    
    idFiled = opt.idFiled || 'id';
    textFiled = opt.textFiled || 'name';
    parentField = opt.parentField || 'pId';
    var i, l, treeData = [], tmpMap = [];
    for (i = 0, l = data.length; i < l; i++) {
        tmpMap[data[i][idFiled]] = data[i];
    }
    for (i = 0, l = data.length; i < l; i++) {
        if (tmpMap[data[i][parentField]] && data[i][idFiled] != data[i][parentField]) {
            if (!tmpMap[data[i][parentField]]['children'])
                tmpMap[data[i][parentField]]['children'] = [];
            data[i]['role'] = "child";
            tmpMap[data[i][parentField]]['children'].push(data[i]);
        } else {
            data[i]['role'] = "root";
            treeData.push(data[i]);
        }
    }
    return treeData;
    
};

function extendToolBarCommandTemplate(options) {
    var template = {
        gridId: '_treegrid',
        $gridId: '#_treegrid',
        //增加按钮方法
        add: function () {
        },

        //编辑按钮方法
        edit: function () {
        },

        //删除按钮方法
        del: function () {
        },

        checkNoRowAndAlert: function (gridid) {
            try {
                if (!gridid) {
                    gridid = this.gridId;
                }

                if (jqGridComm) {
                    if (jqGridComm.noRowSelected(gridid)) {
                        shortMsg("请选择一条数据!");
                        return true;
                    } else {
                        return false;
                    }
                } else {
                    var noRowSelected = $('#' + gridid).jqGrid('getGridParam', 'selrow');
                    if (!noRowSelected) {

                        return false;
                    } else {

                    }
                }

            } catch (e) {
                return false;
            }
            return true;
        },

        showAjaxDelMsg: function (data) {
            if (data.Error) {
                shortMsg(data);
            } else {
                shortMsg(data, '', 'success');
            }
        }
    }

    return $.extend(template, options);
}

function extendJqgridCommon(options) {
    var template = {
        noRowSelected: function (tableId) {
            var id = $('#' + tableId).jqGrid('getGridParam', 'selrow');
            return !id;
        },
        selectedId: function (tableId) {
            return $('#' + tableId).jqGrid('getGridParam', 'selrow');
        },
        setDefaultPager: function (tableId, pagerId) {
            jQuery('#' + tableId).navGrid('#' + pagerId, {
                edit: false,
                add: false,
                del: false,
                search: false,
                refresh: true,
                view: false,
                position: "left",
                cloneToTop: false
            });
        },
        getRowData: function (tableId, rowId) {
            var result = null;
            try {
                result = $('#' + tableId).jqGrid('getRowData', rowId);
            } catch (e) {

            }
            return result;
        },
        reload: function (tableId, url) {
            if (arguments.length == 1) {
                url = $('#' + tableId).getGridParam('url');
            }

            var temp = $('#' + tableId).setGridParam({ "url": url });
            temp.trigger('reloadGrid', [{ page: 1 }]);
        },
        fixXScroll: function () {
            var widthOut = $('.ui-jqgrid-view').width();
            var widthView = $('.ui-jqgrid-btable').width();

            if (widthView <= widthOut) {
                $('.ui-jqgrid-bdiv').css('overflow-x', 'hidden');
            } else {
                $('.ui-jqgrid-bdiv').css('overflow-x', 'auto');
            }
        },
        fixFrozenHeader: function () {
            var header = $('.frozen-div');
            header.css({'top': '4px', 'height': '73px'});
        }
    }

    return $.extend(template, options);
}

function extendEasyGridCommon(options) {
    var template = {
        noRowSelected: function (tableId) {
            var row = $('#' + tableId).datagrid('getSelected');
            return row == null;
        },
        selectedId: function (tableId) {
            return $('#' + tableId).datagrid('getSelected').ID;
        },
        getRowData: function (tableId, rowId) {
            var result = null;
            try {
                result = $('#' + tableId).datagrid('getSelected');
            } catch (e) {

            }
            return result;
        },
        reload: function (tableId, loadParams, url) {
            if (arguments.length == 1) {
                $('#' + tableId).datagrid('reload');
                return;
            }
            $('#' + tableId).datagrid('load', loadParams);
        },
        clearCustomerFilter: function(tableId){
            var options = $('#' + tableId).datagrid('options');
            delete options.queryParams.filterForSearch;
        },
        mergeCells: function (tableID, fldList) {
            var Arr = fldList.split(",");
            var dg = $('#' + tableID);
            var fldName;
            var RowCount = dg.datagrid("getRows").length;
            var span;
            var PerValue = "";
            var CurValue = "";
            var length = Arr.length - 1;
            for (i = length; i >= 0; i--) {
                fldName = Arr[i];
                PerValue = "";
                span = 1;
                for (row = 0; row <= RowCount; row++) {
                    if (row == RowCount) {
                        CurValue = "";
                    }
                    else {
                        CurValue = dg.datagrid("getRows")[row][fldName];
                    }

                    if (PerValue.replace(/ /g, '') == CurValue.replace(/ /g, '')) {
                        span += 1;
                    }
                    else {
                        var index = row - span;
                        dg.datagrid('mergeCells', {
                            index: index,
                            field: fldName,
                            rowspan: span,
                            colspan: null
                        });
                        span = 1;
                        PerValue = CurValue;
                    }
                }
            }
        },
        //------------- cellFormatter ---------------------------------------
        urlFormatter: function (value, row, index) {
            return "<a onclick=\"window.open('http://baidu.com', 'newwindow', 'height=300,width=800,left=200,top=200,toolbar=no,menubar=no,scrollbars=no, resizable=no,location=no, status=no');\" style='font-weight:600;text-decoration:underline;'>" + value + '</a>';
        },
        sexFormatter: function (value, row, index) {
            var val= jQuery.trim(value);
            if (val == "1" || val == '男') {
                return '<span style="color:green"><i class="fa fa-male"></i>（男）</span>';
            } else {
                return '<span style="color:red"><i class="fa fa-female"></i>（女）</span>';
            }
        },
        greenFormatter: function (value, row, index) { 
            return '<span style="color:green;">' + value + '</span>';
        },
        redFormatter: function (value, row, index) {
            return '<span style="color:red;">' + value + '</span>';
        },
        isCustomFilter: false
    }

    return $.extend(template, options);
}

function setJqgridDefaultOptions() {
    jQuery.jgrid.defaults.styleUI = 'Bootstrap';
    jQuery.jgrid.defaults.rowNum = 20;
    jQuery.jgrid.defaults.rowList = [20, 30, 50, 100];
    jQuery.jgrid.defaults.forceFit = true;
    jQuery.jgrid.defaults.shrinkToFit = true;
    jQuery.jgrid.defaults.hoverrows = true;
    jQuery.jgrid.defaults.altRows = true;
    jQuery.jgrid.defaults.resizeStop = function () {
        var widthOut = $('.ui-jqgrid-view').width();
        var widthView = $('.ui-jqgrid-btable').width();

        if (widthView <= widthOut) {
            $('.ui-jqgrid-bdiv').css('overflow-x', 'hidden');
        } else {
            $('.ui-jqgrid-bdiv').css('overflow-x', 'auto');
        }
    }
}

//animate css extend
jQuery.fn.extend({
    animateCss: function (animationName) {
        var animationEnd = 'webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend';
        this.addClass('animated ' + animationName).one(animationEnd, function () {
            jQuery(this).removeClass('animated ' + animationName);
        });
    }
});

