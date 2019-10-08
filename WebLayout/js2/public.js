var ReceiveRWType = undefined;
function GetNewGuid() {
    var S4 = function () {
        return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1);
    };
    return (S4() + S4() + "-" + S4() + "-" + S4() + "-" + S4() + "-" + S4() + S4() + S4());
}

function GetCurTime() {
    var d = new Date();
    var vYear = d.getFullYear();
    var vMon = d.getMonth() + 1;
    var vDay = d.getDate();
    var h = d.getHours();
    var m = d.getMinutes();
    var se = d.getSeconds();
    return vYear + "-"
        + (vMon < 10 ? "0" + vMon : vMon) + "-"
        + (vDay < 10 ? "0" + vDay : vDay) + " "
        + (h < 10 ? "0" + h : h) + ":"
        + (m < 10 ? "0" + m : m) + ":"
        + (se < 10 ? "0" + se : se);
}
//获取浏览器可用宽度
function getWinWidth() {
    var winWidth = 0;
    if (window.innerWidth) {
        winWidth = window.innerWidth;
    } else if (document.body && document.body.clientWidth) {
        winWidth = document.body.clientWidth;
    }
    return winWidth;
}
//获取浏览器可用高度
function getWinHeight() {
    var winHeight = 0;
    if (window.innerHeight) {
        winHeight = window.innerHeight;
    } else if (document.body && document.body.clientHeight) {
        winHeight = document.body.clientHeight;
    }
    return winHeight;
}
//获取浏览器可用高度
function getDocumentHeight() {
    var winHeight = 0;
    winHeight = document.documentElement.clientHeight;
    return winHeight;
}
//新增获取URL参数方法，参数为：pararms
function GetUrlPararm(paras) {
    var url = location.href;
    var paraString = url.substring(url.indexOf("?") + 1, url.length).split("&");
    var paraObj = {};
    for (i = 0; j = paraString[i]; i++) {
        paraObj[j.substring(0, j.indexOf("=")).toLowerCase()] = j.substring(j.indexOf("=") + 1, j.length);
    }
    var returnValue = paraObj[paras.toLowerCase()];
    if (typeof (returnValue) == "undefined") {
        return "";
    }
    else {
        return returnValue;
    }
}
function showSlide(str, time, f, title, w, h) {
    if (f) {
        $.messager.show({
            title: title == undefined ? '温馨提示' : title,
            msg: str,
            width: w == undefined ? 300 : w,
            height: h == undefined ? 200 : h,
            timeout: time == null ? 3000 : time,
            showType: 'slide'
        });
    } else {
        alert(str);
    }
}
//获取所有电话号码
function getAll_CheckBoxPhoneData(roleid) {
    var ckName = 'ckRy_' + roleid;
    var obj = $("input[name='" + ckName + "']");
    var s = '';
    obj.each(function () {
        if ($(this).attr('checked') == "checked") {
            s += $(this).attr("phoneValue") + ' '  //如果选中，将flowData添加到变量s中   
        }
    });
    return s;
}

Date.prototype.format = function (format) {
    /* 
    * eg:format="YYYY-MM-dd hh:mm:ss"; 
    */
    var o = {
        "M+": this.getMonth() + 1,  //month 
        "d+": this.getDate(),     //day 
        "h+": this.getHours(),    //hour 
        "m+": this.getMinutes(),  //minute 
        "s+": this.getSeconds(), //second 
        "q+": Math.floor((this.getMonth() + 3) / 3),  //quarter 
        "S": this.getMilliseconds() //millisecond 
    }


    if (/(y+)/.test(format)) {
        format = format.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
    }


    for (var k in o) {
        if (new RegExp("(" + k + ")").test(format)) {
            format = format.replace(RegExp.$1, RegExp.$1.length == 1 ? o[k] : ("00" + o[k]).substr(("" + o[k]).length));
        }
    }
    return format;
}


function ConertJsonTimeAndFormat(jsonTime, format) {
    return new Date(eval(jsonTime.replace(/\/Date\((\d+)\)\//gi, "new Date($1)"))).format(format);
}

//判断元素是否在数组中出现
Array.prototype.contains = function (obj) {
    var i = this.length;
    while (i--) {
        if (this[i] == obj)
        { return true; }
    } return false;
}
//获取相应元素在数组中的索引
Array.prototype.getIndexLike = function (obj) {
    var i = this.length;
    while (i--) {
        if (this[i].indexOf(obj) > -1)
        { return i; }
    } return -1;
}

function setCookie(name, value) {
    var Days = 7;
    var exp = new Date();
    exp.setTime(exp.getTime() + Days * 24 * 60 * 60 * 1000);
    document.cookie = name + "=" + escape(value) + ";expires=" + exp.toGMTString();
}

//读取cookies 
function getCookie(name) {
    var arr, reg = new RegExp("(^| )" + name + "=([^;]*)(;|$)");

    if (arr = document.cookie.match(reg))

        return unescape(arr[2]);
    else
        return null;
}

//删除cookies 
function delCookie(name) {
    var exp = new Date();
    exp.setTime(exp.getTime() - 1);
    var cval = getCookie(name);
    if (cval != null)
        document.cookie = name + "=" + cval + ";expires=" + exp.toGMTString();
}
//获取指定length位数的随机数
function getRandomNum(length) {
    var chars = ['0', '1', '2', '3', '4', '5', '6', '7', '8', '9'];
    var res = "";
    for (var i = 0; i < length ; i++) {
        var id = Math.ceil(Math.random() * 10);
        res += chars[id];
    }
    return res;
}