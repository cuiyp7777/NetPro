document.write("<script language='javascript' src='../Scripts/jquery.min.js?v=2.1.4'></script>");
document.write("<script language='javascript' src='../Scripts/bootstrap.min.js?v=3.3.6'></script>");
document.write("<script language='javascript' src='../Scripts/jquery-ui-1.10.4.min.js'></script>");
document.write("<script language='javascript' src='../Scripts/jquery-easyui-1.5.1/jquery.easyui.min.js'></script>");
document.write("<script language='javascript' src='../Scripts/jquery-easyui-1.5.1/locale/easyui-lang-zh_CN.js'></script>");
(function () { 
    //加载
    document.write("<script language='javascript' src='../Scripts/layer/layer.js'></script>");
    document.write("<script language='javascript' src='../Scripts/vs.js'></script>");
    document.write("<script language='javascript' src='../Scripts/jquery.layout-1.4/jquery.layout.js'></script>");
    document.write("<script language='javascript' src='../Scripts/icheck/icheck.min.js'></script>");
})();
function openDialog(title, width, height, url) {
    width = width < 920 ? 920 : width;
    height = height < 430 ? 430 : height;
    layer.open({
        type: 2,
        title: title,
        shadeClose: true,
        resize: false,
        //shade: false,
        shadeClose: false,
        maxmin: true, //开启最大化最小化按钮
        area: [width + 'px', height + 'px'],
        content: url
         , end: function () {

         }
    });
}


