<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="HWebTS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <link href="Content/metis/lib/bootstrap/css/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/metis/lib/timepicker/css/bootstrap-timepicker.min.css" rel="stylesheet" />

    <script src="Scripts/jquery-3.2.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Content/metis/lib/timepicker/js/bootstrap-timepicker.min.js"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="input-group bootstrap-timepicker timepicker">
            <input id="timepicker1" type="text" class="form-control input-small">
            <span class="input-group-addon"><i class="glyphicon glyphicon-time"></i></span>
        </div>
 
        <script type="text/javascript">
            $('#timepicker1').timepicker();
        </script>
    </form>
</body>
</html>
