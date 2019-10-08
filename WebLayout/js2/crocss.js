var inner = inner || {};
var getUrlValue = function (url) {
    var url = (url !== undefined) ? url : window.location.href;
    if (url.indexOf("#") > -1) {
        var variable = url.split("#")[1];
    } else {
        var variable = url.split("?")[1];
    }
    if (variable === undefined) {
        return {};
    } else {
        var value = {};
        variable = variable.split("&");
        for (var i = 0, m = variable.length; i < m; i++) {
            value[variable[i].split("=")[0]] = variable[i].split("=")[1];
        }
        return value;
    }
}
//var mathor_url = getUrlValue()['mathor_url']; 
var mathor_url = null;
if (!mathor_url) {

    mathor_url = "10.18.2.186:8888/desktop";
}
inner = {
    iframe_el: null,
    url: 'http://' + mathor_url,
    aid: 1,
    href: null,
    time: null,
    signA: false,
    autoHeight: true,
    getDocHeight: function () { },
    postAction: function (u) {
        var fd = this; //clearInterval(this.time);
        fd.iframe_el_new = document.createElement('iframe');
        //fd.iframe_el_new.id = "contentFrameCross";
        fd.iframe_el_new.height = 0;
        fd.iframe_el_new.style.height = '0px';
        fd.iframe_el_new.style.width = '0px';
        fd.iframe_el_new.style.border = 'none';
        fd.iframe_el_new.width = 0;
        fd.iframe_el_new.frameborder = 0;
        fd.iframe_el_new.border = 0;
        fd.iframe_el_new.scrolling = 'no';
        fd.iframe_el_new.src = fd.url + "/proxy.htm#aid=" + this.aid + "&" + u;
        //alert("fd.iframe_el:::"+fd.iframe_el);
        fd.iframe_el.parentNode.appendChild(fd.iframe_el_new);
        fd.iframe_el.parentNode.removeChild(fd.iframe_el);
        fd.iframe_el_new.id = "contentFrameCross";
        fd.iframe_el = fd.iframe_el_new;
        this.aid++;
    },
    setUrl: function (tzurl, title, show) {

        this.postAction("action=setheight&tzurl=" + tzurl + "&show=" + show + "&tztitle=" + title);
    },
    start: function (tzurl, title, show) {//alert('start');
        /*if(!document.getElementById("contentFrameCross")){
               return;
           }*/

        var fd = this;
        fd.iframe_el = document.getElementById("contentFrameCross"); //-----更改ifram的名称


        fd.setUrl(tzurl, title, show);
    }
};
window.open = function (url, tit) {
    try {
        //if(!tit){tit="查询"}
        if (tit == null || tit == "" || typeof tit == "undefined" || tit == "undefined") {
            // qopen1(url);
        } else {

        }
        if (url && url.indexOf("http") < 0) {
            var rpath = getRootPath();
            url = rpath + "/" + url;
        }
        alert(url);
        inner.start(url, tit, 'tab');
    } catch (e) { alert("windowopen error:" + e); }

}
function qopen1(url) {
    window.open(url);
}

function getRootPath() {
    var curWwwPath = window.document.location.href;
    var pathName = window.document.location.pathname;
    var pos = curWwwPath.indexOf(pathName);
    var localhostPaht = curWwwPath.substring(0, pos);
    var projectName = pathName.substring(0, pathName.substr(1).indexOf('/') + 1);
    return (localhostPaht + projectName);
}


document.write('<iframe id="contentFrameCross" style="width:0; height:0; border:none;display:none" frameborder="0" scrolling="no"></iframe>');

//-----此处也要进行修改，拼接proxy.htm的位置，注意proxy.htm存放的位置
//inner.start();
