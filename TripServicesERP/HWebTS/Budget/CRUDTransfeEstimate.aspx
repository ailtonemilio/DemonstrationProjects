<%@ Page Title="" Language="C#" MasterPageFile="~/MainV3.Master" AutoEventWireup="true" CodeBehind="CRUDTransfeEstimate.aspx.cs" Inherits="HWebTS.Budget.CRUDTransfeEstimate" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadMain" runat="server">
    <%--<cc1:ValidatorCalloutExtender ID="RequiredFieldValidator1_ValidatorCalloutExtender" runat="server" BehaviorID="RequiredFieldValidator1_ValidatorCalloutExtender" TargetControlID="RequiredFieldValidator1">
                                                </cc1:ValidatorCalloutExtender>--%>    <%--<div class="help-block with-errors"></div>--%>

    <style type="text/css">
        .messagealert {
            width: 30%;
            position: fixed;
            top: 5px;
            right: 220px;
            z-index: 100000;
            padding: 0;
            font-size: 15px;
        }

        /*Modal Static*/
        .modal-static { 
            position: fixed;
            top: 15% !important; 
            left: 40% !important; 
            margin-top: -100px;  
            margin-left: -100px; 
            overflow: visible !important;
        }
        .modal-static,
        .modal-static .modal-dialog,
        .modal-static .modal-content {
            width: 300px; 
            height: 460px; 
        }
        .modal-static .modal-dialog,
        .modal-static .modal-content {
            padding: 0 !important; 
            margin: 0 !important;
        }
        .modal-static .modal-content .icon {
        }

        .focus-fs {
            border: 1px solid #ccc;
            border-radius: 4px;
            border-color: crimson;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
            box-shadow: inset 0 1px 1px rgba(255, 0, 0, 0.075), 0 0 8px rgba(255, 0, 0, 0.6);
            -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
        }

        .form-control-focus-fs2 {
            display: block;
            height: 34px;
            padding: 6px 12px;
            font-size: 14px;
            line-height: 1.42857143;
            color: #555;
            background-color: #fff;
            background-image: none;
            border: 1px solid #ccc;
            border-radius: 4px;
            border-color: crimson;
            -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
            box-shadow: inset 0 1px 1px rgba(255, 0, 0, 0.075), 0 0 8px rgba(255, 0, 0, 0.6);
            -webkit-transition: border-color ease-in-out .15s, -webkit-box-shadow ease-in-out .15s;
            -o-transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
            transition: border-color ease-in-out .15s, box-shadow ease-in-out .15s;
        }

       /* Checkbox fs --------------------------------------------------*/
    .checkbox-fs {
        padding-left: 20px;
    }

        .checkbox-fs label {
            display: inline-block;
            vertical-align: middle;
            position: relative;
            padding-left: 2px;
            font-size: 12px;
        }

    .checkbox-fs label::before {
        content: "";
        display: inline-block;
        position: absolute;
        width: 17px;
        height: 17px;
        left: 0;
        margin-left: -20px;
        border: 1px solid #cccccc;
        border-radius: 3px;
        background-color: #fff;
        -webkit-transition: border 0.15s ease-in-out, color 0.15s ease-in-out;
        -o-transition: border 0.15s ease-in-out, color 0.15s ease-in-out;
        transition: border 0.15s ease-in-out, color 0.15s ease-in-out;
    }

    .checkbox-fs label::after {
        display: inline-block;
        position: absolute;
        width: 16px;
        height: 16px;
        left: 0;
        top: 0;
        margin-left: -20px;
        padding-left: 3px;
        padding-top: 1px;
        font-size: 11px;
        color: #555555;
    }

    .checkbox-fs input[type="checkbox"] {
        opacity: 0;
        z-index: 1;
    }

    .checkbox-fs input[type="checkbox"]:checked + label::after {
        font-family: "FontAwesome";
        content: "\f00c";
    }

    .checkbox-fs input[type="checkbox"]:checked + label::before {
        border-color: crimson;
        -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
        box-shadow: inset 0 1px 1px rgba(255, 0, 0, 0.075), 0 0 8px rgba(255, 0, 0, 0.6);
    }

    .checkbox-fs input[type="checkbox"]:checked + label::after {
        color: red;
    }
    /* Checkbox fs --------------------------------------------------*/
    </style>

    

   <%-- <link href="../Content/bootstrap.css" rel="stylesheet" />
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

    <link href="../Content/metis/lib/timepicker/css/bootstrap-responsive.css" rel="stylesheet" />
    <link href="../Content/metis/lib/timepicker/css/bootstrap-timepicker.css" rel="stylesheet" />
    <link href="../Content/metis/lib/timepicker/css/bootstrap-timepicker.min.css" rel="stylesheet" />

    <link href="http://ajax.aspnetcdn.com/ajax/jquery.ui/1.9.2/themes/blitzer/jquery-ui.css" rel="Stylesheet" type="text/css" />
    <link rel="Stylesheet" href="https://twitter.github.io/typeahead.js/css/examples.css" />

    <link rel="stylesheet" href="//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css">--%>

    <!--No change this items, date and hour-->
    <link href="../Content/bootstrap-datepicker.css" rel="stylesheet" />
    <link href="../Content/bootstrap-datepicker.min.css" rel="stylesheet" />

    <link href="../Ubold/assets/libs/flatpickr/flatpickr.min.css" rel="stylesheet" type="text/css" />
    <link href="../Ubold/assets/libs/bootstrap-colorpicker/bootstrap-colorpicker.min.css" rel="stylesheet" type="text/css" />
    <link href="../Ubold/assets/libs/clockpicker/bootstrap-clockpicker.min.css" rel="stylesheet" type="text/css" />
    <link href="../Ubold/assets/libs/bootstrap-datepicker/bootstrap-datepicker.min.css" rel="stylesheet" type="text/css" />

    <!--JScript-->
    <script src="../Scripts/jquery-3.3.1.min.js"></script>

    <%-- Este css tem que ficar aqui apos o carregamento dos CSS no Content--%>
    <style type="text/css">
        .panel-custom-red {
        border-color: #d9534f;
        }

        .panel-custom-red > .panel-heading {
            background: #d9534f;
            color: #ffffff;
            border-color: #d9534f;
        }

        .has-error .help-block,
.has-error .control-label,
.has-error .radio,
.has-error .checkbox,
.has-error .radio-inline,
.has-error .checkbox-inline,
.has-error.radio label,
.has-error.checkbox label,
.has-error.radio-inline label,
.has-error.checkbox-inline label {
    color: #a94442;
}

.has-error .form-control {
    border-color: #a94442;
    -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
    box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075);
}

    .has-error .form-control:focus {
        border-color: #843534;
        -webkit-box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075), 0 0 6px #ce8483;
        box-shadow: inset 0 1px 1px rgba(0, 0, 0, .075), 0 0 6px #ce8483;
    }

.has-error .input-group-addon {
    color: #a94442;
    background-color: #f2dede;
    border-color: #a94442;
}

.has-error .form-control-feedback {
    color: #a94442;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    <div>
        &nbsp;
        <div class="card">
            <div class="card-body">

            
            <div class="form-group">
                <h3><asp:Label ID="lblTitle" runat="server" Text="New Transfer Estimate"></asp:Label></h3>
            </div>
            
            <%-- Passenger --%>
            <div class="card">
                <div class="card-header bg-danger text-white">Passenger Information</div>
                <div class="card-body">
                    <asp:UpdatePanel ID="upMainPassenger" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div>
                                <div class="row">
                                   
                                        <div class="col-lg-1">&nbsp;<label>Name</label></div>
                                        <div class="col-lg-3">
                                            <div class="form-group">
                                                 <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class="fas fa-user"></i></span>
                                                    </div>
                                                    <asp:TextBox ID="txtNamePassenger" runat="server" ControlToValidate="txtNamePassenger" Enabled="false"></asp:TextBox>
                                                </div>
                                                <asp:HiddenField ID="hdfIdPassenger" runat="server" />
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNamePassenger" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small"  ValidationGroup="Save"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="col-lg-1 text-left">
                                            <asp:LinkButton ID="btnInsertPassenger" runat="server" OnClick="btnInsertPassenger_Click" value="NewPassenger" class="btn" title="Search Passenger and Insert New Passenger" ToolTip="Search Passenger and Insert New Passenger" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Searching">
                                                <img src="../images/icon/search.png" />
                                            </asp:LinkButton>
                                        </div>

                                        <div class="col-lg-1">
                                            <label>Phone</label></div>
                                        <div class="col-md-2">
                                            <div class="input-group">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><i class="fas fa-phone"></i></span>
                                                </div>
                                                <asp:TextBox ID="txtfone" runat="server" ControlToValidate="txtfone" Enabled="false"></asp:TextBox>
                                            </div>

                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtfone" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>

                                        <div class="col-lg-1">
                                            <label>Phone 2</label></div>
                                        <div class="col-lg-2">
                                            <div class="input-group">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><i class="fas fa-phone"></i></span>
                                                </div>
                                                <asp:TextBox ID="txtPhone2" runat="server" Enabled="false"></asp:TextBox>
                                            </div>
                                        </div>
                                </div>
                                 <div class="row">&nbsp;</div>
                                <div class="row">
                                    
                                        <div class="col-12 col-md-1">&nbsp;<label>Email</label></div>
                                        <div class="col-12 col-md-3">
                                            <%--<input id="txtEmail" runat="server" class="form-control col-12 col-md-11" type="email" data-error="Por favor, informe um e-mail correto." title="Insert correct email. sample: blabla@gmail.com" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,3}$">--%>
                                            <%--<div class="help-block with-errors"></div>--%>
                                            <div class="form-group">
                                                 <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class=" fas fa-envelope"></i></span>
                                                    </div>
                                                    <asp:TextBox ID="txtEmail" runat="server" ControlToValidate="txtEmail" Enabled="false"></asp:TextBox>
                                                </div>
                                            
                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save">
                                                </asp:RequiredFieldValidator>

                                                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                                    ControlToValidate="txtEmail" ErrorMessage="Please enter corect email"
                                                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Save">
                                                </asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                        <div class="col-12 col-md-1 text-left">
                                            <asp:LinkButton ID="btnClearPassenger" runat="server" OnClick="btnClearPassenger_Click" value="ClearPassenger" class="btn" title="Clear Fields" data-loading-text="<i class='fa fa-spinner fa-spin'></i>   Clearing">
                                                <img src="../images/icon/clean.png" />
                                            </asp:LinkButton>
                                        </div>
                                    

                                    <div class="col-12 col-md-1">
                                        <label>Visa</label></div>
                                    <div class="col-12 col-md-2">
                                        <asp:TextBox ID="txtTypeVisa" runat="server" Enabled="false"></asp:TextBox>
                                    </div>

                                    <div class="col-12 col-md-1">
                                        <label>Note</label></div>
                                    <div class="col-12 col-md-3">
                                        <asp:TextBox ID="txtNote" runat="server" TextMode="MultiLine" ToolTip="maximum 500 characters" onkeyup="document.getElementById('countNotes').innerHTML=this.value.length + ' of 500 chars';" MaxLength="500"></asp:TextBox>
                                        <span id="countNotes" style="font-weight: bold; font-size: 9pt; font-family: Arial; text-align: right;"></span>
                                    </div>

                                </div>

                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>


                </div>
            </div>

            <%-- Transfer Information --%>
            <div class="card">
                <div class="card-header bg-danger text-white">Transfer Information</div>
                <div class="card-body">
                    <div>
                        <div class="row">
                           <%-- <div class="col-lg-1"></div>--%>
                            <div class="col-12 col-lg-10">
                                 <asp:UpdatePanel ID="UpDepartures" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <div class="row">
                                                <div class="col-12 col-lg-3">
                                                    <label>Transfer</label>
                                                    <asp:DropDownList ID="ddlTypeTransfer" runat="server"></asp:DropDownList>
                                                </div>

                                                <div class="col-12 col-lg-3">
                                                    <label>Departures</label>
                                                    <asp:DropDownList ID="ddlCityFrom" runat="server"></asp:DropDownList>
                                                </div>
                            
                                                <div class="col-12 col-lg-3">
                                                    <label>Destination</label>
                                                    <asp:DropDownList ID="ddlCityTo" runat="server"></asp:DropDownList>
                                                </div>
                                            </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                            </div>
                            <%--<div class="col-lg-1"></div>--%>
                        </div>
                        <div class="row">&nbsp;</div>
                        <div class="row">
                            <%--<div class="col-md-1"></div>--%>
                            <div class="col-12 col-lg-10">
                                <div class="row">
                                <div class="col-12 col-lg-3">
                                    <div class="form-group">
                                    <label>Flight Number</label>
                                    <asp:TextBox ID="txtFlightNumber" runat="server"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator15" runat="server" ControlToValidate="txtFlightNumber" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>
                                </div>
                                <div class="col-12 col-lg-3">
                                        <div class="form-group">
                                            <label>Flight day</label>
                                            <div class="input-group date" data-provide="datepicker">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><span class="fas fa-calendar"></span></span>
                                                </div>
                                                <asp:TextBox ID="txtDateVoo" runat="server"></asp:TextBox>
                                            </div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator13" runat="server" ControlToValidate="txtDateVoo" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                <div class="col-12 col-lg-3">
                                        <div class="form-group">
                                        <label>Flight Time</label>
                                             <div class="input-group clockpicker">
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="mdi mdi-clock-outline"></i></span>
                                                </div>
                                                 <asp:TextBox ID="txtTimeVoo" runat="server"></asp:TextBox>
                                            </div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator14" runat="server" ControlToValidate="txtTimeVoo" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <%--<div class="col-md-1"></div>--%>
                        </div>

                        <div class="row">
                            <%--<div class="col-12 col-lg-1"></div>--%>
                            <div class="col-12 col-lg-10">
                                <%-- Flight Details --%>
                                <div class="row">
                                    <div class="col-12 col-lg-3">
                                        <label>Meeting / Drop off point</label>
                                        <asp:DropDownList ID="ddlMetingPoint" runat="server"></asp:DropDownList>
                                    </div>
                                    <div class="col-12 col-lg-3">
                                        <label>Transfer Date</label>
                                        <div class="form-group">
                                            <div class="input-group date" data-provide="datepicker">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><span class="fas fa-calendar"></span></span>
                                                </div>
                                                <asp:TextBox ID="txtDateEstimate" runat="server"></asp:TextBox>
                                            </div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator12" runat="server" ControlToValidate="txtDateEstimate" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>
                                
                                    </div>
                                    <div class="col-12 col-lg-3">
                                        <label>Transfer Time</label>
                                        <div class="form-group">
                                            <div class="input-group clockpicker">
                                                <div class="input-group-append">
                                                    <span class="input-group-text"><i class="mdi mdi-clock-outline"></i></span>
                                                </div>
                                                 <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
                                            </div>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator16" runat="server" ControlToValidate="txtTime" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                </div>  
                            </div>
                            <div class="col-12 col-lg-1"></div>                       

                        </div>

                        <div class="row">
                           <%-- <div class="col-12 col-lg-1"></div>--%>
                            <div class="col-12 col-lg-10">
                                <div class="row">
                                    <div class="col-12 col-lg-3">
                                        <label>Passenger over 12 years old</label>
                                        <asp:DropDownList ID="ddlQtyPassenger" runat="server">
                                            <asp:ListItem>0</asp:ListItem>
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
                            
                                    <div class="col-12 col-lg-4">
                                        <label>Passenger under 12 years old (Kid)</label>
                                        <asp:DropDownList ID="ddlQtyKids" runat="server">
                                            <asp:ListItem>0</asp:ListItem>
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

                                    <div class="col-12 col-lg-2">
                                        <label>Luggage</label>
                                        <asp:DropDownList ID="ddlQtyLuggage" runat="server">
                                            <asp:ListItem>0</asp:ListItem>
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
                            
                                    <div class="col-12 col-lg-2">
                                        <div class="form-group">
                                        <label>Carry-on </label>
                                        <asp:DropDownList ID="ddlQtyCarryon" runat="server">
                                            <asp:ListItem>0</asp:ListItem>
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
                                    </div>
                                </div>
                            </div>
                            <%--<div class="col-12 col-lg-1"></div>--%>
                        </div>
                            
                        <div class="row">
                            <%--<div class="col-12 col-lg-1"></div>--%>
                            <div class="col-12 col-lg-10">
                                <%-- Destination / Origin --%>
                                    <asp:UpdatePanel ID="upMainDestination" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <div class="row">
                                                
                                                    <div class="col-12 col-lg-3 form-group">
                                                        <label>Type Destination</label>
                                                        <div class="form-inline">
                                                            <asp:DropDownList ID="ddlTypeDestination" runat="server" OnSelectedIndexChanged="ddlTypeDestination_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
                                                        &nbsp;
                                                            <asp:LinkButton ID="btnTypeDestination" runat="server" OnClick="btnNewTypeDestination_Click" value="NewTypeDestination" class="btn" title="Add New Type Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Opening">
                                                                    <img src="../images/icon/search.png" />
                                                        </asp:LinkButton>
                                                        </div>
                                                    </div>
                                                   
                                                    <div class="col-12 col-lg-9">
                                                        <label>Contact / Name</label>
                                                        <div class="form-inline">
                                                            <div id="divDestination" runat="server" class="form-inline">
                                                                <asp:DropDownList ID="ddlDestination" runat="server" OnSelectedIndexChanged="ddlDestination_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
                                                                &nbsp;<asp:LinkButton ID="btnNewDestination" runat="server" OnClick="btnNewDestination_Click" value="NewDestination" class="btn" title="Add New Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Opening">
                                                                            <img src="../images/icon/search.png" />
                                                                </asp:LinkButton>
                                                                &nbsp;&nbsp;&nbsp;<asp:LinkButton ID="btnCalcEstimate" runat="server" CssClass="ladda-button btn btn-blue" OnClick="btnCalcEstimate_Click" value="CalcFinalPrice"  title="Calculate transfer estimate" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Calculating">
                                                                    <img src="../images/icon/calculate2.png" />
                                                                </asp:LinkButton>
                                                                &nbsp;
                                                                <asp:Label ID="Label1" runat="server" Text="Transfe Estimate: $ "></asp:Label><b><asp:Label ID="lblTransferAmount" runat="server" Text=""></asp:Label></b>
                                                            </div>
                                                        </div>
                                                    </div>

                                                    
                                                </div>
                                        </ContentTemplate>
                                    </asp:UpdatePanel>
                            </div>
                           <%-- <div class="col-12 col-lg-1"></div>--%>
                        </div>
                        </div>
                </div>
            </div>

            <%-- Sales Channel --%>
            <div class="card">
                <div class="card-header bg-danger text-white">Sales Channel</div>
                <div class="card-body">
                    <asp:UpdatePanel ID="UpSalesChannel" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                            <div>
                                <div class="row">
                                    <div class="col-12 col-lg-2">
                                        <label>Date</label>
                                        <div class="form-group">
                                            <div class="input-group date" data-provide="datepicker">
                                                <div class="input-group-prepend">
                                                    <span class="input-group-text"><span class="fas fa-calendar"></span></span>
                                                </div>
                                                <asp:TextBox ID="txtDateAprove" runat="server"></asp:TextBox>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="col-12 col-lg-10">
                                        <asp:UpdatePanel ID="UpSalesChannel1" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                                        <ContentTemplate>
                                            <div class="row">
                                             <%--<div class="col-12 col-md-1"></div>--%>
                                            <div class="col-12 col-lg-4">
                                                <label>Sales Channel</label>
                                                <asp:DropDownList ID="ddlSalesContact" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlSalesContact_SelectedIndexChanged"></asp:DropDownList>
                                            </div>

                                            <%--<div class="col-12 col-md-1"></div>--%>
                                            <div class="col-12 col-lg-3">
                                                <label>Type Payment</label>
                                                <asp:DropDownList ID="ddlTypePayment" runat="server"></asp:DropDownList>
                                            </div>

                                            <%--<div class="col-12 col-md-1"></div>--%>
                                            <div class="col-12 col-lg-3">
                                                <label>Status Payment</label>
                                                <asp:DropDownList ID="ddlStatusPayment" runat="server"></asp:DropDownList>
                                            </div>

                                            <div class="col-12 col-lg-2">
                                                <label>Aprove</label>
                                                <asp:DropDownList ID="ddlAprove" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlAprove_SelectedIndexChanged"></asp:DropDownList>
                                            </div>
                                                </div>
                                        </ContentTemplate>
                                        </asp:UpdatePanel>
                                    </div>
                                </div>
                                 
                                
                                <asp:UpdatePanel ID="UpSalesChannel2" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                                    <ContentTemplate>
                                        <div class="row">
                                            
                                            
                                            <div class="col-12 col-md-2">
                                                <label>Discount</label>
                                                <div class="input-group">
                                                    <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class="fas fa-dollar-sign"></i></span>
                                                    </div>
                                                    <asp:TextBox ID="txtDiscount" runat="server"></asp:TextBox>
                                                </div>
                                            </div>
                                    
                                                
                                                <div class="col-12 col-md-10">
                                                    <div class="form-group">
                                                        <label>Final Price</label>
                                                        <div class="form-inline">
                                                            <div class="input-group">
                                                                <div class="input-group-prepend">
                                                                    <span class="input-group-text"><i class="fas fa-dollar-sign"></i></span>
                                                                </div>
                                                                <asp:TextBox ID="txtFinalPrice" runat="server" ToolTip="Field is empty, Calculate the final price!"></asp:TextBox>
                                                            </div>
                                                            &nbsp;&nbsp;
                                                             <asp:LinkButton ID="btnCalcFinalPrice" runat="server" OnClick="btnCalcFinalPrice_Click" value="CalcFinalPrice" class="ladda-button btn btn-blue" title="Calculate Final Price" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Calculating">
                                                                 <img src="../images/icon/calculate2.png" />&nbsp;&nbsp;Calculate Final Price
                                                                </asp:LinkButton>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                                                <asp:LinkButton ID="LinkButton1" OnClick="btnSaveTrasferEstimate_Click" ValidationGroup="Save" runat="server" value="SaveTransferEstimate" class="ladda-button btn btn-success" title="Save Estimate" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Savinging">
                                                                    <img src="../images/icon/save.png" />&nbsp;&nbsp;Save Estimate
                                                                </asp:LinkButton>
                                                            &nbsp;&nbsp;&nbsp;&nbsp;
                                                                <asp:LinkButton ID="LinkButton3" OnClick="btnCancelTransferEstimate_Click" runat="server" value="CancelTransferEstimate" class="ladda-button btn btn-danger" title="Cancel Tranfer estimate" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Canceling">
                                                                    <img src="../images/icon/cancel.png" />&nbsp;&nbsp;Cancel Estimate
                                                                </asp:LinkButton>
                                                            &nbsp;&nbsp;
                                                            <asp:CheckBox ID="cbIncludeCalendar" runat="server" text="Include in Calendar"/>
                                                        </div>
                                                    
                                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtFinalPrice" ErrorMessage="Field is empty, Calculate the final price first!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="Save"></asp:RequiredFieldValidator>
                                                        <asp:Label ID="lblDemonstrativePrice" runat="server" Text="" Font-Size="8pt" ForeColor="Blue" Visible="false"></asp:Label>
                                                    </div>
                                                </div>
                                            
                                    
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </div>
            </div>
            </div>
        </div>

    </div>

     <%--ModalInsertSuccess--%>
     <div class="modal fade" id="ModalInsertSuccess" role="dialog" aria-labelledby="myModalInsertSuccess" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="UpModalInsertSuccess" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-body text-center">
                            <h1><asp:Label ID="lblTitleModalSucess" runat="server" Text="Transfer Estimate Inserted successfully."></asp:Label></h1>
                            <br />
                            <%-- Exemplo --%>
                            <%--https://bootsnipp.com/snippets/featured/success-and-error-icon-animation--%>
                            <div class="swal2-icon swal2-success swal2-animate-success-icon" style="display: flex;">
                                <div class="swal2-success-circular-line-left" style="background-color: rgb(255, 255, 255);"></div>
                                <span class="swal2-success-line-tip"></span>
                                <span class="swal2-success-line-long"></span>
                                <div class="swal2-success-ring"></div> 
                                <div class="swal2-success-fix" style="background-color: rgb(255, 255, 255);"></div>
                                <div class="swal2-success-circular-line-right" style="background-color: rgb(255, 255, 255);"></div>
                            </div>

                            <br />
                            <h3>What do you want to do now ?</h3>
                            <br />
                            <div class="row">
                                <div class="col-12 col-lg-2">
                                    &nbsp;
                                </div>
                                <div class="col-12 col-lg-8">
                                    <div class="form-group">
                                         <asp:LinkButton ID="btnGoCalendar" Width="100%" runat="server" OnClick="btnGoCalendar_Click"  class="btn btn-info btn-lg" title="Enter New Estimate Transfer" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Preparing Form">
                                        <img src="../images/icon/calendar.png" />&nbsp;&nbsp;Go to Calendar
                                        </asp:LinkButton>
                                        <div>&nbsp;</div>
                                        <asp:LinkButton ID="btnInsertNewTransferEstimate" Width="100%" runat="server" OnClick="btnInsertNewTransferEstimate_Click"  class="btn btn-success btn-lg" title="Enter New Estimate Transfer" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Preparing Form">
                                        <img src="../images/icon/calculate2.png" />&nbsp;&nbsp;New Estimate Transfer
                                        </asp:LinkButton>
                                        <div>&nbsp;</div>
                                        <asp:LinkButton ID="btnGoTransfersApproved" Width="100%" OnClick="btnGoTransfersApproved_Click" runat="server" class="btn btn-primary btn-lg" title="Back to Transfers Table" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Returning">
                                            <img src="../images/icon/ok.png" />&nbsp;&nbsp;Go to Transfers Approved
                                        </asp:LinkButton>
                                         <div>&nbsp;</div>
                                        <asp:LinkButton ID="btnCancelTransferEstimate" Width="100%" OnClick="btnCancelTransferEstimate_Click" runat="server" class="btn btn-warning btn-lg" title="Back to Transfers Table" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Returning">
                                            <img src="../images/icon/cancel.png" />&nbsp;&nbsp;Back to Transfers Table
                                        </asp:LinkButton>
                                    </div>
                                </div>
                                <div class="col-12 col-lg-2">
                                    &nbsp;
                                </div>
                            </div>
                            
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <%-- ModalSuccess --%>
    <div class="modal fade" id="ModalSucess" role="dialog" aria-labelledby="myModalSucess" aria-hidden="true">
        <div class="modal-dialog modal-lg">
            <asp:UpdatePanel ID="UpdatePanel2" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header bg-danger">
                            <h4 class="modal-title"><asp:Label ID="Label5" runat="server"  Text="Sample"></asp:Label></h4>
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        </div>
                        <div class="modal-body">
                            <div>
                                    <asp:LinkButton ID="LinkButton4" Width="100%"  OnClick="btnInsertNewTransferEstimate_Click" runat="server"  class="btn btn-success btn-lg" title="Enter New Estimate Transfer" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Preparing Form">
                                        <img src="../images/icon/calculate2.png" />&nbsp;&nbsp;New Estimate Transfer
                                    </asp:LinkButton>

                                <asp:Button ID="btnteste" runat="server" OnClick="btnInsertNewTransferEstimate_Click" Text="Teste" />
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <%-- ModalDestination --%>
    <div class="modal fade" id="ModalDestination" role="dialog" aria-labelledby="myModalDestination" aria-hidden="true">
        <div class="modal-dialog modal-lg">
            <asp:UpdatePanel ID="UpModalDestination" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header bg-danger">
                            <h4 class="modal-title"><asp:Label ID="lblModalDestination" runat="server" ForeColor="White" Text="Sample"></asp:Label></h4>
                            <button type="button" class="close"  data-dismiss="modal" aria-hidden="true">&times;</button>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                    <%--Linha1  --%>
                                    <asp:HiddenField ID="hdfIdDestinationOn" runat="server" />
                                    <div class="col-lg-4">
                                        <div class="form-group">
                                            <asp:TextBox ID="txtNameDestination" runat="server" placeholder="Destination"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtNameDestination" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="InsertDestination1"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-lg-3">
                                        <div class="form-group">
                                            <asp:TextBox ID="txtPhoneDestination" runat="server" placeholder="Phone or mobile"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtPhoneDestination" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="InsertDestination1"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-lg-3">
                                        <%--<div class="form-group">--%>
                                            <asp:TextBox ID="txtMobileDestination" runat="server" placeholder="Phone or mobile"></asp:TextBox>
                                        <%--</div>--%>
                                    </div>
                                    <div class="col-lg-2">
                                        <div class="form-group">
                                            <asp:TextBox ID="txtPostalCodeDestination" runat="server" placeholder="Postal Code"></asp:TextBox>
                                        </div>
                                    </div>
                            </div>
                            <div class="row">
                                <%--Linha2  --%>
                                    <div class="col-md-4">
                                        <div class="form-group">
                                            <asp:TextBox ID="txtAddressDestination" runat="server" placeholder="Address"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator11" runat="server" ControlToValidate="txtAddressDestination" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="InsertDestination1"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-3">
                                        <div class="form-group">
                                            <asp:DropDownList ID="ddlIdCityDestModal" runat="server" ></asp:DropDownList>
                                        </div>
                                    </div>
                                    <div class="col-md-3">
                                       <div class="form-group">
                                           <asp:DropDownList ID="ddlIdSalesDestModal" runat="server"></asp:DropDownList>
                                       </div>

                                    </div>
                                    <div class="col-md-2">
                                        <div class="form-group">
                                            <asp:DropDownList ID="ddlIdTypeDestModal" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlIdTypeDestModal_SelectedIndexChanged" ></asp:DropDownList>
                                        </div>
                                    </div>
                            </div>
                            <div class="row">
                                <%--Linha3  --%>
                                    <div class="col-md-12">
                                        <div class="form-group text-right">
                                            <asp:LinkButton ID="btnSearchModalDestination" OnClick="btnSearchModalDestination_Click"  runat="server" value="SearchDestination" class="ladda-button btn btn-primary" title="Search Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Searching">
                                                <img src="../images/icon/search.png" />&nbsp;&nbsp;Search
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="btnEditDestination" OnClick="btnEditDestination_Click"  runat="server" class="ladda-button btn btn-blue" title="Update Destination" Visible="false" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Updating">
                                                <img src="../images/icon/save.png" />&nbsp;&nbsp;Update
                                            </asp:LinkButton>
                                            <asp:LinkButton ID="btnSaveModalDestination"  ValidationGroup="InsertDestination1"  runat="server" OnClick="btnSaveModalDestination_Click" value="SaveDestination" class="ladda-button btn btn-success" title="Save Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Inserting">
                                                <img src="../images/icon/select.png" />&nbsp;&nbsp;Insert
                                            </asp:LinkButton>

                                            <asp:LinkButton ID="btnCancelModalDestination"  runat="server" OnClick="btnCancelModalDestination_Click" value="CancelDestination" class="ladda-button btn btn-warning" title="Cancel Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Canceling">
                                                <img src="../images/icon/cancel.png" />&nbsp;&nbsp;Reset
                                            </asp:LinkButton>
                                        </div>
                                    </div>
                            </div>
                            <div class="row">
                                <div class="col-lg-12" style="height:250px; overflow-y:scroll;">
                                    <div id="divGridModalDestination"  runat="server">
                                    <asp:GridView ID="gvDestination" runat="server" AutoGenerateColumns="False" DataKeyNames="IdDestination" Width="100%" SkinID="NoGridBS" OnSelectedIndexChanged="gvDestination_SelectedIndexChanged" EmptyDataText="No data available in table" >
                                        <Columns>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imbSelectDestination" OnClick="imbSelectDestination_Click" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/images/icon/seta.png" Text="Select" ToolTip="Select the Destination to enter in the Transfer Estimate" />
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                           
                                            <asp:TemplateField HeaderText="Destination">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                                                    <asp:HiddenField ID="hdfIdDestination" runat="server" value='<%# Eval("IdDestination") %>'/>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                                                    <asp:HiddenField ID="hdfIdDestination" runat="server" value='<%# Eval("IdDestination") %>'/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Address">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtAddress" runat="server" Text='<%# Bind("Address") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblAddress" runat="server" Text='<%# Bind("Address") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Postal Code">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtPostalCode" runat="server" Text='<%# Bind("PostalCode") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblPostalCode" runat="server" Text='<%# Bind("PostalCode") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="City">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtCity" runat="server" Text='<%# Bind("City") %>'></asp:TextBox>
                                                    <asp:HiddenField ID="hdfIdCity" runat="server" value='<%# Eval("IdCity") %>'/>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                                                    <asp:HiddenField ID="hdfIdCity" runat="server" value='<%# Eval("IdCity") %>'/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Phone">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtPhone" runat="server" Text='<%# Bind("Phone") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblPhone" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Mobile">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtMobile" runat="server" Text='<%# Bind("Mobile") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblMobile" runat="server" Text='<%# Bind("Mobile") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Type Destination">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtTypeDestination" runat="server" Text='<%# Bind("DescTypeDestination") %>'></asp:TextBox>
                                                    <asp:HiddenField ID="hdfIdTypeDestination" runat="server" value='<%# Eval("IdTypeDestination") %>'/>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTypeDestination" runat="server" Text='<%# Bind("DescTypeDestination") %>'></asp:Label>
                                                    <asp:HiddenField ID="hdfIdTypeDestination" runat="server" value='<%# Eval("IdTypeDestination") %>'/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                             <asp:TemplateField HeaderText="Sales Contact">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtSalesContact" runat="server" Text='<%# Bind("Contact") %>'></asp:TextBox>
                                                    <asp:HiddenField ID="hdfIdSalesContact" runat="server" value='<%# Eval("IdSalesContact") %>'/>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblSalesContact" runat="server" Text='<%# Bind("Contact") %>'></asp:Label>
                                                    <asp:HiddenField ID="hdfIdSalesContact" runat="server" value='<%# Eval("IdSalesContact") %>'/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="imbEditDestination" OnClick="imbEditDestination_Click" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/images/icon/Editar.png" Text="Edit" ToolTip="Select the Destination to edit in the Transfer Estimate" />
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                             <%--<asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                     <asp:LinkButton ID="btnSelectDestination" OnClick="btnSelectDestination_Click" runat="server" CausesValidation="False" CommandName="Select" title="Select Destination for Duplicate">
                                                        <img src="../images/icon/select.png" />
                                                    </asp:LinkButton>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>--%>
                                        </Columns>
                                    </asp:GridView>
                                </div>
                                 
                                <div id="divGridRequestReservation" runat="server">
                                    <div class="panel panel-danger">
                                    <div class="panel-heading">Request Reservation (Destination)</div>
                                      <div class="panel-body">
                                          <asp:GridView ID="gvDestinationReqReservation" runat="server" AutoGenerateColumns="False" DataKeyNames="IdReservationRequest" Width="100%" SkinID="GridBS" OnSelectedIndexChanged="gvDestinationReqReservation_SelectedIndexChanged" OnRowDeleted="gvDestinationReqReservation_OnRowDeleted"  EmptyDataText="No data available in table" >
                                            <Columns>
                                                <asp:TemplateField ShowHeader="False">
                                                    <ItemTemplate>
                                                        <asp:ImageButton ID="imbSelectDestinationReqReservation" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/images/icon/seta.png" Text="Select" />
                                                    </ItemTemplate>
                                                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Destination">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtNamePD" runat="server" Text='<%# Bind("NamePD") %>'></asp:TextBox>
                                                        <asp:HiddenField ID="hdfIdReservationRequest" runat="server" value='<%# Eval("IdReservationRequest") %>'/>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblNamePD" runat="server" Text='<%# Bind("NamePD") %>'></asp:Label>
                                                        <asp:HiddenField ID="hdfIdReservationRequest" runat="server" value='<%# Eval("IdReservationRequest") %>'/>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="Address">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtAddressPD" runat="server" Text='<%# Bind("AddressPD") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblAddressPD" runat="server" Text='<%# Bind("AddressPD") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Postal Code">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtPostalCodePD" runat="server" Text='<%# Bind("PostalCodePD") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblPostalCodePD" runat="server" Text='<%# Bind("PostalCodePD") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField HeaderText="Phone">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtPhonePD" runat="server" Text='<%# Bind("PhonePD") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblPhonePD" runat="server" Text='<%# Bind("PhonePD") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="City">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtCity" runat="server" Text='<%# Bind("City") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblCity" runat="server" Text='<%# Bind("City") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="TypeDestination">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="txtTypeDestination" runat="server" Text='<%# Bind("DescTypeDestination") %>'></asp:TextBox>
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblTypeDestination" runat="server" Text='<%# Bind("DescTypeDestination") %>'></asp:Label>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                 <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                     <asp:LinkButton ID="btnDeleteDestinationReqReservation" runat="server" CausesValidation="False" CommandName="Delete" title="Delete Duplicate Destination">
                                                        <img src="../images/icon/excluir.png" />
                                                    </asp:LinkButton>
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                            </asp:TemplateField>
                                            </Columns>    
                                        </asp:GridView>
                                      </div>
                                    </div>
                                    
                                </div>
                                </div>
                                
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <%--ModalTypeDestination--%>
    <div class="modal fade" id="ModalTypeDestination" role="dialog" aria-labelledby="myModalTypeDestination" aria-hidden="true">
        <div class="modal-dialog">
            <asp:UpdatePanel ID="upModalTypeDestination" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header bg-danger text-white">
                            <h4 class="modal-title"><asp:Label ID="Label2" runat="server" ForeColor="White" Text="Insert Type Destination"></asp:Label></h4>
                            <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        </div>
                        <div class="modal-body">
                            <div>
                                <div class="col-12 col-md-12">
                                    <div class="form-group">
                                        <asp:HiddenField ID="hdfIdModalTypeDestination" runat="server" />
                                        <asp:TextBox ID="txtModalTypeDestination" runat="server" placeholder="Type Destination"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtModalTypeDestination" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="SaveTypeDestination"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col-12 col-md-12 text-right">
                                    <div class="form-group">
                                        <asp:LinkButton ID="btnSearchModelTypeDestination" ValidationGroup="SaveTypeDestination" runat="server" value="SaveViewDestination" class="btn btn-primary" title="Search Type Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Searching">
                                            <img src="../images/icon/search.png" />&nbsp;&nbsp;Search
                                        </asp:LinkButton>
                                   
                                        <asp:LinkButton ID="btnSaveModelTypeDestination" ValidationGroup="SaveTypeDestination" runat="server" OnClick="btnSaveModelTypeDestination_Click" value="SaveViewDestination" class="btn btn-success" title="Insert Type Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Inserting">
                                            <img src="../images/icon/select.png" />&nbsp;&nbsp;Insert
                                        </asp:LinkButton>
                                    
                                        <asp:LinkButton ID="btnCancelTypeModalDestination" runat="server" OnClick="btnCancelTypeModalDestination_Click" value="CancelViewDestination" class="btn btn-warning" title="Clear Type Destination" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Canceling">
                                            <img src="../images/icon/cancel.png" />&nbsp;&nbsp;Reset
                                        </asp:LinkButton>
                                    </div>
                                </div>
                                
                                <div id="divGridModalTypeDestination" runat="server">
                                    <asp:GridView ID="gvTypeDestination1" runat="server" AutoGenerateColumns="False" Width="100%" SkinID="GridBS" OnSelectedIndexChanged="gvTypeDestination1_SelectedIndexChanged1" EmptyDataText="No data available in table">
                                            <Columns>
                                                <asp:TemplateField ShowHeader="False">
                                                    <ItemTemplate>
                                                        <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Select" title="Select" data-loading-text="<i class='fa fa-spinner fa-spin'></i>   Clearing">
                                                        <img src="../images/icon/seta.png" />
                                                        </asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                                <asp:TemplateField HeaderText="DescTypeDestination" SortExpression="DescTypeDestination">
                                                    <EditItemTemplate>
                                                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("DescTypeDestination") %>'></asp:TextBox>
                                                         <asp:HiddenField ID="hdfIdTypeDestination" runat="server" Value='<%# Eval("IdTypeDestination") %>' />
                                                    </EditItemTemplate>
                                                    <ItemTemplate>
                                                        <asp:Label ID="lblDescTypeDestination" runat="server" Text='<%# Bind("DescTypeDestination") %>'></asp:Label>
                                                         <asp:HiddenField ID="hdfIdTypeDestination" runat="server" Value='<%# Eval("IdTypeDestination") %>' />
                                                    </ItemTemplate>
                                                </asp:TemplateField>
                                            </Columns>
                                        </asp:GridView>
                                </div>
                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <%--ModalPassenger--%>
    <div class="modal fade" id="ModalPassenger" role="dialog" aria-labelledby="myModalPassenger" aria-hidden="true">
        <div class="modal-dialog modal-lg">
            <asp:UpdatePanel ID="UpModalPassenger" ChildrenAsTriggers="false" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div class="modal-content">
                        <div class="modal-header bg-danger text-white">
                            <h4 class="modal-title">
                                <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Insert Passenger"></asp:Label></h4>
                             <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                        </div>
                        <div class="modal-body">
                            <div>

                                <%--Linha1  --%>
                                <div class="row">
                                    <div class="col-12 col-md-9">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                <span class="input-group-text"><i class=" fas fa-user"></i></span>
                                            </div>
                                            <asp:TextBox ID="txtNamePassengerModal" runat="server" ControlToValidate="txtNamePassengerModal" placeholder="Name Passenger"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtNamePassengerModal" ErrorMessage="The field Name Passenger is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="SavePassenger1"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="col-12 col-md-3">
                                    <div class="form-group">
                                        <div class="input-group">
                                             <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-phone"></i></span>
                                            </div>
                                            <asp:TextBox ID="txtPhonePassengerModal" runat="server" ControlToValidate="txtPhonePassengerModal" placeholder="Phone"></asp:TextBox>
                                        </div>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPhonePassengerModal" ErrorMessage="Field is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="SavePassenger1"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                </div>
                                
                                

                                <%-- Linha 2 --%>
                                <div class="row">
                                    <div class="col-12 col-md-9">
                                    <div class="form-group">
                                        <div class="input-group">
                                            <div class="input-group-prepend">
                                                        <span class="input-group-text"><i class=" fas fa-envelope"></i></span>
                                                    </div>
                                            <asp:TextBox ID="txtEmailPassengerModal" runat="server" ControlToValidate="txtEmailPassengerModal" placeholder="Email"></asp:TextBox>
                                        </div>
                                        
                                         <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtEmailPassengerModal" ErrorMessage="The field Email is empty!" Display="Dynamic" CssClass="help-block" Font-Size="Small" ValidationGroup="SavePassenger1">
                                        </asp:RequiredFieldValidator>

                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
                                        ControlToValidate="txtEmailPassengerModal" ErrorMessage="Please enter corect email"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="SavePassenger1">
                                        </asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="col-12 col-md-3">
                                    <div class="input-group">
                                        <div class="input-group-prepend">
                                                <span class="input-group-text"><i class="fas fa-phone"></i></span>
                                            </div>
                                        <asp:TextBox ID="txtPhone2PassengerModal" runat="server" placeholder="Phone 2"></asp:TextBox>
                                    </div>
                                </div>
                                </div>
                                
                                
                                <div class="clearfix"></div>
                                <%-- Linha 3 --%>
                                <div class="row">
                                    <div class="col-12 col-md-3">
                                    <div class="form-group">
                                        <asp:DropDownList ID="ddlTypeVisa" runat="server"></asp:DropDownList>
                                    </div>
                                </div>
                                <div class="col-12 col-md-3">
                                    <div class="form-group">
                                        <asp:LinkButton ID="btnSearchPassenger" Width="100%" runat="server" OnClick="btnSearchPassenger_Click" value="SearchPassengerModal" class="ladda-button btn btn-primary" title="Search Passenger By Name" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Searching">
                                            <img src="../images/icon/search.png" />&nbsp;&nbsp;Search
                                        </asp:LinkButton>
                                    </div>
                                </div>
                                <div class="col-12 col-md-3">
                                    <div class="form-group">
                                        <asp:LinkButton ID="btnSavePassenger" Width="100%" runat="server" ValidationGroup="SavePassenger1" OnClick="btnSavePassenger_Click" value="SavePassengerModal" class="ladda-button btn btn-success" title="Insert New Passenger" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Insertinging">
                                    <img src="../images/icon/select.png" />&nbsp;&nbsp;Insert
                                        </asp:LinkButton>
                                    </div>
                                </div>
                                <div class="col-12 col-md-3">
                                     <div class="form-group">
                                        <asp:LinkButton ID="btnCancelPassenger" Width="100%" runat="server" OnClick="btnCancelPassenger_Click" value="CancelPassengerModal" class="ladda-button btn btn-warning" title="Clear Passenger Information" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Reseting">
                                    <img src="../images/icon/cancel.png" />&nbsp;&nbsp;Reset
                                        </asp:LinkButton>
                                    </div>
                                </div>
                                </div>

                                <div id="divGridModalPassenger" runat="server">
                                    <asp:GridView ID="gvPassenger" runat="server" AutoGenerateColumns="False" DataKeyNames="IdPassenger" OnSelectedIndexChanged="gvPassenger_SelectedIndexChanged" Width="100%" SkinID="GridBS" EmptyDataText="No data available in table" >
                                        <Columns>
                                            <asp:TemplateField ShowHeader="False">
                                                <ItemTemplate>
                                                    <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" CommandName="Select" ImageUrl="~/images/icon/seta.png" Text="Select" ToolTip="Select the Passenger to enter in the Transfer Estimate" />
                                                </ItemTemplate>
                                                <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="2%" />
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Name">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="txtName" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
                                                    <asp:HiddenField ID="hdfIdPassenger" runat="server" Value='<%# Eval("IdPassenger") %>' />
                                                    <asp:HiddenField ID="hdfIdTypeVisa" runat="server" Value='<%# Eval("IdTypeVisa") %>' />
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblName" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
                                                    <asp:HiddenField ID="hdfIdPassenger" runat="server" Value='<%# Eval("IdPassenger") %>' />
                                                    <asp:HiddenField ID="hdfIdTypeVisa" runat="server" Value='<%# Eval("IdTypeVisa") %>' />
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Phone">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("Phone") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblPhone" runat="server" Text='<%# Bind("Phone") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Phone2">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Phone2") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblPhone2" runat="server" Text='<%# Bind("Phone2") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Email">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("Email") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblEmail" runat="server" Text='<%# Bind("Email") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Visa">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("DescTypeVisa") %>'></asp:TextBox>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="lblTypeVisa" runat="server" Text='<%# Bind("DescTypeVisa") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                </div>

                            </div>
                        </div>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>

    <div class="messagealert" id="alert_container"></div>

    <%-- Bootstrap 4 --%>
    <%--<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>--%>

    <!--JQuery-->
    <%--<script src="../Scripts/jquery-3.3.1.min.js"></script>

    <script src="../Scripts/jquery-ui-1.12.1.min.js"></script>

    <script type="text/javascript" src="http://cdn.rawgit.com/bassjobsen/Bootstrap-3-Typeahead/master/bootstrap3-typeahead.min.js"></script>
    <link rel="Stylesheet" href="https://twitter.github.io/typeahead.js/css/examples.css" />--%>

    <!-- Bootstrap -->
   <%-- <script src="../Scripts/bootstrap.min.js"></script>--%>

    

    <%--SweetAlert--%>
    <%--<script src="../Scripts/sweetalert/sweetalert.js"></script>
    <script src="../Scripts/sweetalert/sweetalert.min.js"></script>--%>

    <%-- Moment --%>
    <%--<script src="../Scripts/moment.min.js"></script>--%>

    <!-- DataPicker Bootstrap-->
    <%--<script src="../Scripts/bootstrap-datepicker.min.js"></script>--%>

    <!-- DataTimePicker Bootstrap-->
    <%--<script src="../Scripts/bootstrap-datetimepicker.min.js"></script>--%>

    <!-- TimePicker Bootstrap-->
    <%--<script src="../Content/metis/lib/timepicker/js/bootstrap-timepicker.js"></script>
    <script src="../Content/metis/lib/timepicker/js/bootstrap-timepicker.min.js"></script>--%>

    <!-- MetisMenu -->
   <%-- <script src="../Content/metis/lib/metismenu/metisMenu.js"></script>
    <script src="../Content/metis/lib/screenfull/screenfull.js"></script>
    <script src="../Content/metis/js/core.js"></script>
    <script src="../Content/metis/js/app.js"></script>--%>

    <!-- My Library -->
    <script src="../Scripts/Library.js"></script>

    <!--No change this items, data and hours -->
    <script src="../Ubold/assets/libs/bootstrap-datepicker/bootstrap-datepicker.min.js"></script>

    <!-- Plugins js-->
    <script src="../Ubold/assets/libs/flatpickr/flatpickr.min.js"></script>
    <script src="../Ubold/assets/libs/bootstrap-colorpicker/bootstrap-colorpicker.min.js"></script>
    <script src="../Ubold/assets/libs/clockpicker/bootstrap-clockpicker.min.js"></script>


    <!-- Init js-->
    <script src="../Ubold/assets/js/pages/form-pickers.init.js"></script>


    <%--@* DatePicker com a data atual *@--%>    <%-- Auto Complete Passenger--%>
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
    </script>--%>    <%-- Delete Item --%>
    <%--@* Calcula valor do transfer *@--%>
    
    <%-- btn Loading --%>
    <%--<script>
        $('.btn').on('click', function () {
            var $this = $(this);
            $this.button('loading');
            setTimeout(function () {
                $this.button('reset');
            }, 8000);
        });
    </script>--%>

    <%--@* Date TimePicker Bootstrap *@--%>
    <%--<script>
        $(function () {
            $('.datetimepicker').datetimepicker();
        });
    </script>--%>

    <%--@* Date TimePicker - Hour only - Bootstrap *@--%>
    <%--<script>
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
    </script>--%>

    <%--<script>
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
    </script>--%>



    <%--@* DatePicker com a data atual *@--%>
    <%--<script>
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
    </script>--%>


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
</asp:Content>
