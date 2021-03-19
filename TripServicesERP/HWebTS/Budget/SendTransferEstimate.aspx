<%@ Page Title="" Language="C#" MasterPageFile="~/MainV3.Master" AutoEventWireup="true" CodeBehind="SendTransferEstimate.aspx.cs" Inherits="HWebTS.Budget.SendTransferEstimate" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>

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
    <%--<link href="../Content/bootstrap.css" rel="stylesheet" />
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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentMain" runat="server">
    
       <br />

    <div class="card">
        <div class="card-body">
             <div class="row">
                <div class="col-lg-6">
                    <div class="card">
                    <div class="card-header bg-danger py-3 text-white">
                        <div class="card-widgets">
                            <a data-toggle="collapse" href="#cardEmail" role="button" aria-expanded="false" aria-controls="cardCollpase2"><i class="mdi mdi-minus"></i></a>
                        </div>
                        <h5 class="card-title mb-0 text-white">Send Transfer Estimate to Client - Id Transfer # <asp:Label ID="lblIdTransEst" runat="server" Text=""></asp:Label></h5>
                    </div>
                    <div id="cardEmail" class="collapse show">
                        <div class="card-body">
                            <div class="form-group">
                                <div class="input-group">
                                     <div class="input-group">
                                        <div class="input-group-prepend">
                                            <span class="input-group-text" ><img src="../images/icon/email.png" /></span>
                                        </div>
                                        <asp:TextBox ID="txtEmail" runat="server" ControlToValidate="txtEmail" placeholder="Email"></asp:TextBox>
                                    </div>
                                </div>
                                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtEmail" ErrorMessage="Fiel is empty!" Display="None" ValidationGroup="Send">
                                    </asp:RequiredFieldValidator>

                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
                                        ControlToValidate="txtEmail" ErrorMessage="Please enter corect email"
                                        ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Save">
                                    </asp:RegularExpressionValidator>
                        </div>
                      <div class="form-group">
                          <asp:TextBox ID="txtMessage" runat="server" placeholder="Small Message" TextMode="MultiLine"  ToolTip="maximum 500 characters" onkeyup="document.getElementById('countMessage').innerHTML=this.value.length + ' of 500 chars';" MaxLength="500"></asp:TextBox>
                          <span id="countMessage" style="font-weight: bold; font-size: 9pt; font-family: Arial; text-align: right;"></span>  
                     </div>
                      <div class="form-group">
                      <asp:TextBox ID="txtNote" runat="server" placeholder="Note" TextMode="MultiLine"  ToolTip="maximum 500 characters" onkeyup="document.getElementById('countNotes').innerHTML=this.value.length + ' of 500 chars';" MaxLength="500"></asp:TextBox>
                      <span id="countNotes" style="font-weight: bold; font-size: 9pt; font-family: Arial; text-align: right;"></span> 
                      </div>
                      <div class="form-group">
                        <asp:LinkButton ID="btnPDFCreate" OnClick="btnPDFCreate_Click" runat="server" ValidationGroup="Send" CssClass="ladda-button btn btn-blue" title="Send email to Passenger with Transfer attached" >
                            <img src="../images/icon/email.png" /> &nbsp;&nbsp;Send Email
                        </asp:LinkButton>
                      
                      <asp:LinkButton ID="btnReturn" OnClick="btnReturn_Click" runat="server" CssClass="ladda-button btn btn-blue" title="Return to Tranfer Estimate" data-loading-text="<i class='fa fa-spinner fa-spin '></i> Returning, wait for message">
                            <img src="../images/icon/reverse.png" /> &nbsp;&nbsp;Return Estimate
                        </asp:LinkButton>
                        </div> 
                        </div>
                    </div>
                </div> <!-- end card-->
                </div>
                <div class="col-lg-6">
                    <div class="card">
                    <div class="card-header bg-danger py-3 text-white">
                        <div class="card-widgets">
                            <a data-toggle="collapse" href="#cardInfoTransfer" role="button" aria-expanded="false" aria-controls="cardCollpase2"><i class="mdi mdi-minus"></i></a>
                        </div>
                        <h5 class="card-title mb-0 text-white">Info Transfer</h5>
                    </div>
                    <div id="cardInfoTransfer" class="collapse show">
                        <div class="card-body">
                            <div class="row">

                            
                            <div class="form-group col-lg-7">
                          <div class="card">
                            <div class="card-header bg-danger text-white">Passenger Information</div>
                            <div class="card-body">
                                <label>Passenger:</label>
                                <asp:Label ID="lblNamePassenger" runat="server" Text="" ></asp:Label>
                                <br />
                                <label>Email:</label>
                                <asp:Label ID="lblEmailPassenger" runat="server" Text="" ></asp:Label>
                                <br />
                                <label>Phone:</label>
                                <asp:Label ID="lblPhone" runat="server" Text="" ></asp:Label>
                            </div>
                        </div>
                                    
                            <div class="card">
                            <div class="card-header bg-danger text-white">Transfer Information</div>
                            <div class="card-body">
                            <label>Date Transfer:</label>
                                <asp:Label ID="lblDateTransfer" runat="server" Text="" ></asp:Label>
                                <br />
                                <label>Horario Transfer:</label>
                                <asp:Label ID="lblHorarioTrans" runat="server" Text="" ></asp:Label>
                                <br />
                                <label>Local Encontro:</label>
                                <asp:Label ID="lblLocalEncontro" runat="server" Text="" ></asp:Label>
                                <br />
                                <label>Qty Passenger:</label>
                                <asp:Label ID="lblQtyPassenger" runat="server" Text="" ></asp:Label>
                                        
                                    <label>Qty Kids:</label>
                                <asp:Label ID="lblQtyKids" runat="server" Text="" ></asp:Label>
                                <br />
                                <label>Qty Lugagge:</label>
                                <asp:Label ID="lblQtyLugagge" runat="server" Text="" ></asp:Label>
                                <%--<br />--%>
                                <label>Qty Suit Case:</label>
                                <asp:Label ID="lblQtySuitCase" runat="server" Text="" ></asp:Label>
                                <br />
                                <label>From:</label>
                                <asp:Label ID="lblCityFrom" runat="server" Text="" ></asp:Label>
                                <%--<br />--%>
                                <label>To:</label>
                                <asp:Label ID="lblCityTo" runat="server" Text="" ></asp:Label>
                                    <br />
                                <label>Price:</label>
                                <asp:Label ID="lblFinalPrice" runat="server" Text="" ></asp:Label>
                            </div>
                            </div>
                        </div>

                        <div class="form-group col-lg-5">
                          <div class="card">
                            <div class="card-header bg-danger text-white">Voo Information</div>
                                <div class="card-body">
                                    <label>Flight Number:</label>
                                        <asp:Label ID="lblFlightNum" runat="server" Text="" ></asp:Label>
                                        <br />
                                        <label>Flight Date:</label>
                                        <asp:Label ID="lblFlightDate" runat="server" Text="" ></asp:Label>
                                        <br />
                                        <label>Flight Time:</label>
                                        <asp:Label ID="lblFlighTime" runat="server" Text="" ></asp:Label>
                                </div>
                            </div>

                            <div class="card">
                            <div class="card-header bg-danger text-white">Destiny</div>
                                <div class="card-body">
                                    <label>Tipo:</label>
                                    <asp:Label ID="lblTypeDestination" runat="server" Text="" ></asp:Label>
                                    <br />
                                    <label>Nome/Contato:</label>
                                    <asp:Label ID="lblNameContact" runat="server" Text="" ></asp:Label>
                                    <br />
                                    <label>Endereço:</label>
                                    <asp:Label ID="lblAddressContact" runat="server" Text="" ></asp:Label>
                                    <br />
                                    <label>Telefone:</label>
                                    <asp:Label ID="lblPhoneContact" runat="server" Text="" ></asp:Label>
                                    <br />
                                    <label>Celular:</label>
                                    <asp:Label ID="lblMobileContact" runat="server" Text="" ></asp:Label>
                                </div>
                            </div>
                        </div>
                        </div>
                        </div>
                    </div>
                </div> <!-- end card-->
                </div>
                
            </div>
        </div>
    </div>
        <div class="card">
                        <div class="card-header bg-blue text-white">Messages sent</div>
                        <div class="card-body">
                            <div id="divgvSend" runat="server">
                              <asp:GridView ID="gvSend" runat="server" AutoGenerateColumns="False" DataSourceID="sdsSend" Width="100%" EmptyDataText="No send message"  CssClass= "table table-hover table-bordered">
                                  <Columns>
                                      <asp:BoundField DataField="DateSend" HeaderText="Send Date" SortExpression="DateSend" DataFormatString="{0:f}" >
                                      <ItemStyle Width="17%" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="DescAprove" HeaderText="Aprove" SortExpression="DescAprove" >
                                          <HeaderStyle HorizontalAlign="Center" />
                                      <ItemStyle Width="6%" HorizontalAlign="Center" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="NameUser" HeaderText="Sending User" SortExpression="NameUser" >
                                      <ItemStyle Width="9%" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="Note" HeaderText="Note" SortExpression="Note" >
                                      <ItemStyle Width="34%" />
                                      </asp:BoundField>
                                      <asp:BoundField DataField="SmallMessage" HeaderText="Small Message" SortExpression="SmallMessage" >
                                      <ItemStyle Width="34%" />
                                      </asp:BoundField>
                                  </Columns>
                                  <HeaderStyle BackColor="#a3162b" Font-Bold="True" ForeColor="white" />
                              </asp:GridView>
                        </div>
                          <asp:SqlDataSource ID="sdsSend" runat="server" ConnectionString="<%$ ConnectionStrings:atripservicesConnectionString %>" SelectCommand="SELECT TransferSend.DateSend, TransferSend.IdTransEst, TransferSend.Note, TransferSend.SmallMessage,TransferSend.NameUser, TransferAprove.DescAprove FROM TransferSend INNER JOIN TransferAprove ON TransferSend.IdAprove = TransferAprove.IdAprove WHERE (TransferSend.IdTransEst = @IdTransEst)">
                              <SelectParameters>
                                  <asp:ControlParameter ControlID="lblIdTransEst" Name="IdTransEst" PropertyName="Text" />
                              </SelectParameters>
                          </asp:SqlDataSource>
                        </div>
                    </div>

    <div class="messagealert" id="alert_container"></div> 

    <%-- Bootstrap 4 --%>
    <%--<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>--%>

    <!--JQuery-->
    <%--<script src="../Scripts/jquery-3.3.1.min.js"></script>--%>
    

   <%-- <script src="../Scripts/jquery-ui-1.12.1.min.js"></script>

    <script type="text/javascript" src="http://cdn.rawgit.com/bassjobsen/Bootstrap-3-Typeahead/master/bootstrap3-typeahead.min.js"></script>
    <link rel="Stylesheet" href="https://twitter.github.io/typeahead.js/css/examples.css" />--%>

    <!-- Bootstrap -->
    <%--<script src="../Scripts/bootstrap.min.js"></script>--%>

    <!-- My Library -->
    <%--<script src="../Scripts/Library.js"></script>--%>

    <%--SweetAlert--%>
   <%-- <script src="../Scripts/sweetalert/sweetalert.js"></script>
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
    <%--<script src="../Content/metis/lib/metismenu/metisMenu.js"></script>
    <script src="../Content/metis/lib/screenfull/screenfull.js"></script>
    <script src="../Content/metis/js/core.js"></script>
    <script src="../Content/metis/js/app.js"></script>--%>

    <%--@* Loading in the button *@--%>
    <script>
        $('.btn').on('click', function () {
            var $this = $(this);
            $this.button('loading');
            setTimeout(function () {
                $this.button('reset');
            }, 8000);
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
