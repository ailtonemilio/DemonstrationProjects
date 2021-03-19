<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EstimateTransfer.aspx.cs" Inherits="HWebTS.Budget.EstimateTransfer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadMain" runat="server">
    <style type="text/css">
        .messagealert {
            width: 30%;
            position: fixed;
            top:5px;
            right:220px;
            z-index: 100000;
            padding: 0;
            font-size: 15px;
         }
        </style>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <link href="../Content/bootstrap.min.css" rel="stylesheet" />
    <link href="../Content/font-awesome.css" rel="stylesheet" />
    <link href="../Scripts/sweetalert/sweetalert.css" rel="stylesheet" />
    <link href="../Content/bootstrap-datepicker.min.css" rel="stylesheet" />
    <link href="../Content/bootstrap_custom.css" rel="stylesheet" />
    <link href="../App_Themes/Default/Ajax.css" rel="stylesheet" />
    <link href="../Content/bootstrap-formhelpers.css" rel="stylesheet" />
    <link href="../Content/bootstrap-formhelpers.min.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    <div>
    
     <div class="form-group">
         <%--<asp:Button ID="btnAddNew" runat="server" Text="Create New" CssClass="btn btn-danger" OnClick="btnAddNew_Click" />--%>
         <br />
         <asp:LinkButton ID="btnTypeDestination" runat="server" OnClick="btnAddNew_Click" value="NewTransferEstimate" class="btn btn-success" title="Add New Transfer Estimate" data-loading-text="<i class='fa fa-spinner fa-spin '></i>   Opening">New Transfer Estimate
            </asp:LinkButton>
     </div>
    <div>
        <asp:GridView ID="gvBudget" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataKeyNames="IdTransEst" EmptyDataText="NO DATA" CssClass="table table-striped table-hover table-condensed" 
                    OnSelectedIndexChanged="gvBudget_SelectedIndexChanged">
        <Columns>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="btnDelete" runat="server" CommandName="Select" CssClass="btn-search" OnClick="btnDelete_Click" ToolTip="Delete">
                        <span aria-hidden="true" class="fa fa-trash-o text-danger"></span>
                    </asp:LinkButton>
                    &nbsp;
                </ItemTemplate> 
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom" Width="3%"/>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    &nbsp;
                    <asp:LinkButton ID="btnEdit" runat="server" CommandName="Select" CssClass="btn-search" OnClick="btnEdit_Click" ToolTip="Edit Sheet">
                        <span aria-hidden="true" class="fa fa-edit text-primary"></span>
                    </asp:LinkButton>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom" Width="3%"/>
            </asp:TemplateField>

            <asp:TemplateField ShowHeader="False" Visible="false">
                <ItemTemplate>
                    &nbsp;
                    <asp:LinkButton ID="btnSelect" runat="server" CommandName="Select" CssClass="btn-search"  ToolTip="Insert / Edit W x L">
                        <span aria-hidden="true" class="glyphicon glyphicon-pencil text-primary"></span>
                    </asp:LinkButton>
                </ItemTemplate>
                <ItemStyle HorizontalAlign="Center" VerticalAlign="Bottom" Width="3%"/>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Flight Number" SortExpression="FlightNumber">
                <EditItemTemplate>
                    <asp:TextBox ID="txtFlightNumber" runat="server" Text='<%# Bind("FlightNumber") %>'></asp:TextBox>
                    <asp:HiddenField ID="hdfIdTransEst" runat="server" value='<%# Bind("IdTransEst") %>'/>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lblFlightNumber" runat="server" Text='<%# Bind("FlightNumber") %>'></asp:Label>
                    <asp:HiddenField ID="hdfIdTransEst" runat="server" value='<%# Bind("IdTransEst") %>'/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="DateFligh" HeaderText="DateFligh" SortExpression="DateFligh" DataFormatString="{0:d}" />
            <asp:BoundField DataField="TimeFligh" HeaderText="TimeFligh" SortExpression="TimeFligh" />
            <asp:BoundField DataField="TimePiDo" HeaderText="TimePiDo" SortExpression="TimePiDo" />
            <asp:BoundField DataField="QtyPassanger" HeaderText="Passanger" SortExpression="QtyPassenger" />
            <asp:BoundField DataField="QtyMalaGr" HeaderText="MalaGr" SortExpression="QtyMalaGr" />
            <asp:BoundField DataField="QtyMalaPq" HeaderText="MalaPq" SortExpression="QtyMalaPq" />
            <asp:BoundField DataField="CityFromId" HeaderText="From" SortExpression="CityFromId" />
            <asp:BoundField DataField="CityToId" HeaderText="To" SortExpression="CityToId" />
            <asp:BoundField DataField="TransferAmount" HeaderText="Amount" SortExpression="TransferAmount" />
            <asp:BoundField DataField="DateTransEst" HeaderText="DateTransEst" SortExpression="DateTransEst" DataFormatString="{0:d}" />
            <asp:BoundField DataField="DateAprove" HeaderText="DateAprove" SortExpression="DateAprove" DataFormatString="{0:d}" />
            <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination" />
            <asp:BoundField DataField="SalesContact" HeaderText="Sales Contact" SortExpression="SalesContact" />
            <asp:BoundField DataField="TypeTransfer" HeaderText="TypeTransfer" SortExpression="TypeTransfer" />
                    
        </Columns>
    </asp:GridView>
    </div>
    </div>
    
    <div class="messagealert" id="alert_container"></div> 

    <!-- My Library -->
    <script type="text/javascript" src="../Scripts/Library.js"></script>

     <!--JQuery-->
    <script type="text/javascript" src="../Scripts/jquery-3.3.1.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery-3.3.1.js"></script>

    <!-- Bootstrap -->
    <script type="text/javascript" src="../Scripts/bootstrap.min.js"></script>

    <%--Sweet Alert--%>
    <script type="text/javascript" src="../Scripts/sweetalert/sweetalert.js"></script>
    <script src="../Scripts/sweetalert/sweetalert.min.js"></script>

    <%-- Moment --%>
    <script src="../Scripts/moment.min.js"></script>

    <!-- DataPicker Bootstrap-->
    <script src="../Scripts/bootstrap-datepicker.min.js"></script>

    <%-- Bootstrap DateTimePicker --%>
    <script src="../Scripts/bootstrap-datetimepicker.min.js"></script>

    <%-- Bootstrap TimePicker --%>
    <script src="../Content/metis/lib/timepicker/js/bootstrap-timepicker.js"></script>
    <script src="../Content/metis/lib/timepicker/js/bootstrap-timepicker.min.js"></script>

    <%-- Bootstrap Validator --%>
    <script src="../Scripts/validator.min.js"></script>

    <!-- MetisMenu -->
    <script src="../Content/metis/lib/metismenu/metisMenu.js"></script>
    <script src="../Content/metis/lib/screenfull/screenfull.js"></script>
    <script src="../Content/metis/js/core.js"></script>
    <script src="../Content/metis/js/app.js"></script>

    <%--@* Loading in the button *@--%>
    <script>
        $('.btn').on('click', function () {
            var $this = $(this);
            $this.button('loading');
            setTimeout(function () {
                $this.button('reset');
            }, 2000);
        });
    </script>

    <%-- Sweet Alert from delete item --%>
    <script type="text/javascript">
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
</asp:Content>
