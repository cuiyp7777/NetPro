var name = "";
var number = "";
var SmsNr = "";
// 查询短信
function queryDXMSG(phoneNum) {
    $.ajax({
        type: "post",
        dataType: "text",
        url: "../handler/Tx.ashx?Method=queryDXMSG",
        data: {
            phoneNum: phoneNum
        },
        success: function (data) {
            $.messager.alert('成功', '短信查询成功!', 'info');
            $.messager.alert('成功', data, 'info');
            //$('#DivSms').dialog('close');
        },
        error: function () {
            $.messager.alert('错误', '请联系管理员!', 'error');
        }
    });
}

// 发送短信
function sendDXMSG(phoneNum, nr) {
    $.ajax({
        type: "post",
        dataType: "text",
        url: "../handler/Tx.ashx?Method=sendDXMSG",
        data: {
            yjsjid: yjsjid,
            UserName: "zhangwensheng.slrj",
            phoneNum: phoneNum,
            dwbm: "21",
            DXNR: "请您处理：" + nr
        },
        success: function (json) {
            $.messager.alert('成功', '短信发送成功!', 'info');
            //$('#DivSms').dialog("close");
        },
        error: function () {
            $.messager.alert('错误', '请联系管理员!', 'error');
        }
    });
}
function OpenDialogSms(obj) {
    name = $(obj).attr("imgname").toString();
    number = $(obj).attr("alt").toString();
    var divTemp = document.createElement("div");
    divTemp.id = "DivSms";
    $(divTemp).dialog({
        title: '短信发送',
        height: '250',
        width: '450',
        iconCls: "icon-ok",
        href: '../Commun/Sms.aspx',
        onClose: function () {
            $(divTemp).remove();
        }
    });
}
function OpenDialogSms(obj, SmsNrValue) {
    name = $(obj).attr("imgname").toString();
    number = $(obj).attr("alt").toString();
    SmsNr = SmsNrValue;
    var divTemp = document.createElement("div");
    divTemp.id = "DivSms";
    $(divTemp).dialog({
        title: '短信发送',
        height: '250',
        width: '450',
        iconCls: "icon-ok",
        href: '../Commun/Sms.aspx',
        onClose: function () {
            $(divTemp).remove();
        }
    });
}
function OpenDialogLeaderSms(v1, v2, SmsNrValue) {
    name = v1;
    number = v2;
    SmsNr = SmsNrValue;
    var divTemp = document.createElement("div");
    divTemp.id = "DivSms";
    $(divTemp).dialog({
        title: '短信发送',
        height: '250',
        width: '450',
        iconCls: "icon-ok",
        href: '../Commun/Sms.aspx',
        onClose: function () {
            $(divTemp).remove();
        }
    });
}