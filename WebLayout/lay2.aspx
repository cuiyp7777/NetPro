<%@ Page Title="" Language="C#" MasterPageFile="~/content2/pageUi.Master" AutoEventWireup="true" CodeBehind="lay2.aspx.cs" Inherits="webPro.lay2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 100%; float: left;">
        <div id="divZDYContent" style="width: 100%; height: 2800px;">
            <div id="divTabsParent" class="easyui-tabs" data-options="fit:true,border:false,tabPosition:'left',tabWidth:134,tabHeight:30,headerWidth:130">
                <div title="综合查询" data-options="iconCls:'icon-mymk'" cache="false" href="content2/index.html">
                </div>
                <div title="应急物资" data-options="iconCls:'icon-mymk'" cache="false" href="content2/Wz_Index.html">
                </div>
                <div title="应急资源点" data-options="iconCls:'icon-mymk'" cache="false" href="content2/Zyd_List.html">
                </div>
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            //导航栏选中第一个
            $("#Nav_l1").prev().css("background-image", "url(Image/colum_click_left.jpg)");
            $("#Nav_l1").css("background-image", "url(Image/colum_click_center.jpg)");
            $("#Nav_l1").css({ color: "#000" });
            $("#Nav_l1").next().css("background-image", "url(Image/colum_click_right.jpg)");
        });
    </script>
</asp:Content>
