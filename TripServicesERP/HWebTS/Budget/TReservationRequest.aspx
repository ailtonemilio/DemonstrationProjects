<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TReservationRequest.aspx.cs" Inherits="HWebTS.Budget.TReservationRequest" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta charset="UTF-8">
    <!--IE Compatibility modes-->
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!--Mobile first-->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <!-- The above 3 meta tags *must* come first in the head; any other head content must come *after* these tags -->
    <title>Solicitação de Reserva -Reservation Request</title>
    
    <meta name="description" content="ERP WebApp TripServices - Development by AJ Web development">
    <meta name="author" content="">
    
    <meta name="msapplication-TileColor" content="#5bc0de" />
    <meta name="msapplication-TileImage" content="Content/metis/img/metis-tile.png" />
    
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/font-awesome.min.css" rel="stylesheet" />
    <link href="../Scripts/sweetalert/sweetalert.css" rel="stylesheet" />
    <link href="../Content/bootstrap-datepicker.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap_custom.css" rel="stylesheet" />
    <link href="../App_Themes/Default/Ajax.css" rel="stylesheet" />
    <link href="../Content/bootstrap-formhelpers.css" rel="stylesheet" />
    <link href="../Content/bootstrap-formhelpers.min.css" rel="stylesheet" />

    <link href="../Content/metis/css/main.css" rel="stylesheet" />
    <link href="../Content/metis/lib/metismenu/metisMenu.css" rel="stylesheet" />

    <style>
        .background {
            background-image: url('../images/bg.png');
            background-repeat:repeat;
        }
        .messagealert {
            width: 30%;
            position: fixed;
            top: 5px;
            right: 220px;
            z-index: 100000;
            padding: 0;
            font-size: 15px;
        }
    </style>

    <!-- animate.css stylesheet -->
    <%--<cc1:ValidatorCalloutExtender ID="RequiredFieldValidator2_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator2_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator2">
                                            </cc1:ValidatorCalloutExtender>--%>

    <link href="../Content/metis/lib/timepicker/css/bootstrap-responsive.css" rel="stylesheet" />
    <link href="../Content/metis/lib/timepicker/css/bootstrap-timepicker.css" rel="stylesheet" />
    <link href="../Content/metis/lib/timepicker/css/bootstrap-timepicker.min.css" rel="stylesheet" />

    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" />
    <link rel="Stylesheet" href="https://twitter.github.io/typeahead.js/css/examples.css" />

    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">
</head>
<body class="background">
    <form id="form1" runat="server">
        <div>
            <%--<div class="row">&nbsp;</div>--%>
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-4 form-inline">
                    <img src="../images/logo.png" />
                </div>

                <div class="col-md-3 text-center" style="vertical-align:central;">
                    <h2><asp:Label ID="lblReservationRequest" runat="server" Text="Reservation Request" ForeColor="White"></asp:Label></h2>
                </div>
                <div class="col-md-4 form-inline text-right">
                    <asp:LinkButton ID="btnTranslateBrazil" OnClick="btnTranslateBrazil_Click" runat="server" class="btn" title="Portugues" ForeColor="White" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Traduzindo">
                        <img src="../images/icon/brazilflag.png" />&nbsp;PT
                    </asp:LinkButton>
                    <label>|</label>
                    <asp:LinkButton ID="btnTranslateEnglish" OnClick="btnTranslateEnglish_Click" runat="server" class="btn" title="English" ForeColor="White" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Translating">
                        <img src="../images/icon/canadaflag.png" />&nbsp;EN
                    </asp:LinkButton>
                    <label>|</label>
                     <asp:LinkButton ID="btnTranslateEspanish" OnClick="btnTranslateEspanish_Click" runat="server" class="btn" title="Español" ForeColor="White" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Traducción">
                        <img src="../images/icon/espanhaflag.png" />&nbsp;ES
                    </asp:LinkButton>
                </div>
            </div>
            <div class="row">&nbsp;</div>
            
            <%-- Passenger --%>
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="panel panel-danger">
                        <div class="panel-heading "><asp:Label ID="lblPassengerInformation" runat="server" Text="Passenger Information"></asp:Label></div>
                        <div class="panel-body ">
                            <div class="Form-Group">
                                <div class="col-12 col-md-4">
                                    <div class="form-group">
                                        <asp:Label ID="lblPasengerName" runat="server" Text="Passenger Name:" CssClass="control-label" AssociatedControlID="txtNamePassenger"></asp:Label>
                                        <asp:TextBox ID="txtNamePassenger" runat="server" Width="100%" ToolTip="maximum 100 characters" onkeyup="document.getElementById('countPassenger').innerHTML=this.value.length + ' of 100 chars';" MaxLength="100"></asp:TextBox>
                                        <span id="countPassenger" style="font-weight: bold; font-size: 8pt; font-family: Arial; text-align: right;"></span>
                                        <asp:RequiredFieldValidator ID="rfvNamePassenger" runat="server" ControlToValidate="txtNamePassenger" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col-12 col-md-2">
                                     <asp:Label ID="lblTypeVisa" runat="server" Text="Type Visa:" CssClass="control-label"></asp:Label>
                                    <asp:DropDownList ID="ddlTypeVisa" runat="server" Width="100%"></asp:DropDownList>
                                </div>
                                <div class="col-12 col-md-2">
                                    <div class="form-group">
                                        <asp:Label ID="lblPhonePassenger" runat="server" Text="Phone:" CssClass="control-label" AssociatedControlID="txtPhonePassenger"></asp:Label>
                                        <asp:TextBox ID="txtPhonePassenger" runat="server" Width="100%" ToolTip="maximum 20 characters" onkeyup="document.getElementById('countPhonePassenger').innerHTML=this.value.length + ' of 20 chars';" MaxLength="20"></asp:TextBox>
                                        <span id="countPhonePassenger" style="font-weight: bold; font-size: 8pt; font-family: Arial; text-align: right;"></span>
                                        <asp:RequiredFieldValidator ID="rfvPhonePassenger" runat="server" ControlToValidate="txtPhonePassenger" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                               <div class="col-12 col-md-4">
                                   
                                   <div class="form-group">
                                       <asp:Label ID="lblEmailPassenger" runat="server" Text="Email:" CssClass="control-label" AssociatedControlID="txtEmailPassenger"></asp:Label>
                                       <asp:TextBox ID="txtEmailPassenger" CssClass="form-control" runat="server" Width="100%" ToolTip="maximum 100 characters" onkeyup="document.getElementById('countEmailPassenger').innerHTML=this.value.length + ' of 100 chars';" MaxLength="100"></asp:TextBox>
                                       <span id="countEmailPassenger" style="font-weight: bold; font-size: 8pt; font-family: Arial; text-align: right;"></span>
                                       <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="txtEmailPassenger" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                       <asp:RegularExpressionValidator ID="revEmail" runat="server" ForeColor="#cc0000"
                                            ControlToValidate="txtEmailPassenger" ErrorMessage="Please enter corect email"
                                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Save">
                                        </asp:RegularExpressionValidator>
                                    </div>
                               </div>
                                
                             </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-1"></div>
            </div>
            <%-- Transfer Information --%>
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="panel panel-danger">
                        <div class="panel-heading "><asp:Label ID="lblTransferInformation" runat="server" Text="Transfer Information"></asp:Label></div>
                        <div class="panel-body">
                            <div class="Form-Group col-12 col-md-12">
                                <div class="col-12 col-md-2">
                                        <asp:Label ID="lblTransferType" runat="server" Text="Transfer Type:" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="ddlTypeTransfer" runat="server" Width="100%"></asp:DropDownList>
                                    </div>

                                    <div class="col-12 col-md-2">
                                        <div class="form-group">
                                            <asp:Label ID="lblDateTransfer" runat="server" Text="Date Transfer:" CssClass="control-label" AssociatedControlID="txtDateEstimate"></asp:Label>
                                            <div class="input-group date" data-provide="datetimepicker">
                                                <asp:TextBox ID="txtDateEstimate" runat="server" Width="100%"></asp:TextBox>
                                                <div class="input-group-addon">
                                                    <span class="glyphicon glyphicon-calendar"></span>
                                                </div>
                                            </div>
                                            <asp:RequiredFieldValidator ID="rfvDateEstimate" runat="server" ControlToValidate="txtDateEstimate" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>

                                    <div class="col-12 col-md-2">
                                        <div class="form-group">
                                            <asp:Label ID="lblDateTime" runat="server" Text="Time:" CssClass="control-label" AssociatedControlID="txtTime"></asp:Label>
                                            <div class="input-group" id='hourtimepicker2'>
                                                <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
                                                <span class="input-group-addon"><i class="glyphicon glyphicon-time"></i></span>
                                            </div>
                                            <asp:RequiredFieldValidator ID="rfvTimeEstimate" runat="server" ControlToValidate="txtTime" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>

                                    <div class="col-12 col-md-2">
                                        <asp:Label ID="lblCityFrom" runat="server" Text="City:" CssClass="control-label"></asp:Label>
                                       <asp:DropDownList ID="ddlCityFrom" runat="server"></asp:DropDownList>
                                    </div>

                            </div>

                                <div class="Form-Group col-12 col-md-12">
                                    <div class="col-12 col-md-2">
                                        <asp:Label ID="lblPassenger" runat="server" Text="Passenger:" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="ddlQtyPassenger" runat="server">
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                    <div class="col-12 col-md-2">
                                        <asp:Label ID="lblKids" runat="server" Text="Passenger:" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="ddlQtyKids" runat="server">
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>
                                    <div class="col-12 col-md-1">
                                        <asp:Label ID="lblLuggage" runat="server" Text="Luggage:" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="ddlQtyLuggage" runat="server">
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>11</asp:ListItem>
                                            <asp:ListItem>12</asp:ListItem>
                                            <asp:ListItem>13</asp:ListItem>
                                            <asp:ListItem>14</asp:ListItem>
                                            <asp:ListItem>15</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                    <div class="col-12 col-md-2">
                                        <asp:Label ID="lblCarryon" runat="server" Text="Carry-on:" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="ddlQtyCarryon" runat="server">
                                            <asp:ListItem>1</asp:ListItem>
                                            <asp:ListItem>2</asp:ListItem>
                                            <asp:ListItem>3</asp:ListItem>
                                            <asp:ListItem>4</asp:ListItem>
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>6</asp:ListItem>
                                            <asp:ListItem>7</asp:ListItem>
                                            <asp:ListItem>8</asp:ListItem>
                                            <asp:ListItem>9</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>11</asp:ListItem>
                                            <asp:ListItem>12</asp:ListItem>
                                            <asp:ListItem>13</asp:ListItem>
                                            <asp:ListItem>14</asp:ListItem>
                                            <asp:ListItem>15</asp:ListItem>
                                        </asp:DropDownList>
                                    </div>

                                     <div class="col-12 col-md-5">
                                       <asp:Label ID="lblOtherTypes" runat="server" Text="Other Types:" CssClass="control-label"></asp:Label>
                                        <asp:TextBox ID="txtOtherTypes" CssClass="form-control" runat="server" Width="100%" ToolTip="maximum 150 characters" onkeyup="document.getElementById('countOtherTypes').innerHTML=this.value.length + ' of 150 chars';" MaxLength="150"></asp:TextBox>
                                        <span id="countOtherTypes" style="font-weight: bold; font-size: 8pt; font-family: Arial; text-align: right;"></span>
                                   </div>
                                </div>
                               
                        </div>
                    </div>
                </div>
                <div class="col-md-1"></div>
            </div>
            <%-- Voo Information --%>
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                    <div class="panel panel-danger">
                        <div class="panel-heading "><asp:Label ID="lblVooInformation" runat="server" Text="Voo Information"></asp:Label></div>
                        <div class="panel-body">
                            <div>
                                 <div class="col-12 col-md-2">
                                     <div class="form-group">
                                         <asp:Label ID="lblFlightNumber" runat="server" Text="Flight Number:" CssClass="control-label" AssociatedControlID="txtFlightNumber"></asp:Label>
                                         <asp:TextBox ID="txtFlightNumber" CssClass="form-control" runat="server" Width="100%" ToolTip="maximum 8 characters" onkeyup="document.getElementById('countFlightNumber').innerHTML=this.value.length + ' of 8 chars';" MaxLength="8"></asp:TextBox>
                                            <span id="countFlightNumber" style="font-weight: bold; font-size: 8pt; font-family: Arial; text-align: right;"></span>
                                        <asp:RequiredFieldValidator ID="rfvFlightNumber" runat="server" ControlToValidate="txtFlightNumber" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                 <div class="col-12 col-md-2">
                                    <div class="form-group">
                                        <asp:Label ID="lblDateVoo" runat="server" Text="Date Voo (DD/MM/YYYY):" CssClass="control-label" AssociatedControlID="txtDateVoo"></asp:Label>
                                        <div class='input-group date' id='datetimepicker'>
                                            <asp:TextBox ID="txtDateVoo" runat="server"></asp:TextBox>
                                            <span class="input-group-addon">
                                                <span class="glyphicon glyphicon-calendar"></span>
                                            </span>
                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvDateVoo" runat="server" ControlToValidate="txtDateVoo" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>

                                <div class="col-12 col-md-2">
                                    <div class="form-group">
                                        <asp:Label ID="lblTimeVoo" runat="server" Text="Time Voo:" CssClass="control-label" AssociatedControlID="txtTimeVoo"></asp:Label>
                                        <div class="input-group" id='hourtimepicker'>
                                            <asp:TextBox ID="txtTimeVoo" runat="server"></asp:TextBox>
                                            <span class="input-group-addon"><i class="glyphicon glyphicon-time"></i></span>
                                        </div>
                                        <asp:RequiredFieldValidator ID="rfvTimeVoo" runat="server" ControlToValidate="txtTimeVoo" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-1"></div>
            </div>

            <%-- Destination --%>
            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10">
                   
                    <div class="panel panel-danger">
                        <div class="panel-heading "><asp:Label ID="lblDestinationInformation" runat="server" Text="Destination"></asp:Label></div>
                        <div class="panel-body">
                            <div class="form-group">
                                <%-- Line1 --%>
                                <div class="row col-md-10">
                                <div class="col-12 col-md-2">
                                    <asp:Label ID="lblTypeDestination" runat="server" Text="Type Destination:" CssClass="control-label"></asp:Label>
                                    <asp:DropDownList ID="ddlTypeDestination" runat="server" ></asp:DropDownList>
                                </div>
                                <div class="col-12 col-md-3">
                                    <div class="form-group">
                                        <asp:Label ID="lblNameDestination" runat="server" Text="Name/Destination:" CssClass="control-label" AssociatedControlID="txtNameDestination"></asp:Label>
                                        <asp:TextBox ID="txtNameDestination" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvNameDestination" runat="server" ControlToValidate="txtNameDestination" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col-12 col-md-2">
                                    <div class="form-group">
                                        <asp:Label ID="lblPhoneContact" runat="server" Text="Phone:" CssClass="control-label" AssociatedControlID="txtPhoneContact"></asp:Label>
                                        <asp:TextBox ID="txtPhoneContact" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvPhoneContact" runat="server" ControlToValidate="txtPhoneContact" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col-12 col-md-3">
                                    <div class="form-group">
                                        <asp:Label ID="lblAddress" runat="server" Text="Address:" CssClass="control-label" AssociatedControlID="txtAddress"></asp:Label>
                                        <asp:TextBox ID="txtAddress" CssClass="form-control" runat="server" Width="100%"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Fiel is empty!" Display="Dynamic" ForeColor="#cc0000" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col-12 col-md-2">
                                    <asp:Label ID="lblCityTo" runat="server" Text="City:" CssClass="control-label"></asp:Label>
                                   <asp:DropDownList ID="ddlCityTo" runat="server"></asp:DropDownList>
                                </div>
                                </div>

                                <%-- Line2 --%>
                                <div class="row col-md-10">
                               
                                    <div class="col-12 col-md-2">
                                        <asp:Label ID="lblPostalCode" runat="server" Text="Postal Code:" CssClass="control-label"></asp:Label>
                                       <asp:TextBox ID="txtPostalCode" CssClass="form-control" runat="server" Width="100%" MaxLength="6"></asp:TextBox>
                                    </div>
                                     <div class="col-12 col-md-2">
                                        <asp:Label ID="lblProvince" runat="server" Text="Province:" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="ddlProvince" runat="server" Width="100%">
                                                <asp:ListItem Value="BC">British Columbia</asp:ListItem>
                                            </asp:DropDownList>
                                    </div>
                                    <div class="col-12 col-md-2">
                                        <asp:Label ID="lblCountry" runat="server" Text="Country:" CssClass="control-label"></asp:Label>
                                        <asp:DropDownList ID="ddlCountry" runat="server" Width="100%">
                                                <asp:ListItem Value="Canada">Canada</asp:ListItem>
                                            </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </div>
                <div class="col-md-1"></div>
            </div>

            <div class="row">
                <div class="col-md-1"></div>
                <div class="col-md-10 text-right">
                    <asp:LinkButton ID="btnSend"  ValidationGroup="Save" runat="server"  class="btn btn-primary" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Sending" OnClick="btnSend_Click">
                    <img src="../images/icon/email.png" />&nbsp;&nbsp;<asp:Label ID="lblSend" runat="server" Text="Send"></asp:Label>
                </asp:LinkButton>
               <asp:LinkButton ID="btnCancelar" runat="server" class="btn btn-danger" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Canceling" OnClick="btnCancelar_Click">
                    <img src="../images/icon/cancel.png" />&nbsp;&nbsp;<asp:Label ID="lblCancel" runat="server" Text="Cancel"></asp:Label>
                </asp:LinkButton>
                </div>
                <div class="col-md-1"></div>
            </div>
            
            
            <div class="form-group">

            </div>
           
            <div class="form-group"></div>
            <div class="form-group"></div>
            <div class="form-group"></div>
        </div>

       <div class="messagealert" id="alert_container"></div>

    <%-- Bootstrap 4 --%>
    <script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>

    <!--JQuery-->
    <script src="../Scripts/jquery-3.3.1.min.js"></script>
    

    <script src="../Scripts/jquery-ui-1.12.1.min.js"></script>

    <script type="text/javascript" src="http://cdn.rawgit.com/bassjobsen/Bootstrap-3-Typeahead/master/bootstrap3-typeahead.min.js"></script>
    <link rel="Stylesheet" href="https://twitter.github.io/typeahead.js/css/examples.css" />

    <!-- Bootstrap -->
    <script src="../Scripts/bootstrap.min.js"></script>

    <!-- My Library -->
    <script src="../Scripts/Library.js"></script>

    <%--SweetAlert--%>
    <script src="../Scripts/sweetalert/sweetalert.js"></script>
    <script src="../Scripts/sweetalert/sweetalert.min.js"></script>

    <%-- Moment --%>
    <script src="../Scripts/moment.min.js"></script>

    <!-- DataPicker Bootstrap-->
    <script src="../Scripts/bootstrap-datepicker.min.js"></script>

    <!-- DataTimePicker Bootstrap-->
    <script src="../Scripts/bootstrap-datetimepicker.min.js"></script>

    <!-- TimePicker Bootstrap-->
    <script src="../Content/metis/lib/timepicker/js/bootstrap-timepicker.js"></script>
    <script src="../Content/metis/lib/timepicker/js/bootstrap-timepicker.min.js"></script>

        <%-- btn Loading --%>
    <script>
        $('.btn').on('click', function () {
            var $this = $(this);
            $this.button('loading');
            setTimeout(function () {
                $this.button('reset');
            }, 1000);
        });
    </script>

    <%--@* Date TimePicker Bootstrap *@--%>
    <script>
        $(function () {
            $('.datetimepicker').datetimepicker();
        });
    </script>

    <%--@* Date TimePicker - Hour only - Bootstrap *@--%>
    <script>
        $(function () {
            $('#hourtimepicker').datetimepicker({
                format: 'LT'
            });
        });
    </script>

    <script>
        $(function () {
            $('#hourtimepicker2').datetimepicker({
                format: 'LT'
            });
        });
    </script>

    <script>
        $(function () {
            $('.data').datepicker({
                format: "mm/dd/yyyy",
                autoclose: true,
                todayHighlight: true,
                inline: true,
                showOtherMonths: true,
                dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
            });
        });
    </script>



    <%--@* DatePicker com a data atual *@--%>
    <script>
        $(function () {
            var currentDate = new Date();
            $('.date').datepicker({
                format: "mm/dd/yyyy",
                autoclose: true,
                todayHighlight: true,
                inline: true,
                showOtherMonths: true,
                dayNamesMin: ['Sun', 'Mon', 'Tue', 'Wed', 'Thu', 'Fri', 'Sat']
            });
            //$('.date').datepicker("setDate", currentDate);
        });
    </script>


    <%-- Auto Complete Passenger--%>
    <%--<script type="text/javascript">
        $(function () {
            $("[id*=txtNamePassenger]").typeahead({
                hint: true,
                highlight: true,
                minLength: 1,
                source: function (request, response) {
                    $.ajax({
                        url: '/Passenger/AutoComplete/',
                        data: "{ 'prefix': '" + request + "'}",
                        dataType: "json",
                        type: "POST",
                        contentType: "application/json; charset=utf-8",
                        success: function (data) {
                            items = [];
                            map = {};
                            $.each(data, function (i, item) {
                                var id = item.lId;
                                var name = item.lName;
                                var email = item.lEmail;
                                var phone = item.lPhone;
                                var phone2 = item.lPhone2;
                                map[name] = { id: id, name: name, email: email, phone: phone, phone2: phone2 };
                                items.push(name);
                            });
                            response(items);
                            $(".dropdown-menu").css("height", "auto");
                        },
                        error: function (response) {
                            alert(response.responseText);
                        },
                        failure: function (response) {
                            alert(response.responseText);
                        }
                    });
                },
                updater: function (item) {
                    $('[id*=hdfIdPassenger]').val(map[item].id);
                    $('[id*=txtfone]').val(map[item].phone);
                    $('[id*=txtPhone2]').val(map[item].phone2);
                    $('[id*=txtEmail]').val(map[item].email);
                    $('[id*=txtTypeVisa]').val(map[item].typevisa);
                    return item;
                }
            });
        });
    </script>--%>

    <%-- Delete Item --%>
    <script>
        function deletealert(ctl, event) {
            // STORE HREF ATTRIBUTE OF LINK CTL (THIS) BUTTON
            var defaultAction = $(ctl).prop("href");
            // CANCEL DEFAULT LINK BEHAVIOUR
            event.preventDefault();
            swal({
                title: "Are you sure?",
                text: "You will not be able to recover this file!",
                type: "warning",
                showCancelButton: true,
                confirmButtonClass: "btn-danger",
                confirmButtonText: "Yes, delete it!",
                cancelButtonText: "No, cancel!",
                closeOnConfirm: false,
                closeOnCancel: true
            },
                function (isConfirm) {
                    if (isConfirm) {
                        swal({ title: "Deleted!", text: "Your file has been deleted.", type: "success", confirmButtonText: "OK!", closeOnConfirm: true },
                            function () {
                                // RESUME THE DEFAULT LINK ACTION
                                window.location.href = defaultAction;
                                return true;
                            });
                    } else {
                        swal("Cancelled", "Your file is safe.", "error");
                        return false;
                    }
                });
        }
    </script>

    <%--@* Calcula valor do transfer *@--%>
    <script>
        $("#btnCalcFinal").click(function () {
            var CityFrom = $("#ddlCityFrom").val();
            var CityTo = $("#ddlCityTo").val();
            var TypeTransfer = $("#IdTypeTransfer").val();

            var QtyP = document.getElementById("ddlQtyPassenger").value;
            var QtyMGr = document.getElementById("ddlQtyLuggage").value;
            var QtyMPq = document.getElementById("ddlQtyCarryon").value;

            swal("Passageiro", QtyP, "info");

            if (QtyP === "0" || !QtyP || !QtyMGr || !QtyMPq) {
                swal("Number of passengers can not be zero or empty. Amount of suitcases can not be zero or empty.", "Insert 0 (Zero) in field (suitcases) !", "warning");
                document.getElementById("txtFinalPrice").value = CityFrom;
                document.getElementById("txtFinalPrice").style.color = "red";
            }
            else {
                if (CityFrom === CityTo) {
                    swal("Same destination!", "Select City From / To!", "warning");
                    document.getElementById("TransferAmount").value = "Select diferent City From / To!";
                    document.getElementById("TransferAmount").style.color = "red";
                }
                else {
                    $.ajax({
                        type: 'get',
                        dataType: 'json',
                        cache: false,
                        url: "/BudgetTransfer/GetCalculateTranfer",
                        data: {
                            qtyPass: $("#QtyPassenger").val(),
                            QtyMlGr: $("#QtyMalaGr").val(),
                            QtyMlPq: $("#QtyMalaPq").val(),
                            IdCityFrom: $("#CityFromId").val(),
                            IdCityTo: $("#CityToId").val()
                        },
                        success: function (response, textStatus, jqXHR) {
                            document.getElementById("txtFinalPrice").value = response.oldval;
                            document.getElementById("TransferAmount").style.color = "black";
                            document.getElementById("TransferAmount").style.textDecoration.bold = "true";
                        },
                        error: function (jqXHR, textStatus, errorThrown) {
                            alert('Error - ' + errorThrown);
                        }
                    });
                }
            }
        });
    </script>

    <%-- Validator Bootstrap in ASP.NET --%>
    <script type="text/javascript">
        function extendedValidatorUpdateDisplay(obj) {
            // Call the original method - Chama o metodo original
            if (typeof originalValidatorUpdateDisplay === "function") {
                originalValidatorUpdateDisplay(obj);
            }
            // Retrieves the state of the control (valid or invalid) -  Recupera o estado do controle (válido ou inválido)
            // and add or remove the has-error class - e adicione ou remova a classe com erro
            var control = document.getElementById(obj.controltovalidate);
            if (control) {
                var isValid = true;
                for (var i = 0; i < control.Validators.length; i += 1) {
                    if (!control.Validators[i].isvalid) {
                        isValid = false;
                        break;
                    }
                }
                if (isValid) {
                    $(control).closest(".form-group").removeClass("has-error");
                } else {
                    $(control).closest(".form-group").addClass("has-error");
                }
            }
        }
        // Replaces the ValidatorUpdateDisplay method - Substitui o método ValidatorUpdateDisplay
        var originalValidatorUpdateDisplay = window.ValidatorUpdateDisplay;
        window.ValidatorUpdateDisplay = extendedValidatorUpdateDisplay;
    </script>

    </form>
</body>
</html>
