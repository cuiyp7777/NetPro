<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="webReq.aspx.cs" Inherits="WebAppApiRequest.webReq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <script src="jquery-3.3.1.min.js"></script>
    <script>
        $(function () {
            $.ajax({
                type: "get",
                url: "http://localhost:60233/AppRe/GetMvcData?id=1&name=aa",
                success: function (data) {
                    $("#test_div").html(data);
                }
            });
        })
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="test_div">
        </div>
    </form>
</body>
</html>
